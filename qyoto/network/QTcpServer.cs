//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQTcpServerSignals"></see> for signals emitted by QTcpServer
    /// </remarks>
    [SmokeClass("QTcpServer")]
    public class QTcpServer : QObject, IDisposable {
        protected QTcpServer(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTcpServer), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTcpServer() {
            staticInterceptor = new SmokeInvocation(typeof(QTcpServer), null);
        }
        public QTcpServer(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTcpServer#", "QTcpServer(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QTcpServer() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTcpServer", "QTcpServer()", typeof(void));
        }
        public bool Listen(QHostAddress address, ushort port) {
            return (bool) interceptor.Invoke("listen#$", "listen(const QHostAddress&, unsigned short)", typeof(bool), typeof(QHostAddress), address, typeof(ushort), port);
        }
        public bool Listen(QHostAddress address) {
            return (bool) interceptor.Invoke("listen#", "listen(const QHostAddress&)", typeof(bool), typeof(QHostAddress), address);
        }
        public bool Listen() {
            return (bool) interceptor.Invoke("listen", "listen()", typeof(bool));
        }
        public void Close() {
            interceptor.Invoke("close", "close()", typeof(void));
        }
        public bool IsListening() {
            return (bool) interceptor.Invoke("isListening", "isListening() const", typeof(bool));
        }
        public void SetMaxPendingConnections(int numConnections) {
            interceptor.Invoke("setMaxPendingConnections$", "setMaxPendingConnections(int)", typeof(void), typeof(int), numConnections);
        }
        public int MaxPendingConnections() {
            return (int) interceptor.Invoke("maxPendingConnections", "maxPendingConnections() const", typeof(int));
        }
        public ushort ServerPort() {
            return (ushort) interceptor.Invoke("serverPort", "serverPort() const", typeof(ushort));
        }
        public QHostAddress ServerAddress() {
            return (QHostAddress) interceptor.Invoke("serverAddress", "serverAddress() const", typeof(QHostAddress));
        }
        public int SocketDescriptor() {
            return (int) interceptor.Invoke("socketDescriptor", "socketDescriptor() const", typeof(int));
        }
        public bool SetSocketDescriptor(int socketDescriptor) {
            return (bool) interceptor.Invoke("setSocketDescriptor$", "setSocketDescriptor(int)", typeof(bool), typeof(int), socketDescriptor);
        }
        public bool WaitForNewConnection(int msec, ref bool timedOut) {
            StackItem[] stack = new StackItem[3];
            stack[1].s_int = msec;
            stack[2].s_bool = timedOut;
            interceptor.Invoke("waitForNewConnection$$", "waitForNewConnection(int, bool*)", stack);
            timedOut = stack[2].s_bool;
            return stack[0].s_bool;
        }
        public bool WaitForNewConnection(int msec) {
            return (bool) interceptor.Invoke("waitForNewConnection$", "waitForNewConnection(int)", typeof(bool), typeof(int), msec);
        }
        public bool WaitForNewConnection() {
            return (bool) interceptor.Invoke("waitForNewConnection", "waitForNewConnection()", typeof(bool));
        }
        [SmokeMethod("hasPendingConnections() const")]
        public virtual bool HasPendingConnections() {
            return (bool) interceptor.Invoke("hasPendingConnections", "hasPendingConnections() const", typeof(bool));
        }
        [SmokeMethod("nextPendingConnection()")]
        public virtual QTcpSocket NextPendingConnection() {
            return (QTcpSocket) interceptor.Invoke("nextPendingConnection", "nextPendingConnection()", typeof(QTcpSocket));
        }
        public QAbstractSocket.SocketError ServerError() {
            return (QAbstractSocket.SocketError) interceptor.Invoke("serverError", "serverError() const", typeof(QAbstractSocket.SocketError));
        }
        public string ErrorString() {
            return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
        }
        public void SetProxy(QNetworkProxy networkProxy) {
            interceptor.Invoke("setProxy#", "setProxy(const QNetworkProxy&)", typeof(void), typeof(QNetworkProxy), networkProxy);
        }
        public QNetworkProxy Proxy() {
            return (QNetworkProxy) interceptor.Invoke("proxy", "proxy() const", typeof(QNetworkProxy));
        }
        [SmokeMethod("incomingConnection(int)")]
        protected virtual void IncomingConnection(int handle) {
            interceptor.Invoke("incomingConnection$", "incomingConnection(int)", typeof(void), typeof(int), handle);
        }
        ~QTcpServer() {
            interceptor.Invoke("~QTcpServer", "~QTcpServer()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTcpServer", "~QTcpServer()", typeof(void));
        }
        public event SlotFunc SignalNewConnection {
            add { QObject.Connect(this, SIGNAL("newConnection()"), value); }
            remove { QObject.Disconnect(this, SIGNAL("newConnection()"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQTcpServerSignals Emit {
            get { return (IQTcpServerSignals) Q_EMIT; }
        }
    }

    public interface IQTcpServerSignals : IQObjectSignals {
        [Q_SIGNAL("void newConnection()")]
        void NewConnection();
    }
}
