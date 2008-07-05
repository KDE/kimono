//Auto-generated by kalyptus. DO NOT EDIT.
namespace Sonnet {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  <pre>
	///  Sonnet.Dialog = dlg=new Sonnet.Dialog(new Sonnet.BackgroundChecker(
	///           this), this);
	///  //connect signals
	///  ...
	///  dlg.SetBuffer( someText );
	///  dlg.Show();
	///  </pre>
	///  You can change buffer inside a slot connected to done() signal
	///  and spellcheck will continue with new data automatically.
	///       See <see cref="IDialogSignals"></see> for signals emitted by Dialog
	/// </remarks>		<short> Spellcheck dialog.</short>
	[SmokeClass("Sonnet::Dialog")]
	public class Dialog : KDialog, IDisposable {
 		protected Dialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Dialog), this);
		}
		public Dialog(Sonnet.BackgroundChecker checker, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Dialog##", "Dialog(Sonnet::BackgroundChecker*, QWidget*)", typeof(void), typeof(Sonnet.BackgroundChecker), checker, typeof(QWidget), parent);
		}
		public string OriginalBuffer() {
			return (string) interceptor.Invoke("originalBuffer", "originalBuffer() const", typeof(string));
		}
		public string Buffer() {
			return (string) interceptor.Invoke("buffer", "buffer() const", typeof(string));
		}
		public new void Show() {
			interceptor.Invoke("show", "show()", typeof(void));
		}
		public void ActiveAutoCorrect(bool _active) {
			interceptor.Invoke("activeAutoCorrect$", "activeAutoCorrect(bool)", typeof(void), typeof(bool), _active);
		}
		[Q_SLOT("void setBuffer(QString)")]
		public void SetBuffer(string arg1) {
			interceptor.Invoke("setBuffer$", "setBuffer(const QString&)", typeof(void), typeof(string), arg1);
		}
		~Dialog() {
			interceptor.Invoke("~Dialog", "~Dialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Dialog", "~Dialog()", typeof(void));
		}
		protected new IDialogSignals Emit {
			get { return (IDialogSignals) Q_EMIT; }
		}
	}

	public interface IDialogSignals : IKDialogSignals {
		/// <remarks>
		///  The dialog won't be closed if you setBuffer() in slot connected to this signal
		///  Also emitted after stop() signal
		///          </remarks>		<short>    The dialog won't be closed if you setBuffer() in slot connected to this signal </short>
		[Q_SIGNAL("void done(QString)")]
		void Done(string newBuffer);
		[Q_SIGNAL("void misspelling(QString, int)")]
		void Misspelling(string word, int start);
		[Q_SIGNAL("void replace(QString, int, QString)")]
		void Replace(string oldWord, int start, string newWord);
		[Q_SIGNAL("void stop()")]
		void Stop();
		[Q_SIGNAL("void cancel()")]
		void Cancel();
		[Q_SIGNAL("void autoCorrect(QString, QString)")]
		void AutoCorrect(string currentWord, string replaceWord);
		/// <remarks>
		///  Signal sends when spell checking is finished/stopped/completed
		/// </remarks>		<short>    Signal sends when spell checking is finished/stopped/completed </short>
		[Q_SIGNAL("void spellCheckStatus(QString)")]
		void SpellCheckStatus(string arg1);
		/// <remarks>
		///  Emitted when the user changes the language used for spellchecking,
		///  which is shown in a combobox of this dialog.
		/// <param> name="dictionary" the new language the user selected
		/// </param></remarks>		<short>    Emitted when the user changes the language used for spellchecking,  which is shown in a combobox of this dialog.</short>
		[Q_SIGNAL("void languageChanged(QString)")]
		void LanguageChanged(string language);
	}
}
