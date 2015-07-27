//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  @class KPlotPoint
    /// </remarks>        <short> Encapsulates a point in the plot.  A KPlotPoint consists of X and Y coordinates (in Data units),  an optional label string, and an optional bar-width,  The bar-width is only used for plots of type KPlotObject.Bars,  and it allows the width of each bar to be set manually.  If   bar-widths are omitted, then the widths will be set automatically,   based on the halfway-mark between adjacent points.  </short>
    [SmokeClass("KPlotPoint")]
    public class KPlotPoint : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected KPlotPoint(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KPlotPoint), this);
        }
        /// <remarks>
        ///  Default constructor.
        ///      </remarks>        <short>    Default constructor.</short>
        public KPlotPoint() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotPoint", "KPlotPoint()", typeof(void));
        }
        /// <remarks>
        ///  Constructor.  Sets the KPlotPoint according to the given arguments
        /// <param> name="x" the X-position for the point, in Data units
        /// </param><param> name="y" the Y-position for the point, in Data units
        /// </param><param> name="label" the label string for the point.  If the string 
        ///  is defined, the point will be labeled in the plot.
        /// </param><param> name="width" the bar width to use for this point (only used for
        ///  plots of type KPlotObject.Bars)
        ///      </param></remarks>        <short>    Constructor.</short>
        public KPlotPoint(double x, double y, string label, double width) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotPoint$$$$", "KPlotPoint(double, double, const QString&, double)", typeof(void), typeof(double), x, typeof(double), y, typeof(string), label, typeof(double), width);
        }
        public KPlotPoint(double x, double y, string label) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotPoint$$$", "KPlotPoint(double, double, const QString&)", typeof(void), typeof(double), x, typeof(double), y, typeof(string), label);
        }
        public KPlotPoint(double x, double y) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotPoint$$", "KPlotPoint(double, double)", typeof(void), typeof(double), x, typeof(double), y);
        }
        /// <remarks>
        ///  Constructor.  Sets the KPlotPoint according to the given arguments
        /// <param> name="p" the position for the point, in Data units
        /// </param><param> name="label" the label string for the point.  If the string 
        ///  is defined, the point will be labeled in the plot.
        /// </param><param> name="width" the bar width to use for this point (only used for
        ///  plots of type KPlotObject.Bars)
        ///      </param></remarks>        <short>    Constructor.</short>
        public KPlotPoint(QPointF p, string label, double width) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotPoint#$$", "KPlotPoint(const QPointF&, const QString&, double)", typeof(void), typeof(QPointF), p, typeof(string), label, typeof(double), width);
        }
        public KPlotPoint(QPointF p, string label) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotPoint#$", "KPlotPoint(const QPointF&, const QString&)", typeof(void), typeof(QPointF), p, typeof(string), label);
        }
        public KPlotPoint(QPointF p) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KPlotPoint#", "KPlotPoint(const QPointF&)", typeof(void), typeof(QPointF), p);
        }
        /// <remarks>
        /// </remarks>        <return> the position of the point, in data units
        ///      </return>
        ///         <short>   </short>
        public QPointF Position() {
            return (QPointF) interceptor.Invoke("position", "position() const", typeof(QPointF));
        }
        /// <remarks>
        ///  Set the position of the point, in data units
        /// <param> name="pos" the new position for the point.
        ///      </param></remarks>        <short>    Set the position of the point, in data units </short>
        public void SetPosition(QPointF pos) {
            interceptor.Invoke("setPosition#", "setPosition(const QPointF&)", typeof(void), typeof(QPointF), pos);
        }
        /// <remarks>
        /// </remarks>        <return> the X-position of the point, in data units
        ///      </return>
        ///         <short>   </short>
        public double X() {
            return (double) interceptor.Invoke("x", "x() const", typeof(double));
        }
        /// <remarks>
        ///  Set the X-position of the point, in Data units
        ///      </remarks>        <short>    Set the X-position of the point, in Data units      </short>
        public void SetX(double x) {
            interceptor.Invoke("setX$", "setX(double)", typeof(void), typeof(double), x);
        }
        /// <remarks>
        /// </remarks>        <return> the Y-position of the point, in data units
        ///      </return>
        ///         <short>   </short>
        public double Y() {
            return (double) interceptor.Invoke("y", "y() const", typeof(double));
        }
        /// <remarks>
        ///  Set the Y-position of the point, in Data units
        ///      </remarks>        <short>    Set the Y-position of the point, in Data units      </short>
        public void SetY(double y) {
            interceptor.Invoke("setY$", "setY(double)", typeof(void), typeof(double), y);
        }
        /// <remarks>
        /// </remarks>        <return> the label for the point
        ///      </return>
        ///         <short>   </short>
        public string Label() {
            return (string) interceptor.Invoke("label", "label() const", typeof(string));
        }
        /// <remarks>
        ///  Set the label for the point
        ///      </remarks>        <short>    Set the label for the point      </short>
        public void SetLabel(string label) {
            interceptor.Invoke("setLabel$", "setLabel(const QString&)", typeof(void), typeof(string), label);
        }
        /// <remarks>
        /// </remarks>        <return> the bar-width for the point
        ///      </return>
        ///         <short>   </short>
        public double BarWidth() {
            return (double) interceptor.Invoke("barWidth", "barWidth() const", typeof(double));
        }
        /// <remarks>
        ///  Set the bar-width for the point
        ///      </remarks>        <short>    Set the bar-width for the point      </short>
        public void SetBarWidth(double w) {
            interceptor.Invoke("setBarWidth$", "setBarWidth(double)", typeof(void), typeof(double), w);
        }
        ~KPlotPoint() {
            interceptor.Invoke("~KPlotPoint", "~KPlotPoint()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~KPlotPoint", "~KPlotPoint()", typeof(void));
        }
    }
}