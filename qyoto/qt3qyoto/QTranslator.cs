//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTranslator")]
	public class QTranslator : QObject, IDisposable {
 		protected QTranslator(Type dummy) : base((Type) null) {}
		interface IQTranslatorProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTranslator), this);
			_interceptor = (QTranslator) realProxy.GetTransparentProxy();
		}
		private QTranslator ProxyQTranslator() {
			return (QTranslator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTranslator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTranslatorProxy), null);
			_staticInterceptor = (IQTranslatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQTranslatorProxy StaticQTranslator() {
			return (IQTranslatorProxy) _staticInterceptor;
		}

		public enum SaveMode {
			Everything = 0,
			Stripped = 1,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTranslator().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTranslator().ClassName();
		}
		public QTranslator(QObject parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTranslator(parent,name);
		}
		[SmokeMethod("QTranslator(QObject*, const char*)")]
		private void NewQTranslator(QObject parent, string name) {
			ProxyQTranslator().NewQTranslator(parent,name);
		}
		public QTranslator(QObject parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTranslator(parent);
		}
		[SmokeMethod("QTranslator(QObject*)")]
		private void NewQTranslator(QObject parent) {
			ProxyQTranslator().NewQTranslator(parent);
		}
		public QTranslator() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTranslator();
		}
		[SmokeMethod("QTranslator()")]
		private void NewQTranslator() {
			ProxyQTranslator().NewQTranslator();
		}
		[SmokeMethod("find(const char*, const char*, const char*) const")]
		public string Find(string context, string sourceText, string comment) {
			return ProxyQTranslator().Find(context,sourceText,comment);
		}
		[SmokeMethod("find(const char*, const char*) const")]
		public string Find(string context, string sourceText) {
			return ProxyQTranslator().Find(context,sourceText);
		}
		[SmokeMethod("findMessage(const char*, const char*, const char*) const")]
		public virtual QTranslatorMessage FindMessage(string arg1, string arg2, string arg3) {
			return ProxyQTranslator().FindMessage(arg1,arg2,arg3);
		}
		[SmokeMethod("findMessage(const char*, const char*) const")]
		public virtual QTranslatorMessage FindMessage(string arg1, string arg2) {
			return ProxyQTranslator().FindMessage(arg1,arg2);
		}
		[SmokeMethod("load(const QString&, const QString&, const QString&, const QString&)")]
		public bool Load(string filename, string directory, string search_delimiters, string suffix) {
			return ProxyQTranslator().Load(filename,directory,search_delimiters,suffix);
		}
		[SmokeMethod("load(const QString&, const QString&, const QString&)")]
		public bool Load(string filename, string directory, string search_delimiters) {
			return ProxyQTranslator().Load(filename,directory,search_delimiters);
		}
		[SmokeMethod("load(const QString&, const QString&)")]
		public bool Load(string filename, string directory) {
			return ProxyQTranslator().Load(filename,directory);
		}
		[SmokeMethod("load(const QString&)")]
		public bool Load(string filename) {
			return ProxyQTranslator().Load(filename);
		}
		[SmokeMethod("load(const uchar*, int)")]
		public bool Load(char[] data, int len) {
			return ProxyQTranslator().Load(data,len);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQTranslator().Clear();
		}
		[SmokeMethod("save(const QString&, QTranslator::SaveMode)")]
		public bool Save(string filename, QTranslator.SaveMode mode) {
			return ProxyQTranslator().Save(filename,mode);
		}
		[SmokeMethod("save(const QString&)")]
		public bool Save(string filename) {
			return ProxyQTranslator().Save(filename);
		}
		[SmokeMethod("insert(const QTranslatorMessage&)")]
		public void Insert(QTranslatorMessage arg1) {
			ProxyQTranslator().Insert(arg1);
		}
		[SmokeMethod("insert(const char*, const char*, const QString&)")]
		public void Insert(string context, string sourceText, string translation) {
			ProxyQTranslator().Insert(context,sourceText,translation);
		}
		[SmokeMethod("remove(const QTranslatorMessage&)")]
		public void Remove(QTranslatorMessage arg1) {
			ProxyQTranslator().Remove(arg1);
		}
		[SmokeMethod("remove(const char*, const char*)")]
		public void Remove(string context, string sourceText) {
			ProxyQTranslator().Remove(context,sourceText);
		}
		[SmokeMethod("contains(const char*, const char*, const char*) const")]
		public bool Contains(string arg1, string arg2, string comment) {
			return ProxyQTranslator().Contains(arg1,arg2,comment);
		}
		[SmokeMethod("contains(const char*, const char*) const")]
		public bool Contains(string arg1, string arg2) {
			return ProxyQTranslator().Contains(arg1,arg2);
		}
		[SmokeMethod("squeeze(QTranslator::SaveMode)")]
		public void Squeeze(QTranslator.SaveMode arg1) {
			ProxyQTranslator().Squeeze(arg1);
		}
		[SmokeMethod("squeeze()")]
		public void Squeeze() {
			ProxyQTranslator().Squeeze();
		}
		[SmokeMethod("unsqueeze()")]
		public void Unsqueeze() {
			ProxyQTranslator().Unsqueeze();
		}
		// QValueList<QTranslatorMessage> messages(); >>>> NOT CONVERTED
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQTranslator().IsEmpty();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTranslator().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTranslator().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTranslator().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTranslator().TrUtf8(arg1);
		}
		~QTranslator() {
			DisposeQTranslator();
		}
		public new void Dispose() {
			DisposeQTranslator();
		}
		private void DisposeQTranslator() {
			ProxyQTranslator().DisposeQTranslator();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTranslatorSignals), this);
			Q_EMIT = (IQTranslatorSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTranslatorSignals Emit() {
			return (IQTranslatorSignals) Q_EMIT;
		}
	}

	public interface IQTranslatorSignals : IQObjectSignals {
	}
}
