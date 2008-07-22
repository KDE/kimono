//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  An extended QTextBrowser.
    ///  By default it will
    ///  invoke the system mailer or the system browser when a link is
    ///  activated, or it can emit the signal urlClick() or mailClick()
    ///  when a link is activated.
    ///  If the link starts with the text "whatsthis:" a QWhatsThis
    ///  box will appear and then display the rest of the text.
    ///  \image html ktextbrowser.png "KDE Text Browser"
    ///  See <see cref="IKTextBrowserSignals"></see> for signals emitted by KTextBrowser
    /// </remarks>        <author> Espen Sand (espensa@online.no)
    ///  </author>
    ///         <short> Extended QTextBrowser. </short>
    [SmokeClass("KTextBrowser")]
    public class KTextBrowser : QTextBrowser, IDisposable {
        protected KTextBrowser(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTextBrowser), this);
        }
        [Q_PROPERTY("bool", "notifyClick")]
        public bool NotifyClick {
            get { return (bool) interceptor.Invoke("isNotifyClick", "isNotifyClick()", typeof(bool)); }
            set { interceptor.Invoke("setNotifyClick$", "setNotifyClick(bool)", typeof(void), typeof(bool), value); }
        }
        /// <remarks>
        ///  Creates a new text browser.
        /// <param> name="parent" Parent of the widget.
        /// </param><param> name="notifyClick" <code>true</code> causes signals to be emitted.
        ///      </param></remarks>        <short>    Creates a new text browser.</short>
        public KTextBrowser(QWidget parent, bool notifyClick) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTextBrowser#$", "KTextBrowser(QWidget*, bool)", typeof(void), typeof(QWidget), parent, typeof(bool), notifyClick);
        }
        public KTextBrowser(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTextBrowser#", "KTextBrowser(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KTextBrowser() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTextBrowser", "KTextBrowser()", typeof(void));
        }
        /// <remarks>
        ///  Reimplemented to NOT set the source but to do the special handling.
        ///  Do not call.
        ///      </remarks>        <short>    Reimplemented to NOT set the source but to do the special handling.</short>
        [SmokeMethod("setSource(const QUrl&)")]
        protected new virtual void SetSource(QUrl name) {
            interceptor.Invoke("setSource#", "setSource(const QUrl&)", typeof(void), typeof(QUrl), name);
        }
        /// <remarks>
        ///  Makes sure Key_Escape is ignored
        ///      </remarks>        <short>    Makes sure Key_Escape is ignored      </short>
        [SmokeMethod("keyPressEvent(QKeyEvent*)")]
        protected override void KeyPressEvent(QKeyEvent arg1) {
            interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
        }
        /// <remarks>
        ///  Reimplemented to support Qt2 behavior (Ctrl-Wheel = fast scroll)
        ///      </remarks>        <short>    Reimplemented to support Qt2 behavior (Ctrl-Wheel = fast scroll)      </short>
        [SmokeMethod("wheelEvent(QWheelEvent*)")]
        protected override void WheelEvent(QWheelEvent arg1) {
            interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
        }
        /// <remarks>
        ///  Re-implemented for internal reasons.  API not affected.
        ///  See QLineEdit.CreatePopupMenu().
        ///     </remarks>        <short>    Re-implemented for internal reasons.</short>
        [SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
        protected override void ContextMenuEvent(QContextMenuEvent arg1) {
            interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
        }
        ~KTextBrowser() {
            interceptor.Invoke("~KTextBrowser", "~KTextBrowser()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KTextBrowser", "~KTextBrowser()", typeof(void));
        }
        protected new IKTextBrowserSignals Emit {
            get { return (IKTextBrowserSignals) Q_EMIT; }
        }
    }

    public interface IKTextBrowserSignals : IQTextBrowserSignals {
        /// <remarks>
        ///  Emitted when a mail link has been activated and the widget has
        ///  been configured to emit the signal.
        /// <param> name="name" The destination name. It is string() at the moment.
        /// </param><param> name="address" The destination address.
        ///      </param></remarks>        <short>    Emitted when a mail link has been activated and the widget has  been configured to emit the signal.</short>
        [Q_SIGNAL("void mailClick(QString, QString)")]
        void MailClick(string name, string address);
        /// <remarks>
        ///  Emitted if mailClick() is not emitted and the widget has been
        ///  configured to emit the signal.
        /// <param> name="url" The destination address.
        ///      </param></remarks>        <short>    Emitted if mailClick() is not emitted and the widget has been  configured to emit the signal.</short>
        [Q_SIGNAL("void urlClick(QString)")]
        void UrlClick(string url);
    }
}
