//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks> See <see cref="IPushButtonSignals"></see> for signals emitted by PushButton
    /// </remarks>
    [SmokeClass("Plasma::PushButton")]
    public class PushButton : QGraphicsProxyWidget, IDisposable {
        protected PushButton(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(PushButton), this);
        }
        [Q_PROPERTY("QGraphicsWidget*", "parentWidget")]
        public QGraphicsWidget ParentWidget {
            get { return (QGraphicsWidget) interceptor.Invoke("parentWidget", "parentWidget()", typeof(QGraphicsWidget)); }
        }
        [Q_PROPERTY("QString", "text")]
        public string Text {
            get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
            set { interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "image")]
        public string Image {
            get { return (string) interceptor.Invoke("image", "image()", typeof(string)); }
            set { interceptor.Invoke("setImage$", "setImage(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QString", "stylesheet")]
        public string Stylesheet {
            get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
            set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("KPushButton*", "nativeWidget")]
        public KPushButton NativeWidget {
            get { return (KPushButton) interceptor.Invoke("nativeWidget", "nativeWidget()", typeof(KPushButton)); }
        }
        public PushButton(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("PushButton#", "PushButton(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        public PushButton() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("PushButton", "PushButton()", typeof(void));
        }
        [SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
        protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
        }
        ~PushButton() {
            interceptor.Invoke("~PushButton", "~PushButton()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~PushButton", "~PushButton()", typeof(void));
        }
        protected new IPushButtonSignals Emit {
            get { return (IPushButtonSignals) Q_EMIT; }
        }
    }

    public interface IPushButtonSignals : IQGraphicsProxyWidgetSignals {
        [Q_SIGNAL("void clicked()")]
        void Clicked();
    }
}
