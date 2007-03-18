//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QScrollArea")]
	public class QScrollArea : QAbstractScrollArea, IDisposable {
 		protected QScrollArea(Type dummy) : base((Type) null) {}
		[SmokeClass("QScrollArea")]
		interface IQScrollAreaProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QScrollArea), this);
			interceptor = (QScrollArea) realProxy.GetTransparentProxy();
		}
		private static IQScrollAreaProxy staticInterceptor = null;
		static QScrollArea() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQScrollAreaProxy), null);
			staticInterceptor = (IQScrollAreaProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("bool", "widgetResizable")]
		public bool WidgetResizable {
			[SmokeMethod("widgetResizable", "()", "")]
			get { return ((QScrollArea) interceptor).WidgetResizable; }
			[SmokeMethod("setWidgetResizable", "(bool)", "$")]
			set { ((QScrollArea) interceptor).WidgetResizable = value; }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public int Alignment {
			[SmokeMethod("alignment", "()", "")]
			get { return ((QScrollArea) interceptor).Alignment; }
			[SmokeMethod("setAlignment", "(Qt::Alignment)", "$")]
			set { ((QScrollArea) interceptor).Alignment = value; }
		}
		public QScrollArea(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQScrollArea(parent);
		}
		[SmokeMethod("QScrollArea", "(QWidget*)", "#")]
		private void NewQScrollArea(QWidget parent) {
			((QScrollArea) interceptor).NewQScrollArea(parent);
		}
		public QScrollArea() : this((Type) null) {
			CreateProxy();
			NewQScrollArea();
		}
		[SmokeMethod("QScrollArea", "()", "")]
		private void NewQScrollArea() {
			((QScrollArea) interceptor).NewQScrollArea();
		}
		[SmokeMethod("widget", "() const", "")]
		public QWidget Widget() {
			return ((QScrollArea) interceptor).Widget();
		}
		[SmokeMethod("setWidget", "(QWidget*)", "#")]
		public void SetWidget(QWidget widget) {
			((QScrollArea) interceptor).SetWidget(widget);
		}
		[SmokeMethod("takeWidget", "()", "")]
		public QWidget TakeWidget() {
			return ((QScrollArea) interceptor).TakeWidget();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QScrollArea) interceptor).SizeHint();
		}
		[SmokeMethod("focusNextPrevChild", "(bool)", "$")]
		public new virtual bool FocusNextPrevChild(bool next) {
			return ((QScrollArea) interceptor).FocusNextPrevChild(next);
		}
		[SmokeMethod("ensureVisible", "(int, int, int, int)", "$$$$")]
		public void EnsureVisible(int x, int y, int xmargin, int ymargin) {
			((QScrollArea) interceptor).EnsureVisible(x,y,xmargin,ymargin);
		}
		[SmokeMethod("ensureVisible", "(int, int, int)", "$$$")]
		public void EnsureVisible(int x, int y, int xmargin) {
			((QScrollArea) interceptor).EnsureVisible(x,y,xmargin);
		}
		[SmokeMethod("ensureVisible", "(int, int)", "$$")]
		public void EnsureVisible(int x, int y) {
			((QScrollArea) interceptor).EnsureVisible(x,y);
		}
		[SmokeMethod("ensureWidgetVisible", "(QWidget*, int, int)", "#$$")]
		public void EnsureWidgetVisible(QWidget childWidget, int xmargin, int ymargin) {
			((QScrollArea) interceptor).EnsureWidgetVisible(childWidget,xmargin,ymargin);
		}
		[SmokeMethod("ensureWidgetVisible", "(QWidget*, int)", "#$")]
		public void EnsureWidgetVisible(QWidget childWidget, int xmargin) {
			((QScrollArea) interceptor).EnsureWidgetVisible(childWidget,xmargin);
		}
		[SmokeMethod("ensureWidgetVisible", "(QWidget*)", "#")]
		public void EnsureWidgetVisible(QWidget childWidget) {
			((QScrollArea) interceptor).EnsureWidgetVisible(childWidget);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent arg1) {
			return ((QScrollArea) interceptor).Event(arg1);
		}
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return ((QScrollArea) interceptor).EventFilter(arg1,arg2);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			((QScrollArea) interceptor).ResizeEvent(arg1);
		}
		[SmokeMethod("scrollContentsBy", "(int, int)", "$$")]
		protected override void ScrollContentsBy(int dx, int dy) {
			((QScrollArea) interceptor).ScrollContentsBy(dx,dy);
		}
		~QScrollArea() {
			DisposeQScrollArea();
		}
		public new void Dispose() {
			DisposeQScrollArea();
		}
		[SmokeMethod("~QScrollArea", "()", "")]
		private void DisposeQScrollArea() {
			((QScrollArea) interceptor).DisposeQScrollArea();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQScrollAreaSignals Emit {
			get { return (IQScrollAreaSignals) Q_EMIT; }
		}
	}

	public interface IQScrollAreaSignals : IQAbstractScrollAreaSignals {
	}
}
