//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  A PIM item consists of one or more parts, allowing a fine-grained access on its
    ///  content where needed (eg. mail envelope, mail body and attachments).
    ///  There is also a namespace (prefix) for special parts which are local to Akonadi.
    ///  These parts, prefixed by "akonadi-" will never be fetched in the resource.
    ///  They are useful for local extensions like agents which might want to add meta data
    ///  to items in order to handle them but the meta data should not be stored back to the
    ///  resource.
    ///  This class contains beside some type-agnostic information (flags, revision)
    ///  a single payload object representing its actual data. Which objects these actually
    ///  are depends on the mimetype of the item and the corresponding serializer plugin.
    ///  This class is implicitly shared.
    /// </remarks>        <author> Volker Krause <vkrause@kde.org>, Till Adam <adam@kde.org>
    ///  </author>
    ///         <short> Represents a PIM item stored in Akonadi storage. </short>
    [SmokeClass("Akonadi::Item")]
    public class Item : Akonadi.Entity, IDisposable {
        protected Item(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Item), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static Item() {
            staticInterceptor = new SmokeInvocation(typeof(Item), null);
        }
        /// <remarks>
        ///  Describes the type of url which is returned in url().
        ///      </remarks>        <short>    Describes the type of url which is returned in url().</short>
        public enum UrlType {
            UrlShort = 0,
            UrlWithMimeType = 1,
        }
        public static string FullPayload() {
            return (string) staticInterceptor.Invoke("FullPayload", "FullPayload()", typeof(string));
        }
        // QSet<QByteArray> flags(); >>>> NOT CONVERTED
        // void setFlags(const QSet<QByteArray>& arg1); >>>> NOT CONVERTED
        // QSet<QByteArray> loadedPayloadParts(); >>>> NOT CONVERTED
        /// <remarks>
        ///  Creates a new item.
        ///      </remarks>        <short>    Creates a new item.</short>
        public Item() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Item", "Item()", typeof(void));
        }
        /// <remarks>
        ///  Creates a new item with the given unique <code>id.</code>
        ///      </remarks>        <short>    Creates a new item with the given unique <code>id.</code></short>
        public Item(long id) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Item$", "Item(qint64)", typeof(void), typeof(long), id);
        }
        /// <remarks>
        ///  Creates a new item with the given mime type.
        /// <param> name="mimeType" The mime type of the item.
        ///      </param></remarks>        <short>    Creates a new item with the given mime type.</short>
        public Item(string mimeType) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Item$", "Item(const QString&)", typeof(void), typeof(string), mimeType);
        }
        /// <remarks>
        ///  Creates a new item from an <code>other</code> item.
        ///      </remarks>        <short>    Creates a new item from an <code>other</code> item.</short>
        public Item(Akonadi.Item other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Item#", "Item(const Akonadi::Item&)", typeof(void), typeof(Akonadi.Item), other);
        }
        /// <remarks>
        ///  Returns all flags of this item.
        ///      </remarks>        <short>    Returns all flags of this item.</short>
        /// <remarks>
        ///  Returns whether the flag with the given <code>name</code> is
        ///  set in the item.
        ///      </remarks>        <short>    Returns whether the flag with the given <code>name</code> is  set in the item.</short>
        public bool HasFlag(QByteArray name) {
            return (bool) interceptor.Invoke("hasFlag#", "hasFlag(const QByteArray&) const", typeof(bool), typeof(QByteArray), name);
        }
        /// <remarks>
        ///  Sets the flag with the given <code>name</code> in the item.
        ///      </remarks>        <short>    Sets the flag with the given <code>name</code> in the item.</short>
        public void SetFlag(QByteArray name) {
            interceptor.Invoke("setFlag#", "setFlag(const QByteArray&)", typeof(void), typeof(QByteArray), name);
        }
        /// <remarks>
        ///  Removes the flag with the given <code>name</code> from the item.
        ///      </remarks>        <short>    Removes the flag with the given <code>name</code> from the item.</short>
        public void ClearFlag(QByteArray name) {
            interceptor.Invoke("clearFlag#", "clearFlag(const QByteArray&)", typeof(void), typeof(QByteArray), name);
        }
        /// <remarks>
        ///  Overwrites all flags of the item by the given <code>flags.</code>
        ///      </remarks>        <short>    Overwrites all flags of the item by the given <code>flags.</code></short>
        /// <remarks>
        ///  Removes all flags from the item.
        ///      </remarks>        <short>    Removes all flags from the item.</short>
        public void ClearFlags() {
            interceptor.Invoke("clearFlags", "clearFlags()", typeof(void));
        }
        /// <remarks>
        ///  Sets the payload based on the canonical representation normally
        ///  used for data of this mime type.
        /// <param> name="data" The encoded data.
        /// </param></remarks>        <short>    Sets the payload based on the canonical representation normally  used for data of this mime type.</short>
        ///         <see> fullPayloadData</see>
        public void SetPayloadFromData(QByteArray data) {
            interceptor.Invoke("setPayloadFromData#", "setPayloadFromData(const QByteArray&)", typeof(void), typeof(QByteArray), data);
        }
        /// <remarks>
        ///  Returns the full payload in its canonical representation, e.g. the
        ///  binary or textual format usually used for data with this mime type.
        ///  This is useful when communicating with non-Akonadi application by
        ///  e.g. drag&drop, copy&paste or stored files.
        ///      </remarks>        <short>    Returns the full payload in its canonical representation, e.</short>
        public QByteArray PayloadData() {
            return (QByteArray) interceptor.Invoke("payloadData", "payloadData() const", typeof(QByteArray));
        }
        /// <remarks>
        ///  Returns the list of loaded payload parts. This is not necessarily
        ///  identical to all parts in the cache or to all available parts on the backend.
        ///      </remarks>        <short>    Returns the list of loaded payload parts.</short>
        /// <remarks>
        ///  Sets the <code>revision</code> number of the item.
        ///  @note Do not modify this value from within an application,
        ///  it is updated automatically by the revision checking functions.
        ///      </remarks>        <short>    Sets the <code>revision</code> number of the item.</short>
        public void SetRevision(int revision) {
            interceptor.Invoke("setRevision$", "setRevision(int)", typeof(void), typeof(int), revision);
        }
        /// <remarks>
        ///  Returns the revision number of the item.
        ///      </remarks>        <short>    Returns the revision number of the item.</short>
        public int Revision() {
            return (int) interceptor.Invoke("revision", "revision() const", typeof(int));
        }
        /// <remarks>
        ///  Sets the mime type of the item to <code>mimeType.</code>
        ///      </remarks>        <short>    Sets the mime type of the item to <code>mimeType.</code></short>
        public void SetMimeType(string mimeType) {
            interceptor.Invoke("setMimeType$", "setMimeType(const QString&)", typeof(void), typeof(string), mimeType);
        }
        /// <remarks>
        ///  Returns the mime type of the item.
        ///      </remarks>        <short>    Returns the mime type of the item.</short>
        public string MimeType() {
            return (string) interceptor.Invoke("mimeType", "mimeType() const", typeof(string));
        }
        /// <remarks>
        ///  Returns whether the item has a payload object.
        ///      </remarks>        <short>    Returns whether the item has a payload object.</short>
        public bool HasPayload() {
            return (bool) interceptor.Invoke("hasPayload", "hasPayload() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns the url of the item.
        ///      </remarks>        <short>    Returns the url of the item.</short>
        public KUrl Url(Akonadi.Item.UrlType type) {
            return (KUrl) interceptor.Invoke("url$", "url(Akonadi::Item::UrlType) const", typeof(KUrl), typeof(Akonadi.Item.UrlType), type);
        }
        public KUrl Url() {
            return (KUrl) interceptor.Invoke("url", "url() const", typeof(KUrl));
        }
        ~Item() {
            interceptor.Invoke("~Item", "~Item()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~Item", "~Item()", typeof(void));
        }
        /// <remarks>
        ///  Creates an item from the given <code>url.</code>
        ///      </remarks>        <short>    Creates an item from the given <code>url.</code></short>
        public static Akonadi.Item FromUrl(KUrl url) {
            return (Akonadi.Item) staticInterceptor.Invoke("fromUrl#", "fromUrl(const KUrl&)", typeof(Akonadi.Item), typeof(KUrl), url);
        }
    }
}
