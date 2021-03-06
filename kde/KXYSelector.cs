//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  KXYSelector is the base class for other widgets which
    ///  provides the ability to choose from a two-dimensional
    ///  range of values. The currently chosen value is indicated
    ///  by a cross. An example is the KHSSelector which
    ///  allows to choose from a range of colors, and which is
    ///  used in KColorDialog.
    ///  A custom drawing routine for the widget surface has
    ///  to be provided by the subclass.
    ///   See <see cref="IKXYSelectorSignals"></see> for signals emitted by KXYSelector
    /// </remarks>        <short>    KXYSelector is the base class for other widgets which  provides the ability to choose from a two-dimensional  range of values.</short>
    [SmokeClass("KXYSelector")]
    public class KXYSelector : QWidget, IDisposable {
        protected KXYSelector(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KXYSelector), this);
        }
        [Q_PROPERTY("int", "xValue")]
        public int XValue {
            get { return (int) interceptor.Invoke("xValue", "xValue()", typeof(int)); }
            set { interceptor.Invoke("setXValue$", "setXValue(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "yValue")]
        public int YValue {
            get { return (int) interceptor.Invoke("yValue", "yValue()", typeof(int)); }
            set { interceptor.Invoke("setYValue$", "setYValue(int)", typeof(void), typeof(int), value); }
        }
        /// <remarks>
        ///  Constructs a two-dimensional selector widget which
        ///  has a value range of [0..100] in both directions.
        ///    </remarks>        <short>    Constructs a two-dimensional selector widget which  has a value range of [0.</short>
        public KXYSelector(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KXYSelector#", "KXYSelector(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KXYSelector() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KXYSelector", "KXYSelector()", typeof(void));
        }
        /// <remarks>
        ///  Sets the current values in horizontal and
        ///  vertical direction.
        /// <param> name="xPos" the horizontal value
        /// </param><param> name="yPos" the vertical value
        ///    </param></remarks>        <short>    Sets the current values in horizontal and  vertical direction.</short>
        public void SetValues(int xPos, int yPos) {
            interceptor.Invoke("setValues$$", "setValues(int, int)", typeof(void), typeof(int), xPos, typeof(int), yPos);
        }
        /// <remarks>
        ///  Sets the range of possible values.
        ///    </remarks>        <short>    Sets the range of possible values.</short>
        public void SetRange(int minX, int minY, int maxX, int maxY) {
            interceptor.Invoke("setRange$$$$", "setRange(int, int, int, int)", typeof(void), typeof(int), minX, typeof(int), minY, typeof(int), maxX, typeof(int), maxY);
        }
        /// <remarks>
        ///  Sets the color used to draw the marker
        /// <param> name="col" the color
        ///     </param></remarks>        <short>    Sets the color used to draw the marker </short>
        public void SetMarkerColor(QColor col) {
            interceptor.Invoke("setMarkerColor#", "setMarkerColor(const QColor&)", typeof(void), typeof(QColor), col);
        }
        /// <remarks>
        /// </remarks>        <return> the rectangle on which subclasses should draw.
        ///    </return>
        ///         <short>   </short>
        public new QRect ContentsRect() {
            return (QRect) interceptor.Invoke("contentsRect", "contentsRect() const", typeof(QRect));
        }
        /// <remarks>
        ///  Reimplemented to give the widget a minimum size
        ///    </remarks>        <short>    Reimplemented to give the widget a minimum size    </short>
        [SmokeMethod("minimumSizeHint() const")]
        public override QSize MinimumSizeHint() {
            return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
        }
        /// <remarks>
        ///  Override this function to draw the contents of the widget.
        ///  The default implementation does nothing.
        ///  Draw within contentsRect() only.
        ///    </remarks>        <short>    Override this function to draw the contents of the widget.</short>
        [SmokeMethod("drawContents(QPainter*)")]
        protected virtual void DrawContents(QPainter arg1) {
            interceptor.Invoke("drawContents#", "drawContents(QPainter*)", typeof(void), typeof(QPainter), arg1);
        }
        /// <remarks>
        ///  Override this function to draw the marker which
        ///  indicates the currently selected value pair.
        ///    </remarks>        <short>    Override this function to draw the marker which  indicates the currently selected value pair.</short>
        [SmokeMethod("drawMarker(QPainter*, int, int)")]
        protected virtual void DrawMarker(QPainter p, int xp, int yp) {
            interceptor.Invoke("drawMarker#$$", "drawMarker(QPainter*, int, int)", typeof(void), typeof(QPainter), p, typeof(int), xp, typeof(int), yp);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent e) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), e);
        }
        [SmokeMethod("mousePressEvent(QMouseEvent*)")]
        protected override void MousePressEvent(QMouseEvent e) {
            interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
        }
        [SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
        protected override void MouseMoveEvent(QMouseEvent e) {
            interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
        }
        [SmokeMethod("wheelEvent(QWheelEvent*)")]
        protected override void WheelEvent(QWheelEvent arg1) {
            interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
        }
        /// <remarks>
        ///  Converts a pixel position to its corresponding values.
        ///    </remarks>        <short>    Converts a pixel position to its corresponding values.</short>
        protected void ValuesFromPosition(int x, int y, ref int xVal, ref int yVal) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_int = x;
            stack[2].s_int = y;
            stack[3].s_int = xVal;
            stack[4].s_int = yVal;
            interceptor.Invoke("valuesFromPosition$$$$", "valuesFromPosition(int, int, int&, int&) const", stack);
            xVal = stack[3].s_int;
            yVal = stack[4].s_int;
            return;
        }
        ~KXYSelector() {
            interceptor.Invoke("~KXYSelector", "~KXYSelector()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KXYSelector", "~KXYSelector()", typeof(void));
        }
        protected new IKXYSelectorSignals Emit {
            get { return (IKXYSelectorSignals) Q_EMIT; }
        }
    }

    public interface IKXYSelectorSignals : IQWidgetSignals {
        /// <remarks>
        ///  This signal is emitted whenever the user chooses a value,
        ///  e.g. by clicking with the mouse on the widget.
        ///    </remarks>        <short>    This signal is emitted whenever the user chooses a value,  e.</short>
        [Q_SIGNAL("void valueChanged(int, int)")]
        void ValueChanged(int x, int y);
    }
}
