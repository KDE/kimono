//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \class KCharMacroExpander kmacroexpander.h <KMacroExpanderBase>
    ///  Abstract base class for single char macro substitutors. Use this instead of
    ///  the functions in the KMacroExpander namespace if speculatively pre-filling
    ///  the substitution map would be too expensive.
    ///  See KWordMacroExpander for a sample application.
    /// </remarks>        <author> Oswald Buddenhagen <ossi@kde.org>
    ///  </author>
    ///         <short>    \class KCharMacroExpander kmacroexpander.</short>
    [SmokeClass("KCharMacroExpander")]
    public abstract class KCharMacroExpander : KMacroExpanderBase {
        protected KCharMacroExpander(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KCharMacroExpander), this);
        }
        /// <remarks>
        ///  Constructor.
        /// <param> name="c" escape char indicating start of macros, or QChar.Null for none
        ///      </param></remarks>        <short>    Constructor.</short>
        public KCharMacroExpander(QChar c) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KCharMacroExpander#", "KCharMacroExpander(QChar)", typeof(void), typeof(QChar), c);
        }
        public KCharMacroExpander() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KCharMacroExpander", "KCharMacroExpander()", typeof(void));
        }
        [SmokeMethod("expandPlainMacro(const QString&, int, QStringList&)")]
        protected override int ExpandPlainMacro(string str, int pos, List<string> ret) {
            return (int) interceptor.Invoke("expandPlainMacro$$?", "expandPlainMacro(const QString&, int, QStringList&)", typeof(int), typeof(string), str, typeof(int), pos, typeof(List<string>), ret);
        }
        [SmokeMethod("expandEscapedMacro(const QString&, int, QStringList&)")]
        protected override int ExpandEscapedMacro(string str, int pos, List<string> ret) {
            return (int) interceptor.Invoke("expandEscapedMacro$$?", "expandEscapedMacro(const QString&, int, QStringList&)", typeof(int), typeof(string), str, typeof(int), pos, typeof(List<string>), ret);
        }
        /// <remarks>
        ///  Return substitution list <code>ret</code> for single-character macro <code>chr.</code>
        /// <param> name="chr" the macro to expand
        /// </param><param> name="ret" return variable reference. It is guaranteed to be empty
        ///   when expandMacro is entered.
        /// </param></remarks>        <return> @c true iff <code>chr</code> was a recognized macro name
        ///      </return>
        ///         <short>    Return substitution list <code>ret</code> for single-character macro <code>chr.</code></short>
        [SmokeMethod("expandMacro(QChar, QStringList&)")]
        protected abstract bool ExpandMacro(QChar chr, List<string> ret);
    }
}
