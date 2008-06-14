//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  The base class for all jobs.
	///  For all jobs created in an application, the code looks like
	///  <pre>
	///    KIO.Job  job = KIO.Someoperation( some parameters );
	///    connect( job, SIGNAL("result( KJob  )"),
	///             this, SLOT("slotResult( KJob  )") );
	///  </pre>
	///    (other connects, specific to the job)
	///  And slotResult is usually at least:
	///  <pre>
	///   if ( job.Error() )
	///       job.Ui().ShowErrorDialog();
	///  </pre>
	///  See <see cref="IJobSignals"></see> for signals emitted by Job
	/// </remarks>		<short>    The base class for all jobs.</short>
	/// 		<see> Scheduler</see>
	[SmokeClass("KIO::Job")]
	public class Job : KCompositeJob, IDisposable {
 		protected Job(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Job), this);
		}
		// KIO::Job* Job(KIO::JobPrivate& arg1); >>>> NOT CONVERTED
		[SmokeMethod("start()")]
		public override void Start() {
			interceptor.Invoke("start", "start()", typeof(void));
		}
		/// <remarks>
		///  Retrieves the UI delegate of this job.
		///  This method is basically a convenience for static_cast<KIO.JobUiDelegate>(uiDelegate()).
		/// </remarks>		<return> the delegate used by the job to communicate with the UI
		///          </return>
		/// 		<short>    Retrieves the UI delegate of this job.</short>
		public KIO.JobUiDelegate Ui() {
			return (KIO.JobUiDelegate) interceptor.Invoke("ui", "ui() const", typeof(KIO.JobUiDelegate));
		}
		/// <remarks>
		///  Converts an error code and a non-i18n error message into an
		///  error message in the current language. The low level (non-i18n)
		///  error message (usually a url) is put into the translated error
		///  message using %1.
		///  Example for errid == ERR_CANNOT_OPEN_FOR_READING:
		///  <pre>
		///    i18n( "Could not read\n%1" ).arg( errortext );
		///  </pre>
		///  Use this to display the error yourself, but for a dialog box
		///  use Job.ShowErrorDialog. Do not call it if error()
		///  is not 0.
		/// </remarks>		<return> the error message and if there is no error, a message
		///          telling the user that the app is broken, so check with
		///          error() whether there is an error
		///          </return>
		/// 		<short>    Converts an error code and a non-i18n error message into an  error message in the current language.</short>
		[SmokeMethod("errorString() const")]
		public override string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		/// <remarks>
		///  Converts an error code and a non-i18n error message into i18n
		///  strings suitable for presentation in a detailed error message box.
		/// <param> name="reqUrl" the request URL that generated this error message
		/// </param><param> name="method" the method that generated this error message
		///  (unimplemented)
		/// </param></remarks>		<return> the following strings: caption, error + description,
		///          causes+solutions
		///          </return>
		/// 		<short>    Converts an error code and a non-i18n error message into i18n  strings suitable for presentation in a detailed error message box.</short>
		public List<string> DetailedErrorStrings(KUrl reqUrl, int method) {
			return (List<string>) interceptor.Invoke("detailedErrorStrings#$", "detailedErrorStrings(const KUrl*, int) const", typeof(List<string>), typeof(KUrl), reqUrl, typeof(int), method);
		}
		public List<string> DetailedErrorStrings(KUrl reqUrl) {
			return (List<string>) interceptor.Invoke("detailedErrorStrings#", "detailedErrorStrings(const KUrl*) const", typeof(List<string>), typeof(KUrl), reqUrl);
		}
		public List<string> DetailedErrorStrings() {
			return (List<string>) interceptor.Invoke("detailedErrorStrings", "detailedErrorStrings() const", typeof(List<string>));
		}
		/// <remarks>
		///  Returns whether message display is enabled or disabled.
		///  See also setInteractive .
		/// </remarks>		<return> true if message display is enabled
		/// </return>
		/// 		<short>    Returns whether message display is enabled or disabled.</short>
		/// 		<see> setInteractive</see>
		public bool IsInteractive() {
			return (bool) interceptor.Invoke("isInteractive", "isInteractive() const", typeof(bool));
		}
		/// <remarks>
		///  Set the parent Job.
		///  One example use of this is when FileCopyJob calls RenameDialog.Open,
		///  it must pass the correct progress ID of the parent CopyJob
		///  (to hide the progress dialog).
		///  You can set the parent job only once. By default a job does not
		///  have a parent job.
		/// <param> name="parentJob" the new parent job
		///          </param></remarks>		<short>    Set the parent Job.</short>
		public void SetParentJob(KIO.Job parentJob) {
			interceptor.Invoke("setParentJob#", "setParentJob(KIO::Job*)", typeof(void), typeof(KIO.Job), parentJob);
		}
		/// <remarks>
		///  Returns the parent job, if there is one.
		/// </remarks>		<return> the parent job, or 0 if there is none
		/// </return>
		/// 		<short>    Returns the parent job, if there is one.</short>
		/// 		<see> setParentJob</see>
		public KIO.Job ParentJob() {
			return (KIO.Job) interceptor.Invoke("parentJob", "parentJob() const", typeof(KIO.Job));
		}
		/// <remarks>
		///  Set meta data to be sent to the slave, replacing existing
		///  meta data.
		/// <param> name="metaData" the meta data to set
		/// </param></remarks>		<short>    Set meta data to be sent to the slave, replacing existing  meta data.</short>
		/// 		<see> addMetaData</see>
		/// 		<see> mergeMetaData</see>
		public void SetMetaData(KIO.MetaData metaData) {
			interceptor.Invoke("setMetaData#", "setMetaData(const KIO::MetaData&)", typeof(void), typeof(KIO.MetaData), metaData);
		}
		/// <remarks>
		///  Add key/value pair to the meta data that is sent to the slave.
		/// <param> name="key" the key of the meta data
		/// </param><param> name="value" the value of the meta data
		/// </param></remarks>		<short>    Add key/value pair to the meta data that is sent to the slave.</short>
		/// 		<see> setMetaData</see>
		/// 		<see> mergeMetaData</see>
		public void AddMetaData(string key, string value) {
			interceptor.Invoke("addMetaData$$", "addMetaData(const QString&, const QString&)", typeof(void), typeof(string), key, typeof(string), value);
		}
		/// <remarks>
		///  Add key/value pairs to the meta data that is sent to the slave.
		///  If a certain key already existed, it will be overridden.
		/// <param> name="values" the meta data to add
		/// </param></remarks>		<short>    Add key/value pairs to the meta data that is sent to the slave.</short>
		/// 		<see> setMetaData</see>
		/// 		<see> mergeMetaData</see>
		public void AddMetaData(Dictionary<string, string> values) {
			interceptor.Invoke("addMetaData?", "addMetaData(const QMap<QString, QString>&)", typeof(void), typeof(Dictionary<string, string>), values);
		}
		/// <remarks>
		///  Add key/value pairs to the meta data that is sent to the slave.
		///  If a certain key already existed, it will remain unchanged.
		/// <param> name="values" the meta data to merge
		/// </param></remarks>		<short>    Add key/value pairs to the meta data that is sent to the slave.</short>
		/// 		<see> setMetaData</see>
		/// 		<see> addMetaData</see>
		public void MergeMetaData(Dictionary<string, string> values) {
			interceptor.Invoke("mergeMetaData?", "mergeMetaData(const QMap<QString, QString>&)", typeof(void), typeof(Dictionary<string, string>), values);
		}
		/// <remarks>
		///          </remarks>		<short>   </short>
		public KIO.MetaData OutgoingMetaData() {
			return (KIO.MetaData) interceptor.Invoke("outgoingMetaData", "outgoingMetaData() const", typeof(KIO.MetaData));
		}
		/// <remarks>
		///  Get meta data received from the slave.
		///  (Valid when first data is received and/or slave is finished)
		/// </remarks>		<return> the job's meta data
		///          </return>
		/// 		<short>    Get meta data received from the slave.</short>
		public KIO.MetaData MetaData() {
			return (KIO.MetaData) interceptor.Invoke("metaData", "metaData() const", typeof(KIO.MetaData));
		}
		/// <remarks>
		///  Query meta data received from the slave.
		///  (Valid when first data is received and/or slave is finished)
		/// <param> name="key" the key of the meta data to retrieve
		/// </param></remarks>		<return> the value of the meta data, or string() if the
		///          <code>key</code> does not exist
		///          </return>
		/// 		<short>    Query meta data received from the slave.</short>
		public string QueryMetaData(string key) {
			return (string) interceptor.Invoke("queryMetaData$", "queryMetaData(const QString&)", typeof(string), typeof(string), key);
		}
		public Job() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Job", "Job()", typeof(void));
		}
		/// <remarks>
		///  Abort this job.
		///  This kills all subjobs and deletes the job.
		///          </remarks>		<short>    Abort this job.</short>
		[SmokeMethod("doKill()")]
		protected override bool DoKill() {
			return (bool) interceptor.Invoke("doKill", "doKill()", typeof(bool));
		}
		/// <remarks>
		///  Suspend this job
		/// </remarks>		<short>    Suspend this job </short>
		/// 		<see> resume</see>
		[SmokeMethod("doSuspend()")]
		protected override bool DoSuspend() {
			return (bool) interceptor.Invoke("doSuspend", "doSuspend()", typeof(bool));
		}
		/// <remarks>
		///  Resume this job
		/// </remarks>		<short>    Resume this job </short>
		/// 		<see> suspend</see>
		[SmokeMethod("doResume()")]
		protected override bool DoResume() {
			return (bool) interceptor.Invoke("doResume", "doResume()", typeof(bool));
		}
		/// <remarks>
		///  Add a job that has to be finished before a result
		///  is emitted. This has obviously to be called before
		///  the finish signal is emitted by the slave.
		/// <param> name="job" the subjob to add
		///          </param></remarks>		<short>    Add a job that has to be finished before a result  is emitted.</short>
		[SmokeMethod("addSubjob(KJob*)")]
		protected override bool AddSubjob(KJob job) {
			return (bool) interceptor.Invoke("addSubjob#", "addSubjob(KJob*)", typeof(bool), typeof(KJob), job);
		}
		/// <remarks>
		///  Mark a sub job as being done.
		///  KDE4 change: this doesn't terminate the parent job anymore, call emitResult to do that.
		/// <param> name="job" the subjob to remove
		///          </param></remarks>		<short>    Mark a sub job as being done.</short>
		[SmokeMethod("removeSubjob(KJob*)")]
		protected override bool RemoveSubjob(KJob job) {
			return (bool) interceptor.Invoke("removeSubjob#", "removeSubjob(KJob*)", typeof(bool), typeof(KJob), job);
		}
		~Job() {
			interceptor.Invoke("~Job", "~Job()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Job", "~Job()", typeof(void));
		}
		protected new IJobSignals Emit {
			get { return (IJobSignals) Q_EMIT; }
		}
	}

	public interface IJobSignals : IKCompositeJobSignals {
		/// <remarks>
		///  Emitted when the slave successfully connected to the host.
		///  There is no guarantee the slave will send this, and this is
		///  currently unused (in the applications).
		/// <param> name="job" the job that emitted this signal
		///          </param></remarks>		<short>    Emitted when the slave successfully connected to the host.</short>
		[Q_SIGNAL("void connected(KIO::Job*)")]
		void Connected(KIO.Job job);
	}
}
