//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextCodecFactoryInterface")]
	public class QTextCodecFactoryInterface : QFactoryInterface {
 		protected QTextCodecFactoryInterface(Type dummy) : base((Type) null) {}
		[SmokeClass("QTextCodecFactoryInterface")]
		interface IQTextCodecFactoryInterfaceProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextCodecFactoryInterface), this);
			_interceptor = (QTextCodecFactoryInterface) realProxy.GetTransparentProxy();
		}
		private QTextCodecFactoryInterface ProxyQTextCodecFactoryInterface() {
			return (QTextCodecFactoryInterface) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextCodecFactoryInterface() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextCodecFactoryInterfaceProxy), null);
			_staticInterceptor = (IQTextCodecFactoryInterfaceProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextCodecFactoryInterfaceProxy StaticQTextCodecFactoryInterface() {
			return (IQTextCodecFactoryInterfaceProxy) _staticInterceptor;
		}
		[SmokeMethod("create", "(const QString&)", "$")]
		public virtual QTextCodec Create(string key) {
			return ProxyQTextCodecFactoryInterface().Create(key);
		}
		public QTextCodecFactoryInterface() : this((Type) null) {
			CreateProxy();
			NewQTextCodecFactoryInterface();
		}
		[SmokeMethod("QTextCodecFactoryInterface", "()", "")]
		private void NewQTextCodecFactoryInterface() {
			ProxyQTextCodecFactoryInterface().NewQTextCodecFactoryInterface();
		}
		~QTextCodecFactoryInterface() {
			DisposeQTextCodecFactoryInterface();
		}
		public new void Dispose() {
			DisposeQTextCodecFactoryInterface();
		}
		[SmokeMethod("~QTextCodecFactoryInterface", "()", "")]
		private void DisposeQTextCodecFactoryInterface() {
			ProxyQTextCodecFactoryInterface().DisposeQTextCodecFactoryInterface();
		}
	}
}
