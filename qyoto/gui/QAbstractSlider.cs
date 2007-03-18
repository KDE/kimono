//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQAbstractSliderSignals"></see> for signals emitted by QAbstractSlider
	[SmokeClass("QAbstractSlider")]
	public abstract class QAbstractSlider : QWidget, IDisposable {
 		protected QAbstractSlider(Type dummy) : base((Type) null) {}
		[SmokeClass("QAbstractSlider")]
		interface IQAbstractSliderProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractSlider), this);
			interceptor = (QAbstractSlider) realProxy.GetTransparentProxy();
		}
		private static IQAbstractSliderProxy staticInterceptor = null;
		static QAbstractSlider() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractSliderProxy), null);
			staticInterceptor = (IQAbstractSliderProxy) realProxy.GetTransparentProxy();
		}
		public enum SliderAction {
			SliderNoAction = 0,
			SliderSingleStepAdd = 1,
			SliderSingleStepSub = 2,
			SliderPageStepAdd = 3,
			SliderPageStepSub = 4,
			SliderToMinimum = 5,
			SliderToMaximum = 6,
			SliderMove = 7,
		}
		public enum SliderChange {
			SliderRangeChange = 0,
			SliderOrientationChange = 1,
			SliderStepsChange = 2,
			SliderValueChange = 3,
		}
		[Q_PROPERTY("int", "minimum")]
		public int Minimum {
			[SmokeMethod("minimum", "()", "")]
			get { return ((QAbstractSlider) interceptor).Minimum; }
			[SmokeMethod("setMinimum", "(int)", "$")]
			set { ((QAbstractSlider) interceptor).Minimum = value; }
		}
		[Q_PROPERTY("int", "maximum")]
		public int Maximum {
			[SmokeMethod("maximum", "()", "")]
			get { return ((QAbstractSlider) interceptor).Maximum; }
			[SmokeMethod("setMaximum", "(int)", "$")]
			set { ((QAbstractSlider) interceptor).Maximum = value; }
		}
		[Q_PROPERTY("int", "singleStep")]
		public int SingleStep {
			[SmokeMethod("singleStep", "()", "")]
			get { return ((QAbstractSlider) interceptor).SingleStep; }
			[SmokeMethod("setSingleStep", "(int)", "$")]
			set { ((QAbstractSlider) interceptor).SingleStep = value; }
		}
		[Q_PROPERTY("int", "pageStep")]
		public int PageStep {
			[SmokeMethod("pageStep", "()", "")]
			get { return ((QAbstractSlider) interceptor).PageStep; }
			[SmokeMethod("setPageStep", "(int)", "$")]
			set { ((QAbstractSlider) interceptor).PageStep = value; }
		}
		[Q_PROPERTY("int", "value")]
		public int Value {
			[SmokeMethod("value", "()", "")]
			get { return ((QAbstractSlider) interceptor).Value; }
			[SmokeMethod("setValue", "(int)", "$")]
			set { ((QAbstractSlider) interceptor).Value = value; }
		}
		[Q_PROPERTY("int", "sliderPosition")]
		public int SliderPosition {
			[SmokeMethod("sliderPosition", "()", "")]
			get { return ((QAbstractSlider) interceptor).SliderPosition; }
			[SmokeMethod("setSliderPosition", "(int)", "$")]
			set { ((QAbstractSlider) interceptor).SliderPosition = value; }
		}
		[Q_PROPERTY("bool", "tracking")]
		public bool Tracking {
			[SmokeMethod("hasTracking", "()", "")]
			get { return ((QAbstractSlider) interceptor).Tracking; }
			[SmokeMethod("setTracking", "(bool)", "$")]
			set { ((QAbstractSlider) interceptor).Tracking = value; }
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public Qt.Orientation Orientation {
			[SmokeMethod("orientation", "()", "")]
			get { return ((QAbstractSlider) interceptor).Orientation; }
			[SmokeMethod("setOrientation", "(Qt::Orientation)", "$")]
			set { ((QAbstractSlider) interceptor).Orientation = value; }
		}
		[Q_PROPERTY("bool", "invertedAppearance")]
		public bool InvertedAppearance {
			[SmokeMethod("invertedAppearance", "()", "")]
			get { return ((QAbstractSlider) interceptor).InvertedAppearance; }
			[SmokeMethod("setInvertedAppearance", "(bool)", "$")]
			set { ((QAbstractSlider) interceptor).InvertedAppearance = value; }
		}
		[Q_PROPERTY("bool", "invertedControls")]
		public bool InvertedControls {
			[SmokeMethod("invertedControls", "()", "")]
			get { return ((QAbstractSlider) interceptor).InvertedControls; }
			[SmokeMethod("setInvertedControls", "(bool)", "$")]
			set { ((QAbstractSlider) interceptor).InvertedControls = value; }
		}
		[Q_PROPERTY("bool", "sliderDown")]
		public bool SliderDown {
			[SmokeMethod("isSliderDown", "()", "")]
			get { return ((QAbstractSlider) interceptor).SliderDown; }
			[SmokeMethod("setSliderDown", "(bool)", "$")]
			set { ((QAbstractSlider) interceptor).SliderDown = value; }
		}
		public QAbstractSlider(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractSlider(parent);
		}
		[SmokeMethod("QAbstractSlider", "(QWidget*)", "#")]
		private void NewQAbstractSlider(QWidget parent) {
			((QAbstractSlider) interceptor).NewQAbstractSlider(parent);
		}
		public QAbstractSlider() : this((Type) null) {
			CreateProxy();
			NewQAbstractSlider();
		}
		[SmokeMethod("QAbstractSlider", "()", "")]
		private void NewQAbstractSlider() {
			((QAbstractSlider) interceptor).NewQAbstractSlider();
		}
		[SmokeMethod("setRange", "(int, int)", "$$")]
		public void SetRange(int min, int max) {
			((QAbstractSlider) interceptor).SetRange(min,max);
		}
		[SmokeMethod("hasTracking", "() const", "")]
		public bool HasTracking() {
			return ((QAbstractSlider) interceptor).HasTracking();
		}
		[SmokeMethod("isSliderDown", "() const", "")]
		public bool IsSliderDown() {
			return ((QAbstractSlider) interceptor).IsSliderDown();
		}
		[SmokeMethod("triggerAction", "(QAbstractSlider::SliderAction)", "$")]
		public void TriggerAction(QAbstractSlider.SliderAction action) {
			((QAbstractSlider) interceptor).TriggerAction(action);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QAbstractSlider) interceptor).Event(e);
		}
		[SmokeMethod("setRepeatAction", "(QAbstractSlider::SliderAction, int, int)", "$$$")]
		protected void SetRepeatAction(QAbstractSlider.SliderAction action, int thresholdTime, int repeatTime) {
			((QAbstractSlider) interceptor).SetRepeatAction(action,thresholdTime,repeatTime);
		}
		[SmokeMethod("setRepeatAction", "(QAbstractSlider::SliderAction, int)", "$$")]
		protected void SetRepeatAction(QAbstractSlider.SliderAction action, int thresholdTime) {
			((QAbstractSlider) interceptor).SetRepeatAction(action,thresholdTime);
		}
		[SmokeMethod("setRepeatAction", "(QAbstractSlider::SliderAction)", "$")]
		protected void SetRepeatAction(QAbstractSlider.SliderAction action) {
			((QAbstractSlider) interceptor).SetRepeatAction(action);
		}
		[SmokeMethod("repeatAction", "() const", "")]
		protected QAbstractSlider.SliderAction RepeatAction() {
			return ((QAbstractSlider) interceptor).RepeatAction();
		}
		[SmokeMethod("sliderChange", "(QAbstractSlider::SliderChange)", "$")]
		protected virtual void sliderChange(QAbstractSlider.SliderChange change) {
			((QAbstractSlider) interceptor).sliderChange(change);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent ev) {
			((QAbstractSlider) interceptor).KeyPressEvent(ev);
		}
		[SmokeMethod("timerEvent", "(QTimerEvent*)", "#")]
		protected override void TimerEvent(QTimerEvent arg1) {
			((QAbstractSlider) interceptor).TimerEvent(arg1);
		}
		[SmokeMethod("wheelEvent", "(QWheelEvent*)", "#")]
		protected override void WheelEvent(QWheelEvent e) {
			((QAbstractSlider) interceptor).WheelEvent(e);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent e) {
			((QAbstractSlider) interceptor).ChangeEvent(e);
		}
		~QAbstractSlider() {
			DisposeQAbstractSlider();
		}
		public new void Dispose() {
			DisposeQAbstractSlider();
		}
		[SmokeMethod("~QAbstractSlider", "()", "")]
		private void DisposeQAbstractSlider() {
			((QAbstractSlider) interceptor).DisposeQAbstractSlider();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQAbstractSliderSignals Emit {
			get { return (IQAbstractSliderSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractSliderSignals : IQWidgetSignals {
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int value);
		[Q_SIGNAL("void sliderPressed()")]
		void SliderPressed();
		[Q_SIGNAL("void sliderMoved(int)")]
		void SliderMoved(int position);
		[Q_SIGNAL("void sliderReleased()")]
		void SliderReleased();
		[Q_SIGNAL("void rangeChanged(int, int)")]
		void RangeChanged(int min, int max);
		[Q_SIGNAL("void actionTriggered(int)")]
		void ActionTriggered(int action);
	}
}
