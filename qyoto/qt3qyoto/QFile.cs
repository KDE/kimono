//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QFile")]
	public class QFile : QIODevice, IDisposable {
 		protected QFile(Type dummy) : base((Type) null) {}
		interface IQFileProxy {
			string EncodeName(string fileName);
			string DecodeName(string localFileName);
			bool Exists(string fileName);
			bool Remove(string fileName);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFile), this);
			_interceptor = (QFile) realProxy.GetTransparentProxy();
		}
		private QFile ProxyQFile() {
			return (QFile) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFile() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileProxy), null);
			_staticInterceptor = (IQFileProxy) realProxy.GetTransparentProxy();
		}
		private static IQFileProxy StaticQFile() {
			return (IQFileProxy) _staticInterceptor;
		}

		public QFile() : this((Type) null) {
			CreateProxy();
			NewQFile();
		}
		[SmokeMethod("QFile()")]
		private void NewQFile() {
			ProxyQFile().NewQFile();
		}
		public QFile(string name) : this((Type) null) {
			CreateProxy();
			NewQFile(name);
		}
		[SmokeMethod("QFile(const QString&)")]
		private void NewQFile(string name) {
			ProxyQFile().NewQFile(name);
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQFile().Name();
		}
		[SmokeMethod("setName(const QString&)")]
		public void SetName(string name) {
			ProxyQFile().SetName(name);
		}
		[SmokeMethod("exists() const")]
		public bool Exists() {
			return ProxyQFile().Exists();
		}
		[SmokeMethod("remove()")]
		public bool Remove() {
			return ProxyQFile().Remove();
		}
		[SmokeMethod("open(int)")]
		public new bool Open(int arg1) {
			return ProxyQFile().Open(arg1);
		}
		[SmokeMethod("open(int, int)")]
		public new bool Open(int arg1, int arg2) {
			return ProxyQFile().Open(arg1,arg2);
		}
		[SmokeMethod("close()")]
		public new void Close() {
			ProxyQFile().Close();
		}
		[SmokeMethod("flush()")]
		public new void Flush() {
			ProxyQFile().Flush();
		}
		[SmokeMethod("size() const")]
		public new ulong Size() {
			return ProxyQFile().Size();
		}
		[SmokeMethod("at() const")]
		public new ulong At() {
			return ProxyQFile().At();
		}
		[SmokeMethod("at(QIODevice::Offset)")]
		public new bool At(ulong arg1) {
			return ProxyQFile().At(arg1);
		}
		[SmokeMethod("atEnd() const")]
		public new bool AtEnd() {
			return ProxyQFile().AtEnd();
		}
		[SmokeMethod("readBlock(char*, Q_ULONG)")]
		public new long ReadBlock(string data, long len) {
			return ProxyQFile().ReadBlock(data,len);
		}
		[SmokeMethod("writeBlock(const char*, Q_ULONG)")]
		public new long WriteBlock(string data, long len) {
			return ProxyQFile().WriteBlock(data,len);
		}
		[SmokeMethod("writeBlock(const QByteArray&)")]
		public new long WriteBlock(QByteArray data) {
			return ProxyQFile().WriteBlock(data);
		}
		[SmokeMethod("readLine(char*, Q_ULONG)")]
		public new long ReadLine(string data, long maxlen) {
			return ProxyQFile().ReadLine(data,maxlen);
		}
		[SmokeMethod("readLine(QString&, Q_ULONG)")]
		public new long ReadLine(StringBuilder arg1, long maxlen) {
			return ProxyQFile().ReadLine(arg1,maxlen);
		}
		[SmokeMethod("getch()")]
		public new int Getch() {
			return ProxyQFile().Getch();
		}
		[SmokeMethod("putch(int)")]
		public new int Putch(int arg1) {
			return ProxyQFile().Putch(arg1);
		}
		[SmokeMethod("ungetch(int)")]
		public new int Ungetch(int arg1) {
			return ProxyQFile().Ungetch(arg1);
		}
		[SmokeMethod("handle() const")]
		public int Handle() {
			return ProxyQFile().Handle();
		}
		[SmokeMethod("errorString() const")]
		public string ErrorString() {
			return ProxyQFile().ErrorString();
		}
		[SmokeMethod("encodeName(const QString&)")]
		public static string EncodeName(string fileName) {
			return StaticQFile().EncodeName(fileName);
		}
		[SmokeMethod("decodeName(const QCString&)")]
		public static string DecodeName(string localFileName) {
			return StaticQFile().DecodeName(localFileName);
		}
		[SmokeMethod("exists(const QString&)")]
		public static bool Exists(string fileName) {
			return StaticQFile().Exists(fileName);
		}
		[SmokeMethod("remove(const QString&)")]
		public static bool Remove(string fileName) {
			return StaticQFile().Remove(fileName);
		}
		[SmokeMethod("setErrorString(const QString&)")]
		protected void SetErrorString(string arg1) {
			ProxyQFile().SetErrorString(arg1);
		}
		~QFile() {
			DisposeQFile();
		}
		public void Dispose() {
			DisposeQFile();
		}
		private void DisposeQFile() {
			ProxyQFile().DisposeQFile();
		}
	}
}
