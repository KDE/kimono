//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	namespace DOM {

	using System;
	using Qyoto;

	/// <remarks>
	///  The <code>THEAD</code> , <code>TFOOT</code> , and <code>TBODY</code>
	///  elements.
	///  </remarks>		<short>    The <code>THEAD</code> , <code>TFOOT</code> , and <code>TBODY</code>  elements.</short>

	[SmokeClass("DOM::HTMLTableSectionElement")]
	public class HTMLTableSectionElement : DOM.HTMLElement, IDisposable {
 		protected HTMLTableSectionElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLTableSectionElement), this);
		}
		// DOM::HTMLTableSectionElement* HTMLTableSectionElement(DOM::HTMLTableSectionElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLTableSectionElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableSectionElement", "HTMLTableSectionElement()", typeof(void));
		}
		public HTMLTableSectionElement(DOM.HTMLTableSectionElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableSectionElement#", "HTMLTableSectionElement(const DOM::HTMLTableSectionElement&)", typeof(void), typeof(DOM.HTMLTableSectionElement), other);
		}
		public HTMLTableSectionElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLTableSectionElement#", "HTMLTableSectionElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  Horizontal alignment of data in cells. See the <code>align</code>
		///  attribute for HTMLTheadElement for details.
		///      </remarks>		<short>    Horizontal alignment of data in cells.</short>
		public string Align() {
			return (string) interceptor.Invoke("align", "align() const", typeof(string));
		}
		/// <remarks>
		///  see align
		///      </remarks>		<short>    see align      </short>
		public void SetAlign(string arg1) {
			interceptor.Invoke("setAlign#", "setAlign(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Alignment character for cells in a column. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-char">
		///  char attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Alignment character for cells in a column.</short>
		public string Ch() {
			return (string) interceptor.Invoke("ch", "ch() const", typeof(string));
		}
		/// <remarks>
		///  see ch
		///      </remarks>		<short>    see ch      </short>
		public void SetCh(string arg1) {
			interceptor.Invoke("setCh#", "setCh(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Offset of alignment character. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/tables.html#adef-charoff">
		///  charoff attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    Offset of alignment character.</short>
		public string ChOff() {
			return (string) interceptor.Invoke("chOff", "chOff() const", typeof(string));
		}
		/// <remarks>
		///  see chOff
		///      </remarks>		<short>    see chOff      </short>
		public void SetChOff(string arg1) {
			interceptor.Invoke("setChOff#", "setChOff(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  Vertical alignment of data in cells. See the <code>valign</code>
		///  attribute for HTMLTheadElement for details.
		///      </remarks>		<short>    Vertical alignment of data in cells.</short>
		public string VAlign() {
			return (string) interceptor.Invoke("vAlign", "vAlign() const", typeof(string));
		}
		/// <remarks>
		///  see vAlign
		///      </remarks>		<short>    see vAlign      </short>
		public void SetVAlign(string arg1) {
			interceptor.Invoke("setVAlign#", "setVAlign(const DOM::DOMString&)", typeof(void), typeof(string), arg1);
		}
		/// <remarks>
		///  The collection of rows in this table section.
		///      </remarks>		<short>    The collection of rows in this table section.</short>
		public DOM.HTMLCollection Rows() {
			return (DOM.HTMLCollection) interceptor.Invoke("rows", "rows() const", typeof(DOM.HTMLCollection));
		}
		/// <remarks>
		///  Insert a row into this section.
		///  The new row is inserted immediately before the current indexth
		///  row in this section. If index is -1 or equal to the number of rows
		///  in this sectino, the new row is appended.
		/// <param> name="index" The row number where to insert a new row.
		/// </param>     </remarks>		<return> The newly created row.
		/// </return>
		/// 		<short>    Insert a row into this section.</short>
		public DOM.HTMLElement InsertRow(long index) {
			return (DOM.HTMLElement) interceptor.Invoke("insertRow$", "insertRow(long)", typeof(DOM.HTMLElement), typeof(long), index);
		}
		/// <remarks>
		///  Delete a row from this section.
		/// <param> name="index" The index of the row to be deleted,
		///  or -1 to delete the last row. This index starts from 0 and is relative only
		///  to the rows contained inside this section, not all the rows in the table.
		/// </param>     </remarks>		<short>    Delete a row from this section.</short>
		public void DeleteRow(long index) {
			interceptor.Invoke("deleteRow$", "deleteRow(long)", typeof(void), typeof(long), index);
		}
		~HTMLTableSectionElement() {
			interceptor.Invoke("~HTMLTableSectionElement", "~HTMLTableSectionElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLTableSectionElement", "~HTMLTableSectionElement()", typeof(void));
		}
	}
	}
}