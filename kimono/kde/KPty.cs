//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  Provides primitives for opening & closing a pseudo TTY pair, assigning the
	///  controlling TTY, utmp registration and setting various terminal attributes.
	///  </remarks>		<short>    Provides primitives for opening & closing a pseudo TTY pair, assigning the  controlling TTY, utmp registration and setting various terminal attributes.</short>

	[SmokeClass("KPty")]
	public class KPty : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KPty(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPty), this);
		}
		// bool tcGetAttr(struct ::termios* arg1); >>>> NOT CONVERTED
		// bool tcSetAttr(struct ::termios* arg1); >>>> NOT CONVERTED
		// KPty* KPty(KPtyPrivate* arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Constructor
		///    </remarks>		<short>    Constructor    </short>
		public KPty() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPty", "KPty()", typeof(void));
		}
		/// <remarks>
		///  Create a pty master/slave pair.
		/// </remarks>		<return> true if a pty pair was successfully opened
		///    </return>
		/// 		<short>    Create a pty master/slave pair.</short>
		public bool Open() {
			return (bool) interceptor.Invoke("open", "open()", typeof(bool));
		}
		/// <remarks>
		///  Open using an existing pty master.
		/// <param> name="fd" an open pty master file descriptor.
		///    The ownership of the fd remains with the caller;
		///    it will not be automatically closed at any point.
		/// </param></remarks>		<return> true if a pty pair was successfully opened
		///    </return>
		/// 		<short>    Open using an existing pty master.</short>
		public bool Open(int fd) {
			return (bool) interceptor.Invoke("open$", "open(int)", typeof(bool), typeof(int), fd);
		}
		/// <remarks>
		///  Close the pty master/slave pair.
		///    </remarks>		<short>    Close the pty master/slave pair.</short>
		public void Close() {
			interceptor.Invoke("close", "close()", typeof(void));
		}
		/// <remarks>
		///  Close the pty slave descriptor.
		///  When creating the pty, KPty also opens the slave and keeps it open.
		///  Consequently the master will never receive an EOF notification.
		///  Usually this is the desired behavior, as a closed pty slave can be
		///  reopened any time - unlike a pipe or socket. However, in some cases
		///  pipe-alike behavior might be desired.
		///  After this function was called, slaveFd() and setCTty() cannot be
		///  used.
		///    </remarks>		<short>    Close the pty slave descriptor.</short>
		public void CloseSlave() {
			interceptor.Invoke("closeSlave", "closeSlave()", typeof(void));
		}
		/// <remarks>
		///  Open the pty slave descriptor.
		///  This undoes the effect of closeSlave().
		/// </remarks>		<return> true if the pty slave was successfully opened
		///    </return>
		/// 		<short>    Open the pty slave descriptor.</short>
		public bool OpenSlave() {
			return (bool) interceptor.Invoke("openSlave", "openSlave()", typeof(bool));
		}
		/// <remarks>
		///  Creates a new session and process group and makes this pty the
		///  controlling tty.
		///    </remarks>		<short>    Creates a new session and process group and makes this pty the  controlling tty.</short>
		public void SetCTty() {
			interceptor.Invoke("setCTty", "setCTty()", typeof(void));
		}
		/// <remarks>
		///  Creates an utmp entry for the tty.
		///  This function must be called after calling setCTty and
		///  making this pty the stdin.
		/// <param> name="user" the user to be logged on
		/// </param><param> name="remotehost" the host from which the login is coming. This is
		///   <b>not</b> the local host. For remote logins it should be the hostname
		///   of the client. For local logins from inside an X session it should
		///   be the name of the X display. Otherwise it should be empty.
		///    </param></remarks>		<short>    Creates an utmp entry for the tty.</short>
		public void Login(string user, string remotehost) {
			interceptor.Invoke("login$$", "login(const char*, const char*)", typeof(void), typeof(string), user, typeof(string), remotehost);
		}
		public void Login(string user) {
			interceptor.Invoke("login$", "login(const char*)", typeof(void), typeof(string), user);
		}
		public void Login() {
			interceptor.Invoke("login", "login()", typeof(void));
		}
		/// <remarks>
		///  Removes the utmp entry for this tty.
		///    </remarks>		<short>    Removes the utmp entry for this tty.</short>
		public void Logout() {
			interceptor.Invoke("logout", "logout()", typeof(void));
		}
		/// <remarks>
		///  Wrapper around tcgetattr(3).
		///  This function can be used only while the PTY is open.
		///  You will need an #include &lt;termios.h&gt; to do anything useful
		///  with it.
		/// <param> name="ttmode" a pointer to a termios structure.
		///   Note: when declaring ttmode, <code>struct</code> @c .Termios must be used -
		///   without the '.' some version of HP-UX thinks, this declares
		///   the struct in your class, in your method.
		/// </param></remarks>		<return> @c true on success, false otherwise
		///    </return>
		/// 		<short>    Wrapper around tcgetattr(3).</short>
		/// <remarks>
		///  Wrapper around tcsetattr(3) with mode TCSANOW.
		///  This function can be used only while the PTY is open.
		/// <param> name="ttmode" a pointer to a termios structure.
		/// </param></remarks>		<return> @c true on success, false otherwise. Note that success means
		///   that @em at @em least @em one attribute could be set.
		///    </return>
		/// 		<short>    Wrapper around tcsetattr(3) with mode TCSANOW.</short>
		/// <remarks>
		///  Change the logical (screen) size of the pty.
		///  The default is 24 lines by 80 columns.
		///  This function can be used only while the PTY is open.
		/// <param> name="lines" the number of rows
		/// </param><param> name="columns" the number of columns
		/// </param></remarks>		<return> @c true on success, false otherwise
		///    </return>
		/// 		<short>    Change the logical (screen) size of the pty.</short>
		public bool SetWinSize(int lines, int columns) {
			return (bool) interceptor.Invoke("setWinSize$$", "setWinSize(int, int)", typeof(bool), typeof(int), lines, typeof(int), columns);
		}
		/// <remarks>
		///  Set whether the pty should echo input.
		///  Echo is on by default.
		///  If the output of automatically fed (non-interactive) PTY clients
		///  needs to be parsed, disabling echo often makes it much simpler.
		///  This function can be used only while the PTY is open.
		/// <param> name="echo" true if input should be echoed.
		/// </param></remarks>		<return> @c true on success, false otherwise
		///    </return>
		/// 		<short>    Set whether the pty should echo input.</short>
		public bool SetEcho(bool echo) {
			return (bool) interceptor.Invoke("setEcho$", "setEcho(bool)", typeof(bool), typeof(bool), echo);
		}
		/// <remarks>
		///  This function should be called only while the pty is open.
		///    </remarks>		<return> the name of the slave pty device.
		/// </return>
		/// 		<short>   </short>
		public string TtyName() {
			return (string) interceptor.Invoke("ttyName", "ttyName() const", typeof(string));
		}
		/// <remarks>
		///  This function should be called only while the pty is open.
		///    </remarks>		<return> the file descriptor of the master pty
		/// </return>
		/// 		<short>   </short>
		public int MasterFd() {
			return (int) interceptor.Invoke("masterFd", "masterFd() const", typeof(int));
		}
		/// <remarks>
		///  This function should be called only while the pty slave is open.
		///    </remarks>		<return> the file descriptor of the slave pty
		/// </return>
		/// 		<short>   </short>
		public int SlaveFd() {
			return (int) interceptor.Invoke("slaveFd", "slaveFd() const", typeof(int));
		}
		~KPty() {
			interceptor.Invoke("~KPty", "~KPty()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KPty", "~KPty()", typeof(void));
		}
	}
}