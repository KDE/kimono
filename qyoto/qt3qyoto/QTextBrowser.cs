//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQTextBrowserSignals"></see> for signals emitted by QTextBrowser
	[SmokeClass("QTextBrowser")]
	public class QTextBrowser : QTextEdit, IDisposable {
 		protected QTextBrowser(Type dummy) : base((Type) null) {}
		interface IQTextBrowserProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextBrowser), this);
			_interceptor = (QTextBrowser) realProxy.GetTransparentProxy();
		}
		private QTextBrowser ProxyQTextBrowser() {
			return (QTextBrowser) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextBrowser() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextBrowserProxy), null);
			_staticInterceptor = (IQTextBrowserProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextBrowserProxy StaticQTextBrowser() {
			return (IQTextBrowserProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTextBrowser().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTextBrowser().ClassName();
		}
		public QTextBrowser(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			NewQTextBrowser(parent,name);
		}
		[SmokeMethod("QTextBrowser(QWidget*, const char*)")]
		private void NewQTextBrowser(QWidget parent, string name) {
			ProxyQTextBrowser().NewQTextBrowser(parent,name);
		}
		public QTextBrowser(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTextBrowser(parent);
		}
		[SmokeMethod("QTextBrowser(QWidget*)")]
		private void NewQTextBrowser(QWidget parent) {
			ProxyQTextBrowser().NewQTextBrowser(parent);
		}
		public QTextBrowser() : this((Type) null) {
			CreateProxy();
			NewQTextBrowser();
		}
		[SmokeMethod("QTextBrowser()")]
		private void NewQTextBrowser() {
			ProxyQTextBrowser().NewQTextBrowser();
		}
		[SmokeMethod("source() const")]
		public string Source() {
			return ProxyQTextBrowser().Source();
		}
		[Q_SLOT("void setSource(const QString&)")]
		[SmokeMethod("setSource(const QString&)")]
		public virtual void SetSource(string name) {
			ProxyQTextBrowser().SetSource(name);
		}
		[Q_SLOT("void backward()")]
		[SmokeMethod("backward()")]
		public virtual void Backward() {
			ProxyQTextBrowser().Backward();
		}
		[Q_SLOT("void forward()")]
		[SmokeMethod("forward()")]
		public virtual void Forward() {
			ProxyQTextBrowser().Forward();
		}
		[Q_SLOT("void home()")]
		[SmokeMethod("home()")]
		public virtual void Home() {
			ProxyQTextBrowser().Home();
		}
		[Q_SLOT("void reload()")]
		[SmokeMethod("reload()")]
		public virtual void Reload() {
			ProxyQTextBrowser().Reload();
		}
		[Q_SLOT("void setText(const QString&)")]
		[SmokeMethod("setText(const QString&)")]
		public new void SetText(string txt) {
			ProxyQTextBrowser().SetText(txt);
		}
		[Q_SLOT("void setText(const QString&, const QString&)")]
		[SmokeMethod("setText(const QString&, const QString&)")]
		public new virtual void SetText(string txt, string context) {
			ProxyQTextBrowser().SetText(txt,context);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTextBrowser().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTextBrowser().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTextBrowser().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTextBrowser().TrUtf8(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent e) {
			ProxyQTextBrowser().KeyPressEvent(e);
		}
		~QTextBrowser() {
			DisposeQTextBrowser();
		}
		public new void Dispose() {
			DisposeQTextBrowser();
		}
		private void DisposeQTextBrowser() {
			ProxyQTextBrowser().DisposeQTextBrowser();
		}
		protected new IQTextBrowserSignals Emit() {
			return (IQTextBrowserSignals) Q_EMIT;
		}
	}

	public interface IQTextBrowserSignals : IQTextEditSignals {
		[Q_SIGNAL("void backwardAvailable(bool)")]
		void BackwardAvailable(bool arg1);
		[Q_SIGNAL("void forwardAvailable(bool)")]
		void ForwardAvailable(bool arg1);
		[Q_SIGNAL("void sourceChanged(const QString&)")]
		void SourceChanged(string arg1);
		[Q_SIGNAL("void highlighted(const QString&)")]
		void Highlighted(string arg1);
		[Q_SIGNAL("void linkClicked(const QString&)")]
		void LinkClicked(string arg1);
		[Q_SIGNAL("void anchorClicked(const QString&, const QString&)")]
		void AnchorClicked(string arg1, string arg2);
	}
}
