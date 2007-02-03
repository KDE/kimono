//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQDoubleSpinBoxSignals"></see> for signals emitted by QDoubleSpinBox
	[SmokeClass("QDoubleSpinBox")]
	public class QDoubleSpinBox : QAbstractSpinBox, IDisposable {
 		protected QDoubleSpinBox(Type dummy) : base((Type) null) {}
		interface IQDoubleSpinBoxProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDoubleSpinBox), this);
			_interceptor = (QDoubleSpinBox) realProxy.GetTransparentProxy();
		}
		private QDoubleSpinBox ProxyQDoubleSpinBox() {
			return (QDoubleSpinBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDoubleSpinBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDoubleSpinBoxProxy), null);
			_staticInterceptor = (IQDoubleSpinBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQDoubleSpinBoxProxy StaticQDoubleSpinBox() {
			return (IQDoubleSpinBoxProxy) _staticInterceptor;
		}

		[Q_PROPERTY("QString", "prefix")]
		public string Prefix {
			get {
				return Property("prefix").Value<string>();
			}
			set {
				SetProperty("prefix", QVariant.FromValue<string>(value));
			}
		}
		[Q_PROPERTY("QString", "suffix")]
		public string Suffix {
			get {
				return Property("suffix").Value<string>();
			}
			set {
				SetProperty("suffix", QVariant.FromValue<string>(value));
			}
		}
		[Q_PROPERTY("QString", "cleanText")]
		public string CleanText {
			get {
				return Property("cleanText").Value<string>();
			}
		}
		[Q_PROPERTY("int", "decimals")]
		public int Decimals {
			get {
				return Property("decimals").Value<int>();
			}
			set {
				SetProperty("decimals", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("double", "maximum")]
		public double Maximum {
			get {
				return Property("maximum").Value<double>();
			}
			set {
				SetProperty("maximum", QVariant.FromValue<double>(value));
			}
		}
		[Q_PROPERTY("double", "minimum")]
		public double Minimum {
			get {
				return Property("minimum").Value<double>();
			}
			set {
				SetProperty("minimum", QVariant.FromValue<double>(value));
			}
		}
		[Q_PROPERTY("double", "singleStep")]
		public double SingleStep {
			get {
				return Property("singleStep").Value<double>();
			}
			set {
				SetProperty("singleStep", QVariant.FromValue<double>(value));
			}
		}
		[Q_PROPERTY("double", "value")]
		public double Value {
			get {
				return Property("value").Value<double>();
			}
			set {
				SetProperty("value", QVariant.FromValue<double>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDoubleSpinBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDoubleSpinBox(parent);
		}
		[SmokeMethod("QDoubleSpinBox#", "(QWidget*)")]
		private void NewQDoubleSpinBox(QWidget parent) {
			ProxyQDoubleSpinBox().NewQDoubleSpinBox(parent);
		}
		public QDoubleSpinBox() : this((Type) null) {
			CreateProxy();
			NewQDoubleSpinBox();
		}
		[SmokeMethod("QDoubleSpinBox", "()")]
		private void NewQDoubleSpinBox() {
			ProxyQDoubleSpinBox().NewQDoubleSpinBox();
		}
		[SmokeMethod("setRange$$", "(double, double)")]
		public void SetRange(double min, double max) {
			ProxyQDoubleSpinBox().SetRange(min,max);
		}
		[SmokeMethod("validate$$", "(QString&, int&) const")]
		public new virtual int Validate(StringBuilder input, out int pos) {
			return ProxyQDoubleSpinBox().Validate(input,out pos);
		}
		[SmokeMethod("valueFromText$", "(const QString&) const")]
		public virtual double ValueFromText(string text) {
			return ProxyQDoubleSpinBox().ValueFromText(text);
		}
		[SmokeMethod("textFromValue$", "(double) const")]
		public virtual string TextFromValue(double val) {
			return ProxyQDoubleSpinBox().TextFromValue(val);
		}
		[SmokeMethod("fixup$", "(QString&) const")]
		public new virtual void Fixup(StringBuilder str) {
			ProxyQDoubleSpinBox().Fixup(str);
		}
		public static new string Tr(string s, string c) {
			return StaticQDoubleSpinBox().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQDoubleSpinBox().Tr(s);
		}
		~QDoubleSpinBox() {
			DisposeQDoubleSpinBox();
		}
		public new void Dispose() {
			DisposeQDoubleSpinBox();
		}
		[SmokeMethod("~QDoubleSpinBox", "()")]
		private void DisposeQDoubleSpinBox() {
			ProxyQDoubleSpinBox().DisposeQDoubleSpinBox();
		}
		protected new IQDoubleSpinBoxSignals Emit {
			get {
				return (IQDoubleSpinBoxSignals) Q_EMIT;
			}
		}
	}

	public interface IQDoubleSpinBoxSignals : IQAbstractSpinBoxSignals {
		[Q_SIGNAL("void valueChanged(double)")]
		void ValueChanged(double arg1);
		[Q_SIGNAL("void valueChanged(const QString&)")]
		void ValueChanged(string arg1);
	}
}
