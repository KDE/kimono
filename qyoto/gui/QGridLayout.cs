//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QGridLayout")]
	public class QGridLayout : QLayout, IDisposable {
 		protected QGridLayout(Type dummy) : base((Type) null) {}
		interface IQGridLayoutProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGridLayout), this);
			_interceptor = (QGridLayout) realProxy.GetTransparentProxy();
		}
		private QGridLayout ProxyQGridLayout() {
			return (QGridLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGridLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGridLayoutProxy), null);
			_staticInterceptor = (IQGridLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQGridLayoutProxy StaticQGridLayout() {
			return (IQGridLayoutProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QGridLayout(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQGridLayout(parent);
		}
		[SmokeMethod("QGridLayout#", "(QWidget*)")]
		private void NewQGridLayout(QWidget parent) {
			ProxyQGridLayout().NewQGridLayout(parent);
		}
		public QGridLayout() : this((Type) null) {
			CreateProxy();
			NewQGridLayout();
		}
		[SmokeMethod("QGridLayout", "()")]
		private void NewQGridLayout() {
			ProxyQGridLayout().NewQGridLayout();
		}
		[SmokeMethod("sizeHint", "() const")]
		public new QSize SizeHint() {
			return ProxyQGridLayout().SizeHint();
		}
		[SmokeMethod("minimumSize", "() const")]
		public new QSize MinimumSize() {
			return ProxyQGridLayout().MinimumSize();
		}
		[SmokeMethod("maximumSize", "() const")]
		public new QSize MaximumSize() {
			return ProxyQGridLayout().MaximumSize();
		}
		[SmokeMethod("setRowStretch$$", "(int, int)")]
		public void SetRowStretch(int row, int stretch) {
			ProxyQGridLayout().SetRowStretch(row,stretch);
		}
		[SmokeMethod("setColumnStretch$$", "(int, int)")]
		public void SetColumnStretch(int column, int stretch) {
			ProxyQGridLayout().SetColumnStretch(column,stretch);
		}
		[SmokeMethod("rowStretch$", "(int) const")]
		public int RowStretch(int row) {
			return ProxyQGridLayout().RowStretch(row);
		}
		[SmokeMethod("columnStretch$", "(int) const")]
		public int ColumnStretch(int column) {
			return ProxyQGridLayout().ColumnStretch(column);
		}
		[SmokeMethod("setRowMinimumHeight$$", "(int, int)")]
		public void SetRowMinimumHeight(int row, int minSize) {
			ProxyQGridLayout().SetRowMinimumHeight(row,minSize);
		}
		[SmokeMethod("setColumnMinimumWidth$$", "(int, int)")]
		public void SetColumnMinimumWidth(int column, int minSize) {
			ProxyQGridLayout().SetColumnMinimumWidth(column,minSize);
		}
		[SmokeMethod("rowMinimumHeight$", "(int) const")]
		public int RowMinimumHeight(int row) {
			return ProxyQGridLayout().RowMinimumHeight(row);
		}
		[SmokeMethod("columnMinimumWidth$", "(int) const")]
		public int ColumnMinimumWidth(int column) {
			return ProxyQGridLayout().ColumnMinimumWidth(column);
		}
		[SmokeMethod("columnCount", "() const")]
		public int ColumnCount() {
			return ProxyQGridLayout().ColumnCount();
		}
		[SmokeMethod("rowCount", "() const")]
		public int RowCount() {
			return ProxyQGridLayout().RowCount();
		}
		[SmokeMethod("cellRect$$", "(int, int) const")]
		public QRect CellRect(int row, int column) {
			return ProxyQGridLayout().CellRect(row,column);
		}
		[SmokeMethod("hasHeightForWidth", "() const")]
		public new bool HasHeightForWidth() {
			return ProxyQGridLayout().HasHeightForWidth();
		}
		[SmokeMethod("heightForWidth$", "(int) const")]
		public new int HeightForWidth(int arg1) {
			return ProxyQGridLayout().HeightForWidth(arg1);
		}
		[SmokeMethod("minimumHeightForWidth$", "(int) const")]
		public new int MinimumHeightForWidth(int arg1) {
			return ProxyQGridLayout().MinimumHeightForWidth(arg1);
		}
		[SmokeMethod("expandingDirections", "() const")]
		public new int ExpandingDirections() {
			return ProxyQGridLayout().ExpandingDirections();
		}
		[SmokeMethod("invalidate", "()")]
		public new void Invalidate() {
			ProxyQGridLayout().Invalidate();
		}
		[SmokeMethod("addWidget#", "(QWidget*)")]
		public new void AddWidget(QWidget w) {
			ProxyQGridLayout().AddWidget(w);
		}
		[SmokeMethod("addWidget#$$$", "(QWidget*, int, int, Qt::Alignment)")]
		public new void AddWidget(QWidget arg1, int row, int column, int arg4) {
			ProxyQGridLayout().AddWidget(arg1,row,column,arg4);
		}
		[SmokeMethod("addWidget#$$", "(QWidget*, int, int)")]
		public new void AddWidget(QWidget arg1, int row, int column) {
			ProxyQGridLayout().AddWidget(arg1,row,column);
		}
		[SmokeMethod("addWidget#$$$$$", "(QWidget*, int, int, int, int, Qt::Alignment)")]
		public new void AddWidget(QWidget arg1, int row, int column, int rowSpan, int columnSpan, int arg6) {
			ProxyQGridLayout().AddWidget(arg1,row,column,rowSpan,columnSpan,arg6);
		}
		[SmokeMethod("addWidget#$$$$", "(QWidget*, int, int, int, int)")]
		public new void AddWidget(QWidget arg1, int row, int column, int rowSpan, int columnSpan) {
			ProxyQGridLayout().AddWidget(arg1,row,column,rowSpan,columnSpan);
		}
		[SmokeMethod("addLayout#$$$", "(QLayout*, int, int, Qt::Alignment)")]
		public void AddLayout(QLayout arg1, int row, int column, int arg4) {
			ProxyQGridLayout().AddLayout(arg1,row,column,arg4);
		}
		[SmokeMethod("addLayout#$$", "(QLayout*, int, int)")]
		public void AddLayout(QLayout arg1, int row, int column) {
			ProxyQGridLayout().AddLayout(arg1,row,column);
		}
		[SmokeMethod("addLayout#$$$$$", "(QLayout*, int, int, int, int, Qt::Alignment)")]
		public void AddLayout(QLayout arg1, int row, int column, int rowSpan, int columnSpan, int arg6) {
			ProxyQGridLayout().AddLayout(arg1,row,column,rowSpan,columnSpan,arg6);
		}
		[SmokeMethod("addLayout#$$$$", "(QLayout*, int, int, int, int)")]
		public void AddLayout(QLayout arg1, int row, int column, int rowSpan, int columnSpan) {
			ProxyQGridLayout().AddLayout(arg1,row,column,rowSpan,columnSpan);
		}
		[SmokeMethod("setOriginCorner$", "(Qt::Corner)")]
		public void SetOriginCorner(Qt.Corner arg1) {
			ProxyQGridLayout().SetOriginCorner(arg1);
		}
		[SmokeMethod("originCorner", "() const")]
		public Qt.Corner OriginCorner() {
			return ProxyQGridLayout().OriginCorner();
		}
		[SmokeMethod("itemAt$", "(int) const")]
		public new IQLayoutItem ItemAt(int arg1) {
			return ProxyQGridLayout().ItemAt(arg1);
		}
		[SmokeMethod("takeAt$", "(int)")]
		public new IQLayoutItem TakeAt(int arg1) {
			return ProxyQGridLayout().TakeAt(arg1);
		}
		[SmokeMethod("count", "() const")]
		public new int Count() {
			return ProxyQGridLayout().Count();
		}
		[SmokeMethod("setGeometry#", "(const QRect&)")]
		public new void SetGeometry(QRect arg1) {
			ProxyQGridLayout().SetGeometry(arg1);
		}
		[SmokeMethod("addItem#$$$$$", "(QLayoutItem*, int, int, int, int, Qt::Alignment)")]
		public new void AddItem(IQLayoutItem item, int row, int column, int rowSpan, int columnSpan, int arg6) {
			ProxyQGridLayout().AddItem(item,row,column,rowSpan,columnSpan,arg6);
		}
		[SmokeMethod("addItem#$$$$", "(QLayoutItem*, int, int, int, int)")]
		public new void AddItem(IQLayoutItem item, int row, int column, int rowSpan, int columnSpan) {
			ProxyQGridLayout().AddItem(item,row,column,rowSpan,columnSpan);
		}
		[SmokeMethod("addItem#$$$", "(QLayoutItem*, int, int, int)")]
		public new void AddItem(IQLayoutItem item, int row, int column, int rowSpan) {
			ProxyQGridLayout().AddItem(item,row,column,rowSpan);
		}
		[SmokeMethod("addItem#$$", "(QLayoutItem*, int, int)")]
		public new void AddItem(IQLayoutItem item, int row, int column) {
			ProxyQGridLayout().AddItem(item,row,column);
		}
		[SmokeMethod("setDefaultPositioning$$", "(int, Qt::Orientation)")]
		public void SetDefaultPositioning(int n, Qt.Orientation orient) {
			ProxyQGridLayout().SetDefaultPositioning(n,orient);
		}
		[SmokeMethod("getItemPosition$$$$$", "(int, int*, int*, int*, int*)")]
		public void GetItemPosition(int idx, out int row, out int column, out int rowSpan, out int columnSpan) {
			ProxyQGridLayout().GetItemPosition(idx,out row,out column,out rowSpan,out columnSpan);
		}
		public static new string Tr(string s, string c) {
			return StaticQGridLayout().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQGridLayout().Tr(s);
		}
		[SmokeMethod("addItem#", "(QLayoutItem*)")]
		protected new void AddItem(IQLayoutItem arg1) {
			ProxyQGridLayout().AddItem(arg1);
		}
		~QGridLayout() {
			DisposeQGridLayout();
		}
		public new void Dispose() {
			DisposeQGridLayout();
		}
		[SmokeMethod("~QGridLayout", "()")]
		private void DisposeQGridLayout() {
			ProxyQGridLayout().DisposeQGridLayout();
		}
		protected new IQGridLayoutSignals Emit {
			get {
				return (IQGridLayoutSignals) Q_EMIT;
			}
		}
	}

	public interface IQGridLayoutSignals : IQLayoutSignals {
	}
}
