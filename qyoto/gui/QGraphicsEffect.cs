//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQGraphicsEffectSignals"></see> for signals emitted by QGraphicsEffect
    /// </remarks>
    [SmokeClass("QGraphicsEffect")]
    public abstract class QGraphicsEffect : QObject {
        protected QGraphicsEffect(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGraphicsEffect), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QGraphicsEffect() {
            staticInterceptor = new SmokeInvocation(typeof(QGraphicsEffect), null);
        }
        public enum ChangeFlag {
            SourceAttached = 0x1,
            SourceDetached = 0x2,
            SourceBoundingRectChanged = 0x4,
            SourceInvalidated = 0x8,
        }
        public enum PixmapPadMode {
            NoPad = 0,
            PadToTransparentBorder = 1,
            PadToEffectiveBoundingRect = 2,
        }
        [Q_PROPERTY("bool", "enabled")]
        public bool Enabled {
            get { return (bool) interceptor.Invoke("isEnabled", "isEnabled()", typeof(bool)); }
            set { interceptor.Invoke("setEnabled$", "setEnabled(bool)", typeof(void), typeof(bool), value); }
        }
        // QGraphicsEffectSource* source(); >>>> NOT CONVERTED
        // QGraphicsEffect* QGraphicsEffect(QGraphicsEffectPrivate& arg1,QObject* arg2); >>>> NOT CONVERTED
        // QGraphicsEffect* QGraphicsEffect(QGraphicsEffectPrivate& arg1); >>>> NOT CONVERTED
        public QGraphicsEffect(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsEffect#", "QGraphicsEffect(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QGraphicsEffect() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsEffect", "QGraphicsEffect()", typeof(void));
        }
        [SmokeMethod("boundingRectFor(const QRectF&) const")]
        public virtual QRectF BoundingRectFor(QRectF sourceRect) {
            return (QRectF) interceptor.Invoke("boundingRectFor#", "boundingRectFor(const QRectF&) const", typeof(QRectF), typeof(QRectF), sourceRect);
        }
        public QRectF BoundingRect() {
            return (QRectF) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRectF));
        }
        [Q_SLOT("void setEnabled(bool)")]
        public void SetEnabled(bool enable) {
            interceptor.Invoke("setEnabled$", "setEnabled(bool)", typeof(void), typeof(bool), enable);
        }
        [Q_SLOT("void update()")]
        public void Update() {
            interceptor.Invoke("update", "update()", typeof(void));
        }
        [SmokeMethod("draw(QPainter*)")]
        protected abstract void Draw(QPainter painter);
        [SmokeMethod("sourceChanged(QGraphicsEffect::ChangeFlags)")]
        protected virtual void SourceChanged(uint flags) {
            interceptor.Invoke("sourceChanged$", "sourceChanged(QGraphicsEffect::ChangeFlags)", typeof(void), typeof(uint), flags);
        }
        protected void UpdateBoundingRect() {
            interceptor.Invoke("updateBoundingRect", "updateBoundingRect()", typeof(void));
        }
        protected bool SourceIsPixmap() {
            return (bool) interceptor.Invoke("sourceIsPixmap", "sourceIsPixmap() const", typeof(bool));
        }
        protected QRectF SourceBoundingRect(Qt.CoordinateSystem system) {
            return (QRectF) interceptor.Invoke("sourceBoundingRect$", "sourceBoundingRect(Qt::CoordinateSystem) const", typeof(QRectF), typeof(Qt.CoordinateSystem), system);
        }
        protected QRectF SourceBoundingRect() {
            return (QRectF) interceptor.Invoke("sourceBoundingRect", "sourceBoundingRect() const", typeof(QRectF));
        }
        protected void DrawSource(QPainter painter) {
            interceptor.Invoke("drawSource#", "drawSource(QPainter*)", typeof(void), typeof(QPainter), painter);
        }
        protected QPixmap SourcePixmap(Qt.CoordinateSystem system, QPoint offset, QGraphicsEffect.PixmapPadMode mode) {
            return (QPixmap) interceptor.Invoke("sourcePixmap$#$", "sourcePixmap(Qt::CoordinateSystem, QPoint*, QGraphicsEffect::PixmapPadMode) const", typeof(QPixmap), typeof(Qt.CoordinateSystem), system, typeof(QPoint), offset, typeof(QGraphicsEffect.PixmapPadMode), mode);
        }
        protected QPixmap SourcePixmap(Qt.CoordinateSystem system, QPoint offset) {
            return (QPixmap) interceptor.Invoke("sourcePixmap$#", "sourcePixmap(Qt::CoordinateSystem, QPoint*) const", typeof(QPixmap), typeof(Qt.CoordinateSystem), system, typeof(QPoint), offset);
        }
        protected QPixmap SourcePixmap(Qt.CoordinateSystem system) {
            return (QPixmap) interceptor.Invoke("sourcePixmap$", "sourcePixmap(Qt::CoordinateSystem) const", typeof(QPixmap), typeof(Qt.CoordinateSystem), system);
        }
        protected QPixmap SourcePixmap() {
            return (QPixmap) interceptor.Invoke("sourcePixmap", "sourcePixmap() const", typeof(QPixmap));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQGraphicsEffectSignals Emit {
            get { return (IQGraphicsEffectSignals) Q_EMIT; }
        }
    }

    public interface IQGraphicsEffectSignals : IQObjectSignals {
        [Q_SIGNAL("void enabledChanged(bool)")]
        void EnabledChanged(bool enabled);
    }
}