//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \short A container for a set of QAction objects.
    ///  KActionCollection manages a set of QAction objects.  It
    ///  allows them to be grouped for organized presentation of configuration to the user,
    ///  saving + loading of configuration, and optionally for automatic plugging into
    ///  specified widget(s).
    ///  Additionally, KActionCollection provides several convenience functions for locating
    ///  named actions, and actions grouped by QActionGroup.
    ///  <b>Note:<> If you create your own action collection and need to assign shortcuts
    ///  to the actions within, you have to call associateWidget() or
    ///  addAssociatedWidget() to have them working.
    ///   See <see cref="IKActionCollectionSignals"></see> for signals emitted by KActionCollection
    /// </remarks>        <short>    \short A container for a set of QAction objects.</short>
    [SmokeClass("KActionCollection")]
    public class KActionCollection : QObject, IDisposable {
        protected KActionCollection(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KActionCollection), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KActionCollection() {
            staticInterceptor = new SmokeInvocation(typeof(KActionCollection), null);
        }
        [Q_PROPERTY("QString", "configGroup")]
        public string ConfigGroup {
            get { return (string) interceptor.Invoke("configGroup", "configGroup()", typeof(string)); }
            set { interceptor.Invoke("setConfigGroup$", "setConfigGroup(QString)", typeof(void), typeof(string), value); }
        }
        [Q_PROPERTY("bool", "configIsGlobal")]
        public bool ConfigIsGlobal {
            get { return (bool) interceptor.Invoke("configIsGlobal", "configIsGlobal()", typeof(bool)); }
            set { interceptor.Invoke("setConfigGlobal$", "setConfigGlobal(bool)", typeof(void), typeof(bool), value); }
        }
        /// <remarks>
        ///  Constructor.  Allows specification of a KComponentData other than the default
        ///  global KComponentData, where needed.
        ///    </remarks>        <short>    Constructor.</short>
        public KActionCollection(QObject parent, KComponentData cData) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KActionCollection##", "KActionCollection(QObject*, const KComponentData&)", typeof(void), typeof(QObject), parent, typeof(KComponentData), cData);
        }
        public KActionCollection(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KActionCollection#", "KActionCollection(QObject*)", typeof(void), typeof(QObject), parent);
        }
        /// <remarks>
        ///  Clears the entire action collection, deleting all actions.
        ///    </remarks>        <short>    Clears the entire action collection, deleting all actions.</short>
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        /// <remarks>
        ///  Associate all actions in this collection to the given \a widget.
        ///  Unlike addAssociatedWidget, this method only adds all current actions
        ///  in the collection to the given widget. Any action added after this call
        ///  will not be added to the given widget automatically.
        ///  So this is just a shortcut for a foreach loop and a widget.AddAction call.
        ///    </remarks>        <short>    Associate all actions in this collection to the given \a widget.</short>
        public void AssociateWidget(QWidget widget) {
            interceptor.Invoke("associateWidget#", "associateWidget(QWidget*) const", typeof(void), typeof(QWidget), widget);
        }
        /// <remarks>
        ///  Associate all actions in this collection to the given \a widget, including any actions
        ///  added after this association is made.
        ///  This does not change the action's shortcut context, so if you need to have the actions only
        ///  trigger when the widget has focus, you'll need to set the shortcut context on each action
        ///  to Qt.WidgetShortcut (or better still, Qt.WidgetWithChildrenShortcut with Qt 4.4+)
        ///    </remarks>        <short>    Associate all actions in this collection to the given \a widget, including any actions  added after this association is made.</short>
        public void AddAssociatedWidget(QWidget widget) {
            interceptor.Invoke("addAssociatedWidget#", "addAssociatedWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        /// <remarks>
        ///  Remove an association between all actions in this collection and the given \a widget, i.e.
        ///  remove those actions from the widget, and stop associating newly added actions as well.
        ///    </remarks>        <short>    Remove an association between all actions in this collection and the given \a widget, i.</short>
        public void RemoveAssociatedWidget(QWidget widget) {
            interceptor.Invoke("removeAssociatedWidget#", "removeAssociatedWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        /// <remarks>
        ///  Return a list of all associated widgets.
        ///    </remarks>        <short>    Return a list of all associated widgets.</short>
        public List<QWidget> AssociatedWidgets() {
            return (List<QWidget>) interceptor.Invoke("associatedWidgets", "associatedWidgets() const", typeof(List<QWidget>));
        }
        /// <remarks>
        ///  Clear all associated widgets and remove the actions from those widgets.
        ///    </remarks>        <short>    Clear all associated widgets and remove the actions from those widgets.</short>
        public void ClearAssociatedWidgets() {
            interceptor.Invoke("clearAssociatedWidgets", "clearAssociatedWidgets()", typeof(void));
        }
        /// <remarks>
        ///  Read all key associations from <code>config.</code>
        ///  If <code>config</code> is zero, read all key associations from the
        ///  application's configuration file KGlobal.Config(),
        ///  in the group set by setConfigGroup().
        ///     </remarks>        <short>    Read all key associations from <code>config.</code></short>
        public void ReadSettings(KConfigGroup config) {
            interceptor.Invoke("readSettings#", "readSettings(KConfigGroup*)", typeof(void), typeof(KConfigGroup), config);
        }
        public void ReadSettings() {
            interceptor.Invoke("readSettings", "readSettings()", typeof(void));
        }
        /// <remarks>
        ///  Import from <code>config</code> all configurable global key associations.
        ///  \since 4.1
        ///  \param config Config object to read from
        ///     </remarks>        <short>    Import from <code>config</code> all configurable global key associations.</short>
        public void ImportGlobalShortcuts(KConfigGroup config) {
            interceptor.Invoke("importGlobalShortcuts#", "importGlobalShortcuts(KConfigGroup*)", typeof(void), typeof(KConfigGroup), config);
        }
        /// <remarks>
        ///  Export the current configurable global key associations to <code>config.</code>
        ///  \since 4.1
        ///  \param config Config object to save to
        ///  \param writeDefaults set to true to write settings which are already at defaults.
        ///     </remarks>        <short>    Export the current configurable global key associations to <code>config.</code></short>
        public void ExportGlobalShortcuts(KConfigGroup config, bool writeDefaults) {
            interceptor.Invoke("exportGlobalShortcuts#$", "exportGlobalShortcuts(KConfigGroup*, bool) const", typeof(void), typeof(KConfigGroup), config, typeof(bool), writeDefaults);
        }
        public void ExportGlobalShortcuts(KConfigGroup config) {
            interceptor.Invoke("exportGlobalShortcuts#", "exportGlobalShortcuts(KConfigGroup*) const", typeof(void), typeof(KConfigGroup), config);
        }
        /// <remarks>
        ///  Write the current configurable key associations to <b>config</b>. What the
        ///  function does if <b>config</b> is zero depends. If this action collection
        ///  belongs to a KXMLGuiClient the setting are saved to the kxmlgui
        ///  definition file. If not the settings are written to the applications
        ///  config file.
        ///  <b>Note:<> oneAction() and writeDefaults() have no meaning for the kxmlgui
        ///  configuration file.
        ///  \param config Config object to save to, or null (see above)
        ///  \param writeDefaults set to true to write settings which are already at defaults.
        ///  \param oneAction pass an action here if you just want to save the values for one action, eg.
        ///                   if you know that action is the only one which has changed.
        ///     </remarks>        <short>    Write the current configurable key associations to <b>config</b>.</short>
        public void WriteSettings(KConfigGroup config, bool writeDefaults, QAction oneAction) {
            interceptor.Invoke("writeSettings#$#", "writeSettings(KConfigGroup*, bool, QAction*) const", typeof(void), typeof(KConfigGroup), config, typeof(bool), writeDefaults, typeof(QAction), oneAction);
        }
        public void WriteSettings(KConfigGroup config, bool writeDefaults) {
            interceptor.Invoke("writeSettings#$", "writeSettings(KConfigGroup*, bool) const", typeof(void), typeof(KConfigGroup), config, typeof(bool), writeDefaults);
        }
        public void WriteSettings(KConfigGroup config) {
            interceptor.Invoke("writeSettings#", "writeSettings(KConfigGroup*) const", typeof(void), typeof(KConfigGroup), config);
        }
        public void WriteSettings() {
            interceptor.Invoke("writeSettings", "writeSettings() const", typeof(void));
        }
        /// <remarks>
        ///  Returns the number of actions in the collection.
        ///  This is equivalent to actions().count().
        ///    </remarks>        <short>    Returns the number of actions in the collection.</short>
        public int Count() {
            return (int) interceptor.Invoke("count", "count() const", typeof(int));
        }
        /// <remarks>
        ///  Returns whether the action collection is empty or not.
        ///    </remarks>        <short>    Returns whether the action collection is empty or not.</short>
        public bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        /// <remarks>
        ///  Return the QAction at position "index" in the action collection.
        ///  This is equivalent to actions().value(index);
        ///    </remarks>        <short>    Return the QAction  at position "index" in the action collection.</short>
        public QAction Action(int index) {
            return (QAction) interceptor.Invoke("action$", "action(int) const", typeof(QAction), typeof(int), index);
        }
        /// <remarks>
        ///  Get the action with the given \a name from the action collection.
        /// <param> name="name" Name of the KAction
        /// </param></remarks>        <return> A pointer to the KAction in the collection which matches the parameters or
        ///  null if nothing matches.
        ///    </return>
        ///         <short>    Get the action with the given \a name from the action collection.</short>
        public QAction Action(string name) {
            return (QAction) interceptor.Invoke("action$", "action(const QString&) const", typeof(QAction), typeof(string), name);
        }
        /// <remarks>
        ///  Returns the list of KActions which belong to this action collection.
        ///    </remarks>        <short>    Returns the list of KActions which belong to this action collection.</short>
        public List<QAction> Actions() {
            return (List<QAction>) interceptor.Invoke("actions", "actions() const", typeof(List<QAction>));
        }
        /// <remarks>
        ///  Returns the list of KActions without an QAction.ActionGroup() which belong to this action collection.
        ///    </remarks>        <short>    Returns the list of KActions without an QAction.ActionGroup() which belong to this action collection.</short>
        public List<QAction> ActionsWithoutGroup() {
            return (List<QAction>) interceptor.Invoke("actionsWithoutGroup", "actionsWithoutGroup() const", typeof(List<QAction>));
        }
        /// <remarks>
        ///  Returns the list of all QActionGroups associated with actions in this action collection.
        ///    </remarks>        <short>    Returns the list of all QActionGroups associated with actions in this action collection.</short>
        public List<QAction> ActionGroups() {
            return (List<QAction>) interceptor.Invoke("actionGroups", "actionGroups() const", typeof(List<QAction>));
        }
        /// <remarks>
        ///  Set the \a componentData associated with this action collection.
        ///  \warning Don't call this method on a KActionCollection that contains
        ///  actions. This is not supported.
        ///  \param componentData the KComponentData which is to be associated with this action collection,
        ///  or an invalid KComponentData instance to indicate the default KComponentData.
        ///    </remarks>        <short>    Set the \a componentData associated with this action collection.</short>
        public void SetComponentData(KComponentData componentData) {
            interceptor.Invoke("setComponentData#", "setComponentData(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
        }
        /// <remarks> The KComponentData with which this class is associated. </remarks>        <short>   The KComponentData with which this class is associated.</short>
        public KComponentData ComponentData() {
            return (KComponentData) interceptor.Invoke("componentData", "componentData() const", typeof(KComponentData));
        }
        /// <remarks>
        ///  The parent KXMLGUIClient, or null if not available.
        ///    </remarks>        <short>    The parent KXMLGUIClient, or null if not available.</short>
        public IKXMLGUIClient ParentGUIClient() {
            return (IKXMLGUIClient) interceptor.Invoke("parentGUIClient", "parentGUIClient() const", typeof(IKXMLGUIClient));
        }
        /// <remarks>
        ///  Add an action under the given name to the collection.
        ///  Inserting an action that was previously inserted under a different name will replace the
        ///  old entry, i.e. the action will not be available under the old name anymore but only under
        ///  the new one.
        ///  Inserting an action under a name that is already used for another action will replace
        ///  the other action in the collection.
        /// <param> name="name" The name by which the action be retrieved again from the collection.
        /// </param><param> name="action" The action to add.
        ///    </param></remarks>        <short>    Add an action under the given name to the collection.</short>
        public QAction AddAction(string name, QAction action) {
            return (QAction) interceptor.Invoke("addAction$#", "addAction(const QString&, QAction*)", typeof(QAction), typeof(string), name, typeof(QAction), action);
        }
        public KAction AddAction(string name, KAction action) {
            return (KAction) interceptor.Invoke("addAction$#", "addAction(const QString&, KAction*)", typeof(KAction), typeof(string), name, typeof(KAction), action);
        }
        /// <remarks>
        ///  Removes an action from the collection and deletes it.
        /// <param> name="action" The action to remove.
        ///    </param></remarks>        <short>    Removes an action from the collection and deletes it.</short>
        public void RemoveAction(QAction action) {
            interceptor.Invoke("removeAction#", "removeAction(QAction*)", typeof(void), typeof(QAction), action);
        }
        /// <remarks>
        ///  Removes an action from the collection.
        /// <param> name="action" the action to remove.
        ///    </param></remarks>        <short>    Removes an action from the collection.</short>
        public QAction TakeAction(QAction action) {
            return (QAction) interceptor.Invoke("takeAction#", "takeAction(QAction*)", typeof(QAction), typeof(QAction), action);
        }
        /// <remarks>
        ///  Creates a new standard action, adds it to the collection and connects the action's triggered() signal to the
        ///  specified receiver/member. The newly created action is also returned.
        ///  The action can be retrieved later from the collection by its standard name as per
        ///  KStandardAction.StdName.
        ///    </remarks>        <short>    Creates a new standard action, adds it to the collection and connects the action's triggered() signal to the  specified receiver/member.</short>
        public KAction AddAction(KStandardAction.StandardAction actionType, QObject receiver, string member) {
            return (KAction) interceptor.Invoke("addAction$#$", "addAction(KStandardAction::StandardAction, const QObject*, const char*)", typeof(KAction), typeof(KStandardAction.StandardAction), actionType, typeof(QObject), receiver, typeof(string), member);
        }
        public KAction AddAction(KStandardAction.StandardAction actionType, QObject receiver) {
            return (KAction) interceptor.Invoke("addAction$#", "addAction(KStandardAction::StandardAction, const QObject*)", typeof(KAction), typeof(KStandardAction.StandardAction), actionType, typeof(QObject), receiver);
        }
        public KAction AddAction(KStandardAction.StandardAction actionType) {
            return (KAction) interceptor.Invoke("addAction$", "addAction(KStandardAction::StandardAction)", typeof(KAction), typeof(KStandardAction.StandardAction), actionType);
        }
        /// <remarks>
        ///  Creates a new standard action, adds to the collection under the given name and connects the action's triggered() signal to the
        ///  specified receiver/member. The newly created action is also returned.
        ///  The action can be retrieved later from the collection by the specified name.
        ///    </remarks>        <short>    Creates a new standard action, adds to the collection under the given name and connects the action's triggered() signal to the  specified receiver/member.</short>
        public KAction AddAction(KStandardAction.StandardAction actionType, string name, QObject receiver, string member) {
            return (KAction) interceptor.Invoke("addAction$$#$", "addAction(KStandardAction::StandardAction, const QString&, const QObject*, const char*)", typeof(KAction), typeof(KStandardAction.StandardAction), actionType, typeof(string), name, typeof(QObject), receiver, typeof(string), member);
        }
        public KAction AddAction(KStandardAction.StandardAction actionType, string name, QObject receiver) {
            return (KAction) interceptor.Invoke("addAction$$#", "addAction(KStandardAction::StandardAction, const QString&, const QObject*)", typeof(KAction), typeof(KStandardAction.StandardAction), actionType, typeof(string), name, typeof(QObject), receiver);
        }
        public KAction AddAction(KStandardAction.StandardAction actionType, string name) {
            return (KAction) interceptor.Invoke("addAction$$", "addAction(KStandardAction::StandardAction, const QString&)", typeof(KAction), typeof(KStandardAction.StandardAction), actionType, typeof(string), name);
        }
        /// <remarks>
        ///  Creates a new action under the given name to the collection and connects the action's triggered()
        ///  signal to the specified receiver/member. The newly created action is returned.
        ///  Inserting an action that was previously inserted under a different name will replace the
        ///  old entry, i.e. the action will not be available under the old name anymore but only under
        ///  the new one.
        ///  Inserting an action under a name that is already used for another action will replace
        ///  the other action in the collection.
        /// <param> name="name" The name by which the action be retrieved again from the collection.
        /// </param><param> name="action" The action to add.
        ///    </param></remarks>        <short>    Creates a new action under the given name to the collection and connects the action's triggered()  signal to the specified receiver/member.</short>
        public KAction AddAction(string name, QObject receiver, string member) {
            return (KAction) interceptor.Invoke("addAction$#$", "addAction(const QString&, const QObject*, const char*)", typeof(KAction), typeof(string), name, typeof(QObject), receiver, typeof(string), member);
        }
        public KAction AddAction(string name, QObject receiver) {
            return (KAction) interceptor.Invoke("addAction$#", "addAction(const QString&, const QObject*)", typeof(KAction), typeof(string), name, typeof(QObject), receiver);
        }
        public KAction AddAction(string name) {
            return (KAction) interceptor.Invoke("addAction$", "addAction(const QString&)", typeof(KAction), typeof(string), name);
        }
        [Q_SLOT("void connectNotify(char*)")]
        [SmokeMethod("connectNotify(const char*)")]
        protected override void ConnectNotify(string signal) {
            interceptor.Invoke("connectNotify$", "connectNotify(const char*)", typeof(void), typeof(string), signal);
        }
        [Q_SLOT("void slotActionTriggered()")]
        [SmokeMethod("slotActionTriggered()")]
        protected virtual void SlotActionTriggered() {
            interceptor.Invoke("slotActionTriggered", "slotActionTriggered()", typeof(void));
        }
        ~KActionCollection() {
            interceptor.Invoke("~KActionCollection", "~KActionCollection()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KActionCollection", "~KActionCollection()", typeof(void));
        }
        /// <remarks>
        ///  Access the list of all action collections in existence for this app
        ///    </remarks>        <short>    Access the list of all action collections in existence for this app    </short>
        public static List<KActionCollection> AllCollections() {
            return (List<KActionCollection>) staticInterceptor.Invoke("allCollections", "allCollections()", typeof(List<KActionCollection>));
        }
        protected new IKActionCollectionSignals Emit {
            get { return (IKActionCollectionSignals) Q_EMIT; }
        }
    }

    public interface IKActionCollectionSignals : IQObjectSignals {
        /// <remarks>
        ///  Indicates that \a action was inserted into this action collection.
        ///    </remarks>        <short>    Indicates that \a action was inserted into this action collection.</short>
        [Q_SIGNAL("void inserted(QAction*)")]
        void Inserted(QAction action);
        /// <remarks>
        ///  Indicates that \a action was hovered.
        ///    </remarks>        <short>    Indicates that \a action was hovered.</short>
        [Q_SIGNAL("void actionHovered(QAction*)")]
        void ActionHovered(QAction action);
        /// <remarks>
        ///  Indicates that \a action was triggered
        ///    </remarks>        <short>    Indicates that \a action was triggered    </short>
        [Q_SIGNAL("void actionTriggered(QAction*)")]
        void ActionTriggered(QAction action);
    }
}
