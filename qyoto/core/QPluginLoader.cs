//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPluginLoader")]
	public class QPluginLoader : QObject, IDisposable {
 		protected QPluginLoader(Type dummy) : base((Type) null) {}
		[SmokeClass("QPluginLoader")]
		interface IQPluginLoaderProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("staticInstances", "()", "")]
			List<QObject> StaticInstances();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPluginLoader), this);
			_interceptor = (QPluginLoader) realProxy.GetTransparentProxy();
		}
		private QPluginLoader ProxyQPluginLoader() {
			return (QPluginLoader) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPluginLoader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPluginLoaderProxy), null);
			_staticInterceptor = (IQPluginLoaderProxy) realProxy.GetTransparentProxy();
		}
		private static IQPluginLoaderProxy StaticQPluginLoader() {
			return (IQPluginLoaderProxy) _staticInterceptor;
		}
		[Q_PROPERTY("QString", "fileName")]
		public string FileName {
			get {
				return Property("fileName").Value<string>();
			}
			set {
				SetProperty("fileName", QVariant.FromValue<string>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QPluginLoader(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQPluginLoader(parent);
		}
		[SmokeMethod("QPluginLoader", "(QObject*)", "#")]
		private void NewQPluginLoader(QObject parent) {
			ProxyQPluginLoader().NewQPluginLoader(parent);
		}
		public QPluginLoader() : this((Type) null) {
			CreateProxy();
			NewQPluginLoader();
		}
		[SmokeMethod("QPluginLoader", "()", "")]
		private void NewQPluginLoader() {
			ProxyQPluginLoader().NewQPluginLoader();
		}
		public QPluginLoader(string fileName, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQPluginLoader(fileName,parent);
		}
		[SmokeMethod("QPluginLoader", "(const QString&, QObject*)", "$#")]
		private void NewQPluginLoader(string fileName, QObject parent) {
			ProxyQPluginLoader().NewQPluginLoader(fileName,parent);
		}
		public QPluginLoader(string fileName) : this((Type) null) {
			CreateProxy();
			NewQPluginLoader(fileName);
		}
		[SmokeMethod("QPluginLoader", "(const QString&)", "$")]
		private void NewQPluginLoader(string fileName) {
			ProxyQPluginLoader().NewQPluginLoader(fileName);
		}
		[SmokeMethod("instance", "()", "")]
		public QObject Instance() {
			return ProxyQPluginLoader().Instance();
		}
		[SmokeMethod("load", "()", "")]
		public bool Load() {
			return ProxyQPluginLoader().Load();
		}
		[SmokeMethod("unload", "()", "")]
		public bool Unload() {
			return ProxyQPluginLoader().Unload();
		}
		[SmokeMethod("isLoaded", "() const", "")]
		public bool IsLoaded() {
			return ProxyQPluginLoader().IsLoaded();
		}
		[SmokeMethod("errorString", "() const", "")]
		public string ErrorString() {
			return ProxyQPluginLoader().ErrorString();
		}
		public static new string Tr(string s, string c) {
			return StaticQPluginLoader().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQPluginLoader().Tr(s);
		}
		public static List<QObject> StaticInstances() {
			return StaticQPluginLoader().StaticInstances();
		}
		~QPluginLoader() {
			DisposeQPluginLoader();
		}
		public new void Dispose() {
			DisposeQPluginLoader();
		}
		[SmokeMethod("~QPluginLoader", "()", "")]
		private void DisposeQPluginLoader() {
			ProxyQPluginLoader().DisposeQPluginLoader();
		}
		protected new IQPluginLoaderSignals Emit {
			get {
				return (IQPluginLoaderSignals) Q_EMIT;
			}
		}
	}

	public interface IQPluginLoaderSignals : IQObjectSignals {
	}
}
