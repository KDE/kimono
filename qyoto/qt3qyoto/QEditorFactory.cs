//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QEditorFactory")]
	public class QEditorFactory : QObject, IDisposable {
 		protected QEditorFactory(Type dummy) : base((Type) null) {}
		interface IQEditorFactoryProxy {
			QEditorFactory DefaultFactory();
			void InstallDefaultFactory(QEditorFactory factory);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QEditorFactory), this);
			_interceptor = (QEditorFactory) realProxy.GetTransparentProxy();
		}
		private QEditorFactory ProxyQEditorFactory() {
			return (QEditorFactory) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QEditorFactory() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQEditorFactoryProxy), null);
			_staticInterceptor = (IQEditorFactoryProxy) realProxy.GetTransparentProxy();
		}
		private static IQEditorFactoryProxy StaticQEditorFactory() {
			return (IQEditorFactoryProxy) _staticInterceptor;
		}

		public QEditorFactory(QObject parent, string name) : this((Type) null) {
			CreateProxy();
			NewQEditorFactory(parent,name);
		}
		[SmokeMethod("QEditorFactory(QObject*, const char*)")]
		private void NewQEditorFactory(QObject parent, string name) {
			ProxyQEditorFactory().NewQEditorFactory(parent,name);
		}
		public QEditorFactory(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQEditorFactory(parent);
		}
		[SmokeMethod("QEditorFactory(QObject*)")]
		private void NewQEditorFactory(QObject parent) {
			ProxyQEditorFactory().NewQEditorFactory(parent);
		}
		public QEditorFactory() : this((Type) null) {
			CreateProxy();
			NewQEditorFactory();
		}
		[SmokeMethod("QEditorFactory()")]
		private void NewQEditorFactory() {
			ProxyQEditorFactory().NewQEditorFactory();
		}
		[SmokeMethod("createEditor(QWidget*, const QVariant&)")]
		public virtual QWidget CreateEditor(QWidget parent, QVariant v) {
			return ProxyQEditorFactory().CreateEditor(parent,v);
		}
		[SmokeMethod("defaultFactory()")]
		public static QEditorFactory DefaultFactory() {
			return StaticQEditorFactory().DefaultFactory();
		}
		[SmokeMethod("installDefaultFactory(QEditorFactory*)")]
		public static void InstallDefaultFactory(QEditorFactory factory) {
			StaticQEditorFactory().InstallDefaultFactory(factory);
		}
		~QEditorFactory() {
			DisposeQEditorFactory();
		}
		public new void Dispose() {
			DisposeQEditorFactory();
		}
		private void DisposeQEditorFactory() {
			ProxyQEditorFactory().DisposeQEditorFactory();
		}
		protected new IQEditorFactorySignals Emit() {
			return (IQEditorFactorySignals) Q_EMIT;
		}
	}

	public interface IQEditorFactorySignals : IQObjectSignals {
	}
}
