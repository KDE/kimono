//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  An action to allow changing of the font size.
    ///  This action will be shown as a combobox on a toolbar with a proper set of font sizes.
    ///   See <see cref="IKFontSizeActionSignals"></see> for signals emitted by KFontSizeAction
    /// </remarks>        <short>    An action to allow changing of the font size.</short>
    [SmokeClass("KFontSizeAction")]
    public class KFontSizeAction : KSelectAction, IDisposable {
        protected KFontSizeAction(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KFontSizeAction), this);
        }
        [Q_PROPERTY("int", "fontSize")]
        public int FontSize {
            get { return (int) interceptor.Invoke("fontSize", "fontSize()", typeof(int)); }
            set { interceptor.Invoke("setFontSize$", "setFontSize(int)", typeof(void), typeof(int), value); }
        }
        public KFontSizeAction(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KFontSizeAction#", "KFontSizeAction(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public KFontSizeAction(string text, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KFontSizeAction$#", "KFontSizeAction(const QString&, QObject*)", typeof(void), typeof(string), text, typeof(QObject), parent);
        }
        public KFontSizeAction(KIcon icon, string text, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KFontSizeAction#$#", "KFontSizeAction(const KIcon&, const QString&, QObject*)", typeof(void), typeof(KIcon), icon, typeof(string), text, typeof(QObject), parent);
        }
        /// <remarks>
        ///  This function is called whenever an action from the selections is triggered.
        ///      </remarks>        <short>    This function is called whenever an action from the selections is triggered.</short>
        [Q_SLOT("void actionTriggered(QAction*)")]
        [SmokeMethod("actionTriggered(QAction*)")]
        protected override void ActionTriggered(QAction action) {
            interceptor.Invoke("actionTriggered#", "actionTriggered(QAction*)", typeof(void), typeof(QAction), action);
        }
        ~KFontSizeAction() {
            interceptor.Invoke("~KFontSizeAction", "~KFontSizeAction()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KFontSizeAction", "~KFontSizeAction()", typeof(void));
        }
        protected new IKFontSizeActionSignals Emit {
            get { return (IKFontSizeActionSignals) Q_EMIT; }
        }
    }

    public interface IKFontSizeActionSignals : IKSelectActionSignals {
        [Q_SIGNAL("void fontSizeChanged(int)")]
        void FontSizeChanged(int arg1);
    }
}
