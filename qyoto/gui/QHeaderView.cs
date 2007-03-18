//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQHeaderViewSignals"></see> for signals emitted by QHeaderView
	[SmokeClass("QHeaderView")]
	public class QHeaderView : QAbstractItemView, IDisposable {
 		protected QHeaderView(Type dummy) : base((Type) null) {}
		[SmokeClass("QHeaderView")]
		interface IQHeaderViewProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHeaderView), this);
			interceptor = (QHeaderView) realProxy.GetTransparentProxy();
		}
		private static IQHeaderViewProxy staticInterceptor = null;
		static QHeaderView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHeaderViewProxy), null);
			staticInterceptor = (IQHeaderViewProxy) realProxy.GetTransparentProxy();
		}
		public enum ResizeMode {
			Interactive = 0,
			Stretch = 1,
			Fixed = 2,
			ResizeToContents = 3,
			Custom = Fixed,
		}
		[Q_PROPERTY("bool", "showSortIndicator")]
		public bool ShowSortIndicator {
			[SmokeMethod("isSortIndicatorShown", "()", "")]
			get { return ((QHeaderView) interceptor).ShowSortIndicator; }
			[SmokeMethod("setSortIndicatorShown", "(bool)", "$")]
			set { ((QHeaderView) interceptor).ShowSortIndicator = value; }
		}
		[Q_PROPERTY("bool", "highlightSections")]
		public bool HighlightSections {
			[SmokeMethod("highlightSections", "()", "")]
			get { return ((QHeaderView) interceptor).HighlightSections; }
			[SmokeMethod("setHighlightSections", "(bool)", "$")]
			set { ((QHeaderView) interceptor).HighlightSections = value; }
		}
		[Q_PROPERTY("bool", "stretchLastSection")]
		public bool StretchLastSection {
			[SmokeMethod("stretchLastSection", "()", "")]
			get { return ((QHeaderView) interceptor).StretchLastSection; }
			[SmokeMethod("setStretchLastSection", "(bool)", "$")]
			set { ((QHeaderView) interceptor).StretchLastSection = value; }
		}
		[Q_PROPERTY("bool", "cascadingSectionResizes")]
		public bool CascadingSectionResizes {
			[SmokeMethod("cascadingSectionResizes", "()", "")]
			get { return ((QHeaderView) interceptor).CascadingSectionResizes; }
			[SmokeMethod("setCascadingSectionResizes", "(bool)", "$")]
			set { ((QHeaderView) interceptor).CascadingSectionResizes = value; }
		}
		[Q_PROPERTY("int", "defaultSectionSize")]
		public int DefaultSectionSize {
			[SmokeMethod("defaultSectionSize", "()", "")]
			get { return ((QHeaderView) interceptor).DefaultSectionSize; }
			[SmokeMethod("setDefaultSectionSize", "(int)", "$")]
			set { ((QHeaderView) interceptor).DefaultSectionSize = value; }
		}
		[Q_PROPERTY("int", "minimumSectionSize")]
		public int MinimumSectionSize {
			[SmokeMethod("minimumSectionSize", "()", "")]
			get { return ((QHeaderView) interceptor).MinimumSectionSize; }
			[SmokeMethod("setMinimumSectionSize", "(int)", "$")]
			set { ((QHeaderView) interceptor).MinimumSectionSize = value; }
		}
		[Q_PROPERTY("Qt::Alignment", "defaultAlignment")]
		public int DefaultAlignment {
			[SmokeMethod("defaultAlignment", "()", "")]
			get { return ((QHeaderView) interceptor).DefaultAlignment; }
			[SmokeMethod("setDefaultAlignment", "(Qt::Alignment)", "$")]
			set { ((QHeaderView) interceptor).DefaultAlignment = value; }
		}
		public QHeaderView(Qt.Orientation orientation, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQHeaderView(orientation,parent);
		}
		[SmokeMethod("QHeaderView", "(Qt::Orientation, QWidget*)", "$#")]
		private void NewQHeaderView(Qt.Orientation orientation, QWidget parent) {
			((QHeaderView) interceptor).NewQHeaderView(orientation,parent);
		}
		public QHeaderView(Qt.Orientation orientation) : this((Type) null) {
			CreateProxy();
			NewQHeaderView(orientation);
		}
		[SmokeMethod("QHeaderView", "(Qt::Orientation)", "$")]
		private void NewQHeaderView(Qt.Orientation orientation) {
			((QHeaderView) interceptor).NewQHeaderView(orientation);
		}
		[SmokeMethod("setModel", "(QAbstractItemModel*)", "#")]
		public override void SetModel(QAbstractItemModel model) {
			((QHeaderView) interceptor).SetModel(model);
		}
		[SmokeMethod("orientation", "() const", "")]
		public Qt.Orientation Orientation() {
			return ((QHeaderView) interceptor).Orientation();
		}
		[SmokeMethod("offset", "() const", "")]
		public int Offset() {
			return ((QHeaderView) interceptor).Offset();
		}
		[SmokeMethod("length", "() const", "")]
		public int Length() {
			return ((QHeaderView) interceptor).Length();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QHeaderView) interceptor).SizeHint();
		}
		[SmokeMethod("sectionSizeHint", "(int) const", "$")]
		public int SectionSizeHint(int logicalIndex) {
			return ((QHeaderView) interceptor).SectionSizeHint(logicalIndex);
		}
		[SmokeMethod("visualIndexAt", "(int) const", "$")]
		public int VisualIndexAt(int position) {
			return ((QHeaderView) interceptor).VisualIndexAt(position);
		}
		[SmokeMethod("logicalIndexAt", "(int) const", "$")]
		public int LogicalIndexAt(int position) {
			return ((QHeaderView) interceptor).LogicalIndexAt(position);
		}
		[SmokeMethod("logicalIndexAt", "(int, int) const", "$$")]
		public int LogicalIndexAt(int x, int y) {
			return ((QHeaderView) interceptor).LogicalIndexAt(x,y);
		}
		[SmokeMethod("logicalIndexAt", "(const QPoint&) const", "#")]
		public int LogicalIndexAt(QPoint pos) {
			return ((QHeaderView) interceptor).LogicalIndexAt(pos);
		}
		[SmokeMethod("sectionSize", "(int) const", "$")]
		public int SectionSize(int logicalIndex) {
			return ((QHeaderView) interceptor).SectionSize(logicalIndex);
		}
		[SmokeMethod("sectionPosition", "(int) const", "$")]
		public int SectionPosition(int logicalIndex) {
			return ((QHeaderView) interceptor).SectionPosition(logicalIndex);
		}
		[SmokeMethod("sectionViewportPosition", "(int) const", "$")]
		public int SectionViewportPosition(int logicalIndex) {
			return ((QHeaderView) interceptor).SectionViewportPosition(logicalIndex);
		}
		[SmokeMethod("moveSection", "(int, int)", "$$")]
		public void MoveSection(int from, int to) {
			((QHeaderView) interceptor).MoveSection(from,to);
		}
		[SmokeMethod("swapSections", "(int, int)", "$$")]
		public void SwapSections(int first, int second) {
			((QHeaderView) interceptor).SwapSections(first,second);
		}
		[SmokeMethod("resizeSection", "(int, int)", "$$")]
		public void ResizeSection(int logicalIndex, int size) {
			((QHeaderView) interceptor).ResizeSection(logicalIndex,size);
		}
		[SmokeMethod("resizeSections", "(QHeaderView::ResizeMode)", "$")]
		public void ResizeSections(QHeaderView.ResizeMode mode) {
			((QHeaderView) interceptor).ResizeSections(mode);
		}
		[SmokeMethod("isSectionHidden", "(int) const", "$")]
		public bool IsSectionHidden(int logicalIndex) {
			return ((QHeaderView) interceptor).IsSectionHidden(logicalIndex);
		}
		[SmokeMethod("setSectionHidden", "(int, bool)", "$$")]
		public void SetSectionHidden(int logicalIndex, bool hide) {
			((QHeaderView) interceptor).SetSectionHidden(logicalIndex,hide);
		}
		[SmokeMethod("hiddenSectionCount", "() const", "")]
		public int HiddenSectionCount() {
			return ((QHeaderView) interceptor).HiddenSectionCount();
		}
		[SmokeMethod("hideSection", "(int)", "$")]
		public void HideSection(int logicalIndex) {
			((QHeaderView) interceptor).HideSection(logicalIndex);
		}
		[SmokeMethod("showSection", "(int)", "$")]
		public void ShowSection(int logicalIndex) {
			((QHeaderView) interceptor).ShowSection(logicalIndex);
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ((QHeaderView) interceptor).Count();
		}
		[SmokeMethod("visualIndex", "(int) const", "$")]
		public int VisualIndex(int logicalIndex) {
			return ((QHeaderView) interceptor).VisualIndex(logicalIndex);
		}
		[SmokeMethod("logicalIndex", "(int) const", "$")]
		public int LogicalIndex(int visualIndex) {
			return ((QHeaderView) interceptor).LogicalIndex(visualIndex);
		}
		[SmokeMethod("setMovable", "(bool)", "$")]
		public void SetMovable(bool movable) {
			((QHeaderView) interceptor).SetMovable(movable);
		}
		[SmokeMethod("isMovable", "() const", "")]
		public bool IsMovable() {
			return ((QHeaderView) interceptor).IsMovable();
		}
		[SmokeMethod("setClickable", "(bool)", "$")]
		public void SetClickable(bool clickable) {
			((QHeaderView) interceptor).SetClickable(clickable);
		}
		[SmokeMethod("isClickable", "() const", "")]
		public bool IsClickable() {
			return ((QHeaderView) interceptor).IsClickable();
		}
		[SmokeMethod("setResizeMode", "(QHeaderView::ResizeMode)", "$")]
		public void SetResizeMode(QHeaderView.ResizeMode mode) {
			((QHeaderView) interceptor).SetResizeMode(mode);
		}
		[SmokeMethod("setResizeMode", "(int, QHeaderView::ResizeMode)", "$$")]
		public void SetResizeMode(int logicalIndex, QHeaderView.ResizeMode mode) {
			((QHeaderView) interceptor).SetResizeMode(logicalIndex,mode);
		}
		[SmokeMethod("resizeMode", "(int) const", "$")]
		public QHeaderView.ResizeMode resizeMode(int logicalIndex) {
			return ((QHeaderView) interceptor).resizeMode(logicalIndex);
		}
		[SmokeMethod("stretchSectionCount", "() const", "")]
		public int StretchSectionCount() {
			return ((QHeaderView) interceptor).StretchSectionCount();
		}
		[SmokeMethod("setSortIndicatorShown", "(bool)", "$")]
		public void SetSortIndicatorShown(bool show) {
			((QHeaderView) interceptor).SetSortIndicatorShown(show);
		}
		[SmokeMethod("isSortIndicatorShown", "() const", "")]
		public bool IsSortIndicatorShown() {
			return ((QHeaderView) interceptor).IsSortIndicatorShown();
		}
		[SmokeMethod("setSortIndicator", "(int, Qt::SortOrder)", "$$")]
		public void SetSortIndicator(int logicalIndex, Qt.SortOrder order) {
			((QHeaderView) interceptor).SetSortIndicator(logicalIndex,order);
		}
		[SmokeMethod("sortIndicatorSection", "() const", "")]
		public int SortIndicatorSection() {
			return ((QHeaderView) interceptor).SortIndicatorSection();
		}
		[SmokeMethod("sortIndicatorOrder", "() const", "")]
		public Qt.SortOrder SortIndicatorOrder() {
			return ((QHeaderView) interceptor).SortIndicatorOrder();
		}
		[SmokeMethod("doItemsLayout", "()", "")]
		public override void DoItemsLayout() {
			((QHeaderView) interceptor).DoItemsLayout();
		}
		[SmokeMethod("sectionsMoved", "() const", "")]
		public bool SectionsMoved() {
			return ((QHeaderView) interceptor).SectionsMoved();
		}
		[SmokeMethod("sectionsHidden", "() const", "")]
		public bool SectionsHidden() {
			return ((QHeaderView) interceptor).SectionsHidden();
		}
		[Q_SLOT("void setOffset(int)")]
		[SmokeMethod("setOffset", "(int)", "$")]
		public void SetOffset(int offset) {
			((QHeaderView) interceptor).SetOffset(offset);
		}
		[Q_SLOT("void setOffsetToSectionPosition(int)")]
		[SmokeMethod("setOffsetToSectionPosition", "(int)", "$")]
		public void SetOffsetToSectionPosition(int visualIndex) {
			((QHeaderView) interceptor).SetOffsetToSectionPosition(visualIndex);
		}
		[Q_SLOT("void headerDataChanged(Qt::Orientation, int, int)")]
		[SmokeMethod("headerDataChanged", "(Qt::Orientation, int, int)", "$$$")]
		public void HeaderDataChanged(Qt.Orientation orientation, int logicalFirst, int logicalLast) {
			((QHeaderView) interceptor).HeaderDataChanged(orientation,logicalFirst,logicalLast);
		}
		[SmokeMethod("initialize", "()", "")]
		protected void Initialize() {
			((QHeaderView) interceptor).Initialize();
		}
		[SmokeMethod("initializeSections", "()", "")]
		protected void InitializeSections() {
			((QHeaderView) interceptor).InitializeSections();
		}
		[SmokeMethod("initializeSections", "(int, int)", "$$")]
		protected void InitializeSections(int start, int end) {
			((QHeaderView) interceptor).InitializeSections(start,end);
		}
		[SmokeMethod("currentChanged", "(const QModelIndex&, const QModelIndex&)", "##")]
		protected override void CurrentChanged(QModelIndex current, QModelIndex old) {
			((QHeaderView) interceptor).CurrentChanged(current,old);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QHeaderView) interceptor).Event(e);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent e) {
			((QHeaderView) interceptor).PaintEvent(e);
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected override void MousePressEvent(QMouseEvent e) {
			((QHeaderView) interceptor).MousePressEvent(e);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected override void MouseMoveEvent(QMouseEvent e) {
			((QHeaderView) interceptor).MouseMoveEvent(e);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected override void MouseReleaseEvent(QMouseEvent e) {
			((QHeaderView) interceptor).MouseReleaseEvent(e);
		}
		[SmokeMethod("mouseDoubleClickEvent", "(QMouseEvent*)", "#")]
		protected override void MouseDoubleClickEvent(QMouseEvent e) {
			((QHeaderView) interceptor).MouseDoubleClickEvent(e);
		}
		[SmokeMethod("viewportEvent", "(QEvent*)", "#")]
		protected override bool ViewportEvent(QEvent e) {
			return ((QHeaderView) interceptor).ViewportEvent(e);
		}
		[SmokeMethod("paintSection", "(QPainter*, const QRect&, int) const", "##$")]
		protected virtual void PaintSection(QPainter painter, QRect rect, int logicalIndex) {
			((QHeaderView) interceptor).PaintSection(painter,rect,logicalIndex);
		}
		[SmokeMethod("sectionSizeFromContents", "(int) const", "$")]
		protected virtual QSize SectionSizeFromContents(int logicalIndex) {
			return ((QHeaderView) interceptor).SectionSizeFromContents(logicalIndex);
		}
		[SmokeMethod("horizontalOffset", "() const", "")]
		protected override int HorizontalOffset() {
			return ((QHeaderView) interceptor).HorizontalOffset();
		}
		[SmokeMethod("verticalOffset", "() const", "")]
		protected override int VerticalOffset() {
			return ((QHeaderView) interceptor).VerticalOffset();
		}
		[SmokeMethod("updateGeometries", "()", "")]
		protected override void UpdateGeometries() {
			((QHeaderView) interceptor).UpdateGeometries();
		}
		[SmokeMethod("scrollContentsBy", "(int, int)", "$$")]
		protected override void ScrollContentsBy(int dx, int dy) {
			((QHeaderView) interceptor).ScrollContentsBy(dx,dy);
		}
		[SmokeMethod("dataChanged", "(const QModelIndex&, const QModelIndex&)", "##")]
		protected override void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			((QHeaderView) interceptor).DataChanged(topLeft,bottomRight);
		}
		[SmokeMethod("rowsInserted", "(const QModelIndex&, int, int)", "#$$")]
		protected override void RowsInserted(QModelIndex parent, int start, int end) {
			((QHeaderView) interceptor).RowsInserted(parent,start,end);
		}
		[SmokeMethod("visualRect", "(const QModelIndex&) const", "#")]
		public override QRect VisualRect(QModelIndex index) {
			return ((QHeaderView) interceptor).VisualRect(index);
		}
		[SmokeMethod("scrollTo", "(const QModelIndex&, QAbstractItemView::ScrollHint)", "#$")]
		public override void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			((QHeaderView) interceptor).ScrollTo(index,hint);
		}
		[SmokeMethod("indexAt", "(const QPoint&) const", "#")]
		public override QModelIndex IndexAt(QPoint p) {
			return ((QHeaderView) interceptor).IndexAt(p);
		}
		[SmokeMethod("isIndexHidden", "(const QModelIndex&) const", "#")]
		protected override bool IsIndexHidden(QModelIndex index) {
			return ((QHeaderView) interceptor).IsIndexHidden(index);
		}
		[SmokeMethod("moveCursor", "(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)", "$$")]
		protected override QModelIndex MoveCursor(QAbstractItemView.CursorAction arg1, int arg2) {
			return ((QHeaderView) interceptor).MoveCursor(arg1,arg2);
		}
		[SmokeMethod("setSelection", "(const QRect&, QItemSelectionModel::SelectionFlags)", "#$")]
		protected override void SetSelection(QRect arg1, int arg2) {
			((QHeaderView) interceptor).SetSelection(arg1,arg2);
		}
		[SmokeMethod("visualRegionForSelection", "(const QItemSelection&) const", "#")]
		protected override QRegion VisualRegionForSelection(QItemSelection selection) {
			return ((QHeaderView) interceptor).VisualRegionForSelection(selection);
		}
		[Q_SLOT("void updateSection(int)")]
		[SmokeMethod("updateSection", "(int)", "$")]
		protected void UpdateSection(int logicalIndex) {
			((QHeaderView) interceptor).UpdateSection(logicalIndex);
		}
		[Q_SLOT("void resizeSections()")]
		[SmokeMethod("resizeSections", "()", "")]
		protected void ResizeSections() {
			((QHeaderView) interceptor).ResizeSections();
		}
		[Q_SLOT("void sectionsInserted(const QModelIndex&, int, int)")]
		[SmokeMethod("sectionsInserted", "(const QModelIndex&, int, int)", "#$$")]
		protected void SectionsInserted(QModelIndex parent, int logicalFirst, int logicalLast) {
			((QHeaderView) interceptor).SectionsInserted(parent,logicalFirst,logicalLast);
		}
		[Q_SLOT("void sectionsAboutToBeRemoved(const QModelIndex&, int, int)")]
		[SmokeMethod("sectionsAboutToBeRemoved", "(const QModelIndex&, int, int)", "#$$")]
		protected void SectionsAboutToBeRemoved(QModelIndex parent, int logicalFirst, int logicalLast) {
			((QHeaderView) interceptor).SectionsAboutToBeRemoved(parent,logicalFirst,logicalLast);
		}
		~QHeaderView() {
			DisposeQHeaderView();
		}
		public new void Dispose() {
			DisposeQHeaderView();
		}
		[SmokeMethod("~QHeaderView", "()", "")]
		private void DisposeQHeaderView() {
			((QHeaderView) interceptor).DisposeQHeaderView();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQHeaderViewSignals Emit {
			get { return (IQHeaderViewSignals) Q_EMIT; }
		}
	}

	public interface IQHeaderViewSignals : IQAbstractItemViewSignals {
		[Q_SIGNAL("void sectionMoved(int, int, int)")]
		void SectionMoved(int logicalIndex, int oldVisualIndex, int newVisualIndex);
		[Q_SIGNAL("void sectionResized(int, int, int)")]
		void SectionResized(int logicalIndex, int oldSize, int newSize);
		[Q_SIGNAL("void sectionPressed(int)")]
		void SectionPressed(int logicalIndex);
		[Q_SIGNAL("void sectionClicked(int)")]
		void SectionClicked(int logicalIndex);
		[Q_SIGNAL("void sectionDoubleClicked(int)")]
		void SectionDoubleClicked(int logicalIndex);
		[Q_SIGNAL("void sectionCountChanged(int, int)")]
		void SectionCountChanged(int oldCount, int newCount);
		[Q_SIGNAL("void sectionHandleDoubleClicked(int)")]
		void SectionHandleDoubleClicked(int logicalIndex);
		[Q_SIGNAL("void sectionAutoResize(int, QHeaderView::ResizeMode)")]
		void SectionAutoResize(int logicalIndex, QHeaderView.ResizeMode mode);
		[Q_SIGNAL("void geometriesChanged()")]
		void GeometriesChanged();
	}
}
