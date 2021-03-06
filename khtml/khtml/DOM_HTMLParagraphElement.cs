//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  Paragraphs. See the <a
	///  href="http://www.w3.org/TR/REC-html40/struct/text.html#edef-P"> P
	///  element definition </a> in HTML 4.0.
	///  </remarks>		<short>    Paragraphs.</short>
	[SmokeClass("DOM::HTMLParagraphElement")]
	public class HTMLParagraphElement : DOM.HTMLElement, IDisposable {
 		protected HTMLParagraphElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLParagraphElement), this);
		}
		// DOM::HTMLParagraphElement* HTMLParagraphElement(DOM::HTMLElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLParagraphElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLParagraphElement", "HTMLParagraphElement()", typeof(void));
		}
		public HTMLParagraphElement(DOM.HTMLParagraphElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLParagraphElement#", "HTMLParagraphElement(const DOM::HTMLParagraphElement&)", typeof(void), typeof(DOM.HTMLParagraphElement), other);
		}
		public HTMLParagraphElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLParagraphElement#", "HTMLParagraphElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  Horizontal text alignment. See the <a
		///  href="http://www.w3.org/TR/REC-html40/present/graphics.html#adef-align">
		///  align attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Horizontal text alignment.</short>
		public DOM.DOMString Align() {
			return (DOM.DOMString) interceptor.Invoke("align", "align() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see align
		///      </remarks>		<short>    see align      </short>
		public void SetAlign(DOM.DOMString arg1) {
			interceptor.Invoke("setAlign#", "setAlign(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		~HTMLParagraphElement() {
			interceptor.Invoke("~HTMLParagraphElement", "~HTMLParagraphElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLParagraphElement", "~HTMLParagraphElement()", typeof(void));
		}
	}
}
