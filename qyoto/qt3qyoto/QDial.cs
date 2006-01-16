//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQDialSignals"></see> for signals emitted by QDial
	[SmokeClass("QDial")]
	public class QDial : QWidget, IQRangeControl, IDisposable {
 		protected QDial(Type dummy) : base((Type) null) {}
		interface IQDialProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDial), this);
			_interceptor = (QDial) realProxy.GetTransparentProxy();
		}
		private QDial ProxyQDial() {
			return (QDial) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDial() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDialProxy), null);
			_staticInterceptor = (IQDialProxy) realProxy.GetTransparentProxy();
		}
		private static IQDialProxy StaticQDial() {
			return (IQDialProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQDial().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQDial().ClassName();
		}
		public QDial(QWidget parent, string name, int f) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQDial(parent,name,f);
		}
		[SmokeMethod("QDial(QWidget*, const char*, Qt::WFlags)")]
		private void NewQDial(QWidget parent, string name, int f) {
			ProxyQDial().NewQDial(parent,name,f);
		}
		public QDial(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQDial(parent,name);
		}
		[SmokeMethod("QDial(QWidget*, const char*)")]
		private void NewQDial(QWidget parent, string name) {
			ProxyQDial().NewQDial(parent,name);
		}
		public QDial(QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQDial(parent);
		}
		[SmokeMethod("QDial(QWidget*)")]
		private void NewQDial(QWidget parent) {
			ProxyQDial().NewQDial(parent);
		}
		public QDial() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQDial();
		}
		[SmokeMethod("QDial()")]
		private void NewQDial() {
			ProxyQDial().NewQDial();
		}
		public QDial(int minValue, int maxValue, int pageStep, int value, QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQDial(minValue,maxValue,pageStep,value,parent,name);
		}
		[SmokeMethod("QDial(int, int, int, int, QWidget*, const char*)")]
		private void NewQDial(int minValue, int maxValue, int pageStep, int value, QWidget parent, string name) {
			ProxyQDial().NewQDial(minValue,maxValue,pageStep,value,parent,name);
		}
		public QDial(int minValue, int maxValue, int pageStep, int value, QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQDial(minValue,maxValue,pageStep,value,parent);
		}
		[SmokeMethod("QDial(int, int, int, int, QWidget*)")]
		private void NewQDial(int minValue, int maxValue, int pageStep, int value, QWidget parent) {
			ProxyQDial().NewQDial(minValue,maxValue,pageStep,value,parent);
		}
		public QDial(int minValue, int maxValue, int pageStep, int value) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQDial(minValue,maxValue,pageStep,value);
		}
		[SmokeMethod("QDial(int, int, int, int)")]
		private void NewQDial(int minValue, int maxValue, int pageStep, int value) {
			ProxyQDial().NewQDial(minValue,maxValue,pageStep,value);
		}
		[SmokeMethod("tracking() const")]
		public bool Tracking() {
			return ProxyQDial().Tracking();
		}
		[SmokeMethod("wrapping() const")]
		public bool Wrapping() {
			return ProxyQDial().Wrapping();
		}
		[SmokeMethod("notchSize() const")]
		public int NotchSize() {
			return ProxyQDial().NotchSize();
		}
		[SmokeMethod("setNotchTarget(double)")]
		public virtual void SetNotchTarget(double arg1) {
			ProxyQDial().SetNotchTarget(arg1);
		}
		[SmokeMethod("notchTarget() const")]
		public double NotchTarget() {
			return ProxyQDial().NotchTarget();
		}
		[SmokeMethod("notchesVisible() const")]
		public bool NotchesVisible() {
			return ProxyQDial().NotchesVisible();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQDial().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQDial().MinimumSizeHint();
		}
		[SmokeMethod("minValue() const")]
		public int MinValue() {
			return ProxyQDial().MinValue();
		}
		[SmokeMethod("maxValue() const")]
		public int MaxValue() {
			return ProxyQDial().MaxValue();
		}
		[SmokeMethod("setMinValue(int)")]
		public void SetMinValue(int arg1) {
			ProxyQDial().SetMinValue(arg1);
		}
		[SmokeMethod("setMaxValue(int)")]
		public void SetMaxValue(int arg1) {
			ProxyQDial().SetMaxValue(arg1);
		}
		[SmokeMethod("lineStep() const")]
		public int LineStep() {
			return ProxyQDial().LineStep();
		}
		[SmokeMethod("pageStep() const")]
		public int PageStep() {
			return ProxyQDial().PageStep();
		}
		[SmokeMethod("setLineStep(int)")]
		public void SetLineStep(int arg1) {
			ProxyQDial().SetLineStep(arg1);
		}
		[SmokeMethod("setPageStep(int)")]
		public void SetPageStep(int arg1) {
			ProxyQDial().SetPageStep(arg1);
		}
		[SmokeMethod("value() const")]
		public int Value() {
			return ProxyQDial().Value();
		}
		[Q_SLOT("void setValue(int)")]
		[SmokeMethod("setValue(int)")]
		public virtual void SetValue(int arg1) {
			ProxyQDial().SetValue(arg1);
		}
		[Q_SLOT("void addLine()")]
		[SmokeMethod("addLine()")]
		public void AddLine() {
			ProxyQDial().AddLine();
		}
		[Q_SLOT("void subtractLine()")]
		[SmokeMethod("subtractLine()")]
		public void SubtractLine() {
			ProxyQDial().SubtractLine();
		}
		[Q_SLOT("void addPage()")]
		[SmokeMethod("addPage()")]
		public void AddPage() {
			ProxyQDial().AddPage();
		}
		[Q_SLOT("void subtractPage()")]
		[SmokeMethod("subtractPage()")]
		public void SubtractPage() {
			ProxyQDial().SubtractPage();
		}
		[Q_SLOT("void setNotchesVisible(bool)")]
		[SmokeMethod("setNotchesVisible(bool)")]
		public virtual void SetNotchesVisible(bool b) {
			ProxyQDial().SetNotchesVisible(b);
		}
		[Q_SLOT("void setWrapping(bool)")]
		[SmokeMethod("setWrapping(bool)")]
		public virtual void SetWrapping(bool on) {
			ProxyQDial().SetWrapping(on);
		}
		[Q_SLOT("void setTracking(bool)")]
		[SmokeMethod("setTracking(bool)")]
		public virtual void SetTracking(bool enable) {
			ProxyQDial().SetTracking(enable);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQDial().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQDial().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQDial().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQDial().TrUtf8(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQDial().ResizeEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQDial().PaintEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQDial().KeyPressEvent(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQDial().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQDial().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQDial().MouseMoveEvent(arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent arg1) {
			ProxyQDial().WheelEvent(arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected new void FocusInEvent(QFocusEvent arg1) {
			ProxyQDial().FocusInEvent(arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected new void FocusOutEvent(QFocusEvent arg1) {
			ProxyQDial().FocusOutEvent(arg1);
		}
		[SmokeMethod("valueChange()")]
		protected void ValueChange() {
			ProxyQDial().ValueChange();
		}
		[SmokeMethod("rangeChange()")]
		protected void RangeChange() {
			ProxyQDial().RangeChange();
		}
		[SmokeMethod("repaintScreen(const QRect*)")]
		protected virtual void RepaintScreen(QRect cr) {
			ProxyQDial().RepaintScreen(cr);
		}
		[SmokeMethod("repaintScreen()")]
		protected virtual void RepaintScreen() {
			ProxyQDial().RepaintScreen();
		}
		~QDial() {
			DisposeQDial();
		}
		public new void Dispose() {
			DisposeQDial();
		}
		private void DisposeQDial() {
			ProxyQDial().DisposeQDial();
		}
		[SmokeMethod("setRange(int, int)")]
		public void SetRange(int minValue, int maxValue) {
			ProxyQDial().SetRange(minValue,maxValue);
		}
		[SmokeMethod("setSteps(int, int)")]
		public void SetSteps(int line, int page) {
			ProxyQDial().SetSteps(line,page);
		}
		[SmokeMethod("bound(int) const")]
		public int Bound(int arg1) {
			return ProxyQDial().Bound(arg1);
		}
		[SmokeMethod("positionFromValue(int, int) const")]
		protected int PositionFromValue(int val, int space) {
			return ProxyQDial().PositionFromValue(val,space);
		}
		[SmokeMethod("valueFromPosition(int, int) const")]
		protected int ValueFromPosition(int pos, int space) {
			return ProxyQDial().ValueFromPosition(pos,space);
		}
		[SmokeMethod("directSetValue(int)")]
		protected void DirectSetValue(int val) {
			ProxyQDial().DirectSetValue(val);
		}
		[SmokeMethod("prevValue() const")]
		protected int PrevValue() {
			return ProxyQDial().PrevValue();
		}
		[SmokeMethod("stepChange()")]
		protected virtual void StepChange() {
			ProxyQDial().StepChange();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQDialSignals), this);
			Q_EMIT = (IQDialSignals) realProxy.GetTransparentProxy();
		}
		protected new IQDialSignals Emit() {
			return (IQDialSignals) Q_EMIT;
		}
	}

	public interface IQDialSignals : IQWidgetSignals {
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int value);
		[Q_SIGNAL("void dialPressed()")]
		void DialPressed();
		[Q_SIGNAL("void dialMoved(int)")]
		void DialMoved(int value);
		[Q_SIGNAL("void dialReleased()")]
		void DialReleased();
	}
}
