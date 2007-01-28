//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QTextFragment")]
	public class QTextFragment : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QTextFragment(Type dummy) {}
		interface IQTextFragmentProxy {
			bool op_equals(QTextFragment lhs, QTextFragment o);
			bool op_lt(QTextFragment lhs, QTextFragment o);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextFragment), this);
			_interceptor = (QTextFragment) realProxy.GetTransparentProxy();
		}
		private QTextFragment ProxyQTextFragment() {
			return (QTextFragment) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextFragment() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextFragmentProxy), null);
			_staticInterceptor = (IQTextFragmentProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextFragmentProxy StaticQTextFragment() {
			return (IQTextFragmentProxy) _staticInterceptor;
		}

		public QTextFragment() : this((Type) null) {
			CreateProxy();
			NewQTextFragment();
		}
		[SmokeMethod("QTextFragment()")]
		private void NewQTextFragment() {
			ProxyQTextFragment().NewQTextFragment();
		}
		public QTextFragment(QTextFragment o) : this((Type) null) {
			CreateProxy();
			NewQTextFragment(o);
		}
		[SmokeMethod("QTextFragment(const QTextFragment&)")]
		private void NewQTextFragment(QTextFragment o) {
			ProxyQTextFragment().NewQTextFragment(o);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQTextFragment().IsValid();
		}
		[SmokeMethod("operator==(const QTextFragment&) const")]
		public static bool operator==(QTextFragment lhs, QTextFragment o) {
			return StaticQTextFragment().op_equals(lhs,o);
		}
		public static bool operator!=(QTextFragment lhs, QTextFragment o) {
			return !StaticQTextFragment().op_equals(lhs,o);
		}
		public override bool Equals(object o) {
			if (!(o is QTextFragment)) { return false; }
			return this == (QTextFragment) o;
		}
		public override int GetHashCode() {
			return ProxyQTextFragment().GetHashCode();
		}
		[SmokeMethod("operator<(const QTextFragment&) const")]
		public static bool operator<(QTextFragment lhs, QTextFragment o) {
			return StaticQTextFragment().op_lt(lhs,o);
		}
		public static bool operator>(QTextFragment lhs, QTextFragment o) {
			return !StaticQTextFragment().op_lt(lhs,o)
						&& !StaticQTextFragment().op_equals(lhs,o);
		}
		[SmokeMethod("position() const")]
		public int Position() {
			return ProxyQTextFragment().Position();
		}
		[SmokeMethod("length() const")]
		public int Length() {
			return ProxyQTextFragment().Length();
		}
		[SmokeMethod("contains(int) const")]
		public bool Contains(int position) {
			return ProxyQTextFragment().Contains(position);
		}
		[SmokeMethod("charFormat() const")]
		public QTextCharFormat CharFormat() {
			return ProxyQTextFragment().CharFormat();
		}
		[SmokeMethod("charFormatIndex() const")]
		public int CharFormatIndex() {
			return ProxyQTextFragment().CharFormatIndex();
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQTextFragment().Text();
		}
		~QTextFragment() {
			DisposeQTextFragment();
		}
		public void Dispose() {
			DisposeQTextFragment();
		}
		[SmokeMethod("~QTextFragment()")]
		private void DisposeQTextFragment() {
			ProxyQTextFragment().DisposeQTextFragment();
		}
	}
}