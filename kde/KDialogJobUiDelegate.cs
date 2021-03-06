//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  A UI delegate using KMessageBox for interaction (showing errors and warnings).
    ///  </remarks>        <short>    A UI delegate using KMessageBox for interaction (showing errors and warnings).</short>
    [SmokeClass("KDialogJobUiDelegate")]
    public class KDialogJobUiDelegate : KJobUiDelegate, IDisposable {
        protected KDialogJobUiDelegate(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KDialogJobUiDelegate), this);
        }
        /// <remarks>
        ///  Constructs a new KDialogJobUiDelegate.
        ///      </remarks>        <short>    Constructs a new KDialogJobUiDelegate.</short>
        public KDialogJobUiDelegate() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDialogJobUiDelegate", "KDialogJobUiDelegate()", typeof(void));
        }
        /// <remarks>
        ///  Associate this job with a window given by <code>window.</code>
        /// <param> name="window" the window to associate to
        /// </param></remarks>        <short>    Associate this job with a window given by <code>window.</code></short>
        ///         <see> window</see>
        [SmokeMethod("setWindow(QWidget*)")]
        public virtual void SetWindow(QWidget window) {
            interceptor.Invoke("setWindow#", "setWindow(QWidget*)", typeof(void), typeof(QWidget), window);
        }
        /// <remarks>
        ///  Returns the window this job is associated with.
        /// </remarks>        <return> the associated window
        /// </return>
        ///         <short>    Returns the window this job is associated with.</short>
        ///         <see> setWindow</see>
        public QWidget Window() {
            return (QWidget) interceptor.Invoke("window", "window() const", typeof(QWidget));
        }
        /// <remarks>
        ///  Updates the last user action timestamp to the given time.
        ///  See KApplication.UpdateUserTimestamp().
        ///      </remarks>        <short>    Updates the last user action timestamp to the given time.</short>
        public void UpdateUserTimestamp(ulong time) {
            interceptor.Invoke("updateUserTimestamp$", "updateUserTimestamp(unsigned long)", typeof(void), typeof(ulong), time);
        }
        /// <remarks>
        ///      </remarks>        <short>   </short>
        public ulong UserTimestamp() {
            return (ulong) interceptor.Invoke("userTimestamp", "userTimestamp() const", typeof(ulong));
        }
        [SmokeMethod("showErrorMessage()")]
        public override void ShowErrorMessage() {
            interceptor.Invoke("showErrorMessage", "showErrorMessage()", typeof(void));
        }
        [Q_SLOT("void slotWarning(KJob*, QString, QString)")]
        [SmokeMethod("slotWarning(KJob*, const QString&, const QString&)")]
        protected override void SlotWarning(KJob job, string plain, string rich) {
            interceptor.Invoke("slotWarning#$$", "slotWarning(KJob*, const QString&, const QString&)", typeof(void), typeof(KJob), job, typeof(string), plain, typeof(string), rich);
        }
        ~KDialogJobUiDelegate() {
            interceptor.Invoke("~KDialogJobUiDelegate", "~KDialogJobUiDelegate()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KDialogJobUiDelegate", "~KDialogJobUiDelegate()", typeof(void));
        }
        protected new IKDialogJobUiDelegateSignals Emit {
            get { return (IKDialogJobUiDelegateSignals) Q_EMIT; }
        }
    }

    public interface IKDialogJobUiDelegateSignals : IKJobUiDelegateSignals {
    }
}
