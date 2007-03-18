//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;
	using System.Collections.Generic;

	/// See <see cref="IQListViewSignals"></see> for signals emitted by QListView
	[SmokeClass("QListView")]
	public class QListView : QAbstractItemView, IDisposable {
 		protected QListView(Type dummy) : base((Type) null) {}
		[SmokeClass("QListView")]
		interface IQListViewProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QListView), this);
			interceptor = (QListView) realProxy.GetTransparentProxy();
		}
		private static IQListViewProxy staticInterceptor = null;
		static QListView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQListViewProxy), null);
			staticInterceptor = (IQListViewProxy) realProxy.GetTransparentProxy();
		}
		public enum Movement {
			Static = 0,
			Free = 1,
			Snap = 2,
		}
		public enum Flow {
			LeftToRight = 0,
			TopToBottom = 1,
		}
		public enum ResizeMode {
			Fixed = 0,
			Adjust = 1,
		}
		public enum LayoutMode {
			SinglePass = 0,
			Batched = 1,
		}
		public enum ViewMode {
			ListMode = 0,
			IconMode = 1,
		}
		[Q_PROPERTY("QListView::Movement", "movement")]
		public QListView.Movement movement {
			[SmokeMethod("movement", "()", "")]
			get { return ((QListView) interceptor).movement; }
			[SmokeMethod("setMovement", "(QListView::Movement)", "$")]
			set { ((QListView) interceptor).movement = value; }
		}
		[Q_PROPERTY("QListView::Flow", "flow")]
		public QListView.Flow flow {
			[SmokeMethod("flow", "()", "")]
			get { return ((QListView) interceptor).flow; }
			[SmokeMethod("setFlow", "(QListView::Flow)", "$")]
			set { ((QListView) interceptor).flow = value; }
		}
		[Q_PROPERTY("bool", "isWrapping")]
		public bool IsWrapping {
			[SmokeMethod("isWrapping", "()", "")]
			get { return ((QListView) interceptor).IsWrapping; }
			[SmokeMethod("setWrapping", "(bool)", "$")]
			set { ((QListView) interceptor).IsWrapping = value; }
		}
		[Q_PROPERTY("QListView::ResizeMode", "resizeMode")]
		public QListView.ResizeMode resizeMode {
			[SmokeMethod("resizeMode", "()", "")]
			get { return ((QListView) interceptor).resizeMode; }
			[SmokeMethod("setResizeMode", "(QListView::ResizeMode)", "$")]
			set { ((QListView) interceptor).resizeMode = value; }
		}
		[Q_PROPERTY("QListView::LayoutMode", "layoutMode")]
		public QListView.LayoutMode layoutMode {
			[SmokeMethod("layoutMode", "()", "")]
			get { return ((QListView) interceptor).layoutMode; }
			[SmokeMethod("setLayoutMode", "(QListView::LayoutMode)", "$")]
			set { ((QListView) interceptor).layoutMode = value; }
		}
		[Q_PROPERTY("int", "spacing")]
		public int Spacing {
			[SmokeMethod("spacing", "()", "")]
			get { return ((QListView) interceptor).Spacing; }
			[SmokeMethod("setSpacing", "(int)", "$")]
			set { ((QListView) interceptor).Spacing = value; }
		}
		[Q_PROPERTY("QSize", "gridSize")]
		public QSize GridSize {
			[SmokeMethod("gridSize", "()", "")]
			get { return ((QListView) interceptor).GridSize; }
			[SmokeMethod("setGridSize", "(QSize)", "#")]
			set { ((QListView) interceptor).GridSize = value; }
		}
		[Q_PROPERTY("QListView::ViewMode", "viewMode")]
		public QListView.ViewMode viewMode {
			[SmokeMethod("viewMode", "()", "")]
			get { return ((QListView) interceptor).viewMode; }
			[SmokeMethod("setViewMode", "(QListView::ViewMode)", "$")]
			set { ((QListView) interceptor).viewMode = value; }
		}
		[Q_PROPERTY("int", "modelColumn")]
		public int ModelColumn {
			[SmokeMethod("modelColumn", "()", "")]
			get { return ((QListView) interceptor).ModelColumn; }
			[SmokeMethod("setModelColumn", "(int)", "$")]
			set { ((QListView) interceptor).ModelColumn = value; }
		}
		[Q_PROPERTY("bool", "uniformItemSizes")]
		public bool UniformItemSizes {
			[SmokeMethod("uniformItemSizes", "()", "")]
			get { return ((QListView) interceptor).UniformItemSizes; }
			[SmokeMethod("setUniformItemSizes", "(bool)", "$")]
			set { ((QListView) interceptor).UniformItemSizes = value; }
		}
		[Q_PROPERTY("int", "batchSize")]
		public int BatchSize {
			[SmokeMethod("batchSize", "()", "")]
			get { return ((QListView) interceptor).BatchSize; }
			[SmokeMethod("setBatchSize", "(int)", "$")]
			set { ((QListView) interceptor).BatchSize = value; }
		}
		[Q_PROPERTY("bool", "wordWrap")]
		public bool WordWrap {
			[SmokeMethod("wordWrap", "()", "")]
			get { return ((QListView) interceptor).WordWrap; }
			[SmokeMethod("setWordWrap", "(bool)", "$")]
			set { ((QListView) interceptor).WordWrap = value; }
		}
		public QListView(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQListView(parent);
		}
		[SmokeMethod("QListView", "(QWidget*)", "#")]
		private void NewQListView(QWidget parent) {
			((QListView) interceptor).NewQListView(parent);
		}
		public QListView() : this((Type) null) {
			CreateProxy();
			NewQListView();
		}
		[SmokeMethod("QListView", "()", "")]
		private void NewQListView() {
			((QListView) interceptor).NewQListView();
		}
		[SmokeMethod("setWrapping", "(bool)", "$")]
		public void SetWrapping(bool enable) {
			((QListView) interceptor).SetWrapping(enable);
		}
		[SmokeMethod("clearPropertyFlags", "()", "")]
		public void ClearPropertyFlags() {
			((QListView) interceptor).ClearPropertyFlags();
		}
		[SmokeMethod("isRowHidden", "(int) const", "$")]
		public bool IsRowHidden(int row) {
			return ((QListView) interceptor).IsRowHidden(row);
		}
		[SmokeMethod("setRowHidden", "(int, bool)", "$$")]
		public void SetRowHidden(int row, bool hide) {
			((QListView) interceptor).SetRowHidden(row,hide);
		}
		[SmokeMethod("visualRect", "(const QModelIndex&) const", "#")]
		public override QRect VisualRect(QModelIndex index) {
			return ((QListView) interceptor).VisualRect(index);
		}
		[SmokeMethod("scrollTo", "(const QModelIndex&, QAbstractItemView::ScrollHint)", "#$")]
		public override void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			((QListView) interceptor).ScrollTo(index,hint);
		}
		[SmokeMethod("scrollTo", "(const QModelIndex&)", "#")]
		public virtual void ScrollTo(QModelIndex index) {
			((QListView) interceptor).ScrollTo(index);
		}
		[SmokeMethod("indexAt", "(const QPoint&) const", "#")]
		public override QModelIndex IndexAt(QPoint p) {
			return ((QListView) interceptor).IndexAt(p);
		}
		[SmokeMethod("doItemsLayout", "()", "")]
		public override void DoItemsLayout() {
			((QListView) interceptor).DoItemsLayout();
		}
		[SmokeMethod("reset", "()", "")]
		public override void Reset() {
			((QListView) interceptor).Reset();
		}
		[SmokeMethod("setRootIndex", "(const QModelIndex&)", "#")]
		public override void SetRootIndex(QModelIndex index) {
			((QListView) interceptor).SetRootIndex(index);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QListView) interceptor).Event(e);
		}
		[SmokeMethod("scrollContentsBy", "(int, int)", "$$")]
		protected override void ScrollContentsBy(int dx, int dy) {
			((QListView) interceptor).ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("resizeContents", "(int, int)", "$$")]
		protected void ResizeContents(int width, int height) {
			((QListView) interceptor).ResizeContents(width,height);
		}
		[SmokeMethod("contentsSize", "() const", "")]
		protected QSize ContentsSize() {
			return ((QListView) interceptor).ContentsSize();
		}
		[SmokeMethod("dataChanged", "(const QModelIndex&, const QModelIndex&)", "##")]
		protected override void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			((QListView) interceptor).DataChanged(topLeft,bottomRight);
		}
		[SmokeMethod("rowsInserted", "(const QModelIndex&, int, int)", "#$$")]
		protected override void RowsInserted(QModelIndex parent, int start, int end) {
			((QListView) interceptor).RowsInserted(parent,start,end);
		}
		[SmokeMethod("rowsAboutToBeRemoved", "(const QModelIndex&, int, int)", "#$$")]
		protected override void RowsAboutToBeRemoved(QModelIndex parent, int start, int end) {
			((QListView) interceptor).RowsAboutToBeRemoved(parent,start,end);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected override void MouseMoveEvent(QMouseEvent e) {
			((QListView) interceptor).MouseMoveEvent(e);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected override void MouseReleaseEvent(QMouseEvent e) {
			((QListView) interceptor).MouseReleaseEvent(e);
		}
		[SmokeMethod("timerEvent", "(QTimerEvent*)", "#")]
		protected override void TimerEvent(QTimerEvent e) {
			((QListView) interceptor).TimerEvent(e);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent e) {
			((QListView) interceptor).ResizeEvent(e);
		}
		[SmokeMethod("dragMoveEvent", "(QDragMoveEvent*)", "#")]
		protected override void DragMoveEvent(QDragMoveEvent e) {
			((QListView) interceptor).DragMoveEvent(e);
		}
		[SmokeMethod("dragLeaveEvent", "(QDragLeaveEvent*)", "#")]
		protected override void DragLeaveEvent(QDragLeaveEvent e) {
			((QListView) interceptor).DragLeaveEvent(e);
		}
		[SmokeMethod("dropEvent", "(QDropEvent*)", "#")]
		protected override void DropEvent(QDropEvent e) {
			((QListView) interceptor).DropEvent(e);
		}
		[SmokeMethod("startDrag", "(Qt::DropActions)", "$")]
		protected override void StartDrag(int supportedActions) {
			((QListView) interceptor).StartDrag(supportedActions);
		}
		[SmokeMethod("internalDrop", "(QDropEvent*)", "#")]
		protected void InternalDrop(QDropEvent e) {
			((QListView) interceptor).InternalDrop(e);
		}
		[SmokeMethod("internalDrag", "(Qt::DropActions)", "$")]
		protected void InternalDrag(int supportedActions) {
			((QListView) interceptor).InternalDrag(supportedActions);
		}
		[SmokeMethod("viewOptions", "() const", "")]
		protected override QStyleOptionViewItem ViewOptions() {
			return ((QListView) interceptor).ViewOptions();
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent e) {
			((QListView) interceptor).PaintEvent(e);
		}
		[SmokeMethod("horizontalOffset", "() const", "")]
		protected override int HorizontalOffset() {
			return ((QListView) interceptor).HorizontalOffset();
		}
		[SmokeMethod("verticalOffset", "() const", "")]
		protected override int VerticalOffset() {
			return ((QListView) interceptor).VerticalOffset();
		}
		[SmokeMethod("moveCursor", "(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)", "$$")]
		protected override QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, int modifiers) {
			return ((QListView) interceptor).MoveCursor(cursorAction,modifiers);
		}
		[SmokeMethod("rectForIndex", "(const QModelIndex&) const", "#")]
		protected QRect RectForIndex(QModelIndex index) {
			return ((QListView) interceptor).RectForIndex(index);
		}
		[SmokeMethod("setPositionForIndex", "(const QPoint&, const QModelIndex&)", "##")]
		protected void SetPositionForIndex(QPoint position, QModelIndex index) {
			((QListView) interceptor).SetPositionForIndex(position,index);
		}
		[SmokeMethod("setSelection", "(const QRect&, QItemSelectionModel::SelectionFlags)", "#$")]
		protected override void SetSelection(QRect rect, int command) {
			((QListView) interceptor).SetSelection(rect,command);
		}
		[SmokeMethod("visualRegionForSelection", "(const QItemSelection&) const", "#")]
		protected override QRegion VisualRegionForSelection(QItemSelection selection) {
			return ((QListView) interceptor).VisualRegionForSelection(selection);
		}
		[SmokeMethod("selectedIndexes", "() const", "")]
		protected override List<QModelIndex> SelectedIndexes() {
			return ((QListView) interceptor).SelectedIndexes();
		}
		[SmokeMethod("updateGeometries", "()", "")]
		protected override void UpdateGeometries() {
			((QListView) interceptor).UpdateGeometries();
		}
		[SmokeMethod("isIndexHidden", "(const QModelIndex&) const", "#")]
		protected override bool IsIndexHidden(QModelIndex index) {
			return ((QListView) interceptor).IsIndexHidden(index);
		}
		~QListView() {
			DisposeQListView();
		}
		public new void Dispose() {
			DisposeQListView();
		}
		[SmokeMethod("~QListView", "()", "")]
		private void DisposeQListView() {
			((QListView) interceptor).DisposeQListView();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQListViewSignals Emit {
			get { return (IQListViewSignals) Q_EMIT; }
		}
	}

	public interface IQListViewSignals : IQAbstractItemViewSignals {
		[Q_SIGNAL("void indexesMoved(const QModelIndexList&)")]
		void IndexesMoved(List<QModelIndex> indexes);
	}
}
