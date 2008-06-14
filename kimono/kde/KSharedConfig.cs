//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  \class KSharedConfig ksharedconfig.h <KSharedConfig>
	///  KConfig variant using shared memory
	///  KSharedConfig provides a reference counted, shared memory variant
	///  of KConfig.
	///  </remarks>		<short>    \class KSharedConfig ksharedconfig.</short>
	[SmokeClass("KSharedConfig")]
	public class KSharedConfig : KConfig {
 		protected KSharedConfig(Type dummy) : base((Type) null) {}
		private static SmokeInvocation staticInterceptor = null;
		static KSharedConfig() {
			staticInterceptor = new SmokeInvocation(typeof(KSharedConfig), null);
		}
		/// <remarks>
		///  Constructs a KSharedConfig object.
		/// <param> name="fileName" A file to parse in addition to the
		///         system-wide file(s).  If it is not provided, only global
		///         KDE configuration data will be read (depending on the value of
		///         <code>mode</code>).
		/// </param><param> name="resourceType" the place to look in (config, data, etc) @see KStandardDirs.
		/// </param><param> name="backend"    </param></remarks>		<short>    Constructs a KSharedConfig object.</short>
		public static KSharedConfig OpenConfig(string fileName, uint mode, string resourceType) {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig$$$", "openConfig(const QString&, KConfig::OpenFlags, const char*)", typeof(KSharedConfig), typeof(string), fileName, typeof(uint), mode, typeof(string), resourceType);
		}
		public static KSharedConfig OpenConfig(string fileName, uint mode) {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig$$", "openConfig(const QString&, KConfig::OpenFlags)", typeof(KSharedConfig), typeof(string), fileName, typeof(uint), mode);
		}
		public static KSharedConfig OpenConfig(string fileName) {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig$", "openConfig(const QString&)", typeof(KSharedConfig), typeof(string), fileName);
		}
		public static KSharedConfig OpenConfig() {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig", "openConfig()", typeof(KSharedConfig));
		}
		public static KSharedConfig OpenConfig(KComponentData componentData, string fileName, uint mode, string resourceType) {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig#$$$", "openConfig(const KComponentData&, const QString&, KConfig::OpenFlags, const char*)", typeof(KSharedConfig), typeof(KComponentData), componentData, typeof(string), fileName, typeof(uint), mode, typeof(string), resourceType);
		}
		public static KSharedConfig OpenConfig(KComponentData componentData, string fileName, uint mode) {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig#$$", "openConfig(const KComponentData&, const QString&, KConfig::OpenFlags)", typeof(KSharedConfig), typeof(KComponentData), componentData, typeof(string), fileName, typeof(uint), mode);
		}
		public static KSharedConfig OpenConfig(KComponentData componentData, string fileName) {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig#$", "openConfig(const KComponentData&, const QString&)", typeof(KSharedConfig), typeof(KComponentData), componentData, typeof(string), fileName);
		}
		public static KSharedConfig OpenConfig(KComponentData componentData) {
			return (KSharedConfig) staticInterceptor.Invoke("openConfig#", "openConfig(const KComponentData&)", typeof(KSharedConfig), typeof(KComponentData), componentData);
		}
	}
}
