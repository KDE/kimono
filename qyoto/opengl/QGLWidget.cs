//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QGLWidget")]
	public class QGLWidget : QWidget, IDisposable {
 		protected QGLWidget(Type dummy) : base((Type) null) {}
		interface IQGLWidgetProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
			[SmokeMethod("convertToGLFormat#", "(const QImage&)")]
			QImage ConvertToGLFormat(QImage img);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGLWidget), this);
			_interceptor = (QGLWidget) realProxy.GetTransparentProxy();
		}
		private QGLWidget ProxyQGLWidget() {
			return (QGLWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGLWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGLWidgetProxy), null);
			_staticInterceptor = (IQGLWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQGLWidgetProxy StaticQGLWidget() {
			return (IQGLWidgetProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QGLWidget(QWidget parent, QGLWidget shareWidget, int f) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(parent,shareWidget,f);
		}
		[SmokeMethod("QGLWidget##$", "(QWidget*, const QGLWidget*, Qt::WindowFlags)")]
		private void NewQGLWidget(QWidget parent, QGLWidget shareWidget, int f) {
			ProxyQGLWidget().NewQGLWidget(parent,shareWidget,f);
		}
		public QGLWidget(QWidget parent, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(parent,shareWidget);
		}
		[SmokeMethod("QGLWidget##", "(QWidget*, const QGLWidget*)")]
		private void NewQGLWidget(QWidget parent, QGLWidget shareWidget) {
			ProxyQGLWidget().NewQGLWidget(parent,shareWidget);
		}
		public QGLWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(parent);
		}
		[SmokeMethod("QGLWidget#", "(QWidget*)")]
		private void NewQGLWidget(QWidget parent) {
			ProxyQGLWidget().NewQGLWidget(parent);
		}
		public QGLWidget() : this((Type) null) {
			CreateProxy();
			NewQGLWidget();
		}
		[SmokeMethod("QGLWidget", "()")]
		private void NewQGLWidget() {
			ProxyQGLWidget().NewQGLWidget();
		}
		public QGLWidget(QGLContext context, QWidget parent, QGLWidget shareWidget, int f) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(context,parent,shareWidget,f);
		}
		[SmokeMethod("QGLWidget###$", "(QGLContext*, QWidget*, const QGLWidget*, Qt::WindowFlags)")]
		private void NewQGLWidget(QGLContext context, QWidget parent, QGLWidget shareWidget, int f) {
			ProxyQGLWidget().NewQGLWidget(context,parent,shareWidget,f);
		}
		public QGLWidget(QGLContext context, QWidget parent, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(context,parent,shareWidget);
		}
		[SmokeMethod("QGLWidget###", "(QGLContext*, QWidget*, const QGLWidget*)")]
		private void NewQGLWidget(QGLContext context, QWidget parent, QGLWidget shareWidget) {
			ProxyQGLWidget().NewQGLWidget(context,parent,shareWidget);
		}
		public QGLWidget(QGLContext context, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(context,parent);
		}
		[SmokeMethod("QGLWidget##", "(QGLContext*, QWidget*)")]
		private void NewQGLWidget(QGLContext context, QWidget parent) {
			ProxyQGLWidget().NewQGLWidget(context,parent);
		}
		public QGLWidget(QGLContext context) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(context);
		}
		[SmokeMethod("QGLWidget#", "(QGLContext*)")]
		private void NewQGLWidget(QGLContext context) {
			ProxyQGLWidget().NewQGLWidget(context);
		}
		public QGLWidget(QGLFormat format, QWidget parent, QGLWidget shareWidget, int f) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(format,parent,shareWidget,f);
		}
		[SmokeMethod("QGLWidget###$", "(const QGLFormat&, QWidget*, const QGLWidget*, Qt::WindowFlags)")]
		private void NewQGLWidget(QGLFormat format, QWidget parent, QGLWidget shareWidget, int f) {
			ProxyQGLWidget().NewQGLWidget(format,parent,shareWidget,f);
		}
		public QGLWidget(QGLFormat format, QWidget parent, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(format,parent,shareWidget);
		}
		[SmokeMethod("QGLWidget###", "(const QGLFormat&, QWidget*, const QGLWidget*)")]
		private void NewQGLWidget(QGLFormat format, QWidget parent, QGLWidget shareWidget) {
			ProxyQGLWidget().NewQGLWidget(format,parent,shareWidget);
		}
		public QGLWidget(QGLFormat format, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(format,parent);
		}
		[SmokeMethod("QGLWidget##", "(const QGLFormat&, QWidget*)")]
		private void NewQGLWidget(QGLFormat format, QWidget parent) {
			ProxyQGLWidget().NewQGLWidget(format,parent);
		}
		public QGLWidget(QGLFormat format) : this((Type) null) {
			CreateProxy();
			NewQGLWidget(format);
		}
		[SmokeMethod("QGLWidget#", "(const QGLFormat&)")]
		private void NewQGLWidget(QGLFormat format) {
			ProxyQGLWidget().NewQGLWidget(format);
		}
		[SmokeMethod("qglColor#", "(const QColor&) const")]
		public void QglColor(QColor c) {
			ProxyQGLWidget().QglColor(c);
		}
		[SmokeMethod("qglClearColor#", "(const QColor&) const")]
		public void QglClearColor(QColor c) {
			ProxyQGLWidget().QglClearColor(c);
		}
		[SmokeMethod("isValid", "() const")]
		public bool IsValid() {
			return ProxyQGLWidget().IsValid();
		}
		[SmokeMethod("isSharing", "() const")]
		public bool IsSharing() {
			return ProxyQGLWidget().IsSharing();
		}
		[SmokeMethod("makeCurrent", "()")]
		public void MakeCurrent() {
			ProxyQGLWidget().MakeCurrent();
		}
		[SmokeMethod("doneCurrent", "()")]
		public void DoneCurrent() {
			ProxyQGLWidget().DoneCurrent();
		}
		[SmokeMethod("doubleBuffer", "() const")]
		public bool DoubleBuffer() {
			return ProxyQGLWidget().DoubleBuffer();
		}
		[SmokeMethod("swapBuffers", "()")]
		public void SwapBuffers() {
			ProxyQGLWidget().SwapBuffers();
		}
		[SmokeMethod("format", "() const")]
		public QGLFormat Format() {
			return ProxyQGLWidget().Format();
		}
		[SmokeMethod("setFormat#", "(const QGLFormat&)")]
		public void SetFormat(QGLFormat format) {
			ProxyQGLWidget().SetFormat(format);
		}
		[SmokeMethod("context", "() const")]
		public QGLContext Context() {
			return ProxyQGLWidget().Context();
		}
		[SmokeMethod("setContext##$", "(QGLContext*, const QGLContext*, bool)")]
		public void SetContext(QGLContext context, QGLContext shareContext, bool deleteOldContext) {
			ProxyQGLWidget().SetContext(context,shareContext,deleteOldContext);
		}
		[SmokeMethod("setContext##", "(QGLContext*, const QGLContext*)")]
		public void SetContext(QGLContext context, QGLContext shareContext) {
			ProxyQGLWidget().SetContext(context,shareContext);
		}
		[SmokeMethod("setContext#", "(QGLContext*)")]
		public void SetContext(QGLContext context) {
			ProxyQGLWidget().SetContext(context);
		}
		[SmokeMethod("renderPixmap$$$", "(int, int, bool)")]
		public QPixmap RenderPixmap(int w, int h, bool useContext) {
			return ProxyQGLWidget().RenderPixmap(w,h,useContext);
		}
		[SmokeMethod("renderPixmap$$", "(int, int)")]
		public QPixmap RenderPixmap(int w, int h) {
			return ProxyQGLWidget().RenderPixmap(w,h);
		}
		[SmokeMethod("renderPixmap$", "(int)")]
		public QPixmap RenderPixmap(int w) {
			return ProxyQGLWidget().RenderPixmap(w);
		}
		[SmokeMethod("renderPixmap", "()")]
		public QPixmap RenderPixmap() {
			return ProxyQGLWidget().RenderPixmap();
		}
		[SmokeMethod("grabFrameBuffer$", "(bool)")]
		public QImage GrabFrameBuffer(bool withAlpha) {
			return ProxyQGLWidget().GrabFrameBuffer(withAlpha);
		}
		[SmokeMethod("grabFrameBuffer", "()")]
		public QImage GrabFrameBuffer() {
			return ProxyQGLWidget().GrabFrameBuffer();
		}
		[SmokeMethod("makeOverlayCurrent", "()")]
		public void MakeOverlayCurrent() {
			ProxyQGLWidget().MakeOverlayCurrent();
		}
		[SmokeMethod("overlayContext", "() const")]
		public QGLContext OverlayContext() {
			return ProxyQGLWidget().OverlayContext();
		}
		[SmokeMethod("setMouseTracking$", "(bool)")]
		public new void SetMouseTracking(bool enable) {
			ProxyQGLWidget().SetMouseTracking(enable);
		}
		[SmokeMethod("colormap", "() const")]
		public QGLColormap Colormap() {
			return ProxyQGLWidget().Colormap();
		}
		[SmokeMethod("setColormap#", "(const QGLColormap&)")]
		public void SetColormap(QGLColormap map) {
			ProxyQGLWidget().SetColormap(map);
		}
		[SmokeMethod("renderText$$$#$", "(int, int, const QString&, const QFont&, int)")]
		public void RenderText(int x, int y, string str, QFont fnt, int listBase) {
			ProxyQGLWidget().RenderText(x,y,str,fnt,listBase);
		}
		[SmokeMethod("renderText$$$#", "(int, int, const QString&, const QFont&)")]
		public void RenderText(int x, int y, string str, QFont fnt) {
			ProxyQGLWidget().RenderText(x,y,str,fnt);
		}
		[SmokeMethod("renderText$$$", "(int, int, const QString&)")]
		public void RenderText(int x, int y, string str) {
			ProxyQGLWidget().RenderText(x,y,str);
		}
		[SmokeMethod("renderText$$$$#$", "(double, double, double, const QString&, const QFont&, int)")]
		public void RenderText(double x, double y, double z, string str, QFont fnt, int listBase) {
			ProxyQGLWidget().RenderText(x,y,z,str,fnt,listBase);
		}
		[SmokeMethod("renderText$$$$#", "(double, double, double, const QString&, const QFont&)")]
		public void RenderText(double x, double y, double z, string str, QFont fnt) {
			ProxyQGLWidget().RenderText(x,y,z,str,fnt);
		}
		[SmokeMethod("renderText$$$$", "(double, double, double, const QString&)")]
		public void RenderText(double x, double y, double z, string str) {
			ProxyQGLWidget().RenderText(x,y,z,str);
		}
		[SmokeMethod("paintEngine", "() const")]
		public new QPaintEngine PaintEngine() {
			return ProxyQGLWidget().PaintEngine();
		}
		[SmokeMethod("bindTexture#$$", "(const QImage&, GLenum, GLint)")]
		public uint BindTexture(QImage image, int target, int format) {
			return ProxyQGLWidget().BindTexture(image,target,format);
		}
		[SmokeMethod("bindTexture#$", "(const QImage&, GLenum)")]
		public uint BindTexture(QImage image, int target) {
			return ProxyQGLWidget().BindTexture(image,target);
		}
		[SmokeMethod("bindTexture#", "(const QImage&)")]
		public uint BindTexture(QImage image) {
			return ProxyQGLWidget().BindTexture(image);
		}
		[SmokeMethod("bindTexture#$$", "(const QPixmap&, GLenum, GLint)")]
		public uint BindTexture(QPixmap pixmap, int target, int format) {
			return ProxyQGLWidget().BindTexture(pixmap,target,format);
		}
		[SmokeMethod("bindTexture#$", "(const QPixmap&, GLenum)")]
		public uint BindTexture(QPixmap pixmap, int target) {
			return ProxyQGLWidget().BindTexture(pixmap,target);
		}
		[SmokeMethod("bindTexture#", "(const QPixmap&)")]
		public uint BindTexture(QPixmap pixmap) {
			return ProxyQGLWidget().BindTexture(pixmap);
		}
		[SmokeMethod("bindTexture$", "(const QString&)")]
		public uint BindTexture(string fileName) {
			return ProxyQGLWidget().BindTexture(fileName);
		}
		[SmokeMethod("deleteTexture$", "(GLuint)")]
		public void DeleteTexture(uint tx_id) {
			ProxyQGLWidget().DeleteTexture(tx_id);
		}
		[Q_SLOT("void updateGL()")]
		[SmokeMethod("updateGL", "()")]
		public virtual void UpdateGL() {
			ProxyQGLWidget().UpdateGL();
		}
		[Q_SLOT("void updateOverlayGL()")]
		[SmokeMethod("updateOverlayGL", "()")]
		public virtual void UpdateOverlayGL() {
			ProxyQGLWidget().UpdateOverlayGL();
		}
		public static new string Tr(string s, string c) {
			return StaticQGLWidget().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQGLWidget().Tr(s);
		}
		public static QImage ConvertToGLFormat(QImage img) {
			return StaticQGLWidget().ConvertToGLFormat(img);
		}
		[SmokeMethod("event#", "(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQGLWidget().Event(arg1);
		}
		[SmokeMethod("initializeGL", "()")]
		protected virtual void InitializeGL() {
			ProxyQGLWidget().InitializeGL();
		}
		[SmokeMethod("resizeGL$$", "(int, int)")]
		protected virtual void ResizeGL(int w, int h) {
			ProxyQGLWidget().ResizeGL(w,h);
		}
		[SmokeMethod("paintGL", "()")]
		protected virtual void PaintGL() {
			ProxyQGLWidget().PaintGL();
		}
		[SmokeMethod("initializeOverlayGL", "()")]
		protected virtual void InitializeOverlayGL() {
			ProxyQGLWidget().InitializeOverlayGL();
		}
		[SmokeMethod("resizeOverlayGL$$", "(int, int)")]
		protected virtual void ResizeOverlayGL(int w, int h) {
			ProxyQGLWidget().ResizeOverlayGL(w,h);
		}
		[SmokeMethod("paintOverlayGL", "()")]
		protected virtual void PaintOverlayGL() {
			ProxyQGLWidget().PaintOverlayGL();
		}
		[SmokeMethod("setAutoBufferSwap$", "(bool)")]
		protected void SetAutoBufferSwap(bool on) {
			ProxyQGLWidget().SetAutoBufferSwap(on);
		}
		[SmokeMethod("autoBufferSwap", "() const")]
		protected bool AutoBufferSwap() {
			return ProxyQGLWidget().AutoBufferSwap();
		}
		[SmokeMethod("paintEvent#", "(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQGLWidget().PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent#", "(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQGLWidget().ResizeEvent(arg1);
		}
		[SmokeMethod("glInit", "()")]
		protected virtual void GlInit() {
			ProxyQGLWidget().GlInit();
		}
		[SmokeMethod("glDraw", "()")]
		protected virtual void GlDraw() {
			ProxyQGLWidget().GlDraw();
		}
		[SmokeMethod("fontDisplayListBase#$", "(const QFont&, int)")]
		protected int FontDisplayListBase(QFont fnt, int listBase) {
			return ProxyQGLWidget().FontDisplayListBase(fnt,listBase);
		}
		[SmokeMethod("fontDisplayListBase#", "(const QFont&)")]
		protected int FontDisplayListBase(QFont fnt) {
			return ProxyQGLWidget().FontDisplayListBase(fnt);
		}
		~QGLWidget() {
			DisposeQGLWidget();
		}
		public new void Dispose() {
			DisposeQGLWidget();
		}
		[SmokeMethod("~QGLWidget", "()")]
		private void DisposeQGLWidget() {
			ProxyQGLWidget().DisposeQGLWidget();
		}
		protected new IQGLWidgetSignals Emit {
			get {
				return (IQGLWidgetSignals) Q_EMIT;
			}
		}
	}

	public interface IQGLWidgetSignals : IQWidgetSignals {
	}
}
