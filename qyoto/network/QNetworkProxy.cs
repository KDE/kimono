//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QNetworkProxy")]
	public class QNetworkProxy : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QNetworkProxy(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QNetworkProxy), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QNetworkProxy() {
			staticInterceptor = new SmokeInvocation(typeof(QNetworkProxy), null);
		}
		public enum ProxyType {
			DefaultProxy = 0,
			Socks5Proxy = 1,
			NoProxy = 2,
			HttpProxy = 3,
			HttpCachingProxy = 4,
			FtpCachingProxy = 5,
		}
		public QNetworkProxy() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QNetworkProxy", "QNetworkProxy()", typeof(void));
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user, string password) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QNetworkProxy$$$$$", "QNetworkProxy(QNetworkProxy::ProxyType, const QString&, unsigned short, const QString&, const QString&)", typeof(void), typeof(QNetworkProxy.ProxyType), type, typeof(string), hostName, typeof(ushort), port, typeof(string), user, typeof(string), password);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port, string user) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QNetworkProxy$$$$", "QNetworkProxy(QNetworkProxy::ProxyType, const QString&, unsigned short, const QString&)", typeof(void), typeof(QNetworkProxy.ProxyType), type, typeof(string), hostName, typeof(ushort), port, typeof(string), user);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName, ushort port) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QNetworkProxy$$$", "QNetworkProxy(QNetworkProxy::ProxyType, const QString&, unsigned short)", typeof(void), typeof(QNetworkProxy.ProxyType), type, typeof(string), hostName, typeof(ushort), port);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type, string hostName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QNetworkProxy$$", "QNetworkProxy(QNetworkProxy::ProxyType, const QString&)", typeof(void), typeof(QNetworkProxy.ProxyType), type, typeof(string), hostName);
		}
		public QNetworkProxy(QNetworkProxy.ProxyType type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QNetworkProxy$", "QNetworkProxy(QNetworkProxy::ProxyType)", typeof(void), typeof(QNetworkProxy.ProxyType), type);
		}
		public QNetworkProxy(QNetworkProxy other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QNetworkProxy#", "QNetworkProxy(const QNetworkProxy&)", typeof(void), typeof(QNetworkProxy), other);
		}
		public override bool Equals(object o) {
			if (!(o is QNetworkProxy)) { return false; }
			return this == (QNetworkProxy) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public void SetType(QNetworkProxy.ProxyType type) {
			interceptor.Invoke("setType$", "setType(QNetworkProxy::ProxyType)", typeof(void), typeof(QNetworkProxy.ProxyType), type);
		}
		public QNetworkProxy.ProxyType type() {
			return (QNetworkProxy.ProxyType) interceptor.Invoke("type", "type() const", typeof(QNetworkProxy.ProxyType));
		}
		public bool IsCachingProxy() {
			return (bool) interceptor.Invoke("isCachingProxy", "isCachingProxy() const", typeof(bool));
		}
		public bool IsTransparentProxy() {
			return (bool) interceptor.Invoke("isTransparentProxy", "isTransparentProxy() const", typeof(bool));
		}
		public void SetUser(string userName) {
			interceptor.Invoke("setUser$", "setUser(const QString&)", typeof(void), typeof(string), userName);
		}
		public string User() {
			return (string) interceptor.Invoke("user", "user() const", typeof(string));
		}
		public void SetPassword(string password) {
			interceptor.Invoke("setPassword$", "setPassword(const QString&)", typeof(void), typeof(string), password);
		}
		public string Password() {
			return (string) interceptor.Invoke("password", "password() const", typeof(string));
		}
		public void SetHostName(string hostName) {
			interceptor.Invoke("setHostName$", "setHostName(const QString&)", typeof(void), typeof(string), hostName);
		}
		public string HostName() {
			return (string) interceptor.Invoke("hostName", "hostName() const", typeof(string));
		}
		public void SetPort(ushort port) {
			interceptor.Invoke("setPort$", "setPort(unsigned short)", typeof(void), typeof(ushort), port);
		}
		public ushort Port() {
			return (ushort) interceptor.Invoke("port", "port() const", typeof(ushort));
		}
		~QNetworkProxy() {
			interceptor.Invoke("~QNetworkProxy", "~QNetworkProxy()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QNetworkProxy", "~QNetworkProxy()", typeof(void));
		}
		public static bool operator==(QNetworkProxy lhs, QNetworkProxy other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QNetworkProxy&) const", typeof(bool), typeof(QNetworkProxy), lhs, typeof(QNetworkProxy), other);
		}
		public static bool operator!=(QNetworkProxy lhs, QNetworkProxy other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QNetworkProxy&) const", typeof(bool), typeof(QNetworkProxy), lhs, typeof(QNetworkProxy), other);
		}
		public static void SetApplicationProxy(QNetworkProxy proxy) {
			staticInterceptor.Invoke("setApplicationProxy#", "setApplicationProxy(const QNetworkProxy&)", typeof(void), typeof(QNetworkProxy), proxy);
		}
		public static QNetworkProxy ApplicationProxy() {
			return (QNetworkProxy) staticInterceptor.Invoke("applicationProxy", "applicationProxy()", typeof(QNetworkProxy));
		}
	}
}
