//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  A combobox which implements a history like a unix shell. You can navigate
    ///  through all the items by using the Up or Down arrows (configurable of
    ///  course). Additionally, weighted completion is available. So you should
    ///  load and save the completion list to preserve the weighting between
    ///  sessions.
    ///  KHistoryComboBox obeys the HISTCONTROL environment variable to determine
    ///  whether duplicates in the history should be tolerated in
    ///  addToHistory() or not. During construction of KHistoryComboBox,
    ///  duplicates will be disabled when HISTCONTROL is set to "ignoredups" or
    ///  "ignoreboth". Otherwise, duplicates are enabled by default.
    ///  See <see cref="IKHistoryComboBoxSignals"></see> for signals emitted by KHistoryComboBox
    /// </remarks>        <author> Carsten Pfeiffer <pfeiffer@kde.org>
    ///  </author>
    ///         <short> A combobox for offering a history and completion.</short>
    [SmokeClass("KHistoryComboBox")]
    public class KHistoryComboBox : KComboBox, IDisposable {
        protected KHistoryComboBox(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KHistoryComboBox), this);
        }
        [Q_PROPERTY("QStringList", "historyItems")]
        public List<string> HistoryItems {
            get { return (List<string>) interceptor.Invoke("historyItems", "historyItems()", typeof(List<string>)); }
            set { interceptor.Invoke("setHistoryItems?", "setHistoryItems(QStringList)", typeof(void), typeof(List<string>), value); }
        }
        /// <remarks>
        ///  Constructs a "read-write" combobox. A read-only history combobox
        ///  doesn't make much sense, so it is only available as read-write.
        ///  Completion will be used automatically for the items in the combo.
        ///  The insertion-policy is set to NoInsert, you have to add the items
        ///  yourself via the slot addToHistory. If you want every item added,
        ///  use
        ///  <pre>
        ///  connect( combo, SIGNAL("activated( string )"),
        ///           combo, SLOT("addToHistory( string )"));
        ///  </pre>
        ///  Use QComboBox.SetMaxCount() to limit the history.
        ///  <code>parent</code> the parent object of this widget.
        ///      </remarks>        <short>    Constructs a "read-write" combobox.</short>
        public KHistoryComboBox(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KHistoryComboBox#", "KHistoryComboBox(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KHistoryComboBox() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KHistoryComboBox", "KHistoryComboBox()", typeof(void));
        }
        /// <remarks>
        ///  Same as the previous constructor, but additionally has the option
        ///  to specify whether you want to let KHistoryComboBox handle completion
        ///  or not. If set to <code>true</code>, KHistoryComboBox will sync the completion to the
        ///  contents of the combobox.
        ///      </remarks>        <short>    Same as the previous constructor, but additionally has the option  to specify whether you want to let KHistoryComboBox handle completion  or not.</short>
        public KHistoryComboBox(bool useCompletion, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KHistoryComboBox$#", "KHistoryComboBox(bool, QWidget*)", typeof(void), typeof(bool), useCompletion, typeof(QWidget), parent);
        }
        public KHistoryComboBox(bool useCompletion) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KHistoryComboBox$", "KHistoryComboBox(bool)", typeof(void), typeof(bool), useCompletion);
        }
        /// <remarks>
        ///  Inserts <code>items</code> into the combobox. <code>items</code> might get
        ///  truncated if it is longer than maxCount()
        ///  Set <code>setCompletionList</code> to true, if you don't have a list of
        ///  completions. This tells KHistoryComboBox to use all the items for the
        ///  completion object as well.
        ///  You won't have the benefit of weighted completion though, so normally
        ///  you should do something like
        ///  <pre>
        ///  KConfigGroup config(KGlobal.Config(), "somegroup");
        ///  // load the history and completion list after creating the history combo
        ///  List<string> list;
        ///  list = config.readEntry("Completion list", List<string>());
        ///  combo.CompletionObject().SetItems(list);
        ///  list = config.readEntry("History list", List<string>());
        ///  combo.SetHistoryItems(list);
        ///  [...]
        ///  // save the history and completion list when the history combo is
        ///  // destroyed
        ///  List<string> list;
        ///  KConfigGroup config(KGlobal.Config(), "somegroup");
        ///  list = combo.CompletionObject().Items();
        ///  config.writeEntry("Completion list", list);
        ///  list = combo.HistoryItems();
        ///  config.writeEntry("History list", list);
        ///  </pre>
        ///  Be sure to use different names for saving with KConfig if you have more
        ///  than one KHistoryComboBox.
        ///  Note: When <code>setCompletionList</code> is true, the items are inserted into the
        ///  KCompletion object with mode KCompletion.Insertion and the mode is set
        ///  to KCompletion.Weighted afterwards.
        /// </remarks>        <short>    Inserts <code>items</code> into the combobox.</short>
        ///         <see> historyItems</see>
        ///         <see> KComboBox.CompletionObject</see>
        ///         <see> KCompletion.SetItems</see>
        ///         <see> KCompletion.Items</see>
        public void SetHistoryItems(List<string> items, bool setCompletionList) {
            interceptor.Invoke("setHistoryItems?$", "setHistoryItems(const QStringList&, bool)", typeof(void), typeof(List<string>), items, typeof(bool), setCompletionList);
        }
        /// <remarks>
        ///  Removes all items named <code>item.</code>
        /// </remarks>        <return> <code>true</code> if at least one item was removed.
        /// </return>
        ///         <short>    Removes all items named <code>item.</code></short>
        ///         <see> addToHistory</see>
        public bool RemoveFromHistory(string item) {
            return (bool) interceptor.Invoke("removeFromHistory$", "removeFromHistory(const QString&)", typeof(bool), typeof(string), item);
        }
        /// <remarks>
        ///  Sets a pixmap provider, so that items in the combobox can have a pixmap.
        ///  KPixmapProvider is just an abstract class with the one pure virtual
        ///  method KPixmapProvider.PixmapFor(). This method is called whenever
        ///  an item is added to the KHistoryComboBoxBox. Implement it to return your
        ///  own custom pixmaps, or use the KUrlPixmapProvider from libkio,
        ///  which uses KMimeType.PixmapForUrl to resolve icons.
        ///  Set <code>prov</code> to null if you want to disable pixmaps. Default no pixmaps.
        /// </remarks>        <short>    Sets a pixmap provider, so that items in the combobox can have a pixmap.</short>
        ///         <see> pixmapProvider</see>
        public void SetPixmapProvider(KPixmapProvider prov) {
            interceptor.Invoke("setPixmapProvider#", "setPixmapProvider(KPixmapProvider*)", typeof(void), typeof(KPixmapProvider), prov);
        }
        /// <remarks>
        /// </remarks>        <return> the current pixmap provider.
        /// </return>
        ///         <short>   </short>
        ///         <see> setPixmapProvider</see>
        ///         <see> KPixmapProvider</see>
        public KPixmapProvider PixmapProvider() {
            return (KPixmapProvider) interceptor.Invoke("pixmapProvider", "pixmapProvider() const", typeof(KPixmapProvider));
        }
        /// <remarks>
        ///  Resets the current position of the up/down history. Call this
        ///  when you manually call setCurrentItem() or clearEdit().
        ///      </remarks>        <short>    Resets the current position of the up/down history.</short>
        public void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        /// <remarks>
        ///  Adds an item to the end of the history list and to the completion list.
        ///  If maxCount() is reached, the first item of the list will be
        ///  removed.
        ///  If the last inserted item is the same as <code>item</code>, it will not be
        ///  inserted again.
        ///  If duplicatesEnabled() is false, any equal existing item will be
        ///  removed before <code>item</code> is added.
        ///  Note: By using this method and not the Q and KComboBox insertItem()
        ///  methods, you make sure that the combobox stays in sync with the
        ///  completion. It would be annoying if completion would give an item
        ///  not in the combobox, and vice versa.
        /// </remarks>        <short>    Adds an item to the end of the history list and to the completion list.</short>
        ///         <see> removeFromHistory</see>
        ///         <see> QComboBox.SetDuplicatesEnabled</see>
        [Q_SLOT("void addToHistory(QString)")]
        public void AddToHistory(string item) {
            interceptor.Invoke("addToHistory$", "addToHistory(const QString&)", typeof(void), typeof(string), item);
        }
        /// <remarks>
        ///  Clears the history and the completion list.
        ///      </remarks>        <short>    Clears the history and the completion list.</short>
        [Q_SLOT("void clearHistory()")]
        public void ClearHistory() {
            interceptor.Invoke("clearHistory", "clearHistory()", typeof(void));
        }
        /// <remarks>
        ///  Handling key-events, the shortcuts to rotate the items.
        ///      </remarks>        <short>    Handling key-events, the shortcuts to rotate the items.</short>
        [SmokeMethod("keyPressEvent(QKeyEvent*)")]
        protected override void KeyPressEvent(QKeyEvent arg1) {
            interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
        }
        /// <remarks>
        ///  Handling wheel-events, to rotate the items.
        ///      </remarks>        <short>    Handling wheel-events, to rotate the items.</short>
        [SmokeMethod("wheelEvent(QWheelEvent*)")]
        protected override void WheelEvent(QWheelEvent ev) {
            interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), ev);
        }
        /// <remarks>
        ///  Inserts <code>items</code> into the combo, honoring pixmapProvider()
        ///  Does not update the completionObject.
        ///  Note: duplicatesEnabled() is not honored here.
        ///  Called from setHistoryItems() and setPixmapProvider()
        ///      </remarks>        <short>    Inserts <code>items</code> into the combo, honoring pixmapProvider()  Does not update the completionObject.</short>
        protected void InsertItems(List<string> items) {
            interceptor.Invoke("insertItems?", "insertItems(const QStringList&)", typeof(void), typeof(List<string>), items);
        }
        /// <remarks>
        /// </remarks>        <return> if we can modify the completion object or not.
        ///      </return>
        ///         <short>   </short>
        protected bool UseCompletion() {
            return (bool) interceptor.Invoke("useCompletion", "useCompletion() const", typeof(bool));
        }
        ~KHistoryComboBox() {
            interceptor.Invoke("~KHistoryComboBox", "~KHistoryComboBox()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KHistoryComboBox", "~KHistoryComboBox()", typeof(void));
        }
        protected new IKHistoryComboBoxSignals Emit {
            get { return (IKHistoryComboBoxSignals) Q_EMIT; }
        }
    }

    public interface IKHistoryComboBoxSignals : IKComboBoxSignals {
        /// <remarks>
        ///  Emitted when the history was cleared by the entry in the popup menu.
        ///      </remarks>        <short>    Emitted when the history was cleared by the entry in the popup menu.</short>
        [Q_SIGNAL("void cleared()")]
        void Cleared();
    }
}
