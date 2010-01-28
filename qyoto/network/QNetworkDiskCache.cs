//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QNetworkDiskCache")]
    public class QNetworkDiskCache : QAbstractNetworkCache, IDisposable {
        protected QNetworkDiskCache(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QNetworkDiskCache), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QNetworkDiskCache() {
            staticInterceptor = new SmokeInvocation(typeof(QNetworkDiskCache), null);
        }
        public QNetworkDiskCache(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QNetworkDiskCache#", "QNetworkDiskCache(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QNetworkDiskCache() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QNetworkDiskCache", "QNetworkDiskCache()", typeof(void));
        }
        public string CacheDirectory() {
            return (string) interceptor.Invoke("cacheDirectory", "cacheDirectory() const", typeof(string));
        }
        public void SetCacheDirectory(string cacheDir) {
            interceptor.Invoke("setCacheDirectory$", "setCacheDirectory(const QString&)", typeof(void), typeof(string), cacheDir);
        }
        public long MaximumCacheSize() {
            return (long) interceptor.Invoke("maximumCacheSize", "maximumCacheSize() const", typeof(long));
        }
        public void SetMaximumCacheSize(long size) {
            interceptor.Invoke("setMaximumCacheSize$", "setMaximumCacheSize(qint64)", typeof(void), typeof(long), size);
        }
        [SmokeMethod("cacheSize() const")]
        public override long CacheSize() {
            return (long) interceptor.Invoke("cacheSize", "cacheSize() const", typeof(long));
        }
        [SmokeMethod("metaData(const QUrl&)")]
        public override QNetworkCacheMetaData MetaData(QUrl url) {
            return (QNetworkCacheMetaData) interceptor.Invoke("metaData#", "metaData(const QUrl&)", typeof(QNetworkCacheMetaData), typeof(QUrl), url);
        }
        [SmokeMethod("updateMetaData(const QNetworkCacheMetaData&)")]
        public override void UpdateMetaData(QNetworkCacheMetaData metaData) {
            interceptor.Invoke("updateMetaData#", "updateMetaData(const QNetworkCacheMetaData&)", typeof(void), typeof(QNetworkCacheMetaData), metaData);
        }
        [SmokeMethod("data(const QUrl&)")]
        public override QIODevice Data(QUrl url) {
            return (QIODevice) interceptor.Invoke("data#", "data(const QUrl&)", typeof(QIODevice), typeof(QUrl), url);
        }
        [SmokeMethod("remove(const QUrl&)")]
        public override bool Remove(QUrl url) {
            return (bool) interceptor.Invoke("remove#", "remove(const QUrl&)", typeof(bool), typeof(QUrl), url);
        }
        [SmokeMethod("prepare(const QNetworkCacheMetaData&)")]
        public override QIODevice Prepare(QNetworkCacheMetaData metaData) {
            return (QIODevice) interceptor.Invoke("prepare#", "prepare(const QNetworkCacheMetaData&)", typeof(QIODevice), typeof(QNetworkCacheMetaData), metaData);
        }
        [SmokeMethod("insert(QIODevice*)")]
        public override void Insert(QIODevice device) {
            interceptor.Invoke("insert#", "insert(QIODevice*)", typeof(void), typeof(QIODevice), device);
        }
        public QNetworkCacheMetaData FileMetaData(string fileName) {
            return (QNetworkCacheMetaData) interceptor.Invoke("fileMetaData$", "fileMetaData(const QString&) const", typeof(QNetworkCacheMetaData), typeof(string), fileName);
        }
        [Q_SLOT("void clear()")]
        [SmokeMethod("clear()")]
        public override void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        [SmokeMethod("expire()")]
        protected virtual long Expire() {
            return (long) interceptor.Invoke("expire", "expire()", typeof(long));
        }
        ~QNetworkDiskCache() {
            interceptor.Invoke("~QNetworkDiskCache", "~QNetworkDiskCache()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QNetworkDiskCache", "~QNetworkDiskCache()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQNetworkDiskCacheSignals Emit {
            get { return (IQNetworkDiskCacheSignals) Q_EMIT; }
        }
    }

    public interface IQNetworkDiskCacheSignals : IQAbstractNetworkCacheSignals {
    }
}