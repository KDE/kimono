//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsPixmapItem")]
	public class QGraphicsPixmapItem : QGraphicsItem, IDisposable {
 		protected QGraphicsPixmapItem(Type dummy) : base((Type) null) {}
		interface IQGraphicsPixmapItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsPixmapItem), this);
			_interceptor = (QGraphicsPixmapItem) realProxy.GetTransparentProxy();
		}
		private QGraphicsPixmapItem ProxyQGraphicsPixmapItem() {
			return (QGraphicsPixmapItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsPixmapItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsPixmapItemProxy), null);
			_staticInterceptor = (IQGraphicsPixmapItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsPixmapItemProxy StaticQGraphicsPixmapItem() {
			return (IQGraphicsPixmapItemProxy) _staticInterceptor;
		}

		public enum ShapeMode {
			MaskShape = 0,
			BoundingRectShape = 1,
			HeuristicMaskShape = 2,
		}
		public const int Type = 7;

		public QGraphicsPixmapItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPixmapItem(parent,scene);
		}
		[SmokeMethod("QGraphicsPixmapItem##", "(QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsPixmapItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsPixmapItem().NewQGraphicsPixmapItem(parent,scene);
		}
		public QGraphicsPixmapItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPixmapItem(parent);
		}
		[SmokeMethod("QGraphicsPixmapItem#", "(QGraphicsItem*)")]
		private void NewQGraphicsPixmapItem(QGraphicsItem parent) {
			ProxyQGraphicsPixmapItem().NewQGraphicsPixmapItem(parent);
		}
		public QGraphicsPixmapItem() : this((Type) null) {
			CreateProxy();
			NewQGraphicsPixmapItem();
		}
		[SmokeMethod("QGraphicsPixmapItem", "()")]
		private void NewQGraphicsPixmapItem() {
			ProxyQGraphicsPixmapItem().NewQGraphicsPixmapItem();
		}
		public QGraphicsPixmapItem(QPixmap pixmap, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPixmapItem(pixmap,parent,scene);
		}
		[SmokeMethod("QGraphicsPixmapItem###", "(const QPixmap&, QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsPixmapItem(QPixmap pixmap, QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsPixmapItem().NewQGraphicsPixmapItem(pixmap,parent,scene);
		}
		public QGraphicsPixmapItem(QPixmap pixmap, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPixmapItem(pixmap,parent);
		}
		[SmokeMethod("QGraphicsPixmapItem##", "(const QPixmap&, QGraphicsItem*)")]
		private void NewQGraphicsPixmapItem(QPixmap pixmap, QGraphicsItem parent) {
			ProxyQGraphicsPixmapItem().NewQGraphicsPixmapItem(pixmap,parent);
		}
		public QGraphicsPixmapItem(QPixmap pixmap) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPixmapItem(pixmap);
		}
		[SmokeMethod("QGraphicsPixmapItem#", "(const QPixmap&)")]
		private void NewQGraphicsPixmapItem(QPixmap pixmap) {
			ProxyQGraphicsPixmapItem().NewQGraphicsPixmapItem(pixmap);
		}
		[SmokeMethod("pixmap", "() const")]
		public QPixmap Pixmap() {
			return ProxyQGraphicsPixmapItem().Pixmap();
		}
		[SmokeMethod("setPixmap#", "(const QPixmap&)")]
		public void SetPixmap(QPixmap pixmap) {
			ProxyQGraphicsPixmapItem().SetPixmap(pixmap);
		}
		[SmokeMethod("transformationMode", "() const")]
		public Qt.TransformationMode TransformationMode() {
			return ProxyQGraphicsPixmapItem().TransformationMode();
		}
		[SmokeMethod("setTransformationMode$", "(Qt::TransformationMode)")]
		public void SetTransformationMode(Qt.TransformationMode mode) {
			ProxyQGraphicsPixmapItem().SetTransformationMode(mode);
		}
		[SmokeMethod("offset", "() const")]
		public QPointF Offset() {
			return ProxyQGraphicsPixmapItem().Offset();
		}
		[SmokeMethod("setOffset#", "(const QPointF&)")]
		public void SetOffset(QPointF offset) {
			ProxyQGraphicsPixmapItem().SetOffset(offset);
		}
		[SmokeMethod("boundingRect", "() const")]
		public new QRectF BoundingRect() {
			return ProxyQGraphicsPixmapItem().BoundingRect();
		}
		[SmokeMethod("shape", "() const")]
		public new QPainterPath Shape() {
			return ProxyQGraphicsPixmapItem().Shape();
		}
		[SmokeMethod("contains#", "(const QPointF&) const")]
		public new bool Contains(QPointF point) {
			return ProxyQGraphicsPixmapItem().Contains(point);
		}
		[SmokeMethod("paint###", "(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsPixmapItem().Paint(painter,option,widget);
		}
		[SmokeMethod("isObscuredBy#", "(const QGraphicsItem*) const")]
		public new bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsPixmapItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea", "() const")]
		public new QPainterPath OpaqueArea() {
			return ProxyQGraphicsPixmapItem().OpaqueArea();
		}
		[SmokeMethod("type", "() const")]
		public new int type() {
			return ProxyQGraphicsPixmapItem().type();
		}
		[SmokeMethod("shapeMode", "() const")]
		public QGraphicsPixmapItem.ShapeMode shapeMode() {
			return ProxyQGraphicsPixmapItem().shapeMode();
		}
		[SmokeMethod("setShapeMode$", "(QGraphicsPixmapItem::ShapeMode)")]
		public void SetShapeMode(QGraphicsPixmapItem.ShapeMode mode) {
			ProxyQGraphicsPixmapItem().SetShapeMode(mode);
		}
		[SmokeMethod("supportsExtension$", "(QGraphicsItem::Extension) const")]
		protected new bool SupportsExtension(QGraphicsItem.Extension extension) {
			return ProxyQGraphicsPixmapItem().SupportsExtension(extension);
		}
		[SmokeMethod("setExtension$#", "(QGraphicsItem::Extension, const QVariant&)")]
		protected new void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			ProxyQGraphicsPixmapItem().SetExtension(extension,variant);
		}
		[SmokeMethod("extension#", "(const QVariant&) const")]
		protected new QVariant Extension(QVariant variant) {
			return ProxyQGraphicsPixmapItem().Extension(variant);
		}
		~QGraphicsPixmapItem() {
			DisposeQGraphicsPixmapItem();
		}
		public void Dispose() {
			DisposeQGraphicsPixmapItem();
		}
		[SmokeMethod("~QGraphicsPixmapItem", "()")]
		private void DisposeQGraphicsPixmapItem() {
			ProxyQGraphicsPixmapItem().DisposeQGraphicsPixmapItem();
		}
	}
}
