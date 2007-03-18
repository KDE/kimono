//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQActionSignals"></see> for signals emitted by QAction
	[SmokeClass("QAction")]
	public class QAction : QObject, IDisposable {
 		protected QAction(Type dummy) : base((Type) null) {}
		[SmokeClass("QAction")]
		interface IQActionProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAction), this);
			interceptor = (QAction) realProxy.GetTransparentProxy();
		}
		private static IQActionProxy staticInterceptor = null;
		static QAction() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQActionProxy), null);
			staticInterceptor = (IQActionProxy) realProxy.GetTransparentProxy();
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
		[Q_PROPERTY("bool", "checkable")]
		public bool Checkable {
			[SmokeMethod("isCheckable", "()", "")]
			get { return ((QAction) interceptor).Checkable; }
			[SmokeMethod("setCheckable", "(bool)", "$")]
			set { ((QAction) interceptor).Checkable = value; }
		}
		[Q_PROPERTY("bool", "checked")]
		public bool Checked {
			[SmokeMethod("isChecked", "()", "")]
			get { return ((QAction) interceptor).Checked; }
			[SmokeMethod("setChecked", "(bool)", "$")]
			set { ((QAction) interceptor).Checked = value; }
		}
		[Q_PROPERTY("bool", "enabled")]
		public bool Enabled {
			[SmokeMethod("isEnabled", "()", "")]
			get { return ((QAction) interceptor).Enabled; }
			[SmokeMethod("setEnabled", "(bool)", "$")]
			set { ((QAction) interceptor).Enabled = value; }
		}
		[Q_PROPERTY("QIcon", "icon")]
		public QIcon Icon {
			[SmokeMethod("icon", "()", "")]
			get { return ((QAction) interceptor).Icon; }
			[SmokeMethod("setIcon", "(QIcon)", "#")]
			set { ((QAction) interceptor).Icon = value; }
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			[SmokeMethod("text", "()", "")]
			get { return ((QAction) interceptor).Text; }
			[SmokeMethod("setText", "(QString)", "$")]
			set { ((QAction) interceptor).Text = value; }
		}
		[Q_PROPERTY("QString", "iconText")]
		public string IconText {
			[SmokeMethod("iconText", "()", "")]
			get { return ((QAction) interceptor).IconText; }
			[SmokeMethod("setIconText", "(QString)", "$")]
			set { ((QAction) interceptor).IconText = value; }
		}
		[Q_PROPERTY("QString", "toolTip")]
		public string ToolTip {
			[SmokeMethod("toolTip", "()", "")]
			get { return ((QAction) interceptor).ToolTip; }
			[SmokeMethod("setToolTip", "(QString)", "$")]
			set { ((QAction) interceptor).ToolTip = value; }
		}
		[Q_PROPERTY("QString", "statusTip")]
		public string StatusTip {
			[SmokeMethod("statusTip", "()", "")]
			get { return ((QAction) interceptor).StatusTip; }
			[SmokeMethod("setStatusTip", "(QString)", "$")]
			set { ((QAction) interceptor).StatusTip = value; }
		}
		[Q_PROPERTY("QString", "whatsThis")]
		public string WhatsThis {
			[SmokeMethod("whatsThis", "()", "")]
			get { return ((QAction) interceptor).WhatsThis; }
			[SmokeMethod("setWhatsThis", "(QString)", "$")]
			set { ((QAction) interceptor).WhatsThis = value; }
		}
		[Q_PROPERTY("QFont", "font")]
		public QFont Font {
			[SmokeMethod("font", "()", "")]
			get { return ((QAction) interceptor).Font; }
			[SmokeMethod("setFont", "(QFont)", "#")]
			set { ((QAction) interceptor).Font = value; }
		}
		[Q_PROPERTY("QKeySequence", "shortcut")]
		public QKeySequence Shortcut {
			[SmokeMethod("shortcut", "()", "")]
			get { return ((QAction) interceptor).Shortcut; }
			[SmokeMethod("setShortcut", "(QKeySequence)", "#")]
			set { ((QAction) interceptor).Shortcut = value; }
		}
		[Q_PROPERTY("Qt::ShortcutContext", "shortcutContext")]
		public Qt.ShortcutContext ShortcutContext {
			[SmokeMethod("shortcutContext", "()", "")]
			get { return ((QAction) interceptor).ShortcutContext; }
			[SmokeMethod("setShortcutContext", "(Qt::ShortcutContext)", "$")]
			set { ((QAction) interceptor).ShortcutContext = value; }
		}
		[Q_PROPERTY("bool", "autoRepeat")]
		public bool AutoRepeat {
			[SmokeMethod("autoRepeat", "()", "")]
			get { return ((QAction) interceptor).AutoRepeat; }
			[SmokeMethod("setAutoRepeat", "(bool)", "$")]
			set { ((QAction) interceptor).AutoRepeat = value; }
		}
		[Q_PROPERTY("bool", "visible")]
		public bool Visible {
			[SmokeMethod("isVisible", "()", "")]
			get { return ((QAction) interceptor).Visible; }
			[SmokeMethod("setVisible", "(bool)", "$")]
			set { ((QAction) interceptor).Visible = value; }
		}
		[Q_PROPERTY("QAction::MenuRole", "menuRole")]
		public QAction.MenuRole menuRole {
			[SmokeMethod("menuRole", "()", "")]
			get { return ((QAction) interceptor).menuRole; }
			[SmokeMethod("setMenuRole", "(QAction::MenuRole)", "$")]
			set { ((QAction) interceptor).menuRole = value; }
		}
		public QAction(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAction(parent);
		}
		[SmokeMethod("QAction", "(QObject*)", "#")]
		private void NewQAction(QObject parent) {
			((QAction) interceptor).NewQAction(parent);
		}
		public QAction(string text, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAction(text,parent);
		}
		[SmokeMethod("QAction", "(const QString&, QObject*)", "$#")]
		private void NewQAction(string text, QObject parent) {
			((QAction) interceptor).NewQAction(text,parent);
		}
		public QAction(QIcon icon, string text, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQAction(icon,text,parent);
		}
		[SmokeMethod("QAction", "(const QIcon&, const QString&, QObject*)", "#$#")]
		private void NewQAction(QIcon icon, string text, QObject parent) {
			((QAction) interceptor).NewQAction(icon,text,parent);
		}
		[SmokeMethod("setActionGroup", "(QActionGroup*)", "#")]
		public void SetActionGroup(QActionGroup group) {
			((QAction) interceptor).SetActionGroup(group);
		}
		[SmokeMethod("actionGroup", "() const", "")]
		public QActionGroup ActionGroup() {
			return ((QAction) interceptor).ActionGroup();
		}
		[SmokeMethod("menu", "() const", "")]
		public QMenu Menu() {
			return ((QAction) interceptor).Menu();
		}
		[SmokeMethod("setMenu", "(QMenu*)", "#")]
		public void SetMenu(QMenu menu) {
			((QAction) interceptor).SetMenu(menu);
		}
		[SmokeMethod("setSeparator", "(bool)", "$")]
		public void SetSeparator(bool b) {
			((QAction) interceptor).SetSeparator(b);
		}
		[SmokeMethod("isSeparator", "() const", "")]
		public bool IsSeparator() {
			return ((QAction) interceptor).IsSeparator();
		}
		[SmokeMethod("setShortcuts", "(const QList<QKeySequence>&)", "?")]
		public void SetShortcuts(List<QKeySequence> shortcuts) {
			((QAction) interceptor).SetShortcuts(shortcuts);
		}
		[SmokeMethod("setShortcuts", "(QKeySequence::StandardKey)", "$")]
		public void SetShortcuts(QKeySequence.StandardKey arg1) {
			((QAction) interceptor).SetShortcuts(arg1);
		}
		[SmokeMethod("shortcuts", "() const", "")]
		public List<QKeySequence> Shortcuts() {
			return ((QAction) interceptor).Shortcuts();
		}
		[SmokeMethod("isCheckable", "() const", "")]
		public bool IsCheckable() {
			return ((QAction) interceptor).IsCheckable();
		}
		[SmokeMethod("data", "() const", "")]
		public QVariant Data() {
			return ((QAction) interceptor).Data();
		}
		[SmokeMethod("setData", "(const QVariant&)", "#")]
		public void SetData(QVariant var) {
			((QAction) interceptor).SetData(var);
		}
		[SmokeMethod("isChecked", "() const", "")]
		public bool IsChecked() {
			return ((QAction) interceptor).IsChecked();
		}
		[SmokeMethod("isEnabled", "() const", "")]
		public bool IsEnabled() {
			return ((QAction) interceptor).IsEnabled();
		}
		[SmokeMethod("isVisible", "() const", "")]
		public bool IsVisible() {
			return ((QAction) interceptor).IsVisible();
		}
		[SmokeMethod("activate", "(QAction::ActionEvent)", "$")]
		public void Activate(QAction.ActionEvent arg1) {
			((QAction) interceptor).Activate(arg1);
		}
		[SmokeMethod("showStatusText", "(QWidget*)", "#")]
		public bool ShowStatusText(QWidget widget) {
			return ((QAction) interceptor).ShowStatusText(widget);
		}
		[SmokeMethod("showStatusText", "()", "")]
		public bool ShowStatusText() {
			return ((QAction) interceptor).ShowStatusText();
		}
		[SmokeMethod("parentWidget", "() const", "")]
		public QWidget ParentWidget() {
			return ((QAction) interceptor).ParentWidget();
		}
		[SmokeMethod("associatedWidgets", "() const", "")]
		public List<QWidget> AssociatedWidgets() {
			return ((QAction) interceptor).AssociatedWidgets();
		}
		[Q_SLOT("void trigger()")]
		[SmokeMethod("trigger", "()", "")]
		public void Trigger() {
			((QAction) interceptor).Trigger();
		}
		[Q_SLOT("void hover()")]
		[SmokeMethod("hover", "()", "")]
		public void Hover() {
			((QAction) interceptor).Hover();
		}
		[Q_SLOT("void toggle()")]
		[SmokeMethod("toggle", "()", "")]
		public void Toggle() {
			((QAction) interceptor).Toggle();
		}
		[Q_SLOT("void setDisabled(bool)")]
		[SmokeMethod("setDisabled", "(bool)", "$")]
		public void SetDisabled(bool b) {
			((QAction) interceptor).SetDisabled(b);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected new virtual bool Event(QEvent arg1) {
			return ((QAction) interceptor).Event(arg1);
		}
		~QAction() {
			DisposeQAction();
		}
		public new void Dispose() {
			DisposeQAction();
		}
		[SmokeMethod("~QAction", "()", "")]
		private void DisposeQAction() {
			((QAction) interceptor).DisposeQAction();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQActionSignals Emit {
			get { return (IQActionSignals) Q_EMIT; }
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
