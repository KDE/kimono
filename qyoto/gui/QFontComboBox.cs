//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQFontComboBoxSignals"></see> for signals emitted by QFontComboBox
	[SmokeClass("QFontComboBox")]
	public class QFontComboBox : QComboBox, IDisposable {
 		protected QFontComboBox(Type dummy) : base((Type) null) {}
		[SmokeClass("QFontComboBox")]
		interface IQFontComboBoxProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontComboBox), this);
			interceptor = (QFontComboBox) realProxy.GetTransparentProxy();
		}
		private static IQFontComboBoxProxy staticInterceptor = null;
		static QFontComboBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontComboBoxProxy), null);
			staticInterceptor = (IQFontComboBoxProxy) realProxy.GetTransparentProxy();
		}
		public enum FontFilter {
			AllFonts = 0,
			ScalableFonts = 0x1,
			NonScalableFonts = 0x2,
			MonospacedFonts = 0x4,
			ProportionalFonts = 0x8,
		}
		[Q_PROPERTY("QFontDatabase::WritingSystem", "writingSystem")]
		public QFontDatabase.WritingSystem WritingSystem {
			[SmokeMethod("writingSystem", "()", "")]
			get { return ((QFontComboBox) interceptor).WritingSystem; }
			[SmokeMethod("setWritingSystem", "(QFontDatabase::WritingSystem)", "$")]
			set { ((QFontComboBox) interceptor).WritingSystem = value; }
		}
		[Q_PROPERTY("FontFilters", "fontFilters")]
		public int FontFilters {
			[SmokeMethod("fontFilters", "()", "")]
			get { return ((QFontComboBox) interceptor).FontFilters; }
			[SmokeMethod("setFontFilters", "(FontFilters)", "$")]
			set { ((QFontComboBox) interceptor).FontFilters = value; }
		}
		[Q_PROPERTY("QFont", "currentFont")]
		public QFont CurrentFont {
			[SmokeMethod("currentFont", "()", "")]
			get { return ((QFontComboBox) interceptor).CurrentFont; }
			[SmokeMethod("setCurrentFont", "(QFont)", "#")]
			set { ((QFontComboBox) interceptor).CurrentFont = value; }
		}
		public QFontComboBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQFontComboBox(parent);
		}
		[SmokeMethod("QFontComboBox", "(QWidget*)", "#")]
		private void NewQFontComboBox(QWidget parent) {
			((QFontComboBox) interceptor).NewQFontComboBox(parent);
		}
		public QFontComboBox() : this((Type) null) {
			CreateProxy();
			NewQFontComboBox();
		}
		[SmokeMethod("QFontComboBox", "()", "")]
		private void NewQFontComboBox() {
			((QFontComboBox) interceptor).NewQFontComboBox();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ((QFontComboBox) interceptor).SizeHint();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		protected new virtual bool Event(QEvent e) {
			return ((QFontComboBox) interceptor).Event(e);
		}
		~QFontComboBox() {
			DisposeQFontComboBox();
		}
		public new void Dispose() {
			DisposeQFontComboBox();
		}
		[SmokeMethod("~QFontComboBox", "()", "")]
		private void DisposeQFontComboBox() {
			((QFontComboBox) interceptor).DisposeQFontComboBox();
		}
		public static string Tr(string s, string c) {
			return staticInterceptor.Tr(s,c);
		}
		public static string Tr(string s) {
			return staticInterceptor.Tr(s);
		}
		protected new IQFontComboBoxSignals Emit {
			get { return (IQFontComboBoxSignals) Q_EMIT; }
		}
	}

	public interface IQFontComboBoxSignals : IQComboBoxSignals {
		[Q_SIGNAL("void currentFontChanged(const QFont&)")]
		void CurrentFontChanged(QFont f);
	}
}
