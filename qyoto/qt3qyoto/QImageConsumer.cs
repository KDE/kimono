//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QImageConsumer")]
	public class QImageConsumer : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QImageConsumer(Type dummy) {}
		interface IQImageConsumerProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImageConsumer), this);
			_interceptor = (QImageConsumer) realProxy.GetTransparentProxy();
		}
		private QImageConsumer ProxyQImageConsumer() {
			return (QImageConsumer) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QImageConsumer() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQImageConsumerProxy), null);
			_staticInterceptor = (IQImageConsumerProxy) realProxy.GetTransparentProxy();
		}
		private static IQImageConsumerProxy StaticQImageConsumer() {
			return (IQImageConsumerProxy) _staticInterceptor;
		}

		[SmokeMethod("end()")]
		public virtual void End() {
			ProxyQImageConsumer().End();
		}
		[SmokeMethod("changed(const QRect&)")]
		public virtual void Changed(QRect arg1) {
			ProxyQImageConsumer().Changed(arg1);
		}
		[SmokeMethod("frameDone()")]
		public virtual void FrameDone() {
			ProxyQImageConsumer().FrameDone();
		}
		[SmokeMethod("frameDone(const QPoint&, const QRect&)")]
		public virtual void FrameDone(QPoint arg1, QRect arg2) {
			ProxyQImageConsumer().FrameDone(arg1,arg2);
		}
		[SmokeMethod("setLooping(int)")]
		public virtual void SetLooping(int arg1) {
			ProxyQImageConsumer().SetLooping(arg1);
		}
		[SmokeMethod("setFramePeriod(int)")]
		public virtual void SetFramePeriod(int arg1) {
			ProxyQImageConsumer().SetFramePeriod(arg1);
		}
		[SmokeMethod("setSize(int, int)")]
		public virtual void SetSize(int arg1, int arg2) {
			ProxyQImageConsumer().SetSize(arg1,arg2);
		}
		public QImageConsumer() : this((Type) null) {
			CreateProxy();
			NewQImageConsumer();
		}
		[SmokeMethod("QImageConsumer()")]
		private void NewQImageConsumer() {
			ProxyQImageConsumer().NewQImageConsumer();
		}
		~QImageConsumer() {
			DisposeQImageConsumer();
		}
		public void Dispose() {
			DisposeQImageConsumer();
		}
		private void DisposeQImageConsumer() {
			ProxyQImageConsumer().DisposeQImageConsumer();
		}
	}
}
