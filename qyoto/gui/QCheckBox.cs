//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQCheckBoxSignals"></see> for signals emitted by QCheckBox
	[SmokeClass("QCheckBox")]
	public class QCheckBox : QAbstractButton, IDisposable {
 		protected QCheckBox(Type dummy) : base((Type) null) {}
		[SmokeClass("QCheckBox")]
		interface IQCheckBoxProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCheckBox), this);
			_interceptor = (QCheckBox) realProxy.GetTransparentProxy();
		}
		private QCheckBox ProxyQCheckBox() {
			return (QCheckBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCheckBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCheckBoxProxy), null);
			_staticInterceptor = (IQCheckBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQCheckBoxProxy StaticQCheckBox() {
			return (IQCheckBoxProxy) _staticInterceptor;
		}
		[Q_PROPERTY("bool", "tristate")]
		public bool Tristate {
			get { return Property("tristate").Value<bool>(); }
			set { SetProperty("tristate", QVariant.FromValue<bool>(value)); }
		}
		public QCheckBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQCheckBox(parent);
		}
		[SmokeMethod("QCheckBox", "(QWidget*)", "#")]
		private void NewQCheckBox(QWidget parent) {
			ProxyQCheckBox().NewQCheckBox(parent);
		}
		public QCheckBox() : this((Type) null) {
			CreateProxy();
			NewQCheckBox();
		}
		[SmokeMethod("QCheckBox", "()", "")]
		private void NewQCheckBox() {
			ProxyQCheckBox().NewQCheckBox();
		}
		public QCheckBox(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQCheckBox(text,parent);
		}
		[SmokeMethod("QCheckBox", "(const QString&, QWidget*)", "$#")]
		private void NewQCheckBox(string text, QWidget parent) {
			ProxyQCheckBox().NewQCheckBox(text,parent);
		}
		public QCheckBox(string text) : this((Type) null) {
			CreateProxy();
			NewQCheckBox(text);
		}
		[SmokeMethod("QCheckBox", "(const QString&)", "$")]
		private void NewQCheckBox(string text) {
			ProxyQCheckBox().NewQCheckBox(text);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ProxyQCheckBox().SizeHint();
		}
		[SmokeMethod("isTristate", "() const", "")]
		public bool IsTristate() {
			return ProxyQCheckBox().IsTristate();
		}
		[SmokeMethod("checkState", "() const", "")]
		public Qt.CheckState CheckState() {
			return ProxyQCheckBox().CheckState();
		}
		[SmokeMethod("setCheckState", "(Qt::CheckState)", "$")]
		public void SetCheckState(Qt.CheckState state) {
			ProxyQCheckBox().SetCheckState(state);
		}
		public static string Tr(string s, string c) {
			return StaticQCheckBox().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQCheckBox().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ProxyQCheckBox().Event(e);
		}
		[SmokeMethod("hitButton", "(const QPoint&) const", "#")]
		protected override bool HitButton(QPoint pos) {
			return ProxyQCheckBox().HitButton(pos);
		}
		[SmokeMethod("checkStateSet", "()", "")]
		protected override void CheckStateSet() {
			ProxyQCheckBox().CheckStateSet();
		}
		[SmokeMethod("nextCheckState", "()", "")]
		protected override void NextCheckState() {
			ProxyQCheckBox().NextCheckState();
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			ProxyQCheckBox().PaintEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQCheckBox().MouseMoveEvent(arg1);
		}
		~QCheckBox() {
			DisposeQCheckBox();
		}
		public new void Dispose() {
			DisposeQCheckBox();
		}
		[SmokeMethod("~QCheckBox", "()", "")]
		private void DisposeQCheckBox() {
			ProxyQCheckBox().DisposeQCheckBox();
		}
		protected new IQCheckBoxSignals Emit {
			get { return (IQCheckBoxSignals) Q_EMIT; }
		}
	}

	public interface IQCheckBoxSignals : IQAbstractButtonSignals {
		[Q_SIGNAL("void stateChanged(int)")]
		void StateChanged(int arg1);
	}
}
