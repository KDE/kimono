//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  A class to read and parse system time zone data.
	///  Access is performed via the system time zone library functions.
	/// </remarks>		<author> David Jarvie <djarvie@kde.org>.
	///  </author>
	/// 		<short> Reads and parses system time zone data.</short>
	/// 		<see> KSystemTimeZones</see>
	/// 		<see> KSystemTimeZone</see>
	/// 		<see> KSystemTimeZoneData</see>
	/// 		<see> @ingroup</see>
	/// 		<see> timezones</see>
	[SmokeClass("KSystemTimeZoneSource")]
	public class KSystemTimeZoneSource : KTimeZoneSource, IDisposable {
 		protected KSystemTimeZoneSource(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KSystemTimeZoneSource), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KSystemTimeZoneSource() {
			staticInterceptor = new SmokeInvocation(typeof(KSystemTimeZoneSource), null);
		}
		/// <remarks>
		///  Constructs a system time zone source.
		///      </remarks>		<short>    Constructs a system time zone source.</short>
		public KSystemTimeZoneSource() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KSystemTimeZoneSource", "KSystemTimeZoneSource()", typeof(void));
		}
		/// <remarks>
		///  Extract detailed information for one time zone, via the system time zone
		///  library functions.
		/// <param> name="zone" the time zone for which data is to be extracted
		/// </param></remarks>		<return> a KSystemTimeZoneData instance containing the parsed data.
		///          The caller is responsible for deleting the KTimeZoneData instance.
		///          Null is returned on error.
		///      </return>
		/// 		<short>    Extract detailed information for one time zone, via the system time zone  library functions.</short>
		[SmokeMethod("parse(const KTimeZone&) const")]
		public override KTimeZoneData Parse(KTimeZone zone) {
			return (KTimeZoneData) interceptor.Invoke("parse#", "parse(const KTimeZone&) const", typeof(KTimeZoneData), typeof(KTimeZone), zone);
		}
		~KSystemTimeZoneSource() {
			interceptor.Invoke("~KSystemTimeZoneSource", "~KSystemTimeZoneSource()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KSystemTimeZoneSource", "~KSystemTimeZoneSource()", typeof(void));
		}
		/// <remarks>
		///  Use in conjunction with endParseBlock() to improve efficiency when calling parse()
		///  for a group of KSystemTimeZone instances in succession.
		///  Call startParseBlock() before the first parse(), and call endParseBlock() after the last.
		///  The effect of calling these methods is to save and restore the TZ environment variable
		///  only once before and after the group of parse() calls, rather than before and
		///  after every call. So, between calls to startParseBlock() and endParseBlock(), do not
		///  call any functions which rely directly or indirectly on the local time zone setting.
		///      </remarks>		<short>    Use in conjunction with endParseBlock() to improve efficiency when calling parse()  for a group of KSystemTimeZone instances in succession.</short>
		public static void StartParseBlock() {
			staticInterceptor.Invoke("startParseBlock", "startParseBlock()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<short>   </short>
		/// 		<see> startParseBlock</see>
		public static void EndParseBlock() {
			staticInterceptor.Invoke("endParseBlock", "endParseBlock()", typeof(void));
		}
	}
}
