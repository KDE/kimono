//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  The <code>StyleSheetList</code> interface provides the
	///  abstraction of an ordered collection of style sheets.
	///  </remarks>		<short>    The <code>StyleSheetList</code> interface provides the  abstraction of an ordered collection of style sheets.</short>
	[SmokeClass("DOM::StyleSheetList")]
	public class StyleSheetList : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected StyleSheetList(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(StyleSheetList), this);
		}
		// DOM::StyleSheetList* StyleSheetList(DOM::StyleSheetListImpl* arg1); >>>> NOT CONVERTED
		public StyleSheetList() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("StyleSheetList", "StyleSheetList()", typeof(void));
		}
		public StyleSheetList(DOM.StyleSheetList other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("StyleSheetList#", "StyleSheetList(const DOM::StyleSheetList&)", typeof(void), typeof(DOM.StyleSheetList), other);
		}
		/// <remarks>
		///  The number of <code>StyleSheet</code> in the list. The range
		///  of valid child stylesheet indices is <code>0</code> to
		///  <code>length-1</code> inclusive.
		///      </remarks>		<short>    The number of <code>StyleSheet</code> in the list.</short>
		public ulong Length() {
			return (ulong) interceptor.Invoke("length", "length() const", typeof(ulong));
		}
		/// <remarks>
		///  Used to retrieve a style sheet by ordinal index.
		/// <param> name="index" Index into the collection
		/// </param>     </remarks>		<return> The style sheet at the <code>index</code> position in
		///  the <code>StyleSheetList</code> , or <code>null</code> if
		///  that is not a valid index.
		/// </return>
		/// 		<short>    Used to retrieve a style sheet by ordinal index.</short>
		public DOM.StyleSheet Item(ulong index) {
			return (DOM.StyleSheet) interceptor.Invoke("item$", "item(unsigned long)", typeof(DOM.StyleSheet), typeof(ulong), index);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		~StyleSheetList() {
			interceptor.Invoke("~StyleSheetList", "~StyleSheetList()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~StyleSheetList", "~StyleSheetList()", typeof(void));
		}
	}
}
