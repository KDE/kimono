//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Runtime.InteropServices;
	using System.Text;
	/// <remarks> See <see cref="IQSpinBoxSignals"></see> for signals emitted by QSpinBox
	/// </remarks>
	[SmokeClass("QSpinBox")]
	public class QSpinBox : QAbstractSpinBox, IDisposable {
 		protected QSpinBox(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSpinBox), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSpinBox() {
			staticInterceptor = new SmokeInvocation(typeof(QSpinBox), null);
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
		[Q_PROPERTY("QString", "cleanText")]
		public string CleanText {
			get { return (string) interceptor.Invoke("cleanText", "cleanText()", typeof(string)); }
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
		[Q_PROPERTY("int", "singleStep")]
		public int SingleStep {
			get { return (int) interceptor.Invoke("singleStep", "singleStep()", typeof(int)); }
			set { interceptor.Invoke("setSingleStep$", "setSingleStep(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "value")]
		public int Value {
			get { return (int) interceptor.Invoke("value", "value()", typeof(int)); }
			set { interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value); }
		}
		public QSpinBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSpinBox#", "QSpinBox(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QSpinBox() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSpinBox", "QSpinBox()", typeof(void));
		}
		public void SetRange(int min, int max) {
			interceptor.Invoke("setRange$$", "setRange(int, int)", typeof(void), typeof(int), min, typeof(int), max);
		}
		[Q_SLOT("void setValue(int)")]
		public void SetValue(int val) {
			interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), val);
		}
		[SmokeMethod("event(QEvent*)")]
		protected new virtual bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		protected new virtual QValidator.State Validate(StringBuilder input, ref int pos) {
			StackItem[] stack = new StackItem[3];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(input);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(input);
#endif
			stack[2].s_int = pos;
			interceptor.Invoke("validate$$", "validate(QString&, int&) const", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
			pos = stack[2].s_int;
			return (QValidator.State) Enum.ToObject(typeof(QValidator.State), stack[0].s_int);
		}
		[SmokeMethod("valueFromText(const QString&) const")]
		protected virtual int ValueFromText(string text) {
			return (int) interceptor.Invoke("valueFromText$", "valueFromText(const QString&) const", typeof(int), typeof(string), text);
		}
		[SmokeMethod("textFromValue(int) const")]
		protected virtual string TextFromValue(int val) {
			return (string) interceptor.Invoke("textFromValue$", "textFromValue(int) const", typeof(string), typeof(int), val);
		}
		[SmokeMethod("fixup(QString&) const")]
		protected new virtual void Fixup(StringBuilder str) {
			interceptor.Invoke("fixup$", "fixup(QString&) const", typeof(void), typeof(StringBuilder), str);
		}
		~QSpinBox() {
			interceptor.Invoke("~QSpinBox", "~QSpinBox()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QSpinBox", "~QSpinBox()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQSpinBoxSignals Emit {
			get { return (IQSpinBoxSignals) Q_EMIT; }
		}
	}

	public interface IQSpinBoxSignals : IQAbstractSpinBoxSignals {
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int arg1);
		[Q_SIGNAL("void valueChanged(QString)")]
		void ValueChanged(string arg1);
	}
}
