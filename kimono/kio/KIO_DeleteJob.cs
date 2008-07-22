//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  A more complex Job to delete files and directories.
    ///  Don't create the job directly, but use KIO.Del() instead.
    ///  See <see cref="IDeleteJobSignals"></see> for signals emitted by DeleteJob
    /// </remarks>        <short>    A more complex Job to delete files and directories.</short>
    ///         <see> del</see>
    [SmokeClass("KIO::DeleteJob")]
    public class DeleteJob : KIO.Job, IDisposable {
        protected DeleteJob(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(DeleteJob), this);
        }
        // KIO::DeleteJob* DeleteJob(KIO::DeleteJobPrivate& arg1); >>>> NOT CONVERTED
        /// <remarks>
        ///  Returns the list of URLs.
        /// </remarks>        <return> the list of URLs.
        /// 	 </return>
        ///         <short>    Returns the list of URLs.</short>
        public List<KUrl> Urls() {
            return (List<KUrl>) interceptor.Invoke("urls", "urls() const", typeof(List<KUrl>));
        }
        [Q_SLOT("void slotResult(KJob*)")]
        [SmokeMethod("slotResult(KJob*)")]
        protected override void SlotResult(KJob job) {
            interceptor.Invoke("slotResult#", "slotResult(KJob*)", typeof(void), typeof(KJob), job);
        }
        ~DeleteJob() {
            interceptor.Invoke("~DeleteJob", "~DeleteJob()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~DeleteJob", "~DeleteJob()", typeof(void));
        }
        protected new IDeleteJobSignals Emit {
            get { return (IDeleteJobSignals) Q_EMIT; }
        }
    }

    public interface IDeleteJobSignals : KIO.IJobSignals {
        /// <remarks>
        ///  Emitted when the total number of files is known.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="files" the total number of files
        /// 	 </param></remarks>        <short>    Emitted when the total number of files is known.</short>
        [Q_SIGNAL("void totalFiles(KJob*, unsigned long)")]
        void TotalFiles(KJob job, ulong files);
        /// <remarks>
        ///  Emitted when the toal number of direcotries is known.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="dirs" the total number of directories
        /// 	 </param></remarks>        <short>    Emitted when the toal number of direcotries is known.</short>
        [Q_SIGNAL("void totalDirs(KJob*, unsigned long)")]
        void TotalDirs(KJob job, ulong dirs);
        /// <remarks>
        ///  Sends the number of processed files.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="files" the number of processed files
        /// 	 </param></remarks>        <short>    Sends the number of processed files.</short>
        [Q_SIGNAL("void processedFiles(KIO::Job*, unsigned long)")]
        void ProcessedFiles(KIO.Job job, ulong files);
        /// <remarks>
        ///  Sends the number of processed directories.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="dirs" the number of processed dirs
        /// 	 </param></remarks>        <short>    Sends the number of processed directories.</short>
        [Q_SIGNAL("void processedDirs(KIO::Job*, unsigned long)")]
        void ProcessedDirs(KIO.Job job, ulong dirs);
        /// <remarks>
        ///  Sends the URL of the file that is currently being deleted.
        /// <param> name="job" the job that emitted this signal
        /// </param><param> name="file" the URL of the file or directory that is being
        ///         deleted
        /// 	 </param></remarks>        <short>    Sends the URL of the file that is currently being deleted.</short>
        [Q_SIGNAL("void deleting(KIO::Job*, KUrl)")]
        void Deleting(KIO.Job job, KUrl file);
    }
}
