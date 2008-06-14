//Auto-generated by kalyptus. DO NOT EDIT.
namespace Sonnet {
	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks> See <see cref="IHighlighterSignals"></see> for signals emitted by Highlighter
	/// </remarks>
	[SmokeClass("Sonnet::Highlighter")]
	public class Highlighter : QSyntaxHighlighter, IDisposable {
 		protected Highlighter(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Highlighter), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static Highlighter() {
			staticInterceptor = new SmokeInvocation(typeof(Highlighter), null);
		}
		public Highlighter(QTextEdit textEdit, string configFile, QColor col) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Highlighter#$#", "Highlighter(QTextEdit*, const QString&, const QColor&)", typeof(void), typeof(QTextEdit), textEdit, typeof(string), configFile, typeof(QColor), col);
		}
		public Highlighter(QTextEdit textEdit, string configFile) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Highlighter#$", "Highlighter(QTextEdit*, const QString&)", typeof(void), typeof(QTextEdit), textEdit, typeof(string), configFile);
		}
		public Highlighter(QTextEdit textEdit) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Highlighter#", "Highlighter(QTextEdit*)", typeof(void), typeof(QTextEdit), textEdit);
		}
		public bool SpellCheckerFound() {
			return (bool) interceptor.Invoke("spellCheckerFound", "spellCheckerFound() const", typeof(bool));
		}
		public string CurrentLanguage() {
			return (string) interceptor.Invoke("currentLanguage", "currentLanguage() const", typeof(string));
		}
		public void SetCurrentLanguage(string lang) {
			interceptor.Invoke("setCurrentLanguage$", "setCurrentLanguage(const QString&)", typeof(void), typeof(string), lang);
		}
		/// <remarks>
		///  If <code>active</code> is true then spell checking is enabled; otherwise it
		///  is disabled. Note that you have to disable automatic (de)activation
		///  with <see cref="#setAutomatic"></see> before you change the state of spell
		///  checking if you want to persistently enable/disable spell
		///  checking.
		/// <param> name="active" if true, then spell checking is enabled
		/// </param></remarks>		<short> Enable/Disable spell checking. </short>
		/// 		<see> isActive</see>
		/// 		<see> setAutomatic</see>
		public void SetActive(bool active) {
			interceptor.Invoke("setActive$", "setActive(bool)", typeof(void), typeof(bool), active);
		}
		/// <remarks>
		///  Returns the state of spell checking.
		/// </remarks>		<return> true if spell checking is active
		/// </return>
		/// 		<short>    Returns the state of spell checking.</short>
		/// 		<see> setActive</see>
		public bool IsActive() {
			return (bool) interceptor.Invoke("isActive", "isActive() const", typeof(bool));
		}
		public bool Automatic() {
			return (bool) interceptor.Invoke("automatic", "automatic() const", typeof(bool));
		}
		public void SetAutomatic(bool automatic) {
			interceptor.Invoke("setAutomatic$", "setAutomatic(bool)", typeof(void), typeof(bool), automatic);
		}
		/// <remarks>
		///  Adds the given word permanently to the dictionary. It will never
		///  be marked as misspelled again, even after restarting the application.
		/// <param> name="word" the word which will be added to the dictionary
		/// </param></remarks>		<short>    Adds the given word permanently to the dictionary.</short>
		public void AddWordToDictionary(string word) {
			interceptor.Invoke("addWordToDictionary$", "addWordToDictionary(const QString&)", typeof(void), typeof(string), word);
		}
		/// <remarks>
		///  Ignores the given word. This word will not be marked misspelled for
		///  this session. It will again be marked as misspelled when creating
		///  new highlighters.
		/// <param> name="word" the word which will be ignored
		/// </param></remarks>		<short>    Ignores the given word.</short>
		public void IgnoreWord(string word) {
			interceptor.Invoke("ignoreWord$", "ignoreWord(const QString&)", typeof(void), typeof(string), word);
		}
		/// <remarks>
		///  Returns a list of suggested replacements for the given misspelled word.
		///  If the word is not misspelled, the list will be empty.
		/// <param> name="word" the misspelled word
		/// </param><param> name="max" at most this many suggestions will be returned. If this is
		///             -1, as many suggestions as the spell backend supports will
		///             be returned.
		/// </param></remarks>		<return> a list of suggested replacements for the word
		/// </return>
		/// 		<short>    Returns a list of suggested replacements for the given misspelled word.</short>
		public List<string> SuggestionsForWord(string word, int max) {
			return (List<string>) interceptor.Invoke("suggestionsForWord$$", "suggestionsForWord(const QString&, int)", typeof(List<string>), typeof(string), word, typeof(int), max);
		}
		public List<string> SuggestionsForWord(string word) {
			return (List<string>) interceptor.Invoke("suggestionsForWord$", "suggestionsForWord(const QString&)", typeof(List<string>), typeof(string), word);
		}
		/// <remarks>
		///  Checks if a given word is marked as misspelled by the highlighter.
		/// <param> name="word" the word to be checked
		/// </param></remarks>		<return> true if the given word is misspelled.
		/// </return>
		/// 		<short>    Checks if a given word is marked as misspelled by the highlighter.</short>
		public bool IsWordMisspelled(string word) {
			return (bool) interceptor.Invoke("isWordMisspelled$", "isWordMisspelled(const QString&)", typeof(bool), typeof(string), word);
		}
		[Q_SLOT("void slotAutoDetection()")]
		public void SlotAutoDetection() {
			interceptor.Invoke("slotAutoDetection", "slotAutoDetection()", typeof(void));
		}
		[Q_SLOT("void slotRehighlight()")]
		public void SlotRehighlight() {
			interceptor.Invoke("slotRehighlight", "slotRehighlight()", typeof(void));
		}
		[SmokeMethod("highlightBlock(const QString&)")]
		protected override void HighlightBlock(string text) {
			interceptor.Invoke("highlightBlock$", "highlightBlock(const QString&)", typeof(void), typeof(string), text);
		}
		[SmokeMethod("setMisspelled(int, int)")]
		protected virtual void SetMisspelled(int start, int count) {
			interceptor.Invoke("setMisspelled$$", "setMisspelled(int, int)", typeof(void), typeof(int), start, typeof(int), count);
		}
		[SmokeMethod("unsetMisspelled(int, int)")]
		protected virtual void UnsetMisspelled(int start, int count) {
			interceptor.Invoke("unsetMisspelled$$", "unsetMisspelled(int, int)", typeof(void), typeof(int), start, typeof(int), count);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected new virtual bool EventFilter(QObject o, QEvent e) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), o, typeof(QEvent), e);
		}
		protected bool IntraWordEditing() {
			return (bool) interceptor.Invoke("intraWordEditing", "intraWordEditing() const", typeof(bool));
		}
		protected void SetIntraWordEditing(bool editing) {
			interceptor.Invoke("setIntraWordEditing$", "setIntraWordEditing(bool)", typeof(void), typeof(bool), editing);
		}
		~Highlighter() {
			interceptor.Invoke("~Highlighter", "~Highlighter()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Highlighter", "~Highlighter()", typeof(void));
		}
		public static List<string> PersonalWords() {
			return (List<string>) staticInterceptor.Invoke("personalWords", "personalWords()", typeof(List<string>));
		}
		protected new IHighlighterSignals Emit {
			get { return (IHighlighterSignals) Q_EMIT; }
		}
	}

	public interface IHighlighterSignals : IQSyntaxHighlighterSignals {
		/// <remarks>
		///  Emitted when as-you-type spell checking is enabled or disabled.
		/// <param> name="description" is a i18n description of the new state,
		///         with an optional reason
		///          </param></remarks>		<short>    Emitted when as-you-type spell checking is enabled or disabled.</short>
		[Q_SIGNAL("void activeChanged(const QString&)")]
		void ActiveChanged(string description);
	}
}
