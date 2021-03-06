//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  A set of methods used to work with colors.
    ///  </remarks>        <short>    A set of methods used to work with colors.</short>
    [SmokeClass("KColorUtils")]
    public class KColorUtils {
        private static SmokeInvocation staticInterceptor = null;
        static KColorUtils() {
            staticInterceptor = new SmokeInvocation(typeof(KColorUtils), null);
        }
        /// <remarks>
        ///  Calculate the luma of a color. Luma is weighted sum of gamma-adjusted
        ///  R'G'B' components of a color. The result is similar to qGray. The range
        ///  is from 0.0 (black) to 1.0 (white).
        ///  KColorUtils.Darken(), KColorUtils.Lighten() and KColorUtils.Shade()
        ///  operate on the luma of a color.
        /// </remarks>        <short>    Calculate the luma of a color.</short>
        ///         <see> http://en.wikipedia.org/wiki/Luma_(video)</see>
        public static double Luma(QColor arg1) {
            return (double) staticInterceptor.Invoke("luma#", "luma(const QColor&)", typeof(double), typeof(QColor), arg1);
        }
        /// <remarks>
        ///  Calculate the contrast ratio between two colors, according to the
        ///  W3C/WCAG2.0 algorithm, (Lmax + 0.05)/(Lmin + 0.05), where Lmax and Lmin
        ///  are the luma values of the lighter color and the darker color,
        ///  respectively.
        ///  A contrast ration of 5:1 (result == 5.0) is the minimum for "normal"
        ///  text to be considered readable (large text can go as low as 3:1). The
        ///  ratio ranges from 1:1 (result == 1.0) to 21:1 (result == 21.0).
        /// </remarks>        <short>    Calculate the contrast ratio between two colors, according to the  W3C/WCAG2.</short>
        ///         <see> KColorUtils.Luma</see>
        public static double ContrastRatio(QColor arg1, QColor arg2) {
            return (double) staticInterceptor.Invoke("contrastRatio##", "contrastRatio(const QColor&, const QColor&)", typeof(double), typeof(QColor), arg1, typeof(QColor), arg2);
        }
        /// <remarks>
        ///  Adjust the luma of a color by changing its distance from white.
        /// 
        /// <li>
        /// amount == 1.0 gives white
        /// </li>
        /// 
        /// <li>
        /// amount == 0.5 results in a color whose luma is halfway between 1.0
        ///  and that of the original color
        /// </li>
        /// 
        /// <li>
        /// amount == 0.0 gives the original color
        /// </li>
        /// 
        /// <li>
        /// amount == -1.0 gives a color that is 'twice as far from white' as
        ///  the original color, that is luma(result) == 1.0 - 2*(1.0 - luma(color))
        /// </li>
        /// <param> name="amount" factor by which to adjust the luma component of the color
        /// </param><param> name="chromaInverseGain" (optional) factor by which to adjust the chroma
        ///  component of the color; 1.0 means no change, 0.0 maximizes chroma
        /// </param></remarks>        <short>    Adjust the luma of a color by changing its distance from white.</short>
        ///         <see> KColorUtils.Shade</see>
        public static QColor Lighten(QColor arg1, double amount, double chromaInverseGain) {
            return (QColor) staticInterceptor.Invoke("lighten#$$", "lighten(const QColor&, qreal, qreal)", typeof(QColor), typeof(QColor), arg1, typeof(double), amount, typeof(double), chromaInverseGain);
        }
        public static QColor Lighten(QColor arg1, double amount) {
            return (QColor) staticInterceptor.Invoke("lighten#$", "lighten(const QColor&, qreal)", typeof(QColor), typeof(QColor), arg1, typeof(double), amount);
        }
        public static QColor Lighten(QColor arg1) {
            return (QColor) staticInterceptor.Invoke("lighten#", "lighten(const QColor&)", typeof(QColor), typeof(QColor), arg1);
        }
        /// <remarks>
        ///  Adjust the luma of a color by changing its distance from black.
        /// 
        /// <li>
        /// amount == 1.0 gives black
        /// </li>
        /// 
        /// <li>
        /// amount == 0.5 results in a color whose luma is halfway between 0.0
        ///  and that of the original color
        /// </li>
        /// 
        /// <li>
        /// amount == 0.0 gives the original color
        /// </li>
        /// 
        /// <li>
        /// amount == -1.0 gives a color that is 'twice as far from black' as
        ///  the original color, that is luma(result) == 2*luma(color)
        /// </li>
        /// <param> name="amount" factor by which to adjust the luma component of the color
        /// </param><param> name="chromaGain" (optional) factor by which to adjust the chroma
        ///  component of the color; 1.0 means no change, 0.0 minimizes chroma
        /// </param></remarks>        <short>    Adjust the luma of a color by changing its distance from black.</short>
        ///         <see> KColorUtils.Shade</see>
        public static QColor Darken(QColor arg1, double amount, double chromaGain) {
            return (QColor) staticInterceptor.Invoke("darken#$$", "darken(const QColor&, qreal, qreal)", typeof(QColor), typeof(QColor), arg1, typeof(double), amount, typeof(double), chromaGain);
        }
        public static QColor Darken(QColor arg1, double amount) {
            return (QColor) staticInterceptor.Invoke("darken#$", "darken(const QColor&, qreal)", typeof(QColor), typeof(QColor), arg1, typeof(double), amount);
        }
        public static QColor Darken(QColor arg1) {
            return (QColor) staticInterceptor.Invoke("darken#", "darken(const QColor&)", typeof(QColor), typeof(QColor), arg1);
        }
        /// <remarks>
        ///  Adjust the luma and chroma components of a color. The amount is added
        ///  to the corresponding component.
        /// <param> name="lumaAmount" amount by which to adjust the luma component of the
        ///  color; 0.0 results in no change, -1.0 turns anything black, 1.0 turns
        ///  anything white
        /// </param><param> name="chromaAmount" (optional) amount by which to adjust the chroma
        ///  component of the color; 0.0 results in no change, -1.0 minimizes chroma,
        ///  1.0 maximizes chroma
        /// </param></remarks>        <short>    Adjust the luma and chroma components of a color.</short>
        ///         <see> KColorUtils.Luma</see>
        public static QColor Shade(QColor arg1, double lumaAmount, double chromaAmount) {
            return (QColor) staticInterceptor.Invoke("shade#$$", "shade(const QColor&, qreal, qreal)", typeof(QColor), typeof(QColor), arg1, typeof(double), lumaAmount, typeof(double), chromaAmount);
        }
        public static QColor Shade(QColor arg1, double lumaAmount) {
            return (QColor) staticInterceptor.Invoke("shade#$", "shade(const QColor&, qreal)", typeof(QColor), typeof(QColor), arg1, typeof(double), lumaAmount);
        }
        /// <remarks>
        ///  Create a new color by tinting one color with another. This function is
        ///  meant for creating additional colors withing the same class (background,
        ///  foreground) from colors in a different class. Therefore when <code>amount</code>
        ///  is low, the luma of <code>base</code> is mostly preserved, while the hue and
        ///  chroma of <code>color</code> is mostly inherited.
        /// <param> name="base" color to be tinted
        /// </param><param> name="color" color with which to tint
        /// </param><param> name="amount" how strongly to tint the base; 0.0 gives <code>base</code>,
        ///  1.0 gives <code>color</code>
        ///      </param></remarks>        <short>    Create a new color by tinting one color with another.</short>
        public static QColor Tint(QColor arg1, QColor color, double amount) {
            return (QColor) staticInterceptor.Invoke("tint##$", "tint(const QColor&, const QColor&, qreal)", typeof(QColor), typeof(QColor), arg1, typeof(QColor), color, typeof(double), amount);
        }
        public static QColor Tint(QColor arg1, QColor color) {
            return (QColor) staticInterceptor.Invoke("tint##", "tint(const QColor&, const QColor&)", typeof(QColor), typeof(QColor), arg1, typeof(QColor), color);
        }
        /// <remarks>
        ///  Blend two colors into a new color by linear combination.
        ///  @code
        ///         QColor lighter = KColorUtils.Mix(myColor, Qt.White)
        ///  @endcode
        /// <param> name="c1" first color.
        /// </param><param> name="c2" second color.
        /// </param><param> name="bias" weight to be used for the mix. <code>bias</code> <= 0 gives <code>c1</code>,
        ///  <code>bias</code> >= 1 gives <code>c2.</code> <code>bias</code> == 0.5 gives a 50% blend of <code>c1</code>
        ///  and <code>c2.</code>
        ///      </param></remarks>        <short>    Blend two colors into a new color by linear combination.</short>
        public static QColor Mix(QColor c1, QColor c2, double bias) {
            return (QColor) staticInterceptor.Invoke("mix##$", "mix(const QColor&, const QColor&, qreal)", typeof(QColor), typeof(QColor), c1, typeof(QColor), c2, typeof(double), bias);
        }
        public static QColor Mix(QColor c1, QColor c2) {
            return (QColor) staticInterceptor.Invoke("mix##", "mix(const QColor&, const QColor&)", typeof(QColor), typeof(QColor), c1, typeof(QColor), c2);
        }
        /// <remarks>
        ///  Blend two colors into a new color by painting the second color over the
        ///  first using the specified composition mode.
        ///  @code
        ///         QColor white(Qt.White);
        ///         white.setAlphaF(0.5);
        ///         QColor lighter = KColorUtils.OverlayColors(myColor, white);
        ///        @endcode
        /// <param> name="base" the base color (alpha channel is ignored).
        /// </param><param> name="paint" the color to be overlayed onto the base color.
        /// </param><param> name="comp" the CompositionMode used to do the blending.
        ///      </param></remarks>        <short>    Blend two colors into a new color by painting the second color over the  first using the specified composition mode.</short>
        public static QColor OverlayColors(QColor arg1, QColor paint, QPainter.CompositionMode comp) {
            return (QColor) staticInterceptor.Invoke("overlayColors##$", "overlayColors(const QColor&, const QColor&, QPainter::CompositionMode)", typeof(QColor), typeof(QColor), arg1, typeof(QColor), paint, typeof(QPainter.CompositionMode), comp);
        }
        public static QColor OverlayColors(QColor arg1, QColor paint) {
            return (QColor) staticInterceptor.Invoke("overlayColors##", "overlayColors(const QColor&, const QColor&)", typeof(QColor), typeof(QColor), arg1, typeof(QColor), paint);
        }
    }
}
