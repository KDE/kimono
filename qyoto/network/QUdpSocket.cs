//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Runtime.InteropServices;
    [SmokeClass("QUdpSocket")]
    public class QUdpSocket : QAbstractSocket, IDisposable {
        protected QUdpSocket(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QUdpSocket), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QUdpSocket() {
            staticInterceptor = new SmokeInvocation(typeof(QUdpSocket), null);
        }
        public enum BindFlag {
            DefaultForPlatform = 0x0,
            ShareAddress = 0x1,
            DontShareAddress = 0x2,
            ReuseAddressHint = 0x4,
        }
        public QUdpSocket(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUdpSocket#", "QUdpSocket(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QUdpSocket() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUdpSocket", "QUdpSocket()", typeof(void));
        }
        public bool Bind(QHostAddress address, ushort port) {
            return (bool) interceptor.Invoke("bind#$", "bind(const QHostAddress&, unsigned short)", typeof(bool), typeof(QHostAddress), address, typeof(ushort), port);
        }
        public bool Bind(ushort port) {
            return (bool) interceptor.Invoke("bind$", "bind(unsigned short)", typeof(bool), typeof(ushort), port);
        }
        public bool Bind() {
            return (bool) interceptor.Invoke("bind", "bind()", typeof(bool));
        }
        public bool Bind(QHostAddress address, ushort port, uint mode) {
            return (bool) interceptor.Invoke("bind#$$", "bind(const QHostAddress&, unsigned short, QUdpSocket::BindMode)", typeof(bool), typeof(QHostAddress), address, typeof(ushort), port, typeof(uint), mode);
        }
        public bool Bind(ushort port, uint mode) {
            return (bool) interceptor.Invoke("bind$$", "bind(unsigned short, QUdpSocket::BindMode)", typeof(bool), typeof(ushort), port, typeof(uint), mode);
        }
        public bool HasPendingDatagrams() {
            return (bool) interceptor.Invoke("hasPendingDatagrams", "hasPendingDatagrams() const", typeof(bool));
        }
        public long PendingDatagramSize() {
            return (long) interceptor.Invoke("pendingDatagramSize", "pendingDatagramSize() const", typeof(long));
        }
        public long ReadDatagram(Pointer<sbyte> data, long maxlen, QHostAddress host, ref short port) {
            StackItem[] stack = new StackItem[5];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(data);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(data);
#endif
            stack[2].s_long = maxlen;
#if DEBUG
            stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(host);
#else
            stack[3].s_class = (IntPtr) GCHandle.Alloc(host);
#endif
            stack[4].s_short = port;
            interceptor.Invoke("readDatagram$$#$", "readDatagram(char*, qint64, QHostAddress*, unsigned short*)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).SynchronizedFree();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
            ((GCHandle) stack[3].s_class).SynchronizedFree();
#endif
            port = stack[4].s_short;
            return stack[0].s_long;
        }
        public long ReadDatagram(Pointer<sbyte> data, long maxlen, QHostAddress host) {
            return (long) interceptor.Invoke("readDatagram$$#", "readDatagram(char*, qint64, QHostAddress*)", typeof(long), typeof(Pointer<sbyte>), data, typeof(long), maxlen, typeof(QHostAddress), host);
        }
        public long ReadDatagram(Pointer<sbyte> data, long maxlen) {
            return (long) interceptor.Invoke("readDatagram$$", "readDatagram(char*, qint64)", typeof(long), typeof(Pointer<sbyte>), data, typeof(long), maxlen);
        }
        public long WriteDatagram(string data, long len, QHostAddress host, ushort port) {
            return (long) interceptor.Invoke("writeDatagram$$#$", "writeDatagram(const char*, qint64, const QHostAddress&, unsigned short)", typeof(long), typeof(string), data, typeof(long), len, typeof(QHostAddress), host, typeof(ushort), port);
        }
        public long WriteDatagram(QByteArray datagram, QHostAddress host, ushort port) {
            return (long) interceptor.Invoke("writeDatagram##$", "writeDatagram(const QByteArray&, const QHostAddress&, unsigned short)", typeof(long), typeof(QByteArray), datagram, typeof(QHostAddress), host, typeof(ushort), port);
        }
        ~QUdpSocket() {
            interceptor.Invoke("~QUdpSocket", "~QUdpSocket()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QUdpSocket", "~QUdpSocket()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQUdpSocketSignals Emit {
            get { return (IQUdpSocketSignals) Q_EMIT; }
        }
    }

    public interface IQUdpSocketSignals : IQAbstractSocketSignals {
    }
}
