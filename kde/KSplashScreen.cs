//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///   This class is based on QSplashScreen and exists solely to make
    ///   splash screens obey KDE's Xinerama settings.
    ///   For documentation on how to use the class, see the documentation
    ///   for QSplashScreen.
    /// </remarks>        <author> Chris Howells (howells@kde.org)
    ///  </author>
    ///         <short> %KDE splash screen.</short>
    [SmokeClass("KSplashScreen")]
    public class KSplashScreen : QSplashScreen, IDisposable {
        protected KSplashScreen(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KSplashScreen), this);
        }
        /// <remarks>
        ///   Constructs a splash screen.
        ///    </remarks>        <short>     Constructs a splash screen.</short>
        public KSplashScreen(QPixmap pixmap, uint f) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KSplashScreen#$", "KSplashScreen(const QPixmap&, Qt::WindowFlags)", typeof(void), typeof(QPixmap), pixmap, typeof(uint), f);
        }
        public KSplashScreen(QPixmap pixmap) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KSplashScreen#", "KSplashScreen(const QPixmap&)", typeof(void), typeof(QPixmap), pixmap);
        }
        ~KSplashScreen() {
            interceptor.Invoke("~KSplashScreen", "~KSplashScreen()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KSplashScreen", "~KSplashScreen()", typeof(void));
        }
        protected new IKSplashScreenSignals Emit {
            get { return (IKSplashScreenSignals) Q_EMIT; }
        }
    }

    public interface IKSplashScreenSignals : IQSplashScreenSignals {
    }
}
