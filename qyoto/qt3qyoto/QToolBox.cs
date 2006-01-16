//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQToolBoxSignals"></see> for signals emitted by QToolBox
	[SmokeClass("QToolBox")]
	public class QToolBox : QFrame, IDisposable {
 		protected QToolBox(Type dummy) : base((Type) null) {}
		interface IQToolBoxProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolBox), this);
			_interceptor = (QToolBox) realProxy.GetTransparentProxy();
		}
		private QToolBox ProxyQToolBox() {
			return (QToolBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QToolBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolBoxProxy), null);
			_staticInterceptor = (IQToolBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQToolBoxProxy StaticQToolBox() {
			return (IQToolBoxProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQToolBox().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQToolBox().ClassName();
		}
		public QToolBox(QWidget parent, string name, int f) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQToolBox(parent,name,f);
		}
		[SmokeMethod("QToolBox(QWidget*, const char*, Qt::WFlags)")]
		private void NewQToolBox(QWidget parent, string name, int f) {
			ProxyQToolBox().NewQToolBox(parent,name,f);
		}
		public QToolBox(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQToolBox(parent,name);
		}
		[SmokeMethod("QToolBox(QWidget*, const char*)")]
		private void NewQToolBox(QWidget parent, string name) {
			ProxyQToolBox().NewQToolBox(parent,name);
		}
		public QToolBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQToolBox(parent);
		}
		[SmokeMethod("QToolBox(QWidget*)")]
		private void NewQToolBox(QWidget parent) {
			ProxyQToolBox().NewQToolBox(parent);
		}
		public QToolBox() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQToolBox();
		}
		[SmokeMethod("QToolBox()")]
		private void NewQToolBox() {
			ProxyQToolBox().NewQToolBox();
		}
		[SmokeMethod("addItem(QWidget*, const QString&)")]
		public int AddItem(QWidget item, string label) {
			return ProxyQToolBox().AddItem(item,label);
		}
		[SmokeMethod("addItem(QWidget*, const QIconSet&, const QString&)")]
		public int AddItem(QWidget item, QIconSet iconSet, string label) {
			return ProxyQToolBox().AddItem(item,iconSet,label);
		}
		[SmokeMethod("insertItem(int, QWidget*, const QString&)")]
		public int InsertItem(int index, QWidget item, string label) {
			return ProxyQToolBox().InsertItem(index,item,label);
		}
		[SmokeMethod("insertItem(int, QWidget*, const QIconSet&, const QString&)")]
		public int InsertItem(int index, QWidget item, QIconSet iconSet, string label) {
			return ProxyQToolBox().InsertItem(index,item,iconSet,label);
		}
		[SmokeMethod("removeItem(QWidget*)")]
		public int RemoveItem(QWidget item) {
			return ProxyQToolBox().RemoveItem(item);
		}
		[SmokeMethod("setItemEnabled(int, bool)")]
		public void SetItemEnabled(int index, bool enabled) {
			ProxyQToolBox().SetItemEnabled(index,enabled);
		}
		[SmokeMethod("isItemEnabled(int) const")]
		public bool IsItemEnabled(int index) {
			return ProxyQToolBox().IsItemEnabled(index);
		}
		[SmokeMethod("setItemLabel(int, const QString&)")]
		public void SetItemLabel(int index, string label) {
			ProxyQToolBox().SetItemLabel(index,label);
		}
		[SmokeMethod("itemLabel(int) const")]
		public string ItemLabel(int index) {
			return ProxyQToolBox().ItemLabel(index);
		}
		[SmokeMethod("setItemIconSet(int, const QIconSet&)")]
		public void SetItemIconSet(int index, QIconSet iconSet) {
			ProxyQToolBox().SetItemIconSet(index,iconSet);
		}
		[SmokeMethod("itemIconSet(int) const")]
		public QIconSet ItemIconSet(int index) {
			return ProxyQToolBox().ItemIconSet(index);
		}
		[SmokeMethod("setItemToolTip(int, const QString&)")]
		public void SetItemToolTip(int index, string toolTip) {
			ProxyQToolBox().SetItemToolTip(index,toolTip);
		}
		[SmokeMethod("itemToolTip(int) const")]
		public string ItemToolTip(int index) {
			return ProxyQToolBox().ItemToolTip(index);
		}
		[SmokeMethod("currentItem() const")]
		public QWidget CurrentItem() {
			return ProxyQToolBox().CurrentItem();
		}
		[SmokeMethod("setCurrentItem(QWidget*)")]
		public void SetCurrentItem(QWidget item) {
			ProxyQToolBox().SetCurrentItem(item);
		}
		[SmokeMethod("currentIndex() const")]
		public int CurrentIndex() {
			return ProxyQToolBox().CurrentIndex();
		}
		[SmokeMethod("item(int) const")]
		public QWidget Item(int index) {
			return ProxyQToolBox().Item(index);
		}
		[SmokeMethod("indexOf(QWidget*) const")]
		public int IndexOf(QWidget item) {
			return ProxyQToolBox().IndexOf(item);
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQToolBox().Count();
		}
		[Q_SLOT("void setCurrentIndex(int)")]
		[SmokeMethod("setCurrentIndex(int)")]
		public void SetCurrentIndex(int index) {
			ProxyQToolBox().SetCurrentIndex(index);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQToolBox().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQToolBox().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQToolBox().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQToolBox().TrUtf8(arg1);
		}
		[SmokeMethod("itemInserted(int)")]
		protected virtual void ItemInserted(int index) {
			ProxyQToolBox().ItemInserted(index);
		}
		[SmokeMethod("itemRemoved(int)")]
		protected virtual void ItemRemoved(int index) {
			ProxyQToolBox().ItemRemoved(index);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent e) {
			ProxyQToolBox().ShowEvent(e);
		}
		[SmokeMethod("frameChanged()")]
		protected new void FrameChanged() {
			ProxyQToolBox().FrameChanged();
		}
		[SmokeMethod("styleChange(QStyle&)")]
		public new void StyleChange(QStyle arg1) {
			ProxyQToolBox().StyleChange(arg1);
		}
		~QToolBox() {
			DisposeQToolBox();
		}
		public new void Dispose() {
			DisposeQToolBox();
		}
		private void DisposeQToolBox() {
			ProxyQToolBox().DisposeQToolBox();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQToolBoxSignals), this);
			Q_EMIT = (IQToolBoxSignals) realProxy.GetTransparentProxy();
		}
		protected new IQToolBoxSignals Emit() {
			return (IQToolBoxSignals) Q_EMIT;
		}
	}

	public interface IQToolBoxSignals : IQFrameSignals {
		[Q_SIGNAL("void currentChanged(int)")]
		void CurrentChanged(int index);
	}
}
