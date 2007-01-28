//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QTimeEdit")]
	public class QTimeEdit : QDateTimeEdit, IDisposable {
 		protected QTimeEdit(Type dummy) : base((Type) null) {}
		interface IQTimeEditProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTimeEdit), this);
			_interceptor = (QTimeEdit) realProxy.GetTransparentProxy();
		}
		private QTimeEdit ProxyQTimeEdit() {
			return (QTimeEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTimeEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTimeEditProxy), null);
			_staticInterceptor = (IQTimeEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQTimeEditProxy StaticQTimeEdit() {
			return (IQTimeEditProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTimeEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTimeEdit(parent);
		}
		[SmokeMethod("QTimeEdit(QWidget*)")]
		private void NewQTimeEdit(QWidget parent) {
			ProxyQTimeEdit().NewQTimeEdit(parent);
		}
		public QTimeEdit() : this((Type) null) {
			CreateProxy();
			NewQTimeEdit();
		}
		[SmokeMethod("QTimeEdit()")]
		private void NewQTimeEdit() {
			ProxyQTimeEdit().NewQTimeEdit();
		}
		public QTimeEdit(QTime time, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTimeEdit(time,parent);
		}
		[SmokeMethod("QTimeEdit(const QTime&, QWidget*)")]
		private void NewQTimeEdit(QTime time, QWidget parent) {
			ProxyQTimeEdit().NewQTimeEdit(time,parent);
		}
		public QTimeEdit(QTime time) : this((Type) null) {
			CreateProxy();
			NewQTimeEdit(time);
		}
		[SmokeMethod("QTimeEdit(const QTime&)")]
		private void NewQTimeEdit(QTime time) {
			ProxyQTimeEdit().NewQTimeEdit(time);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTimeEdit().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTimeEdit().Tr(s);
		}
		~QTimeEdit() {
			DisposeQTimeEdit();
		}
		public new void Dispose() {
			DisposeQTimeEdit();
		}
		[SmokeMethod("~QTimeEdit()")]
		private void DisposeQTimeEdit() {
			ProxyQTimeEdit().DisposeQTimeEdit();
		}
		protected new IQTimeEditSignals Emit {
			get {
				return (IQTimeEditSignals) Q_EMIT;
			}
		}
	}

	public interface IQTimeEditSignals : IQDateTimeEditSignals {
	}
}