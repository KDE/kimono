//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  CDATA sections are used to escape blocks of text containing
	///  characters that would otherwise be regarded as markup. The only
	///  delimiter that is recognized in a CDATA section is the "]]&gt;"
	///  string that ends the CDATA section. CDATA sections can not be
	///  nested. The primary purpose is for including material such as XML
	///  fragments, without needing to escape all the delimiters.
	///   The <code>DOMString</code> attribute of the <code>Text</code>
	///  node holds the text that is contained by the CDATA section. Note
	///  that this may contain characters that need to be escaped outside of
	///  CDATA sections and that, depending on the character encoding
	///  ("charset") chosen for serialization, it may be impossible to write
	///  out some characters as part of a CDATA section.
	///   The <code>CDATASection</code> interface inherits the
	///  <code>CharacterData</code> interface through the <code>Text</code>
	///  interface. Adjacent <code>CDATASections</code> nodes are not
	///  merged by use of the Element.normalize() method.
	///  </remarks>		<short>    CDATA sections are used to escape blocks of text containing  characters that would otherwise be regarded as markup.</short>
	[SmokeClass("DOM::CDATASection")]
	public class CDATASection : DOM.Text, IDisposable {
 		protected CDATASection(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(CDATASection), this);
		}
		// DOM::CDATASection* CDATASection(DOM::CDATASectionImpl* arg1); >>>> NOT CONVERTED
		public CDATASection() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CDATASection", "CDATASection()", typeof(void));
		}
		public CDATASection(DOM.CDATASection other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CDATASection#", "CDATASection(const DOM::CDATASection&)", typeof(void), typeof(DOM.CDATASection), other);
		}
		public CDATASection(DOM.Node other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CDATASection#", "CDATASection(const DOM::Node&)", typeof(void), typeof(DOM.Node), other);
		}
		~CDATASection() {
			interceptor.Invoke("~CDATASection", "~CDATASection()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~CDATASection", "~CDATASection()", typeof(void));
		}
	}
}
