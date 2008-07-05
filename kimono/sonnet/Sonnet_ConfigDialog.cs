//Auto-generated by kalyptus. DO NOT EDIT.
namespace Sonnet {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks> See <see cref="IConfigDialogSignals"></see> for signals emitted by ConfigDialog
	/// </remarks>
	[SmokeClass("Sonnet::ConfigDialog")]
	public class ConfigDialog : KDialog, IDisposable {
 		protected ConfigDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(ConfigDialog), this);
		}
		public ConfigDialog(KConfig config, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("ConfigDialog##", "ConfigDialog(KConfig*, QWidget*)", typeof(void), typeof(KConfig), config, typeof(QWidget), parent);
		}
		/// <remarks>
		///  Sets the language/dictionary that will be selected by default
		///  in this config dialog.
		///  This overrides the setting in the config file.
		/// <param> name="language" the language which will be selected by default.
		/// </param></remarks>		<short>    Sets the language/dictionary that will be selected by default  in this config dialog.</short>
		public void SetLanguage(string language) {
			interceptor.Invoke("setLanguage$", "setLanguage(const QString&)", typeof(void), typeof(string), language);
		}
		[Q_SLOT("void slotOk()")]
		[SmokeMethod("slotOk()")]
		protected virtual void SlotOk() {
			interceptor.Invoke("slotOk", "slotOk()", typeof(void));
		}
		[Q_SLOT("void slotApply()")]
		[SmokeMethod("slotApply()")]
		protected virtual void SlotApply() {
			interceptor.Invoke("slotApply", "slotApply()", typeof(void));
		}
		~ConfigDialog() {
			interceptor.Invoke("~ConfigDialog", "~ConfigDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~ConfigDialog", "~ConfigDialog()", typeof(void));
		}
		protected new IConfigDialogSignals Emit {
			get { return (IConfigDialogSignals) Q_EMIT; }
		}
	}

	public interface IConfigDialogSignals : IKDialogSignals {
		/// <remarks>
		///  This is emitted when the user closed the dialog (and did not
		///  cancel it).
		/// <param> name="language" the language which the user has selected
		/// </param></remarks>		<short>    This is emitted when the user closed the dialog (and did not  cancel it).</short>
		[Q_SIGNAL("void languageChanged(QString)")]
		void LanguageChanged(string language);
	}
}
