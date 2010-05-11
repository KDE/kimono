/***************************************************************************
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU Lesser General Public License as        *
 *   published by the Free Software Foundation; either version 2 of the    *
 *   License, or (at your option) any later version.                       *
 *                                                                         *
 ***************************************************************************/

#include <QtCore/qbytearray.h>
#include <QtCore/qdir.h>
#include <QtCore/qhash.h>
#include <QtCore/qlinkedlist.h>
#include <QtCore/qmetaobject.h>
#include <QtCore/qobject.h>
#include <QtCore/qpair.h>
#include <QtCore/qprocess.h>
#include <QtCore/qrect.h>
#include <QtCore/qregexp.h>
#include <QtCore/qstring.h>
#include <QtCore/qtextcodec.h>
#include <QtCore/qurl.h>
#include <QtGui/qabstractbutton.h>
#include <QtGui/qaction.h>
#include <QtGui/qapplication.h>
#include <QtGui/qdockwidget.h>
#include <QtGui/qevent.h>
#include <QtGui/qlayout.h>
#include <QtGui/qlistwidget.h>
#include <QtGui/qpainter.h>
#include <QtGui/qpalette.h>
#include <QtGui/qpixmap.h>
#include <QtGui/qpolygon.h>
#include <QtGui/qtabbar.h>
#include <QtGui/qtablewidget.h>
#include <QtGui/qtextlayout.h>
#include <QtGui/qtextobject.h>
#include <QtGui/qtoolbar.h>
#include <QtGui/qtreewidget.h>
#include <QtGui/qwidget.h>
#include <QtNetwork/qhostaddress.h>
#include <QtNetwork/qnetworkinterface.h>
#include <QtNetwork/qurlinfo.h>

#if QT_VERSION >= 0x40200
#include <QtGui/qgraphicsitem.h>
#include <QtGui/qgraphicsscene.h>
#include <QtGui/qstandarditemmodel.h>
#include <QtGui/qundostack.h>
#endif

#if QT_VERSION >= 0x40300
#include <QtGui/qwizard.h>
#include <QtGui/qmdisubwindow.h>
#include <QtNetwork/qsslcertificate.h>
#include <QtNetwork/qsslcipher.h>
#include <QtNetwork/qsslerror.h>
#include <QtXml/qxmlstream.h>
#endif

#if QT_VERSION >= 0x040400
#include <QtGui/qprinterinfo.h>
#include <QtNetwork/qnetworkcookie.h>
#endif

#include "smoke.h"

#undef DEBUG
#ifndef _GNU_SOURCE
#define _GNU_SOURCE
#endif
#ifndef __USE_POSIX
#define __USE_POSIX
#endif
#ifndef __USE_XOPEN
#define __USE_XOPEN
#endif

#include "marshall.h"
#include "qyoto.h"
#include "smokeqyoto.h"
#include "marshall_macros.h"

#ifdef Q_OS_WIN
#include <windows.h>
#endif

extern "C" {
Q_DECL_EXPORT GetIntPtr ListToPointerList;
Q_DECL_EXPORT CreateListFn ConstructList;
Q_DECL_EXPORT SetIntPtr AddIntPtrToList;
Q_DECL_EXPORT ConstructDict ConstructDictionary;
Q_DECL_EXPORT DictToMap DictionaryToQMap;
Q_DECL_EXPORT DictToHash DictionaryToQHash;
Q_DECL_EXPORT InvokeMethodFn AddObjectObjectToDictionary;

Q_DECL_EXPORT GetIntPtr IntPtrToCharStarStar;
Q_DECL_EXPORT GetCharStarFromIntPtr IntPtrToCharStar;
Q_DECL_EXPORT GetIntPtrFromCharStar IntPtrFromCharStar;
Q_DECL_EXPORT GetIntPtr IntPtrToQString;
Q_DECL_EXPORT GetIntPtr IntPtrFromQString;
Q_DECL_EXPORT GetIntPtr StringBuilderToQString;
Q_DECL_EXPORT SetIntPtrFromCharStar StringBuilderFromQString;
Q_DECL_EXPORT GetIntPtr StringListToQStringList;
Q_DECL_EXPORT GetIntPtr ListIntToQListInt;
Q_DECL_EXPORT GetIntPtr ListUIntToQListQRgb;
Q_DECL_EXPORT GetIntPtr ListWizardButtonToQListWizardButton;
Q_DECL_EXPORT AddInt AddIntToListInt;
Q_DECL_EXPORT AddUInt AddUIntToListUInt;
Q_DECL_EXPORT AddIntObject AddIntObjectToDictionary;

Q_DECL_EXPORT GetIntPtr QPairGetFirst;
Q_DECL_EXPORT GetIntPtr QPairGetSecond;
Q_DECL_EXPORT CreateQPairFn CreateQPair;

Q_DECL_EXPORT SetIntPtr UnboxToStackItem;
Q_DECL_EXPORT CreateInstanceFn BoxFromStackItem;

Q_DECL_EXPORT GetIntPtr GenericPointerGetIntPtr;
Q_DECL_EXPORT CreateInstanceFn CreateGenericPointer;

Q_DECL_EXPORT void InstallIntPtrToCharStarStar(GetIntPtr callback)
{
	IntPtrToCharStarStar = callback;
}

Q_DECL_EXPORT void InstallIntPtrToCharStar(GetCharStarFromIntPtr callback)
{
	IntPtrToCharStar = callback;
}

Q_DECL_EXPORT void InstallIntPtrFromCharStar(GetIntPtrFromCharStar callback)
{
	IntPtrFromCharStar = callback;
}

Q_DECL_EXPORT void InstallIntPtrToQString(GetIntPtr callback)
{
	IntPtrToQString = callback;
}

Q_DECL_EXPORT void InstallIntPtrFromQString(GetIntPtr callback)
{
	IntPtrFromQString = callback;
}

Q_DECL_EXPORT void InstallStringBuilderToQString(GetIntPtr callback)
{
	StringBuilderToQString = callback;
}

Q_DECL_EXPORT void InstallStringBuilderFromQString(SetIntPtrFromCharStar callback)
{
	StringBuilderFromQString = callback;
}

Q_DECL_EXPORT void InstallStringListToQStringList(GetIntPtr callback)
{
	StringListToQStringList = callback;
}

Q_DECL_EXPORT void InstallListToPointerList(GetIntPtr callback)
{
	ListToPointerList = callback;
}

Q_DECL_EXPORT void InstallListIntToQListInt(GetIntPtr callback)
{
	ListIntToQListInt = callback;
}

Q_DECL_EXPORT void InstallConstructList(CreateListFn callback)
{
	ConstructList = callback;
}

Q_DECL_EXPORT void InstallAddIntPtrToList(SetIntPtr callback)
{
	AddIntPtrToList = callback;
}

Q_DECL_EXPORT void InstallAddIntToListInt(AddInt callback)
{
	AddIntToListInt = callback;
}

Q_DECL_EXPORT void InstallConstructDictionary(ConstructDict callback)
{
	ConstructDictionary = callback;
}

Q_DECL_EXPORT void InstallAddObjectObjectToDictionary(InvokeMethodFn callback)
{
	AddObjectObjectToDictionary = callback;
}

Q_DECL_EXPORT void InstallAddIntObjectToDictionary(AddIntObject callback)
{
	AddIntObjectToDictionary = callback;
}

Q_DECL_EXPORT void InstallDictionaryToQHash(DictToHash callback)
{
	DictionaryToQHash = callback;
}

Q_DECL_EXPORT void InstallDictionaryToQMap(DictToMap callback)
{
	DictionaryToQMap = callback;
}

Q_DECL_EXPORT void InstallListUIntToQListQRgb(GetIntPtr callback)
{
	ListUIntToQListQRgb = callback;
}

Q_DECL_EXPORT void InstallAddUIntToListUInt(AddUInt callback)
{
	AddUIntToListUInt = callback;
}

Q_DECL_EXPORT void InstallListWizardButtonToQListWizardButton(GetIntPtr callback)
{
	ListWizardButtonToQListWizardButton = callback;
}

Q_DECL_EXPORT void InstallGenericPointerGetIntPtr(GetIntPtr callback)
{
	GenericPointerGetIntPtr = callback;
}

Q_DECL_EXPORT void InstallCreateGenericPointer(CreateInstanceFn callback)
{
	CreateGenericPointer = callback;
}

Q_DECL_EXPORT void InstallQPairGetFirst(GetIntPtr callback)
{
	QPairGetFirst = callback;
}

Q_DECL_EXPORT void InstallQPairGetSecond(GetIntPtr callback)
{
	QPairGetSecond = callback;
}

Q_DECL_EXPORT void InstallCreateQPair(CreateQPairFn callback)
{
	CreateQPair = callback;
}

Q_DECL_EXPORT void InstallUnboxToStackItem(SetIntPtr callback)
{
	UnboxToStackItem = callback;
}

Q_DECL_EXPORT void InstallBoxFromStackItem (CreateInstanceFn callback)
{
	BoxFromStackItem = callback;
}

Q_DECL_EXPORT void* ConstructPointerList()
{
	void * list = (void*) new QList<void*>;
	return list;
}

Q_DECL_EXPORT void AddObjectToPointerList(void* ptr, void* obj)
{
	QList<void*> * list = (QList<void*>*) ptr;
	list->append(obj);
}

Q_DECL_EXPORT void* ConstructQListInt()
{
	void* list = (void*) new QList<int>;
	return list;
}

Q_DECL_EXPORT void AddIntToQList(void* ptr, int i)
{
	QList<int>* list = (QList<int>*) ptr;
	list->append(i);
}
Q_DECL_EXPORT void* ConstructQHash(int type)
{
	if (type == 0) {
		return (void*) new QHash<int, QVariant>();
	} else if (type == 1) {
		return (void*) new QHash<QString, QString>();
	} else if (type == 2) {
		return (void*) new QHash<QString, QVariant>();
	}
	return 0;
}

Q_DECL_EXPORT void AddIntQVariantToQHash(void* ptr, int i, void* qv)
{
	QHash<int, QVariant>* hash = (QHash<int, QVariant>*) ptr;
	QVariant* variant = (QVariant*) ((smokeqyoto_object*) (*GetSmokeObject)(qv))->ptr;
	hash->insert(i, *variant);
}

Q_DECL_EXPORT void AddQStringQStringToQHash(void* ptr, char* str1, char* str2)
{
	QHash<QString, QString>* hash = (QHash<QString, QString>*) ptr;
	hash->insert(QString(str1), QString(str2));
}

Q_DECL_EXPORT void AddQStringQVariantToQHash(void* ptr, char* str, void* qv)
{
	QHash<QString, QVariant>* hash = (QHash<QString, QVariant>*) ptr;
	QVariant* variant = (QVariant*) ((smokeqyoto_object*) (*GetSmokeObject)(qv))->ptr;
	hash->insert(QString(str), *variant);
}

Q_DECL_EXPORT void* ConstructQMap(int type)
{
	if (type == 0) {
		return (void*) new QMap<int, QVariant>();
	} else if (type == 1) {
		return (void*) new QMap<QString, QString>();
	} else if (type == 2) {
		return (void*) new QMap<QString, QVariant>();
	}
	return 0;
}

Q_DECL_EXPORT void AddIntQVariantToQMap(void* ptr, int i, void* qv)
{
	QMap<int, QVariant>* map = (QMap<int, QVariant>*) ptr;
	QVariant* variant = (QVariant*) ((smokeqyoto_object*) (*GetSmokeObject)(qv))->ptr;
	map->insert(i, *variant);
}

Q_DECL_EXPORT void AddQStringQStringToQMap(void* ptr, char* str1, char* str2)
{
	QMap<QString, QString>* map = (QMap<QString, QString>*) ptr;
	map->insert(QString(str1), QString(str2));
}

Q_DECL_EXPORT void AddQStringQVariantToQMap(void* ptr, char* str, void* qv)
{
	QMap<QString, QVariant>* map = (QMap<QString, QVariant>*) ptr;
	QVariant* variant = (QVariant*) ((smokeqyoto_object*) (*GetSmokeObject)(qv))->ptr;
	map->insert(QString(str), *variant);
}

Q_DECL_EXPORT void* ConstructQListQRgb()
{
	return (void*) new QList<QRgb>;
}

Q_DECL_EXPORT void AddUIntToQListQRgb(void* ptr, uint i)
{
	QList<QRgb>* list = (QList<QRgb>*) ptr;
	list->append(i);
}

#if QT_VERSION >= 0x40300
Q_DECL_EXPORT void* ConstructQListWizardButton()
{
	return (void*) new QList<QWizard::WizardButton>();
}

Q_DECL_EXPORT void AddWizardButtonToQList(void* ptr, int i)
{
	QList<QWizard::WizardButton>* list = (QList<QWizard::WizardButton>*) ptr;
	list->append((QWizard::WizardButton) i);
}
#endif

}

// extern bool isDerivedFrom(Smoke *smoke, const char *className, const char *baseClassName);
extern void mapPointer(void * obj, smokeqyoto_object *o, Smoke::Index classId, void *lastptr);

Q_DECL_EXPORT bool
IsContainedInstanceQt(smokeqyoto_object *o)
{
    const char *className = o->smoke->classes[o->classId].className;
		
	if (	qstrcmp(className, "QListBoxItem") == 0
			|| qstrcmp(className, "QStyleSheetItem") == 0
			|| qstrcmp(className, "QSqlCursor") == 0
			|| qstrcmp(className, "QModelIndex") == 0 )
	{
		return true;
	} else if (o->smoke->isDerivedFrom(className, "QLayoutItem")) {
		QLayoutItem * item = (QLayoutItem *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QLayoutItem", true).index);
		if (item->layout() != 0 || item->widget() != 0 || item->spacerItem() != 0) {
			return true;
		}
	} else if (qstrcmp(className, "QListWidgetItem") == 0) {
		QListWidgetItem * item = (QListWidgetItem *) o->ptr;
		if (item->listWidget() != 0) {
			return true;
		}
	} else if (o->smoke->isDerivedFrom(className, "QTableWidgetItem")) {
		QTableWidgetItem * item = (QTableWidgetItem *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QTableWidgetItem", true).index);
		if (item->tableWidget() != 0) {
			return true;
		}
	} else if (o->smoke->isDerivedFrom(className, "QTreeWidgetItem")) {
		QTreeWidgetItem * item = (QTreeWidgetItem *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QTreeWidgetItem", true).index);
		if (item->treeWidget() != 0) {
			return true;
		}
	} else if (o->smoke->isDerivedFrom(className, "QGraphicsScene")) {
		QGraphicsScene * scene = (QGraphicsScene *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QGraphicsScene", true).index);
		if (scene->views().count() > 0 || scene->parent() != 0) {
			return true;
		}
	} else if (o->smoke->isDerivedFrom(className, "QWidget")) {
		// Only garbage collect the widget if it's hidden, doesn't have any parents and if there are no more 
		// references to it in the code. This should produce a more 'natural' behaviour for top-level widgets.
		QWidget * qwidget = (QWidget *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QWidget", true).index);
		if (qwidget->isVisible() || qwidget->parent() != 0) {
			return true;
		}
	} else if (o->smoke->isDerivedFrom(className, "QObject")) {
		QObject * qobject = (QObject *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QObject", true).index);
		if (qobject->parent() != 0) {
			return true;
		}
	} else if (o->smoke->isDerivedFrom(className, "QTextBlockUserData")) {
		return true;
	} else if (o->smoke->isDerivedFrom(className, "QGraphicsItem")) {
		QGraphicsItem * item = (QGraphicsItem *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QGraphicsItem", true).index);
		if (item->scene() != 0 || item->parentItem() != 0) {
			return true;
		}
	}
	
    return false;
}

/*
 * Given an approximate classname and a qt instance, try to improve the resolution of the name
 * by using the various Qt rtti mechanisms for QObjects, QEvents and so on
 */
Q_DECL_EXPORT const char *
qyoto_resolve_classname_qt(smokeqyoto_object * o)
{
#define SET_SMOKEQYOTO_OBJECT(className) \
    { \
        Smoke::ModuleIndex mi = Smoke::findClass(className); \
        o->classId = mi.index; \
        o->smoke = mi.smoke; \
    }

	if (o->smoke->isDerivedFrom(o->smoke->classes[o->classId].className, "QEvent")) {
		QEvent * qevent = (QEvent *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QEvent", true).index);
		switch (qevent->type()) {
		case QEvent::Timer:
   			SET_SMOKEQYOTO_OBJECT("QTimerEvent")
			break;
		case QEvent::MouseButtonPress:
		case QEvent::MouseButtonRelease:
		case QEvent::MouseButtonDblClick:
		case QEvent::MouseMove:
			SET_SMOKEQYOTO_OBJECT("QMouseEvent")
			break;
		case QEvent::KeyPress:
		case QEvent::KeyRelease:
		case QEvent::ShortcutOverride:
   			SET_SMOKEQYOTO_OBJECT("QKeyEvent")
			break;
		case QEvent::FocusIn:
		case QEvent::FocusOut:
   			SET_SMOKEQYOTO_OBJECT("QFocusEvent")
			break;
		case QEvent::Enter:
		case QEvent::Leave:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::Paint:
			SET_SMOKEQYOTO_OBJECT("QPaintEvent")
			break;
		case QEvent::Move:
			SET_SMOKEQYOTO_OBJECT("QMoveEvent")
			break;
		case QEvent::Resize:
			SET_SMOKEQYOTO_OBJECT("QResizeEvent")
			break;
		case QEvent::Create:
		case QEvent::Destroy:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::Show:
			SET_SMOKEQYOTO_OBJECT("QShowEvent")
			break;
		case QEvent::Hide:
			SET_SMOKEQYOTO_OBJECT("QHideEvent")
		case QEvent::Close:
			SET_SMOKEQYOTO_OBJECT("QCloseEvent")
			break;
		case QEvent::Quit:
		case QEvent::ParentChange:
		case QEvent::ParentAboutToChange:
		case QEvent::ThreadChange:
		case QEvent::WindowActivate:
		case QEvent::WindowDeactivate:
		case QEvent::ShowToParent:
		case QEvent::HideToParent:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::Wheel:
			SET_SMOKEQYOTO_OBJECT("QWheelEvent")
			break;
		case QEvent::WindowTitleChange:
		case QEvent::WindowIconChange:
		case QEvent::ApplicationWindowIconChange:
		case QEvent::ApplicationFontChange:
		case QEvent::ApplicationLayoutDirectionChange:
		case QEvent::ApplicationPaletteChange:
		case QEvent::PaletteChange:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::Clipboard:
			SET_SMOKEQYOTO_OBJECT("QClipboardEvent")
			break;
		case QEvent::Speech:
		case QEvent::MetaCall:
		case QEvent::SockAct:
		case QEvent::WinEventAct:
		case QEvent::DeferredDelete:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::DragEnter:
			SET_SMOKEQYOTO_OBJECT("QDragEnterEvent")
			break;
		case QEvent::DragLeave:
			SET_SMOKEQYOTO_OBJECT("QDragLeaveEvent")
			break;
		case QEvent::DragMove:
			SET_SMOKEQYOTO_OBJECT("QDragMoveEvent")
		case QEvent::Drop:
			SET_SMOKEQYOTO_OBJECT("QDropEvent")
			break;
		case QEvent::DragResponse:
			SET_SMOKEQYOTO_OBJECT("QDragResponseEvent")
			break;
		case QEvent::ChildAdded:
		case QEvent::ChildRemoved:
		case QEvent::ChildPolished:
			SET_SMOKEQYOTO_OBJECT("QChildEvent")
			break;
		case QEvent::ShowWindowRequest:
		case QEvent::PolishRequest:
		case QEvent::Polish:
		case QEvent::LayoutRequest:
		case QEvent::UpdateRequest:
		case QEvent::EmbeddingControl:
		case QEvent::ActivateControl:
		case QEvent::DeactivateControl:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
        case QEvent::ContextMenu:
			SET_SMOKEQYOTO_OBJECT("QContextMenuEvent")
			break;
  case QEvent::DynamicPropertyChange:
			SET_SMOKEQYOTO_OBJECT("QDynamicPropertyChangeEvent")
			break;
		case QEvent::InputMethod:
			SET_SMOKEQYOTO_OBJECT("QInputMethodEvent")
			break;
		case QEvent::AccessibilityPrepare:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::TabletMove:
		case QEvent::TabletPress:
		case QEvent::TabletRelease:
			SET_SMOKEQYOTO_OBJECT("QTabletEvent")
			break;
		case QEvent::LocaleChange:
		case QEvent::LanguageChange:
		case QEvent::LayoutDirectionChange:
		case QEvent::Style:
		case QEvent::OkRequest:
		case QEvent::HelpRequest:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::IconDrag:
			SET_SMOKEQYOTO_OBJECT("QIconDragEvent")
			break;
		case QEvent::FontChange:
		case QEvent::EnabledChange:
		case QEvent::ActivationChange:
		case QEvent::StyleChange:
		case QEvent::IconTextChange:
		case QEvent::ModifiedChange:
		case QEvent::MouseTrackingChange:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::WindowBlocked:
		case QEvent::WindowUnblocked:
		case QEvent::WindowStateChange:
			SET_SMOKEQYOTO_OBJECT("QWindowStateChangeEvent")
			break;
		case QEvent::ToolTip:
		case QEvent::WhatsThis:
			SET_SMOKEQYOTO_OBJECT("QHelpEvent")
			break;
		case QEvent::StatusTip:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::ActionChanged:
		case QEvent::ActionAdded:
		case QEvent::ActionRemoved:
			SET_SMOKEQYOTO_OBJECT("QActionEvent")
			break;
		case QEvent::FileOpen:
			SET_SMOKEQYOTO_OBJECT("QFileOpenEvent")
			break;
		case QEvent::Shortcut:
			SET_SMOKEQYOTO_OBJECT("QShortcutEvent")
			break;
		case QEvent::WhatsThisClicked:
			SET_SMOKEQYOTO_OBJECT("QWhatsThisClickedEvent")
			break;
		case QEvent::ToolBarChange:
			SET_SMOKEQYOTO_OBJECT("QToolBarChangeEvent")
			break;
		case QEvent::ApplicationActivated:
		case QEvent::ApplicationDeactivated:
		case QEvent::QueryWhatsThis:
		case QEvent::EnterWhatsThisMode:
		case QEvent::LeaveWhatsThisMode:
		case QEvent::ZOrderChange:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
		case QEvent::HoverEnter:
		case QEvent::HoverLeave:
		case QEvent::HoverMove:
			SET_SMOKEQYOTO_OBJECT("QHoverEvent")
			break;
		case QEvent::AccessibilityHelp:
		case QEvent::AccessibilityDescription:
			SET_SMOKEQYOTO_OBJECT("QEvent")
#if QT_VERSION >= 0x40200
		case QEvent::GraphicsSceneMouseMove:
		case QEvent::GraphicsSceneMousePress:
		case QEvent::GraphicsSceneMouseRelease:
		case QEvent::GraphicsSceneMouseDoubleClick:
			SET_SMOKEQYOTO_OBJECT("QGraphicsSceneMouseEvent")
			break;
		case QEvent::GraphicsSceneContextMenu:
			SET_SMOKEQYOTO_OBJECT("QGraphicsSceneContextMenuEvent")
			break;
		case QEvent::GraphicsSceneHoverEnter:
		case QEvent::GraphicsSceneHoverMove:
		case QEvent::GraphicsSceneHoverLeave:
			SET_SMOKEQYOTO_OBJECT("QGraphicsSceneHoverEvent")
			break;
		case QEvent::GraphicsSceneHelp:
			SET_SMOKEQYOTO_OBJECT("QGraphicsSceneHelpEvent")
			break;
		case QEvent::GraphicsSceneDragEnter:
		case QEvent::GraphicsSceneDragMove:
		case QEvent::GraphicsSceneDragLeave:
		case QEvent::GraphicsSceneDrop:
			SET_SMOKEQYOTO_OBJECT("QGraphicsSceneDragDropEvent")
			break;
		case QEvent::GraphicsSceneWheel:
			SET_SMOKEQYOTO_OBJECT("QGraphicsSceneWheelEvent")
			break;
		case QEvent::KeyboardLayoutChange:
			SET_SMOKEQYOTO_OBJECT("QEvent")
			break;
#endif
		default:
			break;
		}
	} else if (o->smoke->isDerivedFrom(o->smoke->classes[o->classId].className, "QGraphicsItem")) {
		QGraphicsItem * item = (QGraphicsItem *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QGraphicsItem", true).index);
		switch (item->type()) {
		case 1:
			SET_SMOKEQYOTO_OBJECT("QGraphicsItem")
			break;
		case 2:
			SET_SMOKEQYOTO_OBJECT("QGraphicsPathItem")
			break;
		case 3:
			SET_SMOKEQYOTO_OBJECT("QGraphicsRectItem")
		case 4:
			SET_SMOKEQYOTO_OBJECT("QGraphicsEllipseItem")
			break;
		case 5:
			SET_SMOKEQYOTO_OBJECT("QGraphicsPolygonItem")
			break;
		case 6:
			SET_SMOKEQYOTO_OBJECT("QGraphicsLineItem")
			break;
		case 7:
			SET_SMOKEQYOTO_OBJECT("QGraphicsItem")
			break;
		case 8:
			SET_SMOKEQYOTO_OBJECT("QGraphicsTextItem")
			break;
		case 9:
			SET_SMOKEQYOTO_OBJECT("QGraphicsSimpleTextItem")
			break;
		case 10:
			SET_SMOKEQYOTO_OBJECT("QGraphicsItemGroup")
			break;
		}
	} else if (o->smoke->isDerivedFrom(o->smoke->classes[o->classId].className, "QLayoutItem")) {
		QLayoutItem * item = (QLayoutItem *) o->smoke->cast(o->ptr, o->classId, o->smoke->idClass("QLayoutItem", true).index);
		if (item->widget() != 0) {
			SET_SMOKEQYOTO_OBJECT("QWidgetItem")
		} else if (item->spacerItem() != 0) {
			SET_SMOKEQYOTO_OBJECT("QSpacerItem")
		}
	}
	
	return qyoto_modules[o->smoke].binding->className(o->classId);

#undef SET_SMOKEQYOTO_OBJECT
}

bool
matches_arg(Smoke *smoke, Smoke::Index meth, Smoke::Index argidx, const char *argtype)
{
    Smoke::Index *arg = smoke->argumentList + smoke->methods[meth].args + argidx;
    SmokeType type = SmokeType(smoke, *arg);
	return (type.name() && qstrcmp(type.name(), argtype) == 0);
}

void *
construct_copy(smokeqyoto_object *o)
{
    const char *className = o->smoke->className(o->classId);
    int classNameLen = strlen(className);

    // copy constructor signature
    QByteArray ccSig(className);
    int pos = ccSig.lastIndexOf("::");
    if (pos != -1) {
        ccSig = ccSig.mid(pos + strlen("::"));
    }
    ccSig.append("#");

    Smoke::ModuleIndex ccId = o->smoke->findMethodName(className, ccSig);

    char *ccArg = new char[classNameLen + 8];
    sprintf(ccArg, "const %s&", className);

    Smoke::ModuleIndex classId(o->smoke, o->classId);
    Smoke::ModuleIndex ccMeth = o->smoke->findMethod(classId, ccId);

    if(!ccMeth.index) {
	return 0;
    }
	Smoke::Index method = ccMeth.smoke->methodMaps[ccMeth.index].method;
    if(method > 0) {
	// Make sure it's a copy constructor
	if(!matches_arg(ccMeth.smoke, method, 0, ccArg)) {
            delete[] ccArg;
	    return 0;
        }
        delete[] ccArg;
        ccMeth.index = method;
    } else {
        // ambiguous method, pick the copy constructor
	Smoke::Index i = -method;
	while(o->smoke->ambiguousMethodList[i]) {
	    if(matches_arg(ccMeth.smoke, ccMeth.smoke->ambiguousMethodList[i], 0, ccArg))
		break;
            i++;
	}
        delete[] ccArg;
	ccMeth.index = ccMeth.smoke->ambiguousMethodList[i];
	if(!ccMeth.index)
	    return 0;
    }

    // Okay, ccMeth is the copy constructor. Time to call it.
    Smoke::StackItem args[2];
    args[0].s_voidp = 0;
    args[1].s_voidp = o->ptr;
    Smoke::ClassFn fn = o->smoke->classes[o->classId].classFn;
    (*fn)(o->smoke->methods[ccMeth.index].method, 0, args);

    // Initialize the binding for the new instance
    Smoke::StackItem s[2];
    s[1].s_voidp = qyoto_modules[o->smoke].binding;
    (*fn)(0, args[0].s_voidp, s);

    return args[0].s_voidp;
}

extern "C" {

Q_DECL_EXPORT void *
StringArrayToCharStarStar(int length, char ** strArray)
{
	char ** result = (char **) calloc(length, sizeof(char *));
	int i;
	for (i = 0; i < length; i++) {
		result[i] = strdup(strArray[i]);
	}
	return (void *) result;
}

Q_DECL_EXPORT void *
StringToQString(const ushort *str)
{
	QString * result = new QString(QString::fromUtf16(str));
	return (void *) result;
}

Q_DECL_EXPORT const ushort *
StringFromQString(void *ptr)
{
	QString* str = (QString*) ptr;
	int len = str->length() + 1; // include the terminating \0
#ifdef Q_OS_WIN
	ushort *copy = (ushort*) GlobalAlloc(GMEM_FIXED, sizeof(ushort) * len);
#else
	ushort *copy = (ushort*) malloc(sizeof(ushort) * len);
#endif
	memcpy(copy, str->utf16(), sizeof(ushort) * len);
	// return a copy of the string - the runtime will take ownership of it and care about deletion
	return copy;
}

Q_DECL_EXPORT void *
StringArrayToQStringList(int length, char ** strArray)
{
	QStringList * result = new QStringList();
	
	for (int i = 0; i < length; i++) {
		(*result) << QString::fromUtf8(strArray[i]);
	}
	return (void*) result;
}

}

void
marshall_basetype(Marshall *m)
{
    switch(m->type().elem()) {
	
    
      case Smoke::t_bool:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_bool = m->var().s_bool;
	    break;
	  case Marshall::ToObject:
	    m->var().s_bool = m->item().s_bool;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_char:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_char = m->var().s_char;
	    break;
	  case Marshall::ToObject:
	    m->var().s_char = m->item().s_char;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_uchar:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_uchar = m->var().s_uchar;
	    break;
	  case Marshall::ToObject:
	    m->var().s_uchar = m->item().s_uchar;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_short:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_short = m->var().s_short;
	    break;
	  case Marshall::ToObject:
	    m->var().s_short = m->item().s_short;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_ushort:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_ushort = m->var().s_ushort;
	    break;
	  case Marshall::ToObject:
	    m->var().s_ushort = m->item().s_ushort;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_int:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_int = m->var().s_int;
	    break;
	  case Marshall::ToObject:
	    m->var().s_int = m->item().s_int;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_uint:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_uint = m->var().s_uint;
	    break;
	  case Marshall::ToObject:
	    m->var().s_uint = m->item().s_uint;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_long:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_long = m->var().s_long;
	    break;
	  case Marshall::ToObject:
	    m->var().s_long = m->item().s_long;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_ulong:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_ulong = m->var().s_ulong;
	    break;
	  case Marshall::ToObject:
	    m->var().s_ulong = m->item().s_ulong;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_float:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_float = m->var().s_float;
	    break;
	  case Marshall::ToObject:
	    m->var().s_float = m->item().s_float;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_double:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_double = m->var().s_double;
	    break;
	  case Marshall::ToObject:
	    m->var().s_double = m->item().s_double;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
      case Smoke::t_enum:
	switch(m->action()) {
	  case Marshall::FromObject:
	    m->item().s_enum = m->var().s_enum;
	    break;
	  case Marshall::ToObject:
	    m->var().s_enum = m->item().s_enum;
	    break;
	  default:
	    m->unsupported();
	    break;
	}
	break;
	case Smoke::t_class:
	switch(m->action()) {
	case Marshall::FromObject:
	{
		void * obj = m->var().s_voidp;
		if (obj == 0) {
			m->item().s_class = 0;
			return;
		}

		smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(obj);
		if (!o || !o->ptr) {
			if (m->type().isRef()) {
				m->unsupported();
			}
		    m->item().s_class = 0;
		    break;
		}

		void *ptr = o->ptr;
		if (!m->cleanup() && m->type().isStack()) {
		    ptr = construct_copy(o);
		}
		const Smoke::Class &c = m->smoke()->classes[m->type().classId()];
		ptr = o->smoke->cast(
		    ptr,				// pointer
		    o->classId,				// from
		    o->smoke->idClass(c.className, true).index	// to
		);
		m->item().s_class = ptr;
		(*FreeGCHandle)(obj);
		break;
	}
	break;
	case Marshall::ToObject:
	{
		if(m->item().s_voidp == 0) {
			m->var().s_voidp = 0;
		    break;
		}

		void *p = m->item().s_voidp;
		void * obj = (*GetInstance)(p, true);
		if(obj != 0) {
			m->var().s_voidp = obj;
		    break;
		}

		smokeqyoto_object  * o = alloc_smokeqyoto_object(false, m->smoke(), m->type().classId(), p);
		const char * classname = qyoto_resolve_classname(o);

		if((m->type().isConst() && m->type().isRef()) || (m->type().isStack() && m->cleanup())) {
			p = construct_copy( o );
			if (p != 0) {
				o->ptr = p;
				o->allocated = true;
		    }
		}
		
		obj = (*CreateInstance)(classname, o);
		if (do_debug & qtdb_calls) {
			printf("allocating %s %p -> %p\n", classname, o->ptr, (void*)obj);
		}

		if(m->type().isStack()) {
		    o->allocated = true;
		}
		// Keep a mapping of the pointer so that it is only wrapped once
		mapPointer(obj, o, o->classId, 0);
		
		m->var().s_class = obj;
	}
	break;
	default:
		m->unsupported();
		break;
	}
	break;
      default:
	m->unsupported();
	break;
    }

}

static void marshall_void(Marshall * /*m*/) {}
static void marshall_unknown(Marshall *m) {
    m->unsupported();
}

static void marshall_charP(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		if (!m->type().isConst()) {
			m->item().s_voidp = (*GenericPointerGetIntPtr)(m->var().s_class);
			(*FreeGCHandle)(m->var().s_voidp);
			return;
		}
		if (m->var().s_class == 0) {
			m->item().s_voidp = 0;
		} else {
			m->item().s_voidp = (*IntPtrToCharStar)(m->var().s_class);
			(*FreeGCHandle)(m->var().s_voidp);
		}
	}
	break;

	case Marshall::ToObject:
	{
		char *p = (char*) m->item().s_voidp;
		if (!m->type().isConst()) {
			m->var().s_class = (*CreateGenericPointer)("System.SByte", p);
			return;
		}
	    if (p != 0) {
			m->var().s_class = (*IntPtrFromCharStar)(p);
	    } else {
			m->var().s_class = 0;
		}
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_ucharP(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = (*GenericPointerGetIntPtr)(m->var().s_class);
		(*FreeGCHandle)(m->var().s_voidp);
	}
	break;

	case Marshall::ToObject:
	{
		uchar *p = (uchar*) m->item().s_voidp;
		m->var().s_class = (*CreateGenericPointer)("System.Byte", p);
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_QString(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		QString* s = 0;
		if (m->var().s_voidp != 0) {
			if (m->type().isConst()) {
				s = (QString *) (*IntPtrToQString)(m->var().s_voidp);
			} else {
				s = (QString *) (*StringBuilderToQString)(m->var().s_voidp);
			}
		} else {
			s = new QString();
		}
		
		m->item().s_voidp = s;
	    m->next();
		
		if (!m->type().isConst() && m->var().s_voidp != 0 && s != 0) {
			(*StringBuilderFromQString)(m->var().s_voidp, (const char *) s->toUtf8());
		}
	    
		if (s && m->cleanup()) {
			delete s;
		}

		if (m->var().s_voidp != 0) (*FreeGCHandle)(m->var().s_voidp);
	}
	break;
      case Marshall::ToObject:
	{
	    QString *s = (QString*)m->item().s_voidp;
	    if (s) {
			if (s->isNull()) {
				m->var().s_voidp = 0;
			} else {
				m->var().s_class = (*IntPtrFromQString)(s);
			}

			if (m->type().isStack())
				delete s;
			} else {
				m->var().s_voidp = 0;
			}
	}
	break;
		default:
		m->unsupported();
	break;
    }
}

static void marshall_intR(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_int);
	}
	break;

	case Marshall::ToObject:
	{
		int *ip = (int*)m->item().s_voidp;
		m->var().s_int = *ip;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_uintR(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_uint);
	}
	break;

	case Marshall::ToObject:
	{
		uint *ip = (uint*)m->item().s_voidp;
		m->var().s_uint = *ip;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_longR(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_long);
	}
	break;

	case Marshall::ToObject:
	{
		long *ip = (long*)m->item().s_voidp;
		m->var().s_long = *ip;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_ulongR(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_ulong);
	}
	break;

	case Marshall::ToObject:
	{
		unsigned long *ip = (unsigned long*)m->item().s_voidp;
		m->var().s_ulong = *ip;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_shortR(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_short);
	}
	break;

	case Marshall::ToObject:
	{
		short *ip = (short*)m->item().s_voidp;
		m->var().s_short = *ip;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_ushortR(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_ushort);
	}
	break;

	case Marshall::ToObject:
	{
		unsigned short *ip = (unsigned short*)m->item().s_voidp;
		m->var().s_ushort = *ip;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_floatR(Marshall *m) {
    switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_float);
	}
	break;

	case Marshall::ToObject:
	{
		float *dp = (float*)m->item().s_voidp;
		m->var().s_float = *dp;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_doubleR(Marshall *m) {
    switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_double);
	}
	break;

	case Marshall::ToObject:
	{
		double *dp = (double*)m->item().s_voidp;
		m->var().s_double = *dp;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_boolR(Marshall *m) {
    switch(m->action()) {
	case Marshall::FromObject:
	{
		m->item().s_voidp = &(m->var().s_bool);
	}
	break;

	case Marshall::ToObject:
	{
		bool *dp = (bool*)m->item().s_voidp;
		m->var().s_bool = *dp;
	}
	break;

	default:
		m->unsupported();
		break;
	}
}

static void marshall_charP_array(Marshall *m) {

    switch(m->action()) {
        case Marshall::FromObject:
            {
            m->item().s_voidp = (*IntPtrToCharStarStar)(m->var().s_voidp);
//            char ** temp = (char **) m->item().s_voidp;
            }
            break;

        default:
            m->unsupported();
            break;
    }

}

/*static void marshall_voidP_array(Marshall* m) {
	switch(m->action()) {
	case Marshall::FromObject:
		m->item().s_voidp = m->var().s_voidp;
		break;
	case Marshall::ToObject:
		m->var().s_voidp = m->item().s_voidp;
		break;
	default:
		m->unsupported();
		break;
	}
}*/

void marshall_QDBusVariant(Marshall *m) {
	switch(m->action()) {
	case Marshall::FromObject: 
	{
		if (m->var().s_class == 0) {
			m->item().s_class = 0;
			(*FreeGCHandle)(m->var().s_class);
			return;
		}

		smokeqyoto_object *o = (smokeqyoto_object*) (*GetSmokeObject)(m->var().s_class);
		if (!o || !o->ptr) {
			if (m->type().isRef()) {
				m->unsupported();
			}
		    m->item().s_class = 0;
		    break;
		}
		m->item().s_class = o->ptr;
		(*FreeGCHandle)(m->var().s_class);
		break;
	}

	case Marshall::ToObject: 
	{
		if (m->item().s_voidp == 0) {
			m->var().s_voidp = 0;
		    break;
		}

		void *p = m->item().s_voidp;
		void * obj = (*GetInstance)(p, true);
		if(obj != 0) {
			m->var().s_voidp = obj;
		    break;
		}
		
		Smoke::ModuleIndex id = m->smoke()->findClass("QVariant");
		smokeqyoto_object  * o = alloc_smokeqyoto_object(false, id.smoke, id.index, p);

		if((m->type().isConst() && m->type().isRef()) || (m->type().isStack() && m->cleanup())) {
			p = construct_copy( o );
			if (p != 0) {
				o->ptr = p;
				o->allocated = true;
		    }
		}

		
		obj = (*CreateInstance)("Qyoto.QDBusVariant", o);
		if (do_debug & qtdb_calls) {
			printf("allocating %s %p -> %p\n", "QDBusVariant", o->ptr, (void*)obj);
		}

		if (m->type().isStack()) {
		    o->allocated = true;
		}
		// Keep a mapping of the pointer so that it is only wrapped once
		mapPointer(obj, o, o->classId, 0);
		
		m->var().s_class = obj;
	}
	
	default:
		m->unsupported();
		break;
    }
}

void marshall_QMapintQVariant(Marshall *m) {
	switch(m->action()) {
		case Marshall::FromObject: 
		{
			if (m->var().s_class == 0) {
				m->item().s_class = 0;
				return;
			}
			QMap<int, QVariant>* map = (QMap<int, QVariant>*) (*DictionaryToQMap)(m->var().s_voidp, 0);
			m->item().s_voidp = (void*) map;
			m->next();
			
			if (m->cleanup()) {
				delete map;
			}
			(*FreeGCHandle)(m->var().s_voidp);
			break;
		}

		case Marshall::ToObject: 
		{
			QMap<int, QVariant>* map = (QMap<int, QVariant>*) m->item().s_voidp;
			void* dict = (*ConstructDictionary)("System.Int32", "Qyoto.QVariant");
			
			Smoke::ModuleIndex id = m->smoke()->findClass("QVariant");
			
			for (QMap<int, QVariant>::iterator i = map->begin(); i != map->end(); ++i) {
				void* v = (void*) &(i.value());
				smokeqyoto_object * vo = alloc_smokeqyoto_object(false, id.smoke, id.index, v);
				void* value = (*CreateInstance)("Qyoto.QVariant", vo);
				(*AddIntObjectToDictionary)(dict, i.key(), value);
				(*FreeGCHandle)(value);
			}
			
			m->var().s_voidp = dict;
			m->next();

			if (m->type().isStack()) {
				delete map;
			}
			
			break;
		}
	
		default:
			m->unsupported();
			break;
    }
}

void marshall_QMapQStringQString(Marshall *m) {
	switch(m->action()) {
		case Marshall::FromObject: 
		{
			if (m->var().s_class == 0) {
				m->item().s_class = 0;
				return;
			}
			QMap<QString, QString>* map = (QMap<QString, QString>*) (*DictionaryToQMap)(m->var().s_voidp, 1);
			m->item().s_voidp = (void*) map;
			m->next();
			
			if (m->cleanup()) {
				delete map;
			}
			(*FreeGCHandle)(m->var().s_voidp);
			break;
		}

		case Marshall::ToObject: 
		{
			QMap<QString, QString>* map = (QMap<QString, QString>*) m->item().s_voidp;
			void* dict = (*ConstructDictionary)("System.String", "System.String");
			
			for (QMap<QString, QString>::iterator i = map->begin(); i != map->end(); ++i) {
				void* string1 = (void*) (*IntPtrFromQString)((void*) &(i.key()));
				void* string2 = (void*) (*IntPtrFromQString)((void*) &(i.value()));
				(*AddObjectObjectToDictionary)(	dict,
								string1,
								string2);
				(*FreeGCHandle)(string1);
				(*FreeGCHandle)(string2);
			}
			
			m->var().s_voidp = dict;
			m->next();

			if (m->type().isStack()) {
				delete map;
			}

			
			break;
		}
	
		default:
			m->unsupported();
			break;
    }
}

void marshall_QMapQStringQVariant(Marshall *m) {
	switch(m->action()) {
		case Marshall::FromObject: 
		{
			if (m->var().s_class == 0) {
				m->item().s_class = 0;
				return;
			}
			QMap<QString, QVariant>* map = (QMap<QString, QVariant>*) (*DictionaryToQMap)(m->var().s_voidp, 2);
			m->item().s_voidp = (void*) map;
			m->next();
			
			if (m->cleanup()) {
				delete map;
			}
			(*FreeGCHandle)(m->var().s_voidp);
			break;
		}

		case Marshall::ToObject: 
		{
			QMap<QString, QVariant>* map = (QMap<QString, QVariant>*) m->item().s_voidp;
			void* dict = (*ConstructDictionary)("System.String", "Qyoto.QVariant");
			
			Smoke::ModuleIndex id = m->smoke()->findClass("QVariant");
			
			for (QMap<QString, QVariant>::iterator i = map->begin(); i != map->end(); ++i) {
				void* v = new QVariant(i.value());
				smokeqyoto_object * vo = alloc_smokeqyoto_object(false, id.smoke, id.index, v);
				void* value = (*CreateInstance)("Qyoto.QVariant", vo);
				void* string = (void*) (*IntPtrFromQString)((void*) &(i.key()));
				(*AddObjectObjectToDictionary)(	dict,
								string,
								value);
				(*FreeGCHandle)(string);
				(*FreeGCHandle)(value);
			}
			
			m->var().s_voidp = dict;
			m->next();

			if (m->type().isStack()) {
				delete map;
			}

			
			break;
		}
	
		default:
			m->unsupported();
			break;
    }
}

void marshall_QStringList(Marshall *m) {
	switch(m->action()) {
		case Marshall::FromObject: 
		{
			if (m->var().s_class == 0) {
				m->item().s_class = 0;
				return;
			}
			QStringList *stringlist = (QStringList*) (*StringListToQStringList)(m->var().s_voidp);
			
			m->item().s_voidp = (void*) stringlist;
			m->next();
			
			if (m->cleanup()) {
				delete stringlist;
			}
			(*FreeGCHandle)(m->var().s_voidp);
	   
			break;
		}

      case Marshall::ToObject: 
	{
		QStringList *stringlist = static_cast<QStringList *>(m->item().s_voidp);
		if (!stringlist) {
// 			m->var().s_voidp = 0;
			break;
		}

		void* al = (*ConstructList)("System.String");
		for (int i = 0; i < stringlist->count(); i++) {
			(*AddIntPtrToList)(al, (*IntPtrFromCharStar)((char*) (*stringlist)[i].toLatin1().constData()));
		}
		m->var().s_voidp = al;
		m->next();

		if (m->type().isStack()) {
			delete stringlist;
		}

	}
	break;
      default:
	m->unsupported();
	break;
    }
}

#if QT_VERSION >= 0x40300
void marshall_QListWizardButton(Marshall *m) {
    switch(m->action()) {
      case Marshall::FromObject:
	{
	    if (m->var().s_class == 0) {
		m->item().s_class = 0;
		return;
	    }
	    void* list = m->var().s_voidp;
	    void* valuelist = (*ListWizardButtonToQListWizardButton)(list);
	    m->item().s_voidp = valuelist;
	    m->next();

	    (*FreeGCHandle)(m->var().s_voidp);

		/*if (m->cleanup()) {
			delete valuelist;
	    }*/
	}
	break;
      case Marshall::ToObject:
	{
		// not needed yet
		printf("Marshalling QList<QWizard::WizardButton> not yet implemented\n");
	}
	break;
      default:
	m->unsupported();
	break;
    }
}
#endif

void marshall_QListInt(Marshall *m) {
    switch(m->action()) {
      case Marshall::FromObject:
	{
	    if (m->var().s_class == 0) {
		m->item().s_class = 0;
		return;
	    }
	    void* list = m->var().s_voidp;
	    void* valuelist = (*ListIntToQListInt)(list);
	    m->item().s_voidp = valuelist;
	    m->next();

	    (*FreeGCHandle)(m->var().s_voidp);

		/*if (m->cleanup()) {
			delete valuelist;
	    }*/
	}
	break;
      case Marshall::ToObject:
	{
	    QList<int> *valuelist = (QList<int>*)m->item().s_voidp;
	    if(!valuelist) {
		m->var().s_voidp = 0;
		break;
	    }

	    void* av = (*ConstructList)("System.Int32");

		for (QList<int>::iterator i = valuelist->begin(); i != valuelist->end(); ++i )
		{
		    (*AddIntToListInt)(av, (int) *i);
		}
		
	    m->var().s_voidp = av;
		m->next();

		if (m->type().isStack()) {
			delete valuelist;
		}
	}
	break;
      default:
	m->unsupported();
	break;
    }
}

void marshall_QListConstCharP(Marshall *m) {
	switch (m->action()) {
    case Marshall::FromObject:
	{
		m->unsupported();
	}
	break;
	case Marshall::ToObject:
	{
		QList<const char*> *list = static_cast<QList<const char*>*>(m->item().s_voidp);
		void* al = (*ConstructList)("System.String");
		for (int i = 0; i < list->size(); i++) {
			(*AddIntPtrToList)(al, (*IntPtrFromCharStar)(const_cast<char*>(list->at(i))));
		}
		m->var().s_voidp = al;
		m->next();
		if (m->type().isStack()) {
			delete list;
		}
	}
	break;
	default:
		m->unsupported();
		break;
	}
}

DEF_LIST_MARSHALLER( QAbstractButtonList, QList<QAbstractButton*>, QAbstractButton )
DEF_LIST_MARSHALLER( QActionGroupList, QList<QActionGroup*>, QActionGroup )
DEF_LIST_MARSHALLER( QActionList, QList<QAction*>, QAction )
DEF_LIST_MARSHALLER( QListWidgetItemList, QList<QListWidgetItem*>, QListWidgetItem )
DEF_LIST_MARSHALLER( QObjectList, QList<QObject*>, QObject )
DEF_LIST_MARSHALLER( QTableWidgetList, QList<QTableWidget*>, QTableWidget )
DEF_LIST_MARSHALLER( QTableWidgetItemList, QList<QTableWidgetItem*>, QTableWidgetItem )
DEF_LIST_MARSHALLER( QTextFrameList, QList<QTextFrame*>, QTextFrame )
DEF_LIST_MARSHALLER( QTreeWidgetItemList, QList<QTreeWidgetItem*>, QTreeWidgetItem )
DEF_LIST_MARSHALLER( QTreeWidgetList, QList<QTreeWidget*>, QTreeWidget )
DEF_LIST_MARSHALLER( QWidgetList, QList<QWidget*>, QWidget )
DEF_LIST_MARSHALLER( QWidgetPtrList, QList<QWidget*>, QWidget )

#if QT_VERSION >= 0x40200
DEF_LIST_MARSHALLER( QGraphicsItemList, QList<QGraphicsItem*>, QGraphicsItem )
DEF_LIST_MARSHALLER( QStandardItemList, QList<QStandardItem*>, QStandardItem )
DEF_LIST_MARSHALLER( QUndoStackList, QList<QUndoStack*>, QUndoStack )
#endif

#if QT_VERSION >= 0x40300
DEF_LIST_MARSHALLER( QMdiSubWindowList, QList<QMdiSubWindow*>, QMdiSubWindow )
#endif

void marshall_QRgbVector(Marshall *m)
{
	switch(m->action()) {
		case Marshall::FromObject:
		{
			if (m->var().s_class == 0) {
				m->item().s_class = 0;
				return;
			}
			QList<QRgb>* cpplist = (QList<QRgb>*) (*ListUIntToQListQRgb)(m->var().s_voidp);
			m->item().s_voidp = cpplist;
			m->next();
			
			(*FreeGCHandle)(m->var().s_voidp);

			if (m->cleanup()) {
				delete cpplist;
			}
		}
		break;
      
		case Marshall::ToObject:
		{
			QList<QRgb> *valuelist = (QList<QRgb>*) m->item().s_voidp;
			if (valuelist == 0) {
				break;
			}

			void * al = (*ConstructList)("System.UInt32");

			for (int i=0; i < valuelist->size() ; ++i) {
				(*AddUIntToListUInt)(al, valuelist->at(i));
			}

			m->var().s_voidp = al;
			m->next();

			if (m->type().isStack()) {
				delete valuelist;
			}
			

		}
		break;
      
		default:
			m->unsupported();
		break;
	}
}

DEF_VALUELIST_MARSHALLER( QByteArrayList, QList<QByteArray>, QByteArray )
DEF_VALUELIST_MARSHALLER( QColorVector, QVector<QColor>, QColor )
DEF_VALUELIST_MARSHALLER( QFileInfoList, QFileInfoList, QFileInfo )
// DEF_VALUELIST_MARSHALLER( QHostAddressList, QList<QHostAddress>, QHostAddress )
DEF_VALUELIST_MARSHALLER( QImageTextKeyLangList, QList<QImageTextKeyLang>, QImageTextKeyLang )
DEF_VALUELIST_MARSHALLER( QKeySequenceList, QList<QKeySequence>, QKeySequence )
DEF_VALUELIST_MARSHALLER( QLineFVector, QVector<QLineF>, QLineF )
DEF_VALUELIST_MARSHALLER( QLineVector, QVector<QLine>, QLine )
DEF_VALUELIST_MARSHALLER( QModelIndexList, QList<QModelIndex>, QModelIndex )
DEF_VALUELIST_MARSHALLER( QNetworkAddressEntryList, QList<QNetworkAddressEntry>, QNetworkAddressEntry )
DEF_VALUELIST_MARSHALLER( QNetworkInterfaceList, QList<QNetworkInterface>, QNetworkInterface )
DEF_VALUELIST_MARSHALLER( QPixmapList, QList<QPixmap>, QPixmap )
DEF_VALUELIST_MARSHALLER( QPointFVector, QVector<QPointF>, QPointF )
DEF_VALUELIST_MARSHALLER( QPointVector, QVector<QPoint>, QPoint )
DEF_VALUELIST_MARSHALLER( QPolygonFList, QList<QPolygonF>, QPolygonF )
DEF_VALUELIST_MARSHALLER( QRectFList, QList<QRectF>, QRectF )
DEF_VALUELIST_MARSHALLER( QRectFVector, QVector<QRectF>, QRectF )
DEF_VALUELIST_MARSHALLER( QRectVector, QVector<QRect>, QRect )
// DEF_VALUELIST_MARSHALLER( QRgbVector, QVector<QRgb>, QRgb )
DEF_VALUELIST_MARSHALLER( QTableWidgetSelectionRangeList, QList<QTableWidgetSelectionRange>, QTableWidgetSelectionRange )
DEF_VALUELIST_MARSHALLER( QTextBlockList, QList<QTextBlock>, QTextBlock )
DEF_VALUELIST_MARSHALLER( QTextFormatVector, QVector<QTextFormat>, QTextFormat )
DEF_VALUELIST_MARSHALLER( QTextLayoutFormatRangeList, QList<QTextLayout::FormatRange>, QTextLayout::FormatRange)
DEF_VALUELIST_MARSHALLER( QTextLengthVector, QVector<QTextLength>, QTextLength )
DEF_VALUELIST_MARSHALLER( QUrlList, QList<QUrl>, QUrl )
DEF_VALUELIST_MARSHALLER( QVariantList, QList<QVariant>, QVariant )
DEF_VALUELIST_MARSHALLER( QVariantVector, QVector<QVariant>, QVariant )

#if QT_VERSION >= 0x40300
DEF_VALUELIST_MARSHALLER( QSslCertificateList, QList<QSslCertificate>, QSslCertificate )
DEF_VALUELIST_MARSHALLER( QSslCipherList, QList<QSslCipher>, QSslCipher )
DEF_VALUELIST_MARSHALLER( QSslErrorList, QList<QSslError>, QSslError )
DEF_VALUELIST_MARSHALLER( QXmlStreamEntityDeclarations, QVector<QXmlStreamEntityDeclaration>, QXmlStreamEntityDeclaration )
DEF_VALUELIST_MARSHALLER( QXmlStreamNamespaceDeclarations, QVector<QXmlStreamNamespaceDeclaration>, QXmlStreamNamespaceDeclaration )
DEF_VALUELIST_MARSHALLER( QXmlStreamNotationDeclarations, QVector<QXmlStreamNotationDeclaration>, QXmlStreamNotationDeclaration )
#endif

#if QT_VERSION >= 0x40400
DEF_VALUELIST_MARSHALLER( QNetworkCookieList, QList<QNetworkCookie>, QNetworkCookie )
DEF_VALUELIST_MARSHALLER( QPrinterInfoList, QList<QPrinterInfo>, QPrinterInfo )
#endif

DEF_QPAIR_MARSHALLER( QPair_QHostAddress_int, QHostAddress, int, "Qyoto.QHostAddress", "System.Int32" )

Q_DECL_EXPORT TypeHandler Qyoto_handlers[] = {
    { "bool*", marshall_boolR },
    { "bool&", marshall_boolR },
    { "char*", marshall_charP },
    { "char**", marshall_charP_array },
    { "double*", marshall_doubleR },
    { "double&", marshall_doubleR },
    { "float*", marshall_floatR },
    { "float&", marshall_floatR },
    { "int*", marshall_intR },
    { "int&", marshall_intR },
    { "long*", marshall_longR },
    { "long&", marshall_longR },
    { "QDBusVariant", marshall_QDBusVariant },
    { "QDBusVariant&", marshall_QDBusVariant },
    { "QFileInfoList", marshall_QFileInfoList },
    { "QList<const char*>", marshall_QListConstCharP },
    { "QList<const char*>&", marshall_QListConstCharP },
    { "QList<int>", marshall_QListInt },
    { "QList<int>&", marshall_QListInt },
    { "QList<QAbstractButton*>", marshall_QAbstractButtonList },
    { "QList<QActionGroup*>", marshall_QActionGroupList },
    { "QList<QAction*>", marshall_QActionList },
    { "QList<QAction*>&", marshall_QActionList },
    { "QList<QByteArray>", marshall_QByteArrayList },
    { "QList<QByteArray>*", marshall_QByteArrayList },
    { "QList<QByteArray>&", marshall_QByteArrayList },
   // { "QList<QHostAddress>", marshall_QHostAddressList },
   // { "QList<QHostAddress>&", marshall_QHostAddressList },
    { "QList<QImageTextKeyLang>", marshall_QImageTextKeyLangList },
    { "QList<QKeySequence>", marshall_QKeySequenceList },
    { "QList<QKeySequence>&", marshall_QKeySequenceList },
    { "QList<QListWidgetItem*>", marshall_QListWidgetItemList },
    { "QList<QListWidgetItem*>&", marshall_QListWidgetItemList },
    { "QList<QModelIndex>", marshall_QModelIndexList },
    { "QList<QModelIndex>&", marshall_QModelIndexList },
    { "QList<QNetworkAddressEntry>", marshall_QNetworkAddressEntryList },
    { "QList<QNetworkInterface>", marshall_QNetworkInterfaceList },
    { "QList<QObject*>", marshall_QObjectList },
    { "QList<QObject*>&", marshall_QObjectList },
    { "QList<QPixmap>", marshall_QPixmapList },
    { "QList<QPolygonF>", marshall_QPolygonFList },
    { "QList<QRectF>", marshall_QRectFList },
    { "QList<QRectF>&", marshall_QRectFList },
    { "QList<QStandardItem*>", marshall_QStandardItemList },
    { "QList<QStandardItem*>&", marshall_QStandardItemList },
    { "QList<QTableWidgetItem*>", marshall_QTableWidgetItemList },
    { "QList<QTableWidgetItem*>&", marshall_QTableWidgetItemList },
    { "QList<QTableWidgetSelectionRange>", marshall_QTableWidgetSelectionRangeList },
    { "QList<QTextBlock>", marshall_QTextBlockList },
    { "QList<QTextFrame*>", marshall_QTextFrameList },
    { "QList<QTextLayout::FormatRange>", marshall_QTextLayoutFormatRangeList },
    { "QList<QTextLayout::FormatRange>&", marshall_QTextLayoutFormatRangeList },
    { "QList<QTreeWidgetItem*>", marshall_QTreeWidgetItemList },
    { "QList<QTreeWidgetItem*>&", marshall_QTreeWidgetItemList },
    { "QList<QTreeWidget*>&", marshall_QTreeWidgetList },
    { "QList<QUndoStack*>", marshall_QUndoStackList },
    { "QList<QUndoStack*>&", marshall_QUndoStackList },
    { "QList<QUrl>", marshall_QUrlList },
    { "QList<QUrl>&", marshall_QUrlList },
    { "QList<QVariant>", marshall_QVariantList },
    { "QList<QVariant>&", marshall_QVariantList },
    { "QList<QWidget*>", marshall_QWidgetPtrList },
    { "QList<QWidget*>&", marshall_QWidgetPtrList },
    { "QMap<int,QVariant>", marshall_QMapintQVariant },
    { "QMap<QString,QString>", marshall_QMapQStringQString },
    { "QMap<QString,QString>&", marshall_QMapQStringQString },
    { "QMap<QString,QVariant>", marshall_QMapQStringQVariant },
    { "QMap<QString,QVariant>&", marshall_QMapQStringQVariant },
    { "QVariantMap", marshall_QMapQStringQVariant },
    { "QVariantMap&", marshall_QMapQStringQVariant },
    { "QModelIndexList", marshall_QModelIndexList },
    { "QModelIndexList&", marshall_QModelIndexList },
    { "QObjectList", marshall_QObjectList },
    { "QObjectList&", marshall_QObjectList },
    { "QPair<QHostAddress,int>", marshall_QPair_QHostAddress_int },
    { "QPair<QHostAddress,int>&", marshall_QPair_QHostAddress_int },
    { "qreal*", marshall_doubleR },
    { "qreal&", marshall_doubleR },
    { "QStringList", marshall_QStringList },
    { "QStringList*", marshall_QStringList },
    { "QStringList&", marshall_QStringList },
    { "QString", marshall_QString },
    { "QString*", marshall_QString },
    { "QString&", marshall_QString },
    { "QVariantList&", marshall_QVariantList },
    { "QVector<QColor>", marshall_QColorVector },
    { "QVector<QColor>&", marshall_QColorVector },
    { "QVector<QLineF>", marshall_QLineFVector },
    { "QVector<QLineF>&", marshall_QLineFVector },
    { "QVector<QLine>", marshall_QLineVector },
    { "QVector<QLine>&", marshall_QLineVector },
    { "QVector<QPointF>", marshall_QPointFVector },
    { "QVector<QPointF>&", marshall_QPointFVector },
    { "QVector<QPoint>", marshall_QPointVector },
    { "QVector<QPoint>&", marshall_QPointVector },
    { "QVector<QRectF>", marshall_QRectFVector },
    { "QVector<QRectF>&", marshall_QRectFVector },
    { "QVector<QRect>", marshall_QRectVector },
    { "QVector<QRect>&", marshall_QRectVector },
    { "QVector<QRgb>", marshall_QRgbVector },
    { "QVector<QRgb>&", marshall_QRgbVector },
    { "QVector<QTextFormat>", marshall_QTextFormatVector },
    { "QVector<QTextFormat>&", marshall_QTextFormatVector },
    { "QVector<QTextLength>", marshall_QTextLengthVector },
    { "QVector<QTextLength>&", marshall_QTextLengthVector },
    { "QVector<QVariant>", marshall_QVariantVector },
    { "QVector<QVariant>&", marshall_QVariantVector },
    { "QWidgetList", marshall_QWidgetList },
    { "QWidgetList&", marshall_QWidgetList },
    { "short*", marshall_shortR },
    { "short&", marshall_shortR },
    { "signed int*", marshall_intR },
    { "sigend int&", marshall_intR },
    { "signed long*", marshall_longR },
    { "signed long&", marshall_longR },
    { "uchar*", marshall_ucharP},
    { "uint*", marshall_uintR },
    { "uint&", marshall_uintR },
    { "unsigned char*", marshall_ucharP},
    { "unsigned int*", marshall_uintR },
    { "unsigned int&", marshall_uintR },
    { "unsigned long*", marshall_ulongR },
    { "unsigned long&", marshall_ulongR },
    { "unsigned short*", marshall_ushortR },
    { "unsigned short&", marshall_ushortR },
//    { "void**", marshall_voidP_array },
#if QT_VERSION >= 0x40200
    { "QList<QGraphicsItem*>", marshall_QGraphicsItemList },
    { "QList<QGraphicsItem*>&", marshall_QGraphicsItemList },
    { "QList<QStandardItem*>", marshall_QStandardItemList },
    { "QList<QStandardItem*>&", marshall_QStandardItemList },
    { "QList<QUndoStack*>", marshall_QUndoStackList },
    { "QList<QUndoStack*>&", marshall_QUndoStackList },
#endif
#if QT_VERSION >= 0x40300
    { "QList<QMdiSubWindow*>", marshall_QMdiSubWindowList },
    { "QList<QSslCertificate>", marshall_QSslCertificateList },
    { "QList<QSslCertificate>&", marshall_QSslCertificateList },
    { "QList<QSslCipher>", marshall_QSslCipherList },
    { "QList<QSslCipher>&", marshall_QSslCipherList },
    { "QList<QSslError>", marshall_QSslErrorList },
    { "QList<QSslError>&", marshall_QSslErrorList },
    { "QList<QWizard::WizardButton>", marshall_QListWizardButton },
    { "QList<QWizard::WizardButton>&", marshall_QListWizardButton },
    { "QXmlStreamEntityDeclarations", marshall_QXmlStreamEntityDeclarations },
    { "QXmlStreamNamespaceDeclarations", marshall_QXmlStreamNamespaceDeclarations },
    { "QXmlStreamNotationDeclarations", marshall_QXmlStreamNotationDeclarations },
#endif
#if QT_VERSION >= 0x040400
    { "QList<QNetworkCookie>", marshall_QNetworkCookieList },
    { "QList<QNetworkCookie>&", marshall_QNetworkCookieList },
    { "QList<QPrinterInfo>", marshall_QPrinterInfoList },
#endif
    { 0, 0 }
};

QHash<QString,TypeHandler *> qyoto_type_handlers;

void qyoto_install_handlers(TypeHandler *h) {
	while(h->name) {
		qyoto_type_handlers.insert(h->name, h);
		h++;
	}
}

Marshall::HandlerFn getMarshallFn(const SmokeType &type) {
	if (type.elem())
		return marshall_basetype;
	if (!type.name())
		return marshall_void;
	TypeHandler *h = qyoto_type_handlers[type.name()];
	if (h == 0 && type.isConst() && strlen(type.name()) > strlen("const ")) {
    	h = qyoto_type_handlers[type.name() + strlen("const ")];
	}
	
	if(h != 0) {
		return h->fn;
	}

	return marshall_unknown;
}

// kate: space-indent off; mixed-indent off;
