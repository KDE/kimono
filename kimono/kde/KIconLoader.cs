//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Text;
	using System.Collections.Generic;

	/// <remarks>
	///  Iconloader for KDE.
	///  KIconLoader will load the current icon theme and all its base themes.
	///  Icons will be searched in any of these themes. Additionally, it caches
	///  icons and applies effects according the the user's preferences.
	///  In KDE, it is encouraged to load icons by "Group". An icon group is a
	///  location on the screen where icons are being used. Standard groups are:
	///  Desktop, Toolbar, MainToolbar, Small and Panel. Each group has some
	///  centrally configured properties bound to it, including the icon size
	///  and effects. This makes it possible to offer a consistent icon look in
	///  all KDE applications.
	///  The standard groups are defined below.
	/// 
	/// <li>
	/// K3Icon.Desktop: Icons in the iconview of konqueror, kdesktop and similar apps.
	/// </li>
	/// 
	/// <li>
	/// K3Icon.Toolbar: Icons in toolbars.
	/// </li>
	/// 
	/// <li>
	/// K3Icon.MainToolbar: Icons in the main toolbars.
	/// </li>
	/// 
	/// <li>
	/// K3Icon.Small: Various small (typical 16x16) places: titlebars, listviews
	///  and menu entries.
	/// </li>
	/// 
	/// <li>
	/// K3Icon.Panel: Icons in kicker's panel
	/// </li>
	///  The icons are stored on disk in an icon theme or in a standalone
	///  directory. The icon theme directories contain multiple sizes and/or
	///  depths for the same icon. The iconloader will load the correct one based
	///  on the icon group and the current theme. Icon themes are stored globally
	///  in share/icons, or, application specific in share/apps/$appdir/icons.
	///  The standalone directories contain just one version of an icon. The
	///  directories that are searched are: $appdir/pics and $appdir/toolbar.
	///  Icons in these directories can be loaded by using the special group
	///  "User".
	///  </remarks>		<short>    Iconloader for KDE.</short>

	[SmokeClass("KIconLoader")]
	public class KIconLoader : QObject, IDisposable {
 		protected KIconLoader(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KIconLoader), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KIconLoader() {
			staticInterceptor = new SmokeInvocation(typeof(KIconLoader), null);
		}
		// QPixmap loadIcon(const QString& arg1,KIconLoader::Group arg2,int arg3,int arg4,const QStringList& arg5,QString* arg6,bool arg7); >>>> NOT CONVERTED
		// QPixmap loadIcon(const QString& arg1,KIconLoader::Group arg2,int arg3,int arg4,const QStringList& arg5,QString* arg6); >>>> NOT CONVERTED
		// QPixmap loadIcon(const QString& arg1,KIconLoader::Group arg2,int arg3,int arg4,const QStringList& arg5); >>>> NOT CONVERTED
		// QPixmap loadIcon(const QString& arg1,KIconLoader::Group arg2,int arg3,int arg4); >>>> NOT CONVERTED
		// QPixmap loadIcon(const QString& arg1,KIconLoader::Group arg2,int arg3); >>>> NOT CONVERTED
		// QPixmap loadIcon(const QString& arg1,KIconLoader::Group arg2); >>>> NOT CONVERTED
		// QPixmap loadMimeTypeIcon(const QString& arg1,KIconLoader::Group arg2,int arg3,int arg4,const QStringList& arg5,QString* arg6); >>>> NOT CONVERTED
		// QPixmap loadMimeTypeIcon(const QString& arg1,KIconLoader::Group arg2,int arg3,int arg4,const QStringList& arg5); >>>> NOT CONVERTED
		// QPixmap loadMimeTypeIcon(const QString& arg1,KIconLoader::Group arg2,int arg3,int arg4); >>>> NOT CONVERTED
		// QPixmap loadMimeTypeIcon(const QString& arg1,KIconLoader::Group arg2,int arg3); >>>> NOT CONVERTED
		// QPixmap loadMimeTypeIcon(const QString& arg1,KIconLoader::Group arg2); >>>> NOT CONVERTED
		// QMovie* loadMovie(const QString& arg1,KIconLoader::Group arg2,int arg3,QObject* arg4); >>>> NOT CONVERTED
		// QMovie* loadMovie(const QString& arg1,KIconLoader::Group arg2,int arg3); >>>> NOT CONVERTED
		// QMovie* loadMovie(const QString& arg1,KIconLoader::Group arg2); >>>> NOT CONVERTED
		// QString moviePath(const QString& arg1,KIconLoader::Group arg2,int arg3); >>>> NOT CONVERTED
		// QString moviePath(const QString& arg1,KIconLoader::Group arg2); >>>> NOT CONVERTED
		// QStringList loadAnimated(const QString& arg1,KIconLoader::Group arg2,int arg3); >>>> NOT CONVERTED
		// QStringList loadAnimated(const QString& arg1,KIconLoader::Group arg2); >>>> NOT CONVERTED
		// QStringList queryIcons(int arg1,KIconLoader::Context arg2); >>>> NOT CONVERTED
		// QStringList queryIconsByContext(int arg1,KIconLoader::Context arg2); >>>> NOT CONVERTED
		// bool hasContext(KIconLoader::Context arg1); >>>> NOT CONVERTED
		// int currentSize(KIconLoader::Group arg1); >>>> NOT CONVERTED
		// KIconTheme* theme(); >>>> NOT CONVERTED
		/// <remarks>
		///  Constructs an iconloader.
		/// <param> name="appname" Add the data directories of this application to the
		///  icon search path for the "User" group. The default argument adds the
		///  directories of the current application.
		/// </param><param> name="dirs" the KStandardDirs object to use. If null the global one is used
		/// </param> Usually, you use the default iconloader, which can be accessed via
		///  KIconLoader.Global(), so you hardly ever have to create an
		///  iconloader object yourself. That one is the current KComponentData's
		///  (typically KApplication's) iconloader.
		///      </remarks>		<short>    Constructs an iconloader.</short>
		public KIconLoader(string appname, KStandardDirs dirs, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIconLoader$##", "KIconLoader(const QString&, KStandardDirs*, QObject*)", typeof(void), typeof(string), appname, typeof(KStandardDirs), dirs, typeof(QObject), parent);
		}
		public KIconLoader(string appname, KStandardDirs dirs) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIconLoader$#", "KIconLoader(const QString&, KStandardDirs*)", typeof(void), typeof(string), appname, typeof(KStandardDirs), dirs);
		}
		public KIconLoader(string appname) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIconLoader$", "KIconLoader(const QString&)", typeof(void), typeof(string), appname);
		}
		public KIconLoader() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIconLoader", "KIconLoader()", typeof(void));
		}
		/// <remarks>
		///  Constructs an iconloader.
		/// <param> name="componentData" the KComponentData to use to create this icon loader.
		/// </param> Usually, you use the default iconloader, which can be accessed via
		///  KIconLoader.Global(), so you hardly ever have to create an
		///  iconloader object yourself. That one is the current KComponentData's
		///  (typically KApplication's) iconloader.
		///      </remarks>		<short>    Constructs an iconloader.</short>
		public KIconLoader(KComponentData componentData, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIconLoader##", "KIconLoader(const KComponentData&, QObject*)", typeof(void), typeof(KComponentData), componentData, typeof(QObject), parent);
		}
		public KIconLoader(KComponentData componentData) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KIconLoader#", "KIconLoader(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
		}
		/// <remarks>
		///  Adds <code>appname</code> to the list of application specific directories.
		/// <param> name="appname" The application name.
		///      </param></remarks>		<short>    Adds <code>appname</code> to the list of application specific directories.</short>
		public void AddAppDir(string appname) {
			interceptor.Invoke("addAppDir$", "addAppDir(const QString&)", typeof(void), typeof(string), appname);
		}
		/// <remarks>
		///  Loads an icon. It will try very hard to find an icon which is
		///  suitable. If no exact match is found, a close match is searched.
		///  If neither an exact nor a close match is found, a null pixmap or
		///  the "unknown" pixmap is returned, depending on the value of the
		///  <code>canReturnNull</code> parameter.
		/// <param> name="name" The name of the icon, without extension.
		/// </param><param> name="group" The icon group. This will specify the size of and effects to
		///  be applied to the icon.
		/// </param><param> name="size" If nonzero, this overrides the size specified by <code>group.</code>
		///              See K3Icon.StdSizes.
		/// </param><param> name="state" The icon state: <code>DefaultState</code>, <code>ActiveState</code> or
		///  <code>DisabledState.</code> Depending on the user's preferences, the iconloader
		///  may apply a visual effect to hint about its state.
		/// </param><param> name="overlays" a list of emblem icons to overlay, by name. the emblem
		///                  prefix is applied automatically to each name, e.g.
		///                  "zip" becomes "emblem-zip"
		/// </param><param> name="path_store" If not null, the path of the icon is stored here.
		/// </param><param> name="canReturnNull" Can return a null pixmap? If false, the
		///  "unknown" pixmap is returned when no appropriate icon has been found.
		/// </param></remarks>		<return> the QPixmap. Can be null when not found, depending on
		///          <code>canReturnNull.</code>
		///      </return>
		/// 		<short>    Loads an icon.</short>
		/// <remarks>
		///  Loads an icon for a mimetype.
		///  This is basically like loadIcon except that extra desktop themes are loaded if necessary.
		/// <param> name="iconName" The name of the icon, without extension, usually from KMimeType.
		/// </param><param> name="group" The icon group. This will specify the size of and effects to
		///  be applied to the icon.
		/// </param><param> name="size" If nonzero, this overrides the size specified by <code>group.</code>
		///              See K3Icon.StdSizes.
		/// </param><param> name="state" The icon state: <code>DefaultState</code>, <code>ActiveState</code> or
		///  <code>DisabledState.</code> Depending on the user's preferences, the iconloader
		///  may apply a visual effect to hint about its state.
		/// </param><param> name="path_store" If not null, the path of the icon is stored here.
		/// </param><param> name="overlays" a list of emblem icons to overlay, by name. the emblem
		///                  prefix is applied automatically to each name, e.g.
		///                  "zip" becomes "emblem-zip"
		/// </param></remarks>		<return> the QPixmap. Can not be null, the
		///  "unknown" pixmap is returned when no appropriate icon has been found.
		///      </return>
		/// 		<short>    Loads an icon for a mimetype.</short>
		/// <remarks>
		///  Returns the path of an icon.
		/// <param> name="name" The name of the icon, without extension. If an absolute
		///  path is supplied for this parameter, iconPath will return it
		///  directly.
		/// </param><param> name="group_or_size" If positive, search icons whose size is
		///  specified by the icon group <code>group_or_size.</code> If negative, search
		///  icons whose size is - <code>group_or_size.</code>
		///              See K3Icon.Group and K3Icon.StdSizes
		/// </param><param> name="canReturnNull" Can return a null string? If not, a path to the
		///                       "unknown" icon will be returned.
		/// </param></remarks>		<return> the path of an icon, can be null or the "unknown" icon when
		///          not found, depending on <code>canReturnNull.</code>
		///      </return>
		/// 		<short>    Returns the path of an icon.</short>
		public string IconPath(string name, int group_or_size, bool canReturnNull) {
			return (string) interceptor.Invoke("iconPath$$$", "iconPath(const QString&, int, bool) const", typeof(string), typeof(string), name, typeof(int), group_or_size, typeof(bool), canReturnNull);
		}
		public string IconPath(string name, int group_or_size) {
			return (string) interceptor.Invoke("iconPath$$", "iconPath(const QString&, int) const", typeof(string), typeof(string), name, typeof(int), group_or_size);
		}
		/// <remarks>
		///  Loads an animated icon.
		/// <param> name="name" The name of the icon.
		/// </param><param> name="group" The icon group. See loadIcon().
		/// </param><param> name="size" Override the default size for <code>group.</code>
		///              See K3Icon.StdSizes.
		/// </param><param> name="parent" The parent object of the returned QMovie.
		/// </param></remarks>		<return> A QMovie object. Can be null if not found or not valid.
		///          Ownership is passed to the caller.
		///      </return>
		/// 		<short>    Loads an animated icon.</short>
		/// <remarks>
		///  Returns the path to an animated icon.
		/// <param> name="name" The name of the icon.
		/// </param><param> name="group" The icon group. See loadIcon().
		/// </param><param> name="size" Override the default size for <code>group.</code>
		///              See K3Icon.StdSizes.
		/// </param></remarks>		<return> the full path to the movie, ready to be passed to QMovie's constructor.
		///  Empty string if not found.
		///      </return>
		/// 		<short>    Returns the path to an animated icon.</short>
		/// <remarks>
		///  Loads an animated icon as a series of still frames. If you want to load
		///  a .mng animation as QMovie instead, please use loadMovie() instead.
		/// <param> name="name" The name of the icon.
		/// </param><param> name="group" The icon group. See loadIcon().
		/// </param><param> name="size" Override the default size for <code>group.</code>
		///              See K3Icon.StdSizes.
		/// </param></remarks>		<return> A List<string> containing the absolute path of all the frames
		///  making up the animation.
		///      </return>
		/// 		<short>    Loads an animated icon as a series of still frames.</short>
		/// <remarks>
		///  Queries all available icons for a specific group, having a specific
		///  context.
		/// <param> name="group_or_size" If positive, search icons whose size is
		///  specified by the icon group <code>group_or_size.</code> If negative, search
		///  icons whose size is - <code>group_or_size.</code>
		///              See K3Icon.Group and K3Icon.StdSizes
		/// </param><param> name="context" The icon context.
		/// </param></remarks>		<return> a list of all icons
		///      </return>
		/// 		<short>    Queries all available icons for a specific group, having a specific  context.</short>
		public List<string> QueryIcons(int group_or_size) {
			return (List<string>) interceptor.Invoke("queryIcons$", "queryIcons(int) const", typeof(List<string>), typeof(int), group_or_size);
		}
		/// <remarks>
		///  Queries all available icons for a specific context.
		/// <param> name="group_or_size" The icon preferred group or size. If available
		///  at this group or size, those icons will be returned, in other case,
		///  icons of undefined size will be returned. Positive numbers are groups,
		///  negative numbers are negated sizes. See K3Icon.Group and
		///  K3Icon.StdSizes
		/// </param><param> name="context" The icon context.
		/// </param></remarks>		<return> A List<string> containing the icon names
		///  available for that context
		///      </return>
		/// 		<short>    Queries all available icons for a specific context.</short>
		public List<string> QueryIconsByContext(int group_or_size) {
			return (List<string>) interceptor.Invoke("queryIconsByContext$", "queryIconsByContext(int) const", typeof(List<string>), typeof(int), group_or_size);
		}
		/// <remarks>
		///      </remarks>		<short>   </short>
		/// <remarks>
		///  Returns a list of all icons (.png or .xpm extension) in the
		///  given directory.
		/// <param> name="iconsDir" the directory to search in
		/// </param></remarks>		<return> A List<string> containing the icon paths
		///      </return>
		/// 		<short>    Returns a list of all icons ( .</short>
		public List<string> QueryIconsByDir(string iconsDir) {
			return (List<string>) interceptor.Invoke("queryIconsByDir$", "queryIconsByDir(const QString&) const", typeof(List<string>), typeof(string), iconsDir);
		}
		/// <remarks>
		///  Returns the current size of the group.
		/// <param> name="group" the group to check.
		/// </param></remarks>		<return> the current size for an icon group.
		///      </return>
		/// 		<short>    Returns the current size of the group.</short>
		/// <remarks>
		///  Returns a pointer to the current theme. Can be used to query
		///  available and default sizes for groups.
		/// </remarks>		<return> a pointer to the current theme. 0 if no theme set.
		///      </return>
		/// 		<short>    Returns a pointer to the current theme.</short>
		/// <remarks>
		///  Returns a pointer to the KIconEffect object used by the icon loader.
		/// </remarks>		<return> the KIconEffect.
		///      </return>
		/// 		<short>    Returns a pointer to the KIconEffect object used by the icon loader.</short>
		public KIconEffect IconEffect() {
			return (KIconEffect) interceptor.Invoke("iconEffect", "iconEffect() const", typeof(KIconEffect));
		}
		/// <remarks>
		///  Called by KComponentData.NewIconLoader to reconfigure the icon loader.
		/// <param> name="_appname" the new application name
		/// </param><param> name="_dirs" the new standard directories. If 0, the directories
		///               from KGlobal will be taken.
		///      </param></remarks>		<short>    Called by KComponentData.NewIconLoader to reconfigure the icon loader.</short>
		public void Reconfigure(string _appname, KStandardDirs _dirs) {
			interceptor.Invoke("reconfigure$#", "reconfigure(const QString&, KStandardDirs*)", typeof(void), typeof(string), _appname, typeof(KStandardDirs), _dirs);
		}
		/// <remarks>
		///  Adds all the default themes from other desktops at the end of
		///  the list of icon themes.
		///      </remarks>		<short>    Adds all the default themes from other desktops at the end of  the list of icon themes.</short>
		public void AddExtraDesktopThemes() {
			interceptor.Invoke("addExtraDesktopThemes", "addExtraDesktopThemes()", typeof(void));
		}
		/// <remarks>
		///  Returns if the default icon themes of other desktops have been added
		///  to the list of icon themes where icons are searched.
		///      </remarks>		<short>    Returns if the default icon themes of other desktops have been added  to the list of icon themes where icons are searched.</short>
		public bool ExtraDesktopThemesAdded() {
			return (bool) interceptor.Invoke("extraDesktopThemesAdded", "extraDesktopThemesAdded() const", typeof(bool));
		}
		/// <remarks>
		///  Re-initialize the global icon loader
		///     </remarks>		<short>    Re-initialize the global icon loader     </short>
		[Q_SLOT("void newIconLoader()")]
		public void NewIconLoader() {
			interceptor.Invoke("newIconLoader", "newIconLoader()", typeof(void));
		}
		~KIconLoader() {
			interceptor.Invoke("~KIconLoader", "~KIconLoader()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KIconLoader", "~KIconLoader()", typeof(void));
		}
		/// <remarks>
		///  Returns the global icon loader initialized with the global KComponentData.
		///  Therefore you must have a KComponentData instantiated before calling this.
		/// </remarks>		<return> global icon loader
		///      </return>
		/// 		<short>    Returns the global icon loader initialized with the global KComponentData.</short>
		public static KIconLoader Global() {
			return (KIconLoader) staticInterceptor.Invoke("global", "global()", typeof(KIconLoader));
		}
		/// <remarks>
		///  Returns the unknown icon. An icon that is used when no other icon
		///  can be found.
		/// </remarks>		<return> the unknown pixmap
		///      </return>
		/// 		<short>    Returns the unknown icon.</short>
		public static QPixmap Unknown() {
			return (QPixmap) staticInterceptor.Invoke("unknown", "unknown()", typeof(QPixmap));
		}
		protected new IKIconLoaderSignals Emit {
			get { return (IKIconLoaderSignals) Q_EMIT; }
		}
	}

	public interface IKIconLoaderSignals : IQObjectSignals {
	}
}
