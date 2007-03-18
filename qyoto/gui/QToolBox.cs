//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQToolBoxSignals"></see> for signals emitted by QToolBox
	[SmokeClass("QToolBox")]
	public class QToolBox : QFrame, IDisposable {
 		protected QToolBox(Type dummy) : base((Type) null) {}
		[SmokeClass("QToolBox")]
		interface IQToolBoxProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolBox), this);
			interceptor = (QToolBox) realProxy.GetTransparentProxy();
		}
		private static IQToolBoxProxy staticInterceptor = null;
		static QToolBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolBoxProxy), null);
			staticInterceptor = (IQToolBoxProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("int", "currentIndex")]
		public int CurrentIndex {
			[SmokeMethod("currentIndex", "()", "")]
			get { return ((QToolBox) interceptor).CurrentIndex; }
			[SmokeMethod("setCurrentIndex", "(int)", "$")]
			set { ((QToolBox) interceptor).CurrentIndex = value; }
		}
		[Q_PROPERTY("int", "count")]
		public int Count {
			[SmokeMethod("count", "()", "")]
			get { return ((QToolBox) interceptor).Count; }
		}
		public QToolBox(QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQToolBox(parent,f);
		}
		[SmokeMethod("QToolBox", "(QWidget*, Qt::WindowFlags)", "#$")]
		private void NewQToolBox(QWidget parent, int f) {
			((QToolBox) interceptor).NewQToolBox(parent,f);
		}
		public QToolBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQToolBox(parent);
		}
		[SmokeMethod("QToolBox", "(QWidget*)", "#")]
		private void NewQToolBox(QWidget parent) {
			((QToolBox) interceptor).NewQToolBox(parent);
		}
		public QToolBox() : this((Type) null) {
			CreateProxy();
			NewQToolBox();
		}
		[SmokeMethod("QToolBox", "()", "")]
		private void NewQToolBox() {
			((QToolBox) interceptor).NewQToolBox();
		}
		[SmokeMethod("addItem", "(QWidget*, const QString&)", "#$")]
		public int AddItem(QWidget widget, string text) {
			return ((QToolBox) interceptor).AddItem(widget,text);
		}
		[SmokeMethod("addItem", "(QWidget*, const QIcon&, const QString&)", "##$")]
		public int AddItem(QWidget widget, QIcon icon, string text) {
			return ((QToolBox) interceptor).AddItem(widget,icon,text);
		}
		[SmokeMethod("insertItem", "(int, QWidget*, const QString&)", "$#$")]
		public int InsertItem(int index, QWidget widget, string text) {
			return ((QToolBox) interceptor).InsertItem(index,widget,text);
		}
		[SmokeMethod("insertItem", "(int, QWidget*, const QIcon&, const QString&)", "$##$")]
		public int InsertItem(int index, QWidget widget, QIcon icon, string text) {
			return ((QToolBox) interceptor).InsertItem(index,widget,icon,text);
		}
		[SmokeMethod("removeItem", "(int)", "$")]
		public void RemoveItem(int index) {
			((QToolBox) interceptor).RemoveItem(index);
		}
		[SmokeMethod("setItemEnabled", "(int, bool)", "$$")]
		public void SetItemEnabled(int index, bool enabled) {
			((QToolBox) interceptor).SetItemEnabled(index,enabled);
		}
		[SmokeMethod("isItemEnabled", "(int) const", "$")]
		public bool IsItemEnabled(int index) {
			return ((QToolBox) interceptor).IsItemEnabled(index);
		}
		[SmokeMethod("setItemText", "(int, const QString&)", "$$")]
		public void SetItemText(int index, string text) {
			((QToolBox) interceptor).SetItemText(index,text);
		}
		[SmokeMethod("itemText", "(int) const", "$")]
		public string ItemText(int index) {
			return ((QToolBox) interceptor).ItemText(index);
		}
		[SmokeMethod("setItemIcon", "(int, const QIcon&)", "$#")]
		public void SetItemIcon(int index, QIcon icon) {
			((QToolBox) interceptor).SetItemIcon(index,icon);
		}
		[SmokeMethod("itemIcon", "(int) const", "$")]
		public QIcon ItemIcon(int index) {
			return ((QToolBox) interceptor).ItemIcon(index);
		}
		[SmokeMethod("setItemToolTip", "(int, const QString&)", "$$")]
		public void SetItemToolTip(int index, string toolTip) {
			((QToolBox) interceptor).SetItemToolTip(index,toolTip);
		}
		[SmokeMethod("itemToolTip", "(int) const", "$")]
		public string ItemToolTip(int index) {
			return ((QToolBox) interceptor).ItemToolTip(index);
		}
		[SmokeMethod("currentWidget", "() const", "")]
		public QWidget CurrentWidget() {
			return ((QToolBox) interceptor).CurrentWidget();
		}
		[SmokeMethod("widget", "(int) const", "$")]
		public QWidget Widget(int index) {
			return ((QToolBox) interceptor).Widget(index);
		}
		[SmokeMethod("indexOf", "(QWidget*) const", "#")]
		public int IndexOf(QWidget widget) {
			return ((QToolBox) interceptor).IndexOf(widget);
		}
		[Q_SLOT("void setCurrentWidget(QWidget*)")]
		[SmokeMethod("setCurrentWidget", "(QWidget*)", "#")]
		public void SetCurrentWidget(QWidget widget) {
			((QToolBox) interceptor).SetCurrentWidget(widget);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected override bool Event(QEvent e) {
			return ((QToolBox) interceptor).Event(e);
		}
		[SmokeMethod("itemInserted", "(int)", "$")]
		protected virtual void ItemInserted(int index) {
			((QToolBox) interceptor).ItemInserted(index);
		}
		[SmokeMethod("itemRemoved", "(int)", "$")]
		protected virtual void ItemRemoved(int index) {
			((QToolBox) interceptor).ItemRemoved(index);
		}
		[SmokeMethod("showEvent", "(QShowEvent*)", "#")]
		protected override void ShowEvent(QShowEvent e) {
			((QToolBox) interceptor).ShowEvent(e);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent arg1) {
			((QToolBox) interceptor).ChangeEvent(arg1);
		}
		~QToolBox() {
			DisposeQToolBox();
		}
		public new void Dispose() {
			DisposeQToolBox();
		}
		[SmokeMethod("~QToolBox", "()", "")]
		private void DisposeQToolBox() {
			((QToolBox) interceptor).DisposeQToolBox();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQToolBoxSignals Emit {
			get { return (IQToolBoxSignals) Q_EMIT; }
		}
	}

	public interface IQToolBoxSignals : IQFrameSignals {
		[Q_SIGNAL("void currentChanged(int)")]
		void CurrentChanged(int index);
	}
}
