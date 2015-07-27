//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  \class KTempDir ktempdir.h <KTempDir>
    ///  @brief Create a unique directory for temporary use.
    ///  The KTempDir class creates a unique directory for temporary use.
    ///  This is especially useful if you need to create a directory in a world
    ///  writable directory like /tmp without being vulnerable to so called
    ///  symlink attacks.
    ///  KDE applications, however, shouldn't create files or directories in /tmp
    ///  in the first place but use the "tmp" resource instead. The standard
    ///  KTempDir constructor will do that by default.
    ///  To create a temporary directory that starts with a certain name
    ///  in the "tmp" resource, one should use:
    ///  KTempDir(locateLocal("tmp", prefix));
    ///  KTempDir does not create any missing directories, but locateLocal() does.
    /// </remarks>        <author> Joseph Wenninger <jowenn@kde.org>
    ///  </author>
    ///         <short>    \class KTempDir ktempdir.</short>
    ///         <see> KStandardDirs</see>
    ///         <see> KTemporaryFile</see>
    [SmokeClass("KTempDir")]
    public class KTempDir : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KTempDir(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTempDir), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KTempDir() {
            staticInterceptor = new SmokeInvocation(typeof(KTempDir), null);
        }
        /// <remarks>
        ///  Creates a temporary directory with the name:
        ///   \p \<directoryPrefix\>\<six letters\>
        ///  The default <pre>directoryPrefix</pre> is "$KDEHOME/tmp-$HOST/appname"
        /// <param> name="directoryPrefix" the prefix of the file name, or
        ///         string() for the default value
        /// </param><param> name="mode" the file permissions,
        ///  almost always in octal. The first digit selects permissions for
        ///  the user who owns the file: read (4), write (2), and execute
        ///  (1); the second selects permissions for other users in the
        ///  file's group, with the same values; and the fourth for other
        ///  users not in the file's group, with the same values.
        /// </param></remarks>        <short>    Creates a temporary directory with the name:   \p \<directoryPrefix\>\<six letters\> </short>
        public KTempDir(string directoryPrefix, int mode) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTempDir$$", "KTempDir(const QString&, int)", typeof(void), typeof(string), directoryPrefix, typeof(int), mode);
        }
        public KTempDir(string directoryPrefix) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTempDir$", "KTempDir(const QString&)", typeof(void), typeof(string), directoryPrefix);
        }
        public KTempDir() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTempDir", "KTempDir()", typeof(void));
        }
        /// <remarks>
        ///  Turn automatic deletion of the directory on or off.
        ///  Automatic deletion is on by default.
        /// <param> name="autoRemove" toggle automatic deletion on or off
        /// </param></remarks>        <short>    Turn automatic deletion of the directory on or off.</short>
        public void SetAutoRemove(bool autoRemove) {
            interceptor.Invoke("setAutoRemove$", "setAutoRemove(bool)", typeof(void), typeof(bool), autoRemove);
        }
        /// <remarks>
        /// </remarks>        <return> whether auto remove is active
        /// </return>
        ///         <short>   </short>
        ///         <see> setAutoRemove</see>
        public bool AutoRemove() {
            return (bool) interceptor.Invoke("autoRemove", "autoRemove() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns the status of the directory creation  based on errno.
        ///  (see errno.h)
        ///  @note You should check the status after object creation to check
        ///  whether the directory could be created.
        /// </remarks>        <return> the errno status, 0 means ok
        /// </return>
        ///         <short>    Returns the status of the directory creation  based on errno.</short>
        public int Status() {
            return (int) interceptor.Invoke("status", "status() const", typeof(int));
        }
        /// <remarks>
        ///  Returns the full path and name of the directory, including a
        ///  trailing '/'.
        /// </remarks>        <return> The name of the directory, or string() if creating the
        ///          directory has failed or the directory has been unlinked
        /// </return>
        ///         <short>    Returns the full path and name of the directory, including a  trailing '/'.</short>
        public string Name() {
            return (string) interceptor.Invoke("name", "name() const", typeof(string));
        }
        /// <remarks>
        ///  Deletes the directory recursively
        /// </remarks>        <short>    Deletes the directory recursively </short>
        public void Unlink() {
            interceptor.Invoke("unlink", "unlink()", typeof(void));
        }
        /// <remarks>
        ///  Returns true if a temporary directory has successfully been created
        ///  and has not been unlinked yet.
        ///     </remarks>        <short>    Returns true if a temporary directory has successfully been created  and has not been unlinked yet.</short>
        public bool Exists() {
            return (bool) interceptor.Invoke("exists", "exists() const", typeof(bool));
        }
        /// <remarks>
        ///  Creates a "random" directory with specified mode
        /// <param> name="directoryPrefix" to use when creating temp directory
        ///        (the rest is generated randomly)
        /// </param><param> name="mode" directory permissions
        /// </param></remarks>        <return> true upon success
        ///     </return>
        ///         <short>    Creates a "random" directory with specified mode </short>
        protected bool Create(string directoryPrefix, int mode) {
            return (bool) interceptor.Invoke("create$$", "create(const QString&, int)", typeof(bool), typeof(string), directoryPrefix, typeof(int), mode);
        }
        ~KTempDir() {
            interceptor.Invoke("~KTempDir", "~KTempDir()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KTempDir", "~KTempDir()", typeof(void));
        }
        /// <remarks>
        ///  @brief Remove a directory and all its contents
        ///  Remove recursively a directory, even if it is not empty
        ///  or contains other directories.
        ///  However the function works too when the <code>path</code> given
        ///  is a non-directory file. In that case it simply remove that file.
        ///  The function stops on the first error.
        ///  @note This function is more meant for removing a directory
        ///  not created by the user. For user-created directories,
        ///  using KIO.NetAccess.Del is recommended instead,
        ///  especially as it has user feedback for long operations.
        /// <param> name="path" Path of the directory to delete
        /// </param></remarks>        <return> true if successful, otherwise false
        ///  (Use errno for more details about the error.)
        ///  @todo decide how and where this function should be defined in KDE4
        ///     </return>
        ///         <short>    @brief Remove a directory and all its contents </short>
        public static bool RemoveDir(string path) {
            return (bool) staticInterceptor.Invoke("removeDir$", "removeDir(const QString&)", typeof(bool), typeof(string), path);
        }
    }
}