//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Collections.Generic;

    public interface IKCompletionBase {
        KCompletion CompletionObject(bool hsig);
        KCompletion CompletionObject();
        void SetCompletionObject(KCompletion compObj, bool hsig);
        void SetCompletionObject(KCompletion compObj);
        void SetHandleSignals(bool handle);
        bool IsCompletionObjectAutoDeleted();
        void SetAutoDeleteCompletionObject(bool autoDelete);
        void SetEnableSignals(bool enable);
        bool HandleSignals();
        bool EmitSignals();
        void SetCompletionMode(KGlobalSettings.Completion mode);
        KGlobalSettings.Completion CompletionMode();
        bool SetKeyBinding(KCompletionBase.KeyBindingType item, KShortcut key);
        KShortcut GetKeyBinding(KCompletionBase.KeyBindingType item);
        void UseGlobalKeyBindings();
        void SetCompletedText(string text);
        void SetCompletedItems(List<string> items, bool autoSuggest);
        KCompletion CompObj();
    }
    /// <remarks>
    ///  An abstract base class for adding a completion feature
    ///  into widgets.
    ///  This is a convenience class that provides the basic functions
    ///  needed to add text completion support into widgets.  All that
    ///  is required is an implementation for the pure function
    ///  setCompletedText.  Refer to KLineEdit or KComboBox
    ///  to see how easily such support can be added using this as a base
    ///  class.
    /// </remarks>        <author> Dawit Alemayehu <adawit@kde.org>
    ///  </author>
    ///         <short> An abstract class for adding text completion support to widgets. </short>
    [SmokeClass("KCompletionBase")]
    public abstract class KCompletionBase : Object, IKCompletionBase {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KCompletionBase(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KCompletionBase), this);
        }
        /// <remarks>
        ///  Constants that represent the items whose short-cut
        ///  key-binding is programmable.  The default key-bindings
        ///  for these items are defined in KStandardShortcut.
        ///      </remarks>        <short>    Constants that represent the items whose short-cut  key-binding is programmable.</short>
        public enum KeyBindingType {
            TextCompletion = 0,
            PrevCompletionMatch = 1,
            NextCompletionMatch = 2,
            SubstringCompletion = 3,
        }
        // QMap<KCompletionBase::KeyBindingType, KShortcut> getKeyBindings(); >>>> NOT CONVERTED
        /// <remarks>
        ///  Default constructor.
        ///      </remarks>        <short>    Default constructor.</short>
        public KCompletionBase() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KCompletionBase", "KCompletionBase()", typeof(void));
        }
        /// <remarks>
        ///  Returns a pointer to the current completion object.
        ///  If the completion object does not exist, it is automatically created and
        ///  by default handles all the completion signals internally unless <code>hsig</code>
        ///  is set to false. It is also automatically destroyed when the destructor
        ///  is called. You can change this default behavior using the
        ///  <see cref="#setAutoDeleteCompletionObject"></see> and <see cref="#setHandleSignals"></see> member
        ///  functions.
        ///  See also <see cref="#compObj"></see>.
        /// <param> name="hsig" if true, handles completion signals internally.
        /// </param></remarks>        <return> a pointer the completion object.
        ///      </return>
        ///         <short>    Returns a pointer to the current completion object.</short>
        public KCompletion CompletionObject(bool hsig) {
            return (KCompletion) interceptor.Invoke("completionObject$", "completionObject(bool)", typeof(KCompletion), typeof(bool), hsig);
        }
        public KCompletion CompletionObject() {
            return (KCompletion) interceptor.Invoke("completionObject", "completionObject()", typeof(KCompletion));
        }
        /// <remarks>
        ///  Sets up the completion object to be used.
        ///  This method assigns the completion object and sets it up to automatically
        ///  handle the completion and rotation signals internally.  You should use
        ///  this function if you want to share one completion object among your
        ///  widgets or need to use a customized completion object.
        ///  The object assigned through this method is not deleted when this object's
        ///  destructor is invoked unless you explicitly call <see cref="#setAutoDeleteCompletionObject"></see>
        ///  after calling this method. Be sure to set the bool argument to false, if
        ///  you want to handle the completion signals yourself.
        /// <param> name="compObj" a KCompletion() or a derived child object.
        /// </param><param> name="hsig" if true, handles completion signals internally.
        ///      </param></remarks>        <short>    Sets up the completion object to be used.</short>
        [SmokeMethod("setCompletionObject(KCompletion*, bool)")]
        public virtual void SetCompletionObject(KCompletion compObj, bool hsig) {
            interceptor.Invoke("setCompletionObject#$", "setCompletionObject(KCompletion*, bool)", typeof(void), typeof(KCompletion), compObj, typeof(bool), hsig);
        }
        [SmokeMethod("setCompletionObject(KCompletion*)")]
        public virtual void SetCompletionObject(KCompletion compObj) {
            interceptor.Invoke("setCompletionObject#", "setCompletionObject(KCompletion*)", typeof(void), typeof(KCompletion), compObj);
        }
        /// <remarks>
        ///  Enables this object to handle completion and rotation
        ///  events internally.
        ///  This function simply assigns a boolean value that
        ///  indicates whether it should handle rotation and
        ///  completion events or not.  Note that this does not
        ///  stop the object from emitting signals when these
        ///  events occur.
        /// <param> name="handle" if true, handle completion & rotation internally.
        ///      </param></remarks>        <short>    Enables this object to handle completion and rotation  events internally.</short>
        [SmokeMethod("setHandleSignals(bool)")]
        public virtual void SetHandleSignals(bool handle) {
            interceptor.Invoke("setHandleSignals$", "setHandleSignals(bool)", typeof(void), typeof(bool), handle);
        }
        /// <remarks>
        ///  Returns true if the completion object is deleted
        ///  upon this widget's destruction.
        ///  See setCompletionObject() and enableCompletion()
        ///  for details.
        /// </remarks>        <return> true if the completion object will be deleted
        ///               automatically
        ///      </return>
        ///         <short>    Returns true if the completion object is deleted  upon this widget's destruction.</short>
        public bool IsCompletionObjectAutoDeleted() {
            return (bool) interceptor.Invoke("isCompletionObjectAutoDeleted", "isCompletionObjectAutoDeleted() const", typeof(bool));
        }
        /// <remarks>
        ///  Sets the completion object when this widget's destructor
        ///  is called.
        ///  If the argument is set to true, the completion object
        ///  is deleted when this widget's destructor is called.
        /// <param> name="autoDelete" if true, delete completion object on destruction.
        ///      </param></remarks>        <short>    Sets the completion object when this widget's destructor  is called.</short>
        public void SetAutoDeleteCompletionObject(bool autoDelete) {
            interceptor.Invoke("setAutoDeleteCompletionObject$", "setAutoDeleteCompletionObject(bool)", typeof(void), typeof(bool), autoDelete);
        }
        /// <remarks>
        ///  Sets the widget's ability to emit text completion and
        ///  rotation signals.
        ///  Invoking this function with <code>enable</code> set to <code>false</code> will
        ///  cause the completion & rotation signals not to be emitted.
        ///  However, unlike setting the completion object to <code>NULL</code>
        ///  using setCompletionObject, disabling the emition of
        ///  the signals through this method does not affect the current
        ///  completion object.
        ///  There is no need to invoke this function by default.  When a
        ///  completion object is created through completionObject or
        ///  setCompletionObject, these signals are set to emit
        ///  automatically.  Also note that disabling this signals will not
        ///  necessarily interfere with the objects ability to handle these
        ///  events internally.  See setHandleSignals.
        /// <param> name="enable" if false, disables the emition of completion & rotation signals.
        ///      </param></remarks>        <short>    Sets the widget's ability to emit text completion and  rotation signals.</short>
        public void SetEnableSignals(bool enable) {
            interceptor.Invoke("setEnableSignals$", "setEnableSignals(bool)", typeof(void), typeof(bool), enable);
        }
        /// <remarks>
        ///  Returns true if the object handles the signals.
        /// </remarks>        <return> true if this signals are handled internally.
        ///      </return>
        ///         <short>    Returns true if the object handles the signals.</short>
        public bool HandleSignals() {
            return (bool) interceptor.Invoke("handleSignals", "handleSignals() const", typeof(bool));
        }
        /// <remarks>
        ///  Returns true if the object emits the signals.
        /// </remarks>        <return> true if signals are emitted
        ///      </return>
        ///         <short>    Returns true if the object emits the signals.</short>
        public bool EmitSignals() {
            return (bool) interceptor.Invoke("emitSignals", "emitSignals() const", typeof(bool));
        }
        /// <remarks>
        ///  Sets the type of completion to be used.
        ///  The completion modes supported are those defined in
        ///  KGlobalSettings().  See below.
        /// <param> name="mode" Completion type:
        /// </param>
        /// <li>
        /// CompletionNone:  Disables completion feature.
        /// </li>
        /// 
        /// <li>
        /// CompletionAuto:  Attempts to find a match &
        ///                         fills-in the remaining text.
        /// </li>
        /// 
        /// <li>
        /// CompletionMan:   Acts the same as the above
        ///                         except the action has to be
        ///                         manually triggered through
        ///                         pre-defined completion key.
        /// </li>
        /// 
        /// <li>
        /// CompletionShell: Mimics the completion feature
        ///                         found in typical nix shell
        ///                         environments.
        /// </li>
        /// 
        /// <li>
        /// CompletionPopup: Shows all available completions at once,
        ///                         in a listbox popping up.
        ///      
        /// </li></remarks>        <short>    Sets the type of completion to be used.</short>
        [SmokeMethod("setCompletionMode(KGlobalSettings::Completion)")]
        public virtual void SetCompletionMode(KGlobalSettings.Completion mode) {
            interceptor.Invoke("setCompletionMode$", "setCompletionMode(KGlobalSettings::Completion)", typeof(void), typeof(KGlobalSettings.Completion), mode);
        }
        /// <remarks>
        ///  Returns the current completion mode.
        ///  The return values are of type KGlobalSettings.Completion.
        ///  See setCompletionMode() for details.
        /// </remarks>        <return> the completion mode.
        ///      </return>
        ///         <short>    Returns the current completion mode.</short>
        public KGlobalSettings.Completion CompletionMode() {
            return (KGlobalSettings.Completion) interceptor.Invoke("completionMode", "completionMode() const", typeof(KGlobalSettings.Completion));
        }
        /// <remarks>
        ///  Sets the key-binding to be used for manual text
        ///  completion, text rotation in a history list as
        ///  well as a completion list.
        ///  When the keys set by this function are pressed, a
        ///  signal defined by the inheriting widget will be activated.
        ///  If the default value or 0 is specified by the second
        ///  parameter, then the key-binding as defined in the global
        ///  setting should be used.  This method returns false value
        ///  for <code>key</code> is negative or the supplied key-binding conflicts
        ///  with the ones set for one of the other features.
        ///  NOTE: To use a modifier key (Shift, Ctrl, Alt) as part of
        ///  the key-binding simply simply <code>sum</code> up the values of the
        ///  modifier and the actual key.  For example, to use CTRL+E as
        ///  a key binding for one of the items, you would simply supply
        ///  <code></code>"Qt.CtrlButton + Qt.Key_E" as the second argument to this
        ///  function.
        /// <param> name="item" the feature whose key-binding needs to be set:
        /// </param>
        /// <li>
        /// TextCompletion the manual completion key-binding.
        /// </li>
        /// 
        /// <li>
        /// PrevCompletionMatch    the previous match key for multiple completion.
        /// </li>
        /// 
        /// <li>
        /// NextCompletionMatch    the next match key for for multiple completion.
        /// </li>
        /// 
        /// <li>
        /// SubstringCompletion  the key for substring completion
        /// </li>
        /// <param> name="key" key-binding used to rotate down in a list.
        /// </param></remarks>        <return> true if key-binding can successfully be set.
        /// </return>
        ///         <short>    Sets the key-binding to be used for manual text  completion, text rotation in a history list as  well as a completion list.</short>
        ///         <see> getKeyBinding</see>
        public bool SetKeyBinding(KCompletionBase.KeyBindingType item, KShortcut key) {
            return (bool) interceptor.Invoke("setKeyBinding$#", "setKeyBinding(KCompletionBase::KeyBindingType, const KShortcut&)", typeof(bool), typeof(KCompletionBase.KeyBindingType), item, typeof(KShortcut), key);
        }
        /// <remarks>
        ///  Returns the key-binding used for the specified item.
        ///  This methods returns the key-binding used to activate
        ///  the feature feature given by <code>item.</code>  If the binding
        ///  contains modifier key(s), the SUM of the modifier key
        ///  and the actual key code are returned.
        /// <param> name="item" the item to check
        /// </param></remarks>        <return> the key-binding used for the feature given by <code>item.</code>
        /// </return>
        ///         <short>    Returns the key-binding used for the specified item.</short>
        ///         <see> setKeyBinding</see>
        public KShortcut GetKeyBinding(KCompletionBase.KeyBindingType item) {
            return (KShortcut) interceptor.Invoke("getKeyBinding$", "getKeyBinding(KCompletionBase::KeyBindingType) const", typeof(KShortcut), typeof(KCompletionBase.KeyBindingType), item);
        }
        /// <remarks>
        ///  Sets this object to use global values for key-bindings.
        ///  This method changes the values of the key bindings for
        ///  rotation and completion features to the default values
        ///  provided in KGlobalSettings.
        ///  NOTE: By default inheriting widgets should uses the
        ///  global key-bindings so that there will be no need to
        ///  call this method.
        ///      </remarks>        <short>    Sets this object to use global values for key-bindings.</short>
        public void UseGlobalKeyBindings() {
            interceptor.Invoke("useGlobalKeyBindings", "useGlobalKeyBindings()", typeof(void));
        }
        /// <remarks>
        ///  A pure function that must be implemented by
        ///  all inheriting classes.
        ///  This function is intended to allow external completion
        ///  implementations to set completed text appropriately.  It
        ///  is mostly relevant when the completion mode is set to
        ///  CompletionAuto and CompletionManual modes. See
        ///  KCompletionBase.SetCompletedText.
        ///  Does nothing in CompletionPopup mode, as all available
        ///  matches will be shown in the popup.
        /// <param> name="text" the completed text to be set in the widget.
        ///      </param></remarks>        <short>    A pure virtual function that must be implemented by  all inheriting classes.</short>
        [SmokeMethod("setCompletedText(const QString&)")]
        public abstract void SetCompletedText(string text);
        /// <remarks>
        ///  A pure function that must be implemented by
        ///  all inheriting classes.
        /// <param> name="items" the list of completed items
        /// </param><param> name="autoSuggest" if <code>true</code>, the first element of <code>items</code>
        ///         is auto-completed (i.e. pre-selected).
        ///      </param></remarks>        <short>    A pure virtual function that must be implemented by  all inheriting classes.</short>
        [SmokeMethod("setCompletedItems(const QStringList&, bool)")]
        public abstract void SetCompletedItems(List<string> items, bool autoSuggest);
        /// <remarks>
        ///  Returns a pointer to the completion object.
        ///  This method is only different from completionObject()
        ///  in that it does not create a new KCompletion object even if
        ///  the internal pointer is <code>NULL.</code> Use this method to get the
        ///  pointer to a completion object when inheriting so that you
        ///  won't inadvertently create it!!
        /// </remarks>        <return> the completion object or @c NULL if one does not exist.
        ///      </return>
        ///         <short>    Returns a pointer to the completion object.</short>
        public KCompletion CompObj() {
            return (KCompletion) interceptor.Invoke("compObj", "compObj() const", typeof(KCompletion));
        }
        /// <remarks>
        ///  Returns a key-binding map.
        ///  This method is the same as getKeyBinding() except it
        ///  returns the whole keymap containing the key-bindings.
        /// </remarks>        <return> the key-binding used for the feature given by <code>item.</code>
        ///      </return>
        ///         <short>    Returns a key-binding map.</short>
        /// <remarks>
        ///  Sets or removes the delegation object. If a delegation object is
        ///  set, all function calls will be forwarded to the delegation object.
        /// <param> name="delegate" the delegation object, or 0 to remove it
        ///      </param></remarks>        <short>    Sets or removes the delegation object.</short>
        protected void SetDelegate(IKCompletionBase arg1) {
            interceptor.Invoke("setDelegate#", "setDelegate(KCompletionBase*)", typeof(void), typeof(IKCompletionBase), arg1);
        }
        /// <remarks>
        ///  Returns the delegation object.
        /// </remarks>        <return> the delegation object, or 0 if there is none
        /// </return>
        ///         <short>    Returns the delegation object.</short>
        ///         <see> setDelegate</see>
        protected IKCompletionBase Delegate() {
            return (IKCompletionBase) interceptor.Invoke("delegate", "delegate() const", typeof(IKCompletionBase));
        }
    }
}