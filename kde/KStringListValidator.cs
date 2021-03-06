//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Collections.Generic;
    /// <remarks>
    ///  This validator allows you to accept only certain or to accept all
    ///  but certain strings.
    ///  When used in rejecting mode, accepts only strings not in the
    ///  stringlist. This mode is the default and comes in handy when asking
    ///  the user for a name of some listed entity. Set the list of already
    ///  used names to prevent the user from entering duplicate names.
    ///  When used in non-rejecting mode, accepts only strings that appear
    ///  in the stringlist. Use with care! From a user's point of view this
    ///  mode is hard to grasp.
    ///  This validator can also fix strings. In rejecting mode, a number
    ///  will be appended to the string until it is Acceptable. E.g. if
    ///  "foo" and "foo 1" are in the stringlist, then fixup will change
    ///  "foo" to "foo 2", provided "foo 2" isn't in the list of forbidden
    ///  strings.
    ///  In accepting mode, when the input starts with an Acceptable
    ///  substring, truncates to the longest Acceptable string. When the
    ///  input is the start of an Acceptable string, completes to the
    ///  shortest Acceptable string.
    ///  NOTE: fixup isn't yet implemented.
    /// </remarks>        <author> Marc Mutz <mutz@kde.org>
    /// </author>
    ///         <short> A QValidator to (dis)allow certain strings.</short>
    [SmokeClass("KStringListValidator")]
    public class KStringListValidator : QValidator, IDisposable {
        protected KStringListValidator(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KStringListValidator), this);
        }
        [Q_PROPERTY("QStringList", "stringList")]
        public List<string> StringList {
            get { return (List<string>) interceptor.Invoke("stringList", "stringList()", typeof(List<string>)); }
            set { interceptor.Invoke("setStringList?", "setStringList(QStringList)", typeof(void), typeof(List<string>), value); }
        }
        [Q_PROPERTY("bool", "rejecting")]
        public bool Rejecting {
            get { return (bool) interceptor.Invoke("isRejecting", "isRejecting()", typeof(bool)); }
            set { interceptor.Invoke("setRejecting$", "setRejecting(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("bool", "fixupEnabled")]
        public bool FixupEnabled {
            get { return (bool) interceptor.Invoke("isFixupEnabled", "isFixupEnabled()", typeof(bool)); }
            set { interceptor.Invoke("setFixupEnabled$", "setFixupEnabled(bool)", typeof(void), typeof(bool), value); }
        }
        /// <remarks>
        ///  Creates a new string validator.
        /// <param> name="list" The list of strings to (dis)allow.
        /// </param><param> name="rejecting" Selects the validator's mode
        ///                      (rejecting: true; accepting: false)
        /// </param><param> name="fixupEnabled" Selects whether to fix strings or not.
        /// </param><param> name="parent" Passed to lower level constructor.
        /// </param></remarks>        <short>    Creates a new string validator.</short>
        public KStringListValidator(List<string> list, bool rejecting, bool fixupEnabled, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KStringListValidator?$$#", "KStringListValidator(const QStringList&, bool, bool, QObject*)", typeof(void), typeof(List<string>), list, typeof(bool), rejecting, typeof(bool), fixupEnabled, typeof(QObject), parent);
        }
        public KStringListValidator(List<string> list, bool rejecting, bool fixupEnabled) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KStringListValidator?$$", "KStringListValidator(const QStringList&, bool, bool)", typeof(void), typeof(List<string>), list, typeof(bool), rejecting, typeof(bool), fixupEnabled);
        }
        public KStringListValidator(List<string> list, bool rejecting) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KStringListValidator?$", "KStringListValidator(const QStringList&, bool)", typeof(void), typeof(List<string>), list, typeof(bool), rejecting);
        }
        public KStringListValidator(List<string> list) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KStringListValidator?", "KStringListValidator(const QStringList&)", typeof(void), typeof(List<string>), list);
        }
        public KStringListValidator() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KStringListValidator", "KStringListValidator()", typeof(void));
        }
        /// <remarks>
        ///  Reimplemented from @see QValidator.
        ///      </remarks>        <short>    Reimplemented from @see QValidator.</short>
        [SmokeMethod("validate(QString&, int&) const")]
        public override QValidator.State Validate(StringBuilder input, ref int pos) {
            StackItem[] stack = new StackItem[3];
#if DEBUG
            stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(input);
#else
            stack[1].s_class = (IntPtr) GCHandle.Alloc(input);
#endif
            stack[2].s_int = pos;
            interceptor.Invoke("validate$$", "validate(QString&, int&) const", stack);
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
            ((GCHandle) stack[1].s_class).SynchronizedFree();
#endif
            pos = stack[2].s_int;
            return (QValidator.State) Enum.ToObject(typeof(QValidator.State), stack[0].s_int);
        }
        /// <remarks>
        ///  Reimplemented from @see QValidator.
        ///      </remarks>        <short>    Reimplemented from @see QValidator.</short>
        [SmokeMethod("fixup(QString&) const")]
        public override void Fixup(StringBuilder input) {
            interceptor.Invoke("fixup$", "fixup(QString&) const", typeof(void), typeof(StringBuilder), input);
        }
        ~KStringListValidator() {
            interceptor.Invoke("~KStringListValidator", "~KStringListValidator()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KStringListValidator", "~KStringListValidator()", typeof(void));
        }
        protected new IKStringListValidatorSignals Emit {
            get { return (IKStringListValidatorSignals) Q_EMIT; }
        }
    }

    public interface IKStringListValidatorSignals : IQValidatorSignals {
    }
}
