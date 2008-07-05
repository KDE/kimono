//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  This class implements the reading/writing of bookmarks in XML.
	///  The bookmarks file is read and written using the XBEL standard
	///  (http://pyxml.sourceforge.net/topics/xbel/)
	///  A sample file looks like this :
	///  <pre>
	///  <xbel>
	///    <bookmark href="http://techbase.kde.org"><title>Developer Web Site</title></bookmark>
	///    <folder folded="no">
	///      <title>Title of this folder</title>
	///      <bookmark icon="kde" href="http://www.kde.org"><title>KDE Web Site</title></bookmark>
	///      <folder toolbar="yes">
	///        <title>My own bookmarks</title>
	///        <bookmark href="http://www.koffice.org"><title>KOffice Web Site</title></bookmark>
	///        <separator/>
	///        <bookmark href="http://www.kdevelop.org"><title>KDevelop Web Site</title></bookmark>
	///      </folder>
	///    </folder>
	///  </xbel>
	///  </pre>
	///  </remarks>		<short>    This class implements the reading/writing of bookmarks in XML.</short>
	[SmokeClass("KBookmarkManager")]
	public class KBookmarkManager : QObject {
 		protected KBookmarkManager(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KBookmarkManager), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KBookmarkManager() {
			staticInterceptor = new SmokeInvocation(typeof(KBookmarkManager), null);
		}
		/// <remarks>
		///  Set the update flag. Defaults to true.
		/// <param> name="update" if true then KBookmarkManager will listen to DBUS update requests.
		///      </param></remarks>		<short>    Set the update flag.</short>
		public void SetUpdate(bool update) {
			interceptor.Invoke("setUpdate$", "setUpdate(bool)", typeof(void), typeof(bool), update);
		}
		/// <remarks>
		///  Save the bookmarks to the given XML file on disk.
		/// <param> name="filename" full path to the desired bookmarks file location
		/// </param><param> name="toolbarCache" iff true save a cache of the toolbar folder, too
		/// </param></remarks>		<return> true if saving was successful
		///      </return>
		/// 		<short>    Save the bookmarks to the given XML file on disk.</short>
		public bool SaveAs(string filename, bool toolbarCache) {
			return (bool) interceptor.Invoke("saveAs$$", "saveAs(const QString&, bool) const", typeof(bool), typeof(string), filename, typeof(bool), toolbarCache);
		}
		public bool SaveAs(string filename) {
			return (bool) interceptor.Invoke("saveAs$", "saveAs(const QString&) const", typeof(bool), typeof(string), filename);
		}
		/// <remarks>
		///  Update access time stamps for a given url.
		/// <param> name="url" the viewed url
		/// </param></remarks>		<return> true if any metadata was modified (bookmarks file is not saved automatically)
		///      </return>
		/// 		<short>    Update access time stamps for a given url.</short>
		public bool UpdateAccessMetadata(string url) {
			return (bool) interceptor.Invoke("updateAccessMetadata$", "updateAccessMetadata(const QString&)", typeof(bool), typeof(string), url);
		}
		public void UpdateFavicon(string url, string faviconurl) {
			interceptor.Invoke("updateFavicon$$", "updateFavicon(const QString&, const QString&)", typeof(void), typeof(string), url, typeof(string), faviconurl);
		}
		/// <remarks>
		///  This will return the path that this manager is using to read
		///  the bookmarks.
		/// </remarks>		<return> the path containing the bookmarks
		///      </return>
		/// 		<short>    This will return the path that this manager is using to read  the bookmarks.</short>
		public string Path() {
			return (string) interceptor.Invoke("path", "path() const", typeof(string));
		}
		/// <remarks>
		///  This will return the root bookmark.  It is used to iterate
		///  through the bookmarks manually.  It is mostly used internally.
		/// </remarks>		<return> the root (top-level) bookmark
		///      </return>
		/// 		<short>    This will return the root bookmark.</short>
		public KBookmarkGroup Root() {
			return (KBookmarkGroup) interceptor.Invoke("root", "root() const", typeof(KBookmarkGroup));
		}
		/// <remarks>
		///  This returns the root of the toolbar menu.
		///  In the XML, this is the group with the attribute toolbar=yes
		/// </remarks>		<return> the toolbar group
		///      </return>
		/// 		<short>    This returns the root of the toolbar menu.</short>
		public KBookmarkGroup Toolbar() {
			return (KBookmarkGroup) interceptor.Invoke("toolbar", "toolbar()", typeof(KBookmarkGroup));
		}
		/// <remarks>
		/// <param> name="address" the address belonging to the bookmark you're looking for
		/// </param><param> name="tolerate" when true tries to find the most tolerable bookmark position
		/// </param></remarks>		<return> the bookmark designated by <code>address</code>
		/// </return>
		/// 		<short>   </short>
		/// 		<see> KBookmark.Address</see>
		public KBookmark FindByAddress(string address) {
			return (KBookmark) interceptor.Invoke("findByAddress$", "findByAddress(const QString&)", typeof(KBookmark), typeof(string), address);
		}
		/// <remarks>
		///  Saves the bookmark file and notifies everyone.
		/// </remarks>		<short>    Saves the bookmark file and notifies everyone.</short>
		public void EmitChanged() {
			interceptor.Invoke("emitChanged", "emitChanged()", typeof(void));
		}
		/// <remarks>
		///  Saves the bookmark file and notifies everyone.
		/// <param> name="group" the parent of all changed bookmarks
		///      </param></remarks>		<short>    Saves the bookmark file and notifies everyone.</short>
		public void EmitChanged(KBookmarkGroup group) {
			interceptor.Invoke("emitChanged#", "emitChanged(const KBookmarkGroup&)", typeof(void), typeof(KBookmarkGroup), group);
		}
		/// <remarks>
		///  Save the bookmarks to an XML file on disk.
		///  You should use emitChanged() instead of this function, it saves
		///  and notifies everyone that the file has changed.
		///  Only use this if you don't want the emitChanged signal.
		/// <param> name="toolbarCache" iff true save a cache of the toolbar folder, too
		/// </param></remarks>		<return> true if saving was successful
		///      </return>
		/// 		<short>    Save the bookmarks to an XML file on disk.</short>
		public bool Save(bool toolbarCache) {
			return (bool) interceptor.Invoke("save$", "save(bool) const", typeof(bool), typeof(bool), toolbarCache);
		}
		public bool Save() {
			return (bool) interceptor.Invoke("save", "save() const", typeof(bool));
		}
		public void EmitConfigChanged() {
			interceptor.Invoke("emitConfigChanged", "emitConfigChanged()", typeof(void));
		}
		/// <remarks>
		///  Set options with which slotEditBookmarks called keditbookmarks
		///  this can be used to change the appearance of the keditbookmarks
		///  in order to provide a slightly differing outer shell depending
		///  on the bookmarks file / app which calls it.
		/// <param> name="caption" the --caption string, for instance "Konsole"
		/// </param><param> name="browser" iff false display no browser specific
		///             menu items in keditbookmarks . --nobrowser
		///      </param></remarks>		<short>    Set options with which slotEditBookmarks called keditbookmarks  this can be used to change the appearance of the keditbookmarks  in order to provide a slightly differing outer shell depending  on the bookmarks file / app which calls it.</short>
		public void SetEditorOptions(string caption, bool browser) {
			interceptor.Invoke("setEditorOptions$$", "setEditorOptions(const QString&, bool)", typeof(void), typeof(string), caption, typeof(bool), browser);
		}
		/// <remarks>
		///      </remarks>		<short>   </short>
		public QDomDocument InternalDocument() {
			return (QDomDocument) interceptor.Invoke("internalDocument", "internalDocument() const", typeof(QDomDocument));
		}
		[Q_SLOT("void slotEditBookmarks()")]
		public void SlotEditBookmarks() {
			interceptor.Invoke("slotEditBookmarks", "slotEditBookmarks()", typeof(void));
		}
		[Q_SLOT("void slotEditBookmarksAtAddress(QString)")]
		public void SlotEditBookmarksAtAddress(string address) {
			interceptor.Invoke("slotEditBookmarksAtAddress$", "slotEditBookmarksAtAddress(const QString&)", typeof(void), typeof(string), address);
		}
		/// <remarks>
		///  Reparse the whole bookmarks file and notify about the change
		///  Doesn't send signal over DBUS to the other Bookmark Managers
		///  You probably want to use emitChanged()
		///      </remarks>		<short>    Reparse the whole bookmarks file and notify about the change  Doesn't send signal over DBUS to the other Bookmark Managers  You probably want to use emitChanged() </short>
		[Q_SLOT("void notifyCompleteChange(QString)")]
		public void NotifyCompleteChange(string caller) {
			interceptor.Invoke("notifyCompleteChange$", "notifyCompleteChange(const QString&)", typeof(void), typeof(string), caller);
		}
		/// <remarks>
		///  Emit the changed signal for the group whose address is given
		/// </remarks>		<short>    Emit the changed signal for the group whose address is given </short>
		/// 		<see> KBookmark.Address</see>
		/// 		<see> Called</see>
		/// 		<see> by</see>
		/// 		<see> the</see>
		/// 		<see> process</see>
		/// 		<see> that</see>
		/// 		<see> saved</see>
		/// 		<see> the</see>
		/// 		<see> file</see>
		/// 		<see> after</see>
		/// 		<see> a</see>
		/// 		<see> small</see>
		/// 		<see> change</see>
		/// 		<see> (new</see>
		/// 		<see> bookmark</see>
		/// 		<see> or</see>
		/// 		<see> new</see>
		/// 		<see> folder).</see>
		/// 		<see> Does</see>
		/// 		<see> not</see>
		/// 		<see> send</see>
		/// 		<see> signal</see>
		/// 		<see> over</see>
		/// 		<see> DBUS</see>
		/// 		<see> to</see>
		/// 		<see> the</see>
		/// 		<see> other</see>
		/// 		<see> Bookmark</see>
		/// 		<see> Managers</see>
		/// 		<see> You</see>
		/// 		<see> probably</see>
		/// 		<see> want</see>
		/// 		<see> to</see>
		/// 		<see> call</see>
		/// 		<see> emitChanged</see>
		[Q_SLOT("void notifyChanged(QString, QDBusMessage)")]
		public void NotifyChanged(string groupAddress, QDBusMessage msg) {
			interceptor.Invoke("notifyChanged$#", "notifyChanged(const QString&, const QDBusMessage&)", typeof(void), typeof(string), groupAddress, typeof(QDBusMessage), msg);
		}
		[Q_SLOT("void notifyConfigChanged()")]
		public void NotifyConfigChanged() {
			interceptor.Invoke("notifyConfigChanged", "notifyConfigChanged()", typeof(void));
		}
		/// <remarks>
		///  This static function will return an instance of the
		///  KBookmarkManager, responsible for the given <code>bookmarksFile.</code>
		///  If you do not instantiate this class either
		///  natively or in a derived class, then it will return an object
		///  with the default behaviors.  If you wish to use different
		///  behaviors, you <em>must</em> derive your own class and
		///  instantiate it before this method is ever called.
		/// <param> name="bookmarksFile" full path to the bookmarks file,
		///  Use ~/.kde/share/apps/konqueror/bookmarks.xml for the konqueror bookmarks
		/// </param><param> name="dbusObjectName" a unique name that represents this bookmark collection,
		///  usually your kinstance (e.g. kapplication) name. This is "konqueror" for the
		///  konqueror bookmarks, "kfile" for KFileDialog bookmarks, etc.
		///  The final DBus object path is /KBookmarkManager/dbusObjectName
		///  An empty dbusObjectName disables the registration to dbus (used for temporary managers)
		/// </param>     </remarks>		<short>    This static function will return an instance of the  KBookmarkManager, responsible for the given <code>bookmarksFile.</code></short>
		public static KBookmarkManager ManagerForFile(string bookmarksFile, string dbusObjectName) {
			return (KBookmarkManager) staticInterceptor.Invoke("managerForFile$$", "managerForFile(const QString&, const QString&)", typeof(KBookmarkManager), typeof(string), bookmarksFile, typeof(string), dbusObjectName);
		}
		/// <remarks>
		///  Returns a KBookmarkManager, which will use KDirWatch for change detection
		///  This is important when sharing bookmarks with other Desktops.
		/// <param> name="bookmarksFile" full path to the bookmarks file
		/// </param></remarks>		<short>    Returns a KBookmarkManager, which will use KDirWatch for change detection  This is important when sharing bookmarks with other Desktops.</short>
		public static KBookmarkManager ManagerForExternalFile(string bookmarksFile) {
			return (KBookmarkManager) staticInterceptor.Invoke("managerForExternalFile$", "managerForExternalFile(const QString&)", typeof(KBookmarkManager), typeof(string), bookmarksFile);
		}
		/// <remarks>
		///  only used for KBookmarkBar
		///      </remarks>		<short>    only used for KBookmarkBar      </short>
		public static KBookmarkManager CreateTempManager() {
			return (KBookmarkManager) staticInterceptor.Invoke("createTempManager", "createTempManager()", typeof(KBookmarkManager));
		}
		/// <remarks>
		///  Returns a pointer to the user's main (konqueror) bookmark collection.
		///      </remarks>		<short>    Returns a pointer to the user's main (konqueror) bookmark collection.</short>
		public static KBookmarkManager UserBookmarksManager() {
			return (KBookmarkManager) staticInterceptor.Invoke("userBookmarksManager", "userBookmarksManager()", typeof(KBookmarkManager));
		}
		protected new IKBookmarkManagerSignals Emit {
			get { return (IKBookmarkManagerSignals) Q_EMIT; }
		}
	}

	public interface IKBookmarkManagerSignals : IQObjectSignals {
	}
}
