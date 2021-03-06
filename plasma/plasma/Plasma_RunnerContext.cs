//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class RunnerContext plasma/runnercontext.h <Plasma/RunnerContext>
    ///  See <see cref="IRunnerContextSignals"></see> for signals emitted by RunnerContext
    /// </remarks>        <short> The RunnerContext class provides information related to a search,         including the search term, metadata on the search term and collected         matches.  </short>
    [SmokeClass("Plasma::RunnerContext")]
    public class RunnerContext : QObject, IDisposable {
        protected RunnerContext(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(RunnerContext), this);
        }
        public enum TypeOf {
            None = 0,
            UnknownType = 1,
            Directory = 2,
            File = 4,
            NetworkLocation = 8,
            Executable = 16,
            ShellCommand = 32,
            Help = 64,
            FileSystem = Directory|File|Executable|ShellCommand,
        }
        public RunnerContext(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("RunnerContext#", "RunnerContext(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public RunnerContext() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("RunnerContext", "RunnerContext()", typeof(void));
        }
        /// <remarks>
        ///  Copy constructor
        ///          </remarks>        <short>    Copy constructor          </short>
        public RunnerContext(Plasma.RunnerContext other, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("RunnerContext##", "RunnerContext(Plasma::RunnerContext&, QObject*)", typeof(void), typeof(Plasma.RunnerContext), other, typeof(QObject), parent);
        }
        public RunnerContext(Plasma.RunnerContext other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("RunnerContext#", "RunnerContext(Plasma::RunnerContext&)", typeof(void), typeof(Plasma.RunnerContext), other);
        }
        /// <remarks>
        ///  Resets the search term for this object.
        ///  This removes all current matches in the process.
        ///          </remarks>        <short>    Resets the search term for this object.</short>
        public void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        /// <remarks>
        ///  Sets the query term for this object and attempts to determine
        ///  the type of the search.
        ///          </remarks>        <short>    Sets the query term for this object and attempts to determine  the type of the search.</short>
        public void SetQuery(string term) {
            interceptor.Invoke("setQuery$", "setQuery(const QString&)", typeof(void), typeof(string), term);
        }
        /// <remarks>
        /// </remarks>        <return> the current search query term.
        ///          </return>
        ///         <short>   </short>
        public string Query() {
            return (string) interceptor.Invoke("query", "query() const", typeof(string));
        }
        /// <remarks>
        ///  The type of item the search term might refer to.
        /// </remarks>        <short>    The type of item the search term might refer to.</short>
        ///         <see> Type</see>
        public Plasma.RunnerContext.TypeOf type() {
            return (Plasma.RunnerContext.TypeOf) interceptor.Invoke("type", "type() const", typeof(Plasma.RunnerContext.TypeOf));
        }
        /// <remarks>
        ///  The mimetype that the search term refers to, if discoverable.
        /// </remarks>        <return> string() if the mimetype can not be determined, otherwise
        ///          the mimetype of the object being referred to by the search
        ///          string.
        ///          </return>
        ///         <short>    The mimetype that the search term refers to, if discoverable.</short>
        public string MimeType() {
            return (string) interceptor.Invoke("mimeType", "mimeType() const", typeof(string));
        }
        /// <remarks>
        ///  while (.. a possibly large iteration) {
        ///      if (!context.isValid()) {
        ///          return;
        ///      }
        ///      ... some processing ...
        ///  }
        ///  While not required to be used within runners, it provies a nice way
        ///  to avoid unecessary processing in runners that may run for an extended
        ///  period (as measured in 10s of ms) and therefore improve the user experience. 
        /// </remarks>        <return> true if this context is no longer valid and therefore
        ///  matching using it should abort. Most useful as an optimization technique
        ///  inside of AbstractRunner subclasses in the match method, e.g.:
        /// </return>
        ///         <short>   </short>
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        /// <remarks>
        ///  Appends lists of matches to the list of matches.
        ///  This method is thread safe and causes the matchesChanged() signal to be emitted.
        /// </remarks>        <return> true if matches were added, false if matches were e.g. outdated
        ///          </return>
        ///         <short>    Appends lists of matches to the list of matches.</short>
        public bool AddMatches(string term, List<Plasma.QueryMatch> matches) {
            return (bool) interceptor.Invoke("addMatches$?", "addMatches(const QString&, const QList<Plasma::QueryMatch>&)", typeof(bool), typeof(string), term, typeof(List<Plasma.QueryMatch>), matches);
        }
        /// <remarks>
        ///  Appends a match to the existing list of matches.
        ///  If you are going to be adding multiple matches, use addMatches instead.
        ///  @arg term the search term that this match was generated for.
        ///  @arg match the match to add
        /// </remarks>        <return> true if the match was added, false otherwise.
        ///          </return>
        ///         <short>    Appends a match to the existing list of matches.</short>
        public bool AddMatch(string term, Plasma.QueryMatch match) {
            return (bool) interceptor.Invoke("addMatch$#", "addMatch(const QString&, const Plasma::QueryMatch&)", typeof(bool), typeof(string), term, typeof(Plasma.QueryMatch), match);
        }
        /// <remarks>
        ///  Retrieves all available matches for the current search term.
        /// </remarks>        <return> a list of matches
        ///          </return>
        ///         <short>    Retrieves all available matches for the current search term.</short>
        public List<Plasma.QueryMatch> Matches() {
            return (List<Plasma.QueryMatch>) interceptor.Invoke("matches", "matches() const", typeof(List<Plasma.QueryMatch>));
        }
        /// <remarks>
        ///  Retrieves a match by id.
        /// <param> name="id" the id of the match to return
        /// </param></remarks>        <return> the match associated with this id, or an invalid QueryMatch object
        ///          if the id does not eixst
        ///          </return>
        ///         <short>    Retrieves a match by id.</short>
        public Plasma.QueryMatch Match(string id) {
            return (Plasma.QueryMatch) interceptor.Invoke("match$", "match(const QString&) const", typeof(Plasma.QueryMatch), typeof(string), id);
        }
        /// <remarks>
        ///  Sets the launch counts for the associated match ids
        ///  If a runner adds a match to this context, the context will check if the
        ///  match id has been launched before and increase the matches relevance
        ///  correspondingly. In this manner, any front end can implement adaptive search
        ///  by sorting items according to relevance.
        /// <param> name="config" the config group where launch data was stored
        ///          </param></remarks>        <short>    Sets the launch counts for the associated match ids </short>
        public void Restore(KConfigGroup config) {
            interceptor.Invoke("restore#", "restore(const KConfigGroup&)", typeof(void), typeof(KConfigGroup), config);
        }
        /// <remarks>
        /// <param> name="config" the config group where launch data should be stored
        ///          </param></remarks>        <short>   </short>
        public void Save(KConfigGroup config) {
            interceptor.Invoke("save#", "save(KConfigGroup&)", typeof(void), typeof(KConfigGroup), config);
        }
        /// <remarks>
        ///  Run a match using the information from this context
        ///  The context will also keep track of the number of times the match was
        ///  launched to sort future matches according to user habits
        /// <param> name="match" the match to run
        ///          </param></remarks>        <short>    Run a match using the information from this context </short>
        public void Run(Plasma.QueryMatch match) {
            interceptor.Invoke("run#", "run(const Plasma::QueryMatch&)", typeof(void), typeof(Plasma.QueryMatch), match);
        }
        ~RunnerContext() {
            interceptor.Invoke("~RunnerContext", "~RunnerContext()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~RunnerContext", "~RunnerContext()", typeof(void));
        }
        protected new IRunnerContextSignals Emit {
            get { return (IRunnerContextSignals) Q_EMIT; }
        }
    }

    public interface IRunnerContextSignals : IQObjectSignals {
        [Q_SIGNAL("void matchesChanged()")]
        void MatchesChanged();
    }
}
