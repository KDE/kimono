//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDial")]
	public class QDial : QAbstractSlider, IDisposable {
 		protected QDial(Type dummy) : base((Type) null) {}
		[SmokeClass("QDial")]
		interface IQDialProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDial), this);
			interceptor = (QDial) realProxy.GetTransparentProxy();
		}
		private static IQDialProxy staticInterceptor = null;
		static QDial() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDialProxy), null);
			staticInterceptor = (IQDialProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("bool", "wrapping")]
		public bool Wrapping {
			[SmokeMethod("wrapping", "()", "")]
			get { return ((QDial) interceptor).Wrapping; }
			[SmokeMethod("setWrapping", "(bool)", "$")]
			set { ((QDial) interceptor).Wrapping = value; }
		}
		[Q_PROPERTY("int", "notchSize")]
		public int NotchSize {
			[SmokeMethod("notchSize", "()", "")]
			get { return ((QDial) interceptor).NotchSize; }
		}
		[Q_PROPERTY("qreal", "notchTarget")]
		public double NotchTarget {
			[SmokeMethod("notchTarget", "()", "")]
			get { return ((QDial) interceptor).NotchTarget; }
			[SmokeMethod("setNotchTarget", "(qreal)", "$")]
			set { ((QDial) interceptor).NotchTarget = value; }
		}
		[Q_PROPERTY("bool", "notchesVisible")]
		public bool NotchesVisible {
			[SmokeMethod("notchesVisible", "()", "")]
			get { return ((QDial) interceptor).NotchesVisible; }
			[SmokeMethod("setNotchesVisible", "(bool)", "$")]
			set { ((QDial) interceptor).NotchesVisible = value; }
		}
		public QDial(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDial(parent);
		}
		[SmokeMethod("QDial", "(QWidget*)", "#")]
		private void NewQDial(QWidget parent) {
			((QDial) interceptor).NewQDial(parent);
		}
		public QDial() : this((Type) null) {
			CreateProxy();
			NewQDial();
		}
		[SmokeMethod("QDial", "()", "")]
		private void NewQDial() {
			((QDial) interceptor).NewQDial();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QDial) interceptor).SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ((QDial) interceptor).MinimumSizeHint();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QDial) interceptor).Event(e);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent re) {
			((QDial) interceptor).ResizeEvent(re);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent pe) {
			((QDial) interceptor).PaintEvent(pe);
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected override void MousePressEvent(QMouseEvent me) {
			((QDial) interceptor).MousePressEvent(me);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected override void MouseReleaseEvent(QMouseEvent me) {
			((QDial) interceptor).MouseReleaseEvent(me);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected override void MouseMoveEvent(QMouseEvent me) {
			((QDial) interceptor).MouseMoveEvent(me);
		}
		[SmokeMethod("sliderChange", "(QAbstractSlider::SliderChange)", "$")]
		protected override void sliderChange(QAbstractSlider.SliderChange change) {
			((QDial) interceptor).sliderChange(change);
		}
		~QDial() {
			DisposeQDial();
		}
		public new void Dispose() {
			DisposeQDial();
		}
		[SmokeMethod("~QDial", "()", "")]
		private void DisposeQDial() {
			((QDial) interceptor).DisposeQDial();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQDialSignals Emit {
			get { return (IQDialSignals) Q_EMIT; }
		}
	}

	public interface IQDialSignals : IQAbstractSliderSignals {
	}
}
