//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQDockWidgetSignals"></see> for signals emitted by QDockWidget
    /// </remarks>
    [SmokeClass("QDockWidget")]
    public class QDockWidget : QWidget, IDisposable {
        protected QDockWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDockWidget), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QDockWidget() {
            staticInterceptor = new SmokeInvocation(typeof(QDockWidget), null);
        }
        public enum DockWidgetFeature {
            DockWidgetClosable = 0x01,
            DockWidgetMovable = 0x02,
            DockWidgetFloatable = 0x04,
            DockWidgetVerticalTitleBar = 0x08,
            DockWidgetFeatureMask = 0x0f,
            AllDockWidgetFeatures = DockWidgetClosable|DockWidgetMovable|DockWidgetFloatable,
            NoDockWidgetFeatures = 0x00,
            Reserved = 0xff,
        }
        [Q_PROPERTY("bool", "floating")]
        public bool Floating {
            get { return (bool) interceptor.Invoke("isFloating", "isFloating()", typeof(bool)); }
            set { interceptor.Invoke("setFloating$", "setFloating(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QDockWidget::DockWidgetFeatures", "features")]
        public uint Features {
            get { return (uint) interceptor.Invoke("features", "features()", typeof(uint)); }
            set { interceptor.Invoke("setFeatures$", "setFeatures(QDockWidget::DockWidgetFeatures)", typeof(void), typeof(uint), value); }
        }
        [Q_PROPERTY("Qt::DockWidgetAreas", "allowedAreas")]
        public uint AllowedAreas {
            get { return (uint) interceptor.Invoke("allowedAreas", "allowedAreas()", typeof(uint)); }
            set { interceptor.Invoke("setAllowedAreas$", "setAllowedAreas(Qt::DockWidgetAreas)", typeof(void), typeof(uint), value); }
        }
        [Q_PROPERTY("QString", "windowTitle")]
        public new string WindowTitle {
            get { return (string) interceptor.Invoke("windowTitle", "windowTitle()", typeof(string)); }
            set { interceptor.Invoke("setWindowTitle$", "setWindowTitle(QString)", typeof(void), typeof(string), value); }
        }
        public QDockWidget(string title, QWidget parent, uint flags) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDockWidget$#$", "QDockWidget(const QString&, QWidget*, Qt::WindowFlags)", typeof(void), typeof(string), title, typeof(QWidget), parent, typeof(uint), flags);
        }
        public QDockWidget(string title, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDockWidget$#", "QDockWidget(const QString&, QWidget*)", typeof(void), typeof(string), title, typeof(QWidget), parent);
        }
        public QDockWidget(string title) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDockWidget$", "QDockWidget(const QString&)", typeof(void), typeof(string), title);
        }
        public QDockWidget(QWidget parent, uint flags) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDockWidget#$", "QDockWidget(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), flags);
        }
        public QDockWidget(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDockWidget#", "QDockWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QDockWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDockWidget", "QDockWidget()", typeof(void));
        }
        public QWidget Widget() {
            return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
        }
        public void SetWidget(QWidget widget) {
            interceptor.Invoke("setWidget#", "setWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        public void SetTitleBarWidget(QWidget widget) {
            interceptor.Invoke("setTitleBarWidget#", "setTitleBarWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        public QWidget TitleBarWidget() {
            return (QWidget) interceptor.Invoke("titleBarWidget", "titleBarWidget() const", typeof(QWidget));
        }
        public bool IsAreaAllowed(Qt.DockWidgetArea area) {
            return (bool) interceptor.Invoke("isAreaAllowed$", "isAreaAllowed(Qt::DockWidgetArea) const", typeof(bool), typeof(Qt.DockWidgetArea), area);
        }
        public QAction ToggleViewAction() {
            return (QAction) interceptor.Invoke("toggleViewAction", "toggleViewAction() const", typeof(QAction));
        }
        [SmokeMethod("changeEvent(QEvent*)")]
        protected override void ChangeEvent(QEvent arg1) {
            interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("closeEvent(QCloseEvent*)")]
        protected override void CloseEvent(QCloseEvent arg1) {
            interceptor.Invoke("closeEvent#", "closeEvent(QCloseEvent*)", typeof(void), typeof(QCloseEvent), arg1);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent arg1) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        protected void InitStyleOption(QStyleOptionDockWidget option) {
            interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionDockWidget*) const", typeof(void), typeof(QStyleOptionDockWidget), option);
        }
        ~QDockWidget() {
            interceptor.Invoke("~QDockWidget", "~QDockWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDockWidget", "~QDockWidget()", typeof(void));
        }
        public event SlotFunc<uint> SignalFeaturesChanged {
            add { QObject.Connect(this, SIGNAL("featuresChanged(QDockWidget::DockWidgetFeatures)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("featuresChanged(QDockWidget::DockWidgetFeatures)"), value); }
        }
        public event SlotFunc<bool> SignalTopLevelChanged {
            add { QObject.Connect(this, SIGNAL("topLevelChanged(bool)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("topLevelChanged(bool)"), value); }
        }
        public event SlotFunc<uint> SignalAllowedAreasChanged {
            add { QObject.Connect(this, SIGNAL("allowedAreasChanged(Qt::DockWidgetAreas)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("allowedAreasChanged(Qt::DockWidgetAreas)"), value); }
        }
        public event SlotFunc<bool> SignalVisibilityChanged {
            add { QObject.Connect(this, SIGNAL("visibilityChanged(bool)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("visibilityChanged(bool)"), value); }
        }
        public event SlotFunc<Qt.DockWidgetArea> SignalDockLocationChanged {
            add { QObject.Connect(this, SIGNAL("dockLocationChanged(Qt::DockWidgetArea)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("dockLocationChanged(Qt::DockWidgetArea)"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQDockWidgetSignals Emit {
            get { return (IQDockWidgetSignals) Q_EMIT; }
        }
    }

    public interface IQDockWidgetSignals : IQWidgetSignals {
        [Q_SIGNAL("void featuresChanged(QDockWidget::DockWidgetFeatures)")]
        void FeaturesChanged(uint features);
        [Q_SIGNAL("void topLevelChanged(bool)")]
        void TopLevelChanged(bool topLevel);
        [Q_SIGNAL("void allowedAreasChanged(Qt::DockWidgetAreas)")]
        void AllowedAreasChanged(uint allowedAreas);
        [Q_SIGNAL("void visibilityChanged(bool)")]
        void VisibilityChanged(bool visible);
        [Q_SIGNAL("void dockLocationChanged(Qt::DockWidgetArea)")]
        void DockLocationChanged(Qt.DockWidgetArea area);
    }
}
