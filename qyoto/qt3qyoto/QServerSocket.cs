//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QServerSocket")]
	public class QServerSocket : QObject {
 		protected QServerSocket(Type dummy) : base((Type) null) {}
		interface IQServerSocketProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QServerSocket), this);
			_interceptor = (QServerSocket) realProxy.GetTransparentProxy();
		}
		private QServerSocket ProxyQServerSocket() {
			return (QServerSocket) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QServerSocket() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQServerSocketProxy), null);
			_staticInterceptor = (IQServerSocketProxy) realProxy.GetTransparentProxy();
		}
		private static IQServerSocketProxy StaticQServerSocket() {
			return (IQServerSocketProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQServerSocket().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQServerSocket().ClassName();
		}
		public QServerSocket(ushort port, int backlog, QObject parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(port,backlog,parent,name);
		}
		[SmokeMethod("QServerSocket(Q_UINT16, int, QObject*, const char*)")]
		private void NewQServerSocket(ushort port, int backlog, QObject parent, string name) {
			ProxyQServerSocket().NewQServerSocket(port,backlog,parent,name);
		}
		public QServerSocket(ushort port, int backlog, QObject parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(port,backlog,parent);
		}
		[SmokeMethod("QServerSocket(Q_UINT16, int, QObject*)")]
		private void NewQServerSocket(ushort port, int backlog, QObject parent) {
			ProxyQServerSocket().NewQServerSocket(port,backlog,parent);
		}
		public QServerSocket(ushort port, int backlog) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(port,backlog);
		}
		[SmokeMethod("QServerSocket(Q_UINT16, int)")]
		private void NewQServerSocket(ushort port, int backlog) {
			ProxyQServerSocket().NewQServerSocket(port,backlog);
		}
		public QServerSocket(ushort port) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(port);
		}
		[SmokeMethod("QServerSocket(Q_UINT16)")]
		private void NewQServerSocket(ushort port) {
			ProxyQServerSocket().NewQServerSocket(port);
		}
		public QServerSocket(QHostAddress address, ushort port, int backlog, QObject parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(address,port,backlog,parent,name);
		}
		[SmokeMethod("QServerSocket(const QHostAddress&, Q_UINT16, int, QObject*, const char*)")]
		private void NewQServerSocket(QHostAddress address, ushort port, int backlog, QObject parent, string name) {
			ProxyQServerSocket().NewQServerSocket(address,port,backlog,parent,name);
		}
		public QServerSocket(QHostAddress address, ushort port, int backlog, QObject parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(address,port,backlog,parent);
		}
		[SmokeMethod("QServerSocket(const QHostAddress&, Q_UINT16, int, QObject*)")]
		private void NewQServerSocket(QHostAddress address, ushort port, int backlog, QObject parent) {
			ProxyQServerSocket().NewQServerSocket(address,port,backlog,parent);
		}
		public QServerSocket(QHostAddress address, ushort port, int backlog) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(address,port,backlog);
		}
		[SmokeMethod("QServerSocket(const QHostAddress&, Q_UINT16, int)")]
		private void NewQServerSocket(QHostAddress address, ushort port, int backlog) {
			ProxyQServerSocket().NewQServerSocket(address,port,backlog);
		}
		public QServerSocket(QHostAddress address, ushort port) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(address,port);
		}
		[SmokeMethod("QServerSocket(const QHostAddress&, Q_UINT16)")]
		private void NewQServerSocket(QHostAddress address, ushort port) {
			ProxyQServerSocket().NewQServerSocket(address,port);
		}
		public QServerSocket(QObject parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(parent,name);
		}
		[SmokeMethod("QServerSocket(QObject*, const char*)")]
		private void NewQServerSocket(QObject parent, string name) {
			ProxyQServerSocket().NewQServerSocket(parent,name);
		}
		public QServerSocket(QObject parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket(parent);
		}
		[SmokeMethod("QServerSocket(QObject*)")]
		private void NewQServerSocket(QObject parent) {
			ProxyQServerSocket().NewQServerSocket(parent);
		}
		public QServerSocket() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQServerSocket();
		}
		[SmokeMethod("QServerSocket()")]
		private void NewQServerSocket() {
			ProxyQServerSocket().NewQServerSocket();
		}
		[SmokeMethod("ok() const")]
		public bool Ok() {
			return ProxyQServerSocket().Ok();
		}
		[SmokeMethod("port() const")]
		public ushort Port() {
			return ProxyQServerSocket().Port();
		}
		[SmokeMethod("socket() const")]
		public int Socket() {
			return ProxyQServerSocket().Socket();
		}
		[SmokeMethod("setSocket(int)")]
		public virtual void SetSocket(int socket) {
			ProxyQServerSocket().SetSocket(socket);
		}
		[SmokeMethod("address() const")]
		public QHostAddress Address() {
			return ProxyQServerSocket().Address();
		}
		[SmokeMethod("newConnection(int)")]
		public virtual void NewConnection(int socket) {
			ProxyQServerSocket().NewConnection(socket);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQServerSocket().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQServerSocket().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQServerSocket().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQServerSocket().TrUtf8(arg1);
		}
		~QServerSocket() {
			DisposeQServerSocket();
		}
		public new void Dispose() {
			DisposeQServerSocket();
		}
		private void DisposeQServerSocket() {
			ProxyQServerSocket().DisposeQServerSocket();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQServerSocketSignals), this);
			Q_EMIT = (IQServerSocketSignals) realProxy.GetTransparentProxy();
		}
		protected new IQServerSocketSignals Emit() {
			return (IQServerSocketSignals) Q_EMIT;
		}
	}

	public interface IQServerSocketSignals : IQObjectSignals {
	}
}
