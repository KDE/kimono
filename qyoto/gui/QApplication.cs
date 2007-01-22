//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections;
	using System.Text;

	/// See <see cref="IQApplicationSignals"></see> for signals emitted by QApplication
	[SmokeClass("QApplication")]
	public partial class QApplication : QCoreApplication, IDisposable {
 		protected QApplication(Type dummy) : base((Type) null) {}
		interface IQApplicationProxy {
			string Tr(string s, string c);
			string Tr(string s);
			QApplication.E_Type type();
			QStyle Style();
			void SetStyle(QStyle arg1);
			QStyle SetStyle(string arg1);
			int colorSpec();
			void SetColorSpec(int arg1);
			QCursor OverrideCursor();
			void SetOverrideCursor(QCursor arg1);
			void ChangeOverrideCursor(QCursor arg1);
			void RestoreOverrideCursor();
			QPalette Palette();
			QPalette Palette(QWidget arg1);
			QPalette Palette(string className);
			void SetPalette(QPalette arg1, string className);
			void SetPalette(QPalette arg1);
			QFont Font();
			QFont Font(QWidget arg1);
			QFont Font(string className);
			void SetFont(QFont arg1, string className);
			void SetFont(QFont arg1);
			QFontMetrics FontMetrics();
			void SetWindowIcon(QIcon icon);
			QIcon WindowIcon();
			ArrayList AllWidgets();
			ArrayList TopLevelWidgets();
			QDesktopWidget Desktop();
			QWidget ActivePopupWidget();
			QWidget ActiveModalWidget();
			QClipboard Clipboard();
			QWidget FocusWidget();
			QWidget ActiveWindow();
			void SetActiveWindow(QWidget act);
			QWidget WidgetAt(QPoint p);
			QWidget WidgetAt(int x, int y);
			QWidget TopLevelAt(QPoint p);
			QWidget TopLevelAt(int x, int y);
			void SyncX();
			void Beep();
			int KeyboardModifiers();
			int MouseButtons();
			void SetDesktopSettingsAware(bool arg1);
			bool DesktopSettingsAware();
			void SetCursorFlashTime(int arg1);
			int CursorFlashTime();
			void SetDoubleClickInterval(int arg1);
			int DoubleClickInterval();
			void SetKeyboardInputInterval(int arg1);
			int KeyboardInputInterval();
			void SetWheelScrollLines(int arg1);
			int WheelScrollLines();
			void SetGlobalStrut(QSize arg1);
			QSize GlobalStrut();
			void SetStartDragTime(int ms);
			int StartDragTime();
			void SetStartDragDistance(int l);
			int StartDragDistance();
			void SetLayoutDirection(Qt.LayoutDirection direction);
			Qt.LayoutDirection LayoutDirection();
			bool IsRightToLeft();
			bool IsLeftToRight();
			bool IsEffectEnabled(Qt.UIEffect arg1);
			void SetEffectEnabled(Qt.UIEffect arg1, bool enable);
			void SetEffectEnabled(Qt.UIEffect arg1);
			QLocale KeyboardInputLocale();
			Qt.LayoutDirection KeyboardInputDirection();
			int Exec();
			void SetQuitOnLastWindowClosed(bool quit);
			bool QuitOnLastWindowClosed();
			void CloseAllWindows();
			void AboutQt();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QApplication), this);
			_interceptor = (QApplication) realProxy.GetTransparentProxy();
		}
		private QApplication ProxyQApplication() {
			return (QApplication) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QApplication() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQApplicationProxy), null);
			_staticInterceptor = (IQApplicationProxy) realProxy.GetTransparentProxy();
		}
		private static IQApplicationProxy StaticQApplication() {
			return (IQApplicationProxy) _staticInterceptor;
		}

		public enum E_Type {
			Tty = 0,
			GuiClient = 1,
			GuiServer = 2,
		}
		public enum ColorSpec {
			NormalColor = 0,
			CustomColor = 1,
			ManyColor = 2,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("isSessionRestored() const")]
		public bool IsSessionRestored() {
			return ProxyQApplication().IsSessionRestored();
		}
		[SmokeMethod("sessionId() const")]
		public string SessionId() {
			return ProxyQApplication().SessionId();
		}
		[SmokeMethod("sessionKey() const")]
		public string SessionKey() {
			return ProxyQApplication().SessionKey();
		}
		[SmokeMethod("commitData(QSessionManager&)")]
		public virtual void CommitData(QSessionManager sm) {
			ProxyQApplication().CommitData(sm);
		}
		[SmokeMethod("saveState(QSessionManager&)")]
		public virtual void SaveState(QSessionManager sm) {
			ProxyQApplication().SaveState(sm);
		}
		[SmokeMethod("setInputContext(QInputContext*)")]
		public void SetInputContext(QInputContext arg1) {
			ProxyQApplication().SetInputContext(arg1);
		}
		[SmokeMethod("inputContext() const")]
		public QInputContext InputContext() {
			return ProxyQApplication().InputContext();
		}
		[SmokeMethod("notify(QObject*, QEvent*)")]
		public new bool Notify(QObject arg1, QEvent arg2) {
			return ProxyQApplication().Notify(arg1,arg2);
		}
		[SmokeMethod("styleSheet() const")]
		public string StyleSheet() {
			return ProxyQApplication().StyleSheet();
		}
		[SmokeMethod("setStyleSheet(const QString&)")]
		public void SetStyleSheet(string sheet) {
			ProxyQApplication().SetStyleSheet(sheet);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQApplication().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQApplication().Tr(s);
		}
		[SmokeMethod("type()")]
		public static QApplication.E_Type type() {
			return StaticQApplication().type();
		}
		[SmokeMethod("style()")]
		public static QStyle Style() {
			return StaticQApplication().Style();
		}
		[SmokeMethod("setStyle(QStyle*)")]
		public static void SetStyle(QStyle arg1) {
			StaticQApplication().SetStyle(arg1);
		}
		[SmokeMethod("setStyle(const QString&)")]
		public static QStyle SetStyle(string arg1) {
			return StaticQApplication().SetStyle(arg1);
		}
		[SmokeMethod("colorSpec()")]
		public static int colorSpec() {
			return StaticQApplication().colorSpec();
		}
		[SmokeMethod("setColorSpec(int)")]
		public static void SetColorSpec(int arg1) {
			StaticQApplication().SetColorSpec(arg1);
		}
		[SmokeMethod("overrideCursor()")]
		public static QCursor OverrideCursor() {
			return StaticQApplication().OverrideCursor();
		}
		[SmokeMethod("setOverrideCursor(const QCursor&)")]
		public static void SetOverrideCursor(QCursor arg1) {
			StaticQApplication().SetOverrideCursor(arg1);
		}
		[SmokeMethod("changeOverrideCursor(const QCursor&)")]
		public static void ChangeOverrideCursor(QCursor arg1) {
			StaticQApplication().ChangeOverrideCursor(arg1);
		}
		[SmokeMethod("restoreOverrideCursor()")]
		public static void RestoreOverrideCursor() {
			StaticQApplication().RestoreOverrideCursor();
		}
		[SmokeMethod("palette()")]
		public static QPalette Palette() {
			return StaticQApplication().Palette();
		}
		[SmokeMethod("palette(const QWidget*)")]
		public static QPalette Palette(QWidget arg1) {
			return StaticQApplication().Palette(arg1);
		}
		[SmokeMethod("palette(const char*)")]
		public static QPalette Palette(string className) {
			return StaticQApplication().Palette(className);
		}
		[SmokeMethod("setPalette(const QPalette&, const char*)")]
		public static void SetPalette(QPalette arg1, string className) {
			StaticQApplication().SetPalette(arg1,className);
		}
		[SmokeMethod("setPalette(const QPalette&)")]
		public static void SetPalette(QPalette arg1) {
			StaticQApplication().SetPalette(arg1);
		}
		[SmokeMethod("font()")]
		public static QFont Font() {
			return StaticQApplication().Font();
		}
		[SmokeMethod("font(const QWidget*)")]
		public static QFont Font(QWidget arg1) {
			return StaticQApplication().Font(arg1);
		}
		[SmokeMethod("font(const char*)")]
		public static QFont Font(string className) {
			return StaticQApplication().Font(className);
		}
		[SmokeMethod("setFont(const QFont&, const char*)")]
		public static void SetFont(QFont arg1, string className) {
			StaticQApplication().SetFont(arg1,className);
		}
		[SmokeMethod("setFont(const QFont&)")]
		public static void SetFont(QFont arg1) {
			StaticQApplication().SetFont(arg1);
		}
		[SmokeMethod("fontMetrics()")]
		public static QFontMetrics FontMetrics() {
			return StaticQApplication().FontMetrics();
		}
		[SmokeMethod("setWindowIcon(const QIcon&)")]
		public static void SetWindowIcon(QIcon icon) {
			StaticQApplication().SetWindowIcon(icon);
		}
		[SmokeMethod("windowIcon()")]
		public static QIcon WindowIcon() {
			return StaticQApplication().WindowIcon();
		}
		[SmokeMethod("allWidgets()")]
		public static ArrayList AllWidgets() {
			return StaticQApplication().AllWidgets();
		}
		[SmokeMethod("topLevelWidgets()")]
		public static ArrayList TopLevelWidgets() {
			return StaticQApplication().TopLevelWidgets();
		}
		[SmokeMethod("desktop()")]
		public static QDesktopWidget Desktop() {
			return StaticQApplication().Desktop();
		}
		[SmokeMethod("activePopupWidget()")]
		public static QWidget ActivePopupWidget() {
			return StaticQApplication().ActivePopupWidget();
		}
		[SmokeMethod("activeModalWidget()")]
		public static QWidget ActiveModalWidget() {
			return StaticQApplication().ActiveModalWidget();
		}
		[SmokeMethod("clipboard()")]
		public static QClipboard Clipboard() {
			return StaticQApplication().Clipboard();
		}
		[SmokeMethod("focusWidget()")]
		public static QWidget FocusWidget() {
			return StaticQApplication().FocusWidget();
		}
		[SmokeMethod("activeWindow()")]
		public static QWidget ActiveWindow() {
			return StaticQApplication().ActiveWindow();
		}
		[SmokeMethod("setActiveWindow(QWidget*)")]
		public static void SetActiveWindow(QWidget act) {
			StaticQApplication().SetActiveWindow(act);
		}
		[SmokeMethod("widgetAt(const QPoint&)")]
		public static QWidget WidgetAt(QPoint p) {
			return StaticQApplication().WidgetAt(p);
		}
		[SmokeMethod("widgetAt(int, int)")]
		public static QWidget WidgetAt(int x, int y) {
			return StaticQApplication().WidgetAt(x,y);
		}
		[SmokeMethod("topLevelAt(const QPoint&)")]
		public static QWidget TopLevelAt(QPoint p) {
			return StaticQApplication().TopLevelAt(p);
		}
		[SmokeMethod("topLevelAt(int, int)")]
		public static QWidget TopLevelAt(int x, int y) {
			return StaticQApplication().TopLevelAt(x,y);
		}
		[SmokeMethod("syncX()")]
		public static void SyncX() {
			StaticQApplication().SyncX();
		}
		[SmokeMethod("beep()")]
		public static void Beep() {
			StaticQApplication().Beep();
		}
		[SmokeMethod("keyboardModifiers()")]
		public static int KeyboardModifiers() {
			return StaticQApplication().KeyboardModifiers();
		}
		[SmokeMethod("mouseButtons()")]
		public static int MouseButtons() {
			return StaticQApplication().MouseButtons();
		}
		[SmokeMethod("setDesktopSettingsAware(bool)")]
		public static void SetDesktopSettingsAware(bool arg1) {
			StaticQApplication().SetDesktopSettingsAware(arg1);
		}
		[SmokeMethod("desktopSettingsAware()")]
		public static bool DesktopSettingsAware() {
			return StaticQApplication().DesktopSettingsAware();
		}
		[SmokeMethod("setCursorFlashTime(int)")]
		public static void SetCursorFlashTime(int arg1) {
			StaticQApplication().SetCursorFlashTime(arg1);
		}
		[SmokeMethod("cursorFlashTime()")]
		public static int CursorFlashTime() {
			return StaticQApplication().CursorFlashTime();
		}
		[SmokeMethod("setDoubleClickInterval(int)")]
		public static void SetDoubleClickInterval(int arg1) {
			StaticQApplication().SetDoubleClickInterval(arg1);
		}
		[SmokeMethod("doubleClickInterval()")]
		public static int DoubleClickInterval() {
			return StaticQApplication().DoubleClickInterval();
		}
		[SmokeMethod("setKeyboardInputInterval(int)")]
		public static void SetKeyboardInputInterval(int arg1) {
			StaticQApplication().SetKeyboardInputInterval(arg1);
		}
		[SmokeMethod("keyboardInputInterval()")]
		public static int KeyboardInputInterval() {
			return StaticQApplication().KeyboardInputInterval();
		}
		[SmokeMethod("setWheelScrollLines(int)")]
		public static void SetWheelScrollLines(int arg1) {
			StaticQApplication().SetWheelScrollLines(arg1);
		}
		[SmokeMethod("wheelScrollLines()")]
		public static int WheelScrollLines() {
			return StaticQApplication().WheelScrollLines();
		}
		[SmokeMethod("setGlobalStrut(const QSize&)")]
		public static void SetGlobalStrut(QSize arg1) {
			StaticQApplication().SetGlobalStrut(arg1);
		}
		[SmokeMethod("globalStrut()")]
		public static QSize GlobalStrut() {
			return StaticQApplication().GlobalStrut();
		}
		[SmokeMethod("setStartDragTime(int)")]
		public static void SetStartDragTime(int ms) {
			StaticQApplication().SetStartDragTime(ms);
		}
		[SmokeMethod("startDragTime()")]
		public static int StartDragTime() {
			return StaticQApplication().StartDragTime();
		}
		[SmokeMethod("setStartDragDistance(int)")]
		public static void SetStartDragDistance(int l) {
			StaticQApplication().SetStartDragDistance(l);
		}
		[SmokeMethod("startDragDistance()")]
		public static int StartDragDistance() {
			return StaticQApplication().StartDragDistance();
		}
		[SmokeMethod("setLayoutDirection(Qt::LayoutDirection)")]
		public static void SetLayoutDirection(Qt.LayoutDirection direction) {
			StaticQApplication().SetLayoutDirection(direction);
		}
		[SmokeMethod("layoutDirection()")]
		public static Qt.LayoutDirection LayoutDirection() {
			return StaticQApplication().LayoutDirection();
		}
		[SmokeMethod("isRightToLeft()")]
		public static bool IsRightToLeft() {
			return StaticQApplication().IsRightToLeft();
		}
		[SmokeMethod("isLeftToRight()")]
		public static bool IsLeftToRight() {
			return StaticQApplication().IsLeftToRight();
		}
		[SmokeMethod("isEffectEnabled(Qt::UIEffect)")]
		public static bool IsEffectEnabled(Qt.UIEffect arg1) {
			return StaticQApplication().IsEffectEnabled(arg1);
		}
		[SmokeMethod("setEffectEnabled(Qt::UIEffect, bool)")]
		public static void SetEffectEnabled(Qt.UIEffect arg1, bool enable) {
			StaticQApplication().SetEffectEnabled(arg1,enable);
		}
		[SmokeMethod("setEffectEnabled(Qt::UIEffect)")]
		public static void SetEffectEnabled(Qt.UIEffect arg1) {
			StaticQApplication().SetEffectEnabled(arg1);
		}
		[SmokeMethod("keyboardInputLocale()")]
		public static QLocale KeyboardInputLocale() {
			return StaticQApplication().KeyboardInputLocale();
		}
		[SmokeMethod("keyboardInputDirection()")]
		public static Qt.LayoutDirection KeyboardInputDirection() {
			return StaticQApplication().KeyboardInputDirection();
		}
		[SmokeMethod("exec()")]
		public static new int Exec() {
			int ret = StaticQApplication().Exec();
			Qyoto.DeleteQApp();
			return ret;
		}
		[SmokeMethod("setQuitOnLastWindowClosed(bool)")]
		public static void SetQuitOnLastWindowClosed(bool quit) {
			StaticQApplication().SetQuitOnLastWindowClosed(quit);
		}
		[SmokeMethod("quitOnLastWindowClosed()")]
		public static bool QuitOnLastWindowClosed() {
			return StaticQApplication().QuitOnLastWindowClosed();
		}
		[SmokeMethod("closeAllWindows()")]
		public static void CloseAllWindows() {
			StaticQApplication().CloseAllWindows();
		}
		[SmokeMethod("aboutQt()")]
		public static void AboutQt() {
			StaticQApplication().AboutQt();
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQApplication().Event(arg1);
		}
		// bool compressEvent(QEvent* arg1,QObject* arg2,QPostEventList* arg3); >>>> NOT CONVERTED
		~QApplication() {
			DisposeQApplication();
		}
		public new void Dispose() {
			DisposeQApplication();
		}
		[SmokeMethod("~QApplication()")]
		private void DisposeQApplication() {
			ProxyQApplication().DisposeQApplication();
		}
		protected new IQApplicationSignals Emit() {
			return (IQApplicationSignals) Q_EMIT;
		}
	}

	public interface IQApplicationSignals : IQCoreApplicationSignals {
		[Q_SIGNAL("void lastWindowClosed()")]
		void LastWindowClosed();
		[Q_SIGNAL("void focusChanged(QWidget*, QWidget*)")]
		void FocusChanged(QWidget old, QWidget now);
		[Q_SIGNAL("void commitDataRequest(QSessionManager&)")]
		void CommitDataRequest(QSessionManager sessionManager);
		[Q_SIGNAL("void saveStateRequest(QSessionManager&)")]
		void SaveStateRequest(QSessionManager sessionManager);
	}
}
