//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
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
			_interceptor = (QPushButton) realProxy.GetTransparentProxy();
		}
		private QPushButton ProxyQPushButton() {
			return (QPushButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPushButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPushButtonProxy), null);
			_staticInterceptor = (IQPushButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQPushButtonProxy StaticQPushButton() {
			return (IQPushButtonProxy) _staticInterceptor;
		}
		[Q_PROPERTY("bool", "autoDefault")]
		public bool AutoDefault {
			get {
				return Property("autoDefault").Value<bool>();
			}
			set {
				SetProperty("autoDefault", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "default")]
		public bool Default {
			get {
				return Property("default").Value<bool>();
			}
			set {
				SetProperty("default", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "flat")]
		public bool Flat {
			get {
				return Property("flat").Value<bool>();
			}
			set {
				SetProperty("flat", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QPushButton(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPushButton(parent);
		}
		[SmokeMethod("QPushButton", "(QWidget*)", "#")]
		private void NewQPushButton(QWidget parent) {
			ProxyQPushButton().NewQPushButton(parent);
		}
		public QPushButton() : this((Type) null) {
			CreateProxy();
			NewQPushButton();
		}
		[SmokeMethod("QPushButton", "()", "")]
		private void NewQPushButton() {
			ProxyQPushButton().NewQPushButton();
		}
		public QPushButton(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPushButton(text,parent);
		}
		[SmokeMethod("QPushButton", "(const QString&, QWidget*)", "$#")]
		private void NewQPushButton(string text, QWidget parent) {
			ProxyQPushButton().NewQPushButton(text,parent);
		}
		public QPushButton(string text) : this((Type) null) {
			CreateProxy();
			NewQPushButton(text);
		}
		[SmokeMethod("QPushButton", "(const QString&)", "$")]
		private void NewQPushButton(string text) {
			ProxyQPushButton().NewQPushButton(text);
		}
		public QPushButton(QIcon icon, string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPushButton(icon,text,parent);
		}
		[SmokeMethod("QPushButton", "(const QIcon&, const QString&, QWidget*)", "#$#")]
		private void NewQPushButton(QIcon icon, string text, QWidget parent) {
			ProxyQPushButton().NewQPushButton(icon,text,parent);
		}
		public QPushButton(QIcon icon, string text) : this((Type) null) {
			CreateProxy();
			NewQPushButton(icon,text);
		}
		[SmokeMethod("QPushButton", "(const QIcon&, const QString&)", "#$")]
		private void NewQPushButton(QIcon icon, string text) {
			ProxyQPushButton().NewQPushButton(icon,text);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public new QSize SizeHint() {
			return ProxyQPushButton().SizeHint();
		}
		[SmokeMethod("isDefault", "() const", "")]
		public bool IsDefault() {
			return ProxyQPushButton().IsDefault();
		}
		[SmokeMethod("setMenu", "(QMenu*)", "#")]
		public void SetMenu(QMenu menu) {
			ProxyQPushButton().SetMenu(menu);
		}
		[SmokeMethod("menu", "() const", "")]
		public QMenu Menu() {
			return ProxyQPushButton().Menu();
		}
		[SmokeMethod("isFlat", "() const", "")]
		public bool IsFlat() {
			return ProxyQPushButton().IsFlat();
		}
		[Q_SLOT("void showMenu()")]
		[SmokeMethod("showMenu", "()", "")]
		public void ShowMenu() {
			ProxyQPushButton().ShowMenu();
		}
		public static new string Tr(string s, string c) {
			return StaticQPushButton().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQPushButton().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQPushButton().Event(e);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQPushButton().PaintEvent(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQPushButton().KeyPressEvent(arg1);
		}
		[SmokeMethod("focusInEvent", "(QFocusEvent*)", "#")]
		protected new void FocusInEvent(QFocusEvent arg1) {
			ProxyQPushButton().FocusInEvent(arg1);
		}
		[SmokeMethod("focusOutEvent", "(QFocusEvent*)", "#")]
		protected new void FocusOutEvent(QFocusEvent arg1) {
			ProxyQPushButton().FocusOutEvent(arg1);
		}
		~QPushButton() {
			DisposeQPushButton();
		}
		public new void Dispose() {
			DisposeQPushButton();
		}
		[SmokeMethod("~QPushButton", "()", "")]
		private void DisposeQPushButton() {
			ProxyQPushButton().DisposeQPushButton();
		}
		protected new IQPushButtonSignals Emit {
			get {
				return (IQPushButtonSignals) Q_EMIT;
			}
		}
	}

	public interface IQPushButtonSignals : IQAbstractButtonSignals {
	}
}
