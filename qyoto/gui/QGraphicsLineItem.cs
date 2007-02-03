//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsLineItem")]
	public class QGraphicsLineItem : QGraphicsItem, IDisposable {
 		protected QGraphicsLineItem(Type dummy) : base((Type) null) {}
		interface IQGraphicsLineItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsLineItem), this);
			_interceptor = (QGraphicsLineItem) realProxy.GetTransparentProxy();
		}
		private QGraphicsLineItem ProxyQGraphicsLineItem() {
			return (QGraphicsLineItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsLineItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsLineItemProxy), null);
			_staticInterceptor = (IQGraphicsLineItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsLineItemProxy StaticQGraphicsLineItem() {
			return (IQGraphicsLineItemProxy) _staticInterceptor;
		}

		public const int Type = 6;

		public QGraphicsLineItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(parent,scene);
		}
		[SmokeMethod("QGraphicsLineItem##", "(QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsLineItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(parent,scene);
		}
		public QGraphicsLineItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(parent);
		}
		[SmokeMethod("QGraphicsLineItem#", "(QGraphicsItem*)")]
		private void NewQGraphicsLineItem(QGraphicsItem parent) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(parent);
		}
		public QGraphicsLineItem() : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem();
		}
		[SmokeMethod("QGraphicsLineItem", "()")]
		private void NewQGraphicsLineItem() {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem();
		}
		public QGraphicsLineItem(QLineF line, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(line,parent,scene);
		}
		[SmokeMethod("QGraphicsLineItem###", "(const QLineF&, QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsLineItem(QLineF line, QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(line,parent,scene);
		}
		public QGraphicsLineItem(QLineF line, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(line,parent);
		}
		[SmokeMethod("QGraphicsLineItem##", "(const QLineF&, QGraphicsItem*)")]
		private void NewQGraphicsLineItem(QLineF line, QGraphicsItem parent) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(line,parent);
		}
		public QGraphicsLineItem(QLineF line) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(line);
		}
		[SmokeMethod("QGraphicsLineItem#", "(const QLineF&)")]
		private void NewQGraphicsLineItem(QLineF line) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(line);
		}
		public QGraphicsLineItem(double x1, double y1, double x2, double y2, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(x1,y1,x2,y2,parent,scene);
		}
		[SmokeMethod("QGraphicsLineItem$$$$##", "(qreal, qreal, qreal, qreal, QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsLineItem(double x1, double y1, double x2, double y2, QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(x1,y1,x2,y2,parent,scene);
		}
		public QGraphicsLineItem(double x1, double y1, double x2, double y2, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(x1,y1,x2,y2,parent);
		}
		[SmokeMethod("QGraphicsLineItem$$$$#", "(qreal, qreal, qreal, qreal, QGraphicsItem*)")]
		private void NewQGraphicsLineItem(double x1, double y1, double x2, double y2, QGraphicsItem parent) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(x1,y1,x2,y2,parent);
		}
		public QGraphicsLineItem(double x1, double y1, double x2, double y2) : this((Type) null) {
			CreateProxy();
			NewQGraphicsLineItem(x1,y1,x2,y2);
		}
		[SmokeMethod("QGraphicsLineItem$$$$", "(qreal, qreal, qreal, qreal)")]
		private void NewQGraphicsLineItem(double x1, double y1, double x2, double y2) {
			ProxyQGraphicsLineItem().NewQGraphicsLineItem(x1,y1,x2,y2);
		}
		[SmokeMethod("pen", "() const")]
		public QPen Pen() {
			return ProxyQGraphicsLineItem().Pen();
		}
		[SmokeMethod("setPen#", "(const QPen&)")]
		public void SetPen(QPen pen) {
			ProxyQGraphicsLineItem().SetPen(pen);
		}
		[SmokeMethod("line", "() const")]
		public QLineF Line() {
			return ProxyQGraphicsLineItem().Line();
		}
		[SmokeMethod("setLine#", "(const QLineF&)")]
		public void SetLine(QLineF line) {
			ProxyQGraphicsLineItem().SetLine(line);
		}
		[SmokeMethod("setLine$$$$", "(qreal, qreal, qreal, qreal)")]
		public void SetLine(double x1, double y1, double x2, double y2) {
			ProxyQGraphicsLineItem().SetLine(x1,y1,x2,y2);
		}
		[SmokeMethod("boundingRect", "() const")]
		public new QRectF BoundingRect() {
			return ProxyQGraphicsLineItem().BoundingRect();
		}
		[SmokeMethod("shape", "() const")]
		public new QPainterPath Shape() {
			return ProxyQGraphicsLineItem().Shape();
		}
		[SmokeMethod("contains#", "(const QPointF&) const")]
		public new bool Contains(QPointF point) {
			return ProxyQGraphicsLineItem().Contains(point);
		}
		[SmokeMethod("paint###", "(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsLineItem().Paint(painter,option,widget);
		}
		[SmokeMethod("paint##", "(QPainter*, const QStyleOptionGraphicsItem*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			ProxyQGraphicsLineItem().Paint(painter,option);
		}
		[SmokeMethod("isObscuredBy#", "(const QGraphicsItem*) const")]
		public new bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsLineItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea", "() const")]
		public new QPainterPath OpaqueArea() {
			return ProxyQGraphicsLineItem().OpaqueArea();
		}
		[SmokeMethod("type", "() const")]
		public new int type() {
			return ProxyQGraphicsLineItem().type();
		}
		[SmokeMethod("supportsExtension$", "(QGraphicsItem::Extension) const")]
		protected new bool SupportsExtension(QGraphicsItem.Extension extension) {
			return ProxyQGraphicsLineItem().SupportsExtension(extension);
		}
		[SmokeMethod("setExtension$#", "(QGraphicsItem::Extension, const QVariant&)")]
		protected new void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			ProxyQGraphicsLineItem().SetExtension(extension,variant);
		}
		[SmokeMethod("extension#", "(const QVariant&) const")]
		protected new QVariant Extension(QVariant variant) {
			return ProxyQGraphicsLineItem().Extension(variant);
		}
		~QGraphicsLineItem() {
			DisposeQGraphicsLineItem();
		}
		public void Dispose() {
			DisposeQGraphicsLineItem();
		}
		[SmokeMethod("~QGraphicsLineItem", "()")]
		private void DisposeQGraphicsLineItem() {
			ProxyQGraphicsLineItem().DisposeQGraphicsLineItem();
		}
	}
}
