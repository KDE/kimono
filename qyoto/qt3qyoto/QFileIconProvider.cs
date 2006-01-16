//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QFileIconProvider")]
	public class QFileIconProvider : QObject, IDisposable {
 		protected QFileIconProvider(Type dummy) : base((Type) null) {}
		interface IQFileIconProviderProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileIconProvider), this);
			_interceptor = (QFileIconProvider) realProxy.GetTransparentProxy();
		}
		private QFileIconProvider ProxyQFileIconProvider() {
			return (QFileIconProvider) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFileIconProvider() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileIconProviderProxy), null);
			_staticInterceptor = (IQFileIconProviderProxy) realProxy.GetTransparentProxy();
		}
		private static IQFileIconProviderProxy StaticQFileIconProvider() {
			return (IQFileIconProviderProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQFileIconProvider().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQFileIconProvider().ClassName();
		}
		public QFileIconProvider(QObject parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQFileIconProvider(parent,name);
		}
		[SmokeMethod("QFileIconProvider(QObject*, const char*)")]
		private void NewQFileIconProvider(QObject parent, string name) {
			ProxyQFileIconProvider().NewQFileIconProvider(parent,name);
		}
		public QFileIconProvider(QObject parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQFileIconProvider(parent);
		}
		[SmokeMethod("QFileIconProvider(QObject*)")]
		private void NewQFileIconProvider(QObject parent) {
			ProxyQFileIconProvider().NewQFileIconProvider(parent);
		}
		public QFileIconProvider() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQFileIconProvider();
		}
		[SmokeMethod("QFileIconProvider()")]
		private void NewQFileIconProvider() {
			ProxyQFileIconProvider().NewQFileIconProvider();
		}
		[SmokeMethod("pixmap(const QFileInfo&)")]
		public virtual QPixmap Pixmap(QFileInfo arg1) {
			return ProxyQFileIconProvider().Pixmap(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQFileIconProvider().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQFileIconProvider().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQFileIconProvider().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQFileIconProvider().TrUtf8(arg1);
		}
		~QFileIconProvider() {
			DisposeQFileIconProvider();
		}
		public new void Dispose() {
			DisposeQFileIconProvider();
		}
		private void DisposeQFileIconProvider() {
			ProxyQFileIconProvider().DisposeQFileIconProvider();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQFileIconProviderSignals), this);
			Q_EMIT = (IQFileIconProviderSignals) realProxy.GetTransparentProxy();
		}
		protected new IQFileIconProviderSignals Emit() {
			return (IQFileIconProviderSignals) Q_EMIT;
		}
	}

	public interface IQFileIconProviderSignals : IQObjectSignals {
	}
}
