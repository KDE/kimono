//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  </remarks>		<short>   </short>
	[SmokeClass("KIO::SessionData")]
	public class SessionData : QObject, IDisposable {
 		protected SessionData(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(SessionData), this);
		}
		public SessionData() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("SessionData", "SessionData()", typeof(void));
		}
		[SmokeMethod("configDataFor(KIO::MetaData&, const QString&, const QString&)")]
		public virtual void ConfigDataFor(KIO.MetaData configData, string proto, string host) {
			interceptor.Invoke("configDataFor#$$", "configDataFor(KIO::MetaData&, const QString&, const QString&)", typeof(void), typeof(KIO.MetaData), configData, typeof(string), proto, typeof(string), host);
		}
		[SmokeMethod("reset()")]
		public virtual void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		~SessionData() {
			interceptor.Invoke("~SessionData", "~SessionData()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~SessionData", "~SessionData()", typeof(void));
		}
		protected new ISessionDataSignals Emit {
			get { return (ISessionDataSignals) Q_EMIT; }
		}
	}

	public interface ISessionDataSignals : IQObjectSignals {
	}
}
