//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QLayout")]
	public abstract class QLayout : QObject, IQLayoutItem {
 		protected QLayout(Type dummy) : base((Type) null) {}
		[SmokeClass("QLayout")]
		interface IQLayoutProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("closestAcceptableSize", "(const QWidget*, const QSize&)", "##")]
			QSize ClosestAcceptableSize(QWidget w, QSize s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLayout), this);
			interceptor = (QLayout) realProxy.GetTransparentProxy();
		}
		private static IQLayoutProxy staticInterceptor = null;
		static QLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLayoutProxy), null);
			staticInterceptor = (IQLayoutProxy) realProxy.GetTransparentProxy();
		}
		public enum SizeConstraint {
			SetDefaultConstraint = 0,
			SetNoConstraint = 1,
			SetMinimumSize = 2,
			SetFixedSize = 3,
			SetMaximumSize = 4,
			SetMinAndMaxSize = 5,
		}
		[Q_PROPERTY("int", "margin")]
		public int Margin {
			[SmokeMethod("margin", "()", "")]
			get { return ((QLayout) interceptor).Margin; }
			[SmokeMethod("setMargin", "(int)", "$")]
			set { ((QLayout) interceptor).Margin = value; }
		}
		[Q_PROPERTY("int", "spacing")]
		public int Spacing {
			[SmokeMethod("spacing", "()", "")]
			get { return ((QLayout) interceptor).Spacing; }
			[SmokeMethod("setSpacing", "(int)", "$")]
			set { ((QLayout) interceptor).Spacing = value; }
		}
		[Q_PROPERTY("QLayout::SizeConstraint", "sizeConstraint")]
		public QLayout.SizeConstraint sizeConstraint {
			[SmokeMethod("sizeConstraint", "()", "")]
			get { return ((QLayout) interceptor).sizeConstraint; }
			[SmokeMethod("setSizeConstraint", "(QLayout::SizeConstraint)", "$")]
			set { ((QLayout) interceptor).sizeConstraint = value; }
		}
		public QLayout(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQLayout(parent);
		}
		[SmokeMethod("QLayout", "(QWidget*)", "#")]
		private void NewQLayout(QWidget parent) {
			((QLayout) interceptor).NewQLayout(parent);
		}
		public QLayout() : this((Type) null) {
			CreateProxy();
			NewQLayout();
		}
		[SmokeMethod("QLayout", "()", "")]
		private void NewQLayout() {
			((QLayout) interceptor).NewQLayout();
		}
		[SmokeMethod("setAlignment", "(QWidget*, Qt::Alignment)", "#$")]
		public bool SetAlignment(QWidget w, int alignment) {
			return ((QLayout) interceptor).SetAlignment(w,alignment);
		}
		[SmokeMethod("setAlignment", "(QLayout*, Qt::Alignment)", "#$")]
		public bool SetAlignment(QLayout l, int alignment) {
			return ((QLayout) interceptor).SetAlignment(l,alignment);
		}
		[SmokeMethod("setAlignment", "(Qt::Alignment)", "$")]
		public void SetAlignment(int alignment) {
			((QLayout) interceptor).SetAlignment(alignment);
		}
		[SmokeMethod("setMenuBar", "(QWidget*)", "#")]
		public void SetMenuBar(QWidget w) {
			((QLayout) interceptor).SetMenuBar(w);
		}
		[SmokeMethod("menuBar", "() const", "")]
		public QWidget MenuBar() {
			return ((QLayout) interceptor).MenuBar();
		}
		[SmokeMethod("parentWidget", "() const", "")]
		public QWidget ParentWidget() {
			return ((QLayout) interceptor).ParentWidget();
		}
		[SmokeMethod("invalidate", "()", "")]
		public virtual void Invalidate() {
			((QLayout) interceptor).Invalidate();
		}
		[SmokeMethod("geometry", "() const", "")]
		public virtual QRect Geometry() {
			return ((QLayout) interceptor).Geometry();
		}
		[SmokeMethod("activate", "()", "")]
		public bool Activate() {
			return ((QLayout) interceptor).Activate();
		}
		[SmokeMethod("update", "()", "")]
		public void Update() {
			((QLayout) interceptor).Update();
		}
		[SmokeMethod("addWidget", "(QWidget*)", "#")]
		public void AddWidget(QWidget w) {
			((QLayout) interceptor).AddWidget(w);
		}
		[SmokeMethod("addItem", "(QLayoutItem*)", "#")]
		public abstract void AddItem(IQLayoutItem arg1);
		[SmokeMethod("removeWidget", "(QWidget*)", "#")]
		public void RemoveWidget(QWidget w) {
			((QLayout) interceptor).RemoveWidget(w);
		}
		[SmokeMethod("removeItem", "(QLayoutItem*)", "#")]
		public void RemoveItem(IQLayoutItem arg1) {
			((QLayout) interceptor).RemoveItem(arg1);
		}
		[SmokeMethod("expandingDirections", "() const", "")]
		public virtual int ExpandingDirections() {
			return ((QLayout) interceptor).ExpandingDirections();
		}
		[SmokeMethod("minimumSize", "() const", "")]
		public virtual QSize MinimumSize() {
			return ((QLayout) interceptor).MinimumSize();
		}
		[SmokeMethod("maximumSize", "() const", "")]
		public virtual QSize MaximumSize() {
			return ((QLayout) interceptor).MaximumSize();
		}
		[SmokeMethod("setGeometry", "(const QRect&)", "#")]
		public abstract void SetGeometry(QRect arg1);
		[SmokeMethod("itemAt", "(int) const", "$")]
		public abstract IQLayoutItem ItemAt(int index);
		[SmokeMethod("takeAt", "(int)", "$")]
		public abstract IQLayoutItem TakeAt(int index);
		[SmokeMethod("indexOf", "(QWidget*) const", "#")]
		public virtual int IndexOf(QWidget arg1) {
			return ((QLayout) interceptor).IndexOf(arg1);
		}
		[SmokeMethod("count", "() const", "")]
		public abstract int Count();
		[SmokeMethod("isEmpty", "() const", "")]
		public virtual bool IsEmpty() {
			return ((QLayout) interceptor).IsEmpty();
		}
		[SmokeMethod("totalHeightForWidth", "(int) const", "$")]
		public int TotalHeightForWidth(int w) {
			return ((QLayout) interceptor).TotalHeightForWidth(w);
		}
		[SmokeMethod("totalMinimumSize", "() const", "")]
		public QSize TotalMinimumSize() {
			return ((QLayout) interceptor).TotalMinimumSize();
		}
		[SmokeMethod("totalMaximumSize", "() const", "")]
		public QSize TotalMaximumSize() {
			return ((QLayout) interceptor).TotalMaximumSize();
		}
		[SmokeMethod("totalSizeHint", "() const", "")]
		public QSize TotalSizeHint() {
			return ((QLayout) interceptor).TotalSizeHint();
		}
		[SmokeMethod("layout", "()", "")]
		public virtual QLayout Layout() {
			return ((QLayout) interceptor).Layout();
		}
		[SmokeMethod("setEnabled", "(bool)", "$")]
		public void SetEnabled(bool arg1) {
			((QLayout) interceptor).SetEnabled(arg1);
		}
		[SmokeMethod("isEnabled", "() const", "")]
		public bool IsEnabled() {
			return ((QLayout) interceptor).IsEnabled();
		}
		[SmokeMethod("widgetEvent", "(QEvent*)", "#")]
		protected void WidgetEvent(QEvent arg1) {
			((QLayout) interceptor).WidgetEvent(arg1);
		}
		[SmokeMethod("childEvent", "(QChildEvent*)", "#")]
		protected override void ChildEvent(QChildEvent e) {
			((QLayout) interceptor).ChildEvent(e);
		}
		[SmokeMethod("addChildLayout", "(QLayout*)", "#")]
		protected void AddChildLayout(QLayout l) {
			((QLayout) interceptor).AddChildLayout(l);
		}
		[SmokeMethod("addChildWidget", "(QWidget*)", "#")]
		protected void AddChildWidget(QWidget w) {
			((QLayout) interceptor).AddChildWidget(w);
		}
		[SmokeMethod("alignmentRect", "(const QRect&) const", "#")]
		protected QRect AlignmentRect(QRect arg1) {
			return ((QLayout) interceptor).AlignmentRect(arg1);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public abstract QSize SizeHint();
		[SmokeMethod("hasHeightForWidth", "() const", "")]
		public virtual bool HasHeightForWidth() {
			return ((QLayout) interceptor).HasHeightForWidth();
		}
		[SmokeMethod("heightForWidth", "(int) const", "$")]
		public virtual int HeightForWidth(int arg1) {
			return ((QLayout) interceptor).HeightForWidth(arg1);
		}
		[SmokeMethod("minimumHeightForWidth", "(int) const", "$")]
		public virtual int MinimumHeightForWidth(int arg1) {
			return ((QLayout) interceptor).MinimumHeightForWidth(arg1);
		}
		[SmokeMethod("widget", "()", "")]
		public virtual QWidget Widget() {
			return ((QLayout) interceptor).Widget();
		}
		[SmokeMethod("spacerItem", "()", "")]
		public virtual QSpacerItem SpacerItem() {
			return ((QLayout) interceptor).SpacerItem();
		}
		[SmokeMethod("alignment", "() const", "")]
		public int Alignment() {
			return ((QLayout) interceptor).Alignment();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		public static QSize ClosestAcceptableSize(QWidget w, QSize s) {
			return staticInterceptor.ClosestAcceptableSize(w,s);
		}
		protected new IQLayoutSignals Emit {
			get { return (IQLayoutSignals) Q_EMIT; }
		}
	}

	public interface IQLayoutSignals : IQObjectSignals {
	}
}
