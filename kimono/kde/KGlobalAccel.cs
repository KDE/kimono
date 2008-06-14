//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  KGlobalAccel allows you to have global accelerators that are independent of
	///  the focused window.  Unlike regular shortcuts, the application's window does not need focus
	///  for them to be activated.
	/// </remarks>		<short> Configurable global shortcut support.</short>
	/// 		<see> KKeyChooser</see>
	/// 		<see> KKeyDialog</see>
	[SmokeClass("KGlobalAccel")]
	public class KGlobalAccel : QObject {
 		protected KGlobalAccel(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KGlobalAccel), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KGlobalAccel() {
			staticInterceptor = new SmokeInvocation(typeof(KGlobalAccel), null);
		}
		/// <remarks>
		///  Checks whether the accelerators are enabled.
		/// </remarks>		<return> true if the KGlobalAccel is enabled
		///      </return>
		/// 		<short>    Checks whether the accelerators are enabled.</short>
		public bool IsEnabled() {
			return (bool) interceptor.Invoke("isEnabled", "isEnabled() const", typeof(bool));
		}
		/// <remarks>
		///  Enables or disables the KGlobalAccel
		/// <param> name="enabled" true if the KGlobalAccel should be enabled, false if it
		///   should be disabled.
		///      </param></remarks>		<short>    Enables or disables the KGlobalAccel </short>
		public void SetEnabled(bool enabled) {
			interceptor.Invoke("setEnabled$", "setEnabled(bool)", typeof(void), typeof(bool), enabled);
		}
		/// <remarks>
		///  Return the unique and common names of all main components that have global shortcuts.
		///  The action strings of the returned actionId stringlists will be empty.
		///      </remarks>		<short>    Return the unique and common names of all main components that have global shortcuts.</short>
		public List<List<string>> AllMainComponents() {
			return (List<List<string>>) interceptor.Invoke("allMainComponents", "allMainComponents()", typeof(List<List<string>>));
		}
		/// <remarks>
		///  Return the full actionIds of all actions with global shortcuts for the main component
		///  specified by actionId. Only the the ComponentUnique part of actionId will be used;
		///  the other members of the actionId List<string> will be ignored.
		///      </remarks>		<short>    Return the full actionIds of all actions with global shortcuts for the main component  specified by actionId.</short>
		public List<List<string>> AllActionsForComponent(List<string> actionId) {
			return (List<List<string>>) interceptor.Invoke("allActionsForComponent?", "allActionsForComponent(const QStringList&)", typeof(List<List<string>>), typeof(List<string>), actionId);
		}
		/// <remarks>
		///  Returns (and creates if necessary) the singleton instance
		///      </remarks>		<short>    Returns (and creates if necessary) the singleton instance      </short>
		public static KGlobalAccel Self() {
			return (KGlobalAccel) staticInterceptor.Invoke("self", "self()", typeof(KGlobalAccel));
		}
		/// <remarks>
		///  Return the name of the action that uses the given key sequence. This applies to
		///  all actions with global shortcuts in any KDE application.
		/// </remarks>		<short>    Return the name of the action that uses the given key sequence.</short>
		/// 		<see> promptStealShortcutSystemwide</see>
		/// 		<see> stealShorctutSystemwide</see>
		public static List<string> FindActionNameSystemwide(QKeySequence seq) {
			return (List<string>) staticInterceptor.Invoke("findActionNameSystemwide#", "findActionNameSystemwide(const QKeySequence&)", typeof(List<string>), typeof(QKeySequence), seq);
		}
		/// <remarks>
		///  Show a messagebox to inform the user that a global shorcut is already occupied,
		///  and ask to take it away from its current action. This is GUI only, so nothing will
		///  be actually changed.
		/// </remarks>		<short>    Show a messagebox to inform the user that a global shorcut is already occupied,  and ask to take it away from its current action.</short>
		/// 		<see> stealShorctutSystemwide</see>
		public static bool PromptStealShortcutSystemwide(QWidget parent, List<string> actionIdentifier, QKeySequence seq) {
			return (bool) staticInterceptor.Invoke("promptStealShortcutSystemwide#?#", "promptStealShortcutSystemwide(QWidget*, const QStringList&, const QKeySequence&)", typeof(bool), typeof(QWidget), parent, typeof(List<string>), actionIdentifier, typeof(QKeySequence), seq);
		}
		/// <remarks>
		///  Take away the given shortcut from the named action it belongs to.
		///  This applies to all actions with global shortcuts in any KDE application.
		/// </remarks>		<short>    Take away the given shortcut from the named action it belongs to.</short>
		/// 		<see> promptStealShortcutSystemwide</see>
		public static void StealShortcutSystemwide(QKeySequence seq) {
			staticInterceptor.Invoke("stealShortcutSystemwide#", "stealShortcutSystemwide(const QKeySequence&)", typeof(void), typeof(QKeySequence), seq);
		}
		protected new IKGlobalAccelSignals Emit {
			get { return (IKGlobalAccelSignals) Q_EMIT; }
		}
	}

	public interface IKGlobalAccelSignals : IQObjectSignals {
	}
}
