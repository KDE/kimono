//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQTextBrowserSignals"></see> for signals emitted by QTextBrowser
	[SmokeClass("QTextBrowser")]
	public class QTextBrowser : QTextEdit, IDisposable {
 		protected QTextBrowser(Type dummy) : base((Type) null) {}
		[SmokeClass("QTextBrowser")]
		interface IQTextBrowserProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextBrowser), this);
			interceptor = (QTextBrowser) realProxy.GetTransparentProxy();
		}
		private static IQTextBrowserProxy staticInterceptor = null;
		static QTextBrowser() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextBrowserProxy), null);
			staticInterceptor = (IQTextBrowserProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("QUrl", "source")]
		public IQUrl Source {
			[SmokeMethod("source", "()", "")]
			get { return ((QTextBrowser) interceptor).Source; }
			[SmokeMethod("setSource", "(QUrl)", "#")]
			set { ((QTextBrowser) interceptor).Source = value; }
		}
		[Q_PROPERTY("QStringList", "searchPaths")]
		public List<string> SearchPaths {
			[SmokeMethod("searchPaths", "()", "")]
			get { return ((QTextBrowser) interceptor).SearchPaths; }
			[SmokeMethod("setSearchPaths", "(QStringList)", "?")]
			set { ((QTextBrowser) interceptor).SearchPaths = value; }
		}
		[Q_PROPERTY("bool", "openExternalLinks")]
		public bool OpenExternalLinks {
			[SmokeMethod("openExternalLinks", "()", "")]
			get { return ((QTextBrowser) interceptor).OpenExternalLinks; }
			[SmokeMethod("setOpenExternalLinks", "(bool)", "$")]
			set { ((QTextBrowser) interceptor).OpenExternalLinks = value; }
		}
		public QTextBrowser(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTextBrowser(parent);
		}
		[SmokeMethod("QTextBrowser", "(QWidget*)", "#")]
		private void NewQTextBrowser(QWidget parent) {
			((QTextBrowser) interceptor).NewQTextBrowser(parent);
		}
		public QTextBrowser() : this((Type) null) {
			CreateProxy();
			NewQTextBrowser();
		}
		[SmokeMethod("QTextBrowser", "()", "")]
		private void NewQTextBrowser() {
			((QTextBrowser) interceptor).NewQTextBrowser();
		}
		[SmokeMethod("loadResource", "(int, const QUrl&)", "$#")]
		public override QVariant LoadResource(int type, IQUrl name) {
			return ((QTextBrowser) interceptor).LoadResource(type,name);
		}
		[SmokeMethod("isBackwardAvailable", "() const", "")]
		public bool IsBackwardAvailable() {
			return ((QTextBrowser) interceptor).IsBackwardAvailable();
		}
		[SmokeMethod("isForwardAvailable", "() const", "")]
		public bool IsForwardAvailable() {
			return ((QTextBrowser) interceptor).IsForwardAvailable();
		}
		[SmokeMethod("clearHistory", "()", "")]
		public void ClearHistory() {
			((QTextBrowser) interceptor).ClearHistory();
		}
		[Q_SLOT("void backward()")]
		[SmokeMethod("backward", "()", "")]
		public virtual void Backward() {
			((QTextBrowser) interceptor).Backward();
		}
		[Q_SLOT("void forward()")]
		[SmokeMethod("forward", "()", "")]
		public virtual void Forward() {
			((QTextBrowser) interceptor).Forward();
		}
		[Q_SLOT("void home()")]
		[SmokeMethod("home", "()", "")]
		public virtual void Home() {
			((QTextBrowser) interceptor).Home();
		}
		[Q_SLOT("void reload()")]
		[SmokeMethod("reload", "()", "")]
		public virtual void Reload() {
			((QTextBrowser) interceptor).Reload();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QTextBrowser) interceptor).Event(e);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent ev) {
			((QTextBrowser) interceptor).KeyPressEvent(ev);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected override void MouseMoveEvent(QMouseEvent ev) {
			((QTextBrowser) interceptor).MouseMoveEvent(ev);
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected override void MousePressEvent(QMouseEvent ev) {
			((QTextBrowser) interceptor).MousePressEvent(ev);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected override void MouseReleaseEvent(QMouseEvent ev) {
			((QTextBrowser) interceptor).MouseReleaseEvent(ev);
		}
		[SmokeMethod("focusOutEvent", "(QFocusEvent*)", "#")]
		protected override void FocusOutEvent(QFocusEvent ev) {
			((QTextBrowser) interceptor).FocusOutEvent(ev);
		}
		[SmokeMethod("focusNextPrevChild", "(bool)", "$")]
		protected override bool FocusNextPrevChild(bool next) {
			return ((QTextBrowser) interceptor).FocusNextPrevChild(next);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent e) {
			((QTextBrowser) interceptor).PaintEvent(e);
		}
		~QTextBrowser() {
			DisposeQTextBrowser();
		}
		public new void Dispose() {
			DisposeQTextBrowser();
		}
		[SmokeMethod("~QTextBrowser", "()", "")]
		private void DisposeQTextBrowser() {
			((QTextBrowser) interceptor).DisposeQTextBrowser();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQTextBrowserSignals Emit {
			get { return (IQTextBrowserSignals) Q_EMIT; }
		}
	}

	public interface IQTextBrowserSignals : IQTextEditSignals {
		[Q_SIGNAL("void backwardAvailable(bool)")]
		void BackwardAvailable(bool arg1);
		[Q_SIGNAL("void forwardAvailable(bool)")]
		void ForwardAvailable(bool arg1);
		[Q_SIGNAL("void sourceChanged(const QUrl&)")]
		void SourceChanged(IQUrl arg1);
		[Q_SIGNAL("void highlighted(const QUrl&)")]
		void Highlighted(IQUrl arg1);
		[Q_SIGNAL("void highlighted(const QString&)")]
		void Highlighted(string arg1);
		[Q_SIGNAL("void anchorClicked(const QUrl&)")]
		void AnchorClicked(IQUrl arg1);
	}
}
