//Auto-generated by kalyptus. DO NOT EDIT.
namespace KSettings.Dispatcher {

	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;



	/// <remarks>
	///  Since your program does not have direct control over the KCMs that get loaded
	///  into KSettings.Dialog you need a way to get notified. This is what you do:
	///  <pre>
	///  Dispatcher.RegisterComponent(componentData(), this, "loadSettings");
	///  </pre>
	/// </remarks>		<author> Matthias Kretz <kretz@kde.org>
	///  </author>
	/// 		<short> Dispatch change notifications from the KCMs to the program. </short>

	[SmokeClass("KSettings::Dispatcher")]
	public class Global : Object {
		protected SmokeInvocation interceptor = null;
		private static SmokeInvocation staticInterceptor = null;
		static Global() {
			staticInterceptor = new SmokeInvocation(typeof(Global), null);
		}
		/// <remarks>
		///  Register a slot to be called when the configuration for the componentData
		///  has changed. <code>componentData</code> is the KComponentData object
		///  that is passed to KGenericFactory (if it is used). You can query
		///  it with KGenericFactory<YourClassName>.ComponentData().
		///  componentData.componentName() is also the same name that is put into the
		///  .desktop file of the KCMs for the X-KDE-ParentComponents.
		/// <param> name="componentData" The KComponentData object
		/// </param><param> name="recv" The object that should receive the signal
		/// </param><param> name="slot" The slot to be called: "slotName"
		///      </param></remarks>		<short>    Register a slot to be called when the configuration for the componentData  has changed.</short>
		public static void RegisterComponent(KComponentData componentData, QObject recv, string slot) {
			staticInterceptor.Invoke("registerComponent##$", "registerComponent(const KComponentData&, QObject*, const char*)", typeof(void), typeof(KComponentData), componentData, typeof(QObject), recv, typeof(string), slot);
		}
		/// <remarks>
		/// </remarks>		<return> the KConfig object that belongs to the componentName
		///      </return>
		/// 		<short>   </short>
		public static KSharedConfig ConfigForComponentName(string componentName) {
			return (KSharedConfig) staticInterceptor.Invoke("configForComponentName$", "configForComponentName(const QString&)", typeof(KSharedConfig), typeof(string), componentName);
		}
		/// <remarks>
		/// </remarks>		<return> a list of all the componentData names that are currently
		///  registered
		///      </return>
		/// 		<short>   </short>
		public static List<string> ComponentNames() {
			return (List<string>) staticInterceptor.Invoke("componentNames", "componentNames()", typeof(List<string>));
		}
		/// <remarks>
		///  Call this function when the configuration belonging to the associated
		///  componentData name has changed. The registered slot will be called.
		/// <param> name="componentName" The value of X-KDE-ParentComponents.
		///      </param></remarks>		<short>    Call this function when the configuration belonging to the associated  componentData name has changed.</short>
		public static void ReparseConfiguration(string componentName) {
			staticInterceptor.Invoke("reparseConfiguration$", "reparseConfiguration(const QString&)", typeof(void), typeof(string), componentName);
		}
		/// <remarks>
		///  When this function is called the KConfig objects of all the registered
		///  instances are sync()ed. This is useful when some other KConfig
		///  objects will read/write from/to the same config file, so that you
		///  can first write out the current state of the KConfig objects.
		///      </remarks>		<short>    When this function is called the KConfig objects of all the registered  instances are sync()ed.</short>
		public static void SyncConfiguration() {
			staticInterceptor.Invoke("syncConfiguration", "syncConfiguration()", typeof(void));
		}
	}
}