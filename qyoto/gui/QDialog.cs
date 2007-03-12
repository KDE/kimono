//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQDialogSignals"></see> for signals emitted by QDialog
	[SmokeClass("QDialog")]
	public class QDialog : QWidget, IDisposable {
 		protected QDialog(Type dummy) : base((Type) null) {}
		[SmokeClass("QDialog")]
		interface IQDialogProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDialog), this);
			_interceptor = (QDialog) realProxy.GetTransparentProxy();
		}
		private QDialog ProxyQDialog() {
			return (QDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDialogProxy), null);
			_staticInterceptor = (IQDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQDialogProxy StaticQDialog() {
			return (IQDialogProxy) _staticInterceptor;
		}
		public enum DialogCode {
			Rejected = 0,
			Accepted = 1,
		}
		[Q_PROPERTY("bool", "sizeGripEnabled")]
		public bool SizeGripEnabled {
			get { return Property("sizeGripEnabled").Value<bool>(); }
			set { SetProperty("sizeGripEnabled", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("bool", "modal")]
		public bool Modal {
			get { return Property("modal").Value<bool>(); }
			set { SetProperty("modal", QVariant.FromValue<bool>(value)); }
		}
		public QDialog(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQDialog(parent,f);
		}
		[SmokeMethod("QDialog", "(QWidget*, Qt::WindowFlags)", "#$")]
		private void NewQDialog(QWidget parent, int f) {
			ProxyQDialog().NewQDialog(parent,f);
		}
		public QDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDialog(parent);
		}
		[SmokeMethod("QDialog", "(QWidget*)", "#")]
		private void NewQDialog(QWidget parent) {
			ProxyQDialog().NewQDialog(parent);
		}
		public QDialog() : this((Type) null) {
			CreateProxy();
			NewQDialog();
		}
		[SmokeMethod("QDialog", "()", "")]
		private void NewQDialog() {
			ProxyQDialog().NewQDialog();
		}
		[SmokeMethod("result", "() const", "")]
		public int Result() {
			return ProxyQDialog().Result();
		}
		[SmokeMethod("setVisible", "(bool)", "$")]
		public override void SetVisible(bool visible) {
			ProxyQDialog().SetVisible(visible);
		}
		[SmokeMethod("setOrientation", "(Qt::Orientation)", "$")]
		public void SetOrientation(Qt.Orientation orientation) {
			ProxyQDialog().SetOrientation(orientation);
		}
		[SmokeMethod("orientation", "() const", "")]
		public Qt.Orientation Orientation() {
			return ProxyQDialog().Orientation();
		}
		[SmokeMethod("setExtension", "(QWidget*)", "#")]
		public void SetExtension(QWidget extension) {
			ProxyQDialog().SetExtension(extension);
		}
		[SmokeMethod("extension", "() const", "")]
		public QWidget Extension() {
			return ProxyQDialog().Extension();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ProxyQDialog().SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ProxyQDialog().MinimumSizeHint();
		}
		[SmokeMethod("isSizeGripEnabled", "() const", "")]
		public bool IsSizeGripEnabled() {
			return ProxyQDialog().IsSizeGripEnabled();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new virtual bool Event(QEvent arg1) {
			return ProxyQDialog().Event(arg1);
		}
		[SmokeMethod("setResult", "(int)", "$")]
		public void SetResult(int r) {
			ProxyQDialog().SetResult(r);
		}
		[Q_SLOT("int exec()")]
		[SmokeMethod("exec", "()", "")]
		public int Exec() {
			return ProxyQDialog().Exec();
		}
		[Q_SLOT("void done(int)")]
		[SmokeMethod("done", "(int)", "$")]
		public virtual void Done(int arg1) {
			ProxyQDialog().Done(arg1);
		}
		[Q_SLOT("void accept()")]
		[SmokeMethod("accept", "()", "")]
		public virtual void Accept() {
			ProxyQDialog().Accept();
		}
		[Q_SLOT("void reject()")]
		[SmokeMethod("reject", "()", "")]
		public virtual void Reject() {
			ProxyQDialog().Reject();
		}
		[Q_SLOT("void showExtension(bool)")]
		[SmokeMethod("showExtension", "(bool)", "$")]
		public void ShowExtension(bool arg1) {
			ProxyQDialog().ShowExtension(arg1);
		}
		public static string Tr(string s, string c) {
			return StaticQDialog().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQDialog().Tr(s);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			ProxyQDialog().KeyPressEvent(arg1);
		}
		[SmokeMethod("closeEvent", "(QCloseEvent*)", "#")]
		protected override void CloseEvent(QCloseEvent arg1) {
			ProxyQDialog().CloseEvent(arg1);
		}
		[SmokeMethod("showEvent", "(QShowEvent*)", "#")]
		protected override void ShowEvent(QShowEvent arg1) {
			ProxyQDialog().ShowEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			ProxyQDialog().ResizeEvent(arg1);
		}
		[SmokeMethod("contextMenuEvent", "(QContextMenuEvent*)", "#")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQDialog().ContextMenuEvent(arg1);
		}
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQDialog().EventFilter(arg1,arg2);
		}
		[SmokeMethod("adjustPosition", "(QWidget*)", "#")]
		protected void AdjustPosition(QWidget arg1) {
			ProxyQDialog().AdjustPosition(arg1);
		}
		~QDialog() {
			DisposeQDialog();
		}
		public new void Dispose() {
			DisposeQDialog();
		}
		[SmokeMethod("~QDialog", "()", "")]
		private void DisposeQDialog() {
			ProxyQDialog().DisposeQDialog();
		}
		protected new IQDialogSignals Emit {
			get { return (IQDialogSignals) Q_EMIT; }
		}
	}

	public interface IQDialogSignals : IQWidgetSignals {
		[Q_SIGNAL("void finished(int)")]
		void Finished(int result);
		[Q_SIGNAL("void accepted()")]
		void Accepted();
		[Q_SIGNAL("void rejected()")]
		void Rejected();
	}
}
