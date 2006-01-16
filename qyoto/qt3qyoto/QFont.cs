//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QFont")]
	public class QFont : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFont(Type dummy) {}
		interface IQFontProxy {
			bool op_equals(QFont lhs, QFont arg1);
			string Substitute(string arg1);
			ArrayList Substitutes(string arg1);
			ArrayList Substitutions();
			void InsertSubstitution(string arg1, string arg2);
			void InsertSubstitutions(string arg1, string[] arg2);
			void RemoveSubstitution(string arg1);
			void Initialize();
			void Cleanup();
			void CacheStatistics();
			QFont DefaultFont();
			void SetDefaultFont(QFont arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFont), this);
			_interceptor = (QFont) realProxy.GetTransparentProxy();
		}
		private QFont ProxyQFont() {
			return (QFont) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFont() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontProxy), null);
			_staticInterceptor = (IQFontProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontProxy StaticQFont() {
			return (IQFontProxy) _staticInterceptor;
		}

		public enum StyleHint {
			Helvetica = 0,
			SansSerif = Helvetica,
			Times = 1,
			Serif = Times,
			Courier = 2,
			TypeWriter = Courier,
			OldEnglish = 3,
			Decorative = OldEnglish,
			System = 4,
			AnyStyle = 5,
		}
		public enum StyleStrategy {
			PreferDefault = 0x0001,
			PreferBitmap = 0x0002,
			PreferDevice = 0x0004,
			PreferOutline = 0x0008,
			ForceOutline = 0x0010,
			PreferMatch = 0x0020,
			PreferQuality = 0x0040,
			PreferAntialias = 0x0080,
			NoAntialias = 0x0100,
			OpenGLCompatible = 0x0200,
		}
		public enum Weight {
			Light = 25,
			Normal = 50,
			DemiBold = 63,
			Bold = 75,
			Black = 87,
		}
		public enum Stretch {
			UltraCondensed = 50,
			ExtraCondensed = 62,
			Condensed = 75,
			SemiCondensed = 87,
			Unstretched = 100,
			SemiExpanded = 112,
			Expanded = 125,
			ExtraExpanded = 150,
			UltraExpanded = 200,
		}
		public enum Script {
			Latin = 0,
			Greek = 1,
			Cyrillic = 2,
			Armenian = 3,
			Georgian = 4,
			Runic = 5,
			Ogham = 6,
			SpacingModifiers = 7,
			CombiningMarks = 8,
			Hebrew = 9,
			Arabic = 10,
			Syriac = 11,
			Thaana = 12,
			Devanagari = 13,
			Bengali = 14,
			Gurmukhi = 15,
			Gujarati = 16,
			Oriya = 17,
			Tamil = 18,
			Telugu = 19,
			Kannada = 20,
			Malayalam = 21,
			Sinhala = 22,
			Thai = 23,
			Lao = 24,
			Tibetan = 25,
			Myanmar = 26,
			Khmer = 27,
			Han = 28,
			Hiragana = 29,
			Katakana = 30,
			Hangul = 31,
			Bopomofo = 32,
			Yi = 33,
			Ethiopic = 34,
			Cherokee = 35,
			CanadianAboriginal = 36,
			Mongolian = 37,
			CurrencySymbols = 38,
			LetterlikeSymbols = 39,
			NumberForms = 40,
			MathematicalOperators = 41,
			TechnicalSymbols = 42,
			GeometricSymbols = 43,
			MiscellaneousSymbols = 44,
			EnclosedAndSquare = 45,
			Braille = 46,
			Unicode = 47,
			Tagalog = 48,
			Hanunoo = 49,
			Buhid = 50,
			Tagbanwa = 51,
			KatakanaHalfWidth = 52,
			Limbu = 53,
			TaiLe = 54,
			NScripts = 55,
			UnknownScript = NScripts,
			NoScript = 56,
			Han_Japanese = 57,
			Han_SimplifiedChinese = 58,
			Han_TraditionalChinese = 59,
			Han_Korean = 60,
			LastPrivateScript = 61,
		}
		public QFont() : this((Type) null) {
			CreateProxy();
			NewQFont();
		}
		[SmokeMethod("QFont()")]
		private void NewQFont() {
			ProxyQFont().NewQFont();
		}
		public QFont(string family, int pointSize, int weight, bool italic) : this((Type) null) {
			CreateProxy();
			NewQFont(family,pointSize,weight,italic);
		}
		[SmokeMethod("QFont(const QString&, int, int, bool)")]
		private void NewQFont(string family, int pointSize, int weight, bool italic) {
			ProxyQFont().NewQFont(family,pointSize,weight,italic);
		}
		public QFont(string family, int pointSize, int weight) : this((Type) null) {
			CreateProxy();
			NewQFont(family,pointSize,weight);
		}
		[SmokeMethod("QFont(const QString&, int, int)")]
		private void NewQFont(string family, int pointSize, int weight) {
			ProxyQFont().NewQFont(family,pointSize,weight);
		}
		public QFont(string family, int pointSize) : this((Type) null) {
			CreateProxy();
			NewQFont(family,pointSize);
		}
		[SmokeMethod("QFont(const QString&, int)")]
		private void NewQFont(string family, int pointSize) {
			ProxyQFont().NewQFont(family,pointSize);
		}
		public QFont(string family) : this((Type) null) {
			CreateProxy();
			NewQFont(family);
		}
		[SmokeMethod("QFont(const QString&)")]
		private void NewQFont(string family) {
			ProxyQFont().NewQFont(family);
		}
		public QFont(QFont arg1) : this((Type) null) {
			CreateProxy();
			NewQFont(arg1);
		}
		[SmokeMethod("QFont(const QFont&)")]
		private void NewQFont(QFont arg1) {
			ProxyQFont().NewQFont(arg1);
		}
		[SmokeMethod("family() const")]
		public string Family() {
			return ProxyQFont().Family();
		}
		[SmokeMethod("setFamily(const QString&)")]
		public void SetFamily(string arg1) {
			ProxyQFont().SetFamily(arg1);
		}
		[SmokeMethod("pointSize() const")]
		public int PointSize() {
			return ProxyQFont().PointSize();
		}
		[SmokeMethod("pointSizeFloat() const")]
		public float PointSizeFloat() {
			return ProxyQFont().PointSizeFloat();
		}
		[SmokeMethod("setPointSize(int)")]
		public void SetPointSize(int arg1) {
			ProxyQFont().SetPointSize(arg1);
		}
		[SmokeMethod("setPointSizeFloat(float)")]
		public void SetPointSizeFloat(float arg1) {
			ProxyQFont().SetPointSizeFloat(arg1);
		}
		[SmokeMethod("pixelSize() const")]
		public int PixelSize() {
			return ProxyQFont().PixelSize();
		}
		[SmokeMethod("setPixelSize(int)")]
		public void SetPixelSize(int arg1) {
			ProxyQFont().SetPixelSize(arg1);
		}
		[SmokeMethod("setPixelSizeFloat(float)")]
		public void SetPixelSizeFloat(float arg1) {
			ProxyQFont().SetPixelSizeFloat(arg1);
		}
		[SmokeMethod("weight() const")]
		public int weight() {
			return ProxyQFont().weight();
		}
		[SmokeMethod("setWeight(int)")]
		public void SetWeight(int arg1) {
			ProxyQFont().SetWeight(arg1);
		}
		[SmokeMethod("bold() const")]
		public bool Bold() {
			return ProxyQFont().Bold();
		}
		[SmokeMethod("setBold(bool)")]
		public void SetBold(bool arg1) {
			ProxyQFont().SetBold(arg1);
		}
		[SmokeMethod("italic() const")]
		public bool Italic() {
			return ProxyQFont().Italic();
		}
		[SmokeMethod("setItalic(bool)")]
		public void SetItalic(bool arg1) {
			ProxyQFont().SetItalic(arg1);
		}
		[SmokeMethod("underline() const")]
		public bool Underline() {
			return ProxyQFont().Underline();
		}
		[SmokeMethod("setUnderline(bool)")]
		public void SetUnderline(bool arg1) {
			ProxyQFont().SetUnderline(arg1);
		}
		[SmokeMethod("overline() const")]
		public bool Overline() {
			return ProxyQFont().Overline();
		}
		[SmokeMethod("setOverline(bool)")]
		public void SetOverline(bool arg1) {
			ProxyQFont().SetOverline(arg1);
		}
		[SmokeMethod("strikeOut() const")]
		public bool StrikeOut() {
			return ProxyQFont().StrikeOut();
		}
		[SmokeMethod("setStrikeOut(bool)")]
		public void SetStrikeOut(bool arg1) {
			ProxyQFont().SetStrikeOut(arg1);
		}
		[SmokeMethod("fixedPitch() const")]
		public bool FixedPitch() {
			return ProxyQFont().FixedPitch();
		}
		[SmokeMethod("setFixedPitch(bool)")]
		public void SetFixedPitch(bool arg1) {
			ProxyQFont().SetFixedPitch(arg1);
		}
		[SmokeMethod("styleHint() const")]
		public QFont.StyleHint styleHint() {
			return ProxyQFont().styleHint();
		}
		[SmokeMethod("styleStrategy() const")]
		public QFont.StyleStrategy styleStrategy() {
			return ProxyQFont().styleStrategy();
		}
		[SmokeMethod("setStyleHint(QFont::StyleHint, QFont::StyleStrategy)")]
		public void SetStyleHint(QFont.StyleHint arg1, QFont.StyleStrategy arg2) {
			ProxyQFont().SetStyleHint(arg1,arg2);
		}
		[SmokeMethod("setStyleHint(QFont::StyleHint)")]
		public void SetStyleHint(QFont.StyleHint arg1) {
			ProxyQFont().SetStyleHint(arg1);
		}
		[SmokeMethod("setStyleStrategy(QFont::StyleStrategy)")]
		public void SetStyleStrategy(QFont.StyleStrategy s) {
			ProxyQFont().SetStyleStrategy(s);
		}
		[SmokeMethod("stretch() const")]
		public int stretch() {
			return ProxyQFont().stretch();
		}
		[SmokeMethod("setStretch(int)")]
		public void SetStretch(int arg1) {
			ProxyQFont().SetStretch(arg1);
		}
		[SmokeMethod("rawMode() const")]
		public bool RawMode() {
			return ProxyQFont().RawMode();
		}
		[SmokeMethod("setRawMode(bool)")]
		public void SetRawMode(bool arg1) {
			ProxyQFont().SetRawMode(arg1);
		}
		[SmokeMethod("exactMatch() const")]
		public bool ExactMatch() {
			return ProxyQFont().ExactMatch();
		}
		[SmokeMethod("operator==(const QFont&) const")]
		public static bool operator==(QFont lhs, QFont arg1) {
			return StaticQFont().op_equals(lhs,arg1);
		}
		public static bool operator!=(QFont lhs, QFont arg1) {
			return !StaticQFont().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QFont)) { return false; }
			return this == (QFont) o;
		}
		public override int GetHashCode() {
			return ProxyQFont().GetHashCode();
		}
		[SmokeMethod("isCopyOf(const QFont&) const")]
		public bool IsCopyOf(QFont arg1) {
			return ProxyQFont().IsCopyOf(arg1);
		}
		[SmokeMethod("handle() const")]
		public uint Handle() {
			return ProxyQFont().Handle();
		}
		[SmokeMethod("setRawName(const QString&)")]
		public void SetRawName(string arg1) {
			ProxyQFont().SetRawName(arg1);
		}
		[SmokeMethod("rawName() const")]
		public string RawName() {
			return ProxyQFont().RawName();
		}
		[SmokeMethod("key() const")]
		public string Key() {
			return ProxyQFont().Key();
		}
		[SmokeMethod("toString() const")]
		public new string ToString() {
			return ProxyQFont().ToString();
		}
		[SmokeMethod("fromString(const QString&)")]
		public bool FromString(string arg1) {
			return ProxyQFont().FromString(arg1);
		}
		[SmokeMethod("defaultFamily() const")]
		public string DefaultFamily() {
			return ProxyQFont().DefaultFamily();
		}
		[SmokeMethod("lastResortFamily() const")]
		public string LastResortFamily() {
			return ProxyQFont().LastResortFamily();
		}
		[SmokeMethod("lastResortFont() const")]
		public string LastResortFont() {
			return ProxyQFont().LastResortFont();
		}
		[SmokeMethod("resolve(const QFont&) const")]
		public QFont Resolve(QFont arg1) {
			return ProxyQFont().Resolve(arg1);
		}
		[SmokeMethod("substitute(const QString&)")]
		public static string Substitute(string arg1) {
			return StaticQFont().Substitute(arg1);
		}
		[SmokeMethod("substitutes(const QString&)")]
		public static ArrayList Substitutes(string arg1) {
			return StaticQFont().Substitutes(arg1);
		}
		[SmokeMethod("substitutions()")]
		public static ArrayList Substitutions() {
			return StaticQFont().Substitutions();
		}
		[SmokeMethod("insertSubstitution(const QString&, const QString&)")]
		public static void InsertSubstitution(string arg1, string arg2) {
			StaticQFont().InsertSubstitution(arg1,arg2);
		}
		[SmokeMethod("insertSubstitutions(const QString&, const QStringList&)")]
		public static void InsertSubstitutions(string arg1, string[] arg2) {
			StaticQFont().InsertSubstitutions(arg1,arg2);
		}
		[SmokeMethod("removeSubstitution(const QString&)")]
		public static void RemoveSubstitution(string arg1) {
			StaticQFont().RemoveSubstitution(arg1);
		}
		[SmokeMethod("initialize()")]
		public static void Initialize() {
			StaticQFont().Initialize();
		}
		[SmokeMethod("cleanup()")]
		public static void Cleanup() {
			StaticQFont().Cleanup();
		}
		[SmokeMethod("cacheStatistics()")]
		public static void CacheStatistics() {
			StaticQFont().CacheStatistics();
		}
		[SmokeMethod("defaultFont()")]
		public static QFont DefaultFont() {
			return StaticQFont().DefaultFont();
		}
		[SmokeMethod("setDefaultFont(const QFont&)")]
		public static void SetDefaultFont(QFont arg1) {
			StaticQFont().SetDefaultFont(arg1);
		}
		[SmokeMethod("dirty() const")]
		protected bool Dirty() {
			return ProxyQFont().Dirty();
		}
		[SmokeMethod("deciPointSize() const")]
		protected int DeciPointSize() {
			return ProxyQFont().DeciPointSize();
		}
		~QFont() {
			DisposeQFont();
		}
		public void Dispose() {
			DisposeQFont();
		}
		private void DisposeQFont() {
			ProxyQFont().DisposeQFont();
		}
	}
}
