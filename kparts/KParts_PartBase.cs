//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {
    using Kimono;
    using System;
    using Qyoto;

    public interface IPartBase : IKXMLGUIClient {
        void SetPartObject(QObject arg1);
        QObject PartObject();
    }
    /// <remarks>
    /// </remarks>        <short> Base class for all parts.  </short>
    [SmokeClass("KParts::PartBase")]
    public class PartBase : KXMLGUIClient, IDisposable {
        protected PartBase(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(PartBase), this);
        }
        /// <remarks>
        ///  We have three different policies, whether to load new plugins or not. The
        ///  value in the KConfig object of the KComponentData object always overrides
        ///  LoadPlugins and LoadPluginsIfEnabled.
        ///    </remarks>        <short>    We have three different policies, whether to load new plugins or not.</short>
        public enum PluginLoadingMode {
            DoNotLoadPlugins = 0,
            LoadPlugins = 1,
            LoadPluginsIfEnabled = 2,
        }
        // KParts::PartBase* PartBase(KParts::PartBasePrivate& arg1); >>>> NOT CONVERTED
        /// <remarks>
        ///   Constructor.
        ///    </remarks>        <short>     Constructor.</short>
        public PartBase() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("PartBase", "PartBase()", typeof(void));
        }
        /// <remarks>
        ///   Internal method. Called by KParts.Part to specify the parent object for plugin objects.
        ///    </remarks>        <short>     Internal method.</short>
        public void SetPartObject(QObject arg1) {
            interceptor.Invoke("setPartObject#", "setPartObject(QObject*)", typeof(void), typeof(QObject), arg1);
        }
        public QObject PartObject() {
            return (QObject) interceptor.Invoke("partObject", "partObject() const", typeof(QObject));
        }
        /// <remarks>
        ///  Set the componentData(KComponentData) for this part.
        ///  Call this first in the inherited class constructor,
        ///  because it loads the i18n catalogs.
        ///    </remarks>        <short>    Set the componentData(KComponentData) for this part.</short>
        [SmokeMethod("setComponentData(const KComponentData&)")]
        protected override void SetComponentData(KComponentData componentData) {
            interceptor.Invoke("setComponentData#", "setComponentData(const KComponentData&)", typeof(void), typeof(KComponentData), componentData);
        }
        /// <remarks>
        ///  Set the componentData(KComponentData) for this part.
        ///  Call this first in the inherited class constructor,
        ///  because it loads the i18n catalogs.
        ///  It is recommended to call setComponentData with loadPlugins set to false,
        ///  and to load plugins at the end of your part constructor (in the case of
        ///  KParts.MainWindow, plugins are automatically loaded in createGUI anyway,
        ///  so set loadPlugins to false for KParts.MainWindow as well).
        ///    </remarks>        <short>    Set the componentData(KComponentData) for this part.</short>
        [SmokeMethod("setComponentData(const KComponentData&, bool)")]
        protected virtual void SetComponentData(KComponentData componentData, bool loadPlugins) {
            interceptor.Invoke("setComponentData#$", "setComponentData(const KComponentData&, bool)", typeof(void), typeof(KComponentData), componentData, typeof(bool), loadPlugins);
        }
        /// <remarks>
        ///  Load the Plugins honoring the PluginLoadingMode.
        ///  If you call this method in an already constructed GUI (like when the user
        ///  has changed which plugins are enabled) you need to add the new plugins to
        ///  the KXMLGUIFactory:
        ///  <pre>
        ///  if( factory() )
        ///  {
        ///    QList<KParts.Plugin > plugins = KParts.Plugin.PluginObjects( this );
        ///    for(int i = 0; i != plugins.size(); ++i) {
        ///       factory().AddClient( plugins[i] );
        ///    }
        ///  }
        ///  </pre>
        ///    </remarks>        <short>    Load the Plugins honoring the PluginLoadingMode.</short>
        protected void LoadPlugins(QObject parent, IKXMLGUIClient parentGUIClient, KComponentData componentData) {
            interceptor.Invoke("loadPlugins###", "loadPlugins(QObject*, KXMLGUIClient*, const KComponentData&)", typeof(void), typeof(QObject), parent, typeof(IKXMLGUIClient), parentGUIClient, typeof(KComponentData), componentData);
        }
        /// <remarks>
        ///  Set how plugins should be loaded
        /// <param> name="loadingMode" see PluginLoadingMode
        /// </param> For a KParts.Part: call this before setComponentData.
        ///  For a KParts.MainWindow: call this before createGUI.
        ///    </remarks>        <short>    Set how plugins should be loaded </short>
        protected void SetPluginLoadingMode(KParts.PartBase.PluginLoadingMode loadingMode) {
            interceptor.Invoke("setPluginLoadingMode$", "setPluginLoadingMode(KParts::PartBase::PluginLoadingMode)", typeof(void), typeof(KParts.PartBase.PluginLoadingMode), loadingMode);
        }
        /// <remarks>
        ///  If you change the binary interface offered by your part, you can avoid crashes
        ///  from old plugins lying around by setting X-KDE-InterfaceVersion=2 in the
        ///  .desktop files of the plugins, and calling setPluginInterfaceVersion( 2 ), so that
        ///  the old plugins are not loaded. Increase both numbers every time a
        ///  binary incompatible change in the application's plugin interface is made.
        /// <param> name="version" the interface version that plugins must have in order to be loaded.
        /// </param> For a KParts.Part: call this before setComponentData.
        ///  For a KParts.MainWindow: call this before createGUI.
        ///    </remarks>        <short>    If you change the binary interface offered by your part, you can avoid crashes  from old plugins lying around by setting X-KDE-InterfaceVersion=2 in the  .</short>
        protected void SetPluginInterfaceVersion(int version) {
            interceptor.Invoke("setPluginInterfaceVersion$", "setPluginInterfaceVersion(int)", typeof(void), typeof(int), version);
        }
        ~PartBase() {
            interceptor.Invoke("~PartBase", "~PartBase()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~PartBase", "~PartBase()", typeof(void));
        }
    }
}