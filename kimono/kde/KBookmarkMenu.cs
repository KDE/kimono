//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  This class provides a bookmark menu.  It is typically used in
	///  cooperation with KActionMenu but doesn't have to be.
	///  If you use this class by itself, then it will use KDE defaults for
	///  everything -- the bookmark path, bookmark editor, bookmark launcher..
	///  everything.  These defaults reside in the classes
	///  KBookmarkOwner (editing bookmarks) and KBookmarkManager
	///  (almost everything else).  If you wish to change the defaults in
	///  any way, you must reimplement either this class or KBookmarkOwner.
	///  Using this class is very simple:
	///  1) Create a popup menu (either KActionMenu or KMenu will do)
	///  2) Instantiate a new KBookmarkMenu object using the above popup
	///     menu as a parameter
	///  3) Insert your (now full) popup menu wherever you wish
	///  </remarks>		<short>    This class provides a bookmark menu.</short>
	[SmokeClass("KBookmarkMenu")]
	public class KBookmarkMenu : QObject, IDisposable {
 		protected KBookmarkMenu(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KBookmarkMenu), this);
		}
		/// <remarks>
		///  Fills a bookmark menu
		///  (one instance of KBookmarkMenu is created for the toplevel menu,
		///   but also one per submenu).
		/// <param> name="mgr" The bookmark manager to use (i.e. for reading and writing)
		/// </param><param> name="owner" implementation of the KBookmarkOwner callback interface.
		///  Note: If you pass a null KBookmarkOwner to the constructor, the
		///  openBookmark signal is not emitted, instead KRun is used to open the bookmark.
		/// </param><param> name="parentMenu" menu to be filled
		/// </param><param> name="collec" parent collection for the KActions.
		///    </param></remarks>		<short>    Fills a bookmark menu  (one instance of KBookmarkMenu is created for the toplevel menu,   but also one per submenu).</short>
		public KBookmarkMenu(KBookmarkManager mgr, KBookmarkOwner owner, KMenu parentMenu, KActionCollection collec) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KBookmarkMenu####", "KBookmarkMenu(KBookmarkManager*, KBookmarkOwner*, KMenu*, KActionCollection*)", typeof(void), typeof(KBookmarkManager), mgr, typeof(KBookmarkOwner), owner, typeof(KMenu), parentMenu, typeof(KActionCollection), collec);
		}
		/// <remarks>
		///  Creates a bookmark submenu
		///    </remarks>		<short>    Creates a bookmark submenu    </short>
		public KBookmarkMenu(KBookmarkManager mgr, KBookmarkOwner owner, KMenu parentMenu, string parentAddress) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KBookmarkMenu###$", "KBookmarkMenu(KBookmarkManager*, KBookmarkOwner*, KMenu*, const QString&)", typeof(void), typeof(KBookmarkManager), mgr, typeof(KBookmarkOwner), owner, typeof(KMenu), parentMenu, typeof(string), parentAddress);
		}
		/// <remarks>
		///  Call ensureUpToDate() if you need KBookmarkMenu to adjust to its
		///  final size before it is executed.
		/// </remarks>		<short>    Call ensureUpToDate() if you need KBookmarkMenu to adjust to its  final size before it is executed.</short>
		public void EnsureUpToDate() {
			interceptor.Invoke("ensureUpToDate", "ensureUpToDate()", typeof(void));
		}
		[Q_SLOT("void slotBookmarksChanged(QString)")]
		public void SlotBookmarksChanged(string arg1) {
			interceptor.Invoke("slotBookmarksChanged$", "slotBookmarksChanged(const QString&)", typeof(void), typeof(string), arg1);
		}
		[SmokeMethod("clear()")]
		protected virtual void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[SmokeMethod("refill()")]
		protected virtual void Refill() {
			interceptor.Invoke("refill", "refill()", typeof(void));
		}
		[SmokeMethod("actionForBookmark(const KBookmark&)")]
		protected virtual QAction ActionForBookmark(KBookmark bm) {
			return (QAction) interceptor.Invoke("actionForBookmark#", "actionForBookmark(const KBookmark&)", typeof(QAction), typeof(KBookmark), bm);
		}
		[SmokeMethod("contextMenu(QAction*)")]
		protected virtual KMenu ContextMenu(QAction action) {
			return (KMenu) interceptor.Invoke("contextMenu#", "contextMenu(QAction*)", typeof(KMenu), typeof(QAction), action);
		}
		protected void AddActions() {
			interceptor.Invoke("addActions", "addActions()", typeof(void));
		}
		protected void FillBookmarks() {
			interceptor.Invoke("fillBookmarks", "fillBookmarks()", typeof(void));
		}
		protected void AddAddBookmark() {
			interceptor.Invoke("addAddBookmark", "addAddBookmark()", typeof(void));
		}
		protected void AddAddBookmarksList() {
			interceptor.Invoke("addAddBookmarksList", "addAddBookmarksList()", typeof(void));
		}
		protected void AddEditBookmarks() {
			interceptor.Invoke("addEditBookmarks", "addEditBookmarks()", typeof(void));
		}
		protected void AddNewFolder() {
			interceptor.Invoke("addNewFolder", "addNewFolder()", typeof(void));
		}
		protected void AddOpenInTabs() {
			interceptor.Invoke("addOpenInTabs", "addOpenInTabs()", typeof(void));
		}
		protected bool IsRoot() {
			return (bool) interceptor.Invoke("isRoot", "isRoot() const", typeof(bool));
		}
		protected bool IsDirty() {
			return (bool) interceptor.Invoke("isDirty", "isDirty() const", typeof(bool));
		}
		/// <remarks>
		///  Parent bookmark for this menu.
		///    </remarks>		<short>    Parent bookmark for this menu.</short>
		protected string ParentAddress() {
			return (string) interceptor.Invoke("parentAddress", "parentAddress() const", typeof(string));
		}
		protected KBookmarkManager Manager() {
			return (KBookmarkManager) interceptor.Invoke("manager", "manager() const", typeof(KBookmarkManager));
		}
		protected KBookmarkOwner Owner() {
			return (KBookmarkOwner) interceptor.Invoke("owner", "owner() const", typeof(KBookmarkOwner));
		}
		/// <remarks>
		///  The menu in which we insert our actions
		///  Supplied in the constructor.
		///    </remarks>		<short>    The menu in which we insert our actions  Supplied in the constructor.</short>
		protected KMenu ParentMenu() {
			return (KMenu) interceptor.Invoke("parentMenu", "parentMenu() const", typeof(KMenu));
		}
		[Q_SLOT("void slotAboutToShow()")]
		protected void SlotAboutToShow() {
			interceptor.Invoke("slotAboutToShow", "slotAboutToShow()", typeof(void));
		}
		[Q_SLOT("void slotAddBookmarksList()")]
		protected void SlotAddBookmarksList() {
			interceptor.Invoke("slotAddBookmarksList", "slotAddBookmarksList()", typeof(void));
		}
		[Q_SLOT("void slotAddBookmark()")]
		protected void SlotAddBookmark() {
			interceptor.Invoke("slotAddBookmark", "slotAddBookmark()", typeof(void));
		}
		[Q_SLOT("void slotNewFolder()")]
		protected void SlotNewFolder() {
			interceptor.Invoke("slotNewFolder", "slotNewFolder()", typeof(void));
		}
		[Q_SLOT("void slotOpenFolderInTabs()")]
		protected void SlotOpenFolderInTabs() {
			interceptor.Invoke("slotOpenFolderInTabs", "slotOpenFolderInTabs()", typeof(void));
		}
		~KBookmarkMenu() {
			interceptor.Invoke("~KBookmarkMenu", "~KBookmarkMenu()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KBookmarkMenu", "~KBookmarkMenu()", typeof(void));
		}
		protected new IKBookmarkMenuSignals Emit {
			get { return (IKBookmarkMenuSignals) Q_EMIT; }
		}
	}

	public interface IKBookmarkMenuSignals : IQObjectSignals {
	}
}
