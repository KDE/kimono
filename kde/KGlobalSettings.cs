//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  Access the KDE global configuration.
    /// </remarks>        <author> David Faure \<faure@kde.org\>
    ///  </author>
    ///         <short>    Access the KDE global configuration.</short>
    [SmokeClass("KGlobalSettings")]
    public class KGlobalSettings : QObject {
        protected KGlobalSettings(Type dummy) : base((Type) null) {}
        /// <remarks>
        ///  Describes the mouse settings.
        ///      </remarks>        <short>    Describes the mouse settings.</short>
        [SmokeClass("KGlobalSettings::KMouseSettings")]
        public class KMouseSettings : Object {
            protected SmokeInvocation interceptor = null;
            private IntPtr smokeObject;
            protected KMouseSettings(Type dummy) {}
            public const int RightHanded = 0;
            public const int LeftHanded = 1;
            public int Handed {
                get { return (int) interceptor.Invoke("handed", "handed()", typeof(int)); }
                set { interceptor.Invoke("setHanded$", "setHanded(int)", typeof(void), typeof(int), value); }
            }
        }
        private static SmokeInvocation staticInterceptor = null;
        static KGlobalSettings() {
            staticInterceptor = new SmokeInvocation(typeof(KGlobalSettings), null);
        }
        /// <remarks>
        ///  This enum describes the return type for insertTearOffHandle() whether to insert
        ///  a handle or not. Applications who independently want to use handles in their popup menus
        ///  should test for Application level before calling the appropriate function in KMenu.
        /// </remarks>        <short>    This enum describes the return type for insertTearOffHandle() whether to insert  a handle or not.</short>
        public enum TearOffHandle {
            Disable = 0,
            ApplicationLevel = 1,
            Enable = 2,
        }
        /// <remarks>
        ///  This enum describes the completion mode used for by the KCompletion class.
        ///  See <a href="http://developer.kde.org/documentation/standards/kde/style/keys/completion.html">
        ///  the styleguide</a>.
        /// </remarks>        <short>    This enum describes the completion mode used for by the KCompletion class.</short>
        public enum Completion {
            CompletionNone = 1,
            CompletionAuto = 2,
            CompletionMan = 3,
            CompletionShell = 4,
            CompletionPopup = 5,
            CompletionPopupAuto = 6,
        }
        public enum GraphicEffect {
            NoEffects = 0x0000,
            GradientEffects = 0x0001,
            SimpleAnimationEffects = 0x0002,
            ComplexAnimationEffects = 0x0006,
        }
        /// <remarks>
        ///  An identifier for change signals.
        ///  \see emitChange
        ///      </remarks>        <short>    An identifier for change signals.</short>
        public enum ChangeType {
            PaletteChanged = 0,
            FontChanged = 1,
            StyleChanged = 2,
            SettingsChanged = 3,
            IconChanged = 4,
            CursorChanged = 5,
            ToolbarStyleChanged = 6,
            ClipboardConfigChanged = 7,
            BlockShortcuts = 8,
        }
        /// <remarks>
        ///  Valid values for the settingsChanged signal
        ///      </remarks>        <short>    Valid values for the settingsChanged signal      </short>
        public enum SettingsCategory {
            SETTINGS_MOUSE = 0,
            SETTINGS_COMPLETION = 1,
            SETTINGS_PATHS = 2,
            SETTINGS_POPUPMENU = 3,
            SETTINGS_QT = 4,
            SETTINGS_SHORTCUTS = 5,
        }
        // KGlobalSettings::KMouseSettings& mouseSettings(); >>>> NOT CONVERTED
        /// <remarks>
        ///  Returns a threshold in pixels for drag & drop operations.
        ///  As long as the mouse movement has not exceeded this number
        ///  of pixels in either X or Y direction no drag operation may
        ///  be started. This prevents spurious drags when the user intended
        ///  to click on something but moved the mouse a bit while doing so.
        ///  For this to work you must save the position of the mouse (oldPos)
        ///  in the QWidget.MousePressEvent().
        ///  When the position of the mouse (newPos)
        ///  in a QWidget.MouseMoveEvent() exceeds this threshold
        ///  you may start a drag
        ///  which should originate from oldPos.
        ///  Example code:
        ///  <pre>
        ///  void KColorCells.MousePressEvent( QMouseEvent e )
        ///  {
        ///     mOldPos = e.Pos();
        ///  }
        ///  void KColorCells.MouseMoveEvent( QMouseEvent e )
        ///  {
        ///     if( !(e.State() && LeftButton)) return;
        ///     int delay = KGlobalSettings.DndEventDelay();
        ///     QPoint newPos = e.Pos();
        ///     if(newPos.x() > mOldPos.x()+delay || newPos.x() < mOldPos.x()-delay ||
        ///        newPos.y() > mOldPos.y()+delay || newPos.y() < mOldPos.y()-delay)
        ///     {
        ///        // Drag color object
        ///        int cell = posToCell(mOldPos); // Find color at mOldPos
        ///        if ((cell != -1) && colors[cell].isValid())
        ///        {
        ///           KColorDrag d = KColorDrag.MakeDrag( colors[cell], this);
        ///           d.DragCopy();
        ///        }
        ///     }
        ///  }
        ///  </pre>
        /// </remarks>        <return> the threshold for drag & drop in pixels
        ///      </return>
        ///         <short>    Returns a threshold in pixels for drag & drop operations.</short>
        public static int DndEventDelay() {
            return (int) staticInterceptor.Invoke("dndEventDelay", "dndEventDelay()", typeof(int));
        }
        /// <remarks>
        ///  Returns whether KDE runs in single (default) or double click
        ///  mode.
        ///  see http://developer.kde.org/documentation/standards/kde/style/mouse/index.html
        /// </remarks>        <return> true if single click mode, or false if double click mode.
        /// </return>
        ///         <short>    Returns whether KDE runs in single (default) or double click  mode.</short>
        public static bool SingleClick() {
            return (bool) staticInterceptor.Invoke("singleClick", "singleClick()", typeof(bool));
        }
        /// <remarks>
        ///  Returns if item views should force smooth scrolling.
        /// </remarks>        <return> true if smooth scrolling is enabled for item view, false otherwise.
        /// </return>
        ///         <short>    Returns if item views should force smooth scrolling.</short>
        public static bool SmoothScroll() {
            return (bool) staticInterceptor.Invoke("smoothScroll", "smoothScroll()", typeof(bool));
        }
        /// <remarks>
        ///  Returns whether tear-off handles are inserted in KMenus.
        /// </remarks>        <return> whether tear-off handles are inserted in KMenus.
        /// </return>
        ///         <short>    Returns whether tear-off handles are inserted in KMenus.</short>
        public static KGlobalSettings.TearOffHandle InsertTearOffHandle() {
            return (KGlobalSettings.TearOffHandle) staticInterceptor.Invoke("insertTearOffHandle", "insertTearOffHandle()", typeof(KGlobalSettings.TearOffHandle));
        }
        /// <remarks>
        ///  Checks whether the cursor changes over icons.
        /// </remarks>        <return> the KDE setting for "change cursor over icon"
        ///      </return>
        ///         <short>    Checks whether the cursor changes over icons.</short>
        public static bool ChangeCursorOverIcon() {
            return (bool) staticInterceptor.Invoke("changeCursorOverIcon", "changeCursorOverIcon()", typeof(bool));
        }
        /// <remarks>
        ///  Returns the KDE setting for the auto-select option.
        /// </remarks>        <return> the auto-select delay or -1 if auto-select is disabled.
        ///      </return>
        ///         <short>    Returns the KDE setting for the auto-select option.</short>
        public static int AutoSelectDelay() {
            return (int) staticInterceptor.Invoke("autoSelectDelay", "autoSelectDelay()", typeof(int));
        }
        /// <remarks>
        ///  Returns the KDE setting for context menus.
        /// </remarks>        <return> whether context menus should be shown on button press
        ///  or button release (click).
        ///      </return>
        ///         <short>    Returns the KDE setting for context menus.</short>
        public static bool ShowContextMenusOnPress() {
            return (bool) staticInterceptor.Invoke("showContextMenusOnPress", "showContextMenusOnPress()", typeof(bool));
        }
        /// <remarks>
        ///  Returns the preferred completion mode setting.
        /// </remarks>        <return> Completion.  Default is <code>CompletionPopup.</code>
        ///      </return>
        ///         <short>    Returns the preferred completion mode setting.</short>
        public static KGlobalSettings.Completion CompletionMode() {
            return (KGlobalSettings.Completion) staticInterceptor.Invoke("completionMode", "completionMode()", typeof(KGlobalSettings.Completion));
        }
        /// <remarks>
        ///  This returns the current mouse settings.
        ///  On Windows, settings are retrieved from the system.
        /// </remarks>        <return> the current mouse settings
        ///      </return>
        ///         <short>    This returns the current mouse settings.</short>
        /// <remarks>
        ///  The path to the desktop directory of the current user.
        /// </remarks>        <return> the user's desktop directory
        ///      </return>
        ///         <short>    The path to the desktop directory of the current user.</short>
        public static string DesktopPath() {
            return (string) staticInterceptor.Invoke("desktopPath", "desktopPath()", typeof(string));
        }
        /// <remarks>
        ///  The path to the autostart directory of the current user.
        /// </remarks>        <return> the path of the autostart directory
        ///      </return>
        ///         <short>    The path to the autostart directory of the current user.</short>
        public static string AutostartPath() {
            return (string) staticInterceptor.Invoke("autostartPath", "autostartPath()", typeof(string));
        }
        /// <remarks>
        ///  The path where documents are stored of the current user.
        /// </remarks>        <return> the path of the document directory
        ///      </return>
        ///         <short>    The path where documents are stored of the current user.</short>
        public static string DocumentPath() {
            return (string) staticInterceptor.Invoke("documentPath", "documentPath()", typeof(string));
        }
        /// <remarks>
        ///  The default color to use for inactive titles.
        /// </remarks>        <return> the inactive title color
        ///      </return>
        ///         <short>    The default color to use for inactive titles.</short>
        public static QColor InactiveTitleColor() {
            return (QColor) staticInterceptor.Invoke("inactiveTitleColor", "inactiveTitleColor()", typeof(QColor));
        }
        /// <remarks>
        ///  The default color to use for inactive texts.
        /// </remarks>        <return> the inactive text color
        ///      </return>
        ///         <short>    The default color to use for inactive texts.</short>
        public static QColor InactiveTextColor() {
            return (QColor) staticInterceptor.Invoke("inactiveTextColor", "inactiveTextColor()", typeof(QColor));
        }
        /// <remarks>
        ///  The default color to use for active titles.
        /// </remarks>        <return> the active title color
        ///      </return>
        ///         <short>    The default color to use for active titles.</short>
        public static QColor ActiveTitleColor() {
            return (QColor) staticInterceptor.Invoke("activeTitleColor", "activeTitleColor()", typeof(QColor));
        }
        /// <remarks>
        ///  The default color to use for active texts.
        /// </remarks>        <return> the active text color
        ///      </return>
        ///         <short>    The default color to use for active texts.</short>
        public static QColor ActiveTextColor() {
            return (QColor) staticInterceptor.Invoke("activeTextColor", "activeTextColor()", typeof(QColor));
        }
        /// <remarks>
        ///  Returns the contrast for borders.
        /// </remarks>        <return> the contrast (between 0 for minimum and 10 for maximum
        ///          contrast)
        ///      </return>
        ///         <short>    Returns the contrast for borders.</short>
        public static int Contrast() {
            return (int) staticInterceptor.Invoke("contrast", "contrast()", typeof(int));
        }
        /// <remarks>
        ///  Returns the contrast for borders as a floating point value.
        /// <param> name="config" pointer to the config from which to read the contrast
        ///  setting (the default is to use KGlobal.Config())
        /// </param></remarks>        <return> the contrast (between 0.0 for minimum and 1.0 for maximum
        ///          contrast)
        ///      </return>
        ///         <short>    Returns the contrast for borders as a floating point value.</short>
        public static double ContrastF(KSharedConfig config) {
            return (double) staticInterceptor.Invoke("contrastF?", "contrastF(const KSharedPtr<KSharedConfig>&)", typeof(double), typeof(KSharedConfig), config);
        }
        public static double ContrastF() {
            return (double) staticInterceptor.Invoke("contrastF", "contrastF()", typeof(double));
        }
        /// <remarks>
        ///  Returns if the sorted column in a K3ListView shall be drawn with a
        ///  shaded background color.
        /// </remarks>        <return> true if the sorted column shall be shaded
        ///      </return>
        ///         <short>    Returns if the sorted column in a K3ListView shall be drawn with a  shaded background color.</short>
        public static bool ShadeSortColumn() {
            return (bool) staticInterceptor.Invoke("shadeSortColumn", "shadeSortColumn()", typeof(bool));
        }
        /// <remarks>
        ///  Returns if default background images are allowed by the color scheme.
        ///  A "default" background image is just that, i.e. the user has not
        ///  actively selected a background image to use.
        /// </remarks>        <return> true if default background images may be used
        ///      </return>
        ///         <short>    Returns if default background images are allowed by the color scheme.</short>
        public static bool AllowDefaultBackgroundImages() {
            return (bool) staticInterceptor.Invoke("allowDefaultBackgroundImages", "allowDefaultBackgroundImages()", typeof(bool));
        }
        /// <remarks>
        ///  Returns the default general font.
        /// </remarks>        <return> the default general font.
        ///      </return>
        ///         <short>    Returns the default general font.</short>
        public static QFont GeneralFont() {
            return (QFont) staticInterceptor.Invoke("generalFont", "generalFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns the default fixed font.
        /// </remarks>        <return> the default fixed font.
        ///      </return>
        ///         <short>    Returns the default fixed font.</short>
        public static QFont FixedFont() {
            return (QFont) staticInterceptor.Invoke("fixedFont", "fixedFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns the default toolbar font.
        /// </remarks>        <return> the default toolbar font.
        ///      </return>
        ///         <short>    Returns the default toolbar font.</short>
        public static QFont ToolBarFont() {
            return (QFont) staticInterceptor.Invoke("toolBarFont", "toolBarFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns the default menu font.
        /// </remarks>        <return> the default menu font.
        ///      </return>
        ///         <short>    Returns the default menu font.</short>
        public static QFont MenuFont() {
            return (QFont) staticInterceptor.Invoke("menuFont", "menuFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns the default window title font.
        /// </remarks>        <return> the default window title font.
        ///      </return>
        ///         <short>    Returns the default window title font.</short>
        public static QFont WindowTitleFont() {
            return (QFont) staticInterceptor.Invoke("windowTitleFont", "windowTitleFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns the default taskbar font.
        /// </remarks>        <return> the default taskbar font.
        ///      </return>
        ///         <short>    Returns the default taskbar font.</short>
        public static QFont TaskbarFont() {
            return (QFont) staticInterceptor.Invoke("taskbarFont", "taskbarFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns a font of approx. 48 pt. capable of showing <code>text.</code>
        /// <param> name="text" the text to test
        /// </param></remarks>        <return> the font that is capable to show the text with 48 pt
        ///      </return>
        ///         <short>    Returns a font of approx.</short>
        public static QFont LargeFont(string text) {
            return (QFont) staticInterceptor.Invoke("largeFont$", "largeFont(const QString&)", typeof(QFont), typeof(string), text);
        }
        public static QFont LargeFont() {
            return (QFont) staticInterceptor.Invoke("largeFont", "largeFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns the smallest readable font. This can be used in dockers,
        ///  rulers and other places where space is at a premium.
        ///      </remarks>        <short>    Returns the smallest readable font.</short>
        public static QFont SmallestReadableFont() {
            return (QFont) staticInterceptor.Invoke("smallestReadableFont", "smallestReadableFont()", typeof(QFont));
        }
        /// <remarks>
        ///  Returns if the user specified multihead. In case the display
        ///  has multiple screens, the return value of this function specifies
        ///  if the user wants KDE to run on all of them or just on the primary
        ///  On Windows, settings are retrieved from the system.
        /// </remarks>        <return> true if the user chose multi head
        ///      </return>
        ///         <short>    Returns if the user specified multihead.</short>
        public static bool IsMultiHead() {
            return (bool) staticInterceptor.Invoke("isMultiHead", "isMultiHead()", typeof(bool));
        }
        /// <remarks>
        ///  Typically, QScrollView derived classes can be scrolled fast by
        ///  holding down the Ctrl-button during wheel-scrolling.
        ///  But QTextEdit and derived classes perform zooming instead of fast
        ///  scrolling.
        ///  This value determines whether the user wants to zoom or scroll fast
        ///  with Ctrl-wheelscroll.
        /// </remarks>        <return> true if the user wishes to zoom with the mouse wheel,
        ///          false for scrolling
        ///      </return>
        ///         <short>    Typically, QScrollView derived classes can be scrolled fast by  holding down the Ctrl-button during wheel-scrolling.</short>
        public static bool WheelMouseZooms() {
            return (bool) staticInterceptor.Invoke("wheelMouseZooms", "wheelMouseZooms()", typeof(bool));
        }
        /// <remarks>
        ///  This function returns the desktop geometry for an application's splash
        ///  screen.  It takes into account the user's display settings (number of
        ///  screens, Xinerama, etc), and the user's preferences (if KDE should be
        ///  Xinerama aware).
        /// </remarks>        <return> the geometry to use for the desktop.  Note that it might not
        ///          start at (0,0).
        ///      </return>
        ///         <short>    This function returns the desktop geometry for an application's splash  screen.</short>
        public static QRect SplashScreenDesktopGeometry() {
            return (QRect) staticInterceptor.Invoke("splashScreenDesktopGeometry", "splashScreenDesktopGeometry()", typeof(QRect));
        }
        /// <remarks>
        ///  This function returns the desktop geometry for an application that needs
        ///  to set the geometry of a widget on the screen manually.  It takes into
        ///  account the user's display settings (number of screens, Xinerama, etc),
        ///  and the user's preferences (if KDE should be Xinerama aware).
        ///  Note that this can break in multi-head (not Xinerama) mode because this
        ///  point could be on multiple screens.  Use with care.
        /// <param> name="point" a reference point for the widget, for instance one that the
        ///               widget should be adjacent or on top of.
        /// </param></remarks>        <return> the geometry to use for the desktop.  Note that it might not
        ///          start at (0,0).
        ///      </return>
        ///         <short>    This function returns the desktop geometry for an application that needs  to set the geometry of a widget on the screen manually.</short>
        public static QRect DesktopGeometry(QPoint point) {
            return (QRect) staticInterceptor.Invoke("desktopGeometry#", "desktopGeometry(const QPoint&)", typeof(QRect), typeof(QPoint), point);
        }
        /// <remarks>
        ///  This function returns the desktop geometry for an application that needs
        ///  to set the geometry of a widget on the screen manually.  It takes into
        ///  account the user's display settings (number of screens, Xinerama, etc),
        ///  and the user's preferences (if KDE should be Xinerama aware).
        /// <param> name="w" the widget in question.  This is used to determine which screen
        ///           to use in Xinerama or multi-head mode.
        /// </param></remarks>        <return> the geometry to use for the desktop.  Note that it might not
        ///          start at (0,0).
        ///      </return>
        ///         <short>    This function returns the desktop geometry for an application that needs  to set the geometry of a widget on the screen manually.</short>
        public static QRect DesktopGeometry(QWidget w) {
            return (QRect) staticInterceptor.Invoke("desktopGeometry#", "desktopGeometry(const QWidget*)", typeof(QRect), typeof(QWidget), w);
        }
        /// <remarks>
        ///  This function determines if the user wishes to see icons on the
        ///  push buttons.
        /// </remarks>        <return> Returns true if user wants to show icons.
        ///      </return>
        ///         <short>    This function determines if the user wishes to see icons on the  push buttons.</short>
        public static bool ShowIconsOnPushButtons() {
            return (bool) staticInterceptor.Invoke("showIconsOnPushButtons", "showIconsOnPushButtons()", typeof(bool));
        }
        /// <remarks>
        ///  This function determines the desired level of effects on the GUI.
        /// </remarks>        <short>    This function determines the desired level of effects on the GUI.</short>
        public static uint GraphicEffectsLevel() {
            return (uint) staticInterceptor.Invoke("graphicEffectsLevel", "graphicEffectsLevel()", typeof(uint));
        }
        /// <remarks>
        ///  This function determines the default level of effects on the GUI
        ///  depending on the system capabilities.
        /// </remarks>        <short>    This function determines the default level of effects on the GUI  depending on the system capabilities.</short>
        public static uint GraphicEffectsLevelDefault() {
            return (uint) staticInterceptor.Invoke("graphicEffectsLevelDefault", "graphicEffectsLevelDefault()", typeof(uint));
        }
        /// <remarks>
        ///  This function determines if the user wishes to see previews
        ///  for the selected url
        /// </remarks>        <return> Returns true if user wants to show previews.
        ///      </return>
        ///         <short>    This function determines if the user wishes to see previews  for the selected url </short>
        public static bool ShowFilePreview(KUrl arg1) {
            return (bool) staticInterceptor.Invoke("showFilePreview#", "showFilePreview(const KUrl&)", typeof(bool), typeof(KUrl), arg1);
        }
        /// <remarks>
        ///  Whether the user wishes to use opaque resizing. Primarily
        ///  intended for QSplitter.SetOpaqueResize()
        /// </remarks>        <return> Returns true if user wants to use opaque resizing.
        ///      </return>
        ///         <short>    Whether the user wishes to use opaque resizing.</short>
        public static bool OpaqueResize() {
            return (bool) staticInterceptor.Invoke("opaqueResize", "opaqueResize()", typeof(bool));
        }
        /// <remarks>
        ///  The layout scheme to use for dialog buttons
        /// </remarks>        <return> Returns the number of the scheme to use.
        ///      </return>
        ///         <short>    The layout scheme to use for dialog buttons </short>
        public static int ButtonLayout() {
            return (int) staticInterceptor.Invoke("buttonLayout", "buttonLayout()", typeof(int));
        }
        /// <remarks>
        ///  Used to obtain the QPalette that will be used to set the application palette.
        ///  This is only useful for configuration modules such as krdb and should not be
        ///  used in normal circumstances.
        /// <param> name="config" KConfig from which to load the colors (passed as-is to
        ///  .KColorScheme).
        /// </param></remarks>        <return> the QPalette
        ///      </return>
        ///         <short>    Used to obtain the QPalette that will be used to set the application palette.</short>
        public static QPalette CreateApplicationPalette(KSharedConfig config) {
            return (QPalette) staticInterceptor.Invoke("createApplicationPalette?", "createApplicationPalette(const KSharedPtr<KSharedConfig>&)", typeof(QPalette), typeof(KSharedConfig), config);
        }
        public static QPalette CreateApplicationPalette() {
            return (QPalette) staticInterceptor.Invoke("createApplicationPalette", "createApplicationPalette()", typeof(QPalette));
        }
        /// <remarks>
        ///  Notifies all KDE applications on the current display of a change.
        ///  This is typically called by kcontrol modules after changing the corresponding
        ///  config file. Do not call this from a normal KDE application.
        ///      </remarks>        <short>    Notifies all KDE applications on the current display of a change.</short>
        public static void EmitChange(KGlobalSettings.ChangeType changeType, int arg) {
            staticInterceptor.Invoke("emitChange$$", "emitChange(KGlobalSettings::ChangeType, int)", typeof(void), typeof(KGlobalSettings.ChangeType), changeType, typeof(int), arg);
        }
        public static void EmitChange(KGlobalSettings.ChangeType changeType) {
            staticInterceptor.Invoke("emitChange$", "emitChange(KGlobalSettings::ChangeType)", typeof(void), typeof(KGlobalSettings.ChangeType), changeType);
        }
        /// <remarks>
        ///  Return the KGlobalSettings singleton.
        ///  This is used to connect to its signals, to be notified of changes.
        ///      </remarks>        <short>    Return the KGlobalSettings singleton.</short>
        public static KGlobalSettings Self() {
            return (KGlobalSettings) staticInterceptor.Invoke("self", "self()", typeof(KGlobalSettings));
        }
        protected new IKGlobalSettingsSignals Emit {
            get { return (IKGlobalSettingsSignals) Q_EMIT; }
        }
    }

    public interface IKGlobalSettingsSignals : IQObjectSignals {
    }
}