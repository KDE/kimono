//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QSessionManager")]
	public class QSessionManager : QObject {
 		protected QSessionManager(Type dummy) : base((Type) null) {}
		[SmokeClass("QSessionManager")]
		interface IQSessionManagerProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
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
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("sessionId", "() const", "")]
		public string SessionId() {
			return ProxyQSessionManager().SessionId();
		}
		[SmokeMethod("sessionKey", "() const", "")]
		public string SessionKey() {
			return ProxyQSessionManager().SessionKey();
		}
		[SmokeMethod("allowsInteraction", "()", "")]
		public bool AllowsInteraction() {
			return ProxyQSessionManager().AllowsInteraction();
		}
		[SmokeMethod("allowsErrorInteraction", "()", "")]
		public bool AllowsErrorInteraction() {
			return ProxyQSessionManager().AllowsErrorInteraction();
		}
		[SmokeMethod("release", "()", "")]
		public void Release() {
			ProxyQSessionManager().Release();
		}
		[SmokeMethod("cancel", "()", "")]
		public void Cancel() {
			ProxyQSessionManager().Cancel();
		}
		[SmokeMethod("setRestartHint", "(QSessionManager::RestartHint)", "$")]
		public void SetRestartHint(QSessionManager.RestartHint arg1) {
			ProxyQSessionManager().SetRestartHint(arg1);
		}
		[SmokeMethod("restartHint", "() const", "")]
		public QSessionManager.RestartHint restartHint() {
			return ProxyQSessionManager().restartHint();
		}
		[SmokeMethod("setRestartCommand", "(const QStringList&)", "?")]
		public void SetRestartCommand(List<string> arg1) {
			ProxyQSessionManager().SetRestartCommand(arg1);
		}
		[SmokeMethod("restartCommand", "() const", "")]
		public List<string> RestartCommand() {
			return ProxyQSessionManager().RestartCommand();
		}
		[SmokeMethod("setDiscardCommand", "(const QStringList&)", "?")]
		public void SetDiscardCommand(List<string> arg1) {
			ProxyQSessionManager().SetDiscardCommand(arg1);
		}
		[SmokeMethod("discardCommand", "() const", "")]
		public List<string> DiscardCommand() {
			return ProxyQSessionManager().DiscardCommand();
		}
		[SmokeMethod("setManagerProperty", "(const QString&, const QString&)", "$$")]
		public void SetManagerProperty(string name, string value) {
			ProxyQSessionManager().SetManagerProperty(name,value);
		}
		[SmokeMethod("setManagerProperty", "(const QString&, const QStringList&)", "$?")]
		public void SetManagerProperty(string name, List<string> value) {
			ProxyQSessionManager().SetManagerProperty(name,value);
		}
		[SmokeMethod("isPhase2", "() const", "")]
		public bool IsPhase2() {
			return ProxyQSessionManager().IsPhase2();
		}
		[SmokeMethod("requestPhase2", "()", "")]
		public void RequestPhase2() {
			ProxyQSessionManager().RequestPhase2();
		}
		public static new string Tr(string s, string c) {
			return StaticQSessionManager().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQSessionManager().Tr(s);
		}
		protected new IQSessionManagerSignals Emit {
			get {
				return (IQSessionManagerSignals) Q_EMIT;
			}
		}
	}

	public interface IQSessionManagerSignals : IQObjectSignals {
	}
}
