//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQApplicationSignals"></see> for signals emitted by QApplication
	[SmokeClass("QApplication")]
	public partial class QApplication : QCoreApplication, IDisposable {
 		protected QApplication(Type dummy) : base((Type) null) {}
		interface IQApplicationProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
			[SmokeMethod("type", "()")]
			QApplication.TypeOf type();
			[SmokeMethod("style", "()")]
			QStyle Style();
			[SmokeMethod("setStyle#", "(QStyle*)")]
			void SetStyle(QStyle arg1);
			[SmokeMethod("setStyle$", "(const QString&)")]
			QStyle SetStyle(string arg1);
			[SmokeMethod("colorSpec", "()")]
			int colorSpec();
			[SmokeMethod("setColorSpec$", "(int)")]
			void SetColorSpec(int arg1);
			[SmokeMethod("overrideCursor", "()")]
			QCursor OverrideCursor();
			[SmokeMethod("setOverrideCursor#", "(const QCursor&)")]
			void SetOverrideCursor(QCursor arg1);
			[SmokeMethod("changeOverrideCursor#", "(const QCursor&)")]
			void ChangeOverrideCursor(QCursor arg1);
			[SmokeMethod("restoreOverrideCursor", "()")]
			void RestoreOverrideCursor();
			[SmokeMethod("palette", "()")]
			QPalette Palette();
			[SmokeMethod("palette#", "(const QWidget*)")]
			QPalette Palette(QWidget arg1);
			[SmokeMethod("palette$", "(const char*)")]
			QPalette Palette(string className);
			[SmokeMethod("setPalette#$", "(const QPalette&, const char*)")]
			void SetPalette(QPalette arg1, string className);
			[SmokeMethod("setPalette#", "(const QPalette&)")]
			void SetPalette(QPalette arg1);
			[SmokeMethod("font", "()")]
			QFont Font();
			[SmokeMethod("font#", "(const QWidget*)")]
			QFont Font(QWidget arg1);
			[SmokeMethod("font$", "(const char*)")]
			QFont Font(string className);
			[SmokeMethod("setFont#$", "(const QFont&, const char*)")]
			void SetFont(QFont arg1, string className);
			[SmokeMethod("setFont#", "(const QFont&)")]
			void SetFont(QFont arg1);
			[SmokeMethod("fontMetrics", "()")]
			QFontMetrics FontMetrics();
			[SmokeMethod("setWindowIcon#", "(const QIcon&)")]
			void SetWindowIcon(QIcon icon);
			[SmokeMethod("windowIcon", "()")]
			QIcon windowIcon();
			[SmokeMethod("allWidgets", "()")]
			List<QWidget> AllWidgets();
			[SmokeMethod("topLevelWidgets", "()")]
			List<QWidget> TopLevelWidgets();
			[SmokeMethod("desktop", "()")]
			QDesktopWidget Desktop();
			[SmokeMethod("activePopupWidget", "()")]
			QWidget ActivePopupWidget();
			[SmokeMethod("activeModalWidget", "()")]
			QWidget ActiveModalWidget();
			[SmokeMethod("clipboard", "()")]
			QClipboard Clipboard();
			[SmokeMethod("focusWidget", "()")]
			QWidget FocusWidget();
			[SmokeMethod("activeWindow", "()")]
			QWidget ActiveWindow();
			[SmokeMethod("setActiveWindow#", "(QWidget*)")]
			void SetActiveWindow(QWidget act);
			[SmokeMethod("widgetAt#", "(const QPoint&)")]
			QWidget WidgetAt(QPoint p);
			[SmokeMethod("widgetAt$$", "(int, int)")]
			QWidget WidgetAt(int x, int y);
			[SmokeMethod("topLevelAt#", "(const QPoint&)")]
			QWidget TopLevelAt(QPoint p);
			[SmokeMethod("topLevelAt$$", "(int, int)")]
			QWidget TopLevelAt(int x, int y);
			[SmokeMethod("syncX", "()")]
			void SyncX();
			[SmokeMethod("beep", "()")]
			void Beep();
			[SmokeMethod("keyboardModifiers", "()")]
			int KeyboardModifiers();
			[SmokeMethod("mouseButtons", "()")]
			int MouseButtons();
			[SmokeMethod("setDesktopSettingsAware$", "(bool)")]
			void SetDesktopSettingsAware(bool arg1);
			[SmokeMethod("desktopSettingsAware", "()")]
			bool DesktopSettingsAware();
			[SmokeMethod("setCursorFlashTime$", "(int)")]
			void SetCursorFlashTime(int arg1);
			[SmokeMethod("cursorFlashTime", "()")]
			int cursorFlashTime();
			[SmokeMethod("setDoubleClickInterval$", "(int)")]
			void SetDoubleClickInterval(int arg1);
			[SmokeMethod("doubleClickInterval", "()")]
			int doubleClickInterval();
			[SmokeMethod("setKeyboardInputInterval$", "(int)")]
			void SetKeyboardInputInterval(int arg1);
			[SmokeMethod("keyboardInputInterval", "()")]
			int keyboardInputInterval();
			[SmokeMethod("setWheelScrollLines$", "(int)")]
			void SetWheelScrollLines(int arg1);
			[SmokeMethod("wheelScrollLines", "()")]
			int wheelScrollLines();
			[SmokeMethod("setGlobalStrut#", "(const QSize&)")]
			void SetGlobalStrut(QSize arg1);
			[SmokeMethod("globalStrut", "()")]
			QSize globalStrut();
			[SmokeMethod("setStartDragTime$", "(int)")]
			void SetStartDragTime(int ms);
			[SmokeMethod("startDragTime", "()")]
			int startDragTime();
			[SmokeMethod("setStartDragDistance$", "(int)")]
			void SetStartDragDistance(int l);
			[SmokeMethod("startDragDistance", "()")]
			int startDragDistance();
			[SmokeMethod("setLayoutDirection$", "(Qt::LayoutDirection)")]
			void SetLayoutDirection(Qt.LayoutDirection direction);
			[SmokeMethod("layoutDirection", "()")]
			Qt.LayoutDirection layoutDirection();
			[SmokeMethod("isRightToLeft", "()")]
			bool IsRightToLeft();
			[SmokeMethod("isLeftToRight", "()")]
			bool IsLeftToRight();
			[SmokeMethod("isEffectEnabled$", "(Qt::UIEffect)")]
			bool IsEffectEnabled(Qt.UIEffect arg1);
			[SmokeMethod("setEffectEnabled$$", "(Qt::UIEffect, bool)")]
			void SetEffectEnabled(Qt.UIEffect arg1, bool enable);
			[SmokeMethod("setEffectEnabled$", "(Qt::UIEffect)")]
			void SetEffectEnabled(Qt.UIEffect arg1);
			[SmokeMethod("keyboardInputLocale", "()")]
			QLocale KeyboardInputLocale();
			[SmokeMethod("keyboardInputDirection", "()")]
			Qt.LayoutDirection KeyboardInputDirection();
			[SmokeMethod("exec", "()")]
			int Exec();
			[SmokeMethod("setQuitOnLastWindowClosed$", "(bool)")]
			void SetQuitOnLastWindowClosed(bool quit);
			[SmokeMethod("quitOnLastWindowClosed", "()")]
			bool quitOnLastWindowClosed();
			[SmokeMethod("closeAllWindows", "()")]
			void CloseAllWindows();
			[SmokeMethod("aboutQt", "()")]
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
		public Qt.LayoutDirection LayoutDirection {
			get {
				return Property("layoutDirection").Value<Qt.LayoutDirection>();
			}
			set {
				SetProperty("layoutDirection", QVariant.FromValue<Qt.LayoutDirection>(value));
			}
		}
		[Q_PROPERTY("QIcon", "windowIcon")]
		public QIcon WindowIcon {
			get {
				return Property("windowIcon").Value<QIcon>();
			}
			set {
				SetProperty("windowIcon", QVariant.FromValue<QIcon>(value));
			}
		}
		[Q_PROPERTY("int", "cursorFlashTime")]
		public int CursorFlashTime {
			get {
				return Property("cursorFlashTime").Value<int>();
			}
			set {
				SetProperty("cursorFlashTime", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "doubleClickInterval")]
		public int DoubleClickInterval {
			get {
				return Property("doubleClickInterval").Value<int>();
			}
			set {
				SetProperty("doubleClickInterval", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "keyboardInputInterval")]
		public int KeyboardInputInterval {
			get {
				return Property("keyboardInputInterval").Value<int>();
			}
			set {
				SetProperty("keyboardInputInterval", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "wheelScrollLines")]
		public int WheelScrollLines {
			get {
				return Property("wheelScrollLines").Value<int>();
			}
			set {
				SetProperty("wheelScrollLines", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("QSize", "globalStrut")]
		public QSize GlobalStrut {
			get {
				return Property("globalStrut").Value<QSize>();
			}
			set {
				SetProperty("globalStrut", QVariant.FromValue<QSize>(value));
			}
		}
		[Q_PROPERTY("int", "startDragTime")]
		public int StartDragTime {
			get {
				return Property("startDragTime").Value<int>();
			}
			set {
				SetProperty("startDragTime", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "startDragDistance")]
		public int StartDragDistance {
			get {
				return Property("startDragDistance").Value<int>();
			}
			set {
				SetProperty("startDragDistance", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("bool", "quitOnLastWindowClosed")]
		public bool QuitOnLastWindowClosed {
			get {
				return Property("quitOnLastWindowClosed").Value<bool>();
			}
			set {
				SetProperty("quitOnLastWindowClosed", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("QString", "styleSheet")]
		public string StyleSheet {
			get {
				return Property("styleSheet").Value<string>();
			}
			set {
				SetProperty("styleSheet", QVariant.FromValue<string>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("isSessionRestored", "() const")]
		public bool IsSessionRestored() {
			return ProxyQApplication().IsSessionRestored();
		}
		[SmokeMethod("sessionId", "() const")]
		public string SessionId() {
			return ProxyQApplication().SessionId();
		}
		[SmokeMethod("sessionKey", "() const")]
		public string SessionKey() {
			return ProxyQApplication().SessionKey();
		}
		[SmokeMethod("commitData#", "(QSessionManager&)")]
		public virtual void CommitData(QSessionManager sm) {
			ProxyQApplication().CommitData(sm);
		}
		[SmokeMethod("saveState#", "(QSessionManager&)")]
		public virtual void SaveState(QSessionManager sm) {
			ProxyQApplication().SaveState(sm);
		}
		[SmokeMethod("setInputContext#", "(QInputContext*)")]
		public void SetInputContext(QInputContext arg1) {
			ProxyQApplication().SetInputContext(arg1);
		}
		[SmokeMethod("inputContext", "() const")]
		public QInputContext InputContext() {
			return ProxyQApplication().InputContext();
		}
		[SmokeMethod("notify##", "(QObject*, QEvent*)")]
		public new bool Notify(QObject arg1, QEvent arg2) {
			return ProxyQApplication().Notify(arg1,arg2);
		}
		public static new string Tr(string s, string c) {
			return StaticQApplication().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQApplication().Tr(s);
		}
		public static QApplication.TypeOf type() {
			return StaticQApplication().type();
		}
		public static QStyle Style() {
			return StaticQApplication().Style();
		}
		public static void SetStyle(QStyle arg1) {
			StaticQApplication().SetStyle(arg1);
		}
		public static QStyle SetStyle(string arg1) {
			return StaticQApplication().SetStyle(arg1);
		}
		public static int colorSpec() {
			return StaticQApplication().colorSpec();
		}
		public static void SetColorSpec(int arg1) {
			StaticQApplication().SetColorSpec(arg1);
		}
		public static QCursor OverrideCursor() {
			return StaticQApplication().OverrideCursor();
		}
		public static void SetOverrideCursor(QCursor arg1) {
			StaticQApplication().SetOverrideCursor(arg1);
		}
		public static void ChangeOverrideCursor(QCursor arg1) {
			StaticQApplication().ChangeOverrideCursor(arg1);
		}
		public static void RestoreOverrideCursor() {
			StaticQApplication().RestoreOverrideCursor();
		}
		public static QPalette Palette() {
			return StaticQApplication().Palette();
		}
		public static QPalette Palette(QWidget arg1) {
			return StaticQApplication().Palette(arg1);
		}
		public static QPalette Palette(string className) {
			return StaticQApplication().Palette(className);
		}
		public static void SetPalette(QPalette arg1, string className) {
			StaticQApplication().SetPalette(arg1,className);
		}
		public static void SetPalette(QPalette arg1) {
			StaticQApplication().SetPalette(arg1);
		}
		public static QFont Font() {
			return StaticQApplication().Font();
		}
		public static QFont Font(QWidget arg1) {
			return StaticQApplication().Font(arg1);
		}
		public static QFont Font(string className) {
			return StaticQApplication().Font(className);
		}
		public static void SetFont(QFont arg1, string className) {
			StaticQApplication().SetFont(arg1,className);
		}
		public static void SetFont(QFont arg1) {
			StaticQApplication().SetFont(arg1);
		}
		public static QFontMetrics FontMetrics() {
			return StaticQApplication().FontMetrics();
		}
		public static void SetWindowIcon(QIcon icon) {
			StaticQApplication().SetWindowIcon(icon);
		}
		public static QIcon windowIcon() {
			return StaticQApplication().windowIcon();
		}
		public static List<QWidget> AllWidgets() {
			return StaticQApplication().AllWidgets();
		}
		public static List<QWidget> TopLevelWidgets() {
			return StaticQApplication().TopLevelWidgets();
		}
		public static QDesktopWidget Desktop() {
			return StaticQApplication().Desktop();
		}
		public static QWidget ActivePopupWidget() {
			return StaticQApplication().ActivePopupWidget();
		}
		public static QWidget ActiveModalWidget() {
			return StaticQApplication().ActiveModalWidget();
		}
		public static QClipboard Clipboard() {
			return StaticQApplication().Clipboard();
		}
		public static QWidget FocusWidget() {
			return StaticQApplication().FocusWidget();
		}
		public static QWidget ActiveWindow() {
			return StaticQApplication().ActiveWindow();
		}
		public static void SetActiveWindow(QWidget act) {
			StaticQApplication().SetActiveWindow(act);
		}
		public static QWidget WidgetAt(QPoint p) {
			return StaticQApplication().WidgetAt(p);
		}
		public static QWidget WidgetAt(int x, int y) {
			return StaticQApplication().WidgetAt(x,y);
		}
		public static QWidget TopLevelAt(QPoint p) {
			return StaticQApplication().TopLevelAt(p);
		}
		public static QWidget TopLevelAt(int x, int y) {
			return StaticQApplication().TopLevelAt(x,y);
		}
		public static void SyncX() {
			StaticQApplication().SyncX();
		}
		public static void Beep() {
			StaticQApplication().Beep();
		}
		public static int KeyboardModifiers() {
			return StaticQApplication().KeyboardModifiers();
		}
		public static int MouseButtons() {
			return StaticQApplication().MouseButtons();
		}
		public static void SetDesktopSettingsAware(bool arg1) {
			StaticQApplication().SetDesktopSettingsAware(arg1);
		}
		public static bool DesktopSettingsAware() {
			return StaticQApplication().DesktopSettingsAware();
		}
		public static void SetCursorFlashTime(int arg1) {
			StaticQApplication().SetCursorFlashTime(arg1);
		}
		public static int cursorFlashTime() {
			return StaticQApplication().cursorFlashTime();
		}
		public static void SetDoubleClickInterval(int arg1) {
			StaticQApplication().SetDoubleClickInterval(arg1);
		}
		public static int doubleClickInterval() {
			return StaticQApplication().doubleClickInterval();
		}
		public static void SetKeyboardInputInterval(int arg1) {
			StaticQApplication().SetKeyboardInputInterval(arg1);
		}
		public static int keyboardInputInterval() {
			return StaticQApplication().keyboardInputInterval();
		}
		public static void SetWheelScrollLines(int arg1) {
			StaticQApplication().SetWheelScrollLines(arg1);
		}
		public static int wheelScrollLines() {
			return StaticQApplication().wheelScrollLines();
		}
		public static void SetGlobalStrut(QSize arg1) {
			StaticQApplication().SetGlobalStrut(arg1);
		}
		public static QSize globalStrut() {
			return StaticQApplication().globalStrut();
		}
		public static void SetStartDragTime(int ms) {
			StaticQApplication().SetStartDragTime(ms);
		}
		public static int startDragTime() {
			return StaticQApplication().startDragTime();
		}
		public static void SetStartDragDistance(int l) {
			StaticQApplication().SetStartDragDistance(l);
		}
		public static int startDragDistance() {
			return StaticQApplication().startDragDistance();
		}
		public static void SetLayoutDirection(Qt.LayoutDirection direction) {
			StaticQApplication().SetLayoutDirection(direction);
		}
		public static Qt.LayoutDirection layoutDirection() {
			return StaticQApplication().layoutDirection();
		}
		public static bool IsRightToLeft() {
			return StaticQApplication().IsRightToLeft();
		}
		public static bool IsLeftToRight() {
			return StaticQApplication().IsLeftToRight();
		}
		public static bool IsEffectEnabled(Qt.UIEffect arg1) {
			return StaticQApplication().IsEffectEnabled(arg1);
		}
		public static void SetEffectEnabled(Qt.UIEffect arg1, bool enable) {
			StaticQApplication().SetEffectEnabled(arg1,enable);
		}
		public static void SetEffectEnabled(Qt.UIEffect arg1) {
			StaticQApplication().SetEffectEnabled(arg1);
		}
		public static QLocale KeyboardInputLocale() {
			return StaticQApplication().KeyboardInputLocale();
		}
		public static Qt.LayoutDirection KeyboardInputDirection() {
			return StaticQApplication().KeyboardInputDirection();
		}
		public static new int Exec() {
			int ret = StaticQApplication().Exec();
			Qyoto.DeleteQApp();
			return ret;
		}
		public static void SetQuitOnLastWindowClosed(bool quit) {
			StaticQApplication().SetQuitOnLastWindowClosed(quit);
		}
		public static bool quitOnLastWindowClosed() {
			return StaticQApplication().quitOnLastWindowClosed();
		}
		[Q_SLOT("void closeAllWindows()")]
		public static void CloseAllWindows() {
			StaticQApplication().CloseAllWindows();
		}
		[Q_SLOT("void aboutQt()")]
		public static void AboutQt() {
			StaticQApplication().AboutQt();
		}
		[SmokeMethod("event#", "(QEvent*)")]
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
		[SmokeMethod("~QApplication", "()")]
		private void DisposeQApplication() {
			ProxyQApplication().DisposeQApplication();
		}
		protected new IQApplicationSignals Emit {
			get {
				return (IQApplicationSignals) Q_EMIT;
			}
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
