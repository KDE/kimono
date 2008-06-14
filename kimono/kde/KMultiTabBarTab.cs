//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  Use KMultiTabBar.AppendTab to append a tab, which creates a KMultiTabBarTab instance
	///  </remarks>		<short>    Use KMultiTabBar.AppendTab to append a tab, which creates a KMultiTabBarTab instance  </short>
	[SmokeClass("KMultiTabBarTab")]
	public class KMultiTabBarTab : KMultiTabBarButton {
 		protected KMultiTabBarTab(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KMultiTabBarTab), this);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		/// <remarks>
		///  this is used internaly, but can be used by the user, if (s)he wants to
		///  It the according call of KMultiTabBar is invoked though this modifications will be overwritten
		///      </remarks>		<short>    this is used internaly, but can be used by the user, if (s)he wants to  It the according call of KMultiTabBar is invoked though this modifications will be overwritten      </short>
		[Q_SLOT("void setPosition(KMultiTabBar::KMultiTabBarPosition)")]
		public void SetPosition(KMultiTabBar.KMultiTabBarPosition arg1) {
			interceptor.Invoke("setPosition$", "setPosition(KMultiTabBar::KMultiTabBarPosition)", typeof(void), typeof(KMultiTabBar.KMultiTabBarPosition), arg1);
		}
		/// <remarks>
		///  this is used internaly, but can be used by the user, if (s)he wants to
		///  It the according call of KMultiTabBar is invoked though this modifications will be overwritten
		///      </remarks>		<short>    this is used internaly, but can be used by the user, if (s)he wants to  It the according call of KMultiTabBar is invoked though this modifications will be overwritten      </short>
		[Q_SLOT("void setStyle(KMultiTabBar::KMultiTabBarStyle)")]
		public void SetStyle(KMultiTabBar.KMultiTabBarStyle arg1) {
			interceptor.Invoke("setStyle$", "setStyle(KMultiTabBar::KMultiTabBarStyle)", typeof(void), typeof(KMultiTabBar.KMultiTabBarStyle), arg1);
		}
		/// <remarks>
		///  set the active state of the tab
		/// <param> name="state" true==active false==not active
		///      </param></remarks>		<short>    set the active state of the tab </short>
		[Q_SLOT("void setState(bool)")]
		public void SetState(bool state) {
			interceptor.Invoke("setState$", "setState(bool)", typeof(void), typeof(bool), state);
		}
		[Q_SLOT("void setIcon(const QString&)")]
		public void SetIcon(string arg1) {
			interceptor.Invoke("setIcon$", "setIcon(const QString&)", typeof(void), typeof(string), arg1);
		}
		[Q_SLOT("void setIcon(const QPixmap&)")]
		public void SetIcon(QPixmap arg1) {
			interceptor.Invoke("setIcon#", "setIcon(const QPixmap&)", typeof(void), typeof(QPixmap), arg1);
		}
		protected new IKMultiTabBarTabSignals Emit {
			get { return (IKMultiTabBarTabSignals) Q_EMIT; }
		}
	}

	public interface IKMultiTabBarTabSignals : IKMultiTabBarButtonSignals {
	}
}
