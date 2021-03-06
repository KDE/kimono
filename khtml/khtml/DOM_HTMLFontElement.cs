//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  Local change to font. See the <a
	///  href="http://www.w3.org/TR/REC-html40/present/graphics.html#edef-FONT">
	///  FONT element definition </a> in HTML 4.0. This element is
	///  deprecated in HTML 4.0.
	///  </remarks>		<short>    Local change to font.</short>
	[SmokeClass("DOM::HTMLFontElement")]
	public class HTMLFontElement : DOM.HTMLElement, IDisposable {
 		protected HTMLFontElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLFontElement), this);
		}
		// DOM::HTMLFontElement* HTMLFontElement(DOM::HTMLFontElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLFontElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLFontElement", "HTMLFontElement()", typeof(void));
		}
		public HTMLFontElement(DOM.HTMLFontElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLFontElement#", "HTMLFontElement(const DOM::HTMLFontElement&)", typeof(void), typeof(DOM.HTMLFontElement), other);
		}
		public HTMLFontElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLFontElement#", "HTMLFontElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  Font color. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/graphics.html#adef-color-FONT">
		///  color attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Font color.</short>
		public DOM.DOMString Color() {
			return (DOM.DOMString) interceptor.Invoke("color", "color() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see color
		///      </remarks>		<short>    see color      </short>
		public void SetColor(DOM.DOMString arg1) {
			interceptor.Invoke("setColor#", "setColor(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Font face identifier. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/graphics.html#adef-face-FONT">
		///  face attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Font face identifier.</short>
		public DOM.DOMString Face() {
			return (DOM.DOMString) interceptor.Invoke("face", "face() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see face
		///      </remarks>		<short>    see face      </short>
		public void SetFace(DOM.DOMString arg1) {
			interceptor.Invoke("setFace#", "setFace(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Font size. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/graphics.html#adef-size-FONT">
		///  size attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Font size.</short>
		public DOM.DOMString Size() {
			return (DOM.DOMString) interceptor.Invoke("size", "size() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see size
		///      </remarks>		<short>    see size      </short>
		public void SetSize(DOM.DOMString arg1) {
			interceptor.Invoke("setSize#", "setSize(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		~HTMLFontElement() {
			interceptor.Invoke("~HTMLFontElement", "~HTMLFontElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLFontElement", "~HTMLFontElement()", typeof(void));
		}
	}
}
