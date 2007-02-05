//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFocusFrame")]
	public class QFocusFrame : QWidget, IDisposable {
 		protected QFocusFrame(Type dummy) : base((Type) null) {}
		[SmokeClass("QFocusFrame")]
		interface IQFocusFrameProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFocusFrame), this);
			_interceptor = (QFocusFrame) realProxy.GetTransparentProxy();
		}
		private QFocusFrame ProxyQFocusFrame() {
			return (QFocusFrame) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFocusFrame() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFocusFrameProxy), null);
			_staticInterceptor = (IQFocusFrameProxy) realProxy.GetTransparentProxy();
		}
		private static IQFocusFrameProxy StaticQFocusFrame() {
			return (IQFocusFrameProxy) _staticInterceptor;
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QFocusFrame(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQFocusFrame(parent);
		}
		[SmokeMethod("QFocusFrame", "(QWidget*)", "#")]
		private void NewQFocusFrame(QWidget parent) {
			ProxyQFocusFrame().NewQFocusFrame(parent);
		}
		public QFocusFrame() : this((Type) null) {
			CreateProxy();
			NewQFocusFrame();
		}
		[SmokeMethod("QFocusFrame", "()", "")]
		private void NewQFocusFrame() {
			ProxyQFocusFrame().NewQFocusFrame();
		}
		[SmokeMethod("setWidget", "(QWidget*)", "#")]
		public void SetWidget(QWidget widget) {
			ProxyQFocusFrame().SetWidget(widget);
		}
		[SmokeMethod("widget", "() const", "")]
		public QWidget Widget() {
			return ProxyQFocusFrame().Widget();
		}
		public static new string Tr(string s, string c) {
			return StaticQFocusFrame().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQFocusFrame().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQFocusFrame().Event(e);
		}
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQFocusFrame().EventFilter(arg1,arg2);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQFocusFrame().PaintEvent(arg1);
		}
		~QFocusFrame() {
			DisposeQFocusFrame();
		}
		public new void Dispose() {
			DisposeQFocusFrame();
		}
		[SmokeMethod("~QFocusFrame", "()", "")]
		private void DisposeQFocusFrame() {
			ProxyQFocusFrame().DisposeQFocusFrame();
		}
		protected new IQFocusFrameSignals Emit {
			get {
				return (IQFocusFrameSignals) Q_EMIT;
			}
		}
	}

	public interface IQFocusFrameSignals : IQWidgetSignals {
	}
}
