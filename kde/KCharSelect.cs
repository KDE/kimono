//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  This widget allows the user to select a character of a
    ///  specified font and to browse Unicode information
    ///  \image html kcharselect.png "Character Selection Widget"
    ///  You can specify the font whose characters should be displayed via
    ///  setCurrentFont(). Using the Controls argument in the contructor
    ///  you can create a compact version of KCharSelect if there is not enough
    ///  space and if you don't need all features.
    ///  KCharSelect displays one Unicode block at a time and provides
    ///  categorized access to them. Unicode character names and further details,
    ///  including cross references, are displayed. Additionally, there is a search
    ///  to find characters.
    ///  To get the current selected character, use the currentChar()
    ///  method. You can set the character which should be displayed with
    ///  setCurrentChar().
    ///  See <see cref="IKCharSelectSignals"></see> for signals emitted by KCharSelect
    /// </remarks>        <author> Daniel Laidig <d.laidig@gmx.de>
    ///  </author>
    ///         <short> Character selection widget.</short>
    [SmokeClass("KCharSelect")]
    public class KCharSelect : QWidget, IDisposable {
        protected KCharSelect(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KCharSelect), this);
        }
        /// <remarks>
        ///  Flags to set the shown widgets
        ///      </remarks>        <short>    Flags to set the shown widgets      </short>
        public enum Control {
            SearchLine = 0x01,
            FontCombo = 0x02,
            FontSize = 0x04,
            BlockCombos = 0x08,
            CharacterTable = 0x10,
            DetailBrowser = 0x20,
            AllGuiElements = 65535,
        }
        [Q_PROPERTY("QFont", "currentFont")]
        public QFont CurrentFont {
            get { return (QFont) interceptor.Invoke("currentFont", "currentFont()", typeof(QFont)); }
            set { interceptor.Invoke("setCurrentFont#", "setCurrentFont(QFont)", typeof(void), typeof(QFont), value); }
        }
        [Q_PROPERTY("QChar", "currentChar")]
        public QChar CurrentChar {
            get { return (QChar) interceptor.Invoke("currentChar", "currentChar()", typeof(QChar)); }
            set { interceptor.Invoke("setCurrentChar#", "setCurrentChar(QChar)", typeof(void), typeof(QChar), value); }
        }
        [Q_PROPERTY("QList<QChar>", "displayedChars")]
        public List<QChar> DisplayedChars {
            get { return (List<QChar>) interceptor.Invoke("displayedChars", "displayedChars()", typeof(List<QChar>)); }
        }
        // KCharSelect* KCharSelect(QWidget* arg1,const Controls arg2); >>>> NOT CONVERTED
        public KCharSelect(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KCharSelect#", "KCharSelect(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        /// <remarks>
        ///  Reimplemented.
        ///      </remarks>        <short>    Reimplemented.</short>
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        /// <remarks>
        ///  Highlights the character <code>c.</code> If the character is not displayed, the block is changed.
        ///      </remarks>        <short>    Highlights the character <code>c.</code></short>
        [Q_SLOT("void setCurrentChar(QChar)")]
        public void SetCurrentChar(QChar c) {
            interceptor.Invoke("setCurrentChar#", "setCurrentChar(const QChar&)", typeof(void), typeof(QChar), c);
        }
        /// <remarks>
        ///  Sets the font which is displayed to <code>font</code>
        ///      </remarks>        <short>    Sets the font which is displayed to <code>font</code>      </short>
        [Q_SLOT("void setCurrentFont(QFont)")]
        public void SetCurrentFont(QFont font) {
            interceptor.Invoke("setCurrentFont#", "setCurrentFont(const QFont&)", typeof(void), typeof(QFont), font);
        }
        ~KCharSelect() {
            interceptor.Invoke("~KCharSelect", "~KCharSelect()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KCharSelect", "~KCharSelect()", typeof(void));
        }
        protected new IKCharSelectSignals Emit {
            get { return (IKCharSelectSignals) Q_EMIT; }
        }
    }

    public interface IKCharSelectSignals : IQWidgetSignals {
        /// <remarks>
        ///  A new font is selected or the font size changed.
        ///      </remarks>        <short>    A new font is selected or the font size changed.</short>
        [Q_SIGNAL("void currentFontChanged(QFont)")]
        void CurrentFontChanged(QFont _font);
        /// <remarks>
        ///  The current character is changed.
        ///      </remarks>        <short>    The current character is changed.</short>
        [Q_SIGNAL("void currentCharChanged(QChar)")]
        void CurrentCharChanged(QChar c);
        /// <remarks>
        ///  The currently displayed characters are changed (search results or block).
        ///      </remarks>        <short>    The currently displayed characters are changed (search results or block).</short>
        [Q_SIGNAL("void displayedCharsChanged()")]
        void DisplayedCharsChanged();
        /// <remarks>
        ///  A character is selected to be inserted somewhere.
        ///      </remarks>        <short>    A character is selected to be inserted somewhere.</short>
        [Q_SIGNAL("void charSelected(QChar)")]
        void CharSelected(QChar c);
    }
}