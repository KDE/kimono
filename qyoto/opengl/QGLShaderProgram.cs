//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QGLShaderProgram")]
    public class QGLShaderProgram : QObject, IDisposable {
        protected QGLShaderProgram(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QGLShaderProgram), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QGLShaderProgram() {
            staticInterceptor = new SmokeInvocation(typeof(QGLShaderProgram), null);
        }
        // void setAttributeValue(int arg1,GLfloat arg2); >>>> NOT CONVERTED
        // void setAttributeValue(int arg1,GLfloat arg2,GLfloat arg3); >>>> NOT CONVERTED
        // void setAttributeValue(int arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4); >>>> NOT CONVERTED
        // void setAttributeValue(int arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4,GLfloat arg5); >>>> NOT CONVERTED
        // void setAttributeValue(int arg1,const GLfloat* arg2,int arg3,int arg4); >>>> NOT CONVERTED
        // void setAttributeValue(const char* arg1,GLfloat arg2); >>>> NOT CONVERTED
        // void setAttributeValue(const char* arg1,GLfloat arg2,GLfloat arg3); >>>> NOT CONVERTED
        // void setAttributeValue(const char* arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4); >>>> NOT CONVERTED
        // void setAttributeValue(const char* arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4,GLfloat arg5); >>>> NOT CONVERTED
        // void setAttributeValue(const char* arg1,const GLfloat* arg2,int arg3,int arg4); >>>> NOT CONVERTED
        // void setAttributeArray(int arg1,const GLfloat* arg2,int arg3,int arg4); >>>> NOT CONVERTED
        // void setAttributeArray(int arg1,const GLfloat* arg2,int arg3); >>>> NOT CONVERTED
        // void setAttributeArray(const char* arg1,const GLfloat* arg2,int arg3,int arg4); >>>> NOT CONVERTED
        // void setAttributeArray(const char* arg1,const GLfloat* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,GLfloat arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,GLfloat arg2,GLfloat arg3); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4,GLfloat arg5); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<2,2,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<2,3,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<2,4,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<3,2,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<3,3,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<3,4,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<4,2,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const QGenericMatrix<4,3,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(int arg1,const GLfloat value[4][4] arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,GLfloat arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,GLfloat arg2,GLfloat arg3); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,GLfloat arg2,GLfloat arg3,GLfloat arg4,GLfloat arg5); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<2,2,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<2,3,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<2,4,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<3,2,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<3,3,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<3,4,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<4,2,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const QGenericMatrix<4,3,qreal>& arg2); >>>> NOT CONVERTED
        // void setUniformValue(const char* arg1,const GLfloat value[4][4] arg2); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const GLfloat* arg2,int arg3,int arg4); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const GLint* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const GLuint* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<2,2,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<2,3,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<2,4,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<3,2,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<3,3,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<3,4,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<4,2,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(int arg1,const QGenericMatrix<4,3,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const GLfloat* arg2,int arg3,int arg4); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const GLint* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const GLuint* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<2,2,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<2,3,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<2,4,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<3,2,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<3,3,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<3,4,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<4,2,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        // void setUniformValueArray(const char* arg1,const QGenericMatrix<4,3,qreal>* arg2,int arg3); >>>> NOT CONVERTED
        public QGLShaderProgram(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGLShaderProgram#", "QGLShaderProgram(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QGLShaderProgram() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGLShaderProgram", "QGLShaderProgram()", typeof(void));
        }
        public QGLShaderProgram(QGLContext context, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGLShaderProgram##", "QGLShaderProgram(const QGLContext*, QObject*)", typeof(void), typeof(QGLContext), context, typeof(QObject), parent);
        }
        public QGLShaderProgram(QGLContext context) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QGLShaderProgram#", "QGLShaderProgram(const QGLContext*)", typeof(void), typeof(QGLContext), context);
        }
        public bool AddShader(QGLShader shader) {
            return (bool) interceptor.Invoke("addShader#", "addShader(QGLShader*)", typeof(bool), typeof(QGLShader), shader);
        }
        public void RemoveShader(QGLShader shader) {
            interceptor.Invoke("removeShader#", "removeShader(QGLShader*)", typeof(void), typeof(QGLShader), shader);
        }
        public List<QGLShader> Shaders() {
            return (List<QGLShader>) interceptor.Invoke("shaders", "shaders() const", typeof(List<QGLShader>));
        }
        public bool AddShaderFromSourceCode(uint type, string source) {
            return (bool) interceptor.Invoke("addShaderFromSourceCode$$", "addShaderFromSourceCode(QGLShader::ShaderType, const char*)", typeof(bool), typeof(uint), type, typeof(string), source);
        }
        public bool AddShaderFromSourceCode(uint type, QByteArray source) {
            return (bool) interceptor.Invoke("addShaderFromSourceCode$#", "addShaderFromSourceCode(QGLShader::ShaderType, const QByteArray&)", typeof(bool), typeof(uint), type, typeof(QByteArray), source);
        }
        public bool AddShaderFromSourceFile(uint type, string fileName) {
            return (bool) interceptor.Invoke("addShaderFromSourceFile$$", "addShaderFromSourceFile(QGLShader::ShaderType, const QString&)", typeof(bool), typeof(uint), type, typeof(string), fileName);
        }
        public void RemoveAllShaders() {
            interceptor.Invoke("removeAllShaders", "removeAllShaders()", typeof(void));
        }
        [SmokeMethod("link()")]
        public virtual bool Link() {
            return (bool) interceptor.Invoke("link", "link()", typeof(bool));
        }
        public bool IsLinked() {
            return (bool) interceptor.Invoke("isLinked", "isLinked() const", typeof(bool));
        }
        public string Log() {
            return (string) interceptor.Invoke("log", "log() const", typeof(string));
        }
        public bool Bind() {
            return (bool) interceptor.Invoke("bind", "bind()", typeof(bool));
        }
        public void Release() {
            interceptor.Invoke("release", "release()", typeof(void));
        }
        public uint ProgramId() {
            return (uint) interceptor.Invoke("programId", "programId() const", typeof(uint));
        }
        public void BindAttributeLocation(string name, int location) {
            interceptor.Invoke("bindAttributeLocation$$", "bindAttributeLocation(const char*, int)", typeof(void), typeof(string), name, typeof(int), location);
        }
        public void BindAttributeLocation(QByteArray name, int location) {
            interceptor.Invoke("bindAttributeLocation#$", "bindAttributeLocation(const QByteArray&, int)", typeof(void), typeof(QByteArray), name, typeof(int), location);
        }
        public int AttributeLocation(string name) {
            return (int) interceptor.Invoke("attributeLocation$", "attributeLocation(const char*) const", typeof(int), typeof(string), name);
        }
        public int AttributeLocation(QByteArray name) {
            return (int) interceptor.Invoke("attributeLocation#", "attributeLocation(const QByteArray&) const", typeof(int), typeof(QByteArray), name);
        }
        public void SetAttributeValue(int location, QVector2D value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(int, const QVector2D&)", typeof(void), typeof(int), location, typeof(QVector2D), value);
        }
        public void SetAttributeValue(int location, QVector3D value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(int, const QVector3D&)", typeof(void), typeof(int), location, typeof(QVector3D), value);
        }
        public void SetAttributeValue(int location, QVector4D value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(int, const QVector4D&)", typeof(void), typeof(int), location, typeof(QVector4D), value);
        }
        public void SetAttributeValue(int location, QColor value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(int, const QColor&)", typeof(void), typeof(int), location, typeof(QColor), value);
        }
        public void SetAttributeValue(string name, QVector2D value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(const char*, const QVector2D&)", typeof(void), typeof(string), name, typeof(QVector2D), value);
        }
        public void SetAttributeValue(string name, QVector3D value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(const char*, const QVector3D&)", typeof(void), typeof(string), name, typeof(QVector3D), value);
        }
        public void SetAttributeValue(string name, QVector4D value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(const char*, const QVector4D&)", typeof(void), typeof(string), name, typeof(QVector4D), value);
        }
        public void SetAttributeValue(string name, QColor value) {
            interceptor.Invoke("setAttributeValue$#", "setAttributeValue(const char*, const QColor&)", typeof(void), typeof(string), name, typeof(QColor), value);
        }
        public void SetAttributeArray(int location, QVector2D values, int stride) {
            interceptor.Invoke("setAttributeArray$#$", "setAttributeArray(int, const QVector2D*, int)", typeof(void), typeof(int), location, typeof(QVector2D), values, typeof(int), stride);
        }
        public void SetAttributeArray(int location, QVector2D values) {
            interceptor.Invoke("setAttributeArray$#", "setAttributeArray(int, const QVector2D*)", typeof(void), typeof(int), location, typeof(QVector2D), values);
        }
        public void SetAttributeArray(int location, QVector3D values, int stride) {
            interceptor.Invoke("setAttributeArray$#$", "setAttributeArray(int, const QVector3D*, int)", typeof(void), typeof(int), location, typeof(QVector3D), values, typeof(int), stride);
        }
        public void SetAttributeArray(int location, QVector3D values) {
            interceptor.Invoke("setAttributeArray$#", "setAttributeArray(int, const QVector3D*)", typeof(void), typeof(int), location, typeof(QVector3D), values);
        }
        public void SetAttributeArray(int location, QVector4D values, int stride) {
            interceptor.Invoke("setAttributeArray$#$", "setAttributeArray(int, const QVector4D*, int)", typeof(void), typeof(int), location, typeof(QVector4D), values, typeof(int), stride);
        }
        public void SetAttributeArray(int location, QVector4D values) {
            interceptor.Invoke("setAttributeArray$#", "setAttributeArray(int, const QVector4D*)", typeof(void), typeof(int), location, typeof(QVector4D), values);
        }
        public void SetAttributeArray(string name, QVector2D values, int stride) {
            interceptor.Invoke("setAttributeArray$#$", "setAttributeArray(const char*, const QVector2D*, int)", typeof(void), typeof(string), name, typeof(QVector2D), values, typeof(int), stride);
        }
        public void SetAttributeArray(string name, QVector2D values) {
            interceptor.Invoke("setAttributeArray$#", "setAttributeArray(const char*, const QVector2D*)", typeof(void), typeof(string), name, typeof(QVector2D), values);
        }
        public void SetAttributeArray(string name, QVector3D values, int stride) {
            interceptor.Invoke("setAttributeArray$#$", "setAttributeArray(const char*, const QVector3D*, int)", typeof(void), typeof(string), name, typeof(QVector3D), values, typeof(int), stride);
        }
        public void SetAttributeArray(string name, QVector3D values) {
            interceptor.Invoke("setAttributeArray$#", "setAttributeArray(const char*, const QVector3D*)", typeof(void), typeof(string), name, typeof(QVector3D), values);
        }
        public void SetAttributeArray(string name, QVector4D values, int stride) {
            interceptor.Invoke("setAttributeArray$#$", "setAttributeArray(const char*, const QVector4D*, int)", typeof(void), typeof(string), name, typeof(QVector4D), values, typeof(int), stride);
        }
        public void SetAttributeArray(string name, QVector4D values) {
            interceptor.Invoke("setAttributeArray$#", "setAttributeArray(const char*, const QVector4D*)", typeof(void), typeof(string), name, typeof(QVector4D), values);
        }
        public void EnableAttributeArray(int location) {
            interceptor.Invoke("enableAttributeArray$", "enableAttributeArray(int)", typeof(void), typeof(int), location);
        }
        public void EnableAttributeArray(string name) {
            interceptor.Invoke("enableAttributeArray$", "enableAttributeArray(const char*)", typeof(void), typeof(string), name);
        }
        public void DisableAttributeArray(int location) {
            interceptor.Invoke("disableAttributeArray$", "disableAttributeArray(int)", typeof(void), typeof(int), location);
        }
        public void DisableAttributeArray(string name) {
            interceptor.Invoke("disableAttributeArray$", "disableAttributeArray(const char*)", typeof(void), typeof(string), name);
        }
        public int UniformLocation(string name) {
            return (int) interceptor.Invoke("uniformLocation$", "uniformLocation(const char*) const", typeof(int), typeof(string), name);
        }
        public int UniformLocation(QByteArray name) {
            return (int) interceptor.Invoke("uniformLocation#", "uniformLocation(const QByteArray&) const", typeof(int), typeof(QByteArray), name);
        }
        public void SetUniformValue(int location, int value) {
            interceptor.Invoke("setUniformValue$$", "setUniformValue(int, GLint)", typeof(void), typeof(int), location, typeof(int), value);
        }
        public void SetUniformValue(int location, uint value) {
            interceptor.Invoke("setUniformValue$$", "setUniformValue(int, GLuint)", typeof(void), typeof(int), location, typeof(uint), value);
        }
        public void SetUniformValue(int location, QVector2D value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QVector2D&)", typeof(void), typeof(int), location, typeof(QVector2D), value);
        }
        public void SetUniformValue(int location, QVector3D value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QVector3D&)", typeof(void), typeof(int), location, typeof(QVector3D), value);
        }
        public void SetUniformValue(int location, QVector4D value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QVector4D&)", typeof(void), typeof(int), location, typeof(QVector4D), value);
        }
        public void SetUniformValue(int location, QColor color) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QColor&)", typeof(void), typeof(int), location, typeof(QColor), color);
        }
        public void SetUniformValue(int location, QPoint point) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QPoint&)", typeof(void), typeof(int), location, typeof(QPoint), point);
        }
        public void SetUniformValue(int location, QPointF point) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QPointF&)", typeof(void), typeof(int), location, typeof(QPointF), point);
        }
        public void SetUniformValue(int location, QSize size) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QSize&)", typeof(void), typeof(int), location, typeof(QSize), size);
        }
        public void SetUniformValue(int location, QSizeF size) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QSizeF&)", typeof(void), typeof(int), location, typeof(QSizeF), size);
        }
        public void SetUniformValue(int location, QMatrix4x4 value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QMatrix4x4&)", typeof(void), typeof(int), location, typeof(QMatrix4x4), value);
        }
        public void SetUniformValue(int location, QTransform value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(int, const QTransform&)", typeof(void), typeof(int), location, typeof(QTransform), value);
        }
        public void SetUniformValue(string name, int value) {
            interceptor.Invoke("setUniformValue$$", "setUniformValue(const char*, GLint)", typeof(void), typeof(string), name, typeof(int), value);
        }
        public void SetUniformValue(string name, uint value) {
            interceptor.Invoke("setUniformValue$$", "setUniformValue(const char*, GLuint)", typeof(void), typeof(string), name, typeof(uint), value);
        }
        public void SetUniformValue(string name, QVector2D value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QVector2D&)", typeof(void), typeof(string), name, typeof(QVector2D), value);
        }
        public void SetUniformValue(string name, QVector3D value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QVector3D&)", typeof(void), typeof(string), name, typeof(QVector3D), value);
        }
        public void SetUniformValue(string name, QVector4D value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QVector4D&)", typeof(void), typeof(string), name, typeof(QVector4D), value);
        }
        public void SetUniformValue(string name, QColor color) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QColor&)", typeof(void), typeof(string), name, typeof(QColor), color);
        }
        public void SetUniformValue(string name, QPoint point) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QPoint&)", typeof(void), typeof(string), name, typeof(QPoint), point);
        }
        public void SetUniformValue(string name, QPointF point) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QPointF&)", typeof(void), typeof(string), name, typeof(QPointF), point);
        }
        public void SetUniformValue(string name, QSize size) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QSize&)", typeof(void), typeof(string), name, typeof(QSize), size);
        }
        public void SetUniformValue(string name, QSizeF size) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QSizeF&)", typeof(void), typeof(string), name, typeof(QSizeF), size);
        }
        public void SetUniformValue(string name, QMatrix4x4 value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QMatrix4x4&)", typeof(void), typeof(string), name, typeof(QMatrix4x4), value);
        }
        public void SetUniformValue(string name, QTransform value) {
            interceptor.Invoke("setUniformValue$#", "setUniformValue(const char*, const QTransform&)", typeof(void), typeof(string), name, typeof(QTransform), value);
        }
        public void SetUniformValueArray(int location, QVector2D values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(int, const QVector2D*, int)", typeof(void), typeof(int), location, typeof(QVector2D), values, typeof(int), count);
        }
        public void SetUniformValueArray(int location, QVector3D values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(int, const QVector3D*, int)", typeof(void), typeof(int), location, typeof(QVector3D), values, typeof(int), count);
        }
        public void SetUniformValueArray(int location, QVector4D values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(int, const QVector4D*, int)", typeof(void), typeof(int), location, typeof(QVector4D), values, typeof(int), count);
        }
        public void SetUniformValueArray(int location, QMatrix4x4 values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(int, const QMatrix4x4*, int)", typeof(void), typeof(int), location, typeof(QMatrix4x4), values, typeof(int), count);
        }
        public void SetUniformValueArray(string name, QVector2D values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(const char*, const QVector2D*, int)", typeof(void), typeof(string), name, typeof(QVector2D), values, typeof(int), count);
        }
        public void SetUniformValueArray(string name, QVector3D values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(const char*, const QVector3D*, int)", typeof(void), typeof(string), name, typeof(QVector3D), values, typeof(int), count);
        }
        public void SetUniformValueArray(string name, QVector4D values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(const char*, const QVector4D*, int)", typeof(void), typeof(string), name, typeof(QVector4D), values, typeof(int), count);
        }
        public void SetUniformValueArray(string name, QMatrix4x4 values, int count) {
            interceptor.Invoke("setUniformValueArray$#$", "setUniformValueArray(const char*, const QMatrix4x4*, int)", typeof(void), typeof(string), name, typeof(QMatrix4x4), values, typeof(int), count);
        }
        ~QGLShaderProgram() {
            interceptor.Invoke("~QGLShaderProgram", "~QGLShaderProgram()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QGLShaderProgram", "~QGLShaderProgram()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        public static bool HasOpenGLShaderPrograms(QGLContext context) {
            return (bool) staticInterceptor.Invoke("hasOpenGLShaderPrograms#", "hasOpenGLShaderPrograms(const QGLContext*)", typeof(bool), typeof(QGLContext), context);
        }
        public static bool HasOpenGLShaderPrograms() {
            return (bool) staticInterceptor.Invoke("hasOpenGLShaderPrograms", "hasOpenGLShaderPrograms()", typeof(bool));
        }
        protected new IQGLShaderProgramSignals Emit {
            get { return (IQGLShaderProgramSignals) Q_EMIT; }
        }
    }

    public interface IQGLShaderProgramSignals : IQObjectSignals {
    }
}