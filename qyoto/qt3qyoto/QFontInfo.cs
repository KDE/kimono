//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QFontInfo")]
	public class QFontInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFontInfo(Type dummy) {}
		interface IQFontInfoProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontInfo), this);
			_interceptor = (QFontInfo) realProxy.GetTransparentProxy();
		}
		private QFontInfo ProxyQFontInfo() {
			return (QFontInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontInfoProxy), null);
			_staticInterceptor = (IQFontInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontInfoProxy StaticQFontInfo() {
			return (IQFontInfoProxy) _staticInterceptor;
		}

		public QFontInfo(QFont arg1) : this((Type) null) {
			CreateProxy();
			NewQFontInfo(arg1);
		}
		[SmokeMethod("QFontInfo(const QFont&)")]
		private void NewQFontInfo(QFont arg1) {
			ProxyQFontInfo().NewQFontInfo(arg1);
		}
		public QFontInfo(QFont arg1, QFont.Script arg2) : this((Type) null) {
			CreateProxy();
			NewQFontInfo(arg1,arg2);
		}
		[SmokeMethod("QFontInfo(const QFont&, QFont::Script)")]
		private void NewQFontInfo(QFont arg1, QFont.Script arg2) {
			ProxyQFontInfo().NewQFontInfo(arg1,arg2);
		}
		public QFontInfo(QFontInfo arg1) : this((Type) null) {
			CreateProxy();
			NewQFontInfo(arg1);
		}
		[SmokeMethod("QFontInfo(const QFontInfo&)")]
		private void NewQFontInfo(QFontInfo arg1) {
			ProxyQFontInfo().NewQFontInfo(arg1);
		}
		[SmokeMethod("family() const")]
		public string Family() {
			return ProxyQFontInfo().Family();
		}
		[SmokeMethod("pixelSize() const")]
		public int PixelSize() {
			return ProxyQFontInfo().PixelSize();
		}
		[SmokeMethod("pointSize() const")]
		public int PointSize() {
			return ProxyQFontInfo().PointSize();
		}
		[SmokeMethod("italic() const")]
		public bool Italic() {
			return ProxyQFontInfo().Italic();
		}
		[SmokeMethod("weight() const")]
		public int Weight() {
			return ProxyQFontInfo().Weight();
		}
		[SmokeMethod("bold() const")]
		public bool Bold() {
			return ProxyQFontInfo().Bold();
		}
		[SmokeMethod("underline() const")]
		public bool Underline() {
			return ProxyQFontInfo().Underline();
		}
		[SmokeMethod("overline() const")]
		public bool Overline() {
			return ProxyQFontInfo().Overline();
		}
		[SmokeMethod("strikeOut() const")]
		public bool StrikeOut() {
			return ProxyQFontInfo().StrikeOut();
		}
		[SmokeMethod("fixedPitch() const")]
		public bool FixedPitch() {
			return ProxyQFontInfo().FixedPitch();
		}
		[SmokeMethod("styleHint() const")]
		public QFont.StyleHint StyleHint() {
			return ProxyQFontInfo().StyleHint();
		}
		[SmokeMethod("rawMode() const")]
		public bool RawMode() {
			return ProxyQFontInfo().RawMode();
		}
		[SmokeMethod("exactMatch() const")]
		public bool ExactMatch() {
			return ProxyQFontInfo().ExactMatch();
		}
		~QFontInfo() {
			DisposeQFontInfo();
		}
		public void Dispose() {
			DisposeQFontInfo();
		}
		private void DisposeQFontInfo() {
			ProxyQFontInfo().DisposeQFontInfo();
		}
	}
}
