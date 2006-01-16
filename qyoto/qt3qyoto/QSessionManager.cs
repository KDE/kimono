//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QSessionManager")]
	public class QSessionManager : QObject {
 		protected QSessionManager(Type dummy) : base((Type) null) {}
		interface IQSessionManagerProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSessionManager), this);
			_interceptor = (QSessionManager) realProxy.GetTransparentProxy();
		}
		private QSessionManager ProxyQSessionManager() {
			return (QSessionManager) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSessionManager() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSessionManagerProxy), null);
			_staticInterceptor = (IQSessionManagerProxy) realProxy.GetTransparentProxy();
		}
		private static IQSessionManagerProxy StaticQSessionManager() {
			return (IQSessionManagerProxy) _staticInterceptor;
		}

		public enum RestartHint {
			RestartIfRunning = 0,
			RestartAnyway = 1,
			RestartImmediately = 2,
			RestartNever = 3,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQSessionManager().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQSessionManager().ClassName();
		}
		[SmokeMethod("sessionId() const")]
		public string SessionId() {
			return ProxyQSessionManager().SessionId();
		}
		[SmokeMethod("sessionKey() const")]
		public string SessionKey() {
			return ProxyQSessionManager().SessionKey();
		}
		[SmokeMethod("allowsInteraction()")]
		public bool AllowsInteraction() {
			return ProxyQSessionManager().AllowsInteraction();
		}
		[SmokeMethod("allowsErrorInteraction()")]
		public bool AllowsErrorInteraction() {
			return ProxyQSessionManager().AllowsErrorInteraction();
		}
		[SmokeMethod("release()")]
		public void Release() {
			ProxyQSessionManager().Release();
		}
		[SmokeMethod("cancel()")]
		public void Cancel() {
			ProxyQSessionManager().Cancel();
		}
		[SmokeMethod("setRestartHint(QSessionManager::RestartHint)")]
		public void SetRestartHint(QSessionManager.RestartHint arg1) {
			ProxyQSessionManager().SetRestartHint(arg1);
		}
		[SmokeMethod("restartHint() const")]
		public QSessionManager.RestartHint restartHint() {
			return ProxyQSessionManager().restartHint();
		}
		[SmokeMethod("setRestartCommand(const QStringList&)")]
		public void SetRestartCommand(string[] arg1) {
			ProxyQSessionManager().SetRestartCommand(arg1);
		}
		[SmokeMethod("restartCommand() const")]
		public ArrayList RestartCommand() {
			return ProxyQSessionManager().RestartCommand();
		}
		[SmokeMethod("setDiscardCommand(const QStringList&)")]
		public void SetDiscardCommand(string[] arg1) {
			ProxyQSessionManager().SetDiscardCommand(arg1);
		}
		[SmokeMethod("discardCommand() const")]
		public ArrayList DiscardCommand() {
			return ProxyQSessionManager().DiscardCommand();
		}
		[SmokeMethod("setManagerProperty(const QString&, const QString&)")]
		public void SetManagerProperty(string name, string value) {
			ProxyQSessionManager().SetManagerProperty(name,value);
		}
		[SmokeMethod("setManagerProperty(const QString&, const QStringList&)")]
		public void SetManagerProperty(string name, string[] value) {
			ProxyQSessionManager().SetManagerProperty(name,value);
		}
		[SmokeMethod("isPhase2() const")]
		public bool IsPhase2() {
			return ProxyQSessionManager().IsPhase2();
		}
		[SmokeMethod("requestPhase2()")]
		public void RequestPhase2() {
			ProxyQSessionManager().RequestPhase2();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQSessionManager().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQSessionManager().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQSessionManager().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQSessionManager().TrUtf8(arg1);
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQSessionManagerSignals), this);
			Q_EMIT = (IQSessionManagerSignals) realProxy.GetTransparentProxy();
		}
		protected new IQSessionManagerSignals Emit() {
			return (IQSessionManagerSignals) Q_EMIT;
		}
	}

	public interface IQSessionManagerSignals : IQObjectSignals {
	}
}
