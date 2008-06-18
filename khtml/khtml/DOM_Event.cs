//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  Introduced in DOM Level 2
	///  The Event interface is used to provide contextual information about an event
	///  to the handler processing the event. An object which implements the Event
	///  interface is generally passed as the first parameter to an event handler.
	///  More specific context information is passed to event handlers by deriving
	///  additional interfaces from Event which contain information directly relating
	///  to the type of event they accompany. These derived interfaces are also
	///  implemented by the object passed to the event listener.
	///  </remarks>		<short>    Introduced in DOM Level 2 </short>
	[SmokeClass("DOM::Event")]
	public class Event : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected Event(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Event), this);
		}
		/// <remarks>
		///  An integer indicating which phase of event flow is being processed.
		///  AT_TARGET: The event is currently being evaluated at the target
		///  EventTarget.
		///  BUBBLING_PHASE: The current event phase is the bubbling phase.
		///  CAPTURING_PHASE: The current event phase is the capturing phase.
		///      </remarks>		<short>    An integer indicating which phase of event flow is being processed.</short>
		public enum PhaseType {
			CAPTURING_PHASE = 1,
			AT_TARGET = 2,
			BUBBLING_PHASE = 3,
		}
		// DOM::DOMTimeStamp timeStamp(); >>>> NOT CONVERTED
		// DOM::Event* Event(DOM::EventImpl* arg1); >>>> NOT CONVERTED
		public Event() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Event", "Event()", typeof(void));
		}
		public Event(DOM.Event other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Event#", "Event(const DOM::Event&)", typeof(void), typeof(DOM.Event), other);
		}
		/// <remarks>
		///  The name of the event (case-insensitive). The name must be an XML name.
		///      </remarks>		<short>    The name of the event (case-insensitive).</short>
		public DOM.DOMString type() {
			return (DOM.DOMString) interceptor.Invoke("type", "type() const", typeof(DOM.DOMString));
		}
		/// <remarks>
		///  Used to indicate the EventTarget to which the event was originally
		///  dispatched.
		///      </remarks>		<short>    Used to indicate the EventTarget to which the event was originally  dispatched.</short>
		public DOM.Node Target() {
			return (DOM.Node) interceptor.Invoke("target", "target() const", typeof(DOM.Node));
		}
		/// <remarks>
		///  Used to indicate the EventTarget whose EventListeners are currently
		///  being processed. This is particularly useful during capturing and
		///  bubbling.
		///      </remarks>		<short>    Used to indicate the EventTarget whose EventListeners are currently  being processed.</short>
		public DOM.Node CurrentTarget() {
			return (DOM.Node) interceptor.Invoke("currentTarget", "currentTarget() const", typeof(DOM.Node));
		}
		/// <remarks>
		///  Used to indicate which phase of event flow is currently being evaluated.
		///      </remarks>		<short>    Used to indicate which phase of event flow is currently being evaluated.</short>
		public ushort EventPhase() {
			return (ushort) interceptor.Invoke("eventPhase", "eventPhase() const", typeof(ushort));
		}
		/// <remarks>
		///  Used to indicate whether or not an event is a bubbling event. If the
		///  event can bubble the value is true, else the value is false.
		///      </remarks>		<short>    Used to indicate whether or not an event is a bubbling event.</short>
		public bool Bubbles() {
			return (bool) interceptor.Invoke("bubbles", "bubbles() const", typeof(bool));
		}
		/// <remarks>
		///  Used to indicate whether or not an event can have its default action
		///  prevented. If the default action can be prevented the value is true,
		///  else the value is false.
		///      </remarks>		<short>    Used to indicate whether or not an event can have its default action  prevented.</short>
		public bool Cancelable() {
			return (bool) interceptor.Invoke("cancelable", "cancelable() const", typeof(bool));
		}
		/// <remarks>
		///  Used to specify the time (in milliseconds relative to the epoch) at
		///  which the event was created. Due to the fact that some systems may not
		///  provide this information the value of timeStamp may be not available for
		///  all events. When not available, a value of 0 will be returned. Examples
		///  of epoch time are the time of the system start or 0:0:0 UTC 1st January 1970.
		///      </remarks>		<short>    Used to specify the time (in milliseconds relative to the epoch) at  which the event was created.</short>
		/// <remarks>
		///  The stopPropagation method is used prevent further propagation of an
		///  event during event flow. If this method is called by any EventListener
		///  the event will cease propagating through the tree. The event will
		///  complete dispatch to all listeners on the current EventTarget before
		///  event flow stops. This method may be used during any stage of event flow.
		///      </remarks>		<short>    The stopPropagation method is used prevent further propagation of an  event during event flow.</short>
		public void StopPropagation() {
			interceptor.Invoke("stopPropagation", "stopPropagation()", typeof(void));
		}
		/// <remarks>
		///  If an event is cancelable, the preventDefault method is used to signify
		///  that the event is to be canceled, meaning any default action normally
		///  taken by the implementation as a result of the event will not occur. If,
		///  during any stage of event flow, the preventDefault method is called the
		///  event is canceled. Any default action associated with the event will not
		///  occur. Calling this method for a non-cancelable event has no effect.
		///  Once preventDefault has been called it will remain in effect throughout
		///  the remainder of the event's propagation. This method may be used during
		///  any stage of event flow.
		///      </remarks>		<short>    If an event is cancelable, the preventDefault method is used to signify  that the event is to be canceled, meaning any default action normally  taken by the implementation as a result of the event will not occur.</short>
		public void PreventDefault() {
			interceptor.Invoke("preventDefault", "preventDefault()", typeof(void));
		}
		/// <remarks>
		///  The initEvent method is used to initialize the value of an Event created
		///  through the DocumentEvent interface. This method may only be called
		///  before the Event has been dispatched via the dispatchEvent method,
		///  though it may be called multiple times during that phase if necessary.
		///  If called multiple times the final invocation takes precedence. If
		///  called from a subclass of Event interface only the values specified in
		///  the initEvent method are modified, all other attributes are left
		///  unchanged.
		/// <param> name="eventTypeArg" Specifies the event type. This type may be any event
		///  type currently defined in this specification or a new event type.. The
		///  string must be an XML name.
		/// </param> Any new event type must not begin with any upper, lower, or mixed case
		///  version of the string "DOM". This prefix is reserved for future DOM
		///  event sets. It is also strongly recommended that third parties adding
		///  their own events use their own prefix to avoid confusion and lessen the
		///  probability of conflicts with other new events.
		/// <param> name="canBubbleArg" Specifies whether or not the event can bubble.
		/// </param><param> name="cancelableArg" Specifies whether or not the event's default action can be prevented.
		/// </param>     </remarks>		<short>    The initEvent method is used to initialize the value of an Event created  through the DocumentEvent interface.</short>
		public void InitEvent(DOM.DOMString eventTypeArg, bool canBubbleArg, bool cancelableArg) {
			interceptor.Invoke("initEvent#$$", "initEvent(const DOM::DOMString&, bool, bool)", typeof(void), typeof(DOM.DOMString), eventTypeArg, typeof(bool), canBubbleArg, typeof(bool), cancelableArg);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		~Event() {
			interceptor.Invoke("~Event", "~Event()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~Event", "~Event()", typeof(void));
		}
	}
}