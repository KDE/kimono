//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QSqlDatabase")]
	public class QSqlDatabase : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QSqlDatabase(Type dummy) {}
		interface IQSqlDatabaseProxy {
			QSqlDatabase AddDatabase(string type, string connectionName);
			QSqlDatabase AddDatabase(string type);
			QSqlDatabase AddDatabase(QSqlDriver driver, string connectionName);
			QSqlDatabase AddDatabase(QSqlDriver driver);
			QSqlDatabase CloneDatabase(QSqlDatabase other, string connectionName);
			QSqlDatabase Database(string connectionName, bool open);
			QSqlDatabase Database(string connectionName);
			QSqlDatabase Database();
			void RemoveDatabase(string connectionName);
			bool Contains(string connectionName);
			bool Contains();
			List<string> Drivers();
			List<string> ConnectionNames();
			bool IsDriverAvailable(string name);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlDatabase), this);
			_interceptor = (QSqlDatabase) realProxy.GetTransparentProxy();
		}
		private QSqlDatabase ProxyQSqlDatabase() {
			return (QSqlDatabase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlDatabase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlDatabaseProxy), null);
			_staticInterceptor = (IQSqlDatabaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlDatabaseProxy StaticQSqlDatabase() {
			return (IQSqlDatabaseProxy) _staticInterceptor;
		}

		public QSqlDatabase() : this((Type) null) {
			CreateProxy();
			NewQSqlDatabase();
		}
		[SmokeMethod("QSqlDatabase()")]
		private void NewQSqlDatabase() {
			ProxyQSqlDatabase().NewQSqlDatabase();
		}
		public QSqlDatabase(QSqlDatabase other) : this((Type) null) {
			CreateProxy();
			NewQSqlDatabase(other);
		}
		[SmokeMethod("QSqlDatabase(const QSqlDatabase&)")]
		private void NewQSqlDatabase(QSqlDatabase other) {
			ProxyQSqlDatabase().NewQSqlDatabase(other);
		}
		[SmokeMethod("open()")]
		public bool Open() {
			return ProxyQSqlDatabase().Open();
		}
		[SmokeMethod("open(const QString&, const QString&)")]
		public bool Open(string user, string password) {
			return ProxyQSqlDatabase().Open(user,password);
		}
		[SmokeMethod("close()")]
		public void Close() {
			ProxyQSqlDatabase().Close();
		}
		[SmokeMethod("isOpen() const")]
		public bool IsOpen() {
			return ProxyQSqlDatabase().IsOpen();
		}
		[SmokeMethod("isOpenError() const")]
		public bool IsOpenError() {
			return ProxyQSqlDatabase().IsOpenError();
		}
		[SmokeMethod("tables(QSql::TableType) const")]
		public List<string> Tables(QSql.TableType type) {
			return ProxyQSqlDatabase().Tables(type);
		}
		[SmokeMethod("tables() const")]
		public List<string> Tables() {
			return ProxyQSqlDatabase().Tables();
		}
		[SmokeMethod("primaryIndex(const QString&) const")]
		public QSqlIndex PrimaryIndex(string tablename) {
			return ProxyQSqlDatabase().PrimaryIndex(tablename);
		}
		[SmokeMethod("record(const QString&) const")]
		public QSqlRecord Record(string tablename) {
			return ProxyQSqlDatabase().Record(tablename);
		}
		[SmokeMethod("exec(const QString&) const")]
		public IQSqlQuery Exec(string query) {
			return ProxyQSqlDatabase().Exec(query);
		}
		[SmokeMethod("exec() const")]
		public IQSqlQuery Exec() {
			return ProxyQSqlDatabase().Exec();
		}
		[SmokeMethod("lastError() const")]
		public QSqlError LastError() {
			return ProxyQSqlDatabase().LastError();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQSqlDatabase().IsValid();
		}
		[SmokeMethod("transaction()")]
		public bool Transaction() {
			return ProxyQSqlDatabase().Transaction();
		}
		[SmokeMethod("commit()")]
		public bool Commit() {
			return ProxyQSqlDatabase().Commit();
		}
		[SmokeMethod("rollback()")]
		public bool Rollback() {
			return ProxyQSqlDatabase().Rollback();
		}
		[SmokeMethod("setDatabaseName(const QString&)")]
		public void SetDatabaseName(string name) {
			ProxyQSqlDatabase().SetDatabaseName(name);
		}
		[SmokeMethod("setUserName(const QString&)")]
		public void SetUserName(string name) {
			ProxyQSqlDatabase().SetUserName(name);
		}
		[SmokeMethod("setPassword(const QString&)")]
		public void SetPassword(string password) {
			ProxyQSqlDatabase().SetPassword(password);
		}
		[SmokeMethod("setHostName(const QString&)")]
		public void SetHostName(string host) {
			ProxyQSqlDatabase().SetHostName(host);
		}
		[SmokeMethod("setPort(int)")]
		public void SetPort(int p) {
			ProxyQSqlDatabase().SetPort(p);
		}
		[SmokeMethod("setConnectOptions(const QString&)")]
		public void SetConnectOptions(string options) {
			ProxyQSqlDatabase().SetConnectOptions(options);
		}
		[SmokeMethod("setConnectOptions()")]
		public void SetConnectOptions() {
			ProxyQSqlDatabase().SetConnectOptions();
		}
		[SmokeMethod("databaseName() const")]
		public string DatabaseName() {
			return ProxyQSqlDatabase().DatabaseName();
		}
		[SmokeMethod("userName() const")]
		public string UserName() {
			return ProxyQSqlDatabase().UserName();
		}
		[SmokeMethod("password() const")]
		public string Password() {
			return ProxyQSqlDatabase().Password();
		}
		[SmokeMethod("hostName() const")]
		public string HostName() {
			return ProxyQSqlDatabase().HostName();
		}
		[SmokeMethod("driverName() const")]
		public string DriverName() {
			return ProxyQSqlDatabase().DriverName();
		}
		[SmokeMethod("port() const")]
		public int Port() {
			return ProxyQSqlDatabase().Port();
		}
		[SmokeMethod("connectOptions() const")]
		public string ConnectOptions() {
			return ProxyQSqlDatabase().ConnectOptions();
		}
		[SmokeMethod("driver() const")]
		public QSqlDriver Driver() {
			return ProxyQSqlDatabase().Driver();
		}
		[SmokeMethod("addDatabase(const QString&, const QString&)")]
		public static QSqlDatabase AddDatabase(string type, string connectionName) {
			return StaticQSqlDatabase().AddDatabase(type,connectionName);
		}
		[SmokeMethod("addDatabase(const QString&)")]
		public static QSqlDatabase AddDatabase(string type) {
			return StaticQSqlDatabase().AddDatabase(type);
		}
		[SmokeMethod("addDatabase(QSqlDriver*, const QString&)")]
		public static QSqlDatabase AddDatabase(QSqlDriver driver, string connectionName) {
			return StaticQSqlDatabase().AddDatabase(driver,connectionName);
		}
		[SmokeMethod("addDatabase(QSqlDriver*)")]
		public static QSqlDatabase AddDatabase(QSqlDriver driver) {
			return StaticQSqlDatabase().AddDatabase(driver);
		}
		[SmokeMethod("cloneDatabase(const QSqlDatabase&, const QString&)")]
		public static QSqlDatabase CloneDatabase(QSqlDatabase other, string connectionName) {
			return StaticQSqlDatabase().CloneDatabase(other,connectionName);
		}
		[SmokeMethod("database(const QString&, bool)")]
		public static QSqlDatabase Database(string connectionName, bool open) {
			return StaticQSqlDatabase().Database(connectionName,open);
		}
		[SmokeMethod("database(const QString&)")]
		public static QSqlDatabase Database(string connectionName) {
			return StaticQSqlDatabase().Database(connectionName);
		}
		[SmokeMethod("database()")]
		public static QSqlDatabase Database() {
			return StaticQSqlDatabase().Database();
		}
		[SmokeMethod("removeDatabase(const QString&)")]
		public static void RemoveDatabase(string connectionName) {
			StaticQSqlDatabase().RemoveDatabase(connectionName);
		}
		[SmokeMethod("contains(const QString&)")]
		public static bool Contains(string connectionName) {
			return StaticQSqlDatabase().Contains(connectionName);
		}
		[SmokeMethod("contains()")]
		public static bool Contains() {
			return StaticQSqlDatabase().Contains();
		}
		[SmokeMethod("drivers()")]
		public static List<string> Drivers() {
			return StaticQSqlDatabase().Drivers();
		}
		[SmokeMethod("connectionNames()")]
		public static List<string> ConnectionNames() {
			return StaticQSqlDatabase().ConnectionNames();
		}
		// void registerSqlDriver(const QString& arg1,QSqlDriverCreatorBase* arg2); >>>> NOT CONVERTED
		[SmokeMethod("isDriverAvailable(const QString&)")]
		public static bool IsDriverAvailable(string name) {
			return StaticQSqlDatabase().IsDriverAvailable(name);
		}
		public QSqlDatabase(string type) : this((Type) null) {
			CreateProxy();
			NewQSqlDatabase(type);
		}
		[SmokeMethod("QSqlDatabase(const QString&)")]
		private void NewQSqlDatabase(string type) {
			ProxyQSqlDatabase().NewQSqlDatabase(type);
		}
		public QSqlDatabase(QSqlDriver driver) : this((Type) null) {
			CreateProxy();
			NewQSqlDatabase(driver);
		}
		[SmokeMethod("QSqlDatabase(QSqlDriver*)")]
		private void NewQSqlDatabase(QSqlDriver driver) {
			ProxyQSqlDatabase().NewQSqlDatabase(driver);
		}
		~QSqlDatabase() {
			DisposeQSqlDatabase();
		}
		public void Dispose() {
			DisposeQSqlDatabase();
		}
		[SmokeMethod("~QSqlDatabase()")]
		private void DisposeQSqlDatabase() {
			ProxyQSqlDatabase().DisposeQSqlDatabase();
		}
	}
}