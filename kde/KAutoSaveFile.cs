//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \class KAutoSaveFile kautosavefile.h <KAutoSaveFile>
    ///  @brief Creates and manages an "auto-save" file.
    ///  Autosave files are temporary files that applications use to store
    ///  the unsaved data in a file they have open for
    ///  editing. KAutoSaveFile allows you to easily create and manage such
    ///  files, as well as to recover the unsaved data left over by a
    ///  crashed or otherwise gone process.
    ///  Each KAutoSaveFile object is associated with one specific file that
    ///  the application holds open. KAutoSaveFile is also a QObject, so it
    ///  can be reparented to the actual opened file object, so as to manage
    ///  the lifetime of the temporary file.
    ///  Typical use consists of:
    ///  - verifying whether stale autosave files exist for the opened file
    ///  - deciding whether to recover the old, autosaved data
    ///  - if not recovering, creating a KAutoSaveFile object for the opened file
    ///  - during normal execution of the program, periodically save unsaved
    ///    data into the KAutoSaveFile file.
    ///  KAutoSaveFile holds a lock on the autosave file, so it's safe to
    ///  delete the file and recreate it later. Because of that, disposing
    ///  of stale autosave files should be done with releaseLock(). No lock is
    ///  held on the managed file.
    ///  Examples:
    ///  Opening a new file:
    ///  @code
    ///    void Document.Open(KUrlurl)
    ///    {
    ///        // check whether autosave files exist:
    ///        QList<KAutoSaveFile > staleFiles = KAutoSaveFile.StaleFiles(url);
    ///        if (!staleFiles.isEmpty()) {
    ///            if (KMessageBox.QuestionYesNo(parent,
    ///                                           "Auto-saved files exist. Do you want to recover them now?",
    ///                                           "File Recovery",
    ///                                           "Recover", "Don't recover") == KMessage.Yes) {
    ///                recoverFiles(staleFiles);
    ///                return;
    ///            } else {
    ///                // remove the stale files
    ///                foreach (KAutoSaveFile stale, staleFiles) {
    ///                    stale.Open(QIODevice.ReadWrite);
    ///                    delete stale;
    ///                }
    ///            }
    ///        }
    ///        // create new autosave object
    ///        m_autosave = new KAutoSaveFile(url, this);
    ///        // continue the process of opening file 'url'
    ///        ...
    ///    }
    ///  @endcode
    ///  The function recoverFiles could loop over the list of files and do this:
    ///  @code
    ///    foreach (KAutoSaveFile stale, staleFiles) {
    ///        if (!stale.Open(QIODevice.ReadWrite)) {
    ///            // show an error message; we could not steal the lockfile
    ///            // maybe another application got to the file before us?
    ///            delete stale;
    ///            continue;
    ///        }
    ///        Document doc = new Document;
    ///        doc.M_autosave = stale;
    ///        stale.SetParent(doc); // reparent
    ///        doc.SetUrl(stale.ManagedFile());
    ///        doc.SetContents(stale.ReadAll());
    ///        doc.SetState(Document.Modified); // mark it as modified and unsaved
    ///        documentManager.AddDocument(doc);
    ///    }
    ///  @endcode
    ///  If the file is unsaved, periodically write the contents to the save file:
    ///  @code
    ///    if (!m_autosave.IsOpen() && !m_autosave.Open(QIODevice.ReadWrite)) {
    ///        // show error: could not open the autosave file
    ///    }
    ///    m_autosave.Write(contents());
    ///  @endcode
    ///  When the user saves the file, the autosaved file is no longer
    ///  necessary and can be removed or emptied.
    ///  @code
    ///     m_autosave.Resize(0);    // leaves the file open
    ///  @endcode
    ///  @code
    ///     m_autosave.Remove();     // closes the file
    ///  @endcode
    /// </remarks>        <author> Jacob R Rideout <kde@jacobrideout.net>
    ///  </author>
    ///         <short>    \class KAutoSaveFile kautosavefile.</short>
    [SmokeClass("KAutoSaveFile")]
    public class KAutoSaveFile : QFile, IDisposable {
        protected KAutoSaveFile(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KAutoSaveFile), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KAutoSaveFile() {
            staticInterceptor = new SmokeInvocation(typeof(KAutoSaveFile), null);
        }
        /// <remarks>
        ///  Constructs a KAutoSaveFile for file <code>filename.</code> The temporary
        ///  file is not opened or created until actually needed. The file
        ///  <code>filename</code> does not have to exist for KAutoSaveFile to be
        ///  constructed (if it exists, it will not be touched).
        /// <param> name="filename" the filename that this KAutoSaveFile refers to
        /// </param><param> name="parent" the parent object
        ///      </param></remarks>        <short>    Constructs a KAutoSaveFile for file <code>filename.</code></short>
        public KAutoSaveFile(KUrl filename, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAutoSaveFile##", "KAutoSaveFile(const KUrl&, QObject*)", typeof(void), typeof(KUrl), filename, typeof(QObject), parent);
        }
        public KAutoSaveFile(KUrl filename) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAutoSaveFile#", "KAutoSaveFile(const KUrl&)", typeof(void), typeof(KUrl), filename);
        }
        /// <remarks>
        ///  @overload
        ///  Constructs a KAutoSaveFile object. Note that you need to call
        ///  setManagedFile() before calling open().
        /// <param> name="parent" the parent object
        ///      </param></remarks>        <short>    @overload  Constructs a KAutoSaveFile object.</short>
        public KAutoSaveFile(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAutoSaveFile#", "KAutoSaveFile(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public KAutoSaveFile() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAutoSaveFile", "KAutoSaveFile()", typeof(void));
        }
        /// <remarks>
        ///  Retrieves the URL of the file managed by KAutoSaveFile. This
        ///  is the same URL that was given to setManagedFile() or the
        ///  KAutoSaveFile constructor.
        ///  This is the name of the real file being edited by the
        ///  application. To get the name of the temporary file where data
        ///  can be saved, use fileName() (after you have called open()).
        ///      </remarks>        <short>    Retrieves the URL of the file managed by KAutoSaveFile.</short>
        public KUrl ManagedFile() {
            return (KUrl) interceptor.Invoke("managedFile", "managedFile() const", typeof(KUrl));
        }
        /// <remarks>
        ///  Sets the URL of the file managed by KAutoSaveFile. This should
        ///  be the name of the real file being edited by the application.
        ///  If the file was previously set, this function calls releaseLock().
        /// <param> name="filename" the filename that this KAutoSaveFile refers to
        ///      </param></remarks>        <short>    Sets the URL of the file managed by KAutoSaveFile.</short>
        public void SetManagedFile(KUrl filename) {
            interceptor.Invoke("setManagedFile#", "setManagedFile(const KUrl&)", typeof(void), typeof(KUrl), filename);
        }
        /// <remarks>
        ///  Closes the autosave file resource and removes the lock
        ///  file. The file name returned by fileName() will no longer be
        ///  protected and can be overwritten by another application at any
        ///  time. To obtain a new lock, call open() again.
        ///  This function calls remove(), so the autosave temporary file
        ///  will be removed too.
        ///      </remarks>        <short>    Closes the autosave file resource and removes the lock  file.</short>
        [SmokeMethod("releaseLock()")]
        public virtual void ReleaseLock() {
            interceptor.Invoke("releaseLock", "releaseLock()", typeof(void));
        }
        /// <remarks>
        ///  Opens the autosave file and locks it if it wasn't already
        ///  locked. The name of the temporary file where data can be saved
        ///  to will be set by this function and can be retrieved with
        ///  fileName(). It will not change unless releaseLock() is called. No
        ///  other application will attempt to edit such a file either while
        ///  the lock is held.
        /// <param> name="openmode" the mode that should be used to open the file,
        ///         probably QIODevice.ReadWrite
        /// </param></remarks>        <return> true if the file could be opened (= locked and
        ///  created), false if the operation failed
        ///      </return>
        ///         <short>    Opens the autosave file and locks it if it wasn't already  locked.</short>
        [SmokeMethod("open(QIODevice::OpenMode)")]
        public override bool Open(uint openmode) {
            return (bool) interceptor.Invoke("open$", "open(QIODevice::OpenMode)", typeof(bool), typeof(uint), openmode);
        }
        ~KAutoSaveFile() {
            interceptor.Invoke("~KAutoSaveFile", "~KAutoSaveFile()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KAutoSaveFile", "~KAutoSaveFile()", typeof(void));
        }
        /// <remarks>
        ///  Checks for stale autosave files for <code>filename.</code> Returns a list
        ///  of autosave files that contain autosaved data left behind by
        ///  other instances of the application, due to crashing or
        ///  otherwise uncleanly exiting.
        ///  It is the application's job to determine what to do with such
        ///  unsaved data. Generally, this is done by asking the user if he
        ///  wants to see the recovered data, and then allowing the user to
        ///  save if he wants to.
        ///  If not given, the application name is obtained from
        ///  QCoreApplication, so be sure to have set it correctly before
        ///  calling this function.
        ///  This function returns a list of unopened KAutoSaveFile
        ///  objects. By calling open() on them, the application will steal
        ///  the lock. Subsequent releaseLock() or deleting of the object will
        ///  then erase the stale autosave file.
        ///      </remarks>        <short>    Checks for stale autosave files for <code>filename.</code></short>
        public static List<KAutoSaveFile> StaleFiles(KUrl filename, string applicationName) {
            return (List<KAutoSaveFile>) staticInterceptor.Invoke("staleFiles#$", "staleFiles(const KUrl&, const QString&)", typeof(List<KAutoSaveFile>), typeof(KUrl), filename, typeof(string), applicationName);
        }
        public static List<KAutoSaveFile> StaleFiles(KUrl filename) {
            return (List<KAutoSaveFile>) staticInterceptor.Invoke("staleFiles#", "staleFiles(const KUrl&)", typeof(List<KAutoSaveFile>), typeof(KUrl), filename);
        }
        /// <remarks>
        ///  Returns all stale autosave files left behind by crashed or
        ///  otherwise gone instances of this application.
        ///  If not given, the application name is obtained from
        ///  QCoreApplication, so be sure to have set it correctly before
        ///  calling this function.
        ///  See staleFiles() for information on the returned objects.
        ///      </remarks>        <short>    Returns all stale autosave files left behind by crashed or  otherwise gone instances of this application.</short>
        public static List<KAutoSaveFile> AllStaleFiles(string applicationName) {
            return (List<KAutoSaveFile>) staticInterceptor.Invoke("allStaleFiles$", "allStaleFiles(const QString&)", typeof(List<KAutoSaveFile>), typeof(string), applicationName);
        }
        public static List<KAutoSaveFile> AllStaleFiles() {
            return (List<KAutoSaveFile>) staticInterceptor.Invoke("allStaleFiles", "allStaleFiles()", typeof(List<KAutoSaveFile>));
        }
        protected new IKAutoSaveFileSignals Emit {
            get { return (IKAutoSaveFileSignals) Q_EMIT; }
        }
    }

    public interface IKAutoSaveFileSignals : IQFileSignals {
    }
}
