//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  @class GLApplet plasma/glapplet.h <Plasma/GLApplet>
    /// </remarks>        <short> Plasma Applet that is fully rendered using OpengGL.</short>
    [SmokeClass("Plasma::GLApplet")]
    public class GLApplet : Plasma.Applet, IDisposable {
        protected GLApplet(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(GLApplet), this);
        }
        /// <remarks>
        ///  @arg parent the QGraphicsItem this applet is parented to
        ///  @arg serviceId the name of the .desktop file containing the
        ///       information about the widget
        ///  @arg appletId a unique id used to differentiate between multiple
        ///       instances of the same Applet type
        ///          </remarks>        <short>    @arg parent the QGraphicsItem this applet is parented to  @arg serviceId the name of the .</short>
        public GLApplet(IQGraphicsItem parent, string serviceId, int appletId) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("GLApplet#$$", "GLApplet(QGraphicsItem*, const QString&, int)", typeof(void), typeof(IQGraphicsItem), parent, typeof(string), serviceId, typeof(int), appletId);
        }
        /// <remarks>
        ///  This constructor is to be used with the plugin loading systems
        ///  found in KPluginInfo and KService. The argument list is expected
        ///  to have two elements: the KService service ID for the desktop entry
        ///  and an applet ID which must be a base 10 number.
        ///  @arg parent a QObject parent; you probably want to pass in 0
        ///  @arg args a list of strings containing two entries: the service id
        ///       and the applet id
        ///          </remarks>        <short>    This constructor is to be used with the plugin loading systems  found in KPluginInfo and KService.</short>
        public GLApplet(QObject parent, List<QVariant> args) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("GLApplet#?", "GLApplet(QObject*, const QList<QVariant>&)", typeof(void), typeof(QObject), parent, typeof(List<QVariant>), args);
        }
        public uint BindTexture(QImage image, int target) {
            return (uint) interceptor.Invoke("bindTexture#$", "bindTexture(const QImage&, GLenum)", typeof(uint), typeof(QImage), image, typeof(int), target);
        }
        public uint BindTexture(QImage image) {
            return (uint) interceptor.Invoke("bindTexture#", "bindTexture(const QImage&)", typeof(uint), typeof(QImage), image);
        }
        public void DeleteTexture(uint texture_id) {
            interceptor.Invoke("deleteTexture$", "deleteTexture(GLuint)", typeof(void), typeof(uint), texture_id);
        }
        /// <remarks>
        ///  Reimplement this method to render using OpenGL. QPainter passed
        ///  to this method will always use OpenGL engine and rendering
        ///  using OpenGL api directly is supported.
        ///          </remarks>        <short>    Reimplement this method to render using OpenGL.</short>
        [SmokeMethod("paintGLInterface(QPainter*, const QStyleOptionGraphicsItem*)")]
        public virtual void PaintGLInterface(QPainter painter, QStyleOptionGraphicsItem option) {
            interceptor.Invoke("paintGLInterface##", "paintGLInterface(QPainter*, const QStyleOptionGraphicsItem*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option);
        }
        public void MakeCurrent() {
            interceptor.Invoke("makeCurrent", "makeCurrent()", typeof(void));
        }
        ~GLApplet() {
            interceptor.Invoke("~GLApplet", "~GLApplet()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~GLApplet", "~GLApplet()", typeof(void));
        }
        protected new IGLAppletSignals Emit {
            get { return (IGLAppletSignals) Q_EMIT; }
        }
    }

    public interface IGLAppletSignals : Plasma.IAppletSignals {
    }
}
