//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  This widget can be used to display or allow user selection of a date.
	///  See <see cref="IKDateWidgetSignals"></see> for signals emitted by KDateWidget
	/// </remarks>		<short> A pushbutton to display or allow user selection of a date. </short>
	/// 		<see> KDatePicker</see>
	[SmokeClass("KDateWidget")]
	public class KDateWidget : QWidget, IDisposable {
 		protected KDateWidget(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KDateWidget), this);
		}
		[Q_PROPERTY("QDate", "date")]
		public QDate Date {
			get { return (QDate) interceptor.Invoke("date", "date()", typeof(QDate)); }
			set { interceptor.Invoke("setDate#", "setDate(QDate)", typeof(void), typeof(QDate), value); }
		}
		/// <remarks>
		///  Constructs a date selection widget.
		///      </remarks>		<short>    Constructs a date selection widget.</short>
		public KDateWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateWidget#", "KDateWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KDateWidget() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateWidget", "KDateWidget()", typeof(void));
		}
		/// <remarks>
		///  Constructs a date selection widget with the initial date set to <code>date.</code>
		///      </remarks>		<short>    Constructs a date selection widget with the initial date set to <code>date.</code></short>
		public KDateWidget(QDate date, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateWidget##", "KDateWidget(const QDate&, QWidget*)", typeof(void), typeof(QDate), date, typeof(QWidget), parent);
		}
		public KDateWidget(QDate date) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateWidget#", "KDateWidget(const QDate&)", typeof(void), typeof(QDate), date);
		}
		/// <remarks>
		///  Returns the currently selected calendar system.
		/// </remarks>		<return> a KCalendarSystem object
		///      </return>
		/// 		<short>    Returns the currently selected calendar system.</short>
		public KCalendarSystem Calendar() {
			return (KCalendarSystem) interceptor.Invoke("calendar", "calendar() const", typeof(KCalendarSystem));
		}
		/// <remarks>
		///  Changes the calendar system to use.  Can use its own local locale if set.
		/// <param> name="calendar" the calendar system object to use, defaults to global
		/// </param></remarks>		<return> @c true if the calendar system was successfully set, @c false otherwise
		///      </return>
		/// 		<short>    Changes the calendar system to use.</short>
		public bool SetCalendar(KCalendarSystem calendar) {
			return (bool) interceptor.Invoke("setCalendar#", "setCalendar(KCalendarSystem*)", typeof(bool), typeof(KCalendarSystem), calendar);
		}
		public bool SetCalendar() {
			return (bool) interceptor.Invoke("setCalendar", "setCalendar()", typeof(bool));
		}
		/// <remarks>
		///  Changes the calendar system to use.  Will always use global locale.
		/// <param> name="calendarType" the calendar system type to use
		/// </param></remarks>		<return> @c true if the calendar system was successfully set, @c false otherwise
		///      </return>
		/// 		<short>    Changes the calendar system to use.</short>
		public bool SetCalendar(string calendarType) {
			return (bool) interceptor.Invoke("setCalendar$", "setCalendar(const QString&)", typeof(bool), typeof(string), calendarType);
		}
		protected void Init(QDate date) {
			interceptor.Invoke("init#", "init(const QDate&)", typeof(void), typeof(QDate), date);
		}
		[Q_SLOT("void slotDateChanged()")]
		protected void SlotDateChanged() {
			interceptor.Invoke("slotDateChanged", "slotDateChanged()", typeof(void));
		}
		~KDateWidget() {
			interceptor.Invoke("~KDateWidget", "~KDateWidget()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KDateWidget", "~KDateWidget()", typeof(void));
		}
		protected new IKDateWidgetSignals Emit {
			get { return (IKDateWidgetSignals) Q_EMIT; }
		}
	}

	public interface IKDateWidgetSignals : IQWidgetSignals {
		/// <remarks>
		///  Emitted whenever the date of the widget
		///  is changed, either with setDate() or via user selection.
		///      </remarks>		<short>    Emitted whenever the date of the widget  is changed, either with setDate() or via user selection.</short>
		[Q_SIGNAL("void changed(QDate)")]
		void Changed(QDate date);
	}
}
