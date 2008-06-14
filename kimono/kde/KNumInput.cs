//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  You need to inherit from this class if you want to implement KNumInput
	///  for a different variable type
	///  </remarks>		<short>    You need to inherit from this class if you want to implement K NumInput  for a different variable type </short>
	[SmokeClass("KNumInput")]
	public abstract class KNumInput : QWidget {
 		protected KNumInput(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KNumInput), this);
		}
		[Q_PROPERTY("QString", "label")]
		public string Label {
			get { return (string) interceptor.Invoke("label", "label()", typeof(string)); }
			set { interceptor.Invoke("setLabel$", "setLabel(QString)", typeof(void), typeof(string), value); }
		}
		/// <remarks>
		///  Default constructor
		/// <param> name="parent" If parent is 0, the new widget becomes a top-level
		///  window. If parent is another widget, this widget becomes a child
		///  window inside parent. The new widget is deleted when its parent is deleted.
		///      </param></remarks>		<short>    Default constructor </short>
		public KNumInput(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNumInput#", "KNumInput(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KNumInput() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNumInput", "KNumInput()", typeof(void));
		}
		/// <remarks>
		/// <param> name="below" A pointer to another KNumInput.
		/// </param><param> name="parent" parent widget
		///  \deprecated - use the version without the below parameter instead
		///      </param></remarks>		<short>   </short>
		public KNumInput(QWidget parent, KNumInput below) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNumInput##", "KNumInput(QWidget*, KNumInput*)", typeof(void), typeof(QWidget), parent, typeof(KNumInput), below);
		}
		/// <remarks>
		///  Sets the text and alignment of the main description label.
		/// <param> name="label" The text of the label.
		///               Use string() to remove an existing one.
		/// </param><param> name="a" The alignment of the label (Qt.Alignment).
		///           Default is <code>Qt</code>:AlignLeft | <code>Qt</code>:AlignTop.
		/// </param> The vertical alignment flags have special meaning with this
		///  widget:
		/// 
		/// <li>
		/// <code>Qt</code>:AlignTop     The label is placed above the edit/slider
		/// </li>
		/// 
		/// <li>
		/// <code>Qt</code>:AlignVCenter The label is placed left beside the edit
		/// </li>
		/// 
		/// <li>
		/// <code>Qt</code>:AlignBottom  The label is placed below the edit/slider
		/// </li>
		///      </remarks>		<short>    Sets the text and alignment of the main description label.</short>
		[SmokeMethod("setLabel(const QString&, Qt::Alignment)")]
		public virtual void SetLabel(string label, uint a) {
			interceptor.Invoke("setLabel$$", "setLabel(const QString&, Qt::Alignment)", typeof(void), typeof(string), label, typeof(uint), a);
		}
		[SmokeMethod("setLabel(const QString&)")]
		public virtual void SetLabel(string label) {
			interceptor.Invoke("setLabel$", "setLabel(const QString&)", typeof(void), typeof(string), label);
		}
		/// <remarks>
		/// </remarks>		<return> if the num input has a slider.
		///      </return>
		/// 		<short>   </short>
		public bool ShowSlider() {
			return (bool) interceptor.Invoke("showSlider", "showSlider() const", typeof(bool));
		}
		/// <remarks>
		///  Sets the spacing of tickmarks for the slider.
		/// <param> name="minor" Minor tickmark separation.
		/// </param><param> name="major" Major tickmark separation.
		///      </param></remarks>		<short>    Sets the spacing of tickmarks for the slider.</short>
		public void SetSteps(int minor, int major) {
			interceptor.Invoke("setSteps$$", "setSteps(int, int)", typeof(void), typeof(int), minor, typeof(int), major);
		}
		/// <remarks>
		///  Returns a size which fits the contents of the control.
		/// </remarks>		<return> the preferred size necessary to show the control
		///      </return>
		/// 		<short>    Returns a size which fits the contents of the control.</short>
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		/// <remarks>
		///      </remarks>		<return> the slider widget.
		/// </return>
		/// 		<short>   </short>
		protected QSlider Slider() {
			return (QSlider) interceptor.Invoke("slider", "slider() const", typeof(QSlider));
		}
		/// <remarks>
		///  Call this function whenever you change something in the geometry
		///  of your KNumInput child.
		///      </remarks>		<short>    Call this function whenever you change something in the geometry  of your KNumInput child.</short>
		protected void Layout(bool deep) {
			interceptor.Invoke("layout$", "layout(bool)", typeof(void), typeof(bool), deep);
		}
		/// <remarks>
		///  You need to overwrite this method and implement your layout
		///  calculations there.
		///  See KIntNumInput.DoLayout and KDoubleNumInput.DoLayout implementation
		///  for details.
		///      </remarks>		<short>    You need to overwrite this method and implement your layout  calculations there.</short>
		[SmokeMethod("doLayout()")]
		protected abstract void DoLayout();
		protected new IKNumInputSignals Emit {
			get { return (IKNumInputSignals) Q_EMIT; }
		}
	}

	public interface IKNumInputSignals : IQWidgetSignals {
	}
}
