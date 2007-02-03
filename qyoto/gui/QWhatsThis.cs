//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QWhatsThis")]
	public class QWhatsThis : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QWhatsThis(Type dummy) {}
		interface IQWhatsThisProxy {
			[SmokeMethod("enterWhatsThisMode", "()")]
			void EnterWhatsThisMode();
			[SmokeMethod("inWhatsThisMode", "()")]
			bool InWhatsThisMode();
			[SmokeMethod("leaveWhatsThisMode", "()")]
			void LeaveWhatsThisMode();
			[SmokeMethod("showText#$#", "(const QPoint&, const QString&, QWidget*)")]
			void ShowText(QPoint pos, string text, QWidget w);
			[SmokeMethod("showText#$", "(const QPoint&, const QString&)")]
			void ShowText(QPoint pos, string text);
			[SmokeMethod("hideText", "()")]
			void HideText();
			[SmokeMethod("createAction#", "(QObject*)")]
			QAction CreateAction(QObject parent);
			[SmokeMethod("createAction", "()")]
			QAction CreateAction();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QWhatsThis), this);
			_interceptor = (QWhatsThis) realProxy.GetTransparentProxy();
		}
		private QWhatsThis ProxyQWhatsThis() {
			return (QWhatsThis) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QWhatsThis() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQWhatsThisProxy), null);
			_staticInterceptor = (IQWhatsThisProxy) realProxy.GetTransparentProxy();
		}
		private static IQWhatsThisProxy StaticQWhatsThis() {
			return (IQWhatsThisProxy) _staticInterceptor;
		}

		public static void EnterWhatsThisMode() {
			StaticQWhatsThis().EnterWhatsThisMode();
		}
		public static bool InWhatsThisMode() {
			return StaticQWhatsThis().InWhatsThisMode();
		}
		public static void LeaveWhatsThisMode() {
			StaticQWhatsThis().LeaveWhatsThisMode();
		}
		public static void ShowText(QPoint pos, string text, QWidget w) {
			StaticQWhatsThis().ShowText(pos,text,w);
		}
		public static void ShowText(QPoint pos, string text) {
			StaticQWhatsThis().ShowText(pos,text);
		}
		public static void HideText() {
			StaticQWhatsThis().HideText();
		}
		public static QAction CreateAction(QObject parent) {
			return StaticQWhatsThis().CreateAction(parent);
		}
		public static QAction CreateAction() {
			return StaticQWhatsThis().CreateAction();
		}
		~QWhatsThis() {
			DisposeQWhatsThis();
		}
		public void Dispose() {
			DisposeQWhatsThis();
		}
		[SmokeMethod("~QWhatsThis", "()")]
		private void DisposeQWhatsThis() {
			ProxyQWhatsThis().DisposeQWhatsThis();
		}
	}
}
