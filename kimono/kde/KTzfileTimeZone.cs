//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  The KTzfileTimeZone class represents a time zone defined in tzfile(5) format.
	///  It works in partnership with the KTzfileTimeZoneSource class which reads and parses the
	///  time zone definition files.
	/// </remarks>		<author> David Jarvie <djarvie@kde.org>.
	///  </author>
	/// 		<short> Represents a time zone defined in tzfile(5) format.</short>
	/// 		<see> KTzfileTimeZoneBackend</see>
	/// 		<see> KTzfileTimeZoneSource</see>
	/// 		<see> KTzfileTimeZoneData</see>
	/// 		<see> @ingroup</see>
	/// 		<see> timezones</see>
	[SmokeClass("KTzfileTimeZone")]
	public class KTzfileTimeZone : KTimeZone, IDisposable {
 		protected KTzfileTimeZone(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KTzfileTimeZone), this);
		}
		/// <remarks>
		///  Creates a time zone.
		/// <param> name="source" tzfile reader and parser
		/// </param><param> name="name" time zone's unique name, which must be the tzfile path relative
		///                     to the location specified for <code>source</code>
		/// </param><param> name="countryCode" ISO 3166 2-character country code, empty if unknown
		/// </param><param> name="latitude" in degrees (between -90 and +90), UNKNOWN if not known
		/// </param><param> name="longitude" in degrees (between -180 and +180), UNKNOWN if not known
		/// </param><param> name="comment" description of the time zone, if any
		///      </param></remarks>		<short>    Creates a time zone.</short>
		public KTzfileTimeZone(KTzfileTimeZoneSource source, string name, string countryCode, float latitude, float longitude, string comment) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KTzfileTimeZone#$$$$$", "KTzfileTimeZone(KTzfileTimeZoneSource*, const QString&, const QString&, float, float, const QString&)", typeof(void), typeof(KTzfileTimeZoneSource), source, typeof(string), name, typeof(string), countryCode, typeof(float), latitude, typeof(float), longitude, typeof(string), comment);
		}
		public KTzfileTimeZone(KTzfileTimeZoneSource source, string name, string countryCode, float latitude, float longitude) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KTzfileTimeZone#$$$$", "KTzfileTimeZone(KTzfileTimeZoneSource*, const QString&, const QString&, float, float)", typeof(void), typeof(KTzfileTimeZoneSource), source, typeof(string), name, typeof(string), countryCode, typeof(float), latitude, typeof(float), longitude);
		}
		public KTzfileTimeZone(KTzfileTimeZoneSource source, string name, string countryCode, float latitude) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KTzfileTimeZone#$$$", "KTzfileTimeZone(KTzfileTimeZoneSource*, const QString&, const QString&, float)", typeof(void), typeof(KTzfileTimeZoneSource), source, typeof(string), name, typeof(string), countryCode, typeof(float), latitude);
		}
		public KTzfileTimeZone(KTzfileTimeZoneSource source, string name, string countryCode) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KTzfileTimeZone#$$", "KTzfileTimeZone(KTzfileTimeZoneSource*, const QString&, const QString&)", typeof(void), typeof(KTzfileTimeZoneSource), source, typeof(string), name, typeof(string), countryCode);
		}
		public KTzfileTimeZone(KTzfileTimeZoneSource source, string name) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KTzfileTimeZone#$", "KTzfileTimeZone(KTzfileTimeZoneSource*, const QString&)", typeof(void), typeof(KTzfileTimeZoneSource), source, typeof(string), name);
		}
		~KTzfileTimeZone() {
			interceptor.Invoke("~KTzfileTimeZone", "~KTzfileTimeZone()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KTzfileTimeZone", "~KTzfileTimeZone()", typeof(void));
		}
	}
}
