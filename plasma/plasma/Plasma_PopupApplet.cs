//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  Allows applets to automatically 'collapse' into an icon when put in an panel, and is a convenient
    ///  base class for any applet that wishes to use extenders.
    ///  Applets that subclass this class should implement either widget() or graphicsWidget() to return a
    ///  widget that will be displayed in the applet if the applet is in a Planar or MediaCenter form
    ///  factor. If the applet is put in a panel, an icon will be displayed instead, which shows the
    ///  widget in a popup when clicked.
    ///  If you use this class as a base class for your extender using applet, the extender will
    ///  automaticaly be used for the popup; reimplementing graphicsWidget() is unecessary in this case.
    ///  </remarks>        <short>    Allows applets to automatically 'collapse' into an icon when put in an panel, and is a convenient  base class for any applet that wishes to use extenders.</short>
    [SmokeClass("Plasma::PopupApplet")]
    public class PopupApplet : Plasma.Applet, IDisposable {
        protected PopupApplet(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(PopupApplet), this);
        }
        public PopupApplet(QObject parent, List<QVariant> args) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("PopupApplet#?", "PopupApplet(QObject*, const QList<QVariant>&)", typeof(void), typeof(QObject), parent, typeof(List<QVariant>), args);
        }
        /// <remarks>
        ///  @arg icon the icon that has to be displayed when the applet is in a panel.
        ///      </remarks>        <short>    @arg icon the icon that has to be displayed when the applet is in a panel.</short>
        public void SetPopupIcon(QIcon icon) {
            interceptor.Invoke("setPopupIcon#", "setPopupIcon(const QIcon&)", typeof(void), typeof(QIcon), icon);
        }
        /// <remarks>
        ///  @arg icon the icon that has to be displayed when the applet is in a panel.
        ///      </remarks>        <short>    @arg icon the icon that has to be displayed when the applet is in a panel.</short>
        public void SetPopupIcon(string iconName) {
            interceptor.Invoke("setPopupIcon$", "setPopupIcon(const QString&)", typeof(void), typeof(string), iconName);
        }
        /// <remarks>
        /// </remarks>        <return> the icon that is displayed when the applet is in a panel.
        ///      </return>
        ///         <short>   </short>
        public QIcon PopupIcon() {
            return (QIcon) interceptor.Invoke("popupIcon", "popupIcon() const", typeof(QIcon));
        }
        /// <remarks>
        ///  Implement either this function or graphicsWidget().
        /// </remarks>        <return> the widget that will get shown in either a layout, in the applet or in a Dialog,
        ///  depending on the form factor of the applet.
        ///      </return>
        ///         <short>    Implement either this function or graphicsWidget().</short>
        [SmokeMethod("widget()")]
        public virtual QWidget Widget() {
            return (QWidget) interceptor.Invoke("widget", "widget()", typeof(QWidget));
        }
        /// <remarks>
        ///  Implement either this function or widget().
        /// </remarks>        <return> the widget that will get shown in either a layout, in the applet or in a Dialog,
        ///  depending on the form factor of the applet.
        ///      </return>
        ///         <short>    Implement either this function or widget().</short>
        [SmokeMethod("graphicsWidget()")]
        public virtual QGraphicsWidget GraphicsWidget() {
            return (QGraphicsWidget) interceptor.Invoke("graphicsWidget", "graphicsWidget()", typeof(QGraphicsWidget));
        }
        /// <remarks>
        ///  Shows the dialog showing the widget if the applet is in a panel.
        ///  @arg displayTime the time in ms that the popup should be displayed, defaults to 0 which means
        ///  always (until the user closes it again, that is).
        ///      </remarks>        <short>    Shows the dialog showing the widget if the applet is in a panel.</short>
        public void ShowPopup(uint displayTime) {
            interceptor.Invoke("showPopup$", "showPopup(uint)", typeof(void), typeof(uint), displayTime);
        }
        public void ShowPopup() {
            interceptor.Invoke("showPopup", "showPopup()", typeof(void));
        }
        /// <remarks>
        /// </remarks>        <return> the placement of the popup relating to the icon
        ///      </return>
        ///         <short>   </short>
        public Plasma.PopupPlacement popupPlacement() {
            return (Plasma.PopupPlacement) interceptor.Invoke("popupPlacement", "popupPlacement() const", typeof(Plasma.PopupPlacement));
        }
        /// <remarks>
        ///  This event handler can be reimplemented in a subclass to receive an event before the popup is shown or hidden.
        ///  @arg show true if the popup is going to be shown, false if the popup is going to be hidden.
        ///  Note that showing and hiding the popup on click is already done in PopupApplet.
        ///      </remarks>        <short>    This event handler can be reimplemented in a subclass to receive an event before the popup is shown or hidden.</short>
        [SmokeMethod("popupEvent(bool)")]
        public virtual void PopupEvent(bool show) {
            interceptor.Invoke("popupEvent$", "popupEvent(bool)", typeof(void), typeof(bool), show);
        }
        /// <remarks>
        ///  Hides the popup.
        ///      </remarks>        <short>    Hides the popup.</short>
        [Q_SLOT("void hidePopup()")]
        public void HidePopup() {
            interceptor.Invoke("hidePopup", "hidePopup()", typeof(void));
        }
        [SmokeMethod("mousePressEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mousePressEvent#", "mousePressEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("mouseReleaseEvent(QGraphicsSceneMouseEvent*)")]
        protected override void MouseReleaseEvent(QGraphicsSceneMouseEvent arg1) {
            interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QGraphicsSceneMouseEvent*)", typeof(void), typeof(QGraphicsSceneMouseEvent), arg1);
        }
        [SmokeMethod("eventFilter(QObject*, QEvent*)")]
        protected override bool EventFilter(QObject watched, QEvent arg2) {
            return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), watched, typeof(QEvent), arg2);
        }
        [SmokeMethod("itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)")]
        protected override QVariant ItemChange(QGraphicsItem.GraphicsItemChange change, QVariant value) {
            return (QVariant) interceptor.Invoke("itemChange$#", "itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)", typeof(QVariant), typeof(QGraphicsItem.GraphicsItemChange), change, typeof(QVariant), value);
        }
        ~PopupApplet() {
            interceptor.Invoke("~PopupApplet", "~PopupApplet()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~PopupApplet", "~PopupApplet()", typeof(void));
        }
        protected new IPopupAppletSignals Emit {
            get { return (IPopupAppletSignals) Q_EMIT; }
        }
    }

    public interface IPopupAppletSignals : Plasma.IAppletSignals {
    }
}