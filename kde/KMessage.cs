//Auto-generated by kalyptus. DO NOT EDIT.
namespace KMessage {
    using Kimono;
    using System;
    using Qyoto;
    public enum MessageType {
        Error = 0,
        Information = 1,
        Warning = 2,
        Sorry = 3,
        Fatal = 4,
    }
    /// <remarks>
    ///  @brief Display an informative message using a KMessageHandler.
    ///  This class does not define how to display a message, it is just
    ///  a clean interface for developers to use. 
    ///  The job is done by the current KMessageHandler set in the class.
    ///  If no KMessageHandler is currently registered in KMessage, 
    ///  the message will be outputed to stderr.
    ///  Use KMessage.SetMessageHandler() to use a KMessageHandler.
    ///  @code
    ///  KMessage.SetMessageHandler( new KMessageBoxHandler(this) );
    ///  // some operation
    ///  KMessage.Message( KMessage.Error, i18n("Could not load service. Use kbuildsycoca to fix the service database."), i18n("KService") );
    ///  @endcode
    ///  Some KMessageHandler are already done such as KMessageBoxMessageHandler and KPassivePopupMessageHandler.
    /// </remarks>        <author> Michaël Larouche <michael.larouche@kdemail.net>
    ///  </author>
    ///         <short>    @brief Display an informative message using a KMessageHandler.</short>
    [SmokeClass("KMessage")]
    public class Global {
        private static SmokeInvocation staticInterceptor = null;
        static Global() {
            staticInterceptor = new SmokeInvocation(typeof(Global), null);
        }
        /// <remarks>
        ///  @brief Display a long message of a certain type.
        ///  A long message span on multiple lines and can have a caption.
        /// <param> name="messageType" Currrent type of message. See MessageType enum.
        /// </param><param> name="text" Long message to be displayed.
        /// </param><param> name="caption" Caption to be used. This is optional.
        ///      </param></remarks>        <short>    @brief Display a long message of a certain type.</short>
        public static void Message(KMessage.MessageType messageType, string text, string caption) {
            staticInterceptor.Invoke("message$$$", "message(KMessage::MessageType, const QString&, const QString&)", typeof(void), typeof(KMessage.MessageType), messageType, typeof(string), text, typeof(string), caption);
        }
        public static void Message(KMessage.MessageType messageType, string text) {
            staticInterceptor.Invoke("message$$", "message(KMessage::MessageType, const QString&)", typeof(void), typeof(KMessage.MessageType), messageType, typeof(string), text);
        }
        /// <remarks>
        ///  @brief Set the current KMessageHandler
        ///  Note that this method take ownership of the KMessageHandler.
        /// <param> name="handler" Instance of a real KMessageHandler.
        /// </param> @warning This function isn't thread-safe. You don't want to
        ///           change the message handler during the program's
        ///           execution anyways. Do so <b>only</b> at start-up.
        ///      </remarks>        <short>    @brief Set the current KMessageHandler  Note that this method take ownership of the KMessageHandler.</short>
        public static void SetMessageHandler(IKMessageHandler handler) {
            staticInterceptor.Invoke("setMessageHandler#", "setMessageHandler(KMessageHandler*)", typeof(void), typeof(IKMessageHandler), handler);
        }
    }
}
