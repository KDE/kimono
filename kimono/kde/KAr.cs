//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  KAr is a class for reading archives in ar format. Writing
    ///  is not supported.
    /// </remarks>        <author> Laurence Anderson <l.d.anderson@warwick.ac.uk>
    ///  </author>
    ///         <short> A class for reading ar archives. </short>
    [SmokeClass("KAr")]
    public class KAr : KArchive, IDisposable {
        protected KAr(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KAr), this);
        }
        /// <remarks>
        ///  Creates an instance that operates on the given filename.
        /// <param> name="filename" is a local path (e.g. "/home/holger/myfile.ar")
        ///      </param></remarks>        <short>    Creates an instance that operates on the given filename.</short>
        public KAr(string filename) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAr$", "KAr(const QString&)", typeof(void), typeof(string), filename);
        }
        /// <remarks>
        ///  Creates an instance that operates on the given device.
        ///  The device can be compressed (KFilterDev) or not (QFile, etc.).
        /// <param> name="dev" the device to read from
        ///      </param></remarks>        <short>    Creates an instance that operates on the given device.</short>
        public KAr(QIODevice dev) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KAr#", "KAr(QIODevice*)", typeof(void), typeof(QIODevice), dev);
        }
        [SmokeMethod("doPrepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t, time_t, time_t)")]
        protected override bool DoPrepareWriting(string name, string user, string group, long size, long perm, int atime, int mtime, int ctime) {
            return (bool) interceptor.Invoke("doPrepareWriting$$$$$$$$", "doPrepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), size, typeof(long), perm, typeof(int), atime, typeof(int), mtime, typeof(int), ctime);
        }
        [SmokeMethod("doFinishWriting(qint64)")]
        protected override bool DoFinishWriting(long size) {
            return (bool) interceptor.Invoke("doFinishWriting$", "doFinishWriting(qint64)", typeof(bool), typeof(long), size);
        }
        [SmokeMethod("doWriteDir(const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)")]
        protected override bool DoWriteDir(string name, string user, string group, long perm, int atime, int mtime, int ctime) {
            return (bool) interceptor.Invoke("doWriteDir$$$$$$$", "doWriteDir(const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime, typeof(int), mtime, typeof(int), ctime);
        }
        [SmokeMethod("doWriteSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)")]
        protected override bool DoWriteSymLink(string name, string target, string user, string group, long perm, int atime, int mtime, int ctime) {
            return (bool) interceptor.Invoke("doWriteSymLink$$$$$$$$", "doWriteSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), target, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime, typeof(int), mtime, typeof(int), ctime);
        }
        /// <remarks>
        ///  Opens the archive for reading.
        ///  Parses the directory listing of the archive
        ///  and creates the KArchiveDirectory/KArchiveFile entries.
        ///      </remarks>        <short>    Opens the archive for reading.</short>
        [SmokeMethod("openArchive(QIODevice::OpenMode)")]
        protected override bool OpenArchive(uint mode) {
            return (bool) interceptor.Invoke("openArchive$", "openArchive(QIODevice::OpenMode)", typeof(bool), typeof(uint), mode);
        }
        [SmokeMethod("closeArchive()")]
        protected override bool CloseArchive() {
            return (bool) interceptor.Invoke("closeArchive", "closeArchive()", typeof(bool));
        }
        ~KAr() {
            interceptor.Invoke("~KAr", "~KAr()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KAr", "~KAr()", typeof(void));
        }
    }
}
