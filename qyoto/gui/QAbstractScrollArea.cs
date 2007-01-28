//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QAbstractScrollArea")]
	public class QAbstractScrollArea : QFrame, IDisposable {
 		protected QAbstractScrollArea(Type dummy) : base((Type) null) {}
		interface IQAbstractScrollAreaProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractScrollArea), this);
			_interceptor = (QAbstractScrollArea) realProxy.GetTransparentProxy();
		}
		private QAbstractScrollArea ProxyQAbstractScrollArea() {
			return (QAbstractScrollArea) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractScrollArea() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractScrollAreaProxy), null);
			_staticInterceptor = (IQAbstractScrollAreaProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractScrollAreaProxy StaticQAbstractScrollArea() {
			return (IQAbstractScrollAreaProxy) _staticInterceptor;
		}

		public Qt.ScrollBarPolicy VerticalScrollBarPolicy {
			get {
				return Property("verticalScrollBarPolicy").Value<Qt.ScrollBarPolicy>();
			}
			set {
				SetProperty("verticalScrollBarPolicy", QVariant.FromValue<Qt.ScrollBarPolicy>(value));
			}
		}
		public Qt.ScrollBarPolicy HorizontalScrollBarPolicy {
			get {
				return Property("horizontalScrollBarPolicy").Value<Qt.ScrollBarPolicy>();
			}
			set {
				SetProperty("horizontalScrollBarPolicy", QVariant.FromValue<Qt.ScrollBarPolicy>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QAbstractScrollArea(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractScrollArea(parent);
		}
		[SmokeMethod("QAbstractScrollArea(QWidget*)")]
		private void NewQAbstractScrollArea(QWidget parent) {
			ProxyQAbstractScrollArea().NewQAbstractScrollArea(parent);
		}
		public QAbstractScrollArea() : this((Type) null) {
			CreateProxy();
			NewQAbstractScrollArea();
		}
		[SmokeMethod("QAbstractScrollArea()")]
		private void NewQAbstractScrollArea() {
			ProxyQAbstractScrollArea().NewQAbstractScrollArea();
		}
		[SmokeMethod("verticalScrollBar() const")]
		public QScrollBar VerticalScrollBar() {
			return ProxyQAbstractScrollArea().VerticalScrollBar();
		}
		[SmokeMethod("setVerticalScrollBar(QScrollBar*)")]
		public void SetVerticalScrollBar(QScrollBar scrollbar) {
			ProxyQAbstractScrollArea().SetVerticalScrollBar(scrollbar);
		}
		[SmokeMethod("horizontalScrollBar() const")]
		public QScrollBar HorizontalScrollBar() {
			return ProxyQAbstractScrollArea().HorizontalScrollBar();
		}
		[SmokeMethod("setHorizontalScrollBar(QScrollBar*)")]
		public void SetHorizontalScrollBar(QScrollBar scrollbar) {
			ProxyQAbstractScrollArea().SetHorizontalScrollBar(scrollbar);
		}
		[SmokeMethod("cornerWidget() const")]
		public QWidget CornerWidget() {
			return ProxyQAbstractScrollArea().CornerWidget();
		}
		[SmokeMethod("setCornerWidget(QWidget*)")]
		public void SetCornerWidget(QWidget widget) {
			ProxyQAbstractScrollArea().SetCornerWidget(widget);
		}
		[SmokeMethod("addScrollBarWidget(QWidget*, Qt::Alignment)")]
		public void AddScrollBarWidget(QWidget widget, int alignment) {
			ProxyQAbstractScrollArea().AddScrollBarWidget(widget,alignment);
		}
		[SmokeMethod("scrollBarWidgets(Qt::Alignment)")]
		public List<QWidget> ScrollBarWidgets(int alignment) {
			return ProxyQAbstractScrollArea().ScrollBarWidgets(alignment);
		}
		[SmokeMethod("viewport() const")]
		public QWidget Viewport() {
			return ProxyQAbstractScrollArea().Viewport();
		}
		[SmokeMethod("setViewport(QWidget*)")]
		public void SetViewport(QWidget widget) {
			ProxyQAbstractScrollArea().SetViewport(widget);
		}
		[SmokeMethod("maximumViewportSize() const")]
		public QSize MaximumViewportSize() {
			return ProxyQAbstractScrollArea().MaximumViewportSize();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQAbstractScrollArea().MinimumSizeHint();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQAbstractScrollArea().SizeHint();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQAbstractScrollArea().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQAbstractScrollArea().Tr(s);
		}
		[SmokeMethod("setupViewport(QWidget*)")]
		protected void SetupViewport(QWidget viewport) {
			ProxyQAbstractScrollArea().SetupViewport(viewport);
		}
		[SmokeMethod("setViewportMargins(int, int, int, int)")]
		protected void SetViewportMargins(int left, int top, int right, int bottom) {
			ProxyQAbstractScrollArea().SetViewportMargins(left,top,right,bottom);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQAbstractScrollArea().Event(arg1);
		}
		[SmokeMethod("viewportEvent(QEvent*)")]
		protected virtual bool ViewportEvent(QEvent arg1) {
			return ProxyQAbstractScrollArea().ViewportEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQAbstractScrollArea().ResizeEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQAbstractScrollArea().PaintEvent(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQAbstractScrollArea().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQAbstractScrollArea().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected new void MouseDoubleClickEvent(QMouseEvent arg1) {
			ProxyQAbstractScrollArea().MouseDoubleClickEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQAbstractScrollArea().MouseMoveEvent(arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent arg1) {
			ProxyQAbstractScrollArea().WheelEvent(arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected new void ContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQAbstractScrollArea().ContextMenuEvent(arg1);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected new void DragEnterEvent(QDragEnterEvent arg1) {
			ProxyQAbstractScrollArea().DragEnterEvent(arg1);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected new void DragMoveEvent(QDragMoveEvent arg1) {
			ProxyQAbstractScrollArea().DragMoveEvent(arg1);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected new void DragLeaveEvent(QDragLeaveEvent arg1) {
			ProxyQAbstractScrollArea().DragLeaveEvent(arg1);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected new void DropEvent(QDropEvent arg1) {
			ProxyQAbstractScrollArea().DropEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQAbstractScrollArea().KeyPressEvent(arg1);
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected virtual void ScrollContentsBy(int dx, int dy) {
			ProxyQAbstractScrollArea().ScrollContentsBy(dx,dy);
		}
		~QAbstractScrollArea() {
			DisposeQAbstractScrollArea();
		}
		public new void Dispose() {
			DisposeQAbstractScrollArea();
		}
		[SmokeMethod("~QAbstractScrollArea()")]
		private void DisposeQAbstractScrollArea() {
			ProxyQAbstractScrollArea().DisposeQAbstractScrollArea();
		}
		protected new IQAbstractScrollAreaSignals Emit {
			get {
				return (IQAbstractScrollAreaSignals) Q_EMIT;
			}
		}
	}

	public interface IQAbstractScrollAreaSignals : IQFrameSignals {
	}
}