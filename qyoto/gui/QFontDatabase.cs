//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QFontDatabase")]
	public class QFontDatabase : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QFontDatabase(Type dummy) {}
		[SmokeClass("QFontDatabase")]
		interface IQFontDatabaseProxy {
			[SmokeMethod("standardSizes", "()", "")]
			List<int> StandardSizes();
			[SmokeMethod("writingSystemName", "(QFontDatabase::WritingSystem)", "$")]
			string WritingSystemName(QFontDatabase.WritingSystem writingSystem);
			[SmokeMethod("writingSystemSample", "(QFontDatabase::WritingSystem)", "$")]
			string WritingSystemSample(QFontDatabase.WritingSystem writingSystem);
			[SmokeMethod("addApplicationFont", "(const QString&)", "$")]
			int AddApplicationFont(string fileName);
			[SmokeMethod("addApplicationFontFromData", "(const QByteArray&)", "#")]
			int AddApplicationFontFromData(QByteArray fontData);
			[SmokeMethod("applicationFontFamilies", "(int)", "$")]
			List<string> ApplicationFontFamilies(int id);
			[SmokeMethod("removeApplicationFont", "(int)", "$")]
			bool RemoveApplicationFont(int id);
			[SmokeMethod("removeAllApplicationFonts", "()", "")]
			bool RemoveAllApplicationFonts();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontDatabase), this);
			_interceptor = (QFontDatabase) realProxy.GetTransparentProxy();
		}
		private QFontDatabase ProxyQFontDatabase() {
			return (QFontDatabase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontDatabase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontDatabaseProxy), null);
			_staticInterceptor = (IQFontDatabaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontDatabaseProxy StaticQFontDatabase() {
			return (IQFontDatabaseProxy) _staticInterceptor;
		}
		public enum WritingSystem {
			Any = 0,
			Latin = 1,
			Greek = 2,
			Cyrillic = 3,
			Armenian = 4,
			Hebrew = 5,
			Arabic = 6,
			Syriac = 7,
			Thaana = 8,
			Devanagari = 9,
			Bengali = 10,
			Gurmukhi = 11,
			Gujarati = 12,
			Oriya = 13,
			Tamil = 14,
			Telugu = 15,
			Kannada = 16,
			Malayalam = 17,
			Sinhala = 18,
			Thai = 19,
			Lao = 20,
			Tibetan = 21,
			Myanmar = 22,
			Georgian = 23,
			Khmer = 24,
			SimplifiedChinese = 25,
			TraditionalChinese = 26,
			Japanese = 27,
			Korean = 28,
			Vietnamese = 29,
			Symbol = 30,
			Other = Symbol,
			Ogham = 31,
			Runic = 32,
			WritingSystemsCount = 33,
		}
		public QFontDatabase() : this((Type) null) {
			CreateProxy();
			NewQFontDatabase();
		}
		[SmokeMethod("QFontDatabase", "()", "")]
		private void NewQFontDatabase() {
			ProxyQFontDatabase().NewQFontDatabase();
		}
		// QList<QFontDatabase::WritingSystem> writingSystems(); >>>> NOT CONVERTED
		// QList<QFontDatabase::WritingSystem> writingSystems(const QString& arg1); >>>> NOT CONVERTED
		[SmokeMethod("families", "(QFontDatabase::WritingSystem) const", "$")]
		public List<string> Families(QFontDatabase.WritingSystem writingSystem) {
			return ProxyQFontDatabase().Families(writingSystem);
		}
		[SmokeMethod("families", "() const", "")]
		public List<string> Families() {
			return ProxyQFontDatabase().Families();
		}
		[SmokeMethod("styles", "(const QString&) const", "$")]
		public List<string> Styles(string family) {
			return ProxyQFontDatabase().Styles(family);
		}
		[SmokeMethod("pointSizes", "(const QString&, const QString&)", "$$")]
		public List<int> PointSizes(string family, string style) {
			return ProxyQFontDatabase().PointSizes(family,style);
		}
		[SmokeMethod("pointSizes", "(const QString&)", "$")]
		public List<int> PointSizes(string family) {
			return ProxyQFontDatabase().PointSizes(family);
		}
		[SmokeMethod("smoothSizes", "(const QString&, const QString&)", "$$")]
		public List<int> SmoothSizes(string family, string style) {
			return ProxyQFontDatabase().SmoothSizes(family,style);
		}
		[SmokeMethod("styleString", "(const QFont&)", "#")]
		public string StyleString(QFont font) {
			return ProxyQFontDatabase().StyleString(font);
		}
		[SmokeMethod("styleString", "(const QFontInfo&)", "#")]
		public string StyleString(QFontInfo fontInfo) {
			return ProxyQFontDatabase().StyleString(fontInfo);
		}
		[SmokeMethod("font", "(const QString&, const QString&, int) const", "$$$")]
		public QFont Font(string family, string style, int pointSize) {
			return ProxyQFontDatabase().Font(family,style,pointSize);
		}
		[SmokeMethod("isBitmapScalable", "(const QString&, const QString&) const", "$$")]
		public bool IsBitmapScalable(string family, string style) {
			return ProxyQFontDatabase().IsBitmapScalable(family,style);
		}
		[SmokeMethod("isBitmapScalable", "(const QString&) const", "$")]
		public bool IsBitmapScalable(string family) {
			return ProxyQFontDatabase().IsBitmapScalable(family);
		}
		[SmokeMethod("isSmoothlyScalable", "(const QString&, const QString&) const", "$$")]
		public bool IsSmoothlyScalable(string family, string style) {
			return ProxyQFontDatabase().IsSmoothlyScalable(family,style);
		}
		[SmokeMethod("isSmoothlyScalable", "(const QString&) const", "$")]
		public bool IsSmoothlyScalable(string family) {
			return ProxyQFontDatabase().IsSmoothlyScalable(family);
		}
		[SmokeMethod("isScalable", "(const QString&, const QString&) const", "$$")]
		public bool IsScalable(string family, string style) {
			return ProxyQFontDatabase().IsScalable(family,style);
		}
		[SmokeMethod("isScalable", "(const QString&) const", "$")]
		public bool IsScalable(string family) {
			return ProxyQFontDatabase().IsScalable(family);
		}
		[SmokeMethod("isFixedPitch", "(const QString&, const QString&) const", "$$")]
		public bool IsFixedPitch(string family, string style) {
			return ProxyQFontDatabase().IsFixedPitch(family,style);
		}
		[SmokeMethod("isFixedPitch", "(const QString&) const", "$")]
		public bool IsFixedPitch(string family) {
			return ProxyQFontDatabase().IsFixedPitch(family);
		}
		[SmokeMethod("italic", "(const QString&, const QString&) const", "$$")]
		public bool Italic(string family, string style) {
			return ProxyQFontDatabase().Italic(family,style);
		}
		[SmokeMethod("bold", "(const QString&, const QString&) const", "$$")]
		public bool Bold(string family, string style) {
			return ProxyQFontDatabase().Bold(family,style);
		}
		[SmokeMethod("weight", "(const QString&, const QString&) const", "$$")]
		public int Weight(string family, string style) {
			return ProxyQFontDatabase().Weight(family,style);
		}
		public static List<int> StandardSizes() {
			return StaticQFontDatabase().StandardSizes();
		}
		public static string WritingSystemName(QFontDatabase.WritingSystem writingSystem) {
			return StaticQFontDatabase().WritingSystemName(writingSystem);
		}
		public static string WritingSystemSample(QFontDatabase.WritingSystem writingSystem) {
			return StaticQFontDatabase().WritingSystemSample(writingSystem);
		}
		public static int AddApplicationFont(string fileName) {
			return StaticQFontDatabase().AddApplicationFont(fileName);
		}
		public static int AddApplicationFontFromData(QByteArray fontData) {
			return StaticQFontDatabase().AddApplicationFontFromData(fontData);
		}
		public static List<string> ApplicationFontFamilies(int id) {
			return StaticQFontDatabase().ApplicationFontFamilies(id);
		}
		public static bool RemoveApplicationFont(int id) {
			return StaticQFontDatabase().RemoveApplicationFont(id);
		}
		public static bool RemoveAllApplicationFonts() {
			return StaticQFontDatabase().RemoveAllApplicationFonts();
		}
		~QFontDatabase() {
			DisposeQFontDatabase();
		}
		public void Dispose() {
			DisposeQFontDatabase();
		}
		[SmokeMethod("~QFontDatabase", "()", "")]
		private void DisposeQFontDatabase() {
			ProxyQFontDatabase().DisposeQFontDatabase();
		}
	}
}
