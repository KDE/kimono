//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  The KShortcutsDialog class is used for configuring dictionaries of key/action
	///  associations for KActionCollection and KGlobalAccel. It uses the KShortcutsEditor widget
	///  and offers buttons to set all keys to defaults and invoke on-line help.
	///  Several static methods are supplied which provide the most convenient interface
	///  to the dialog. The most common and most encouraged use is with KActionCollection.
	///  <pre>
	///  KShortcutsDialog.Configure( actionCollection() );
	///  </pre>
	/// </remarks>		<author> Michael Jansen <kde@michael-jansen.biz>
	///  </author>
	/// 		<short> Dialog for configuration of KActionCollection and KGlobalAccel. </short>
	[SmokeClass("KShortcutsDialog")]
	public class KShortcutsDialog : KDialog, IDisposable {
 		protected KShortcutsDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KShortcutsDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KShortcutsDialog() {
			staticInterceptor = new SmokeInvocation(typeof(KShortcutsDialog), null);
		}
		/// <remarks>
		///  Constructs a KShortcutsDialog as a child of <code>parent.</code>
		///  Set <code>allowLetterShortcuts</code> to false if unmodified alphanumeric
		///  keys ('A', '1', etc.) are not permissible shortcuts.
		/// 	 </remarks>		<short>    Constructs a KShortcutsDialog as a child of <code>parent.</code></short>
		public KShortcutsDialog(uint types, KShortcutsEditor.LetterShortcuts allowLetterShortcuts, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KShortcutsDialog$$#", "KShortcutsDialog(KShortcutsEditor::ActionTypes, KShortcutsEditor::LetterShortcuts, QWidget*)", typeof(void), typeof(uint), types, typeof(KShortcutsEditor.LetterShortcuts), allowLetterShortcuts, typeof(QWidget), parent);
		}
		public KShortcutsDialog(uint types, KShortcutsEditor.LetterShortcuts allowLetterShortcuts) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KShortcutsDialog$$", "KShortcutsDialog(KShortcutsEditor::ActionTypes, KShortcutsEditor::LetterShortcuts)", typeof(void), typeof(uint), types, typeof(KShortcutsEditor.LetterShortcuts), allowLetterShortcuts);
		}
		public KShortcutsDialog(uint types) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KShortcutsDialog$", "KShortcutsDialog(KShortcutsEditor::ActionTypes)", typeof(void), typeof(uint), types);
		}
		public KShortcutsDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KShortcutsDialog", "KShortcutsDialog()", typeof(void));
		}
		/// <remarks>
		///  Add all actions of the collection to the ones displayed and configured
		///  by the dialog.
		/// <param> name="title" the title associated with the collection (if null, the
		///  KAboutData.ProgName() of the collection's componentData is used)
		/// 	 </param></remarks>		<short>    Add all actions of the collection to the ones displayed and configured  by the dialog.</short>
		public void AddCollection(KActionCollection arg1, string title) {
			interceptor.Invoke("addCollection#$", "addCollection(KActionCollection*, const QString&)", typeof(void), typeof(KActionCollection), arg1, typeof(string), title);
		}
		public void AddCollection(KActionCollection arg1) {
			interceptor.Invoke("addCollection#", "addCollection(KActionCollection*)", typeof(void), typeof(KActionCollection), arg1);
		}
		/// <remarks>
		///  Run the dialog and call writeSettings() on the action collections
		///  that were added if <code>bSaveSettings</code> is true.
		/// 	 </remarks>		<short>    Run the dialog and call writeSettings() on the action collections  that were added if <code>bSaveSettings</code> is true.</short>
		public bool Configure(bool saveSettings) {
			return (bool) interceptor.Invoke("configure$", "configure(bool)", typeof(bool), typeof(bool), saveSettings);
		}
		public bool Configure() {
			return (bool) interceptor.Invoke("configure", "configure()", typeof(bool));
		}
		/// <remarks> @see QWidget.SizeHint() </remarks>		<short>   @see QWidget.SizeHint() </short>
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		~KShortcutsDialog() {
			interceptor.Invoke("~KShortcutsDialog", "~KShortcutsDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KShortcutsDialog", "~KShortcutsDialog()", typeof(void));
		}
		/// <remarks>
		///  Pops up a modal dialog for configuring key settings. The new
		///  shortcut settings will become active if the user presses OK.
		/// <param> name="collection" the KActionCollection to configure
		/// </param><param> name="allowLetterShortcuts" set to KShortcutsEditor.LetterShortcutsDisallowed if unmodified alphanumeric
		///   keys ('A', '1', etc.) are not permissible shortcuts.
		/// </param><param> name="parent" the parent widget to attach to
		/// </param><param> name="bSaveSettings" if true, the settings will also be saved back
		///  by calling writeSettings() on the action collections that were added.
		/// </param></remarks>		<return> Accept if the dialog was closed with OK, Reject otherwise.
		/// 	 </return>
		/// 		<short>    Pops up a modal dialog for configuring key settings.</short>
		public static int Configure(KActionCollection collection, KShortcutsEditor.LetterShortcuts allowLetterShortcuts, QWidget parent, bool bSaveSettings) {
			return (int) staticInterceptor.Invoke("configure#$#$", "configure(KActionCollection*, KShortcutsEditor::LetterShortcuts, QWidget*, bool)", typeof(int), typeof(KActionCollection), collection, typeof(KShortcutsEditor.LetterShortcuts), allowLetterShortcuts, typeof(QWidget), parent, typeof(bool), bSaveSettings);
		}
		public static int Configure(KActionCollection collection, KShortcutsEditor.LetterShortcuts allowLetterShortcuts, QWidget parent) {
			return (int) staticInterceptor.Invoke("configure#$#", "configure(KActionCollection*, KShortcutsEditor::LetterShortcuts, QWidget*)", typeof(int), typeof(KActionCollection), collection, typeof(KShortcutsEditor.LetterShortcuts), allowLetterShortcuts, typeof(QWidget), parent);
		}
		public static int Configure(KActionCollection collection, KShortcutsEditor.LetterShortcuts allowLetterShortcuts) {
			return (int) staticInterceptor.Invoke("configure#$", "configure(KActionCollection*, KShortcutsEditor::LetterShortcuts)", typeof(int), typeof(KActionCollection), collection, typeof(KShortcutsEditor.LetterShortcuts), allowLetterShortcuts);
		}
		public static int Configure(KActionCollection collection) {
			return (int) staticInterceptor.Invoke("configure#", "configure(KActionCollection*)", typeof(int), typeof(KActionCollection), collection);
		}
		protected new IKShortcutsDialogSignals Emit {
			get { return (IKShortcutsDialogSignals) Q_EMIT; }
		}
	}

	public interface IKShortcutsDialogSignals : IKDialogSignals {
	}
}
