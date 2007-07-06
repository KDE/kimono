//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  KDE X509v3 Flag Class
	///  This class is used to track X509v3 flags for 
	/// </remarks>		<author> George Staikos <staikos@kde.org>
	/// </author>
	/// 		<short> KDE SSL Class.</short>
	/// 		<see> KExtendedSocket</see>
	/// 		<see> TCPSlaveBase</see>

	[SmokeClass("KSSLX509V3")]
	public class KSSLX509V3 : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KSSLX509V3(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KSSLX509V3), this);
		}
		/// <remarks>
		///   Determine if this certificate can be used by a certificate authority
		/// </remarks>		<return> true if it can be used by a certificate authority
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used by a certificate authority </short>
		public bool CertTypeCA() {
			return (bool) interceptor.Invoke("certTypeCA", "certTypeCA() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used by an SSL signer
		/// </remarks>		<return> true if it can be used by an SSL signer
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used by an SSL signer </short>
		public bool CertTypeSSLCA() {
			return (bool) interceptor.Invoke("certTypeSSLCA", "certTypeSSLCA() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used by an S/MIME signer
		/// </remarks>		<return> true if it can be used by an S/MIME signer
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used by an S/MIME signer </short>
		public bool CertTypeEmailCA() {
			return (bool) interceptor.Invoke("certTypeEmailCA", "certTypeEmailCA() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used by a code certificate signer
		/// </remarks>		<return> true if it can be used by a code certificate signer
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used by a code certificate signer </short>
		public bool CertTypeCodeCA() {
			return (bool) interceptor.Invoke("certTypeCodeCA", "certTypeCodeCA() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used by an SSL client
		/// </remarks>		<return> true if it can be used by an SSL client
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used by an SSL client </short>
		public bool CertTypeSSLClient() {
			return (bool) interceptor.Invoke("certTypeSSLClient", "certTypeSSLClient() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used by an SSL server
		/// </remarks>		<return> true if it can be used by an SSL server
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used by an SSL server </short>
		public bool CertTypeSSLServer() {
			return (bool) interceptor.Invoke("certTypeSSLServer", "certTypeSSLServer() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used by a Netscape SSL server
		/// </remarks>		<return> true if it can be used by a Netscape SSL server
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used by a Netscape SSL server </short>
		public bool CertTypeNSSSLServer() {
			return (bool) interceptor.Invoke("certTypeNSSSLServer", "certTypeNSSSLServer() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used for S/MIME
		/// </remarks>		<return> true if it can be used for S/MIME
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used for S/MIME </short>
		public bool CertTypeSMIME() {
			return (bool) interceptor.Invoke("certTypeSMIME", "certTypeSMIME() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used for S/MIME encryption
		/// </remarks>		<return> true if it can be used for S/MIME encryption
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used for S/MIME encryption </short>
		public bool CertTypeSMIMEEncrypt() {
			return (bool) interceptor.Invoke("certTypeSMIMEEncrypt", "certTypeSMIMEEncrypt() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used for S/MIME signing
		/// </remarks>		<return> true if it can be used for S/MIME signing
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used for S/MIME signing </short>
		public bool CertTypeSMIMESign() {
			return (bool) interceptor.Invoke("certTypeSMIMESign", "certTypeSMIMESign() const", typeof(bool));
		}
		/// <remarks>
		///   Determine if this certificate can be used for revocation signing
		/// </remarks>		<return> true if it can be used for revocation signing
		/// 	 </return>
		/// 		<short>     Determine if this certificate can be used for revocation signing </short>
		public bool CertTypeCRLSign() {
			return (bool) interceptor.Invoke("certTypeCRLSign", "certTypeCRLSign() const", typeof(bool));
		}
		public KSSLX509V3() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KSSLX509V3", "KSSLX509V3()", typeof(void));
		}
		~KSSLX509V3() {
			interceptor.Invoke("~KSSLX509V3", "~KSSLX509V3()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KSSLX509V3", "~KSSLX509V3()", typeof(void));
		}
	}
}