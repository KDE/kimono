//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano {
	using Soprano;
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  \class NodeIterator nodeiterator.h Soprano/NodeIterator
	///  \brief An iterator that provides a stream of Nodes.
	///  The most common use of %NodeIterator is through Model.ListContexts().
	///  Many backends do lock the underlying Model during iteration. Thus, 
	///  it is always a good idea to cache the results if they are to be used
	///  to modify the model to prevent a deadlock:
	///  <pre>
	///  Soprano.NodeIterator it = model.ListContexts();
	///  QList<Node> allNodes = it.allElements();
	///  Q_FOREACH( Soprano.Node n, allNodes ) {
	///     modifyTheModel( model, n );
	///  }
	///  </pre>
	///  For further details on %Soprano iterators see Iterator.
	///  \warning Be aware that iterators in Soprano are shared objects which means
	///  that copies of one iterator object work on the same data.
	///  \author Sebastian Trueg <trueg@kde.org>
	///      </remarks>		<short>    \class NodeIterator nodeiterator.</short>
	[SmokeClass("Soprano::NodeIterator")]
	public class NodeIterator : Soprano.Iterator, IDisposable {
 		protected NodeIterator(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(NodeIterator), this);
		}
		// Soprano::NodeIterator* NodeIterator(Soprano::IteratorBackend<Soprano::Node>* arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Creates and empty, invalid iterator.
		///          </remarks>		<short>    Creates and empty, invalid iterator.</short>
		public NodeIterator() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("NodeIterator", "NodeIterator()", typeof(void));
		}
		public NodeIterator(Soprano.NodeIterator sti) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("NodeIterator#", "NodeIterator(const Soprano::NodeIterator&)", typeof(void), typeof(Soprano.NodeIterator), sti);
		}
		/// <remarks>
		///  Convenience method which extracts all nodes (this does not include the
		///  nodes that have already been read from the iterator) from the iterator
		///  and returns them in a list.
		///  Be aware that after calling this method the iterator will be invalid.
		///  \return A list of all nodes that rest in the iterator.
		///          </remarks>		<short>    Convenience method which extracts all nodes (this does not include the  nodes that have already been read from the iterator) from the iterator  and returns them in a list.</short>
		public List<Soprano.Node> AllNodes() {
			return (List<Soprano.Node>) interceptor.Invoke("allNodes", "allNodes()", typeof(List<Soprano.Node>));
		}
		~NodeIterator() {
			interceptor.Invoke("~NodeIterator", "~NodeIterator()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~NodeIterator", "~NodeIterator()", typeof(void));
		}
	}
}
