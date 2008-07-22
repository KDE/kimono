//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  Represents a directory entry in a KArchive.
    /// </remarks>        <short> A directory in an archive. </short>
    ///         <see> KArchive</see>
    ///         <see> KArchiveFile</see>
    [SmokeClass("KArchiveDirectory")]
    public class KArchiveDirectory : KArchiveEntry, IDisposable {
        protected KArchiveDirectory(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KArchiveDirectory), this);
        }
        /// <remarks>
        ///  Creates a new directory entry.
        /// <param> name="archive" the entries archive
        /// </param><param> name="name" the name of the entry
        /// </param><param> name="access" the permissions in unix format
        /// </param><param> name="date" the date (in seconds since 1970)
        /// </param><param> name="user" the user that owns the entry
        /// </param><param> name="group" the group that owns the entry
        /// </param><param> name="symlink" the symlink, or string()
        ///      </param></remarks>        <short>    Creates a new directory entry.</short>
        public KArchiveDirectory(KArchive archive, string name, int access, int date, string user, string group, string symlink) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KArchiveDirectory#$$$$$$", "KArchiveDirectory(KArchive*, const QString&, int, int, const QString&, const QString&, const QString&)", typeof(void), typeof(KArchive), archive, typeof(string), name, typeof(int), access, typeof(int), date, typeof(string), user, typeof(string), group, typeof(string), symlink);
        }
        /// <remarks>
        ///  Returns a list of sub-entries.
        ///  Note that the list is not sorted, it's even in random order (due to using a hashtable).
        ///  Use sort() on the result to sort the list by filename.
        /// </remarks>        <return> the names of all entries in this directory (filenames, no path).
        ///      </return>
        ///         <short>    Returns a list of sub-entries.</short>
        public List<string> Entries() {
            return (List<string>) interceptor.Invoke("entries", "entries() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Returns the entry with the given name.
        /// <param> name="name" may be "test1", "mydir/test3", "mydir/mysubdir/test3", etc.
        /// </param></remarks>        <return> a pointer to the entry in the directory.
        ///      </return>
        ///         <short>    Returns the entry with the given name.</short>
        public KArchiveEntry Entry(string name) {
            return (KArchiveEntry) interceptor.Invoke("entry$", "entry(const QString&) const", typeof(KArchiveEntry), typeof(string), name);
        }
        /// <remarks>
        ///  Adds a new entry to the directory.
        ///      </remarks>        <short>   </short>
        public void AddEntry(KArchiveEntry arg1) {
            interceptor.Invoke("addEntry#", "addEntry(KArchiveEntry*)", typeof(void), typeof(KArchiveEntry), arg1);
        }
        /// <remarks>
        ///  Checks whether this entry is a directory.
        /// </remarks>        <return> true, since this entry is a directory
        ///      </return>
        ///         <short>    Checks whether this entry is a directory.</short>
        [SmokeMethod("isDirectory() const")]
        public override bool IsDirectory() {
            return (bool) interceptor.Invoke("isDirectory", "isDirectory() const", typeof(bool));
        }
        /// <remarks>
        ///  Extracts all entries in this archive directory to the directory
        ///  <code>dest.</code>
        /// <param> name="dest" the directory to extract to
        /// </param><param> name="recursive" if set to true, subdirectories are extracted as well
        ///      </param></remarks>        <short>    Extracts all entries in this archive directory to the directory  <code>dest.</code></short>
        public void CopyTo(string dest, bool recursive) {
            interceptor.Invoke("copyTo$$", "copyTo(const QString&, bool) const", typeof(void), typeof(string), dest, typeof(bool), recursive);
        }
        public void CopyTo(string dest) {
            interceptor.Invoke("copyTo$", "copyTo(const QString&) const", typeof(void), typeof(string), dest);
        }
        ~KArchiveDirectory() {
            interceptor.Invoke("~KArchiveDirectory", "~KArchiveDirectory()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KArchiveDirectory", "~KArchiveDirectory()", typeof(void));
        }
    }
}
