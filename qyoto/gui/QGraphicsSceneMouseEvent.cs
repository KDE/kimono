//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsSceneMouseEvent")]
	public class QGraphicsSceneMouseEvent : QGraphicsSceneEvent, IDisposable {
 		protected QGraphicsSceneMouseEvent(Type dummy) : base((Type) null) {}
		interface IQGraphicsSceneMouseEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsSceneMouseEvent), this);
			_interceptor = (QGraphicsSceneMouseEvent) realProxy.GetTransparentProxy();
		}
		private QGraphicsSceneMouseEvent ProxyQGraphicsSceneMouseEvent() {
			return (QGraphicsSceneMouseEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsSceneMouseEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsSceneMouseEventProxy), null);
			_staticInterceptor = (IQGraphicsSceneMouseEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsSceneMouseEventProxy StaticQGraphicsSceneMouseEvent() {
			return (IQGraphicsSceneMouseEventProxy) _staticInterceptor;
		}

		public QGraphicsSceneMouseEvent(QEvent.TypeOf type) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneMouseEvent(type);
		}
		[SmokeMethod("QGraphicsSceneMouseEvent$", "(QEvent::Type)")]
		private void NewQGraphicsSceneMouseEvent(QEvent.TypeOf type) {
			ProxyQGraphicsSceneMouseEvent().NewQGraphicsSceneMouseEvent(type);
		}
		public QGraphicsSceneMouseEvent() : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneMouseEvent();
		}
		[SmokeMethod("QGraphicsSceneMouseEvent", "()")]
		private void NewQGraphicsSceneMouseEvent() {
			ProxyQGraphicsSceneMouseEvent().NewQGraphicsSceneMouseEvent();
		}
		[SmokeMethod("pos", "() const")]
		public QPointF Pos() {
			return ProxyQGraphicsSceneMouseEvent().Pos();
		}
		[SmokeMethod("setPos#", "(const QPointF&)")]
		public void SetPos(QPointF pos) {
			ProxyQGraphicsSceneMouseEvent().SetPos(pos);
		}
		[SmokeMethod("scenePos", "() const")]
		public QPointF ScenePos() {
			return ProxyQGraphicsSceneMouseEvent().ScenePos();
		}
		[SmokeMethod("setScenePos#", "(const QPointF&)")]
		public void SetScenePos(QPointF pos) {
			ProxyQGraphicsSceneMouseEvent().SetScenePos(pos);
		}
		[SmokeMethod("screenPos", "() const")]
		public QPoint ScreenPos() {
			return ProxyQGraphicsSceneMouseEvent().ScreenPos();
		}
		[SmokeMethod("setScreenPos#", "(const QPoint&)")]
		public void SetScreenPos(QPoint pos) {
			ProxyQGraphicsSceneMouseEvent().SetScreenPos(pos);
		}
		[SmokeMethod("buttonDownPos$", "(Qt::MouseButton) const")]
		public QPointF ButtonDownPos(Qt.MouseButton button) {
			return ProxyQGraphicsSceneMouseEvent().ButtonDownPos(button);
		}
		[SmokeMethod("setButtonDownPos$#", "(Qt::MouseButton, const QPointF&)")]
		public void SetButtonDownPos(Qt.MouseButton button, QPointF pos) {
			ProxyQGraphicsSceneMouseEvent().SetButtonDownPos(button,pos);
		}
		[SmokeMethod("buttonDownScenePos$", "(Qt::MouseButton) const")]
		public QPointF ButtonDownScenePos(Qt.MouseButton button) {
			return ProxyQGraphicsSceneMouseEvent().ButtonDownScenePos(button);
		}
		[SmokeMethod("setButtonDownScenePos$#", "(Qt::MouseButton, const QPointF&)")]
		public void SetButtonDownScenePos(Qt.MouseButton button, QPointF pos) {
			ProxyQGraphicsSceneMouseEvent().SetButtonDownScenePos(button,pos);
		}
		[SmokeMethod("buttonDownScreenPos$", "(Qt::MouseButton) const")]
		public QPoint ButtonDownScreenPos(Qt.MouseButton button) {
			return ProxyQGraphicsSceneMouseEvent().ButtonDownScreenPos(button);
		}
		[SmokeMethod("setButtonDownScreenPos$#", "(Qt::MouseButton, const QPoint&)")]
		public void SetButtonDownScreenPos(Qt.MouseButton button, QPoint pos) {
			ProxyQGraphicsSceneMouseEvent().SetButtonDownScreenPos(button,pos);
		}
		[SmokeMethod("lastPos", "() const")]
		public QPointF LastPos() {
			return ProxyQGraphicsSceneMouseEvent().LastPos();
		}
		[SmokeMethod("setLastPos#", "(const QPointF&)")]
		public void SetLastPos(QPointF pos) {
			ProxyQGraphicsSceneMouseEvent().SetLastPos(pos);
		}
		[SmokeMethod("lastScenePos", "() const")]
		public QPointF LastScenePos() {
			return ProxyQGraphicsSceneMouseEvent().LastScenePos();
		}
		[SmokeMethod("setLastScenePos#", "(const QPointF&)")]
		public void SetLastScenePos(QPointF pos) {
			ProxyQGraphicsSceneMouseEvent().SetLastScenePos(pos);
		}
		[SmokeMethod("lastScreenPos", "() const")]
		public QPoint LastScreenPos() {
			return ProxyQGraphicsSceneMouseEvent().LastScreenPos();
		}
		[SmokeMethod("setLastScreenPos#", "(const QPoint&)")]
		public void SetLastScreenPos(QPoint pos) {
			ProxyQGraphicsSceneMouseEvent().SetLastScreenPos(pos);
		}
		[SmokeMethod("buttons", "() const")]
		public int Buttons() {
			return ProxyQGraphicsSceneMouseEvent().Buttons();
		}
		[SmokeMethod("setButtons$", "(Qt::MouseButtons)")]
		public void SetButtons(int buttons) {
			ProxyQGraphicsSceneMouseEvent().SetButtons(buttons);
		}
		[SmokeMethod("button", "() const")]
		public Qt.MouseButton Button() {
			return ProxyQGraphicsSceneMouseEvent().Button();
		}
		[SmokeMethod("setButton$", "(Qt::MouseButton)")]
		public void SetButton(Qt.MouseButton button) {
			ProxyQGraphicsSceneMouseEvent().SetButton(button);
		}
		[SmokeMethod("modifiers", "() const")]
		public int Modifiers() {
			return ProxyQGraphicsSceneMouseEvent().Modifiers();
		}
		[SmokeMethod("setModifiers$", "(Qt::KeyboardModifiers)")]
		public void SetModifiers(int modifiers) {
			ProxyQGraphicsSceneMouseEvent().SetModifiers(modifiers);
		}
		~QGraphicsSceneMouseEvent() {
			DisposeQGraphicsSceneMouseEvent();
		}
		public new void Dispose() {
			DisposeQGraphicsSceneMouseEvent();
		}
		[SmokeMethod("~QGraphicsSceneMouseEvent", "()")]
		private void DisposeQGraphicsSceneMouseEvent() {
			ProxyQGraphicsSceneMouseEvent().DisposeQGraphicsSceneMouseEvent();
		}
	}
}
