//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  KArchive is a base class for reading and writing archives.
	/// </remarks>		<author> David Faure <faure@kde.org>
	///  </author>
	/// 		<short> generic class for reading/writing archives.</short>
	[SmokeClass("KArchive")]
	public abstract class KArchive : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KArchive(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KArchive), this);
		}
		public const int UnknownTime = -1;

		/// <remarks>
		///  Opens the archive for reading or writing.
		///  Inherited classes might want to reimplement openArchive instead.
		/// <param> name="mode" may be QIODevice.ReadOnly or QIODevice.WriteOnly
		/// </param></remarks>		<short>    Opens the archive for reading or writing.</short>
		/// 		<see> close</see>
		[SmokeMethod("open(QIODevice::OpenMode)")]
		public virtual bool Open(uint mode) {
			return (bool) interceptor.Invoke("open$", "open(QIODevice::OpenMode)", typeof(bool), typeof(uint), mode);
		}
		/// <remarks>
		///  Closes the archive.
		///  Inherited classes might want to reimplement closeArchive instead.
		/// </remarks>		<return> true if close succeeded without problems
		/// </return>
		/// 		<short>    Closes the archive.</short>
		/// 		<see> open</see>
		[SmokeMethod("close()")]
		public virtual bool Close() {
			return (bool) interceptor.Invoke("close", "close()", typeof(bool));
		}
		/// <remarks>
		///  Checks whether the archive is open.
		/// </remarks>		<return> true if the archive is opened
		///      </return>
		/// 		<short>    Checks whether the archive is open.</short>
		public bool IsOpen() {
			return (bool) interceptor.Invoke("isOpen", "isOpen() const", typeof(bool));
		}
		/// <remarks>
		///  Returns the mode in which the archive was opened
		/// </remarks>		<return> the mode in which the archive was opened (QIODevice.ReadOnly or QIODevice.WriteOnly)
		/// </return>
		/// 		<short>    Returns the mode in which the archive was opened </short>
		/// 		<see> open</see>
		public uint Mode() {
			return (uint) interceptor.Invoke("mode", "mode() const", typeof(uint));
		}
		/// <remarks>
		///  The underlying device.
		/// </remarks>		<return> the underlying device.
		///      </return>
		/// 		<short>    The underlying device.</short>
		public QIODevice Device() {
			return (QIODevice) interceptor.Invoke("device", "device() const", typeof(QIODevice));
		}
		/// <remarks>
		///  The name of the archive file, as passed to the constructor that takes a
		///  fileName, or an empty string if you used the QIODevice constructor.
		/// </remarks>		<return> the name of the file, or string() if unknown
		///      </return>
		/// 		<short>    The name of the archive file, as passed to the constructor that takes a  fileName, or an empty string if you used the QIODevice constructor.</short>
		public string FileName() {
			return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
		}
		/// <remarks>
		///  If an archive is opened for reading, then the contents
		///  of the archive can be accessed via this function.
		/// </remarks>		<return> the directory of the archive
		///      </return>
		/// 		<short>    If an archive is opened for reading, then the contents  of the archive can be accessed via this function.</short>
		public KArchiveDirectory Directory() {
			return (KArchiveDirectory) interceptor.Invoke("directory", "directory() const", typeof(KArchiveDirectory));
		}
		/// <remarks>
		///  Writes a local file into the archive. The main difference with writeFile,
		///  is that this method minimizes memory usage, by not loading the whole file
		///  into memory in one go.
		///  If <code>fileName</code> is a symbolic link, it will be written as is, i. e.
		///  it will not be resolved before.
		/// <param> name="fileName" full path to an existing local file, to be added to the archive.
		/// </param><param> name="destName" the resulting name (or relative path) of the file in the archive.
		///      </param></remarks>		<short>    Writes a local file into the archive.</short>
		public bool AddLocalFile(string fileName, string destName) {
			return (bool) interceptor.Invoke("addLocalFile$$", "addLocalFile(const QString&, const QString&)", typeof(bool), typeof(string), fileName, typeof(string), destName);
		}
		/// <remarks>
		///  Writes a local directory into the archive, including all its contents, recursively.
		///  Calls addLocalFile for each file to be added.
		///  Since KDE 3.2 it will also add a <code>path</code> that is a symbolic link to a
		///  directory. The symbolic link will be dereferenced and the content of the
		///  directory it is pointing to added recursively. However, symbolic links
		///  under <code>path</code> will be stored as is.
		/// <param> name="path" full path to an existing local directory, to be added to the archive.
		/// </param><param> name="destName" the resulting name (or relative path) of the file in the archive.
		///      </param></remarks>		<short>    Writes a local directory into the archive, including all its contents, recursively.</short>
		public bool AddLocalDirectory(string path, string destName) {
			return (bool) interceptor.Invoke("addLocalDirectory$$", "addLocalDirectory(const QString&, const QString&)", typeof(bool), typeof(string), path, typeof(string), destName);
		}
		/// <remarks>
		///  If an archive is opened for writing then you can add new directories
		///  using this function. KArchive won't write one directory twice.
		///  This method also allows some file metadata to be set.
		///  However, depending on the archive type not all metadata might be regarded.
		/// <param> name="name" the name of the directory
		/// </param><param> name="user" the user that owns the directory
		/// </param><param> name="group" the group that owns the directory
		/// </param><param> name="perm" permissions of the directory
		/// </param><param> name="atime" time the file was last accessed
		/// </param><param> name="mtime" modification time of the file
		/// </param><param> name="ctime" time of last status change
		///      </param></remarks>		<short>    If an archive is opened for writing then you can add new directories  using this function.</short>
		[SmokeMethod("writeDir(const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)")]
		public virtual bool WriteDir(string name, string user, string group, long perm, int atime, int mtime, int ctime) {
			return (bool) interceptor.Invoke("writeDir$$$$$$$", "writeDir(const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime, typeof(int), mtime, typeof(int), ctime);
		}
		[SmokeMethod("writeDir(const QString&, const QString&, const QString&, mode_t, time_t, time_t)")]
		public virtual bool WriteDir(string name, string user, string group, long perm, int atime, int mtime) {
			return (bool) interceptor.Invoke("writeDir$$$$$$", "writeDir(const QString&, const QString&, const QString&, mode_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime, typeof(int), mtime);
		}
		[SmokeMethod("writeDir(const QString&, const QString&, const QString&, mode_t, time_t)")]
		public virtual bool WriteDir(string name, string user, string group, long perm, int atime) {
			return (bool) interceptor.Invoke("writeDir$$$$$", "writeDir(const QString&, const QString&, const QString&, mode_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime);
		}
		[SmokeMethod("writeDir(const QString&, const QString&, const QString&, mode_t)")]
		public virtual bool WriteDir(string name, string user, string group, long perm) {
			return (bool) interceptor.Invoke("writeDir$$$$", "writeDir(const QString&, const QString&, const QString&, mode_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), perm);
		}
		[SmokeMethod("writeDir(const QString&, const QString&, const QString&)")]
		public virtual bool WriteDir(string name, string user, string group) {
			return (bool) interceptor.Invoke("writeDir$$$", "writeDir(const QString&, const QString&, const QString&)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group);
		}
		/// <remarks>
		///  Writes a symbolic link to the archive if supported.
		///  The archive must be opened for writing.
		/// <param> name="name" name of symbolic link
		/// </param><param> name="target" target of symbolic link
		/// </param><param> name="user" the user that owns the directory
		/// </param><param> name="group" the group that owns the directory
		/// </param><param> name="perm" permissions of the directory
		/// </param><param> name="atime" time the file was last accessed
		/// </param><param> name="mtime" modification time of the file
		/// </param><param> name="ctime" time of last status change
		///      </param></remarks>		<short>    Writes a symbolic link to the archive if supported.</short>
		[SmokeMethod("writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)")]
		public virtual bool WriteSymLink(string name, string target, string user, string group, long perm, int atime, int mtime, int ctime) {
			return (bool) interceptor.Invoke("writeSymLink$$$$$$$$", "writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), target, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime, typeof(int), mtime, typeof(int), ctime);
		}
		[SmokeMethod("writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t, time_t)")]
		public virtual bool WriteSymLink(string name, string target, string user, string group, long perm, int atime, int mtime) {
			return (bool) interceptor.Invoke("writeSymLink$$$$$$$", "writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), target, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime, typeof(int), mtime);
		}
		[SmokeMethod("writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t)")]
		public virtual bool WriteSymLink(string name, string target, string user, string group, long perm, int atime) {
			return (bool) interceptor.Invoke("writeSymLink$$$$$$", "writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t)", typeof(bool), typeof(string), name, typeof(string), target, typeof(string), user, typeof(string), group, typeof(long), perm, typeof(int), atime);
		}
		[SmokeMethod("writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t)")]
		public virtual bool WriteSymLink(string name, string target, string user, string group, long perm) {
			return (bool) interceptor.Invoke("writeSymLink$$$$$", "writeSymLink(const QString&, const QString&, const QString&, const QString&, mode_t)", typeof(bool), typeof(string), name, typeof(string), target, typeof(string), user, typeof(string), group, typeof(long), perm);
		}
		[SmokeMethod("writeSymLink(const QString&, const QString&, const QString&, const QString&)")]
		public virtual bool WriteSymLink(string name, string target, string user, string group) {
			return (bool) interceptor.Invoke("writeSymLink$$$$", "writeSymLink(const QString&, const QString&, const QString&, const QString&)", typeof(bool), typeof(string), name, typeof(string), target, typeof(string), user, typeof(string), group);
		}
		/// <remarks>
		///  If an archive is opened for writing then you can add a new file
		///  using this function. If the file name is for example "mydir/test1" then
		///  the directory "mydir" is automatically appended first if that did not
		///  happen yet.
		///  This method also allows some file metadata to be
		///  set. However, depending on the archive type not all metadata might be
		///  regarded.
		/// <param> name="name" the name of the file
		/// </param><param> name="user" the user that owns the file
		/// </param><param> name="group" the group that owns the file
		/// </param><param> name="data" the data to write (<code>size</code> bytes)
		/// </param><param> name="size" the size of the file
		/// </param><param> name="perm" permissions of the file
		/// </param><param> name="atime" time the file was last accessed
		/// </param><param> name="mtime" modification time of the file
		/// </param><param> name="ctime" time of last status change
		///      </param></remarks>		<short>    If an archive is opened for writing then you can add a new file  using this function.</short>
		[SmokeMethod("writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t, time_t, time_t, time_t)")]
		public virtual bool WriteFile(string name, string user, string group, string data, long size, long perm, int atime, int mtime, int ctime) {
			return (bool) interceptor.Invoke("writeFile$$$$$$$$$", "writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t, time_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(string), data, typeof(long), size, typeof(long), perm, typeof(int), atime, typeof(int), mtime, typeof(int), ctime);
		}
		[SmokeMethod("writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t, time_t, time_t)")]
		public virtual bool WriteFile(string name, string user, string group, string data, long size, long perm, int atime, int mtime) {
			return (bool) interceptor.Invoke("writeFile$$$$$$$$", "writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(string), data, typeof(long), size, typeof(long), perm, typeof(int), atime, typeof(int), mtime);
		}
		[SmokeMethod("writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t, time_t)")]
		public virtual bool WriteFile(string name, string user, string group, string data, long size, long perm, int atime) {
			return (bool) interceptor.Invoke("writeFile$$$$$$$", "writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(string), data, typeof(long), size, typeof(long), perm, typeof(int), atime);
		}
		[SmokeMethod("writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t)")]
		public virtual bool WriteFile(string name, string user, string group, string data, long size, long perm) {
			return (bool) interceptor.Invoke("writeFile$$$$$$", "writeFile(const QString&, const QString&, const QString&, const char*, qint64, mode_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(string), data, typeof(long), size, typeof(long), perm);
		}
		[SmokeMethod("writeFile(const QString&, const QString&, const QString&, const char*, qint64)")]
		public virtual bool WriteFile(string name, string user, string group, string data, long size) {
			return (bool) interceptor.Invoke("writeFile$$$$$", "writeFile(const QString&, const QString&, const QString&, const char*, qint64)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(string), data, typeof(long), size);
		}
		/// <remarks>
		///  Here's another way of writing a file into an archive:
		///  Call prepareWriting(), then call writeData()
		///  as many times as wanted then call finishWriting( totalSize ).
		///  For tar.gz files, you need to know the size before hand, it is needed in the header!
		///  For zip files, size isn't used.
		///  This method also allows some file metadata to be
		///  set. However, depending on the archive type not all metadata might be
		///  regarded.
		/// <param> name="name" the name of the file
		/// </param><param> name="user" the user that owns the file
		/// </param><param> name="group" the group that owns the file
		/// </param><param> name="size" the size of the file
		/// </param><param> name="perm" permissions of the file
		/// </param><param> name="atime" time the file was last accessed
		/// </param><param> name="mtime" modification time of the file
		/// </param><param> name="ctime" time of last status change
		///      </param></remarks>		<short>    Here's another way of writing a file into an archive:  Call prepareWriting(), then call writeData()  as many times as wanted then call finishWriting( totalSize ).</short>
		[SmokeMethod("prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t, time_t, time_t)")]
		public virtual bool PrepareWriting(string name, string user, string group, long size, long perm, int atime, int mtime, int ctime) {
			return (bool) interceptor.Invoke("prepareWriting$$$$$$$$", "prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), size, typeof(long), perm, typeof(int), atime, typeof(int), mtime, typeof(int), ctime);
		}
		[SmokeMethod("prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t, time_t)")]
		public virtual bool PrepareWriting(string name, string user, string group, long size, long perm, int atime, int mtime) {
			return (bool) interceptor.Invoke("prepareWriting$$$$$$$", "prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), size, typeof(long), perm, typeof(int), atime, typeof(int), mtime);
		}
		[SmokeMethod("prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t)")]
		public virtual bool PrepareWriting(string name, string user, string group, long size, long perm, int atime) {
			return (bool) interceptor.Invoke("prepareWriting$$$$$$", "prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), size, typeof(long), perm, typeof(int), atime);
		}
		[SmokeMethod("prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t)")]
		public virtual bool PrepareWriting(string name, string user, string group, long size, long perm) {
			return (bool) interceptor.Invoke("prepareWriting$$$$$", "prepareWriting(const QString&, const QString&, const QString&, qint64, mode_t)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), size, typeof(long), perm);
		}
		[SmokeMethod("prepareWriting(const QString&, const QString&, const QString&, qint64)")]
		public virtual bool PrepareWriting(string name, string user, string group, long size) {
			return (bool) interceptor.Invoke("prepareWriting$$$$", "prepareWriting(const QString&, const QString&, const QString&, qint64)", typeof(bool), typeof(string), name, typeof(string), user, typeof(string), group, typeof(long), size);
		}
		/// <remarks>
		///  Write data into the current file - to be called after calling prepareWriting
		///      </remarks>		<short>    Write data into the current file - to be called after calling prepareWriting      </short>
		[SmokeMethod("writeData(const char*, qint64)")]
		public virtual bool WriteData(string data, long size) {
			return (bool) interceptor.Invoke("writeData$$", "writeData(const char*, qint64)", typeof(bool), typeof(string), data, typeof(long), size);
		}
		/// <remarks>
		///  Call finishWriting after writing the data.
		/// <param> name="size" the size of the file
		/// </param></remarks>		<short>    Call finishWriting after writing the data.</short>
		/// 		<see> prepareWriting</see>
		[SmokeMethod("finishWriting(qint64)")]
		public virtual bool FinishWriting(long size) {
			return (bool) interceptor.Invoke("finishWriting$", "finishWriting(qint64)", typeof(bool), typeof(long), size);
		}
		/// <remarks>
		///  Base constructor (protected since this is a pure class).
		/// <param> name="fileName" is a local path (e.g. "/tmp/myfile.ext"),
		///  from which the archive will be read from, or into which the archive
		///  will be written, depending on the mode given to open().
		///      </param></remarks>		<short>    Base constructor (protected since this is a pure virtual class).</short>
		public KArchive(string fileName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KArchive$", "KArchive(const QString&)", typeof(void), typeof(string), fileName);
		}
		/// <remarks>
		///  Base constructor (protected since this is a pure class).
		/// <param> name="dev" the I/O device where the archive reads its data
		///  Note that this can be a file, but also a data buffer, a compression filter, etc.
		///  For a file in writing mode it is better to use the other constructor
		///  though, to benefit from the use of KSaveFile when saving.
		///      </param></remarks>		<short>    Base constructor (protected since this is a pure virtual class).</short>
		public KArchive(QIODevice dev) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KArchive#", "KArchive(QIODevice*)", typeof(void), typeof(QIODevice), dev);
		}
		/// <remarks>
		///  Opens an archive for reading or writing.
		///  Called by open.
		/// <param> name="mode" may be QIODevice.ReadOnly or QIODevice.WriteOnly
		///      </param></remarks>		<short>    Opens an archive for reading or writing.</short>
		[SmokeMethod("openArchive(QIODevice::OpenMode)")]
		protected abstract bool OpenArchive(uint mode);
		/// <remarks>
		///  Closes the archive.
		///  Called by close.
		///      </remarks>		<short>    Closes the archive.</short>
		[SmokeMethod("closeArchive()")]
		protected abstract bool CloseArchive();
		/// <remarks>
		///  Retrieves or create the root directory.
		///  The default implementation assumes that openArchive() did the parsing,
		///  so it creates a dummy rootdir if none was set (write mode, or no '/' in the archive).
		///  Reimplement this to provide parsing/listing on demand.
		/// </remarks>		<return> the root directory
		///      </return>
		/// 		<short>    Retrieves or create the root directory.</short>
		[SmokeMethod("rootDir()")]
		protected virtual KArchiveDirectory RootDir() {
			return (KArchiveDirectory) interceptor.Invoke("rootDir", "rootDir()", typeof(KArchiveDirectory));
		}
		/// <remarks>
		///  Write a directory to the archive.
		///  This method must be implemented by subclasses.
		///  Depending on the archive type not all metadata might be used.
		/// <param> name="name" the name of the directory
		/// </param><param> name="user" the user that owns the directory
		/// </param><param> name="group" the group that owns the directory
		/// </param><param> name="perm" permissions of the directory. Use 040755 if you don't have any other information.
		/// </param><param> name="atime" time the file was last accessed
		/// </param><param> name="mtime" modification time of the file
		/// </param><param> name="ctime" time of last status change
		/// </param></remarks>		<short>    Write a directory to the archive.</short>
		/// 		<see> writeDir</see>
		[SmokeMethod("doWriteDir(const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)")]
		protected abstract bool DoWriteDir(string name, string user, string group, long perm, int atime, int mtime, int ctime);
		/// <remarks>
		///  Writes a symbolic link to the archive.
		///  This method must be implemented by subclasses.
		/// <param> name="name" name of symbolic link
		/// </param><param> name="target" target of symbolic link
		/// </param><param> name="user" the user that owns the directory
		/// </param><param> name="group" the group that owns the directory
		/// </param><param> name="perm" permissions of the directory
		/// </param><param> name="atime" time the file was last accessed
		/// </param><param> name="mtime" modification time of the file
		/// </param><param> name="ctime" time of last status change
		/// </param></remarks>		<short>    Writes a symbolic link to the archive.</short>
		/// 		<see> writeSymLink</see>
		[SmokeMethod("doWriteSymLink(const QString&, const QString&, const QString&, const QString&, mode_t, time_t, time_t, time_t)")]
		protected abstract bool DoWriteSymLink(string name, string target, string user, string group, long perm, int atime, int mtime, int ctime);
		/// <remarks>
		///  This method must be implemented by subclasses.
		///  Depending on the archive type not all metadata might be used.
		/// <param> name="name" the name of the file
		/// </param><param> name="user" the user that owns the file
		/// </param><param> name="group" the group that owns the file
		/// </param><param> name="size" the size of the file
		/// </param><param> name="perm" permissions of the file. Use 0100644 if you don't have any more specific permissions to set.
		/// </param><param> name="atime" time the file was last accessed
		/// </param><param> name="mtime" modification time of the file
		/// </param><param> name="ctime" time of last status change
		/// </param></remarks>		<short>    This virtual method must be implemented by subclasses.</short>
		/// 		<see> prepareWriting</see>
		[SmokeMethod("doPrepareWriting(const QString&, const QString&, const QString&, qint64, mode_t, time_t, time_t, time_t)")]
		protected abstract bool DoPrepareWriting(string name, string user, string group, long size, long perm, int atime, int mtime, int ctime);
		/// <remarks>
		///  Called after writing the data.
		///  This method must be implemented by subclasses.
		/// <param> name="size" the size of the file
		/// </param></remarks>		<short>    Called after writing the data.</short>
		/// 		<see> finishWriting</see>
		[SmokeMethod("doFinishWriting(qint64)")]
		protected abstract bool DoFinishWriting(long size);
		/// <remarks>
		///  Ensures that <code>path</code> exists, create otherwise.
		///  This handles e.g. tar files missing directory entries, like mico-2.3.0.tar.gz :)
		/// <param> name="path" the path of the directory
		/// </param></remarks>		<return> the directory with the given <code>path</code>
		///      </return>
		/// 		<short>    Ensures that <code>path</code> exists, create otherwise.</short>
		protected KArchiveDirectory FindOrCreate(string path) {
			return (KArchiveDirectory) interceptor.Invoke("findOrCreate$", "findOrCreate(const QString&)", typeof(KArchiveDirectory), typeof(string), path);
		}
		/// <remarks>
		///  Can be reimplemented in order to change the creation of the device
		///  (when using the fileName constructor). By default this method uses
		///  KSaveFile when saving, and a simple QFile on reading.
		///  This method is called by open().
		///      </remarks>		<short>    Can be reimplemented in order to change the creation of the device  (when using the fileName constructor).</short>
		[SmokeMethod("createDevice(QIODevice::OpenMode)")]
		protected virtual bool CreateDevice(uint mode) {
			return (bool) interceptor.Invoke("createDevice$", "createDevice(QIODevice::OpenMode)", typeof(bool), typeof(uint), mode);
		}
		/// <remarks>
		///  Can be called by derived classes in order to set the underlying device.
		///  Note that KArchive will -not- own the device, it must be deleted by the derived class.
		///      </remarks>		<short>    Can be called by derived classes in order to set the underlying device.</short>
		protected void SetDevice(QIODevice dev) {
			interceptor.Invoke("setDevice#", "setDevice(QIODevice*)", typeof(void), typeof(QIODevice), dev);
		}
		/// <remarks>
		///  Derived classes call setRootDir from openArchive,
		///  to set the root directory after parsing an existing archive.
		///      </remarks>		<short>    Derived classes call setRootDir from openArchive,  to set the root directory after parsing an existing archive.</short>
		protected void SetRootDir(KArchiveDirectory rootDir) {
			interceptor.Invoke("setRootDir#", "setRootDir(KArchiveDirectory*)", typeof(void), typeof(KArchiveDirectory), rootDir);
		}
	}
}
