//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QContextMenuEvent")]
	public class QContextMenuEvent : QInputEvent, IDisposable {
 		protected QContextMenuEvent(Type dummy) : base((Type) null) {}
		interface IQContextMenuEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QContextMenuEvent), this);
			_interceptor = (QContextMenuEvent) realProxy.GetTransparentProxy();
		}
		private QContextMenuEvent ProxyQContextMenuEvent() {
			return (QContextMenuEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QContextMenuEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQContextMenuEventProxy), null);
			_staticInterceptor = (IQContextMenuEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQContextMenuEventProxy StaticQContextMenuEvent() {
			return (IQContextMenuEventProxy) _staticInterceptor;
		}

		public enum Reason {
			Mouse = 0,
			Keyboard = 1,
			Other = 2,
		}
		public QContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos, QPoint globalPos) : this((Type) null) {
			CreateProxy();
			NewQContextMenuEvent(reason,pos,globalPos);
		}
		[SmokeMethod("QContextMenuEvent$##", "(QContextMenuEvent::Reason, const QPoint&, const QPoint&)")]
		private void NewQContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos, QPoint globalPos) {
			ProxyQContextMenuEvent().NewQContextMenuEvent(reason,pos,globalPos);
		}
		public QContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos) : this((Type) null) {
			CreateProxy();
			NewQContextMenuEvent(reason,pos);
		}
		[SmokeMethod("QContextMenuEvent$#", "(QContextMenuEvent::Reason, const QPoint&)")]
		private void NewQContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos) {
			ProxyQContextMenuEvent().NewQContextMenuEvent(reason,pos);
		}
		[SmokeMethod("x", "() const")]
		public int X() {
			return ProxyQContextMenuEvent().X();
		}
		[SmokeMethod("y", "() const")]
		public int Y() {
			return ProxyQContextMenuEvent().Y();
		}
		[SmokeMethod("globalX", "() const")]
		public int GlobalX() {
			return ProxyQContextMenuEvent().GlobalX();
		}
		[SmokeMethod("globalY", "() const")]
		public int GlobalY() {
			return ProxyQContextMenuEvent().GlobalY();
		}
		[SmokeMethod("pos", "() const")]
		public QPoint Pos() {
			return ProxyQContextMenuEvent().Pos();
		}
		[SmokeMethod("globalPos", "() const")]
		public QPoint GlobalPos() {
			return ProxyQContextMenuEvent().GlobalPos();
		}
		[SmokeMethod("reason", "() const")]
		public QContextMenuEvent.Reason reason() {
			return ProxyQContextMenuEvent().reason();
		}
		~QContextMenuEvent() {
			DisposeQContextMenuEvent();
		}
		public new void Dispose() {
			DisposeQContextMenuEvent();
		}
		[SmokeMethod("~QContextMenuEvent", "()")]
		private void DisposeQContextMenuEvent() {
			ProxyQContextMenuEvent().DisposeQContextMenuEvent();
		}
	}
}
