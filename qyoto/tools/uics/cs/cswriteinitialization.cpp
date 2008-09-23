/****************************************************************************
**
** Copyright (C) 1992-2006 Trolltech ASA. All rights reserved.
**
** This file is part of the tools applications of the Qt Toolkit.
**
** Licensees holding valid Qt Preview licenses may use this file in
** accordance with the Qt Preview License Agreement provided with the
** Software.
**
** See http://www.trolltech.com/pricing.html or email sales@trolltech.com for
** information about Qt Commercial License Agreements.
**
** Contact info@trolltech.com if any conditions of this licensing are
** not clear to you.
**
** This file is provided AS IS with NO WARRANTY OF ANY KIND, INCLUDING THE
** WARRANTY OF DESIGN, MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
**
****************************************************************************/

#include "cswriteinitialization.h"
#include "driver.h"
#include "ui4.h"
#include "utils.h"
#include "uic.h"
#include "databaseinfo.h"
#include "globaldefs.h"

#include <QTextStream>
#include <QtDebug>

#include <limits.h>
namespace {
    // Fixup an enumeration name from class Qt.
    // They are currently stored as "BottomToolBarArea" instead of "Qt::BottomToolBarArea".
    // due to MO issues. This might be fixed in the future.
    void fixQtEnumerationName(QString& name) {
        static const QLatin1String prefix("Qt::");
        if (name.indexOf(prefix) != 0)
            name.prepend(prefix);
    }
    // figure out the toolbar area of a DOM attrib list.
    // By legacy, it is stored as an integer. As of 4.3.0, it is the enumeration value.
    QString toolBarAreaStringFromDOMAttributes(const CS::WriteInitialization::DomPropertyMap &attributes) {
        const DomProperty *pstyle = attributes.value(QLatin1String("toolBarArea"));
        if (!pstyle)
            return QString();

        switch (pstyle->kind()) {
        case DomProperty::Number: {
            QString area = QLatin1String("(Qt.ToolBarArea)(");
            area += QString::number(pstyle->elementNumber());
            area += QLatin1String("), ");
            return area;
        }
        case DomProperty::Enum: {
            QString area = pstyle->elementEnum();
            fixQtEnumerationName(area);
            area += QLatin1String(", ");
            return area;
        }
        default:
            break;
        }
        return QString();
    }

    // Write a statement to create a spacer item.
    void writeSpacerItem(const DomSpacer *node, QTextStream &output) {
        const QHash<QString, DomProperty *> properties = propertyMap(node->elementProperty());
                output << "new QSpacerItem(";

        if (properties.contains(QLatin1String("sizeHint"))) {
            const DomSize *sizeHint = properties.value(QLatin1String("sizeHint"))->elementSize();
            output << sizeHint->elementWidth() << ", " << sizeHint->elementHeight() << ", ";
        }

        // size type
        QString sizeType = properties.contains(QLatin1String("sizeType"))  ?
                           properties.value(QLatin1String("sizeType"))->elementEnum() :
                           QString::fromLatin1("Expanding");

        if (sizeType.startsWith(QLatin1String("QSizePolicy::")))
            sizeType.replace(QLatin1String("::"), QLatin1String(".Policy."));
        else
            sizeType.prepend(QLatin1String("QSizePolicy.Policy."));
        // orientation
        bool isVspacer = false;
        if (properties.contains(QLatin1String("orientation"))) {
            const QString orientation = properties.value(QLatin1String("orientation"))->elementEnum();
            if (orientation == QLatin1String("Qt::Vertical") || orientation == QLatin1String("Vertical"))  isVspacer = true;
        }

        if (isVspacer)
            output << "QSizePolicy.Policy.Minimum, " << sizeType << ')';
        else
            output << sizeType << ", QSizePolicy.Policy.Minimum)";
    }


    // Helper for implementing comparison functions for integers.
    int compareInt(int i1, int i2) {
        if (i1 < i2) return -1;
        if (i1 > i2) return  1;
        return  0;
    }

    // Write object->setFoo(x);
    template <class Value>
        void writeSetter(const QString &indent, const QString &varName,const QString &setter, Value v, QTextStream &str) {
            QString property(setter);
            property.replace("set", "");
            str << indent << varName << "." << property << " = " << v << ";\n";
        }

    void writeSetupUIScriptVariableDeclarations(const QString &indent, QTextStream &str)  {
//        str << indent << "ScriptContext scriptContext;\n";
//        str << indent << "List<QWidget> childWidgets = new List<QWidget>();\n";
    }
}

namespace CS {

FontHandle::FontHandle(const DomFont *domFont) :
      m_domFont(domFont)
{
}

int FontHandle::compare(const FontHandle &rhs) const
{
    const QString family    = m_domFont->hasElementFamily()     ?     m_domFont->elementFamily() : QString();
    const QString rhsFamily = rhs.m_domFont->hasElementFamily() ? rhs.m_domFont->elementFamily() : QString();

    if (const int frc = family.compare(rhsFamily))
        return frc;

    const int pointSize    = m_domFont->hasElementPointSize()     ?     m_domFont->elementPointSize() : -1;
    const int rhsPointSize = rhs.m_domFont->hasElementPointSize() ? rhs.m_domFont->elementPointSize() : -1;

    if (const int crc = compareInt(pointSize, rhsPointSize))
        return crc;

    const int bold    = m_domFont->hasElementBold()     ? (m_domFont->elementBold()     ? 1 : 0) : -1;
    const int rhsBold = rhs.m_domFont->hasElementBold() ? (rhs.m_domFont->elementBold() ? 1 : 0) : -1;
    if (const int crc = compareInt(bold, rhsBold))
        return crc;

    const int italic    = m_domFont->hasElementItalic()     ? (m_domFont->elementItalic()     ? 1 : 0) : -1;
    const int rhsItalic = rhs.m_domFont->hasElementItalic() ? (rhs.m_domFont->elementItalic() ? 1 : 0) : -1;
    if (const int crc = compareInt(italic, rhsItalic))
        return crc;

    const int underline    = m_domFont->hasElementUnderline()     ? (m_domFont->elementUnderline()     ? 1 : 0) : -1;
    const int rhsUnderline = rhs.m_domFont->hasElementUnderline() ? (rhs.m_domFont->elementUnderline() ? 1 : 0) : -1;
    if (const int crc = compareInt(underline, rhsUnderline))
        return crc;

    const int weight    = m_domFont->hasElementWeight()     ?     m_domFont->elementWeight() : -1;
    const int rhsWeight = rhs.m_domFont->hasElementWeight() ? rhs.m_domFont->elementWeight() : -1;
    if (const int crc = compareInt(weight, rhsWeight))
        return crc;

    const int strikeOut    = m_domFont->hasElementStrikeOut()     ? (m_domFont->elementStrikeOut()     ? 1 : 0) : -1;
    const int rhsStrikeOut = rhs.m_domFont->hasElementStrikeOut() ? (rhs.m_domFont->elementStrikeOut() ? 1 : 0) : -1;
    if (const int crc = compareInt(strikeOut, rhsStrikeOut))
        return crc;

    const int kerning    = m_domFont->hasElementKerning()     ? (m_domFont->elementKerning()     ? 1 : 0) : -1;
    const int rhsKerning = rhs.m_domFont->hasElementKerning() ? (rhs.m_domFont->elementKerning() ? 1 : 0) : -1;
    if (const int crc = compareInt(kerning, rhsKerning))
        return crc;

    const int antialiasing    = m_domFont->hasElementAntialiasing()     ? (m_domFont->elementAntialiasing()     ? 1 : 0) : -1;
    const int rhsAntialiasing = rhs.m_domFont->hasElementAntialiasing() ? (rhs.m_domFont->elementAntialiasing() ? 1 : 0) : -1;
    if (const int crc = compareInt(antialiasing, rhsAntialiasing))
        return crc;

    const QString styleStrategy    = m_domFont->hasElementStyleStrategy()     ?     m_domFont->elementStyleStrategy() : QString();
    const QString rhsStyleStrategy = rhs.m_domFont->hasElementStyleStrategy() ? rhs.m_domFont->elementStyleStrategy() : QString();

    if (const int src = styleStrategy.compare(rhsStyleStrategy))
        return src;

    return 0;
}


#if defined(Q_OS_MAC) && defined(Q_CC_GNU) && (__GNUC__ == 3 && __GNUC_MINOR__ == 3)
inline uint qHash(const SizePolicyHandle &handle) { return qHash(handle.m_domSizePolicy); }
inline uint qHash(const FontHandle &handle) { return qHash(handle.m_domFont); }
#endif

SizePolicyHandle::SizePolicyHandle(const DomSizePolicy *domSizePolicy) :
    m_domSizePolicy(domSizePolicy)
{
}

int SizePolicyHandle::compare(const SizePolicyHandle &rhs) const
{

    const int hSizeType    = m_domSizePolicy->hasElementHSizeType()     ? m_domSizePolicy->elementHSizeType()     : -1;
    const int rhsHSizeType = rhs.m_domSizePolicy->hasElementHSizeType() ? rhs.m_domSizePolicy->elementHSizeType() : -1;
    if (const int crc = compareInt(hSizeType, rhsHSizeType))
        return crc;

    const int vSizeType    = m_domSizePolicy->hasElementVSizeType()     ? m_domSizePolicy->elementVSizeType()     : -1;
    const int rhsVSizeType = rhs.m_domSizePolicy->hasElementVSizeType() ? rhs.m_domSizePolicy->elementVSizeType() : -1;
    if (const int crc = compareInt(vSizeType, rhsVSizeType))
        return crc;

    const int hStretch    =  m_domSizePolicy->hasElementHorStretch()     ? m_domSizePolicy->elementHorStretch()     : -1;
    const int rhsHStretch =  rhs.m_domSizePolicy->hasElementHorStretch() ? rhs.m_domSizePolicy->elementHorStretch() : -1;
    if (const int crc = compareInt(hStretch, rhsHStretch))
        return crc;

    const int vStretch    =  m_domSizePolicy->hasElementVerStretch()     ? m_domSizePolicy->elementVerStretch()     : -1;
    const int rhsVStretch =  rhs.m_domSizePolicy->hasElementVerStretch() ? rhs.m_domSizePolicy->elementVerStretch() : -1;
    if (const int crc = compareInt(vStretch, rhsVStretch))
        return crc;

    const QString attributeHSizeType    = m_domSizePolicy->hasAttributeHSizeType()     ? m_domSizePolicy->attributeHSizeType()     : QString();
    const QString rhsAttributeHSizeType = rhs.m_domSizePolicy->hasAttributeHSizeType() ? rhs.m_domSizePolicy->attributeHSizeType() : QString();

    if (const int hrc = attributeHSizeType.compare(rhsAttributeHSizeType))
        return hrc;

    const QString attributeVSizeType    = m_domSizePolicy->hasAttributeVSizeType()     ? m_domSizePolicy->attributeVSizeType()     : QString();
    const QString rhsAttributeVSizeType = rhs.m_domSizePolicy->hasAttributeVSizeType() ? rhs.m_domSizePolicy->attributeVSizeType() : QString();

    return attributeVSizeType.compare(rhsAttributeVSizeType);
}

// ---  WriteInitialization: LayoutDefaultHandler

WriteInitialization::LayoutDefaultHandler::LayoutDefaultHandler()
{
    qFill(m_state, m_state + NumProperties, 0u);
    qFill(m_defaultValues, m_defaultValues + NumProperties, 0);
}



void WriteInitialization::LayoutDefaultHandler::acceptLayoutDefault(DomLayoutDefault *node)
{
    if (!node)
        return;
    if (node->hasAttributeMargin()) {
        m_state[Margin] |= HasDefaultValue;
        m_defaultValues[Margin] = node->attributeMargin();
    }
    if (node->hasAttributeSpacing()) {
        m_state[Spacing] |= HasDefaultValue;
        m_defaultValues[Spacing]  = node->attributeSpacing();
    }
}

void WriteInitialization::LayoutDefaultHandler::acceptLayoutFunction(DomLayoutFunction *node)
{
    if (!node)
        return;
    if (node->hasAttributeMargin()) {
        m_state[Margin]     |= HasDefaultFunction;
        m_functions[Margin] =  node->attributeMargin();
        m_functions[Margin] += QLatin1String("()");
    }
    if (node->hasAttributeSpacing()) {
        m_state[Spacing]     |= HasDefaultFunction;
        m_functions[Spacing] =  node->attributeSpacing();
        m_functions[Spacing] += QLatin1String("()");
    }
}

void WriteInitialization::LayoutDefaultHandler::writeProperty(int p, const QString &indent, const QString &objectName,
                                                              const DomPropertyMap &properties, const QString &propertyName, const QString &setter,
                                                              int defaultStyleValue, bool suppressDefault, QTextStream &str) const
{
    // User value
    const DomPropertyMap::const_iterator mit = properties.constFind(propertyName);
    const bool found = mit != properties.constEnd();
    if (found) {
        const int value = mit.value()->elementNumber();
        // Emulate the pre 4.3 behaviour: The value form default value was only used to determine
        // the default value, layout properties were always written
        const bool useLayoutFunctionPre43 = !suppressDefault && (m_state[p] == (HasDefaultFunction|HasDefaultValue)) && value == m_defaultValues[p];
        if (!useLayoutFunctionPre43) {
            bool ifndefMac = (!(m_state[p] & (HasDefaultFunction|HasDefaultValue)) 
                             && value == defaultStyleValue);
            if (ifndefMac)
                str << "";
            writeSetter(indent, objectName, setter, value, str);
            if (ifndefMac)
                str << "";
            return;
        }
    }
    if (suppressDefault)
        return;
    // get default
    if (m_state[p] & HasDefaultFunction) {
        writeSetter(indent, objectName, setter, m_functions[p], str);
        return;
    }
    if (m_state[p] & HasDefaultValue) {
        writeSetter(indent, objectName, setter, m_defaultValues[p], str);
    }
    return;
}


void WriteInitialization::LayoutDefaultHandler::writeProperties(const QString &indent, const QString &varName,
                                                                const DomPropertyMap &properties, int marginType,
                                                                bool suppressMarginDefault,
                                                                QTextStream &str) const {
    // Write out properties and ignore the ones found in
    // subsequent writing of the property list.
    int defaultSpacing = marginType == WriteInitialization::Use43UiFile ? -1 : 6;
    writeProperty(Spacing, indent, varName, properties, QLatin1String("spacing"), QLatin1String("setSpacing"),
                  defaultSpacing, false, str);
    // We use 9 as TopLevelMargin, since Designer seem to always use 9.
    static const int layoutmargins[4] = {-1, 9, 9, 0};
    writeProperty(Margin,  indent, varName, properties, QLatin1String("margin"),  QLatin1String("setMargin"),
                  layoutmargins[marginType], suppressMarginDefault, str);
}

WriteInitialization::WriteInitialization(Uic *uic) :
      m_uic(uic),
      m_driver(uic->driver()), m_output(uic->output()), m_option(uic->option()),
      m_layoutMarginType(TopLevelMargin),
      m_delayedOut(&m_delayedInitialization, QIODevice::WriteOnly),
      m_refreshOut(&m_refreshInitialization, QIODevice::WriteOnly),
      m_actionOut(&m_delayedActionInitialization, QIODevice::WriteOnly),
      m_layoutWidget(false)
{
}

void WriteInitialization::acceptUI(DomUI *node)
{
    m_registeredImages.clear();
    m_actionGroupChain.push(0);
    m_widgetChain.push(0);
    m_layoutChain.push(0);

    acceptLayoutDefault(node->elementLayoutDefault());
    acceptLayoutFunction(node->elementLayoutFunction());

    if (node->elementCustomWidgets())
        TreeWalker::acceptCustomWidgets(node->elementCustomWidgets());

    if (node->elementImages())
        TreeWalker::acceptImages(node->elementImages());

    /*if (option.generateImplemetation)
        m_output << "#include <" << m_driver->headerFileName() << ">\n\n";*/

    m_stdsetdef = true;
    if (node->hasAttributeStdSetDef())
        m_stdsetdef = node->attributeStdSetDef();

    QString className = node->elementClass() + m_option.postfix;
    m_generatedClass = className;

    QString varName = m_driver->findOrInsertWidget(node->elementWidget());
    m_registeredWidgets.insert(varName, node->elementWidget()); // register the main widget

    QString widgetClassName = node->elementWidget()->attributeClass();

    m_output << m_option.indent << "public void " << "SetupUi(" << widgetClassName << " " << varName << ")\n"
           << m_option.indent << "{\n";

    QStringList connections = m_uic->databaseInfo()->connections();
    for (int i=0; i<connections.size(); ++i) {
        QString connection = connections.at(i);

        if (connection == QLatin1String("(default)"))
            continue;

        QString varConn = connection + QLatin1String("Connection");
        m_output << m_option.indent << varConn << " = QSqlDatabase.Database(" << fixString(connection, m_option.indent) << ");\n";
    }

    acceptWidget(node->elementWidget());

    for (int i=0; i<m_buddies.size(); ++i) {
        const Buddy &b = m_buddies.at(i);

        if (!m_registeredWidgets.contains(b.objName)) {
            fprintf(stderr, "'%s' isn't a valid widget\n", b.objName.toLatin1().data());
            continue;
        } else if (!m_registeredWidgets.contains(b.buddy)) {
            fprintf(stderr, "'%s' isn't a valid widget\n", b.buddy.toLatin1().data());
            continue;
        }

        m_output << m_option.indent << b.objName << ".SetBuddy(" << b.buddy << ");\n";
    }

    if (node->elementTabStops())
        acceptTabStops(node->elementTabStops());

    if (m_delayedActionInitialization.size())
        m_output << "\n" << m_delayedActionInitialization;

    m_output << "\n" << m_option.indent << "RetranslateUi(" << varName << ");\n";

    if (node->elementConnections())
        acceptConnections(node->elementConnections());

    if (!m_delayedInitialization.isEmpty())
        m_output << "\n" << m_delayedInitialization << "\n";

    if (m_option.autoConnection)
        m_output << "\n" << m_option.indent << "QMetaObject.ConnectSlotsByName(" << varName << ");\n";

    m_output << m_option.indent << "} // SetupUi\n\n";

    /*if (m_delayedActionInitialization.isEmpty()) {
        m_refreshInitialization += m_option.indent + QLatin1String("Q_UNUSED(") + varName + QLatin1String(");\n");
    }*/

    m_output << m_option.indent << "public void " << "RetranslateUi(" << widgetClassName << " " << varName << ")\n"
           << m_option.indent << "{\n"
           << m_refreshInitialization
           << m_option.indent << "} // RetranslateUi\n\n";

    m_layoutChain.pop();
    m_widgetChain.pop();
    m_actionGroupChain.pop();
}

void WriteInitialization::acceptWidget(DomWidget *node)
{
    m_layoutMarginType = m_widgetChain.count() == 1 ? TopLevelMargin : ChildMargin;
    QString className = node->attributeClass();
    QString varName = m_driver->findOrInsertWidget(node);
    m_registeredWidgets.insert(varName, node); // register the current widget

    QString parentWidget, parentClass;
    if (m_widgetChain.top()) {
        parentWidget = m_driver->findOrInsertWidget(m_widgetChain.top());
        parentClass = m_widgetChain.top()->attributeClass();
    }

    QString savedParentWidget = parentWidget;

    if (m_uic->isContainer(parentClass) || m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("Q3ToolBar")))
        parentWidget.clear();

    if (m_widgetChain.size() != 1)
        m_output << m_option.indent << varName << " = new " << m_uic->customWidgetsInfo()->realClassName(className) << "(" << parentWidget << ");\n";

    parentWidget = savedParentWidget;

    if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QComboBox"))) {
        initializeComboBox(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QListWidget"))) {
        initializeListWidget(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QTreeWidget"))) {
        initializeTreeWidget(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QTableWidget"))) {
        initializeTableWidget(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("Q3ListBox"))) {
        initializeQ3ListBox(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("Q3ListView"))) {
        initializeQ3ListView(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("Q3IconView"))) {
        initializeQ3IconView(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("Q3Table"))) {
        initializeQ3Table(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("Q3DataTable"))) {
        initializeQ3SqlDataTable(node);
    } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("Q3DataBrowser"))) {
        initializeQ3SqlDataBrowser(node);
    }

    if (m_uic->isButton(className)) {
        const DomPropertyMap attributes = propertyMap(node->elementAttribute());
        if (const DomProperty *prop = attributes.value(QLatin1String("buttonGroup"))) {
            const QString groupName = toString(prop->elementString());
            if (!m_buttonGroups.contains(groupName)) {
                m_buttonGroups.insert(groupName, m_driver->findOrInsertName(groupName));
                QString g = m_buttonGroups.value(groupName);
                m_output << m_option.indent << "QButtonGroup" << g << " = new QButtonGroup(" << m_generatedClass << ");\n";
            }

            QString g = m_buttonGroups.value(groupName);
            m_output << m_option.indent << g << ".AddButton(" << varName << ");\n";
        }
    }

    writeProperties(varName, className, node->elementProperty());

    if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QMenu")) && parentWidget.size()) {
        initializeMenu(node, parentWidget);
    }

    if (node->elementLayout().isEmpty())
        m_layoutChain.push(0);

    m_layoutWidget = false;
    if (className == QLatin1String("QWidget") && !node->hasAttributeNative()) {
        if (m_widgetChain.top() && m_widgetChain.top()->attributeClass() != "QMainWindow" && !m_uic->isContainer(m_widgetChain.top()->attributeClass()))
            m_layoutWidget = true;
    }
    m_widgetChain.push(node);
    m_layoutChain.push(0);
    TreeWalker::acceptWidget(node);
    m_layoutChain.pop();
    m_widgetChain.pop();
    m_layoutWidget = false;

    const DomPropertyMap attributes = propertyMap(node->elementAttribute());

    QString title = QLatin1String("Page");
    if (const DomProperty *ptitle = attributes.value(QLatin1String("title"))) {
        title = toString(ptitle->elementString());
    }

    QString label = QLatin1String("Page");
    if (const DomProperty *plabel = attributes.value(QLatin1String("label"))) {
        label = toString(plabel->elementString());
    }

    int id = -1;
    if (const DomProperty *pid = attributes.value(QLatin1String("id"))) {
        id = pid->elementNumber();
    }

    if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("QMainWindow"))
            || m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("Q3MainWindow"))) {

        if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QMenuBar"))) {
            if (!m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("Q3MainWindow")))
                m_output << m_option.indent << parentWidget << ".SetMenuBar(" << varName <<");\n";
        } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QToolBar"))) {
            QString area;
            if (const DomProperty *pstyle = attributes.value(QLatin1String("toolBarArea"))) {
                   area += QLatin1String("Qt.ToolBarArea.");
                   area += pstyle->elementEnum();
            }

            m_output << m_option.indent << parentWidget << ".AddToolBar(" << area << ", " << varName << ");\n";

            if (const DomProperty *pbreak = attributes.value(QLatin1String("toolBarBreak"))) {
                if (pbreak->elementBool() == QLatin1String("true")) {
                    m_output << m_option.indent << parentWidget << ".InsertToolBarBreak(" <<  varName << ");\n";
                }
            }

        } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QDockWidget"))) {
            QString area;
            if (const DomProperty *pstyle = attributes.value(QLatin1String("dockWidgetArea"))) {
                area += QLatin1String("(Qt.DockWidgetArea) ");
                area += QString::number(pstyle->elementNumber());
            }

            m_output << m_option.indent << parentWidget << ".AddDockWidget(" << area << ", " << varName << ");\n";
        } else if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QStatusBar"))) {
            m_output << m_option.indent << parentWidget << ".SetStatusBar(" << varName << ");\n";
        } else if (className == QLatin1String("QWidget")) {
            m_output << m_option.indent << parentWidget << ".SetCentralWidget(" << varName << ");\n";
        }
    }

    if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("QStackedWidget"))) {
        m_output << m_option.indent << parentWidget << ".AddWidget(" << varName << ");\n";
    } else if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("QToolBar"))) {
        m_output << m_option.indent << parentWidget << ".AddWidget(" << varName << ");\n";
    } else if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("Q3WidgetStack"))) {
        m_output << m_option.indent << parentWidget << ".AddWidget(" << varName << ", " << id << ");\n";
    } else if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("QDockWidget"))) {
        m_output << m_option.indent << parentWidget << ".SetWidget(" << varName << ");\n";
    } else if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("QSplitter"))) {
        m_output << m_option.indent << parentWidget << ".AddWidget(" << varName << ");\n";
    } else if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("QToolBox"))) {
        QString icon;
        if (const DomProperty *picon = attributes.value(QLatin1String("icon"))) {
            icon += QLatin1String(", ") + pixCall(picon);
        }

        m_output << m_option.indent << parentWidget << ".AddItem(" << varName << icon << ", " << trCall(label) << ");\n";

        m_refreshOut << m_option.indent << parentWidget << ".SetItemText("
                   << parentWidget << ".IndexOf(" << varName << "), " << trCall(label) << ");\n";

        if (const DomProperty *ptoolTip = attributes.value(QLatin1String("toolTip"))) {
            m_refreshOut << m_option.indent << parentWidget << ".SetItemToolTip("
                       << parentWidget << ".IndexOf(" << varName << "), " << trCall(ptoolTip->elementString()) << ");\n";
        }
    } else if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("QTabWidget"))) {
        QString icon;
        if (const DomProperty *picon = attributes.value(QLatin1String("icon"))) {
            icon += QLatin1String(", ") + pixCall(picon);
        }

        m_output << m_option.indent << parentWidget << ".AddTab(" << varName << icon << ", " << trCall(title) << ");\n";

        m_refreshOut << m_option.indent << parentWidget << ".SetTabText("
                   << parentWidget << ".IndexOf(" << varName << "), " << trCall(title) << ");\n";

        if (const DomProperty *ptoolTip = attributes.value(QLatin1String("toolTip"))) {
            m_refreshOut << m_option.indent << parentWidget << ".SetTabToolTip("
                       << parentWidget << ".IndexOf(" << varName << "), " << trCall(ptoolTip->elementString()) << ");\n";
        }
    } else if (m_uic->customWidgetsInfo()->extends(parentClass, QLatin1String("Q3Wizard"))) {
        m_output << m_option.indent << parentWidget << ".AddPage(" << varName << ", " << trCall(title) << ");\n";

        m_refreshOut << m_option.indent << parentWidget << ".SetTitle("
                   << varName << ", " << trCall(title) << ");\n";

    }

    if (node->elementLayout().isEmpty())
        m_layoutChain.pop();
}

void WriteInitialization::acceptLayout(DomLayout *node)
{
    QString className = node->attributeClass();
    QString varName = m_driver->findOrInsertLayout(node);

    const DomPropertyMap properties = propertyMap(node->elementProperty());
    const bool oldLayoutProperties = properties.constFind(QLatin1String("margin")) != properties.constEnd();

    bool isGroupBox = false;

    if (m_widgetChain.top()) {
        QString parentWidget = m_widgetChain.top()->attributeClass();

        if (!m_layoutChain.top() && (m_uic->customWidgetsInfo()->extends(parentWidget, QLatin1String("Q3GroupBox"))
                        || m_uic->customWidgetsInfo()->extends(parentWidget, QLatin1String("Q3ButtonGroup")))) {
            QString parent = m_driver->findOrInsertWidget(m_widgetChain.top());

            isGroupBox = true;

            // special case for group box

            m_output << m_option.indent << parent << ".SetColumnLayout(0, Qt.Orientation.Vertical);\n";
            QString objectName = parent;
            objectName += "Layout()";
            int marginType = Use43UiFile;
            if (oldLayoutProperties)
                marginType = m_layoutMarginType;

            m_LayoutDefaultHandler.writeProperties(m_option.indent, 
                                    objectName, properties, marginType, false, m_output);
        }
    }

    m_output << m_option.indent << varName << " = new " << className << "(";

    if (!m_layoutChain.top() && !isGroupBox)
        m_output << m_driver->findOrInsertWidget(m_widgetChain.top());

    m_output << ");\n";

    if (isGroupBox) {
        const QString tempName = m_driver->unique(QLatin1String("boxlayout"));
        m_output << m_option.indent << "QBoxLayout " << tempName << " = (QBoxLayout)(" <<
                    m_driver->findOrInsertWidget(m_widgetChain.top()) << ".Layout());\n";
        m_output << m_option.indent << "if (" << tempName << ")\n";
        m_output << m_option.indent << "    " << tempName << ".AddLayout(" << varName << ");\n";
    }

    if (isGroupBox) {
        m_output << m_option.indent << varName << ".Alignment = Qt.AlignTop;\n";
    } else {
        // Suppress margin on a read child layout
        const bool suppressMarginDefault = m_layoutChain.top();
        int marginType = Use43UiFile;
        if (oldLayoutProperties)
            marginType = m_layoutMarginType;
        m_LayoutDefaultHandler.writeProperties(m_option.indent, varName, properties, marginType, suppressMarginDefault, m_output);
    }

    m_layoutMarginType = SubLayoutMargin;

    DomPropertyList propList = node->elementProperty();
    if (m_layoutWidget) {
        bool left, top, right, bottom;
        left = top = right = bottom = false;
        for (int i = 0; i < propList.size(); ++i) {
            const DomProperty *p = propList.at(i);
            const QString propertyName = p->attributeName();
            if (propertyName == QLatin1String("leftMargin") && p->kind() == DomProperty::Number)
                left = true;
            else if (propertyName == QLatin1String("topMargin") && p->kind() == DomProperty::Number)
                top = true;
            else if (propertyName == QLatin1String("rightMargin") && p->kind() == DomProperty::Number)
                right = true;
            else if (propertyName == QLatin1String("bottomMargin") && p->kind() == DomProperty::Number)
                bottom = true;
        }
        if (!left) {
            DomProperty *p = new DomProperty();
            p->setAttributeName(QLatin1String("leftMargin"));
            p->setElementNumber(0);
            propList.append(p);
        }
        if (!top) {
            DomProperty *p = new DomProperty();
            p->setAttributeName(QLatin1String("topMargin"));
            p->setElementNumber(0);
            propList.append(p);
        }
        if (!right) {
            DomProperty *p = new DomProperty();
            p->setAttributeName(QLatin1String("rightMargin"));
            p->setElementNumber(0);
            propList.append(p);
        }
        if (!bottom) {
            DomProperty *p = new DomProperty();
            p->setAttributeName(QLatin1String("bottomMargin"));
            p->setElementNumber(0);
            propList.append(p);
        }
        m_layoutWidget = false;
    }

    writeProperties(varName, className, propList, WritePropertyIgnoreMargin|WritePropertyIgnoreSpacing);

    m_layoutChain.push(node);
    TreeWalker::acceptLayout(node);
    m_layoutChain.pop();
}

void WriteInitialization::acceptSpacer(DomSpacer *node)
{
    m_output << m_option.indent << m_driver->findOrInsertSpacer(node) << " = ";
    writeSpacerItem(node, m_output);
    m_output << ";\n";
}

void WriteInitialization::acceptLayoutItem(DomLayoutItem *node)
{
    TreeWalker::acceptLayoutItem(node);

    DomLayout *layout = m_layoutChain.top();

    if (!layout)
        return;

    QString varName = m_driver->findOrInsertLayoutItem(node);
    QString layoutName = m_driver->findOrInsertLayout(layout);

    QString opt;
    if (layout->attributeClass() == QLatin1String("QGridLayout")) {
        const int row = node->attributeRow();
        const int col = node->attributeColumn();

        int rowSpan = 1;
        if (node->hasAttributeRowSpan())
            rowSpan = node->attributeRowSpan();

        int colSpan = 1;
        if (node->hasAttributeColSpan())
            colSpan = node->attributeColSpan();

        opt = QString::fromLatin1(", %1, %2, %3, %4").arg(row).arg(col).arg(rowSpan).arg(colSpan);
    }

    QString method = QLatin1String("AddItem");
    switch (node->kind()) {
        case DomLayoutItem::Widget:
            method = QLatin1String("AddWidget");
            break;
        case DomLayoutItem::Layout:
            method = QLatin1String("AddLayout");
            break;
        case DomLayoutItem::Spacer:
            method = QLatin1String("AddItem");
            break;
        case DomLayoutItem::Unknown:
            Q_ASSERT( 0 );
            break;
    }

    m_output << "\n" << m_option.indent << layoutName << "." << method << "(" << varName << opt << ");\n\n";
}

void WriteInitialization::acceptActionGroup(DomActionGroup *node)
{
    QString actionName = m_driver->findOrInsertActionGroup(node);
    QString varName = m_driver->findOrInsertWidget(m_widgetChain.top());

    if (m_actionGroupChain.top())
        varName = m_driver->findOrInsertActionGroup(m_actionGroupChain.top());

    m_output << m_option.indent << actionName << " = new QActionGroup(" << varName << ");\n";
    writeProperties(actionName, QLatin1String("QActionGroup"), node->elementProperty());

    m_actionGroupChain.push(node);
    TreeWalker::acceptActionGroup(node);
    m_actionGroupChain.pop();
}

void WriteInitialization::acceptAction(DomAction *node)
{
    if (node->hasAttributeMenu())
        return;

    QString actionName = m_driver->findOrInsertAction(node);
    m_registeredActions.insert(actionName, node);
    QString varName = m_driver->findOrInsertWidget(m_widgetChain.top());

    if (m_actionGroupChain.top())
        varName = m_driver->findOrInsertActionGroup(m_actionGroupChain.top());

    m_output << m_option.indent << actionName << " = new QAction(" << varName << ");\n";
    writeProperties(actionName, QLatin1String("QAction"), node->elementProperty());
}

void WriteInitialization::acceptActionRef(DomActionRef *node)
{
    QString actionName = node->attributeName();
    bool isSeparator = actionName == QLatin1String("separator");
    bool isMenu = false;

    QString varName = m_driver->findOrInsertWidget(m_widgetChain.top());

    if (actionName.isEmpty() || !m_widgetChain.top()) {
        return;
    } else if (m_driver->actionGroupByName(actionName)) {
        return;
    } else if (DomWidget *w = m_driver->widgetByName(actionName)) {
        isMenu = m_uic->isMenu(w->attributeClass());
        bool inQ3ToolBar = m_uic->customWidgetsInfo()->extends(m_widgetChain.top()->attributeClass(), QLatin1String("Q3ToolBar"));
        if (!isMenu && inQ3ToolBar) {
            m_actionOut << m_option.indent << actionName << ".SetParent(" << varName << ");\n";
            return;
        }
    } else if (!(m_driver->actionByName(actionName) || isSeparator)) {
        fprintf(stderr, "Warning: action `%s' not declared\n", actionName.toLatin1().data());
        return;
    }

    if (m_widgetChain.top() && isSeparator) {
        // separator is always reserved!
        m_actionOut << m_option.indent << varName << ".AddSeparator();\n";
        return;
    }

    if (isMenu)
        actionName += QLatin1String(".MenuAction()");

    m_actionOut << m_option.indent << varName << ".AddAction(" << actionName << ");\n";
}

void WriteInitialization::writeProperties(const QString &varName,
                                          const QString &className,
                                          const DomPropertyList &lst,
                                          unsigned flags)
{
    const bool isTopLevel = m_widgetChain.count() == 1;

	QStringList lowerCasePropertyNames;
    lowerCasePropertyNames << "acceptMode";
    lowerCasePropertyNames << "buttonSymbols";
    lowerCasePropertyNames << "cacheMode";
    lowerCasePropertyNames << "completionMode";
    lowerCasePropertyNames << "correctionMode";
    lowerCasePropertyNames << "curveShape";
    lowerCasePropertyNames << "direction";
    lowerCasePropertyNames << "dragDropMode";
    lowerCasePropertyNames << "dragMode";
    lowerCasePropertyNames << "echoMode";
    lowerCasePropertyNames << "fileMode";
    lowerCasePropertyNames << "flow";
    lowerCasePropertyNames << "horizontalHeaderFormat";
    lowerCasePropertyNames << "icon";
    lowerCasePropertyNames << "insertPolicy";
    lowerCasePropertyNames << "itemIndexMethod";
    lowerCasePropertyNames << "layoutMode";
    lowerCasePropertyNames << "lineWrapMode";
    lowerCasePropertyNames << "menuRole";
    lowerCasePropertyNames << "mode";
    lowerCasePropertyNames << "modelSorting";
    lowerCasePropertyNames << "movement";
    lowerCasePropertyNames << "notation";
    lowerCasePropertyNames << "resizeMode";
    lowerCasePropertyNames << "segmentStyle";
    lowerCasePropertyNames << "selectionBehavior";
    lowerCasePropertyNames << "selectionMode";
    lowerCasePropertyNames << "shape";
    lowerCasePropertyNames << "sizeAdjustPolicy";
    lowerCasePropertyNames << "sizeConstraint";
    lowerCasePropertyNames << "submitPolicy";
    lowerCasePropertyNames << "tabPosition";
    lowerCasePropertyNames << "tabShape";
    lowerCasePropertyNames << "tickPosition";
    lowerCasePropertyNames << "verticalHeaderFormat";
    lowerCasePropertyNames << "viewMode";
    lowerCasePropertyNames << "viewportUpdateMode";
    lowerCasePropertyNames << "wizardStyle";

    if (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QAxWidget"))) {
        const DomPropertyMap properties = propertyMap(lst);
        if (properties.contains(QLatin1String("control"))) {
            DomProperty *p = properties.value(QLatin1String("control"));
            m_output << m_option.indent << varName << ".Control = "
                   << fixString(toString(p->elementString()), m_option.indent) << ";\n";
        }
    }

    DomWidget *buttonGroupWidget = findWidget(QLatin1String("Q3ButtonGroup"));

    QString indent;
    if (!m_widgetChain.top()) {
        indent = "    ";
        m_output << m_option.indent << "if (" << varName << ".ObjectName == \"\")\n";
    }
    m_output << m_option.indent << indent << varName << ".ObjectName = " << fixString(varName, m_option.indent) << ";\n";

    int leftMargin, topMargin, rightMargin, bottomMargin;
    leftMargin = topMargin = rightMargin = bottomMargin = -1;

    for (int i=0; i<lst.size(); ++i) {
        const DomProperty *p = lst.at(i);
        const QString propertyName = p->attributeName();
        QString propertyValue;

        // special case for the property `geometry'
        if (isTopLevel && propertyName == QLatin1String("geometry") && p->elementRect()) {
            DomRect *r = p->elementRect();
            int w = r->elementWidth();
            int h = r->elementHeight();
			QString tempName = m_driver->unique(QLatin1String("Size"));
			m_output << m_option.indent << "QSize " << tempName << " = new QSize(" << w << ", " << h << ");\n"
                      << m_option.indent << tempName << " = " << tempName << ".ExpandedTo("
                      << varName << ".MinimumSizeHint());\n"
                      << m_option.indent << varName << ".Size = " << tempName << ";\n";                
            continue;
        } else if (propertyName == QLatin1String("buttonGroupId") && buttonGroupWidget) { // Q3ButtonGroup support
            m_output << m_option.indent << m_driver->findOrInsertWidget(buttonGroupWidget) << ".Insert("
                   << varName << ", " << p->elementNumber() << ");\n";
            continue;
        } else if (propertyName == QLatin1String("currentRow") // QListWidget::currentRow
                    && m_uic->customWidgetsInfo()->extends(className, QLatin1String("QListWidget"))) {
            m_delayedOut << m_option.indent << varName << ".CurrentRow = "
                       << p->elementNumber() << ";\n";
            continue;
        } else if (propertyName == QLatin1String("currentIndex") // set currentIndex later
                    && (m_uic->customWidgetsInfo()->extends(className, QLatin1String("QComboBox"))
                    || m_uic->customWidgetsInfo()->extends(className, QLatin1String("QStackedWidget"))
                    || m_uic->customWidgetsInfo()->extends(className, QLatin1String("QTabWidget"))
                    || m_uic->customWidgetsInfo()->extends(className, QLatin1String("QToolBox")))) {
            m_delayedOut << m_option.indent << varName << ".CurrentIndex = "
                       << p->elementNumber() << ";\n";
            continue;
        } else if (propertyName == QLatin1String("control") // ActiveQt support
                    && m_uic->customWidgetsInfo()->extends(className, QLatin1String("QAxWidget"))) {
            // already done ;)
            continue;
        } else if (propertyName == QLatin1String("database")
                    && p->elementStringList()) {
            // Sql support
            continue;
        } else if (propertyName == QLatin1String("frameworkCode")
                    && p->kind() == DomProperty::Bool) {
            // Sql support
            continue;
        } else if (propertyName == QLatin1String("orientation")
                    && m_uic->customWidgetsInfo()->extends(className, QLatin1String("Line"))) {
            // Line support
            QString shape = QLatin1String("QFrame.Shape.HLine");
            if (p->elementEnum() == QLatin1String("Qt::Vertical"))
                shape = QLatin1String("QFrame.Shape.VLine");

            m_output << m_option.indent << varName << ".FrameShape = " << shape << ";\n";
            m_output << m_option.indent << varName << ".FrameShadow = QFrame.Shadow.Sunken;\n";
            continue;
        } else if ((flags & WritePropertyIgnoreMargin)  && propertyName == QLatin1String("margin")) {
            continue;
        } else if ((flags & WritePropertyIgnoreSpacing) && propertyName == QLatin1String("spacing")) {
            continue;
        } else if (propertyName == QLatin1String("leftMargin") && p->kind() == DomProperty::Number) {
            leftMargin = p->elementNumber();
            continue;
        } else if (propertyName == QLatin1String("topMargin") && p->kind() == DomProperty::Number) {
            topMargin = p->elementNumber();
            continue;
        } else if (propertyName == QLatin1String("rightMargin") && p->kind() == DomProperty::Number) {
            rightMargin = p->elementNumber();
            continue;
        } else if (propertyName == QLatin1String("bottomMargin") && p->kind() == DomProperty::Number) {
            bottomMargin = p->elementNumber();
            continue;
        }

        bool stdset = m_stdsetdef;
        if (p->hasAttributeStdset())
            stdset = p->attributeStdset();

        QString setFunction;

        if (lowerCasePropertyNames.contains(propertyName)) {
             setFunction = QLatin1String(".")
                + propertyName
                + QLatin1String(" = ");
        } else {
            setFunction = QLatin1String(".")
                + propertyName.left(1).toUpper()
                + propertyName.mid(1)
                + QLatin1String(" = ");
        }

        switch (p->kind()) {
        case DomProperty::Bool: {
            propertyValue = p->elementBool();
            break;
        }
        case DomProperty::Color: {
            DomColor *c = p->elementColor();
            propertyValue = QString::fromLatin1("new QColor(%1, %2, %3)")
                  .arg(c->elementRed())
                  .arg(c->elementGreen())
                  .arg(c->elementBlue()); }
            break;
        case DomProperty::Cstring:
            if (propertyName == QLatin1String("buddy") && m_uic->customWidgetsInfo()->extends(className, QLatin1String("QLabel"))) {
                m_buddies.append(Buddy(varName, p->elementCstring()));
            } else {
                if (stdset)
                    propertyValue = fixString(p->elementCstring(), m_option.indent);
                else
                    propertyValue = QLatin1String("new QByteArray(") + fixString(p->elementCstring(), m_option.indent) + QLatin1String(")");
            }
            break;
        case DomProperty::Cursor:
            propertyValue = QString::fromLatin1("new QCursor((Qt.CursorShape) (%1))")
                            .arg(p->elementCursor());
            break;
        case DomProperty::CursorShape:
            propertyValue = QString::fromLatin1("new QCursor(Qt.CursorShape.%1)")
                            .arg(p->elementCursorShape());
            break;
        case DomProperty::Enum:
            propertyValue = p->elementEnum();
            if (propertyValue.contains(QLatin1String("::"))) {
                QStringList parts = propertyValue.split("::");
                QString csname = propertyName.left(1).toUpper() + propertyName.mid(1);
                // hack for differing enum names
                if (csname == "FrameShadow") {
                    csname = "Shadow";
                } else if (csname == "FrameShape") {
                    csname = "Shape";
                }
                propertyValue = parts[0] + QLatin1String(".") + csname + QLatin1String(".") + parts[1];
            }
            if (!p->elementEnum().contains(QLatin1String("::")))
                propertyValue.prepend(className + QLatin1String(QLatin1String(".")));
            break;
        case DomProperty::Set:
            // this need special treatment because in C++ the enums aren't specified
            propertyValue = p->elementSet();
            if (propertyValue.contains(QLatin1String("::"))) {
                QStringList enums = propertyValue.split("|");
                QString qyotoValue;
                for (int i = 0; i < enums.size(); ++i) {
                    enums.at(i);
                    QStringList parts = enums.at(i).split("::");
                    if (i > 0) {
                        qyotoValue += QLatin1String(" | ");
                    }
                    qyotoValue += QLatin1String("Qyoto.Qyoto.GetCPPEnumValue(\"") + parts[0] + "\", \"" + parts[1] + QLatin1String("\")");
                }
                propertyValue = qyotoValue;
            }
            break;
        case DomProperty::Font: {
            propertyValue = writeFontProperties(p->elementFont());
            break;
        }
        case DomProperty::IconSet:
            propertyValue = pixCall(p);
            break;

        case DomProperty::Pixmap:
            propertyValue = pixCall(p);
            break;

        case DomProperty::Palette: {
            DomPalette *pal = p->elementPalette();
            QString paletteName = m_driver->unique(QLatin1String("palette"));
            m_output << m_option.indent << "QPalette " << paletteName << " = new QPalette();\n";

            writeColorGroup(pal->elementActive(), QLatin1String("QPalette.ColorGroup.Active"), paletteName);
            writeColorGroup(pal->elementInactive(), QLatin1String("QPalette.ColorGroup.Inactive"), paletteName);
            writeColorGroup(pal->elementDisabled(), QLatin1String("QPalette.ColorGroup.Disabled"), paletteName);

            propertyValue = paletteName;
            break;
        }
        case DomProperty::Point: {
            DomPoint *po = p->elementPoint();
            propertyValue = QString::fromLatin1("new QPoint(%1, %2)")
                            .arg(po->elementX()).arg(po->elementY());
            break;
        }
        case DomProperty::PointF: {
            DomPointF *pof = p->elementPointF();
            propertyValue = QString::fromLatin1("new QPointF(%1, %2)")
                            .arg(pof->elementX()).arg(pof->elementY());
            break;
        }
        case DomProperty::Rect: {
            DomRect *r = p->elementRect();
            propertyValue = QString::fromLatin1("new QRect(%1, %2, %3, %4)")
                            .arg(r->elementX()).arg(r->elementY())
                            .arg(r->elementWidth()).arg(r->elementHeight());
            break;
        }
        case DomProperty::RectF: {
            DomRectF *rf = p->elementRectF();
            propertyValue = QString::fromLatin1("new QRectF(%1, %2, %3, %4)")
                            .arg(rf->elementX()).arg(rf->elementY())
                            .arg(rf->elementWidth()).arg(rf->elementHeight());
            break;
        }
        case DomProperty::Locale: {
             const DomLocale *locale = p->elementLocale();
             propertyValue = QString::fromLatin1("new QLocale(QLocale.Language.%1, QLocale.Country.%2)")
                             .arg(locale->attributeLanguage()).arg(locale->attributeCountry());
            break;
        }
        case DomProperty::SizePolicy: {
            const QString spName = writeSizePolicy( p->elementSizePolicy());
            m_output << m_option.indent << spName << QString::fromLatin1(
                ".SetHeightForWidth(%1.SizePolicy.HasHeightForWidth());\n")
                .arg(varName);

            propertyValue = spName;
            break;
        }
        case DomProperty::Size: {
             DomSize *s = p->elementSize();
              propertyValue = QString::fromLatin1("new QSize(%1, %2)")
                             .arg(s->elementWidth()).arg(s->elementHeight());
            break;
        }
        case DomProperty::SizeF: {
            DomSizeF *sf = p->elementSizeF();
             propertyValue = QString::fromLatin1("new QSizeF(%1, %2)")
                            .arg(sf->elementWidth()).arg(sf->elementHeight());
            break;
        }
        case DomProperty::String: {
            if (propertyName == QLatin1String("objectName")) {
                QString v = p->elementString()->text();
                if (v == varName)
                    break;

                // ### qWarning("Deprecated: the property `objectName' is different from the variable name");
            }

            if (p->elementString()->hasAttributeNotr()
                    && toBool(p->elementString()->attributeNotr())) {
                propertyValue = fixString(p->elementString()->text(), m_option.indent);
            } else {
                propertyValue = trCall(p->elementString());
            }
            break;
        }
        case DomProperty::Number:
            propertyValue = QString::number(p->elementNumber());
            break;
        case DomProperty::UInt:
            propertyValue = QString::number(p->elementUInt());
            propertyValue += QLatin1Char('u');
            break;
        case DomProperty::LongLong:
            propertyValue = QString::number(p->elementLongLong());
            break;
        case DomProperty::ULongLong:
            propertyValue += QString::number(p->elementULongLong());
            break;
        case DomProperty::Float:
            propertyValue = QString::number(p->elementFloat());
            break;
        case DomProperty::Double:
            propertyValue = QString::number(p->elementDouble());
            break;
        case DomProperty::Char: {
            DomChar *c = p->elementChar();
            propertyValue = QString::fromLatin1("new QChar(%1)")
                            .arg(c->elementUnicode());
            break;
        }
        case DomProperty::Date: {
            DomDate *d = p->elementDate();
            propertyValue = QString::fromLatin1("new QDate(%1, %2, %3)")
                            .arg(d->elementYear())
                            .arg(d->elementMonth())
                            .arg(d->elementDay());
            break;
        }
        case DomProperty::Time: {
            DomTime *t = p->elementTime();
            propertyValue = QString::fromLatin1("new QTime(%1, %2, %3)")
                            .arg(t->elementHour())
                            .arg(t->elementMinute())
                            .arg(t->elementSecond());
            break;
        }
        case DomProperty::DateTime: {
            DomDateTime *dt = p->elementDateTime();
            propertyValue = QString::fromLatin1("new QDateTime(QDate(%1, %2, %3), QTime(%4, %5, %6))")
                            .arg(dt->elementYear())
                            .arg(dt->elementMonth())
                            .arg(dt->elementDay())
                            .arg(dt->elementHour())
                            .arg(dt->elementMinute())
                            .arg(dt->elementSecond());
            break;
        }
        case DomProperty::StringList:
            propertyValue = QLatin1String("new string[ ");
            if (p->elementStringList()->elementString().size()) {
                QStringList lst = p->elementStringList()->elementString();
                for (int i=0; i<lst.size(); ++i) {
                    if (i != lst.size() - 1) {
                    	propertyValue += fixString(lst.at(i), m_option.indent) + QLatin1String(", ");
                    }
                    else {
                    	propertyValue += fixString(lst.at(i), m_option.indent) + QLatin1String(" ");
                    }
                }
            }
            propertyValue += QLatin1String("]");
            break;

        case DomProperty::Url: {
            DomUrl* u = p->elementUrl();
            propertyValue = QString::fromLatin1("new QUrl(%1)")
                            .arg(fixString(u->elementString()->text(), m_option.indent));
            break;
        }
        case DomProperty::Unknown:
            break;
        }

        if (propertyValue.size()) {
            QTextStream *o = &m_output;

            if (p->kind() == DomProperty::String
                    && (!p->elementString()->hasAttributeNotr() || !toBool(p->elementString()->attributeNotr())))
                o = &m_refreshOut;

            (*o) << m_option.indent << varName << setFunction << propertyValue;
            if (!stdset)
                (*o) << "";
            (*o) << ";\n";
//            (*o) << ");\n";
        }
    }
    if (leftMargin != -1 || topMargin != -1 || rightMargin != -1 || bottomMargin != -1) {
        QString objectName = varName;
        m_output << m_option.indent << objectName << QLatin1String(".SetContentsMargins(")
                << QString::number(leftMargin) << QLatin1String(", ")
                << QString::number(topMargin) << QLatin1String(", ")
                << QString::number(rightMargin) << QLatin1String(", ")
                << QString::number(bottomMargin) << QLatin1String(");\n");
    }
}

QString  WriteInitialization::writeSizePolicy(const DomSizePolicy *sp)
{

    // check cache
    const SizePolicyHandle sizePolicyHandle(sp);
    const SizePolicyNameMap::const_iterator it = m_SizePolicyNameMap.constFind(sizePolicyHandle);
    if ( it != m_SizePolicyNameMap.constEnd()) {
        return it.value();
    }


    // insert with new name
    const QString spName = m_driver->unique(QLatin1String("sizePolicy"));
    m_SizePolicyNameMap.insert(sizePolicyHandle, spName);

    m_output << m_option.indent << "QSizePolicy " << spName << " = new QSizePolicy";
    do {
        if (sp->hasElementHSizeType() && sp->hasElementVSizeType()) {
            m_output << "((QSizePolicy.Policy)(" << sp->elementHSizeType()
                << "), (QSizePolicy.Policy)(" << sp->elementVSizeType() << "));\n";
            break;
        }
        if (sp->hasAttributeHSizeType() && sp->hasAttributeVSizeType()) {
                m_output << "(QSizePolicy.Policy." << sp->attributeHSizeType() << ", QSizePolicy.Policy."
                << sp->attributeVSizeType() << ");\n";
            break;
        }
        m_output << ";\n";
    } while (false);

    m_output << m_option.indent << spName << ".SetHorizontalStretch("
        << sp->elementHorStretch() << ");\n";
    m_output << m_option.indent << spName << ".SetVerticalStretch("
        << sp->elementVerStretch() << ");\n";
    return spName;
}
// Check for a font with the given properties in the FontPropertiesNameMap
// or create a new one. Returns the name.

QString WriteInitialization::writeFontProperties(const DomFont *f)
{
    // check cache
    const FontHandle fontHandle(f);
    const FontPropertiesNameMap::const_iterator it = m_FontPropertiesNameMap.constFind(fontHandle);
    if ( it != m_FontPropertiesNameMap.constEnd()) {
        return it.value();
    }

    // insert with new name
    const QString fontName = m_driver->unique(QLatin1String("font"));
    m_FontPropertiesNameMap.insert(FontHandle(f), fontName);

    m_output << m_option.indent << "QFont " << fontName << " = new QFont();\n";
    if (f->hasElementFamily() && !f->elementFamily().isEmpty()) {
        m_output << m_option.indent << fontName << ".SetFamily(" << fixString(f->elementFamily(), m_option.indent)
            << ");\n";
    }
    if (f->hasElementPointSize() && f->elementPointSize() > 0) {
         m_output << m_option.indent << fontName << ".SetPointSize(" << f->elementPointSize()
             << ");\n";
    }

    if (f->hasElementBold()) {
        m_output << m_option.indent << fontName << ".SetBold("
            << (f->elementBold() ? "true" : "false") << ");\n";
    }
    if (f->hasElementItalic()) {
        m_output << m_option.indent << fontName << ".SetItalic("
            <<  (f->elementItalic() ? "true" : "false") << ");\n";
    }
    if (f->hasElementUnderline()) {
        m_output << m_option.indent << fontName << ".SetUnderline("
            << (f->elementUnderline() ? "true" : "false") << ");\n";
    }
    if (f->hasElementWeight() && f->elementWeight() > 0) {
        m_output << m_option.indent << fontName << ".SetWeight("
            << f->elementWeight() << ");" << endl;
    }
    if (f->hasElementStrikeOut()) {
         m_output << m_option.indent << fontName << ".SetStrikeOut("
            << (f->elementStrikeOut() ? "true" : "false") << ");\n";
    }
    if (f->hasElementKerning()) {
        m_output << m_option.indent << fontName << ".SetKerning("
            << (f->elementKerning() ? "true" : "false") << ");\n";
    }
    if (f->hasElementAntialiasing()) {
        m_output << m_option.indent << fontName << ".SetStyleStrategy("
            << (f->elementAntialiasing() ? "QFont.StyleStrategy.PreferDefault" : "QFont.StyleStrategy.NoAntialias") << ");\n";
    }
    if (f->hasElementStyleStrategy()) {
         m_output << m_option.indent << fontName << ".SetStyleStrategy(QFont.StyleStrategy."
            << f->elementStyleStrategy() << ");\n";
    }
    return  fontName;
}

QString WriteInitialization::domColor2QString(const DomColor *c)
{
    if (c->hasAttributeAlpha())
        return QString::fromLatin1("new QColor(%1, %2, %3, %4)")
            .arg(c->elementRed())
            .arg(c->elementGreen())
            .arg(c->elementBlue())
            .arg(c->attributeAlpha());
    return QString::fromLatin1("new QColor(%1, %2, %3)")
        .arg(c->elementRed())
        .arg(c->elementGreen())
        .arg(c->elementBlue());
}

void WriteInitialization::writeColorGroup(DomColorGroup *colorGroup, const QString &group, const QString &paletteName)
{
    if (!colorGroup)
        return;

    // old format
    const QList<DomColor*> colors = colorGroup->elementColor();
    for (int i=0; i<colors.size(); ++i) {
        DomColor *color = colors.at(i);

        m_output << m_option.indent << paletteName << ".SetColor(" << group
            << ", " << "(QPalette.ColorRole) (" << QString::number(i) << ")"
            << ", " << domColor2QString(color)
            << ");\n";
    }

    // new format
    const QList<DomColorRole *> colorRoles = colorGroup->elementColorRole();
    QListIterator<DomColorRole *> itRole(colorRoles);
    while (itRole.hasNext()) {
        const DomColorRole *colorRole = itRole.next();
        if (colorRole->hasAttributeRole()) {
            DomBrush *brush = colorRole->elementBrush();
            QString brushName;
            if (!brush->hasAttributeBrushStyle() || brush->attributeBrushStyle() == QLatin1String("SolidPattern")) {
                const DomColor *color = brush->elementColor();
                if (color) {
                    uint c = ((color->elementRed() & 0xFF) << 24) |
                        ((color->elementGreen() & 0xFF) << 16) |
                        ((color->elementBlue() & 0xFF) << 8) |
                        ((color->attributeAlpha() & 0xFF));
                    if (m_colorBrushHash.contains(c)) {
                        brushName = m_colorBrushHash.value(c);
                    } else {
                        brushName = m_driver->unique(QLatin1String("brush"));
                        writeBrush(colorRole->elementBrush(), brushName);
                        m_colorBrushHash[c] = brushName;
                    }
                }
            }
            if (brushName.isEmpty()) {
                brushName = m_driver->unique(QLatin1String("brush"));
                writeBrush(colorRole->elementBrush(), brushName);
            }

            m_output << m_option.indent << paletteName << ".SetBrush(" << group
                << ", " << "QPalette.ColorRole." << colorRole->attributeRole()
                << ", " << brushName << ");\n";
        }
    }
}

void WriteInitialization::writeBrush(DomBrush *brush, const QString &brushName)
{
    QString style = QLatin1String("SolidPattern");
    if (brush->hasAttributeBrushStyle())
        style = brush->attributeBrushStyle();

    if (style == QLatin1String("LinearGradientPattern") ||
            style == QLatin1String("RadialGradientPattern") ||
            style == QLatin1String("ConicalGradientPattern")) {
        DomGradient *gradient = brush->elementGradient();
        QString gradientType = gradient->attributeType();
        QString gradientName = m_driver->unique(QLatin1String("gradient"));
        if (gradientType == QLatin1String("LinearGradient")) {
            m_output << m_option.indent << "QLinearGradient " << gradientName
                << "(" << gradient->attributeStartX()
                << ", " << gradient->attributeStartY()
                << ", " << gradient->attributeEndX()
                << ", " << gradient->attributeEndY() << ");\n";
        } else if (gradientType == QLatin1String("RadialGradient")) {
            m_output << m_option.indent << "QRadialGradient " << gradientName
                << "(" << gradient->attributeCentralX()
                << ", " << gradient->attributeCentralY()
                << ", " << gradient->attributeRadius()
                << ", " << gradient->attributeFocalX()
                << ", " << gradient->attributeFocalY() << ");\n";
        } else if (gradientType == QLatin1String("ConicalGradient")) {
            m_output << m_option.indent << "QConicalGradient " << gradientName
                << "(" << gradient->attributeCentralX()
                << ", " << gradient->attributeCentralY()
                << ", " << gradient->attributeAngle() << ");\n";
        }

        m_output << m_option.indent << gradientName << ".SetSpread(QGradient.Spread."
            << gradient->attributeSpread() << ");\n";

        if (gradient->hasAttributeCoordinateMode()) {
            m_output << m_option.indent << gradientName << ".SetCoordinateMode(QGradient.CoordinateMode."
                << gradient->attributeCoordinateMode() << ");\n";
        }

        const QList<DomGradientStop *> stops = gradient->elementGradientStop();
        QListIterator<DomGradientStop *> it(stops);
        while (it.hasNext()) {
            const DomGradientStop *stop = it.next();
            const DomColor *color = stop->elementColor();
            m_output << m_option.indent << gradientName << ".SetColorAt("
                << stop->attributePosition() << ", "
                << domColor2QString(color) << ");\n";
        }
        m_output << m_option.indent << "new QBrush " << brushName << "("
            << gradientName << ");\n";
    } else if (style == QLatin1String("TexturePattern")) {
        DomProperty *property = brush->elementTexture();

        m_output << m_option.indent << "new QBrush " << brushName << " = QBrush("
            << pixCall(property) << ");\n";
    } else {
        DomColor *color = brush->elementColor();
        m_output << m_option.indent << "new QBrush " << brushName << "("
            << domColor2QString(color) << ");\n";

        m_output << m_option.indent << brushName << ".SetStyle("
            << "Qt.BrushStyle." << style << ");\n";
    }
}

void WriteInitialization::acceptCustomWidget(DomCustomWidget *node)
{
    Q_UNUSED(node);
}

void WriteInitialization::acceptCustomWidgets(DomCustomWidgets *node)
{
    Q_UNUSED(node);
}

void WriteInitialization::acceptTabStops(DomTabStops *tabStops)
{
    QString lastName;

    const QStringList l = tabStops->elementTabStop();
    for (int i=0; i<l.size(); ++i) {
        QString name = l.at(i);

        if (!m_registeredWidgets.contains(name)) {
            fprintf(stderr, "'%s' isn't a valid widget\n", name.toLatin1().data());
            continue;
        }

        if (i == 0) {
            lastName = name;
            continue;
        } else if (name.isEmpty() || lastName.isEmpty()) {
            continue;
        }

        m_output << m_option.indent << "QWidget.SetTabOrder(" << lastName << ", " << name << ");\n";

        lastName = name;
    }
}

void WriteInitialization::initializeTreeWidgetItems(const QString &className, const QString &varName, const QList<DomItem *> &items)
{
    if (items.isEmpty())
        return;

    // items
    for (int i=0; i<items.size(); ++i) {
        DomItem *item = items.at(i);

        QString itemName = m_driver->unique(QLatin1String("__item"));
        m_refreshOut << "\n";
        m_refreshOut << m_option.indent << "QTreeWidgetItem " << itemName << " = new QTreeWidgetItem(" << varName << ");\n";

        int textCount = 0;
        QList<DomProperty*> properties = item->elementProperty();
        for (int i=0; i<properties.size(); ++i) {
            DomProperty *p = properties.at(i);
            if (p->attributeName() == QLatin1String("text"))
                m_refreshOut << m_option.indent << itemName << ".Text = " << textCount++ << ", "
                           << trCall(p->elementString()) << ";\n";

            if (p->attributeName() == QLatin1String("icon") && textCount > 0)
                m_refreshOut << m_option.indent << itemName << ".SetIcon(" << textCount - 1 << ", "
                           << pixCall(p) << ");\n";
        }

        if (item->elementItem().size())
            initializeTreeWidgetItems(className, itemName, item->elementItem());
    }
}

void WriteInitialization::initializeComboBox(DomWidget *w)
{
    const QString varName = m_driver->findOrInsertWidget(w);
    const QString className = w->attributeClass();

    const QList<DomItem*> items = w->elementItem();

    if (items.isEmpty())
        return;

    m_refreshOut << m_option.indent << varName << ".Clear();\n";

    // If possible use qcombobox's addItems() which is much faster then a bunch of addItem() calls
    bool noIcons = true;
    QStringList list;
    for (int i=0; i<items.size(); ++i) {
        const DomItem *item = items.at(i);
        const DomPropertyMap properties = propertyMap(item->elementProperty());
        const DomProperty *text = properties.value(QLatin1String("text"));
        const DomProperty *pixmap = properties.value(QLatin1String("icon"));
        if (pixmap != 0) {
            noIcons = false;
            break;
        }
        list.append(trCall(text->elementString()));
    }

    if (noIcons) {
        for (int i=0; i<list.size(); ++i) {
            m_refreshOut << m_option.indent << varName << ".AddItem(" << list.at(i) << ");\n";
        }
    } else {
        for (int i=0; i<items.size(); ++i) {
            const DomItem *item = items.at(i);
            const DomPropertyMap properties = propertyMap(item->elementProperty());
            const DomProperty *text = properties.value(QLatin1String("text"));
            const DomProperty *pixmap = properties.value(QLatin1String("icon"));
            if (!(text || pixmap))
                continue;

            m_refreshOut << m_option.indent << varName << ".AddItem(";

            if (pixmap != 0) {
                m_refreshOut << pixCall(pixmap);

                if (text)
                    m_refreshOut << ", ";
            }

            m_refreshOut << trCall(text->elementString()) << ");\n";
        }
    }
}

void WriteInitialization::initializeQ3ListBox(DomWidget *w)
{
    QString varName = m_driver->findOrInsertWidget(w);
    QString className = w->attributeClass();

    QList<DomItem*> items = w->elementItem();

    if (items.isEmpty())
        return;

    m_refreshOut << m_option.indent << varName << ".Clear();\n";

    for (int i=0; i<items.size(); ++i) {
        DomItem *item = items.at(i);

        const DomPropertyMap properties = propertyMap(item->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *pixmap = properties.value(QLatin1String("pixmap"));
        if (!(text || pixmap))
            continue;

        m_refreshOut << m_option.indent << varName << ".InsertItem(";
        if (pixmap) {
            m_refreshOut << pixCall(pixmap);

            if (text)
                m_refreshOut << ", ";
        }
        if (text)
            m_refreshOut << trCall(text->elementString());
        m_refreshOut << ");\n";
    }
}

void WriteInitialization::initializeQ3IconView(DomWidget *w)
{
    QString varName = m_driver->findOrInsertWidget(w);
    QString className = w->attributeClass();

    QList<DomItem*> items = w->elementItem();

    if (items.isEmpty())
        return;

    m_refreshOut << m_option.indent << varName << ".Clear();\n";

    for (int i=0; i<items.size(); ++i) {
        DomItem *item = items.at(i);

        const DomPropertyMap properties = propertyMap(item->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *pixmap = properties.value(QLatin1String("pixmap"));
        if (!(text || pixmap))
            continue;

        QString itemName = m_driver->unique(QLatin1String("__item"));
        m_refreshOut << "\n";
        m_refreshOut << m_option.indent << "Q3IconViewItem " << itemName << " = new Q3IconViewItem(" << varName << ");\n";

        if (pixmap) {
            m_refreshOut << m_option.indent << itemName << ".SetPixmap(" << pixCall(pixmap) << ");\n";
        }

        if (text) {
            m_refreshOut << m_option.indent << itemName << ".Text = " << trCall(text->elementString()) << ";\n";
        }
    }
}

void WriteInitialization::initializeQ3ListView(DomWidget *w)
{
    QString varName = m_driver->findOrInsertWidget(w);
    QString className = w->attributeClass();

    // columns
    QList<DomColumn*> columns = w->elementColumn();
    for (int i=0; i<columns.size(); ++i) {
        DomColumn *column = columns.at(i);

        const DomPropertyMap properties = propertyMap(column->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *pixmap = properties.value(QLatin1String("pixmap"));
        DomProperty *clickable = properties.value(QLatin1String("clickable"));
        DomProperty *resizable = properties.value(QLatin1String("resizable"));

        QString txt = trCall(text->elementString());
        m_output << m_option.indent << varName << ".AddColumn(" << txt << ");\n";
        m_refreshOut << m_option.indent << varName << ".Header().SetLabel(" << i << ", " << txt << ");\n";

        if (pixmap) {
            m_output << m_option.indent << varName << ".Header().SetLabel("
                   << varName << ".Header().Count() - 1, " << pixCall(pixmap) << ", " << txt << ");\n";
        }

        if (clickable != 0) {
            m_output << m_option.indent << varName << ".Header().SetClickEnabled(" << clickable->elementBool() << ", " << varName << ".Header().Count() - 1);\n";
        }

        if (resizable != 0) {
            m_output << m_option.indent << varName << ".Header().SetResizeEnabled(" << resizable->elementBool() << ", " << varName << ".Header().Count() - 1);\n";
        }
    }

    if (w->elementItem().size()) {
        m_refreshOut << m_option.indent << varName << ".Clear();\n";

        initializeQ3ListViewItems(className, varName, w->elementItem());
    }
}

void WriteInitialization::initializeQ3ListViewItems(const QString &className, const QString &varName, const QList<DomItem *> &items)
{
    if (items.isEmpty())
        return;

    // items
    for (int i=0; i<items.size(); ++i) {
        DomItem *item = items.at(i);

        QString itemName = m_driver->unique(QLatin1String("__item"));
        m_refreshOut << "\n";
        m_refreshOut << m_option.indent << "Q3ListViewItem " << itemName << " = new Q3ListViewItem(" << varName << ");\n";

        int textCount = 0, pixCount = 0;
        QList<DomProperty*> properties = item->elementProperty();
        for (int i=0; i<properties.size(); ++i) {
            DomProperty *p = properties.at(i);
            if (p->attributeName() == QLatin1String("text"))
                m_refreshOut << m_option.indent << itemName << ".Text = " << textCount++ << ", "
                           << trCall(p->elementString()) << ";\n";

            if (p->attributeName() == QLatin1String("pixmap"))
                m_refreshOut << m_option.indent << itemName << ".SetPixmap(" << pixCount++ << ", "
                           << pixCall(p) << ");\n";
        }

        if (item->elementItem().size()) {
            m_refreshOut << m_option.indent << itemName << ".Open = true;\n";
            initializeQ3ListViewItems(className, itemName, item->elementItem());
        }
    }
}

void WriteInitialization::initializeQ3Table(DomWidget *w)
{
    QString varName = m_driver->findOrInsertWidget(w);
    QString className = w->attributeClass();

    // columns
    QList<DomColumn*> columns = w->elementColumn();

    for (int i=0; i<columns.size(); ++i) {
        DomColumn *column = columns.at(i);

        const DomPropertyMap properties = propertyMap(column->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *pixmap = properties.value(QLatin1String("pixmap"));

        m_refreshOut << m_option.indent << varName << ".HorizontalHeader().SetLabel(" << i << ", ";
        if (pixmap) {
            m_refreshOut << pixCall(pixmap) << ", ";
        }
        m_refreshOut << trCall(text->elementString()) << ");\n";
    }

    // rows
    QList<DomRow*> rows = w->elementRow();
    for (int i=0; i<rows.size(); ++i) {
        DomRow *row = rows.at(i);

        const DomPropertyMap properties = propertyMap(row->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *pixmap = properties.value(QLatin1String("pixmap"));

        m_refreshOut << m_option.indent << varName << ".VerticalHeader().SetLabel(" << i << ", ";
        if (pixmap) {
            m_refreshOut << pixCall(pixmap) << ", ";
        }
        m_refreshOut << trCall(text->elementString()) << ");\n";
    }


    //initializeQ3TableItems(className, varName, w->elementItem());
}

void WriteInitialization::initializeQ3TableItems(const QString &className, const QString &varName, const QList<DomItem *> &items)
{
    Q_UNUSED(className);
    Q_UNUSED(varName);
    Q_UNUSED(items);
}

QString WriteInitialization::pixCall(const DomProperty *p) const
{
    Q_ASSERT(p->kind() == DomProperty::IconSet || p->kind() == DomProperty::Pixmap);

    QString type, s;
    if (p->kind() == DomProperty::IconSet) {
        type = QLatin1String("new QIcon");
        s = p->elementIconSet()->text();
    } else {
        type = QLatin1String("new QPixmap");
        s = p->elementPixmap()->text();
    }

    if (s.isEmpty())
        return type + QLatin1String("()");
    else if (findImage(s) != 0)
        return QLatin1String("Icon(") + s + QLatin1String("_ID)");

    /*QString pixFunc = m_uic->pixmapFunction();
    if (pixFunc.isEmpty())
        pixFunc = QLatin1String("QString.FromUtf8");*/

    return type + QLatin1String("(") + fixString(s, m_option.indent) + QLatin1String(")");
}

void WriteInitialization::initializeListWidget(DomWidget *w)
{
    QString varName = m_driver->findOrInsertWidget(w);
    QString className = w->attributeClass();

    QList<DomItem*> items = w->elementItem();

    if (items.isEmpty())
        return;

    m_refreshOut << m_option.indent << varName << ".Clear();\n";

    // items
    for (int i=0; i<items.size(); ++i) {
        DomItem *item = items.at(i);

        QString itemName = m_driver->unique(QLatin1String("__item"));
        m_refreshOut << "\n";
        m_refreshOut << m_option.indent << "QListWidgetItem " << itemName << " = new QListWidgetItem(" << varName << ");\n";

        QList<DomProperty*> properties = item->elementProperty();
        for (int i=0; i<properties.size(); ++i) {
            DomProperty *p = properties.at(i);

            if (p->attributeName() == QLatin1String("text"))
                m_refreshOut << m_option.indent << itemName << ".SetText(" << trCall(p->elementString()) << ");\n";

            if (p->attributeName() == QLatin1String("icon"))
                m_refreshOut << m_option.indent << itemName << ".SetIcon(" << pixCall(p) << ");\n";
        }
    }
}

void WriteInitialization::initializeTreeWidget(DomWidget *w)
{
    QString varName = m_driver->findOrInsertWidget(w);
    QString className = w->attributeClass();

    // columns
    QList<DomColumn*> columns = w->elementColumn();
    for (int i=0; i<columns.size(); ++i) {
        DomColumn *column = columns.at(i);

        const DomPropertyMap properties = propertyMap(column->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *icon = properties.value(QLatin1String("icon"));

        QString txt = trCall(text->elementString());
        m_refreshOut << m_option.indent << varName << ".HeaderItem().SetText(" << i << ", " << txt << ");\n";

        if (icon != 0 && icon->elementIconSet()) {
            m_output << m_option.indent << varName << ".HeaderItem().SetIcon("
                   << i << ", " << pixCall(icon) << ");\n";
        }
    }

    if (w->elementItem().size()) {
        m_refreshOut << m_option.indent << varName << ".Clear();\n";

        initializeTreeWidgetItems(className, varName, w->elementItem());
    }
}

void WriteInitialization::initializeTableWidget(DomWidget *w)
{
    QString varName = m_driver->findOrInsertWidget(w);
    QString className = w->attributeClass();

    // columns
    QList<DomColumn *> columns = w->elementColumn();

    if (columns.size() != 0) {
        m_refreshOut << m_option.indent << "if (" << varName << ".ColumnCount < " << columns.size() << ")\n"
            << m_option.indent << m_option.indent << varName << ".ColumnCount = " << columns.size() << ";\n";
    }

    for (int i = 0; i < columns.size(); ++i) {
        DomColumn *column = columns.at(i);

        const DomPropertyMap properties = propertyMap(column->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *icon = properties.value(QLatin1String("icon"));
        if (text || icon) {
            QString itemName = m_driver->unique(QLatin1String("__colItem"));
            m_refreshOut << "\n";
            m_refreshOut << m_option.indent << "QTableWidgetItem "
                           << itemName << " = new QTableWidgetItem();\n";

            if (text && text->attributeName() == QLatin1String("text"))
                m_refreshOut << m_option.indent << itemName << ".Text = "
                           << trCall(text->elementString()) << ";\n";

            if (icon && icon->attributeName() == QLatin1String("icon"))
                m_refreshOut << m_option.indent << itemName << ".Icon = "
                           << pixCall(icon) << ";\n";
            m_refreshOut << m_option.indent << varName << ".SetHorizontalHeaderItem("
                           << i << ", " << itemName << ");\n";
        }
    }

    // rows
    QList<DomRow *> rows = w->elementRow();

    if (rows.size() != 0) {
        m_refreshOut << m_option.indent << "if (" << varName << ".RowCount < " << rows.size() << ")\n"
            << m_option.indent << m_option.indent << varName << ".RowCount = " << rows.size() << ";\n";
    }

    for (int i = 0; i < rows.size(); ++i) {
        DomRow *row = rows.at(i);

        const DomPropertyMap properties = propertyMap(row->elementProperty());
        DomProperty *text = properties.value(QLatin1String("text"));
        DomProperty *icon = properties.value(QLatin1String("icon"));
        if (text || icon) {
            QString itemName = m_driver->unique(QLatin1String("__rowItem"));
            m_refreshOut << "\n";
            m_refreshOut << m_option.indent << "QTableWidgetItem "
                           << itemName << " = new QTableWidgetItem();\n";

            if (text && text->attributeName() == QLatin1String("text"))
                m_refreshOut << m_option.indent << itemName << ".Text = "
                           << trCall(text->elementString()) << ";\n";

            if (icon && icon->attributeName() == QLatin1String("icon"))
                m_refreshOut << m_option.indent << itemName << ".Icon = "
                           << pixCall(icon) << ";\n";
            m_refreshOut << m_option.indent << varName << ".SetVerticalHeaderItem("
                           << i << ", " << itemName << ");\n";
        }
    }

    // items
    QList<DomItem *> items = w->elementItem();
    QString tempName;
    if (!items.isEmpty()) {
        // turn off sortingEnabled to force programmatic item order (setItem())
        tempName = m_driver->unique(QLatin1String("__sortingEnabled"));
        m_refreshOut << "\n";
        m_refreshOut << m_option.indent << "bool " << tempName
                   << " = " << varName << ".IsSortingEnabled();\n";
        m_refreshOut << m_option.indent << varName << ".SetSortingEnabled(false);\n";
    }
    for (int i = 0; i < items.size(); ++i) {
        DomItem *item = items.at(i);
        if (item->hasAttributeRow() && item->hasAttributeColumn()) {
            const DomPropertyMap properties = propertyMap(item->elementProperty());
            DomProperty *text = properties.value(QLatin1String("text"));
            DomProperty *icon = properties.value(QLatin1String("icon"));
            if (text || icon) {
                QString itemName = m_driver->unique(QLatin1String("__item"));
                m_refreshOut << "\n";
                m_refreshOut << m_option.indent << "QTableWidgetItem "
                    << itemName << " = new QTableWidgetItem();\n";

                if (text && text->attributeName() == QLatin1String("text"))
                    m_refreshOut << m_option.indent << itemName << ".Text = "
                        << trCall(text->elementString()) << ";\n";

                if (icon && icon->attributeName() == QLatin1String("icon"))
                    m_refreshOut << m_option.indent << itemName << ".Icon = "
                        << pixCall(icon) << ";\n";
                m_refreshOut << m_option.indent << varName << ".SetItem("
                    << item->attributeRow() << ", "
                    << item->attributeColumn() << ", "
                    << itemName << ");\n";
            }
        }
    }
    if (!items.isEmpty()) {
        // restore value of sortingEnabled
        m_refreshOut << "\n";
        m_refreshOut << m_option.indent << varName << ".SetSortingEnabled(" << tempName << ");\n";
        m_refreshOut << "\n";
    }
}

QString WriteInitialization::trCall(const QString &str, const QString &commentHint) const
{
    if (str.isEmpty())
        return QLatin1String("");

    QString result;
    QString comment = commentHint.isEmpty() ? QString::fromUtf8("null") : fixString(commentHint, m_option.indent);

    if (m_option.translateFunction.isEmpty()) {
        result = QLatin1String("QApplication.Translate(\"");
        result += m_generatedClass;
        result += QLatin1String("\"");
        result += QLatin1String(", ");
    } else {
        result = m_option.translateFunction + QLatin1String("(");
    }

    result += fixString(str, m_option.indent);
    result += QLatin1String(", ");
    result += comment;

    if (m_option.translateFunction.isEmpty()) {
        result += QLatin1String(", ");
        result += QLatin1String("QApplication.Encoding.UnicodeUTF8");
    }

    result += QLatin1String(")");
    return result;
}

void WriteInitialization::initializeQ3SqlDataTable(DomWidget *w)
{
    const DomPropertyMap properties = propertyMap(w->elementProperty());

    DomProperty *frameworkCode = properties.value(QLatin1String("frameworkCode"), 0);
    if (frameworkCode && toBool(frameworkCode->elementBool()) == false)
        return;

    QString connection;
    QString table;
    QString field;

    DomProperty *db = properties.value(QLatin1String("database"), 0);
    if (db && db->elementStringList()) {
        QStringList info = db->elementStringList()->elementString();
        connection = info.size() > 0 ? info.at(0) : QString();
        table = info.size() > 1 ? info.at(1) : QString();
        field = info.size() > 2 ? info.at(2) : QString();
    }

    if (table.isEmpty() || connection.isEmpty()) {
        fprintf(stderr, "invalid database connection\n");
        return;
    }

    QString varName = m_driver->findOrInsertWidget(w);

    m_output << m_option.indent << "if (!" << varName << ".SqlCursor()) {\n";

    m_output << m_option.indent << m_option.indent << varName << ".SetSqlCursor(";

    if (connection == QLatin1String("(default)")) {
        m_output << "new Q3SqlCursor(" << fixString(table, m_option.indent) << "), false, true);\n";
    } else {
        m_output << "new Q3SqlCursor(" << fixString(table, m_option.indent) << ", true, " << connection << "Connection" << "), false, true);\n";
    }
    m_output << m_option.indent << m_option.indent << varName << ".Refresh(Q3DataTable.RefreshAll);\n";
    m_output << m_option.indent << "}\n";
}

void WriteInitialization::initializeQ3SqlDataBrowser(DomWidget *w)
{
    const DomPropertyMap properties = propertyMap(w->elementProperty());

    DomProperty *frameworkCode = properties.value(QLatin1String("frameworkCode"), 0);
    if (frameworkCode && toBool(frameworkCode->elementBool()) == false)
        return;

    QString connection;
    QString table;
    QString field;

    DomProperty *db = properties.value(QLatin1String("database"), 0);
    if (db && db->elementStringList()) {
        QStringList info = db->elementStringList()->elementString();
        connection = info.size() > 0 ? info.at(0) : QString();
        table = info.size() > 1 ? info.at(1) : QString();
        field = info.size() > 2 ? info.at(2) : QString();
    }

    if (table.isEmpty() || connection.isEmpty()) {
        fprintf(stderr, "invalid database connection\n");
        return;
    }

    QString varName = m_driver->findOrInsertWidget(w);

    m_output << m_option.indent << "if (!" << varName << ".SqlCursor()) {\n";

    m_output << m_option.indent << m_option.indent << varName << ".SetSqlCursor(";

    if (connection == QLatin1String("(default)")) {
        m_output << "new Q3SqlCursor(" << fixString(table, m_option.indent) << "), true);\n";
    } else {
        m_output << "new Q3SqlCursor(" << fixString(table, m_option.indent) << ", true, " << connection << "Connection" << "), false, true);\n";
    }
    m_output << m_option.indent << m_option.indent << varName << ".Refresh();\n";
    m_output << m_option.indent << "}\n";
}

void WriteInitialization::initializeMenu(DomWidget *w, const QString &/*parentWidget*/)
{
    QString menuName = m_driver->findOrInsertWidget(w);
    QString menuAction = menuName + QLatin1String("Action");

    DomAction *action = m_driver->actionByName(menuAction);
    if (action && action->hasAttributeMenu()) {
        m_output << m_option.indent << menuAction << " = " << menuName << ".MenuAction();\n";
    }
}

QString WriteInitialization::trCall(DomString *str) const
{
    return trCall(toString(str), str->attributeComment());
}

bool WriteInitialization::isValidObject(const QString &name) const
{
    return m_registeredWidgets.contains(name)
        || m_registeredActions.contains(name);
}

QString WriteInitialization::findDeclaration(const QString &name)
{
    QString normalized = Driver::normalizedName(name);

    if (DomWidget *widget = m_driver->widgetByName(normalized))
        return m_driver->findOrInsertWidget(widget);
    else if (DomAction *action = m_driver->actionByName(normalized))
        return m_driver->findOrInsertAction(action);

    return QString();
}

void WriteInitialization::acceptConnection(DomConnection *connection)
{
    QString sender = findDeclaration(connection->elementSender());
    QString receiver = findDeclaration(connection->elementReceiver());

    if (sender.isEmpty() || receiver.isEmpty())
        return;

    m_output << m_option.indent << "QObject.Connect("
        << sender
        << ", "
        << "Qt.SIGNAL(\"" << connection->elementSignal() << "\")"
        << ", "
        << receiver
        << ", "
        << "Qt.SLOT(\"" << connection->elementSlot() << "\")"
        << ");\n";
}

DomImage *WriteInitialization::findImage(const QString &name) const
{
    return m_registeredImages.value(name);
}

DomWidget *WriteInitialization::findWidget(const QString &widgetClass)
{
    for (int i = m_widgetChain.count() - 1; i >= 0; --i) {
        DomWidget *widget = m_widgetChain.at(i);

        if (widget && m_uic->customWidgetsInfo()->extends(widget->attributeClass(), widgetClass))
            return widget;
    }

    return 0;
}

void WriteInitialization::acceptImage(DomImage *image)
{
    if (!image->hasAttributeName())
        return;

    m_registeredImages.insert(image->attributeName(), image);
}

} // namespace CS
