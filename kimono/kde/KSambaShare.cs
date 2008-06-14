//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  Similar functionality like KFileShare, 
	///  but works only for Samba and do not need 
	///  any suid script.
	///  Singleton class, call instance() to get an instance.
	///  </remarks>		<short>    Similar functionality like KFileShare,   but works only for Samba and do not need   any suid script.</short>
	[SmokeClass("KSambaShare")]
	public class KSambaShare : QObject {
 		protected KSambaShare(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KSambaShare), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KSambaShare() {
			staticInterceptor = new SmokeInvocation(typeof(KSambaShare), null);
		}
		/// <remarks>
		///  Whether or not the given path is shared by Samba.
		/// <param> name="path" the path to check if it is shared by Samba.
		/// </param></remarks>		<return> whether the given path is shared by Samba.
		///    </return>
		/// 		<short>    Whether or not the given path is shared by Samba.</short>
		public bool IsDirectoryShared(string path) {
			return (bool) interceptor.Invoke("isDirectoryShared$", "isDirectoryShared(const QString&) const", typeof(bool), typeof(string), path);
		}
		/// <remarks>
		///  Returns a list of all directories shared by Samba.
		///  The resulting list is not sorted.
		/// </remarks>		<return> a list of all directories shared by Samba.
		///    </return>
		/// 		<short>    Returns a list of all directories shared by Samba.</short>
		public List<string> SharedDirectories() {
			return (List<string>) interceptor.Invoke("sharedDirectories", "sharedDirectories() const", typeof(List<string>));
		}
		/// <remarks>
		///  Returns the path to the used smb.conf file
		///  or null if no file was found
		///    </remarks>		<short>    Returns the path to the used smb.</short>
		public string SmbConfPath() {
			return (string) interceptor.Invoke("smbConfPath", "smbConfPath() const", typeof(string));
		}
		/// <remarks>
		///  Returns the one and only instance of KSambaShare
		///    </remarks>		<short>    Returns the one and only instance of KSambaShare    </short>
		public static KSambaShare Instance() {
			return (KSambaShare) staticInterceptor.Invoke("instance", "instance()", typeof(KSambaShare));
		}
		protected new IKSambaShareSignals Emit {
			get { return (IKSambaShareSignals) Q_EMIT; }
		}
	}

	public interface IKSambaShareSignals : IQObjectSignals {
	}
}
