//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsSceneHelpEvent")]
	public class QGraphicsSceneHelpEvent : QGraphicsSceneEvent, IDisposable {
 		protected QGraphicsSceneHelpEvent(Type dummy) : base((Type) null) {}
		interface IQGraphicsSceneHelpEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsSceneHelpEvent), this);
			_interceptor = (QGraphicsSceneHelpEvent) realProxy.GetTransparentProxy();
		}
		private QGraphicsSceneHelpEvent ProxyQGraphicsSceneHelpEvent() {
			return (QGraphicsSceneHelpEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsSceneHelpEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsSceneHelpEventProxy), null);
			_staticInterceptor = (IQGraphicsSceneHelpEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsSceneHelpEventProxy StaticQGraphicsSceneHelpEvent() {
			return (IQGraphicsSceneHelpEventProxy) _staticInterceptor;
		}

		public QGraphicsSceneHelpEvent(QEvent.E_Type type) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneHelpEvent(type);
		}
		[SmokeMethod("QGraphicsSceneHelpEvent(QEvent::Type)")]
		private void NewQGraphicsSceneHelpEvent(QEvent.E_Type type) {
			ProxyQGraphicsSceneHelpEvent().NewQGraphicsSceneHelpEvent(type);
		}
		public QGraphicsSceneHelpEvent() : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneHelpEvent();
		}
		[SmokeMethod("QGraphicsSceneHelpEvent()")]
		private void NewQGraphicsSceneHelpEvent() {
			ProxyQGraphicsSceneHelpEvent().NewQGraphicsSceneHelpEvent();
		}
		[SmokeMethod("scenePos() const")]
		public QPointF ScenePos() {
			return ProxyQGraphicsSceneHelpEvent().ScenePos();
		}
		[SmokeMethod("setScenePos(const QPointF&)")]
		public void SetScenePos(QPointF pos) {
			ProxyQGraphicsSceneHelpEvent().SetScenePos(pos);
		}
		[SmokeMethod("screenPos() const")]
		public QPoint ScreenPos() {
			return ProxyQGraphicsSceneHelpEvent().ScreenPos();
		}
		[SmokeMethod("setScreenPos(const QPoint&)")]
		public void SetScreenPos(QPoint pos) {
			ProxyQGraphicsSceneHelpEvent().SetScreenPos(pos);
		}
		~QGraphicsSceneHelpEvent() {
			DisposeQGraphicsSceneHelpEvent();
		}
		public new void Dispose() {
			DisposeQGraphicsSceneHelpEvent();
		}
		[SmokeMethod("~QGraphicsSceneHelpEvent()")]
		private void DisposeQGraphicsSceneHelpEvent() {
			ProxyQGraphicsSceneHelpEvent().DisposeQGraphicsSceneHelpEvent();
		}
	}
}