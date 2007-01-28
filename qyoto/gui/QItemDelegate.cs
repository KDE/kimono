//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QItemDelegate")]
	public class QItemDelegate : QAbstractItemDelegate, IDisposable {
 		protected QItemDelegate(Type dummy) : base((Type) null) {}
		interface IQItemDelegateProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QItemDelegate), this);
			_interceptor = (QItemDelegate) realProxy.GetTransparentProxy();
		}
		private QItemDelegate ProxyQItemDelegate() {
			return (QItemDelegate) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QItemDelegate() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQItemDelegateProxy), null);
			_staticInterceptor = (IQItemDelegateProxy) realProxy.GetTransparentProxy();
		}
		private static IQItemDelegateProxy StaticQItemDelegate() {
			return (IQItemDelegateProxy) _staticInterceptor;
		}

		public bool Clipping {
			get {
				return Property("clipping").Value<bool>();
			}
			set {
				SetProperty("clipping", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QItemDelegate(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQItemDelegate(parent);
		}
		[SmokeMethod("QItemDelegate(QObject*)")]
		private void NewQItemDelegate(QObject parent) {
			ProxyQItemDelegate().NewQItemDelegate(parent);
		}
		public QItemDelegate() : this((Type) null) {
			CreateProxy();
			NewQItemDelegate();
		}
		[SmokeMethod("QItemDelegate()")]
		private void NewQItemDelegate() {
			ProxyQItemDelegate().NewQItemDelegate();
		}
		[SmokeMethod("hasClipping() const")]
		public bool HasClipping() {
			return ProxyQItemDelegate().HasClipping();
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		public new void Paint(QPainter painter, QStyleOptionViewItem option, QModelIndex index) {
			ProxyQItemDelegate().Paint(painter,option,index);
		}
		[SmokeMethod("sizeHint(const QStyleOptionViewItem&, const QModelIndex&) const")]
		public new QSize SizeHint(QStyleOptionViewItem option, QModelIndex index) {
			return ProxyQItemDelegate().SizeHint(option,index);
		}
		[SmokeMethod("createEditor(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		public new QWidget CreateEditor(QWidget parent, QStyleOptionViewItem option, QModelIndex index) {
			return ProxyQItemDelegate().CreateEditor(parent,option,index);
		}
		[SmokeMethod("setEditorData(QWidget*, const QModelIndex&) const")]
		public new void SetEditorData(QWidget editor, QModelIndex index) {
			ProxyQItemDelegate().SetEditorData(editor,index);
		}
		[SmokeMethod("setModelData(QWidget*, QAbstractItemModel*, const QModelIndex&) const")]
		public new void SetModelData(QWidget editor, QAbstractItemModel model, QModelIndex index) {
			ProxyQItemDelegate().SetModelData(editor,model,index);
		}
		[SmokeMethod("updateEditorGeometry(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		public new void UpdateEditorGeometry(QWidget editor, QStyleOptionViewItem option, QModelIndex index) {
			ProxyQItemDelegate().UpdateEditorGeometry(editor,option,index);
		}
		[SmokeMethod("itemEditorFactory() const")]
		public QItemEditorFactory ItemEditorFactory() {
			return ProxyQItemDelegate().ItemEditorFactory();
		}
		[SmokeMethod("setItemEditorFactory(QItemEditorFactory*)")]
		public void SetItemEditorFactory(QItemEditorFactory factory) {
			ProxyQItemDelegate().SetItemEditorFactory(factory);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQItemDelegate().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQItemDelegate().Tr(s);
		}
		[SmokeMethod("drawDisplay(QPainter*, const QStyleOptionViewItem&, const QRect&, const QString&) const")]
		protected virtual void DrawDisplay(QPainter painter, QStyleOptionViewItem option, QRect rect, string text) {
			ProxyQItemDelegate().DrawDisplay(painter,option,rect,text);
		}
		[SmokeMethod("drawDecoration(QPainter*, const QStyleOptionViewItem&, const QRect&, const QPixmap&) const")]
		protected virtual void DrawDecoration(QPainter painter, QStyleOptionViewItem option, QRect rect, QPixmap pixmap) {
			ProxyQItemDelegate().DrawDecoration(painter,option,rect,pixmap);
		}
		[SmokeMethod("drawFocus(QPainter*, const QStyleOptionViewItem&, const QRect&) const")]
		protected virtual void DrawFocus(QPainter painter, QStyleOptionViewItem option, QRect rect) {
			ProxyQItemDelegate().DrawFocus(painter,option,rect);
		}
		[SmokeMethod("drawCheck(QPainter*, const QStyleOptionViewItem&, const QRect&, Qt::CheckState) const")]
		protected virtual void DrawCheck(QPainter painter, QStyleOptionViewItem option, QRect rect, Qt.CheckState state) {
			ProxyQItemDelegate().DrawCheck(painter,option,rect,state);
		}
		[SmokeMethod("drawBackground(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		protected void DrawBackground(QPainter painter, QStyleOptionViewItem option, QModelIndex index) {
			ProxyQItemDelegate().DrawBackground(painter,option,index);
		}
		[SmokeMethod("doLayout(const QStyleOptionViewItem&, QRect*, QRect*, QRect*, bool) const")]
		protected void DoLayout(QStyleOptionViewItem option, QRect checkRect, QRect iconRect, QRect textRect, bool hint) {
			ProxyQItemDelegate().DoLayout(option,checkRect,iconRect,textRect,hint);
		}
		[SmokeMethod("rect(const QStyleOptionViewItem&, const QModelIndex&, int) const")]
		protected QRect Rect(QStyleOptionViewItem option, QModelIndex index, int role) {
			return ProxyQItemDelegate().Rect(option,index,role);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQItemDelegate().EventFilter(arg1,arg2);
		}
		[SmokeMethod("editorEvent(QEvent*, QAbstractItemModel*, const QStyleOptionViewItem&, const QModelIndex&)")]
		protected new bool EditorEvent(QEvent arg1, QAbstractItemModel model, QStyleOptionViewItem option, QModelIndex index) {
			return ProxyQItemDelegate().EditorEvent(arg1,model,option,index);
		}
		[SmokeMethod("setOptions(const QModelIndex&, const QStyleOptionViewItem&) const")]
		protected QStyleOptionViewItem SetOptions(QModelIndex index, QStyleOptionViewItem option) {
			return ProxyQItemDelegate().SetOptions(index,option);
		}
		[SmokeMethod("decoration(const QStyleOptionViewItem&, const QVariant&) const")]
		protected QPixmap Decoration(QStyleOptionViewItem option, QVariant variant) {
			return ProxyQItemDelegate().Decoration(option,variant);
		}
		[SmokeMethod("selected(const QPixmap&, const QPalette&, bool) const")]
		protected QPixmap Selected(QPixmap pixmap, QPalette palette, bool enabled) {
			return ProxyQItemDelegate().Selected(pixmap,palette,enabled);
		}
		[SmokeMethod("check(const QStyleOptionViewItem&, const QRect&, const QVariant&) const")]
		protected QRect Check(QStyleOptionViewItem option, QRect bounding, QVariant variant) {
			return ProxyQItemDelegate().Check(option,bounding,variant);
		}
		[SmokeMethod("textRectangle(QPainter*, const QRect&, const QFont&, const QString&) const")]
		protected QRect TextRectangle(QPainter painter, QRect rect, QFont font, string text) {
			return ProxyQItemDelegate().TextRectangle(painter,rect,font,text);
		}
		~QItemDelegate() {
			DisposeQItemDelegate();
		}
		public new void Dispose() {
			DisposeQItemDelegate();
		}
		[SmokeMethod("~QItemDelegate()")]
		private void DisposeQItemDelegate() {
			ProxyQItemDelegate().DisposeQItemDelegate();
		}
		protected new IQItemDelegateSignals Emit {
			get {
				return (IQItemDelegateSignals) Q_EMIT;
			}
		}
	}

	public interface IQItemDelegateSignals : IQAbstractItemDelegateSignals {
	}
}