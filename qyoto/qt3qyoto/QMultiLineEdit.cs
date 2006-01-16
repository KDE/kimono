//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QMultiLineEdit")]
	public class QMultiLineEdit : QTextEdit, IDisposable {
 		protected QMultiLineEdit(Type dummy) : base((Type) null) {}
		interface IQMultiLineEditProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMultiLineEdit), this);
			_interceptor = (QMultiLineEdit) realProxy.GetTransparentProxy();
		}
		private QMultiLineEdit ProxyQMultiLineEdit() {
			return (QMultiLineEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMultiLineEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMultiLineEditProxy), null);
			_staticInterceptor = (IQMultiLineEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQMultiLineEditProxy StaticQMultiLineEdit() {
			return (IQMultiLineEditProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQMultiLineEdit().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQMultiLineEdit().ClassName();
		}
		public QMultiLineEdit(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQMultiLineEdit(parent,name);
		}
		[SmokeMethod("QMultiLineEdit(QWidget*, const char*)")]
		private void NewQMultiLineEdit(QWidget parent, string name) {
			ProxyQMultiLineEdit().NewQMultiLineEdit(parent,name);
		}
		public QMultiLineEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQMultiLineEdit(parent);
		}
		[SmokeMethod("QMultiLineEdit(QWidget*)")]
		private void NewQMultiLineEdit(QWidget parent) {
			ProxyQMultiLineEdit().NewQMultiLineEdit(parent);
		}
		public QMultiLineEdit() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQMultiLineEdit();
		}
		[SmokeMethod("QMultiLineEdit()")]
		private void NewQMultiLineEdit() {
			ProxyQMultiLineEdit().NewQMultiLineEdit();
		}
		[SmokeMethod("textLine(int) const")]
		public string TextLine(int line) {
			return ProxyQMultiLineEdit().TextLine(line);
		}
		[SmokeMethod("numLines() const")]
		public int NumLines() {
			return ProxyQMultiLineEdit().NumLines();
		}
		[SmokeMethod("insertLine(const QString&, int)")]
		public virtual void InsertLine(string s, int line) {
			ProxyQMultiLineEdit().InsertLine(s,line);
		}
		[SmokeMethod("insertLine(const QString&)")]
		public virtual void InsertLine(string s) {
			ProxyQMultiLineEdit().InsertLine(s);
		}
		[SmokeMethod("insertAt(const QString&, int, int)")]
		public new virtual void InsertAt(string s, int line, int col) {
			ProxyQMultiLineEdit().InsertAt(s,line,col);
		}
		[SmokeMethod("insertAt(const QString&, int, int, bool)")]
		public new virtual void InsertAt(string s, int line, int col, bool mark) {
			ProxyQMultiLineEdit().InsertAt(s,line,col,mark);
		}
		[SmokeMethod("removeLine(int)")]
		public virtual void RemoveLine(int line) {
			ProxyQMultiLineEdit().RemoveLine(line);
		}
		[SmokeMethod("setCursorPosition(int, int)")]
		public new virtual void SetCursorPosition(int line, int col) {
			ProxyQMultiLineEdit().SetCursorPosition(line,col);
		}
		[SmokeMethod("setCursorPosition(int, int, bool)")]
		public new virtual void SetCursorPosition(int line, int col, bool mark) {
			ProxyQMultiLineEdit().SetCursorPosition(line,col,mark);
		}
		[SmokeMethod("atBeginning() const")]
		public bool AtBeginning() {
			return ProxyQMultiLineEdit().AtBeginning();
		}
		[SmokeMethod("atEnd() const")]
		public bool AtEnd() {
			return ProxyQMultiLineEdit().AtEnd();
		}
		[SmokeMethod("setAlignment(int)")]
		public new void SetAlignment(int flags) {
			ProxyQMultiLineEdit().SetAlignment(flags);
		}
		[SmokeMethod("alignment() const")]
		public new int Alignment() {
			return ProxyQMultiLineEdit().Alignment();
		}
		[SmokeMethod("setEdited(bool)")]
		public void SetEdited(bool arg1) {
			ProxyQMultiLineEdit().SetEdited(arg1);
		}
		[SmokeMethod("edited() const")]
		public bool Edited() {
			return ProxyQMultiLineEdit().Edited();
		}
		[SmokeMethod("hasMarkedText() const")]
		public bool HasMarkedText() {
			return ProxyQMultiLineEdit().HasMarkedText();
		}
		[SmokeMethod("markedText() const")]
		public string MarkedText() {
			return ProxyQMultiLineEdit().MarkedText();
		}
		[SmokeMethod("cursorWordForward(bool)")]
		public void CursorWordForward(bool mark) {
			ProxyQMultiLineEdit().CursorWordForward(mark);
		}
		[SmokeMethod("cursorWordBackward(bool)")]
		public void CursorWordBackward(bool mark) {
			ProxyQMultiLineEdit().CursorWordBackward(mark);
		}
		[SmokeMethod("autoUpdate() const")]
		public bool AutoUpdate() {
			return ProxyQMultiLineEdit().AutoUpdate();
		}
		[SmokeMethod("setAutoUpdate(bool)")]
		public virtual void SetAutoUpdate(bool arg1) {
			ProxyQMultiLineEdit().SetAutoUpdate(arg1);
		}
		[SmokeMethod("totalWidth() const")]
		public int TotalWidth() {
			return ProxyQMultiLineEdit().TotalWidth();
		}
		[SmokeMethod("totalHeight() const")]
		public int TotalHeight() {
			return ProxyQMultiLineEdit().TotalHeight();
		}
		[SmokeMethod("maxLines() const")]
		public int MaxLines() {
			return ProxyQMultiLineEdit().MaxLines();
		}
		[SmokeMethod("setMaxLines(int)")]
		public void SetMaxLines(int arg1) {
			ProxyQMultiLineEdit().SetMaxLines(arg1);
		}
		[Q_SLOT("void deselect()")]
		[SmokeMethod("deselect()")]
		public void Deselect() {
			ProxyQMultiLineEdit().Deselect();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQMultiLineEdit().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQMultiLineEdit().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQMultiLineEdit().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQMultiLineEdit().TrUtf8(arg1);
		}
		[SmokeMethod("cursorPoint() const")]
		protected QPoint CursorPoint() {
			return ProxyQMultiLineEdit().CursorPoint();
		}
		[SmokeMethod("insertAndMark(const QString&, bool)")]
		protected virtual void InsertAndMark(string arg1, bool mark) {
			ProxyQMultiLineEdit().InsertAndMark(arg1,mark);
		}
		[SmokeMethod("newLine()")]
		protected virtual void NewLine() {
			ProxyQMultiLineEdit().NewLine();
		}
		[SmokeMethod("killLine()")]
		protected virtual void KillLine() {
			ProxyQMultiLineEdit().KillLine();
		}
		[SmokeMethod("pageUp(bool)")]
		protected virtual void PageUp(bool mark) {
			ProxyQMultiLineEdit().PageUp(mark);
		}
		[SmokeMethod("pageUp()")]
		protected virtual void PageUp() {
			ProxyQMultiLineEdit().PageUp();
		}
		[SmokeMethod("pageDown(bool)")]
		protected virtual void PageDown(bool mark) {
			ProxyQMultiLineEdit().PageDown(mark);
		}
		[SmokeMethod("pageDown()")]
		protected virtual void PageDown() {
			ProxyQMultiLineEdit().PageDown();
		}
		[SmokeMethod("cursorLeft(bool, bool)")]
		protected virtual void CursorLeft(bool mark, bool wrap) {
			ProxyQMultiLineEdit().CursorLeft(mark,wrap);
		}
		[SmokeMethod("cursorLeft(bool)")]
		protected virtual void CursorLeft(bool mark) {
			ProxyQMultiLineEdit().CursorLeft(mark);
		}
		[SmokeMethod("cursorLeft()")]
		protected virtual void CursorLeft() {
			ProxyQMultiLineEdit().CursorLeft();
		}
		[SmokeMethod("cursorRight(bool, bool)")]
		protected virtual void CursorRight(bool mark, bool wrap) {
			ProxyQMultiLineEdit().CursorRight(mark,wrap);
		}
		[SmokeMethod("cursorRight(bool)")]
		protected virtual void CursorRight(bool mark) {
			ProxyQMultiLineEdit().CursorRight(mark);
		}
		[SmokeMethod("cursorRight()")]
		protected virtual void CursorRight() {
			ProxyQMultiLineEdit().CursorRight();
		}
		[SmokeMethod("cursorUp(bool)")]
		protected virtual void CursorUp(bool mark) {
			ProxyQMultiLineEdit().CursorUp(mark);
		}
		[SmokeMethod("cursorUp()")]
		protected virtual void CursorUp() {
			ProxyQMultiLineEdit().CursorUp();
		}
		[SmokeMethod("cursorDown(bool)")]
		protected virtual void CursorDown(bool mark) {
			ProxyQMultiLineEdit().CursorDown(mark);
		}
		[SmokeMethod("cursorDown()")]
		protected virtual void CursorDown() {
			ProxyQMultiLineEdit().CursorDown();
		}
		[SmokeMethod("backspace()")]
		protected virtual void Backspace() {
			ProxyQMultiLineEdit().Backspace();
		}
		[SmokeMethod("home(bool)")]
		protected virtual void Home(bool mark) {
			ProxyQMultiLineEdit().Home(mark);
		}
		[SmokeMethod("home()")]
		protected virtual void Home() {
			ProxyQMultiLineEdit().Home();
		}
		[SmokeMethod("end(bool)")]
		protected virtual void End(bool mark) {
			ProxyQMultiLineEdit().End(mark);
		}
		[SmokeMethod("end()")]
		protected virtual void End() {
			ProxyQMultiLineEdit().End();
		}
		[SmokeMethod("getMarkedRegion(int*, int*, int*, int*) const")]
		protected bool GetMarkedRegion(out int line1, out int col1, out int line2, out int col2) {
			return ProxyQMultiLineEdit().GetMarkedRegion(out line1,out col1,out line2,out col2);
		}
		[SmokeMethod("lineLength(int) const")]
		protected int LineLength(int row) {
			return ProxyQMultiLineEdit().LineLength(row);
		}
		~QMultiLineEdit() {
			DisposeQMultiLineEdit();
		}
		public new void Dispose() {
			DisposeQMultiLineEdit();
		}
		private void DisposeQMultiLineEdit() {
			ProxyQMultiLineEdit().DisposeQMultiLineEdit();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQMultiLineEditSignals), this);
			Q_EMIT = (IQMultiLineEditSignals) realProxy.GetTransparentProxy();
		}
		protected new IQMultiLineEditSignals Emit() {
			return (IQMultiLineEditSignals) Q_EMIT;
		}
	}

	public interface IQMultiLineEditSignals : IQTextEditSignals {
	}
}
