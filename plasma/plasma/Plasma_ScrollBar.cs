//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks>
    ///  @class ScrollBar plasma/widgets/scrollbar.h <Plasma/Widgets/ScrollBar>
    ///  See <see cref="IScrollBarSignals"></see> for signals emitted by ScrollBar
    /// </remarks>        <short> Provides a plasma-themed QScrollBar.  </short>
    [SmokeClass("Plasma::ScrollBar")]
    public class ScrollBar : QGraphicsProxyWidget, IDisposable {
        protected ScrollBar(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ScrollBar), this);
        }
        [Q_PROPERTY("int", "singleStep")]
        public int SingleStep {
            get { return (int) interceptor.Invoke("singleStep", "singleStep()", typeof(int)); }
            set { interceptor.Invoke("setSingleStep$", "setSingleStep(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "pageStep")]
        public int PageStep {
            get { return (int) interceptor.Invoke("pageStep", "pageStep()", typeof(int)); }
            set { interceptor.Invoke("setPageStep$", "setPageStep(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "value")]
        public int Value {
            get { return (int) interceptor.Invoke("value", "value()", typeof(int)); }
            set { interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "minimum")]
        public int Minimum {
            get { return (int) interceptor.Invoke("minimum", "minimum()", typeof(int)); }
        }
        [Q_PROPERTY("int", "maximum")]
        public int Maximum {
            get { return (int) interceptor.Invoke("maximum", "maximum()", typeof(int)); }
        }
        [Q_PROPERTY("QString", "stylesheet")]
        public string Stylesheet {
            get { return (string) interceptor.Invoke("styleSheet", "styleSheet()", typeof(string)); }
            set { interceptor.Invoke("setStyleSheet$", "setStyleSheet(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("QScrollBar*", "nativeWidget")]
        public QScrollBar NativeWidget {
            get { return (QScrollBar) interceptor.Invoke("nativeWidget", "nativeWidget()", typeof(QScrollBar)); }
        }
        /// <remarks>
        ///  Creates a scrollbar; the default orientation is vertical
        ///      </remarks>        <short>    Creates a scrollbar; the default orientation is vertical      </short>
        public ScrollBar(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ScrollBar#", "ScrollBar(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        /// <remarks>
        ///  Sets the scrollbar minimum and maximum values
        ///  @arg min minimum value
        ///  @arg max maximum value
        ///      </remarks>        <short>    Sets the scrollbar minimum and maximum values  @arg min minimum value  @arg max maximum value      </short>
        public void SetRange(int min, int max) {
            interceptor.Invoke("setRange$$", "setRange(int, int)", typeof(void), typeof(int), min, typeof(int), max);
        }
        /// <remarks>
        ///  Sets the current value for the ScrollBar
        ///  @arg value must be minimum() <= value <= maximum()
        ///      </remarks>        <short>    Sets the current value for the ScrollBar  @arg value must be minimum() <= value <= maximum()      </short>
        [Q_SLOT("void setValue(int)")]
        public void SetValue(int val) {
            interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), val);
        }
        /// <remarks>
        ///  Sets the orientation of the ScrollBar.
        ///      </remarks>        <short>    Sets the orientation of the ScrollBar.</short>
        [Q_SLOT("void setOrientation(Qt::Orientation)")]
        public void SetOrientation(Qt.Orientation orientation) {
            interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), orientation);
        }
        ~ScrollBar() {
            interceptor.Invoke("~ScrollBar", "~ScrollBar()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ScrollBar", "~ScrollBar()", typeof(void));
        }
        protected new IScrollBarSignals Emit {
            get { return (IScrollBarSignals) Q_EMIT; }
        }
    }

    public interface IScrollBarSignals : IQGraphicsProxyWidgetSignals {
        /// <remarks>
        ///  Emitted when the value of the slider changes
        ///      </remarks>        <short>    Emitted when the value of the slider changes      </short>
        [Q_SIGNAL("void valueChanged(int)")]
        void ValueChanged(int value);
    }
}
