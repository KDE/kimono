//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTapGesture")]
    public class QTapGesture : QGesture, IDisposable {
        protected QTapGesture(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTapGesture), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTapGesture() {
            staticInterceptor = new SmokeInvocation(typeof(QTapGesture), null);
        }
        [Q_PROPERTY("QPointF", "position")]
        public QPointF Position {
            get { return (QPointF) interceptor.Invoke("position", "position()", typeof(QPointF)); }
            set { interceptor.Invoke("setPosition#", "setPosition(QPointF)", typeof(void), typeof(QPointF), value); }
        }
        public QTapGesture(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTapGesture#", "QTapGesture(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QTapGesture() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTapGesture", "QTapGesture()", typeof(void));
        }
        ~QTapGesture() {
            interceptor.Invoke("~QTapGesture", "~QTapGesture()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTapGesture", "~QTapGesture()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQTapGestureSignals Emit {
            get { return (IQTapGestureSignals) Q_EMIT; }
        }
    }

    public interface IQTapGestureSignals : IQGestureSignals {
    }
}