//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  This class provides a widget base class which handles multiple
    ///  pages and allows the user to switch between these pages in
    ///  different ways.
    ///  Currently, <code>Auto</code>, <code>Plain</code>, <code>List</code>, <code>Tree</code> and <code>Tabbed</code> face
    ///  types are available. @see KPageWidget
    ///  <li><b>Example:</b></li>
    ///  <pre>
    ///   KPageModel model = new MyPageModel();
    ///   KPageView view = new KPageView( this );
    ///   view.SetModel( model );
    ///   view.SetFaceType( KPageView.List );
    ///  </pre>
    ///  See <see cref="IKPageViewSignals"></see> for signals emitted by KPageView
    /// </remarks>        <author> Tobias Koenig (tokoe@kde.org)
    ///  </author>
    ///         <short> A base class which can handle multiple pages. </short>
    [SmokeClass("KPageView")]
    public class KPageView : QWidget, IDisposable {
        protected KPageView(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KPageView), this);
        }
        /// <remarks>
        ///  This enum is used to decide which type of navigation view
        ///  shall be used in the page view.
        /// 
        /// <li>
        /// Auto   - Depending on the number of pages in the model,
        ///               the Plain (one page), the List (several pages)
        ///               or the Tree face (nested pages) will be used.
        ///               This is the default face type.
        /// </li>
        /// 
        /// <li>
        /// Plain  - No navigation view will be visible and only the
        ///               first page of the model will be shown.
        /// </li>
        /// 
        /// <li>
        /// List   - An icon list is used as navigation view.
        /// </li>
        /// 
        /// <li>
        /// Tree   - A tree list is used as navigation view.
        /// </li>
        /// 
        /// <li>
        /// Tabbed - A tab widget is used as navigation view.
        ///      
        /// </li></remarks>        <short>    This enum is used to decide which type of navigation view  shall be used in the page view.</short>
        public enum FaceType {
            Auto = 0,
            Plain = 1,
            List = 2,
            Tree = 3,
            Tabbed = 4,
        }
        [Q_PROPERTY("KPageView::FaceType", "faceType")]
        public KPageView.FaceType faceType {
            get { return (KPageView.FaceType) interceptor.Invoke("faceType", "faceType()", typeof(KPageView.FaceType)); }
            set { interceptor.Invoke("setFaceType$", "setFaceType(KPageView::FaceType)", typeof(void), typeof(KPageView.FaceType), value); }
        }
        // KPageView* KPageView(KPageViewPrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
        /// <remarks>
        ///  Creates a page view with given parent.
        ///      </remarks>        <short>    Creates a page view with given parent.</short>
        public KPageView(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPageView#", "KPageView(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KPageView() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPageView", "KPageView()", typeof(void));
        }
        /// <remarks>
        ///  Sets the <code>model</code> of the page view.
        ///  The model has to provide data for the roles defined in KPageModel.Role.
        ///      </remarks>        <short>    Sets the <code>model</code> of the page view.</short>
        public void SetModel(QAbstractItemModel model) {
            interceptor.Invoke("setModel#", "setModel(QAbstractItemModel*)", typeof(void), typeof(QAbstractItemModel), model);
        }
        /// <remarks>
        ///  Returns the model of the page view.
        ///      </remarks>        <short>    Returns the model of the page view.</short>
        public QAbstractItemModel Model() {
            return (QAbstractItemModel) interceptor.Invoke("model", "model() const", typeof(QAbstractItemModel));
        }
        /// <remarks>
        ///  Sets the page with @param index to be the current page and emits
        ///  the @see currentPageChanged signal.
        ///      </remarks>        <short>    Sets the page with @param index to be the current page and emits  the @see currentPageChanged signal.</short>
        public void SetCurrentPage(QModelIndex index) {
            interceptor.Invoke("setCurrentPage#", "setCurrentPage(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
        }
        /// <remarks>
        ///  Returns the index for the current page or an invalid index
        ///  if no current page exists.
        ///      </remarks>        <short>    Returns the index for the current page or an invalid index  if no current page exists.</short>
        public QModelIndex CurrentPage() {
            return (QModelIndex) interceptor.Invoke("currentPage", "currentPage() const", typeof(QModelIndex));
        }
        /// <remarks>
        ///  Sets the item @param delegate which can be used customize
        ///  the page view.
        ///      </remarks>        <short>    Sets the item @param delegate which can be used customize  the page view.</short>
        public void SetItemDelegate(QAbstractItemDelegate arg1) {
            interceptor.Invoke("setItemDelegate#", "setItemDelegate(QAbstractItemDelegate*)", typeof(void), typeof(QAbstractItemDelegate), arg1);
        }
        /// <remarks>
        ///  Returns the item delegate of the page view.
        ///      </remarks>        <short>    Returns the item delegate of the page view.</short>
        public QAbstractItemDelegate ItemDelegate() {
            return (QAbstractItemDelegate) interceptor.Invoke("itemDelegate", "itemDelegate() const", typeof(QAbstractItemDelegate));
        }
        /// <remarks>
        ///  Sets the <code>widget</code> which will be shown when a page is selected
        ///  that has no own widget set.
        ///      </remarks>        <short>    Sets the <code>widget</code> which will be shown when a page is selected  that has no own widget set.</short>
        public void SetDefaultWidget(QWidget widget) {
            interceptor.Invoke("setDefaultWidget#", "setDefaultWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        /// <remarks>
        ///  Returns the navigation view, depending on the current
        ///  face type.
        ///  This method can be reimplemented to provide custom
        ///  navigation views.
        ///      </remarks>        <short>    Returns the navigation view, depending on the current  face type.</short>
        [SmokeMethod("createView()")]
        protected virtual QAbstractItemView CreateView() {
            return (QAbstractItemView) interceptor.Invoke("createView", "createView()", typeof(QAbstractItemView));
        }
        /// <remarks>
        ///  Returns whether the page header should be visible.
        ///  This method can be reimplemented for adapting custom
        ///  views.
        ///      </remarks>        <short>    Returns whether the page header should be visible.</short>
        [SmokeMethod("showPageHeader() const")]
        protected virtual bool ShowPageHeader() {
            return (bool) interceptor.Invoke("showPageHeader", "showPageHeader() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns the position where the navigation view should be
        ///  located according to the page stack.
        ///  This method can be reimplemented for adapting custom
        ///  views.
        ///      </remarks>        <short>    Returns the position where the navigation view should be  located according to the page stack.</short>
        [SmokeMethod("viewPosition() const")]
        protected virtual uint ViewPosition() {
            return (uint) interceptor.Invoke("viewPosition", "viewPosition() const", typeof(uint));
        }
        ~KPageView() {
            interceptor.Invoke("~KPageView", "~KPageView()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KPageView", "~KPageView()", typeof(void));
        }
        protected new IKPageViewSignals Emit {
            get { return (IKPageViewSignals) Q_EMIT; }
        }
    }

    public interface IKPageViewSignals : IQWidgetSignals {
        /// <remarks>
        ///  This signal is emitted whenever the current page changes.
        ///  The previous page index is replaced by the current index.
        ///      </remarks>        <short>    This signal is emitted whenever the current page changes.</short>
        [Q_SIGNAL("void currentPageChanged(QModelIndex, QModelIndex)")]
        void CurrentPageChanged(QModelIndex current, QModelIndex previous);
    }
}
