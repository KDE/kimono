//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Text;
	using System.Collections.Generic;
	/// <remarks>
	///  This class offers easy use of "auto-completion", "manual-completion" or
	///  "shell completion" on string objects. A common use is completing filenames
	///  or URLs (see KUrlCompletion()).
	///  But it is not limited to URL-completion -- everything should be completable!
	///  The user should be able to complete email-addresses, telephone-numbers,
	///  commands, SQL queries, ...
	///  Every time your program knows what the user can type into an edit-field, you
	///  should offer completion. With KCompletion, this is very easy, and if you are
	///  using a line edit widget ( KLineEdit), it is even more easy.
	///  Basically, you tell a KCompletion object what strings should be completable
	///  and whenever completion should be invoked, you call makeCompletion().
	///  KLineEdit and (an editable) KComboBox even do this automatically for you.
	///  KCompletion offers the completed string via the signal match() and
	///  all matching strings (when the result is ambiguous) via the method
	///  allMatches().
	///  Notice: auto-completion, shell completion and manual completion work
	///          slightly differently:
	/// 
	/// <li>
	/// auto-completion always returns a complete item as match.
	///      When more than one matching items are available, it will deliver just
	///      the first (depending on sorting order) item. Iterating over all matches
	///      is possible via nextMatch() and previousMatch().
	/// </li>
	/// 
	/// <li>
	/// popup-completion works in the same way, the only difference being that
	///      the completed items are not put into the edit-widget, but into a
	///      separate popup-box.
	/// </li>
	/// 
	/// <li>
	/// manual completion works the same way as auto-completion, the
	///      subtle difference is, that it isn't invoked automatically while the user
	///      is typing, but only when the user presses a special key. The difference
	///      of manual and auto-completion is therefore only visible in UI classes,
	///      KCompletion needs to know whether to deliver partial matches
	///      (shell completion) or whole matches (auto/manual completion), therefore
	///  KGlobalSettings.CompletionMan and
	///  KGlobalSettings.CompletionAuto have the exact same effect in
	///      KCompletion.
	/// </li>
	/// 
	/// <li>
	/// shell completion works like how shells complete filenames:
	///      when multiple matches are available, the longest possible string of all
	///      matches is returned (i.e. only a partial item).
	///      Iterating over all matching items (complete, not partial) is possible
	///      via nextMatch() and previousMatch().
	/// </li>
	///  You don't have to worry much about that though, KCompletion handles
	///  that for you, according to the setting setCompletionMode().
	///  The default setting is globally configured by the user and read
	///  from KGlobalSettings.CompletionMode().
	///  A short example:
	///  <pre>
	///  KCompletion completion;
	///  completion.setOrder( KCompletion.Sorted );
	///  completion.addItem( "pfeiffer@kde.org" );
	///  completion.addItem( "coolo@kde.org" );
	///  completion.addItem( "carpdjih@sp.zrz.tu-berlin.de" );
	///  completion.addItem( "carp@cs.tu-berlin.de" );
	///  cout << completion.makeCompletion( "ca" ).latin1() << endl;
	///  </pre>
	///  In shell-completion-mode, this will be "carp"; in auto-completion-
	///  mode it will be "carp\@cs.tu-berlin.de", as that is alphabetically
	///  smaller.
	///  If setOrder was set to Insertion, "carpdjih\@sp.zrz.tu-berlin.de"
	///  would be completed in auto-completion-mode, as that was inserted before
	///  "carp\@cs.tu-berlin.de".
	///  You can dynamically update the completable items by removing and adding them
	///  whenever you want.
	///  For advanced usage, you could even use multiple KCompletion objects. E.g.
	///  imagine an editor like kwrite with multiple open files. You could store
	///  items of each file in a different KCompletion object, so that you know (and
	///  tell the user) where a completion comes from.
	///  Note: KCompletion does not work with strings that contain 0x0 characters
	///        (unicode nul), as this is used internally as a delimiter.
	///  You may inherit from KCompletion and override makeCompletion() in
	///  special cases (like reading directories/urls and then supplying the
	///  contents to KCompletion, as KUrlCompletion does), but generally, this is
	///  not necessary.
	///  See <see cref="IKCompletionSignals"></see> for signals emitted by KCompletion
	/// </remarks>		<author> Carsten Pfeiffer <pfeiffer@kde.org>
	///  </author>
	/// 		<short> A generic class for completing strings.</short>
	[SmokeClass("KCompletion")]
	public class KCompletion : QObject, IDisposable {
 		protected KCompletion(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KCompletion), this);
		}
		/// <remarks>
		///  Constants that represent the order in which KCompletion performs
		///  completion-lookups.
		///      </remarks>		<short>    Constants that represent the order in which KCompletion performs  completion-lookups.</short>
		public enum CompOrder {
			Sorted = 0,
			Insertion = 1,
			Weighted = 2,
		}
		[Q_PROPERTY("KCompletion::CompOrder", "order")]
		public KCompletion.CompOrder Order {
			get { return (KCompletion.CompOrder) interceptor.Invoke("order", "order()", typeof(KCompletion.CompOrder)); }
			set { interceptor.Invoke("setOrder$", "setOrder(KCompletion::CompOrder)", typeof(void), typeof(KCompletion.CompOrder), value); }
		}
		[Q_PROPERTY("bool", "ignoreCase")]
		public bool IgnoreCase {
			get { return (bool) interceptor.Invoke("ignoreCase", "ignoreCase()", typeof(bool)); }
			set { interceptor.Invoke("setIgnoreCase$", "setIgnoreCase(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QStringList", "items")]
		public List<string> Items {
			get { return (List<string>) interceptor.Invoke("items", "items()", typeof(List<string>)); }
			set { interceptor.Invoke("setItems?", "setItems(QStringList)", typeof(void), typeof(List<string>), value); }
		}
		/// <remarks>
		///  Constructor, nothing special here :)
		///      </remarks>		<short>    Constructor, nothing special here :)      </short>
		public KCompletion() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCompletion", "KCompletion()", typeof(void));
		}
		/// <remarks>
		///  Attempts to find an item in the list of available completions,
		///  that begins with <code>string.</code> Will either return the first matching item
		///  (if there is more than one match) or string(), if no match was
		///  found.
		///  In the latter case, a sound will be issued, depending on
		///  soundsEnabled().
		///  If a match was found, it will also be emitted via the signal
		///  match().
		///  If this is called twice or more often with the same string while no
		///  items were added or removed in the meantime, all available completions
		///  will be emitted via the signal #matches().
		///  This happens only in shell-completion-mode.
		/// <param> name="string" the string to complete
		/// </param></remarks>		<return> the matching item, or string() if there is no matching
		///  item.
		/// </return>
		/// 		<short>    Attempts to find an item in the list of available completions,  that begins with <code>string.</code></short>
		/// 		<see> slotMakeCompletion</see>
		/// 		<see> substringCompletion</see>
		[SmokeMethod("makeCompletion(const QString&)")]
		public virtual string MakeCompletion(string arg1) {
			return (string) interceptor.Invoke("makeCompletion$", "makeCompletion(const QString&)", typeof(string), typeof(string), arg1);
		}
		/// <remarks>
		///  Returns a list of all completion items that contain the given <code>string.</code>
		/// <param> name="string" the string to complete
		/// </param></remarks>		<return> a list of items which all contain <code>text</code> as a substring,
		///  i.e. not necessarily at the beginning.
		/// </return>
		/// 		<short>    Returns a list of all completion items that contain the given <code>string.</code></short>
		/// 		<see> makeCompletion</see>
		public List<string> SubstringCompletion(string arg1) {
			return (List<string>) interceptor.Invoke("substringCompletion$", "substringCompletion(const QString&) const", typeof(List<string>), typeof(string), arg1);
		}
		/// <remarks>
		///  Returns the next item from the matching-items-list.
		///  When reaching the beginning, the list is rotated so it will return the
		///  last match and a sound is issued (depending on soundsEnabled()).
		/// </remarks>		<return> the next item from the matching-items-list.
		///  When there is no match, string() is returned and
		///  a sound is be issued.
		/// </return>
		/// 		<short>    Returns the next item from the matching-items-list.</short>
		/// 		<see> slotPreviousMatch</see>
		public string PreviousMatch() {
			return (string) interceptor.Invoke("previousMatch", "previousMatch()", typeof(string));
		}
		/// <remarks>
		///  Returns the next item from the matching-items-list.
		///  When reaching the last item, the list is rotated, so it will return
		///  the first match and a sound is issued (depending on
		///  soundsEnabled()).
		/// </remarks>		<return> the next item from the matching-items-list.  When there is no
		///  match, string() is returned and a sound is issued
		/// </return>
		/// 		<short>    Returns the next item from the matching-items-list.</short>
		/// 		<see> slotNextMatch</see>
		public string NextMatch() {
			return (string) interceptor.Invoke("nextMatch", "nextMatch()", typeof(string));
		}
		/// <remarks>
		///  Returns the last match. Might be useful if you need to check whether
		///  a completion is different from the last one.
		/// </remarks>		<return> the last match. string() is returned when there is no
		///          last match.
		///      </return>
		/// 		<short>    Returns the last match.</short>
		[SmokeMethod("lastMatch() const")]
		public virtual string LastMatch() {
			return (string) interceptor.Invoke("lastMatch", "lastMatch() const", typeof(string));
		}
		/// <remarks>
		///  Returns true when the completion object contains no entries.
		///      </remarks>		<short>    Returns true when the completion object contains no entries.</short>
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		/// <remarks>
		///  Sets the completion mode to Auto/Manual, Shell or None.
		///  If you don't set the mode explicitly, the global default value
		///  KGlobalSettings.CompletionMode() is used.
		///  KGlobalSettings.CompletionNone disables completion.
		/// <param> name="mode" the completion mode
		/// </param></remarks>		<short>    Sets the completion mode to Auto/Manual, Shell or None.</short>
		/// 		<see> completionMode</see>
		/// 		<see> KGlobalSettings.CompletionMode</see>
		[SmokeMethod("setCompletionMode(KGlobalSettings::Completion)")]
		public virtual void SetCompletionMode(KGlobalSettings.Completion mode) {
			interceptor.Invoke("setCompletionMode$", "setCompletionMode(KGlobalSettings::Completion)", typeof(void), typeof(KGlobalSettings.Completion), mode);
		}
		/// <remarks>
		///  Return the current completion mode.
		///  May be different from KGlobalSettings.CompletionMode(), if you
		///  explicitly called setCompletionMode().
		/// </remarks>		<return> the current completion mode
		/// </return>
		/// 		<short>    Return the current completion mode.</short>
		/// 		<see> setCompletionMode</see>
		public KGlobalSettings.Completion CompletionMode() {
			return (KGlobalSettings.Completion) interceptor.Invoke("completionMode", "completionMode() const", typeof(KGlobalSettings.Completion));
		}
		/// <remarks>
		///  KCompletion offers three different ways in which it offers its items:
		/// 
		/// <li>
		/// in the order of insertion
		/// </li>
		/// 
		/// <li>
		/// sorted alphabetically
		/// </li>
		/// 
		/// <li>
		/// weighted
		/// </li>
		///  Choosing weighted makes KCompletion perform an implicit weighting based
		///  on how often an item is inserted. Imagine a web browser with a location
		///  bar, where the user enters URLs. The more often a URL is entered, the
		///  higher priority it gets.
		///  Note: Setting the order to sorted only affects new inserted items,
		///  already existing items will stay in the current order. So you probably
		///  want to call setOrder( Sorted ) before inserting items, when you want
		///  everything sorted.
		///  Default is insertion order.
		/// <param> name="order" the new order
		/// </param></remarks>		<short>    KCompletion offers three different ways in which it offers its items: </short>
		/// 		<see> order</see>
		[SmokeMethod("setOrder(KCompletion::CompOrder)")]
		public virtual void SetOrder(KCompletion.CompOrder order) {
			interceptor.Invoke("setOrder$", "setOrder(KCompletion::CompOrder)", typeof(void), typeof(KCompletion.CompOrder), order);
		}
		/// <remarks>
		///  Setting this to true makes KCompletion behave case insensitively.
		///  E.g. makeCompletion( "CA" ); might return "carp\@cs.tu-berlin.de".
		///  Default is false (case sensitive).
		/// <param> name="ignoreCase" true to ignore the case
		/// </param></remarks>		<short>    Setting this to true makes KCompletion behave case insensitively.</short>
		/// 		<see> ignoreCase</see>
		[SmokeMethod("setIgnoreCase(bool)")]
		public virtual void SetIgnoreCase(bool ignoreCase) {
			interceptor.Invoke("setIgnoreCase$", "setIgnoreCase(bool)", typeof(void), typeof(bool), ignoreCase);
		}
		/// <remarks>
		///  Returns a list of all items matching the last completed string.
		///  Might take some time, when you have LOTS of items.
		/// </remarks>		<return> a list of all matches for the last completed string.
		/// </return>
		/// 		<short>    Returns a list of all items matching the last completed string.</short>
		/// 		<see> substringCompletion</see>
		public List<string> AllMatches() {
			return (List<string>) interceptor.Invoke("allMatches", "allMatches()", typeof(List<string>));
		}
		/// <remarks>
		///  Returns a list of all items matching <code>string.</code>
		/// <param> name="string" the string to match
		/// </param></remarks>		<return> the list of all matches
		///      </return>
		/// 		<short>    Returns a list of all items matching <code>string.</code></short>
		public List<string> AllMatches(string arg1) {
			return (List<string>) interceptor.Invoke("allMatches$", "allMatches(const QString&)", typeof(List<string>), typeof(string), arg1);
		}
		/// <remarks>
		///  Returns a list of all items matching the last completed string.
		///  Might take some time, when you have LOTS of items.
		///  The matches are returned as KCompletionMatches, which also
		///  keeps the weight of the matches, allowing
		///  you to modify some matches or merge them with matches
		///  from another call to allWeightedMatches(), and sort the matches
		///  after that in order to have the matches ordered correctly.
		/// </remarks>		<return> a list of all completion matches
		/// </return>
		/// 		<short>    Returns a list of all items matching the last completed string.</short>
		/// 		<see> substringCompletion</see>
		public List<string> AllWeightedMatches() {
			return (List<string>) interceptor.Invoke("allWeightedMatches", "allWeightedMatches()", typeof(List<string>));
		}
		/// <remarks>
		///  Returns a list of all items matching <code>string.</code>
		/// <param> name="string" the string to match
		/// </param></remarks>		<return> a list of all matches
		///      </return>
		/// 		<short>    Returns a list of all items matching <code>string.</code></short>
		public List<string> AllWeightedMatches(string arg1) {
			return (List<string>) interceptor.Invoke("allWeightedMatches$", "allWeightedMatches(const QString&)", typeof(List<string>), typeof(string), arg1);
		}
		/// <remarks>
		///  Enables/disables playing a sound when
		/// 
		/// <li>
		/// makeCompletion() can't find a match
		/// </li>
		/// 
		/// <li>
		/// there is a partial completion (= multiple matches in
		///      Shell-completion mode)
		/// </li>
		/// 
		/// <li>
		/// nextMatch() or previousMatch() hit the last possible
		///      match . rotation
		/// </li>
		///  For playing the sounds, KNotifyClient() is used.
		/// <param> name="enable" true to enable sounds
		/// </param></remarks>		<short>    Enables/disables playing a sound when </short>
		/// 		<see> soundsEnabled</see>
		[SmokeMethod("setSoundsEnabled(bool)")]
		public virtual void SetSoundsEnabled(bool enable) {
			interceptor.Invoke("setSoundsEnabled$", "setSoundsEnabled(bool)", typeof(void), typeof(bool), enable);
		}
		/// <remarks>
		///  Tells you whether KCompletion will play sounds on certain occasions.
		///  Default is enabled.
		/// </remarks>		<return> true if sounds are enabled
		/// </return>
		/// 		<short>    Tells you whether KCompletion will play sounds on certain occasions.</short>
		/// 		<see> setSoundsEnabled</see>
		public bool SoundsEnabled() {
			return (bool) interceptor.Invoke("soundsEnabled", "soundsEnabled() const", typeof(bool));
		}
		/// <remarks>
		///  Returns true when more than one match is found.
		/// </remarks>		<return> true if there are more than one match
		/// </return>
		/// 		<short>    Returns true when more than one match is found.</short>
		/// 		<see> multipleMatches</see>
		public bool HasMultipleMatches() {
			return (bool) interceptor.Invoke("hasMultipleMatches", "hasMultipleMatches() const", typeof(bool));
		}
		/// <remarks>
		///  Attempts to complete "string" and emits the completion via match().
		///  Same as makeCompletion() (just as a slot).
		/// <param> name="string" the string to complete
		/// </param></remarks>		<short>    Attempts to complete "string" and emits the completion via match().</short>
		/// 		<see> makeCompletion</see>
		[Q_SLOT("void slotMakeCompletion(QString)")]
		public void SlotMakeCompletion(string arg1) {
			interceptor.Invoke("slotMakeCompletion$", "slotMakeCompletion(const QString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Searches the previous matching item and emits it via match().
		///  Same as previousMatch() (just as a slot).
		/// </remarks>		<short>    Searches the previous matching item and emits it via match().</short>
		/// 		<see> previousMatch</see>
		[Q_SLOT("void slotPreviousMatch()")]
		public void SlotPreviousMatch() {
			interceptor.Invoke("slotPreviousMatch", "slotPreviousMatch()", typeof(void));
		}
		/// <remarks>
		///  Searches the next matching item and emits it via match().
		///  Same as nextMatch() (just as a slot).
		/// </remarks>		<short>    Searches the next matching item and emits it via match().</short>
		/// 		<see> nextMatch</see>
		[Q_SLOT("void slotNextMatch()")]
		public void SlotNextMatch() {
			interceptor.Invoke("slotNextMatch", "slotNextMatch()", typeof(void));
		}
		/// <remarks>
		///  Inserts <code>items</code> into the list of possible completions.
		///  Does the same as setItems(), but does not call clear() before.
		/// <param> name="items" the items to insert
		///      </param></remarks>		<short>    Inserts <code>items</code> into the list of possible completions.</short>
		[Q_SLOT("void insertItems(QStringList)")]
		public void InsertItems(List<string> items) {
			interceptor.Invoke("insertItems?", "insertItems(const QStringList&)", typeof(void), typeof(List<string>), items);
		}
		/// <remarks>
		///  Sets the list of items available for completion. Removes all previous
		///  items.
		///  Notice: when order() == Weighted, then the weighting is looked up for
		///  every item in the stringlist. Every item should have ":number" appended,
		///  where number is an unsigned integer, specifying the weighting.
		///  If you don't like this, call
		///  setOrder( KCompletion.Insertion )
		///  before calling setItems().
		/// <param> name="list" the list of items that are available for completion
		/// </param></remarks>		<short>    Sets the list of items available for completion.</short>
		/// 		<see> items</see>
		[Q_SLOT("void setItems(QStringList)")]
		[SmokeMethod("setItems(const QStringList&)")]
		public virtual void SetItems(List<string> list) {
			interceptor.Invoke("setItems?", "setItems(const QStringList&)", typeof(void), typeof(List<string>), list);
		}
		/// <remarks>
		///  Adds an item to the list of available completions.
		///  Resets the current item-state ( previousMatch() and nextMatch()
		///  won't work anymore).
		/// <param> name="item" the item to add
		///      </param></remarks>		<short>    Adds an item to the list of available completions.</short>
		[Q_SLOT("void addItem(QString)")]
		public void AddItem(string item) {
			interceptor.Invoke("addItem$", "addItem(const QString&)", typeof(void), typeof(string), item);
		}
		/// <remarks>
		///  Adds an item to the list of available completions.
		///  Resets the current item-state ( previousMatch() and nextMatch()
		///  won't work anymore).
		///  Sets the weighting of the item to <code>weight</code> or adds it to the current
		///  weighting if the item is already available. The weight has to be greater
		///  than 1 to take effect (default weight is 1).
		/// <param> name="item" the item to add
		/// </param><param> name="weight" the weight of the item, default is 1
		///      </param></remarks>		<short>    Adds an item to the list of available completions.</short>
		[Q_SLOT("void addItem(QString, uint)")]
		public void AddItem(string item, uint weight) {
			interceptor.Invoke("addItem$$", "addItem(const QString&, uint)", typeof(void), typeof(string), item, typeof(uint), weight);
		}
		/// <remarks>
		///  Removes an item from the list of available completions.
		///  Resets the current item-state ( previousMatch() and nextMatch()
		///  won't work anymore).
		/// <param> name="item" the item to remove
		///      </param></remarks>		<short>    Removes an item from the list of available completions.</short>
		[Q_SLOT("void removeItem(QString)")]
		public void RemoveItem(string item) {
			interceptor.Invoke("removeItem$", "removeItem(const QString&)", typeof(void), typeof(string), item);
		}
		/// <remarks>
		///  Removes all inserted items.
		///      </remarks>		<short>    Removes all inserted items.</short>
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		/// <remarks>
		///  This method is called after a completion is found and before the
		///  matching string is emitted. You can override this method to modify the
		///  string that will be emitted.
		///  This is necessary e.g. in KUrlCompletion(), where files with spaces
		///  in their names are shown escaped ("filename\ with\ spaces"), but stored
		///  unescaped inside KCompletion.
		///  Never delete that pointer!
		///  Default implementation does nothing.
		/// <param> name="pMatch" the match to process
		/// </param></remarks>		<short>    This method is called after a completion is found and before the  matching string is emitted.</short>
		/// 		<see> postProcessMatches</see>
		[SmokeMethod("postProcessMatch(QString*) const")]
		protected virtual void PostProcessMatch(StringBuilder pMatch) {
			interceptor.Invoke("postProcessMatch$", "postProcessMatch(QString*) const", typeof(void), typeof(StringBuilder), pMatch);
		}
		/// <remarks>
		///  This method is called before a list of all available completions is
		///  emitted via #matches. You can override this method to modify the
		///  found items before match() or #matches are emitted.
		///  Never delete that pointer!
		///  Default implementation does nothing.
		/// <param> name="pMatches" the matches to process
		/// </param></remarks>		<short>    This method is called before a list of all available completions is  emitted via #matches.</short>
		/// 		<see> postProcessMatch</see>
		[SmokeMethod("postProcessMatches(QStringList*) const")]
		protected virtual void PostProcessMatches(List<string> pMatches) {
			interceptor.Invoke("postProcessMatches?", "postProcessMatches(QStringList*) const", typeof(void), typeof(List<string>), pMatches);
		}
		~KCompletion() {
			interceptor.Invoke("~KCompletion", "~KCompletion()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KCompletion", "~KCompletion()", typeof(void));
		}
		protected new IKCompletionSignals Emit {
			get { return (IKCompletionSignals) Q_EMIT; }
		}
	}

	public interface IKCompletionSignals : IQObjectSignals {
		/// <remarks>
		///  The matching item. Will be emitted by makeCompletion(),
		///  previousMatch() or nextMatch(). May be string() if there
		///  is no matching item.
		/// <param> name="item" the match, or string() if there is none
		///      </param></remarks>		<short>    The matching item.</short>
		[Q_SIGNAL("void match(QString)")]
		void Match(string item);
		/// <remarks>
		///  All matching items. Will be emitted by makeCompletion() in shell-
		///  completion-mode, when the same string is passed to makeCompletion twice
		///  or more often.
		/// <param> name="matchlist" the list of matches
		///      </param></remarks>		<short>    All matching items.</short>
		[Q_SIGNAL("void matches(QStringList)")]
		void Matches(List<string> matchlist);
		/// <remarks>
		///  This signal is emitted, when calling makeCompletion() and more than
		///  one matching item is found.
		/// </remarks>		<short>    This signal is emitted, when calling makeCompletion() and more than  one matching item is found.</short>
		/// 		<see> hasMultipleMatches</see>
		[Q_SIGNAL("void multipleMatches()")]
		void MultipleMatches();
	}
}
