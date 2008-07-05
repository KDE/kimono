//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QGraphicsView")]
	public class QGraphicsView : QAbstractScrollArea, IDisposable {
 		protected QGraphicsView(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGraphicsView), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QGraphicsView() {
			staticInterceptor = new SmokeInvocation(typeof(QGraphicsView), null);
		}
		public enum ViewportAnchor {
			NoAnchor = 0,
			AnchorViewCenter = 1,
			AnchorUnderMouse = 2,
		}
		public enum CacheModeFlag {
			CacheNone = 0x0,
			CacheBackground = 0x1,
		}
		public enum DragMode {
			NoDrag = 0,
			ScrollHandDrag = 1,
			RubberBandDrag = 2,
		}
		public enum ViewportUpdateMode {
			FullViewportUpdate = 0,
			MinimalViewportUpdate = 1,
			SmartViewportUpdate = 2,
			NoViewportUpdate = 3,
			BoundingRectViewportUpdate = 4,
		}
		public enum OptimizationFlag {
			DontClipPainter = 0x1,
			DontSavePainterState = 0x2,
			DontAdjustForAntialiasing = 0x4,
		}
		[Q_PROPERTY("QBrush", "backgroundBrush")]
		public QBrush BackgroundBrush {
			get { return (QBrush) interceptor.Invoke("backgroundBrush", "backgroundBrush()", typeof(QBrush)); }
			set { interceptor.Invoke("setBackgroundBrush#", "setBackgroundBrush(QBrush)", typeof(void), typeof(QBrush), value); }
		}
		[Q_PROPERTY("QBrush", "foregroundBrush")]
		public QBrush ForegroundBrush {
			get { return (QBrush) interceptor.Invoke("foregroundBrush", "foregroundBrush()", typeof(QBrush)); }
			set { interceptor.Invoke("setForegroundBrush#", "setForegroundBrush(QBrush)", typeof(void), typeof(QBrush), value); }
		}
		[Q_PROPERTY("bool", "interactive")]
		public bool Interactive {
			get { return (bool) interceptor.Invoke("isInteractive", "isInteractive()", typeof(bool)); }
			set { interceptor.Invoke("setInteractive$", "setInteractive(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QRectF", "sceneRect")]
		public QRectF SceneRect {
			get { return (QRectF) interceptor.Invoke("sceneRect", "sceneRect()", typeof(QRectF)); }
			set { interceptor.Invoke("setSceneRect#", "setSceneRect(QRectF)", typeof(void), typeof(QRectF), value); }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public uint Alignment {
			get { return (uint) interceptor.Invoke("alignment", "alignment()", typeof(uint)); }
			set { interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(uint), value); }
		}
		[Q_PROPERTY("QPainter::RenderHints", "renderHints")]
		public uint RenderHints {
			get { return (uint) interceptor.Invoke("renderHints", "renderHints()", typeof(uint)); }
			set { interceptor.Invoke("setRenderHints$", "setRenderHints(QPainter::RenderHints)", typeof(void), typeof(uint), value); }
		}
		[Q_PROPERTY("QGraphicsView::DragMode", "dragMode")]
		public QGraphicsView.DragMode dragMode {
			get { return (QGraphicsView.DragMode) interceptor.Invoke("dragMode", "dragMode()", typeof(QGraphicsView.DragMode)); }
			set { interceptor.Invoke("setDragMode$", "setDragMode(QGraphicsView::DragMode)", typeof(void), typeof(QGraphicsView.DragMode), value); }
		}
		[Q_PROPERTY("QGraphicsView::CacheMode", "cacheMode")]
		public uint CacheMode {
			get { return (uint) interceptor.Invoke("cacheMode", "cacheMode()", typeof(uint)); }
			set { interceptor.Invoke("setCacheMode$", "setCacheMode(QGraphicsView::CacheMode)", typeof(void), typeof(uint), value); }
		}
		[Q_PROPERTY("QGraphicsView::ViewportAnchor", "transformationAnchor")]
		public QGraphicsView.ViewportAnchor TransformationAnchor {
			get { return (QGraphicsView.ViewportAnchor) interceptor.Invoke("transformationAnchor", "transformationAnchor()", typeof(QGraphicsView.ViewportAnchor)); }
			set { interceptor.Invoke("setTransformationAnchor$", "setTransformationAnchor(QGraphicsView::ViewportAnchor)", typeof(void), typeof(QGraphicsView.ViewportAnchor), value); }
		}
		[Q_PROPERTY("QGraphicsView::ViewportAnchor", "resizeAnchor")]
		public QGraphicsView.ViewportAnchor ResizeAnchor {
			get { return (QGraphicsView.ViewportAnchor) interceptor.Invoke("resizeAnchor", "resizeAnchor()", typeof(QGraphicsView.ViewportAnchor)); }
			set { interceptor.Invoke("setResizeAnchor$", "setResizeAnchor(QGraphicsView::ViewportAnchor)", typeof(void), typeof(QGraphicsView.ViewportAnchor), value); }
		}
		[Q_PROPERTY("QGraphicsView::ViewportUpdateMode", "viewportUpdateMode")]
		public QGraphicsView.ViewportUpdateMode viewportUpdateMode {
			get { return (QGraphicsView.ViewportUpdateMode) interceptor.Invoke("viewportUpdateMode", "viewportUpdateMode()", typeof(QGraphicsView.ViewportUpdateMode)); }
			set { interceptor.Invoke("setViewportUpdateMode$", "setViewportUpdateMode(QGraphicsView::ViewportUpdateMode)", typeof(void), typeof(QGraphicsView.ViewportUpdateMode), value); }
		}
		[Q_PROPERTY("Qt::ItemSelectionMode", "rubberBandSelectionMode")]
		public Qt.ItemSelectionMode RubberBandSelectionMode {
			get { return (Qt.ItemSelectionMode) interceptor.Invoke("rubberBandSelectionMode", "rubberBandSelectionMode()", typeof(Qt.ItemSelectionMode)); }
			set { interceptor.Invoke("setRubberBandSelectionMode$", "setRubberBandSelectionMode(Qt::ItemSelectionMode)", typeof(void), typeof(Qt.ItemSelectionMode), value); }
		}
		[Q_PROPERTY("QGraphicsView::OptimizationFlags", "optimizationFlags")]
		public uint OptimizationFlags {
			get { return (uint) interceptor.Invoke("optimizationFlags", "optimizationFlags()", typeof(uint)); }
			set { interceptor.Invoke("setOptimizationFlags$", "setOptimizationFlags(QGraphicsView::OptimizationFlags)", typeof(void), typeof(uint), value); }
		}
		// void drawItems(QPainter* arg1,int arg2,QGraphicsItem** arg3,const QStyleOptionGraphicsItem* arg4); >>>> NOT CONVERTED
		public QGraphicsView(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsView#", "QGraphicsView(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QGraphicsView() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsView", "QGraphicsView()", typeof(void));
		}
		public QGraphicsView(QGraphicsScene scene, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsView##", "QGraphicsView(QGraphicsScene*, QWidget*)", typeof(void), typeof(QGraphicsScene), scene, typeof(QWidget), parent);
		}
		public QGraphicsView(QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsView#", "QGraphicsView(QGraphicsScene*)", typeof(void), typeof(QGraphicsScene), scene);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		public void SetRenderHint(QPainter.RenderHint hint, bool enabled) {
			interceptor.Invoke("setRenderHint$$", "setRenderHint(QPainter::RenderHint, bool)", typeof(void), typeof(QPainter.RenderHint), hint, typeof(bool), enabled);
		}
		public void SetRenderHint(QPainter.RenderHint hint) {
			interceptor.Invoke("setRenderHint$", "setRenderHint(QPainter::RenderHint)", typeof(void), typeof(QPainter.RenderHint), hint);
		}
		public void SetOptimizationFlag(QGraphicsView.OptimizationFlag flag, bool enabled) {
			interceptor.Invoke("setOptimizationFlag$$", "setOptimizationFlag(QGraphicsView::OptimizationFlag, bool)", typeof(void), typeof(QGraphicsView.OptimizationFlag), flag, typeof(bool), enabled);
		}
		public void SetOptimizationFlag(QGraphicsView.OptimizationFlag flag) {
			interceptor.Invoke("setOptimizationFlag$", "setOptimizationFlag(QGraphicsView::OptimizationFlag)", typeof(void), typeof(QGraphicsView.OptimizationFlag), flag);
		}
		public void ResetCachedContent() {
			interceptor.Invoke("resetCachedContent", "resetCachedContent()", typeof(void));
		}
		public QGraphicsScene Scene() {
			return (QGraphicsScene) interceptor.Invoke("scene", "scene() const", typeof(QGraphicsScene));
		}
		public void SetScene(QGraphicsScene scene) {
			interceptor.Invoke("setScene#", "setScene(QGraphicsScene*)", typeof(void), typeof(QGraphicsScene), scene);
		}
		public void SetSceneRect(double x, double y, double w, double h) {
			interceptor.Invoke("setSceneRect$$$$", "setSceneRect(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public QMatrix Matrix() {
			return (QMatrix) interceptor.Invoke("matrix", "matrix() const", typeof(QMatrix));
		}
		public void SetMatrix(QMatrix matrix, bool combine) {
			interceptor.Invoke("setMatrix#$", "setMatrix(const QMatrix&, bool)", typeof(void), typeof(QMatrix), matrix, typeof(bool), combine);
		}
		public void SetMatrix(QMatrix matrix) {
			interceptor.Invoke("setMatrix#", "setMatrix(const QMatrix&)", typeof(void), typeof(QMatrix), matrix);
		}
		public void ResetMatrix() {
			interceptor.Invoke("resetMatrix", "resetMatrix()", typeof(void));
		}
		public QTransform Transform() {
			return (QTransform) interceptor.Invoke("transform", "transform() const", typeof(QTransform));
		}
		public QTransform ViewportTransform() {
			return (QTransform) interceptor.Invoke("viewportTransform", "viewportTransform() const", typeof(QTransform));
		}
		public void SetTransform(QTransform matrix, bool combine) {
			interceptor.Invoke("setTransform#$", "setTransform(const QTransform&, bool)", typeof(void), typeof(QTransform), matrix, typeof(bool), combine);
		}
		public void SetTransform(QTransform matrix) {
			interceptor.Invoke("setTransform#", "setTransform(const QTransform&)", typeof(void), typeof(QTransform), matrix);
		}
		public void ResetTransform() {
			interceptor.Invoke("resetTransform", "resetTransform()", typeof(void));
		}
		public void Rotate(double angle) {
			interceptor.Invoke("rotate$", "rotate(qreal)", typeof(void), typeof(double), angle);
		}
		public void Scale(double sx, double sy) {
			interceptor.Invoke("scale$$", "scale(qreal, qreal)", typeof(void), typeof(double), sx, typeof(double), sy);
		}
		public void Shear(double sh, double sv) {
			interceptor.Invoke("shear$$", "shear(qreal, qreal)", typeof(void), typeof(double), sh, typeof(double), sv);
		}
		public void Translate(double dx, double dy) {
			interceptor.Invoke("translate$$", "translate(qreal, qreal)", typeof(void), typeof(double), dx, typeof(double), dy);
		}
		public void CenterOn(QPointF pos) {
			interceptor.Invoke("centerOn#", "centerOn(const QPointF&)", typeof(void), typeof(QPointF), pos);
		}
		public void CenterOn(double x, double y) {
			interceptor.Invoke("centerOn$$", "centerOn(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
		}
		public void CenterOn(QGraphicsItem item) {
			interceptor.Invoke("centerOn#", "centerOn(const QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), item);
		}
		public void EnsureVisible(QRectF rect, int xmargin, int ymargin) {
			interceptor.Invoke("ensureVisible#$$", "ensureVisible(const QRectF&, int, int)", typeof(void), typeof(QRectF), rect, typeof(int), xmargin, typeof(int), ymargin);
		}
		public void EnsureVisible(QRectF rect, int xmargin) {
			interceptor.Invoke("ensureVisible#$", "ensureVisible(const QRectF&, int)", typeof(void), typeof(QRectF), rect, typeof(int), xmargin);
		}
		public void EnsureVisible(QRectF rect) {
			interceptor.Invoke("ensureVisible#", "ensureVisible(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public void EnsureVisible(double x, double y, double w, double h, int xmargin, int ymargin) {
			interceptor.Invoke("ensureVisible$$$$$$", "ensureVisible(qreal, qreal, qreal, qreal, int, int)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(int), xmargin, typeof(int), ymargin);
		}
		public void EnsureVisible(double x, double y, double w, double h, int xmargin) {
			interceptor.Invoke("ensureVisible$$$$$", "ensureVisible(qreal, qreal, qreal, qreal, int)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(int), xmargin);
		}
		public void EnsureVisible(double x, double y, double w, double h) {
			interceptor.Invoke("ensureVisible$$$$", "ensureVisible(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public void EnsureVisible(QGraphicsItem item, int xmargin, int ymargin) {
			interceptor.Invoke("ensureVisible#$$", "ensureVisible(const QGraphicsItem*, int, int)", typeof(void), typeof(QGraphicsItem), item, typeof(int), xmargin, typeof(int), ymargin);
		}
		public void EnsureVisible(QGraphicsItem item, int xmargin) {
			interceptor.Invoke("ensureVisible#$", "ensureVisible(const QGraphicsItem*, int)", typeof(void), typeof(QGraphicsItem), item, typeof(int), xmargin);
		}
		public void EnsureVisible(QGraphicsItem item) {
			interceptor.Invoke("ensureVisible#", "ensureVisible(const QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), item);
		}
		public void FitInView(QRectF rect, Qt.AspectRatioMode aspectRadioMode) {
			interceptor.Invoke("fitInView#$", "fitInView(const QRectF&, Qt::AspectRatioMode)", typeof(void), typeof(QRectF), rect, typeof(Qt.AspectRatioMode), aspectRadioMode);
		}
		public void FitInView(QRectF rect) {
			interceptor.Invoke("fitInView#", "fitInView(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public void FitInView(double x, double y, double w, double h, Qt.AspectRatioMode aspectRadioMode) {
			interceptor.Invoke("fitInView$$$$$", "fitInView(qreal, qreal, qreal, qreal, Qt::AspectRatioMode)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(Qt.AspectRatioMode), aspectRadioMode);
		}
		public void FitInView(double x, double y, double w, double h) {
			interceptor.Invoke("fitInView$$$$", "fitInView(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public void FitInView(QGraphicsItem item, Qt.AspectRatioMode aspectRadioMode) {
			interceptor.Invoke("fitInView#$", "fitInView(const QGraphicsItem*, Qt::AspectRatioMode)", typeof(void), typeof(QGraphicsItem), item, typeof(Qt.AspectRatioMode), aspectRadioMode);
		}
		public void FitInView(QGraphicsItem item) {
			interceptor.Invoke("fitInView#", "fitInView(const QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), item);
		}
		public void Render(QPainter painter, QRectF target, QRect source, Qt.AspectRatioMode aspectRatioMode) {
			interceptor.Invoke("render###$", "render(QPainter*, const QRectF&, const QRect&, Qt::AspectRatioMode)", typeof(void), typeof(QPainter), painter, typeof(QRectF), target, typeof(QRect), source, typeof(Qt.AspectRatioMode), aspectRatioMode);
		}
		public void Render(QPainter painter, QRectF target, QRect source) {
			interceptor.Invoke("render###", "render(QPainter*, const QRectF&, const QRect&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), target, typeof(QRect), source);
		}
		public void Render(QPainter painter, QRectF target) {
			interceptor.Invoke("render##", "render(QPainter*, const QRectF&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), target);
		}
		public new void Render(QPainter painter) {
			interceptor.Invoke("render#", "render(QPainter*)", typeof(void), typeof(QPainter), painter);
		}
		public List<QGraphicsItem> Items() {
			return (List<QGraphicsItem>) interceptor.Invoke("items", "items() const", typeof(List<QGraphicsItem>));
		}
		public List<QGraphicsItem> Items(QPoint pos) {
			return (List<QGraphicsItem>) interceptor.Invoke("items#", "items(const QPoint&) const", typeof(List<QGraphicsItem>), typeof(QPoint), pos);
		}
		public List<QGraphicsItem> Items(int x, int y) {
			return (List<QGraphicsItem>) interceptor.Invoke("items$$", "items(int, int) const", typeof(List<QGraphicsItem>), typeof(int), x, typeof(int), y);
		}
		public List<QGraphicsItem> Items(QRect rect, Qt.ItemSelectionMode mode) {
			return (List<QGraphicsItem>) interceptor.Invoke("items#$", "items(const QRect&, Qt::ItemSelectionMode) const", typeof(List<QGraphicsItem>), typeof(QRect), rect, typeof(Qt.ItemSelectionMode), mode);
		}
		public List<QGraphicsItem> Items(QRect rect) {
			return (List<QGraphicsItem>) interceptor.Invoke("items#", "items(const QRect&) const", typeof(List<QGraphicsItem>), typeof(QRect), rect);
		}
		public List<QGraphicsItem> Items(int x, int y, int w, int h, Qt.ItemSelectionMode mode) {
			return (List<QGraphicsItem>) interceptor.Invoke("items$$$$$", "items(int, int, int, int, Qt::ItemSelectionMode) const", typeof(List<QGraphicsItem>), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h, typeof(Qt.ItemSelectionMode), mode);
		}
		public List<QGraphicsItem> Items(int x, int y, int w, int h) {
			return (List<QGraphicsItem>) interceptor.Invoke("items$$$$", "items(int, int, int, int) const", typeof(List<QGraphicsItem>), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
		}
		public List<QGraphicsItem> Items(QPolygon polygon, Qt.ItemSelectionMode mode) {
			return (List<QGraphicsItem>) interceptor.Invoke("items#$", "items(const QPolygon&, Qt::ItemSelectionMode) const", typeof(List<QGraphicsItem>), typeof(QPolygon), polygon, typeof(Qt.ItemSelectionMode), mode);
		}
		public List<QGraphicsItem> Items(QPolygon polygon) {
			return (List<QGraphicsItem>) interceptor.Invoke("items#", "items(const QPolygon&) const", typeof(List<QGraphicsItem>), typeof(QPolygon), polygon);
		}
		public List<QGraphicsItem> Items(QPainterPath path, Qt.ItemSelectionMode mode) {
			return (List<QGraphicsItem>) interceptor.Invoke("items#$", "items(const QPainterPath&, Qt::ItemSelectionMode) const", typeof(List<QGraphicsItem>), typeof(QPainterPath), path, typeof(Qt.ItemSelectionMode), mode);
		}
		public List<QGraphicsItem> Items(QPainterPath path) {
			return (List<QGraphicsItem>) interceptor.Invoke("items#", "items(const QPainterPath&) const", typeof(List<QGraphicsItem>), typeof(QPainterPath), path);
		}
		public QGraphicsItem ItemAt(QPoint pos) {
			return (QGraphicsItem) interceptor.Invoke("itemAt#", "itemAt(const QPoint&) const", typeof(QGraphicsItem), typeof(QPoint), pos);
		}
		public QGraphicsItem ItemAt(int x, int y) {
			return (QGraphicsItem) interceptor.Invoke("itemAt$$", "itemAt(int, int) const", typeof(QGraphicsItem), typeof(int), x, typeof(int), y);
		}
		public QPointF MapToScene(QPoint point) {
			return (QPointF) interceptor.Invoke("mapToScene#", "mapToScene(const QPoint&) const", typeof(QPointF), typeof(QPoint), point);
		}
		public QPolygonF MapToScene(QRect rect) {
			return (QPolygonF) interceptor.Invoke("mapToScene#", "mapToScene(const QRect&) const", typeof(QPolygonF), typeof(QRect), rect);
		}
		public QPolygonF MapToScene(QPolygon polygon) {
			return (QPolygonF) interceptor.Invoke("mapToScene#", "mapToScene(const QPolygon&) const", typeof(QPolygonF), typeof(QPolygon), polygon);
		}
		public QPainterPath MapToScene(QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapToScene#", "mapToScene(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), path);
		}
		public QPoint MapFromScene(QPointF point) {
			return (QPoint) interceptor.Invoke("mapFromScene#", "mapFromScene(const QPointF&) const", typeof(QPoint), typeof(QPointF), point);
		}
		public QPolygon MapFromScene(QRectF rect) {
			return (QPolygon) interceptor.Invoke("mapFromScene#", "mapFromScene(const QRectF&) const", typeof(QPolygon), typeof(QRectF), rect);
		}
		public QPolygon MapFromScene(QPolygonF polygon) {
			return (QPolygon) interceptor.Invoke("mapFromScene#", "mapFromScene(const QPolygonF&) const", typeof(QPolygon), typeof(QPolygonF), polygon);
		}
		public QPainterPath MapFromScene(QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("mapFromScene#", "mapFromScene(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), path);
		}
		public QPointF MapToScene(int x, int y) {
			return (QPointF) interceptor.Invoke("mapToScene$$", "mapToScene(int, int) const", typeof(QPointF), typeof(int), x, typeof(int), y);
		}
		public QPolygonF MapToScene(int x, int y, int w, int h) {
			return (QPolygonF) interceptor.Invoke("mapToScene$$$$", "mapToScene(int, int, int, int) const", typeof(QPolygonF), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
		}
		public QPoint MapFromScene(double x, double y) {
			return (QPoint) interceptor.Invoke("mapFromScene$$", "mapFromScene(qreal, qreal) const", typeof(QPoint), typeof(double), x, typeof(double), y);
		}
		public QPolygon MapFromScene(double x, double y, double w, double h) {
			return (QPolygon) interceptor.Invoke("mapFromScene$$$$", "mapFromScene(qreal, qreal, qreal, qreal) const", typeof(QPolygon), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		[SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
		public override QVariant InputMethodQuery(Qt.InputMethodQuery query) {
			return (QVariant) interceptor.Invoke("inputMethodQuery$", "inputMethodQuery(Qt::InputMethodQuery) const", typeof(QVariant), typeof(Qt.InputMethodQuery), query);
		}
		[Q_SLOT("void updateScene(QList<QRectF>)")]
		public void UpdateScene(List<QRectF> rects) {
			interceptor.Invoke("updateScene?", "updateScene(const QList<QRectF>&)", typeof(void), typeof(List<QRectF>), rects);
		}
		[Q_SLOT("void invalidateScene(QRectF, QGraphicsScene::SceneLayers)")]
		public void InvalidateScene(QRectF rect, uint layers) {
			interceptor.Invoke("invalidateScene#$", "invalidateScene(const QRectF&, QGraphicsScene::SceneLayers)", typeof(void), typeof(QRectF), rect, typeof(uint), layers);
		}
		[Q_SLOT("void invalidateScene(QRectF)")]
		public void InvalidateScene(QRectF rect) {
			interceptor.Invoke("invalidateScene#", "invalidateScene(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		[Q_SLOT("void invalidateScene()")]
		public void InvalidateScene() {
			interceptor.Invoke("invalidateScene", "invalidateScene()", typeof(void));
		}
		[Q_SLOT("void updateSceneRect(QRectF)")]
		public void UpdateSceneRect(QRectF rect) {
			interceptor.Invoke("updateSceneRect#", "updateSceneRect(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("viewportEvent(QEvent*)")]
		protected override bool ViewportEvent(QEvent arg1) {
			return (bool) interceptor.Invoke("viewportEvent#", "viewportEvent(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected override void DragEnterEvent(QDragEnterEvent arg1) {
			interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QDragEnterEvent*)", typeof(void), typeof(QDragEnterEvent), arg1);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected override void DragLeaveEvent(QDragLeaveEvent arg1) {
			interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QDragLeaveEvent*)", typeof(void), typeof(QDragLeaveEvent), arg1);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected override void DragMoveEvent(QDragMoveEvent arg1) {
			interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QDragMoveEvent*)", typeof(void), typeof(QDragMoveEvent), arg1);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected override void DropEvent(QDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected override bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected override void KeyReleaseEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyReleaseEvent#", "keyReleaseEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected override void MouseDoubleClickEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent arg1) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected override void ScrollContentsBy(int dx, int dy) {
			interceptor.Invoke("scrollContentsBy$$", "scrollContentsBy(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent arg1) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
		}
		[SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
		protected override void InputMethodEvent(QInputMethodEvent arg1) {
			interceptor.Invoke("inputMethodEvent#", "inputMethodEvent(QInputMethodEvent*)", typeof(void), typeof(QInputMethodEvent), arg1);
		}
		[SmokeMethod("drawBackground(QPainter*, const QRectF&)")]
		protected virtual void DrawBackground(QPainter painter, QRectF rect) {
			interceptor.Invoke("drawBackground##", "drawBackground(QPainter*, const QRectF&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect);
		}
		[SmokeMethod("drawForeground(QPainter*, const QRectF&)")]
		protected virtual void DrawForeground(QPainter painter, QRectF rect) {
			interceptor.Invoke("drawForeground##", "drawForeground(QPainter*, const QRectF&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect);
		}
		[Q_SLOT("void setupViewport(QWidget*)")]
		protected new void SetupViewport(QWidget widget) {
			interceptor.Invoke("setupViewport#", "setupViewport(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		~QGraphicsView() {
			interceptor.Invoke("~QGraphicsView", "~QGraphicsView()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QGraphicsView", "~QGraphicsView()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQGraphicsViewSignals Emit {
			get { return (IQGraphicsViewSignals) Q_EMIT; }
		}
	}

	public interface IQGraphicsViewSignals : IQAbstractScrollAreaSignals {
	}
}
