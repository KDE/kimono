//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQSignalMapperSignals"></see> for signals emitted by QSignalMapper
    /// </remarks>
    [SmokeClass("QSignalMapper")]
    public class QSignalMapper : QObject, IDisposable {
        protected QSignalMapper(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QSignalMapper), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QSignalMapper() {
            staticInterceptor = new SmokeInvocation(typeof(QSignalMapper), null);
        }
        public QSignalMapper(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSignalMapper#", "QSignalMapper(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QSignalMapper() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSignalMapper", "QSignalMapper()", typeof(void));
        }
        public void SetMapping(QObject sender, int id) {
            interceptor.Invoke("setMapping#$", "setMapping(QObject*, int)", typeof(void), typeof(QObject), sender, typeof(int), id);
        }
        public void SetMapping(QObject sender, string text) {
            interceptor.Invoke("setMapping#$", "setMapping(QObject*, const QString&)", typeof(void), typeof(QObject), sender, typeof(string), text);
        }
        public void SetMapping(QObject sender, QWidget widget) {
            interceptor.Invoke("setMapping##", "setMapping(QObject*, QWidget*)", typeof(void), typeof(QObject), sender, typeof(QWidget), widget);
        }
        public void SetMapping(QObject sender, QObject arg2) {
            interceptor.Invoke("setMapping##", "setMapping(QObject*, QObject*)", typeof(void), typeof(QObject), sender, typeof(QObject), arg2);
        }
        public void RemoveMappings(QObject sender) {
            interceptor.Invoke("removeMappings#", "removeMappings(QObject*)", typeof(void), typeof(QObject), sender);
        }
        public QObject Mapping(int id) {
            return (QObject) interceptor.Invoke("mapping$", "mapping(int) const", typeof(QObject), typeof(int), id);
        }
        public QObject Mapping(string text) {
            return (QObject) interceptor.Invoke("mapping$", "mapping(const QString&) const", typeof(QObject), typeof(string), text);
        }
        public QObject Mapping(QWidget widget) {
            return (QObject) interceptor.Invoke("mapping#", "mapping(QWidget*) const", typeof(QObject), typeof(QWidget), widget);
        }
        public QObject Mapping(QObject arg1) {
            return (QObject) interceptor.Invoke("mapping#", "mapping(QObject*) const", typeof(QObject), typeof(QObject), arg1);
        }
        [Q_SLOT("void map()")]
        public void Map() {
            interceptor.Invoke("map", "map()", typeof(void));
        }
        [Q_SLOT("void map(QObject*)")]
        public void Map(QObject sender) {
            interceptor.Invoke("map#", "map(QObject*)", typeof(void), typeof(QObject), sender);
        }
        ~QSignalMapper() {
            interceptor.Invoke("~QSignalMapper", "~QSignalMapper()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QSignalMapper", "~QSignalMapper()", typeof(void));
        }
        public event SlotFunc<int> SignalMapped_int {
            add { QObject.Connect(this, SIGNAL("mapped(int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("mapped(int)"), value); }
        }
        public event SlotFunc<string> SignalMapped_string {
            add { QObject.Connect(this, SIGNAL("mapped(QString)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("mapped(QString)"), value); }
        }
        public event SlotFunc<QWidget> SignalMapped_QWidget {
            add { QObject.Connect(this, SIGNAL("mapped(QWidget*)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("mapped(QWidget*)"), value); }
        }
        public event SlotFunc<QObject> SignalMapped_QObject {
            add { QObject.Connect(this, SIGNAL("mapped(QObject*)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("mapped(QObject*)"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQSignalMapperSignals Emit {
            get { return (IQSignalMapperSignals) Q_EMIT; }
        }
    }

    public interface IQSignalMapperSignals : IQObjectSignals {
        [Q_SIGNAL("void mapped(int)")]
        void Mapped(int arg1);
        [Q_SIGNAL("void mapped(QString)")]
        void Mapped(string arg1);
        [Q_SIGNAL("void mapped(QWidget*)")]
        void Mapped(QWidget arg1);
        [Q_SIGNAL("void mapped(QObject*)")]
        void Mapped(QObject arg1);
    }
}
