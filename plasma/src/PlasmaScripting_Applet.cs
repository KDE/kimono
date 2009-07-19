/*
 *   Copyright 2008 by Richard Dale <richard.j.dale@gmail.com>
 *   Copyright 2008, Arno Rehn <arno@arnorehn.de>
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU Library General Public License as
 *   published by the Free Software Foundation; either version 2, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details
 *
 *   You should have received a copy of the GNU Library General Public
 *   License along with this program; if not, write to the
 *   Free Software Foundation, Inc.,
 *   51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

namespace PlasmaScripting {
    using Plasma;
    using System;
    using Kimono;
    using QyotoQGraphicsWidget = Qyoto.QGraphicsWidget;
    using Qyoto;
    using System.Collections.Generic;
    using System.Reflection;
    /// <remarks>
    ///  Applet provides several important roles for add-ons widgets in Plasma.
    ///  First, it is the base class for the plugin system and therefore is the
    ///  interface to applets for host applications. It also handles the life time
    ///  management of data engines (e.g. all data engines accessed via
    ///  Applet.DataEngine(string) are properly deref'd on Applet
    ///  destruction), background painting (allowing for consistent and complex
    ///  look and feel in just one line of code for applets), loading and starting
    ///  of scripting support for each applet, providing access to the associated
    ///  plasmoid package (if any) and access to configuration data.
    ///  See techbase.kde.org for tutorial on writing Applets using this class.
    ///   See <see cref="IAppletSignals"></see> for signals emitted by Applet
    /// </remarks>        <short> The base Applet class.</short>
    public class Applet : QGraphicsWidget, IDisposable {
        [Q_PROPERTY("bool", "hasConfigurationInterface")]
        public bool HasConfigurationInterface {
            get { return applet.HasConfigurationInterface; }
            set { applet.HasConfigurationInterface = value; }
        }
        [Q_PROPERTY("QString", "name")]
        public string Name {
            get { return applet.Name; }
        }
        [Q_PROPERTY("QString", "category")]
        public string Category {
            get { return applet.Category; }
        }
        [Q_PROPERTY("Plasma::ImmutabilityType", "immutability")]
        public Plasma.ImmutabilityType Immutability {
            get { return applet.Immutability; }
            set { applet.Immutability = value; }
        }
        [Q_PROPERTY("bool", "hasFailedToLaunch")]
        public bool HasFailedToLaunch {
            get { return applet.HasFailedToLaunch; }
            set { applet.HasFailedToLaunch = value; }
        }
        [Q_PROPERTY("bool", "configurationRequired")]
        public bool ConfigurationRequired {
            get { return applet.ConfigurationRequired; }
            set { applet.ConfigurationRequired = value; }
        }
        [Q_PROPERTY("QRectF", "geometry")]
        public QRectF Geometry {
            get { return applet.Geometry; }
            set { applet.Geometry = value; }
        }
        [Q_PROPERTY("bool", "shouldConserveResources")]
        public bool ShouldConserveResources {
            get { return applet.ShouldConserveResources; }
        }
        /// <remarks>
        /// </remarks>        <return> the id of this applet
        ///          </return>
        ///         <short>   </short>
        public uint Id() {
            return applet.Id();
        }
        /// <remarks>
        ///  Returns the KConfigGroup to access the applets configuration.
        ///  This config object will write to an instance
        ///  specific config file named \<appletname\>\<instanceid\>rc
        ///  in the Plasma appdata directory.
        /// </remarks>        <short>    Returns the KConfigGroup to access the applets configuration.</short>
        public KConfigGroup Config() {
            return applet.Config();
        }
        /// <remarks>
        ///  Returns a config group with the name provided. This ensures
        ///  that the group name is properly namespaced to avoid collision
        ///  with other applets that may be sharing this config file
        /// <param> name="group" the name of the group to access
        /// </param></remarks>        <short>    Returns a config group with the name provided.</short>
        public KConfigGroup Config(string group) {
            return applet.Config(group);
        }
        /// <remarks>
        ///  Saves state information about this applet that will
        ///  be accessed when next instantiated in the restore(KConfigGroup&) method.
        ///  This method does not need to be reimplmented by Applet
        ///  subclasses, but can be useful for Applet specializations
        ///  (such as Containment) to do so.
        ///  Applet subclasses may instead want to reimplement saveState().
        /// </remarks>        <short>    Saves state information about this applet that will  be accessed when next instantiated in the restore(KConfigGroup&) method.</short>
        public virtual void Save(KConfigGroup group) {
            applet.Save(group);
        }
        /// <remarks>
        ///  Restores state information about this applet saved previously
        ///  in save(KConfigGroup&).
        ///  This method does not need to be reimplmented by Applet
        ///  subclasses, but can be useful for Applet specializations
        ///  (such as Containment) to do so.
        /// </remarks>        <short>    Restores state information about this applet saved previously  in save(KConfigGroup&).</short>
        public virtual void Restore(KConfigGroup group) {
            applet.Restore(group);
        }
        /// <remarks>
        ///  Returns a KConfigGroup object to be shared by all applets of this
        ///  type.
        ///  This config object will write to an applet-specific config object
        ///  named plasma_\<appletname\>rc in the local config directory.
        ///          </remarks>        <short>    Returns a KConfigGroup object to be shared by all applets of this  type.</short>
        public KConfigGroup GlobalConfig() {
            return applet.GlobalConfig();
        }
        /// <remarks>
        ///  Returns the config skeleton object from this applet's package,
        ///  if any.
        /// </remarks>        <return> config skeleton object, or 0 if none
        /// </return>
        ///         <short>    Returns the config skeleton object from this applet's package,  if any.</short>
        public Plasma.ConfigLoader ConfigScheme() {
            return applet.ConfigScheme();
        }
        /// <remarks>
        ///  Loads the given DataEngine
        ///  Tries to load the data engine given by <code>name.</code>  Each engine is
        ///  only loaded once, and that instance is re-used on all subsequent
        ///  requests.
        ///  If the data engine was not found, an invalid data engine is returned
        ///  (see DataEngine.IsValid()).
        ///  Note that you should <em>not</em> delete the returned engine.
        /// <param> name="name" Name of the data engine to load
        /// </param></remarks>        <return> pointer to the data engine if it was loaded,
        ///          or an invalid data engine if the requested engine
        ///          could not be loaded
        ///          </return>
        ///         <short>    Loads the given DataEngine </short>
        public Plasma.DataEngine DataEngine(string name) {
            return applet.DataEngine(name);
        }
        /// <remarks>
        ///  Accessor for the associated Package object if any.
        ///  Generally, only Plasmoids come in a Package.
        /// </remarks>        <return> the Package object, or 0 if none
        /// </return>
        ///         <short>    Accessor for the associated Package object if any.</short>
        public Plasma.Package Package() {
            return applet.Package();
        }
        /// <remarks>
        ///  Returns the view this widget is visible on
        ///          </remarks>        <short>    Returns the view this widget is visible on          </short>
        public QGraphicsView View() {
            return applet.View();
        }
        /// <remarks>
        ///  Maps a QRect from a view's coordinates to local coordinates.
        /// <param> name="view" the view from which rect should be mapped
        /// </param><param> name="rect" the rect to be mapped
        ///          </param></remarks>        <short>    Maps a QRect from a view's coordinates to local coordinates.</short>
        public QRectF MapFromView(QGraphicsView view, QRect rect) {
            return applet.MapFromView(view, rect);
        }
        /// <remarks>
        ///  Maps a QRectF from local coordinates to a view's coordinates.
        /// <param> name="view" the view to which rect should be mapped
        /// </param><param> name="rect" the rect to be mapped
        ///          </param></remarks>        <short>    Maps a QRectF from local coordinates to a view's coordinates.</short>
        public QRect MapToView(QGraphicsView view, QRectF rect) {
            return applet.MapToView(view, rect);
        }
        /// <remarks>
        ///  Reccomended position for a popup window like a menu or a tooltip
        ///  given its size
        /// <param> name="s" size of the popup
        /// </param></remarks>        <return> reccomended position
        ///          </return>
        ///         <short>    Reccomended position for a popup window like a menu or a tooltip  given its size </short>
        public QPoint PopupPosition(QSize s) {
            return applet.PopupPosition(s);
        }
        /// <remarks>
        ///  Called when any of the geometry constraints have been updated.
        ///  This method calls constraintsEvent, which may be reimplemented,
        ///  once the Applet has been prepared for updating the constraints.
        /// <param> name="constraints" the type of constraints that were updated
        ///          </param></remarks>        <short>    Called when any of the geometry constraints have been updated.</short>
        public void UpdateConstraints(uint constraints) {
            applet.UpdateConstraints(constraints);
        }
        public void UpdateConstraints() {
            applet.UpdateConstraints();
        }
        /// <remarks>
        ///  Returns the current form factor the applet is being displayed in.
        /// </remarks>        <short>    Returns the current form factor the applet is being displayed in.</short>
        ///         <see> Plasma.FormFactor</see>
        public virtual Plasma.FormFactor formFactor() {
            return applet.formFactor();
        }
        /// <remarks>
        ///  Returns the location of the scene which is displaying applet.
        /// </remarks>        <short>    Returns the location of the scene which is displaying applet.</short>
        ///         <see> Plasma.Location</see>
        public virtual Plasma.Location location() {
            return applet.location();
        }
        /// <remarks>
        /// </remarks>        <return> the preferred aspect ratio mode for placement and resizing
        ///          </return>
        ///         <short>   </short>
        public Plasma.AspectRatioMode aspectRatioMode() {
            return applet.aspectRatioMode();
        }
        /// <remarks>
        ///  Sets the preferred aspect ratio mode for placement and resizing
        ///          </remarks>        <short>    Sets the preferred aspect ratio mode for placement and resizing          </short>
        public void SetAspectRatioMode(Plasma.AspectRatioMode arg1) {
            applet.SetAspectRatioMode(arg1);
        }
        /// <remarks>
        ///  This method is called when the interface should be painted.
        /// <param> name="painter" the QPainter to use to do the paintiner
        /// </param><param> name="option" the style options object
        /// </param><param> name="contentsRect" the rect to paint within; automatically adjusted for
        ///                      the background, if any
        /// </param></remarks>        <short>    This method is called when the interface should be painted.</short>
        public virtual void PaintInterface(QPainter painter, QStyleOptionGraphicsItem option, QRect contentsRect) {
        }
        /// <remarks>
        /// </remarks>        <return> the font currently set for this widget
        /// </return>
        ///         <short>   </short>
        public new QFont Font() {
            return applet.Font();
        }
        /// <remarks>
        ///  Returns the plugin name for the applet
        ///          </remarks>        <short>    Returns the plugin name for the applet          </short>
        public string PluginName() {
            return applet.PluginName();
        }
        /// <remarks>
        ///  Returns the icon related to this applet
        /// </remarks>        <short>    Returns the icon related to this applet </short>
        public string Icon() {
            return applet.Icon();
        }
        public virtual void PaintWindowFrame(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
            applet.PaintWindowFrame(painter, option, widget);
        }
        /// <remarks>
        ///  Returns a list of context-related QAction instances.
        ///  This is used e.g. within the \a DesktopView to display a
        ///  contextmenu.
        /// </remarks>        <return> A list of actions. The default implementation returns an
        ///          empty list.
        /// </return>
        ///         <short>    Returns a list of context-related QAction instances.</short>
        public virtual List<QAction> ContextualActions() {
            return new List<QAction>();
        }
        /// <remarks>
        ///  Returns the QAction with the given name from our collection
        ///          </remarks>        <short>    Returns the QAction with the given name from our collection          </short>
        public QAction Action(string name) {
            return applet.Action(name);
        }
        /// <remarks>
        ///  Adds the action to our collection under the given name
        ///          </remarks>        <short>    Adds the action to our collection under the given name          </short>
        public void AddAction(string name, QAction action) {
            applet.AddAction(name, action);
        }
        /// <remarks>
        ///  Sets the BackgroundHints for this applet @see BackgroundHint
        /// <param> name="hints" the BackgroundHint combination for this applet
        ///          </param></remarks>        <short>    Sets the BackgroundHints for this applet @see BackgroundHint </short>
        public void SetBackgroundHints(uint hints) {
            applet.SetBackgroundHints(hints);
        }
        /// <remarks>
        /// </remarks>        <return> BackgroundHints flags combination telling if the standard background is shown
        ///          and if it has a drop shadow
        ///          </return>
        ///         <short>   </short>
        public uint BackgroundHints() {
            return applet.BackgroundHints();
        }
        /// <remarks>
        /// </remarks>        <return> true if this Applet is currently being used as a Containment, false otherwise
        ///          </return>
        ///         <short>   </short>
        public bool IsContainment() {
            return applet.IsContainment();
        }
        /// <remarks>
        /// </remarks>        <return> a rect of the applet in screen coordinates.
        ///          </return>
        ///         <short>   </short>
        public QRect ScreenRect() {
            return applet.ScreenRect();
        }
        /// <remarks>
        ///  Reimplemented from QGraphicsItem
        /// </remarks>        <short>    Reimplemented from QGraphicsItem </short>
        public int type() {
            return applet.type();
        }
        /// <remarks>
        /// </remarks>        <return> the Containment, if any, this applet belongs to
        /// </return>
        ///         <short>   </short>
        public Plasma.Containment Containment() {
            return applet.Containment();
        }
        /// <remarks>
        ///  Sets the global shorcut to associate with this widget.
        ///          </remarks>        <short>    Sets the global shorcut to associate with this widget.</short>
        public void SetGlobalShortcut(KShortcut shortcut) {
            applet.SetGlobalShortcut(shortcut);
        }
        /// <remarks>
        /// </remarks>        <return> the global shortcut associated with this wiget, or
        ///  an empty shortcut if no global shortcut is associated.
        ///          </return>
        ///         <short>   </short>
        public KShortcut GlobalShortcut() {
            return applet.GlobalShortcut();
        }
        /// <remarks>
        ///  associate actions with this widget, including ones added after this call.
        ///  needed to make keyboard shortcuts work.
        ///          </remarks>        <short>    associate actions with this widget, including ones added after this call.</short>
        public virtual void AddAssociatedWidget(QWidget widget) {
            applet.AddAssociatedWidget(widget);
        }
        /// <remarks>
        ///  un-associate actions from this widget, including ones added after this call.
        ///  needed to make keyboard shortcuts work.
        ///          </remarks>        <short>    un-associate actions from this widget, including ones added after this call.</short>
        public virtual void RemoveAssociatedWidget(QWidget widget) {
            applet.RemoveAssociatedWidget(widget);
        }
        /// <remarks>
        ///  Sets the immutability type for this applet (not immutable, user immutable or system immutable)
        ///  @arg immutable the new immutability type of this applet
        ///          </remarks>        <short>    Sets the immutability type for this applet (not immutable, user immutable or system immutable)  @arg immutable the new immutability type of this applet          </short>
        [Q_SLOT("void setImmutability(Plasma::ImmutabilityType)")]
        public void SetImmutability(Plasma.ImmutabilityType immutable) {
            applet.SetImmutability(immutable);
        }
        /// <remarks>
        ///  Destroys the applet; it will be removed nicely and deleted.
        ///  Its configuration will also be deleted.
        ///          </remarks>        <short>    Destroys the applet; it will be removed nicely and deleted.</short>
        [Q_SLOT("void destroy()")]
        public virtual void Destroy() {
            applet.Destroy();
        }
        KConfigSkeleton nullManager;
        KConfigDialog dialog;
        /// <remarks>
        ///  Lets the user interact with the plasmoid options.
        ///  Called when the user selects the configure entry
        ///  from the context menu.
        ///  Unless there is good reason for overriding this method,
        ///  Applet subclasses should actually virtual createConfigurationInterface
        ///  instead. A good example of when this isn't plausible is
        ///  when using a dialog prepared by another library, such
        ///  as KPropertiesDialog from libkfile.
        ///          </remarks>        <short>    Lets the user interact with the plasmoid options.</short>
        [Q_SLOT("void showConfigurationInterface()")]
        public virtual void ShowConfigurationInterface() {
            string dialogId = applet.Id() + "settings" + applet.Name;
            string windowTitle = KDE.I18nc("@title:window", applet.Name + " Settings");
            nullManager = new KConfigSkeleton();
            dialog = new KConfigDialog(null, dialogId, nullManager);
            dialog.SetFaceType(KPageDialog.FaceType.Auto);
            dialog.SetWindowTitle(windowTitle);
            dialog.SetAttribute(Qt.WidgetAttribute.WA_DeleteOnClose, true);
            CreateConfigurationInterface(dialog);
            //TODO: would be nice to not show dialog if there are no pages added?
            Connect(dialog, SIGNAL("finished()"), nullManager, SLOT("deleteLater()"));
            //TODO: Apply button does not correctly work for now, so do not show it
            dialog.ShowButton(KDialog.ButtonCode.Apply, false);
            dialog.Show();
        }
        /// <remarks>
        ///  Causes this applet to raise above all other applets.
        ///          </remarks>        <short>    Causes this applet to raise above all other applets.</short>
        [Q_SLOT("void raise()")]
        public void Raise() {
            applet.Raise();
        }
        /// <remarks>
        ///  Causes this applet to lower below all the other applets.
        ///          </remarks>        <short>    Causes this applet to lower below all the other applets.</short>
        [Q_SLOT("void lower()")]
        public void Lower() {
            applet.Lower();
        }
        /// <remarks>
        ///  Sends all pending contraints updates to the applet. Will usually
        ///  be called automatically, but can also be called manually if needed.
        ///          </remarks>        <short>    Sends all pending contraints updates to the applet.</short>
        [Q_SLOT("void flushPendingConstraintsEvents()")]
        public void FlushPendingConstraintsEvents() {
            applet.FlushPendingConstraintsEvents();
        }
        /// <remarks>
        ///  This method is called once the applet is loaded and added to a Corona.
        ///  If the applet requires a QGraphicsScene or has an particularly intensive
        ///  set of initialization routines to go through, consider implementing it
        ///  in this method instead of the constructor.
        /// </remarks>        <short>    This method is called once the applet is loaded and added to a Corona.</short>
        [Q_SLOT("void init()")]
        public virtual void Init() {
        }
        [Q_SLOT("void initExtenderItem(Plasma::ExtenderItem*)")]
        public virtual void InitExtenderItem(Plasma.ExtenderItem item) {
            Console.WriteLine("Missing implementation of initExtenderItem in the applet {0}!",
                              item.Config().ReadEntry("SourceAppletPluginName", ""));
            Console.WriteLine("Any applet that uses extenders should implement initExtenderItem to instantiate a widget.");
        }
         /// <remarks>
         /// </remarks>        <return> the extender this applet has.
         ///          </return>
         ///         <short>   </short>
        [Q_SLOT("Plasma::Extender* extender()")]
        protected Plasma.Extender Extender() {
            return (Plasma.Extender) appletType.GetMethod("Extender").Invoke(applet, null);
        }
        public Applet(AppletScript parent) : base(parent) {
            Connect(applet, SIGNAL("releaseVisualFocus()"), this, SIGNAL("releaseVisualFocus()"));
            Connect(applet, SIGNAL("geometryChanged()"), this, SIGNAL("geometryChanged()"));
            Connect(applet, SIGNAL("configNeedsSaving()"), this, SIGNAL("configNeedsSaving()"));
            Connect(applet, SIGNAL("activate()"), this, SIGNAL("activate()"));
            Connect(applet, SIGNAL("extenderItemRestored(Plasma::ExtenderItem*)"), 
                    this, SLOT("initExtenderItem(Plasma::ExtenderItem*)"));
        }
        /// <remarks>
        ///  Call this method when the applet fails to launch properly. An
        ///  optional reason can be provided.
        ///  Not that all children items will be deleted when this method is
        ///  called. If you have pointers to these items, you will need to
        ///  reset them after calling this method.
        /// <param> name="failed" true when the applet failed, false when it succeeded
        /// </param><param> name="reason" an optional reason to show the user why the applet
        ///                failed to launch
        /// </param></remarks>        <short>    Call this method when the applet fails to launch properly.</short>
        protected void SetFailedToLaunch(bool failed, string reason) {
            Object[] parameters = new Object[2];
            parameters[0] = failed;
            parameters[1] = reason;
            MethodInfo method = appletType.GetMethod(  "SetFailedToLaunch", 
                                                        new Type[] {    typeof(System.Boolean), 
                                                                        typeof(System.String) } );
            method.Invoke(applet, parameters);
        }
        protected void SetFailedToLaunch(bool failed) {
            Object[] parameters = new Object[1];
            parameters[0] = failed;
            MethodInfo method = appletType.GetMethod(  "SetFailedToLaunch", 
                                                        new Type[] {typeof(System.Boolean)} );
            method.Invoke(applet, parameters);
        }
        /// <remarks>
        ///  When called, the Applet should write any information needed as part
        ///  of the Applet's running state to the configuration object in config()
        ///  and/or globalConfig().
        ///  Applets that always sync their settings/state with the config
        ///  objects when these settings/states change do not need to reimplement
        ///  this method.
        /// </remarks>        <short>    When called, the Applet should write any information needed as part  of the Applet's running state to the configuration object in config()  and/or globalConfig().</short>
        protected virtual void SaveState(KConfigGroup config) {
        }
        /// <remarks>
        ///  When the applet needs to be configured before being usable, this
        ///  method can be called to show a standard interface prompting the user
        ///  to configure the applet
        ///  Not that all children items will be deleted when this method is
        ///  called. If you have pointers to these items, you will need to
        ///  reset them after calling this method.
        /// <param> name="needsConfiguring" true if the applet needs to be configured,
        ///                          or false if it doesn't
        ///          </param></remarks>        <short>    When the applet needs to be configured before being usable, this  method can be called to show a standard interface prompting the user  to configure the applet </short>
        protected void SetConfigurationRequired(bool needsConfiguring, string reason) {
            Object[] parameters = new Object[2];
            parameters[0] = needsConfiguring;
            parameters[1] = reason;
            MethodInfo method = appletType.GetMethod(  "SetConfigurationRequired", 
                                                        new Type[] {    typeof(System.Boolean), 
                                                                        typeof(System.String) } );
            method.Invoke(applet, parameters);
        }
        protected void SetConfigurationRequired(bool needsConfiguring) {
            Object[] parameters = new Object[1];
            parameters[0] = needsConfiguring;
            MethodInfo method = appletType.GetMethod(  "SetConfigurationRequired", 
                                                        new Type[] {typeof(System.Boolean)} );
            method.Invoke(applet, parameters);
        }
        /// <remarks>
        ///  Reimplement this method so provide a configuration interface,
        ///  parented to the supplied widget. Ownership of the widgets is passed
        ///  to the parent widget.
        /// <param> name="parent" the dialog which is the parent of the configuration
        ///                widgets
        ///          </param></remarks>        <short>    Reimplement this method so provide a configuration interface,  parented to the supplied widget.</short>
        public virtual void CreateConfigurationInterface(KConfigDialog parent) {
        }
        /// <remarks>
        ///  Sets whether or not this Applet is acting as a Containment
        ///          </remarks>        <short>    Sets whether or not this Applet is acting as a Containment          </short>
        protected void SetIsContainment(bool isContainment) {
            Object[] parameters = new Object[1];
            parameters[0] = isContainment;
            appletType.GetMethod("SetIsContainment").Invoke(applet, parameters);
        }
        /// <remarks>
        ///  Called when any of the geometry constraints have been updated.
        ///  This is always called prior to painting and should be used as an
        ///  opportunity to layout the widget, calculate sizings, etc.
        ///  Do not call update() from this method; an update() will be triggered
        ///  at the appropriate time for the applet.
        /// <param> name="constraints" the type of constraints that were updated
        ///  @property constraint
        ///          </param></remarks>        <short>    Called when any of the geometry constraints have been updated.</short>
        public virtual void ConstraintsEvent(uint constraints) {
        }
        /// <remarks>
        ///  Register the widgets that manage mouse clicks but you still want
        ///  to be able to drag the applet around when holding the mouse pointer
        ///  on that widget.
        ///  Calling this results in an eventFilter being places on the widget.
        /// <param> name="item" the item to watch for mouse move
        ///          </param></remarks>        <short>    Register the widgets that manage mouse clicks but you still want  to be able to drag the applet around when holding the mouse pointer  on that widget.</short>
        protected void RegisterAsDragHandle(QGraphicsItem item) {
            Object[] parameters = new Object[1];
            parameters[0] = item;
            appletType.GetMethod("RegisterAsDragHandle").Invoke(applet, parameters);
        }
        /// <remarks>
        ///  Unregister a widget registered with registerAsDragHandle.
        /// <param> name="item" the item to unregister
        ///          </param></remarks>        <short>    Unregister a widget registered with registerAsDragHandle.</short>
        protected void UnregisterAsDragHandle(QGraphicsItem item) {
            Object[] parameters = new Object[1];
            parameters[0] = item;
            appletType.GetMethod("UnregisterAsDragHandle").Invoke(applet, parameters);
        }
        /// <remarks>
        /// <param> name="item" the item to look for if it is registered or not
        /// </param></remarks>        <return> true if it is registered, false otherwise
        ///          </return>
        ///         <short>   </short>
        protected bool IsRegisteredAsDragHandle(QGraphicsItem item) {
            Object[] parameters = new Object[1];
            parameters[0] = item;
            return (bool) appletType.GetMethod("IsRegisteredAsDragHandle").Invoke(applet, parameters);
        }
        /// <remarks>
        /// </remarks>        <short>   </short>
        protected new virtual bool EventFilter(QObject o, QEvent e) {
            return false;
        }
        /// <remarks>
        ///          </remarks>        <short>   </short>
        protected virtual bool SceneEventFilter(QGraphicsItem watched, QEvent arg2) {
            return false;
        }
        /// <remarks>
        ///          </remarks>        <short>   </short>
        protected virtual void MouseMoveEvent(QGraphicsSceneMouseEvent arg1) {
        }
        /// <remarks>
        ///          </remarks>        <short>   </short>
        protected virtual void MousePressEvent(QGraphicsSceneMouseEvent arg1) {
        }
        /// <remarks>
        ///  Reimplemented from QGraphicsItem
        ///          </remarks>        <short>    Reimplemented from QGraphicsItem          </short>
        protected virtual void FocusInEvent(QFocusEvent arg1) {
        }
        /// <remarks>
        ///  Reimplemented from QGraphicsItem
        ///          </remarks>        <short>    Reimplemented from QGraphicsItem          </short>
        protected virtual void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
        }
        /// <remarks>
        ///  Reimplemented from QGraphicsItem
        ///          </remarks>        <short>    Reimplemented from QGraphicsItem          </short>
        protected virtual QVariant ItemChange(QGraphicsItem.GraphicsItemChange change, QVariant value) {
            Object[] parameters = new Object[2];
            parameters[0] = change;
            parameters[1] = value;
            return (QVariant) appletType.GetMethod("ItemChange").Invoke(applet, parameters);
        }
        /// <remarks>
        ///  Reimplemented from QGraphicsItem
        ///          </remarks>        <short>    Reimplemented from QGraphicsItem          </short>
        protected new virtual QPainterPath Shape() {
            return appletScript.Shape();
        }
        protected QSizeF Size() {
            return appletScript.Size();
        }
        /// <remarks>
        ///  Reimplemented from QGraphicsLayoutItem
        ///          </remarks>        <short>    Reimplemented from QGraphicsLayoutItem          </short>
        public virtual QSizeF SizeHint(Qt.SizeHint which, QSizeF constraint) {
            return new QSizeF();
        }
        protected virtual QSizeF SizeHint(Qt.SizeHint which) {
            return new QSizeF();
        }
        /// <remarks>
        ///  Reimplemented from QObject
        ///           </remarks>        <short>    Reimplemented from QObject           </short>
        protected virtual void TimerEvent(QTimerEvent arg1) {
        }
        ~Applet() {
        }
        public new void Dispose() {
        }
        protected new IAppletSignals Emit {
            get { return (IAppletSignals) Q_EMIT; }
        }
        public static implicit operator Plasma.Applet(Applet arg) {
            return arg.PlasmaApplet;
        }
        public static implicit operator QyotoQGraphicsWidget(Applet arg) {
            return arg.PlasmaApplet;
        }
    }

    public interface IAppletSignals : IQObjectSignals {
        /// <remarks>
        ///  This signal indicates that an application launch, window
        ///  creation or window focus event was triggered. This is used, for instance,
        ///  to ensure that the Dashboard view in Plasma hides when such an event is
        ///  triggered by an item it is displaying.
        ///          </remarks>        <short>    This signal indicates that an application launch, window  creation or window focus event was triggered.</short>
        [Q_SIGNAL("void releaseVisualFocus()")]
        void ReleaseVisualFocus();
        /// <remarks>
        ///  Emitted whenever the applet makes a geometry change, so that views
        ///  can coordinate themselves with these changes if they desire.
        ///          </remarks>        <short>    Emitted whenever the applet makes a geometry change, so that views  can coordinate themselves with these changes if they desire.</short>
        [Q_SIGNAL("void geometryChanged()")]
        void GeometryChanged();
        /// <remarks>
        ///  Emitted when an applet has changed values in its configuration
        ///  and wishes for them to be saved at the next save point. As this implies
        ///  disk activity, this signal should be used with care.
        ///  @note This does not need to be emitted from saveState by individual
        ///  applets.
        ///          </remarks>        <short>    Emitted when an applet has changed values in its configuration  and wishes for them to be saved at the next save point.</short>
        [Q_SIGNAL("void configNeedsSaving()")]
        void ConfigNeedsSaving();
        /// <remarks>
        ///  Emitted when activation is requested due to, for example, a global
        ///  keyboard shortcut. By default the wiget is given focus.
        ///          </remarks>        <short>    Emitted when activation is requested due to, for example, a global  keyboard shortcut.</short>
        [Q_SIGNAL("void activate()")]
        void Activate();
    }
}

// kate: space-indent on; indent-width 4; replace-tabs on; mixed-indent off;
