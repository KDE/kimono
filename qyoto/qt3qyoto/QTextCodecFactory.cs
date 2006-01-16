//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTextCodecFactory")]
	public class QTextCodecFactory : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTextCodecFactory(Type dummy) {}
		interface IQTextCodecFactoryProxy {
			QTextCodec CreateForName(string arg1);
			QTextCodec CreateForMib(int arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextCodecFactory), this);
			_interceptor = (QTextCodecFactory) realProxy.GetTransparentProxy();
		}
		private QTextCodecFactory ProxyQTextCodecFactory() {
			return (QTextCodecFactory) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextCodecFactory() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextCodecFactoryProxy), null);
			_staticInterceptor = (IQTextCodecFactoryProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextCodecFactoryProxy StaticQTextCodecFactory() {
			return (IQTextCodecFactoryProxy) _staticInterceptor;
		}

		public QTextCodecFactory() : this((Type) null) {
			CreateProxy();
			NewQTextCodecFactory();
		}
		[SmokeMethod("QTextCodecFactory()")]
		private void NewQTextCodecFactory() {
			ProxyQTextCodecFactory().NewQTextCodecFactory();
		}
		[SmokeMethod("createForName(const QString&)")]
		public static QTextCodec CreateForName(string arg1) {
			return StaticQTextCodecFactory().CreateForName(arg1);
		}
		[SmokeMethod("createForMib(int)")]
		public static QTextCodec CreateForMib(int arg1) {
			return StaticQTextCodecFactory().CreateForMib(arg1);
		}
		~QTextCodecFactory() {
			DisposeQTextCodecFactory();
		}
		public void Dispose() {
			DisposeQTextCodecFactory();
		}
		private void DisposeQTextCodecFactory() {
			ProxyQTextCodecFactory().DisposeQTextCodecFactory();
		}
	}
}
