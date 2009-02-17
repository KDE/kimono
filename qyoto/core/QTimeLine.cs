//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQTimeLineSignals"></see> for signals emitted by QTimeLine
    /// </remarks>
    [SmokeClass("QTimeLine")]
    public class QTimeLine : QObject, IDisposable {
        protected QTimeLine(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTimeLine), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTimeLine() {
            staticInterceptor = new SmokeInvocation(typeof(QTimeLine), null);
        }
        public enum State {
            NotRunning = 0,
            Paused = 1,
            Running = 2,
        }
        public enum Direction {
            Forward = 0,
            Backward = 1,
        }
        public enum CurveShape {
            EaseInCurve = 0,
            EaseOutCurve = 1,
            EaseInOutCurve = 2,
            LinearCurve = 3,
            SineCurve = 4,
            CosineCurve = 5,
        }
        [Q_PROPERTY("int", "duration")]
        public int Duration {
            get { return (int) interceptor.Invoke("duration", "duration()", typeof(int)); }
            set { interceptor.Invoke("setDuration$", "setDuration(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "updateInterval")]
        public int UpdateInterval {
            get { return (int) interceptor.Invoke("updateInterval", "updateInterval()", typeof(int)); }
            set { interceptor.Invoke("setUpdateInterval$", "setUpdateInterval(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("int", "currentTime")]
        public int CurrentTime {
            get { return (int) interceptor.Invoke("currentTime", "currentTime()", typeof(int)); }
            set { interceptor.Invoke("setCurrentTime$", "setCurrentTime(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("QTimeLine::Direction", "direction")]
        public QTimeLine.Direction direction {
            get { return (QTimeLine.Direction) interceptor.Invoke("direction", "direction()", typeof(QTimeLine.Direction)); }
            set { interceptor.Invoke("setDirection$", "setDirection(QTimeLine::Direction)", typeof(void), typeof(QTimeLine.Direction), value); }
        }
        [Q_PROPERTY("int", "loopCount")]
        public int LoopCount {
            get { return (int) interceptor.Invoke("loopCount", "loopCount()", typeof(int)); }
            set { interceptor.Invoke("setLoopCount$", "setLoopCount(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("QTimeLine::CurveShape", "curveShape")]
        public QTimeLine.CurveShape curveShape {
            get { return (QTimeLine.CurveShape) interceptor.Invoke("curveShape", "curveShape()", typeof(QTimeLine.CurveShape)); }
            set { interceptor.Invoke("setCurveShape$", "setCurveShape(QTimeLine::CurveShape)", typeof(void), typeof(QTimeLine.CurveShape), value); }
        }
        public QTimeLine(int duration, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTimeLine$#", "QTimeLine(int, QObject*)", typeof(void), typeof(int), duration, typeof(QObject), parent);
        }
        public QTimeLine(int duration) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTimeLine$", "QTimeLine(int)", typeof(void), typeof(int), duration);
        }
        public QTimeLine() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTimeLine", "QTimeLine()", typeof(void));
        }
        public QTimeLine.State state() {
            return (QTimeLine.State) interceptor.Invoke("state", "state() const", typeof(QTimeLine.State));
        }
        public int StartFrame() {
            return (int) interceptor.Invoke("startFrame", "startFrame() const", typeof(int));
        }
        public void SetStartFrame(int frame) {
            interceptor.Invoke("setStartFrame$", "setStartFrame(int)", typeof(void), typeof(int), frame);
        }
        public int EndFrame() {
            return (int) interceptor.Invoke("endFrame", "endFrame() const", typeof(int));
        }
        public void SetEndFrame(int frame) {
            interceptor.Invoke("setEndFrame$", "setEndFrame(int)", typeof(void), typeof(int), frame);
        }
        public void SetFrameRange(int startFrame, int endFrame) {
            interceptor.Invoke("setFrameRange$$", "setFrameRange(int, int)", typeof(void), typeof(int), startFrame, typeof(int), endFrame);
        }
        public int CurrentFrame() {
            return (int) interceptor.Invoke("currentFrame", "currentFrame() const", typeof(int));
        }
        public double CurrentValue() {
            return (double) interceptor.Invoke("currentValue", "currentValue() const", typeof(double));
        }
        public int FrameForTime(int msec) {
            return (int) interceptor.Invoke("frameForTime$", "frameForTime(int) const", typeof(int), typeof(int), msec);
        }
        [SmokeMethod("valueForTime(int) const")]
        public virtual double ValueForTime(int msec) {
            return (double) interceptor.Invoke("valueForTime$", "valueForTime(int) const", typeof(double), typeof(int), msec);
        }
        [Q_SLOT("void start()")]
        public void Start() {
            interceptor.Invoke("start", "start()", typeof(void));
        }
        [Q_SLOT("void resume()")]
        public void Resume() {
            interceptor.Invoke("resume", "resume()", typeof(void));
        }
        [Q_SLOT("void stop()")]
        public void Stop() {
            interceptor.Invoke("stop", "stop()", typeof(void));
        }
        [Q_SLOT("void setPaused(bool)")]
        public void SetPaused(bool paused) {
            interceptor.Invoke("setPaused$", "setPaused(bool)", typeof(void), typeof(bool), paused);
        }
        [Q_SLOT("void setCurrentTime(int)")]
        public void SetCurrentTime(int msec) {
            interceptor.Invoke("setCurrentTime$", "setCurrentTime(int)", typeof(void), typeof(int), msec);
        }
        [Q_SLOT("void toggleDirection()")]
        public void ToggleDirection() {
            interceptor.Invoke("toggleDirection", "toggleDirection()", typeof(void));
        }
        [SmokeMethod("timerEvent(QTimerEvent*)")]
        protected override void TimerEvent(QTimerEvent arg1) {
            interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), arg1);
        }
        ~QTimeLine() {
            interceptor.Invoke("~QTimeLine", "~QTimeLine()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTimeLine", "~QTimeLine()", typeof(void));
        }
        public event SlotFunc<double> SignalValueChanged {
            add { QObject.Connect(this, SIGNAL("valueChanged(qreal)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("valueChanged(qreal)"), value); }
        }
        public event SlotFunc<int> SignalFrameChanged {
            add { QObject.Connect(this, SIGNAL("frameChanged(int)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("frameChanged(int)"), value); }
        }
        public event SlotFunc<QTimeLine.State> SignalStateChanged {
            add { QObject.Connect(this, SIGNAL("stateChanged(QTimeLine::State)"), value); }
            remove { QObject.Disconnect(this, SIGNAL("stateChanged(QTimeLine::State)"), value); }
        }
        public event SlotFunc SignalFinished {
            add { QObject.Connect(this, SIGNAL("finished()"), value); }
            remove { QObject.Disconnect(this, SIGNAL("finished()"), value); }
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQTimeLineSignals Emit {
            get { return (IQTimeLineSignals) Q_EMIT; }
        }
    }

    public interface IQTimeLineSignals : IQObjectSignals {
        [Q_SIGNAL("void valueChanged(qreal)")]
        void ValueChanged(double x);
        [Q_SIGNAL("void frameChanged(int)")]
        void FrameChanged(int arg1);
        [Q_SIGNAL("void stateChanged(QTimeLine::State)")]
        void StateChanged(QTimeLine.State newState);
        [Q_SIGNAL("void finished()")]
        void Finished();
    }
}
