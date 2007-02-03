//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QInputDialog")]
	public class QInputDialog : QDialog {
 		protected QInputDialog(Type dummy) : base((Type) null) {}
		interface IQInputDialogProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
			[SmokeMethod("getText#$$$$$$", "(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&, bool*, Qt::WindowFlags)")]
			string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, out bool ok, int f);
			[SmokeMethod("getText#$$$$$", "(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&, bool*)")]
			string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, out bool ok);
			[SmokeMethod("getText#$$$$", "(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&)")]
			string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text);
			[SmokeMethod("getText#$$$", "(QWidget*, const QString&, const QString&, QLineEdit::EchoMode)")]
			string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo);
			[SmokeMethod("getText#$$", "(QWidget*, const QString&, const QString&)")]
			string GetText(QWidget parent, string title, string label);
			[SmokeMethod("getInteger#$$$$$$$$", "(QWidget*, const QString&, const QString&, int, int, int, int, bool*, Qt::WindowFlags)")]
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok, int f);
			[SmokeMethod("getInteger#$$$$$$$", "(QWidget*, const QString&, const QString&, int, int, int, int, bool*)")]
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok);
			[SmokeMethod("getInteger#$$$$$$", "(QWidget*, const QString&, const QString&, int, int, int, int)")]
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step);
			[SmokeMethod("getInteger#$$$$$", "(QWidget*, const QString&, const QString&, int, int, int)")]
			int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue);
			[SmokeMethod("getInteger#$$$$", "(QWidget*, const QString&, const QString&, int, int)")]
			int GetInteger(QWidget parent, string title, string label, int value, int minValue);
			[SmokeMethod("getInteger#$$$", "(QWidget*, const QString&, const QString&, int)")]
			int GetInteger(QWidget parent, string title, string label, int value);
			[SmokeMethod("getInteger#$$", "(QWidget*, const QString&, const QString&)")]
			int GetInteger(QWidget parent, string title, string label);
			[SmokeMethod("getDouble#$$$$$$$$", "(QWidget*, const QString&, const QString&, double, double, double, int, bool*, Qt::WindowFlags)")]
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok, int f);
			[SmokeMethod("getDouble#$$$$$$$", "(QWidget*, const QString&, const QString&, double, double, double, int, bool*)")]
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok);
			[SmokeMethod("getDouble#$$$$$$", "(QWidget*, const QString&, const QString&, double, double, double, int)")]
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals);
			[SmokeMethod("getDouble#$$$$$", "(QWidget*, const QString&, const QString&, double, double, double)")]
			double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue);
			[SmokeMethod("getDouble#$$$$", "(QWidget*, const QString&, const QString&, double, double)")]
			double GetDouble(QWidget parent, string title, string label, double value, double minValue);
			[SmokeMethod("getDouble#$$$", "(QWidget*, const QString&, const QString&, double)")]
			double GetDouble(QWidget parent, string title, string label, double value);
			[SmokeMethod("getDouble#$$", "(QWidget*, const QString&, const QString&)")]
			double GetDouble(QWidget parent, string title, string label);
			[SmokeMethod("getItem#$$?$$$$", "(QWidget*, const QString&, const QString&, const QStringList&, int, bool, bool*, Qt::WindowFlags)")]
			string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, out bool ok, int f);
			[SmokeMethod("getItem#$$?$$$", "(QWidget*, const QString&, const QString&, const QStringList&, int, bool, bool*)")]
			string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, out bool ok);
			[SmokeMethod("getItem#$$?$$", "(QWidget*, const QString&, const QString&, const QStringList&, int, bool)")]
			string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable);
			[SmokeMethod("getItem#$$?$", "(QWidget*, const QString&, const QString&, const QStringList&, int)")]
			string GetItem(QWidget parent, string title, string label, List<string> list, int current);
			[SmokeMethod("getItem#$$?", "(QWidget*, const QString&, const QString&, const QStringList&)")]
			string GetItem(QWidget parent, string title, string label, List<string> list);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QInputDialog), this);
			_interceptor = (QInputDialog) realProxy.GetTransparentProxy();
		}
		private QInputDialog ProxyQInputDialog() {
			return (QInputDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QInputDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQInputDialogProxy), null);
			_staticInterceptor = (IQInputDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQInputDialogProxy StaticQInputDialog() {
			return (IQInputDialogProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public static new string Tr(string s, string c) {
			return StaticQInputDialog().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQInputDialog().Tr(s);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, out bool ok, int f) {
			return StaticQInputDialog().GetText(parent,title,label,echo,text,out ok,f);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, out bool ok) {
			return StaticQInputDialog().GetText(parent,title,label,echo,text,out ok);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text) {
			return StaticQInputDialog().GetText(parent,title,label,echo,text);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo) {
			return StaticQInputDialog().GetText(parent,title,label,echo);
		}
		public static string GetText(QWidget parent, string title, string label) {
			return StaticQInputDialog().GetText(parent,title,label);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok, int f) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue,step,out ok,f);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, out bool ok) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue,step,out ok);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue,step);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue,maxValue);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue) {
			return StaticQInputDialog().GetInteger(parent,title,label,value,minValue);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value) {
			return StaticQInputDialog().GetInteger(parent,title,label,value);
		}
		public static int GetInteger(QWidget parent, string title, string label) {
			return StaticQInputDialog().GetInteger(parent,title,label);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok, int f) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue,decimals,out ok,f);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, out bool ok) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue,decimals,out ok);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue,decimals);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue,maxValue);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue) {
			return StaticQInputDialog().GetDouble(parent,title,label,value,minValue);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value) {
			return StaticQInputDialog().GetDouble(parent,title,label,value);
		}
		public static double GetDouble(QWidget parent, string title, string label) {
			return StaticQInputDialog().GetDouble(parent,title,label);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, out bool ok, int f) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current,editable,out ok,f);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, out bool ok) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current,editable,out ok);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current,editable);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current) {
			return StaticQInputDialog().GetItem(parent,title,label,list,current);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list) {
			return StaticQInputDialog().GetItem(parent,title,label,list);
		}
		protected new IQInputDialogSignals Emit {
			get {
				return (IQInputDialogSignals) Q_EMIT;
			}
		}
	}

	public interface IQInputDialogSignals : IQDialogSignals {
	}
}
