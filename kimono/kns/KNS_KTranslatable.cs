//Auto-generated by kalyptus. DO NOT EDIT.
namespace KNS {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  KTranslatable is used as a drop-in replacement for string
    ///  whenever human-visible information needs to be stored and this
    ///  information depends on the current language.
    /// </remarks>        <author> Josef Spillner (spillner@kde.org)
    ///  </author>
    ///         <short> String class with multiple localized representations. </short>
    [SmokeClass("KNS::KTranslatable")]
    public class KTranslatable : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KTranslatable(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTranslatable), this);
        }
        /// <remarks>
        ///  Constructor.
        ///      </remarks>        <short>    Constructor.</short>
        public KTranslatable() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTranslatable", "KTranslatable()", typeof(void));
        }
        /// <remarks>
        ///  Constructor.
        ///  Initializes the contents with a single string.
        ///      </remarks>        <short>    Constructor.</short>
        public KTranslatable(string arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTranslatable$", "KTranslatable(const QString&)", typeof(void), typeof(string), arg1);
        }
        public KTranslatable(KNS.KTranslatable arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTranslatable#", "KTranslatable(const KNS::KTranslatable&)", typeof(void), typeof(KNS.KTranslatable), arg1);
        }
        /// <remarks>
        ///  Adds a string to the contents of this object.
        /// <param> name="lang" Language code in 'xx_XX' format
        /// </param><param> name="string" The string to be stored for this language
        ///      </param></remarks>        <short>    Adds a string to the contents of this object.</short>
        public void AddString(string lang, string arg2) {
            interceptor.Invoke("addString$$", "addString(const QString&, const QString&)", typeof(void), typeof(string), lang, typeof(string), arg2);
        }
        /// <remarks>
        ///  Returns the string which matches most closely the current language.
        /// </remarks>        <return> Contents for the current language
        ///      </return>
        ///         <short>    Returns the string which matches most closely the current language.</short>
        public string Representation() {
            return (string) interceptor.Invoke("representation", "representation() const", typeof(string));
        }
        /// <remarks>
        ///  Returns the string which matches most closely the specified language.
        /// <param> name="lang" Language the contents should appear in, in 'xx_XX' format
        /// </param></remarks>        <return> Contents for the specified language
        ///      </return>
        ///         <short>    Returns the string which matches most closely the specified language.</short>
        public string Translated(string lang) {
            return (string) interceptor.Invoke("translated$", "translated(const QString&) const", typeof(string), typeof(string), lang);
        }
        /// <remarks>
        ///  Returns the list of all strings stored for all languages.
        /// </remarks>        <return> All strings stored in this object
        ///      </return>
        ///         <short>    Returns the list of all strings stored for all languages.</short>
        public List<string> Strings() {
            return (List<string>) interceptor.Invoke("strings", "strings() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Returns the list of all languages for which strings are stored.
        /// </remarks>        <return> All languages the content is available for
        ///      </return>
        ///         <short>    Returns the list of all languages for which strings are stored.</short>
        public List<string> Languages() {
            return (List<string>) interceptor.Invoke("languages", "languages() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Returns the language which most likely resembles the current language.
        /// </remarks>        <return> Current language, or one close to it
        ///      </return>
        ///         <short>    Returns the language which most likely resembles the current language.</short>
        public string Language() {
            return (string) interceptor.Invoke("language", "language() const", typeof(string));
        }
        /// <remarks>
        ///  Returns a map of all languages and their strings.
        /// </remarks>        <return> Map of all languages as keys and all strings as values
        ///      </return>
        ///         <short>    Returns a map of all languages and their strings.</short>
        public Dictionary<string, string> Stringmap() {
            return (Dictionary<string, string>) interceptor.Invoke("stringmap", "stringmap() const", typeof(Dictionary<string, string>));
        }
        /// <remarks>
        ///  Returns whether the content provides alternative (translated) strings.
        /// </remarks>        <return> <b></b>rue if contents are translated, <b></b>alse otherwise
        ///      </return>
        ///         <short>    Returns whether the content provides alternative (translated) strings.</short>
        public bool IsTranslated() {
            return (bool) interceptor.Invoke("isTranslated", "isTranslated() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns whether no content is set yet
        /// </remarks>        <return> <b></b>rue if no content has been added yet, <b></b>alse otherwise
        ///      </return>
        ///         <short>    Returns whether no content is set yet </short>
        public bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        ~KTranslatable() {
            interceptor.Invoke("~KTranslatable", "~KTranslatable()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KTranslatable", "~KTranslatable()", typeof(void));
        }
    }
}
