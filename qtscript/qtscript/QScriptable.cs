//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QScriptable")]
    public class QScriptable : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QScriptable(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QScriptable), this);
        }
        public QScriptable() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QScriptable", "QScriptable()", typeof(void));
        }
        public QScriptEngine Engine() {
            return (QScriptEngine) interceptor.Invoke("engine", "engine() const", typeof(QScriptEngine));
        }
        public QScriptContext Context() {
            return (QScriptContext) interceptor.Invoke("context", "context() const", typeof(QScriptContext));
        }
        public QScriptValue ThisObject() {
            return (QScriptValue) interceptor.Invoke("thisObject", "thisObject() const", typeof(QScriptValue));
        }
        public int ArgumentCount() {
            return (int) interceptor.Invoke("argumentCount", "argumentCount() const", typeof(int));
        }
        public QScriptValue Argument(int index) {
            return (QScriptValue) interceptor.Invoke("argument$", "argument(int) const", typeof(QScriptValue), typeof(int), index);
        }
        ~QScriptable() {
            interceptor.Invoke("~QScriptable", "~QScriptable()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QScriptable", "~QScriptable()", typeof(void));
        }
    }
}
