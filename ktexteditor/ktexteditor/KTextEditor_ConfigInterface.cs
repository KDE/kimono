//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \brief Config interface extension for the View.
    ///  \ingroup kte_group_view_extensions
    ///  \section config_intro Introduction
    ///  The ConfigInterface provides methods to access and modify the low level
    ///  config information for a given View. Examples of this config data can be
    ///  displaying the icon bar, showing line numbers, etc. This generally allows
    ///  access to settings that otherwise are only accessible during runtime.
    ///  \section config_access Accessing the Interface
    ///  The ConfigInterface is supposed to be an extension interface for a View,
    ///  i.e. the View inherits the interface \e provided that the
    ///  KTextEditor library in use implements the interface. Use qobject_cast to access
    ///  the interface:
    ///  <pre>
    ///  // view is of type KTextEditor.View
    ///  KTextEditor.ConfigInterface iface =
    ///      qobject_cast<KTextEditor.ConfigInterface>( view );
    ///  if( iface ) {
    ///      // the implementation supports the interface
    ///      // do stuff
    ///  }
    ///  </pre>
    ///  \section config_data Accessing Data
    ///  A list of available config variables (or keys) can be optained by calling
    ///  configKeys(). For all available keys configValue() returns the corresponding
    ///  value as QVariant. A value for a given key can be set by calling
    ///  setConfigValue(). Right now KatePart has support for the following
    ///  tuples:
    ///   - line-numbers [bool], show/hide line numbers
    ///   - icon-bar [bool], show/hide icon bar
    ///   - dynamic-word-wrap [bool], enable/disable dynamic word wrap
    ///  As a small example, if you want to enable dynamic word wrap simply call
    ///  <pre>
    ///  iface.SetConfigValue("dynamic-word-wrap", true);
    ///  </pre>
    ///  \see KTextEditor.View
    ///  \author Matt Broadstone \<mbroadst@gmail.com\>
    ///  </remarks>        <short>    \brief Config interface extension for the View.</short>
    [SmokeClass("KTextEditor::ConfigInterface")]
    public class ConfigInterface : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected ConfigInterface(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ConfigInterface), this);
        }
        public ConfigInterface() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigInterface", "ConfigInterface()", typeof(void));
        }
        /// <remarks>
        ///  Get a list of all available keys.
        ///      </remarks>        <short>    Get a list of all available keys.</short>
        [SmokeMethod("configKeys() const")]
        public virtual List<string> ConfigKeys() {
            return (List<string>) interceptor.Invoke("configKeys", "configKeys() const", typeof(List<string>));
        }
        /// <remarks>
        ///  Get a value for the <pre>key</pre>.
        ///      </remarks>        <short>    Get a value for the \p key.</short>
        [SmokeMethod("configValue(const QString&)")]
        public virtual QVariant ConfigValue(string key) {
            return (QVariant) interceptor.Invoke("configValue$", "configValue(const QString&)", typeof(QVariant), typeof(string), key);
        }
        /// <remarks>
        ///  Set a the <pre>key</pre>'s value to <pre>value</pre>.
        ///      </remarks>        <short>    Set a the \p key's value to \p value.</short>
        [SmokeMethod("setConfigValue(const QString&, const QVariant&)")]
        public virtual void SetConfigValue(string key, QVariant value) {
            interceptor.Invoke("setConfigValue$#", "setConfigValue(const QString&, const QVariant&)", typeof(void), typeof(string), key, typeof(QVariant), value);
        }
        ~ConfigInterface() {
            interceptor.Invoke("~ConfigInterface", "~ConfigInterface()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~ConfigInterface", "~ConfigInterface()", typeof(void));
        }
    }
}
