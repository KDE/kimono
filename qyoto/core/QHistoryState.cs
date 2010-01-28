//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QHistoryState")]
    public class QHistoryState : QAbstractState, IDisposable {
        protected QHistoryState(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QHistoryState), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QHistoryState() {
            staticInterceptor = new SmokeInvocation(typeof(QHistoryState), null);
        }
        public enum HistoryType {
            ShallowHistory = 0,
            DeepHistory = 1,
        }
        [Q_PROPERTY("QAbstractState*", "defaultState")]
        public QAbstractState DefaultState {
            get { return (QAbstractState) interceptor.Invoke("defaultState", "defaultState()", typeof(QAbstractState)); }
            set { interceptor.Invoke("setDefaultState#", "setDefaultState(QAbstractState*)", typeof(void), typeof(QAbstractState), value); }
        }
        [Q_PROPERTY("QHistoryState::HistoryType", "historyType")]
        public QHistoryState.HistoryType historyType {
            get { return (QHistoryState.HistoryType) interceptor.Invoke("historyType", "historyType()", typeof(QHistoryState.HistoryType)); }
            set { interceptor.Invoke("setHistoryType$", "setHistoryType(QHistoryState::HistoryType)", typeof(void), typeof(QHistoryState.HistoryType), value); }
        }
        public QHistoryState(QState parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QHistoryState#", "QHistoryState(QState*)", typeof(void), typeof(QState), parent);
        }
        public QHistoryState() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QHistoryState", "QHistoryState()", typeof(void));
        }
        public QHistoryState(QHistoryState.HistoryType type, QState parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QHistoryState$#", "QHistoryState(QHistoryState::HistoryType, QState*)", typeof(void), typeof(QHistoryState.HistoryType), type, typeof(QState), parent);
        }
        public QHistoryState(QHistoryState.HistoryType type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QHistoryState$", "QHistoryState(QHistoryState::HistoryType)", typeof(void), typeof(QHistoryState.HistoryType), type);
        }
        [SmokeMethod("onEntry(QEvent*)")]
        protected override void OnEntry(QEvent arg1) {
            interceptor.Invoke("onEntry#", "onEntry(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("onExit(QEvent*)")]
        protected override void OnExit(QEvent arg1) {
            interceptor.Invoke("onExit#", "onExit(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        ~QHistoryState() {
            interceptor.Invoke("~QHistoryState", "~QHistoryState()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QHistoryState", "~QHistoryState()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQHistoryStateSignals Emit {
            get { return (IQHistoryStateSignals) Q_EMIT; }
        }
    }

    public interface IQHistoryStateSignals : IQAbstractStateSignals {
    }
}