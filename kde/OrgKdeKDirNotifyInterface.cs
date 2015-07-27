//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IOrgKdeKDirNotifyInterfaceSignals"></see> for signals emitted by OrgKdeKDirNotifyInterface
    /// </remarks>
    [SmokeClass("OrgKdeKDirNotifyInterface")]
    public class OrgKdeKDirNotifyInterface : QDBusAbstractInterface, IDisposable {
        protected OrgKdeKDirNotifyInterface(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(OrgKdeKDirNotifyInterface), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static OrgKdeKDirNotifyInterface() {
            staticInterceptor = new SmokeInvocation(typeof(OrgKdeKDirNotifyInterface), null);
        }
        public OrgKdeKDirNotifyInterface(string service, string path, QDBusConnection connection, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("OrgKdeKDirNotifyInterface$$##", "OrgKdeKDirNotifyInterface(const QString&, const QString&, const QDBusConnection&, QObject*)", typeof(void), typeof(string), service, typeof(string), path, typeof(QDBusConnection), connection, typeof(QObject), parent);
        }
        public OrgKdeKDirNotifyInterface(string service, string path, QDBusConnection connection) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("OrgKdeKDirNotifyInterface$$#", "OrgKdeKDirNotifyInterface(const QString&, const QString&, const QDBusConnection&)", typeof(void), typeof(string), service, typeof(string), path, typeof(QDBusConnection), connection);
        }
        ~OrgKdeKDirNotifyInterface() {
            interceptor.Invoke("~OrgKdeKDirNotifyInterface", "~OrgKdeKDirNotifyInterface()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~OrgKdeKDirNotifyInterface", "~OrgKdeKDirNotifyInterface()", typeof(void));
        }
        public static string StaticInterfaceName() {
            return (string) staticInterceptor.Invoke("staticInterfaceName", "staticInterfaceName()", typeof(string));
        }
        public static void EmitFileRenamed(string src, string dst) {
            staticInterceptor.Invoke("emitFileRenamed$$", "emitFileRenamed(const QString&, const QString&)", typeof(void), typeof(string), src, typeof(string), dst);
        }
        public static void EmitFileMoved(string src, string dst) {
            staticInterceptor.Invoke("emitFileMoved$$", "emitFileMoved(const QString&, const QString&)", typeof(void), typeof(string), src, typeof(string), dst);
        }
        public static void EmitFilesAdded(string directory) {
            staticInterceptor.Invoke("emitFilesAdded$", "emitFilesAdded(const QString&)", typeof(void), typeof(string), directory);
        }
        public static void EmitFilesChanged(List<string> fileList) {
            staticInterceptor.Invoke("emitFilesChanged?", "emitFilesChanged(const QStringList&)", typeof(void), typeof(List<string>), fileList);
        }
        public static void EmitFilesRemoved(List<string> fileList) {
            staticInterceptor.Invoke("emitFilesRemoved?", "emitFilesRemoved(const QStringList&)", typeof(void), typeof(List<string>), fileList);
        }
        public static void EmitEnteredDirectory(string url) {
            staticInterceptor.Invoke("emitEnteredDirectory$", "emitEnteredDirectory(const QString&)", typeof(void), typeof(string), url);
        }
        public static void EmitLeftDirectory(string url) {
            staticInterceptor.Invoke("emitLeftDirectory$", "emitLeftDirectory(const QString&)", typeof(void), typeof(string), url);
        }
        protected new IOrgKdeKDirNotifyInterfaceSignals Emit {
            get { return (IOrgKdeKDirNotifyInterfaceSignals) Q_EMIT; }
        }
    }

    public interface IOrgKdeKDirNotifyInterfaceSignals : IQDBusAbstractInterfaceSignals {
        [Q_SIGNAL("void FileRenamed(QString, QString)")]
        void FileRenamed(string src, string dst);
        [Q_SIGNAL("void FileMoved(QString, QString)")]
        void FileMoved(string src, string dst);
        [Q_SIGNAL("void FilesAdded(QString)")]
        void FilesAdded(string directory);
        [Q_SIGNAL("void FilesChanged(QStringList)")]
        void FilesChanged(List<string> fileList);
        [Q_SIGNAL("void FilesRemoved(QStringList)")]
        void FilesRemoved(List<string> fileList);
        [Q_SIGNAL("void enteredDirectory(QString)")]
        void EnteredDirectory(string url);
        [Q_SIGNAL("void leftDirectory(QString)")]
        void LeftDirectory(string url);
    }
}