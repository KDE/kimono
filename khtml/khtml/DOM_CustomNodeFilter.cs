//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  CustomNodeFilter can be used to define your own NodeFilter for use
	///  with NodeIterators and TreeWalkers. You can create a custom filter
	///  by doing the following:
	///  class MyCustomNodeFilter {
	///   .....
	///   short acceptNode (Noden);
	///   .....
	///  }
	///  Then in your program:
	///  short MyCustomNodeFilter.AcceptNode (Noden)
	///  {
	///    if (condition)
	///      return NodeFilter.FILTER_ACCEPT;
	///    else
	///     ....
	///  }
	///  MyCustomFilter filter = new MyCustomFilter();
	///  NodeFilter nf = NodeFilter.CreateCustom(filter);
	///  NodeIterator ni = document.createNodeIterator(document,NodeFilter.SHOW_ALL,nf,false);
	///  The default implementation of acceptNode() returns NodeFilter.FILTER_ACCEPT
	///  for all nodes.
	///  </remarks>		<short>    CustomNodeFilter can be used to define your own NodeFilter for use  with NodeIterators and TreeWalkers.</short>
	[SmokeClass("DOM::CustomNodeFilter")]
	public class CustomNodeFilter : DOM.DomShared, IDisposable {
 		protected CustomNodeFilter(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(CustomNodeFilter), this);
		}
		public CustomNodeFilter() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("CustomNodeFilter", "CustomNodeFilter()", typeof(void));
		}
		[SmokeMethod("acceptNode(const DOM::Node&)")]
		public virtual short AcceptNode(DOM.Node n) {
			return (short) interceptor.Invoke("acceptNode#", "acceptNode(const DOM::Node&)", typeof(short), typeof(DOM.Node), n);
		}
		[SmokeMethod("isNull()")]
		public virtual bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull()", typeof(bool));
		}
		/// <remarks>
		///  not part of the DOM
		///  Returns a name specifying the type of custom node filter. Useful for checking
		///  if an custom node filter is of a particular sublass.
		///      </remarks>		<short>   </short>
		[SmokeMethod("customNodeFilterType()")]
		public virtual DOM.DOMString CustomNodeFilterType() {
			return (DOM.DOMString) interceptor.Invoke("customNodeFilterType", "customNodeFilterType()", typeof(DOM.DOMString));
		}
		~CustomNodeFilter() {
			interceptor.Invoke("~CustomNodeFilter", "~CustomNodeFilter()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~CustomNodeFilter", "~CustomNodeFilter()", typeof(void));
		}
	}
}
