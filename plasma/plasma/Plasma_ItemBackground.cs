//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    /// <remarks> See <see cref="IItemBackgroundSignals"></see> for signals emitted by ItemBackground
    /// </remarks>
    [SmokeClass("Plasma::ItemBackground")]
    public class ItemBackground : QGraphicsWidget, IDisposable {
        protected ItemBackground(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ItemBackground), this);
        }
        [Q_PROPERTY("QRectF", "target")]
        public QRectF Target {
            get { return (QRectF) interceptor.Invoke("target", "target()", typeof(QRectF)); }
            set { interceptor.Invoke("setTarget#", "setTarget(QRectF)", typeof(void), typeof(QRectF), value); }
        }
        [Q_PROPERTY("QGraphicsItem*", "targetItem")]
        public IQGraphicsItem TargetItem {
            get { return (IQGraphicsItem) interceptor.Invoke("targetItem", "targetItem()", typeof(IQGraphicsItem)); }
            set { interceptor.Invoke("setTargetItem#", "setTargetItem(QGraphicsItem*)", typeof(void), typeof(IQGraphicsItem), value); }
        }
        public ItemBackground(QGraphicsWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ItemBackground#", "ItemBackground(QGraphicsWidget*)", typeof(void), typeof(QGraphicsWidget), parent);
        }
        public ItemBackground() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ItemBackground", "ItemBackground()", typeof(void));
        }
        /// <remarks>
        ///  @reimp from QGraphicsWidget
        ///      </remarks>        <short>    @reimp from QGraphicsWidget      </short>
        [SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
        public override void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
            interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
        }
        /// <remarks>
        ///  @reimp from QGraphicsWidget
        ///      </remarks>        <short>    @reimp from QGraphicsWidget      </short>
        [SmokeMethod("itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)")]
        protected override QVariant ItemChange(QGraphicsItem.GraphicsItemChange change, QVariant value) {
            return (QVariant) interceptor.Invoke("itemChange$#", "itemChange(QGraphicsItem::GraphicsItemChange, const QVariant&)", typeof(QVariant), typeof(QGraphicsItem.GraphicsItemChange), change, typeof(QVariant), value);
        }
        /// <remarks>
        ///  @reimp from QObject
        ///      </remarks>        <short>    @reimp from QObject      </short>
        [SmokeMethod("eventFilter(QObject*, QEvent*)")]
        protected new virtual bool EventFilter(QObject watched, QEvent arg2) {
            return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), watched, typeof(QEvent), arg2);
        }
        /// <remarks>
        ///  @reimp from QGraphicsItem
        ///      </remarks>        <short>    @reimp from QGraphicsItem      </short>
        [SmokeMethod("sceneEventFilter(QGraphicsItem*, QEvent*)")]
        protected override bool SceneEventFilter(IQGraphicsItem watched, QEvent arg2) {
            return (bool) interceptor.Invoke("sceneEventFilter##", "sceneEventFilter(QGraphicsItem*, QEvent*)", typeof(bool), typeof(IQGraphicsItem), watched, typeof(QEvent), arg2);
        }
        /// <remarks>
        ///  @reimp from QGraphicsItem
        ///      </remarks>        <short>    @reimp from QGraphicsItem      </short>
        [SmokeMethod("resizeEvent(QGraphicsSceneResizeEvent*)")]
        protected override void ResizeEvent(QGraphicsSceneResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QGraphicsSceneResizeEvent*)", typeof(void), typeof(QGraphicsSceneResizeEvent), arg1);
        }
        ~ItemBackground() {
            interceptor.Invoke("~ItemBackground", "~ItemBackground()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ItemBackground", "~ItemBackground()", typeof(void));
        }
        protected new IItemBackgroundSignals Emit {
            get { return (IItemBackgroundSignals) Q_EMIT; }
        }
    }

    public interface IItemBackgroundSignals : IQGraphicsWidgetSignals {
        /// <remarks>
        ///  Emitted when the visual layout and appearance changes. Useful for synchronizing
        ///  content margins.
        ///      </remarks>        <short>    Emitted when the visual layout and appearance changes.</short>
        [Q_SIGNAL("void appearanceChanged()")]
        void AppearanceChanged();
        /// <remarks>
        ///  Emitted at each animation frame. Useful for synchronizing item animations
        ///      </remarks>        <short>    Emitted at each animation frame.</short>
        [Q_SIGNAL("void animationStep(qreal)")]
        void AnimationStep(double progress);
        /// <remarks>
        ///  Emitted when the target has been reached. Useful to consider this instead of
        ///  the corresponding hoverEnterEvent; 
        ///      </remarks>        <short>    Emitted when the target has been reached.</short>
        [Q_SIGNAL("void targetReached(QRectF)")]
        void TargetReached(QRectF arg1);
        /// <remarks>
        ///  Emitted when the target has been reached. Useful to consider this instead of
        ///  the corresponding hoverEnterEvent; 
        ///      </remarks>        <short>    Emitted when the target has been reached.</short>
        [Q_SIGNAL("void targetItemReached(QGraphicsItem*)")]
        void TargetItemReached(IQGraphicsItem arg1);
    }
}