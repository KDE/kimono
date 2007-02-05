//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQProcessSignals"></see> for signals emitted by QProcess
	[SmokeClass("QProcess")]
	public class QProcess : QIODevice, IDisposable {
 		protected QProcess(Type dummy) : base((Type) null) {}
		[SmokeClass("QProcess")]
		interface IQProcessProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("execute", "(const QString&, const QStringList&)", "$?")]
			int Execute(string program, List<string> arguments);
			[SmokeMethod("execute", "(const QString&)", "$")]
			int Execute(string program);
			[SmokeMethod("startDetached", "(const QString&, const QStringList&)", "$?")]
			bool StartDetached(string program, List<string> arguments);
			[SmokeMethod("startDetached", "(const QString&)", "$")]
			bool StartDetached(string program);
			[SmokeMethod("systemEnvironment", "()", "")]
			List<string> SystemEnvironment();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QProcess), this);
			_interceptor = (QProcess) realProxy.GetTransparentProxy();
		}
		private QProcess ProxyQProcess() {
			return (QProcess) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QProcess() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQProcessProxy), null);
			_staticInterceptor = (IQProcessProxy) realProxy.GetTransparentProxy();
		}
		private static IQProcessProxy StaticQProcess() {
			return (IQProcessProxy) _staticInterceptor;
		}
		public enum ProcessError {
			FailedToStart = 0,
			Crashed = 1,
			Timedout = 2,
			ReadError = 3,
			WriteError = 4,
			UnknownError = 5,
		}
		public enum ProcessState {
			NotRunning = 0,
			Starting = 1,
			Running = 2,
		}
		public enum ProcessChannel {
			StandardOutput = 0,
			StandardError = 1,
		}
		public enum ProcessChannelMode {
			SeparateChannels = 0,
			MergedChannels = 1,
			ForwardedChannels = 2,
		}
		public enum ExitStatus {
			NormalExit = 0,
			CrashExit = 1,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QProcess(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQProcess(parent);
		}
		[SmokeMethod("QProcess", "(QObject*)", "#")]
		private void NewQProcess(QObject parent) {
			ProxyQProcess().NewQProcess(parent);
		}
		public QProcess() : this((Type) null) {
			CreateProxy();
			NewQProcess();
		}
		[SmokeMethod("QProcess", "()", "")]
		private void NewQProcess() {
			ProxyQProcess().NewQProcess();
		}
		[SmokeMethod("start", "(const QString&, const QStringList&, OpenMode)", "$?$")]
		public void Start(string program, List<string> arguments, int mode) {
			ProxyQProcess().Start(program,arguments,mode);
		}
		[SmokeMethod("start", "(const QString&, const QStringList&)", "$?")]
		public void Start(string program, List<string> arguments) {
			ProxyQProcess().Start(program,arguments);
		}
		[SmokeMethod("start", "(const QString&, OpenMode)", "$$")]
		public void Start(string program, int mode) {
			ProxyQProcess().Start(program,mode);
		}
		[SmokeMethod("start", "(const QString&)", "$")]
		public void Start(string program) {
			ProxyQProcess().Start(program);
		}
		[SmokeMethod("readChannelMode", "() const", "")]
		public QProcess.ProcessChannelMode ReadChannelMode() {
			return ProxyQProcess().ReadChannelMode();
		}
		[SmokeMethod("setReadChannelMode", "(QProcess::ProcessChannelMode)", "$")]
		public void SetReadChannelMode(QProcess.ProcessChannelMode mode) {
			ProxyQProcess().SetReadChannelMode(mode);
		}
		[SmokeMethod("processChannelMode", "() const", "")]
		public QProcess.ProcessChannelMode processChannelMode() {
			return ProxyQProcess().processChannelMode();
		}
		[SmokeMethod("setProcessChannelMode", "(QProcess::ProcessChannelMode)", "$")]
		public void SetProcessChannelMode(QProcess.ProcessChannelMode mode) {
			ProxyQProcess().SetProcessChannelMode(mode);
		}
		[SmokeMethod("readChannel", "() const", "")]
		public QProcess.ProcessChannel ReadChannel() {
			return ProxyQProcess().ReadChannel();
		}
		[SmokeMethod("setReadChannel", "(QProcess::ProcessChannel)", "$")]
		public void SetReadChannel(QProcess.ProcessChannel channel) {
			ProxyQProcess().SetReadChannel(channel);
		}
		[SmokeMethod("closeReadChannel", "(QProcess::ProcessChannel)", "$")]
		public void CloseReadChannel(QProcess.ProcessChannel channel) {
			ProxyQProcess().CloseReadChannel(channel);
		}
		[SmokeMethod("closeWriteChannel", "()", "")]
		public void CloseWriteChannel() {
			ProxyQProcess().CloseWriteChannel();
		}
		[SmokeMethod("setStandardInputFile", "(const QString&)", "$")]
		public void SetStandardInputFile(string fileName) {
			ProxyQProcess().SetStandardInputFile(fileName);
		}
		[SmokeMethod("setStandardOutputFile", "(const QString&, OpenMode)", "$$")]
		public void SetStandardOutputFile(string fileName, int mode) {
			ProxyQProcess().SetStandardOutputFile(fileName,mode);
		}
		[SmokeMethod("setStandardOutputFile", "(const QString&)", "$")]
		public void SetStandardOutputFile(string fileName) {
			ProxyQProcess().SetStandardOutputFile(fileName);
		}
		[SmokeMethod("setStandardErrorFile", "(const QString&, OpenMode)", "$$")]
		public void SetStandardErrorFile(string fileName, int mode) {
			ProxyQProcess().SetStandardErrorFile(fileName,mode);
		}
		[SmokeMethod("setStandardErrorFile", "(const QString&)", "$")]
		public void SetStandardErrorFile(string fileName) {
			ProxyQProcess().SetStandardErrorFile(fileName);
		}
		[SmokeMethod("setStandardOutputProcess", "(QProcess*)", "#")]
		public void SetStandardOutputProcess(QProcess destination) {
			ProxyQProcess().SetStandardOutputProcess(destination);
		}
		[SmokeMethod("workingDirectory", "() const", "")]
		public string WorkingDirectory() {
			return ProxyQProcess().WorkingDirectory();
		}
		[SmokeMethod("setWorkingDirectory", "(const QString&)", "$")]
		public void SetWorkingDirectory(string dir) {
			ProxyQProcess().SetWorkingDirectory(dir);
		}
		[SmokeMethod("setEnvironment", "(const QStringList&)", "?")]
		public void SetEnvironment(List<string> environment) {
			ProxyQProcess().SetEnvironment(environment);
		}
		[SmokeMethod("environment", "() const", "")]
		public List<string> Environment() {
			return ProxyQProcess().Environment();
		}
		[SmokeMethod("error", "() const", "")]
		public QProcess.ProcessError Error() {
			return ProxyQProcess().Error();
		}
		[SmokeMethod("state", "() const", "")]
		public QProcess.ProcessState State() {
			return ProxyQProcess().State();
		}
		// Q_PID pid(); >>>> NOT CONVERTED
		[SmokeMethod("waitForStarted", "(int)", "$")]
		public bool WaitForStarted(int msecs) {
			return ProxyQProcess().WaitForStarted(msecs);
		}
		[SmokeMethod("waitForStarted", "()", "")]
		public bool WaitForStarted() {
			return ProxyQProcess().WaitForStarted();
		}
		[SmokeMethod("waitForReadyRead", "(int)", "$")]
		public new bool WaitForReadyRead(int msecs) {
			return ProxyQProcess().WaitForReadyRead(msecs);
		}
		[SmokeMethod("waitForReadyRead", "()", "")]
		public new bool WaitForReadyRead() {
			return ProxyQProcess().WaitForReadyRead();
		}
		[SmokeMethod("waitForBytesWritten", "(int)", "$")]
		public new bool WaitForBytesWritten(int msecs) {
			return ProxyQProcess().WaitForBytesWritten(msecs);
		}
		[SmokeMethod("waitForBytesWritten", "()", "")]
		public new bool WaitForBytesWritten() {
			return ProxyQProcess().WaitForBytesWritten();
		}
		[SmokeMethod("waitForFinished", "(int)", "$")]
		public bool WaitForFinished(int msecs) {
			return ProxyQProcess().WaitForFinished(msecs);
		}
		[SmokeMethod("waitForFinished", "()", "")]
		public bool WaitForFinished() {
			return ProxyQProcess().WaitForFinished();
		}
		[SmokeMethod("readAllStandardOutput", "()", "")]
		public QByteArray ReadAllStandardOutput() {
			return ProxyQProcess().ReadAllStandardOutput();
		}
		[SmokeMethod("readAllStandardError", "()", "")]
		public QByteArray ReadAllStandardError() {
			return ProxyQProcess().ReadAllStandardError();
		}
		[SmokeMethod("exitCode", "() const", "")]
		public int ExitCode() {
			return ProxyQProcess().ExitCode();
		}
		[SmokeMethod("exitStatus", "() const", "")]
		public QProcess.ExitStatus exitStatus() {
			return ProxyQProcess().exitStatus();
		}
		[SmokeMethod("bytesAvailable", "() const", "")]
		public new long BytesAvailable() {
			return ProxyQProcess().BytesAvailable();
		}
		[SmokeMethod("bytesToWrite", "() const", "")]
		public new long BytesToWrite() {
			return ProxyQProcess().BytesToWrite();
		}
		[SmokeMethod("isSequential", "() const", "")]
		public new bool IsSequential() {
			return ProxyQProcess().IsSequential();
		}
		[SmokeMethod("canReadLine", "() const", "")]
		public new bool CanReadLine() {
			return ProxyQProcess().CanReadLine();
		}
		[SmokeMethod("close", "()", "")]
		public new void Close() {
			ProxyQProcess().Close();
		}
		[SmokeMethod("atEnd", "() const", "")]
		public new bool AtEnd() {
			return ProxyQProcess().AtEnd();
		}
		[Q_SLOT("void terminate()")]
		[SmokeMethod("terminate", "()", "")]
		public void Terminate() {
			ProxyQProcess().Terminate();
		}
		[Q_SLOT("void kill()")]
		[SmokeMethod("kill", "()", "")]
		public void Kill() {
			ProxyQProcess().Kill();
		}
		public static new string Tr(string s, string c) {
			return StaticQProcess().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQProcess().Tr(s);
		}
		public static int Execute(string program, List<string> arguments) {
			return StaticQProcess().Execute(program,arguments);
		}
		public static int Execute(string program) {
			return StaticQProcess().Execute(program);
		}
		public static bool StartDetached(string program, List<string> arguments) {
			return StaticQProcess().StartDetached(program,arguments);
		}
		public static bool StartDetached(string program) {
			return StaticQProcess().StartDetached(program);
		}
		public static List<string> SystemEnvironment() {
			return StaticQProcess().SystemEnvironment();
		}
		[SmokeMethod("setProcessState", "(QProcess::ProcessState)", "$")]
		protected void SetProcessState(QProcess.ProcessState state) {
			ProxyQProcess().SetProcessState(state);
		}
		[SmokeMethod("setupChildProcess", "()", "")]
		protected virtual void SetupChildProcess() {
			ProxyQProcess().SetupChildProcess();
		}
		[SmokeMethod("readData", "(char*, qint64)", "$$")]
		protected new long ReadData(string data, long maxlen) {
			return ProxyQProcess().ReadData(data,maxlen);
		}
		[SmokeMethod("writeData", "(const char*, qint64)", "$$")]
		protected new long WriteData(string data, long len) {
			return ProxyQProcess().WriteData(data,len);
		}
		~QProcess() {
			DisposeQProcess();
		}
		public void Dispose() {
			DisposeQProcess();
		}
		[SmokeMethod("~QProcess", "()", "")]
		private void DisposeQProcess() {
			ProxyQProcess().DisposeQProcess();
		}
		protected new IQProcessSignals Emit {
			get {
				return (IQProcessSignals) Q_EMIT;
			}
		}
	}

	public interface IQProcessSignals : IQIODeviceSignals {
		[Q_SIGNAL("void started()")]
		void Started();
		[Q_SIGNAL("void finished(int)")]
		void Finished(int exitCode);
		[Q_SIGNAL("void finished(int, QProcess::ExitStatus)")]
		void Finished(int exitCode, QProcess.ExitStatus exitStatus);
		[Q_SIGNAL("void error(QProcess::ProcessError)")]
		void Error(QProcess.ProcessError error);
		[Q_SIGNAL("void stateChanged(QProcess::ProcessState)")]
		void StateChanged(QProcess.ProcessState state);
		[Q_SIGNAL("void readyReadStandardOutput()")]
		void ReadyReadStandardOutput();
		[Q_SIGNAL("void readyReadStandardError()")]
		void ReadyReadStandardError();
	}
}
