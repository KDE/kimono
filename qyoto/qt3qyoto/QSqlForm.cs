//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QSqlForm")]
	public class QSqlForm : QObject, IDisposable {
 		protected QSqlForm(Type dummy) : base((Type) null) {}
		interface IQSqlFormProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlForm), this);
			_interceptor = (QSqlForm) realProxy.GetTransparentProxy();
		}
		private QSqlForm ProxyQSqlForm() {
			return (QSqlForm) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlForm() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlFormProxy), null);
			_staticInterceptor = (IQSqlFormProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlFormProxy StaticQSqlForm() {
			return (IQSqlFormProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQSqlForm().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQSqlForm().ClassName();
		}
		public QSqlForm(QObject parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQSqlForm(parent,name);
		}
		[SmokeMethod("QSqlForm(QObject*, const char*)")]
		private void NewQSqlForm(QObject parent, string name) {
			ProxyQSqlForm().NewQSqlForm(parent,name);
		}
		public QSqlForm(QObject parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQSqlForm(parent);
		}
		[SmokeMethod("QSqlForm(QObject*)")]
		private void NewQSqlForm(QObject parent) {
			ProxyQSqlForm().NewQSqlForm(parent);
		}
		public QSqlForm() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQSqlForm();
		}
		[SmokeMethod("QSqlForm()")]
		private void NewQSqlForm() {
			ProxyQSqlForm().NewQSqlForm();
		}
		[SmokeMethod("insert(QWidget*, const QString&)")]
		public virtual void Insert(QWidget widget, string field) {
			ProxyQSqlForm().Insert(widget,field);
		}
		[SmokeMethod("remove(const QString&)")]
		public virtual void Remove(string field) {
			ProxyQSqlForm().Remove(field);
		}
		[SmokeMethod("count() const")]
		public uint Count() {
			return ProxyQSqlForm().Count();
		}
		[SmokeMethod("widget(uint) const")]
		public QWidget Widget(uint i) {
			return ProxyQSqlForm().Widget(i);
		}
		[SmokeMethod("widgetToField(QWidget*) const")]
		public QSqlField WidgetToField(QWidget widget) {
			return ProxyQSqlForm().WidgetToField(widget);
		}
		[SmokeMethod("fieldToWidget(QSqlField*) const")]
		public QWidget FieldToWidget(QSqlField field) {
			return ProxyQSqlForm().FieldToWidget(field);
		}
		[SmokeMethod("installPropertyMap(QSqlPropertyMap*)")]
		public void InstallPropertyMap(QSqlPropertyMap map) {
			ProxyQSqlForm().InstallPropertyMap(map);
		}
		[SmokeMethod("setRecord(QSqlRecord*)")]
		public virtual void SetRecord(QSqlRecord buf) {
			ProxyQSqlForm().SetRecord(buf);
		}
		[Q_SLOT("void readField(QWidget*)")]
		[SmokeMethod("readField(QWidget*)")]
		public virtual void ReadField(QWidget widget) {
			ProxyQSqlForm().ReadField(widget);
		}
		[Q_SLOT("void writeField(QWidget*)")]
		[SmokeMethod("writeField(QWidget*)")]
		public virtual void WriteField(QWidget widget) {
			ProxyQSqlForm().WriteField(widget);
		}
		[Q_SLOT("void readFields()")]
		[SmokeMethod("readFields()")]
		public virtual void ReadFields() {
			ProxyQSqlForm().ReadFields();
		}
		[Q_SLOT("void writeFields()")]
		[SmokeMethod("writeFields()")]
		public virtual void WriteFields() {
			ProxyQSqlForm().WriteFields();
		}
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			ProxyQSqlForm().Clear();
		}
		[Q_SLOT("void clearValues(bool)")]
		[SmokeMethod("clearValues(bool)")]
		public virtual void ClearValues(bool nullify) {
			ProxyQSqlForm().ClearValues(nullify);
		}
		[Q_SLOT("void clearValues()")]
		[SmokeMethod("clearValues()")]
		public virtual void ClearValues() {
			ProxyQSqlForm().ClearValues();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQSqlForm().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQSqlForm().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQSqlForm().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQSqlForm().TrUtf8(arg1);
		}
		[SmokeMethod("insert(QWidget*, QSqlField*)")]
		protected virtual void Insert(QWidget widget, QSqlField field) {
			ProxyQSqlForm().Insert(widget,field);
		}
		[SmokeMethod("remove(QWidget*)")]
		protected virtual void Remove(QWidget widget) {
			ProxyQSqlForm().Remove(widget);
		}
		[SmokeMethod("clearMap()")]
		protected void ClearMap() {
			ProxyQSqlForm().ClearMap();
		}
		~QSqlForm() {
			DisposeQSqlForm();
		}
		public new void Dispose() {
			DisposeQSqlForm();
		}
		private void DisposeQSqlForm() {
			ProxyQSqlForm().DisposeQSqlForm();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQSqlFormSignals), this);
			Q_EMIT = (IQSqlFormSignals) realProxy.GetTransparentProxy();
		}
		protected new IQSqlFormSignals Emit() {
			return (IQSqlFormSignals) Q_EMIT;
		}
	}

	public interface IQSqlFormSignals : IQObjectSignals {
	}
}
