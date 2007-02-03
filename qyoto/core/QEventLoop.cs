//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QEventLoop")]
	public class QEventLoop : QObject, IDisposable {
 		protected QEventLoop(Type dummy) : base((Type) null) {}
		interface IQEventLoopProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QEventLoop), this);
			_interceptor = (QEventLoop) realProxy.GetTransparentProxy();
		}
		private QEventLoop ProxyQEventLoop() {
			return (QEventLoop) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QEventLoop() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQEventLoopProxy), null);
			_staticInterceptor = (IQEventLoopProxy) realProxy.GetTransparentProxy();
		}
		private static IQEventLoopProxy StaticQEventLoop() {
			return (IQEventLoopProxy) _staticInterceptor;
		}

		public enum ProcessEventsFlag {
			AllEvents = 0x00,
			ExcludeUserInputEvents = 0x01,
			ExcludeSocketNotifiers = 0x02,
			WaitForMoreEvents = 0x04,
			X11ExcludeTimers = 0x08,
			DeferredDeletion = 0x10,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QEventLoop(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQEventLoop(parent);
		}
		[SmokeMethod("QEventLoop#", "(QObject*)")]
		private void NewQEventLoop(QObject parent) {
			ProxyQEventLoop().NewQEventLoop(parent);
		}
		public QEventLoop() : this((Type) null) {
			CreateProxy();
			NewQEventLoop();
		}
		[SmokeMethod("QEventLoop", "()")]
		private void NewQEventLoop() {
			ProxyQEventLoop().NewQEventLoop();
		}
		[SmokeMethod("processEvents$", "(ProcessEventsFlags)")]
		public bool ProcessEvents(int flags) {
			return ProxyQEventLoop().ProcessEvents(flags);
		}
		[SmokeMethod("processEvents", "()")]
		public bool ProcessEvents() {
			return ProxyQEventLoop().ProcessEvents();
		}
		[SmokeMethod("processEvents$$", "(ProcessEventsFlags, int)")]
		public void ProcessEvents(int flags, int maximumTime) {
			ProxyQEventLoop().ProcessEvents(flags,maximumTime);
		}
		[SmokeMethod("exec$", "(ProcessEventsFlags)")]
		public int Exec(int flags) {
			return ProxyQEventLoop().Exec(flags);
		}
		[SmokeMethod("exec", "()")]
		public int Exec() {
			return ProxyQEventLoop().Exec();
		}
		[SmokeMethod("exit$", "(int)")]
		public void Exit(int returnCode) {
			ProxyQEventLoop().Exit(returnCode);
		}
		[SmokeMethod("exit", "()")]
		public void Exit() {
			ProxyQEventLoop().Exit();
		}
		[SmokeMethod("isRunning", "() const")]
		public bool IsRunning() {
			return ProxyQEventLoop().IsRunning();
		}
		[SmokeMethod("wakeUp", "()")]
		public void WakeUp() {
			ProxyQEventLoop().WakeUp();
		}
		[Q_SLOT("void quit()")]
		[SmokeMethod("quit", "()")]
		public void Quit() {
			ProxyQEventLoop().Quit();
		}
		public static new string Tr(string s, string c) {
			return StaticQEventLoop().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQEventLoop().Tr(s);
		}
		~QEventLoop() {
			DisposeQEventLoop();
		}
		public new void Dispose() {
			DisposeQEventLoop();
		}
		[SmokeMethod("~QEventLoop", "()")]
		private void DisposeQEventLoop() {
			ProxyQEventLoop().DisposeQEventLoop();
		}
		protected new IQEventLoopSignals Emit {
			get {
				return (IQEventLoopSignals) Q_EMIT;
			}
		}
	}

	public interface IQEventLoopSignals : IQObjectSignals {
	}
}
