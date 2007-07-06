//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  X.509 Map Parsing Class
	///  This class is used to parse and store a map as used in X.509 certificates.
	///  It is of the form /name=value/name=value/name=value
	/// </remarks>		<author> George Staikos <staikos@kde.org>
	/// </author>
	/// 		<short> X.509 Map Parser.</short>
	/// 		<see> KSSL</see>
	/// 		<see> KSSLCertificate</see>

	[SmokeClass("KSSLX509Map")]
	public class KSSLX509Map : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KSSLX509Map(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KSSLX509Map), this);
		}
		/// <remarks>
		///   Construct an X.509 Map
		/// <param> name="name" the map to parse
		/// 	 </param></remarks>		<short>     Construct an X.</short>
		public KSSLX509Map(string name) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KSSLX509Map$", "KSSLX509Map(const QString&)", typeof(void), typeof(string), name);
		}
		/// <remarks>
		///   Set a value in the map
		/// <param> name="key" the key
		/// </param><param> name="value" the value
		/// 	 </param></remarks>		<short>     Set a value in the map </short>
		public void SetValue(string key, string value) {
			interceptor.Invoke("setValue$$", "setValue(const QString&, const QString&)", typeof(void), typeof(string), key, typeof(string), value);
		}
		/// <remarks>
		///   Get the value of an entry in the map
		/// <param> name="key" the key
		/// </param></remarks>		<return> the value
		/// 	 </return>
		/// 		<short>     Get the value of an entry in the map </short>
		public string GetValue(string key) {
			return (string) interceptor.Invoke("getValue$", "getValue(const QString&) const", typeof(string), typeof(string), key);
		}
		/// <remarks>
		///   Reset (clear) the internal storage.
		/// <param> name="name" if this is not empty, it will be parsed and used as
		///          the new map internally
		/// 	 </param></remarks>		<short>     Reset (clear) the internal storage.</short>
		public void Reset(string name) {
			interceptor.Invoke("reset$", "reset(const QString&)", typeof(void), typeof(string), name);
		}
		public void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		~KSSLX509Map() {
			interceptor.Invoke("~KSSLX509Map", "~KSSLX509Map()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KSSLX509Map", "~KSSLX509Map()", typeof(void));
		}
	}
}