//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQUndoStackSignals"></see> for signals emitted by QUndoStack
    /// </remarks>
    [SmokeClass("QUndoStack")]
    public class QUndoStack : QObject, IDisposable {
        protected QUndoStack(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QUndoStack), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QUndoStack() {
            staticInterceptor = new SmokeInvocation(typeof(QUndoStack), null);
        }
        [Q_PROPERTY("bool", "active")]
        public bool Active {
            get { return (bool) interceptor.Invoke("isActive", "isActive()", typeof(bool)); }
            set { interceptor.Invoke("setActive$", "setActive(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("int", "undoLimit")]
        public int UndoLimit {
            get { return (int) interceptor.Invoke("undoLimit", "undoLimit()", typeof(int)); }
            set { interceptor.Invoke("setUndoLimit$", "setUndoLimit(int)", typeof(void), typeof(int), value); }
        }
        public QUndoStack(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoStack#", "QUndoStack(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QUndoStack() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QUndoStack", "QUndoStack()", typeof(void));
        }
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        public void Push(QUndoCommand cmd) {
            interceptor.Invoke("push#", "push(QUndoCommand*)", typeof(void), typeof(QUndoCommand), cmd);
        }
        public bool CanUndo() {
            return (bool) interceptor.Invoke("canUndo", "canUndo() const", typeof(bool));
        }
        public bool CanRedo() {
            return (bool) interceptor.Invoke("canRedo", "canRedo() const", typeof(bool));
        }
        public string UndoText() {
            return (string) interceptor.Invoke("undoText", "undoText() const", typeof(string));
        }
        public string RedoText() {
            return (string) interceptor.Invoke("redoText", "redoText() const", typeof(string));
        }
        public int Count() {
            return (int) interceptor.Invoke("count", "count() const", typeof(int));
        }
        public int Index() {
            return (int) interceptor.Invoke("index", "index() const", typeof(int));
        }
        public string Text(int idx) {
            return (string) interceptor.Invoke("text$", "text(int) const", typeof(string), typeof(int), idx);
        }
        public QAction CreateUndoAction(QObject parent, string prefix) {
            return (QAction) interceptor.Invoke("createUndoAction#$", "createUndoAction(QObject*, const QString&) const", typeof(QAction), typeof(QObject), parent, typeof(string), prefix);
        }
        public QAction CreateUndoAction(QObject parent) {
            return (QAction) interceptor.Invoke("createUndoAction#", "createUndoAction(QObject*) const", typeof(QAction), typeof(QObject), parent);
        }
        public QAction CreateRedoAction(QObject parent, string prefix) {
            return (QAction) interceptor.Invoke("createRedoAction#$", "createRedoAction(QObject*, const QString&) const", typeof(QAction), typeof(QObject), parent, typeof(string), prefix);
        }
        public QAction CreateRedoAction(QObject parent) {
            return (QAction) interceptor.Invoke("createRedoAction#", "createRedoAction(QObject*) const", typeof(QAction), typeof(QObject), parent);
        }
        public bool IsClean() {
            return (bool) interceptor.Invoke("isClean", "isClean() const", typeof(bool));
        }
        public int CleanIndex() {
            return (int) interceptor.Invoke("cleanIndex", "cleanIndex() const", typeof(int));
        }
        public void BeginMacro(string text) {
            interceptor.Invoke("beginMacro$", "beginMacro(const QString&)", typeof(void), typeof(string), text);
        }
        public void EndMacro() {
            interceptor.Invoke("endMacro", "endMacro()", typeof(void));
        }
        public QUndoCommand Command(int index) {
            return (QUndoCommand) interceptor.Invoke("command$", "command(int) const", typeof(QUndoCommand), typeof(int), index);
        }
        [Q_SLOT("void setClean()")]
        public void SetClean() {
            interceptor.Invoke("setClean", "setClean()", typeof(void));
        }
        [Q_SLOT("void setIndex(int)")]
        public void SetIndex(int idx) {
            interceptor.Invoke("setIndex$", "setIndex(int)", typeof(void), typeof(int), idx);
        }
        [Q_SLOT("void undo()")]
        public void Undo() {
            interceptor.Invoke("undo", "undo()", typeof(void));
        }
        [Q_SLOT("void redo()")]
        public void Redo() {
            interceptor.Invoke("redo", "redo()", typeof(void));
        }
        [Q_SLOT("void setActive(bool)")]
        public void SetActive(bool active) {
            interceptor.Invoke("setActive$", "setActive(bool)", typeof(void), typeof(bool), active);
        }
        [Q_SLOT("void setActive()")]
        public void SetActive() {
            interceptor.Invoke("setActive", "setActive()", typeof(void));
        }
        ~QUndoStack() {
            interceptor.Invoke("~QUndoStack", "~QUndoStack()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QUndoStack", "~QUndoStack()", typeof(void));
        }
        public event SlotFunc<int> SignalIndexChanged {
            add { QObject.Connect(this, SIGNAL("indexChanged(int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("indexChanged(int)"), value); }
        }
        public event SlotFunc<bool> SignalCleanChanged {
            add { QObject.Connect(this, SIGNAL("cleanChanged(bool)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("cleanChanged(bool)"), value); }
        }
        public event SlotFunc<bool> SignalCanUndoChanged {
            add { QObject.Connect(this, SIGNAL("canUndoChanged(bool)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("canUndoChanged(bool)"), value); }
        }
        public event SlotFunc<bool> SignalCanRedoChanged {
            add { QObject.Connect(this, SIGNAL("canRedoChanged(bool)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("canRedoChanged(bool)"), value); }
        }
        public event SlotFunc<string> SignalUndoTextChanged {
            add { QObject.Connect(this, SIGNAL("undoTextChanged(QString)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("undoTextChanged(QString)"), value); }
        }
        public event SlotFunc<string> SignalRedoTextChanged {
            add { QObject.Connect(this, SIGNAL("redoTextChanged(QString)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("redoTextChanged(QString)"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQUndoStackSignals Emit {
            get { return (IQUndoStackSignals) Q_EMIT; }
        }
    }

    public interface IQUndoStackSignals : IQObjectSignals {
        [Q_SIGNAL("void indexChanged(int)")]
        void IndexChanged(int idx);
        [Q_SIGNAL("void cleanChanged(bool)")]
        void CleanChanged(bool clean);
        [Q_SIGNAL("void canUndoChanged(bool)")]
        void CanUndoChanged(bool canUndo);
        [Q_SIGNAL("void canRedoChanged(bool)")]
        void CanRedoChanged(bool canRedo);
        [Q_SIGNAL("void undoTextChanged(QString)")]
        void UndoTextChanged(string undoText);
        [Q_SIGNAL("void redoTextChanged(QString)")]
        void RedoTextChanged(string redoText);
    }
}
