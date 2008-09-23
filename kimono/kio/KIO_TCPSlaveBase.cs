//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  There are two classes that specifies the protocol between application (job)
    ///  and kioslave. SlaveInterface is the class to use on the application end,
    ///  SlaveBase is the one to use on the slave end.
    ///  Slave implementations should simply inherit SlaveBase
    ///  A call to foo() results in a call to slotFoo() on the other end.
    ///  </remarks>        <short>    There are two classes that specifies the protocol between application (job)  and kioslave.</short>
    [SmokeClass("KIO::TCPSlaveBase")]
    public class TCPSlaveBase : KIO.SlaveBase {
        protected TCPSlaveBase(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(TCPSlaveBase), this);
        }
        public enum SslResultDetail {
            ResultOk = 1,
            ResultOverridden = 2,
            ResultFailed = 4,
            ResultFailedEarly = 8,
        }
        /// <remarks>
        ///  Constructor.
        /// <param> name="autoSsl" if true, will automatically invoke startSsl() right after
        ///                 connecting. In the absence of errors the use of SSL will
        ///                 therefore be transparent to higher layers.
        ///      </param></remarks>        <short>    Constructor.</short>
        public TCPSlaveBase(QByteArray protocol, QByteArray poolSocket, QByteArray appSocket, bool autoSsl) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("TCPSlaveBase###$", "TCPSlaveBase(const QByteArray&, const QByteArray&, const QByteArray&, bool)", typeof(void), typeof(QByteArray), protocol, typeof(QByteArray), poolSocket, typeof(QByteArray), appSocket, typeof(bool), autoSsl);
        }
        public TCPSlaveBase(QByteArray protocol, QByteArray poolSocket, QByteArray appSocket) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("TCPSlaveBase###", "TCPSlaveBase(const QByteArray&, const QByteArray&, const QByteArray&)", typeof(void), typeof(QByteArray), protocol, typeof(QByteArray), poolSocket, typeof(QByteArray), appSocket);
        }
        /// <remarks>
        ///  Send data to the remote host.
        /// <param> name="data" data to be sent to remote machine
        /// </param><param> name="len" the length (in bytes) of the data to be sent
        /// </param></remarks>        <return> the actual size of the data that was sent
        ///      </return>
        ///         <short>    Send data to the remote host.</short>
        protected int Write(string data, int len) {
            return (int) interceptor.Invoke("write$?", "write(const char*, ssize_t)", typeof(int), typeof(string), data, typeof(int), len);
        }
        /// <remarks>
        ///  Read incoming data from the remote host.
        /// <param> name="data" storage for the data read from server
        /// </param><param> name="len" length of the data (in bytes) to read from the server
        /// </param></remarks>        <return> the actual size of data that was obtained
        ///      </return>
        ///         <short>    Read incoming data from the remote host.</short>
        protected int Read(Pointer<sbyte> data, int len) {
            return (int) interceptor.Invoke("read$?", "read(char*, ssize_t)", typeof(int), typeof(Pointer<sbyte>), data, typeof(int), len);
        }
        /// <remarks>
        ///  Same as read() except it reads data one line at a time.
        ///      </remarks>        <short>    Same as read() except it reads data one line at a time.</short>
        protected int ReadLine(Pointer<sbyte> data, int len) {
            return (int) interceptor.Invoke("readLine$?", "readLine(char*, ssize_t)", typeof(int), typeof(Pointer<sbyte>), data, typeof(int), len);
        }
        /// <remarks>
        ///  Performs the initial TCP connection stuff and/or
        ///  SSL handshaking as necessary.
        ///  Please note that unlike its deprecated counterpart, this
        ///  function allows you to disable any error message from being
        ///  sent back to the calling application!  You can then use the
        ///  connectResult() function to determine the result of the
        ///  request for connection.
        /// <param> name="protocol" the protocol being used
        /// </param><param> name="host" hostname
        /// </param><param> name="port" port number
        /// </param><param> name="sendError" if true sends error message to calling app on error.
        /// </param></remarks>        <return> on succes, true is returned.
        ///          on failure, false is returned and an appropriate
        ///          error message is sent to the application.
        ///      </return>
        ///         <short>    Performs the initial TCP connection stuff and/or  SSL handshaking as necessary.</short>
        protected bool ConnectToHost(string protocol, string host, ushort port) {
            return (bool) interceptor.Invoke("connectToHost$$$", "connectToHost(const QString&, const QString&, unsigned short)", typeof(bool), typeof(string), protocol, typeof(string), host, typeof(ushort), port);
        }
        /// <remarks>
        ///  the current port for this service
        ///      </remarks>        <short>    the current port for this service </short>
        protected ushort Port() {
            return (ushort) interceptor.Invoke("port", "port() const", typeof(ushort));
        }
        /// <remarks>
        ///  Will start SSL after connecting?
        /// </remarks>        <return> if so, true is returned.
        ///          if not, false is returned.
        ///      </return>
        ///         <short>    Will start SSL after connecting? </short>
        protected bool IsAutoSsl() {
            return (bool) interceptor.Invoke("isAutoSsl", "isAutoSsl() const", typeof(bool));
        }
        /// <remarks>
        ///  Is the current connection using SSL?
        /// </remarks>        <return> if so, true is returned.
        ///          if not, false is returned.
        ///      </return>
        ///         <short>    Is the current connection using SSL? </short>
        protected bool IsUsingSsl() {
            return (bool) interceptor.Invoke("isUsingSsl", "isUsingSsl() const", typeof(bool));
        }
        /// <remarks>
        ///  Start using SSL on the connection. You can use it right after connecting
        ///  for classic, transparent to the protocol SSL. Calling it later can be
        ///  used to implement e.g. SMTP's STARTTLS feature.
        /// </remarks>        <return> on success, true is returned.
        ///          on failure, false is returned.
        ///      </return>
        ///         <short>    Start using SSL on the connection.</short>
        protected bool StartSsl() {
            return (bool) interceptor.Invoke("startSsl", "startSsl()", typeof(bool));
        }
        /// <remarks>
        ///  Close the connection and forget non-permanent data like the peer host.
        ///      </remarks>        <short>    Close the connection and forget non-permanent data like the peer host.</short>
        protected void DisconnectFromHost() {
            interceptor.Invoke("disconnectFromHost", "disconnectFromHost()", typeof(void));
        }
        /// <remarks>
        ///  Returns true when end of data is reached.
        ///      </remarks>        <short>    Returns true when end of data is reached.</short>
        protected bool AtEnd() {
            return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
        }
        /// <remarks>
        ///  Determines whether or not we are still connected
        ///  to the remote machine.
        ///  return <code>true</code> if the socket is still active or
        ///            false otherwise.
        ///      </remarks>        <short>    Determines whether or not we are still connected  to the remote machine.</short>
        protected bool IsConnected() {
            return (bool) interceptor.Invoke("isConnected", "isConnected() const", typeof(bool));
        }
        /// <remarks>
        ///  Wait for incoming data on the socket
        ///  for the period specified by <code>t.</code>
        /// <param> name="t" length of time in seconds that we should monitor the
        ///            socket before timing out.
        /// </param></remarks>        <return> true if any data arrived on the socket before the
        ///               timeout value was reached, false otherwise.
        ///      </return>
        ///         <short>    Wait for incoming data on the socket  for the period specified by <code>t.</code></short>
        protected bool WaitForResponse(int t) {
            return (bool) interceptor.Invoke("waitForResponse$", "waitForResponse(int)", typeof(bool), typeof(int), t);
        }
        /// <remarks>
        ///  Sets the mode of the connection to blocking or non-blocking.
        ///  Be sure to call this function before calling connectToHost.
        ///  Otherwise, this setting will not have any effect until the next
        ///  <code>connectToHost.</code>
        /// <param> name="b" true to make the connection a blocking one, false otherwise.
        ///      </param></remarks>        <short>    Sets the mode of the connection to blocking or non-blocking.</short>
        protected void SetBlocking(bool b) {
            interceptor.Invoke("setBlocking$", "setBlocking(bool)", typeof(void), typeof(bool), b);
        }
        /// <remarks>
        ///  Return the socket object, if the class ever needs to do anything to it
        ///      </remarks>        <short>    Return the socket object, if the class ever needs to do anything to it      </short>
        protected QIODevice Socket() {
            return (QIODevice) interceptor.Invoke("socket", "socket() const", typeof(QIODevice));
        }
    }
}
