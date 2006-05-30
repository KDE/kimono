//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQAccelSignals"></see> for signals emitted by QAccel
	[SmokeClass("QAccel")]
	public class QAccel : QObject, IDisposable {
 		protected QAccel(Type dummy) : base((Type) null) {}
		interface IQAccelProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QKeySequence ShortcutKey(string arg1);
			string KeyToString(QKeySequence k);
			QKeySequence StringToKey(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAccel), this);
			_interceptor = (QAccel) realProxy.GetTransparentProxy();
		}
		private QAccel ProxyQAccel() {
			return (QAccel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAccel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAccelProxy), null);
			_staticInterceptor = (IQAccelProxy) realProxy.GetTransparentProxy();
		}
		private static IQAccelProxy StaticQAccel() {
			return (IQAccelProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQAccel().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQAccel().ClassName();
		}
		public QAccel(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			NewQAccel(parent,name);
		}
		[SmokeMethod("QAccel(QWidget*, const char*)")]
		private void NewQAccel(QWidget parent, string name) {
			ProxyQAccel().NewQAccel(parent,name);
		}
		public QAccel(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAccel(parent);
		}
		[SmokeMethod("QAccel(QWidget*)")]
		private void NewQAccel(QWidget parent) {
			ProxyQAccel().NewQAccel(parent);
		}
		public QAccel(QWidget watch, QObject parent, string name) : this((Type) null) {
			CreateProxy();
			NewQAccel(watch,parent,name);
		}
		[SmokeMethod("QAccel(QWidget*, QObject*, const char*)")]
		private void NewQAccel(QWidget watch, QObject parent, string name) {
			ProxyQAccel().NewQAccel(watch,parent,name);
		}
		public QAccel(QWidget watch, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAccel(watch,parent);
		}
		[SmokeMethod("QAccel(QWidget*, QObject*)")]
		private void NewQAccel(QWidget watch, QObject parent) {
			ProxyQAccel().NewQAccel(watch,parent);
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQAccel().IsEnabled();
		}
		[SmokeMethod("setEnabled(bool)")]
		public void SetEnabled(bool arg1) {
			ProxyQAccel().SetEnabled(arg1);
		}
		[SmokeMethod("count() const")]
		public uint Count() {
			return ProxyQAccel().Count();
		}
		[SmokeMethod("insertItem(const QKeySequence&, int)")]
		public int InsertItem(QKeySequence key, int id) {
			return ProxyQAccel().InsertItem(key,id);
		}
		[SmokeMethod("insertItem(const QKeySequence&)")]
		public int InsertItem(QKeySequence key) {
			return ProxyQAccel().InsertItem(key);
		}
		[SmokeMethod("removeItem(int)")]
		public void RemoveItem(int id) {
			ProxyQAccel().RemoveItem(id);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQAccel().Clear();
		}
		[SmokeMethod("key(int)")]
		public QKeySequence Key(int id) {
			return ProxyQAccel().Key(id);
		}
		[SmokeMethod("findKey(const QKeySequence&) const")]
		public int FindKey(QKeySequence key) {
			return ProxyQAccel().FindKey(key);
		}
		[SmokeMethod("isItemEnabled(int) const")]
		public bool IsItemEnabled(int id) {
			return ProxyQAccel().IsItemEnabled(id);
		}
		[SmokeMethod("setItemEnabled(int, bool)")]
		public void SetItemEnabled(int id, bool enable) {
			ProxyQAccel().SetItemEnabled(id,enable);
		}
		[SmokeMethod("connectItem(int, const QObject*, const char*)")]
		public bool ConnectItem(int id, QObject receiver, string member) {
			return ProxyQAccel().ConnectItem(id,receiver,member);
		}
		[SmokeMethod("disconnectItem(int, const QObject*, const char*)")]
		public bool DisconnectItem(int id, QObject receiver, string member) {
			return ProxyQAccel().DisconnectItem(id,receiver,member);
		}
		[SmokeMethod("repairEventFilter()")]
		public void RepairEventFilter() {
			ProxyQAccel().RepairEventFilter();
		}
		[SmokeMethod("setWhatsThis(int, const QString&)")]
		public void SetWhatsThis(int id, string arg2) {
			ProxyQAccel().SetWhatsThis(id,arg2);
		}
		[SmokeMethod("whatsThis(int) const")]
		public string WhatsThis(int id) {
			return ProxyQAccel().WhatsThis(id);
		}
		[SmokeMethod("setIgnoreWhatsThis(bool)")]
		public void SetIgnoreWhatsThis(bool arg1) {
			ProxyQAccel().SetIgnoreWhatsThis(arg1);
		}
		[SmokeMethod("ignoreWhatsThis() const")]
		public bool IgnoreWhatsThis() {
			return ProxyQAccel().IgnoreWhatsThis();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQAccel().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQAccel().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQAccel().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQAccel().TrUtf8(arg1);
		}
		[SmokeMethod("shortcutKey(const QString&)")]
		public static QKeySequence ShortcutKey(string arg1) {
			return StaticQAccel().ShortcutKey(arg1);
		}
		[SmokeMethod("keyToString(QKeySequence)")]
		public static string KeyToString(QKeySequence k) {
			return StaticQAccel().KeyToString(k);
		}
		[SmokeMethod("stringToKey(const QString&)")]
		public static QKeySequence StringToKey(string arg1) {
			return StaticQAccel().StringToKey(arg1);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQAccel().EventFilter(arg1,arg2);
		}
		~QAccel() {
			DisposeQAccel();
		}
		public new void Dispose() {
			DisposeQAccel();
		}
		private void DisposeQAccel() {
			ProxyQAccel().DisposeQAccel();
		}
		protected new IQAccelSignals Emit() {
			return (IQAccelSignals) Q_EMIT;
		}
	}

	public interface IQAccelSignals : IQObjectSignals {
		[Q_SIGNAL("void activated(int)")]
		void Activated(int id);
		[Q_SIGNAL("void activatedAmbiguously(int)")]
		void ActivatedAmbiguously(int id);
	}
}
