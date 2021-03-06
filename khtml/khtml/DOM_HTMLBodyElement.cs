//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  The HTML document body. This element is always present in the DOM
	///  API, even if the tags are not present in the source document. See
	///  the <a
	///  href="http://www.w3.org/TR/REC-html40/struct/global.html#edef-BODY">
	///  BODY element definition </a> in HTML 4.0.
	///  </remarks>		<short>    The HTML document body.</short>
	[SmokeClass("DOM::HTMLBodyElement")]
	public class HTMLBodyElement : DOM.HTMLElement, IDisposable {
 		protected HTMLBodyElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLBodyElement), this);
		}
		// DOM::HTMLBodyElement* HTMLBodyElement(DOM::HTMLBodyElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLBodyElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLBodyElement", "HTMLBodyElement()", typeof(void));
		}
		public HTMLBodyElement(DOM.HTMLBodyElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLBodyElement#", "HTMLBodyElement(const DOM::HTMLBodyElement&)", typeof(void), typeof(DOM.HTMLBodyElement), other);
		}
		public HTMLBodyElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLBodyElement#", "HTMLBodyElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  Color of active links (after mouse-button down, but before
		///  mouse-button up). See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/global.html#adef-alink">
		///  alink attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Color of active links (after mouse-button down, but before  mouse-button up).</short>
		public DOM.DOMString ALink() {
			return (DOM.DOMString) interceptor.Invoke("aLink", "aLink() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see aLink
		///      </remarks>		<short>    see aLink      </short>
		public void SetALink(DOM.DOMString arg1) {
			interceptor.Invoke("setALink#", "setALink(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  URI of the background texture tile image. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/global.html#adef-background">
		///  background attribute definition </a> in HTML 4.0. This
		///  attribute is deprecated in HTML 4.0.
		///      </remarks>		<short>    URI of the background texture tile image.</short>
		public DOM.DOMString Background() {
			return (DOM.DOMString) interceptor.Invoke("background", "background() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see background
		///      </remarks>		<short>    see background      </short>
		public void SetBackground(DOM.DOMString arg1) {
			interceptor.Invoke("setBackground#", "setBackground(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Document background color. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/graphics.html#adef-bgcolor">
		///  bgcolor attribute definition </a> in HTML 4.0. This attribute
		///  is deprecated in HTML 4.0.
		///      </remarks>		<short>    Document background color.</short>
		public DOM.DOMString BgColor() {
			return (DOM.DOMString) interceptor.Invoke("bgColor", "bgColor() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see bgColor
		///      </remarks>		<short>    see bgColor      </short>
		public void SetBgColor(DOM.DOMString arg1) {
			interceptor.Invoke("setBgColor#", "setBgColor(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Color of links that are not active and unvisited. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/global.html#adef-link">
		///  link attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Color of links that are not active and unvisited.</short>
		public DOM.DOMString Link() {
			return (DOM.DOMString) interceptor.Invoke("link", "link() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see link
		///      </remarks>		<short>    see link      </short>
		public void SetLink(DOM.DOMString arg1) {
			interceptor.Invoke("setLink#", "setLink(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Document text color. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/global.html#adef-text">
		///  text attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Document text color.</short>
		public DOM.DOMString Text() {
			return (DOM.DOMString) interceptor.Invoke("text", "text() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see text
		///      </remarks>		<short>    see text      </short>
		public void SetText(DOM.DOMString arg1) {
			interceptor.Invoke("setText#", "setText(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Color of links that have been visited by the user. See the <a
		///  href="http://www.w3.org/TR/REC-html40/struct/global.html#adef-vlink">
		///  vlink attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Color of links that have been visited by the user.</short>
		public DOM.DOMString VLink() {
			return (DOM.DOMString) interceptor.Invoke("vLink", "vLink() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see vLink
		///      </remarks>		<short>    see vLink      </short>
		public void SetVLink(DOM.DOMString arg1) {
			interceptor.Invoke("setVLink#", "setVLink(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		~HTMLBodyElement() {
			interceptor.Invoke("~HTMLBodyElement", "~HTMLBodyElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLBodyElement", "~HTMLBodyElement()", typeof(void));
		}
	}
}
