//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QAbstractFileEngine")]
	public class QAbstractFileEngine : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QAbstractFileEngine(Type dummy) {}
		[SmokeClass("QAbstractFileEngine")]
		interface IQAbstractFileEngineProxy {
			[SmokeMethod("create", "(const QString&)", "$")]
			QAbstractFileEngine Create(string fileName);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractFileEngine), this);
			_interceptor = (QAbstractFileEngine) realProxy.GetTransparentProxy();
		}
		private QAbstractFileEngine ProxyQAbstractFileEngine() {
			return (QAbstractFileEngine) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractFileEngine() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractFileEngineProxy), null);
			_staticInterceptor = (IQAbstractFileEngineProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractFileEngineProxy StaticQAbstractFileEngine() {
			return (IQAbstractFileEngineProxy) _staticInterceptor;
		}
		public enum FileFlag {
			ReadOwnerPerm = 0x4000,
			WriteOwnerPerm = 0x2000,
			ExeOwnerPerm = 0x1000,
			ReadUserPerm = 0x0400,
			WriteUserPerm = 0x0200,
			ExeUserPerm = 0x0100,
			ReadGroupPerm = 0x0040,
			WriteGroupPerm = 0x0020,
			ExeGroupPerm = 0x0010,
			ReadOtherPerm = 0x0004,
			WriteOtherPerm = 0x0002,
			ExeOtherPerm = 0x0001,
			LinkType = 0x10000,
			FileType = 0x20000,
			DirectoryType = 0x40000,
			HiddenFlag = 0x0100000,
			LocalDiskFlag = 0x0200000,
			ExistsFlag = 0x0400000,
			RootFlag = 0x0800000,
			PermsMask = 0x0000FFFF,
			TypesMask = 0x000F0000,
			FlagsMask = 0x0FF00000,
			FileInfoAll = FlagsMask|PermsMask|TypesMask,
		}
		public enum FileName {
			DefaultName = 0,
			BaseName = 1,
			PathName = 2,
			AbsoluteName = 3,
			AbsolutePathName = 4,
			LinkName = 5,
			CanonicalName = 6,
			CanonicalPathName = 7,
		}
		public enum FileOwner {
			OwnerUser = 0,
			OwnerGroup = 1,
		}
		public enum FileTime {
			CreationTime = 0,
			ModificationTime = 1,
			AccessTime = 2,
		}
		public enum Extension {
		}
		[SmokeMethod("open", "(QIODevice::OpenMode)", "$")]
		public virtual bool Open(int openMode) {
			return ProxyQAbstractFileEngine().Open(openMode);
		}
		[SmokeMethod("close", "()", "")]
		public virtual bool Close() {
			return ProxyQAbstractFileEngine().Close();
		}
		[SmokeMethod("flush", "()", "")]
		public virtual bool Flush() {
			return ProxyQAbstractFileEngine().Flush();
		}
		[SmokeMethod("size", "() const", "")]
		public virtual long Size() {
			return ProxyQAbstractFileEngine().Size();
		}
		[SmokeMethod("pos", "() const", "")]
		public virtual long Pos() {
			return ProxyQAbstractFileEngine().Pos();
		}
		[SmokeMethod("seek", "(qint64)", "$")]
		public virtual bool Seek(long pos) {
			return ProxyQAbstractFileEngine().Seek(pos);
		}
		[SmokeMethod("isSequential", "() const", "")]
		public virtual bool IsSequential() {
			return ProxyQAbstractFileEngine().IsSequential();
		}
		[SmokeMethod("remove", "()", "")]
		public virtual bool Remove() {
			return ProxyQAbstractFileEngine().Remove();
		}
		[SmokeMethod("copy", "(const QString&)", "$")]
		public virtual bool Copy(string newName) {
			return ProxyQAbstractFileEngine().Copy(newName);
		}
		[SmokeMethod("rename", "(const QString&)", "$")]
		public virtual bool Rename(string newName) {
			return ProxyQAbstractFileEngine().Rename(newName);
		}
		[SmokeMethod("link", "(const QString&)", "$")]
		public virtual bool Link(string newName) {
			return ProxyQAbstractFileEngine().Link(newName);
		}
		[SmokeMethod("mkdir", "(const QString&, bool) const", "$$")]
		public virtual bool Mkdir(string dirName, bool createParentDirectories) {
			return ProxyQAbstractFileEngine().Mkdir(dirName,createParentDirectories);
		}
		[SmokeMethod("rmdir", "(const QString&, bool) const", "$$")]
		public virtual bool Rmdir(string dirName, bool recurseParentDirectories) {
			return ProxyQAbstractFileEngine().Rmdir(dirName,recurseParentDirectories);
		}
		[SmokeMethod("setSize", "(qint64)", "$")]
		public virtual bool SetSize(long size) {
			return ProxyQAbstractFileEngine().SetSize(size);
		}
		[SmokeMethod("caseSensitive", "() const", "")]
		public virtual bool CaseSensitive() {
			return ProxyQAbstractFileEngine().CaseSensitive();
		}
		[SmokeMethod("isRelativePath", "() const", "")]
		public virtual bool IsRelativePath() {
			return ProxyQAbstractFileEngine().IsRelativePath();
		}
		[SmokeMethod("entryList", "(QDir::Filters, const QStringList&) const", "$?")]
		public virtual List<string> EntryList(int filters, List<string> filterNames) {
			return ProxyQAbstractFileEngine().EntryList(filters,filterNames);
		}
		[SmokeMethod("fileFlags", "(FileFlags) const", "$")]
		public virtual int FileFlags(int type) {
			return ProxyQAbstractFileEngine().FileFlags(type);
		}
		[SmokeMethod("fileFlags", "() const", "")]
		public virtual int FileFlags() {
			return ProxyQAbstractFileEngine().FileFlags();
		}
		[SmokeMethod("setPermissions", "(uint)", "$")]
		public virtual bool SetPermissions(uint perms) {
			return ProxyQAbstractFileEngine().SetPermissions(perms);
		}
		[SmokeMethod("fileName", "(QAbstractFileEngine::FileName) const", "$")]
		public virtual string fileName(QAbstractFileEngine.FileName file) {
			return ProxyQAbstractFileEngine().fileName(file);
		}
		[SmokeMethod("fileName", "() const", "")]
		public virtual string fileName() {
			return ProxyQAbstractFileEngine().fileName();
		}
		[SmokeMethod("ownerId", "(QAbstractFileEngine::FileOwner) const", "$")]
		public virtual uint OwnerId(QAbstractFileEngine.FileOwner arg1) {
			return ProxyQAbstractFileEngine().OwnerId(arg1);
		}
		[SmokeMethod("owner", "(QAbstractFileEngine::FileOwner) const", "$")]
		public virtual string Owner(QAbstractFileEngine.FileOwner arg1) {
			return ProxyQAbstractFileEngine().Owner(arg1);
		}
		[SmokeMethod("fileTime", "(QAbstractFileEngine::FileTime) const", "$")]
		public virtual QDateTime fileTime(QAbstractFileEngine.FileTime time) {
			return ProxyQAbstractFileEngine().fileTime(time);
		}
		[SmokeMethod("setFileName", "(const QString&)", "$")]
		public virtual void SetFileName(string file) {
			ProxyQAbstractFileEngine().SetFileName(file);
		}
		// QAbstractFileEngine::Iterator* beginEntryList(QDir::Filters arg1,const QStringList& arg2); >>>> NOT CONVERTED
		// QAbstractFileEngine::Iterator* endEntryList(); >>>> NOT CONVERTED
		[SmokeMethod("read", "(char*, qint64)", "$$")]
		public virtual long Read(string data, long maxlen) {
			return ProxyQAbstractFileEngine().Read(data,maxlen);
		}
		[SmokeMethod("readLine", "(char*, qint64)", "$$")]
		public virtual long ReadLine(string data, long maxlen) {
			return ProxyQAbstractFileEngine().ReadLine(data,maxlen);
		}
		[SmokeMethod("write", "(const char*, qint64)", "$$")]
		public virtual long Write(string data, long len) {
			return ProxyQAbstractFileEngine().Write(data,len);
		}
		[SmokeMethod("error", "() const", "")]
		public QFile.FileError Error() {
			return ProxyQAbstractFileEngine().Error();
		}
		[SmokeMethod("errorString", "() const", "")]
		public string ErrorString() {
			return ProxyQAbstractFileEngine().ErrorString();
		}
		// bool extension(QAbstractFileEngine::Extension arg1,const QAbstractFileEngine::ExtensionOption* arg2,QAbstractFileEngine::ExtensionReturn* arg3); >>>> NOT CONVERTED
		// bool extension(QAbstractFileEngine::Extension arg1,const QAbstractFileEngine::ExtensionOption* arg2); >>>> NOT CONVERTED
		[SmokeMethod("extension", "(QAbstractFileEngine::Extension)", "$")]
		public virtual bool extension(QAbstractFileEngine.Extension extension) {
			return ProxyQAbstractFileEngine().extension(extension);
		}
		[SmokeMethod("supportsExtension", "(QAbstractFileEngine::Extension) const", "$")]
		public virtual bool SupportsExtension(QAbstractFileEngine.Extension extension) {
			return ProxyQAbstractFileEngine().SupportsExtension(extension);
		}
		public static QAbstractFileEngine Create(string fileName) {
			return StaticQAbstractFileEngine().Create(fileName);
		}
		[SmokeMethod("setError", "(QFile::FileError, const QString&)", "$$")]
		protected void SetError(QFile.FileError error, string str) {
			ProxyQAbstractFileEngine().SetError(error,str);
		}
		public QAbstractFileEngine() : this((Type) null) {
			CreateProxy();
			NewQAbstractFileEngine();
		}
		[SmokeMethod("QAbstractFileEngine", "()", "")]
		private void NewQAbstractFileEngine() {
			ProxyQAbstractFileEngine().NewQAbstractFileEngine();
		}
		// QAbstractFileEngine* QAbstractFileEngine(QAbstractFileEnginePrivate& arg1); >>>> NOT CONVERTED
		~QAbstractFileEngine() {
			DisposeQAbstractFileEngine();
		}
		public void Dispose() {
			DisposeQAbstractFileEngine();
		}
		[SmokeMethod("~QAbstractFileEngine", "()", "")]
		private void DisposeQAbstractFileEngine() {
			ProxyQAbstractFileEngine().DisposeQAbstractFileEngine();
		}
	}
}
