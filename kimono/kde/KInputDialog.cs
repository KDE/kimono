//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Runtime.InteropServices;
	using System.Collections.Generic;
	/// <remarks>
	///  The KInputDialog namespace provides simple dialogs to get a single value
	///  from the user. The value can be a string, a number (either an integer or
	///  a float) or an item from a list.
	/// </remarks>		<author> Nadeem Hasan <nhasan@kde.org>
	///  </author>
	/// 		<short>    The KInputDialog namespace provides simple dialogs to get a single value  from the user.</short>
	[SmokeClass("KInputDialog")]
	public class KInputDialog {
		private static SmokeInvocation staticInterceptor = null;
		static KInputDialog() {
			staticInterceptor = new SmokeInvocation(typeof(KInputDialog), null);
		}
		/// <remarks>
		///  Static convenience function to get a string from the user.
		///  caption is the text that is displayed in the title bar. label is the
		///  text that appears as a label for the line edit. value is the initial
		///  value of the line edit. ok will be set to true if user pressed Ok
		///  and false if user pressed Cancel.
		///  If you provide a validator, the Ok button is disabled as long as
		///  the validator doesn't return Acceptable. If there is no validator,
		///  the Ok button is enabled whenever the line edit isn't empty. If you
		///  want to accept empty input, create a trivial QValidator that
		///  always returns acceptable, e.g. QRegExpValidator with a regexp
		///  of ".*".
		/// <param> name="caption" Caption of the dialog
		/// </param><param> name="label" Text of the label for the line edit
		/// </param><param> name="value" Initial value of the line edit
		/// </param><param> name="ok" This bool would be set to true if user pressed Ok
		/// </param><param> name="parent" Parent of the dialog widget
		/// </param><param> name="validator" A <see cref="QValidator"></see> to be associated with the line edit
		/// </param><param> name="mask" Mask associated with the line edit. See the
		///                   documentation for <see cref="QLineEdit"></see> about masks
		/// </param><param> name="whatsThis" a QWhatsThis text for the input widget.
		/// </param><param> name="completionList" a list of items which should be used for input completion
		/// </param></remarks>		<return> String user entered if Ok was pressed, else a null string
		///      </return>
		/// 		<short>    Static convenience function to get a string from the user.</short>
		public static string GetText(string caption, string label, string value, ref bool ok, QWidget parent, QValidator validator, string mask, string whatsThis, List<string> completionList) {
			StackItem[] stack = new StackItem[10];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
#if DEBUG
			stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[5].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
			stack[6].s_class = (IntPtr) DebugGCHandle.Alloc(validator);
#else
			stack[6].s_class = (IntPtr) GCHandle.Alloc(validator);
#endif
#if DEBUG
			stack[7].s_class = (IntPtr) DebugGCHandle.Alloc(mask);
#else
			stack[7].s_class = (IntPtr) GCHandle.Alloc(mask);
#endif
#if DEBUG
			stack[8].s_class = (IntPtr) DebugGCHandle.Alloc(whatsThis);
#else
			stack[8].s_class = (IntPtr) GCHandle.Alloc(whatsThis);
#endif
#if DEBUG
			stack[9].s_class = (IntPtr) DebugGCHandle.Alloc(completionList);
#else
			stack[9].s_class = (IntPtr) GCHandle.Alloc(completionList);
#endif
			staticInterceptor.Invoke("getText$$$$##$$?", "getText(const QString&, const QString&, const QString&, bool*, QWidget*, QValidator*, const QString&, const QString&, const QStringList&)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
			((GCHandle) stack[5].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[6].s_class);
#else
			((GCHandle) stack[6].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[7].s_class);
#else
			((GCHandle) stack[7].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[8].s_class);
#else
			((GCHandle) stack[8].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[9].s_class);
#else
			((GCHandle) stack[9].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetText(string caption, string label, string value, ref bool ok, QWidget parent, QValidator validator, string mask, string whatsThis) {
			StackItem[] stack = new StackItem[9];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
#if DEBUG
			stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[5].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
			stack[6].s_class = (IntPtr) DebugGCHandle.Alloc(validator);
#else
			stack[6].s_class = (IntPtr) GCHandle.Alloc(validator);
#endif
#if DEBUG
			stack[7].s_class = (IntPtr) DebugGCHandle.Alloc(mask);
#else
			stack[7].s_class = (IntPtr) GCHandle.Alloc(mask);
#endif
#if DEBUG
			stack[8].s_class = (IntPtr) DebugGCHandle.Alloc(whatsThis);
#else
			stack[8].s_class = (IntPtr) GCHandle.Alloc(whatsThis);
#endif
			staticInterceptor.Invoke("getText$$$$##$$", "getText(const QString&, const QString&, const QString&, bool*, QWidget*, QValidator*, const QString&, const QString&)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
			((GCHandle) stack[5].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[6].s_class);
#else
			((GCHandle) stack[6].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[7].s_class);
#else
			((GCHandle) stack[7].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[8].s_class);
#else
			((GCHandle) stack[8].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetText(string caption, string label, string value, ref bool ok, QWidget parent, QValidator validator, string mask) {
			StackItem[] stack = new StackItem[8];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
#if DEBUG
			stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[5].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
			stack[6].s_class = (IntPtr) DebugGCHandle.Alloc(validator);
#else
			stack[6].s_class = (IntPtr) GCHandle.Alloc(validator);
#endif
#if DEBUG
			stack[7].s_class = (IntPtr) DebugGCHandle.Alloc(mask);
#else
			stack[7].s_class = (IntPtr) GCHandle.Alloc(mask);
#endif
			staticInterceptor.Invoke("getText$$$$##$", "getText(const QString&, const QString&, const QString&, bool*, QWidget*, QValidator*, const QString&)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
			((GCHandle) stack[5].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[6].s_class);
#else
			((GCHandle) stack[6].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[7].s_class);
#else
			((GCHandle) stack[7].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetText(string caption, string label, string value, ref bool ok, QWidget parent, QValidator validator) {
			StackItem[] stack = new StackItem[7];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
#if DEBUG
			stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[5].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
#if DEBUG
			stack[6].s_class = (IntPtr) DebugGCHandle.Alloc(validator);
#else
			stack[6].s_class = (IntPtr) GCHandle.Alloc(validator);
#endif
			staticInterceptor.Invoke("getText$$$$##", "getText(const QString&, const QString&, const QString&, bool*, QWidget*, QValidator*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
			((GCHandle) stack[5].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[6].s_class);
#else
			((GCHandle) stack[6].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetText(string caption, string label, string value, ref bool ok, QWidget parent) {
			StackItem[] stack = new StackItem[6];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
#if DEBUG
			stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[5].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
			staticInterceptor.Invoke("getText$$$$#", "getText(const QString&, const QString&, const QString&, bool*, QWidget*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
			((GCHandle) stack[5].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetText(string caption, string label, string value, ref bool ok) {
			StackItem[] stack = new StackItem[5];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
			staticInterceptor.Invoke("getText$$$$", "getText(const QString&, const QString&, const QString&, bool*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetText(string caption, string label, string value) {
			return (string) staticInterceptor.Invoke("getText$$$", "getText(const QString&, const QString&, const QString&)", typeof(string), typeof(string), caption, typeof(string), label, typeof(string), value);
		}
		public static string GetText(string caption, string label) {
			return (string) staticInterceptor.Invoke("getText$$", "getText(const QString&, const QString&)", typeof(string), typeof(string), caption, typeof(string), label);
		}
		/// <remarks>
		///  Static convenience function to get a multiline string from the user.
		///  caption is the text that is displayed in the title bar. label is the
		///  text that appears as a label for the line edit. value is the initial
		///  value of the line edit. ok will be set to true if user pressed Ok
		///  and false if user pressed Cancel.
		/// <param> name="caption" Caption of the dialog
		/// </param><param> name="label" Text of the label for the line edit
		/// </param><param> name="value" Initial value of the line edit
		/// </param><param> name="ok" This bool would be set to true if user pressed Ok
		/// </param><param> name="parent" Parent of the dialog widget
		/// </param></remarks>		<return> String user entered if Ok was pressed, else a null string
		///      </return>
		/// 		<short>    Static convenience function to get a multiline string from the user.</short>
		public static string GetMultiLineText(string caption, string label, string value, ref bool ok, QWidget parent) {
			StackItem[] stack = new StackItem[6];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
#if DEBUG
			stack[5].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[5].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
			staticInterceptor.Invoke("getMultiLineText$$$$#", "getMultiLineText(const QString&, const QString&, const QString&, bool*, QWidget*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[5].s_class);
#else
			((GCHandle) stack[5].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetMultiLineText(string caption, string label, string value, ref bool ok) {
			StackItem[] stack = new StackItem[5];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(value);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(value);
#endif
			stack[4].s_bool = ok;
			staticInterceptor.Invoke("getMultiLineText$$$$", "getMultiLineText(const QString&, const QString&, const QString&, bool*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[4].s_bool;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetMultiLineText(string caption, string label, string value) {
			return (string) staticInterceptor.Invoke("getMultiLineText$$$", "getMultiLineText(const QString&, const QString&, const QString&)", typeof(string), typeof(string), caption, typeof(string), label, typeof(string), value);
		}
		public static string GetMultiLineText(string caption, string label) {
			return (string) staticInterceptor.Invoke("getMultiLineText$$", "getMultiLineText(const QString&, const QString&)", typeof(string), typeof(string), caption, typeof(string), label);
		}
		/// <remarks>
		///  Static convenience function to let the user select an item from a
		///  list. caption is the text that is displayed in the title bar.
		///  label is the text that appears as the label for the list. list
		///  is the string list which is inserted into the list, and current
		///  is the number of the item which should be the selected item. If
		///  editable is true, the user can enter his own text.
		/// <param> name="caption" Caption of the dialog
		/// </param><param> name="label" Text of the label for the list
		/// </param><param> name="list" List of item for user to choose from
		/// </param><param> name="current" Index of the selected item
		/// </param><param> name="editable" If true, user can enter own text
		/// </param><param> name="ok" This bool would be set to true if user pressed Ok
		/// </param><param> name="parent" Parent of the dialog widget
		/// </param></remarks>		<return> Text of the selected item. If <code>editable</code> is true this can be
		///          a text entered by the user.
		///      </return>
		/// 		<short>    Static convenience function to let the user select an item from a  list.</short>
		public static string GetItem(string caption, string label, List<string> list, int current, bool editable, ref bool ok, QWidget parent) {
			StackItem[] stack = new StackItem[8];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(list);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(list);
#endif
			stack[4].s_int = current;
			stack[5].s_bool = editable;
			stack[6].s_bool = ok;
#if DEBUG
			stack[7].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[7].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
			staticInterceptor.Invoke("getItem$$?$$$#", "getItem(const QString&, const QString&, const QStringList&, int, bool, bool*, QWidget*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[6].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[7].s_class);
#else
			((GCHandle) stack[7].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetItem(string caption, string label, List<string> list, int current, bool editable, ref bool ok) {
			StackItem[] stack = new StackItem[7];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(list);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(list);
#endif
			stack[4].s_int = current;
			stack[5].s_bool = editable;
			stack[6].s_bool = ok;
			staticInterceptor.Invoke("getItem$$?$$$", "getItem(const QString&, const QString&, const QStringList&, int, bool, bool*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
			ok = stack[6].s_bool;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		public static string GetItem(string caption, string label, List<string> list, int current, bool editable) {
			return (string) staticInterceptor.Invoke("getItem$$?$$", "getItem(const QString&, const QString&, const QStringList&, int, bool)", typeof(string), typeof(string), caption, typeof(string), label, typeof(List<string>), list, typeof(int), current, typeof(bool), editable);
		}
		public static string GetItem(string caption, string label, List<string> list, int current) {
			return (string) staticInterceptor.Invoke("getItem$$?$", "getItem(const QString&, const QString&, const QStringList&, int)", typeof(string), typeof(string), caption, typeof(string), label, typeof(List<string>), list, typeof(int), current);
		}
		public static string GetItem(string caption, string label, List<string> list) {
			return (string) staticInterceptor.Invoke("getItem$$?", "getItem(const QString&, const QString&, const QStringList&)", typeof(string), typeof(string), caption, typeof(string), label, typeof(List<string>), list);
		}
		/// <remarks>
		///  Static convenience function to let the user select one or more
		///  items from a listbox. caption is the text that is displayed in the
		///  title bar. label is the text that appears as the label for the listbox.
		///  list is the string list which is inserted into the listbox, select
		///  is the list of item(s) that should be the selected. If multiple is
		///  true, the user can select multiple items.
		/// <param> name="caption" Caption of the dialog
		/// </param><param> name="label" Text of the label for the list
		/// </param><param> name="list" List of item for user to choose from
		/// </param><param> name="select" List of item(s) that should be selected
		/// </param><param> name="multiple" If true, user can select multiple items
		/// </param><param> name="ok" This bool would be set to true if user pressed Ok
		/// </param><param> name="parent" Parent of the dialog widget
		/// </param></remarks>		<return> List of selected items if multiple is true, else currently
		///          selected item as a List<string>
		///      </return>
		/// 		<short>    Static convenience function to let the user select one or more  items from a listbox.</short>
		public static List<string> GetItemList(string caption, string label, List<string> list, List<string> select, bool multiple, ref bool ok, QWidget parent) {
			StackItem[] stack = new StackItem[8];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(list);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(list);
#endif
#if DEBUG
			stack[4].s_class = (IntPtr) DebugGCHandle.Alloc(select);
#else
			stack[4].s_class = (IntPtr) GCHandle.Alloc(select);
#endif
			stack[5].s_bool = multiple;
			stack[6].s_bool = ok;
#if DEBUG
			stack[7].s_class = (IntPtr) DebugGCHandle.Alloc(parent);
#else
			stack[7].s_class = (IntPtr) GCHandle.Alloc(parent);
#endif
			staticInterceptor.Invoke("getItemList$$??$$#", "getItemList(const QString&, const QString&, const QStringList&, const QStringList&, bool, bool*, QWidget*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[4].s_class);
#else
			((GCHandle) stack[4].s_class).Free();
#endif
			ok = stack[6].s_bool;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[7].s_class);
#else
			((GCHandle) stack[7].s_class).Free();
#endif
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (List<string>) returnValue;
		}
		public static List<string> GetItemList(string caption, string label, List<string> list, List<string> select, bool multiple, ref bool ok) {
			StackItem[] stack = new StackItem[7];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(caption);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(caption);
#endif
#if DEBUG
			stack[2].s_class = (IntPtr) DebugGCHandle.Alloc(label);
#else
			stack[2].s_class = (IntPtr) GCHandle.Alloc(label);
#endif
#if DEBUG
			stack[3].s_class = (IntPtr) DebugGCHandle.Alloc(list);
#else
			stack[3].s_class = (IntPtr) GCHandle.Alloc(list);
#endif
#if DEBUG
			stack[4].s_class = (IntPtr) DebugGCHandle.Alloc(select);
#else
			stack[4].s_class = (IntPtr) GCHandle.Alloc(select);
#endif
			stack[5].s_bool = multiple;
			stack[6].s_bool = ok;
			staticInterceptor.Invoke("getItemList$$??$$", "getItemList(const QString&, const QString&, const QStringList&, const QStringList&, bool, bool*)", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[2].s_class);
#else
			((GCHandle) stack[2].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[3].s_class);
#else
			((GCHandle) stack[3].s_class).Free();
#endif
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[4].s_class);
#else
			((GCHandle) stack[4].s_class).Free();
#endif
			ok = stack[6].s_bool;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (List<string>) returnValue;
		}
		public static List<string> GetItemList(string caption, string label, List<string> list, List<string> select, bool multiple) {
			return (List<string>) staticInterceptor.Invoke("getItemList$$??$", "getItemList(const QString&, const QString&, const QStringList&, const QStringList&, bool)", typeof(List<string>), typeof(string), caption, typeof(string), label, typeof(List<string>), list, typeof(List<string>), select, typeof(bool), multiple);
		}
		public static List<string> GetItemList(string caption, string label, List<string> list, List<string> select) {
			return (List<string>) staticInterceptor.Invoke("getItemList$$??", "getItemList(const QString&, const QString&, const QStringList&, const QStringList&)", typeof(List<string>), typeof(string), caption, typeof(string), label, typeof(List<string>), list, typeof(List<string>), select);
		}
		public static List<string> GetItemList(string caption, string label, List<string> list) {
			return (List<string>) staticInterceptor.Invoke("getItemList$$?", "getItemList(const QString&, const QString&, const QStringList&)", typeof(List<string>), typeof(string), caption, typeof(string), label, typeof(List<string>), list);
		}
		public static List<string> GetItemList(string caption, string label) {
			return (List<string>) staticInterceptor.Invoke("getItemList$$", "getItemList(const QString&, const QString&)", typeof(List<string>), typeof(string), caption, typeof(string), label);
		}
	}
}
