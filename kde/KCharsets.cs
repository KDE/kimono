//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    /// <remarks>
    ///  Charset font and encoder/decoder handling.
    ///  This is needed, because Qt's encoding name matching in
    ///  QTextCodec.CodecForName matches only closely-related encoded names
    ///  but not alternate names, e.g. found in the reality of the Internet.
    ///  </remarks>        <short>    Charset font and encoder/decoder handling.</short>
    [SmokeClass("KCharsets")]
    public class KCharsets : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KCharsets(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KCharsets), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KCharsets() {
            staticInterceptor = new SmokeInvocation(typeof(KCharsets), null);
        }
        /// <remarks>
        ///  Provided for compatibility.
        /// <param> name="name" the name of the codec
        /// </param></remarks>        <return> the QTextCodec. If the desired codec could not be found,
        ///          it returns a default (ISO 8859-1) codec
        ///      </return>
        ///         <short>    Provided for compatibility.</short>
        public QTextCodec CodecForName(string name) {
            return (QTextCodec) interceptor.Invoke("codecForName$", "codecForName(const QString&) const", typeof(QTextCodec), typeof(string), name);
        }
        /// <remarks>
        ///  Tries to find a QTextCodec to convert the given encoding from and to
        ///  Unicode.
        ///  If no codec could be found, the ISO 8859-1 codec will be returned an
        ///  and <code>ok</code> will be set to false.
        /// <param> name="ok" true if a matching codec has been found, false if not
        /// </param></remarks>        <return> the QTextCodec. If the desired codec could not be found,
        ///          it returns a default (ISO 8859-1) codec
        ///      </return>
        ///         <short>    Tries to find a QTextCodec to convert the given encoding from and to  Unicode.</short>
        public QTextCodec CodecForName(string n, bool ok) {
            return (QTextCodec) interceptor.Invoke("codecForName$$", "codecForName(const QString&, bool&) const", typeof(QTextCodec), typeof(string), n, typeof(bool), ok);
        }
        /// <remarks>
        ///  Lists all available encodings as names.
        /// </remarks>        <return> the list of all encodings
        ///      </return>
        ///         <short>    Lists all available encodings as names.</short>
        public List<string> AvailableEncodingNames() {
            return (List<string>) interceptor.Invoke("availableEncodingNames", "availableEncodingNames() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Lists the available encoding names together with a more descriptive language.
        /// </remarks>        <return> the list of descriptive encoding names
        ///      </return>
        ///         <short>    Lists the available encoding names together with a more descriptive language.</short>
        public List<string> DescriptiveEncodingNames() {
            return (List<string>) interceptor.Invoke("descriptiveEncodingNames", "descriptiveEncodingNames() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Lists the available encoding names grouped by script (or language that uses them).
        /// </remarks>        <return> the list of lists consisting of description followed by encoding names (i.e. encodingsByScript().at(i).at(0) is a description for encodingsByScript().at(i).at(k), k>0)
        ///      </return>
        ///         <short>    Lists the available encoding names grouped by script (or language that uses them).</short>
        public List<List<string>> EncodingsByScript() {
            return (List<List<string>>) interceptor.Invoke("encodingsByScript", "encodingsByScript() const", typeof(List<List<string>>));
        }
        /// <remarks>
        ///  @brief Returns a long description for an encoding name.
        /// <param> name="encoding" the encoding for the language
        /// </param></remarks>        <return> the long description for the encoding
        ///      </return>
        ///         <short>    @brief Returns a long description for an encoding name.</short>
        public string DescriptionForEncoding(string encoding) {
            return (string) interceptor.Invoke("descriptionForEncoding$", "descriptionForEncoding(const QString&) const", typeof(string), typeof(string), encoding);
        }
        /// <remarks>
        ///  Returns the encoding for a string obtained with descriptiveEncodingNames().
        /// <param> name="descriptiveName" the descriptive name for the encoding
        /// </param></remarks>        <return> the name of the encoding
        ///      </return>
        ///         <short>    Returns the encoding for a string obtained with descriptiveEncodingNames().</short>
        public string EncodingForName(string descriptiveName) {
            return (string) interceptor.Invoke("encodingForName$", "encodingForName(const QString&) const", typeof(string), typeof(string), descriptiveName);
        }
        /// <remarks> Protected constructor. If you need the kcharsets object, use
        ///  KGlobal.Charsets() instead.
        ///     </remarks>        <short>   Protected constructor.</short>
        public KCharsets() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KCharsets", "KCharsets()", typeof(void));
        }
        ~KCharsets() {
            interceptor.Invoke("~KCharsets", "~KCharsets()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KCharsets", "~KCharsets()", typeof(void));
        }
        /// <remarks>
        ///  @brief Converts an entity to a character.
        ///  The string must contain only the
        ///  entity without the trailing ';'.
        /// <param> name="str" the entity
        /// </param></remarks>        <return> QChar.Null if the entity could not be decoded.
        ///      </return>
        ///         <short>    @brief Converts an entity to a character.</short>
        public static QChar FromEntity(string str) {
            return (QChar) staticInterceptor.Invoke("fromEntity$", "fromEntity(const QString&)", typeof(QChar), typeof(string), str);
        }
        /// <remarks>
        ///  Overloaded member function. Tries to find an entity in the
        ///  string str.
        /// <param> name="str" the string containing entified
        /// </param><param> name="len" is a return value, that gives the length of the decoded
        ///  entity.
        /// </param></remarks>        <return> a decoded entity if one could be found, QChar.Null
        ///  otherwise
        ///      </return>
        ///         <short>    Overloaded member function.</short>
        public static QChar FromEntity(string str, ref int len) {
            StackItem[] stack = new StackItem[3];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(str);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(str);
#endif
            stack[2].s_int = len;
            staticInterceptor.Invoke("fromEntity$$", "fromEntity(const QString&, int&)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).SynchronizedFree();
#endif
            len = stack[2].s_int;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).SynchronizedFree();
#endif
            return (QChar) returnValue;
        }
        /// <remarks>
        ///  Converts a QChar to an entity. The returned string does already
        ///  contain the leading '&' and the trailing ';'.
        /// <param> name="ch" the char to convert
        /// </param></remarks>        <return> the entity
        ///      </return>
        ///         <short>    Converts a QChar to an entity.</short>
        public static string ToEntity(QChar ch) {
            return (string) staticInterceptor.Invoke("toEntity#", "toEntity(const QChar&)", typeof(string), typeof(QChar), ch);
        }
        /// <remarks>
        ///  Scans the given string for entities (like &amp;amp;) and resolves them
        ///  using fromEntity.
        /// <param> name="text" the string containing the entities
        /// </param></remarks>        <return> the clean string
        ///      </return>
        ///         <short>    Scans the given string for entities (like &amp;amp;) and resolves them  using fromEntity.</short>
        public static string ResolveEntities(string text) {
            return (string) staticInterceptor.Invoke("resolveEntities$", "resolveEntities(const QString&)", typeof(string), typeof(string), text);
        }
    }
}
