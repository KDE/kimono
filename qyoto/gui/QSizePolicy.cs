//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSizePolicy")]
	public class QSizePolicy : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QSizePolicy(Type dummy) {}
		interface IQSizePolicyProxy {
			bool op_equals(QSizePolicy lhs, QSizePolicy s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSizePolicy), this);
			_interceptor = (QSizePolicy) realProxy.GetTransparentProxy();
		}
		private QSizePolicy ProxyQSizePolicy() {
			return (QSizePolicy) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSizePolicy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSizePolicyProxy), null);
			_staticInterceptor = (IQSizePolicyProxy) realProxy.GetTransparentProxy();
		}
		private static IQSizePolicyProxy StaticQSizePolicy() {
			return (IQSizePolicyProxy) _staticInterceptor;
		}

		public enum PolicyFlag {
			GrowFlag = 1,
			ExpandFlag = 2,
			ShrinkFlag = 4,
			IgnoreFlag = 8,
		}
		public enum Policy {
			Fixed = 0,
			Minimum = PolicyFlag.GrowFlag,
			Maximum = PolicyFlag.ShrinkFlag,
			Preferred = PolicyFlag.GrowFlag|PolicyFlag.ShrinkFlag,
			MinimumExpanding = PolicyFlag.GrowFlag|PolicyFlag.ExpandFlag,
			Expanding = PolicyFlag.GrowFlag|PolicyFlag.ShrinkFlag|PolicyFlag.ExpandFlag,
			Ignored = PolicyFlag.ShrinkFlag|PolicyFlag.GrowFlag|PolicyFlag.IgnoreFlag,
		}
		public QSizePolicy() : this((Type) null) {
			CreateProxy();
			NewQSizePolicy();
		}
		[SmokeMethod("QSizePolicy()")]
		private void NewQSizePolicy() {
			ProxyQSizePolicy().NewQSizePolicy();
		}
		public QSizePolicy(QSizePolicy.Policy horizontal, QSizePolicy.Policy vertical) : this((Type) null) {
			CreateProxy();
			NewQSizePolicy(horizontal,vertical);
		}
		[SmokeMethod("QSizePolicy(QSizePolicy::Policy, QSizePolicy::Policy)")]
		private void NewQSizePolicy(QSizePolicy.Policy horizontal, QSizePolicy.Policy vertical) {
			ProxyQSizePolicy().NewQSizePolicy(horizontal,vertical);
		}
		[SmokeMethod("horizontalPolicy() const")]
		public QSizePolicy.Policy HorizontalPolicy() {
			return ProxyQSizePolicy().HorizontalPolicy();
		}
		[SmokeMethod("verticalPolicy() const")]
		public QSizePolicy.Policy VerticalPolicy() {
			return ProxyQSizePolicy().VerticalPolicy();
		}
		[SmokeMethod("setHorizontalPolicy(QSizePolicy::Policy)")]
		public void SetHorizontalPolicy(QSizePolicy.Policy d) {
			ProxyQSizePolicy().SetHorizontalPolicy(d);
		}
		[SmokeMethod("setVerticalPolicy(QSizePolicy::Policy)")]
		public void SetVerticalPolicy(QSizePolicy.Policy d) {
			ProxyQSizePolicy().SetVerticalPolicy(d);
		}
		[SmokeMethod("expandingDirections() const")]
		public int ExpandingDirections() {
			return ProxyQSizePolicy().ExpandingDirections();
		}
		[SmokeMethod("setHeightForWidth(bool)")]
		public void SetHeightForWidth(bool b) {
			ProxyQSizePolicy().SetHeightForWidth(b);
		}
		[SmokeMethod("hasHeightForWidth() const")]
		public bool HasHeightForWidth() {
			return ProxyQSizePolicy().HasHeightForWidth();
		}
		[SmokeMethod("operator==(const QSizePolicy&) const")]
		public static bool operator==(QSizePolicy lhs, QSizePolicy s) {
			return StaticQSizePolicy().op_equals(lhs,s);
		}
		public static bool operator!=(QSizePolicy lhs, QSizePolicy s) {
			return !StaticQSizePolicy().op_equals(lhs,s);
		}
		public override bool Equals(object o) {
			if (!(o is QSizePolicy)) { return false; }
			return this == (QSizePolicy) o;
		}
		public override int GetHashCode() {
			return ProxyQSizePolicy().GetHashCode();
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("horizontalStretch() const")]
		public int HorizontalStretch() {
			return ProxyQSizePolicy().HorizontalStretch();
		}
		[SmokeMethod("verticalStretch() const")]
		public int VerticalStretch() {
			return ProxyQSizePolicy().VerticalStretch();
		}
		[SmokeMethod("setHorizontalStretch(uchar)")]
		public void SetHorizontalStretch(ushort stretchFactor) {
			ProxyQSizePolicy().SetHorizontalStretch(stretchFactor);
		}
		[SmokeMethod("setVerticalStretch(uchar)")]
		public void SetVerticalStretch(ushort stretchFactor) {
			ProxyQSizePolicy().SetVerticalStretch(stretchFactor);
		}
		[SmokeMethod("transpose()")]
		public void Transpose() {
			ProxyQSizePolicy().Transpose();
		}
		~QSizePolicy() {
			DisposeQSizePolicy();
		}
		public void Dispose() {
			DisposeQSizePolicy();
		}
		[SmokeMethod("~QSizePolicy()")]
		private void DisposeQSizePolicy() {
			ProxyQSizePolicy().DisposeQSizePolicy();
		}
	}
}
