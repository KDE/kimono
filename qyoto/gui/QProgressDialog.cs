//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQProgressDialogSignals"></see> for signals emitted by QProgressDialog
	[SmokeClass("QProgressDialog")]
	public class QProgressDialog : QDialog, IDisposable {
 		protected QProgressDialog(Type dummy) : base((Type) null) {}
		interface IQProgressDialogProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QProgressDialog), this);
			_interceptor = (QProgressDialog) realProxy.GetTransparentProxy();
		}
		private QProgressDialog ProxyQProgressDialog() {
			return (QProgressDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QProgressDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQProgressDialogProxy), null);
			_staticInterceptor = (IQProgressDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQProgressDialogProxy StaticQProgressDialog() {
			return (IQProgressDialogProxy) _staticInterceptor;
		}

		[Q_PROPERTY("bool", "wasCanceled")]
		public bool WasCanceled {
			get {
				return Property("wasCanceled").Value<bool>();
			}
		}
		[Q_PROPERTY("int", "minimum")]
		public int Minimum {
			get {
				return Property("minimum").Value<int>();
			}
			set {
				SetProperty("minimum", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "maximum")]
		public int Maximum {
			get {
				return Property("maximum").Value<int>();
			}
			set {
				SetProperty("maximum", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "value")]
		public int Value {
			get {
				return Property("value").Value<int>();
			}
			set {
				SetProperty("value", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("bool", "autoReset")]
		public bool AutoReset {
			get {
				return Property("autoReset").Value<bool>();
			}
			set {
				SetProperty("autoReset", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "autoClose")]
		public bool AutoClose {
			get {
				return Property("autoClose").Value<bool>();
			}
			set {
				SetProperty("autoClose", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("int", "minimumDuration")]
		public int MinimumDuration {
			get {
				return Property("minimumDuration").Value<int>();
			}
			set {
				SetProperty("minimumDuration", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("QString", "labelText")]
		public string LabelText {
			get {
				return Property("labelText").Value<string>();
			}
			set {
				SetProperty("labelText", QVariant.FromValue<string>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QProgressDialog(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(parent,f);
		}
		[SmokeMethod("QProgressDialog#$", "(QWidget*, Qt::WindowFlags)")]
		private void NewQProgressDialog(QWidget parent, int f) {
			ProxyQProgressDialog().NewQProgressDialog(parent,f);
		}
		public QProgressDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(parent);
		}
		[SmokeMethod("QProgressDialog#", "(QWidget*)")]
		private void NewQProgressDialog(QWidget parent) {
			ProxyQProgressDialog().NewQProgressDialog(parent);
		}
		public QProgressDialog() : this((Type) null) {
			CreateProxy();
			NewQProgressDialog();
		}
		[SmokeMethod("QProgressDialog", "()")]
		private void NewQProgressDialog() {
			ProxyQProgressDialog().NewQProgressDialog();
		}
		public QProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent,f);
		}
		[SmokeMethod("QProgressDialog$$$$#$", "(const QString&, const QString&, int, int, QWidget*, Qt::WindowFlags)")]
		private void NewQProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent, int f) {
			ProxyQProgressDialog().NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent,f);
		}
		public QProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent);
		}
		[SmokeMethod("QProgressDialog$$$$#", "(const QString&, const QString&, int, int, QWidget*)")]
		private void NewQProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum, QWidget parent) {
			ProxyQProgressDialog().NewQProgressDialog(labelText,cancelButtonText,minimum,maximum,parent);
		}
		public QProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum) : this((Type) null) {
			CreateProxy();
			NewQProgressDialog(labelText,cancelButtonText,minimum,maximum);
		}
		[SmokeMethod("QProgressDialog$$$$", "(const QString&, const QString&, int, int)")]
		private void NewQProgressDialog(string labelText, string cancelButtonText, int minimum, int maximum) {
			ProxyQProgressDialog().NewQProgressDialog(labelText,cancelButtonText,minimum,maximum);
		}
		[SmokeMethod("setLabel#", "(QLabel*)")]
		public void SetLabel(QLabel label) {
			ProxyQProgressDialog().SetLabel(label);
		}
		[SmokeMethod("setCancelButton#", "(QPushButton*)")]
		public void SetCancelButton(QPushButton button) {
			ProxyQProgressDialog().SetCancelButton(button);
		}
		[SmokeMethod("setBar#", "(QProgressBar*)")]
		public void SetBar(QProgressBar bar) {
			ProxyQProgressDialog().SetBar(bar);
		}
		[SmokeMethod("setRange$$", "(int, int)")]
		public void SetRange(int minimum, int maximum) {
			ProxyQProgressDialog().SetRange(minimum,maximum);
		}
		[SmokeMethod("sizeHint", "() const")]
		public new QSize SizeHint() {
			return ProxyQProgressDialog().SizeHint();
		}
		[Q_SLOT("void cancel()")]
		[SmokeMethod("cancel", "()")]
		public void Cancel() {
			ProxyQProgressDialog().Cancel();
		}
		[Q_SLOT("void reset()")]
		[SmokeMethod("reset", "()")]
		public void Reset() {
			ProxyQProgressDialog().Reset();
		}
		[Q_SLOT("void setCancelButtonText(const QString&)")]
		[SmokeMethod("setCancelButtonText$", "(const QString&)")]
		public void SetCancelButtonText(string arg1) {
			ProxyQProgressDialog().SetCancelButtonText(arg1);
		}
		public static new string Tr(string s, string c) {
			return StaticQProgressDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQProgressDialog().Tr(s);
		}
		[SmokeMethod("resizeEvent#", "(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQProgressDialog().ResizeEvent(arg1);
		}
		[SmokeMethod("closeEvent#", "(QCloseEvent*)")]
		protected new void CloseEvent(QCloseEvent arg1) {
			ProxyQProgressDialog().CloseEvent(arg1);
		}
		[SmokeMethod("changeEvent#", "(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQProgressDialog().ChangeEvent(arg1);
		}
		[SmokeMethod("showEvent#", "(QShowEvent*)")]
		public new void ShowEvent(QShowEvent e) {
			ProxyQProgressDialog().ShowEvent(e);
		}
		[Q_SLOT("void forceShow()")]
		[SmokeMethod("forceShow", "()")]
		protected void ForceShow() {
			ProxyQProgressDialog().ForceShow();
		}
		~QProgressDialog() {
			DisposeQProgressDialog();
		}
		public new void Dispose() {
			DisposeQProgressDialog();
		}
		[SmokeMethod("~QProgressDialog", "()")]
		private void DisposeQProgressDialog() {
			ProxyQProgressDialog().DisposeQProgressDialog();
		}
		protected new IQProgressDialogSignals Emit {
			get {
				return (IQProgressDialogSignals) Q_EMIT;
			}
		}
	}

	public interface IQProgressDialogSignals : IQDialogSignals {
		[Q_SIGNAL("void canceled()")]
		void Canceled();
	}
}
