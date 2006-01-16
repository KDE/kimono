//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QColorDialog")]
	public class QColorDialog : QDialog {
 		protected QColorDialog(Type dummy) : base((Type) null) {}
		interface IQColorDialogProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QColor GetColor(QColor init, QWidget parent, string name);
			QColor GetColor(QColor init, QWidget parent);
			QColor GetColor(QColor init);
			QColor GetColor();
			uint GetRgba(uint arg1, out bool ok, QWidget parent, string name);
			uint GetRgba(uint arg1, out bool ok, QWidget parent);
			uint GetRgba(uint arg1, out bool ok);
			uint GetRgba(uint arg1);
			int CustomCount();
			uint CustomColor(int arg1);
			void SetCustomColor(int arg1, uint arg2);
			void SetStandardColor(int arg1, uint arg2);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QColorDialog), this);
			_interceptor = (QColorDialog) realProxy.GetTransparentProxy();
		}
		private QColorDialog ProxyQColorDialog() {
			return (QColorDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QColorDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQColorDialogProxy), null);
			_staticInterceptor = (IQColorDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQColorDialogProxy StaticQColorDialog() {
			return (IQColorDialogProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQColorDialog().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQColorDialog().ClassName();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQColorDialog().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQColorDialog().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQColorDialog().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQColorDialog().TrUtf8(arg1);
		}
		[SmokeMethod("getColor(const QColor&, QWidget*, const char*)")]
		public static QColor GetColor(QColor init, QWidget parent, string name) {
			return StaticQColorDialog().GetColor(init,parent,name);
		}
		[SmokeMethod("getColor(const QColor&, QWidget*)")]
		public static QColor GetColor(QColor init, QWidget parent) {
			return StaticQColorDialog().GetColor(init,parent);
		}
		[SmokeMethod("getColor(const QColor&)")]
		public static QColor GetColor(QColor init) {
			return StaticQColorDialog().GetColor(init);
		}
		[SmokeMethod("getColor()")]
		public static QColor GetColor() {
			return StaticQColorDialog().GetColor();
		}
		[SmokeMethod("getRgba(QRgb, bool*, QWidget*, const char*)")]
		public static uint GetRgba(uint arg1, out bool ok, QWidget parent, string name) {
			return StaticQColorDialog().GetRgba(arg1,out ok,parent,name);
		}
		[SmokeMethod("getRgba(QRgb, bool*, QWidget*)")]
		public static uint GetRgba(uint arg1, out bool ok, QWidget parent) {
			return StaticQColorDialog().GetRgba(arg1,out ok,parent);
		}
		[SmokeMethod("getRgba(QRgb, bool*)")]
		public static uint GetRgba(uint arg1, out bool ok) {
			return StaticQColorDialog().GetRgba(arg1,out ok);
		}
		[SmokeMethod("getRgba(QRgb)")]
		public static uint GetRgba(uint arg1) {
			return StaticQColorDialog().GetRgba(arg1);
		}
		[SmokeMethod("customCount()")]
		public static int CustomCount() {
			return StaticQColorDialog().CustomCount();
		}
		[SmokeMethod("customColor(int)")]
		public static uint CustomColor(int arg1) {
			return StaticQColorDialog().CustomColor(arg1);
		}
		[SmokeMethod("setCustomColor(int, QRgb)")]
		public static void SetCustomColor(int arg1, uint arg2) {
			StaticQColorDialog().SetCustomColor(arg1,arg2);
		}
		[SmokeMethod("setStandardColor(int, QRgb)")]
		public static void SetStandardColor(int arg1, uint arg2) {
			StaticQColorDialog().SetStandardColor(arg1,arg2);
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQColorDialogSignals), this);
			Q_EMIT = (IQColorDialogSignals) realProxy.GetTransparentProxy();
		}
		protected new IQColorDialogSignals Emit() {
			return (IQColorDialogSignals) Q_EMIT;
		}
	}

	public interface IQColorDialogSignals : IQDialogSignals {
	}
}
