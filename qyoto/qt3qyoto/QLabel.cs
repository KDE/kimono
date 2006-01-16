//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QLabel")]
	public class QLabel : QFrame, IDisposable {
 		protected QLabel(Type dummy) : base((Type) null) {}
		interface IQLabelProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLabel), this);
			_interceptor = (QLabel) realProxy.GetTransparentProxy();
		}
		private QLabel ProxyQLabel() {
			return (QLabel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLabel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLabelProxy), null);
			_staticInterceptor = (IQLabelProxy) realProxy.GetTransparentProxy();
		}
		private static IQLabelProxy StaticQLabel() {
			return (IQLabelProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQLabel().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQLabel().ClassName();
		}
		public QLabel(QWidget parent, string name, int f) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(parent,name,f);
		}
		[SmokeMethod("QLabel(QWidget*, const char*, Qt::WFlags)")]
		private void NewQLabel(QWidget parent, string name, int f) {
			ProxyQLabel().NewQLabel(parent,name,f);
		}
		public QLabel(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(parent,name);
		}
		[SmokeMethod("QLabel(QWidget*, const char*)")]
		private void NewQLabel(QWidget parent, string name) {
			ProxyQLabel().NewQLabel(parent,name);
		}
		public QLabel(QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(parent);
		}
		[SmokeMethod("QLabel(QWidget*)")]
		private void NewQLabel(QWidget parent) {
			ProxyQLabel().NewQLabel(parent);
		}
		public QLabel(string text, QWidget parent, string name, int f) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(text,parent,name,f);
		}
		[SmokeMethod("QLabel(const QString&, QWidget*, const char*, Qt::WFlags)")]
		private void NewQLabel(string text, QWidget parent, string name, int f) {
			ProxyQLabel().NewQLabel(text,parent,name,f);
		}
		public QLabel(string text, QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(text,parent,name);
		}
		[SmokeMethod("QLabel(const QString&, QWidget*, const char*)")]
		private void NewQLabel(string text, QWidget parent, string name) {
			ProxyQLabel().NewQLabel(text,parent,name);
		}
		public QLabel(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(text,parent);
		}
		[SmokeMethod("QLabel(const QString&, QWidget*)")]
		private void NewQLabel(string text, QWidget parent) {
			ProxyQLabel().NewQLabel(text,parent);
		}
		public QLabel(QWidget buddy, string arg2, QWidget parent, string name, int f) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(buddy,arg2,parent,name,f);
		}
		[SmokeMethod("QLabel(QWidget*, const QString&, QWidget*, const char*, Qt::WFlags)")]
		private void NewQLabel(QWidget buddy, string arg2, QWidget parent, string name, int f) {
			ProxyQLabel().NewQLabel(buddy,arg2,parent,name,f);
		}
		public QLabel(QWidget buddy, string arg2, QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(buddy,arg2,parent,name);
		}
		[SmokeMethod("QLabel(QWidget*, const QString&, QWidget*, const char*)")]
		private void NewQLabel(QWidget buddy, string arg2, QWidget parent, string name) {
			ProxyQLabel().NewQLabel(buddy,arg2,parent,name);
		}
		public QLabel(QWidget buddy, string arg2, QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQLabel(buddy,arg2,parent);
		}
		[SmokeMethod("QLabel(QWidget*, const QString&, QWidget*)")]
		private void NewQLabel(QWidget buddy, string arg2, QWidget parent) {
			ProxyQLabel().NewQLabel(buddy,arg2,parent);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQLabel().Text();
		}
		[SmokeMethod("pixmap() const")]
		public QPixmap Pixmap() {
			return ProxyQLabel().Pixmap();
		}
		[SmokeMethod("picture() const")]
		public QPicture Picture() {
			return ProxyQLabel().Picture();
		}
		[SmokeMethod("movie() const")]
		public QMovie Movie() {
			return ProxyQLabel().Movie();
		}
		[SmokeMethod("textFormat() const")]
		public Qt.TextFormat TextFormat() {
			return ProxyQLabel().TextFormat();
		}
		[SmokeMethod("setTextFormat(Qt::TextFormat)")]
		public void SetTextFormat(Qt.TextFormat arg1) {
			ProxyQLabel().SetTextFormat(arg1);
		}
		[SmokeMethod("alignment() const")]
		public int Alignment() {
			return ProxyQLabel().Alignment();
		}
		[SmokeMethod("setAlignment(int)")]
		public virtual void SetAlignment(int arg1) {
			ProxyQLabel().SetAlignment(arg1);
		}
		[SmokeMethod("indent() const")]
		public int Indent() {
			return ProxyQLabel().Indent();
		}
		[SmokeMethod("setIndent(int)")]
		public void SetIndent(int arg1) {
			ProxyQLabel().SetIndent(arg1);
		}
		[SmokeMethod("autoResize() const")]
		public bool AutoResize() {
			return ProxyQLabel().AutoResize();
		}
		[SmokeMethod("setAutoResize(bool)")]
		public virtual void SetAutoResize(bool arg1) {
			ProxyQLabel().SetAutoResize(arg1);
		}
		[SmokeMethod("hasScaledContents() const")]
		public bool HasScaledContents() {
			return ProxyQLabel().HasScaledContents();
		}
		[SmokeMethod("setScaledContents(bool)")]
		public void SetScaledContents(bool arg1) {
			ProxyQLabel().SetScaledContents(arg1);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQLabel().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQLabel().MinimumSizeHint();
		}
		[SmokeMethod("setBuddy(QWidget*)")]
		public virtual void SetBuddy(QWidget arg1) {
			ProxyQLabel().SetBuddy(arg1);
		}
		[SmokeMethod("buddy() const")]
		public QWidget Buddy() {
			return ProxyQLabel().Buddy();
		}
		[SmokeMethod("heightForWidth(int) const")]
		public new int HeightForWidth(int arg1) {
			return ProxyQLabel().HeightForWidth(arg1);
		}
		[SmokeMethod("setFont(const QFont&)")]
		public new void SetFont(QFont f) {
			ProxyQLabel().SetFont(f);
		}
		[Q_SLOT("void setText(const QString&)")]
		[SmokeMethod("setText(const QString&)")]
		public virtual void SetText(string arg1) {
			ProxyQLabel().SetText(arg1);
		}
		[Q_SLOT("void setPixmap(const QPixmap&)")]
		[SmokeMethod("setPixmap(const QPixmap&)")]
		public virtual void SetPixmap(QPixmap arg1) {
			ProxyQLabel().SetPixmap(arg1);
		}
		[Q_SLOT("void setPicture(const QPicture&)")]
		[SmokeMethod("setPicture(const QPicture&)")]
		public virtual void SetPicture(QPicture arg1) {
			ProxyQLabel().SetPicture(arg1);
		}
		[Q_SLOT("void setMovie(const QMovie&)")]
		[SmokeMethod("setMovie(const QMovie&)")]
		public virtual void SetMovie(QMovie arg1) {
			ProxyQLabel().SetMovie(arg1);
		}
		[Q_SLOT("void setNum(int)")]
		[SmokeMethod("setNum(int)")]
		public virtual void SetNum(int arg1) {
			ProxyQLabel().SetNum(arg1);
		}
		[Q_SLOT("void setNum(double)")]
		[SmokeMethod("setNum(double)")]
		public virtual void SetNum(double arg1) {
			ProxyQLabel().SetNum(arg1);
		}
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQLabel().Clear();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQLabel().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQLabel().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQLabel().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQLabel().TrUtf8(arg1);
		}
		[SmokeMethod("drawContents(QPainter*)")]
		protected new void DrawContents(QPainter arg1) {
			ProxyQLabel().DrawContents(arg1);
		}
		[SmokeMethod("fontChange(const QFont&)")]
		protected new void FontChange(QFont arg1) {
			ProxyQLabel().FontChange(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQLabel().ResizeEvent(arg1);
		}
		~QLabel() {
			DisposeQLabel();
		}
		public new void Dispose() {
			DisposeQLabel();
		}
		private void DisposeQLabel() {
			ProxyQLabel().DisposeQLabel();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQLabelSignals), this);
			Q_EMIT = (IQLabelSignals) realProxy.GetTransparentProxy();
		}
		protected new IQLabelSignals Emit() {
			return (IQLabelSignals) Q_EMIT;
		}
	}

	public interface IQLabelSignals : IQFrameSignals {
	}
}
