//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDBusInterface")]
	public class QDBusInterface : QDBusAbstractInterface, IDisposable {
 		protected QDBusInterface(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusInterface), this);
			interceptor = (QDBusInterface) realProxy.GetTransparentProxy();
		}
		public QDBusInterface(string service, string path, string arg3, QDBusConnection connection, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDBusInterface(service,path,arg3,connection,parent);
		}
		[SmokeMethod("QDBusInterface", "(const QString&, const QString&, const QString&, const QDBusConnection&, QObject*)", "$$$##")]
		private void NewQDBusInterface(string service, string path, string arg3, QDBusConnection connection, QObject parent) {
			((QDBusInterface) interceptor).NewQDBusInterface(service,path,arg3,connection,parent);
		}
		public QDBusInterface(string service, string path, string arg3, QDBusConnection connection) : this((Type) null) {
			CreateProxy();
			NewQDBusInterface(service,path,arg3,connection);
		}
		[SmokeMethod("QDBusInterface", "(const QString&, const QString&, const QString&, const QDBusConnection&)", "$$$#")]
		private void NewQDBusInterface(string service, string path, string arg3, QDBusConnection connection) {
			((QDBusInterface) interceptor).NewQDBusInterface(service,path,arg3,connection);
		}
		public QDBusInterface(string service, string path, string arg3) : this((Type) null) {
			CreateProxy();
			NewQDBusInterface(service,path,arg3);
		}
		[SmokeMethod("QDBusInterface", "(const QString&, const QString&, const QString&)", "$$$")]
		private void NewQDBusInterface(string service, string path, string arg3) {
			((QDBusInterface) interceptor).NewQDBusInterface(service,path,arg3);
		}
		public QDBusInterface(string service, string path) : this((Type) null) {
			CreateProxy();
			NewQDBusInterface(service,path);
		}
		[SmokeMethod("QDBusInterface", "(const QString&, const QString&)", "$$")]
		private void NewQDBusInterface(string service, string path) {
			((QDBusInterface) interceptor).NewQDBusInterface(service,path);
		}
		~QDBusInterface() {
			DisposeQDBusInterface();
		}
		public new void Dispose() {
			DisposeQDBusInterface();
		}
		[SmokeMethod("~QDBusInterface", "()", "")]
		private void DisposeQDBusInterface() {
			((QDBusInterface) interceptor).DisposeQDBusInterface();
		}
		protected new IQDBusInterfaceSignals Emit {
			get { return (IQDBusInterfaceSignals) Q_EMIT; }
		}
	}

	public interface IQDBusInterfaceSignals : IQDBusAbstractInterfaceSignals {
	}
}
