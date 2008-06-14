//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  A Tip-of-the-Day dialog.
	///  This dialog class presents a tip-of-the-day.
	/// </remarks>		<author> Matthias Hoelzer-Kluepfel <mhk@caldera.de>
	///  </author>
	/// 		<short>    A Tip-of-the-Day dialog.</short>
	[SmokeClass("KTipDialog")]
	public class KTipDialog : KDialog, IDisposable {
 		protected KTipDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KTipDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KTipDialog() {
			staticInterceptor = new SmokeInvocation(typeof(KTipDialog), null);
		}
		// KTipDialog* KTipDialog(KTipDatabase* arg1,QWidget* arg2); >>>> NOT CONVERTED
		// KTipDialog* KTipDialog(KTipDatabase* arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Construct a tip dialog.
		/// <param> name="database" TipDatabase that should be used by the TipDialog.
		/// </param><param> name="parent" Parent widget of TipDialog.
		///      </param></remarks>		<short>    Construct a tip dialog.</short>
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected override bool EventFilter(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		~KTipDialog() {
			interceptor.Invoke("~KTipDialog", "~KTipDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KTipDialog", "~KTipDialog()", typeof(void));
		}
		/// <remarks>
		///  Shows a tip.
		///  This static method is all that is needed to add a tip-of-the-day
		///  dialog to an application. It will pop up the dialog, unless the
		///  user has asked that the dialog does not pop up on startup.
		///  Note that you probably want an item in the help menu calling
		///  this method with force=true.
		/// <param> name="parent" Parent widget of TipDialog.
		/// </param><param> name="tipFile" The name of the tip file. It has be relative to the "data"
		///                 resource of KStandardDirs
		/// </param><param> name="force" If true, the dialog is show, even when the users
		///               disabled it.
		///      </param></remarks>		<short>    Shows a tip.</short>
		public static void ShowTip(QWidget parent, string tipFile, bool force) {
			staticInterceptor.Invoke("showTip#$$", "showTip(QWidget*, const QString&, bool)", typeof(void), typeof(QWidget), parent, typeof(string), tipFile, typeof(bool), force);
		}
		public static void ShowTip(QWidget parent, string tipFile) {
			staticInterceptor.Invoke("showTip#$", "showTip(QWidget*, const QString&)", typeof(void), typeof(QWidget), parent, typeof(string), tipFile);
		}
		public static void ShowTip(QWidget parent) {
			staticInterceptor.Invoke("showTip#", "showTip(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		/// <remarks>
		///  Shows a tip
		///  This method behaves essentially as the one above, but expects a list of tips
		/// <param> name="parent" Parent widget of TipDialog.
		/// </param><param> name="tipFiles" A List of tip files. Each has be relative to the "data"
		///                 resource of KStandardDirs
		/// </param><param> name="force" If true, the dialog is show, even when the users
		///               disabled it.
		///      </param></remarks>		<short>    Shows a tip </short>
		public static void ShowMultiTip(QWidget parent, List<string> tipFiles, bool force) {
			staticInterceptor.Invoke("showMultiTip#?$", "showMultiTip(QWidget*, const QStringList&, bool)", typeof(void), typeof(QWidget), parent, typeof(List<string>), tipFiles, typeof(bool), force);
		}
		public static void ShowMultiTip(QWidget parent, List<string> tipFiles) {
			staticInterceptor.Invoke("showMultiTip#?", "showMultiTip(QWidget*, const QStringList&)", typeof(void), typeof(QWidget), parent, typeof(List<string>), tipFiles);
		}
		/// <remarks>
		///  Shows a tip.
		///  This methods calls showTip() with the applications main window as parent.
		///      </remarks>		<short>    Shows a tip.</short>
		public static void ShowTip(string tipFile, bool force) {
			staticInterceptor.Invoke("showTip$$", "showTip(const QString&, bool)", typeof(void), typeof(string), tipFile, typeof(bool), force);
		}
		public static void ShowTip(string tipFile) {
			staticInterceptor.Invoke("showTip$", "showTip(const QString&)", typeof(void), typeof(string), tipFile);
		}
		public static void ShowTip() {
			staticInterceptor.Invoke("showTip", "showTip()", typeof(void));
		}
		/// <remarks>
		///  Toggles the start behavior.
		///  Normally, the user can disable the display of the tip in the dialog.
		///  This is just a way to change this setting from outside.
		///      </remarks>		<short>    Toggles the start behavior.</short>
		public static void SetShowOnStart(bool show) {
			staticInterceptor.Invoke("setShowOnStart$", "setShowOnStart(bool)", typeof(void), typeof(bool), show);
		}
		protected new IKTipDialogSignals Emit {
			get { return (IKTipDialogSignals) Q_EMIT; }
		}
	}

	public interface IKTipDialogSignals : IKDialogSignals {
	}
}
