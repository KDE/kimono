//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  Base class for any "viewer" part.
    ///  This class takes care of network transparency for you,
    ///  in the simplest way (downloading to a temporary file, then letting the part
    ///  load from the temporary file).
    ///  To use the built-in network transparency, you only need to implement
    ///  openFile(), not openUrl().
    ///  To implement network transparency differently (e.g. for progressive loading,
    ///  like a web browser does for instance), or to prevent network transparency
    ///  (but why would you do that?), you can override openUrl().
    ///  KParts Application can use the signals to show feedback while the URL is being loaded.
    ///  ReadOnlyPart handles the window caption by setting it to the current URL
    ///  (set in openUrl(), and each time the part is activated).
    ///  If you want another caption, set it in openFile() and
    ///  (if the part might ever be used with a part manager) in guiActivateEvent()
    ///   See <see cref="IReadOnlyPartSignals"></see> for signals emitted by ReadOnlyPart
    /// </remarks>        <short>    Base class for any "viewer" part.</short>
    [SmokeClass("KParts::ReadOnlyPart")]
    public abstract class ReadOnlyPart : KParts.Part {
        protected ReadOnlyPart(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ReadOnlyPart), this);
        }
        [Q_PROPERTY("KUrl", "url")]
        public KUrl Url {
            get { return (KUrl) interceptor.Invoke("url", "url()", typeof(KUrl)); }
        }
        // KParts::ReadOnlyPart* ReadOnlyPart(KParts::ReadOnlyPartPrivate& arg1,QObject* arg2); >>>> NOT CONVERTED
        /// <remarks>
        ///  Constructor
        ///  See also Part for the setXXX methods to call.
        ///      </remarks>        <short>    Constructor  See also Part for the setXXX methods to call.</short>
        public ReadOnlyPart(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ReadOnlyPart#", "ReadOnlyPart(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public ReadOnlyPart() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ReadOnlyPart", "ReadOnlyPart()", typeof(void));
        }
        /// <remarks>
        ///  Call this to turn off the progress info dialog used by
        ///  the internal KIO job. Use this if you provide another way
        ///  of displaying progress info (e.g. a statusbar), using the
        ///  signals emitted by this class, and/or those emitted by
        ///  the Job given by started.
        ///      </remarks>        <short>    Call this to turn off the progress info dialog used by  the internal KIO job.</short>
        public void SetProgressInfoEnabled(bool show) {
            interceptor.Invoke("setProgressInfoEnabled$", "setProgressInfoEnabled(bool)", typeof(void), typeof(bool), show);
        }
        /// <remarks>
        ///  Returns whether the part shows the progress info dialog used by internal
        ///  KIO job.
        ///      </remarks>        <short>    Returns whether the part shows the progress info dialog used by internal  KIO job.</short>
        public bool IsProgressInfoEnabled() {
            return (bool) interceptor.Invoke("isProgressInfoEnabled", "isProgressInfoEnabled() const", typeof(bool));
        }
        public void ShowProgressInfo(bool show) {
            interceptor.Invoke("showProgressInfo$", "showProgressInfo(bool)", typeof(void), typeof(bool), show);
        }
        /// <remarks>
        ///  Called when closing the current url (e.g. document), for instance
        ///  when switching to another url (note that openUrl() calls it
        ///  automatically in this case).
        ///  If the current URL is not fully loaded yet, aborts loading.
        ///  Deletes the temporary file used when the url is remote.
        /// </remarks>        <return> always true, but the return value exists for reimplementations
        ///      </return>
        ///         <short>    Called when closing the current url (e.</short>
        [SmokeMethod("closeUrl()")]
        public virtual bool CloseUrl() {
            return (bool) interceptor.Invoke("closeUrl", "closeUrl()", typeof(bool));
        }
        /// <remarks>
        ///  This convenience method returns the browserExtension for this part,
        ///  or 0 if there isn't any.
        ///      </remarks>        <short>    This convenience method returns the browserExtension for this part,  or 0 if there isn't any.</short>
        public KParts.BrowserExtension BrowserExtension() {
            return (KParts.BrowserExtension) interceptor.Invoke("browserExtension", "browserExtension() const", typeof(KParts.BrowserExtension));
        }
        /// <remarks>
        ///  Sets the arguments to use for the next openUrl call.
        ///      </remarks>        <short>    Sets the arguments to use for the next openUrl call.</short>
        public void SetArguments(KParts.OpenUrlArguments arguments) {
            interceptor.Invoke("setArguments#", "setArguments(const KParts::OpenUrlArguments&)", typeof(void), typeof(KParts.OpenUrlArguments), arguments);
        }
        /// <remarks>
        /// </remarks>        <return> the arguments that were used to open this URL.
        ///      </return>
        ///         <short>   </short>
        public KParts.OpenUrlArguments Arguments() {
            return (KParts.OpenUrlArguments) interceptor.Invoke("arguments", "arguments() const", typeof(KParts.OpenUrlArguments));
        }
        /// <remarks>
        ///  Initiate sending data to this part.
        ///  This is an alternative to openUrl, which allows the user of the part
        ///  to load the data itself, and send it progressively to the part.
        /// <param> name="mimeType" the type of data that is going to be sent to this part.
        /// </param><param> name="url" the URL representing this data. Although not directly used,
        ///  every ReadOnlyPart has a URL (see url()), so this simply sets it.
        /// </param></remarks>        <return> true if the part supports progressive loading and accepts data, false otherwise.
        ///      </return>
        ///         <short>    Initiate sending data to this part.</short>
        public bool OpenStream(string mimeType, KUrl url) {
            return (bool) interceptor.Invoke("openStream$#", "openStream(const QString&, const KUrl&)", typeof(bool), typeof(string), mimeType, typeof(KUrl), url);
        }
        /// <remarks>
        ///  Send some data to the part. openStream must have been called previously,
        ///  and must have returned true.
        /// </remarks>        <return> true if the data was accepted by the part. If false is returned,
        ///  the application should stop sending data, and doesn't have to call closeStream.
        ///      </return>
        ///         <short>    Send some data to the part.</short>
        public bool WriteStream(QByteArray data) {
            return (bool) interceptor.Invoke("writeStream#", "writeStream(const QByteArray&)", typeof(bool), typeof(QByteArray), data);
        }
        /// <remarks>
        ///  Terminate the sending of data to the part.
        ///  With some data types (text, html...) closeStream might never actually be called,
        ///  in the case of continuous streams, for instance plain text or HTML data.
        ///      </remarks>        <short>    Terminate the sending of data to the part.</short>
        public bool CloseStream() {
            return (bool) interceptor.Invoke("closeStream", "closeStream()", typeof(bool));
        }
        /// <remarks>
        ///  Only reimplement openUrl if you don't want the network transparency support
        ///  to download from the url into a temporary file (when the url isn't local).
        ///  Otherwise, reimplement openFile() only .
        ///  If you reimplement it, don't forget to set the caption, usually with
        ///  emit setWindowCaption( url.prettyUrl() );
        ///      </remarks>        <short>    Only reimplement openUrl if you don't want the network transparency support  to download from the url into a temporary file (when the url isn't local).</short>
        [Q_SLOT("bool openUrl(KUrl)")]
        [SmokeMethod("openUrl(const KUrl&)")]
        public virtual bool OpenUrl(KUrl url) {
            return (bool) interceptor.Invoke("openUrl#", "openUrl(const KUrl&)", typeof(bool), typeof(KUrl), url);
        }
        /// <remarks>
        ///  If the part uses the standard implementation of openUrl(),
        ///  it must reimplement this, to open the local file.
        ///  Otherwise simply define it to { return false; }
        ///      </remarks>        <short>    If the part uses the standard implementation of openUrl(),  it must reimplement this, to open the local file.</short>
        [SmokeMethod("openFile()")]
        protected abstract bool OpenFile();
        /// <remarks>
        ///      </remarks>        <short>   </short>
        protected void AbortLoad() {
            interceptor.Invoke("abortLoad", "abortLoad()", typeof(void));
        }
        /// <remarks>
        ///  Reimplemented from Part, so that the window caption is set to
        ///  the current url (decoded) when the part is activated
        ///  This is the usual behavior in 99% of the apps
        ///  Reimplement if you don't like it - test for event.Activated() !
        ///  Technical note : this is done with GUIActivateEvent and not with
        ///  PartActivateEvent because it's handled by the mainwindow
        ///  (which gets the even after the PartActivateEvent events have been sent)
        ///      </remarks>        <short>    Reimplemented from Part, so that the window caption is set to  the current url (decoded) when the part is activated  This is the usual behavior in 99% of the apps  Reimplement if you don't like it - test for event.Activated() ! </short>
        [SmokeMethod("guiActivateEvent(KParts::GUIActivateEvent*)")]
        protected override void GuiActivateEvent(KParts.GUIActivateEvent arg1) {
            interceptor.Invoke("guiActivateEvent#", "guiActivateEvent(KParts::GUIActivateEvent*)", typeof(void), typeof(KParts.GUIActivateEvent), arg1);
        }
        /// <remarks>
        ///  Returns the local file path associated with this part.
        ///      </remarks>        <short>    Returns the local file path associated with this part.</short>
        protected string LocalFilePath() {
            return (string) interceptor.Invoke("localFilePath", "localFilePath() const", typeof(string));
        }
        /// <remarks>
        ///  Sets the local file path associated with this part.
        ///      </remarks>        <short>    Sets the local file path associated with this part.</short>
        protected void SetLocalFilePath(string localFilePath) {
            interceptor.Invoke("setLocalFilePath$", "setLocalFilePath(const QString&)", typeof(void), typeof(string), localFilePath);
        }
        protected new IReadOnlyPartSignals Emit {
            get { return (IReadOnlyPartSignals) Q_EMIT; }
        }
    }

    public interface IReadOnlyPartSignals : KParts.IPartSignals {
        /// <remarks>
        ///  The part emits this when starting data.
        ///  If using a KIO.Job, it sets the job in the signal, so that
        ///  progress information can be shown. Otherwise, job is 0.
        /// </remarks>        <short>    The part emits this when starting data.</short>
        [Q_SIGNAL("void started(KIO::Job*)")]
        void Started(KIO.Job arg1);
        /// <remarks>
        ///  Emit this when you have completed loading data.
        ///  Hosting apps will want to know when the process of loading the data
        ///  is finished, so that they can access the data when everything is loaded.
        /// </remarks>        <short>    Emit this when you have completed loading data.</short>
        [Q_SIGNAL("void completed()")]
        void Completed();
        /// <remarks>
        ///  Same as the above signal except it indicates whether there is
        ///  a pending action to be executed on a delay timer. An example of
        ///  this is the meta-refresh tags on web pages used to reload/redirect
        ///  after a certain period of time. This signal is useful if you want
        ///  to give the user the ability to cancel such pending actions.
        ///  <code>pendingAction</code> true if a pending action exists, false otherwise.
        ///      </remarks>        <short>    Same as the above signal except it indicates whether there is  a pending action to be executed on a delay timer.</short>
        [Q_SIGNAL("void completed(bool)")]
        void Completed(bool pendingAction);
        /// <remarks>
        ///  Emit this if loading is canceled by the user or by an error.
        /// <param> name="errMsg" the error message, empty if the user canceled the loading voluntarily.
        ///      </param></remarks>        <short>    Emit this if loading is canceled by the user or by an error.</short>
        [Q_SIGNAL("void canceled(QString)")]
        void Canceled(string errMsg);
    }
}
