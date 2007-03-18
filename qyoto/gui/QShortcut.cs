//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQShortcutSignals"></see> for signals emitted by QShortcut
	[SmokeClass("QShortcut")]
	public class QShortcut : QObject, IDisposable {
 		protected QShortcut(Type dummy) : base((Type) null) {}
		[SmokeClass("QShortcut")]
		interface IQShortcutProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QShortcut), this);
			interceptor = (QShortcut) realProxy.GetTransparentProxy();
		}
		private static IQShortcutProxy staticInterceptor = null;
		static QShortcut() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQShortcutProxy), null);
			staticInterceptor = (IQShortcutProxy) realProxy.GetTransparentProxy();
		}
		[Q_PROPERTY("QKeySequence", "key")]
		public QKeySequence Key {
			[SmokeMethod("key", "()", "")]
			get { return ((QShortcut) interceptor).Key; }
			[SmokeMethod("setKey", "(QKeySequence)", "#")]
			set { ((QShortcut) interceptor).Key = value; }
		}
		[Q_PROPERTY("QString", "whatsThis")]
		public string WhatsThis {
			[SmokeMethod("whatsThis", "()", "")]
			get { return ((QShortcut) interceptor).WhatsThis; }
			[SmokeMethod("setWhatsThis", "(QString)", "$")]
			set { ((QShortcut) interceptor).WhatsThis = value; }
		}
		[Q_PROPERTY("bool", "enabled")]
		public bool Enabled {
			[SmokeMethod("isEnabled", "()", "")]
			get { return ((QShortcut) interceptor).Enabled; }
			[SmokeMethod("setEnabled", "(bool)", "$")]
			set { ((QShortcut) interceptor).Enabled = value; }
		}
		[Q_PROPERTY("bool", "autoRepeat")]
		public bool AutoRepeat {
			[SmokeMethod("autoRepeat", "()", "")]
			get { return ((QShortcut) interceptor).AutoRepeat; }
			[SmokeMethod("setAutoRepeat", "(bool)", "$")]
			set { ((QShortcut) interceptor).AutoRepeat = value; }
		}
		[Q_PROPERTY("Qt::ShortcutContext", "context")]
		public Qt.ShortcutContext Context {
			[SmokeMethod("context", "()", "")]
			get { return ((QShortcut) interceptor).Context; }
			[SmokeMethod("setContext", "(Qt::ShortcutContext)", "$")]
			set { ((QShortcut) interceptor).Context = value; }
		}
		public QShortcut(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQShortcut(parent);
		}
		[SmokeMethod("QShortcut", "(QWidget*)", "#")]
		private void NewQShortcut(QWidget parent) {
			((QShortcut) interceptor).NewQShortcut(parent);
		}
		public QShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember, Qt.ShortcutContext context) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent,member,ambiguousMember,context);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*, const char*, const char*, Qt::ShortcutContext)", "##$$$")]
		private void NewQShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember, Qt.ShortcutContext context) {
			((QShortcut) interceptor).NewQShortcut(key,parent,member,ambiguousMember,context);
		}
		public QShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent,member,ambiguousMember);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*, const char*, const char*)", "##$$")]
		private void NewQShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember) {
			((QShortcut) interceptor).NewQShortcut(key,parent,member,ambiguousMember);
		}
		public QShortcut(QKeySequence key, QWidget parent, string member) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent,member);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*, const char*)", "##$")]
		private void NewQShortcut(QKeySequence key, QWidget parent, string member) {
			((QShortcut) interceptor).NewQShortcut(key,parent,member);
		}
		public QShortcut(QKeySequence key, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*)", "##")]
		private void NewQShortcut(QKeySequence key, QWidget parent) {
			((QShortcut) interceptor).NewQShortcut(key,parent);
		}
		[SmokeMethod("isEnabled", "() const", "")]
		public bool IsEnabled() {
			return ((QShortcut) interceptor).IsEnabled();
		}
		[SmokeMethod("id", "() const", "")]
		public int Id() {
			return ((QShortcut) interceptor).Id();
		}
		[SmokeMethod("parentWidget", "() const", "")]
		public QWidget ParentWidget() {
			return ((QShortcut) interceptor).ParentWidget();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected new virtual bool Event(QEvent e) {
			return ((QShortcut) interceptor).Event(e);
		}
		~QShortcut() {
			DisposeQShortcut();
		}
		public new void Dispose() {
			DisposeQShortcut();
		}
		[SmokeMethod("~QShortcut", "()", "")]
		private void DisposeQShortcut() {
			((QShortcut) interceptor).DisposeQShortcut();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQShortcutSignals Emit {
			get { return (IQShortcutSignals) Q_EMIT; }
		}
	}

	public interface IQShortcutSignals : IQObjectSignals {
		[Q_SIGNAL("void activated()")]
		void Activated();
		[Q_SIGNAL("void activatedAmbiguously()")]
		void ActivatedAmbiguously();
	}
}
