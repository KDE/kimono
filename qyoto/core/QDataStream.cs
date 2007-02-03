//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDataStream")]
	public class QDataStream : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDataStream(Type dummy) {}
		interface IQDataStreamProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDataStream), this);
			_interceptor = (QDataStream) realProxy.GetTransparentProxy();
		}
		private QDataStream ProxyQDataStream() {
			return (QDataStream) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDataStream() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDataStreamProxy), null);
			_staticInterceptor = (IQDataStreamProxy) realProxy.GetTransparentProxy();
		}
		private static IQDataStreamProxy StaticQDataStream() {
			return (IQDataStreamProxy) _staticInterceptor;
		}

		public enum Version {
			Qt_1_0 = 1,
			Qt_2_0 = 2,
			Qt_2_1 = 3,
			Qt_3_0 = 4,
			Qt_3_1 = 5,
			Qt_3_3 = 6,
			Qt_4_0 = 7,
			Qt_4_1 = Qt_4_0,
			Qt_4_2 = 8,
		}
		public enum Status {
			Ok = 0,
			ReadPastEnd = 1,
			ReadCorruptData = 2,
		}
		public QDataStream() : this((Type) null) {
			CreateProxy();
			NewQDataStream();
		}
		[SmokeMethod("QDataStream", "()")]
		private void NewQDataStream() {
			ProxyQDataStream().NewQDataStream();
		}
		public QDataStream(IQIODevice arg1) : this((Type) null) {
			CreateProxy();
			NewQDataStream(arg1);
		}
		[SmokeMethod("QDataStream#", "(QIODevice*)")]
		private void NewQDataStream(IQIODevice arg1) {
			ProxyQDataStream().NewQDataStream(arg1);
		}
		public QDataStream(QByteArray arg1, int flags) : this((Type) null) {
			CreateProxy();
			NewQDataStream(arg1,flags);
		}
		[SmokeMethod("QDataStream#$", "(QByteArray*, QIODevice::OpenMode)")]
		private void NewQDataStream(QByteArray arg1, int flags) {
			ProxyQDataStream().NewQDataStream(arg1,flags);
		}
		public QDataStream(QByteArray arg1) : this((Type) null) {
			CreateProxy();
			NewQDataStream(arg1);
		}
		[SmokeMethod("QDataStream#", "(const QByteArray&)")]
		private void NewQDataStream(QByteArray arg1) {
			ProxyQDataStream().NewQDataStream(arg1);
		}
		[SmokeMethod("device", "() const")]
		public IQIODevice Device() {
			return ProxyQDataStream().Device();
		}
		[SmokeMethod("setDevice#", "(QIODevice*)")]
		public void SetDevice(IQIODevice arg1) {
			ProxyQDataStream().SetDevice(arg1);
		}
		[SmokeMethod("unsetDevice", "()")]
		public void UnsetDevice() {
			ProxyQDataStream().UnsetDevice();
		}
		[SmokeMethod("atEnd", "() const")]
		public bool AtEnd() {
			return ProxyQDataStream().AtEnd();
		}
		[SmokeMethod("status", "() const")]
		public QDataStream.Status status() {
			return ProxyQDataStream().status();
		}
		[SmokeMethod("setStatus$", "(QDataStream::Status)")]
		public void SetStatus(QDataStream.Status status) {
			ProxyQDataStream().SetStatus(status);
		}
		[SmokeMethod("resetStatus", "()")]
		public void ResetStatus() {
			ProxyQDataStream().ResetStatus();
		}
		[SmokeMethod("version", "() const")]
		public int version() {
			return ProxyQDataStream().version();
		}
		[SmokeMethod("setVersion$", "(int)")]
		public void SetVersion(int arg1) {
			ProxyQDataStream().SetVersion(arg1);
		}
		// QDataStream& operator>>(qint8& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(quint8& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(qint16& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(quint16& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>$", "(qint32&)")]
		public QDataStream op_read(int i) {
			return ProxyQDataStream().op_read(i);
		}
		// QDataStream& operator>>(quint32& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(qint64& arg1); >>>> NOT CONVERTED
		// QDataStream& operator>>(quint64& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>$", "(bool&)")]
		public QDataStream op_read(bool i) {
			return ProxyQDataStream().op_read(i);
		}
		[SmokeMethod("operator>>$", "(float&)")]
		public QDataStream op_read(float f) {
			return ProxyQDataStream().op_read(f);
		}
		[SmokeMethod("operator>>$", "(double&)")]
		public QDataStream op_read(double f) {
			return ProxyQDataStream().op_read(f);
		}
		[SmokeMethod("operator>>?", "(char*&)")]
		public QDataStream op_read(string str) {
			return ProxyQDataStream().op_read(str);
		}
		// QDataStream& operator<<(qint8 arg1); >>>> NOT CONVERTED
		// QDataStream& operator<<(quint8 arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator<<$", "(qint16)")]
		public QDataStream op_write(short i) {
			return ProxyQDataStream().op_write(i);
		}
		[SmokeMethod("operator<<$", "(quint16)")]
		public QDataStream op_write(ushort i) {
			return ProxyQDataStream().op_write(i);
		}
		[SmokeMethod("operator<<$", "(qint32)")]
		public QDataStream op_write(int i) {
			return ProxyQDataStream().op_write(i);
		}
		[SmokeMethod("operator<<$", "(quint32)")]
		public QDataStream op_write(uint i) {
			return ProxyQDataStream().op_write(i);
		}
		[SmokeMethod("operator<<$", "(qint64)")]
		public QDataStream op_write(long i) {
			return ProxyQDataStream().op_write(i);
		}
		[SmokeMethod("operator<<$", "(quint64)")]
		public QDataStream op_write(ulong i) {
			return ProxyQDataStream().op_write(i);
		}
		[SmokeMethod("operator<<$", "(bool)")]
		public QDataStream op_write(bool i) {
			return ProxyQDataStream().op_write(i);
		}
		[SmokeMethod("operator<<$", "(float)")]
		public QDataStream op_write(float f) {
			return ProxyQDataStream().op_write(f);
		}
		[SmokeMethod("operator<<$", "(double)")]
		public QDataStream op_write(double f) {
			return ProxyQDataStream().op_write(f);
		}
		[SmokeMethod("operator<<$", "(const char*)")]
		public QDataStream op_write(string str) {
			return ProxyQDataStream().op_write(str);
		}
		[SmokeMethod("readBytes?$", "(char*&, uint&)")]
		public QDataStream ReadBytes(string arg1, uint len) {
			return ProxyQDataStream().ReadBytes(arg1,len);
		}
		[SmokeMethod("readRawData$$", "(char*, int)")]
		public int ReadRawData(string arg1, int len) {
			return ProxyQDataStream().ReadRawData(arg1,len);
		}
		[SmokeMethod("writeBytes$$", "(const char*, uint)")]
		public QDataStream WriteBytes(string arg1, uint len) {
			return ProxyQDataStream().WriteBytes(arg1,len);
		}
		[SmokeMethod("writeRawData$$", "(const char*, int)")]
		public int WriteRawData(string arg1, int len) {
			return ProxyQDataStream().WriteRawData(arg1,len);
		}
		[SmokeMethod("skipRawData$", "(int)")]
		public int SkipRawData(int len) {
			return ProxyQDataStream().SkipRawData(len);
		}
		~QDataStream() {
			DisposeQDataStream();
		}
		public void Dispose() {
			DisposeQDataStream();
		}
		[SmokeMethod("~QDataStream", "()")]
		private void DisposeQDataStream() {
			ProxyQDataStream().DisposeQDataStream();
		}
	}
}
