//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTableItem")]
	public class QTableItem : Qt, IDisposable {
 		protected QTableItem(Type dummy) : base((Type) null) {}
		interface IQTableItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTableItem), this);
			_interceptor = (QTableItem) realProxy.GetTransparentProxy();
		}
		private QTableItem ProxyQTableItem() {
			return (QTableItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTableItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTableItemProxy), null);
			_staticInterceptor = (IQTableItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQTableItemProxy StaticQTableItem() {
			return (IQTableItemProxy) _staticInterceptor;
		}

		public enum EditType {
			Never = 0,
			OnTyping = 1,
			WhenCurrent = 2,
			Always = 3,
		}
		public QTableItem(QTable table, QTableItem.EditType et) : this((Type) null) {
			CreateProxy();
			NewQTableItem(table,et);
		}
		[SmokeMethod("QTableItem(QTable*, QTableItem::EditType)")]
		private void NewQTableItem(QTable table, QTableItem.EditType et) {
			ProxyQTableItem().NewQTableItem(table,et);
		}
		public QTableItem(QTable table, QTableItem.EditType et, string text) : this((Type) null) {
			CreateProxy();
			NewQTableItem(table,et,text);
		}
		[SmokeMethod("QTableItem(QTable*, QTableItem::EditType, const QString&)")]
		private void NewQTableItem(QTable table, QTableItem.EditType et, string text) {
			ProxyQTableItem().NewQTableItem(table,et,text);
		}
		public QTableItem(QTable table, QTableItem.EditType et, string text, QPixmap p) : this((Type) null) {
			CreateProxy();
			NewQTableItem(table,et,text,p);
		}
		[SmokeMethod("QTableItem(QTable*, QTableItem::EditType, const QString&, const QPixmap&)")]
		private void NewQTableItem(QTable table, QTableItem.EditType et, string text, QPixmap p) {
			ProxyQTableItem().NewQTableItem(table,et,text,p);
		}
		[SmokeMethod("pixmap() const")]
		public virtual QPixmap Pixmap() {
			return ProxyQTableItem().Pixmap();
		}
		[SmokeMethod("text() const")]
		public virtual string Text() {
			return ProxyQTableItem().Text();
		}
		[SmokeMethod("setPixmap(const QPixmap&)")]
		public virtual void SetPixmap(QPixmap p) {
			ProxyQTableItem().SetPixmap(p);
		}
		[SmokeMethod("setText(const QString&)")]
		public virtual void SetText(string t) {
			ProxyQTableItem().SetText(t);
		}
		[SmokeMethod("table() const")]
		public QTable Table() {
			return ProxyQTableItem().Table();
		}
		[SmokeMethod("alignment() const")]
		public virtual int Alignment() {
			return ProxyQTableItem().Alignment();
		}
		[SmokeMethod("setWordWrap(bool)")]
		public virtual void SetWordWrap(bool b) {
			ProxyQTableItem().SetWordWrap(b);
		}
		[SmokeMethod("wordWrap() const")]
		public bool WordWrap() {
			return ProxyQTableItem().WordWrap();
		}
		[SmokeMethod("editType() const")]
		public QTableItem.EditType editType() {
			return ProxyQTableItem().editType();
		}
		[SmokeMethod("createEditor() const")]
		public virtual QWidget CreateEditor() {
			return ProxyQTableItem().CreateEditor();
		}
		[SmokeMethod("setContentFromEditor(QWidget*)")]
		public virtual void SetContentFromEditor(QWidget w) {
			ProxyQTableItem().SetContentFromEditor(w);
		}
		[SmokeMethod("setReplaceable(bool)")]
		public virtual void SetReplaceable(bool arg1) {
			ProxyQTableItem().SetReplaceable(arg1);
		}
		[SmokeMethod("isReplaceable() const")]
		public bool IsReplaceable() {
			return ProxyQTableItem().IsReplaceable();
		}
		[SmokeMethod("key() const")]
		public virtual string Key() {
			return ProxyQTableItem().Key();
		}
		[SmokeMethod("sizeHint() const")]
		public virtual QSize SizeHint() {
			return ProxyQTableItem().SizeHint();
		}
		[SmokeMethod("setSpan(int, int)")]
		public virtual void SetSpan(int rs, int cs) {
			ProxyQTableItem().SetSpan(rs,cs);
		}
		[SmokeMethod("rowSpan() const")]
		public int RowSpan() {
			return ProxyQTableItem().RowSpan();
		}
		[SmokeMethod("colSpan() const")]
		public int ColSpan() {
			return ProxyQTableItem().ColSpan();
		}
		[SmokeMethod("setRow(int)")]
		public virtual void SetRow(int r) {
			ProxyQTableItem().SetRow(r);
		}
		[SmokeMethod("setCol(int)")]
		public virtual void SetCol(int c) {
			ProxyQTableItem().SetCol(c);
		}
		[SmokeMethod("row() const")]
		public int Row() {
			return ProxyQTableItem().Row();
		}
		[SmokeMethod("col() const")]
		public int Col() {
			return ProxyQTableItem().Col();
		}
		[SmokeMethod("paint(QPainter*, const QColorGroup&, const QRect&, bool)")]
		public virtual void Paint(QPainter p, QColorGroup cg, QRect cr, bool selected) {
			ProxyQTableItem().Paint(p,cg,cr,selected);
		}
		[SmokeMethod("updateEditor(int, int)")]
		public void UpdateEditor(int oldRow, int oldCol) {
			ProxyQTableItem().UpdateEditor(oldRow,oldCol);
		}
		[SmokeMethod("setEnabled(bool)")]
		public virtual void SetEnabled(bool b) {
			ProxyQTableItem().SetEnabled(b);
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQTableItem().IsEnabled();
		}
		[SmokeMethod("rtti() const")]
		public virtual int Rtti() {
			return ProxyQTableItem().Rtti();
		}
		~QTableItem() {
			DisposeQTableItem();
		}
		public void Dispose() {
			DisposeQTableItem();
		}
		private void DisposeQTableItem() {
			ProxyQTableItem().DisposeQTableItem();
		}
	}
}
