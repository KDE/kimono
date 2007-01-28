//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QPictureIO")]
	public class QPictureIO : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QPictureIO(Type dummy) {}
		interface IQPictureIOProxy {
			QByteArray PictureFormat(string fileName);
			QByteArray PictureFormat(IQIODevice arg1);
			List<QByteArray> InputFormats();
			List<QByteArray> OutputFormats();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPictureIO), this);
			_interceptor = (QPictureIO) realProxy.GetTransparentProxy();
		}
		private QPictureIO ProxyQPictureIO() {
			return (QPictureIO) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPictureIO() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPictureIOProxy), null);
			_staticInterceptor = (IQPictureIOProxy) realProxy.GetTransparentProxy();
		}
		private static IQPictureIOProxy StaticQPictureIO() {
			return (IQPictureIOProxy) _staticInterceptor;
		}

		public QPictureIO() : this((Type) null) {
			CreateProxy();
			NewQPictureIO();
		}
		[SmokeMethod("QPictureIO()")]
		private void NewQPictureIO() {
			ProxyQPictureIO().NewQPictureIO();
		}
		public QPictureIO(IQIODevice ioDevice, string format) : this((Type) null) {
			CreateProxy();
			NewQPictureIO(ioDevice,format);
		}
		[SmokeMethod("QPictureIO(QIODevice*, const char*)")]
		private void NewQPictureIO(IQIODevice ioDevice, string format) {
			ProxyQPictureIO().NewQPictureIO(ioDevice,format);
		}
		public QPictureIO(string fileName, string format) : this((Type) null) {
			CreateProxy();
			NewQPictureIO(fileName,format);
		}
		[SmokeMethod("QPictureIO(const QString&, const char*)")]
		private void NewQPictureIO(string fileName, string format) {
			ProxyQPictureIO().NewQPictureIO(fileName,format);
		}
		[SmokeMethod("picture() const")]
		public QPicture Picture() {
			return ProxyQPictureIO().Picture();
		}
		[SmokeMethod("status() const")]
		public int Status() {
			return ProxyQPictureIO().Status();
		}
		[SmokeMethod("format() const")]
		public string Format() {
			return ProxyQPictureIO().Format();
		}
		[SmokeMethod("ioDevice() const")]
		public IQIODevice IoDevice() {
			return ProxyQPictureIO().IoDevice();
		}
		[SmokeMethod("fileName() const")]
		public string FileName() {
			return ProxyQPictureIO().FileName();
		}
		[SmokeMethod("quality() const")]
		public int Quality() {
			return ProxyQPictureIO().Quality();
		}
		[SmokeMethod("description() const")]
		public string Description() {
			return ProxyQPictureIO().Description();
		}
		[SmokeMethod("parameters() const")]
		public string Parameters() {
			return ProxyQPictureIO().Parameters();
		}
		[SmokeMethod("gamma() const")]
		public float Gamma() {
			return ProxyQPictureIO().Gamma();
		}
		[SmokeMethod("setPicture(const QPicture&)")]
		public void SetPicture(QPicture arg1) {
			ProxyQPictureIO().SetPicture(arg1);
		}
		[SmokeMethod("setStatus(int)")]
		public void SetStatus(int arg1) {
			ProxyQPictureIO().SetStatus(arg1);
		}
		[SmokeMethod("setFormat(const char*)")]
		public void SetFormat(string arg1) {
			ProxyQPictureIO().SetFormat(arg1);
		}
		[SmokeMethod("setIODevice(QIODevice*)")]
		public void SetIODevice(IQIODevice arg1) {
			ProxyQPictureIO().SetIODevice(arg1);
		}
		[SmokeMethod("setFileName(const QString&)")]
		public void SetFileName(string arg1) {
			ProxyQPictureIO().SetFileName(arg1);
		}
		[SmokeMethod("setQuality(int)")]
		public void SetQuality(int arg1) {
			ProxyQPictureIO().SetQuality(arg1);
		}
		[SmokeMethod("setDescription(const QString&)")]
		public void SetDescription(string arg1) {
			ProxyQPictureIO().SetDescription(arg1);
		}
		[SmokeMethod("setParameters(const char*)")]
		public void SetParameters(string arg1) {
			ProxyQPictureIO().SetParameters(arg1);
		}
		[SmokeMethod("setGamma(float)")]
		public void SetGamma(float arg1) {
			ProxyQPictureIO().SetGamma(arg1);
		}
		[SmokeMethod("read()")]
		public bool Read() {
			return ProxyQPictureIO().Read();
		}
		[SmokeMethod("write()")]
		public bool Write() {
			return ProxyQPictureIO().Write();
		}
		[SmokeMethod("pictureFormat(const QString&)")]
		public static QByteArray PictureFormat(string fileName) {
			return StaticQPictureIO().PictureFormat(fileName);
		}
		[SmokeMethod("pictureFormat(QIODevice*)")]
		public static QByteArray PictureFormat(IQIODevice arg1) {
			return StaticQPictureIO().PictureFormat(arg1);
		}
		[SmokeMethod("inputFormats()")]
		public static List<QByteArray> InputFormats() {
			return StaticQPictureIO().InputFormats();
		}
		[SmokeMethod("outputFormats()")]
		public static List<QByteArray> OutputFormats() {
			return StaticQPictureIO().OutputFormats();
		}
		// void defineIOHandler(const char* arg1,const char* arg2,const char* arg3,picture_io_handler arg4,picture_io_handler arg5); >>>> NOT CONVERTED
		~QPictureIO() {
			DisposeQPictureIO();
		}
		public void Dispose() {
			DisposeQPictureIO();
		}
		[SmokeMethod("~QPictureIO()")]
		private void DisposeQPictureIO() {
			ProxyQPictureIO().DisposeQPictureIO();
		}
	}
}