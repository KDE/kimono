//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  See <see cref="IKPageWidgetSignals"></see> for signals emitted by KPageWidget
	/// </remarks>		<author> Tobias Koenig (tokoe@kde.org)
	///  </author>
	/// 		<short> Page widget with many layouts (faces). </short>
	/// 		<see> KPageView</see>
	/// 		<see> with</see>
	/// 		<see> hierarchical</see>
	/// 		<see> page</see>
	/// 		<see> model.</see>
	[SmokeClass("KPageWidget")]
	public class KPageWidget : KPageView, IDisposable {
 		protected KPageWidget(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPageWidget), this);
		}
		// KPageWidget* KPageWidget(KPageWidgetPrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
		/// <remarks>
		///  Creates a new page widget.
		/// <param> name="parent" The parent widget.
		///      </param></remarks>		<short>    Creates a new page widget.</short>
		public KPageWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPageWidget#", "KPageWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPageWidget() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPageWidget", "KPageWidget()", typeof(void));
		}
		/// <remarks>
		///  Adds a new top level page to the widget.
		/// <param> name="widget" The widget of the page.
		/// </param><param> name="name" The name which is displayed in the navigation view.
		/// </param></remarks>		<return> The associated @see KPageWidgetItem.
		///      </return>
		/// 		<short>    Adds a new top level page to the widget.</short>
		public KPageWidgetItem AddPage(QWidget widget, string name) {
			return (KPageWidgetItem) interceptor.Invoke("addPage#$", "addPage(QWidget*, const QString&)", typeof(KPageWidgetItem), typeof(QWidget), widget, typeof(string), name);
		}
		/// <remarks>
		///  Adds a new top level page to the widget.
		/// <param> name="item" The @see KPageWidgetItem which describes the page.
		///      </param></remarks>		<short>    Adds a new top level page to the widget.</short>
		public void AddPage(KPageWidgetItem item) {
			interceptor.Invoke("addPage#", "addPage(KPageWidgetItem*)", typeof(void), typeof(KPageWidgetItem), item);
		}
		/// <remarks>
		///  Inserts a new page in the widget.
		/// <param> name="before" The new page will be insert before this @see KPageWidgetItem
		///                on the same level in hierarchy.
		/// </param><param> name="widget" The widget of the page.
		/// </param><param> name="name" The name which is displayed in the navigation view.
		/// </param></remarks>		<return> The associated @see KPageWidgetItem.
		///      </return>
		/// 		<short>    Inserts a new page in the widget.</short>
		public KPageWidgetItem InsertPage(KPageWidgetItem before, QWidget widget, string name) {
			return (KPageWidgetItem) interceptor.Invoke("insertPage##$", "insertPage(KPageWidgetItem*, QWidget*, const QString&)", typeof(KPageWidgetItem), typeof(KPageWidgetItem), before, typeof(QWidget), widget, typeof(string), name);
		}
		/// <remarks>
		///  Inserts a new page in the widget.
		/// <param> name="before" The new page will be insert before this @see KPageWidgetItem
		///                on the same level in hierarchy.
		/// </param><param> name="item" The @see KPageWidgetItem which describes the page.
		///      </param></remarks>		<short>    Inserts a new page in the widget.</short>
		public void InsertPage(KPageWidgetItem before, KPageWidgetItem item) {
			interceptor.Invoke("insertPage##", "insertPage(KPageWidgetItem*, KPageWidgetItem*)", typeof(void), typeof(KPageWidgetItem), before, typeof(KPageWidgetItem), item);
		}
		/// <remarks>
		///  Inserts a new sub page in the widget.
		/// <param> name="parent" The new page will be insert as child of this @see KPageWidgetItem.
		/// </param><param> name="widget" The widget of the page.
		/// </param><param> name="name" The name which is displayed in the navigation view.
		/// </param></remarks>		<return> The associated @see KPageWidgetItem.
		///      </return>
		/// 		<short>    Inserts a new sub page in the widget.</short>
		public KPageWidgetItem AddSubPage(KPageWidgetItem parent, QWidget widget, string name) {
			return (KPageWidgetItem) interceptor.Invoke("addSubPage##$", "addSubPage(KPageWidgetItem*, QWidget*, const QString&)", typeof(KPageWidgetItem), typeof(KPageWidgetItem), parent, typeof(QWidget), widget, typeof(string), name);
		}
		/// <remarks>
		///  Inserts a new sub page in the widget.
		/// <param> name="parent" The new page will be insert as child of this @see KPageWidgetItem.
		/// </param><param> name="item" The @see KPageWidgetItem which describes the page.
		///      </param></remarks>		<short>    Inserts a new sub page in the widget.</short>
		public void AddSubPage(KPageWidgetItem parent, KPageWidgetItem item) {
			interceptor.Invoke("addSubPage##", "addSubPage(KPageWidgetItem*, KPageWidgetItem*)", typeof(void), typeof(KPageWidgetItem), parent, typeof(KPageWidgetItem), item);
		}
		/// <remarks>
		///  Removes the page associated with the given @see KPageWidgetItem.
		///      </remarks>		<short>    Removes the page associated with the given @see KPageWidgetItem.</short>
		public void RemovePage(KPageWidgetItem item) {
			interceptor.Invoke("removePage#", "removePage(KPageWidgetItem*)", typeof(void), typeof(KPageWidgetItem), item);
		}
		/// <remarks>
		///  Sets the page which is associated with the given @see KPageWidgetItem to
		///  be the current page and emits the currentPageChanged() signal.
		///      </remarks>		<short>    Sets the page which is associated with the given @see KPageWidgetItem to  be the current page and emits the currentPageChanged() signal.</short>
		public void SetCurrentPage(KPageWidgetItem item) {
			interceptor.Invoke("setCurrentPage#", "setCurrentPage(KPageWidgetItem*)", typeof(void), typeof(KPageWidgetItem), item);
		}
		/// <remarks>
		///  Returns the @see KPageWidgetItem for the current page or 0 if there is no
		///  current page.
		///      </remarks>		<short>    Returns the @see KPageWidgetItem for the current page or 0 if there is no  current page.</short>
		public new KPageWidgetItem CurrentPage() {
			return (KPageWidgetItem) interceptor.Invoke("currentPage", "currentPage() const", typeof(KPageWidgetItem));
		}
		~KPageWidget() {
			interceptor.Invoke("~KPageWidget", "~KPageWidget()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPageWidget", "~KPageWidget()", typeof(void));
		}
		protected new IKPageWidgetSignals Emit {
			get { return (IKPageWidgetSignals) Q_EMIT; }
		}
	}

	public interface IKPageWidgetSignals : IKPageViewSignals {
		/// <remarks>
		///  This signal is emitted whenever the current page has changed.
		/// <param> name="item" The new current page or 0 if no current page is available.
		///      </param></remarks>		<short>    This signal is emitted whenever the current page has changed.</short>
		[Q_SIGNAL("void currentPageChanged(KPageWidgetItem*, KPageWidgetItem*)")]
		void CurrentPageChanged(KPageWidgetItem current, KPageWidgetItem before);
		/// <remarks>
		///  This signal is emitted whenever a checkable page changes its state. @param checked is true
		///  when the @param page is checked, or false if the @param page is unchecked.
		///      </remarks>		<short>    This signal is emitted whenever a checkable page changes its state.</short>
		[Q_SIGNAL("void pageToggled(KPageWidgetItem*, bool)")]
		void PageToggled(KPageWidgetItem page, bool arg2);
		/// <remarks>
		///  This signal is emitted when a page is removed.
		/// <param> name="page" The page which is removed
		///  </param></remarks>		<short>    This signal is emitted when a page is removed.</short>
		[Q_SIGNAL("void pageRemoved(KPageWidgetItem*)")]
		void PageRemoved(KPageWidgetItem page);
	}
}
