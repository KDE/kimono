//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QUrlInfo")]
	public class QUrlInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QUrlInfo(Type dummy) {}
		interface IQUrlInfoProxy {
			[SmokeMethod("greaterThan##$", "(const QUrlInfo&, const QUrlInfo&, int)")]
			bool GreaterThan(QUrlInfo i1, QUrlInfo i2, int sortBy);
			[SmokeMethod("lessThan##$", "(const QUrlInfo&, const QUrlInfo&, int)")]
			bool LessThan(QUrlInfo i1, QUrlInfo i2, int sortBy);
			[SmokeMethod("equal##$", "(const QUrlInfo&, const QUrlInfo&, int)")]
			bool Equal(QUrlInfo i1, QUrlInfo i2, int sortBy);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QUrlInfo), this);
			_interceptor = (QUrlInfo) realProxy.GetTransparentProxy();
		}
		private QUrlInfo ProxyQUrlInfo() {
			return (QUrlInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QUrlInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQUrlInfoProxy), null);
			_staticInterceptor = (IQUrlInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQUrlInfoProxy StaticQUrlInfo() {
			return (IQUrlInfoProxy) _staticInterceptor;
		}

		public enum PermissionSpec {
			ReadOwner = 00400,
			WriteOwner = 00200,
			ExeOwner = 00100,
			ReadGroup = 00040,
			WriteGroup = 00020,
			ExeGroup = 00010,
			ReadOther = 00004,
			WriteOther = 00002,
			ExeOther = 00001,
		}
		public QUrlInfo() : this((Type) null) {
			CreateProxy();
			NewQUrlInfo();
		}
		[SmokeMethod("QUrlInfo", "()")]
		private void NewQUrlInfo() {
			ProxyQUrlInfo().NewQUrlInfo();
		}
		public QUrlInfo(QUrlInfo ui) : this((Type) null) {
			CreateProxy();
			NewQUrlInfo(ui);
		}
		[SmokeMethod("QUrlInfo#", "(const QUrlInfo&)")]
		private void NewQUrlInfo(QUrlInfo ui) {
			ProxyQUrlInfo().NewQUrlInfo(ui);
		}
		public QUrlInfo(string name, int permissions, string owner, string group, long size, QDateTime lastModified, QDateTime lastRead, bool isDir, bool isFile, bool isSymLink, bool isWritable, bool isReadable, bool isExecutable) : this((Type) null) {
			CreateProxy();
			NewQUrlInfo(name,permissions,owner,group,size,lastModified,lastRead,isDir,isFile,isSymLink,isWritable,isReadable,isExecutable);
		}
		[SmokeMethod("QUrlInfo$$$$$##$$$$$$", "(const QString&, int, const QString&, const QString&, qint64, const QDateTime&, const QDateTime&, bool, bool, bool, bool, bool, bool)")]
		private void NewQUrlInfo(string name, int permissions, string owner, string group, long size, QDateTime lastModified, QDateTime lastRead, bool isDir, bool isFile, bool isSymLink, bool isWritable, bool isReadable, bool isExecutable) {
			ProxyQUrlInfo().NewQUrlInfo(name,permissions,owner,group,size,lastModified,lastRead,isDir,isFile,isSymLink,isWritable,isReadable,isExecutable);
		}
		public QUrlInfo(IQUrl url, int permissions, string owner, string group, long size, QDateTime lastModified, QDateTime lastRead, bool isDir, bool isFile, bool isSymLink, bool isWritable, bool isReadable, bool isExecutable) : this((Type) null) {
			CreateProxy();
			NewQUrlInfo(url,permissions,owner,group,size,lastModified,lastRead,isDir,isFile,isSymLink,isWritable,isReadable,isExecutable);
		}
		[SmokeMethod("QUrlInfo#$$$$##$$$$$$", "(const QUrl&, int, const QString&, const QString&, qint64, const QDateTime&, const QDateTime&, bool, bool, bool, bool, bool, bool)")]
		private void NewQUrlInfo(IQUrl url, int permissions, string owner, string group, long size, QDateTime lastModified, QDateTime lastRead, bool isDir, bool isFile, bool isSymLink, bool isWritable, bool isReadable, bool isExecutable) {
			ProxyQUrlInfo().NewQUrlInfo(url,permissions,owner,group,size,lastModified,lastRead,isDir,isFile,isSymLink,isWritable,isReadable,isExecutable);
		}
		[SmokeMethod("setName$", "(const QString&)")]
		public virtual void SetName(string name) {
			ProxyQUrlInfo().SetName(name);
		}
		[SmokeMethod("setDir$", "(bool)")]
		public virtual void SetDir(bool b) {
			ProxyQUrlInfo().SetDir(b);
		}
		[SmokeMethod("setFile$", "(bool)")]
		public virtual void SetFile(bool b) {
			ProxyQUrlInfo().SetFile(b);
		}
		[SmokeMethod("setSymLink$", "(bool)")]
		public virtual void SetSymLink(bool b) {
			ProxyQUrlInfo().SetSymLink(b);
		}
		[SmokeMethod("setOwner$", "(const QString&)")]
		public virtual void SetOwner(string s) {
			ProxyQUrlInfo().SetOwner(s);
		}
		[SmokeMethod("setGroup$", "(const QString&)")]
		public virtual void SetGroup(string s) {
			ProxyQUrlInfo().SetGroup(s);
		}
		[SmokeMethod("setSize$", "(qint64)")]
		public virtual void SetSize(long size) {
			ProxyQUrlInfo().SetSize(size);
		}
		[SmokeMethod("setWritable$", "(bool)")]
		public virtual void SetWritable(bool b) {
			ProxyQUrlInfo().SetWritable(b);
		}
		[SmokeMethod("setReadable$", "(bool)")]
		public virtual void SetReadable(bool b) {
			ProxyQUrlInfo().SetReadable(b);
		}
		[SmokeMethod("setPermissions$", "(int)")]
		public virtual void SetPermissions(int p) {
			ProxyQUrlInfo().SetPermissions(p);
		}
		[SmokeMethod("setLastModified#", "(const QDateTime&)")]
		public virtual void SetLastModified(QDateTime dt) {
			ProxyQUrlInfo().SetLastModified(dt);
		}
		[SmokeMethod("isValid", "() const")]
		public bool IsValid() {
			return ProxyQUrlInfo().IsValid();
		}
		[SmokeMethod("name", "() const")]
		public string Name() {
			return ProxyQUrlInfo().Name();
		}
		[SmokeMethod("permissions", "() const")]
		public int Permissions() {
			return ProxyQUrlInfo().Permissions();
		}
		[SmokeMethod("owner", "() const")]
		public string Owner() {
			return ProxyQUrlInfo().Owner();
		}
		[SmokeMethod("group", "() const")]
		public string Group() {
			return ProxyQUrlInfo().Group();
		}
		[SmokeMethod("size", "() const")]
		public long Size() {
			return ProxyQUrlInfo().Size();
		}
		[SmokeMethod("lastModified", "() const")]
		public QDateTime LastModified() {
			return ProxyQUrlInfo().LastModified();
		}
		[SmokeMethod("lastRead", "() const")]
		public QDateTime LastRead() {
			return ProxyQUrlInfo().LastRead();
		}
		[SmokeMethod("isDir", "() const")]
		public bool IsDir() {
			return ProxyQUrlInfo().IsDir();
		}
		[SmokeMethod("isFile", "() const")]
		public bool IsFile() {
			return ProxyQUrlInfo().IsFile();
		}
		[SmokeMethod("isSymLink", "() const")]
		public bool IsSymLink() {
			return ProxyQUrlInfo().IsSymLink();
		}
		[SmokeMethod("isWritable", "() const")]
		public bool IsWritable() {
			return ProxyQUrlInfo().IsWritable();
		}
		[SmokeMethod("isReadable", "() const")]
		public bool IsReadable() {
			return ProxyQUrlInfo().IsReadable();
		}
		[SmokeMethod("isExecutable", "() const")]
		public bool IsExecutable() {
			return ProxyQUrlInfo().IsExecutable();
		}
		public static bool GreaterThan(QUrlInfo i1, QUrlInfo i2, int sortBy) {
			return StaticQUrlInfo().GreaterThan(i1,i2,sortBy);
		}
		public static bool LessThan(QUrlInfo i1, QUrlInfo i2, int sortBy) {
			return StaticQUrlInfo().LessThan(i1,i2,sortBy);
		}
		public static bool Equal(QUrlInfo i1, QUrlInfo i2, int sortBy) {
			return StaticQUrlInfo().Equal(i1,i2,sortBy);
		}
		~QUrlInfo() {
			DisposeQUrlInfo();
		}
		public void Dispose() {
			DisposeQUrlInfo();
		}
		[SmokeMethod("~QUrlInfo", "()")]
		private void DisposeQUrlInfo() {
			ProxyQUrlInfo().DisposeQUrlInfo();
		}
	}
}
