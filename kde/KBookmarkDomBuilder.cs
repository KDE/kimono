//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    [SmokeClass("KBookmarkDomBuilder")]
    public class KBookmarkDomBuilder : QObject, IDisposable {
        protected KBookmarkDomBuilder(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KBookmarkDomBuilder), this);
        }
        public KBookmarkDomBuilder(KBookmarkGroup group, KBookmarkManager arg2) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KBookmarkDomBuilder##", "KBookmarkDomBuilder(const KBookmarkGroup&, KBookmarkManager*)", typeof(void), typeof(KBookmarkGroup), group, typeof(KBookmarkManager), arg2);
        }
        public void ConnectImporter(QObject arg1) {
            interceptor.Invoke("connectImporter#", "connectImporter(const QObject*)", typeof(void), typeof(QObject), arg1);
        }
        [Q_SLOT("void newBookmark(QString, QString, QString)")]
        protected void NewBookmark(string text, string url, string additionalInfo) {
            interceptor.Invoke("newBookmark$$$", "newBookmark(const QString&, const QString&, const QString&)", typeof(void), typeof(string), text, typeof(string), url, typeof(string), additionalInfo);
        }
        [Q_SLOT("void newFolder(QString, bool, QString)")]
        protected void NewFolder(string text, bool open, string additionalInfo) {
            interceptor.Invoke("newFolder$$$", "newFolder(const QString&, bool, const QString&)", typeof(void), typeof(string), text, typeof(bool), open, typeof(string), additionalInfo);
        }
        [Q_SLOT("void newSeparator()")]
        protected void NewSeparator() {
            interceptor.Invoke("newSeparator", "newSeparator()", typeof(void));
        }
        [Q_SLOT("void endFolder()")]
        protected void EndFolder() {
            interceptor.Invoke("endFolder", "endFolder()", typeof(void));
        }
        ~KBookmarkDomBuilder() {
            interceptor.Invoke("~KBookmarkDomBuilder", "~KBookmarkDomBuilder()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KBookmarkDomBuilder", "~KBookmarkDomBuilder()", typeof(void));
        }
        protected new IKBookmarkDomBuilderSignals Emit {
            get { return (IKBookmarkDomBuilderSignals) Q_EMIT; }
        }
    }

    public interface IKBookmarkDomBuilderSignals : IQObjectSignals {
    }
}
