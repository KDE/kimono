//Auto-generated by kalyptus. DO NOT EDIT.
namespace Nepomuk.Search {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    [SmokeClass("Nepomuk::Search::Query")]
    public class Query : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected Query(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Query), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static Query() {
            staticInterceptor = new SmokeInvocation(typeof(Query), null);
        }
        public enum TypeOf {
            InvalidQuery = 0,
            PlainQuery = 1,
            SPARQLQuery = 2,
        }
        /// <remarks>
        ///  Create an empty invalid query object.
        ///              </remarks>        <short>    Create an empty invalid query object.</short>
        public Query() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Query", "Query()", typeof(void));
        }
        /// <remarks>
        ///  Create a query of type PlainQuery based on
        ///  \a term.
        ///              </remarks>        <short>    Create a query of type PlainQuery based on  \a term.</short>
        public Query(Nepomuk.Search.Term term) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Query#", "Query(const Nepomuk::Search::Term&)", typeof(void), typeof(Nepomuk.Search.Term), term);
        }
        /// <remarks>
        ///  Create a SPARQL query. The query has to have one select variable called "?r"
        ///              </remarks>        <short>    Create a SPARQL query.</short>
        public Query(string sparqlQuery) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Query$", "Query(const QString&)", typeof(void), typeof(string), sparqlQuery);
        }
        /// <remarks>
        ///  Copy constructor.
        ///              </remarks>        <short>    Copy constructor.</short>
        public Query(Nepomuk.Search.Query arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Query#", "Query(const Nepomuk::Search::Query&)", typeof(void), typeof(Nepomuk.Search.Query), arg1);
        }
        public Nepomuk.Search.Query.TypeOf type() {
            return (Nepomuk.Search.Query.TypeOf) interceptor.Invoke("type", "type() const", typeof(Nepomuk.Search.Query.TypeOf));
        }
        public Nepomuk.Search.Term Term() {
            return (Nepomuk.Search.Term) interceptor.Invoke("term", "term() const", typeof(Nepomuk.Search.Term));
        }
        public string SparqlQuery() {
            return (string) interceptor.Invoke("sparqlQuery", "sparqlQuery() const", typeof(string));
        }
        public int Limit() {
            return (int) interceptor.Invoke("limit", "limit() const", typeof(int));
        }
        public void SetTerm(Nepomuk.Search.Term arg1) {
            interceptor.Invoke("setTerm#", "setTerm(const Nepomuk::Search::Term&)", typeof(void), typeof(Nepomuk.Search.Term), arg1);
        }
        public void SetSparqlQuery(string arg1) {
            interceptor.Invoke("setSparqlQuery$", "setSparqlQuery(const QString&)", typeof(void), typeof(string), arg1);
        }
        public void SetLimit(int arg1) {
            interceptor.Invoke("setLimit$", "setLimit(int)", typeof(void), typeof(int), arg1);
        }
        /// <remarks>
        ///  Add a property that should be reported with each search result.
        ///  \param property The requested property.
        ///  \param optional If <pre>true</pre> the property is optional, meaning it can
        ///         be empty ins earch results.
        ///              </remarks>        <short>    Add a property that should be reported with each search result.</short>
        public void AddRequestProperty(QUrl property, bool optional) {
            interceptor.Invoke("addRequestProperty#$", "addRequestProperty(const QUrl&, bool)", typeof(void), typeof(QUrl), property, typeof(bool), optional);
        }
        public void AddRequestProperty(QUrl property) {
            interceptor.Invoke("addRequestProperty#", "addRequestProperty(const QUrl&)", typeof(void), typeof(QUrl), property);
        }
        public void ClearRequestProperties() {
            interceptor.Invoke("clearRequestProperties", "clearRequestProperties()", typeof(void));
        }
        public List<QPair<bool, QUrl>> RequestProperties() {
            return (List<QPair<bool, QUrl>>) interceptor.Invoke("requestProperties", "requestProperties() const", typeof(List<QPair<bool, QUrl>>));
        }
        public override bool Equals(object o) {
            if (!(o is Query)) { return false; }
            return this == (Query) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        ~Query() {
            interceptor.Invoke("~Query", "~Query()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~Query", "~Query()", typeof(void));
        }
        public static bool operator==(Query lhs, Nepomuk.Search.Query arg1) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const Nepomuk::Search::Query&) const", typeof(bool), typeof(Query), lhs, typeof(Nepomuk.Search.Query), arg1);
        }
        public static bool operator!=(Query lhs, Nepomuk.Search.Query arg1) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const Nepomuk::Search::Query&) const", typeof(bool), typeof(Query), lhs, typeof(Nepomuk.Search.Query), arg1);
        }
    }
}