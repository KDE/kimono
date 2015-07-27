//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///   A QSpinBox with support for arbitrary base numbers
    ///   (e.g. hexadecimal).
    ///   The class provides an easy interface to use other
    ///   numeric systems than the decimal.
    ///  </remarks>        <short> A QSpinBox with support for arbitrary base numbers. </short>
    [SmokeClass("KIntSpinBox")]
    public class KIntSpinBox : QSpinBox, IDisposable {
        protected KIntSpinBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KIntSpinBox), this);
        }
        [Q_PROPERTY("int", "base")]
        public int Base {
            get { return (int) interceptor.Invoke("base", "base()", typeof(int)); }
            set { interceptor.Invoke("setBase$", "setBase(int)", typeof(void), typeof(int), value); }
        }
        /// <remarks>
        ///   Constructor.
        ///   Constructs a widget with an integer inputline with a little scrollbar
        ///   and a slider, with minimal value 0, maximal value 99, step 1, base 10
        ///   and initial value 0.
        ///      </remarks>        <short>     Constructor.</short>
        public KIntSpinBox(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KIntSpinBox#", "KIntSpinBox(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KIntSpinBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KIntSpinBox", "KIntSpinBox()", typeof(void));
        }
        /// <remarks>
        ///   Constructor.
        ///   Constructs a widget with an integer inputline with a little scrollbar
        ///   and a slider.
        /// <param> name="lower" The lowest valid value.
        /// </param><param> name="upper" The greatest valid value.
        /// </param><param> name="step" The step size of the scrollbar.
        /// </param><param> name="value" The actual value.
        /// </param><param> name="base" The base of the used number system.
        /// </param><param> name="parent" The parent of the widget.
        ///      </param></remarks>        <short>     Constructor.</short>
        public KIntSpinBox(int lower, int upper, int step, int value, QWidget parent, int arg6) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KIntSpinBox$$$$#$", "KIntSpinBox(int, int, int, int, QWidget*, int)", typeof(void), typeof(int), lower, typeof(int), upper, typeof(int), step, typeof(int), value, typeof(QWidget), parent, typeof(int), arg6);
        }
        public KIntSpinBox(int lower, int upper, int step, int value, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KIntSpinBox$$$$#", "KIntSpinBox(int, int, int, int, QWidget*)", typeof(void), typeof(int), lower, typeof(int), upper, typeof(int), step, typeof(int), value, typeof(QWidget), parent);
        }
        /// <remarks>
        ///  sets focus and optionally marks all text
        ///      </remarks>        <short>    sets focus and optionally marks all text </short>
        public void SetEditFocus(bool mark) {
            interceptor.Invoke("setEditFocus$", "setEditFocus(bool)", typeof(void), typeof(bool), mark);
        }
        /// <remarks>
        ///   Overloaded the method in QSpinBox
        ///   to make use of the base given in the constructor.
        ///      </remarks>        <short>     Overloaded the method in QSpinBox   to make use of the base given in the constructor.</short>
        [SmokeMethod("textFromValue(int) const")]
        protected override string TextFromValue(int arg1) {
            return (string) interceptor.Invoke("textFromValue$", "textFromValue(int) const", typeof(string), typeof(int), arg1);
        }
        /// <remarks>
        ///   Overloaded the method in QSpinBox
        ///   to make use of the base given in the constructor.
        ///      </remarks>        <short>     Overloaded the method in QSpinBox   to make use of the base given in the constructor.</short>
        [SmokeMethod("valueFromText(const QString&) const")]
        protected override int ValueFromText(string text) {
            return (int) interceptor.Invoke("valueFromText$", "valueFromText(const QString&) const", typeof(int), typeof(string), text);
        }
        ~KIntSpinBox() {
            interceptor.Invoke("~KIntSpinBox", "~KIntSpinBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KIntSpinBox", "~KIntSpinBox()", typeof(void));
        }
        protected new IKIntSpinBoxSignals Emit {
            get { return (IKIntSpinBoxSignals) Q_EMIT; }
        }
    }

    public interface IKIntSpinBoxSignals : IQSpinBoxSignals {
    }
}