//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQGraphicsBlurEffectSignals"></see> for signals emitted by QGraphicsBlurEffect
    /// </remarks>
    [SmokeClass("QGraphicsBlurEffect")]
    public class QGraphicsBlurEffect : QGraphicsEffect, IDisposable {
        protected QGraphicsBlurEffect(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGraphicsBlurEffect), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QGraphicsBlurEffect() {
            staticInterceptor = new SmokeInvocation(typeof(QGraphicsBlurEffect), null);
        }
        public enum BlurHint {
            PerformanceHint = 0x00,
            QualityHint = 0x01,
            AnimationHint = 0x02,
        }
        [Q_PROPERTY("qreal", "blurRadius")]
        public double BlurRadius {
            get { return (double) interceptor.Invoke("blurRadius", "blurRadius()", typeof(double)); }
            set { interceptor.Invoke("setBlurRadius$", "setBlurRadius(qreal)", typeof(void), typeof(double), value); }
        }
        [Q_PROPERTY("QGraphicsBlurEffect::BlurHints", "blurHints")]
        public uint BlurHints {
            get { return (uint) interceptor.Invoke("blurHints", "blurHints()", typeof(uint)); }
            set { interceptor.Invoke("setBlurHints$", "setBlurHints(QGraphicsBlurEffect::BlurHints)", typeof(void), typeof(uint), value); }
        }
        public QGraphicsBlurEffect(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsBlurEffect#", "QGraphicsBlurEffect(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QGraphicsBlurEffect() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGraphicsBlurEffect", "QGraphicsBlurEffect()", typeof(void));
        }
        [SmokeMethod("boundingRectFor(const QRectF&) const")]
        public override QRectF BoundingRectFor(QRectF rect) {
            return (QRectF) interceptor.Invoke("boundingRectFor#", "boundingRectFor(const QRectF&) const", typeof(QRectF), typeof(QRectF), rect);
        }
        [Q_SLOT("void setBlurRadius(qreal)")]
        public void SetBlurRadius(double blurRadius) {
            interceptor.Invoke("setBlurRadius$", "setBlurRadius(qreal)", typeof(void), typeof(double), blurRadius);
        }
        [Q_SLOT("void setBlurHints(BlurHints)")]
        public void SetBlurHints(uint hints) {
            interceptor.Invoke("setBlurHints$", "setBlurHints(QGraphicsBlurEffect::BlurHints)", typeof(void), typeof(uint), hints);
        }
        [SmokeMethod("draw(QPainter*)")]
        protected override void Draw(QPainter painter) {
            interceptor.Invoke("draw#", "draw(QPainter*)", typeof(void), typeof(QPainter), painter);
        }
        ~QGraphicsBlurEffect() {
            interceptor.Invoke("~QGraphicsBlurEffect", "~QGraphicsBlurEffect()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QGraphicsBlurEffect", "~QGraphicsBlurEffect()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQGraphicsBlurEffectSignals Emit {
            get { return (IQGraphicsBlurEffectSignals) Q_EMIT; }
        }
    }

    public interface IQGraphicsBlurEffectSignals : IQGraphicsEffectSignals {
        [Q_SIGNAL("void blurRadiusChanged(qreal)")]
        void BlurRadiusChanged(double blurRadius);
        [Q_SIGNAL("void blurHintsChanged(BlurHints)")]
        void BlurHintsChanged(uint hints);
    }
}