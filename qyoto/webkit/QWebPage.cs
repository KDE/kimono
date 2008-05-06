//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// <remarks> See <see cref="IQWebPageSignals"></see> for signals emitted by QWebPage
	/// </remarks>

	[SmokeClass("QWebPage")]
	public class QWebPage : QObject, IDisposable {
 		protected QWebPage(Type dummy) : base((Type) null) {}


		[SmokeClass("QWebPage::ExtensionOption")]
		public class ExtensionOption : Object {
			protected SmokeInvocation interceptor = null;
			private IntPtr smokeObject;
			protected ExtensionOption(Type dummy) {}
		}


		[SmokeClass("QWebPage::ExtensionReturn")]
		public class ExtensionReturn : Object {
			protected SmokeInvocation interceptor = null;
			private IntPtr smokeObject;
			protected ExtensionReturn(Type dummy) {}
		}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QWebPage), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QWebPage() {
			staticInterceptor = new SmokeInvocation(typeof(QWebPage), null);
		}
		public enum NavigationType {
			NavigationTypeLinkClicked = 0,
			NavigationTypeFormSubmitted = 1,
			NavigationTypeBackOrForward = 2,
			NavigationTypeReload = 3,
			NavigationTypeFormResubmitted = 4,
			NavigationTypeOther = 5,
		}
		public enum WebAction {
			NoWebAction = -1,
			OpenLink = 0,
			OpenLinkInNewWindow = 1,
			OpenFrameInNewWindow = 2,
			DownloadLinkToDisk = 3,
			CopyLinkToClipboard = 4,
			OpenImageInNewWindow = 5,
			DownloadImageToDisk = 6,
			CopyImageToClipboard = 7,
			Back = 8,
			Forward = 9,
			Stop = 10,
			Reload = 11,
			Cut = 12,
			Copy = 13,
			Paste = 14,
			Undo = 15,
			Redo = 16,
			MoveToNextChar = 17,
			MoveToPreviousChar = 18,
			MoveToNextWord = 19,
			MoveToPreviousWord = 20,
			MoveToNextLine = 21,
			MoveToPreviousLine = 22,
			MoveToStartOfLine = 23,
			MoveToEndOfLine = 24,
			MoveToStartOfBlock = 25,
			MoveToEndOfBlock = 26,
			MoveToStartOfDocument = 27,
			MoveToEndOfDocument = 28,
			SelectNextChar = 29,
			SelectPreviousChar = 30,
			SelectNextWord = 31,
			SelectPreviousWord = 32,
			SelectNextLine = 33,
			SelectPreviousLine = 34,
			SelectStartOfLine = 35,
			SelectEndOfLine = 36,
			SelectStartOfBlock = 37,
			SelectEndOfBlock = 38,
			SelectStartOfDocument = 39,
			SelectEndOfDocument = 40,
			DeleteStartOfWord = 41,
			DeleteEndOfWord = 42,
			SetTextDirectionDefault = 43,
			SetTextDirectionLeftToRight = 44,
			SetTextDirectionRightToLeft = 45,
			ToggleBold = 46,
			ToggleItalic = 47,
			ToggleUnderline = 48,
			InspectElement = 49,
			WebActionCount = 50,
		}
		public enum FindFlag {
			FindBackward = 1,
			FindCaseSensitively = 2,
			FindWrapsAroundDocument = 4,
		}
		public enum LinkDelegationPolicy {
			DontDelegateLinks = 0,
			DelegateExternalLinks = 1,
			DelegateAllLinks = 2,
		}
		public enum WebWindowType {
			WebBrowserWindow = 0,
			WebModalDialog = 1,
		}
		public enum Extension {
		}
		[Q_PROPERTY("bool", "modified")]
		public bool Modified {
			get { return (bool) interceptor.Invoke("isModified", "isModified()", typeof(bool)); }
		}
		[Q_PROPERTY("QString", "selectedText")]
		public string SelectedText {
			get { return (string) interceptor.Invoke("selectedText", "selectedText()", typeof(string)); }
		}
		[Q_PROPERTY("QSize", "viewportSize")]
		public QSize ViewportSize {
			get { return (QSize) interceptor.Invoke("viewportSize", "viewportSize()", typeof(QSize)); }
			set { interceptor.Invoke("setViewportSize#", "setViewportSize(QSize)", typeof(void), typeof(QSize), value); }
		}
		[Q_PROPERTY("bool", "forwardUnsupportedContent")]
		public bool ForwardUnsupportedContent {
			get { return (bool) interceptor.Invoke("forwardUnsupportedContent", "forwardUnsupportedContent()", typeof(bool)); }
			set { interceptor.Invoke("setForwardUnsupportedContent$", "setForwardUnsupportedContent(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QWebPage::LinkDelegationPolicy", "linkDelegationPolicy")]
		public QWebPage.LinkDelegationPolicy linkDelegationPolicy {
			get { return (QWebPage.LinkDelegationPolicy) interceptor.Invoke("linkDelegationPolicy", "linkDelegationPolicy()", typeof(QWebPage.LinkDelegationPolicy)); }
			set { interceptor.Invoke("setLinkDelegationPolicy$", "setLinkDelegationPolicy(QWebPage::LinkDelegationPolicy)", typeof(void), typeof(QWebPage.LinkDelegationPolicy), value); }
		}
		[Q_PROPERTY("QPalette", "palette")]
		public QPalette Palette {
			get { return (QPalette) interceptor.Invoke("palette", "palette()", typeof(QPalette)); }
			set { interceptor.Invoke("setPalette#", "setPalette(QPalette)", typeof(void), typeof(QPalette), value); }
		}
		// void setPluginFactory(QWebPluginFactory* arg1); >>>> NOT CONVERTED
		// QWebPluginFactory* pluginFactory(); >>>> NOT CONVERTED
		// bool extension(QWebPage::Extension arg1,const QWebPage::ExtensionOption* arg2,QWebPage::ExtensionReturn* arg3); >>>> NOT CONVERTED
		// bool extension(QWebPage::Extension arg1,const QWebPage::ExtensionOption* arg2); >>>> NOT CONVERTED
		public QWebPage(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWebPage#", "QWebPage(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QWebPage() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWebPage", "QWebPage()", typeof(void));
		}
		public QWebFrame MainFrame() {
			return (QWebFrame) interceptor.Invoke("mainFrame", "mainFrame() const", typeof(QWebFrame));
		}
		public QWebFrame CurrentFrame() {
			return (QWebFrame) interceptor.Invoke("currentFrame", "currentFrame() const", typeof(QWebFrame));
		}
		public QWebHistory History() {
			return (QWebHistory) interceptor.Invoke("history", "history() const", typeof(QWebHistory));
		}
		public QWebSettings Settings() {
			return (QWebSettings) interceptor.Invoke("settings", "settings() const", typeof(QWebSettings));
		}
		public void SetView(QWidget view) {
			interceptor.Invoke("setView#", "setView(QWidget*)", typeof(void), typeof(QWidget), view);
		}
		public QWidget View() {
			return (QWidget) interceptor.Invoke("view", "view() const", typeof(QWidget));
		}
		public QUndoStack UndoStack() {
			return (QUndoStack) interceptor.Invoke("undoStack", "undoStack() const", typeof(QUndoStack));
		}
		public void SetNetworkAccessManager(QNetworkAccessManager manager) {
			interceptor.Invoke("setNetworkAccessManager#", "setNetworkAccessManager(QNetworkAccessManager*)", typeof(void), typeof(QNetworkAccessManager), manager);
		}
		public QNetworkAccessManager NetworkAccessManager() {
			return (QNetworkAccessManager) interceptor.Invoke("networkAccessManager", "networkAccessManager() const", typeof(QNetworkAccessManager));
		}
		public ulong TotalBytes() {
			return (ulong) interceptor.Invoke("totalBytes", "totalBytes() const", typeof(ulong));
		}
		public ulong BytesReceived() {
			return (ulong) interceptor.Invoke("bytesReceived", "bytesReceived() const", typeof(ulong));
		}
		public QAction Action(QWebPage.WebAction action) {
			return (QAction) interceptor.Invoke("action$", "action(QWebPage::WebAction) const", typeof(QAction), typeof(QWebPage.WebAction), action);
		}
		[SmokeMethod("triggerAction(QWebPage::WebAction, bool)")]
		public virtual void TriggerAction(QWebPage.WebAction action, bool arg2) {
			interceptor.Invoke("triggerAction$$", "triggerAction(QWebPage::WebAction, bool)", typeof(void), typeof(QWebPage.WebAction), action, typeof(bool), arg2);
		}
		[SmokeMethod("triggerAction(QWebPage::WebAction)")]
		public virtual void TriggerAction(QWebPage.WebAction action) {
			interceptor.Invoke("triggerAction$", "triggerAction(QWebPage::WebAction)", typeof(void), typeof(QWebPage.WebAction), action);
		}
		[SmokeMethod("event(QEvent*)")]
		public override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		public bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		public new QVariant InputMethodQuery(Qt.InputMethodQuery property) {
			return (QVariant) interceptor.Invoke("inputMethodQuery$", "inputMethodQuery(Qt::InputMethodQuery) const", typeof(QVariant), typeof(Qt.InputMethodQuery), property);
		}
		public bool FindText(string subString, uint options) {
			return (bool) interceptor.Invoke("findText$$", "findText(const QString&, QWebPage::FindFlags)", typeof(bool), typeof(string), subString, typeof(uint), options);
		}
		public bool FindText(string subString) {
			return (bool) interceptor.Invoke("findText$", "findText(const QString&)", typeof(bool), typeof(string), subString);
		}
		public bool SwallowContextMenuEvent(QContextMenuEvent arg1) {
			return (bool) interceptor.Invoke("swallowContextMenuEvent#", "swallowContextMenuEvent(QContextMenuEvent*)", typeof(bool), typeof(QContextMenuEvent), arg1);
		}
		public void UpdatePositionDependentActions(QPoint pos) {
			interceptor.Invoke("updatePositionDependentActions#", "updatePositionDependentActions(const QPoint&)", typeof(void), typeof(QPoint), pos);
		}
		[SmokeMethod("extension(QWebPage::Extension)")]
		public virtual bool extension(QWebPage.Extension extension) {
			return (bool) interceptor.Invoke("extension$", "extension(QWebPage::Extension)", typeof(bool), typeof(QWebPage.Extension), extension);
		}
		[SmokeMethod("supportsExtension(QWebPage::Extension) const")]
		public virtual bool SupportsExtension(QWebPage.Extension extension) {
			return (bool) interceptor.Invoke("supportsExtension$", "supportsExtension(QWebPage::Extension) const", typeof(bool), typeof(QWebPage.Extension), extension);
		}
		[SmokeMethod("createWindow(QWebPage::WebWindowType)")]
		protected virtual QWebPage CreateWindow(QWebPage.WebWindowType type) {
			return (QWebPage) interceptor.Invoke("createWindow$", "createWindow(QWebPage::WebWindowType)", typeof(QWebPage), typeof(QWebPage.WebWindowType), type);
		}
		[SmokeMethod("createPlugin(const QString&, const QUrl&, const QStringList&, const QStringList&)")]
		protected virtual QObject CreatePlugin(string classid, QUrl url, List<string> paramNames, List<string> paramValues) {
			return (QObject) interceptor.Invoke("createPlugin$#??", "createPlugin(const QString&, const QUrl&, const QStringList&, const QStringList&)", typeof(QObject), typeof(string), classid, typeof(QUrl), url, typeof(List<string>), paramNames, typeof(List<string>), paramValues);
		}
		[SmokeMethod("acceptNavigationRequest(QWebFrame*, const QNetworkRequest&, QWebPage::NavigationType)")]
		protected virtual bool AcceptNavigationRequest(QWebFrame frame, QNetworkRequest request, QWebPage.NavigationType type) {
			return (bool) interceptor.Invoke("acceptNavigationRequest##$", "acceptNavigationRequest(QWebFrame*, const QNetworkRequest&, QWebPage::NavigationType)", typeof(bool), typeof(QWebFrame), frame, typeof(QNetworkRequest), request, typeof(QWebPage.NavigationType), type);
		}
		[SmokeMethod("chooseFile(QWebFrame*, const QString&)")]
		protected virtual string ChooseFile(QWebFrame originatingFrame, string oldFile) {
			return (string) interceptor.Invoke("chooseFile#$", "chooseFile(QWebFrame*, const QString&)", typeof(string), typeof(QWebFrame), originatingFrame, typeof(string), oldFile);
		}
		[SmokeMethod("javaScriptAlert(QWebFrame*, const QString&)")]
		protected virtual void JavaScriptAlert(QWebFrame originatingFrame, string msg) {
			interceptor.Invoke("javaScriptAlert#$", "javaScriptAlert(QWebFrame*, const QString&)", typeof(void), typeof(QWebFrame), originatingFrame, typeof(string), msg);
		}
		[SmokeMethod("javaScriptConfirm(QWebFrame*, const QString&)")]
		protected virtual bool JavaScriptConfirm(QWebFrame originatingFrame, string msg) {
			return (bool) interceptor.Invoke("javaScriptConfirm#$", "javaScriptConfirm(QWebFrame*, const QString&)", typeof(bool), typeof(QWebFrame), originatingFrame, typeof(string), msg);
		}
		[SmokeMethod("javaScriptPrompt(QWebFrame*, const QString&, const QString&, QString*)")]
		protected virtual bool JavaScriptPrompt(QWebFrame originatingFrame, string msg, string defaultValue, StringBuilder result) {
			return (bool) interceptor.Invoke("javaScriptPrompt#$$$", "javaScriptPrompt(QWebFrame*, const QString&, const QString&, QString*)", typeof(bool), typeof(QWebFrame), originatingFrame, typeof(string), msg, typeof(string), defaultValue, typeof(StringBuilder), result);
		}
		[SmokeMethod("javaScriptConsoleMessage(const QString&, int, const QString&)")]
		protected virtual void JavaScriptConsoleMessage(string message, int lineNumber, string sourceID) {
			interceptor.Invoke("javaScriptConsoleMessage$$$", "javaScriptConsoleMessage(const QString&, int, const QString&)", typeof(void), typeof(string), message, typeof(int), lineNumber, typeof(string), sourceID);
		}
		[SmokeMethod("userAgentForUrl(const QUrl&) const")]
		protected virtual string UserAgentForUrl(QUrl url) {
			return (string) interceptor.Invoke("userAgentForUrl#", "userAgentForUrl(const QUrl&) const", typeof(string), typeof(QUrl), url);
		}
		~QWebPage() {
			interceptor.Invoke("~QWebPage", "~QWebPage()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QWebPage", "~QWebPage()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQWebPageSignals Emit {
			get { return (IQWebPageSignals) Q_EMIT; }
		}
	}

	public interface IQWebPageSignals : IQObjectSignals {
		[Q_SIGNAL("void loadStarted()")]
		void LoadStarted();
		[Q_SIGNAL("void loadProgress(int)")]
		void LoadProgress(int progress);
		[Q_SIGNAL("void loadFinished(bool)")]
		void LoadFinished(bool ok);
		[Q_SIGNAL("void linkHovered(const QString&, const QString&, const QString&)")]
		void LinkHovered(string link, string title, string textContent);
		[Q_SIGNAL("void statusBarMessage(const QString&)")]
		void StatusBarMessage(string text);
		[Q_SIGNAL("void selectionChanged()")]
		void SelectionChanged();
		[Q_SIGNAL("void frameCreated(QWebFrame*)")]
		void FrameCreated(QWebFrame frame);
		[Q_SIGNAL("void geometryChangeRequested(const QRect&)")]
		void GeometryChangeRequested(QRect geom);
		[Q_SIGNAL("void repaintRequested(const QRect&)")]
		void RepaintRequested(QRect dirtyRect);
		[Q_SIGNAL("void scrollRequested(int, int, const QRect&)")]
		void ScrollRequested(int dx, int dy, QRect scrollViewRect);
		[Q_SIGNAL("void windowCloseRequested()")]
		void WindowCloseRequested();
		[Q_SIGNAL("void printRequested(QWebFrame*)")]
		void PrintRequested(QWebFrame frame);
		[Q_SIGNAL("void linkClicked(const QUrl&)")]
		void LinkClicked(QUrl url);
		[Q_SIGNAL("void toolBarVisibilityChangeRequested(bool)")]
		void ToolBarVisibilityChangeRequested(bool visible);
		[Q_SIGNAL("void statusBarVisibilityChangeRequested(bool)")]
		void StatusBarVisibilityChangeRequested(bool visible);
		[Q_SIGNAL("void menuBarVisibilityChangeRequested(bool)")]
		void MenuBarVisibilityChangeRequested(bool visible);
		[Q_SIGNAL("void unsupportedContent(QNetworkReply*)")]
		void UnsupportedContent(QNetworkReply reply);
		[Q_SIGNAL("void downloadRequested(const QNetworkRequest&)")]
		void DownloadRequested(QNetworkRequest request);
		[Q_SIGNAL("void microFocusChanged()")]
		void MicroFocusChanged();
	}
}