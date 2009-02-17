//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQMdiAreaSignals"></see> for signals emitted by QMdiArea
    /// </remarks>
    [SmokeClass("QMdiArea")]
    public class QMdiArea : QAbstractScrollArea, IDisposable {
        protected QMdiArea(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QMdiArea), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QMdiArea() {
            staticInterceptor = new SmokeInvocation(typeof(QMdiArea), null);
        }
        public enum AreaOption {
            DontMaximizeSubWindowOnActivation = 0x1,
        }
        public enum WindowOrder {
            CreationOrder = 0,
            StackingOrder = 1,
            ActivationHistoryOrder = 2,
        }
        public enum ViewMode {
            SubWindowView = 0,
            TabbedView = 1,
        }
        [Q_PROPERTY("QBrush", "background")]
        public QBrush Background {
            get { return (QBrush) interceptor.Invoke("background", "background()", typeof(QBrush)); }
            set { interceptor.Invoke("setBackground#", "setBackground(QBrush)", typeof(void), typeof(QBrush), value); }
        }
        [Q_PROPERTY("QMdiArea::WindowOrder", "activationOrder")]
        public QMdiArea.WindowOrder ActivationOrder {
            get { return (QMdiArea.WindowOrder) interceptor.Invoke("activationOrder", "activationOrder()", typeof(QMdiArea.WindowOrder)); }
            set { interceptor.Invoke("setActivationOrder$", "setActivationOrder(QMdiArea::WindowOrder)", typeof(void), typeof(QMdiArea.WindowOrder), value); }
        }
        [Q_PROPERTY("QMdiArea::ViewMode", "viewMode")]
        public QMdiArea.ViewMode viewMode {
            get { return (QMdiArea.ViewMode) interceptor.Invoke("viewMode", "viewMode()", typeof(QMdiArea.ViewMode)); }
            set { interceptor.Invoke("setViewMode$", "setViewMode(QMdiArea::ViewMode)", typeof(void), typeof(QMdiArea.ViewMode), value); }
        }
        [Q_PROPERTY("bool", "documentMode")]
        public bool DocumentMode {
            get { return (bool) interceptor.Invoke("documentMode", "documentMode()", typeof(bool)); }
            set { interceptor.Invoke("setDocumentMode$", "setDocumentMode(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("QTabWidget::TabShape", "tabShape")]
        public QTabWidget.TabShape TabShape {
            get { return (QTabWidget.TabShape) interceptor.Invoke("tabShape", "tabShape()", typeof(QTabWidget.TabShape)); }
            set { interceptor.Invoke("setTabShape$", "setTabShape(QTabWidget::TabShape)", typeof(void), typeof(QTabWidget.TabShape), value); }
        }
        [Q_PROPERTY("QTabWidget::TabPosition", "tabPosition")]
        public QTabWidget.TabPosition TabPosition {
            get { return (QTabWidget.TabPosition) interceptor.Invoke("tabPosition", "tabPosition()", typeof(QTabWidget.TabPosition)); }
            set { interceptor.Invoke("setTabPosition$", "setTabPosition(QTabWidget::TabPosition)", typeof(void), typeof(QTabWidget.TabPosition), value); }
        }
        public QMdiArea(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QMdiArea#", "QMdiArea(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QMdiArea() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QMdiArea", "QMdiArea()", typeof(void));
        }
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        [SmokeMethod("minimumSizeHint() const")]
        public override QSize MinimumSizeHint() {
            return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
        }
        public QMdiSubWindow CurrentSubWindow() {
            return (QMdiSubWindow) interceptor.Invoke("currentSubWindow", "currentSubWindow() const", typeof(QMdiSubWindow));
        }
        public QMdiSubWindow ActiveSubWindow() {
            return (QMdiSubWindow) interceptor.Invoke("activeSubWindow", "activeSubWindow() const", typeof(QMdiSubWindow));
        }
        public List<QMdiSubWindow> SubWindowList(QMdiArea.WindowOrder order) {
            return (List<QMdiSubWindow>) interceptor.Invoke("subWindowList$", "subWindowList(QMdiArea::WindowOrder) const", typeof(List<QMdiSubWindow>), typeof(QMdiArea.WindowOrder), order);
        }
        public List<QMdiSubWindow> SubWindowList() {
            return (List<QMdiSubWindow>) interceptor.Invoke("subWindowList", "subWindowList() const", typeof(List<QMdiSubWindow>));
        }
        public QMdiSubWindow AddSubWindow(QWidget widget, uint flags) {
            return (QMdiSubWindow) interceptor.Invoke("addSubWindow#$", "addSubWindow(QWidget*, Qt::WindowFlags)", typeof(QMdiSubWindow), typeof(QWidget), widget, typeof(uint), flags);
        }
        public QMdiSubWindow AddSubWindow(QWidget widget) {
            return (QMdiSubWindow) interceptor.Invoke("addSubWindow#", "addSubWindow(QWidget*)", typeof(QMdiSubWindow), typeof(QWidget), widget);
        }
        public void RemoveSubWindow(QWidget widget) {
            interceptor.Invoke("removeSubWindow#", "removeSubWindow(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        public void SetOption(QMdiArea.AreaOption option, bool on) {
            interceptor.Invoke("setOption$$", "setOption(QMdiArea::AreaOption, bool)", typeof(void), typeof(QMdiArea.AreaOption), option, typeof(bool), on);
        }
        public void SetOption(QMdiArea.AreaOption option) {
            interceptor.Invoke("setOption$", "setOption(QMdiArea::AreaOption)", typeof(void), typeof(QMdiArea.AreaOption), option);
        }
        public bool TestOption(QMdiArea.AreaOption opton) {
            return (bool) interceptor.Invoke("testOption$", "testOption(QMdiArea::AreaOption) const", typeof(bool), typeof(QMdiArea.AreaOption), opton);
        }
        [Q_SLOT("void setActiveSubWindow(QMdiSubWindow*)")]
        public void SetActiveSubWindow(QMdiSubWindow window) {
            interceptor.Invoke("setActiveSubWindow#", "setActiveSubWindow(QMdiSubWindow*)", typeof(void), typeof(QMdiSubWindow), window);
        }
        [Q_SLOT("void tileSubWindows()")]
        public void TileSubWindows() {
            interceptor.Invoke("tileSubWindows", "tileSubWindows()", typeof(void));
        }
        [Q_SLOT("void cascadeSubWindows()")]
        public void CascadeSubWindows() {
            interceptor.Invoke("cascadeSubWindows", "cascadeSubWindows()", typeof(void));
        }
        [Q_SLOT("void closeActiveSubWindow()")]
        public void CloseActiveSubWindow() {
            interceptor.Invoke("closeActiveSubWindow", "closeActiveSubWindow()", typeof(void));
        }
        [Q_SLOT("void closeAllSubWindows()")]
        public void CloseAllSubWindows() {
            interceptor.Invoke("closeAllSubWindows", "closeAllSubWindows()", typeof(void));
        }
        [Q_SLOT("void activateNextSubWindow()")]
        public void ActivateNextSubWindow() {
            interceptor.Invoke("activateNextSubWindow", "activateNextSubWindow()", typeof(void));
        }
        [Q_SLOT("void activatePreviousSubWindow()")]
        public void ActivatePreviousSubWindow() {
            interceptor.Invoke("activatePreviousSubWindow", "activatePreviousSubWindow()", typeof(void));
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        [SmokeMethod("eventFilter(QObject*, QEvent*)")]
        protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
            return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent paintEvent) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), paintEvent);
        }
        [SmokeMethod("childEvent(QChildEvent*)")]
        protected override void ChildEvent(QChildEvent childEvent) {
            interceptor.Invoke("childEvent#", "childEvent(QChildEvent*)", typeof(void), typeof(QChildEvent), childEvent);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent resizeEvent) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), resizeEvent);
        }
        [SmokeMethod("timerEvent(QTimerEvent*)")]
        protected override void TimerEvent(QTimerEvent timerEvent) {
            interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), timerEvent);
        }
        [SmokeMethod("showEvent(QShowEvent*)")]
        protected override void ShowEvent(QShowEvent showEvent) {
            interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), showEvent);
        }
        [SmokeMethod("viewportEvent(QEvent*)")]
        protected override bool ViewportEvent(QEvent arg1) {
            return (bool) interceptor.Invoke("viewportEvent#", "viewportEvent(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        [SmokeMethod("scrollContentsBy(int, int)")]
        protected override void ScrollContentsBy(int dx, int dy) {
            interceptor.Invoke("scrollContentsBy$$", "scrollContentsBy(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
        }
        [Q_SLOT("void setupViewport(QWidget*)")]
        protected new void SetupViewport(QWidget viewport) {
            interceptor.Invoke("setupViewport#", "setupViewport(QWidget*)", typeof(void), typeof(QWidget), viewport);
        }
        ~QMdiArea() {
            interceptor.Invoke("~QMdiArea", "~QMdiArea()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QMdiArea", "~QMdiArea()", typeof(void));
        }
        public event SlotFunc<QMdiSubWindow> SignalSubWindowActivated {
            add { QObject.Connect(this, SIGNAL("subWindowActivated(QMdiSubWindow*)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("subWindowActivated(QMdiSubWindow*)"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQMdiAreaSignals Emit {
            get { return (IQMdiAreaSignals) Q_EMIT; }
        }
    }

    public interface IQMdiAreaSignals : IQAbstractScrollAreaSignals {
        [Q_SIGNAL("void subWindowActivated(QMdiSubWindow*)")]
        void SubWindowActivated(QMdiSubWindow arg1);
    }
}
