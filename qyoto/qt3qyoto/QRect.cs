//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QRect")]
	public class QRect : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QRect(Type dummy) {}
		interface IQRectProxy {
			QRect op_or(QRect lhs, QRect r);
			QRect op_and(QRect lhs, QRect r);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRect), this);
			_interceptor = (QRect) realProxy.GetTransparentProxy();
		}
		private QRect ProxyQRect() {
			return (QRect) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QRect() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRectProxy), null);
			_staticInterceptor = (IQRectProxy) realProxy.GetTransparentProxy();
		}
		private static IQRectProxy StaticQRect() {
			return (IQRectProxy) _staticInterceptor;
		}

		public QRect() : this((Type) null) {
			CreateProxy();
			NewQRect();
		}
		[SmokeMethod("QRect()")]
		private void NewQRect() {
			ProxyQRect().NewQRect();
		}
		public QRect(QPoint topleft, QPoint bottomright) : this((Type) null) {
			CreateProxy();
			NewQRect(topleft,bottomright);
		}
		[SmokeMethod("QRect(const QPoint&, const QPoint&)")]
		private void NewQRect(QPoint topleft, QPoint bottomright) {
			ProxyQRect().NewQRect(topleft,bottomright);
		}
		public QRect(QPoint topleft, QSize size) : this((Type) null) {
			CreateProxy();
			NewQRect(topleft,size);
		}
		[SmokeMethod("QRect(const QPoint&, const QSize&)")]
		private void NewQRect(QPoint topleft, QSize size) {
			ProxyQRect().NewQRect(topleft,size);
		}
		public QRect(int left, int top, int width, int height) : this((Type) null) {
			CreateProxy();
			NewQRect(left,top,width,height);
		}
		[SmokeMethod("QRect(int, int, int, int)")]
		private void NewQRect(int left, int top, int width, int height) {
			ProxyQRect().NewQRect(left,top,width,height);
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQRect().IsNull();
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQRect().IsEmpty();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQRect().IsValid();
		}
		[SmokeMethod("normalize() const")]
		public QRect Normalize() {
			return ProxyQRect().Normalize();
		}
		[SmokeMethod("left() const")]
		public int Left() {
			return ProxyQRect().Left();
		}
		[SmokeMethod("top() const")]
		public int Top() {
			return ProxyQRect().Top();
		}
		[SmokeMethod("right() const")]
		public int Right() {
			return ProxyQRect().Right();
		}
		[SmokeMethod("bottom() const")]
		public int Bottom() {
			return ProxyQRect().Bottom();
		}
		[SmokeMethod("rLeft()")]
		public short RLeft() {
			return ProxyQRect().RLeft();
		}
		[SmokeMethod("rTop()")]
		public short RTop() {
			return ProxyQRect().RTop();
		}
		[SmokeMethod("rRight()")]
		public short RRight() {
			return ProxyQRect().RRight();
		}
		[SmokeMethod("rBottom()")]
		public short RBottom() {
			return ProxyQRect().RBottom();
		}
		[SmokeMethod("x() const")]
		public int X() {
			return ProxyQRect().X();
		}
		[SmokeMethod("y() const")]
		public int Y() {
			return ProxyQRect().Y();
		}
		[SmokeMethod("setLeft(int)")]
		public void SetLeft(int pos) {
			ProxyQRect().SetLeft(pos);
		}
		[SmokeMethod("setTop(int)")]
		public void SetTop(int pos) {
			ProxyQRect().SetTop(pos);
		}
		[SmokeMethod("setRight(int)")]
		public void SetRight(int pos) {
			ProxyQRect().SetRight(pos);
		}
		[SmokeMethod("setBottom(int)")]
		public void SetBottom(int pos) {
			ProxyQRect().SetBottom(pos);
		}
		[SmokeMethod("setX(int)")]
		public void SetX(int x) {
			ProxyQRect().SetX(x);
		}
		[SmokeMethod("setY(int)")]
		public void SetY(int y) {
			ProxyQRect().SetY(y);
		}
		[SmokeMethod("setTopLeft(const QPoint&)")]
		public void SetTopLeft(QPoint p) {
			ProxyQRect().SetTopLeft(p);
		}
		[SmokeMethod("setBottomRight(const QPoint&)")]
		public void SetBottomRight(QPoint p) {
			ProxyQRect().SetBottomRight(p);
		}
		[SmokeMethod("setTopRight(const QPoint&)")]
		public void SetTopRight(QPoint p) {
			ProxyQRect().SetTopRight(p);
		}
		[SmokeMethod("setBottomLeft(const QPoint&)")]
		public void SetBottomLeft(QPoint p) {
			ProxyQRect().SetBottomLeft(p);
		}
		[SmokeMethod("topLeft() const")]
		public QPoint TopLeft() {
			return ProxyQRect().TopLeft();
		}
		[SmokeMethod("bottomRight() const")]
		public QPoint BottomRight() {
			return ProxyQRect().BottomRight();
		}
		[SmokeMethod("topRight() const")]
		public QPoint TopRight() {
			return ProxyQRect().TopRight();
		}
		[SmokeMethod("bottomLeft() const")]
		public QPoint BottomLeft() {
			return ProxyQRect().BottomLeft();
		}
		[SmokeMethod("center() const")]
		public QPoint Center() {
			return ProxyQRect().Center();
		}
		[SmokeMethod("rect(int*, int*, int*, int*) const")]
		public void Rect(out int x, out int y, out int w, out int h) {
			ProxyQRect().Rect(out x,out y,out w,out h);
		}
		[SmokeMethod("coords(int*, int*, int*, int*) const")]
		public void Coords(out int x1, out int y1, out int x2, out int y2) {
			ProxyQRect().Coords(out x1,out y1,out x2,out y2);
		}
		[SmokeMethod("moveLeft(int)")]
		public void MoveLeft(int pos) {
			ProxyQRect().MoveLeft(pos);
		}
		[SmokeMethod("moveTop(int)")]
		public void MoveTop(int pos) {
			ProxyQRect().MoveTop(pos);
		}
		[SmokeMethod("moveRight(int)")]
		public void MoveRight(int pos) {
			ProxyQRect().MoveRight(pos);
		}
		[SmokeMethod("moveBottom(int)")]
		public void MoveBottom(int pos) {
			ProxyQRect().MoveBottom(pos);
		}
		[SmokeMethod("moveTopLeft(const QPoint&)")]
		public void MoveTopLeft(QPoint p) {
			ProxyQRect().MoveTopLeft(p);
		}
		[SmokeMethod("moveBottomRight(const QPoint&)")]
		public void MoveBottomRight(QPoint p) {
			ProxyQRect().MoveBottomRight(p);
		}
		[SmokeMethod("moveTopRight(const QPoint&)")]
		public void MoveTopRight(QPoint p) {
			ProxyQRect().MoveTopRight(p);
		}
		[SmokeMethod("moveBottomLeft(const QPoint&)")]
		public void MoveBottomLeft(QPoint p) {
			ProxyQRect().MoveBottomLeft(p);
		}
		[SmokeMethod("moveCenter(const QPoint&)")]
		public void MoveCenter(QPoint p) {
			ProxyQRect().MoveCenter(p);
		}
		[SmokeMethod("moveBy(int, int)")]
		public void MoveBy(int dx, int dy) {
			ProxyQRect().MoveBy(dx,dy);
		}
		[SmokeMethod("setRect(int, int, int, int)")]
		public void SetRect(int x, int y, int w, int h) {
			ProxyQRect().SetRect(x,y,w,h);
		}
		[SmokeMethod("setCoords(int, int, int, int)")]
		public void SetCoords(int x1, int y1, int x2, int y2) {
			ProxyQRect().SetCoords(x1,y1,x2,y2);
		}
		[SmokeMethod("addCoords(int, int, int, int)")]
		public void AddCoords(int x1, int y1, int x2, int y2) {
			ProxyQRect().AddCoords(x1,y1,x2,y2);
		}
		[SmokeMethod("size() const")]
		public QSize Size() {
			return ProxyQRect().Size();
		}
		[SmokeMethod("width() const")]
		public int Width() {
			return ProxyQRect().Width();
		}
		[SmokeMethod("height() const")]
		public int Height() {
			return ProxyQRect().Height();
		}
		[SmokeMethod("setWidth(int)")]
		public void SetWidth(int w) {
			ProxyQRect().SetWidth(w);
		}
		[SmokeMethod("setHeight(int)")]
		public void SetHeight(int h) {
			ProxyQRect().SetHeight(h);
		}
		[SmokeMethod("setSize(const QSize&)")]
		public void SetSize(QSize s) {
			ProxyQRect().SetSize(s);
		}
		[SmokeMethod("operator|(const QRect&) const")]
		public static QRect operator|(QRect lhs, QRect r) {
			return StaticQRect().op_or(lhs,r);
		}
		[SmokeMethod("operator&(const QRect&) const")]
		public static QRect operator&(QRect lhs, QRect r) {
			return StaticQRect().op_and(lhs,r);
		}
		[SmokeMethod("contains(const QPoint&, bool) const")]
		public bool Contains(QPoint p, bool proper) {
			return ProxyQRect().Contains(p,proper);
		}
		[SmokeMethod("contains(const QPoint&) const")]
		public bool Contains(QPoint p) {
			return ProxyQRect().Contains(p);
		}
		[SmokeMethod("contains(int, int) const")]
		public bool Contains(int x, int y) {
			return ProxyQRect().Contains(x,y);
		}
		[SmokeMethod("contains(int, int, bool) const")]
		public bool Contains(int x, int y, bool proper) {
			return ProxyQRect().Contains(x,y,proper);
		}
		[SmokeMethod("contains(const QRect&, bool) const")]
		public bool Contains(QRect r, bool proper) {
			return ProxyQRect().Contains(r,proper);
		}
		[SmokeMethod("contains(const QRect&) const")]
		public bool Contains(QRect r) {
			return ProxyQRect().Contains(r);
		}
		[SmokeMethod("unite(const QRect&) const")]
		public QRect Unite(QRect r) {
			return ProxyQRect().Unite(r);
		}
		[SmokeMethod("intersect(const QRect&) const")]
		public QRect Intersect(QRect r) {
			return ProxyQRect().Intersect(r);
		}
		[SmokeMethod("intersects(const QRect&) const")]
		public bool Intersects(QRect r) {
			return ProxyQRect().Intersects(r);
		}
		~QRect() {
			DisposeQRect();
		}
		public void Dispose() {
			DisposeQRect();
		}
		private void DisposeQRect() {
			ProxyQRect().DisposeQRect();
		}
	}
}
