//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    ///  @class Slider plasma/widgets/slider.h <Plasma/Widgets/Slider>
    ///  See <see cref="ISliderSignals"></see> for signals emitted by Slider
    /// </remarks>        <short> Provides a plasma-themed QSlider.  </short>
    [SmokeClass("Plasma::Slider")]
    public class Slider : QGraphicsProxyWidget, IDisposable {
        protected Slider(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Slider), this);
        }
        [Q_PROPERTY("QGraphicsWidget*", "parentWidget")]
        public QGraphicsWidget ParentWidget {
            get { return (QGraphicsWidget) interceptor.Invoke("parentWidget", "parentWidget()", typeof(QGraphicsWidget)); }
        }
        [Q_PROPERTY("int", "maximum")]
        public int Maximum {
            get { return (int) interceptor.Invoke("maximum", "maximum()", typeof(int)); }
            set { interceptor.Invoke("setMinimum$", "setMinimum(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "minimum")]
        public int Minimum {
            get { return (int) interceptor.Invoke("minimum", "minimum()", typeof(int)); }
            set { interceptor.Invoke("setMinimum$", "setMinimum(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "value")]
        public int Value {
            get { return (int) interceptor.Invoke("value", "value()", typeof(int)); }
            set { interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("Qt::Orientation", "orientation")]
        public new Qt.Orientation Orientation {
            get { return (Qt.Orientation) interceptor.Invoke("orientation", "orientation()", typeof(Qt.Orientation)); }
            set { interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), value); }
        }
        [Q_PROPERTY("QString", "styleSheet")]
        public string StyleSheet {
            get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
            set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QSlider*", "nativeWidget")]
        public QSlider NativeWidget {
            get { return (QSlider) interceptor.Invoke("nativeWidget", "nativeWidget()", typeof(QSlider)); }
        }
        public Slider(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Slider#", "Slider(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        public Slider() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Slider", "Slider()", typeof(void));
        }
        /// <remarks>
        ///  Sets the maximum value the slider can take.
        ///      </remarks>        <short>    Sets the maximum value the slider can take.</short>
        [Q_SLOT("void setMaximum(int)")]
        public void SetMaximum(int maximum) {
            interceptor.Invoke("setMaximum$", "setMaximum(int)", typeof(void), typeof(int), maximum);
        }
        /// <remarks>
        ///  Sets the minimum value the slider can take.
        ///      </remarks>        <short>    Sets the minimum value the slider can take.</short>
        [Q_SLOT("void setMinimum(int)")]
        public void SetMinimum(int minimum) {
            interceptor.Invoke("setMinimum$", "setMinimum(int)", typeof(void), typeof(int), minimum);
        }
        /// <remarks>
        ///  Sets the minimum and maximum values the slider can take.
        ///      </remarks>        <short>    Sets the minimum and maximum values the slider can take.</short>
        [Q_SLOT("void setRange(int, int)")]
        public void SetRange(int minimum, int maximum) {
            interceptor.Invoke("setRange$$", "setRange(int, int)", typeof(void), typeof(int), minimum, typeof(int), maximum);
        }
        /// <remarks>
        ///  Sets the value of the slider.
        ///  If it is outside the range specified by minimum() and maximum(),
        ///  it will be adjusted to fit.
        ///      </remarks>        <short>    Sets the value of the slider.</short>
        [Q_SLOT("void setValue(int)")]
        public void SetValue(int value) {
            interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value);
        }
        /// <remarks>
        ///  Sets the orientation of the slider.
        ///      </remarks>        <short>    Sets the orientation of the slider.</short>
        [Q_SLOT("void setOrientation(Qt::Orientation)")]
        public void SetOrientation(Qt.Orientation orientation) {
            interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), orientation);
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
        protected new virtual void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
            interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
        }
        [SmokeMethod("wheelEvent(QGraphicsSceneWheelEvent*)")]
        protected override void WheelEvent(QGraphicsSceneWheelEvent arg1) {
            interceptor.Invoke("wheelEvent#", "wheelEvent(QGraphicsSceneWheelEvent*)", typeof(void), typeof(QGraphicsSceneWheelEvent), arg1);
        }
        ~Slider() {
            interceptor.Invoke("~Slider", "~Slider()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~Slider", "~Slider()", typeof(void));
        }
        protected new ISliderSignals Emit {
            get { return (ISliderSignals) Q_EMIT; }
        }
    }

    public interface ISliderSignals : IQGraphicsProxyWidgetSignals {
        /// <remarks>
        ///  This signal is emitted when the user drags the slider.
        ///  In fact, it is emitted whenever the sliderMoved(int) signal
        ///  of QSlider would be emitted.  See the Qt documentation for
        ///  more information.
        ///      </remarks>        <short>    This signal is emitted when the user drags the slider.</short>
        [Q_SIGNAL("void sliderMoved(int)")]
        void SliderMoved(int value);
        /// <remarks>
        ///  This signal is emitted when the slider value has changed,
        ///  with the new slider value as argument.
        ///      </remarks>        <short>    This signal is emitted when the slider value has changed,  with the new slider value as argument.</short>
        [Q_SIGNAL("void valueChanged(int)")]
        void ValueChanged(int value);
    }
}
