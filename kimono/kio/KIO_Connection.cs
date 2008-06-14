//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
	using Kimono;
	using System;
	using Qyoto;
	using System.Runtime.InteropServices;
	/// <remarks>
	///  @private
	///  This class provides a simple means for IPC between two applications
	///  via a pipe.
	///  It handles a queue of commands to be sent which makes it possible to
	///  queue data before an actual connection has been established.
	///       See <see cref="IConnectionSignals"></see> for signals emitted by Connection
	/// </remarks>		<short>    @private </short>
	[SmokeClass("KIO::Connection")]
	public class Connection : QObject, IDisposable {
 		protected Connection(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Connection), this);
		}
		/// <remarks>
		///  Creates a new connection.
		/// </remarks>		<short>    Creates a new connection.</short>
		/// 		<see> connectToRemote</see>
		/// 		<see> listenForRemote</see>
		public Connection(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Connection#", "Connection(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public Connection() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Connection", "Connection()", typeof(void));
		}
		/// <remarks>
		///  Connects to the remote address.
		///          </remarks>		<short>    Connects to the remote address.</short>
		public void ConnectToRemote(string address) {
			interceptor.Invoke("connectToRemote$", "connectToRemote(const QString&)", typeof(void), typeof(string), address);
		}
		public void Close() {
			interceptor.Invoke("close", "close()", typeof(void));
		}
		public string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		public bool IsConnected() {
			return (bool) interceptor.Invoke("isConnected", "isConnected() const", typeof(bool));
		}
		/// <remarks>
		///  Checks whether the connection has been initialized.
		/// </remarks>		<return> true if the initialized
		/// </return>
		/// 		<short>    Checks whether the connection has been initialized.</short>
		/// 		<see> init</see>
		public bool Inited() {
			return (bool) interceptor.Invoke("inited", "inited() const", typeof(bool));
		}
		/// <remarks>
		///  Sends/queues the given command to be sent.
		/// <param> name="cmd" the command to set
		/// </param><param> name="arr" the bytes to send
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Sends/queues the given command to be sent.</short>
		public bool Send(int cmd, QByteArray arr) {
			return (bool) interceptor.Invoke("send$#", "send(int, const QByteArray&)", typeof(bool), typeof(int), cmd, typeof(QByteArray), arr);
		}
		public bool Send(int cmd) {
			return (bool) interceptor.Invoke("send$", "send(int)", typeof(bool), typeof(int), cmd);
		}
		/// <remarks>
		///  Sends the given command immediately.
		/// <param> name="_cmd" the command to set
		/// </param><param> name="data" the bytes to send
		/// </param></remarks>		<return> true if successful, false otherwise
		/// 	 </return>
		/// 		<short>    Sends the given command immediately.</short>
		public bool Sendnow(int _cmd, QByteArray data) {
			return (bool) interceptor.Invoke("sendnow$#", "sendnow(int, const QByteArray&)", typeof(bool), typeof(int), _cmd, typeof(QByteArray), data);
		}
		/// <remarks>
		///  Returns true if there are packets to be read immediately,
		///  false if waitForIncomingTask must be called before more data
		///  is available.
		///          </remarks>		<short>    Returns true if there are packets to be read immediately,  false if waitForIncomingTask must be called before more data  is available.</short>
		public bool HasTaskAvailable() {
			return (bool) interceptor.Invoke("hasTaskAvailable", "hasTaskAvailable() const", typeof(bool));
		}
		/// <remarks>
		///  Waits for one more command to be handled and ready.
		/// <param> name="ms" the time to wait in milliseconds
		/// </param></remarks>		<return> true if one command can be read, false if we timed out
		///          </return>
		/// 		<short>    Waits for one more command to be handled and ready.</short>
		public bool WaitForIncomingTask(int ms) {
			return (bool) interceptor.Invoke("waitForIncomingTask$", "waitForIncomingTask(int)", typeof(bool), typeof(int), ms);
		}
		public bool WaitForIncomingTask() {
			return (bool) interceptor.Invoke("waitForIncomingTask", "waitForIncomingTask()", typeof(bool));
		}
		/// <remarks>
		///  Receive data.
		/// <param> name="_cmd" the received command will be written here
		/// </param><param> name="data" the received data will be written here
		/// </param></remarks>		<return> >=0 indicates the received data size upon success
		///          -1  indicates error
		/// 	 </return>
		/// 		<short>    Receive data.</short>
		public int Read(ref int _cmd, QByteArray data) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_int = _cmd;
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(data);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(data);
#endif
			interceptor.Invoke("read$#", "read(int*, QByteArray&)", stack);
			_cmd = stack[1].s_int;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
			return stack[0].s_int;
		}
		/// <remarks>
		///  Don't handle incoming data until resumed.
		///          </remarks>		<short>    Don't handle incoming data until resumed.</short>
		public void Suspend() {
			interceptor.Invoke("suspend", "suspend()", typeof(void));
		}
		/// <remarks>
		///  Resume handling of incoming data.
		///          </remarks>		<short>    Resume handling of incoming data.</short>
		public void Resume() {
			interceptor.Invoke("resume", "resume()", typeof(void));
		}
		/// <remarks>
		///  Returns status of connection.
		/// </remarks>		<return> true if suspended, false otherwise
		///          </return>
		/// 		<short>    Returns status of connection.</short>
		public bool Suspended() {
			return (bool) interceptor.Invoke("suspended", "suspended() const", typeof(bool));
		}
		~Connection() {
			interceptor.Invoke("~Connection", "~Connection()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Connection", "~Connection()", typeof(void));
		}
		protected new IConnectionSignals Emit {
			get { return (IConnectionSignals) Q_EMIT; }
		}
	}

	public interface IConnectionSignals : IQObjectSignals {
		[Q_SIGNAL("void readyRead()")]
		void ReadyRead();
	}
}
