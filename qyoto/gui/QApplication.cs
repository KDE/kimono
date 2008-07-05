//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	/// <remarks> See <see cref="IQApplicationSignals"></see> for signals emitted by QApplication
	/// </remarks>
	[SmokeClass("QApplication")]
	public partial class QApplication : QCoreApplication, IDisposable {
 		protected QApplication(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QApplication), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QApplication() {
			staticInterceptor = new SmokeInvocation(typeof(QApplication), null);
		}
		public enum TypeOf {
			Tty = 0,
			GuiClient = 1,
			GuiServer = 2,
		}
		public enum ColorSpec {
			NormalColor = 0,
			CustomColor = 1,
			ManyColor = 2,
		}
		[Q_PROPERTY("Qt::LayoutDirection", "layoutDirection")]
		public new Qt.LayoutDirection LayoutDirection {
			get { return (Qt.LayoutDirection) interceptor.Invoke("layoutDirection", "layoutDirection()", typeof(Qt.LayoutDirection)); }
			set { interceptor.Invoke("setLayoutDirection$", "setLayoutDirection(Qt::LayoutDirection)", typeof(void), typeof(Qt.LayoutDirection), value); }
		}
		[Q_PROPERTY("QIcon", "windowIcon")]
		public QIcon WindowIcon {
			get { return (QIcon) interceptor.Invoke("windowIcon", "windowIcon()", typeof(QIcon)); }
			set { interceptor.Invoke("setWindowIcon#", "setWindowIcon(QIcon)", typeof(void), typeof(QIcon), value); }
		}
		[Q_PROPERTY("int", "cursorFlashTime")]
		public int CursorFlashTime {
			get { return (int) interceptor.Invoke("cursorFlashTime", "cursorFlashTime()", typeof(int)); }
			set { interceptor.Invoke("setCursorFlashTime$", "setCursorFlashTime(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "doubleClickInterval")]
		public int DoubleClickInterval {
			get { return (int) interceptor.Invoke("doubleClickInterval", "doubleClickInterval()", typeof(int)); }
			set { interceptor.Invoke("setDoubleClickInterval$", "setDoubleClickInterval(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "keyboardInputInterval")]
		public int KeyboardInputInterval {
			get { return (int) interceptor.Invoke("keyboardInputInterval", "keyboardInputInterval()", typeof(int)); }
			set { interceptor.Invoke("setKeyboardInputInterval$", "setKeyboardInputInterval(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "wheelScrollLines")]
		public int WheelScrollLines {
			get { return (int) interceptor.Invoke("wheelScrollLines", "wheelScrollLines()", typeof(int)); }
			set { interceptor.Invoke("setWheelScrollLines$", "setWheelScrollLines(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("QSize", "globalStrut")]
		public QSize GlobalStrut {
			get { return (QSize) interceptor.Invoke("globalStrut", "globalStrut()", typeof(QSize)); }
			set { interceptor.Invoke("setGlobalStrut#", "setGlobalStrut(QSize)", typeof(void), typeof(QSize), value); }
		}
		[Q_PROPERTY("int", "startDragTime")]
		public int StartDragTime {
			get { return (int) interceptor.Invoke("startDragTime", "startDragTime()", typeof(int)); }
			set { interceptor.Invoke("setStartDragTime$", "setStartDragTime(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "startDragDistance")]
		public int StartDragDistance {
			get { return (int) interceptor.Invoke("startDragDistance", "startDragDistance()", typeof(int)); }
			set { interceptor.Invoke("setStartDragDistance$", "setStartDragDistance(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "quitOnLastWindowClosed")]
		public bool QuitOnLastWindowClosed {
			get { return (bool) interceptor.Invoke("quitOnLastWindowClosed", "quitOnLastWindowClosed()", typeof(bool)); }
			set { interceptor.Invoke("setQuitOnLastWindowClosed$", "setQuitOnLastWindowClosed(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "styleSheet")]
		public string StyleSheet {
			get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
			set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
		}
		// bool compressEvent(QEvent* arg1,QObject* arg2,QPostEventList* arg3); >>>> NOT CONVERTED
		public bool IsSessionRestored() {
			return (bool) interceptor.Invoke("isSessionRestored", "isSessionRestored() const", typeof(bool));
		}
		public string SessionId() {
			return (string) interceptor.Invoke("sessionId", "sessionId() const", typeof(string));
		}
		public string SessionKey() {
			return (string) interceptor.Invoke("sessionKey", "sessionKey() const", typeof(string));
		}
		[SmokeMethod("commitData(QSessionManager&)")]
		public virtual void CommitData(QSessionManager sm) {
			interceptor.Invoke("commitData#", "commitData(QSessionManager&)", typeof(void), typeof(QSessionManager), sm);
		}
		[SmokeMethod("saveState(QSessionManager&)")]
		public virtual void SaveState(QSessionManager sm) {
			interceptor.Invoke("saveState#", "saveState(QSessionManager&)", typeof(void), typeof(QSessionManager), sm);
		}
		public void SetInputContext(QInputContext arg1) {
			interceptor.Invoke("setInputContext#", "setInputContext(QInputContext*)", typeof(void), typeof(QInputContext), arg1);
		}
		public QInputContext InputContext() {
			return (QInputContext) interceptor.Invoke("inputContext", "inputContext() const", typeof(QInputContext));
		}
		[SmokeMethod("notify(QObject*, QEvent*)")]
		public override bool Notify(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("notify##", "notify(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		[Q_SLOT("void setStyleSheet(QString)")]
		public void SetStyleSheet(string sheet) {
			interceptor.Invoke("setStyleSheet$", "setStyleSheet(const QString&)", typeof(void), typeof(string), sheet);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		~QApplication() {
			interceptor.Invoke("~QApplication", "~QApplication()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QApplication", "~QApplication()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static QApplication.TypeOf type() {
			return (QApplication.TypeOf) staticInterceptor.Invoke("type", "type()", typeof(QApplication.TypeOf));
		}
		public static QStyle Style() {
			return (QStyle) staticInterceptor.Invoke("style", "style()", typeof(QStyle));
		}
		public static void SetStyle(QStyle arg1) {
			staticInterceptor.Invoke("setStyle#", "setStyle(QStyle*)", typeof(void), typeof(QStyle), arg1);
		}
		public static QStyle SetStyle(string arg1) {
			return (QStyle) staticInterceptor.Invoke("setStyle$", "setStyle(const QString&)", typeof(QStyle), typeof(string), arg1);
		}
		public static int colorSpec() {
			return (int) staticInterceptor.Invoke("colorSpec", "colorSpec()", typeof(int));
		}
		public static void SetColorSpec(int arg1) {
			staticInterceptor.Invoke("setColorSpec$", "setColorSpec(int)", typeof(void), typeof(int), arg1);
		}
		public static QCursor OverrideCursor() {
			return (QCursor) staticInterceptor.Invoke("overrideCursor", "overrideCursor()", typeof(QCursor));
		}
		public static void SetOverrideCursor(QCursor arg1) {
			staticInterceptor.Invoke("setOverrideCursor#", "setOverrideCursor(const QCursor&)", typeof(void), typeof(QCursor), arg1);
		}
		public static void ChangeOverrideCursor(QCursor arg1) {
			staticInterceptor.Invoke("changeOverrideCursor#", "changeOverrideCursor(const QCursor&)", typeof(void), typeof(QCursor), arg1);
		}
		public static void RestoreOverrideCursor() {
			staticInterceptor.Invoke("restoreOverrideCursor", "restoreOverrideCursor()", typeof(void));
		}
		public static QPalette Palette() {
			return (QPalette) staticInterceptor.Invoke("palette", "palette()", typeof(QPalette));
		}
		public static QPalette Palette(QWidget arg1) {
			return (QPalette) staticInterceptor.Invoke("palette#", "palette(const QWidget*)", typeof(QPalette), typeof(QWidget), arg1);
		}
		public static QPalette Palette(string className) {
			return (QPalette) staticInterceptor.Invoke("palette$", "palette(const char*)", typeof(QPalette), typeof(string), className);
		}
		public static void SetPalette(QPalette arg1, string className) {
			staticInterceptor.Invoke("setPalette#$", "setPalette(const QPalette&, const char*)", typeof(void), typeof(QPalette), arg1, typeof(string), className);
		}
		public static void SetPalette(QPalette arg1) {
			staticInterceptor.Invoke("setPalette#", "setPalette(const QPalette&)", typeof(void), typeof(QPalette), arg1);
		}
		public static QFont Font() {
			return (QFont) staticInterceptor.Invoke("font", "font()", typeof(QFont));
		}
		public static QFont Font(QWidget arg1) {
			return (QFont) staticInterceptor.Invoke("font#", "font(const QWidget*)", typeof(QFont), typeof(QWidget), arg1);
		}
		public static QFont Font(string className) {
			return (QFont) staticInterceptor.Invoke("font$", "font(const char*)", typeof(QFont), typeof(string), className);
		}
		public static void SetFont(QFont arg1, string className) {
			staticInterceptor.Invoke("setFont#$", "setFont(const QFont&, const char*)", typeof(void), typeof(QFont), arg1, typeof(string), className);
		}
		public static void SetFont(QFont arg1) {
			staticInterceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), arg1);
		}
		public static QFontMetrics FontMetrics() {
			return (QFontMetrics) staticInterceptor.Invoke("fontMetrics", "fontMetrics()", typeof(QFontMetrics));
		}
		public static List<QWidget> AllWidgets() {
			return (List<QWidget>) staticInterceptor.Invoke("allWidgets", "allWidgets()", typeof(List<QWidget>));
		}
		public static List<QWidget> TopLevelWidgets() {
			return (List<QWidget>) staticInterceptor.Invoke("topLevelWidgets", "topLevelWidgets()", typeof(List<QWidget>));
		}
		public static QDesktopWidget Desktop() {
			return (QDesktopWidget) staticInterceptor.Invoke("desktop", "desktop()", typeof(QDesktopWidget));
		}
		public static QWidget ActivePopupWidget() {
			return (QWidget) staticInterceptor.Invoke("activePopupWidget", "activePopupWidget()", typeof(QWidget));
		}
		public static QWidget ActiveModalWidget() {
			return (QWidget) staticInterceptor.Invoke("activeModalWidget", "activeModalWidget()", typeof(QWidget));
		}
		public static QClipboard Clipboard() {
			return (QClipboard) staticInterceptor.Invoke("clipboard", "clipboard()", typeof(QClipboard));
		}
		public static QWidget FocusWidget() {
			return (QWidget) staticInterceptor.Invoke("focusWidget", "focusWidget()", typeof(QWidget));
		}
		public static QWidget ActiveWindow() {
			return (QWidget) staticInterceptor.Invoke("activeWindow", "activeWindow()", typeof(QWidget));
		}
		public static void SetActiveWindow(QWidget act) {
			staticInterceptor.Invoke("setActiveWindow#", "setActiveWindow(QWidget*)", typeof(void), typeof(QWidget), act);
		}
		public static QWidget WidgetAt(QPoint p) {
			return (QWidget) staticInterceptor.Invoke("widgetAt#", "widgetAt(const QPoint&)", typeof(QWidget), typeof(QPoint), p);
		}
		public static QWidget WidgetAt(int x, int y) {
			return (QWidget) staticInterceptor.Invoke("widgetAt$$", "widgetAt(int, int)", typeof(QWidget), typeof(int), x, typeof(int), y);
		}
		public static QWidget TopLevelAt(QPoint p) {
			return (QWidget) staticInterceptor.Invoke("topLevelAt#", "topLevelAt(const QPoint&)", typeof(QWidget), typeof(QPoint), p);
		}
		public static QWidget TopLevelAt(int x, int y) {
			return (QWidget) staticInterceptor.Invoke("topLevelAt$$", "topLevelAt(int, int)", typeof(QWidget), typeof(int), x, typeof(int), y);
		}
		public static void SyncX() {
			staticInterceptor.Invoke("syncX", "syncX()", typeof(void));
		}
		public static void Beep() {
			staticInterceptor.Invoke("beep", "beep()", typeof(void));
		}
		public static void Alert(QWidget widget, int duration) {
			staticInterceptor.Invoke("alert#$", "alert(QWidget*, int)", typeof(void), typeof(QWidget), widget, typeof(int), duration);
		}
		public static void Alert(QWidget widget) {
			staticInterceptor.Invoke("alert#", "alert(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		public static uint KeyboardModifiers() {
			return (uint) staticInterceptor.Invoke("keyboardModifiers", "keyboardModifiers()", typeof(uint));
		}
		public static uint MouseButtons() {
			return (uint) staticInterceptor.Invoke("mouseButtons", "mouseButtons()", typeof(uint));
		}
		public static void SetDesktopSettingsAware(bool arg1) {
			staticInterceptor.Invoke("setDesktopSettingsAware$", "setDesktopSettingsAware(bool)", typeof(void), typeof(bool), arg1);
		}
		public static bool DesktopSettingsAware() {
			return (bool) staticInterceptor.Invoke("desktopSettingsAware", "desktopSettingsAware()", typeof(bool));
		}
		public static bool IsRightToLeft() {
			return (bool) staticInterceptor.Invoke("isRightToLeft", "isRightToLeft()", typeof(bool));
		}
		public static bool IsLeftToRight() {
			return (bool) staticInterceptor.Invoke("isLeftToRight", "isLeftToRight()", typeof(bool));
		}
		public static bool IsEffectEnabled(Qt.UIEffect arg1) {
			return (bool) staticInterceptor.Invoke("isEffectEnabled$", "isEffectEnabled(Qt::UIEffect)", typeof(bool), typeof(Qt.UIEffect), arg1);
		}
		public static void SetEffectEnabled(Qt.UIEffect arg1, bool enable) {
			staticInterceptor.Invoke("setEffectEnabled$$", "setEffectEnabled(Qt::UIEffect, bool)", typeof(void), typeof(Qt.UIEffect), arg1, typeof(bool), enable);
		}
		public static void SetEffectEnabled(Qt.UIEffect arg1) {
			staticInterceptor.Invoke("setEffectEnabled$", "setEffectEnabled(Qt::UIEffect)", typeof(void), typeof(Qt.UIEffect), arg1);
		}
		public static QLocale KeyboardInputLocale() {
			return (QLocale) staticInterceptor.Invoke("keyboardInputLocale", "keyboardInputLocale()", typeof(QLocale));
		}
		public static Qt.LayoutDirection KeyboardInputDirection() {
			return (Qt.LayoutDirection) staticInterceptor.Invoke("keyboardInputDirection", "keyboardInputDirection()", typeof(Qt.LayoutDirection));
		}
		public static new int Exec() {
			int result = (int) staticInterceptor.Invoke("exec", "exec()", typeof(int));
			Qyoto.SetApplicationTerminated();
			return result;
		}
		public static void CloseAllWindows() {
			staticInterceptor.Invoke("closeAllWindows", "closeAllWindows()", typeof(void));
		}
		public static void AboutQt() {
			staticInterceptor.Invoke("aboutQt", "aboutQt()", typeof(void));
		}
		protected new IQApplicationSignals Emit {
			get { return (IQApplicationSignals) Q_EMIT; }
		}
	}

	public interface IQApplicationSignals : IQCoreApplicationSignals {
		[Q_SIGNAL("void lastWindowClosed()")]
		void LastWindowClosed();
		[Q_SIGNAL("void focusChanged(QWidget*, QWidget*)")]
		void FocusChanged(QWidget old, QWidget now);
		[Q_SIGNAL("void commitDataRequest(QSessionManager)")]
		void CommitDataRequest(QSessionManager sessionManager);
		[Q_SIGNAL("void saveStateRequest(QSessionManager)")]
		void SaveStateRequest(QSessionManager sessionManager);
	}
}
