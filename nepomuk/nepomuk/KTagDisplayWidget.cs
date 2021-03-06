//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  The KTagDisplayWidget shows a list of tags and allows clicking each of them.
    ///   See <see cref="IKTagDisplayWidgetSignals"></see> for signals emitted by KTagDisplayWidget
    /// </remarks>        <short>    The KTagDisplayWidget shows a list of tags and allows clicking each of them.</short>
    [SmokeClass("KTagDisplayWidget")]
    public class KTagDisplayWidget : QWidget, IDisposable {
        protected KTagDisplayWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KTagDisplayWidget), this);
        }
        public KTagDisplayWidget(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTagDisplayWidget#", "KTagDisplayWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KTagDisplayWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KTagDisplayWidget", "KTagDisplayWidget()", typeof(void));
        }
        /// <remarks>
        ///  Set \a tags to be displayed.
        ///      </remarks>        <short>    Set \a tags to be displayed.</short>
        [Q_SLOT("void setTags(QStringList)")]
        public void SetTags(List<string> tags) {
            interceptor.Invoke("setTags?", "setTags(const QStringList&)", typeof(void), typeof(List<string>), tags);
        }
        /// <remarks>
        ///  Add \a tag to be displayed.
        ///  Existing tags with the same name will be overwritten.
        ///      </remarks>        <short>    Add \a tag to be displayed.</short>
        [Q_SLOT("void addTag(QString)")]
        public void AddTag(string tag) {
            interceptor.Invoke("addTag$", "addTag(const QString&)", typeof(void), typeof(string), tag);
        }
        /// <remarks>
        ///  Add a set of tags to be displayed.
        ///  Existing tags with the same name will be overwritten.
        ///      </remarks>        <short>    Add a set of tags to be displayed.</short>
        [Q_SLOT("void addTags(QStringList)")]
        public void AddTags(List<string> tags) {
            interceptor.Invoke("addTags?", "addTags(const QStringList&)", typeof(void), typeof(List<string>), tags);
        }
        /// <remarks>
        ///  Remove all tags.
        ///      </remarks>        <short>    Remove all tags.</short>
        [Q_SLOT("void clear()")]
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        ~KTagDisplayWidget() {
            interceptor.Invoke("~KTagDisplayWidget", "~KTagDisplayWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KTagDisplayWidget", "~KTagDisplayWidget()", typeof(void));
        }
        protected new IKTagDisplayWidgetSignals Emit {
            get { return (IKTagDisplayWidgetSignals) Q_EMIT; }
        }
    }

    public interface IKTagDisplayWidgetSignals : IQWidgetSignals {
        [Q_SIGNAL("void tagClicked(QString)")]
        void TagClicked(string tag);
    }
}
