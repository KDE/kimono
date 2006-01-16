//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTextStream")]
	public class QTextStream : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTextStream(Type dummy) {}
		interface IQTextStreamProxy {
			QTextStream op_read(QTextStream lhs, char arg1);
			QTextStream op_read(QTextStream lhs, ushort arg1);
			QTextStream op_read(QTextStream lhs, uint arg1);
			QTextStream op_read(QTextStream lhs, ulong arg1);
			QTextStream op_read(QTextStream lhs, float arg1);
			QTextStream op_read(QTextStream lhs, double arg1);
			QTextStream op_read(QTextStream lhs, string arg1);
			QTextStream op_read(QTextStream lhs, StringBuilder arg1);
			QTextStream op_write(QTextStream lhs, char arg1);
			QTextStream op_write(QTextStream lhs, short arg1);
			QTextStream op_write(QTextStream lhs, uint arg1);
			QTextStream op_write(QTextStream lhs, long arg1);
			QTextStream op_write(QTextStream lhs, float arg1);
			QTextStream op_write(QTextStream lhs, double arg1);
			QTextStream op_write(QTextStream lhs, string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextStream), this);
			_interceptor = (QTextStream) realProxy.GetTransparentProxy();
		}
		private QTextStream ProxyQTextStream() {
			return (QTextStream) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextStream() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextStreamProxy), null);
			_staticInterceptor = (IQTextStreamProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextStreamProxy StaticQTextStream() {
			return (IQTextStreamProxy) _staticInterceptor;
		}

		public const int skipws = 0x0001;
		public const int left = 0x0002;
		public const int right = 0x0004;
		public const int _internal = 0x0008;
		public const int bin = 0x0010;
		public const int oct = 0x0020;
		public const int dec = 0x0040;
		public const int hex = 0x0080;
		public const int showbase = 0x0100;
		public const int showpoint = 0x0200;
		public const int uppercase = 0x0400;
		public const int showpos = 0x0800;
		public const int scientific = 0x1000;
		public const int _fixed = 0x2000;

		public enum Encoding {
			Locale = 0,
			Latin1 = 1,
			Unicode = 2,
			UnicodeNetworkOrder = 3,
			UnicodeReverse = 4,
			RawUnicode = 5,
			UnicodeUTF8 = 6,
		}
		[SmokeMethod("setEncoding(QTextStream::Encoding)")]
		public void SetEncoding(QTextStream.Encoding arg1) {
			ProxyQTextStream().SetEncoding(arg1);
		}
		[SmokeMethod("setCodec(QTextCodec*)")]
		public void SetCodec(QTextCodec arg1) {
			ProxyQTextStream().SetCodec(arg1);
		}
		[SmokeMethod("codec()")]
		public QTextCodec Codec() {
			return ProxyQTextStream().Codec();
		}
		public QTextStream() : this((Type) null) {
			CreateProxy();
			NewQTextStream();
		}
		[SmokeMethod("QTextStream()")]
		private void NewQTextStream() {
			ProxyQTextStream().NewQTextStream();
		}
		public QTextStream(IQIODevice arg1) : this((Type) null) {
			CreateProxy();
			NewQTextStream(arg1);
		}
		[SmokeMethod("QTextStream(QIODevice*)")]
		private void NewQTextStream(IQIODevice arg1) {
			ProxyQTextStream().NewQTextStream(arg1);
		}
		public QTextStream(StringBuilder arg1, int mode) : this((Type) null) {
			CreateProxy();
			NewQTextStream(arg1,mode);
		}
		[SmokeMethod("QTextStream(QString*, int)")]
		private void NewQTextStream(StringBuilder arg1, int mode) {
			ProxyQTextStream().NewQTextStream(arg1,mode);
		}
		public QTextStream(QByteArray arg1, int mode) : this((Type) null) {
			CreateProxy();
			NewQTextStream(arg1,mode);
		}
		[SmokeMethod("QTextStream(QByteArray, int)")]
		private void NewQTextStream(QByteArray arg1, int mode) {
			ProxyQTextStream().NewQTextStream(arg1,mode);
		}
		[SmokeMethod("device() const")]
		public IQIODevice Device() {
			return ProxyQTextStream().Device();
		}
		[SmokeMethod("setDevice(QIODevice*)")]
		public void SetDevice(IQIODevice arg1) {
			ProxyQTextStream().SetDevice(arg1);
		}
		[SmokeMethod("unsetDevice()")]
		public void UnsetDevice() {
			ProxyQTextStream().UnsetDevice();
		}
		[SmokeMethod("atEnd() const")]
		public bool AtEnd() {
			return ProxyQTextStream().AtEnd();
		}
		[SmokeMethod("eof() const")]
		public bool Eof() {
			return ProxyQTextStream().Eof();
		}
		[SmokeMethod("operator>>(QChar&)")]
		public static QTextStream op_read(QTextStream lhs, char arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		// QTextStream& operator>>(signed short& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>(unsigned short&)")]
		public static QTextStream op_read(QTextStream lhs, ushort arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		// QTextStream& operator>>(signed int& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>(unsigned int&)")]
		public static QTextStream op_read(QTextStream lhs, uint arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		// QTextStream& operator>>(signed long& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>(unsigned long&)")]
		public static QTextStream op_read(QTextStream lhs, ulong arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		[SmokeMethod("operator>>(float&)")]
		public static QTextStream op_read(QTextStream lhs, float arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		[SmokeMethod("operator>>(double&)")]
		public static QTextStream op_read(QTextStream lhs, double arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		[SmokeMethod("operator>>(char*)")]
		public static QTextStream op_read(QTextStream lhs, string arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		[SmokeMethod("operator>>(QString&)")]
		public static QTextStream op_read(QTextStream lhs, StringBuilder arg1) {
			return StaticQTextStream().op_read(lhs,arg1);
		}
		[SmokeMethod("operator<<(QChar)")]
		public static QTextStream op_write(QTextStream lhs, char arg1) {
			return StaticQTextStream().op_write(lhs,arg1);
		}
		[SmokeMethod("operator<<(short)")]
		public static QTextStream op_write(QTextStream lhs, short arg1) {
			return StaticQTextStream().op_write(lhs,arg1);
		}
		// QTextStream& operator<<(signed arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator<<(unsigned)")]
		public static QTextStream op_write(QTextStream lhs, uint arg1) {
			return StaticQTextStream().op_write(lhs,arg1);
		}
		[SmokeMethod("operator<<(long)")]
		public static QTextStream op_write(QTextStream lhs, long arg1) {
			return StaticQTextStream().op_write(lhs,arg1);
		}
		[SmokeMethod("operator<<(float)")]
		public static QTextStream op_write(QTextStream lhs, float arg1) {
			return StaticQTextStream().op_write(lhs,arg1);
		}
		[SmokeMethod("operator<<(double)")]
		public static QTextStream op_write(QTextStream lhs, double arg1) {
			return StaticQTextStream().op_write(lhs,arg1);
		}
		[SmokeMethod("operator<<(const char*)")]
		public static QTextStream op_write(QTextStream lhs, string arg1) {
			return StaticQTextStream().op_write(lhs,arg1);
		}
		// QTextStream& operator<<(void* arg1); >>>> NOT CONVERTED
		[SmokeMethod("readRawBytes(char*, uint)")]
		public QTextStream ReadRawBytes(string arg1, uint len) {
			return ProxyQTextStream().ReadRawBytes(arg1,len);
		}
		[SmokeMethod("writeRawBytes(const char*, uint)")]
		public QTextStream WriteRawBytes(string arg1, uint len) {
			return ProxyQTextStream().WriteRawBytes(arg1,len);
		}
		[SmokeMethod("readLine()")]
		public string ReadLine() {
			return ProxyQTextStream().ReadLine();
		}
		[SmokeMethod("read()")]
		public string Read() {
			return ProxyQTextStream().Read();
		}
		[SmokeMethod("skipWhiteSpace()")]
		public void SkipWhiteSpace() {
			ProxyQTextStream().SkipWhiteSpace();
		}
		[SmokeMethod("flags() const")]
		public int Flags() {
			return ProxyQTextStream().Flags();
		}
		[SmokeMethod("flags(int)")]
		public int Flags(int f) {
			return ProxyQTextStream().Flags(f);
		}
		[SmokeMethod("setf(int)")]
		public int Setf(int bits) {
			return ProxyQTextStream().Setf(bits);
		}
		[SmokeMethod("setf(int, int)")]
		public int Setf(int bits, int mask) {
			return ProxyQTextStream().Setf(bits,mask);
		}
		[SmokeMethod("unsetf(int)")]
		public int Unsetf(int bits) {
			return ProxyQTextStream().Unsetf(bits);
		}
		[SmokeMethod("reset()")]
		public void Reset() {
			ProxyQTextStream().Reset();
		}
		[SmokeMethod("width() const")]
		public int Width() {
			return ProxyQTextStream().Width();
		}
		[SmokeMethod("width(int)")]
		public int Width(int arg1) {
			return ProxyQTextStream().Width(arg1);
		}
		[SmokeMethod("fill() const")]
		public int Fill() {
			return ProxyQTextStream().Fill();
		}
		[SmokeMethod("fill(int)")]
		public int Fill(int arg1) {
			return ProxyQTextStream().Fill(arg1);
		}
		[SmokeMethod("precision() const")]
		public int Precision() {
			return ProxyQTextStream().Precision();
		}
		[SmokeMethod("precision(int)")]
		public int Precision(int arg1) {
			return ProxyQTextStream().Precision(arg1);
		}
		~QTextStream() {
			DisposeQTextStream();
		}
		public void Dispose() {
			DisposeQTextStream();
		}
		private void DisposeQTextStream() {
			ProxyQTextStream().DisposeQTextStream();
		}
	}
}
