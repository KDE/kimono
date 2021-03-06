//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    [SmokeClass("KBookmark")]
    public class KBookmark : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KBookmark(Type dummy) {}
        /// <remarks>
        ///  KUrl.Bookmark is a QList that contains bookmarks with a few
        ///  convenience methods.
        /// </remarks>        <short>    KUrl.Bookmark is a QList that contains bookmarks with a few  convenience methods.</short>
        ///         <see> KBookmark</see>
        ///         <see> QList</see>
        [SmokeClass("KBookmark::List")]
        public class List : Object, IDisposable {
            protected SmokeInvocation interceptor = null;
            private IntPtr smokeObject;
            protected List(Type dummy) {}
            protected void CreateProxy() {
                interceptor = new SmokeInvocation(typeof(List), this);
            }
            private static SmokeInvocation staticInterceptor = null;
            static List() {
                staticInterceptor = new SmokeInvocation(typeof(List), null);
            }
            public List() : this((Type) null) {
                CreateProxy();
                interceptor.Invoke("List", "List()", typeof(void));
            }
            /// <remarks>
            ///  Adds this list of bookmark into the given QMimeData.
            /// <param> name="mimeData" the QMimeData instance used to drag or copy this bookmark
            ///          </param></remarks>        <short>    Adds this list of bookmark into the given QMimeData.</short>
            public void PopulateMimeData(QMimeData mimeData) {
                interceptor.Invoke("populateMimeData#", "populateMimeData(QMimeData*) const", typeof(void), typeof(QMimeData), mimeData);
            }
            ~List() {
                interceptor.Invoke("~List", "~List()", typeof(void));
            }
            public void Dispose() {
                interceptor.Invoke("~List", "~List()", typeof(void));
            }
            /// <remarks>
            ///  Return true if <code>mimeData</code> contains bookmarks
            ///          </remarks>        <short>    Return true if <code>mimeData</code> contains bookmarks          </short>
            public static bool CanDecode(QMimeData mimeData) {
                return (bool) staticInterceptor.Invoke("canDecode#", "canDecode(const QMimeData*)", typeof(bool), typeof(QMimeData), mimeData);
            }
            /// <remarks>
            ///  Return the list of mimeTypes that can be decoded by fromMimeData
            ///          </remarks>        <short>    Return the list of mimeTypes that can be decoded by fromMimeData          </short>
            public static List<string> MimeDataTypes() {
                return (List<string>) staticInterceptor.Invoke("mimeDataTypes", "mimeDataTypes()", typeof(List<string>));
            }
            /// <remarks>
            ///  Extract a list of bookmarks from the contents of <code>mimeData.</code>
            ///  Decoding will fail if <code>mimeData</code> does not contain any bookmarks.
            /// <param> name="mimeData" the mime data to extract from; cannot be 0
            /// </param></remarks>        <return> the list of bookmarks
            ///  @note those bookmarks are valid QDomElements, but their parent QDomDocument
            ///  is already deleted, do not use ownerDocument()
            ///          </return>
            ///         <short>    Extract a list of bookmarks from the contents of <code>mimeData.</code></short>
            public static KBookmark.List FromMimeData(QMimeData mimeData) {
                return (KBookmark.List) staticInterceptor.Invoke("fromMimeData#", "fromMimeData(const QMimeData*)", typeof(KBookmark.List), typeof(QMimeData), mimeData);
            }
        }
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KBookmark), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KBookmark() {
            staticInterceptor = new SmokeInvocation(typeof(KBookmark), null);
        }
        public enum MetaDataOverwriteMode {
            OverwriteMetaData = 0,
            DontOverwriteMetaData = 1,
        }
        /// <remarks>
        ///  Constructs a null bookmark, i.e. a bookmark for which isNull() returns true
        ///  If you want to create a new bookmark use eitehr KBookmarkGroup.addBookmark
        ///  or if you want an interactive dialog use KBookmarkDialog.
        ///      </remarks>        <short>    Constructs a null bookmark, i.</short>
        public KBookmark() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KBookmark", "KBookmark()", typeof(void));
        }
        /// <remarks>
        ///  Creates the KBookmark wrapper for @param elem
        ///  Mostly for internal usage.
        ///      </remarks>        <short>    Creates the KBookmark wrapper for @param elem  Mostly for internal usage.</short>
        public KBookmark(QDomElement elem) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KBookmark#", "KBookmark(const QDomElement&)", typeof(void), typeof(QDomElement), elem);
        }
        /// <remarks>
        ///  Whether the bookmark is a group or a normal bookmark
        ///      </remarks>        <short>    Whether the bookmark is a group or a normal bookmark      </short>
        public bool IsGroup() {
            return (bool) interceptor.Invoke("isGroup", "isGroup() const", typeof(bool));
        }
        /// <remarks>
        ///  Whether the bookmark is a separator
        ///      </remarks>        <short>    Whether the bookmark is a separator      </short>
        public bool IsSeparator() {
            return (bool) interceptor.Invoke("isSeparator", "isSeparator() const", typeof(bool));
        }
        /// <remarks>
        /// </remarks>        <return> true if this is a null bookmark. This will never
        ///  be the case for a real bookmark (in a menu), but it's used
        ///  for instance as the end condition for KBookmarkGroup.Next()
        ///      </return>
        ///         <short>   </short>
        public bool IsNull() {
            return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
        }
        /// <remarks>
        /// </remarks>        <return> true if bookmark is contained by a QDomDocument,
        ///  if not it is most likely that it has become separated and
        ///  is thus invalid and/or has been deleted from the bookmarks.
        ///      </return>
        ///         <short>   </short>
        public bool HasParent() {
            return (bool) interceptor.Invoke("hasParent", "hasParent() const", typeof(bool));
        }
        /// <remarks>
        ///  Text shown for the bookmark
        ///  If bigger than 40, the text is shortened by
        ///  replacing middle characters with "..." (see KStringHandler.Csqueeze)
        ///      </remarks>        <short>    Text shown for the bookmark  If bigger than 40, the text is shortened by  replacing middle characters with ".</short>
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        /// <remarks>
        ///  Text shown for the bookmark, not truncated.
        ///  You should not use this - this is mainly for keditbookmarks.
        ///      </remarks>        <short>    Text shown for the bookmark, not truncated.</short>
        public string FullText() {
            return (string) interceptor.Invoke("fullText", "fullText() const", typeof(string));
        }
        /// <remarks>
        ///  Set the text shown for the bookmark.
        /// <param> name="fullText" the new bookmark title
        ///      </param></remarks>        <short>    Set the text shown for the bookmark.</short>
        public void SetFullText(string fullText) {
            interceptor.Invoke("setFullText$", "setFullText(const QString&)", typeof(void), typeof(string), fullText);
        }
        /// <remarks>
        ///  URL contained by the bookmark
        ///      </remarks>        <short>    URL contained by the bookmark      </short>
        public KUrl Url() {
            return (KUrl) interceptor.Invoke("url", "url() const", typeof(KUrl));
        }
        /// <remarks>
        ///  Set the URL of the bookmark
        /// <param> name="url" the new bookmark URL
        ///      </param></remarks>        <short>    Set the URL of the bookmark </short>
        public void SetUrl(KUrl url) {
            interceptor.Invoke("setUrl#", "setUrl(const KUrl&)", typeof(void), typeof(KUrl), url);
        }
        /// <remarks>
        /// </remarks>        <return> the pixmap file for this bookmark
        ///  (i.e. the name of the icon)
        ///      </return>
        ///         <short>   </short>
        public string Icon() {
            return (string) interceptor.Invoke("icon", "icon() const", typeof(string));
        }
        /// <remarks>
        ///  Set the icon name of the bookmark
        /// <param> name="icon" the new icon name for this bookmark
        ///      </param></remarks>        <short>    Set the icon name of the bookmark </short>
        public void SetIcon(string icon) {
            interceptor.Invoke("setIcon$", "setIcon(const QString&)", typeof(void), typeof(string), icon);
        }
        /// <remarks>
        /// </remarks>        <return> Mime-Type of this item
        /// </return>
        ///         <short>   </short>
        public string MimeType() {
            return (string) interceptor.Invoke("mimeType", "mimeType() const", typeof(string));
        }
        /// <remarks>
        ///  Set the Mime-Type of this item
        /// <param> name="Mime" -Type
        /// </param></remarks>        <short>    Set the Mime-Type of this item </short>
        public void SetMimeType(string mimeType) {
            interceptor.Invoke("setMimeType$", "setMimeType(const QString&)", typeof(void), typeof(string), mimeType);
        }
        /// <remarks>
        ///      </remarks>        <return> if the bookmark should be shown in the toolbar
        ///  (used by the filtered toolbar)
        /// </return>
        ///         <short>   </short>
        public bool ShowInToolbar() {
            return (bool) interceptor.Invoke("showInToolbar", "showInToolbar() const", typeof(bool));
        }
        /// <remarks>
        ///  Set whether this bookmark is show in a filterd toolbar
        ///      </remarks>        <short>    Set whether this bookmark is show in a filterd toolbar      </short>
        public void SetShowInToolbar(bool show) {
            interceptor.Invoke("setShowInToolbar$", "setShowInToolbar(bool)", typeof(void), typeof(bool), show);
        }
        /// <remarks>
        /// </remarks>        <return> the group containing this bookmark
        ///      </return>
        ///         <short>   </short>
        public KBookmarkGroup ParentGroup() {
            return (KBookmarkGroup) interceptor.Invoke("parentGroup", "parentGroup() const", typeof(KBookmarkGroup));
        }
        /// <remarks>
        ///  Convert this to a group - do this only if
        ///  isGroup() returns true.
        ///      </remarks>        <short>    Convert this to a group - do this only if  isGroup() returns true.</short>
        public KBookmarkGroup ToGroup() {
            return (KBookmarkGroup) interceptor.Invoke("toGroup", "toGroup() const", typeof(KBookmarkGroup));
        }
        /// <remarks>
        ///  Return the "address" of this bookmark in the whole tree.
        ///  This is used when telling other processes about a change
        ///  in a given bookmark. The encoding of the address is "/4/2", for
        ///  instance, to designate the 2nd child inside the 4th child of the 
        ///  root bookmark.
        ///      </remarks>        <short>    Return the "address" of this bookmark in the whole tree.</short>
        public string Address() {
            return (string) interceptor.Invoke("address", "address() const", typeof(string));
        }
        /// <remarks>
        ///  Return the position in the parent, i.e. the last number in the address
        ///      </remarks>        <short>    Return the position in the parent, i.</short>
        public int PositionInParent() {
            return (int) interceptor.Invoke("positionInParent", "positionInParent() const", typeof(int));
        }
        /// <remarks>
        ///      </remarks>        <short>   </short>
        public QDomElement InternalElement() {
            return (QDomElement) interceptor.Invoke("internalElement", "internalElement() const", typeof(QDomElement));
        }
        /// <remarks>
        ///  Updates the bookmarks access metadata
        ///  Call when a user accesses the bookmark
        ///      </remarks>        <short>    Updates the bookmarks access metadata  Call when a user accesses the bookmark      </short>
        public void UpdateAccessMetadata() {
            interceptor.Invoke("updateAccessMetadata", "updateAccessMetadata()", typeof(void));
        }
        /// <remarks>
        /// </remarks>        <return> the metadata container node for a certain matadata owner
        /// </return>
        ///         <short>   </short>
        public QDomNode MetaData(string owner, bool create) {
            return (QDomNode) interceptor.Invoke("metaData$$", "metaData(const QString&, bool) const", typeof(QDomNode), typeof(string), owner, typeof(bool), create);
        }
        /// <remarks>
        ///  Get the value of a specific metadata item (owner = "http://www.kde.org").
        /// <param> name="key" Name of the metadata item
        /// </param></remarks>        <return> Value of the metadata item. string() is returned in case
        ///  the specified key does not exist.
        ///      </return>
        ///         <short>    Get the value of a specific metadata item (owner = "http://www.</short>
        public string MetaDataItem(string key) {
            return (string) interceptor.Invoke("metaDataItem$", "metaDataItem(const QString&) const", typeof(string), typeof(string), key);
        }
        /// <remarks>
        ///  Change the value of a specific metadata item, or create the given item
        ///  if it doesn't exist already (owner = "http://www.kde.org").     
        /// <param> name="key" Name of the metadata item to change
        /// </param><param> name="value" Value to use for the specified metadata item
        /// </param><param> name="mode" Whether to overwrite the item's value if it exists already or not.
        ///      </param></remarks>        <short>    Change the value of a specific metadata item, or create the given item  if it doesn't exist already (owner = "http://www.</short>
        public void SetMetaDataItem(string key, string value, KBookmark.MetaDataOverwriteMode mode) {
            interceptor.Invoke("setMetaDataItem$$$", "setMetaDataItem(const QString&, const QString&, KBookmark::MetaDataOverwriteMode)", typeof(void), typeof(string), key, typeof(string), value, typeof(KBookmark.MetaDataOverwriteMode), mode);
        }
        public void SetMetaDataItem(string key, string value) {
            interceptor.Invoke("setMetaDataItem$$", "setMetaDataItem(const QString&, const QString&)", typeof(void), typeof(string), key, typeof(string), value);
        }
        /// <remarks>
        ///  Adds this bookmark into the given QMimeData.
        ///  WARNING: do not call this method multiple times, use KBookmark.List.PopulateMimeData instead.
        /// <param> name="mimeData" the QMimeData instance used to drag or copy this bookmark
        ///      </param></remarks>        <short>    Adds this bookmark into the given QMimeData.</short>
        public void PopulateMimeData(QMimeData mimeData) {
            interceptor.Invoke("populateMimeData#", "populateMimeData(QMimeData*) const", typeof(void), typeof(QMimeData), mimeData);
        }
        /// <remarks>
        ///  Comparison operator
        ///      </remarks>        <short>    Comparison operator      </short>
        public override bool Equals(object o) {
            if (!(o is KBookmark)) { return false; }
            return this == (KBookmark) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        ~KBookmark() {
            interceptor.Invoke("~KBookmark", "~KBookmark()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KBookmark", "~KBookmark()", typeof(void));
        }
        public static bool operator==(KBookmark lhs, KBookmark rhs) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const KBookmark&) const", typeof(bool), typeof(KBookmark), lhs, typeof(KBookmark), rhs);
        }
        public static bool operator!=(KBookmark lhs, KBookmark rhs) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const KBookmark&) const", typeof(bool), typeof(KBookmark), lhs, typeof(KBookmark), rhs);
        }
        /// <remarks>
        ///  Creates a stand alone bookmark. This is fairly expensive since a new QDom Tree is build.
        ///      </remarks>        <short>    Creates a stand alone bookmark.</short>
        public static KBookmark StandaloneBookmark(string text, KUrl url, string icon) {
            return (KBookmark) staticInterceptor.Invoke("standaloneBookmark$#$", "standaloneBookmark(const QString&, const KUrl&, const QString&)", typeof(KBookmark), typeof(string), text, typeof(KUrl), url, typeof(string), icon);
        }
        public static KBookmark StandaloneBookmark(string text, KUrl url) {
            return (KBookmark) staticInterceptor.Invoke("standaloneBookmark$#", "standaloneBookmark(const QString&, const KUrl&)", typeof(KBookmark), typeof(string), text, typeof(KUrl), url);
        }
        /// <remarks>
        /// </remarks>        <return> address of parent
        ///      </return>
        ///         <short>   </short>
        public static string ParentAddress(string address) {
            return (string) staticInterceptor.Invoke("parentAddress$", "parentAddress(const QString&)", typeof(string), typeof(string), address);
        }
        /// <remarks>
        /// </remarks>        <return> position in parent (e.g. /4/5/2 . 2)
        ///      </return>
        ///         <short>   </short>
        public static uint PositionInParent(string address) {
            return (uint) staticInterceptor.Invoke("positionInParent$", "positionInParent(const QString&)", typeof(uint), typeof(string), address);
        }
        /// <remarks>
        /// </remarks>        <return> address of previous sibling (e.g. /4/5/2 . /4/5/1)
        ///  Returns string() for a first child
        ///      </return>
        ///         <short>   </short>
        public static string PreviousAddress(string address) {
            return (string) staticInterceptor.Invoke("previousAddress$", "previousAddress(const QString&)", typeof(string), typeof(string), address);
        }
        /// <remarks>
        /// </remarks>        <return> address of next sibling (e.g. /4/5/2 . /4/5/3)
        ///  This doesn't check whether it actually exists
        ///      </return>
        ///         <short>   </short>
        public static string NextAddress(string address) {
            return (string) staticInterceptor.Invoke("nextAddress$", "nextAddress(const QString&)", typeof(string), typeof(string), address);
        }
        /// <remarks>
        /// </remarks>        <return> the common parent of both addresses which
        ///  has the greatest depth
        ///      </return>
        ///         <short>   </short>
        public static string CommonParent(string A, string B) {
            return (string) staticInterceptor.Invoke("commonParent$$", "commonParent(const QString&, const QString&)", typeof(string), typeof(string), A, typeof(string), B);
        }
    }
}
