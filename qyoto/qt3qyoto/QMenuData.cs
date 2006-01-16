//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public interface IQMenuData {
			uint Count();
			int InsertItem(string text, QObject receiver, string member, QKeySequence accel, int id, int index);
			int InsertItem(string text, QObject receiver, string member, QKeySequence accel, int id);
			int InsertItem(string text, QObject receiver, string member, QKeySequence accel);
			int InsertItem(string text, QObject receiver, string member);
			int InsertItem(QIconSet icon, string text, QObject receiver, string member, QKeySequence accel, int id, int index);
			int InsertItem(QIconSet icon, string text, QObject receiver, string member, QKeySequence accel, int id);
			int InsertItem(QIconSet icon, string text, QObject receiver, string member, QKeySequence accel);
			int InsertItem(QIconSet icon, string text, QObject receiver, string member);
			int InsertItem(QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id, int index);
			int InsertItem(QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id);
			int InsertItem(QPixmap pixmap, QObject receiver, string member, QKeySequence accel);
			int InsertItem(QPixmap pixmap, QObject receiver, string member);
			int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id, int index);
			int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id);
			int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member, QKeySequence accel);
			int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member);
			int InsertItem(string text, int id, int index);
			int InsertItem(string text, int id);
			int InsertItem(string text);
			int InsertItem(QIconSet icon, string text, int id, int index);
			int InsertItem(QIconSet icon, string text, int id);
			int InsertItem(QIconSet icon, string text);
			int InsertItem(string text, QPopupMenu popup, int id, int index);
			int InsertItem(string text, QPopupMenu popup, int id);
			int InsertItem(string text, QPopupMenu popup);
			int InsertItem(QIconSet icon, string text, QPopupMenu popup, int id, int index);
			int InsertItem(QIconSet icon, string text, QPopupMenu popup, int id);
			int InsertItem(QIconSet icon, string text, QPopupMenu popup);
			int InsertItem(QPixmap pixmap, int id, int index);
			int InsertItem(QPixmap pixmap, int id);
			int InsertItem(QPixmap pixmap);
			int InsertItem(QIconSet icon, QPixmap pixmap, int id, int index);
			int InsertItem(QIconSet icon, QPixmap pixmap, int id);
			int InsertItem(QIconSet icon, QPixmap pixmap);
			int InsertItem(QPixmap pixmap, QPopupMenu popup, int id, int index);
			int InsertItem(QPixmap pixmap, QPopupMenu popup, int id);
			int InsertItem(QPixmap pixmap, QPopupMenu popup);
			int InsertItem(QIconSet icon, QPixmap pixmap, QPopupMenu popup, int id, int index);
			int InsertItem(QIconSet icon, QPixmap pixmap, QPopupMenu popup, int id);
			int InsertItem(QIconSet icon, QPixmap pixmap, QPopupMenu popup);
			int InsertItem(QWidget widget, int id, int index);
			int InsertItem(QWidget widget, int id);
			int InsertItem(QWidget widget);
			int InsertItem(QIconSet icon, QCustomMenuItem custom, int id, int index);
			int InsertItem(QIconSet icon, QCustomMenuItem custom, int id);
			int InsertItem(QIconSet icon, QCustomMenuItem custom);
			int InsertItem(QCustomMenuItem custom, int id, int index);
			int InsertItem(QCustomMenuItem custom, int id);
			int InsertItem(QCustomMenuItem custom);
			int InsertSeparator(int index);
			int InsertSeparator();
			void RemoveItem(int id);
			void RemoveItemAt(int index);
			void Clear();
			QKeySequence Accel(int id);
			void SetAccel(QKeySequence key, int id);
			QIconSet IconSet(int id);
			string Text(int id);
			QPixmap Pixmap(int id);
			void SetWhatsThis(int id, string arg2);
			string WhatsThis(int id);
			void ChangeItem(int id, string text);
			void ChangeItem(int id, QPixmap pixmap);
			void ChangeItem(int id, QIconSet icon, string text);
			void ChangeItem(int id, QIconSet icon, QPixmap pixmap);
			void ChangeItem(string text, int id);
			void ChangeItem(QPixmap pixmap, int id);
			void ChangeItem(QIconSet icon, string text, int id);
			bool IsItemActive(int id);
			bool IsItemEnabled(int id);
			void SetItemEnabled(int id, bool enable);
			bool IsItemChecked(int id);
			void SetItemChecked(int id, bool check);
			bool IsItemVisible(int id);
			void SetItemVisible(int id, bool visible);
			void UpdateItem(int id);
			int IndexOf(int id);
			int IdAt(int index);
			void SetId(int index, int id);
			bool ConnectItem(int id, QObject receiver, string member);
			bool DisconnectItem(int id, QObject receiver, string member);
			bool SetItemParameter(int id, int param);
			int ItemParameter(int id);
			QMenuItem FindItem(int id);
			QMenuItem FindPopup(QPopupMenu arg1, out int index);
			QMenuItem FindPopup(QPopupMenu arg1);
			void ActivateItemAt(int index);
	}

	[SmokeClass("QMenuData")]
	public class QMenuData : MarshalByRefObject, IQMenuData, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QMenuData(Type dummy) {}
		interface IQMenuDataProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMenuData), this);
			_interceptor = (QMenuData) realProxy.GetTransparentProxy();
		}
		private QMenuData ProxyQMenuData() {
			return (QMenuData) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMenuData() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMenuDataProxy), null);
			_staticInterceptor = (IQMenuDataProxy) realProxy.GetTransparentProxy();
		}
		private static IQMenuDataProxy StaticQMenuData() {
			return (IQMenuDataProxy) _staticInterceptor;
		}

		public QMenuData() : this((Type) null) {
			CreateProxy();
			NewQMenuData();
		}
		[SmokeMethod("QMenuData()")]
		private void NewQMenuData() {
			ProxyQMenuData().NewQMenuData();
		}
		[SmokeMethod("count() const")]
		public uint Count() {
			return ProxyQMenuData().Count();
		}
		[SmokeMethod("insertItem(const QString&, const QObject*, const char*, const QKeySequence&, int, int)")]
		public int InsertItem(string text, QObject receiver, string member, QKeySequence accel, int id, int index) {
			return ProxyQMenuData().InsertItem(text,receiver,member,accel,id,index);
		}
		[SmokeMethod("insertItem(const QString&, const QObject*, const char*, const QKeySequence&, int)")]
		public int InsertItem(string text, QObject receiver, string member, QKeySequence accel, int id) {
			return ProxyQMenuData().InsertItem(text,receiver,member,accel,id);
		}
		[SmokeMethod("insertItem(const QString&, const QObject*, const char*, const QKeySequence&)")]
		public int InsertItem(string text, QObject receiver, string member, QKeySequence accel) {
			return ProxyQMenuData().InsertItem(text,receiver,member,accel);
		}
		[SmokeMethod("insertItem(const QString&, const QObject*, const char*)")]
		public int InsertItem(string text, QObject receiver, string member) {
			return ProxyQMenuData().InsertItem(text,receiver,member);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, const QObject*, const char*, const QKeySequence&, int, int)")]
		public int InsertItem(QIconSet icon, string text, QObject receiver, string member, QKeySequence accel, int id, int index) {
			return ProxyQMenuData().InsertItem(icon,text,receiver,member,accel,id,index);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, const QObject*, const char*, const QKeySequence&, int)")]
		public int InsertItem(QIconSet icon, string text, QObject receiver, string member, QKeySequence accel, int id) {
			return ProxyQMenuData().InsertItem(icon,text,receiver,member,accel,id);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, const QObject*, const char*, const QKeySequence&)")]
		public int InsertItem(QIconSet icon, string text, QObject receiver, string member, QKeySequence accel) {
			return ProxyQMenuData().InsertItem(icon,text,receiver,member,accel);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, const QObject*, const char*)")]
		public int InsertItem(QIconSet icon, string text, QObject receiver, string member) {
			return ProxyQMenuData().InsertItem(icon,text,receiver,member);
		}
		[SmokeMethod("insertItem(const QPixmap&, const QObject*, const char*, const QKeySequence&, int, int)")]
		public int InsertItem(QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id, int index) {
			return ProxyQMenuData().InsertItem(pixmap,receiver,member,accel,id,index);
		}
		[SmokeMethod("insertItem(const QPixmap&, const QObject*, const char*, const QKeySequence&, int)")]
		public int InsertItem(QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id) {
			return ProxyQMenuData().InsertItem(pixmap,receiver,member,accel,id);
		}
		[SmokeMethod("insertItem(const QPixmap&, const QObject*, const char*, const QKeySequence&)")]
		public int InsertItem(QPixmap pixmap, QObject receiver, string member, QKeySequence accel) {
			return ProxyQMenuData().InsertItem(pixmap,receiver,member,accel);
		}
		[SmokeMethod("insertItem(const QPixmap&, const QObject*, const char*)")]
		public int InsertItem(QPixmap pixmap, QObject receiver, string member) {
			return ProxyQMenuData().InsertItem(pixmap,receiver,member);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, const QObject*, const char*, const QKeySequence&, int, int)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id, int index) {
			return ProxyQMenuData().InsertItem(icon,pixmap,receiver,member,accel,id,index);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, const QObject*, const char*, const QKeySequence&, int)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member, QKeySequence accel, int id) {
			return ProxyQMenuData().InsertItem(icon,pixmap,receiver,member,accel,id);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, const QObject*, const char*, const QKeySequence&)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member, QKeySequence accel) {
			return ProxyQMenuData().InsertItem(icon,pixmap,receiver,member,accel);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, const QObject*, const char*)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, QObject receiver, string member) {
			return ProxyQMenuData().InsertItem(icon,pixmap,receiver,member);
		}
		[SmokeMethod("insertItem(const QString&, int, int)")]
		public int InsertItem(string text, int id, int index) {
			return ProxyQMenuData().InsertItem(text,id,index);
		}
		[SmokeMethod("insertItem(const QString&, int)")]
		public int InsertItem(string text, int id) {
			return ProxyQMenuData().InsertItem(text,id);
		}
		[SmokeMethod("insertItem(const QString&)")]
		public int InsertItem(string text) {
			return ProxyQMenuData().InsertItem(text);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, int, int)")]
		public int InsertItem(QIconSet icon, string text, int id, int index) {
			return ProxyQMenuData().InsertItem(icon,text,id,index);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, int)")]
		public int InsertItem(QIconSet icon, string text, int id) {
			return ProxyQMenuData().InsertItem(icon,text,id);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&)")]
		public int InsertItem(QIconSet icon, string text) {
			return ProxyQMenuData().InsertItem(icon,text);
		}
		[SmokeMethod("insertItem(const QString&, QPopupMenu*, int, int)")]
		public int InsertItem(string text, QPopupMenu popup, int id, int index) {
			return ProxyQMenuData().InsertItem(text,popup,id,index);
		}
		[SmokeMethod("insertItem(const QString&, QPopupMenu*, int)")]
		public int InsertItem(string text, QPopupMenu popup, int id) {
			return ProxyQMenuData().InsertItem(text,popup,id);
		}
		[SmokeMethod("insertItem(const QString&, QPopupMenu*)")]
		public int InsertItem(string text, QPopupMenu popup) {
			return ProxyQMenuData().InsertItem(text,popup);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, QPopupMenu*, int, int)")]
		public int InsertItem(QIconSet icon, string text, QPopupMenu popup, int id, int index) {
			return ProxyQMenuData().InsertItem(icon,text,popup,id,index);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, QPopupMenu*, int)")]
		public int InsertItem(QIconSet icon, string text, QPopupMenu popup, int id) {
			return ProxyQMenuData().InsertItem(icon,text,popup,id);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QString&, QPopupMenu*)")]
		public int InsertItem(QIconSet icon, string text, QPopupMenu popup) {
			return ProxyQMenuData().InsertItem(icon,text,popup);
		}
		[SmokeMethod("insertItem(const QPixmap&, int, int)")]
		public int InsertItem(QPixmap pixmap, int id, int index) {
			return ProxyQMenuData().InsertItem(pixmap,id,index);
		}
		[SmokeMethod("insertItem(const QPixmap&, int)")]
		public int InsertItem(QPixmap pixmap, int id) {
			return ProxyQMenuData().InsertItem(pixmap,id);
		}
		[SmokeMethod("insertItem(const QPixmap&)")]
		public int InsertItem(QPixmap pixmap) {
			return ProxyQMenuData().InsertItem(pixmap);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, int, int)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, int id, int index) {
			return ProxyQMenuData().InsertItem(icon,pixmap,id,index);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, int)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, int id) {
			return ProxyQMenuData().InsertItem(icon,pixmap,id);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap) {
			return ProxyQMenuData().InsertItem(icon,pixmap);
		}
		[SmokeMethod("insertItem(const QPixmap&, QPopupMenu*, int, int)")]
		public int InsertItem(QPixmap pixmap, QPopupMenu popup, int id, int index) {
			return ProxyQMenuData().InsertItem(pixmap,popup,id,index);
		}
		[SmokeMethod("insertItem(const QPixmap&, QPopupMenu*, int)")]
		public int InsertItem(QPixmap pixmap, QPopupMenu popup, int id) {
			return ProxyQMenuData().InsertItem(pixmap,popup,id);
		}
		[SmokeMethod("insertItem(const QPixmap&, QPopupMenu*)")]
		public int InsertItem(QPixmap pixmap, QPopupMenu popup) {
			return ProxyQMenuData().InsertItem(pixmap,popup);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, QPopupMenu*, int, int)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, QPopupMenu popup, int id, int index) {
			return ProxyQMenuData().InsertItem(icon,pixmap,popup,id,index);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, QPopupMenu*, int)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, QPopupMenu popup, int id) {
			return ProxyQMenuData().InsertItem(icon,pixmap,popup,id);
		}
		[SmokeMethod("insertItem(const QIconSet&, const QPixmap&, QPopupMenu*)")]
		public int InsertItem(QIconSet icon, QPixmap pixmap, QPopupMenu popup) {
			return ProxyQMenuData().InsertItem(icon,pixmap,popup);
		}
		[SmokeMethod("insertItem(QWidget*, int, int)")]
		public int InsertItem(QWidget widget, int id, int index) {
			return ProxyQMenuData().InsertItem(widget,id,index);
		}
		[SmokeMethod("insertItem(QWidget*, int)")]
		public int InsertItem(QWidget widget, int id) {
			return ProxyQMenuData().InsertItem(widget,id);
		}
		[SmokeMethod("insertItem(QWidget*)")]
		public int InsertItem(QWidget widget) {
			return ProxyQMenuData().InsertItem(widget);
		}
		[SmokeMethod("insertItem(const QIconSet&, QCustomMenuItem*, int, int)")]
		public int InsertItem(QIconSet icon, QCustomMenuItem custom, int id, int index) {
			return ProxyQMenuData().InsertItem(icon,custom,id,index);
		}
		[SmokeMethod("insertItem(const QIconSet&, QCustomMenuItem*, int)")]
		public int InsertItem(QIconSet icon, QCustomMenuItem custom, int id) {
			return ProxyQMenuData().InsertItem(icon,custom,id);
		}
		[SmokeMethod("insertItem(const QIconSet&, QCustomMenuItem*)")]
		public int InsertItem(QIconSet icon, QCustomMenuItem custom) {
			return ProxyQMenuData().InsertItem(icon,custom);
		}
		[SmokeMethod("insertItem(QCustomMenuItem*, int, int)")]
		public int InsertItem(QCustomMenuItem custom, int id, int index) {
			return ProxyQMenuData().InsertItem(custom,id,index);
		}
		[SmokeMethod("insertItem(QCustomMenuItem*, int)")]
		public int InsertItem(QCustomMenuItem custom, int id) {
			return ProxyQMenuData().InsertItem(custom,id);
		}
		[SmokeMethod("insertItem(QCustomMenuItem*)")]
		public int InsertItem(QCustomMenuItem custom) {
			return ProxyQMenuData().InsertItem(custom);
		}
		[SmokeMethod("insertSeparator(int)")]
		public int InsertSeparator(int index) {
			return ProxyQMenuData().InsertSeparator(index);
		}
		[SmokeMethod("insertSeparator()")]
		public int InsertSeparator() {
			return ProxyQMenuData().InsertSeparator();
		}
		[SmokeMethod("removeItem(int)")]
		public void RemoveItem(int id) {
			ProxyQMenuData().RemoveItem(id);
		}
		[SmokeMethod("removeItemAt(int)")]
		public void RemoveItemAt(int index) {
			ProxyQMenuData().RemoveItemAt(index);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQMenuData().Clear();
		}
		[SmokeMethod("accel(int) const")]
		public QKeySequence Accel(int id) {
			return ProxyQMenuData().Accel(id);
		}
		[SmokeMethod("setAccel(const QKeySequence&, int)")]
		public void SetAccel(QKeySequence key, int id) {
			ProxyQMenuData().SetAccel(key,id);
		}
		[SmokeMethod("iconSet(int) const")]
		public QIconSet IconSet(int id) {
			return ProxyQMenuData().IconSet(id);
		}
		[SmokeMethod("text(int) const")]
		public string Text(int id) {
			return ProxyQMenuData().Text(id);
		}
		[SmokeMethod("pixmap(int) const")]
		public QPixmap Pixmap(int id) {
			return ProxyQMenuData().Pixmap(id);
		}
		[SmokeMethod("setWhatsThis(int, const QString&)")]
		public void SetWhatsThis(int id, string arg2) {
			ProxyQMenuData().SetWhatsThis(id,arg2);
		}
		[SmokeMethod("whatsThis(int) const")]
		public string WhatsThis(int id) {
			return ProxyQMenuData().WhatsThis(id);
		}
		[SmokeMethod("changeItem(int, const QString&)")]
		public void ChangeItem(int id, string text) {
			ProxyQMenuData().ChangeItem(id,text);
		}
		[SmokeMethod("changeItem(int, const QPixmap&)")]
		public void ChangeItem(int id, QPixmap pixmap) {
			ProxyQMenuData().ChangeItem(id,pixmap);
		}
		[SmokeMethod("changeItem(int, const QIconSet&, const QString&)")]
		public void ChangeItem(int id, QIconSet icon, string text) {
			ProxyQMenuData().ChangeItem(id,icon,text);
		}
		[SmokeMethod("changeItem(int, const QIconSet&, const QPixmap&)")]
		public void ChangeItem(int id, QIconSet icon, QPixmap pixmap) {
			ProxyQMenuData().ChangeItem(id,icon,pixmap);
		}
		[SmokeMethod("changeItem(const QString&, int)")]
		public void ChangeItem(string text, int id) {
			ProxyQMenuData().ChangeItem(text,id);
		}
		[SmokeMethod("changeItem(const QPixmap&, int)")]
		public void ChangeItem(QPixmap pixmap, int id) {
			ProxyQMenuData().ChangeItem(pixmap,id);
		}
		[SmokeMethod("changeItem(const QIconSet&, const QString&, int)")]
		public void ChangeItem(QIconSet icon, string text, int id) {
			ProxyQMenuData().ChangeItem(icon,text,id);
		}
		[SmokeMethod("isItemActive(int) const")]
		public bool IsItemActive(int id) {
			return ProxyQMenuData().IsItemActive(id);
		}
		[SmokeMethod("isItemEnabled(int) const")]
		public bool IsItemEnabled(int id) {
			return ProxyQMenuData().IsItemEnabled(id);
		}
		[SmokeMethod("setItemEnabled(int, bool)")]
		public void SetItemEnabled(int id, bool enable) {
			ProxyQMenuData().SetItemEnabled(id,enable);
		}
		[SmokeMethod("isItemChecked(int) const")]
		public bool IsItemChecked(int id) {
			return ProxyQMenuData().IsItemChecked(id);
		}
		[SmokeMethod("setItemChecked(int, bool)")]
		public void SetItemChecked(int id, bool check) {
			ProxyQMenuData().SetItemChecked(id,check);
		}
		[SmokeMethod("isItemVisible(int) const")]
		public bool IsItemVisible(int id) {
			return ProxyQMenuData().IsItemVisible(id);
		}
		[SmokeMethod("setItemVisible(int, bool)")]
		public void SetItemVisible(int id, bool visible) {
			ProxyQMenuData().SetItemVisible(id,visible);
		}
		[SmokeMethod("updateItem(int)")]
		public virtual void UpdateItem(int id) {
			ProxyQMenuData().UpdateItem(id);
		}
		[SmokeMethod("indexOf(int) const")]
		public int IndexOf(int id) {
			return ProxyQMenuData().IndexOf(id);
		}
		[SmokeMethod("idAt(int) const")]
		public int IdAt(int index) {
			return ProxyQMenuData().IdAt(index);
		}
		[SmokeMethod("setId(int, int)")]
		public virtual void SetId(int index, int id) {
			ProxyQMenuData().SetId(index,id);
		}
		[SmokeMethod("connectItem(int, const QObject*, const char*)")]
		public bool ConnectItem(int id, QObject receiver, string member) {
			return ProxyQMenuData().ConnectItem(id,receiver,member);
		}
		[SmokeMethod("disconnectItem(int, const QObject*, const char*)")]
		public bool DisconnectItem(int id, QObject receiver, string member) {
			return ProxyQMenuData().DisconnectItem(id,receiver,member);
		}
		[SmokeMethod("setItemParameter(int, int)")]
		public bool SetItemParameter(int id, int param) {
			return ProxyQMenuData().SetItemParameter(id,param);
		}
		[SmokeMethod("itemParameter(int) const")]
		public int ItemParameter(int id) {
			return ProxyQMenuData().ItemParameter(id);
		}
		[SmokeMethod("findItem(int) const")]
		public QMenuItem FindItem(int id) {
			return ProxyQMenuData().FindItem(id);
		}
		// QMenuItem* findItem(int arg1,QMenuData** arg2); >>>> NOT CONVERTED
		[SmokeMethod("findPopup(QPopupMenu*, int*)")]
		public QMenuItem FindPopup(QPopupMenu arg1, out int index) {
			return ProxyQMenuData().FindPopup(arg1,out index);
		}
		[SmokeMethod("findPopup(QPopupMenu*)")]
		public QMenuItem FindPopup(QPopupMenu arg1) {
			return ProxyQMenuData().FindPopup(arg1);
		}
		[SmokeMethod("activateItemAt(int)")]
		public virtual void ActivateItemAt(int index) {
			ProxyQMenuData().ActivateItemAt(index);
		}
		[SmokeMethod("menuContentsChanged()")]
		protected virtual void MenuContentsChanged() {
			ProxyQMenuData().MenuContentsChanged();
		}
		[SmokeMethod("menuStateChanged()")]
		protected virtual void MenuStateChanged() {
			ProxyQMenuData().MenuStateChanged();
		}
		[SmokeMethod("menuInsPopup(QPopupMenu*)")]
		protected virtual void MenuInsPopup(QPopupMenu arg1) {
			ProxyQMenuData().MenuInsPopup(arg1);
		}
		[SmokeMethod("menuDelPopup(QPopupMenu*)")]
		protected virtual void MenuDelPopup(QPopupMenu arg1) {
			ProxyQMenuData().MenuDelPopup(arg1);
		}
		~QMenuData() {
			DisposeQMenuData();
		}
		public void Dispose() {
			DisposeQMenuData();
		}
		private void DisposeQMenuData() {
			ProxyQMenuData().DisposeQMenuData();
		}
	}
}
