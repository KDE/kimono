//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  This job commits all changes of this transaction.
    /// </remarks>        <author> Volker Krause <vkrause@kde.org>
    ///  </author>
    ///         <short> Job that commits a session-global transaction. </short>
    [SmokeClass("Akonadi::TransactionCommitJob")]
    public class TransactionCommitJob : Akonadi.Job, IDisposable {
        protected TransactionCommitJob(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(TransactionCommitJob), this);
        }
        /// <remarks>
        ///  Creates a new transaction commit job.
        ///  The parent must be the same parent as for the TransactionBeginJob.
        /// <param> name="parent" The parent job or Session, must not be 0.
        ///      </param></remarks>        <short>    Creates a new transaction commit job.</short>
        public TransactionCommitJob(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("TransactionCommitJob#", "TransactionCommitJob(QObject*)", typeof(void), typeof(QObject), parent);
        }
        [SmokeMethod("doStart()")]
        protected override void DoStart() {
            interceptor.Invoke("doStart", "doStart()", typeof(void));
        }
        ~TransactionCommitJob() {
            interceptor.Invoke("~TransactionCommitJob", "~TransactionCommitJob()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~TransactionCommitJob", "~TransactionCommitJob()", typeof(void));
        }
        protected new ITransactionCommitJobSignals Emit {
            get { return (ITransactionCommitJobSignals) Q_EMIT; }
        }
    }

    public interface ITransactionCommitJobSignals : Akonadi.IJobSignals {
    }
}
