//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQTreeWidgetSignals"></see> for signals emitted by QTreeWidget
    /// </remarks>
    [SmokeClass("QTreeWidget")]
    public class QTreeWidget : QTreeView, IDisposable {
        protected QTreeWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTreeWidget), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTreeWidget() {
            staticInterceptor = new SmokeInvocation(typeof(QTreeWidget), null);
        }
        [Q_PROPERTY("int", "columnCount")]
        public int ColumnCount {
            get { return (int) interceptor.Invoke("columnCount", "columnCount()", typeof(int)); }
            set { interceptor.Invoke("setColumnCount$", "setColumnCount(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "topLevelItemCount")]
        public int TopLevelItemCount {
            get { return (int) interceptor.Invoke("topLevelItemCount", "topLevelItemCount()", typeof(int)); }
        }
        public QTreeWidget(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTreeWidget#", "QTreeWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QTreeWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTreeWidget", "QTreeWidget()", typeof(void));
        }
        public QTreeWidgetItem InvisibleRootItem() {
            return (QTreeWidgetItem) interceptor.Invoke("invisibleRootItem", "invisibleRootItem() const", typeof(QTreeWidgetItem));
        }
        public QTreeWidgetItem TopLevelItem(int index) {
            return (QTreeWidgetItem) interceptor.Invoke("topLevelItem$", "topLevelItem(int) const", typeof(QTreeWidgetItem), typeof(int), index);
        }
        public void InsertTopLevelItem(int index, QTreeWidgetItem item) {
            interceptor.Invoke("insertTopLevelItem$#", "insertTopLevelItem(int, QTreeWidgetItem*)", typeof(void), typeof(int), index, typeof(QTreeWidgetItem), item);
        }
        public void AddTopLevelItem(QTreeWidgetItem item) {
            interceptor.Invoke("addTopLevelItem#", "addTopLevelItem(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        public QTreeWidgetItem TakeTopLevelItem(int index) {
            return (QTreeWidgetItem) interceptor.Invoke("takeTopLevelItem$", "takeTopLevelItem(int)", typeof(QTreeWidgetItem), typeof(int), index);
        }
        public int IndexOfTopLevelItem(QTreeWidgetItem item) {
            return (int) interceptor.Invoke("indexOfTopLevelItem#", "indexOfTopLevelItem(QTreeWidgetItem*)", typeof(int), typeof(QTreeWidgetItem), item);
        }
        public void InsertTopLevelItems(int index, List<QTreeWidgetItem> items) {
            interceptor.Invoke("insertTopLevelItems$?", "insertTopLevelItems(int, const QList<QTreeWidgetItem*>&)", typeof(void), typeof(int), index, typeof(List<QTreeWidgetItem>), items);
        }
        public void AddTopLevelItems(List<QTreeWidgetItem> items) {
            interceptor.Invoke("addTopLevelItems?", "addTopLevelItems(const QList<QTreeWidgetItem*>&)", typeof(void), typeof(List<QTreeWidgetItem>), items);
        }
        public QTreeWidgetItem HeaderItem() {
            return (QTreeWidgetItem) interceptor.Invoke("headerItem", "headerItem() const", typeof(QTreeWidgetItem));
        }
        public void SetHeaderItem(QTreeWidgetItem item) {
            interceptor.Invoke("setHeaderItem#", "setHeaderItem(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        public void SetHeaderLabels(List<string> labels) {
            interceptor.Invoke("setHeaderLabels?", "setHeaderLabels(const QStringList&)", typeof(void), typeof(List<string>), labels);
        }
        public void SetHeaderLabel(string label) {
            interceptor.Invoke("setHeaderLabel$", "setHeaderLabel(const QString&)", typeof(void), typeof(string), label);
        }
        public QTreeWidgetItem CurrentItem() {
            return (QTreeWidgetItem) interceptor.Invoke("currentItem", "currentItem() const", typeof(QTreeWidgetItem));
        }
        public int CurrentColumn() {
            return (int) interceptor.Invoke("currentColumn", "currentColumn() const", typeof(int));
        }
        public void SetCurrentItem(QTreeWidgetItem item) {
            interceptor.Invoke("setCurrentItem#", "setCurrentItem(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        public void SetCurrentItem(QTreeWidgetItem item, int column) {
            interceptor.Invoke("setCurrentItem#$", "setCurrentItem(QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidgetItem), item, typeof(int), column);
        }
        public void SetCurrentItem(QTreeWidgetItem item, int column, uint command) {
            interceptor.Invoke("setCurrentItem#$$", "setCurrentItem(QTreeWidgetItem*, int, QItemSelectionModel::SelectionFlags)", typeof(void), typeof(QTreeWidgetItem), item, typeof(int), column, typeof(uint), command);
        }
        public QTreeWidgetItem ItemAt(QPoint p) {
            return (QTreeWidgetItem) interceptor.Invoke("itemAt#", "itemAt(const QPoint&) const", typeof(QTreeWidgetItem), typeof(QPoint), p);
        }
        public QTreeWidgetItem ItemAt(int x, int y) {
            return (QTreeWidgetItem) interceptor.Invoke("itemAt$$", "itemAt(int, int) const", typeof(QTreeWidgetItem), typeof(int), x, typeof(int), y);
        }
        public QRect VisualItemRect(QTreeWidgetItem item) {
            return (QRect) interceptor.Invoke("visualItemRect#", "visualItemRect(const QTreeWidgetItem*) const", typeof(QRect), typeof(QTreeWidgetItem), item);
        }
        public int SortColumn() {
            return (int) interceptor.Invoke("sortColumn", "sortColumn() const", typeof(int));
        }
        public void SortItems(int column, Qt.SortOrder order) {
            interceptor.Invoke("sortItems$$", "sortItems(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
        }
        public void SetSortingEnabled(bool enable) {
            interceptor.Invoke("setSortingEnabled$", "setSortingEnabled(bool)", typeof(void), typeof(bool), enable);
        }
        public bool IsSortingEnabled() {
            return (bool) interceptor.Invoke("isSortingEnabled", "isSortingEnabled() const", typeof(bool));
        }
        public void EditItem(QTreeWidgetItem item, int column) {
            interceptor.Invoke("editItem#$", "editItem(QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidgetItem), item, typeof(int), column);
        }
        public void EditItem(QTreeWidgetItem item) {
            interceptor.Invoke("editItem#", "editItem(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        public void OpenPersistentEditor(QTreeWidgetItem item, int column) {
            interceptor.Invoke("openPersistentEditor#$", "openPersistentEditor(QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidgetItem), item, typeof(int), column);
        }
        public void OpenPersistentEditor(QTreeWidgetItem item) {
            interceptor.Invoke("openPersistentEditor#", "openPersistentEditor(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        public void ClosePersistentEditor(QTreeWidgetItem item, int column) {
            interceptor.Invoke("closePersistentEditor#$", "closePersistentEditor(QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidgetItem), item, typeof(int), column);
        }
        public void ClosePersistentEditor(QTreeWidgetItem item) {
            interceptor.Invoke("closePersistentEditor#", "closePersistentEditor(QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        public QWidget ItemWidget(QTreeWidgetItem item, int column) {
            return (QWidget) interceptor.Invoke("itemWidget#$", "itemWidget(QTreeWidgetItem*, int) const", typeof(QWidget), typeof(QTreeWidgetItem), item, typeof(int), column);
        }
        public void SetItemWidget(QTreeWidgetItem item, int column, QWidget widget) {
            interceptor.Invoke("setItemWidget#$#", "setItemWidget(QTreeWidgetItem*, int, QWidget*)", typeof(void), typeof(QTreeWidgetItem), item, typeof(int), column, typeof(QWidget), widget);
        }
        public void RemoveItemWidget(QTreeWidgetItem item, int column) {
            interceptor.Invoke("removeItemWidget#$", "removeItemWidget(QTreeWidgetItem*, int)", typeof(void), typeof(QTreeWidgetItem), item, typeof(int), column);
        }
        public bool IsItemSelected(QTreeWidgetItem item) {
            return (bool) interceptor.Invoke("isItemSelected#", "isItemSelected(const QTreeWidgetItem*) const", typeof(bool), typeof(QTreeWidgetItem), item);
        }
        public void SetItemSelected(QTreeWidgetItem item, bool select) {
            interceptor.Invoke("setItemSelected#$", "setItemSelected(const QTreeWidgetItem*, bool)", typeof(void), typeof(QTreeWidgetItem), item, typeof(bool), select);
        }
        public List<QTreeWidgetItem> SelectedItems() {
            return (List<QTreeWidgetItem>) interceptor.Invoke("selectedItems", "selectedItems() const", typeof(List<QTreeWidgetItem>));
        }
        public List<QTreeWidgetItem> FindItems(string text, uint flags, int column) {
            return (List<QTreeWidgetItem>) interceptor.Invoke("findItems$$$", "findItems(const QString&, Qt::MatchFlags, int) const", typeof(List<QTreeWidgetItem>), typeof(string), text, typeof(uint), flags, typeof(int), column);
        }
        public List<QTreeWidgetItem> FindItems(string text, uint flags) {
            return (List<QTreeWidgetItem>) interceptor.Invoke("findItems$$", "findItems(const QString&, Qt::MatchFlags) const", typeof(List<QTreeWidgetItem>), typeof(string), text, typeof(uint), flags);
        }
        public bool IsItemHidden(QTreeWidgetItem item) {
            return (bool) interceptor.Invoke("isItemHidden#", "isItemHidden(const QTreeWidgetItem*) const", typeof(bool), typeof(QTreeWidgetItem), item);
        }
        public void SetItemHidden(QTreeWidgetItem item, bool hide) {
            interceptor.Invoke("setItemHidden#$", "setItemHidden(const QTreeWidgetItem*, bool)", typeof(void), typeof(QTreeWidgetItem), item, typeof(bool), hide);
        }
        public bool IsItemExpanded(QTreeWidgetItem item) {
            return (bool) interceptor.Invoke("isItemExpanded#", "isItemExpanded(const QTreeWidgetItem*) const", typeof(bool), typeof(QTreeWidgetItem), item);
        }
        public void SetItemExpanded(QTreeWidgetItem item, bool expand) {
            interceptor.Invoke("setItemExpanded#$", "setItemExpanded(const QTreeWidgetItem*, bool)", typeof(void), typeof(QTreeWidgetItem), item, typeof(bool), expand);
        }
        public bool IsFirstItemColumnSpanned(QTreeWidgetItem item) {
            return (bool) interceptor.Invoke("isFirstItemColumnSpanned#", "isFirstItemColumnSpanned(const QTreeWidgetItem*) const", typeof(bool), typeof(QTreeWidgetItem), item);
        }
        public void SetFirstItemColumnSpanned(QTreeWidgetItem item, bool span) {
            interceptor.Invoke("setFirstItemColumnSpanned#$", "setFirstItemColumnSpanned(const QTreeWidgetItem*, bool)", typeof(void), typeof(QTreeWidgetItem), item, typeof(bool), span);
        }
        public QTreeWidgetItem ItemAbove(QTreeWidgetItem item) {
            return (QTreeWidgetItem) interceptor.Invoke("itemAbove#", "itemAbove(const QTreeWidgetItem*) const", typeof(QTreeWidgetItem), typeof(QTreeWidgetItem), item);
        }
        public QTreeWidgetItem ItemBelow(QTreeWidgetItem item) {
            return (QTreeWidgetItem) interceptor.Invoke("itemBelow#", "itemBelow(const QTreeWidgetItem*) const", typeof(QTreeWidgetItem), typeof(QTreeWidgetItem), item);
        }
        [SmokeMethod("setSelectionModel(QItemSelectionModel*)")]
        public override void SetSelectionModel(QItemSelectionModel selectionModel) {
            interceptor.Invoke("setSelectionModel#", "setSelectionModel(QItemSelectionModel*)", typeof(void), typeof(QItemSelectionModel), selectionModel);
        }
        [Q_SLOT("void scrollToItem(QTreeWidgetItem*, QAbstractItemView::ScrollHint)")]
        public void ScrollToItem(QTreeWidgetItem item, QAbstractItemView.ScrollHint hint) {
            interceptor.Invoke("scrollToItem#$", "scrollToItem(const QTreeWidgetItem*, QAbstractItemView::ScrollHint)", typeof(void), typeof(QTreeWidgetItem), item, typeof(QAbstractItemView.ScrollHint), hint);
        }
        [Q_SLOT("void scrollToItem(QTreeWidgetItem*)")]
        public void ScrollToItem(QTreeWidgetItem item) {
            interceptor.Invoke("scrollToItem#", "scrollToItem(const QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        [Q_SLOT("void expandItem(QTreeWidgetItem*)")]
        public void ExpandItem(QTreeWidgetItem item) {
            interceptor.Invoke("expandItem#", "expandItem(const QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        [Q_SLOT("void collapseItem(QTreeWidgetItem*)")]
        public void CollapseItem(QTreeWidgetItem item) {
            interceptor.Invoke("collapseItem#", "collapseItem(const QTreeWidgetItem*)", typeof(void), typeof(QTreeWidgetItem), item);
        }
        [Q_SLOT("void clear()")]
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("mimeTypes() const")]
        protected virtual List<string> MimeTypes() {
            return (List<string>) interceptor.Invoke("mimeTypes", "mimeTypes() const", typeof(List<string>));
        }
        [SmokeMethod("mimeData(const QList<QTreeWidgetItem*>) const")]
        protected virtual QMimeData MimeData(List<QTreeWidgetItem> items) {
            return (QMimeData) interceptor.Invoke("mimeData?", "mimeData(const QList<QTreeWidgetItem*>) const", typeof(QMimeData), typeof(List<QTreeWidgetItem>), items);
        }
        [SmokeMethod("dropMimeData(QTreeWidgetItem*, int, const QMimeData*, Qt::DropAction)")]
        protected virtual bool DropMimeData(QTreeWidgetItem parent, int index, QMimeData data, Qt.DropAction action) {
            return (bool) interceptor.Invoke("dropMimeData#$#$", "dropMimeData(QTreeWidgetItem*, int, const QMimeData*, Qt::DropAction)", typeof(bool), typeof(QTreeWidgetItem), parent, typeof(int), index, typeof(QMimeData), data, typeof(Qt.DropAction), action);
        }
        [SmokeMethod("supportedDropActions() const")]
        protected virtual uint SupportedDropActions() {
            return (uint) interceptor.Invoke("supportedDropActions", "supportedDropActions() const", typeof(uint));
        }
        protected List<QTreeWidgetItem> Items(QMimeData data) {
            return (List<QTreeWidgetItem>) interceptor.Invoke("items#", "items(const QMimeData*) const", typeof(List<QTreeWidgetItem>), typeof(QMimeData), data);
        }
        protected QModelIndex IndexFromItem(QTreeWidgetItem item, int column) {
            return (QModelIndex) interceptor.Invoke("indexFromItem#$", "indexFromItem(QTreeWidgetItem*, int) const", typeof(QModelIndex), typeof(QTreeWidgetItem), item, typeof(int), column);
        }
        protected QModelIndex IndexFromItem(QTreeWidgetItem item) {
            return (QModelIndex) interceptor.Invoke("indexFromItem#", "indexFromItem(QTreeWidgetItem*) const", typeof(QModelIndex), typeof(QTreeWidgetItem), item);
        }
        protected QTreeWidgetItem ItemFromIndex(QModelIndex index) {
            return (QTreeWidgetItem) interceptor.Invoke("itemFromIndex#", "itemFromIndex(const QModelIndex&) const", typeof(QTreeWidgetItem), typeof(QModelIndex), index);
        }
        [SmokeMethod("dropEvent(QDropEvent*)")]
        protected override void DropEvent(QDropEvent arg1) {
            interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
        }
        ~QTreeWidget() {
            interceptor.Invoke("~QTreeWidget", "~QTreeWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTreeWidget", "~QTreeWidget()", typeof(void));
        }
        public event SlotFunc<QTreeWidgetItem,int> SignalItemPressed {
            add { QObject.Connect(this, SIGNAL("itemPressed(QTreeWidgetItem*, int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemPressed(QTreeWidgetItem*, int)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem,int> SignalItemClicked {
            add { QObject.Connect(this, SIGNAL("itemClicked(QTreeWidgetItem*, int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemClicked(QTreeWidgetItem*, int)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem,int> SignalItemDoubleClicked {
            add { QObject.Connect(this, SIGNAL("itemDoubleClicked(QTreeWidgetItem*, int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemDoubleClicked(QTreeWidgetItem*, int)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem,int> SignalItemActivated {
            add { QObject.Connect(this, SIGNAL("itemActivated(QTreeWidgetItem*, int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemActivated(QTreeWidgetItem*, int)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem,int> SignalItemEntered {
            add { QObject.Connect(this, SIGNAL("itemEntered(QTreeWidgetItem*, int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemEntered(QTreeWidgetItem*, int)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem,int> SignalItemChanged {
            add { QObject.Connect(this, SIGNAL("itemChanged(QTreeWidgetItem*, int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemChanged(QTreeWidgetItem*, int)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem> SignalItemExpanded {
            add { QObject.Connect(this, SIGNAL("itemExpanded(QTreeWidgetItem*)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemExpanded(QTreeWidgetItem*)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem> SignalItemCollapsed {
            add { QObject.Connect(this, SIGNAL("itemCollapsed(QTreeWidgetItem*)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemCollapsed(QTreeWidgetItem*)"), value); }
        }
        public event SlotFunc<QTreeWidgetItem,QTreeWidgetItem> SignalCurrentItemChanged {
            add { QObject.Connect(this, SIGNAL("currentItemChanged(QTreeWidgetItem*, QTreeWidgetItem*)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("currentItemChanged(QTreeWidgetItem*, QTreeWidgetItem*)"), value); }
        }
        public event SlotFunc SignalItemSelectionChanged {
            add { QObject.Connect(this, SIGNAL("itemSelectionChanged()"), value); }
            remove { QObject.Disconnect(this, SIGNAL("itemSelectionChanged()"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQTreeWidgetSignals Emit {
            get { return (IQTreeWidgetSignals) Q_EMIT; }
        }
    }

    public interface IQTreeWidgetSignals : IQTreeViewSignals {
        [Q_SIGNAL("void itemPressed(QTreeWidgetItem*, int)")]
        void ItemPressed(QTreeWidgetItem item, int column);
        [Q_SIGNAL("void itemClicked(QTreeWidgetItem*, int)")]
        void ItemClicked(QTreeWidgetItem item, int column);
        [Q_SIGNAL("void itemDoubleClicked(QTreeWidgetItem*, int)")]
        void ItemDoubleClicked(QTreeWidgetItem item, int column);
        [Q_SIGNAL("void itemActivated(QTreeWidgetItem*, int)")]
        void ItemActivated(QTreeWidgetItem item, int column);
        [Q_SIGNAL("void itemEntered(QTreeWidgetItem*, int)")]
        void ItemEntered(QTreeWidgetItem item, int column);
        [Q_SIGNAL("void itemChanged(QTreeWidgetItem*, int)")]
        void ItemChanged(QTreeWidgetItem item, int column);
        [Q_SIGNAL("void itemExpanded(QTreeWidgetItem*)")]
        void ItemExpanded(QTreeWidgetItem item);
        [Q_SIGNAL("void itemCollapsed(QTreeWidgetItem*)")]
        void ItemCollapsed(QTreeWidgetItem item);
        [Q_SIGNAL("void currentItemChanged(QTreeWidgetItem*, QTreeWidgetItem*)")]
        void CurrentItemChanged(QTreeWidgetItem current, QTreeWidgetItem previous);
        [Q_SIGNAL("void itemSelectionChanged()")]
        void ItemSelectionChanged();
    }
}
