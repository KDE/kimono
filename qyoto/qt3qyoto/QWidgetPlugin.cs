//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QWidgetPlugin")]
	public class QWidgetPlugin : QGPlugin {
 		protected QWidgetPlugin(Type dummy) : base((Type) null) {}
		interface IQWidgetPluginProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QWidgetPlugin), this);
			_interceptor = (QWidgetPlugin) realProxy.GetTransparentProxy();
		}
		private QWidgetPlugin ProxyQWidgetPlugin() {
			return (QWidgetPlugin) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QWidgetPlugin() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQWidgetPluginProxy), null);
			_staticInterceptor = (IQWidgetPluginProxy) realProxy.GetTransparentProxy();
		}
		private static IQWidgetPluginProxy StaticQWidgetPlugin() {
			return (IQWidgetPluginProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQWidgetPlugin().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQWidgetPlugin().ClassName();
		}
		public QWidgetPlugin() : this((Type) null) {
			CreateProxy();
			NewQWidgetPlugin();
		}
		[SmokeMethod("QWidgetPlugin()")]
		private void NewQWidgetPlugin() {
			ProxyQWidgetPlugin().NewQWidgetPlugin();
		}
		[SmokeMethod("keys() const")]
		public virtual ArrayList Keys() {
			return ProxyQWidgetPlugin().Keys();
		}
		[SmokeMethod("create(const QString&, QWidget*, const char*)")]
		public virtual QWidget Create(string key, QWidget parent, string name) {
			return ProxyQWidgetPlugin().Create(key,parent,name);
		}
		[SmokeMethod("create(const QString&, QWidget*)")]
		public virtual QWidget Create(string key, QWidget parent) {
			return ProxyQWidgetPlugin().Create(key,parent);
		}
		[SmokeMethod("create(const QString&)")]
		public virtual QWidget Create(string key) {
			return ProxyQWidgetPlugin().Create(key);
		}
		[SmokeMethod("group(const QString&) const")]
		public virtual string Group(string key) {
			return ProxyQWidgetPlugin().Group(key);
		}
		[SmokeMethod("iconSet(const QString&) const")]
		public virtual QIconSet IconSet(string key) {
			return ProxyQWidgetPlugin().IconSet(key);
		}
		[SmokeMethod("includeFile(const QString&) const")]
		public virtual string IncludeFile(string key) {
			return ProxyQWidgetPlugin().IncludeFile(key);
		}
		[SmokeMethod("toolTip(const QString&) const")]
		public virtual string ToolTip(string key) {
			return ProxyQWidgetPlugin().ToolTip(key);
		}
		[SmokeMethod("whatsThis(const QString&) const")]
		public virtual string WhatsThis(string key) {
			return ProxyQWidgetPlugin().WhatsThis(key);
		}
		[SmokeMethod("isContainer(const QString&) const")]
		public virtual bool IsContainer(string key) {
			return ProxyQWidgetPlugin().IsContainer(key);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQWidgetPlugin().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQWidgetPlugin().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQWidgetPlugin().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQWidgetPlugin().TrUtf8(arg1);
		}
		~QWidgetPlugin() {
			DisposeQWidgetPlugin();
		}
		public new void Dispose() {
			DisposeQWidgetPlugin();
		}
		private void DisposeQWidgetPlugin() {
			ProxyQWidgetPlugin().DisposeQWidgetPlugin();
		}
		protected new IQWidgetPluginSignals Emit() {
			return (IQWidgetPluginSignals) Q_EMIT;
		}
	}

	public interface IQWidgetPluginSignals : IQGPluginSignals {
	}
}
