//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Client {
    using Soprano;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \class DBusModel dbusmodel.h Soprano/Client/DBusModel
    ///  \brief Interface to a DBus server model.
    ///  The DBusModel provides a fully functional interface
    ///  to a Model provided through a %Soprano DBus server. It can thus,
    ///  be seen as the counterpart to Server.DBusExportModel.
    ///  Given the DBus service name and the object path of the Model
    ///  in question it handles all DBus communication transparently.
    ///  Normally there is no need to use this class directly as 
    ///  DBusClient does create instances of it on request.
    ///  \warning DBusModel is not thread-safe by default
    ///  and has to be protected if is is to be used from different
    ///  threads (This can be done via Soprano.Util.MutexModel
    ///  in Soprano.Util.MutexModel.ReadWriteMultiThreading mode
    ///  or via setting the model to async mode via setAsyncCalls()).
    ///  \author Sebastian Trueg <trueg@kde.org>
    ///  \sa \ref soprano_server_dbus
    ///          </remarks>        <short>    \class DBusModel dbusmodel.</short>
    [SmokeClass("Soprano::Client::DBusModel")]
    public class DBusModel : Soprano.StorageModel, IDisposable {
        protected DBusModel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(DBusModel), this);
        }
        /// <remarks>
        ///  Create a new DBus Model interface.
        ///  \param serviceName The name of the DBus service that provides the Model.
        ///  \param dbusObject The path to the Model object in the DBus service.
        ///  \param backend The backend that created this model. Should always be set to 0.
        ///              </remarks>        <short>    Create a new DBus Model interface.</short>
        public DBusModel(string serviceName, string dbusObject, Soprano.Backend backend) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("DBusModel$$#", "DBusModel(const QString&, const QString&, const Soprano::Backend*)", typeof(void), typeof(string), serviceName, typeof(string), dbusObject, typeof(Soprano.Backend), backend);
        }
        public DBusModel(string serviceName, string dbusObject) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("DBusModel$$", "DBusModel(const QString&, const QString&)", typeof(void), typeof(string), serviceName, typeof(string), dbusObject);
        }
        /// <remarks>
        ///  Configure DBusModel to use asyncronous calls over DBus.
        ///  With asyncronous calls DBusModel will enter local event
        ///  loops while waiting for the reply. This way multiple calls
        ///  can be performed interweaved. However, the application does 
        ///  not block, i.e. events (such as signals and slots) are handled
        ///  which might not be wanted.
        ///  If that is the case it is better to use Util.MutexModel
        ///  instead.
        ///  \param b If true asyncronous calls are enabled.
        ///  Per default asyncronous calls are disabled.
        ///  \warning Asyncronous calls only work in combination with a QCoreApplication
        ///  instance.
        ///  \sa QDBus.BlockWithGui
        ///              </remarks>        <short>    Configure DBusModel to use asyncronous calls over DBus.</short>
        public void SetAsyncCalls(bool b) {
            interceptor.Invoke("setAsyncCalls$", "setAsyncCalls(bool)", typeof(void), typeof(bool), b);
        }
        /// <remarks>
        ///  \return <pre>true</pre> if asyncronous calls are enabled.
        ///              </remarks>        <short>    \return \p true if asyncronous calls are enabled.</short>
        public bool AsyncCalls() {
            return (bool) interceptor.Invoke("asyncCalls", "asyncCalls() const", typeof(bool));
        }
        [SmokeMethod("addStatement(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode AddStatement(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("addStatement#", "addStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("listContexts() const")]
        public override Soprano.NodeIterator ListContexts() {
            return (Soprano.NodeIterator) interceptor.Invoke("listContexts", "listContexts() const", typeof(Soprano.NodeIterator));
        }
        [SmokeMethod("executeQuery(const QString&, Soprano::Query::QueryLanguage, const QString&) const")]
        public override Soprano.QueryResultIterator ExecuteQuery(string query, Soprano.Query.QueryLanguage language, string userQueryLanguage) {
            return (Soprano.QueryResultIterator) interceptor.Invoke("executeQuery$$$", "executeQuery(const QString&, Soprano::Query::QueryLanguage, const QString&) const", typeof(Soprano.QueryResultIterator), typeof(string), query, typeof(Soprano.Query.QueryLanguage), language, typeof(string), userQueryLanguage);
        }
        [SmokeMethod("executeQuery(const QString&, Soprano::Query::QueryLanguage) const")]
        public virtual Soprano.QueryResultIterator ExecuteQuery(string query, Soprano.Query.QueryLanguage language) {
            return (Soprano.QueryResultIterator) interceptor.Invoke("executeQuery$$", "executeQuery(const QString&, Soprano::Query::QueryLanguage) const", typeof(Soprano.QueryResultIterator), typeof(string), query, typeof(Soprano.Query.QueryLanguage), language);
        }
        [SmokeMethod("listStatements(const Soprano::Statement&) const")]
        public override Soprano.StatementIterator ListStatements(Soprano.Statement partial) {
            return (Soprano.StatementIterator) interceptor.Invoke("listStatements#", "listStatements(const Soprano::Statement&) const", typeof(Soprano.StatementIterator), typeof(Soprano.Statement), partial);
        }
        [SmokeMethod("removeStatement(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode RemoveStatement(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("removeStatement#", "removeStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("removeAllStatements(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode RemoveAllStatements(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("removeAllStatements#", "removeAllStatements(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("statementCount() const")]
        public override int StatementCount() {
            return (int) interceptor.Invoke("statementCount", "statementCount() const", typeof(int));
        }
        [SmokeMethod("isEmpty() const")]
        public override bool IsEmpty() {
            return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
        }
        [SmokeMethod("containsStatement(const Soprano::Statement&) const")]
        public override bool ContainsStatement(Soprano.Statement statement) {
            return (bool) interceptor.Invoke("containsStatement#", "containsStatement(const Soprano::Statement&) const", typeof(bool), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("containsAnyStatement(const Soprano::Statement&) const")]
        public override bool ContainsAnyStatement(Soprano.Statement statement) {
            return (bool) interceptor.Invoke("containsAnyStatement#", "containsAnyStatement(const Soprano::Statement&) const", typeof(bool), typeof(Soprano.Statement), statement);
        }
        [SmokeMethod("createBlankNode()")]
        public override Soprano.Node CreateBlankNode() {
            return (Soprano.Node) interceptor.Invoke("createBlankNode", "createBlankNode()", typeof(Soprano.Node));
        }
        ~DBusModel() {
            interceptor.Invoke("~DBusModel", "~DBusModel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~DBusModel", "~DBusModel()", typeof(void));
        }
        protected new IDBusModelSignals Emit {
            get { return (IDBusModelSignals) Q_EMIT; }
        }
    }

    public interface IDBusModelSignals : Soprano.IStorageModelSignals {
    }
}
