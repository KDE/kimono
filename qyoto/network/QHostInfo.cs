//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QHostInfo")]
	public class QHostInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QHostInfo(Type dummy) {}
		interface IQHostInfoProxy {
			[SmokeMethod("lookupHost$#$", "(const QString&, QObject*, const char*)")]
			int LookupHost(string name, QObject receiver, string member);
			[SmokeMethod("abortHostLookup$", "(int)")]
			void AbortHostLookup(int lookupId);
			[SmokeMethod("fromName$", "(const QString&)")]
			QHostInfo FromName(string name);
			[SmokeMethod("localHostName", "()")]
			string LocalHostName();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHostInfo), this);
			_interceptor = (QHostInfo) realProxy.GetTransparentProxy();
		}
		private QHostInfo ProxyQHostInfo() {
			return (QHostInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHostInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHostInfoProxy), null);
			_staticInterceptor = (IQHostInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQHostInfoProxy StaticQHostInfo() {
			return (IQHostInfoProxy) _staticInterceptor;
		}

		public enum HostInfoError {
			NoError = 0,
			HostNotFound = 1,
			UnknownError = 2,
		}
		public QHostInfo(int lookupId) : this((Type) null) {
			CreateProxy();
			NewQHostInfo(lookupId);
		}
		[SmokeMethod("QHostInfo$", "(int)")]
		private void NewQHostInfo(int lookupId) {
			ProxyQHostInfo().NewQHostInfo(lookupId);
		}
		public QHostInfo() : this((Type) null) {
			CreateProxy();
			NewQHostInfo();
		}
		[SmokeMethod("QHostInfo", "()")]
		private void NewQHostInfo() {
			ProxyQHostInfo().NewQHostInfo();
		}
		public QHostInfo(QHostInfo d) : this((Type) null) {
			CreateProxy();
			NewQHostInfo(d);
		}
		[SmokeMethod("QHostInfo#", "(const QHostInfo&)")]
		private void NewQHostInfo(QHostInfo d) {
			ProxyQHostInfo().NewQHostInfo(d);
		}
		[SmokeMethod("hostName", "() const")]
		public string HostName() {
			return ProxyQHostInfo().HostName();
		}
		[SmokeMethod("setHostName$", "(const QString&)")]
		public void SetHostName(string name) {
			ProxyQHostInfo().SetHostName(name);
		}
		[SmokeMethod("addresses", "() const")]
		public List<QHostAddress> Addresses() {
			return ProxyQHostInfo().Addresses();
		}
		[SmokeMethod("setAddresses?", "(const QList<QHostAddress>&)")]
		public void SetAddresses(List<QHostAddress> addresses) {
			ProxyQHostInfo().SetAddresses(addresses);
		}
		[SmokeMethod("error", "() const")]
		public QHostInfo.HostInfoError Error() {
			return ProxyQHostInfo().Error();
		}
		[SmokeMethod("setError$", "(QHostInfo::HostInfoError)")]
		public void SetError(QHostInfo.HostInfoError error) {
			ProxyQHostInfo().SetError(error);
		}
		[SmokeMethod("errorString", "() const")]
		public string ErrorString() {
			return ProxyQHostInfo().ErrorString();
		}
		[SmokeMethod("setErrorString$", "(const QString&)")]
		public void SetErrorString(string errorString) {
			ProxyQHostInfo().SetErrorString(errorString);
		}
		[SmokeMethod("setLookupId$", "(int)")]
		public void SetLookupId(int id) {
			ProxyQHostInfo().SetLookupId(id);
		}
		[SmokeMethod("lookupId", "() const")]
		public int LookupId() {
			return ProxyQHostInfo().LookupId();
		}
		public static int LookupHost(string name, QObject receiver, string member) {
			return StaticQHostInfo().LookupHost(name,receiver,member);
		}
		public static void AbortHostLookup(int lookupId) {
			StaticQHostInfo().AbortHostLookup(lookupId);
		}
		public static QHostInfo FromName(string name) {
			return StaticQHostInfo().FromName(name);
		}
		public static string LocalHostName() {
			return StaticQHostInfo().LocalHostName();
		}
		~QHostInfo() {
			DisposeQHostInfo();
		}
		public void Dispose() {
			DisposeQHostInfo();
		}
		[SmokeMethod("~QHostInfo", "()")]
		private void DisposeQHostInfo() {
			ProxyQHostInfo().DisposeQHostInfo();
		}
	}
}
