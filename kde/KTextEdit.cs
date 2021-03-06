//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  This is just a little subclass of QTextEdit, implementing
    ///  some standard KDE features, like cursor auto-hiding, configurable
    ///  wheelscrolling (fast-scroll or zoom), spell checking and deleting of entire
    ///  words with Ctrl-Backspace or Ctrl-Delete.
    ///  This text edit provides two ways of spell checking: background checking,
    ///  which will mark incorrectly spelled words red, and a spell check dialog,
    ///  which lets the user check and correct all incorrectly spelled words.
    ///  Basic rule: whenever you want to use QTextEdit, use KTextEdit!
    ///  See <see cref="IKTextEditSignals"></see> for signals emitted by KTextEdit
    /// </remarks>        <author> Carsten Pfeiffer <pfeiffer@kde.org>
    ///  </author>
    ///         <short> A KDE'ified QTextEdit.</short>
    ///         <see> QTextEdit</see>
    [SmokeClass("KTextEdit")]
    public class KTextEdit : QTextEdit, IDisposable {
        protected KTextEdit(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTextEdit), this);
        }
        /// <remarks>
        ///  Constructs a KTextEdit object. See QTextEdit.QTextEdit
        ///  for details.
        ///      </remarks>        <short>    Constructs a KTextEdit object.</short>
        public KTextEdit(string text, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTextEdit$#", "KTextEdit(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
        }
        public KTextEdit(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTextEdit$", "KTextEdit(const QString&)", typeof(void), typeof(string), text);
        }
        /// <remarks>
        ///  Constructs a KTextEdit object. See QTextEdit.QTextEdit
        ///  for details.
        ///      </remarks>        <short>    Constructs a KTextEdit object.</short>
        public KTextEdit(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTextEdit#", "KTextEdit(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KTextEdit() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTextEdit", "KTextEdit()", typeof(void));
        }
        /// <remarks>
        ///  Reimplemented to set a proper "deactivated" background color.
        ///      </remarks>        <short>    Reimplemented to set a proper "deactivated" background color.</short>
        [SmokeMethod("setReadOnly(bool)")]
        public virtual void SetReadOnly(bool readOnly) {
            interceptor.Invoke("setReadOnly$", "setReadOnly(bool)", typeof(void), typeof(bool), readOnly);
        }
        /// <remarks>
        ///  Turns background spell checking for this text edit on or off.
        ///  Note that spell checking is only available in read-writable KTextEdits.
        ///  Enabling spell checking will set back the current highlighter to the one
        ///  returned by createHighlighter().
        /// </remarks>        <short>    Turns background spell checking for this text edit on or off.</short>
        ///         <see> checkSpellingEnabled</see>
        ///         <see> isReadOnly</see>
        ///         <see> setReadOnly</see>
        public void SetCheckSpellingEnabled(bool check) {
            interceptor.Invoke("setCheckSpellingEnabled$", "setCheckSpellingEnabled(bool)", typeof(void), typeof(bool), check);
        }
        /// <remarks>
        ///  Returns true if background spell checking is enabled for this text edit.
        ///  Note that it even returns true if this is a read-only KTextEdit,
        ///  where spell checking is actually disabled.
        ///  By default spell checking is disabled.
        /// </remarks>        <short>    Returns true if background spell checking is enabled for this text edit.</short>
        ///         <see> setCheckSpellingEnabled</see>
        public bool CheckSpellingEnabled() {
            return (bool) interceptor.Invoke("checkSpellingEnabled", "checkSpellingEnabled() const", typeof(bool));
        }
        /// <remarks>
        ///  Selects the characters at the specified position. Any previous
        ///  selection will be lost. The cursor is moved to the first character
        ///  of the new selection.
        /// <param> name="length" The length of the selection, in number of characters
        /// </param><param> name="pos" The position of the first character of the selection
        ///      </param></remarks>        <short>    Selects the characters at the specified position.</short>
        public void HighlightWord(int length, int pos) {
            interceptor.Invoke("highlightWord$$", "highlightWord(int, int)", typeof(void), typeof(int), length, typeof(int), pos);
        }
        /// <remarks>
        ///  Allows to override the config file where the settings for spell checking,
        ///  like the current language or encoding, are stored.
        ///  By default, the global config file (kdeglobals) is used, to share
        ///  spell check settings between all applications.
        ///  This has to be called before any spell checking is initiated.
        /// <param> name="fileName" the URL of the config file which will be used to
        ///                  read spell settings
        ///  @bug this has no effect for the spell dialog, only for the background
        ///       check
        ///      </param></remarks>        <short>    Allows to override the config file where the settings for spell checking,  like the current language or encoding, are stored.</short>
        public void SetSpellCheckingConfigFileName(string fileName) {
            interceptor.Invoke("setSpellCheckingConfigFileName$", "setSpellCheckingConfigFileName(const QString&)", typeof(void), typeof(string), fileName);
        }
        /// <remarks>
        ///  change default language for spell checking dialogbox
        /// </remarks>        <short>    change default language for spell checking dialogbox </short>
        public void SetSpellCheckingLanguage(string language) {
            interceptor.Invoke("setSpellCheckingLanguage$", "setSpellCheckingLanguage(const QString&)", typeof(void), typeof(string), language);
        }
        /// <remarks>
        ///  Allows to create a specific highlighter if reimplemented.
        ///  By default, it creates a normal highlighter, based on the config
        ///  file given to setSpellCheckingConfigFileName().
        ///  This highlighter is set each time spell checking is toggled on by
        ///  calling setCheckSpellingEnabled(), but can later be overridden by calling
        ///  setHighlighter().
        /// </remarks>        <short>    Allows to create a specific highlighter if reimplemented.</short>
        ///         <see> setHighlighter</see>
        ///         <see> highlighter</see>
        ///         <see> setSpellCheckingConfigFileName</see>
        [SmokeMethod("createHighlighter()")]
        public virtual void CreateHighlighter() {
            interceptor.Invoke("createHighlighter", "createHighlighter()", typeof(void));
        }
        /// <remarks>
        ///  Returns the current highlighter, which is 0 if spell checking is disabled.
        ///  The default highlighter is the one created by createHighlighter(), but
        ///  might be overridden by setHighlighter().
        /// </remarks>        <short>    Returns the current highlighter, which is 0 if spell checking is disabled.</short>
        ///         <see> setHighlighter</see>
        ///         <see> createHighlighter</see>
        public Sonnet.Highlighter Highlighter() {
            return (Sonnet.Highlighter) interceptor.Invoke("highlighter", "highlighter() const", typeof(Sonnet.Highlighter));
        }
        /// <remarks>
        ///  Sets a custom backgound spell highlighter for this text edit.
        ///  Normally, the highlighter returned by createHighlighter() will be
        ///  used to detect and highlight incorrectly spelled words, but this
        ///  function allows to set a custom highlighter.
        ///  This has to be called after enabling spell checking with
        ///  setCheckSpellingEnabled(), otherwise it has no effect.
        /// <param> name="highLighter" the new highlighter which will be used now
        ///      </param></remarks>        <short>    Sets a custom backgound spell highlighter for this text edit.</short>
        ///         <see> highlighter</see>
        ///         <see> createHighlighter</see>
        public void SetHighlighter(Sonnet.Highlighter _highLighter) {
            interceptor.Invoke("setHighlighter#", "setHighlighter(Sonnet::Highlighter*)", typeof(void), typeof(Sonnet.Highlighter), _highLighter);
        }
        /// <remarks>
        ///  Return standard KTextEdit popupMenu
        /// </remarks>        <short>    Return standard KTextEdit popupMenu </short>
        public QMenu MousePopupMenu() {
            return (QMenu) interceptor.Invoke("mousePopupMenu", "mousePopupMenu()", typeof(QMenu));
        }
        /// <remarks>
        ///  Enable find replace action.
        /// </remarks>        <short>    Enable find replace action.</short>
        public void EnableFindReplace(bool enabled) {
            interceptor.Invoke("enableFindReplace$", "enableFindReplace(bool)", typeof(void), typeof(bool), enabled);
        }
        /// <remarks>
        ///  Create a modal dialog to check the spelling.  This slot will not return
        ///  until spell checking has been completed.
        ///      </remarks>        <short>    Create a modal dialog to check the spelling.</short>
        [Q_SLOT("void checkSpelling()")]
        public void CheckSpelling() {
            interceptor.Invoke("checkSpelling", "checkSpelling()", typeof(void));
        }
        /// <remarks>
        ///  Create replace dialogbox
        /// </remarks>        <short>    Create replace dialogbox </short>
        [Q_SLOT("void replace()")]
        public void Replace() {
            interceptor.Invoke("replace", "replace()", typeof(void));
        }
        /// <remarks>
        ///  Reimplemented to catch "delete word" shortcut events.
        ///      </remarks>        <short>    Reimplemented to catch "delete word" shortcut events.</short>
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        /// <remarks>
        ///  Reimplemented for internal reasons
        ///      </remarks>        <short>    Reimplemented for internal reasons      </short>
        [SmokeMethod("keyPressEvent(QKeyEvent*)")]
        protected override void KeyPressEvent(QKeyEvent arg1) {
            interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
        }
        /// <remarks>
        ///  Reimplemented to instantiate a KDictSpellingHighlighter, if
        ///  spellchecking is enabled.
        ///      </remarks>        <short>    Reimplemented to instantiate a KDictSpellingHighlighter, if  spellchecking is enabled.</short>
        [SmokeMethod("focusInEvent(QFocusEvent*)")]
        protected override void FocusInEvent(QFocusEvent arg1) {
            interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
        }
        /// <remarks>
        ///  Reimplemented to allow fast-wheelscrolling with Ctrl-Wheel
        ///  or zoom.
        ///      </remarks>        <short>    Reimplemented to allow fast-wheelscrolling with Ctrl-Wheel  or zoom.</short>
        [SmokeMethod("wheelEvent(QWheelEvent*)")]
        protected override void WheelEvent(QWheelEvent arg1) {
            interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
        }
        /// <remarks>
        ///  Deletes a word backwards from the current cursor position,
        ///  if available.
        ///      </remarks>        <short>    Deletes a word backwards from the current cursor position,  if available.</short>
        [SmokeMethod("deleteWordBack()")]
        protected virtual void DeleteWordBack() {
            interceptor.Invoke("deleteWordBack", "deleteWordBack()", typeof(void));
        }
        /// <remarks>
        ///  Deletes a word forwards from the current cursor position,
        ///  if available.
        ///      </remarks>        <short>    Deletes a word forwards from the current cursor position,  if available.</short>
        [SmokeMethod("deleteWordForward()")]
        protected virtual void DeleteWordForward() {
            interceptor.Invoke("deleteWordForward", "deleteWordForward()", typeof(void));
        }
        /// <remarks>
        ///  Reimplemented from QTextEdit to add spelling related items
        ///  when appropriate.
        ///      </remarks>        <short>    Reimplemented from QTextEdit to add spelling related items  when appropriate.</short>
        [SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
        protected override void ContextMenuEvent(QContextMenuEvent arg1) {
            interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
        }
        /// <remarks>
        /// </remarks>        <short>   </short>
        [Q_SLOT("void slotDoReplace()")]
        protected void SlotDoReplace() {
            interceptor.Invoke("slotDoReplace", "slotDoReplace()", typeof(void));
        }
        [Q_SLOT("void slotReplaceNext()")]
        protected void SlotReplaceNext() {
            interceptor.Invoke("slotReplaceNext", "slotReplaceNext()", typeof(void));
        }
        [Q_SLOT("void slotDoFind()")]
        protected void SlotDoFind() {
            interceptor.Invoke("slotDoFind", "slotDoFind()", typeof(void));
        }
        [Q_SLOT("void slotFind()")]
        protected void SlotFind() {
            interceptor.Invoke("slotFind", "slotFind()", typeof(void));
        }
        [Q_SLOT("void slotFindNext()")]
        protected void SlotFindNext() {
            interceptor.Invoke("slotFindNext", "slotFindNext()", typeof(void));
        }
        [Q_SLOT("void slotReplace()")]
        protected void SlotReplace() {
            interceptor.Invoke("slotReplace", "slotReplace()", typeof(void));
        }
        ~KTextEdit() {
            interceptor.Invoke("~KTextEdit", "~KTextEdit()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KTextEdit", "~KTextEdit()", typeof(void));
        }
        protected new IKTextEditSignals Emit {
            get { return (IKTextEditSignals) Q_EMIT; }
        }
    }

    public interface IKTextEditSignals : IQTextEditSignals {
        /// <remarks>
        ///  emit signal when we activate or not autospellchecking
        /// </remarks>        <short>    emit signal when we activate or not autospellchecking </short>
        [Q_SIGNAL("void checkSpellingChanged(bool)")]
        void CheckSpellingChanged(bool arg1);
        /// <remarks>
        ///  Signal sends when spell checking is finished/stopped/completed
        /// </remarks>        <short>    Signal sends when spell checking is finished/stopped/completed </short>
        [Q_SIGNAL("void spellCheckStatus(QString)")]
        void SpellCheckStatus(string arg1);
        /// <remarks>
        ///  Emitted when the user changes the language in the spellcheck dialog
        ///  shown by checkSpelling().
        /// <param> name="language" the new language the user selected
        /// </param></remarks>        <short>    Emitted when the user changes the language in the spellcheck dialog  shown by checkSpelling().</short>
        [Q_SIGNAL("void languageChanged(QString)")]
        void LanguageChanged(string language);
    }
}
