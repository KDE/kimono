//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;

	[SmokeClass("QDomNodeList")]
	public class QDomNodeList : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QDomNodeList(Type dummy) {}
		interface IQDomNodeListProxy {
			bool op_equals(QDomNodeList lhs, ArrayList arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomNodeList), this);
			_interceptor = (QDomNodeList) realProxy.GetTransparentProxy();
		}
		private QDomNodeList ProxyQDomNodeList() {
			return (QDomNodeList) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomNodeList() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomNodeListProxy), null);
			_staticInterceptor = (IQDomNodeListProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomNodeListProxy StaticQDomNodeList() {
			return (IQDomNodeListProxy) _staticInterceptor;
		}

		public QDomNodeList() : this((Type) null) {
			CreateProxy();
			NewQDomNodeList();
		}
		[SmokeMethod("QDomNodeList()")]
		private void NewQDomNodeList() {
			ProxyQDomNodeList().NewQDomNodeList();
		}
		public QDomNodeList(ArrayList arg1) : this((Type) null) {
			CreateProxy();
			NewQDomNodeList(arg1);
		}
		[SmokeMethod("QDomNodeList(const QDomNodeList&)")]
		private void NewQDomNodeList(ArrayList arg1) {
			ProxyQDomNodeList().NewQDomNodeList(arg1);
		}
		[SmokeMethod("operator==(const QDomNodeList&) const")]
		public static bool operator==(QDomNodeList lhs, ArrayList arg1) {
			return StaticQDomNodeList().op_equals(lhs,arg1);
		}
		public static bool operator!=(QDomNodeList lhs, ArrayList arg1) {
			return !StaticQDomNodeList().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QDomNodeList)) { return false; }
			return this == (QDomNodeList) o;
		}
		public override int GetHashCode() {
			return ProxyQDomNodeList().GetHashCode();
		}
		[SmokeMethod("item(int) const")]
		public virtual QDomNode Item(int index) {
			return ProxyQDomNodeList().Item(index);
		}
		[SmokeMethod("length() const")]
		public virtual uint Length() {
			return ProxyQDomNodeList().Length();
		}
		[SmokeMethod("count() const")]
		public uint Count() {
			return ProxyQDomNodeList().Count();
		}
		~QDomNodeList() {
			DisposeQDomNodeList();
		}
		public void Dispose() {
			DisposeQDomNodeList();
		}
		private void DisposeQDomNodeList() {
			ProxyQDomNodeList().DisposeQDomNodeList();
		}
	}
}
