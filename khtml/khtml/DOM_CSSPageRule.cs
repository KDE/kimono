//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  The <code>CSSPageRule</code> interface represents a <a
	///  href="http://www.w3.org/TR/REC-CSS2/page.html#page-box"> page rule
	///  </a> within a CSS style sheet. The <code>@page</code> rule is
	///  used to specify the dimensions, orientation, margins, etc. of a
	///  page box for paged media.
	///  </remarks>		<short>    The <code>CSSPageRule</code> interface represents a <a  href="http://www.</short>
	[SmokeClass("DOM::CSSPageRule")]
	public class CSSPageRule : DOM.CSSRule, IDisposable {
 		protected CSSPageRule(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(CSSPageRule), this);
		}
		// DOM::CSSPageRule* CSSPageRule(DOM::CSSPageRuleImpl* arg1); >>>> NOT CONVERTED
		public CSSPageRule() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSPageRule", "CSSPageRule()", typeof(void));
		}
		public CSSPageRule(DOM.CSSPageRule other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSPageRule#", "CSSPageRule(const DOM::CSSPageRule&)", typeof(void), typeof(DOM.CSSPageRule), other);
		}
		public CSSPageRule(DOM.CSSRule other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CSSPageRule#", "CSSPageRule(const DOM::CSSRule&)", typeof(void), typeof(DOM.CSSRule), other);
		}
		/// <remarks>
		///  The parsable textual representation of the page selector for
		///  the rule.
		///      </remarks>		<short>    The parsable textual representation of the page selector for  the rule.</short>
		public DOM.DOMString SelectorText() {
			return (DOM.DOMString) interceptor.Invoke("selectorText", "selectorText() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  see selectorText
		///      </remarks>		<short>    see selectorText </short>
		public void SetSelectorText(DOM.DOMString arg1) {
			interceptor.Invoke("setSelectorText#", "setSelectorText(const DOM::DOMString&)", typeof(void), typeof(DOM.DOMString), arg1);
		}
		/// <remarks>
		///  The <a href="http://www.w3.org/TR/REC-CSS2/syndata.html#q8">
		///  declaration-block </a> of this rule.
		///      </remarks>		<short>    The <a href="http://www.</short>
		public DOM.CSSStyleDeclaration Style() {
			return (DOM.CSSStyleDeclaration) interceptor.Invoke("style", "style() const", typeof(DOM.CSSStyleDeclaration));
		}
		~CSSPageRule() {
			interceptor.Invoke("~CSSPageRule", "~CSSPageRule()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~CSSPageRule", "~CSSPageRule()", typeof(void));
		}
	}
}
