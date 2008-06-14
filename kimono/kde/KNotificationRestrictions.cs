//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  KNotificationRestrictions provides a simple mechanism to avoid disruptions
	///  during full screen presentations or other use cases where the screensaver or
	///  desktop notifcations are inappropriate.
	///  Using KNotificationRestrictions is quite straightforward: create an instance
	///  of KNotificationRestrictions, passing in the set of or'd flags representing
	///  the services that should be prevented from interrupting the user. When done
	///  (for instance when the presentation is complete) simply delete the
	///  KNotificationRestrictions object.
	///  Example: to ensure the screensaver does not turn on during a presentation
	///  void MyApp.DoPresentation()
	///  {
	///    KNotificationRestrictions restrict(KNotificationRestrictions.ScreenSaver);
	///    // show presentation
	///  }
	///  </remarks>		<short>    KNotificationRestrictions provides a simple mechanism to avoid disruptions  during full screen presentations or other use cases where the screensaver or  desktop notifcations are inappropriate.</short>
	[SmokeClass("KNotificationRestrictions")]
	public class KNotificationRestrictions : QObject, IDisposable {
 		protected KNotificationRestrictions(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KNotificationRestrictions), this);
		}
		/// <remarks>
		///  @enum Service
		///  @value NoServices the baseline "don't disable anything" value
		///  @value ScreenSaver causes the screensaver to be prevented from
		///         automatically turning on
		///  @value MessagingPopups (NOT IMPLEMENTED YET) causes instant messaging
		///         and email notifications to not appear
		///  @value Notifications (NOT IMPLEMENTED YET) causes non-critical
		///         desktop messages to be suppressed
		///  @value CriticalNotifications (NOT IMPLEMENTED YET) causes all desktop
		///         notifications, including critical ones such as battery low
		///         warnings to be suppressed
		///          </remarks>		<short>    @enum Service  @value NoServices the baseline "don't disable anything" value  @value ScreenSaver causes the screensaver to be prevented from         automatically turning on  @value MessagingPopups (NOT IMPLEMENTED YET) causes instant messaging         and email notifications to not appear  @value Notifications (NOT IMPLEMENTED YET) causes non-critical         desktop messages to be suppressed  @value CriticalNotifications (NOT IMPLEMENTED YET) causes all desktop         notifications, including critical ones such as battery low         warnings to be suppressed          </short>
		public enum Service {
			NoServices = 0,
			ScreenSaver = 1,
			MessagingPopups = 2,
			Notifications = 4,
			CriticalNotifications = 8,
			NonCriticalServices = ScreenSaver|MessagingPopups|Notifications,
			AllServices = NonCriticalServices|CriticalNotifications,
		}
		public KNotificationRestrictions(uint control, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNotificationRestrictions$#", "KNotificationRestrictions(KNotificationRestrictions::Services, QObject*)", typeof(void), typeof(uint), control, typeof(QObject), parent);
		}
		public KNotificationRestrictions(uint control) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNotificationRestrictions$", "KNotificationRestrictions(KNotificationRestrictions::Services)", typeof(void), typeof(uint), control);
		}
		public KNotificationRestrictions() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNotificationRestrictions", "KNotificationRestrictions()", typeof(void));
		}
		~KNotificationRestrictions() {
			interceptor.Invoke("~KNotificationRestrictions", "~KNotificationRestrictions()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KNotificationRestrictions", "~KNotificationRestrictions()", typeof(void));
		}
		protected new IKNotificationRestrictionsSignals Emit {
			get { return (IKNotificationRestrictionsSignals) Q_EMIT; }
		}
	}

	public interface IKNotificationRestrictionsSignals : IQObjectSignals {
	}
}
