//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  This is the base class for compression filters
    ///  such as gzip and bzip2. It's pretty much internal.
    ///  Don't use directly, use KFilterDev instead.
    ///  </remarks>        <short>    This is the base class for compression filters  such as gzip and bzip2.</short>
    [SmokeClass("KFilterBase")]
    public abstract class KFilterBase : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KFilterBase(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KFilterBase), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KFilterBase() {
            staticInterceptor = new SmokeInvocation(typeof(KFilterBase), null);
        }
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        public enum Result {
            Ok = 0,
            End = 1,
            Error = 2,
        }
        public KFilterBase() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KFilterBase", "KFilterBase()", typeof(void));
        }
        /// <remarks>
        ///  Sets the device on which the filter will work
        /// <param> name="dev" the device on which the filter will work
        /// </param><param> name="autodelete" if true, <code>dev</code> is deleted when the filter is deleted
        ///      </param></remarks>        <short>    Sets the device on which the filter will work </short>
        public void SetDevice(QIODevice dev, bool autodelete) {
            interceptor.Invoke("setDevice#$", "setDevice(QIODevice*, bool)", typeof(void), typeof(QIODevice), dev, typeof(bool), autodelete);
        }
        public void SetDevice(QIODevice dev) {
            interceptor.Invoke("setDevice#", "setDevice(QIODevice*)", typeof(void), typeof(QIODevice), dev);
        }
        /// <remarks>
        ///  Returns the device on which the filter will work.
        /// </remarks>        <return> the device on which the filter will work
        ///      </return>
        ///         <short>    Returns the device on which the filter will work.</short>
        public QIODevice Device() {
            return (QIODevice) interceptor.Invoke("device", "device()", typeof(QIODevice));
        }
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("init(int)")]
        public abstract void Init(int mode);
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("mode() const")]
        public abstract int Mode();
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("terminate()")]
        public virtual void Terminate() {
            interceptor.Invoke("terminate", "terminate()", typeof(void));
        }
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("reset()")]
        public virtual void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("readHeader()")]
        public abstract bool ReadHeader();
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("writeHeader(const QByteArray&)")]
        public abstract bool WriteHeader(QByteArray filename);
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("setOutBuffer(char*, uint)")]
        public abstract void SetOutBuffer(Pointer<sbyte> data, uint maxlen);
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("setInBuffer(const char*, uint)")]
        public abstract void SetInBuffer(string data, uint size);
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("inBufferEmpty() const")]
        public virtual bool InBufferEmpty() {
            return (bool) interceptor.Invoke("inBufferEmpty", "inBufferEmpty() const", typeof(bool));
        }
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("inBufferAvailable() const")]
        public abstract int InBufferAvailable();
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("outBufferFull() const")]
        public virtual bool OutBufferFull() {
            return (bool) interceptor.Invoke("outBufferFull", "outBufferFull() const", typeof(bool));
        }
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("outBufferAvailable() const")]
        public abstract int OutBufferAvailable();
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("uncompress()")]
        public abstract KFilterBase.Result Uncompress();
        /// <remarks> \internal </remarks>        <short>   \internal </short>
        [SmokeMethod("compress(bool)")]
        public abstract KFilterBase.Result Compress(bool finish);
        /// <remarks>
        ///  Call this to create the appropriate filter for the file
        ///  named <code>fileName.</code>
        /// <param> name="fileName" the name of the file to filter
        /// </param></remarks>        <return> the filter for the <code>fileName</code>, or 0 if not found
        ///      </return>
        ///         <short>    Call this to create the appropriate filter for the file  named <code>fileName.</code></short>
        public static KFilterBase FindFilterByFileName(string fileName) {
            return (KFilterBase) staticInterceptor.Invoke("findFilterByFileName$", "findFilterByFileName(const QString&)", typeof(KFilterBase), typeof(string), fileName);
        }
        /// <remarks>
        ///  Call this to create the appropriate filter for the mimetype
        ///  <code>mimeType.</code> For instance application/x-gzip.
        /// <param> name="mimeType" the mime type of the file to filter
        /// </param></remarks>        <return> the filter for the <code>mimeType</code>, or 0 if not found
        ///      </return>
        ///         <short>    Call this to create the appropriate filter for the mimetype  <code>mimeType.</code></short>
        public static KFilterBase FindFilterByMimeType(string mimeType) {
            return (KFilterBase) staticInterceptor.Invoke("findFilterByMimeType$", "findFilterByMimeType(const QString&)", typeof(KFilterBase), typeof(string), mimeType);
        }
    }
}
