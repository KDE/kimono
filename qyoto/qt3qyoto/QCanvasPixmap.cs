//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QCanvasPixmap")]
	public class QCanvasPixmap : QPixmap, IDisposable {
 		protected QCanvasPixmap(Type dummy) : base((Type) null) {}
		interface IQCanvasPixmapProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCanvasPixmap), this);
			_interceptor = (QCanvasPixmap) realProxy.GetTransparentProxy();
		}
		private QCanvasPixmap ProxyQCanvasPixmap() {
			return (QCanvasPixmap) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCanvasPixmap() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCanvasPixmapProxy), null);
			_staticInterceptor = (IQCanvasPixmapProxy) realProxy.GetTransparentProxy();
		}
		private static IQCanvasPixmapProxy StaticQCanvasPixmap() {
			return (IQCanvasPixmapProxy) _staticInterceptor;
		}

		public QCanvasPixmap(string datafilename) : this((Type) null) {
			CreateProxy();
			NewQCanvasPixmap(datafilename);
		}
		[SmokeMethod("QCanvasPixmap(const QString&)")]
		private void NewQCanvasPixmap(string datafilename) {
			ProxyQCanvasPixmap().NewQCanvasPixmap(datafilename);
		}
		public QCanvasPixmap(QImage image) : this((Type) null) {
			CreateProxy();
			NewQCanvasPixmap(image);
		}
		[SmokeMethod("QCanvasPixmap(const QImage&)")]
		private void NewQCanvasPixmap(QImage image) {
			ProxyQCanvasPixmap().NewQCanvasPixmap(image);
		}
		public QCanvasPixmap(QPixmap arg1, QPoint hotspot) : this((Type) null) {
			CreateProxy();
			NewQCanvasPixmap(arg1,hotspot);
		}
		[SmokeMethod("QCanvasPixmap(const QPixmap&, const QPoint&)")]
		private void NewQCanvasPixmap(QPixmap arg1, QPoint hotspot) {
			ProxyQCanvasPixmap().NewQCanvasPixmap(arg1,hotspot);
		}
		[SmokeMethod("offsetX() const")]
		public int OffsetX() {
			return ProxyQCanvasPixmap().OffsetX();
		}
		[SmokeMethod("offsetY() const")]
		public int OffsetY() {
			return ProxyQCanvasPixmap().OffsetY();
		}
		[SmokeMethod("setOffset(int, int)")]
		public void SetOffset(int x, int y) {
			ProxyQCanvasPixmap().SetOffset(x,y);
		}
		~QCanvasPixmap() {
			DisposeQCanvasPixmap();
		}
		public void Dispose() {
			DisposeQCanvasPixmap();
		}
		private void DisposeQCanvasPixmap() {
			ProxyQCanvasPixmap().DisposeQCanvasPixmap();
		}
	}
}
