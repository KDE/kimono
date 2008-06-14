//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///   This class is an action to handle a recent files submenu.
	///   The best way to create the action is to use KStandardAction.OpenRecent.
	///   Then you simply need to call loadEntries on startup, saveEntries
	///   on shutdown, addURL when your application loads/saves a file.
	///  See <see cref="IKRecentFilesActionSignals"></see> for signals emitted by KRecentFilesAction
	/// </remarks>		<author> Michael Koch
	///  </author>
	/// 		<short> Recent files action.</short>
	[SmokeClass("KRecentFilesAction")]
	public class KRecentFilesAction : KSelectAction, IDisposable {
 		protected KRecentFilesAction(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KRecentFilesAction), this);
		}
		[Q_PROPERTY("int", "maxItems")]
		public int MaxItems {
			get { return (int) interceptor.Invoke("maxItems", "maxItems()", typeof(int)); }
			set { interceptor.Invoke("setMaxItems$", "setMaxItems(int)", typeof(void), typeof(int), value); }
		}
		/// <remarks>
		///  Constructs an action with the specified parent.
		/// <param> name="parent" The parent of this action.
		///      </param></remarks>		<short>    Constructs an action with the specified parent.</short>
		public KRecentFilesAction(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRecentFilesAction#", "KRecentFilesAction(QObject*)", typeof(void), typeof(QObject), parent);
		}
		/// <remarks>
		///  Constructs an action with text; a shortcut may be specified by
		///  the ampersand character (e.g. "&amp;Option" creates a shortcut with key \e O )
		///  This is the most common KAction used when you do not have a
		///  corresponding icon (note that it won't appear in the current version
		///  of the "Edit ToolBar" dialog, because an action needs an icon to be
		///  plugged in a toolbar...).
		/// <param> name="text" The text that will be displayed.
		/// </param><param> name="parent" The parent of this action.
		///      </param></remarks>		<short>    Constructs an action with text; a shortcut may be specified by  the ampersand character (e.</short>
		public KRecentFilesAction(string text, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRecentFilesAction$#", "KRecentFilesAction(const QString&, QObject*)", typeof(void), typeof(string), text, typeof(QObject), parent);
		}
		/// <remarks>
		///  Constructs an action with text and an icon; a shortcut may be specified by
		///  the ampersand character (e.g. "&amp;Option" creates a shortcut with key \e O )
		///  This is the other common KAction used.  Use it when you
		///  \e do have a corresponding icon.
		/// <param> name="icon" The icon to display.
		/// </param><param> name="text" The text that will be displayed.
		/// </param><param> name="parent" The parent of this action.
		///      </param></remarks>		<short>    Constructs an action with text and an icon; a shortcut may be specified by  the ampersand character (e.</short>
		public KRecentFilesAction(KIcon icon, string text, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KRecentFilesAction#$#", "KRecentFilesAction(const KIcon&, const QString&, QObject*)", typeof(void), typeof(KIcon), icon, typeof(string), text, typeof(QObject), parent);
		}
		/// <remarks>
		///  Adds \a action to the list of URLs, with \a url and title \a name.
		///  Do not use addAction(QAction), as no url will be associated, and
		///  consequently urlSelected() will not be emitted when \a action is selected.
		///    </remarks>		<short>    Adds \a action to the list of URLs, with \a url and title \a name.</short>
		public void AddAction(QAction action, KUrl url, string name) {
			interceptor.Invoke("addAction##$", "addAction(QAction*, const KUrl&, const QString&)", typeof(void), typeof(QAction), action, typeof(KUrl), url, typeof(string), name);
		}
		/// <remarks>
		///  Reimplemented for internal reasons.
		///    </remarks>		<short>    Reimplemented for internal reasons.</short>
		[SmokeMethod("removeAction(QAction*)")]
		public override QAction RemoveAction(QAction action) {
			return (QAction) interceptor.Invoke("removeAction#", "removeAction(QAction*)", typeof(QAction), typeof(QAction), action);
		}
		/// <remarks>
		///  Reimplemented for internal reasons.
		///    </remarks>		<short>    Reimplemented for internal reasons.</short>
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		/// <remarks>
		///   Loads the recent files entries from a given KConfigGroup object.
		///   You can provide the name of the group used to load the entries.
		///   If the groupname is empty, entries are load from a group called 'RecentFiles'
		///    </remarks>		<short>     Loads the recent files entries from a given KConfigGroup object.</short>
		public void LoadEntries(KConfigGroup config) {
			interceptor.Invoke("loadEntries#", "loadEntries(const KConfigGroup&)", typeof(void), typeof(KConfigGroup), config);
		}
		/// <remarks>
		///   Saves the current recent files entries to a given KConfigGroup object.
		///   You can provide the name of the group used to load the entries.
		///   If the groupname is empty, entries are saved to a group called 'RecentFiles'
		///    </remarks>		<short>     Saves the current recent files entries to a given KConfigGroup object.</short>
		public void SaveEntries(KConfigGroup config) {
			interceptor.Invoke("saveEntries#", "saveEntries(const KConfigGroup&)", typeof(void), typeof(KConfigGroup), config);
		}
		/// <remarks>
		///   Add URL to recent files list.
		/// <param> name="url" The URL of the file
		/// </param><param> name="name" The user visible pretty name that appears before the URL
		///    </param></remarks>		<short>     Add URL to recent files list.</short>
		public void AddUrl(KUrl url, string name) {
			interceptor.Invoke("addUrl#$", "addUrl(const KUrl&, const QString&)", typeof(void), typeof(KUrl), url, typeof(string), name);
		}
		public void AddUrl(KUrl url) {
			interceptor.Invoke("addUrl#", "addUrl(const KUrl&)", typeof(void), typeof(KUrl), url);
		}
		/// <remarks>
		///   Remove an URL from the recent files list.
		/// <param> name="url" The URL of the file
		///    </param></remarks>		<short>     Remove an URL from the recent files list.</short>
		public void RemoveUrl(KUrl url) {
			interceptor.Invoke("removeUrl#", "removeUrl(const KUrl&)", typeof(void), typeof(KUrl), url);
		}
		/// <remarks>
		///   Retrieve a list of all URLs in the recent files list.
		///    </remarks>		<short>     Retrieve a list of all URLs in the recent files list.</short>
		public List<KUrl> Urls() {
			return (List<KUrl>) interceptor.Invoke("urls", "urls() const", typeof(List<KUrl>));
		}
		~KRecentFilesAction() {
			interceptor.Invoke("~KRecentFilesAction", "~KRecentFilesAction()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KRecentFilesAction", "~KRecentFilesAction()", typeof(void));
		}
		protected new IKRecentFilesActionSignals Emit {
			get { return (IKRecentFilesActionSignals) Q_EMIT; }
		}
	}

	public interface IKRecentFilesActionSignals : IKSelectActionSignals {
		/// <remarks>
		///   This signal gets emitted when the user selects an URL.
		/// <param> name="url" The URL thats the user selected.
		///    </param></remarks>		<short>     This signal gets emitted when the user selects an URL.</short>
		[Q_SIGNAL("void urlSelected(const KUrl&)")]
		void UrlSelected(KUrl url);
	}
}
