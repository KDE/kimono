//Auto-generated by kalyptus. DO NOT EDIT.
namespace Akonadi {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  Remote Id must only be set by the resource storing the item, other clients
    ///  should leave it empty, since the resource responsible for the target collection
    ///  will be notified about the addition and then create a suitable remote Id.
    ///  There are two different forms of ItemSync usage:
    ///  - Full-Sync: meaning the client provides all valid items, i.e. any item not
    ///    part of the list but currently stored in Akonadi will be removed
    ///  - Incremental-Sync: meaning the client provides two lists, one for items which
    ///    are new or modified and one for items which should be removed. Any item not
    ///    part of either list but currently stored in Akonadi will not be changed.
    ///  @note This is provided for convenience to implement "save all" like behavior,
    ///        however it is strongly recommended to use single item jobs whenever
    ///        possible, e.g. ItemCreateJob, ItemModifyJob and ItemDeleteJob
    /// </remarks>        <author> Tobias Koenig <tokoe@kde.org>
    ///  </author>
    ///         <short> Syncs between items known to a client (usually a resource) and the Akonadi storage. </short>
    [SmokeClass("Akonadi::ItemSync")]
    public class ItemSync : Akonadi.Job, IDisposable {
        protected ItemSync(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ItemSync), this);
        }
        /// <remarks>
        ///  Creates a new item synchronizer.
        /// <param> name="collection" The collection we are syncing.
        /// </param><param> name="parent" The parent object.
        ///      </param></remarks>        <short>    Creates a new item synchronizer.</short>
        public ItemSync(Akonadi.Collection collection, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ItemSync##", "ItemSync(const Akonadi::Collection&, QObject*)", typeof(void), typeof(Akonadi.Collection), collection, typeof(QObject), parent);
        }
        public ItemSync(Akonadi.Collection collection) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ItemSync#", "ItemSync(const Akonadi::Collection&)", typeof(void), typeof(Akonadi.Collection), collection);
        }
        /// <remarks>
        ///  Sets the full item list for the collection.
        ///  Usually the result of a full item listing.
        ///  @warning If the client using this is a resource, all items must have
        ///           a valid remote identifier.
        /// <param> name="items" A list of items.
        ///      </param></remarks>        <short>    Sets the full item list for the collection.</short>
        public void SetFullSyncItems(List<Akonadi.Item> items) {
            interceptor.Invoke("setFullSyncItems?", "setFullSyncItems(const QList<Akonadi::Item>&)", typeof(void), typeof(List<Akonadi.Item>), items);
        }
        /// <remarks>
        ///  Set the amount of items which you are going to return in total
        ///  by using the setFullSyncItems() method.
        /// <param> name="amount" The amount of items in total.
        ///      </param></remarks>        <short>    Set the amount of items which you are going to return in total  by using the setFullSyncItems() method.</short>
        public void SetTotalItems(int amount) {
            interceptor.Invoke("setTotalItems$", "setTotalItems(int)", typeof(void), typeof(int), amount);
        }
        /// <remarks>
        ///       Enable item streaming. Item streaming means that the items delivered by setXItems() calls
        ///       are delivered in chunks and you manually indicate when all items have been delivered
        ///       by calling deliveryDone().
        /// <param> name="enable" <code>true</code> to enable item streaming
        ///     </param></remarks>        <short>         Enable item streaming.</short>
        public void SetStreamingEnabled(bool enable) {
            interceptor.Invoke("setStreamingEnabled$", "setStreamingEnabled(bool)", typeof(void), typeof(bool), enable);
        }
        /// <remarks>
        ///       Notify ItemSync that all remote items have been delivered.
        ///       Only call this in streaming mode.
        ///     </remarks>        <short>         Notify ItemSync that all remote items have been delivered.</short>
        public void DeliveryDone() {
            interceptor.Invoke("deliveryDone", "deliveryDone()", typeof(void));
        }
        /// <remarks>
        ///  Sets the item lists for incrementally syncing the collection.
        ///  Usually the result of an incremental remote item listing.
        ///  @warning If the client using this is a resource, all items must have
        ///           a valid remote identifier.
        /// <param> name="changedItems" A list of items added or changed by the client.
        /// </param><param> name="removedItems" A list of items deleted by the client.
        ///      </param></remarks>        <short>    Sets the item lists for incrementally syncing the collection.</short>
        public void SetIncrementalSyncItems(List<Akonadi.Item> changedItems, List<Akonadi.Item> removedItems) {
            interceptor.Invoke("setIncrementalSyncItems??", "setIncrementalSyncItems(const QList<Akonadi::Item>&, const QList<Akonadi::Item>&)", typeof(void), typeof(List<Akonadi.Item>), changedItems, typeof(List<Akonadi.Item>), removedItems);
        }
        /// <remarks>
        ///  Sets the item fetch scope.
        ///  The ItemFetchScope controls how much of an item's data is fetched
        ///  from the server, e.g. whether to fetch the full item payload or
        ///  only meta data.
        /// <param> name="fetchScope" The new scope for item fetch operations.
        /// </param></remarks>        <short>    Sets the item fetch scope.</short>
        ///         <see> fetchScope</see>
        public void SetFetchScope(Akonadi.ItemFetchScope fetchScope) {
            interceptor.Invoke("setFetchScope#", "setFetchScope(Akonadi::ItemFetchScope&)", typeof(void), typeof(Akonadi.ItemFetchScope), fetchScope);
        }
        /// <remarks>
        ///  Returns the item fetch scope.
        ///  Since this returns a reference it can be used to conveniently modify the
        ///  current scope in-place, i.e. by calling a method on the returned reference
        ///  without storing it in a local variable. See the ItemFetchScope documentation
        ///  for an example.
        /// </remarks>        <return> a reference to the current item fetch scope
        /// </return>
        ///         <short>    Returns the item fetch scope.</short>
        ///         <see> setFetchScope</see>
        ///         <see> for</see>
        ///         <see> replacing</see>
        ///         <see> the</see>
        ///         <see> current</see>
        ///         <see> item</see>
        ///         <see> fetch</see>
        ///         <see> scope</see>
        public Akonadi.ItemFetchScope FetchScope() {
            return (Akonadi.ItemFetchScope) interceptor.Invoke("fetchScope", "fetchScope()", typeof(Akonadi.ItemFetchScope));
        }
        [SmokeMethod("doStart()")]
        protected override void DoStart() {
            interceptor.Invoke("doStart", "doStart()", typeof(void));
        }
        /// <remarks>
        ///  Reimplement this method to customize the synchronization algorithm.
        ///  You can update the <code>newItem</code> according to the <code>storedItem</code> before
        ///  it gets committed.
        ///      </remarks>        <short>    Reimplement this method to customize the synchronization algorithm.</short>
        [SmokeMethod("updateItem(const Akonadi::Item&, Akonadi::Item&)")]
        protected virtual bool UpdateItem(Akonadi.Item storedItem, Akonadi.Item newItem) {
            return (bool) interceptor.Invoke("updateItem##", "updateItem(const Akonadi::Item&, Akonadi::Item&)", typeof(bool), typeof(Akonadi.Item), storedItem, typeof(Akonadi.Item), newItem);
        }
        ~ItemSync() {
            interceptor.Invoke("~ItemSync", "~ItemSync()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ItemSync", "~ItemSync()", typeof(void));
        }
        protected new IItemSyncSignals Emit {
            get { return (IItemSyncSignals) Q_EMIT; }
        }
    }

    public interface IItemSyncSignals : Akonadi.IJobSignals {
    }
}
