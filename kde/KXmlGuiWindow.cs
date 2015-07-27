//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Text;
    using System.Collections.Generic;
    /// <remarks>
    ///  Instead of creating a KMainWindow manually and assigning menus, menu entries,
    ///  toolbar buttons and actions to it by hand, this class can be used to load an
    ///  rc file to manage the main window's actions.
    ///  See http://techbase.kde.org/Development/Tutorials/Using_KActions#XMLGUI
    ///  for essential information on the XML file format and usage of this class.
    ///  </remarks>        <author> Reginald Stadlbauer (reggie@kde.org) Stephan Kulow (coolo@kde.org), Matthias Ettrich (ettrich@kde.org), Chris Schlaeger (cs@kde.org), Sven Radej (radej@kde.org). Maintained by Sven Radej (radej@kde.org)
    /// </author>
    ///         <short> %KDE top level main window with predefined action layout.</short>
    ///         <see> KMainWindow</see>
    [SmokeClass("KXmlGuiWindow")]
    public class KXmlGuiWindow : KMainWindow, IKXMLGUIBuilder, IKXMLGUIClient, IDisposable {
        protected KXmlGuiWindow(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KXmlGuiWindow), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KXmlGuiWindow() {
            staticInterceptor = new SmokeInvocation(typeof(KXmlGuiWindow), null);
        }
        /// <remarks>
        /// </remarks>        <short>   </short>
        ///         <see> setupGUI</see>
        public enum StandardWindowOption {
            ToolBar = 1,
            Keys = 2,
            StatusBar = 4,
            Save = 8,
            Create = 16,
            Default = ToolBar|Keys|StatusBar|Save|Create,
        }
        [Q_PROPERTY("bool", "hasMenuBar")]
        public new bool HasMenuBar {
            get { return (bool) interceptor.Invoke("hasMenuBar", "hasMenuBar()", typeof(bool)); }
        }
        [Q_PROPERTY("bool", "autoSaveSettings")]
        public new bool AutoSaveSettings {
            get { return (bool) interceptor.Invoke("autoSaveSettings", "autoSaveSettings()", typeof(bool)); }
        }
        [Q_PROPERTY("QString", "autoSaveGroup")]
        public new string AutoSaveGroup {
            get { return (string) interceptor.Invoke("autoSaveGroup", "autoSaveGroup()", typeof(string)); }
        }
        [Q_PROPERTY("bool", "standardToolBarMenuEnabled")]
        public bool StandardToolBarMenuEnabled {
            get { return (bool) interceptor.Invoke("isStandardToolBarMenuEnabled", "isStandardToolBarMenuEnabled()", typeof(bool)); }
            set { interceptor.Invoke("setStandardToolBarMenuEnabled$", "setStandardToolBarMenuEnabled(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "initialGeometrySet")]
        public new bool InitialGeometrySet {
            get { return (bool) interceptor.Invoke("initialGeometrySet", "initialGeometrySet()", typeof(bool)); }
        }
        // QWidget* createContainer(QWidget* arg1,int arg2,const QDomElement& arg3,QAction*& arg4); >>>> NOT CONVERTED
        // KXMLGUIClient::StateChange getActionsToChangeForState(const QString& arg1); >>>> NOT CONVERTED
        /// <remarks>
        ///  Construct a main window.
        /// <param> name="parent" The widget parent. This is usually 0 but it may also be the window
        ///  group leader. In that case, the KMainWindow becomes sort of a
        ///  secondary window.
        /// </param><param> name="f" Specify the widget flags. The default is
        ///  WType_TopLevel and WDestructiveClose.  TopLevel indicates that a
        ///  main window is a toplevel window, regardless of whether it has a
        ///  parent or not. DestructiveClose indicates that a main window is
        ///  automatically destroyed when its window is closed. Pass 0 if
        ///  you do not want this behavior.
        /// </param> KMainWindows must be created on the heap with 'new', like:
        ///  <pre>
        ///  KMainWindow kmw = new KMainWindow(...);
        ///  kmw.SetObjectName(...);
        ///  </pre>
        ///  IMPORTANT: For session management and window management to work
        ///  properly, all main windows in the application should have a
        ///  different name. If you don't do it, KMainWindow will create
        ///  a unique name, but it's recommended to explicitly pass a window name that will
        ///  also describe the type of the window. If there can be several windows of the same
        ///  type, append '#' (hash) to the name, and KMainWindow will replace it with numbers to make
        ///  the names unique. For example, for a mail client which has one main window showing
        ///  the mails and folders, and which can also have one or more windows for composing
        ///  mails, the name for the folders window should be e.g. "mainwindow" and
        ///  for the composer windows "composer#".
        ///      </remarks>        <short>    Construct a main window.</short>
        ///         <see> http://doc.trolltech.com/3.2/qt.html#WidgetFlags-enum</see>
        public KXmlGuiWindow(QWidget parent, uint f) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KXmlGuiWindow#$", "KXmlGuiWindow(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), f);
        }
        public KXmlGuiWindow(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KXmlGuiWindow#", "KXmlGuiWindow(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KXmlGuiWindow() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KXmlGuiWindow", "KXmlGuiWindow()", typeof(void));
        }
        /// <remarks>
        ///  Enables the build of a standard help menu when calling createGUI().
        ///  The default behavior is to build one, you must call this function
        ///  to disable it
        ///      </remarks>        <short>    Enables the build of a standard help menu when calling createGUI().</short>
        public void SetHelpMenuEnabled(bool showHelpMenu) {
            interceptor.Invoke("setHelpMenuEnabled$", "setHelpMenuEnabled(bool)", typeof(void), typeof(bool), showHelpMenu);
        }
        public void SetHelpMenuEnabled() {
            interceptor.Invoke("setHelpMenuEnabled", "setHelpMenuEnabled()", typeof(void));
        }
        /// <remarks>
        ///  Return <code>true</code> when the help menu is enabled
        ///      </remarks>        <short>    Return <code>true</code> when the help menu is enabled      </short>
        public bool IsHelpMenuEnabled() {
            return (bool) interceptor.Invoke("isHelpMenuEnabled", "isHelpMenuEnabled() const", typeof(bool));
        }
        [SmokeMethod("guiFactory()")]
        public virtual KXMLGUIFactory GuiFactory() {
            return (KXMLGUIFactory) interceptor.Invoke("guiFactory", "guiFactory()", typeof(KXMLGUIFactory));
        }
        /// <remarks>
        ///  Create a GUI given a local XML file.
        ///  If <code>xmlfile</code> is NULL,
        ///  then it will try to construct a local XML filename like
        ///  appnameui.rc where 'appname' is your app's name.  If that file
        ///  does not exist, then the XML UI code will only use the global
        ///  (standard) XML file for the layout purposes.
        /// <param> name="xmlfile" The local xmlfile (relative or absolute)
        ///      </param></remarks>        <short>    Create a GUI given a local XML file.</short>
        public void CreateGUI(string xmlfile) {
            interceptor.Invoke("createGUI$", "createGUI(const QString&)", typeof(void), typeof(string), xmlfile);
        }
        public void CreateGUI() {
            interceptor.Invoke("createGUI", "createGUI()", typeof(void));
        }
        /// <remarks>
        ///  Sets whether KMainWindow should provide a menu that allows showing/hiding
        ///  of the statusbar ( using KToggleStatusBarAction ).
        ///  The menu / menu item is implemented using xmlgui. It will be inserted
        ///  in your menu structure in the 'Settings' menu.
        ///  Note that you should enable this feature before calling createGUI()
        ///  ( or similar ).
        ///  If an application maintains the action on its own (i.e. never calls
        ///  this function) a connection needs to be made to let KMainWindow
        ///  know when that status (hidden/shown) of the statusbar has changed.
        ///  For example:
        ///  connect(action, SIGNAL("activated()"),
        ///          kmainwindow, SLOT("setSettingsDirty()"));
        ///  Otherwise the status (hidden/show) of the statusbar might not be saved
        ///  by KMainWindow.
        ///      </remarks>        <short>    Sets whether KMainWindow should provide a menu that allows showing/hiding  of the statusbar ( using KToggleStatusBarAction ).</short>
        public void CreateStandardStatusBarAction() {
            interceptor.Invoke("createStandardStatusBarAction", "createStandardStatusBarAction()", typeof(void));
        }
        /// <remarks>
        ///  Configures the current windows and its actions in the typical KDE
        ///  fashion.  The options are all enabled by default but can be turned
        ///  off if desired through the params or if the prereqs don't exists.
        ///  Typically this function replaces createGUI().
        ///      </remarks>        <short>    Configures the current windows and its actions in the typical KDE  fashion.</short>
        ///         <see> StandardWindowOptions</see>
        public void SetupGUI(uint options, string xmlfile) {
            interceptor.Invoke("setupGUI$$", "setupGUI(KXmlGuiWindow::StandardWindowOptions, const QString&)", typeof(void), typeof(uint), options, typeof(string), xmlfile);
        }
        public void SetupGUI(uint options) {
            interceptor.Invoke("setupGUI$", "setupGUI(KXmlGuiWindow::StandardWindowOptions)", typeof(void), typeof(uint), options);
        }
        public void SetupGUI() {
            interceptor.Invoke("setupGUI", "setupGUI()", typeof(void));
        }
        /// <remarks>
        ///  Configures the current windows and its actions in the typical KDE
        ///  fashion.  The options are all enabled by default but can be turned
        ///  off if desired through the params or if the prereqs don't exists.
        ///  <code>defaultSize</code> The default size of the window
        ///  Typically this function replaces createGUI().
        /// </remarks>        <short>    Configures the current windows and its actions in the typical KDE  fashion.</short>
        ///         <see> StandardWindowOptions</see>
        public void SetupGUI(QSize defaultSize, uint options, string xmlfile) {
            interceptor.Invoke("setupGUI#$$", "setupGUI(const QSize&, KXmlGuiWindow::StandardWindowOptions, const QString&)", typeof(void), typeof(QSize), defaultSize, typeof(uint), options, typeof(string), xmlfile);
        }
        public void SetupGUI(QSize defaultSize, uint options) {
            interceptor.Invoke("setupGUI#$", "setupGUI(const QSize&, KXmlGuiWindow::StandardWindowOptions)", typeof(void), typeof(QSize), defaultSize, typeof(uint), options);
        }
        public void SetupGUI(QSize defaultSize) {
            interceptor.Invoke("setupGUI#", "setupGUI(const QSize&)", typeof(void), typeof(QSize), defaultSize);
        }
        /// <remarks>
        ///  Returns a pointer to the mainwindows action responsible for the toolbars menu
        ///      </remarks>        <short>    Returns a pointer to the mainwindows action responsible for the toolbars menu      </short>
        public QAction ToolBarMenuAction() {
            return (QAction) interceptor.Invoke("toolBarMenuAction", "toolBarMenuAction()", typeof(QAction));
        }
        /// <remarks>
        ///      </remarks>        <short>   </short>
        public void SetupToolbarMenuActions() {
            interceptor.Invoke("setupToolbarMenuActions", "setupToolbarMenuActions()", typeof(void));
        }
        [SmokeMethod("finalizeGUI(KXMLGUIClient*)")]
        public virtual void FinalizeGUI(IKXMLGUIClient client) {
            interceptor.Invoke("finalizeGUI#", "finalizeGUI(KXMLGUIClient*)", typeof(void), typeof(IKXMLGUIClient), client);
        }
        /// <remarks>
        ///      </remarks>        <short>   </short>
        public void FinalizeGUI(bool force) {
            interceptor.Invoke("finalizeGUI$", "finalizeGUI(bool)", typeof(void), typeof(bool), force);
        }
        [SmokeMethod("applyMainWindowSettings(const KConfigGroup&, bool)")]
        public override void ApplyMainWindowSettings(KConfigGroup config, bool force) {
            interceptor.Invoke("applyMainWindowSettings#$", "applyMainWindowSettings(const KConfigGroup&, bool)", typeof(void), typeof(KConfigGroup), config, typeof(bool), force);
        }
        [SmokeMethod("applyMainWindowSettings(const KConfigGroup&)")]
        public override void ApplyMainWindowSettings(KConfigGroup config) {
            interceptor.Invoke("applyMainWindowSettings#", "applyMainWindowSettings(const KConfigGroup&)", typeof(void), typeof(KConfigGroup), config);
        }
        /// <remarks>
        ///  Show a standard configure toolbar dialog.
        ///  This slot can be connected directly to the action to configure toolbar.
        ///  This is very simple to do that by adding a single line
        ///  <pre>
        ///  KStandardAction.ConfigureToolbars( this, SLOT("configureToolbars()"),
        ///                                 actionCollection() );
        ///  </pre>
        ///      </remarks>        <short>    Show a standard configure toolbar dialog.</short>
        [Q_SLOT("void configureToolbars()")]
        [SmokeMethod("configureToolbars()")]
        public virtual void ConfigureToolbars() {
            interceptor.Invoke("configureToolbars", "configureToolbars()", typeof(void));
        }
        /// <remarks>
        ///  Apply a state change
        ///  Enable and disable actions as defined in the XML rc file
        ///      </remarks>        <short>    Apply a state change </short>
        [Q_SLOT("void slotStateChanged(QString)")]
        [SmokeMethod("slotStateChanged(const QString&)")]
        public virtual void SlotStateChanged(string newstate) {
            interceptor.Invoke("slotStateChanged$", "slotStateChanged(const QString&)", typeof(void), typeof(string), newstate);
        }
        /// <remarks>
        ///  Apply a state change
        ///  Enable and disable actions as defined in the XML rc file,
        ///  can "reverse" the state (disable the actions which should be
        ///  enabled, and vice-versa) if specified.
        ///      </remarks>        <short>    Apply a state change </short>
        [Q_SLOT("void slotStateChanged(QString, bool)")]
        public void SlotStateChanged(string newstate, bool reverse) {
            interceptor.Invoke("slotStateChanged$$", "slotStateChanged(const QString&, bool)", typeof(void), typeof(string), newstate, typeof(bool), reverse);
        }
        /// <remarks>
        ///  Reimplemented to catch QEvent.Polish in order to adjust the object name
        ///  if needed, once all constructor code for the main window has run.
        ///  Also reimplemented to catch when a QDockWidget is added or removed.
        ///      </remarks>        <short>    Reimplemented to catch QEvent.Polish in order to adjust the object name  if needed, once all constructor code for the main window has run.</short>
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        /// <remarks>
        ///  Rebuilds the GUI after KEditToolbar changed the toolbar layout.
        /// </remarks>        <short>    Rebuilds the GUI after KEditToolbar changed the toolbar layout.</short>
        ///         <see> configureToolbars</see>
        [Q_SLOT("void saveNewToolbarConfig()")]
        [SmokeMethod("saveNewToolbarConfig()")]
        protected virtual void SaveNewToolbarConfig() {
            interceptor.Invoke("saveNewToolbarConfig", "saveNewToolbarConfig()", typeof(void));
        }
        ~KXmlGuiWindow() {
            interceptor.Invoke("~KXmlGuiWindow", "~KXmlGuiWindow()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KXmlGuiWindow", "~KXmlGuiWindow()", typeof(void));
        }
        public IKXMLGUIClient BuilderClient() {
            return (IKXMLGUIClient) interceptor.Invoke("builderClient", "builderClient() const", typeof(IKXMLGUIClient));
        }
        public void SetBuilderClient(IKXMLGUIClient client) {
            interceptor.Invoke("setBuilderClient#", "setBuilderClient(KXMLGUIClient*)", typeof(void), typeof(IKXMLGUIClient), client);
        }
        public KComponentData BuilderComponentData() {
            return (KComponentData) interceptor.Invoke("builderComponentData", "builderComponentData() const", typeof(KComponentData));
        }
        public void SetBuilderComponentData(KComponentData componentData) {
            interceptor.Invoke("setBuilderComponentData#", "setBuilderComponentData(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
        }
        public QWidget Widget() {
            return (QWidget) interceptor.Invoke("widget", "widget()", typeof(QWidget));
        }
        [SmokeMethod("containerTags() const")]
        public virtual List<string> ContainerTags() {
            return (List<string>) interceptor.Invoke("containerTags", "containerTags() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Creates a container (menubar/menu/toolbar/statusbar/separator/...)
        ///  from an element in the XML file
        /// <param> name="parent" The parent for the container
        /// </param><param> name="index" The index where the container should be inserted
        ///               into the parent container/widget
        /// </param><param> name="element" The element from the DOM tree describing the
        ///                 container (use it to access container specified
        ///                 attributes or child elements)
        /// </param><param> name="action" The action created for this container; used for e.g. passing to removeContainer.
        ///    </param></remarks>        <short>    Creates a container (menubar/menu/toolbar/statusbar/separator/.</short>
        /// <remarks>
        ///  Removes the given (and previously via createContainer )
        ///  created container.
        ///    </remarks>        <short>    Removes the given (and previously via createContainer )  created container.</short>
        [SmokeMethod("removeContainer(QWidget*, QWidget*, QDomElement&, QAction*)")]
        public virtual void RemoveContainer(QWidget container, QWidget parent, QDomElement element, QAction containerAction) {
            interceptor.Invoke("removeContainer####", "removeContainer(QWidget*, QWidget*, QDomElement&, QAction*)", typeof(void), typeof(QWidget), container, typeof(QWidget), parent, typeof(QDomElement), element, typeof(QAction), containerAction);
        }
        [SmokeMethod("customTags() const")]
        public virtual List<string> CustomTags() {
            return (List<string>) interceptor.Invoke("customTags", "customTags() const", typeof(List<string>));
        }
        [SmokeMethod("createCustomElement(QWidget*, int, const QDomElement&)")]
        public virtual QAction CreateCustomElement(QWidget parent, int index, QDomElement element) {
            return (QAction) interceptor.Invoke("createCustomElement#$#", "createCustomElement(QWidget*, int, const QDomElement&)", typeof(QAction), typeof(QWidget), parent, typeof(int), index, typeof(QDomElement), element);
        }
        [SmokeMethod("removeCustomElement(QWidget*, QAction*)")]
        public virtual void RemoveCustomElement(QWidget parent, QAction action) {
            interceptor.Invoke("removeCustomElement##", "removeCustomElement(QWidget*, QAction*)", typeof(void), typeof(QWidget), parent, typeof(QAction), action);
        }
        /// <remarks>
        ///  Retrieves an action of the client by name.  If not found, it looks in its child clients.
        ///  This method is provided for convenience, as it uses actionCollection()
        ///  to get the action object.
        ///    </remarks>        <short>    Retrieves an action of the client by name.</short>
        public QAction Action(string name) {
            return (QAction) interceptor.Invoke("action$", "action(const char*) const", typeof(QAction), typeof(string), name);
        }
        /// <remarks>
        ///  Retrieves an action for a given QDomElement. The default
        ///  implementation uses the "name" attribute to query the action
        ///  object via the other action() method.
        ///    </remarks>        <short>    Retrieves an action for a given QDomElement.</short>
        [SmokeMethod("action(const QDomElement&) const")]
        public virtual QAction Action(QDomElement element) {
            return (QAction) interceptor.Invoke("action#", "action(const QDomElement&) const", typeof(QAction), typeof(QDomElement), element);
        }
        /// <remarks>
        ///  Retrieves the entire action collection for the GUI client.
        ///    </remarks>        <short>    Retrieves the entire action collection for the GUI client.</short>
        [SmokeMethod("actionCollection() const")]
        public virtual KActionCollection ActionCollection() {
            return (KActionCollection) interceptor.Invoke("actionCollection", "actionCollection() const", typeof(KActionCollection));
        }
        /// <remarks>
        /// </remarks>        <return> The componentData ( KComponentData ) for this GUI client.
        ///    </return>
        ///         <short>   </short>
        [SmokeMethod("componentData() const")]
        public virtual KComponentData ComponentData() {
            return (KComponentData) interceptor.Invoke("componentData", "componentData() const", typeof(KComponentData));
        }
        /// <remarks>
        /// </remarks>        <return> The parsed XML in a QDomDocument, set by
        ///  setXMLFile() or setXML().
        ///  This document describes the layout of the GUI.
        ///    </return>
        ///         <short>   </short>
        [SmokeMethod("domDocument() const")]
        public virtual QDomDocument DomDocument() {
            return (QDomDocument) interceptor.Invoke("domDocument", "domDocument() const", typeof(QDomDocument));
        }
        /// <remarks>
        ///  This will return the name of the XML file as set by setXMLFile().
        ///  If setXML() is used directly, then this will return NULL.
        ///  The filename that this returns is obvious for components as each
        ///  component has exactly one XML file.  In non-components, however,
        ///  there are usually two: the global file and the local file.  This
        ///  function doesn't really care about that, though.  It will always
        ///  return the last XML file set.  This, in almost all cases, will
        ///  be the local XML file.
        /// </remarks>        <return> The name of the XML file or string()
        ///    </return>
        ///         <short>    This will return the name of the XML file as set by setXMLFile().</short>
        [SmokeMethod("xmlFile() const")]
        public virtual string XmlFile() {
            return (string) interceptor.Invoke("xmlFile", "xmlFile() const", typeof(string));
        }
        [SmokeMethod("localXMLFile() const")]
        public virtual string LocalXMLFile() {
            return (string) interceptor.Invoke("localXMLFile", "localXMLFile() const", typeof(string));
        }
        /// <remarks>
        ///    </remarks>        <short>   </short>
        public void SetXMLGUIBuildDocument(QDomDocument doc) {
            interceptor.Invoke("setXMLGUIBuildDocument#", "setXMLGUIBuildDocument(const QDomDocument&)", typeof(void), typeof(QDomDocument), doc);
        }
        /// <remarks>
        ///    </remarks>        <short>   </short>
        public QDomDocument XmlguiBuildDocument() {
            return (QDomDocument) interceptor.Invoke("xmlguiBuildDocument", "xmlguiBuildDocument() const", typeof(QDomDocument));
        }
        /// <remarks>
        ///  This method is called by the KXMLGUIFactory as soon as the client
        ///  is added to the KXMLGUIFactory's GUI.
        ///    </remarks>        <short>    This method is called by the KXMLGUIFactory as soon as the client  is added to the KXMLGUIFactory's GUI.</short>
        public void SetFactory(KXMLGUIFactory factory) {
            interceptor.Invoke("setFactory#", "setFactory(KXMLGUIFactory*)", typeof(void), typeof(KXMLGUIFactory), factory);
        }
        /// <remarks>
        ///  Retrieves a pointer to the KXMLGUIFactory this client is
        ///  associated with (will return 0 if the client's GUI has not been built
        ///  by a KXMLGUIFactory.
        ///    </remarks>        <short>    Retrieves a pointer to the KXMLGUIFactory this client is  associated with (will return 0 if the client's GUI has not been built  by a KXMLGUIFactory.</short>
        public KXMLGUIFactory Factory() {
            return (KXMLGUIFactory) interceptor.Invoke("factory", "factory() const", typeof(KXMLGUIFactory));
        }
        /// <remarks>
        ///  KXMLGUIClients can form a simple child/parent object tree. This
        ///  method returns a pointer to the parent client or 0 if it has no
        ///  parent client assigned.
        ///    </remarks>        <short>    KXMLGUIClients can form a simple child/parent object tree.</short>
        public IKXMLGUIClient ParentClient() {
            return (IKXMLGUIClient) interceptor.Invoke("parentClient", "parentClient() const", typeof(IKXMLGUIClient));
        }
        /// <remarks>
        ///  Use this method to make a client a child client of another client.
        ///  Usually you don't need to call this method, as it is called
        ///  automatically when using the second constructor, which takes a
        ///  parent argument.
        ///    </remarks>        <short>    Use this method to make a client a child client of another client.</short>
        public void InsertChildClient(IKXMLGUIClient child) {
            interceptor.Invoke("insertChildClient#", "insertChildClient(KXMLGUIClient*)", typeof(void), typeof(IKXMLGUIClient), child);
        }
        /// <remarks>
        ///  Removes the given <code>child</code> from the client's children list.
        ///    </remarks>        <short>    Removes the given <code>child</code> from the client's children list.</short>
        public void RemoveChildClient(IKXMLGUIClient child) {
            interceptor.Invoke("removeChildClient#", "removeChildClient(KXMLGUIClient*)", typeof(void), typeof(IKXMLGUIClient), child);
        }
        /// <remarks>
        ///  Retrieves a list of all child clients.
        ///    </remarks>        <short>    Retrieves a list of all child clients.</short>
        public List<KXMLGUIClient> ChildClients() {
            return (List<KXMLGUIClient>) interceptor.Invoke("childClients", "childClients()", typeof(List<KXMLGUIClient>));
        }
        /// <remarks>
        ///  A client can have an own KXMLGUIBuilder.
        ///  Use this method to assign your builder instance to the client (so that the
        ///  KXMLGUIFactory can use it when building the client's GUI)
        ///  Client specific guibuilders are useful if you want to create
        ///  custom container widgets for your GUI.
        ///    </remarks>        <short>    A client can have an own KXMLGUIBuilder.</short>
        public void SetClientBuilder(IKXMLGUIBuilder builder) {
            interceptor.Invoke("setClientBuilder#", "setClientBuilder(KXMLGUIBuilder*)", typeof(void), typeof(IKXMLGUIBuilder), builder);
        }
        /// <remarks>
        ///  Retrieves the client's GUI builder or 0 if no client specific
        ///  builder has been assigned via setClientBuilder()
        ///    </remarks>        <short>    Retrieves the client's GUI builder or 0 if no client specific  builder has been assigned via setClientBuilder()    </short>
        public IKXMLGUIBuilder ClientBuilder() {
            return (IKXMLGUIBuilder) interceptor.Invoke("clientBuilder", "clientBuilder() const", typeof(IKXMLGUIBuilder));
        }
        /// <remarks>
        ///  Forces this client to re-read its XML resource file.  This is
        ///  intended to be used when you know that the resource file has
        ///  changed and you will soon be rebuilding the GUI.  It has no
        ///  useful effect with non-KParts GUIs, so don't bother using it
        ///  unless your app is component based.
        ///    </remarks>        <short>    Forces this client to re-read its XML resource file.</short>
        public void ReloadXML() {
            interceptor.Invoke("reloadXML", "reloadXML()", typeof(void));
        }
        /// <remarks>
        ///  ActionLists are a way for XMLGUI to support dynamic lists of
        ///  actions.  E.g. if you are writing a file manager, and there is a
        ///  menu file whose contents depend on the mimetype of the file that
        ///  is selected, then you can achieve this using ActionLists. It
        ///  works as follows:
        ///  In your xxxui.rc file ( the one that you set in setXMLFile() / pass to setupGUI()
        ///  ), you put a tag <tt>\<ActionList name="xxx"\></tt>.
        ///  Example:
        ///  <pre>
        ///  <kpartgui name="xxx_part" version="1">
        ///  <MenuBar>
        ///    <Menu name="file">
        ///      ...  <!-- some useful actions-->
        ///      <ActionList name="xxx_file_actionlist" />
        ///      ...  <!-- even more useful actions-->
        ///    </Menu>
        ///    ...
        ///  </MenuBar>
        ///  </kpartgui>
        ///  </pre>
        ///  This tag will get expanded to a list of actions.  In the example
        ///  above ( a file manager with a dynamic file menu ), you would call
        ///  <pre>
        ///  QList<QAction> file_actions;
        ///  for( ... )
        ///    if( ... )
        ///      file_actions.append( cool_action );
        ///  unplugActionList( "xxx_file_actionlist" );
        ///  plugActionList( "xxx_file_actionlist", file_actions );
        ///  </pre>
        ///  every time a file is selected, unselected or ...
        ///  <b>Note:<> You should not call createGUI() after calling this
        ///        function.  In fact, that would remove the newly added
        ///        actionlists again...
        ///  <b>Note:<> Forgetting to call unplugActionList() before
        ///        plugActionList() would leave the previous actions in the
        ///        menu too..
        ///  \see unplugActionList()
        ///    </remarks>        <short>    ActionLists are a way for XMLGUI to support dynamic lists of  actions.</short>
        public void PlugActionList(string name, List<QAction> actionList) {
            interceptor.Invoke("plugActionList$?", "plugActionList(const QString&, const QList<QAction*>&)", typeof(void), typeof(string), name, typeof(List<QAction>), actionList);
        }
        /// <remarks>
        ///  Unplugs the action list <pre>name</pre> from the XMLGUI.
        ///  Calling this removes the specified action list, i.e. this is the
        ///  complement to plugActionList(). See plugActionList() for a more
        ///  detailed example.
        ///  \see plugActionList()
        ///    </remarks>        <short>    Unplugs the action list \p name from the XMLGUI.</short>
        public void UnplugActionList(string name) {
            interceptor.Invoke("unplugActionList$", "unplugActionList(const QString&)", typeof(void), typeof(string), name);
        }
        public void AddStateActionEnabled(string state, string action) {
            interceptor.Invoke("addStateActionEnabled$$", "addStateActionEnabled(const QString&, const QString&)", typeof(void), typeof(string), state, typeof(string), action);
        }
        public void AddStateActionDisabled(string state, string action) {
            interceptor.Invoke("addStateActionDisabled$$", "addStateActionDisabled(const QString&, const QString&)", typeof(void), typeof(string), state, typeof(string), action);
        }
        public void BeginXMLPlug(QWidget arg1) {
            interceptor.Invoke("beginXMLPlug#", "beginXMLPlug(QWidget*)", typeof(void), typeof(QWidget), arg1);
        }
        public void EndXMLPlug() {
            interceptor.Invoke("endXMLPlug", "endXMLPlug()", typeof(void));
        }
        public void PrepareXMLUnplug(QWidget arg1) {
            interceptor.Invoke("prepareXMLUnplug#", "prepareXMLUnplug(QWidget*)", typeof(void), typeof(QWidget), arg1);
        }
        /// <remarks>
        ///  Sets the componentData ( KComponentData) for this part.
        ///  Call this first in the inherited class constructor.
        ///  (At least before setXMLFile().)
        ///    </remarks>        <short>    Sets the componentData ( KComponentData) for this part.</short>
        [SmokeMethod("setComponentData(const KComponentData&)")]
        protected virtual void SetComponentData(KComponentData componentData) {
            interceptor.Invoke("setComponentData#", "setComponentData(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
        }
        /// <remarks>
        ///  Sets the name of the rc file containing the XML for the part.
        ///  Call this in the Part-inherited class constructor.
        ///  If you're writing usual application, use KXmlGuiWindow.SetupGUI() with non-default arguments
        /// <param> name="file" Either an absolute path for the file, or simply the
        ///              filename, which will then be assumed to be installed
        ///              in the "data" resource, under a directory named like
        ///              the componentData.
        /// </param><param> name="merge" Whether to merge with the global document.
        /// </param><param> name="setXMLDoc" Specify whether to call setXML. Default is true.
        ///                and the DOM document at once.
        /// </param></remarks>        <short>    Sets the name of the rc file containing the XML for the part.</short>
        [SmokeMethod("setXMLFile(const QString&, bool, bool)")]
        protected virtual void SetXMLFile(string file, bool merge, bool setXMLDoc) {
            interceptor.Invoke("setXMLFile$$$", "setXMLFile(const QString&, bool, bool)", typeof(void), typeof(string), file, typeof(bool), merge, typeof(bool), setXMLDoc);
        }
        [SmokeMethod("setXMLFile(const QString&, bool)")]
        protected virtual void SetXMLFile(string file, bool merge) {
            interceptor.Invoke("setXMLFile$$", "setXMLFile(const QString&, bool)", typeof(void), typeof(string), file, typeof(bool), merge);
        }
        [SmokeMethod("setXMLFile(const QString&)")]
        protected virtual void SetXMLFile(string file) {
            interceptor.Invoke("setXMLFile$", "setXMLFile(const QString&)", typeof(void), typeof(string), file);
        }
        [SmokeMethod("setLocalXMLFile(const QString&)")]
        protected virtual void SetLocalXMLFile(string file) {
            interceptor.Invoke("setLocalXMLFile$", "setLocalXMLFile(const QString&)", typeof(void), typeof(string), file);
        }
        /// <remarks>
        ///  Sets the XML for the part.
        ///  Call this in the Part-inherited class constructor if you
        ///   don't call setXMLFile().
        /// </remarks>        <short>    Sets the XML for the part.</short>
        [SmokeMethod("setXML(const QString&, bool)")]
        protected virtual void SetXML(string document, bool merge) {
            interceptor.Invoke("setXML$$", "setXML(const QString&, bool)", typeof(void), typeof(string), document, typeof(bool), merge);
        }
        [SmokeMethod("setXML(const QString&)")]
        protected virtual void SetXML(string document) {
            interceptor.Invoke("setXML$", "setXML(const QString&)", typeof(void), typeof(string), document);
        }
        /// <remarks>
        ///  Sets the Document for the part, describing the layout of the GUI.
        ///  Call this in the Part-inherited class constructor if you don't call
        ///  setXMLFile or setXML .
        ///    </remarks>        <short>    Sets the Document for the part, describing the layout of the GUI.</short>
        [SmokeMethod("setDOMDocument(const QDomDocument&, bool)")]
        protected virtual void SetDOMDocument(QDomDocument document, bool merge) {
            interceptor.Invoke("setDOMDocument#$", "setDOMDocument(const QDomDocument&, bool)", typeof(void), typeof(QDomDocument), document, typeof(bool), merge);
        }
        [SmokeMethod("setDOMDocument(const QDomDocument&)")]
        protected virtual void SetDOMDocument(QDomDocument document) {
            interceptor.Invoke("setDOMDocument#", "setDOMDocument(const QDomDocument&)", typeof(void), typeof(QDomDocument), document);
        }
        /// <remarks>
        ///  Actions can collectively be assigned a "State". To accomplish this
        ///  the respective actions are tagged as \<enable\> or \<disable\> in
        ///  a \<State\> \</State\> group of the XMLfile. During program execution the
        ///  programmer can call stateChanged() to set actions to a defined state.
        /// <param> name="newstate" Name of a State in the XMLfile.
        /// </param><param> name="reverse" If the flag reverse is set to StateReverse, the State is reversed.
        ///  (actions to be enabled will be disabled and action to be disabled will be enabled)
        ///  Default is reverse=false.
        ///    </param></remarks>        <short>    Actions can collectively be assigned a "State".</short>
        [SmokeMethod("stateChanged(const QString&, KXMLGUIClient::ReverseStateChange)")]
        protected virtual void StateChanged(string newstate, KXMLGUIClient.ReverseStateChange reverse) {
            interceptor.Invoke("stateChanged$$", "stateChanged(const QString&, KXMLGUIClient::ReverseStateChange)", typeof(void), typeof(string), newstate, typeof(KXMLGUIClient.ReverseStateChange), reverse);
        }
        [SmokeMethod("stateChanged(const QString&)")]
        protected virtual void StateChanged(string newstate) {
            interceptor.Invoke("stateChanged$", "stateChanged(const QString&)", typeof(void), typeof(string), newstate);
        }
        public static string FindMostRecentXMLFile(List<string> files, StringBuilder doc) {
            return (string) staticInterceptor.Invoke("findMostRecentXMLFile?$", "findMostRecentXMLFile(const QStringList&, QString&)", typeof(string), typeof(List<string>), files, typeof(StringBuilder), doc);
        }
        protected new IKXmlGuiWindowSignals Emit {
            get { return (IKXmlGuiWindowSignals) Q_EMIT; }
        }
    }

    public interface IKXmlGuiWindowSignals : IKMainWindowSignals {
    }
}