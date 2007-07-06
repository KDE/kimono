//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///   This action provides two states: checked or not.
	///  </remarks>		<short> Checkbox like action. </short>

	[SmokeClass("KToggleAction")]
	public class KToggleAction : KAction, IDisposable {
 		protected KToggleAction(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KToggleAction), this);
		}
		/// <remarks>
		///  Constructs an action with the specified parent.
		/// <param> name="parent" The action's parent object.
		///      </param></remarks>		<short>    Constructs an action with the specified parent.</short>
		public KToggleAction(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KToggleAction#", "KToggleAction(QObject*)", typeof(void), typeof(QObject), parent);
		}
		/// <remarks>
		///  Constructs an action with text; a shortcut may be specified by
		///  the ampersand character (e.g. "&amp;Option" creates a shortcut with key \e O )
		///  This is the most common KAction used when you do not have a
		///  corresponding icon (note that it won't appear in the current version
		///  of the "Edit ToolBar" dialog, because an action needs an icon to be
		///  plugged in a toolbar...).
		/// <param> name="text" The text that will be displayed.
		/// </param><param> name="parent" The action's parent object.
		///      </param></remarks>		<short>    Constructs an action with text; a shortcut may be specified by  the ampersand character (e.</short>
		public KToggleAction(string text, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KToggleAction$#", "KToggleAction(const QString&, QObject*)", typeof(void), typeof(string), text, typeof(QObject), parent);
		}
		/// <remarks>
		///  Constructs an action with text and an icon; a shortcut may be specified by
		///  the ampersand character (e.g. "&amp;Option" creates a shortcut with key \e O )
		///  This is the other common KAction used.  Use it when you
		///  \e do have a corresponding icon.
		/// <param> name="icon" The icon to display.
		/// </param><param> name="text" The text that will be displayed.
		/// </param><param> name="parent" The action's parent object.
		///      </param></remarks>		<short>    Constructs an action with text and an icon; a shortcut may be specified by  the ampersand character (e.</short>
		public KToggleAction(KIcon icon, string text, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KToggleAction#$#", "KToggleAction(const KIcon&, const QString&, QObject*)", typeof(void), typeof(KIcon), icon, typeof(string), text, typeof(QObject), parent);
		}
		/// <remarks>
		///  Defines the text (and icon, tooltip, whatsthis) that should be displayed
		///  instead of the normal text, when the action is checked.
		///  Note that this does <em>not</em> replace the check box in front of the
		///  menu.  So you should not use it to replace the text "Show <foo>" with
		///  "Hide <foo>", for example.
		///  If hasIcon(), the icon is kept for the 'checked state', unless
		///  <code>checkedItem</code> defines an icon explicitly. Same thing for tooltip and whatsthis.
		///      </remarks>		<short>    Defines the text (and icon, tooltip, whatsthis) that should be displayed  instead of the normal text, when the action is checked.</short>
		public void SetCheckedState(KGuiItem checkedItem) {
			interceptor.Invoke("setCheckedState#", "setCheckedState(const KGuiItem&)", typeof(void), typeof(KGuiItem), checkedItem);
		}
		[Q_SLOT("void slotToggled(bool)")]
		[SmokeMethod("slotToggled(bool)")]
		protected virtual void SlotToggled(bool arg1) {
			interceptor.Invoke("slotToggled$", "slotToggled(bool)", typeof(void), typeof(bool), arg1);
		}
		~KToggleAction() {
			interceptor.Invoke("~KToggleAction", "~KToggleAction()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KToggleAction", "~KToggleAction()", typeof(void));
		}
		protected new IKToggleActionSignals Emit {
			get { return (IKToggleActionSignals) Q_EMIT; }
		}
	}

	public interface IKToggleActionSignals : IKActionSignals {
	}
}