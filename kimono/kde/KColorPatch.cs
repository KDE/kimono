//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  The KColorPatch widget is a (usually small) widget showing
	///  a selected color e. g. in the KColorDialog. It
	///  automatically handles drag and drop from and on the widget.
	///   See <see cref="IKColorPatchSignals"></see> for signals emitted by KColorPatch
	/// </remarks>		<short> A color displayer. </short>
	[SmokeClass("KColorPatch")]
	public class KColorPatch : QFrame, IDisposable {
 		protected KColorPatch(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KColorPatch), this);
		}
		public KColorPatch(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KColorPatch#", "KColorPatch(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public void SetColor(QColor col) {
			interceptor.Invoke("setColor#", "setColor(const QColor&)", typeof(void), typeof(QColor), col);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent pe) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), pe);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected override void DragEnterEvent(QDragEnterEvent arg1) {
			interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QDragEnterEvent*)", typeof(void), typeof(QDragEnterEvent), arg1);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected override void DropEvent(QDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
		}
		~KColorPatch() {
			interceptor.Invoke("~KColorPatch", "~KColorPatch()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KColorPatch", "~KColorPatch()", typeof(void));
		}
		protected new IKColorPatchSignals Emit {
			get { return (IKColorPatchSignals) Q_EMIT; }
		}
	}

	public interface IKColorPatchSignals : IQFrameSignals {
		[Q_SIGNAL("void colorChanged(const QColor&)")]
		void ColorChanged(QColor arg1);
	}
}
