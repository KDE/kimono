//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  KIntNumInput combines a QSpinBox and optionally a QSlider
	///  with a label to make an easy to use control for setting some integer
	///  parameter. This is especially nice for configuration dialogs,
	///  which can have many such combinated controls.
	///  The slider is created only when the user specifies a range
	///  for the control using the setRange function or when the user
	///  calls setSliderEnabled.
	///  A special feature of KIntNumInput, designed specifically for
	///  the situation when there are several KIntNumInputs in a column,
	///  is that you can specify what portion of the control is taken by the
	///  QSpinBox (the remaining portion is used by the slider). This makes
	///  it very simple to have all the sliders in a column be the same size.
	///  It uses KIntValidator validator class. KIntNumInput enforces the
	///  value to be in the given range, and can display it in any base
	///  between 2 and 36.
	///  \image html kintnuminput.png "KDE Int Number Input Spinbox"
	///   See <see cref="IKIntNumInputSignals"></see> for signals emitted by KIntNumInput
	/// </remarks>		<short> An input widget for integer numbers, consisting of a spinbox and a slider. </short>
	[SmokeClass("KIntNumInput")]
	public class KIntNumInput : KNumInput, IDisposable {
 		protected KIntNumInput(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KIntNumInput), this);
		}
		[Q_PROPERTY("int", "value")]
		public int Value {
			get { return (int) interceptor.Invoke("value", "value()", typeof(int)); }
			set { interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "minimum")]
		public int Minimum {
			get { return (int) interceptor.Invoke("minimum", "minimum()", typeof(int)); }
			set { interceptor.Invoke("setMinimum$", "setMinimum(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "maximum")]
		public int Maximum {
			get { return (int) interceptor.Invoke("maximum", "maximum()", typeof(int)); }
			set { interceptor.Invoke("setMaximum$", "setMaximum(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "referencePoint")]
		public int ReferencePoint {
			get { return (int) interceptor.Invoke("referencePoint", "referencePoint()", typeof(int)); }
			set { interceptor.Invoke("setReferencePoint$", "setReferencePoint(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("double", "relativeValue")]
		public double RelativeValue {
			get { return (double) interceptor.Invoke("relativeValue", "relativeValue()", typeof(double)); }
			set { interceptor.Invoke("setRelativeValue$", "setRelativeValue(double)", typeof(void), typeof(double), value); }
		}
		[Q_PROPERTY("QString", "suffix")]
		public string Suffix {
			get { return (string) interceptor.Invoke("suffix", "suffix()", typeof(string)); }
			set { interceptor.Invoke("setSuffix$", "setSuffix(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "prefix")]
		public string Prefix {
			get { return (string) interceptor.Invoke("prefix", "prefix()", typeof(string)); }
			set { interceptor.Invoke("setPrefix$", "setPrefix(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "specialValueText")]
		public string SpecialValueText {
			get { return (string) interceptor.Invoke("specialValueText", "specialValueText()", typeof(string)); }
			set { interceptor.Invoke("setSpecialValueText$", "setSpecialValueText(QString)", typeof(void), typeof(string), value); }
		}
		/// <remarks>
		///  Constructs an input control for integer values
		///  with base 10 and initial value 0.
		///      </remarks>		<short>    Constructs an input control for integer values  with base 10 and initial value 0.</short>
		public KIntNumInput(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIntNumInput#", "KIntNumInput(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KIntNumInput() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIntNumInput", "KIntNumInput()", typeof(void));
		}
		/// <remarks>
		///  Constructor
		///  It constructs a QSpinBox that allows the input of integer numbers
		///  in the range of -INT_MAX to +INT_MAX. To set a descriptive label,
		///  use setLabel(). To enforce the value being in a range and optionally to
		///  attach a slider to it, use setRange().
		/// <param> name="value" initial value for the control
		/// </param><param> name="base" numeric base used for display
		/// </param><param> name="parent" parent QWidget
		///      </param></remarks>		<short>    Constructor  It constructs a QSpinBox that allows the input of integer numbers  in the range of -INT_MAX to +INT_MAX.</short>
		public KIntNumInput(int value, QWidget parent, int arg3) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIntNumInput$#$", "KIntNumInput(int, QWidget*, int)", typeof(void), typeof(int), value, typeof(QWidget), parent, typeof(int), arg3);
		}
		public KIntNumInput(int value, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIntNumInput$#", "KIntNumInput(int, QWidget*)", typeof(void), typeof(int), value, typeof(QWidget), parent);
		}
		public KIntNumInput(int value) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIntNumInput$", "KIntNumInput(int)", typeof(void), typeof(int), value);
		}
		/// <remarks>
		///  Constructor
		///  the difference to the one above is the "below" parameter. It tells
		///  this instance that it is visually put below some other KNumInput widget.
		///  Note that these two KNumInput's need not to have the same parent widget
		///  or be in the same layout group.
		///  The effect is that it'll adjust its layout in correspondence
		///  with the layout of the other KNumInput's (you can build an arbitrary long
		///  chain).
		/// <param> name="below" append KIntNumInput to the KNumInput chain
		/// </param><param> name="value" initial value for the control
		/// </param><param> name="base" numeric base used for display
		/// </param><param> name="parent" parent QWidget
		/// </param> \deprecated use the version without the below parameter instead.
		///      </remarks>		<short>    Constructor </short>
		public KIntNumInput(KNumInput below, int value, QWidget parent, int arg4) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIntNumInput#$#$", "KIntNumInput(KNumInput*, int, QWidget*, int)", typeof(void), typeof(KNumInput), below, typeof(int), value, typeof(QWidget), parent, typeof(int), arg4);
		}
		public KIntNumInput(KNumInput below, int value, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIntNumInput#$#", "KIntNumInput(KNumInput*, int, QWidget*)", typeof(void), typeof(KNumInput), below, typeof(int), value, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Sets the allowed input range and the step size for the slider and the
		///  spin box.
		/// <param> name="min" minimum value
		/// </param><param> name="max" maximum value
		/// </param><param> name="step" step size
		///      </param></remarks>		<short>    Sets the allowed input range and the step size for the slider and the  spin box.</short>
		public void SetRange(int min, int max, int step) {
			interceptor.Invoke("setRange$$$", "setRange(int, int, int)", typeof(void), typeof(int), min, typeof(int), max, typeof(int), step);
		}
		public void SetRange(int min, int max) {
			interceptor.Invoke("setRange$$", "setRange(int, int)", typeof(void), typeof(int), min, typeof(int), max);
		}
		/// <remarks>
		/// <param> name="enabled" Show the slider
		///  @default enabled
		///       </param></remarks>		<short>   </short>
		public void SetSliderEnabled(bool enabled) {
			interceptor.Invoke("setSliderEnabled$", "setSliderEnabled(bool)", typeof(void), typeof(bool), enabled);
		}
		public void SetSliderEnabled() {
			interceptor.Invoke("setSliderEnabled", "setSliderEnabled()", typeof(void));
		}
		[SmokeMethod("setLabel(const QString&, Qt::Alignment)")]
		public override void SetLabel(string label, uint a) {
			interceptor.Invoke("setLabel$$", "setLabel(const QString&, Qt::Alignment)", typeof(void), typeof(string), label, typeof(uint), a);
		}
		[SmokeMethod("setLabel(const QString&)")]
		public override void SetLabel(string label) {
			interceptor.Invoke("setLabel$", "setLabel(const QString&)", typeof(void), typeof(string), label);
		}
		/// <remarks>
		///  This method returns the minimum size necessary to display the
		///  control. The minimum size is enough to show all the labels
		///  in the current font (font change may invalidate the return value).
		/// </remarks>		<return> the minimum size necessary to show the control
		///      </return>
		/// 		<short>    This method returns the minimum size necessary to display the  control.</short>
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		/// <remarks>
		///  Sets the value of the control.
		///      </remarks>		<short>    Sets the value of the control.</short>
		[Q_SLOT("void setValue(int)")]
		public void SetValue(int arg1) {
			interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), arg1);
		}
		/// <remarks>
		///  Sets the value in units of the referencePoint
		///      </remarks>		<short>    Sets the value in units of the referencePoint      </short>
		[Q_SLOT("void setRelativeValue(double)")]
		public void SetRelativeValue(double arg1) {
			interceptor.Invoke("setRelativeValue$", "setRelativeValue(double)", typeof(void), typeof(double), arg1);
		}
		/// <remarks>
		///  Sets the reference point for relativeValue.
		///      </remarks>		<short>    Sets the reference point for relativeValue.</short>
		[Q_SLOT("void setReferencePoint(int)")]
		public void SetReferencePoint(int arg1) {
			interceptor.Invoke("setReferencePoint$", "setReferencePoint(int)", typeof(void), typeof(int), arg1);
		}
		/// <remarks>
		///  Sets the suffix to <code>suffix.</code>
		///  Use string() to disable this feature.
		///  Formatting has to be provided (e.g. a space separator between the
		///  prepended <code>value</code> and the suffix's text has to be provided
		///  as the first character in the suffix).
		/// </remarks>		<short>    Sets the suffix to <code>suffix.</code></short>
		/// 		<see> QSpinBox.SetSuffix</see>
		/// 		<see> setPrefix</see>
		[Q_SLOT("void setSuffix(QString)")]
		public void SetSuffix(string suffix) {
			interceptor.Invoke("setSuffix$", "setSuffix(const QString&)", typeof(void), typeof(string), suffix);
		}
		/// <remarks>
		///  Sets the prefix to <code>prefix.</code>
		///  Use string() to disable this feature.
		///  Formatting has to be provided (see above).
		/// </remarks>		<short>    Sets the prefix to <code>prefix.</code></short>
		/// 		<see> QSpinBox.SetPrefix</see>
		/// 		<see> setSuffix</see>
		[Q_SLOT("void setPrefix(QString)")]
		public void SetPrefix(string prefix) {
			interceptor.Invoke("setPrefix$", "setPrefix(const QString&)", typeof(void), typeof(string), prefix);
		}
		/// <remarks>
		///  sets focus to the edit widget and marks all text in if mark == true
		///      </remarks>		<short>    sets focus to the edit widget and marks all text in if mark == true </short>
		[Q_SLOT("void setEditFocus(bool)")]
		public void SetEditFocus(bool mark) {
			interceptor.Invoke("setEditFocus$", "setEditFocus(bool)", typeof(void), typeof(bool), mark);
		}
		[Q_SLOT("void setEditFocus()")]
		public void SetEditFocus() {
			interceptor.Invoke("setEditFocus", "setEditFocus()", typeof(void));
		}
		/// <remarks>
		///      </remarks>		<return> the spin box widget.
		/// </return>
		/// 		<short>   </short>
		protected QSpinBox SpinBox() {
			return (QSpinBox) interceptor.Invoke("spinBox", "spinBox() const", typeof(QSpinBox));
		}
		[SmokeMethod("doLayout()")]
		protected override void DoLayout() {
			interceptor.Invoke("doLayout", "doLayout()", typeof(void));
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		~KIntNumInput() {
			interceptor.Invoke("~KIntNumInput", "~KIntNumInput()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KIntNumInput", "~KIntNumInput()", typeof(void));
		}
		protected new IKIntNumInputSignals Emit {
			get { return (IKIntNumInputSignals) Q_EMIT; }
		}
	}

	public interface IKIntNumInputSignals : IKNumInputSignals {
		/// <remarks>
		///  Emitted every time the value changes (by calling setValue() or
		///  by user interaction).
		///      </remarks>		<short>    Emitted every time the value changes (by calling setValue() or  by user interaction).</short>
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int arg1);
		/// <remarks>
		///  Emitted whenever valueChanged is. Contains the change
		///  relative to the referencePoint.
		///      </remarks>		<short>    Emitted whenever valueChanged is.</short>
		[Q_SIGNAL("void relativeValueChanged(double)")]
		void RelativeValueChanged(double arg1);
	}
}
