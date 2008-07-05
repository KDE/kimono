//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  Class for manipulating the application startup notification.
	///  This class can be used to send information about started application,
	///  change the information and receive this information. For detailed
	///  description, see kdelibs/kdecore/README.kstartupinfo.
	///  You usually don't need to use this class for sending the notification
	///  information, as KDE libraries should do this when an application is
	///  started (e.g. KRun class).
	///  For receiving the startup notification info, create an instance and connect
	///  to its slots. It will automatically detect started applications and when
	///  they are ready.
	///  See <see cref="IKStartupInfoSignals"></see> for signals emitted by KStartupInfo
	/// </remarks>		<author> Lubos Lunak <l.lunak@kde.org>
	///  </author>
	/// 		<short>    Class for manipulating the application startup notification.</short>
	/// 		<see> KStartupInfoId</see>
	/// 		<see> KStartupInfoData</see>
	[SmokeClass("KStartupInfo")]
	public class KStartupInfo : QObject, IDisposable {
 		protected KStartupInfo(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KStartupInfo), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KStartupInfo() {
			staticInterceptor = new SmokeInvocation(typeof(KStartupInfo), null);
		}
		/// <remarks>
		/// 
		/// <li>
		/// NoMatch    - the window doesn't match any existing startup notification
		/// </li>
		/// 
		/// <li>
		/// Match      - the window matches an existing startup notification
		/// </li>
		/// 
		/// <li>
		/// CantDetect - unable to detect if the window matches any existing
		/// 			startup notification
		/// 	 
		/// </li></remarks>		<short>   </short>
		public enum startup_t {
			NoMatch = 0,
			Match = 1,
			CantDetect = 2,
		}
		public const int CleanOnCantDetect = 1<<0;
		public const int DisableKWinModule = 1<<1;
		public const int AnnounceSilenceChanges = 1<<2;
		// bool sendStartupX(Display* arg1,const KStartupInfoId& arg2,const KStartupInfoData& arg3); >>>> NOT CONVERTED
		// bool sendChangeX(Display* arg1,const KStartupInfoId& arg2,const KStartupInfoData& arg3); >>>> NOT CONVERTED
		// bool sendFinishX(Display* arg1,const KStartupInfoId& arg2); >>>> NOT CONVERTED
		// bool sendFinishX(Display* arg1,const KStartupInfoId& arg2,const KStartupInfoData& arg3); >>>> NOT CONVERTED
		/// <remarks>
		///  Creates an instance that will receive the startup notifications.
		///  The various flags passed may be
		/// 
		/// <li>
		/// CleanOnCantDetect - when a new unknown window appears, all startup
		///      notifications for applications that are not compliant with
		///      the startup protocol are removed
		/// </li>
		/// 
		/// <li>
		/// DisableKWinModule - KWinModule, which is normally used to detect
		///      new windows, is disabled. With this flag, checkStartup() must be
		///      called in order to check newly mapped windows.
		/// </li>
		/// 
		/// <li>
		/// AnnounceSilenceChanges - normally, startup notifications are
		///      "removed" when they're silenced, and "recreated" when they're resumed.
		///      With this flag, the change is normally announced with gotStartupChange().
		/// </li>
		/// <param> name="flags" OR-ed combination of flags
		/// </param><param> name="parent" the parent of this QObject (can be 0 for no parent)
		/// </param>	 </remarks>		<short>    Creates an instance that will receive the startup notifications.</short>
		public KStartupInfo(int flags, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KStartupInfo$#", "KStartupInfo(int, QObject*)", typeof(void), typeof(int), flags, typeof(QObject), parent);
		}
		public KStartupInfo(int flags) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KStartupInfo$", "KStartupInfo(int)", typeof(void), typeof(int), flags);
		}
		/// <remarks>
		///  Checks if the given windows matches any existing startup notification.
		/// <param> name="w" the window id to check
		/// </param></remarks>		<return> the result of the operation
		/// 	 </return>
		/// 		<short>    Checks if the given windows matches any existing startup notification.</short>
		public KStartupInfo.startup_t CheckStartup(uint w) {
			return (KStartupInfo.startup_t) interceptor.Invoke("checkStartup$", "checkStartup(WId)", typeof(KStartupInfo.startup_t), typeof(uint), w);
		}
		/// <remarks>
		///  Checks if the given windows matches any existing startup notification, and
		///  if yes, returns the identification in id.
		/// <param> name="w" the window id to check
		/// </param><param> name="id" if found, the id of the startup notification will be written here
		/// </param></remarks>		<return> the result of the operation
		/// 	 </return>
		/// 		<short>    Checks if the given windows matches any existing startup notification, and  if yes, returns the identification in id.</short>
		public KStartupInfo.startup_t CheckStartup(uint w, KStartupInfoId id) {
			return (KStartupInfo.startup_t) interceptor.Invoke("checkStartup$#", "checkStartup(WId, KStartupInfoId&)", typeof(KStartupInfo.startup_t), typeof(uint), w, typeof(KStartupInfoId), id);
		}
		/// <remarks>
		///  Checks if the given windows matches any existing startup notification, and
		///  if yes, returns the notification data in data.
		/// <param> name="w" the window id to check
		/// </param><param> name="data" if found, the data of the startup notification will be written here
		/// </param></remarks>		<return> the result of the operation
		/// 	 </return>
		/// 		<short>    Checks if the given windows matches any existing startup notification, and  if yes, returns the notification data in data.</short>
		public KStartupInfo.startup_t CheckStartup(uint w, KStartupInfoData data) {
			return (KStartupInfo.startup_t) interceptor.Invoke("checkStartup$#", "checkStartup(WId, KStartupInfoData&)", typeof(KStartupInfo.startup_t), typeof(uint), w, typeof(KStartupInfoData), data);
		}
		/// <remarks>
		///  Checks if the given windows matches any existing startup notification, and
		///  if yes, returns the identification in id and notification data in data.
		/// <param> name="w" the window id to check
		/// </param><param> name="id" if found, the id of the startup notification will be written here
		/// </param><param> name="data" if found, the data of the startup notification will be written here
		/// </param></remarks>		<return> the result of the operation
		/// 	 </return>
		/// 		<short>    Checks if the given windows matches any existing startup notification, and  if yes, returns the identification in id and notification data in data.</short>
		public KStartupInfo.startup_t CheckStartup(uint w, KStartupInfoId id, KStartupInfoData data) {
			return (KStartupInfo.startup_t) interceptor.Invoke("checkStartup$##", "checkStartup(WId, KStartupInfoId&, KStartupInfoData&)", typeof(KStartupInfo.startup_t), typeof(uint), w, typeof(KStartupInfoId), id, typeof(KStartupInfoData), data);
		}
		/// <remarks>
		///  Sets the timeout for notifications, after this timeout a notification is removed.
		/// <param> name="secs" the new timeout in seconds
		/// 	 </param></remarks>		<short>    Sets the timeout for notifications, after this timeout a notification is removed.</short>
		public void SetTimeout(uint secs) {
			interceptor.Invoke("setTimeout$", "setTimeout(unsigned int)", typeof(void), typeof(uint), secs);
		}
		/// <remarks>
		/// 	 </remarks>		<short>   </short>
		[SmokeMethod("customEvent(QEvent*)")]
		protected override void CustomEvent(QEvent e_P) {
			interceptor.Invoke("customEvent#", "customEvent(QEvent*)", typeof(void), typeof(QEvent), e_P);
		}
		~KStartupInfo() {
			interceptor.Invoke("~KStartupInfo", "~KStartupInfo()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KStartupInfo", "~KStartupInfo()", typeof(void));
		}
		/// <remarks>
		///  By default, the startup notification is ended for the application
		///  after it shows its first toplevel window. If you app e.g. has
		///  several toplevel windows after its startup, you can disable
		///  the automatic handling, and call appStarted() manually after
		///  all toplevel windows have been shown.
		///          </remarks>		<short>    By default, the startup notification is ended for the application  after it shows its first toplevel window.</short>
		public static void DisableAutoAppStartedSending(bool disable) {
			staticInterceptor.Invoke("disableAutoAppStartedSending$", "disableAutoAppStartedSending(bool)", typeof(void), typeof(bool), disable);
		}
		public static void DisableAutoAppStartedSending() {
			staticInterceptor.Invoke("disableAutoAppStartedSending", "disableAutoAppStartedSending()", typeof(void));
		}
		/// <remarks>
		///  Manual notification that the application has started.
		///  If you do not map a (toplevel) window, then startup
		///  notification will not disappear for the application
		///  until a timeout. You can use this as an alternative
		///  method in this case.
		///          </remarks>		<short>    Manual notification that the application has started.</short>
		public static void AppStarted() {
			staticInterceptor.Invoke("appStarted", "appStarted()", typeof(void));
		}
		/// <remarks>
		///  Sends explicit notification that the startup notification
		///  with id startup_id should end.
		///          </remarks>		<short>    Sends explicit notification that the startup notification  with id startup_id should end.</short>
		public static void AppStarted(QByteArray startup_id) {
			staticInterceptor.Invoke("appStarted#", "appStarted(const QByteArray&)", typeof(void), typeof(QByteArray), startup_id);
		}
		/// <remarks>
		///  Use this function if the application got a request with startup
		///  notification from outside (for example, when KUniqueApplication.NewInstance()
		///  is called, or e.g. when khelpcenter opens new URL in its window).
		///  The window can be either an already existing and visible window,
		///  or a new one, before being shown. Note that this function is usually
		///  needed only when a window is reused.
		///          </remarks>		<short>    Use this function if the application got a request with startup  notification from outside (for example, when KUniqueApplication.NewInstance()  is called, or e.</short>
		public static void SetNewStartupId(QWidget window, QByteArray startup_id) {
			staticInterceptor.Invoke("setNewStartupId##", "setNewStartupId(QWidget*, const QByteArray&)", typeof(void), typeof(QWidget), window, typeof(QByteArray), startup_id);
		}
		/// <remarks>
		///  If your application shows temporarily some window during its startup,
		///  for example a dialog, and only after closing it shows the main window,
		///  startup notification would normally be shown while the dialog is visible.
		///  To temporarily suspend and resume the notification, use this function.
		///  Note that this is cumulative, i.e. after suspending twice, you have to
		///  resume twice.
		///          </remarks>		<short>    If your application shows temporarily some window during its startup,  for example a dialog, and only after closing it shows the main window,  startup notification would normally be shown while the dialog is visible.</short>
		public static void SilenceStartup(bool silence) {
			staticInterceptor.Invoke("silenceStartup$", "silenceStartup(bool)", typeof(void), typeof(bool), silence);
		}
		/// <remarks>
		///  Creates and returns new startup id. The id includes properly setup
		///  user timestamp.
		///          </remarks>		<short>    Creates and returns new startup id.</short>
		public static QByteArray CreateNewStartupId() {
			return (QByteArray) staticInterceptor.Invoke("createNewStartupId", "createNewStartupId()", typeof(QByteArray));
		}
		/// <remarks>
		///  Sends given notification data about started application
		///  with the given startup identification. If no notification for this identification
		///  exists yet, it is created, otherwise it's updated. Note that the name field
		///  in data is required.
		/// <param> name="id" the id of the application
		/// </param><param> name="data" the application's data
		/// </param></remarks>		<return> true if successful, false otherwise
		/// </return>
		/// 		<short>    Sends given notification data about started application  with the given startup identification.</short>
		/// 		<see> KStartupInfoId</see>
		/// 		<see> KStartupInfoData</see>
		public static bool SendStartup(KStartupInfoId id, KStartupInfoData data) {
			return (bool) staticInterceptor.Invoke("sendStartup##", "sendStartup(const KStartupInfoId&, const KStartupInfoData&)", typeof(bool), typeof(KStartupInfoId), id, typeof(KStartupInfoData), data);
		}
		/// <remarks>
		///  Like sendStartup , uses dpy instead of qt_x11display() for sending the info.
		/// <param> name="dpy" the display of the application. Note that the name field
		///  in data is required.
		/// </param><param> name="id" the id of the application
		/// </param><param> name="data" the application's data
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Like sendStartup , uses dpy instead of qt_x11display() for sending the info.</short>
		/// <remarks>
		///  Sends given notification data about started application
		///  with the given startup identification. This is used for updating the notification
		///  info, if no notification for this identification exists, it's ignored.
		/// <param> name="id" the id of the application
		/// </param><param> name="data" the application's data
		/// </param></remarks>		<return> true if successful, false otherwise
		/// </return>
		/// 		<short>    Sends given notification data about started application  with the given startup identification.</short>
		/// 		<see> KStartupInfoId</see>
		/// 		<see> KStartupInfoData</see>
		public static bool SendChange(KStartupInfoId id, KStartupInfoData data) {
			return (bool) staticInterceptor.Invoke("sendChange##", "sendChange(const KStartupInfoId&, const KStartupInfoData&)", typeof(bool), typeof(KStartupInfoId), id, typeof(KStartupInfoData), data);
		}
		/// <remarks>
		///  Like sendChange , uses dpy instead of qt_x11display() for sending the info.
		/// <param> name="dpy" the display of the application.
		/// </param><param> name="id" the id of the application
		/// </param><param> name="data" the application's data
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Like sendChange , uses dpy instead of qt_x11display() for sending the info.</short>
		/// <remarks>
		///  Ends startup notification with the given identification.
		/// <param> name="id" the id of the application
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Ends startup notification with the given identification.</short>
		public static bool SendFinish(KStartupInfoId id) {
			return (bool) staticInterceptor.Invoke("sendFinish#", "sendFinish(const KStartupInfoId&)", typeof(bool), typeof(KStartupInfoId), id);
		}
		/// <remarks>
		///  Like sendFinish , uses dpy instead of qt_x11display() for sending the info.
		/// <param> name="dpy" the display of the application.
		/// </param><param> name="id" the id of the application
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Like sendFinish , uses dpy instead of qt_x11display() for sending the info.</short>
		/// <remarks>
		///  Ends startup notification with the given identification and the given data ( e.g.
		///  PIDs of processes for this startup notification that exited ).
		/// <param> name="id" the id of the application
		/// </param><param> name="data" the application's data
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Ends startup notification with the given identification and the given data ( e.</short>
		public static bool SendFinish(KStartupInfoId id, KStartupInfoData data) {
			return (bool) staticInterceptor.Invoke("sendFinish##", "sendFinish(const KStartupInfoId&, const KStartupInfoData&)", typeof(bool), typeof(KStartupInfoId), id, typeof(KStartupInfoData), data);
		}
		/// <remarks>
		///  Like sendFinish , uses dpy instead of qt_x11display() for sending the info.
		/// <param> name="dpy" the display of the application.
		/// </param><param> name="id" the id of the application
		/// </param><param> name="data" the application's data
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Like sendFinish , uses dpy instead of qt_x11display() for sending the info.</short>
		/// <remarks>
		///  Returns the current startup notification identification for the current
		///  startup notification environment variable. Note that KApplication constructor
		///  unsets the variable and you have to use KApplication.StartupId .
		/// </remarks>		<return> the current startup notification identification
		/// 	 </return>
		/// 		<short>    Returns the current startup notification identification for the current  startup notification environment variable.</short>
		public static KStartupInfoId CurrentStartupIdEnv() {
			return (KStartupInfoId) staticInterceptor.Invoke("currentStartupIdEnv", "currentStartupIdEnv()", typeof(KStartupInfoId));
		}
		/// <remarks>
		///  Unsets the startup notification environment variable.
		/// 	 </remarks>		<short>    Unsets the startup notification environment variable.</short>
		public static void ResetStartupEnv() {
			staticInterceptor.Invoke("resetStartupEnv", "resetStartupEnv()", typeof(void));
		}
		/// <remarks>
		///  Sets the startup notification window property on the given window.
		/// <param> name="window" the id of the window
		/// </param><param> name="id" the startup notification id
		/// 	 </param></remarks>		<short>    Sets the startup notification window property on the given window.</short>
		public static void SetWindowStartupId(uint window, QByteArray id) {
			staticInterceptor.Invoke("setWindowStartupId$#", "setWindowStartupId(WId, const QByteArray&)", typeof(void), typeof(uint), window, typeof(QByteArray), id);
		}
		/// <remarks>
		///  Returns startup notification identification of the given window.
		/// <param> name="w" the id of the window
		/// </param></remarks>		<return> the startup notification id. Can be null if not found.
		/// 	 </return>
		/// 		<short>    Returns startup notification identification of the given window.</short>
		public static QByteArray WindowStartupId(uint w) {
			return (QByteArray) staticInterceptor.Invoke("windowStartupId$", "windowStartupId(WId)", typeof(QByteArray), typeof(uint), w);
		}
		/// <remarks>
		///          </remarks>		<short>   </short>
		public static void HandleAutoAppStartedSending() {
			staticInterceptor.Invoke("handleAutoAppStartedSending", "handleAutoAppStartedSending()", typeof(void));
		}
		protected new IKStartupInfoSignals Emit {
			get { return (IKStartupInfoSignals) Q_EMIT; }
		}
	}

	public interface IKStartupInfoSignals : IQObjectSignals {
		/// <remarks>
		///  Emitted when a new startup notification is created (i.e. a new application is
		///  being started).
		/// <param> name="id" the notification identification
		/// </param><param> name="data" the notification data
		/// 	 </param></remarks>		<short>    Emitted when a new startup notification is created (i.</short>
		[Q_SIGNAL("void gotNewStartup(KStartupInfoId, KStartupInfoData)")]
		void GotNewStartup(KStartupInfoId id, KStartupInfoData data);
		/// <remarks>
		///  Emitted when a startup notification changes.
		/// <param> name="id" the notification identification
		/// </param><param> name="data" the notification data
		/// 	 </param></remarks>		<short>    Emitted when a startup notification changes.</short>
		[Q_SIGNAL("void gotStartupChange(KStartupInfoId, KStartupInfoData)")]
		void GotStartupChange(KStartupInfoId id, KStartupInfoData data);
		/// <remarks>
		///  Emitted when a startup notification is removed (either because it was detected
		///  that the application is ready or because of a timeout).
		/// <param> name="id" the notification identification
		/// </param><param> name="data" the notification data
		/// 	 </param></remarks>		<short>    Emitted when a startup notification is removed (either because it was detected  that the application is ready or because of a timeout).</short>
		[Q_SIGNAL("void gotRemoveStartup(KStartupInfoId, KStartupInfoData)")]
		void GotRemoveStartup(KStartupInfoId id, KStartupInfoData data);
	}
}
