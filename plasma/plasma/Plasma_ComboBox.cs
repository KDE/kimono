//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    ///  @class ComboBox plasma/widgets/combobox.h <Plasma/Widgets/ComboBox>
    ///  See <see cref="IComboBoxSignals"></see> for signals emitted by ComboBox
    /// </remarks>        <short> Provides a Plasma-themed combo box.  </short>
    [SmokeClass("Plasma::ComboBox")]
    public class ComboBox : QGraphicsProxyWidget, IDisposable {
        protected ComboBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ComboBox), this);
        }
        [Q_PROPERTY("QGraphicsWidget*", "parentWidget")]
        public QGraphicsWidget ParentWidget {
            get { return (QGraphicsWidget) interceptor.Invoke("parentWidget", "parentWidget()", typeof(QGraphicsWidget)); }
        }
        [Q_PROPERTY("QString", "text")]
        public string Text {
            get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
            set { interceptor.Invoke("textChanged$", "textChanged(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "styleSheet")]
        public string StyleSheet {
            get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
            set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("KComboBox*", "nativeWidget")]
        public KComboBox NativeWidget {
            get { return (KComboBox) interceptor.Invoke("nativeWidget", "nativeWidget()", typeof(KComboBox)); }
            set { interceptor.Invoke("setNativeWidget#", "setNativeWidget(KComboBox*)", typeof(void), typeof(KComboBox), value); }
        }
        public ComboBox(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ComboBox#", "ComboBox(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        public ComboBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ComboBox", "ComboBox()", typeof(void));
        }
        /// <remarks>
        ///  Adds an item to the combo box with the given text. The
        ///  item is appended to the list of existing items.
        ///      </remarks>        <short>    Adds an item to the combo box with the given text.</short>
        public void AddItem(string text) {
            interceptor.Invoke("addItem$", "addItem(const QString&)", typeof(void), typeof(string), text);
        }
        [Q_SLOT("void clear()")]
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        [SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
        protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
        protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
            interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
        }
        [SmokeMethod("focusInEvent(QFocusEvent*)")]
        protected override void FocusInEvent(QFocusEvent arg1) {
            interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
        }
        [SmokeMethod("focusOutEvent(QFocusEvent*)")]
        protected override void FocusOutEvent(QFocusEvent arg1) {
            interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
        }
        [SmokeMethod("hoverEnterEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverEnterEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverEnterEvent#", "hoverEnterEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("hoverLeaveEvent(QGraphicsSceneHoverEvent*)")]
        protected override void HoverLeaveEvent(QGraphicsSceneHoverEvent arg1) {
            interceptor.Invoke("hoverLeaveEvent#", "hoverLeaveEvent(QGraphicsSceneHoverEvent*)", typeof(void), typeof(QGraphicsSceneHoverEvent), arg1);
        }
        [SmokeMethod("changeEvent(QEvent*)")]
        protected override void ChangeEvent(QEvent arg1) {
            interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        ~ComboBox() {
            interceptor.Invoke("~ComboBox", "~ComboBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ComboBox", "~ComboBox()", typeof(void));
        }
        protected new IComboBoxSignals Emit {
            get { return (IComboBoxSignals) Q_EMIT; }
        }
    }

    public interface IComboBoxSignals : IQGraphicsProxyWidgetSignals {
        /// <remarks>
        ///  This signal is sent when the user chooses an item in the combobox.
        ///  The item's text is passed.
        ///      </remarks>        <short>    This signal is sent when the user chooses an item in the combobox.</short>
        [Q_SIGNAL("void activated(QString)")]
        void Activated(string text);
        /// <remarks>
        ///  This signal is sent whenever the currentIndex in the combobox changes 
        ///  either through user interaction or programmatically. 
        ///  The item's text is passed.
        ///      </remarks>        <short>    This signal is sent whenever the currentIndex in the combobox changes   either through user interaction or programmatically.</short>
        [Q_SIGNAL("void textChanged(QString)")]
        void TextChanged(string text);
    }
}
