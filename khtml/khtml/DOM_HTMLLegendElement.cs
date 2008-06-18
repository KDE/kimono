//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  Provides a caption for a <code>FIELDSET</code> grouping. See the
	///  <a
	///  href="http://www.w3.org/TR/REC-html40/interact/forms.html#edef-LEGEND">
	///  LEGEND element definition </a> in HTML 4.0.
	///  </remarks>		<short>    Provides a caption for a <code>FIELDSET</code> grouping.</short>
	[SmokeClass("DOM::HTMLLegendElement")]
	public class HTMLLegendElement : DOM.HTMLElement, IDisposable {
 		protected HTMLLegendElement(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(HTMLLegendElement), this);
		}
		// DOM::HTMLLegendElement* HTMLLegendElement(DOM::HTMLLegendElementImpl* arg1); >>>> NOT CONVERTED
		public HTMLLegendElement() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLLegendElement", "HTMLLegendElement()", typeof(void));
		}
		public HTMLLegendElement(DOM.HTMLLegendElement other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLLegendElement#", "HTMLLegendElement(const DOM::HTMLLegendElement&)", typeof(void), typeof(DOM.HTMLLegendElement), other);
		}
		public HTMLLegendElement(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("HTMLLegendElement#", "HTMLLegendElement(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		/// <remarks>
		///  ### KDE 4.0: remove
		///      </remarks>		<short>    ### KDE 4.</short>
		public new DOM.HTMLFormElement Form() {
			return (DOM.HTMLFormElement) interceptor.Invoke("form", "form() const", typeof(DOM.HTMLFormElement));
		}
		/// <remarks>
		///  A single character access key to give access to the form
		///  control. See the <a
		///  href="http://www.w3.org/TR/REC-html40/interact/forms.html#adef-accesskey">
		///  accesskey attribute definition </a> in HTML 4.0.
		///      </remarks>		<short>    A single character access key to give access to the form  control.</short>
		public DOM.DOMString AccessKey() {
			return (DOM.DOMString) interceptor.Invoke("accessKey", "accessKey() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see accessKey
		///      </remarks>		<short>    see accessKey      </short>
		public void SetAccessKey(DOM.DOMString arg1) {
			interceptor.Invoke("setAccessKey#", "setAccessKey(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  Text alignment relative to <code>FIELDSET</code> . See the <a
		///  href="http://www.w3.org/TR/REC-html40/interact/forms.html#adef-align-LEGEND">
		///  align attribute definition </a> in HTML 4.0. This attribute is
		///  deprecated in HTML 4.0.
		///      </remarks>		<short>    Text alignment relative to <code>FIELDSET</code> .</short>
		public DOM.DOMString Align() {
			return (DOM.DOMString) interceptor.Invoke("align", "align() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see align
		///      </remarks>		<short>    see align      </short>
		public void SetAlign(DOM.DOMString arg1) {
			interceptor.Invoke("setAlign#", "setAlign(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		~HTMLLegendElement() {
			interceptor.Invoke("~HTMLLegendElement", "~HTMLLegendElement()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~HTMLLegendElement", "~HTMLLegendElement()", typeof(void));
		}
	}
}