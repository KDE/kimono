//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  KAutostart provides a programmatic means to control the state of
    ///  autostart services on a per-user basis. This is useful for applications
    ///  that wish to offer a configurable means to allow the application to be
    ///  autostarted.
    ///  By using this class you future-proof your applications against potential
    ///  future or platform-specific changes to the autostart mechanism(s).
    ///  Typical usage might look like:
    ///  @code
    ///  KAutostart autostart; // without an entryName arg, gets name from KAboutData
    ///  autostart.setAutostarts(true); // will now start up when the user logs in
    ///  // set the value in our configuration settings to reflect whether or not
    ///  // we will actually start up on log in
    ///  config.setAutoStart(autostart.autoStarts());
    ///  @endcode
    ///  </remarks>        <short>    KAutostart provides a programmatic means to control the state of  autostart services on a per-user basis.</short>
    [SmokeClass("KAutostart")]
    public class KAutostart : QObject, IDisposable {
        protected KAutostart(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KAutostart), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KAutostart() {
            staticInterceptor = new SmokeInvocation(typeof(KAutostart), null);
        }
        /// <remarks>
        ///  Flags for each of the conditions that may affect whether or not
        ///  a service actually autostarted on login
        ///          </remarks>        <short>    Flags for each of the conditions that may affect whether or not  a service actually autostarted on login          </short>
        public enum Condition {
            NoConditions = 0,
            CheckCommand = 1,
        }
        /// <remarks>
        ///  Enumerates the various autostart phases that occur during start-up.
        ///          </remarks>        <short>    Enumerates the various autostart phases that occur during start-up.</short>
        public enum StartPhase {
            BaseDesktop = 0,
            DesktopServices = 1,
            Applications = 2,
        }
        /// <remarks>
        ///  Creates a new KAutostart object that represents the autostart
        ///  service "entryName". If the service already exists in the system
        ///  then the values associated with that service, such as the executable
        ///  command, will be loaded as well.
        ///  Note that unless this service is explicitly set to autostart,
        ///  simply creating a KAutostart object will not result in the
        ///  service being autostarted on next log in.
        ///  If no such service is already registered and the command to be
        ///  executed on startup is not the same as entryName, then you will want
        ///  to set the associated command with setExec(string)
        /// <param> name="entryName" the name used to identify the service. If none is
        ///         provided then it uses the name registered with KAboutData.
        /// </param><param> name="parent" QObject
        ///          </param></remarks>        <short>    Creates a new KAutostart object that represents the autostart  service "entryName".</short>
        ///         <see> setExec</see>
        public KAutostart(string entryName, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAutostart$#", "KAutostart(const QString&, QObject*)", typeof(void), typeof(string), entryName, typeof(QObject), parent);
        }
        public KAutostart(string entryName) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAutostart$", "KAutostart(const QString&)", typeof(void), typeof(string), entryName);
        }
        public KAutostart() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAutostart", "KAutostart()", typeof(void));
        }
        /// <remarks>
        ///  Sets the given exec to start automatically at login
        /// <param> name="autostart" will register with the autostart facility when true
        ///         and deregister when false
        /// </param></remarks>        <short>    Sets the given exec to start automatically at login </short>
        ///         <see> autostarts</see>
        public void SetAutostarts(bool autostart) {
            interceptor.Invoke("setAutostarts$", "setAutostarts(bool)", typeof(void), typeof(bool), autostart);
        }
        /// <remarks>
        ///  Returns whether or not the service represented by entryName in the
        ///  autostart system is set to autostart at login or not
        /// <param> name="environment" if provided the check will be performed as if
        ///         being loaded in that environment
        /// </param><param> name="check" autostart conditions to check for (see commandToCheck())
        /// </param></remarks>        <short>    Returns whether or not the service represented by entryName in the  autostart system is set to autostart at login or not </short>
        ///         <see> setAutostarts</see>
        public bool Autostarts(string environment, uint check) {
            return (bool) interceptor.Invoke("autostarts$$", "autostarts(const QString&, KAutostart::Conditions) const", typeof(bool), typeof(string), environment, typeof(uint), check);
        }
        public bool Autostarts(string environment) {
            return (bool) interceptor.Invoke("autostarts$", "autostarts(const QString&) const", typeof(bool), typeof(string), environment);
        }
        public bool Autostarts() {
            return (bool) interceptor.Invoke("autostarts", "autostarts() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns the associated command for this autostart service
        /// </remarks>        <short>    Returns the associated command for this autostart service </short>
        ///         <see> setCommand</see>
        public string Command() {
            return (string) interceptor.Invoke("command", "command() const", typeof(string));
        }
        /// <remarks>
        ///  Set the associated command for this autostart service
        /// </remarks>        <short>    Set the associated command for this autostart service </short>
        ///         <see> command</see>
        public void SetCommand(string command) {
            interceptor.Invoke("setCommand$", "setCommand(const QString&)", typeof(void), typeof(string), command);
        }
        /// <remarks>
        ///  Returns the user-visible name this autostart service is registered as
        /// </remarks>        <short>    Returns the user-visible name this autostart service is registered as </short>
        ///         <see> setVisibleName</see>
        ///         <see> setEntryName</see>
        public string VisibleName() {
            return (string) interceptor.Invoke("visibleName", "visibleName() const", typeof(string));
        }
        /// <remarks>
        ///  Sets the user-visible name for this autostart service.
        /// </remarks>        <short>    Sets the user-visible name for this autostart service.</short>
        ///         <see> visibleName</see>
        public void SetVisibleName(string entryName) {
            interceptor.Invoke("setVisibleName$", "setVisibleName(const QString&)", typeof(void), typeof(string), entryName);
        }
        /// <remarks>
        ///  Returns the executable to check for when attempting to autostart
        ///  this service. If the executable is not found in the user's
        ///  environment, it will not autostart.
        /// </remarks>        <short>    Returns the executable to check for when attempting to autostart  this service.</short>
        ///         <see> setCommandToCheck</see>
        public string CommandToCheck() {
            return (string) interceptor.Invoke("commandToCheck", "commandToCheck() const", typeof(string));
        }
        /// <remarks>
        ///  Sets the executable to check for the existence of when
        ///  autostarting this service
        /// </remarks>        <short>    Sets the executable to check for the existence of when  autostarting this service </short>
        ///         <see> commandToCheck</see>
        public void SetCommandToCheck(string exec) {
            interceptor.Invoke("setCommandToCheck$", "setCommandToCheck(const QString&)", typeof(void), typeof(string), exec);
        }
        /// <remarks>
        ///  Returns the autostart phase this service is started in.
        ///  Note that this is KDE specific and may not work in other
        ///  environments.
        /// </remarks>        <short>    Returns the autostart phase this service is started in.</short>
        ///         <see> StartPhase</see>
        ///         <see> setStartPhase</see>
        public KAutostart.StartPhase startPhase() {
            return (KAutostart.StartPhase) interceptor.Invoke("startPhase", "startPhase() const", typeof(KAutostart.StartPhase));
        }
        /// <remarks>
        ///  Sets the service (by name) this service should be started after.
        ///  Note that this is KDE specific and may not work in other
        ///  environments.
        /// </remarks>        <short>    Sets the service (by name) this service should be started after.</short>
        ///         <see> StartPhase</see>
        ///         <see> startPhase</see>
        public void SetStartPhase(KAutostart.StartPhase phase) {
            interceptor.Invoke("setStartPhase$", "setStartPhase(KAutostart::StartPhase)", typeof(void), typeof(KAutostart.StartPhase), phase);
        }
        /// <remarks>
        ///  Returns the list of environments (e.g. "KDE") this service is allowed
        ///  to start in.
        ///  This does not take other autostart conditions
        ///  into account. If any environment is added to the allowed environments
        ///  list, then only those environments will be allowed to
        ///  autoload the service. If an environment is marked as both allowed
        ///  and excluded, it will be excluded.
        /// </remarks>        <short>    Returns the list of environments (e.</short>
        ///         <see> setAllowedEnvironments</see>
        public List<string> AllowedEnvironments() {
            return (List<string>) interceptor.Invoke("allowedEnvironments", "allowedEnvironments() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Sets the environments this service is allowed to start in
        /// </remarks>        <short>    Sets the environments this service is allowed to start in </short>
        ///         <see> allowedEnvironments</see>
        ///         <see> addToAllowedEnvironments</see>
        public void SetAllowedEnvironments(List<string> environments) {
            interceptor.Invoke("setAllowedEnvironments?", "setAllowedEnvironments(const QStringList&)", typeof(void), typeof(List<string>), environments);
        }
        /// <remarks>
        ///  Adds an environment to the list of environments this service may
        ///  start in.
        /// </remarks>        <short>    Adds an environment to the list of environments this service may  start in.</short>
        ///         <see> setAllowedEnvironments</see>
        ///         <see> removeFromAllowedEnvironments</see>
        public void AddToAllowedEnvironments(string environment) {
            interceptor.Invoke("addToAllowedEnvironments$", "addToAllowedEnvironments(const QString&)", typeof(void), typeof(string), environment);
        }
        /// <remarks>
        ///  Removes an environment to the list of environments this service may
        ///  start in.
        /// </remarks>        <short>    Removes an environment to the list of environments this service may  start in.</short>
        ///         <see> addToAllowedEnvironments</see>
        public void RemoveFromAllowedEnvironments(string environment) {
            interceptor.Invoke("removeFromAllowedEnvironments$", "removeFromAllowedEnvironments(const QString&)", typeof(void), typeof(string), environment);
        }
        /// <remarks>
        ///  Returns the list of environments this service is explicitly not
        ///  allowed to start in.
        ///  This does not take other autostart conditions
        ///  such as into account. If the same environment is also marked as
        ///  allowed, it will still be excluded.
        /// </remarks>        <short>    Returns the list of environments this service is explicitly not  allowed to start in.</short>
        ///         <see> setExcludedEnvironments</see>
        public List<string> ExcludedEnvironments() {
            return (List<string>) interceptor.Invoke("excludedEnvironments", "excludedEnvironments() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Sets the environments this service is not allowed to start in
        /// </remarks>        <short>    Sets the environments this service is not allowed to start in </short>
        ///         <see> excludedEnvironments</see>
        ///         <see> addToExcludedEnvironments</see>
        public void SetExcludedEnvironments(List<string> environments) {
            interceptor.Invoke("setExcludedEnvironments?", "setExcludedEnvironments(const QStringList&)", typeof(void), typeof(List<string>), environments);
        }
        /// <remarks>
        ///  Adds an environment to the list of environments this service may
        ///  not be autostarted in
        /// </remarks>        <short>    Adds an environment to the list of environments this service may  not be autostarted in </short>
        ///         <see> removeFromExcludedEnvironments</see>
        public void AddToExcludedEnvironments(string environment) {
            interceptor.Invoke("addToExcludedEnvironments$", "addToExcludedEnvironments(const QString&)", typeof(void), typeof(string), environment);
        }
        /// <remarks>
        ///  Removes an environment to the list of environments this service may
        ///  not be autostarted in
        /// </remarks>        <short>    Removes an environment to the list of environments this service may  not be autostarted in </short>
        ///         <see> addToExcludedEnvironments</see>
        public void RemoveFromExcludedEnvironments(string environment) {
            interceptor.Invoke("removeFromExcludedEnvironments$", "removeFromExcludedEnvironments(const QString&)", typeof(void), typeof(string), environment);
        }
        ~KAutostart() {
            interceptor.Invoke("~KAutostart", "~KAutostart()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KAutostart", "~KAutostart()", typeof(void));
        }
        /// <remarks>
        ///  Checks whether or not a service by the given name <code>entryName</code> is registered
        ///  with the autostart system. Does not check whether or not it is
        ///  set to actually autostart or not.
        /// <param> name="entryName" the name of the service to check for
        ///          </param></remarks>        <short>    Checks whether or not a service by the given name <code>entryName</code> is registered  with the autostart system.</short>
        public static bool IsServiceRegistered(string entryName) {
            return (bool) staticInterceptor.Invoke("isServiceRegistered$", "isServiceRegistered(const QString&)", typeof(bool), typeof(string), entryName);
        }
        protected new IKAutostartSignals Emit {
            get { return (IKAutostartSignals) Q_EMIT; }
        }
    }

    public interface IKAutostartSignals : IQObjectSignals {
    }
}
