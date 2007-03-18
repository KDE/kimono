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
			interceptor = (QCheckBox) realProxy.GetTransparentProxy();
		}
		private static IQCheckBoxProxy staticInterceptor = null;
		static QCheckBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCheckBoxProxy), null);
			staticInterceptor = (IQCheckBoxProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("bool", "tristate")]
		public bool Tristate {
			[SmokeMethod("isTristate", "()", "")]
			get { return ((QCheckBox) interceptor).Tristate; }
			[SmokeMethod("setTristate", "(bool)", "$")]
			set { ((QCheckBox) interceptor).Tristate = value; }
		}
		public QCheckBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQCheckBox(parent);
		}
		[SmokeMethod("QCheckBox", "(QWidget*)", "#")]
		private void NewQCheckBox(QWidget parent) {
			((QCheckBox) interceptor).NewQCheckBox(parent);
		}
		public QCheckBox() : this((Type) null) {
			CreateProxy();
			NewQCheckBox();
		}
		[SmokeMethod("QCheckBox", "()", "")]
		private void NewQCheckBox() {
			((QCheckBox) interceptor).NewQCheckBox();
		}
		public QCheckBox(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQCheckBox(text,parent);
		}
		[SmokeMethod("QCheckBox", "(const QString&, QWidget*)", "$#")]
		private void NewQCheckBox(string text, QWidget parent) {
			((QCheckBox) interceptor).NewQCheckBox(text,parent);
		}
		public QCheckBox(string text) : this((Type) null) {
			CreateProxy();
			NewQCheckBox(text);
		}
		[SmokeMethod("QCheckBox", "(const QString&)", "$")]
		private void NewQCheckBox(string text) {
			((QCheckBox) interceptor).NewQCheckBox(text);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QCheckBox) interceptor).SizeHint();
		}
		[SmokeMethod("isTristate", "() const", "")]
		public bool IsTristate() {
			return ((QCheckBox) interceptor).IsTristate();
		}
		[SmokeMethod("checkState", "() const", "")]
		public Qt.CheckState CheckState() {
			return ((QCheckBox) interceptor).CheckState();
		}
		[SmokeMethod("setCheckState", "(Qt::CheckState)", "$")]
		public void SetCheckState(Qt.CheckState state) {
			((QCheckBox) interceptor).SetCheckState(state);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QCheckBox) interceptor).Event(e);
		}
		[SmokeMethod("hitButton", "(const QPoint&) const", "#")]
		protected override bool HitButton(QPoint pos) {
			return ((QCheckBox) interceptor).HitButton(pos);
		}
		[SmokeMethod("checkStateSet", "()", "")]
		protected override void CheckStateSet() {
			((QCheckBox) interceptor).CheckStateSet();
		}
		[SmokeMethod("nextCheckState", "()", "")]
		protected override void NextCheckState() {
			((QCheckBox) interceptor).NextCheckState();
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			((QCheckBox) interceptor).PaintEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			((QCheckBox) interceptor).MouseMoveEvent(arg1);
		}
		~QCheckBox() {
			DisposeQCheckBox();
		}
		public new void Dispose() {
			DisposeQCheckBox();
		}
		[SmokeMethod("~QCheckBox", "()", "")]
		private void DisposeQCheckBox() {
			((QCheckBox) interceptor).DisposeQCheckBox();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
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
