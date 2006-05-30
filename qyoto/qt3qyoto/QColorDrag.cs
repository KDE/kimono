//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QColorDrag")]
	public class QColorDrag : QStoredDrag, IDisposable {
 		protected QColorDrag(Type dummy) : base((Type) null) {}
		interface IQColorDragProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			bool CanDecode(IQMimeSource arg1);
			bool Decode(IQMimeSource arg1, QColor col);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QColorDrag), this);
			_interceptor = (QColorDrag) realProxy.GetTransparentProxy();
		}
		private QColorDrag ProxyQColorDrag() {
			return (QColorDrag) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QColorDrag() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQColorDragProxy), null);
			_staticInterceptor = (IQColorDragProxy) realProxy.GetTransparentProxy();
		}
		private static IQColorDragProxy StaticQColorDrag() {
			return (IQColorDragProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQColorDrag().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQColorDrag().ClassName();
		}
		public QColorDrag(QColor col, QWidget dragsource, string name) : this((Type) null) {
			CreateProxy();
			NewQColorDrag(col,dragsource,name);
		}
		[SmokeMethod("QColorDrag(const QColor&, QWidget*, const char*)")]
		private void NewQColorDrag(QColor col, QWidget dragsource, string name) {
			ProxyQColorDrag().NewQColorDrag(col,dragsource,name);
		}
		public QColorDrag(QColor col, QWidget dragsource) : this((Type) null) {
			CreateProxy();
			NewQColorDrag(col,dragsource);
		}
		[SmokeMethod("QColorDrag(const QColor&, QWidget*)")]
		private void NewQColorDrag(QColor col, QWidget dragsource) {
			ProxyQColorDrag().NewQColorDrag(col,dragsource);
		}
		public QColorDrag(QColor col) : this((Type) null) {
			CreateProxy();
			NewQColorDrag(col);
		}
		[SmokeMethod("QColorDrag(const QColor&)")]
		private void NewQColorDrag(QColor col) {
			ProxyQColorDrag().NewQColorDrag(col);
		}
		public QColorDrag(QWidget dragSource, string name) : this((Type) null) {
			CreateProxy();
			NewQColorDrag(dragSource,name);
		}
		[SmokeMethod("QColorDrag(QWidget*, const char*)")]
		private void NewQColorDrag(QWidget dragSource, string name) {
			ProxyQColorDrag().NewQColorDrag(dragSource,name);
		}
		public QColorDrag(QWidget dragSource) : this((Type) null) {
			CreateProxy();
			NewQColorDrag(dragSource);
		}
		[SmokeMethod("QColorDrag(QWidget*)")]
		private void NewQColorDrag(QWidget dragSource) {
			ProxyQColorDrag().NewQColorDrag(dragSource);
		}
		public QColorDrag() : this((Type) null) {
			CreateProxy();
			NewQColorDrag();
		}
		[SmokeMethod("QColorDrag()")]
		private void NewQColorDrag() {
			ProxyQColorDrag().NewQColorDrag();
		}
		[SmokeMethod("setColor(const QColor&)")]
		public void SetColor(QColor col) {
			ProxyQColorDrag().SetColor(col);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQColorDrag().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQColorDrag().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQColorDrag().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQColorDrag().TrUtf8(arg1);
		}
		[SmokeMethod("canDecode(QMimeSource*)")]
		public static bool CanDecode(IQMimeSource arg1) {
			return StaticQColorDrag().CanDecode(arg1);
		}
		[SmokeMethod("decode(QMimeSource*, QColor&)")]
		public static bool Decode(IQMimeSource arg1, QColor col) {
			return StaticQColorDrag().Decode(arg1,col);
		}
		~QColorDrag() {
			DisposeQColorDrag();
		}
		public new void Dispose() {
			DisposeQColorDrag();
		}
		private void DisposeQColorDrag() {
			ProxyQColorDrag().DisposeQColorDrag();
		}
		protected new IQColorDragSignals Emit() {
			return (IQColorDragSignals) Q_EMIT;
		}
	}

	public interface IQColorDragSignals : IQStoredDragSignals {
	}
}
