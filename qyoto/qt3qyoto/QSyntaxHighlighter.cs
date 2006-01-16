//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QSyntaxHighlighter")]
	public class QSyntaxHighlighter : Qt {
 		protected QSyntaxHighlighter(Type dummy) : base((Type) null) {}
		interface IQSyntaxHighlighterProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSyntaxHighlighter), this);
			_interceptor = (QSyntaxHighlighter) realProxy.GetTransparentProxy();
		}
		private QSyntaxHighlighter ProxyQSyntaxHighlighter() {
			return (QSyntaxHighlighter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSyntaxHighlighter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSyntaxHighlighterProxy), null);
			_staticInterceptor = (IQSyntaxHighlighterProxy) realProxy.GetTransparentProxy();
		}
		private static IQSyntaxHighlighterProxy StaticQSyntaxHighlighter() {
			return (IQSyntaxHighlighterProxy) _staticInterceptor;
		}

		public QSyntaxHighlighter(QTextEdit textEdit) : this((Type) null) {
			CreateProxy();
			NewQSyntaxHighlighter(textEdit);
		}
		[SmokeMethod("QSyntaxHighlighter(QTextEdit*)")]
		private void NewQSyntaxHighlighter(QTextEdit textEdit) {
			ProxyQSyntaxHighlighter().NewQSyntaxHighlighter(textEdit);
		}
		[SmokeMethod("highlightParagraph(const QString&, int)")]
		public virtual int HighlightParagraph(string text, int endStateOfLastPara) {
			return ProxyQSyntaxHighlighter().HighlightParagraph(text,endStateOfLastPara);
		}
		[SmokeMethod("setFormat(int, int, const QFont&, const QColor&)")]
		public void SetFormat(int start, int count, QFont font, QColor color) {
			ProxyQSyntaxHighlighter().SetFormat(start,count,font,color);
		}
		[SmokeMethod("setFormat(int, int, const QColor&)")]
		public void SetFormat(int start, int count, QColor color) {
			ProxyQSyntaxHighlighter().SetFormat(start,count,color);
		}
		[SmokeMethod("setFormat(int, int, const QFont&)")]
		public void SetFormat(int start, int count, QFont font) {
			ProxyQSyntaxHighlighter().SetFormat(start,count,font);
		}
		[SmokeMethod("textEdit() const")]
		public QTextEdit TextEdit() {
			return ProxyQSyntaxHighlighter().TextEdit();
		}
		[SmokeMethod("rehighlight()")]
		public void Rehighlight() {
			ProxyQSyntaxHighlighter().Rehighlight();
		}
		[SmokeMethod("currentParagraph() const")]
		public int CurrentParagraph() {
			return ProxyQSyntaxHighlighter().CurrentParagraph();
		}
		~QSyntaxHighlighter() {
			DisposeQSyntaxHighlighter();
		}
		public void Dispose() {
			DisposeQSyntaxHighlighter();
		}
		private void DisposeQSyntaxHighlighter() {
			ProxyQSyntaxHighlighter().DisposeQSyntaxHighlighter();
		}
	}
}
