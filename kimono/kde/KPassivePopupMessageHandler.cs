//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  @brief This is a convenience KMessageHandler that uses KPassivePopup.
	/// </remarks>		<author> Michaël Larouche <michael.larouche@kdemail.net>
	///  </author>
	/// 		<short>    @brief This is a convenience KMessageHandler that uses KPassivePopup.</short>
	[SmokeClass("KPassivePopupMessageHandler")]
	public class KPassivePopupMessageHandler : QObject, IKMessageHandler, IDisposable {
 		protected KPassivePopupMessageHandler(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPassivePopupMessageHandler), this);
		}
		/// <remarks>
		///  @brief Create a new KPassivePopupMessageHandler
		/// <param> name="parent" Parent widget to use for the KPassivePopup.
		///      </param></remarks>		<short>    @brief Create a new KPassivePopupMessageHandler </short>
		public KPassivePopupMessageHandler(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPassivePopupMessageHandler#", "KPassivePopupMessageHandler(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPassivePopupMessageHandler() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPassivePopupMessageHandler", "KPassivePopupMessageHandler()", typeof(void));
		}
		/// <remarks>
		///  @copydoc KMessageHandler.Message
		///      </remarks>		<short>    @copydoc KMessageHandler.Message      </short>
		[SmokeMethod("message(KMessage::MessageType, const QString&, const QString&)")]
		public virtual void Message(KMessage.MessageType messageType, string text, string caption) {
			interceptor.Invoke("message$$$", "message(KMessage::MessageType, const QString&, const QString&)", typeof(void), typeof(KMessage.MessageType), messageType, typeof(string), text, typeof(string), caption);
		}
		~KPassivePopupMessageHandler() {
			interceptor.Invoke("~KPassivePopupMessageHandler", "~KPassivePopupMessageHandler()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPassivePopupMessageHandler", "~KPassivePopupMessageHandler()", typeof(void));
		}
		protected new IKPassivePopupMessageHandlerSignals Emit {
			get { return (IKPassivePopupMessageHandlerSignals) Q_EMIT; }
		}
	}

	public interface IKPassivePopupMessageHandlerSignals : IQObjectSignals {
	}
}
