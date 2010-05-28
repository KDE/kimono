namespace Qyoto {

	using System;
	using System.Runtime.InteropServices;

	[SmokeClass("QAbstractTextDocumentLayout")]
	internal class QAbstractTextDocumentLayoutInternal : QAbstractTextDocumentLayout {
		[DllImport("qyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr QAbstractTextDocumentLayoutBlockBoundingRect(IntPtr obj, IntPtr block);
		
		[DllImport("qyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr QAbstractTextDocumentLayoutDocumentSize(IntPtr obj);
		
		[DllImport("qyoto", CharSet=CharSet.Ansi)]
		static extern IntPtr QAbstractTextDocumentLayoutFrameBoundingRect(IntPtr obj, IntPtr frame);
		
		[DllImport("qyoto", CharSet=CharSet.Ansi)]
		static extern int QAbstractTextDocumentLayoutHitTest(IntPtr obj, IntPtr point, int accuracy);
		
		[DllImport("qyoto", CharSet=CharSet.Ansi)]
		static extern int QAbstractTextDocumentLayoutPageCount(IntPtr obj);
		
		protected QAbstractTextDocumentLayoutInternal(Type dummy) : base((Type) null) {}
		
		public override QRectF BlockBoundingRect (QTextBlock block) {
			GCHandle ret = (GCHandle) QAbstractTextDocumentLayoutBlockBoundingRect((IntPtr) GCHandle.Alloc(this), 
												(IntPtr) GCHandle.Alloc(block));
			QRectF r = (QRectF) ret.Target;
			ret.SynchronizedFree();
			return r;
		}
		
		public override QSizeF DocumentSize () {
			GCHandle ret = (GCHandle) QAbstractTextDocumentLayoutDocumentSize((IntPtr) GCHandle.Alloc(this));
			QSizeF s = (QSizeF) ret.Target;
			ret.SynchronizedFree();
			return s;
		}
		
		public override QRectF FrameBoundingRect (QTextFrame frame) {
			GCHandle ret = (GCHandle) QAbstractTextDocumentLayoutFrameBoundingRect((IntPtr) GCHandle.Alloc(this), 
												(IntPtr) GCHandle.Alloc(frame));
			QRectF r = (QRectF) ret.Target;
			ret.SynchronizedFree();
			return r;
		}
		
		public override int HitTest (QPointF point, HitTestAccuracy accuracy) {
			return QAbstractTextDocumentLayoutHitTest((IntPtr) GCHandle.Alloc(this), 
									(IntPtr) GCHandle.Alloc(point), (int) accuracy);
		}
		
		public override int PageCount () {
			return QAbstractTextDocumentLayoutPageCount((IntPtr) GCHandle.Alloc(this));
		}
		
		protected override void DocumentChanged (int from, int charsRemoved, int charsAdded) {}
	}
}
