//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  Every part can use this class to customize the statusbar as long as it is active.
	///  Add items via addStatusBarItem and remove an item with removeStatusBarItem.
	///  IMPORTANT: do NOT add any items immediately after constructing the extension.
	///  Give the application time to set the statusbar in the extension if necessary.
	///    </remarks>		<short> an extension for KParts that allows more sophisticated statusbar handling.</short>
	[SmokeClass("KParts::StatusBarExtension")]
	public class StatusBarExtension : QObject, IDisposable {
 		protected StatusBarExtension(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(StatusBarExtension), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static StatusBarExtension() {
			staticInterceptor = new SmokeInvocation(typeof(StatusBarExtension), null);
		}
		public StatusBarExtension(KParts.ReadOnlyPart parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("StatusBarExtension#", "StatusBarExtension(KParts::ReadOnlyPart*)", typeof(void), typeof(KParts.ReadOnlyPart), parent);
		}
		/// <remarks>
		///  This adds a widget to the statusbar for this part.
		///  If you use this method instead of using statusBar() directly,
		///  this extension will take care of removing the items when the parts GUI
		///  is deactivated and will re-add them when it is reactivated.
		///  The parameters are the same as QStatusBar.AddWidget().
		///  Note that you can't use KStatusBar methods (inserting text items by id)
		///  but you can create a KStatusBarLabel with a dummy id instead, and use
		///  it directly in order to get the same look and feel.
		/// <param> name="widget" the widget to add
		/// </param><param> name="stretch" the stretch factor. 0 for a minimum size.
		/// </param><param> name="permanent" passed to QStatusBar.AddWidget as the "permanent" bool.
		///  Note that the item isn't really permanent though, it goes away when
		///  the part is unactivated. This simply controls where temporary messages
		///  hide the <code>widget</code>, and whether it's added to the left or to the right side.
		/// </param> IMPORTANT: do NOT add any items immediately after constructing the extension.
		///  Give the application time to set the statusbar in the extension if necessary.
		///        </remarks>		<short>    This adds a widget to the statusbar for this part.</short>
		public void AddStatusBarItem(QWidget widget, int stretch, bool permanent) {
			interceptor.Invoke("addStatusBarItem#$$", "addStatusBarItem(QWidget*, int, bool)", typeof(void), typeof(QWidget), widget, typeof(int), stretch, typeof(bool), permanent);
		}
		/// <remarks>
		///  Remove a widget from the statusbar for this part.
		///        </remarks>		<short>    Remove a widget from the statusbar for this part.</short>
		public void RemoveStatusBarItem(QWidget widget) {
			interceptor.Invoke("removeStatusBarItem#", "removeStatusBarItem(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		/// <remarks>
		/// </remarks>		<return> the statusbar of the KMainWindow in which this part is currently embedded.
		///  WARNING: this could return 0L
		///        </return>
		/// 		<short>   </short>
		public KStatusBar StatusBar() {
			return (KStatusBar) interceptor.Invoke("statusBar", "statusBar() const", typeof(KStatusBar));
		}
		/// <remarks>
		///  This allows the hosting application to set a particular KStatusBar
		///  for this part. If it doesn't do this, the statusbar used will be
		///  the one of the KMainWindow in which the part is embedded.
		///  Konqueror uses this to assign a view-statusbar to the part.
		///  The part should never call this method!
		///        </remarks>		<short>    This allows the hosting application to set a particular KStatusBar  for this part.</short>
		public void SetStatusBar(KStatusBar status) {
			interceptor.Invoke("setStatusBar#", "setStatusBar(KStatusBar*)", typeof(void), typeof(KStatusBar), status);
		}
		/// <remarks> @internal </remarks>		<short>   @internal </short>
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public override bool EventFilter(QObject watched, QEvent ev) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), watched, typeof(QEvent), ev);
		}
		~StatusBarExtension() {
			interceptor.Invoke("~StatusBarExtension", "~StatusBarExtension()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~StatusBarExtension", "~StatusBarExtension()", typeof(void));
		}
		/// <remarks>
		///  Queries <code>obj</code> for a child object which inherits from this
		///  BrowserExtension class. Convenience method.
		///        </remarks>		<short>    Queries <code>obj</code> for a child object which inherits from this  BrowserExtension class.</short>
		public static KParts.StatusBarExtension ChildObject(QObject arg1) {
			return (KParts.StatusBarExtension) staticInterceptor.Invoke("childObject#", "childObject(QObject*)", typeof(KParts.StatusBarExtension), typeof(QObject), arg1);
		}
		protected new IStatusBarExtensionSignals Emit {
			get { return (IStatusBarExtensionSignals) Q_EMIT; }
		}
	}

	public interface IStatusBarExtensionSignals : IQObjectSignals {
	}
}
