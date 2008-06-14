//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  KDE's trader for services associated to a given mimetype.
	///  Example: say that you want to the list of all KParts components that can handle HTML.
	///  Our code would look like:
	///  <pre>
	///  KServiceOfferList lst = KMimeTypeTrader.Self().Query("text/html",
	///                                                         "KParts/ReadOnlyPart");
	///  </pre>
	///  If you want to get the preferred KParts component for text/html you could use
	///  preferredService("text/html", "KParts/ReadOnlyPart"), although if this is about
	///  loading that component you would use createPartInstanceFromQuery directly.
	/// </remarks>		<short>    KDE's trader for services associated to a given mimetype.</short>
	/// 		<see> KServiceTypeTrader</see>
	/// 		<see> KService</see>
	[SmokeClass("KMimeTypeTrader")]
	public class KMimeTypeTrader : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KMimeTypeTrader(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KMimeTypeTrader), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KMimeTypeTrader() {
			staticInterceptor = new SmokeInvocation(typeof(KMimeTypeTrader), null);
		}
		/// <remarks>
		///  This method returns a list of services which are associated with a given mimetype.
		///  Example usage:
		///  To get list of applications that can handle a given mimetype,
		///  set <code>genericServiceType</code> to "Application" (which is the default).
		///  To get list of embeddable components that can handle a given mimetype,
		///  set <code>genericServiceType</code> to "KParts/ReadOnlyPart".
		///  The constraint parameter is used to limit the possible choices
		///  returned based on the constraints you give it.
		///  The <code>constraint</code> language is rather full.  The most common
		///  keywords are AND, OR, NOT, IN, and EXIST, all used in an
		///  almost spoken-word form.  An example is:
		///  <pre>
		///  (Type == 'Service') and (('Browser/View' in ServiceTypes) and (exist Library))
		///  </pre>
		///  The keys used in the query (Type, ServiceTypes, Library) are all
		///  fields found in the .desktop files.
		/// <param> name="mimeType" A mime type like 'text/plain' or 'text/html'.
		/// </param><param> name="genericServiceType" a basic service type, like 'KParts/ReadOnlyPart' or 'Application'
		/// </param><param> name="constraint" A constraint to limit the choices returned, string() to
		///                     get all services that can handle the given <code>mimetype</code>
		/// </param></remarks>		<return> A list of services that satisfy the query, sorted by preference
		///  (preferred service first)
		/// </return>
		/// 		<short>    This method returns a list of services which are associated with a given mimetype.</short>
		/// 		<see> http://techbase.kde.org/Development/Tutorials/Services/Traders#The_KTrader_Query_Language</see>
		public List<KService> Query(string mimeType, string genericServiceType, string constraint) {
			return (List<KService>) interceptor.Invoke("query$$$", "query(const QString&, const QString&, const QString&) const", typeof(List<KService>), typeof(string), mimeType, typeof(string), genericServiceType, typeof(string), constraint);
		}
		public List<KService> Query(string mimeType, string genericServiceType) {
			return (List<KService>) interceptor.Invoke("query$$", "query(const QString&, const QString&) const", typeof(List<KService>), typeof(string), mimeType, typeof(string), genericServiceType);
		}
		public List<KService> Query(string mimeType) {
			return (List<KService>) interceptor.Invoke("query$", "query(const QString&) const", typeof(List<KService>), typeof(string), mimeType);
		}
		/// <remarks>
		///  Returns the preferred service for <code>mimeType</code> and <code>genericServiceType</code>
		///  This is almost like offers().first(), except that it also checks
		///  if the service is allowed as a preferred service (see KService.AllowAsDefault).
		/// <param> name="mimeType" the mime type (see offers())
		/// </param><param> name="genericServiceType" the service type (see offers())
		/// </param></remarks>		<return> the preferred service, or 0 if no service is available
		///      </return>
		/// 		<short>    Returns the preferred service for <code>mimeType</code> and <code>genericServiceType</code> </short>
		public KService PreferredService(string mimeType, string genericServiceType) {
			return (KService) interceptor.Invoke("preferredService$$", "preferredService(const QString&, const QString&)", typeof(KService), typeof(string), mimeType, typeof(string), genericServiceType);
		}
		public KService PreferredService(string mimeType) {
			return (KService) interceptor.Invoke("preferredService$", "preferredService(const QString&)", typeof(KService), typeof(string), mimeType);
		}
		/// <remarks>
		///  This is a static pointer to the KMimeTypeTrader singleton.
		///  You will need to use this to access the KMimeTypeTrader functionality since the
		///  constructors are protected.
		/// </remarks>		<return> Static KMimeTypeTrader instance
		///      </return>
		/// 		<short>    This is a static pointer to the KMimeTypeTrader singleton.</short>
		public static KMimeTypeTrader Self() {
			return (KMimeTypeTrader) staticInterceptor.Invoke("self", "self()", typeof(KMimeTypeTrader));
		}
	}
}
