//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QPrinter")]
	public class QPrinter : QPaintDevice, IDisposable {
 		protected QPrinter(Type dummy) : base((Type) null) {}
		interface IQPrinterProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPrinter), this);
			_interceptor = (QPrinter) realProxy.GetTransparentProxy();
		}
		private QPrinter ProxyQPrinter() {
			return (QPrinter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPrinter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPrinterProxy), null);
			_staticInterceptor = (IQPrinterProxy) realProxy.GetTransparentProxy();
		}
		private static IQPrinterProxy StaticQPrinter() {
			return (IQPrinterProxy) _staticInterceptor;
		}

		public enum PrinterMode {
			ScreenResolution = 0,
			PrinterResolution = 1,
			HighResolution = 2,
			Compatible = 3,
		}
		public enum Orientation {
			Portrait = 0,
			Landscape = 1,
		}
		public enum PageSize {
			A4 = 0,
			B5 = 1,
			Letter = 2,
			Legal = 3,
			Executive = 4,
			A0 = 5,
			A1 = 6,
			A2 = 7,
			A3 = 8,
			A5 = 9,
			A6 = 10,
			A7 = 11,
			A8 = 12,
			A9 = 13,
			B0 = 14,
			B1 = 15,
			B10 = 16,
			B2 = 17,
			B3 = 18,
			B4 = 19,
			B6 = 20,
			B7 = 21,
			B8 = 22,
			B9 = 23,
			C5E = 24,
			Comm10E = 25,
			DLE = 26,
			Folio = 27,
			Ledger = 28,
			Tabloid = 29,
			Custom = 30,
			NPageSize = Custom,
		}
		public enum PageOrder {
			FirstPageFirst = 0,
			LastPageFirst = 1,
		}
		public enum ColorMode {
			GrayScale = 0,
			Color = 1,
		}
		public enum PaperSource {
			OnlyOne = 0,
			Lower = 1,
			Middle = 2,
			Manual = 3,
			Envelope = 4,
			EnvelopeManual = 5,
			Auto = 6,
			Tractor = 7,
			SmallFormat = 8,
			LargeFormat = 9,
			LargeCapacity = 10,
			Cassette = 11,
			FormSource = 12,
		}
		public enum PrintRange {
			AllPages = 0,
			Selection = 1,
			PageRange = 2,
		}
		public enum PrinterOption {
			PrintToFile = 0,
			PrintSelection = 1,
			PrintPageRange = 2,
		}
		public QPrinter(QPrinter.PrinterMode mode) : this((Type) null) {
			CreateProxy();
			NewQPrinter(mode);
		}
		[SmokeMethod("QPrinter(QPrinter::PrinterMode)")]
		private void NewQPrinter(QPrinter.PrinterMode mode) {
			ProxyQPrinter().NewQPrinter(mode);
		}
		public QPrinter() : this((Type) null) {
			CreateProxy();
			NewQPrinter();
		}
		[SmokeMethod("QPrinter()")]
		private void NewQPrinter() {
			ProxyQPrinter().NewQPrinter();
		}
		[SmokeMethod("printerName() const")]
		public string PrinterName() {
			return ProxyQPrinter().PrinterName();
		}
		[SmokeMethod("setPrinterName(const QString&)")]
		public virtual void SetPrinterName(string arg1) {
			ProxyQPrinter().SetPrinterName(arg1);
		}
		[SmokeMethod("outputToFile() const")]
		public bool OutputToFile() {
			return ProxyQPrinter().OutputToFile();
		}
		[SmokeMethod("setOutputToFile(bool)")]
		public virtual void SetOutputToFile(bool arg1) {
			ProxyQPrinter().SetOutputToFile(arg1);
		}
		[SmokeMethod("outputFileName() const")]
		public string OutputFileName() {
			return ProxyQPrinter().OutputFileName();
		}
		[SmokeMethod("setOutputFileName(const QString&)")]
		public virtual void SetOutputFileName(string arg1) {
			ProxyQPrinter().SetOutputFileName(arg1);
		}
		[SmokeMethod("printProgram() const")]
		public string PrintProgram() {
			return ProxyQPrinter().PrintProgram();
		}
		[SmokeMethod("setPrintProgram(const QString&)")]
		public virtual void SetPrintProgram(string arg1) {
			ProxyQPrinter().SetPrintProgram(arg1);
		}
		[SmokeMethod("printerSelectionOption() const")]
		public string PrinterSelectionOption() {
			return ProxyQPrinter().PrinterSelectionOption();
		}
		[SmokeMethod("setPrinterSelectionOption(const QString&)")]
		public virtual void SetPrinterSelectionOption(string arg1) {
			ProxyQPrinter().SetPrinterSelectionOption(arg1);
		}
		[SmokeMethod("docName() const")]
		public string DocName() {
			return ProxyQPrinter().DocName();
		}
		[SmokeMethod("setDocName(const QString&)")]
		public virtual void SetDocName(string arg1) {
			ProxyQPrinter().SetDocName(arg1);
		}
		[SmokeMethod("creator() const")]
		public string Creator() {
			return ProxyQPrinter().Creator();
		}
		[SmokeMethod("setCreator(const QString&)")]
		public virtual void SetCreator(string arg1) {
			ProxyQPrinter().SetCreator(arg1);
		}
		[SmokeMethod("orientation() const")]
		public QPrinter.Orientation orientation() {
			return ProxyQPrinter().orientation();
		}
		[SmokeMethod("setOrientation(QPrinter::Orientation)")]
		public virtual void SetOrientation(QPrinter.Orientation arg1) {
			ProxyQPrinter().SetOrientation(arg1);
		}
		[SmokeMethod("pageSize() const")]
		public QPrinter.PageSize pageSize() {
			return ProxyQPrinter().pageSize();
		}
		[SmokeMethod("setPageSize(QPrinter::PageSize)")]
		public virtual void SetPageSize(QPrinter.PageSize arg1) {
			ProxyQPrinter().SetPageSize(arg1);
		}
		[SmokeMethod("setPageOrder(QPrinter::PageOrder)")]
		public virtual void SetPageOrder(QPrinter.PageOrder arg1) {
			ProxyQPrinter().SetPageOrder(arg1);
		}
		[SmokeMethod("pageOrder() const")]
		public QPrinter.PageOrder pageOrder() {
			return ProxyQPrinter().pageOrder();
		}
		[SmokeMethod("setResolution(int)")]
		public new void SetResolution(int arg1) {
			ProxyQPrinter().SetResolution(arg1);
		}
		[SmokeMethod("resolution() const")]
		public new int Resolution() {
			return ProxyQPrinter().Resolution();
		}
		[SmokeMethod("setColorMode(QPrinter::ColorMode)")]
		public virtual void SetColorMode(QPrinter.ColorMode arg1) {
			ProxyQPrinter().SetColorMode(arg1);
		}
		[SmokeMethod("colorMode() const")]
		public QPrinter.ColorMode colorMode() {
			return ProxyQPrinter().colorMode();
		}
		[SmokeMethod("setFullPage(bool)")]
		public virtual void SetFullPage(bool arg1) {
			ProxyQPrinter().SetFullPage(arg1);
		}
		[SmokeMethod("fullPage() const")]
		public bool FullPage() {
			return ProxyQPrinter().FullPage();
		}
		[SmokeMethod("margins() const")]
		public QSize Margins() {
			return ProxyQPrinter().Margins();
		}
		[SmokeMethod("setMargins(uint, uint, uint, uint)")]
		public void SetMargins(uint top, uint left, uint bottom, uint right) {
			ProxyQPrinter().SetMargins(top,left,bottom,right);
		}
		[SmokeMethod("margins(uint*, uint*, uint*, uint*) const")]
		public void Margins(out int top, out int left, out int bottom, out int right) {
			ProxyQPrinter().Margins(out top,out left,out bottom,out right);
		}
		[SmokeMethod("fromPage() const")]
		public int FromPage() {
			return ProxyQPrinter().FromPage();
		}
		[SmokeMethod("toPage() const")]
		public int ToPage() {
			return ProxyQPrinter().ToPage();
		}
		[SmokeMethod("setFromTo(int, int)")]
		public virtual void SetFromTo(int fromPage, int toPage) {
			ProxyQPrinter().SetFromTo(fromPage,toPage);
		}
		[SmokeMethod("minPage() const")]
		public int MinPage() {
			return ProxyQPrinter().MinPage();
		}
		[SmokeMethod("maxPage() const")]
		public int MaxPage() {
			return ProxyQPrinter().MaxPage();
		}
		[SmokeMethod("setMinMax(int, int)")]
		public virtual void SetMinMax(int minPage, int maxPage) {
			ProxyQPrinter().SetMinMax(minPage,maxPage);
		}
		[SmokeMethod("numCopies() const")]
		public int NumCopies() {
			return ProxyQPrinter().NumCopies();
		}
		[SmokeMethod("setNumCopies(int)")]
		public virtual void SetNumCopies(int arg1) {
			ProxyQPrinter().SetNumCopies(arg1);
		}
		[SmokeMethod("collateCopiesEnabled() const")]
		public bool CollateCopiesEnabled() {
			return ProxyQPrinter().CollateCopiesEnabled();
		}
		[SmokeMethod("setCollateCopiesEnabled(bool)")]
		public void SetCollateCopiesEnabled(bool arg1) {
			ProxyQPrinter().SetCollateCopiesEnabled(arg1);
		}
		[SmokeMethod("collateCopies() const")]
		public bool CollateCopies() {
			return ProxyQPrinter().CollateCopies();
		}
		[SmokeMethod("setCollateCopies(bool)")]
		public void SetCollateCopies(bool arg1) {
			ProxyQPrinter().SetCollateCopies(arg1);
		}
		[SmokeMethod("printRange() const")]
		public QPrinter.PrintRange printRange() {
			return ProxyQPrinter().printRange();
		}
		[SmokeMethod("setPrintRange(QPrinter::PrintRange)")]
		public void SetPrintRange(QPrinter.PrintRange range) {
			ProxyQPrinter().SetPrintRange(range);
		}
		[SmokeMethod("newPage()")]
		public bool NewPage() {
			return ProxyQPrinter().NewPage();
		}
		[SmokeMethod("abort()")]
		public bool Abort() {
			return ProxyQPrinter().Abort();
		}
		[SmokeMethod("aborted() const")]
		public bool Aborted() {
			return ProxyQPrinter().Aborted();
		}
		[SmokeMethod("setup(QWidget*)")]
		public bool Setup(QWidget parent) {
			return ProxyQPrinter().Setup(parent);
		}
		[SmokeMethod("setup()")]
		public bool Setup() {
			return ProxyQPrinter().Setup();
		}
		[SmokeMethod("paperSource() const")]
		public QPrinter.PaperSource paperSource() {
			return ProxyQPrinter().paperSource();
		}
		[SmokeMethod("setPaperSource(QPrinter::PaperSource)")]
		public virtual void SetPaperSource(QPrinter.PaperSource arg1) {
			ProxyQPrinter().SetPaperSource(arg1);
		}
		[SmokeMethod("setOptionEnabled(QPrinter::PrinterOption, bool)")]
		public void SetOptionEnabled(QPrinter.PrinterOption arg1, bool enable) {
			ProxyQPrinter().SetOptionEnabled(arg1,enable);
		}
		[SmokeMethod("isOptionEnabled(QPrinter::PrinterOption)")]
		public bool IsOptionEnabled(QPrinter.PrinterOption arg1) {
			return ProxyQPrinter().IsOptionEnabled(arg1);
		}
		// bool cmd(int arg1,QPainter* arg2,QPDevCmdParam* arg3); >>>> NOT CONVERTED
		[SmokeMethod("metric(int) const")]
		protected new int Metric(int arg1) {
			return ProxyQPrinter().Metric(arg1);
		}
		~QPrinter() {
			DisposeQPrinter();
		}
		public void Dispose() {
			DisposeQPrinter();
		}
		private void DisposeQPrinter() {
			ProxyQPrinter().DisposeQPrinter();
		}
	}
}
