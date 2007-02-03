//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Reflection;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQObjectSignals"></see> for signals emitted by QObject
	[SmokeClass("QObject")]
	public class QObject : Qt, IDisposable {
 
		private IntPtr _smokeObject;
		protected Object Q_EMIT = null;
		protected QObject(Type dummy) {
			try {
				Type proxyInterface = Qyoto.GetSignalsInterface(GetType());
				SignalInvocation realProxy = new SignalInvocation(proxyInterface, this);
				Q_EMIT = realProxy.GetTransparentProxy();
			}
			catch {
				Console.WriteLine("Could not retrieve signal interface");
			}
		}
		[SmokeMethod("metaObject", "()")]
		public virtual QMetaObject MetaObject() {
			if (Qyoto.IsSmokeClass(GetType())) {
				return ProxyQObject().MetaObject();
			} else {
				return Qyoto.GetMetaObject(this);
			}
		}
		interface IQObjectProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
			[SmokeMethod("connect#$#$$", "(const QObject*, const char*, const QObject*, const char*, Qt::ConnectionType)")]
			bool Connect(QObject sender, string signal, QObject receiver, string member, Qt.ConnectionType arg5);
			[SmokeMethod("connect#$#$", "(const QObject*, const char*, const QObject*, const char*)")]
			bool Connect(QObject sender, string signal, QObject receiver, string member);
			[SmokeMethod("disconnect#$#$", "(const QObject*, const char*, const QObject*, const char*)")]
			bool Disconnect(QObject sender, string signal, QObject receiver, string member);
			[SmokeMethod("registerUserData", "()")]
			uint RegisterUserData();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QObject), this);
			_interceptor = (QObject) realProxy.GetTransparentProxy();
		}
		private QObject ProxyQObject() {
			return (QObject) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QObject() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQObjectProxy), null);
			_staticInterceptor = (IQObjectProxy) realProxy.GetTransparentProxy();
		}
		private static IQObjectProxy StaticQObject() {
			return (IQObjectProxy) _staticInterceptor;
		}

		[Q_PROPERTY("QString", "objectName")]
		public string ObjectName {
			get {
				return Property("objectName").Value<string>();
			}
			set {
				SetProperty("objectName", QVariant.FromValue<string>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QObject(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQObject(parent);
		}
		[SmokeMethod("QObject#", "(QObject*)")]
		private void NewQObject(QObject parent) {
			ProxyQObject().NewQObject(parent);
		}
		public QObject() : this((Type) null) {
			CreateProxy();
			NewQObject();
		}
		[SmokeMethod("QObject", "()")]
		private void NewQObject() {
			ProxyQObject().NewQObject();
		}
		[SmokeMethod("event#", "(QEvent*)")]
		public virtual bool Event(QEvent arg1) {
			return ProxyQObject().Event(arg1);
		}
		[SmokeMethod("eventFilter##", "(QObject*, QEvent*)")]
		public virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQObject().EventFilter(arg1,arg2);
		}
		[SmokeMethod("isWidgetType", "() const")]
		public bool IsWidgetType() {
			return ProxyQObject().IsWidgetType();
		}
		[SmokeMethod("signalsBlocked", "() const")]
		public bool SignalsBlocked() {
			return ProxyQObject().SignalsBlocked();
		}
		[SmokeMethod("blockSignals$", "(bool)")]
		public bool BlockSignals(bool b) {
			return ProxyQObject().BlockSignals(b);
		}
		// QThread* thread(); >>>> NOT CONVERTED
		// void moveToThread(QThread* arg1); >>>> NOT CONVERTED
		[SmokeMethod("startTimer$", "(int)")]
		public int StartTimer(int interval) {
			return ProxyQObject().StartTimer(interval);
		}
		[SmokeMethod("killTimer$", "(int)")]
		public void KillTimer(int id) {
			ProxyQObject().KillTimer(id);
		}
		[SmokeMethod("children", "() const")]
		public List<QObject> Children() {
			return ProxyQObject().Children();
		}
		[SmokeMethod("setParent#", "(QObject*)")]
		public void SetParent(QObject arg1) {
			ProxyQObject().SetParent(arg1);
		}
		[SmokeMethod("installEventFilter#", "(QObject*)")]
		public void InstallEventFilter(QObject arg1) {
			ProxyQObject().InstallEventFilter(arg1);
		}
		[SmokeMethod("removeEventFilter#", "(QObject*)")]
		public void RemoveEventFilter(QObject arg1) {
			ProxyQObject().RemoveEventFilter(arg1);
		}
		[SmokeMethod("connect#$$$", "(const QObject*, const char*, const char*, Qt::ConnectionType) const")]
		public bool Connect(QObject sender, string signal, string member, Qt.ConnectionType type) {
			return ProxyQObject().Connect(sender,signal,member,type);
		}
		[SmokeMethod("connect#$$", "(const QObject*, const char*, const char*) const")]
		public bool Connect(QObject sender, string signal, string member) {
			return ProxyQObject().Connect(sender,signal,member);
		}
		[SmokeMethod("disconnect$#$", "(const char*, const QObject*, const char*)")]
		public bool Disconnect(string signal, QObject receiver, string member) {
			return ProxyQObject().Disconnect(signal,receiver,member);
		}
		[SmokeMethod("disconnect$#", "(const char*, const QObject*)")]
		public bool Disconnect(string signal, QObject receiver) {
			return ProxyQObject().Disconnect(signal,receiver);
		}
		[SmokeMethod("disconnect$", "(const char*)")]
		public bool Disconnect(string signal) {
			return ProxyQObject().Disconnect(signal);
		}
		[SmokeMethod("disconnect", "()")]
		public bool Disconnect() {
			return ProxyQObject().Disconnect();
		}
		[SmokeMethod("disconnect#$", "(const QObject*, const char*)")]
		public bool Disconnect(QObject receiver, string member) {
			return ProxyQObject().Disconnect(receiver,member);
		}
		[SmokeMethod("disconnect#", "(const QObject*)")]
		public bool Disconnect(QObject receiver) {
			return ProxyQObject().Disconnect(receiver);
		}
		[SmokeMethod("dumpObjectTree", "()")]
		public void DumpObjectTree() {
			ProxyQObject().DumpObjectTree();
		}
		[SmokeMethod("dumpObjectInfo", "()")]
		public void DumpObjectInfo() {
			ProxyQObject().DumpObjectInfo();
		}
		[SmokeMethod("setProperty$#", "(const char*, const QVariant&)")]
		public bool SetProperty(string name, QVariant value) {
			return ProxyQObject().SetProperty(name,value);
		}
		[SmokeMethod("property$", "(const char*) const")]
		public QVariant Property(string name) {
			return ProxyQObject().Property(name);
		}
		[SmokeMethod("dynamicPropertyNames", "() const")]
		public List<QByteArray> DynamicPropertyNames() {
			return ProxyQObject().DynamicPropertyNames();
		}
		// void setUserData(uint arg1,QObjectUserData* arg2); >>>> NOT CONVERTED
		// QObjectUserData* userData(uint arg1); >>>> NOT CONVERTED
		[SmokeMethod("parent", "() const")]
		public QObject Parent() {
			return ProxyQObject().Parent();
		}
		[SmokeMethod("inherits$", "(const char*) const")]
		public bool Inherits(string classname) {
			return ProxyQObject().Inherits(classname);
		}
		[Q_SLOT("void deleteLater()")]
		[SmokeMethod("deleteLater", "()")]
		public void DeleteLater() {
			ProxyQObject().DeleteLater();
		}
		public static string Tr(string s, string c) {
			return StaticQObject().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQObject().Tr(s);
		}
		public static bool Connect(QObject sender, string signal, QObject receiver, string member, Qt.ConnectionType arg5) {
			return StaticQObject().Connect(sender,signal,receiver,member,arg5);
		}
		public static bool Connect(QObject sender, string signal, QObject receiver, string member) {
			return StaticQObject().Connect(sender,signal,receiver,member);
		}
		public static bool Disconnect(QObject sender, string signal, QObject receiver, string member) {
			return StaticQObject().Disconnect(sender,signal,receiver,member);
		}
		public static uint RegisterUserData() {
			return StaticQObject().RegisterUserData();
		}
		[SmokeMethod("sender", "() const")]
		protected QObject Sender() {
			return ProxyQObject().Sender();
		}
		[SmokeMethod("receivers$", "(const char*) const")]
		protected int Receivers(string signal) {
			return ProxyQObject().Receivers(signal);
		}
		[SmokeMethod("timerEvent#", "(QTimerEvent*)")]
		protected virtual void TimerEvent(QTimerEvent arg1) {
			ProxyQObject().TimerEvent(arg1);
		}
		[SmokeMethod("childEvent#", "(QChildEvent*)")]
		protected virtual void ChildEvent(QChildEvent arg1) {
			ProxyQObject().ChildEvent(arg1);
		}
		[SmokeMethod("customEvent#", "(QEvent*)")]
		protected virtual void CustomEvent(QEvent arg1) {
			ProxyQObject().CustomEvent(arg1);
		}
		[SmokeMethod("connectNotify$", "(const char*)")]
		protected virtual void ConnectNotify(string signal) {
			ProxyQObject().ConnectNotify(signal);
		}
		[SmokeMethod("disconnectNotify$", "(const char*)")]
		protected virtual void DisconnectNotify(string signal) {
			ProxyQObject().DisconnectNotify(signal);
		}
		~QObject() {
			DisposeQObject();
		}
		public void Dispose() {
			DisposeQObject();
		}
		[SmokeMethod("~QObject", "()")]
		private void DisposeQObject() {
			ProxyQObject().DisposeQObject();
		}
		protected new IQObjectSignals Emit {
			get {
				return (IQObjectSignals) Q_EMIT;
			}
		}
	}

	public interface IQObjectSignals {
		[Q_SIGNAL("void destroyed(QObject*)")]
		void Destroyed(QObject arg1);
		[Q_SIGNAL("void destroyed()")]
		void Destroyed();
	}
}
