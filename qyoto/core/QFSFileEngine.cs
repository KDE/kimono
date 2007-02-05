//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QFSFileEngine")]
	public class QFSFileEngine : QAbstractFileEngine, IDisposable {
 		protected QFSFileEngine(Type dummy) : base((Type) null) {}
		[SmokeClass("QFSFileEngine")]
		interface IQFSFileEngineProxy {
			[SmokeMethod("setCurrentPath", "(const QString&)", "$")]
			bool SetCurrentPath(string path);
			[SmokeMethod("currentPath", "(const QString&)", "$")]
			string CurrentPath(string path);
			[SmokeMethod("currentPath", "()", "")]
			string CurrentPath();
			[SmokeMethod("homePath", "()", "")]
			string HomePath();
			[SmokeMethod("rootPath", "()", "")]
			string RootPath();
			[SmokeMethod("tempPath", "()", "")]
			string TempPath();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFSFileEngine), this);
			_interceptor = (QFSFileEngine) realProxy.GetTransparentProxy();
		}
		private QFSFileEngine ProxyQFSFileEngine() {
			return (QFSFileEngine) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFSFileEngine() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFSFileEngineProxy), null);
			_staticInterceptor = (IQFSFileEngineProxy) realProxy.GetTransparentProxy();
		}
		private static IQFSFileEngineProxy StaticQFSFileEngine() {
			return (IQFSFileEngineProxy) _staticInterceptor;
		}
		public QFSFileEngine() : this((Type) null) {
			CreateProxy();
			NewQFSFileEngine();
		}
		[SmokeMethod("QFSFileEngine", "()", "")]
		private void NewQFSFileEngine() {
			ProxyQFSFileEngine().NewQFSFileEngine();
		}
		public QFSFileEngine(string file) : this((Type) null) {
			CreateProxy();
			NewQFSFileEngine(file);
		}
		[SmokeMethod("QFSFileEngine", "(const QString&)", "$")]
		private void NewQFSFileEngine(string file) {
			ProxyQFSFileEngine().NewQFSFileEngine(file);
		}
		[SmokeMethod("open", "(QIODevice::OpenMode)", "$")]
		public new bool Open(int openMode) {
			return ProxyQFSFileEngine().Open(openMode);
		}
		[SmokeMethod("close", "()", "")]
		public new bool Close() {
			return ProxyQFSFileEngine().Close();
		}
		[SmokeMethod("flush", "()", "")]
		public new bool Flush() {
			return ProxyQFSFileEngine().Flush();
		}
		[SmokeMethod("size", "() const", "")]
		public new long Size() {
			return ProxyQFSFileEngine().Size();
		}
		[SmokeMethod("pos", "() const", "")]
		public new long Pos() {
			return ProxyQFSFileEngine().Pos();
		}
		[SmokeMethod("seek", "(qint64)", "$")]
		public new bool Seek(long arg1) {
			return ProxyQFSFileEngine().Seek(arg1);
		}
		[SmokeMethod("isSequential", "() const", "")]
		public new bool IsSequential() {
			return ProxyQFSFileEngine().IsSequential();
		}
		[SmokeMethod("remove", "()", "")]
		public new bool Remove() {
			return ProxyQFSFileEngine().Remove();
		}
		[SmokeMethod("copy", "(const QString&)", "$")]
		public new bool Copy(string newName) {
			return ProxyQFSFileEngine().Copy(newName);
		}
		[SmokeMethod("rename", "(const QString&)", "$")]
		public new bool Rename(string newName) {
			return ProxyQFSFileEngine().Rename(newName);
		}
		[SmokeMethod("link", "(const QString&)", "$")]
		public new bool Link(string newName) {
			return ProxyQFSFileEngine().Link(newName);
		}
		[SmokeMethod("mkdir", "(const QString&, bool) const", "$$")]
		public new bool Mkdir(string dirName, bool createParentDirectories) {
			return ProxyQFSFileEngine().Mkdir(dirName,createParentDirectories);
		}
		[SmokeMethod("rmdir", "(const QString&, bool) const", "$$")]
		public new bool Rmdir(string dirName, bool recurseParentDirectories) {
			return ProxyQFSFileEngine().Rmdir(dirName,recurseParentDirectories);
		}
		[SmokeMethod("setSize", "(qint64)", "$")]
		public new bool SetSize(long size) {
			return ProxyQFSFileEngine().SetSize(size);
		}
		[SmokeMethod("caseSensitive", "() const", "")]
		public new bool CaseSensitive() {
			return ProxyQFSFileEngine().CaseSensitive();
		}
		[SmokeMethod("isRelativePath", "() const", "")]
		public new bool IsRelativePath() {
			return ProxyQFSFileEngine().IsRelativePath();
		}
		[SmokeMethod("entryList", "(QDir::Filters, const QStringList&) const", "$?")]
		public new List<string> EntryList(int filters, List<string> filterNames) {
			return ProxyQFSFileEngine().EntryList(filters,filterNames);
		}
		[SmokeMethod("fileFlags", "(FileFlags) const", "$")]
		public new int FileFlags(int type) {
			return ProxyQFSFileEngine().FileFlags(type);
		}
		[SmokeMethod("setPermissions", "(uint)", "$")]
		public new bool SetPermissions(uint perms) {
			return ProxyQFSFileEngine().SetPermissions(perms);
		}
		[SmokeMethod("fileName", "(QAbstractFileEngine::FileName) const", "$")]
		public new string FileName(QAbstractFileEngine.FileName file) {
			return ProxyQFSFileEngine().FileName(file);
		}
		[SmokeMethod("ownerId", "(QAbstractFileEngine::FileOwner) const", "$")]
		public new uint OwnerId(QAbstractFileEngine.FileOwner arg1) {
			return ProxyQFSFileEngine().OwnerId(arg1);
		}
		[SmokeMethod("owner", "(QAbstractFileEngine::FileOwner) const", "$")]
		public new string Owner(QAbstractFileEngine.FileOwner arg1) {
			return ProxyQFSFileEngine().Owner(arg1);
		}
		[SmokeMethod("fileTime", "(QAbstractFileEngine::FileTime) const", "$")]
		public new QDateTime FileTime(QAbstractFileEngine.FileTime time) {
			return ProxyQFSFileEngine().FileTime(time);
		}
		[SmokeMethod("setFileName", "(const QString&)", "$")]
		public new void SetFileName(string file) {
			ProxyQFSFileEngine().SetFileName(file);
		}
		// QAbstractFileEngine::Iterator* beginEntryList(QDir::Filters arg1,const QStringList& arg2); >>>> NOT CONVERTED
		// QAbstractFileEngine::Iterator* endEntryList(); >>>> NOT CONVERTED
		[SmokeMethod("read", "(char*, qint64)", "$$")]
		public new long Read(string data, long maxlen) {
			return ProxyQFSFileEngine().Read(data,maxlen);
		}
		[SmokeMethod("readLine", "(char*, qint64)", "$$")]
		public new long ReadLine(string data, long maxlen) {
			return ProxyQFSFileEngine().ReadLine(data,maxlen);
		}
		[SmokeMethod("write", "(const char*, qint64)", "$$")]
		public new long Write(string data, long len) {
			return ProxyQFSFileEngine().Write(data,len);
		}
		// bool extension(QAbstractFileEngine::Extension arg1,const QAbstractFileEngine::ExtensionOption* arg2,QAbstractFileEngine::ExtensionReturn* arg3); >>>> NOT CONVERTED
		// bool extension(QAbstractFileEngine::Extension arg1,const QAbstractFileEngine::ExtensionOption* arg2); >>>> NOT CONVERTED
		[SmokeMethod("extension", "(QAbstractFileEngine::Extension)", "$")]
		public new bool Extension(QAbstractFileEngine.Extension extension) {
			return ProxyQFSFileEngine().Extension(extension);
		}
		[SmokeMethod("supportsExtension", "(QAbstractFileEngine::Extension) const", "$")]
		public new bool SupportsExtension(QAbstractFileEngine.Extension extension) {
			return ProxyQFSFileEngine().SupportsExtension(extension);
		}
		[SmokeMethod("open", "(QIODevice::OpenMode, int)", "$$")]
		public new bool Open(int flags, int fd) {
			return ProxyQFSFileEngine().Open(flags,fd);
		}
		public static bool SetCurrentPath(string path) {
			return StaticQFSFileEngine().SetCurrentPath(path);
		}
		public static string CurrentPath(string path) {
			return StaticQFSFileEngine().CurrentPath(path);
		}
		public static string CurrentPath() {
			return StaticQFSFileEngine().CurrentPath();
		}
		public static string HomePath() {
			return StaticQFSFileEngine().HomePath();
		}
		public static string RootPath() {
			return StaticQFSFileEngine().RootPath();
		}
		public static string TempPath() {
			return StaticQFSFileEngine().TempPath();
		}
		// QFileInfoList drives(); >>>> NOT CONVERTED
		// QFSFileEngine* QFSFileEngine(QFSFileEnginePrivate& arg1); >>>> NOT CONVERTED
		~QFSFileEngine() {
			DisposeQFSFileEngine();
		}
		public new void Dispose() {
			DisposeQFSFileEngine();
		}
		[SmokeMethod("~QFSFileEngine", "()", "")]
		private void DisposeQFSFileEngine() {
			ProxyQFSFileEngine().DisposeQFSFileEngine();
		}
	}
}
