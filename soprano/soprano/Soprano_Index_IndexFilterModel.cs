//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Index {
    using Soprano;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \class IndexFilterModel indexfiltermodel.h Soprano/Index/IndexFilterModel
    ///  \brief The IndexFilterModel provides a full text index around any Soprano Model.
    ///  All statements with a literal object will be indexed. The literals can then be searched 
    ///  with CLucene queries. More details regarding queries can be found in the documentation fo
    ///  executeQuery().
    ///  \author Sebastian Trueg <trueg@kde.org>
    ///          </remarks>        <short>    \class IndexFilterModel indexfiltermodel.</short>
    [SmokeClass("Soprano::Index::IndexFilterModel")]
    public class IndexFilterModel : Soprano.FilterModel, IDisposable {
        protected IndexFilterModel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(IndexFilterModel), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static IndexFilterModel() {
            staticInterceptor = new SmokeInvocation(typeof(IndexFilterModel), null);
        }
        /// <remarks>
        ///  Create a new index model.
        ///  \param indexDir The directory where the index should be stored. If the
        ///  directory already contains an index, it will be used. Otherwise a new
        ///  one will be created.
        ///  \param model The parent model to forward the calls to. If 0 the Model has to
        ///  be set later on with FilterModel.SetParentModel.
        ///              </remarks>        <short>    Create a new index model.</short>
        public IndexFilterModel(string indexDir, Soprano.Model model) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("IndexFilterModel$#", "IndexFilterModel(const QString&, Soprano::Model*)", typeof(void), typeof(string), indexDir, typeof(Soprano.Model), model);
        }
        public IndexFilterModel(string indexDir) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("IndexFilterModel$", "IndexFilterModel(const QString&)", typeof(void), typeof(string), indexDir);
        }
        /// <remarks>
        ///  Create a new index model.
        ///  \param index The index to be used. The filter model will NOT take ownership of
        ///  the index. The caller has to take care of deleting the index.
        ///  \param model The parent model to forward the calls to. If 0 the Model has to
        ///  be set later on with FilterModel.SetParentModel.
        ///              </remarks>        <short>    Create a new index model.</short>
        public IndexFilterModel(Soprano.Index.CLuceneIndex index, Soprano.Model model) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("IndexFilterModel##", "IndexFilterModel(Soprano::Index::CLuceneIndex*, Soprano::Model*)", typeof(void), typeof(Soprano.Index.CLuceneIndex), index, typeof(Soprano.Model), model);
        }
        public IndexFilterModel(Soprano.Index.CLuceneIndex index) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("IndexFilterModel#", "IndexFilterModel(Soprano::Index::CLuceneIndex*)", typeof(void), typeof(Soprano.Index.CLuceneIndex), index);
        }
        /// <remarks>
        ///  Retrieve the index used by this index model.
        ///              </remarks>        <short>    Retrieve the index used by this index model.</short>
        public Soprano.Index.CLuceneIndex Index() {
            return (Soprano.Index.CLuceneIndex) interceptor.Invoke("index", "index() const", typeof(Soprano.Index.CLuceneIndex));
        }
        /// <remarks>
        ///  Adds a new statement.
        ///  This will index the statement and then forward the call to the parent model.
        ///  Normally only statements with literal objects are indexed. An exception
        ///  are those statements with predicates that are set via setForceIndexPredicates.
        ///              </remarks>        <short>    Adds a new statement.</short>
        [SmokeMethod("addStatement(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode AddStatement(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("addStatement#", "addStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        /// <remarks>
        ///  Removes a statement.
        ///  This will remove the statement from the index and then forward the call to the parent model.
        ///              </remarks>        <short>    Removes a statement.</short>
        [SmokeMethod("removeStatement(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode RemoveStatement(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("removeStatement#", "removeStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        /// <remarks>
        ///  Removes statements.
        ///  This will remove the statements from the index and then forward the call to the parent model.
        ///              </remarks>        <short>    Removes statements.</short>
        [SmokeMethod("removeAllStatements(const Soprano::Statement&)")]
        public override Soprano.Error.ErrorCode RemoveAllStatements(Soprano.Statement statement) {
            return (Soprano.Error.ErrorCode) interceptor.Invoke("removeAllStatements#", "removeAllStatements(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), statement);
        }
        /// <remarks>
        ///  The IndexFilterModel is currently based on CLucene. While the index itself is available
        ///  via index() and allows querying via CLucene queries it is not available over the 
        ///  Soprano.Client interface.
        ///  Thus, CLucene queries are supported through this method and will return QueryHit objects
        ///  wrapped in a QueryResultIterator.
        ///  Future versions of %Soprano will support querying the index through the Soprano.Query API
        ///  (still unfinished and unstable).
        ///  \param query The query string. This can be a CLucene query in which case the query will
        ///               be passed to CLuceneIndex.
        ///  \param language The query language. Set to Soprano.Query.QueryLanguageUser for
        ///                  CLucene queries.
        ///  \param userQueryLanguage If <pre>language</pre> equals Query.QueryLanguageUser
        ///                           userQueryLanguage defines the language to use. Use <b>"lucene"</b>
        ///                           to perform CLucene queries.
        ///  \return An iterator over all results matching the query, 
        ///  on error an invalid iterator is returned. In case of a CLucene query the iterator will
        ///  wrap a set of QueryHit objects through the bindings <b>"resource"</b> and <b>"score"</b>.
        ///  \sa CLuceneIndex.Search()
        ///              </remarks>        <short>    The IndexFilterModel is currently based on CLucene.</short>
        [SmokeMethod("executeQuery(const QString&, Soprano::Query::QueryLanguage, const QString&) const")]
        public override Soprano.QueryResultIterator ExecuteQuery(string query, Soprano.Query.QueryLanguage language, string userQueryLanguage) {
            return (Soprano.QueryResultIterator) interceptor.Invoke("executeQuery$$$", "executeQuery(const QString&, Soprano::Query::QueryLanguage, const QString&) const", typeof(Soprano.QueryResultIterator), typeof(string), query, typeof(Soprano.Query.QueryLanguage), language, typeof(string), userQueryLanguage);
        }
        [SmokeMethod("executeQuery(const QString&, Soprano::Query::QueryLanguage) const")]
        public override Soprano.QueryResultIterator ExecuteQuery(string query, Soprano.Query.QueryLanguage language) {
            return (Soprano.QueryResultIterator) interceptor.Invoke("executeQuery$$", "executeQuery(const QString&, Soprano::Query::QueryLanguage) const", typeof(Soprano.QueryResultIterator), typeof(string), query, typeof(Soprano.Query.QueryLanguage), language);
        }
        /// <remarks>
        ///  Set the number or addStatement operations that are to be cached in the index.
        ///  The default value is 1 which means that no caching occurs. Be aware that query
        ///  operations will always close cached transactions.
        ///  \param size The number of operations that should be handled in one transaction.
        ///  Set to 1 to disable.
        ///  \sa CLuceneIndex.StartTransaction, CLuceneIndex.CloseTransaction
        ///              </remarks>        <short>    Set the number or addStatement operations that are to be cached in the index.</short>
        public void SetTransactionCacheSize(int size) {
            interceptor.Invoke("setTransactionCacheSize$", "setTransactionCacheSize(int)", typeof(void), typeof(int), size);
        }
        /// <remarks>
        ///  The number of addStatement operations to cache in one transaction.
        ///  \sa setTransactionCacheSize
        ///              </remarks>        <short>    The number of addStatement operations to cache in one transaction.</short>
        public int TransactionCacheSize() {
            return (int) interceptor.Invoke("transactionCacheSize", "transactionCacheSize() const", typeof(int));
        }
        /// <remarks>
        ///  Rebuild the complete index. This means that the index will be cleared and all 
        ///  literal statements will be re-indexed.
        ///  This method is purely intended for maintenance.
        ///  \since 2.1
        ///              </remarks>        <short>    Rebuild the complete index.</short>
        public void RebuildIndex() {
            interceptor.Invoke("rebuildIndex", "rebuildIndex()", typeof(void));
        }
        /// <remarks>
        ///  Optimize the index for search. This makes sense after adding or
        ///  removing a large number of statements.
        ///  \sa CLuceneIndex.Optimize
        ///  \since 2.2
        ///              </remarks>        <short>    Optimize the index for search.</short>
        public void OptimizeIndex() {
            interceptor.Invoke("optimizeIndex", "optimizeIndex()", typeof(void));
        }
        /// <remarks>
        ///  Add a predicate which should only be indexed. This might be useful
        ///  for very large literals whose value is of no interest but which
        ///  should be searchable.
        ///  \param predicate The predicate that should only be indexed
        ///  but not stored in the underlying Model.
        ///  \sa indexOnlyPredicates, setIndexOnlyPredicates
        ///  \since 2.1
        ///              </remarks>        <short>    Add a predicate which should only be indexed.</short>
        public void AddIndexOnlyPredicate(QUrl predicate) {
            interceptor.Invoke("addIndexOnlyPredicate#", "addIndexOnlyPredicate(const QUrl&)", typeof(void), typeof(QUrl), predicate);
        }
        /// <remarks>
        ///  Set the predicates that should only be indexed. This might be useful
        ///  for very large literals whose value is of no interest but which
        ///  should be searchable.
        ///  \param predicates A list of predicates that should only be indexed
        ///  but not stored in the underlying Model.
        ///  \sa indexOnlyPredicates, addIndexOnlyPredicate
        ///  \since 2.1
        ///              </remarks>        <short>    Set the predicates that should only be indexed.</short>
        public void SetIndexOnlyPredicates(List<QUrl> predicates) {
            interceptor.Invoke("setIndexOnlyPredicates?", "setIndexOnlyPredicates(const QList<QUrl>&)", typeof(void), typeof(List<QUrl>), predicates);
        }
        /// <remarks>
        ///  The IndexFilterModel supports to not forward certain predicates to
        ///  the parent Model but only index their value. This might be useful
        ///  for very large literals whose value is of no interest but which
        ///  should be searchable.
        ///  \return A list of predicates that will only be indexed but not
        ///  stored in the underlying Model.
        ///  \sa addIndexOnlyPredicate, setIndexOnlyPredicates
        ///  \since 2.1
        ///              </remarks>        <short>    The IndexFilterModel supports to not forward certain predicates to  the parent Model but only index their value.</short>
        public List<QUrl> IndexOnlyPredicates() {
            return (List<QUrl>) interceptor.Invoke("indexOnlyPredicates", "indexOnlyPredicates() const", typeof(List<QUrl>));
        }
        /// <remarks>
        ///  Add a predicate which should be indexed even if the object is a resource.
        ///  See setForceIndexPredicates for a detailed explanation.
        ///  \param predicate The predicate that should be indexed
        ///  in any case.
        ///  \sa forceIndexPredicates, setForceIndexPredicates
        ///  \since 2.2
        ///              </remarks>        <short>    Add a predicate which should be indexed even if the object is a resource.</short>
        public void AddForceIndexPredicate(QUrl predicate) {
            interceptor.Invoke("addForceIndexPredicate#", "addForceIndexPredicate(const QUrl&)", typeof(void), typeof(QUrl), predicate);
        }
        /// <remarks>
        ///  Normally only statements with a literal object are indexed when added
        ///  thorugh addStatement. In some cases however, it is useful to also index 
        ///  resource objects.
        ///  Statement with a resource object (a URI) and a predicate that matches
        ///  one of the force index predicates, are converted to strings using
        ///  QUrl.ToEncoded and added to the index non-tokenized. Thus, the resources
        ///  will be searchable directly via a 'field:uri' query but not via the
        ///  default search  field.
        ///  A typical and very useful predicate is Vocabulary.RDF.Type(). 
        ///  This allows to restrict the type of resources in lucene queries:
        ///  <pre>
        ///  model.ExecuteQuery( string( "foobar AND %1:%2" )
        ///                       .arg( encodeUriForLuceneQuery( RDF.Type() ) )
        ///                       .arg( encodeUriForLuceneQuery( myType ) ),
        ///                       Query.QueryLanguageUser,
        ///                       "lucene" );
        ///  </pre>
        ///  \param predicates The predicates that should be indexed
        ///  in any case.
        ///  \sa forceIndexPredicates, addForceIndexPredicate
        ///  \since 2.2
        ///              </remarks>        <short>    Normally only statements with a literal object are indexed when added  thorugh addStatement.</short>
        public void SetForceIndexPredicates(List<QUrl> predicates) {
            interceptor.Invoke("setForceIndexPredicates?", "setForceIndexPredicates(const QList<QUrl>&)", typeof(void), typeof(List<QUrl>), predicates);
        }
        /// <remarks>
        ///  See setForceIndexPredicates for a detailed explanation.
        ///  \return A list of predicates that will be indexed even if the object
        ///  is not a literal.
        ///  \sa addForceIndexPredicate, setForceIndexPredicates
        ///  \since 2.2
        ///              </remarks>        <short>    See setForceIndexPredicates for a detailed explanation.</short>
        public List<QUrl> ForceIndexPredicates() {
            return (List<QUrl>) interceptor.Invoke("forceIndexPredicates", "forceIndexPredicates() const", typeof(List<QUrl>));
        }
        ~IndexFilterModel() {
            interceptor.Invoke("~IndexFilterModel", "~IndexFilterModel()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~IndexFilterModel", "~IndexFilterModel()", typeof(void));
        }
        /// <remarks>
        ///  Encodes a string to be used in a lucene query. String values
        ///  may contain characters that are reserved in lucene queries.
        ///  These are property escaped by this method.
        ///  This method converts an arbitrary string into a string that can be used
        ///  in a lucene query.
        ///  \param value The string to be encoded.
        ///  \return An encoded and escaped string representation of the 
        ///  provided string.
        ///  \sa encodeUriForLuceneQuery
        ///  \since 2.2
        ///              </remarks>        <short>    Encodes a string to be used in a lucene query.</short>
        public static string EncodeStringForLuceneQuery(string value) {
            return (string) staticInterceptor.Invoke("encodeStringForLuceneQuery$", "encodeStringForLuceneQuery(const QString&)", typeof(string), typeof(string), value);
        }
        /// <remarks>
        ///  Encodes a URI to be used in a lucene query. URIs often contain
        ///  characters that are reserved in lucene queries and, thus, need
        ///  to be escaped. In addition, the URIs are encoded by the index
        ///  model for storage in clucene.
        ///  This method converts a URI into a string that can be used
        ///  in a lucene query.
        ///  \param uri The URI to be encoded.
        ///  \return An encoded and escaped string representation of the URI.
        ///  \sa encodeStringForLuceneQuery
        ///  \since 2.2
        ///              </remarks>        <short>    Encodes a URI to be used in a lucene query.</short>
        public static string EncodeUriForLuceneQuery(QUrl uri) {
            return (string) staticInterceptor.Invoke("encodeUriForLuceneQuery#", "encodeUriForLuceneQuery(const QUrl&)", typeof(string), typeof(QUrl), uri);
        }
        protected new IIndexFilterModelSignals Emit {
            get { return (IIndexFilterModelSignals) Q_EMIT; }
        }
    }

    public interface IIndexFilterModelSignals : Soprano.IFilterModelSignals {
    }
}
