//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQStatusBarSignals"></see> for signals emitted by QStatusBar
	[SmokeClass("QStatusBar")]
	public class QStatusBar : QWidget, IDisposable {
 		protected QStatusBar(Type dummy) : base((Type) null) {}
		interface IQStatusBarProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStatusBar), this);
			_interceptor = (QStatusBar) realProxy.GetTransparentProxy();
		}
		private QStatusBar ProxyQStatusBar() {
			return (QStatusBar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStatusBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStatusBarProxy), null);
			_staticInterceptor = (IQStatusBarProxy) realProxy.GetTransparentProxy();
		}
		private static IQStatusBarProxy StaticQStatusBar() {
			return (IQStatusBarProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQStatusBar().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQStatusBar().ClassName();
		}
		public QStatusBar(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQStatusBar(parent,name);
		}
		[SmokeMethod("QStatusBar(QWidget*, const char*)")]
		private void NewQStatusBar(QWidget parent, string name) {
			ProxyQStatusBar().NewQStatusBar(parent,name);
		}
		public QStatusBar(QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQStatusBar(parent);
		}
		[SmokeMethod("QStatusBar(QWidget*)")]
		private void NewQStatusBar(QWidget parent) {
			ProxyQStatusBar().NewQStatusBar(parent);
		}
		public QStatusBar() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQStatusBar();
		}
		[SmokeMethod("QStatusBar()")]
		private void NewQStatusBar() {
			ProxyQStatusBar().NewQStatusBar();
		}
		[SmokeMethod("addWidget(QWidget*, int, bool)")]
		public virtual void AddWidget(QWidget arg1, int stretch, bool arg3) {
			ProxyQStatusBar().AddWidget(arg1,stretch,arg3);
		}
		[SmokeMethod("addWidget(QWidget*, int)")]
		public virtual void AddWidget(QWidget arg1, int stretch) {
			ProxyQStatusBar().AddWidget(arg1,stretch);
		}
		[SmokeMethod("addWidget(QWidget*)")]
		public virtual void AddWidget(QWidget arg1) {
			ProxyQStatusBar().AddWidget(arg1);
		}
		[SmokeMethod("removeWidget(QWidget*)")]
		public virtual void RemoveWidget(QWidget arg1) {
			ProxyQStatusBar().RemoveWidget(arg1);
		}
		[SmokeMethod("setSizeGripEnabled(bool)")]
		public void SetSizeGripEnabled(bool arg1) {
			ProxyQStatusBar().SetSizeGripEnabled(arg1);
		}
		[SmokeMethod("isSizeGripEnabled() const")]
		public bool IsSizeGripEnabled() {
			return ProxyQStatusBar().IsSizeGripEnabled();
		}
		[Q_SLOT("void message(const QString&)")]
		[SmokeMethod("message(const QString&)")]
		public void Message(string arg1) {
			ProxyQStatusBar().Message(arg1);
		}
		[Q_SLOT("void message(const QString&, int)")]
		[SmokeMethod("message(const QString&, int)")]
		public void Message(string arg1, int arg2) {
			ProxyQStatusBar().Message(arg1,arg2);
		}
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQStatusBar().Clear();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQStatusBar().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQStatusBar().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQStatusBar().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQStatusBar().TrUtf8(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQStatusBar().PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQStatusBar().ResizeEvent(arg1);
		}
		[SmokeMethod("reformat()")]
		protected void Reformat() {
			ProxyQStatusBar().Reformat();
		}
		[SmokeMethod("hideOrShow()")]
		protected void HideOrShow() {
			ProxyQStatusBar().HideOrShow();
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQStatusBar().Event(arg1);
		}
		~QStatusBar() {
			DisposeQStatusBar();
		}
		public new void Dispose() {
			DisposeQStatusBar();
		}
		private void DisposeQStatusBar() {
			ProxyQStatusBar().DisposeQStatusBar();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQStatusBarSignals), this);
			Q_EMIT = (IQStatusBarSignals) realProxy.GetTransparentProxy();
		}
		protected new IQStatusBarSignals Emit() {
			return (IQStatusBarSignals) Q_EMIT;
		}
	}

	public interface IQStatusBarSignals : IQWidgetSignals {
		[Q_SIGNAL("void messageChanged(const QString&)")]
		void MessageChanged(string text);
	}
}
