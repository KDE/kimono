//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQActionSignals"></see> for signals emitted by QAction
	[SmokeClass("QAction")]
	public class QAction : QObject, IDisposable {
 		protected QAction(Type dummy) : base((Type) null) {}
		interface IQActionProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAction), this);
			_interceptor = (QAction) realProxy.GetTransparentProxy();
		}
		private QAction ProxyQAction() {
			return (QAction) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAction() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQActionProxy), null);
			_staticInterceptor = (IQActionProxy) realProxy.GetTransparentProxy();
		}
		private static IQActionProxy StaticQAction() {
			return (IQActionProxy) _staticInterceptor;
		}

		public enum MenuRole {
			NoRole = 0,
			TextHeuristicRole = 1,
			ApplicationSpecificRole = 2,
			AboutQtRole = 3,
			AboutRole = 4,
			PreferencesRole = 5,
			QuitRole = 6,
		}
		public enum ActionEvent {
			Trigger = 0,
			Hover = 1,
		}
		public bool Checkable {
			get {
				return Property("checkable").Value<bool>();
			}
			set {
				SetProperty("checkable", QVariant.FromValue<bool>(value));
			}
		}
		public bool Checked {
			get {
				return Property("checked").Value<bool>();
			}
			set {
				SetProperty("checked", QVariant.FromValue<bool>(value));
			}
		}
		public bool Enabled {
			get {
				return Property("enabled").Value<bool>();
			}
			set {
				SetProperty("enabled", QVariant.FromValue<bool>(value));
			}
		}
		public QIcon Icon {
			get {
				return Property("icon").Value<QIcon>();
			}
			set {
				SetProperty("icon", QVariant.FromValue<QIcon>(value));
			}
		}
		public string Text {
			get {
				return Property("text").Value<string>();
			}
			set {
				SetProperty("text", QVariant.FromValue<string>(value));
			}
		}
		public string IconText {
			get {
				return Property("iconText").Value<string>();
			}
			set {
				SetProperty("iconText", QVariant.FromValue<string>(value));
			}
		}
		public string ToolTip {
			get {
				return Property("toolTip").Value<string>();
			}
			set {
				SetProperty("toolTip", QVariant.FromValue<string>(value));
			}
		}
		public string StatusTip {
			get {
				return Property("statusTip").Value<string>();
			}
			set {
				SetProperty("statusTip", QVariant.FromValue<string>(value));
			}
		}
		public string WhatsThis {
			get {
				return Property("whatsThis").Value<string>();
			}
			set {
				SetProperty("whatsThis", QVariant.FromValue<string>(value));
			}
		}
		public QFont Font {
			get {
				return Property("font").Value<QFont>();
			}
			set {
				SetProperty("font", QVariant.FromValue<QFont>(value));
			}
		}
		public QKeySequence Shortcut {
			get {
				return Property("shortcut").Value<QKeySequence>();
			}
			set {
				SetProperty("shortcut", QVariant.FromValue<QKeySequence>(value));
			}
		}
		public Qt.ShortcutContext ShortcutContext {
			get {
				return Property("shortcutContext").Value<Qt.ShortcutContext>();
			}
			set {
				SetProperty("shortcutContext", QVariant.FromValue<Qt.ShortcutContext>(value));
			}
		}
		public bool AutoRepeat {
			get {
				return Property("autoRepeat").Value<bool>();
			}
			set {
				SetProperty("autoRepeat", QVariant.FromValue<bool>(value));
			}
		}
		public bool Visible {
			get {
				return Property("visible").Value<bool>();
			}
			set {
				SetProperty("visible", QVariant.FromValue<bool>(value));
			}
		}
		public QAction.MenuRole menuRole {
			get {
				return Property("menuRole").Value<QAction.MenuRole>();
			}
			set {
				SetProperty("menuRole", QVariant.FromValue<QAction.MenuRole>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QAction(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAction(parent);
		}
		[SmokeMethod("QAction(QObject*)")]
		private void NewQAction(QObject parent) {
			ProxyQAction().NewQAction(parent);
		}
		public QAction(string text, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAction(text,parent);
		}
		[SmokeMethod("QAction(const QString&, QObject*)")]
		private void NewQAction(string text, QObject parent) {
			ProxyQAction().NewQAction(text,parent);
		}
		public QAction(QIcon icon, string text, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAction(icon,text,parent);
		}
		[SmokeMethod("QAction(const QIcon&, const QString&, QObject*)")]
		private void NewQAction(QIcon icon, string text, QObject parent) {
			ProxyQAction().NewQAction(icon,text,parent);
		}
		[SmokeMethod("setActionGroup(QActionGroup*)")]
		public void SetActionGroup(QActionGroup group) {
			ProxyQAction().SetActionGroup(group);
		}
		[SmokeMethod("actionGroup() const")]
		public QActionGroup ActionGroup() {
			return ProxyQAction().ActionGroup();
		}
		[SmokeMethod("menu() const")]
		public QMenu Menu() {
			return ProxyQAction().Menu();
		}
		[SmokeMethod("setMenu(QMenu*)")]
		public void SetMenu(QMenu menu) {
			ProxyQAction().SetMenu(menu);
		}
		[SmokeMethod("setSeparator(bool)")]
		public void SetSeparator(bool b) {
			ProxyQAction().SetSeparator(b);
		}
		[SmokeMethod("isSeparator() const")]
		public bool IsSeparator() {
			return ProxyQAction().IsSeparator();
		}
		[SmokeMethod("setShortcuts(const QList<QKeySequence>&)")]
		public void SetShortcuts(List<QKeySequence> shortcuts) {
			ProxyQAction().SetShortcuts(shortcuts);
		}
		[SmokeMethod("setShortcuts(QKeySequence::StandardKey)")]
		public void SetShortcuts(QKeySequence.StandardKey arg1) {
			ProxyQAction().SetShortcuts(arg1);
		}
		[SmokeMethod("shortcuts() const")]
		public List<QKeySequence> Shortcuts() {
			return ProxyQAction().Shortcuts();
		}
		[SmokeMethod("isCheckable() const")]
		public bool IsCheckable() {
			return ProxyQAction().IsCheckable();
		}
		[SmokeMethod("data() const")]
		public QVariant Data() {
			return ProxyQAction().Data();
		}
		[SmokeMethod("setData(const QVariant&)")]
		public void SetData(QVariant var) {
			ProxyQAction().SetData(var);
		}
		[SmokeMethod("isChecked() const")]
		public bool IsChecked() {
			return ProxyQAction().IsChecked();
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQAction().IsEnabled();
		}
		[SmokeMethod("isVisible() const")]
		public bool IsVisible() {
			return ProxyQAction().IsVisible();
		}
		[SmokeMethod("activate(QAction::ActionEvent)")]
		public void Activate(QAction.ActionEvent arg1) {
			ProxyQAction().Activate(arg1);
		}
		[SmokeMethod("showStatusText(QWidget*)")]
		public bool ShowStatusText(QWidget widget) {
			return ProxyQAction().ShowStatusText(widget);
		}
		[SmokeMethod("showStatusText()")]
		public bool ShowStatusText() {
			return ProxyQAction().ShowStatusText();
		}
		[SmokeMethod("parentWidget() const")]
		public QWidget ParentWidget() {
			return ProxyQAction().ParentWidget();
		}
		[SmokeMethod("associatedWidgets() const")]
		public List<QWidget> AssociatedWidgets() {
			return ProxyQAction().AssociatedWidgets();
		}
		[SmokeMethod("trigger()")]
		public void Trigger() {
			ProxyQAction().Trigger();
		}
		[SmokeMethod("hover()")]
		public void Hover() {
			ProxyQAction().Hover();
		}
		[SmokeMethod("toggle()")]
		public void Toggle() {
			ProxyQAction().Toggle();
		}
		[SmokeMethod("setDisabled(bool)")]
		public void SetDisabled(bool b) {
			ProxyQAction().SetDisabled(b);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQAction().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQAction().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQAction().Event(arg1);
		}
		~QAction() {
			DisposeQAction();
		}
		public new void Dispose() {
			DisposeQAction();
		}
		[SmokeMethod("~QAction()")]
		private void DisposeQAction() {
			ProxyQAction().DisposeQAction();
		}
		protected new IQActionSignals Emit {
			get {
				return (IQActionSignals) Q_EMIT;
			}
		}
	}

	public interface IQActionSignals : IQObjectSignals {
		[Q_SIGNAL("void changed()")]
		void Changed();
		[Q_SIGNAL("void triggered(bool)")]
		void Triggered(bool arg1);
		[Q_SIGNAL("void triggered()")]
		void Triggered();
		[Q_SIGNAL("void hovered()")]
		void Hovered();
		[Q_SIGNAL("void toggled(bool)")]
		void Toggled(bool arg1);
	}
}