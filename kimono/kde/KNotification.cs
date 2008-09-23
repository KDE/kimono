//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  KNotification is used to notify the user of an event.
    ///  \section introduction
    ///  There are two main kinds of notifications:
    /// 
    /// <li>
    /// Feedback events:
    ///  For notifying the user that he/she just performed an operation, like maximizing a
    ///  window. This allows us to play sounds when a dialog appears.
    ///  This is an instant notification.  It ends automatically after a small timeout.
    /// </li>
    /// 
    /// <li>
    /// persistant notifications:
    ///  Notify when the user received a new message, or when something else important happened
    ///  the user has to know about.  This notification has a start and a end.  It begins when
    ///  the event actually occurs, and finishes when the message is acknowledged or read.
    /// </li>
    ///  Example of a persistent notification in an instant messaging application:
    ///  The application emits the notification when the message is actually received, and closes it only
    ///  when the user has read the message (when the message window has received the focus) using the close() slot
    ///  Persistent notifications must have the Persistent flag.
    ///  In order to perform a notification, you need to create a description file, which contains
    ///  default parameters of the notification, and use KNotification.Event at the place in the
    ///  application code where the notification occurs.
    ///  The returned KNotification pointer may be used to connect signals or slots
    ///  \section file The global config file
    ///  Your application should install a file called:
    ///   <em>$KDEDIR/share/apps/appname/appname.notifyrc</em>
    ///  You can do this with the following CMake command:
    ///  install( FILES appname.notifyrc  DESTINATION ${DATA_INSTALL_DIR}/appname))
    ///   This file contains  mainly 3 parts
    ///    <ol><li>\ref global "Global information"</li>
    ///        <li>\ref context "Context information"</li>
    ///        <li>\ref events "Definition of individual events"</li></ol>
    ///   \subsection global Global information
    ///  The global part looks like that
    ///  <pre>
    /// 		   [Global]
    /// 		   IconName=Filename
    /// 		   Comment=Friendly Name of app
    ///  </pre>
    ///    The icon filename is just the name, without extension,  it's found with the KIconLoader
    ///  \subsection context Context information
    ///  This part consists of hints for the configuration widget
    ///   <pre>
    /// 		   [Context/group]
    /// 		   Name=Group name
    /// 		   Comment=The name of the group for contacts
    /// 		   [Context/folder]
    /// 		   Name=Group name
    ///   </pre>
    ///   The second part of the groupname is the context identifier.
    ///   It should not contain special characters.
    ///   The Name field is the one the user will see (and which is translated)
    ///  \subsection events Definition of Events
    ///  The definition of the events forms the most important part of the config file
    ///  <pre>
    /// 		   [Event/newmail]
    /// 		   Name=New email
    /// 		   Comment=You have got a new email
    /// 		   Contexts=folder,group
    /// 		   Action=Sound|Popup
    /// 		   [Event/contactOnline]
    /// 		   Name=Contact goes online
    /// 		   Comment=One of your contact has been connected
    /// 		   Contexts=group
    /// 		   Sound=filetoplay.ogg
    /// 		   Action=None
    ///   </pre>
    ///   These are the default settings for each notifiable event.
    ///   Action is a bitmask of KNotification.NotifyPresentation
    ///   Contexts is a comma separated list of possible context for this event.
    ///   \section userfile The user's config file
    ///   This is an implementation detail, and is described here for your information.
    ///   In the config file, there are two parts:  the event configuration, and the context information
    ///  \subsection context Context information
    ///   These are hints for the configuration dialog. They contain both the internal id of the context, and the user visible string.
    ///   <pre>
    /// 		   [Context/group]
    /// 		   Values=1:Friends,2:Work,3:Family
    ///   </pre>
    ///  \subsection event Events configuration
    ///    This contains the configuration of events for the user.
    ///    It contains the same fields as the description file.
    ///     The key of groups is in the form 
    ///   <em>Event/&lt;EventName&gt;/&lt;ContextName&gt;/&lt;ContextValue&gt;</em>
    ///  <pre>
    /// 		   [Event/contactOnline]
    /// 		   Action=Sound
    /// 		   Sound=/usr/share/sounds/super.ogg
    /// 		   [Event/contactOnline/group/1]
    /// 		   Action=PassivePopup|Sound
    ///  </pre>
    ///  \section example Example of code
    ///  This portion of code will fire the event for the "contactOnline" event
    ///  @code
    /// 	KNotification notification= new KNotification ( "contactOnline", widget );
    /// 	notification.SetText( i18n("The contact <i>%1</i> has gone online").arg( contact.Name() ) );
    /// 	notification.SetPixmap( contact.Pixmap() );
    /// 	notification.SetActions( List<string>( i18n( "Open chat" ) ) );
    /// 	foreach( stringgroup , contact.Groups() ) {
    /// 		notification.AddContext( "group" , group ) ;
    /// 	}
    /// 	connect(notification, SIGNAL("activated(unsigned int )"), contact , SLOT("slotOpenChat()") );
    /// 	notification.SendEvent();
    ///  @endcode
    ///  See <see cref="IKNotificationSignals"></see> for signals emitted by KNotification
    /// </remarks>        <author> Olivier Goffart  \<ogoffart at kde.org\>
    ///  </author>
    ///         <short>    KNotification is used to notify the user of an event.</short>
    [SmokeClass("KNotification")]
    public class KNotification : QObject, IDisposable {
        protected KNotification(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KNotification), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KNotification() {
            staticInterceptor = new SmokeInvocation(typeof(KNotification), null);
        }
        public enum NotificationFlag {
            RaiseWidgetOnActivation = 0x01,
            CloseOnTimeout = 0x00,
            Persistent = 0x02,
            CloseWhenWidgetActivated = 0x04,
            Persistant = Persistent,
            DefaultEvent = 0xF000,
        }
        /// <remarks>
        ///  default events you can use in the event function
        /// 	 </remarks>        <short>    default events you can use in the event function 	 </short>
        public enum StandardEvent {
            Notification = 0,
            Warning = 1,
            Error = 2,
            Catastrophe = 3,
        }
        /// <remarks>
        ///  Create a new notification.
        ///  You have to use sendEvent to show the notification.
        ///  The pointer is automatically deleted when the event is closed.
        ///  Make sure you use one of the NotificationFlags CloseOnTimeOut or 
        ///  CloseWhenWidgetActivated, if not,
        ///  you have to close the notification yourself.
        /// <param> name="eventId" is the name of the event
        /// </param><param> name="widget" is a widget where the notification reports to
        /// </param><param> name="flags" is a bitmask of NotificationFlag
        /// 	 </param></remarks>        <short>    Create a new notification.</short>
        public KNotification(string eventId, QWidget widget, uint flags) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KNotification$#$", "KNotification(const QString&, QWidget*, const KNotification::NotificationFlags&)", typeof(void), typeof(string), eventId, typeof(QWidget), widget, typeof(uint), flags);
        }
        public KNotification(string eventId, QWidget widget) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KNotification$#", "KNotification(const QString&, QWidget*)", typeof(void), typeof(string), eventId, typeof(QWidget), widget);
        }
        public KNotification(string eventId) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KNotification$", "KNotification(const QString&)", typeof(void), typeof(string), eventId);
        }
        /// <remarks>
        ///  @brief the widget associated to the notification
        ///  If the widget is destroyed, the notification will be automatically cancelled.
        ///  If the widget is activated, the notification will be automatically closed if the NotificationFlags specify that
        ///  When the notification is activated, the widget might be raised.
        ///  Depending on the configuration, the taskbar entry of the window containing the widget may blink.
        /// 	 </remarks>        <short>    @brief the widget associated to the notification </short>
        public QWidget Widget() {
            return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
        }
        /// <remarks>
        ///  Set the widget associated to the notification.
        ///  The notification is reparented to the new widget.
        ///  \see widget()
        /// <param> name="widget" the new widget
        /// 	 </param></remarks>        <short>    Set the widget associated to the notification.</short>
        public void SetWidget(QWidget widget) {
            interceptor.Invoke("setWidget#", "setWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        /// <remarks>
        /// </remarks>        <return> the name of the event
        /// 	 </return>
        ///         <short>   </short>
        public string EventId() {
            return (string) interceptor.Invoke("eventId", "eventId() const", typeof(string));
        }
        /// <remarks>
        /// </remarks>        <return> the notification text
        /// </return>
        ///         <short>   </short>
        ///         <see> setText</see>
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        /// <remarks>
        ///  Set the notification text that will appear in the popup.
        ///  The text is shown in a QLabel, you should make sure to escape any html that is needed.
        ///  You can use some of the qt basic html tags.
        /// <param> name="text" the text
        /// 	 </param></remarks>        <short>    Set the notification text that will appear in the popup.</short>
        public void SetText(string text) {
            interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
        }
        /// <remarks>
        ///  \return the pixmap shown in the popup
        ///  \see setPixmap
        /// 	 </remarks>        <short>    \return the pixmap shown in the popup  \see setPixmap 	 </short>
        public QPixmap Pixmap() {
            return (QPixmap) interceptor.Invoke("pixmap", "pixmap() const", typeof(QPixmap));
        }
        /// <remarks>
        ///  set the pixmap that will be shown in the popup.
        /// <param> name="pix" the pixmap
        /// 	 </param></remarks>        <short>    set the pixmap that will be shown in the popup.</short>
        public void SetPixmap(QPixmap pix) {
            interceptor.Invoke("setPixmap#", "setPixmap(const QPixmap&)", typeof(void), typeof(QPixmap), pix);
        }
        /// <remarks>
        /// </remarks>        <return> the list of actions
        /// 	 </return>
        ///         <short>   </short>
        public List<string> Actions() {
            return (List<string>) interceptor.Invoke("actions", "actions() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Set the list of actions link shown in the popup.
        /// <param> name="actions" the list of actions
        /// 	 </param></remarks>        <short>    Set the list of actions link shown in the popup.</short>
        public void SetActions(List<string> actions) {
            interceptor.Invoke("setActions?", "setActions(const QStringList&)", typeof(void), typeof(List<string>), actions);
        }
        /// <remarks>
        /// </remarks>        <return> the list of contexts, see KNotification.Context
        /// 	 </return>
        ///         <short>   </short>
        public List<QPair<string, string>> Contexts() {
            return (List<QPair<string, string>>) interceptor.Invoke("contexts", "contexts() const", typeof(List<QPair<string, string>>));
        }
        /// <remarks>
        ///  set the list of contexts, see KNotification.Context
        ///  The list of contexts must be set before calling sendEvent;
        /// 	 </remarks>        <short>    set the list of contexts, see KNotification.Context </short>
        public void SetContexts(List<QPair<string, string>> contexts) {
            interceptor.Invoke("setContexts?", "setContexts(const QList<QPair<QString,QString> >&)", typeof(void), typeof(List<QPair<string, string>>), contexts);
        }
        /// <remarks>
        ///  append a context at the list of contexts, see KNotificaiton.Context
        /// <param> name="context" the context which is added
        /// 	 </param></remarks>        <short>    append a context at the list of contexts, see KNotificaiton.Context </short>
        public void AddContext(QPair<string, string> context) {
            interceptor.Invoke("addContext?", "addContext(const QPair<QString,QString>&)", typeof(void), typeof(QPair<string, string>), context);
        }
        /// <remarks>
        ///  @overload
        /// <param> name="context_key" is the key of the context
        /// </param><param> name="context_value" is the value of the context
        /// 	 </param></remarks>        <short>    @overload </short>
        public void AddContext(string context_key, string context_value) {
            interceptor.Invoke("addContext$$", "addContext(const QString&, const QString&)", typeof(void), typeof(string), context_key, typeof(string), context_value);
        }
        /// <remarks>
        /// </remarks>        <return> the notification flags.
        ///      </return>
        ///         <short>   </short>
        public uint Flags() {
            return (uint) interceptor.Invoke("flags", "flags() const", typeof(uint));
        }
        /// <remarks>
        ///  Set the notification flags.
        ///  should be called before sendEvent().
        ///      </remarks>        <short>    Set the notification flags.</short>
        public void SetFlags(uint flags) {
            interceptor.Invoke("setFlags$", "setFlags(const KNotification::NotificationFlags&)", typeof(void), typeof(uint), flags);
        }
        /// <remarks>
        ///  The componentData is used to determine the location of the config file.  By default, kapp is used
        /// <param> name="componentData" the new componentData
        ///      </param></remarks>        <short>    The componentData is used to determine the location of the config file.</short>
        public void SetComponentData(KComponentData componentData) {
            interceptor.Invoke("setComponentData#", "setComponentData(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
        }
        /// <remarks>
        ///  @brief Activate the action specified action
        ///  If the action is zero, then the default action is activated
        /// 	 </remarks>        <short>    @brief Activate the action specified action  If the action is zero, then the default action is activated 	 </short>
        [Q_SLOT("void activate(unsigned int)")]
        public void Activate(uint action) {
            interceptor.Invoke("activate$", "activate(unsigned int)", typeof(void), typeof(uint), action);
        }
        [Q_SLOT("void activate()")]
        public void Activate() {
            interceptor.Invoke("activate", "activate()", typeof(void));
        }
        /// <remarks>
        ///  Close the notification without activating it.
        ///  This will delete the notification.
        /// 	 </remarks>        <short>    Close the notification without activating it.</short>
        [Q_SLOT("void close()")]
        public void Close() {
            interceptor.Invoke("close", "close()", typeof(void));
        }
        /// <remarks>
        ///  @brief Raise the widget.
        ///  This will change the desktop, activate the window, and the tab if needed.
        /// 	 </remarks>        <short>    @brief Raise the widget.</short>
        [Q_SLOT("void raiseWidget()")]
        public void RaiseWidget() {
            interceptor.Invoke("raiseWidget", "raiseWidget()", typeof(void));
        }
        /// <remarks>
        ///  The notification will automatically be closed if all presentations are finished.
        ///  if you want to show your own presentation in your application, you should use this
        ///  function, so it will not be automatically closed when there is nothing to show.
        ///  don't forgot to deref, or the notification may be never closed if there is no timeout.
        /// </remarks>        <short>    The notification will automatically be closed if all presentations are finished.</short>
        ///         <see> ref</see>
        [Q_SLOT("void ref()")]
        public void Ref() {
            interceptor.Invoke("ref", "ref()", typeof(void));
        }
        /// <remarks>
        ///  remove a reference made with ref()
        ///  the notification may be closed when calling this.
        /// </remarks>        <short>    remove a reference made with ref()  the notification may be closed when calling this.</short>
        ///         <see> ref</see>
        [Q_SLOT("void deref()")]
        public void Deref() {
            interceptor.Invoke("deref", "deref()", typeof(void));
        }
        /// <remarks>
        ///  Emit or re-emit the event.
        /// 	 </remarks>        <short>    Emit or re-emit the event.</short>
        [Q_SLOT("void sendEvent()")]
        public void SendEvent() {
            interceptor.Invoke("sendEvent", "sendEvent()", typeof(void));
        }
        /// <remarks>
        ///  update the texts, the icon, and the actions of one existing notification
        /// 	 </remarks>        <short>   </short>
        [Q_SLOT("void update()")]
        public void Update() {
            interceptor.Invoke("update", "update()", typeof(void));
        }
        /// <remarks>
        ///  reimplemented for internal reasons
        /// 	 </remarks>        <short>    reimplemented for internal reasons 	 </short>
        [SmokeMethod("eventFilter(QObject*, QEvent*)")]
        protected new virtual bool EventFilter(QObject watched, QEvent arg2) {
            return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), watched, typeof(QEvent), arg2);
        }
        ~KNotification() {
            interceptor.Invoke("~KNotification", "~KNotification()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KNotification", "~KNotification()", typeof(void));
        }
        /// <remarks>
        ///  @brief emit an event
        ///  This method creates the KNotification, setting every parameter, and fire the event.
        ///  You don't need to call sendEvent
        ///  A popup may be displayed or a sound may be played, depending the config.
        ///  return a KNotification .  You may use that pointer to connect some signals or slot.
        ///  the pointer is automatically deleted when the event is closed.
        ///  Make sure you use one of the CloseOnTimeOut or CloseWhenWidgetActivated, if not,
        ///  you have to close yourself the notification.
        ///  @note the text is shown in a QLabel, you should escape HTML, if needed.
        /// <param> name="eventId" is the name of the event
        /// </param><param> name="text" is the text of the notification to show in the popup.
        /// </param><param> name="pixmap" is a picture which may be shown in the popup.
        /// </param><param> name="widget" is a widget where the notification reports to
        /// </param><param> name="flags" is a bitmask of NotificationFlag
        /// </param><param> name="componentData" used to determine the location of the config file.  by default, kapp is used
        /// 	 </param></remarks>        <short>    @brief emit an event </short>
        public static KNotification Event(string eventId, string text, QPixmap pixmap, QWidget widget, uint flags, KComponentData componentData) {
            return (KNotification) staticInterceptor.Invoke("event$$##$#", "event(const QString&, const QString&, const QPixmap&, QWidget*, const KNotification::NotificationFlags&, const KComponentData&)", typeof(KNotification), typeof(string), eventId, typeof(string), text, typeof(QPixmap), pixmap, typeof(QWidget), widget, typeof(uint), flags, typeof(KComponentData), componentData);
        }
        public static KNotification Event(string eventId, string text, QPixmap pixmap, QWidget widget, uint flags) {
            return (KNotification) staticInterceptor.Invoke("event$$##$", "event(const QString&, const QString&, const QPixmap&, QWidget*, const KNotification::NotificationFlags&)", typeof(KNotification), typeof(string), eventId, typeof(string), text, typeof(QPixmap), pixmap, typeof(QWidget), widget, typeof(uint), flags);
        }
        public static KNotification Event(string eventId, string text, QPixmap pixmap, QWidget widget) {
            return (KNotification) staticInterceptor.Invoke("event$$##", "event(const QString&, const QString&, const QPixmap&, QWidget*)", typeof(KNotification), typeof(string), eventId, typeof(string), text, typeof(QPixmap), pixmap, typeof(QWidget), widget);
        }
        public static KNotification Event(string eventId, string text, QPixmap pixmap) {
            return (KNotification) staticInterceptor.Invoke("event$$#", "event(const QString&, const QString&, const QPixmap&)", typeof(KNotification), typeof(string), eventId, typeof(string), text, typeof(QPixmap), pixmap);
        }
        public static KNotification Event(string eventId, string text) {
            return (KNotification) staticInterceptor.Invoke("event$$", "event(const QString&, const QString&)", typeof(KNotification), typeof(string), eventId, typeof(string), text);
        }
        public static KNotification Event(string eventId) {
            return (KNotification) staticInterceptor.Invoke("event$", "event(const QString&)", typeof(KNotification), typeof(string), eventId);
        }
        /// <remarks>
        ///  @brief emit a standard event
        ///  @overload
        ///  This will emit a standard event
        /// <param> name="eventId" is the name of the event
        /// </param><param> name="text" is the text of the notification to show in the popup
        /// </param><param> name="pixmap" is a picture which may be shown in the popup
        /// </param><param> name="widget" is a widget where the notification reports to
        /// </param><param> name="flags" is a bitmask of NotificationFlag 
        /// 	 </param></remarks>        <short>    @brief emit a standard event  @overload </short>
        public static KNotification Event(KNotification.StandardEvent eventId, string text, QPixmap pixmap, QWidget widget, uint flags) {
            return (KNotification) staticInterceptor.Invoke("event$$##$", "event(KNotification::StandardEvent, const QString&, const QPixmap&, QWidget*, const KNotification::NotificationFlags&)", typeof(KNotification), typeof(KNotification.StandardEvent), eventId, typeof(string), text, typeof(QPixmap), pixmap, typeof(QWidget), widget, typeof(uint), flags);
        }
        public static KNotification Event(KNotification.StandardEvent eventId, string text, QPixmap pixmap, QWidget widget) {
            return (KNotification) staticInterceptor.Invoke("event$$##", "event(KNotification::StandardEvent, const QString&, const QPixmap&, QWidget*)", typeof(KNotification), typeof(KNotification.StandardEvent), eventId, typeof(string), text, typeof(QPixmap), pixmap, typeof(QWidget), widget);
        }
        public static KNotification Event(KNotification.StandardEvent eventId, string text, QPixmap pixmap) {
            return (KNotification) staticInterceptor.Invoke("event$$#", "event(KNotification::StandardEvent, const QString&, const QPixmap&)", typeof(KNotification), typeof(KNotification.StandardEvent), eventId, typeof(string), text, typeof(QPixmap), pixmap);
        }
        public static KNotification Event(KNotification.StandardEvent eventId, string text) {
            return (KNotification) staticInterceptor.Invoke("event$$", "event(KNotification::StandardEvent, const QString&)", typeof(KNotification), typeof(KNotification.StandardEvent), eventId, typeof(string), text);
        }
        public static KNotification Event(KNotification.StandardEvent eventId) {
            return (KNotification) staticInterceptor.Invoke("event$", "event(KNotification::StandardEvent)", typeof(KNotification), typeof(KNotification.StandardEvent), eventId);
        }
        /// <remarks>
        ///  This is a simple substitution for QApplication.Beep()
        /// <param> name="reason" a short text explaining what has happened (may be empty)
        /// </param><param> name="widget" the widget the notification refers to
        /// 	 </param></remarks>        <short>    This is a simple substitution for QApplication.Beep() </short>
        public static void Beep(string reason, QWidget widget) {
            staticInterceptor.Invoke("beep$#", "beep(const QString&, QWidget*)", typeof(void), typeof(string), reason, typeof(QWidget), widget);
        }
        public static void Beep(string reason) {
            staticInterceptor.Invoke("beep$", "beep(const QString&)", typeof(void), typeof(string), reason);
        }
        public static void Beep() {
            staticInterceptor.Invoke("beep", "beep()", typeof(void));
        }
        protected new IKNotificationSignals Emit {
            get { return (IKNotificationSignals) Q_EMIT; }
        }
    }

    public interface IKNotificationSignals : IQObjectSignals {
        /// <remarks>
        ///  Emit only when the default activation has occurred
        /// 	 </remarks>        <short>    Emit only when the default activation has occurred 	 </short>
        [Q_SIGNAL("void activated()")]
        void Activated();
        /// <remarks>
        ///  Emit when an action has been activated.
        /// <param> name="action" will be 0 is the default aciton was activated, or any action id
        /// 	 </param></remarks>        <short>    Emit when an action has been activated.</short>
        [Q_SIGNAL("void activated(unsigned int)")]
        void Activated(uint action);
        /// <remarks>
        ///  Convenience signal that is emitted when the first action is activated.
        ///      </remarks>        <short>    Convenience signal that is emitted when the first action is activated.</short>
        [Q_SIGNAL("void action1Activated()")]
        void Action1Activated();
        /// <remarks>
        ///  \overload
        ///      </remarks>        <short>    \overload      </short>
        [Q_SIGNAL("void action2Activated()")]
        void Action2Activated();
        /// <remarks>
        ///  \overload
        ///      </remarks>        <short>    \overload      </short>
        [Q_SIGNAL("void action3Activated()")]
        void Action3Activated();
        /// <remarks>
        ///  Emitted when the notification is closed. Both when it is activated or if it is just ignored.
        /// 	 </remarks>        <short>    Emitted when the notification is closed.</short>
        [Q_SIGNAL("void closed()")]
        void Closed();
        /// <remarks>
        ///  The notification has been ignored
        /// 	 </remarks>        <short>    The notification has been ignored 	 </short>
        [Q_SIGNAL("void ignored()")]
        void Ignored();
    }
}
