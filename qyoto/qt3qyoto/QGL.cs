//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public interface IQGL {
	}

	[SmokeClass("QGL")]
	public class QGL : MarshalByRefObject, IQGL, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QGL(Type dummy) {}
		interface IQGLProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGL), this);
			_interceptor = (QGL) realProxy.GetTransparentProxy();
		}
		private QGL ProxyQGL() {
			return (QGL) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGL() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGLProxy), null);
			_staticInterceptor = (IQGLProxy) realProxy.GetTransparentProxy();
		}
		private static IQGLProxy StaticQGL() {
			return (IQGLProxy) _staticInterceptor;
		}

		public enum FormatOption {
			DoubleBuffer = 0x0001,
			DepthBuffer = 0x0002,
			Rgba = 0x0004,
			AlphaChannel = 0x0008,
			AccumBuffer = 0x0010,
			StencilBuffer = 0x0020,
			StereoBuffers = 0x0040,
			DirectRendering = 0x0080,
			HasOverlay = 0x0100,
			SingleBuffer = DoubleBuffer<<16,
			NoDepthBuffer = DepthBuffer<<16,
			ColorIndex = Rgba<<16,
			NoAlphaChannel = AlphaChannel<<16,
			NoAccumBuffer = AccumBuffer<<16,
			NoStencilBuffer = StencilBuffer<<16,
			NoStereoBuffers = StereoBuffers<<16,
			IndirectRendering = DirectRendering<<16,
			NoOverlay = HasOverlay<<16,
		}
		public QGL() : this((Type) null) {
			CreateProxy();
			NewQGL();
		}
		[SmokeMethod("QGL()")]
		private void NewQGL() {
			ProxyQGL().NewQGL();
		}
		~QGL() {
			DisposeQGL();
		}
		public void Dispose() {
			DisposeQGL();
		}
		private void DisposeQGL() {
			ProxyQGL().DisposeQGL();
		}
	}
}
