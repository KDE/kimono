//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  A ruler widget.
	///  The vertical ruler looks similar to this:
	/// <pre>
	///     meters                       inches
	///     ------   <--- end mark  --. ------
	///         --                            -
	///         --   <---little mark--.     --
	///         --                            -
	///         --                          ---
	///        ---   <---medium mark          -
	///         --                           --
	///         --        tiny mark---.      -
	///         --                         ----
	///         --                            -
	///       ----   <-----big mark          --
	///         --                            -
	///       |>--   <--ruler pointer-.   |>--
	///  </pre>
	///  There are tiny marks, little marks, medium marks, and big marks along the
	///   ruler.
	///  To receive mouse clicks or mouse moves,
	///  the class has to be overloaded.
	///  For performance reasons, the public methods don't call QWidget.Repaint().
	///  (Slots do, see documentation below.)
	///  All the changed settings will be painted once after leaving
	///  to the main event loop.
	///  For performance painting the slot methods should be used,
	///  they do a fast QWidget.Repaint() call after changing the values.
	///  For setting multiple values like minValue(), maxValue(), offset() etc.
	///  using the public methods is recommended
	///  so the widget will be painted only once when entering the main event loop.
	/// </remarks>		<author> Jörg Habenicht
	///  </author>
	/// 		<short> A ruler widget. </short>
	[SmokeClass("KRuler")]
	public class KRuler : QAbstractSlider, IDisposable {
 		protected KRuler(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KRuler), this);
		}
		/// <remarks>
		///  The types of units used.
		/// </remarks>		<short>    The types of units used.</short>
		public enum MetricStyle {
			Custom = 0,
			Pixel = 1,
			Inch = 2,
			Millimetres = 3,
			Centimetres = 4,
			Metres = 5,
		}
		[Q_PROPERTY("bool", "showTinyMarks")]
		public bool ShowTinyMarks {
			get { return (bool) interceptor.Invoke("showTinyMarks", "showTinyMarks()", typeof(bool)); }
			set { interceptor.Invoke("setShowTinyMarks$", "setShowTinyMarks(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "showLittleMarks")]
		public bool ShowLittleMarks {
			get { return (bool) interceptor.Invoke("showLittleMarks", "showLittleMarks()", typeof(bool)); }
			set { interceptor.Invoke("setShowLittleMarks$", "setShowLittleMarks(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "showMediumMarks")]
		public bool ShowMediumMarks {
			get { return (bool) interceptor.Invoke("showMediumMarks", "showMediumMarks()", typeof(bool)); }
			set { interceptor.Invoke("setShowMediumMarks$", "setShowMediumMarks(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "showBigMarks")]
		public bool ShowBigMarks {
			get { return (bool) interceptor.Invoke("showBigMarks", "showBigMarks()", typeof(bool)); }
			set { interceptor.Invoke("setShowBigMarks$", "setShowBigMarks(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "showPointer")]
		public bool ShowPointer {
			get { return (bool) interceptor.Invoke("showPointer", "showPointer()", typeof(bool)); }
			set { interceptor.Invoke("setShowPointer$", "setShowPointer(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "showEndLabel")]
		public bool ShowEndLabel {
			get { return (bool) interceptor.Invoke("showEndLabel", "showEndLabel()", typeof(bool)); }
			set { interceptor.Invoke("setShowEndLabel$", "setShowEndLabel(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "tinyMarkDistance")]
		public int TinyMarkDistance {
			get { return (int) interceptor.Invoke("tinyMarkDistance", "tinyMarkDistance()", typeof(int)); }
			set { interceptor.Invoke("setTinyMarkDistance$", "setTinyMarkDistance(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "littleMarkDistance")]
		public int LittleMarkDistance {
			get { return (int) interceptor.Invoke("littleMarkDistance", "littleMarkDistance()", typeof(int)); }
			set { interceptor.Invoke("setLittleMarkDistance$", "setLittleMarkDistance(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "mediumMarkDistance")]
		public int MediumMarkDistance {
			get { return (int) interceptor.Invoke("mediumMarkDistance", "mediumMarkDistance()", typeof(int)); }
			set { interceptor.Invoke("setBigMarkDistance$", "setBigMarkDistance(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "bigMarkDistance")]
		public int BigMarkDistance {
			get { return (int) interceptor.Invoke("bigMarkDistance", "bigMarkDistance()", typeof(int)); }
			set { interceptor.Invoke("setBigMarkDistance$", "setBigMarkDistance(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("double", "pixelPerMark")]
		public double PixelPerMark {
			get { return (double) interceptor.Invoke("pixelPerMark", "pixelPerMark()", typeof(double)); }
			set { interceptor.Invoke("setPixelPerMark$", "setPixelPerMark(double)", typeof(void), typeof(double), value); }
		}
		[Q_PROPERTY("bool", "lengthFixed")]
		public bool LengthFixed {
			get { return (bool) interceptor.Invoke("lengthFixed", "lengthFixed()", typeof(bool)); }
			set { interceptor.Invoke("setLengthFixed$", "setLengthFixed(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "endLabel")]
		public string EndLabel {
			get { return (string) interceptor.Invoke("endLabel", "endLabel()", typeof(string)); }
			set { interceptor.Invoke("setEndLabel$", "setEndLabel(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("KRuler::MetricStyle", "rulerMetricStyle")]
		public KRuler.MetricStyle RulerMetricStyle {
			get { return (KRuler.MetricStyle) interceptor.Invoke("setRulerMetricStyle", "setRulerMetricStyle()", typeof(KRuler.MetricStyle)); }
		}
		[Q_PROPERTY("int", "length")]
		public int Length {
			get { return (int) interceptor.Invoke("length", "length()", typeof(int)); }
			set { interceptor.Invoke("setLength$", "setLength(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "offset")]
		public int Offset {
			get { return (int) interceptor.Invoke("offset", "offset()", typeof(int)); }
		}
		[Q_PROPERTY("int", "endOffset")]
		public int EndOffset {
			get { return (int) interceptor.Invoke("endOffset", "endOffset()", typeof(int)); }
		}
		/// <remarks>
		///  Constructs a horizontal ruler.
		///    </remarks>		<short>    Constructs a horizontal ruler.</short>
		public KRuler(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler#", "KRuler(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KRuler() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler", "KRuler()", typeof(void));
		}
		/// <remarks>
		///  Constructs a ruler with orientation <code>orient.</code>
		///  <code>parent</code> and <code>f</code> are passed to QFrame.
		///  The default look is a raised widget
		///  but may be changed with the inherited QFrame methods.
		/// <param> name="orient" Orientation of the ruler.
		/// </param><param> name="parent" Will be handed over to QFrame.
		/// </param><param> name="f" Will be handed over to QFrame.
		/// </param></remarks>		<short>    Constructs a ruler with orientation <code>orient.</code></short>
		public KRuler(Qt.Orientation orient, QWidget parent, uint f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler$#$", "KRuler(Qt::Orientation, QWidget*, Qt::WindowFlags)", typeof(void), typeof(Qt.Orientation), orient, typeof(QWidget), parent, typeof(uint), f);
		}
		public KRuler(Qt.Orientation orient, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler$#", "KRuler(Qt::Orientation, QWidget*)", typeof(void), typeof(Qt.Orientation), orient, typeof(QWidget), parent);
		}
		public KRuler(Qt.Orientation orient) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler$", "KRuler(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), orient);
		}
		/// <remarks>
		///  Constructs a ruler with orientation <code>orient</code> and initial width <code>widgetWidth.</code>
		///  The width sets the fixed width of the widget. This is useful if you
		///  want to draw the ruler bigger or smaller than the default size.
		///  Note: The size of the marks doesn't change.
		///  <code>parent</code> and <code>f</code> are passed to QFrame.
		/// <param> name="orient" Orientation of the ruler.
		/// </param><param> name="widgetWidth" Fixed width of the widget.
		/// </param><param> name="parent" Will be handed over to QFrame.
		/// </param><param> name="f" Will be handed over to QFrame.
		/// </param>   </remarks>		<short>    Constructs a ruler with orientation <code>orient</code> and initial width <code>widgetWidth.</code></short>
		public KRuler(Qt.Orientation orient, int widgetWidth, QWidget parent, uint f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler$$#$", "KRuler(Qt::Orientation, int, QWidget*, Qt::WindowFlags)", typeof(void), typeof(Qt.Orientation), orient, typeof(int), widgetWidth, typeof(QWidget), parent, typeof(uint), f);
		}
		public KRuler(Qt.Orientation orient, int widgetWidth, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler$$#", "KRuler(Qt::Orientation, int, QWidget*)", typeof(void), typeof(Qt.Orientation), orient, typeof(int), widgetWidth, typeof(QWidget), parent);
		}
		public KRuler(Qt.Orientation orient, int widgetWidth) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRuler$$", "KRuler(Qt::Orientation, int)", typeof(void), typeof(Qt.Orientation), orient, typeof(int), widgetWidth);
		}
		/// <remarks>
		///  Shows/hides end marks.
		/// </remarks>		<short>    Shows/hides end marks.</short>
		public void SetShowEndMarks(bool arg1) {
			interceptor.Invoke("setShowEndMarks$", "setShowEndMarks(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool ShowEndMarks() {
			return (bool) interceptor.Invoke("showEndMarks", "showEndMarks() const", typeof(bool));
		}
		public void SetFrameStyle(int arg1) {
			interceptor.Invoke("setFrameStyle$", "setFrameStyle(int)", typeof(void), typeof(int), arg1);
		}
		/// <remarks>
		///  Sets the number of pixels by which the ruler may slide up or left.
		///  The number of pixels moved is realive to the previous position.
		///  The Method makes sense for updating a ruler, which is working with
		///  a scrollbar.
		///  This doesn't affect the position of the ruler pointer.
		///  Only the visible part of the ruler is moved.
		/// <param> name="count" Number of pixel moving up or left relative to the previous position
		/// </param></remarks>		<short>    Sets the number of pixels by which the ruler may slide up or left.</short>
		public void SlideUp(int count) {
			interceptor.Invoke("slideUp$", "slideUp(int)", typeof(void), typeof(int), count);
		}
		public void SlideUp() {
			interceptor.Invoke("slideUp", "slideUp()", typeof(void));
		}
		/// <remarks>
		///  Sets the number of pixels by which the ruler may slide down or right.
		///  The number of pixels moved is realive to the previous position.
		///  The Method makes sense for updating a ruler, which is working with
		///  a scrollbar.
		///  This doesn't affect the position of the ruler pointer.
		///  Only the visible part of the ruler is moved.
		/// <param> name="count" Number of pixel moving up or left relative to the previous position
		/// </param></remarks>		<short>    Sets the number of pixels by which the ruler may slide down or right.</short>
		public void SlideDown(int count) {
			interceptor.Invoke("slideDown$", "slideDown(int)", typeof(void), typeof(int), count);
		}
		public void SlideDown() {
			interceptor.Invoke("slideDown", "slideDown()", typeof(void));
		}
		/// <remarks>
		///  Sets the pointer to a new position.
		///  The offset is NOT updated.
		///  QWidget.Repaint() is called afterwards.
		/// </remarks>		<short>    Sets the pointer to a new position.</short>
		[Q_SLOT("void slotNewValue(int)")]
		public void SlotNewValue(int arg1) {
			interceptor.Invoke("slotNewValue$", "slotNewValue(int)", typeof(void), typeof(int), arg1);
		}
		/// <remarks>
		///  Sets the ruler marks to a new position.
		///  The pointer is NOT updated.
		///  QWidget.Repaint() is called afterwards.
		/// </remarks>		<short>    Sets the ruler marks to a new position.</short>
		[Q_SLOT("void slotNewOffset(int)")]
		public void SlotNewOffset(int arg1) {
			interceptor.Invoke("slotNewOffset$", "slotNewOffset(int)", typeof(void), typeof(int), arg1);
		}
		[Q_SLOT("void slotEndOffset(int)")]
		public void SlotEndOffset(int arg1) {
			interceptor.Invoke("slotEndOffset$", "slotEndOffset(int)", typeof(void), typeof(int), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		~KRuler() {
			interceptor.Invoke("~KRuler", "~KRuler()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KRuler", "~KRuler()", typeof(void));
		}
		protected new IKRulerSignals Emit {
			get { return (IKRulerSignals) Q_EMIT; }
		}
	}

	public interface IKRulerSignals : IQAbstractSliderSignals {
	}
}
