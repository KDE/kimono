//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQTabDialogSignals"></see> for signals emitted by QTabDialog
	[SmokeClass("QTabDialog")]
	public class QTabDialog : QDialog, IDisposable {
 		protected QTabDialog(Type dummy) : base((Type) null) {}
		interface IQTabDialogProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTabDialog), this);
			_interceptor = (QTabDialog) realProxy.GetTransparentProxy();
		}
		private QTabDialog ProxyQTabDialog() {
			return (QTabDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTabDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTabDialogProxy), null);
			_staticInterceptor = (IQTabDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQTabDialogProxy StaticQTabDialog() {
			return (IQTabDialogProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTabDialog().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTabDialog().ClassName();
		}
		public QTabDialog(QWidget parent, string name, bool modal, int f) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTabDialog(parent,name,modal,f);
		}
		[SmokeMethod("QTabDialog(QWidget*, const char*, bool, Qt::WFlags)")]
		private void NewQTabDialog(QWidget parent, string name, bool modal, int f) {
			ProxyQTabDialog().NewQTabDialog(parent,name,modal,f);
		}
		public QTabDialog(QWidget parent, string name, bool modal) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTabDialog(parent,name,modal);
		}
		[SmokeMethod("QTabDialog(QWidget*, const char*, bool)")]
		private void NewQTabDialog(QWidget parent, string name, bool modal) {
			ProxyQTabDialog().NewQTabDialog(parent,name,modal);
		}
		public QTabDialog(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTabDialog(parent,name);
		}
		[SmokeMethod("QTabDialog(QWidget*, const char*)")]
		private void NewQTabDialog(QWidget parent, string name) {
			ProxyQTabDialog().NewQTabDialog(parent,name);
		}
		public QTabDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTabDialog(parent);
		}
		[SmokeMethod("QTabDialog(QWidget*)")]
		private void NewQTabDialog(QWidget parent) {
			ProxyQTabDialog().NewQTabDialog(parent);
		}
		public QTabDialog() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQTabDialog();
		}
		[SmokeMethod("QTabDialog()")]
		private void NewQTabDialog() {
			ProxyQTabDialog().NewQTabDialog();
		}
		[SmokeMethod("show()")]
		public new void Show() {
			ProxyQTabDialog().Show();
		}
		[SmokeMethod("setFont(const QFont&)")]
		public new void SetFont(QFont font) {
			ProxyQTabDialog().SetFont(font);
		}
		[SmokeMethod("addTab(QWidget*, const QString&)")]
		public void AddTab(QWidget arg1, string arg2) {
			ProxyQTabDialog().AddTab(arg1,arg2);
		}
		[SmokeMethod("addTab(QWidget*, const QIconSet&, const QString&)")]
		public void AddTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabDialog().AddTab(child,iconset,label);
		}
		[SmokeMethod("addTab(QWidget*, QTab*)")]
		public void AddTab(QWidget arg1, QTab arg2) {
			ProxyQTabDialog().AddTab(arg1,arg2);
		}
		[SmokeMethod("insertTab(QWidget*, const QString&, int)")]
		public void InsertTab(QWidget arg1, string arg2, int index) {
			ProxyQTabDialog().InsertTab(arg1,arg2,index);
		}
		[SmokeMethod("insertTab(QWidget*, const QString&)")]
		public void InsertTab(QWidget arg1, string arg2) {
			ProxyQTabDialog().InsertTab(arg1,arg2);
		}
		[SmokeMethod("insertTab(QWidget*, const QIconSet&, const QString&, int)")]
		public void InsertTab(QWidget child, QIconSet iconset, string label, int index) {
			ProxyQTabDialog().InsertTab(child,iconset,label,index);
		}
		[SmokeMethod("insertTab(QWidget*, const QIconSet&, const QString&)")]
		public void InsertTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabDialog().InsertTab(child,iconset,label);
		}
		[SmokeMethod("insertTab(QWidget*, QTab*, int)")]
		public void InsertTab(QWidget arg1, QTab arg2, int index) {
			ProxyQTabDialog().InsertTab(arg1,arg2,index);
		}
		[SmokeMethod("insertTab(QWidget*, QTab*)")]
		public void InsertTab(QWidget arg1, QTab arg2) {
			ProxyQTabDialog().InsertTab(arg1,arg2);
		}
		[SmokeMethod("changeTab(QWidget*, const QString&)")]
		public void ChangeTab(QWidget arg1, string arg2) {
			ProxyQTabDialog().ChangeTab(arg1,arg2);
		}
		[SmokeMethod("changeTab(QWidget*, const QIconSet&, const QString&)")]
		public void ChangeTab(QWidget child, QIconSet iconset, string label) {
			ProxyQTabDialog().ChangeTab(child,iconset,label);
		}
		[SmokeMethod("isTabEnabled(QWidget*) const")]
		public bool IsTabEnabled(QWidget arg1) {
			return ProxyQTabDialog().IsTabEnabled(arg1);
		}
		[SmokeMethod("setTabEnabled(QWidget*, bool)")]
		public void SetTabEnabled(QWidget arg1, bool arg2) {
			ProxyQTabDialog().SetTabEnabled(arg1,arg2);
		}
		[SmokeMethod("isTabEnabled(const char*) const")]
		public bool IsTabEnabled(string arg1) {
			return ProxyQTabDialog().IsTabEnabled(arg1);
		}
		[SmokeMethod("setTabEnabled(const char*, bool)")]
		public void SetTabEnabled(string arg1, bool arg2) {
			ProxyQTabDialog().SetTabEnabled(arg1,arg2);
		}
		[SmokeMethod("showPage(QWidget*)")]
		public void ShowPage(QWidget arg1) {
			ProxyQTabDialog().ShowPage(arg1);
		}
		[SmokeMethod("removePage(QWidget*)")]
		public void RemovePage(QWidget arg1) {
			ProxyQTabDialog().RemovePage(arg1);
		}
		[SmokeMethod("tabLabel(QWidget*)")]
		public string TabLabel(QWidget arg1) {
			return ProxyQTabDialog().TabLabel(arg1);
		}
		[SmokeMethod("currentPage() const")]
		public QWidget CurrentPage() {
			return ProxyQTabDialog().CurrentPage();
		}
		[SmokeMethod("setDefaultButton(const QString&)")]
		public void SetDefaultButton(string text) {
			ProxyQTabDialog().SetDefaultButton(text);
		}
		[SmokeMethod("setDefaultButton()")]
		public void SetDefaultButton() {
			ProxyQTabDialog().SetDefaultButton();
		}
		[SmokeMethod("hasDefaultButton() const")]
		public bool HasDefaultButton() {
			return ProxyQTabDialog().HasDefaultButton();
		}
		[SmokeMethod("setHelpButton(const QString&)")]
		public void SetHelpButton(string text) {
			ProxyQTabDialog().SetHelpButton(text);
		}
		[SmokeMethod("setHelpButton()")]
		public void SetHelpButton() {
			ProxyQTabDialog().SetHelpButton();
		}
		[SmokeMethod("hasHelpButton() const")]
		public bool HasHelpButton() {
			return ProxyQTabDialog().HasHelpButton();
		}
		[SmokeMethod("setCancelButton(const QString&)")]
		public void SetCancelButton(string text) {
			ProxyQTabDialog().SetCancelButton(text);
		}
		[SmokeMethod("setCancelButton()")]
		public void SetCancelButton() {
			ProxyQTabDialog().SetCancelButton();
		}
		[SmokeMethod("hasCancelButton() const")]
		public bool HasCancelButton() {
			return ProxyQTabDialog().HasCancelButton();
		}
		[SmokeMethod("setApplyButton(const QString&)")]
		public void SetApplyButton(string text) {
			ProxyQTabDialog().SetApplyButton(text);
		}
		[SmokeMethod("setApplyButton()")]
		public void SetApplyButton() {
			ProxyQTabDialog().SetApplyButton();
		}
		[SmokeMethod("hasApplyButton() const")]
		public bool HasApplyButton() {
			return ProxyQTabDialog().HasApplyButton();
		}
		[SmokeMethod("setOKButton(const QString&)")]
		public void SetOKButton(string text) {
			ProxyQTabDialog().SetOKButton(text);
		}
		[SmokeMethod("setOKButton()")]
		public void SetOKButton() {
			ProxyQTabDialog().SetOKButton();
		}
		[SmokeMethod("setOkButton(const QString&)")]
		public void SetOkButton(string text) {
			ProxyQTabDialog().SetOkButton(text);
		}
		[SmokeMethod("setOkButton()")]
		public void SetOkButton() {
			ProxyQTabDialog().SetOkButton();
		}
		[SmokeMethod("hasOkButton() const")]
		public bool HasOkButton() {
			return ProxyQTabDialog().HasOkButton();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTabDialog().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTabDialog().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTabDialog().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTabDialog().TrUtf8(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQTabDialog().PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQTabDialog().ResizeEvent(arg1);
		}
		[SmokeMethod("styleChange(QStyle&)")]
		public new void StyleChange(QStyle arg1) {
			ProxyQTabDialog().StyleChange(arg1);
		}
		[SmokeMethod("setTabBar(QTabBar*)")]
		protected void SetTabBar(QTabBar arg1) {
			ProxyQTabDialog().SetTabBar(arg1);
		}
		[SmokeMethod("tabBar() const")]
		protected QTabBar TabBar() {
			return ProxyQTabDialog().TabBar();
		}
		~QTabDialog() {
			DisposeQTabDialog();
		}
		public new void Dispose() {
			DisposeQTabDialog();
		}
		private void DisposeQTabDialog() {
			ProxyQTabDialog().DisposeQTabDialog();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTabDialogSignals), this);
			Q_EMIT = (IQTabDialogSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTabDialogSignals Emit() {
			return (IQTabDialogSignals) Q_EMIT;
		}
	}

	public interface IQTabDialogSignals : IQDialogSignals {
		[Q_SIGNAL("void aboutToShow()")]
		void AboutToShow();
		[Q_SIGNAL("void applyButtonPressed()")]
		void ApplyButtonPressed();
		[Q_SIGNAL("void cancelButtonPressed()")]
		void CancelButtonPressed();
		[Q_SIGNAL("void defaultButtonPressed()")]
		void DefaultButtonPressed();
		[Q_SIGNAL("void helpButtonPressed()")]
		void HelpButtonPressed();
		[Q_SIGNAL("void currentChanged(QWidget*)")]
		void CurrentChanged(QWidget arg1);
		[Q_SIGNAL("void selected(const QString&)")]
		void Selected(string arg1);
	}
}
