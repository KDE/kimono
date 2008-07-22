//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Runtime.InteropServices;
    [SmokeClass("QScriptClass")]
    public class QScriptClass : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QScriptClass(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QScriptClass), this);
        }
        public enum QueryFlag {
            HandlesReadAccess = 0x01,
            HandlesWriteAccess = 0x02,
        }
        public enum Extension {
            Callable = 0,
        }
        // QScriptClass* QScriptClass(QScriptEngine* arg1,QScriptClassPrivate& arg2); >>>> NOT CONVERTED
        public QScriptClass(QScriptEngine engine) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QScriptClass#", "QScriptClass(QScriptEngine*)", typeof(void), typeof(QScriptEngine), engine);
        }
        public QScriptEngine Engine() {
            return (QScriptEngine) interceptor.Invoke("engine", "engine() const", typeof(QScriptEngine));
        }
        [SmokeMethod("queryProperty(const QScriptValue&, const QScriptString&, QScriptClass::QueryFlags, uint*)")]
        public virtual uint QueryProperty(QScriptValue arg1, QScriptString name, uint flags, ref int id) {
            StackItem[] stack = new StackItem[5];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(arg1);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(arg1);
#endif
#if DEBUG
            stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(name);
#else
            stack[2].s_class = (IntPtr) GCHandle.Alloc(name);
#endif
            stack[3].s_uint = flags;
            stack[4].s_int = id;
            interceptor.Invoke("queryProperty##$$", "queryProperty(const QScriptValue&, const QScriptString&, QScriptClass::QueryFlags, uint*)", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
            ((GCHandle) stack[2].s_class).Free();
#endif
            id = stack[4].s_int;
            return stack[0].s_uint;
        }
        [SmokeMethod("property(const QScriptValue&, const QScriptString&, uint)")]
        public virtual QScriptValue Property(QScriptValue arg1, QScriptString name, uint id) {
            return (QScriptValue) interceptor.Invoke("property##$", "property(const QScriptValue&, const QScriptString&, uint)", typeof(QScriptValue), typeof(QScriptValue), arg1, typeof(QScriptString), name, typeof(uint), id);
        }
        [SmokeMethod("setProperty(QScriptValue&, const QScriptString&, uint, const QScriptValue&)")]
        public virtual void SetProperty(QScriptValue arg1, QScriptString name, uint id, QScriptValue value) {
            interceptor.Invoke("setProperty##$#", "setProperty(QScriptValue&, const QScriptString&, uint, const QScriptValue&)", typeof(void), typeof(QScriptValue), arg1, typeof(QScriptString), name, typeof(uint), id, typeof(QScriptValue), value);
        }
        [SmokeMethod("propertyFlags(const QScriptValue&, const QScriptString&, uint)")]
        public virtual uint PropertyFlags(QScriptValue arg1, QScriptString name, uint id) {
            return (uint) interceptor.Invoke("propertyFlags##$", "propertyFlags(const QScriptValue&, const QScriptString&, uint)", typeof(uint), typeof(QScriptValue), arg1, typeof(QScriptString), name, typeof(uint), id);
        }
        [SmokeMethod("newIterator(const QScriptValue&)")]
        public virtual QScriptClassPropertyIterator NewIterator(QScriptValue arg1) {
            return (QScriptClassPropertyIterator) interceptor.Invoke("newIterator#", "newIterator(const QScriptValue&)", typeof(QScriptClassPropertyIterator), typeof(QScriptValue), arg1);
        }
        [SmokeMethod("prototype() const")]
        public virtual QScriptValue Prototype() {
            return (QScriptValue) interceptor.Invoke("prototype", "prototype() const", typeof(QScriptValue));
        }
        [SmokeMethod("name() const")]
        public virtual string Name() {
            return (string) interceptor.Invoke("name", "name() const", typeof(string));
        }
        [SmokeMethod("supportsExtension(QScriptClass::Extension) const")]
        public virtual bool SupportsExtension(QScriptClass.Extension extension) {
            return (bool) interceptor.Invoke("supportsExtension$", "supportsExtension(QScriptClass::Extension) const", typeof(bool), typeof(QScriptClass.Extension), extension);
        }
        [SmokeMethod("extension(QScriptClass::Extension, const QVariant&)")]
        public virtual QVariant extension(QScriptClass.Extension extension, QVariant argument) {
            return (QVariant) interceptor.Invoke("extension$#", "extension(QScriptClass::Extension, const QVariant&)", typeof(QVariant), typeof(QScriptClass.Extension), extension, typeof(QVariant), argument);
        }
        [SmokeMethod("extension(QScriptClass::Extension)")]
        public virtual QVariant extension(QScriptClass.Extension extension) {
            return (QVariant) interceptor.Invoke("extension$", "extension(QScriptClass::Extension)", typeof(QVariant), typeof(QScriptClass.Extension), extension);
        }
        ~QScriptClass() {
            interceptor.Invoke("~QScriptClass", "~QScriptClass()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QScriptClass", "~QScriptClass()", typeof(void));
        }
    }
}
