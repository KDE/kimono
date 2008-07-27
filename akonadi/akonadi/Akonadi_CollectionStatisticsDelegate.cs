//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  The delegate provides the following features:
    ///     - Collections with unread items will have the foldername and the unread
    ///       column marked in bold.
    ///     - If a folder is collapsed, the unread and the total column will contain
    ///       the total sum of all child folders
    ///     - It has the possibility to draw the unread count directly after the
    ///       foldername, see toggleUnreadAfterFolderName().
    ///  Example:
    ///  @code
    ///  QTreeView view = new QTreeView( this );
    ///  Akonadi.CollectionStatisticsModel model = new Akonadi.CollectionStatisticsModel( view );
    ///  view.SetModel( model );
    ///  Akonadi.CollectionStatisticsDelegate delegate = new Akonadi.CollectionStatisticsDelegate( view );
    ///  view.SetItemDelegate( delegate );
    ///  @endcode
    /// </remarks>        <author> Thomas McGuire <thomas.mcguire@gmx.net>
    ///  </author>
    ///         <short> A delegate that draws unread and total count for CollectionStatisticsModel. </short>
    [SmokeClass("Akonadi::CollectionStatisticsDelegate")]
    public class CollectionStatisticsDelegate : QStyledItemDelegate, IDisposable {
        protected CollectionStatisticsDelegate(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(CollectionStatisticsDelegate), this);
        }
        /// <remarks>
        ///  Creates a new collection statistics delegate.
        /// <param> name="parent" The parent tree view, which will also take ownership.
        ///      </param></remarks>        <short>    Creates a new collection statistics delegate.</short>
        public CollectionStatisticsDelegate(QTreeView parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("CollectionStatisticsDelegate#", "CollectionStatisticsDelegate(QTreeView*)", typeof(void), typeof(QTreeView), parent);
        }
        /// <remarks>
        ///  Sets whether the unread count is drawn next to the folder name.
        ///  You probably want to enable this when the unread count is hidden only.
        ///  This is disabled by default.
        /// <param> name="enable" If <code>true</code>, the unread count is drawn next to the folder name,
        ///                if <code>false</code>, the folder name will be drawn normally.
        ///      </param></remarks>        <short>    Sets whether the unread count is drawn next to the folder name.</short>
        [Q_SLOT("void setUnreadCountShown(bool)")]
        public void SetUnreadCountShown(bool enable) {
            interceptor.Invoke("setUnreadCountShown$", "setUnreadCountShown(bool)", typeof(void), typeof(bool), enable);
        }
        /// <remarks>
        ///  Returns whether the unread count is drawn next to the folder name.
        ///      </remarks>        <short>    Returns whether the unread count is drawn next to the folder name.</short>
        [Q_SLOT("bool unreadCountShown()")]
        public bool UnreadCountShown() {
            return (bool) interceptor.Invoke("unreadCountShown", "unreadCountShown() const", typeof(bool));
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const")]
        protected new virtual void Paint(QPainter painter, QStyleOptionViewItem option, QModelIndex index) {
            interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
        }
        [SmokeMethod("initStyleOption(QStyleOptionViewItem*, const QModelIndex&) const")]
        protected override void InitStyleOption(QStyleOptionViewItem option, QModelIndex index) {
            interceptor.Invoke("initStyleOption##", "initStyleOption(QStyleOptionViewItem*, const QModelIndex&) const", typeof(void), typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
        }
        ~CollectionStatisticsDelegate() {
            interceptor.Invoke("~CollectionStatisticsDelegate", "~CollectionStatisticsDelegate()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~CollectionStatisticsDelegate", "~CollectionStatisticsDelegate()", typeof(void));
        }
        protected new ICollectionStatisticsDelegateSignals Emit {
            get { return (ICollectionStatisticsDelegateSignals) Q_EMIT; }
        }
    }

    public interface ICollectionStatisticsDelegateSignals : IQStyledItemDelegateSignals {
    }
}