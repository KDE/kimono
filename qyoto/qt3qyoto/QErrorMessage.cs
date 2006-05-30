//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QErrorMessage")]
	public class QErrorMessage : QDialog, IDisposable {
 		protected QErrorMessage(Type dummy) : base((Type) null) {}
		interface IQErrorMessageProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QErrorMessage QtHandler();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QErrorMessage), this);
			_interceptor = (QErrorMessage) realProxy.GetTransparentProxy();
		}
		private QErrorMessage ProxyQErrorMessage() {
			return (QErrorMessage) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QErrorMessage() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQErrorMessageProxy), null);
			_staticInterceptor = (IQErrorMessageProxy) realProxy.GetTransparentProxy();
		}
		private static IQErrorMessageProxy StaticQErrorMessage() {
			return (IQErrorMessageProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQErrorMessage().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQErrorMessage().ClassName();
		}
		public QErrorMessage(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			NewQErrorMessage(parent,name);
		}
		[SmokeMethod("QErrorMessage(QWidget*, const char*)")]
		private void NewQErrorMessage(QWidget parent, string name) {
			ProxyQErrorMessage().NewQErrorMessage(parent,name);
		}
		public QErrorMessage(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQErrorMessage(parent);
		}
		[SmokeMethod("QErrorMessage(QWidget*)")]
		private void NewQErrorMessage(QWidget parent) {
			ProxyQErrorMessage().NewQErrorMessage(parent);
		}
		[Q_SLOT("void message(const QString&)")]
		[SmokeMethod("message(const QString&)")]
		public void Message(string arg1) {
			ProxyQErrorMessage().Message(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQErrorMessage().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQErrorMessage().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQErrorMessage().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQErrorMessage().TrUtf8(arg1);
		}
		[SmokeMethod("qtHandler()")]
		public static QErrorMessage QtHandler() {
			return StaticQErrorMessage().QtHandler();
		}
		[SmokeMethod("done(int)")]
		protected new void Done(int arg1) {
			ProxyQErrorMessage().Done(arg1);
		}
		~QErrorMessage() {
			DisposeQErrorMessage();
		}
		public new void Dispose() {
			DisposeQErrorMessage();
		}
		private void DisposeQErrorMessage() {
			ProxyQErrorMessage().DisposeQErrorMessage();
		}
		protected new IQErrorMessageSignals Emit() {
			return (IQErrorMessageSignals) Q_EMIT;
		}
	}

	public interface IQErrorMessageSignals : IQDialogSignals {
	}
}
