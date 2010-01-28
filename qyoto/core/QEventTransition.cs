//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QEventTransition")]
    public class QEventTransition : QAbstractTransition, IDisposable {
        protected QEventTransition(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QEventTransition), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QEventTransition() {
            staticInterceptor = new SmokeInvocation(typeof(QEventTransition), null);
        }
        [Q_PROPERTY("QObject*", "eventSource")]
        public QObject EventSource {
            get { return (QObject) interceptor.Invoke("eventSource", "eventSource()", typeof(QObject)); }
            set { interceptor.Invoke("setEventSource#", "setEventSource(QObject*)", typeof(void), typeof(QObject), value); }
        }
        [Q_PROPERTY("QEvent::Type", "eventType")]
        public QEvent.TypeOf EventType {
            get { return (QEvent.TypeOf) interceptor.Invoke("eventType", "eventType()", typeof(QEvent.TypeOf)); }
            set { interceptor.Invoke("setEventType$", "setEventType(QEvent::Type)", typeof(void), typeof(QEvent.TypeOf), value); }
        }
        // QEventTransition* QEventTransition(QEventTransitionPrivate& arg1,QState* arg2); >>>> NOT CONVERTED
        // QEventTransition* QEventTransition(QEventTransitionPrivate& arg1,QObject* arg2,QEvent::Type arg3,QState* arg4); >>>> NOT CONVERTED
        public QEventTransition(QState sourceState) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QEventTransition#", "QEventTransition(QState*)", typeof(void), typeof(QState), sourceState);
        }
        public QEventTransition() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QEventTransition", "QEventTransition()", typeof(void));
        }
        public QEventTransition(QObject arg1, QEvent.TypeOf type, QState sourceState) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QEventTransition#$#", "QEventTransition(QObject*, QEvent::Type, QState*)", typeof(void), typeof(QObject), arg1, typeof(QEvent.TypeOf), type, typeof(QState), sourceState);
        }
        public QEventTransition(QObject arg1, QEvent.TypeOf type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QEventTransition#$", "QEventTransition(QObject*, QEvent::Type)", typeof(void), typeof(QObject), arg1, typeof(QEvent.TypeOf), type);
        }
        [SmokeMethod("eventTest(QEvent*)")]
        protected override bool EventTest(QEvent arg1) {
            return (bool) interceptor.Invoke("eventTest#", "eventTest(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        [SmokeMethod("onTransition(QEvent*)")]
        protected override void OnTransition(QEvent arg1) {
            interceptor.Invoke("onTransition#", "onTransition(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        ~QEventTransition() {
            interceptor.Invoke("~QEventTransition", "~QEventTransition()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QEventTransition", "~QEventTransition()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQEventTransitionSignals Emit {
            get { return (IQEventTransitionSignals) Q_EMIT; }
        }
    }

    public interface IQEventTransitionSignals : IQAbstractTransitionSignals {
    }
}