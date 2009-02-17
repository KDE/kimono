//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQSystemTrayIconSignals"></see> for signals emitted by QSystemTrayIcon
    /// </remarks>
    [SmokeClass("QSystemTrayIcon")]
    public class QSystemTrayIcon : QObject, IDisposable {
        protected QSystemTrayIcon(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QSystemTrayIcon), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QSystemTrayIcon() {
            staticInterceptor = new SmokeInvocation(typeof(QSystemTrayIcon), null);
        }
        public enum ActivationReason {
            Unknown = 0,
            Context = 1,
            DoubleClick = 2,
            Trigger = 3,
            MiddleClick = 4,
        }
        public enum MessageIcon {
            NoIcon = 0,
            Information = 1,
            Warning = 2,
            Critical = 3,
        }
        [Q_PROPERTY("QString", "toolTip")]
        public string ToolTip {
            get { return (string) interceptor.Invoke("toolTip", "toolTip()", typeof(string)); }
            set { interceptor.Invoke("setToolTip$", "setToolTip(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QIcon", "icon")]
        public QIcon icon {
            get { return (QIcon) interceptor.Invoke("icon", "icon()", typeof(QIcon)); }
            set { interceptor.Invoke("setIcon#", "setIcon(QIcon)", typeof(void), typeof(QIcon), value); }
        }
        [Q_PROPERTY("bool", "visible")]
        public bool Visible {
            get { return (bool) interceptor.Invoke("isVisible", "isVisible()", typeof(bool)); }
            set { interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), value); }
        }
        public QSystemTrayIcon(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSystemTrayIcon#", "QSystemTrayIcon(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QSystemTrayIcon() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSystemTrayIcon", "QSystemTrayIcon()", typeof(void));
        }
        public QSystemTrayIcon(QIcon icon, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSystemTrayIcon##", "QSystemTrayIcon(const QIcon&, QObject*)", typeof(void), typeof(QIcon), icon, typeof(QObject), parent);
        }
        public QSystemTrayIcon(QIcon icon) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSystemTrayIcon#", "QSystemTrayIcon(const QIcon&)", typeof(void), typeof(QIcon), icon);
        }
        public void SetContextMenu(QMenu menu) {
            interceptor.Invoke("setContextMenu#", "setContextMenu(QMenu*)", typeof(void), typeof(QMenu), menu);
        }
        public QMenu ContextMenu() {
            return (QMenu) interceptor.Invoke("contextMenu", "contextMenu() const", typeof(QMenu));
        }
        public void ShowMessage(string title, string msg, QSystemTrayIcon.MessageIcon icon, int msecs) {
            interceptor.Invoke("showMessage$$$$", "showMessage(const QString&, const QString&, QSystemTrayIcon::MessageIcon, int)", typeof(void), typeof(string), title, typeof(string), msg, typeof(QSystemTrayIcon.MessageIcon), icon, typeof(int), msecs);
        }
        public void ShowMessage(string title, string msg, QSystemTrayIcon.MessageIcon icon) {
            interceptor.Invoke("showMessage$$$", "showMessage(const QString&, const QString&, QSystemTrayIcon::MessageIcon)", typeof(void), typeof(string), title, typeof(string), msg, typeof(QSystemTrayIcon.MessageIcon), icon);
        }
        public void ShowMessage(string title, string msg) {
            interceptor.Invoke("showMessage$$", "showMessage(const QString&, const QString&)", typeof(void), typeof(string), title, typeof(string), msg);
        }
        public QRect Geometry() {
            return (QRect) interceptor.Invoke("geometry", "geometry() const", typeof(QRect));
        }
        [Q_SLOT("void setVisible(bool)")]
        public void SetVisible(bool visible) {
            interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), visible);
        }
        [Q_SLOT("void show()")]
        public void Show() {
            interceptor.Invoke("show", "show()", typeof(void));
        }
        [Q_SLOT("void hide()")]
        public void Hide() {
            interceptor.Invoke("hide", "hide()", typeof(void));
        }
        [SmokeMethod("event(QEvent*)")]
        protected new virtual bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        ~QSystemTrayIcon() {
            interceptor.Invoke("~QSystemTrayIcon", "~QSystemTrayIcon()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QSystemTrayIcon", "~QSystemTrayIcon()", typeof(void));
        }
        public event SlotFunc<QSystemTrayIcon.ActivationReason> SignalActivated {
            add { QObject.Connect(this, SIGNAL("activated(QSystemTrayIcon::ActivationReason)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("activated(QSystemTrayIcon::ActivationReason)"), value); }
        }
        public event SlotFunc SignalMessageClicked {
            add { QObject.Connect(this, SIGNAL("messageClicked()"), value); }
            remove { QObject.Disconnect(this, SIGNAL("messageClicked()"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        public static bool IsSystemTrayAvailable() {
            return (bool) staticInterceptor.Invoke("isSystemTrayAvailable", "isSystemTrayAvailable()", typeof(bool));
        }
        public static bool SupportsMessages() {
            return (bool) staticInterceptor.Invoke("supportsMessages", "supportsMessages()", typeof(bool));
        }
        protected new IQSystemTrayIconSignals Emit {
            get { return (IQSystemTrayIconSignals) Q_EMIT; }
        }
    }

    public interface IQSystemTrayIconSignals : IQObjectSignals {
        [Q_SIGNAL("void activated(QSystemTrayIcon::ActivationReason)")]
        void Activated(QSystemTrayIcon.ActivationReason reason);
        [Q_SIGNAL("void messageClicked()")]
        void MessageClicked();
    }
}
