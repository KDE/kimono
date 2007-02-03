//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQAbstractItemModelSignals"></see> for signals emitted by QAbstractItemModel
	[SmokeClass("QAbstractItemModel")]
	public class QAbstractItemModel : QObject {
 		protected QAbstractItemModel(Type dummy) : base((Type) null) {}
		interface IQAbstractItemModelProxy {
			[SmokeMethod("tr$$", "(const char*, const char*)")]
			string Tr(string s, string c);
			[SmokeMethod("tr$", "(const char*)")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractItemModel), this);
			_interceptor = (QAbstractItemModel) realProxy.GetTransparentProxy();
		}
		private QAbstractItemModel ProxyQAbstractItemModel() {
			return (QAbstractItemModel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractItemModel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractItemModelProxy), null);
			_staticInterceptor = (IQAbstractItemModelProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractItemModelProxy StaticQAbstractItemModel() {
			return (IQAbstractItemModelProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QAbstractItemModel(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractItemModel(parent);
		}
		[SmokeMethod("QAbstractItemModel#", "(QObject*)")]
		private void NewQAbstractItemModel(QObject parent) {
			ProxyQAbstractItemModel().NewQAbstractItemModel(parent);
		}
		public QAbstractItemModel() : this((Type) null) {
			CreateProxy();
			NewQAbstractItemModel();
		}
		[SmokeMethod("QAbstractItemModel", "()")]
		private void NewQAbstractItemModel() {
			ProxyQAbstractItemModel().NewQAbstractItemModel();
		}
		[SmokeMethod("hasIndex$$#", "(int, int, const QModelIndex&) const")]
		public bool HasIndex(int row, int column, QModelIndex parent) {
			return ProxyQAbstractItemModel().HasIndex(row,column,parent);
		}
		[SmokeMethod("hasIndex$$", "(int, int) const")]
		public bool HasIndex(int row, int column) {
			return ProxyQAbstractItemModel().HasIndex(row,column);
		}
		[SmokeMethod("index$$#", "(int, int, const QModelIndex&) const")]
		public virtual QModelIndex Index(int row, int column, QModelIndex parent) {
			return ProxyQAbstractItemModel().Index(row,column,parent);
		}
		[SmokeMethod("index$$", "(int, int) const")]
		public virtual QModelIndex Index(int row, int column) {
			return ProxyQAbstractItemModel().Index(row,column);
		}
		[SmokeMethod("parent#", "(const QModelIndex&) const")]
		public new virtual QModelIndex Parent(QModelIndex child) {
			return ProxyQAbstractItemModel().Parent(child);
		}
		[SmokeMethod("sibling$$#", "(int, int, const QModelIndex&) const")]
		public QModelIndex Sibling(int row, int column, QModelIndex idx) {
			return ProxyQAbstractItemModel().Sibling(row,column,idx);
		}
		[SmokeMethod("rowCount#", "(const QModelIndex&) const")]
		public virtual int RowCount(QModelIndex parent) {
			return ProxyQAbstractItemModel().RowCount(parent);
		}
		[SmokeMethod("rowCount", "() const")]
		public virtual int RowCount() {
			return ProxyQAbstractItemModel().RowCount();
		}
		[SmokeMethod("columnCount#", "(const QModelIndex&) const")]
		public virtual int ColumnCount(QModelIndex parent) {
			return ProxyQAbstractItemModel().ColumnCount(parent);
		}
		[SmokeMethod("columnCount", "() const")]
		public virtual int ColumnCount() {
			return ProxyQAbstractItemModel().ColumnCount();
		}
		[SmokeMethod("hasChildren#", "(const QModelIndex&) const")]
		public virtual bool HasChildren(QModelIndex parent) {
			return ProxyQAbstractItemModel().HasChildren(parent);
		}
		[SmokeMethod("hasChildren", "() const")]
		public virtual bool HasChildren() {
			return ProxyQAbstractItemModel().HasChildren();
		}
		[SmokeMethod("data#$", "(const QModelIndex&, int) const")]
		public virtual QVariant Data(QModelIndex index, int role) {
			return ProxyQAbstractItemModel().Data(index,role);
		}
		[SmokeMethod("data#", "(const QModelIndex&) const")]
		public virtual QVariant Data(QModelIndex index) {
			return ProxyQAbstractItemModel().Data(index);
		}
		[SmokeMethod("setData##$", "(const QModelIndex&, const QVariant&, int)")]
		public virtual bool SetData(QModelIndex index, QVariant value, int role) {
			return ProxyQAbstractItemModel().SetData(index,value,role);
		}
		[SmokeMethod("setData##", "(const QModelIndex&, const QVariant&)")]
		public virtual bool SetData(QModelIndex index, QVariant value) {
			return ProxyQAbstractItemModel().SetData(index,value);
		}
		[SmokeMethod("headerData$$$", "(int, Qt::Orientation, int) const")]
		public virtual QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return ProxyQAbstractItemModel().HeaderData(section,orientation,role);
		}
		[SmokeMethod("headerData$$", "(int, Qt::Orientation) const")]
		public virtual QVariant HeaderData(int section, Qt.Orientation orientation) {
			return ProxyQAbstractItemModel().HeaderData(section,orientation);
		}
		[SmokeMethod("setHeaderData$$#$", "(int, Qt::Orientation, const QVariant&, int)")]
		public virtual bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value, int role) {
			return ProxyQAbstractItemModel().SetHeaderData(section,orientation,value,role);
		}
		[SmokeMethod("setHeaderData$$#", "(int, Qt::Orientation, const QVariant&)")]
		public virtual bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value) {
			return ProxyQAbstractItemModel().SetHeaderData(section,orientation,value);
		}
		[SmokeMethod("itemData#", "(const QModelIndex&) const")]
		public virtual Dictionary<int, QVariant> ItemData(QModelIndex index) {
			return ProxyQAbstractItemModel().ItemData(index);
		}
		[SmokeMethod("setItemData#?", "(const QModelIndex&, const QMap<int, QVariant>&)")]
		public virtual bool SetItemData(QModelIndex index, Dictionary<int, QVariant> roles) {
			return ProxyQAbstractItemModel().SetItemData(index,roles);
		}
		[SmokeMethod("mimeTypes", "() const")]
		public virtual List<string> MimeTypes() {
			return ProxyQAbstractItemModel().MimeTypes();
		}
		[SmokeMethod("mimeData?", "(const QModelIndexList&) const")]
		public virtual QMimeData MimeData(List<QModelIndex> indexes) {
			return ProxyQAbstractItemModel().MimeData(indexes);
		}
		[SmokeMethod("dropMimeData#$$$#", "(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)")]
		public virtual bool DropMimeData(QMimeData data, Qt.DropAction action, int row, int column, QModelIndex parent) {
			return ProxyQAbstractItemModel().DropMimeData(data,action,row,column,parent);
		}
		[SmokeMethod("supportedDropActions", "() const")]
		public virtual int SupportedDropActions() {
			return ProxyQAbstractItemModel().SupportedDropActions();
		}
		[SmokeMethod("supportedDragActions", "() const")]
		public int SupportedDragActions() {
			return ProxyQAbstractItemModel().SupportedDragActions();
		}
		[SmokeMethod("setSupportedDragActions$", "(Qt::DropActions)")]
		public void SetSupportedDragActions(int arg1) {
			ProxyQAbstractItemModel().SetSupportedDragActions(arg1);
		}
		[SmokeMethod("insertRows$$#", "(int, int, const QModelIndex&)")]
		public virtual bool InsertRows(int row, int count, QModelIndex parent) {
			return ProxyQAbstractItemModel().InsertRows(row,count,parent);
		}
		[SmokeMethod("insertRows$$", "(int, int)")]
		public virtual bool InsertRows(int row, int count) {
			return ProxyQAbstractItemModel().InsertRows(row,count);
		}
		[SmokeMethod("insertColumns$$#", "(int, int, const QModelIndex&)")]
		public virtual bool InsertColumns(int column, int count, QModelIndex parent) {
			return ProxyQAbstractItemModel().InsertColumns(column,count,parent);
		}
		[SmokeMethod("insertColumns$$", "(int, int)")]
		public virtual bool InsertColumns(int column, int count) {
			return ProxyQAbstractItemModel().InsertColumns(column,count);
		}
		[SmokeMethod("removeRows$$#", "(int, int, const QModelIndex&)")]
		public virtual bool RemoveRows(int row, int count, QModelIndex parent) {
			return ProxyQAbstractItemModel().RemoveRows(row,count,parent);
		}
		[SmokeMethod("removeRows$$", "(int, int)")]
		public virtual bool RemoveRows(int row, int count) {
			return ProxyQAbstractItemModel().RemoveRows(row,count);
		}
		[SmokeMethod("removeColumns$$#", "(int, int, const QModelIndex&)")]
		public virtual bool RemoveColumns(int column, int count, QModelIndex parent) {
			return ProxyQAbstractItemModel().RemoveColumns(column,count,parent);
		}
		[SmokeMethod("removeColumns$$", "(int, int)")]
		public virtual bool RemoveColumns(int column, int count) {
			return ProxyQAbstractItemModel().RemoveColumns(column,count);
		}
		[SmokeMethod("insertRow$#", "(int, const QModelIndex&)")]
		public bool InsertRow(int row, QModelIndex parent) {
			return ProxyQAbstractItemModel().InsertRow(row,parent);
		}
		[SmokeMethod("insertRow$", "(int)")]
		public bool InsertRow(int row) {
			return ProxyQAbstractItemModel().InsertRow(row);
		}
		[SmokeMethod("insertColumn$#", "(int, const QModelIndex&)")]
		public bool InsertColumn(int column, QModelIndex parent) {
			return ProxyQAbstractItemModel().InsertColumn(column,parent);
		}
		[SmokeMethod("insertColumn$", "(int)")]
		public bool InsertColumn(int column) {
			return ProxyQAbstractItemModel().InsertColumn(column);
		}
		[SmokeMethod("removeRow$#", "(int, const QModelIndex&)")]
		public bool RemoveRow(int row, QModelIndex parent) {
			return ProxyQAbstractItemModel().RemoveRow(row,parent);
		}
		[SmokeMethod("removeRow$", "(int)")]
		public bool RemoveRow(int row) {
			return ProxyQAbstractItemModel().RemoveRow(row);
		}
		[SmokeMethod("removeColumn$#", "(int, const QModelIndex&)")]
		public bool RemoveColumn(int column, QModelIndex parent) {
			return ProxyQAbstractItemModel().RemoveColumn(column,parent);
		}
		[SmokeMethod("removeColumn$", "(int)")]
		public bool RemoveColumn(int column) {
			return ProxyQAbstractItemModel().RemoveColumn(column);
		}
		[SmokeMethod("fetchMore#", "(const QModelIndex&)")]
		public virtual void FetchMore(QModelIndex parent) {
			ProxyQAbstractItemModel().FetchMore(parent);
		}
		[SmokeMethod("canFetchMore#", "(const QModelIndex&) const")]
		public virtual bool CanFetchMore(QModelIndex parent) {
			return ProxyQAbstractItemModel().CanFetchMore(parent);
		}
		[SmokeMethod("flags#", "(const QModelIndex&) const")]
		public virtual int Flags(QModelIndex index) {
			return ProxyQAbstractItemModel().Flags(index);
		}
		[SmokeMethod("sort$$", "(int, Qt::SortOrder)")]
		public virtual void Sort(int column, Qt.SortOrder order) {
			ProxyQAbstractItemModel().Sort(column,order);
		}
		[SmokeMethod("sort$", "(int)")]
		public virtual void Sort(int column) {
			ProxyQAbstractItemModel().Sort(column);
		}
		[SmokeMethod("buddy#", "(const QModelIndex&) const")]
		public virtual QModelIndex Buddy(QModelIndex index) {
			return ProxyQAbstractItemModel().Buddy(index);
		}
		[SmokeMethod("match#$#$$", "(const QModelIndex&, int, const QVariant&, int, Qt::MatchFlags) const")]
		public virtual List<QModelIndex> Match(QModelIndex start, int role, QVariant value, int hits, int flags) {
			return ProxyQAbstractItemModel().Match(start,role,value,hits,flags);
		}
		[SmokeMethod("match#$#$", "(const QModelIndex&, int, const QVariant&, int) const")]
		public virtual List<QModelIndex> Match(QModelIndex start, int role, QVariant value, int hits) {
			return ProxyQAbstractItemModel().Match(start,role,value,hits);
		}
		[SmokeMethod("match#$#", "(const QModelIndex&, int, const QVariant&) const")]
		public virtual List<QModelIndex> Match(QModelIndex start, int role, QVariant value) {
			return ProxyQAbstractItemModel().Match(start,role,value);
		}
		[SmokeMethod("span#", "(const QModelIndex&) const")]
		public virtual QSize Span(QModelIndex index) {
			return ProxyQAbstractItemModel().Span(index);
		}
		[SmokeMethod("parent", "() const")]
		public new QObject Parent() {
			return ProxyQAbstractItemModel().Parent();
		}
		[Q_SLOT("bool submit()")]
		[SmokeMethod("submit", "()")]
		public virtual bool Submit() {
			return ProxyQAbstractItemModel().Submit();
		}
		[Q_SLOT("void revert()")]
		[SmokeMethod("revert", "()")]
		public virtual void Revert() {
			ProxyQAbstractItemModel().Revert();
		}
		public static new string Tr(string s, string c) {
			return StaticQAbstractItemModel().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQAbstractItemModel().Tr(s);
		}
		~QAbstractItemModel() {
			DisposeQAbstractItemModel();
		}
		public new void Dispose() {
			DisposeQAbstractItemModel();
		}
		[SmokeMethod("~QAbstractItemModel", "()")]
		private void DisposeQAbstractItemModel() {
			ProxyQAbstractItemModel().DisposeQAbstractItemModel();
		}
		protected new IQAbstractItemModelSignals Emit {
			get {
				return (IQAbstractItemModelSignals) Q_EMIT;
			}
		}
	}

	public interface IQAbstractItemModelSignals : IQObjectSignals {
		[Q_SIGNAL("void dataChanged(const QModelIndex&, const QModelIndex&)")]
		void DataChanged(QModelIndex topLeft, QModelIndex bottomRight);
		[Q_SIGNAL("void headerDataChanged(Qt::Orientation, int, int)")]
		void HeaderDataChanged(Qt.Orientation orientation, int first, int last);
		[Q_SIGNAL("void layoutChanged()")]
		void LayoutChanged();
		[Q_SIGNAL("void layoutAboutToBeChanged()")]
		void LayoutAboutToBeChanged();
	}
}
