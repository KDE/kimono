//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QSqlDriverCreatorBase")]
	public class QSqlDriverCreatorBase : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QSqlDriverCreatorBase(Type dummy) {}
		interface IQSqlDriverCreatorBaseProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlDriverCreatorBase), this);
			_interceptor = (QSqlDriverCreatorBase) realProxy.GetTransparentProxy();
		}
		private QSqlDriverCreatorBase ProxyQSqlDriverCreatorBase() {
			return (QSqlDriverCreatorBase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlDriverCreatorBase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlDriverCreatorBaseProxy), null);
			_staticInterceptor = (IQSqlDriverCreatorBaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlDriverCreatorBaseProxy StaticQSqlDriverCreatorBase() {
			return (IQSqlDriverCreatorBaseProxy) _staticInterceptor;
		}

		[SmokeMethod("createObject()")]
		public virtual QSqlDriver CreateObject() {
			return ProxyQSqlDriverCreatorBase().CreateObject();
		}
		// QSqlDriverCreatorBase* QSqlDriverCreatorBase(); >>>> NOT CONVERTED
		~QSqlDriverCreatorBase() {
			DisposeQSqlDriverCreatorBase();
		}
		public void Dispose() {
			DisposeQSqlDriverCreatorBase();
		}
		private void DisposeQSqlDriverCreatorBase() {
			ProxyQSqlDriverCreatorBase().DisposeQSqlDriverCreatorBase();
		}
	}
}
