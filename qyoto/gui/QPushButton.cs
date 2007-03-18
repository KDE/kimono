//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QPushButton")]
	public class QPushButton : QAbstractButton, IDisposable {
 		protected QPushButton(Type dummy) : base((Type) null) {}
		[SmokeClass("QPushButton")]
		interface IQPushButtonProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPushButton), this);
			interceptor = (QPushButton) realProxy.GetTransparentProxy();
		}
		private static IQPushButtonProxy staticInterceptor = null;
		static QPushButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPushButtonProxy), null);
			staticInterceptor = (IQPushButtonProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("bool", "autoDefault")]
		public bool AutoDefault {
			[SmokeMethod("autoDefault", "()", "")]
			get { return ((QPushButton) interceptor).AutoDefault; }
			[SmokeMethod("setAutoDefault", "(bool)", "$")]
			set { ((QPushButton) interceptor).AutoDefault = value; }
		}
		[Q_PROPERTY("bool", "default")]
		public bool Default {
			[SmokeMethod("isDefault", "()", "")]
			get { return ((QPushButton) interceptor).Default; }
			[SmokeMethod("setDefault", "(bool)", "$")]
			set { ((QPushButton) interceptor).Default = value; }
		}
		[Q_PROPERTY("bool", "flat")]
		public bool Flat {
			[SmokeMethod("isFlat", "()", "")]
			get { return ((QPushButton) interceptor).Flat; }
			[SmokeMethod("setFlat", "(bool)", "$")]
			set { ((QPushButton) interceptor).Flat = value; }
		}
		public QPushButton(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPushButton(parent);
		}
		[SmokeMethod("QPushButton", "(QWidget*)", "#")]
		private void NewQPushButton(QWidget parent) {
			((QPushButton) interceptor).NewQPushButton(parent);
		}
		public QPushButton() : this((Type) null) {
			CreateProxy();
			NewQPushButton();
		}
		[SmokeMethod("QPushButton", "()", "")]
		private void NewQPushButton() {
			((QPushButton) interceptor).NewQPushButton();
		}
		public QPushButton(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPushButton(text,parent);
		}
		[SmokeMethod("QPushButton", "(const QString&, QWidget*)", "$#")]
		private void NewQPushButton(string text, QWidget parent) {
			((QPushButton) interceptor).NewQPushButton(text,parent);
		}
		public QPushButton(string text) : this((Type) null) {
			CreateProxy();
			NewQPushButton(text);
		}
		[SmokeMethod("QPushButton", "(const QString&)", "$")]
		private void NewQPushButton(string text) {
			((QPushButton) interceptor).NewQPushButton(text);
		}
		public QPushButton(QIcon icon, string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPushButton(icon,text,parent);
		}
		[SmokeMethod("QPushButton", "(const QIcon&, const QString&, QWidget*)", "#$#")]
		private void NewQPushButton(QIcon icon, string text, QWidget parent) {
			((QPushButton) interceptor).NewQPushButton(icon,text,parent);
		}
		public QPushButton(QIcon icon, string text) : this((Type) null) {
			CreateProxy();
			NewQPushButton(icon,text);
		}
		[SmokeMethod("QPushButton", "(const QIcon&, const QString&)", "#$")]
		private void NewQPushButton(QIcon icon, string text) {
			((QPushButton) interceptor).NewQPushButton(icon,text);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QPushButton) interceptor).SizeHint();
		}
		[SmokeMethod("isDefault", "() const", "")]
		public bool IsDefault() {
			return ((QPushButton) interceptor).IsDefault();
		}
		[SmokeMethod("setMenu", "(QMenu*)", "#")]
		public void SetMenu(QMenu menu) {
			((QPushButton) interceptor).SetMenu(menu);
		}
		[SmokeMethod("menu", "() const", "")]
		public QMenu Menu() {
			return ((QPushButton) interceptor).Menu();
		}
		[SmokeMethod("isFlat", "() const", "")]
		public bool IsFlat() {
			return ((QPushButton) interceptor).IsFlat();
		}
		[Q_SLOT("void showMenu()")]
		[SmokeMethod("showMenu", "()", "")]
		public void ShowMenu() {
			((QPushButton) interceptor).ShowMenu();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QPushButton) interceptor).Event(e);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			((QPushButton) interceptor).PaintEvent(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			((QPushButton) interceptor).KeyPressEvent(arg1);
		}
		[SmokeMethod("focusInEvent", "(QFocusEvent*)", "#")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			((QPushButton) interceptor).FocusInEvent(arg1);
		}
		[SmokeMethod("focusOutEvent", "(QFocusEvent*)", "#")]
		protected override void FocusOutEvent(QFocusEvent arg1) {
			((QPushButton) interceptor).FocusOutEvent(arg1);
		}
		~QPushButton() {
			DisposeQPushButton();
		}
		public new void Dispose() {
			DisposeQPushButton();
		}
		[SmokeMethod("~QPushButton", "()", "")]
		private void DisposeQPushButton() {
			((QPushButton) interceptor).DisposeQPushButton();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQPushButtonSignals Emit {
			get { return (IQPushButtonSignals) Q_EMIT; }
		}
	}

	public interface IQPushButtonSignals : IQAbstractButtonSignals {
	}
}
