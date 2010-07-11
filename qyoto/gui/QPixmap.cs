//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QPixmap")]
    public class QPixmap : QPaintDevice, IDisposable {
        protected QPixmap(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QPixmap), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QPixmap() {
            staticInterceptor = new SmokeInvocation(typeof(QPixmap), null);
        }
        // QPixmap* QPixmap(QPixmapData* arg1); >>>> NOT CONVERTED
        // QPixmap* QPixmap(const char** arg1); >>>> NOT CONVERTED
        //  operator QVariant(); >>>> NOT CONVERTED
        // QPixmapData* pixmapData(); >>>> NOT CONVERTED
        // QPixmapData*& data_ptr(); >>>> NOT CONVERTED
        public QPixmap() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPixmap", "QPixmap()", typeof(void));
        }
        public QPixmap(int w, int h) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPixmap$$", "QPixmap(int, int)", typeof(void), typeof(int), w, typeof(int), h);
        }
        public QPixmap(QSize arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPixmap#", "QPixmap(const QSize&)", typeof(void), typeof(QSize), arg1);
        }
        public QPixmap(string fileName, string format, uint flags) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPixmap$$$", "QPixmap(const QString&, const char*, Qt::ImageConversionFlags)", typeof(void), typeof(string), fileName, typeof(string), format, typeof(uint), flags);
        }
        public QPixmap(string fileName, string format) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPixmap$$", "QPixmap(const QString&, const char*)", typeof(void), typeof(string), fileName, typeof(string), format);
        }
        public QPixmap(string fileName) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPixmap$", "QPixmap(const QString&)", typeof(void), typeof(string), fileName);
        }
        public QPixmap(QPixmap arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPixmap#", "QPixmap(const QPixmap&)", typeof(void), typeof(QPixmap), arg1);
        }
        public bool IsNull() {
            return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
        }
        [SmokeMethod("devType() const")]
        public override int DevType() {
            return (int) interceptor.Invoke("devType", "devType() const", typeof(int));
        }
        public new int Width() {
            return (int) interceptor.Invoke("width", "width() const", typeof(int));
        }
        public new int Height() {
            return (int) interceptor.Invoke("height", "height() const", typeof(int));
        }
        public QSize Size() {
            return (QSize) interceptor.Invoke("size", "size() const", typeof(QSize));
        }
        public QRect Rect() {
            return (QRect) interceptor.Invoke("rect", "rect() const", typeof(QRect));
        }
        public new int Depth() {
            return (int) interceptor.Invoke("depth", "depth() const", typeof(int));
        }
        public void Fill(QColor fillColor) {
            interceptor.Invoke("fill#", "fill(const QColor&)", typeof(void), typeof(QColor), fillColor);
        }
        public void Fill() {
            interceptor.Invoke("fill", "fill()", typeof(void));
        }
        public void Fill(QWidget widget, QPoint ofs) {
            interceptor.Invoke("fill##", "fill(const QWidget*, const QPoint&)", typeof(void), typeof(QWidget), widget, typeof(QPoint), ofs);
        }
        public void Fill(QWidget widget, int xofs, int yofs) {
            interceptor.Invoke("fill#$$", "fill(const QWidget*, int, int)", typeof(void), typeof(QWidget), widget, typeof(int), xofs, typeof(int), yofs);
        }
        public QBitmap Mask() {
            return (QBitmap) interceptor.Invoke("mask", "mask() const", typeof(QBitmap));
        }
        public void SetMask(QBitmap arg1) {
            interceptor.Invoke("setMask#", "setMask(const QBitmap&)", typeof(void), typeof(QBitmap), arg1);
        }
        public QPixmap AlphaChannel() {
            return (QPixmap) interceptor.Invoke("alphaChannel", "alphaChannel() const", typeof(QPixmap));
        }
        public void SetAlphaChannel(QPixmap arg1) {
            interceptor.Invoke("setAlphaChannel#", "setAlphaChannel(const QPixmap&)", typeof(void), typeof(QPixmap), arg1);
        }
        public bool HasAlpha() {
            return (bool) interceptor.Invoke("hasAlpha", "hasAlpha() const", typeof(bool));
        }
        public bool HasAlphaChannel() {
            return (bool) interceptor.Invoke("hasAlphaChannel", "hasAlphaChannel() const", typeof(bool));
        }
        public QBitmap CreateHeuristicMask(bool clipTight) {
            return (QBitmap) interceptor.Invoke("createHeuristicMask$", "createHeuristicMask(bool) const", typeof(QBitmap), typeof(bool), clipTight);
        }
        public QBitmap CreateHeuristicMask() {
            return (QBitmap) interceptor.Invoke("createHeuristicMask", "createHeuristicMask() const", typeof(QBitmap));
        }
        public QBitmap CreateMaskFromColor(QColor maskColor) {
            return (QBitmap) interceptor.Invoke("createMaskFromColor#", "createMaskFromColor(const QColor&) const", typeof(QBitmap), typeof(QColor), maskColor);
        }
        public QBitmap CreateMaskFromColor(QColor maskColor, Qt.MaskMode mode) {
            return (QBitmap) interceptor.Invoke("createMaskFromColor#$", "createMaskFromColor(const QColor&, Qt::MaskMode) const", typeof(QBitmap), typeof(QColor), maskColor, typeof(Qt.MaskMode), mode);
        }
        public QPixmap Scaled(int w, int h, Qt.AspectRatioMode aspectMode, Qt.TransformationMode mode) {
            return (QPixmap) interceptor.Invoke("scaled$$$$", "scaled(int, int, Qt::AspectRatioMode, Qt::TransformationMode) const", typeof(QPixmap), typeof(int), w, typeof(int), h, typeof(Qt.AspectRatioMode), aspectMode, typeof(Qt.TransformationMode), mode);
        }
        public QPixmap Scaled(int w, int h, Qt.AspectRatioMode aspectMode) {
            return (QPixmap) interceptor.Invoke("scaled$$$", "scaled(int, int, Qt::AspectRatioMode) const", typeof(QPixmap), typeof(int), w, typeof(int), h, typeof(Qt.AspectRatioMode), aspectMode);
        }
        public QPixmap Scaled(int w, int h) {
            return (QPixmap) interceptor.Invoke("scaled$$", "scaled(int, int) const", typeof(QPixmap), typeof(int), w, typeof(int), h);
        }
        public QPixmap Scaled(QSize s, Qt.AspectRatioMode aspectMode, Qt.TransformationMode mode) {
            return (QPixmap) interceptor.Invoke("scaled#$$", "scaled(const QSize&, Qt::AspectRatioMode, Qt::TransformationMode) const", typeof(QPixmap), typeof(QSize), s, typeof(Qt.AspectRatioMode), aspectMode, typeof(Qt.TransformationMode), mode);
        }
        public QPixmap Scaled(QSize s, Qt.AspectRatioMode aspectMode) {
            return (QPixmap) interceptor.Invoke("scaled#$", "scaled(const QSize&, Qt::AspectRatioMode) const", typeof(QPixmap), typeof(QSize), s, typeof(Qt.AspectRatioMode), aspectMode);
        }
        public QPixmap Scaled(QSize s) {
            return (QPixmap) interceptor.Invoke("scaled#", "scaled(const QSize&) const", typeof(QPixmap), typeof(QSize), s);
        }
        public QPixmap ScaledToWidth(int w, Qt.TransformationMode mode) {
            return (QPixmap) interceptor.Invoke("scaledToWidth$$", "scaledToWidth(int, Qt::TransformationMode) const", typeof(QPixmap), typeof(int), w, typeof(Qt.TransformationMode), mode);
        }
        public QPixmap ScaledToWidth(int w) {
            return (QPixmap) interceptor.Invoke("scaledToWidth$", "scaledToWidth(int) const", typeof(QPixmap), typeof(int), w);
        }
        public QPixmap ScaledToHeight(int h, Qt.TransformationMode mode) {
            return (QPixmap) interceptor.Invoke("scaledToHeight$$", "scaledToHeight(int, Qt::TransformationMode) const", typeof(QPixmap), typeof(int), h, typeof(Qt.TransformationMode), mode);
        }
        public QPixmap ScaledToHeight(int h) {
            return (QPixmap) interceptor.Invoke("scaledToHeight$", "scaledToHeight(int) const", typeof(QPixmap), typeof(int), h);
        }
        public QPixmap Transformed(QMatrix arg1, Qt.TransformationMode mode) {
            return (QPixmap) interceptor.Invoke("transformed#$", "transformed(const QMatrix&, Qt::TransformationMode) const", typeof(QPixmap), typeof(QMatrix), arg1, typeof(Qt.TransformationMode), mode);
        }
        public QPixmap Transformed(QMatrix arg1) {
            return (QPixmap) interceptor.Invoke("transformed#", "transformed(const QMatrix&) const", typeof(QPixmap), typeof(QMatrix), arg1);
        }
        public QPixmap Transformed(QTransform arg1, Qt.TransformationMode mode) {
            return (QPixmap) interceptor.Invoke("transformed#$", "transformed(const QTransform&, Qt::TransformationMode) const", typeof(QPixmap), typeof(QTransform), arg1, typeof(Qt.TransformationMode), mode);
        }
        public QPixmap Transformed(QTransform arg1) {
            return (QPixmap) interceptor.Invoke("transformed#", "transformed(const QTransform&) const", typeof(QPixmap), typeof(QTransform), arg1);
        }
        public QImage ToImage() {
            return (QImage) interceptor.Invoke("toImage", "toImage() const", typeof(QImage));
        }
        public bool Load(string fileName, string format, uint flags) {
            return (bool) interceptor.Invoke("load$$$", "load(const QString&, const char*, Qt::ImageConversionFlags)", typeof(bool), typeof(string), fileName, typeof(string), format, typeof(uint), flags);
        }
        public bool Load(string fileName, string format) {
            return (bool) interceptor.Invoke("load$$", "load(const QString&, const char*)", typeof(bool), typeof(string), fileName, typeof(string), format);
        }
        public bool Load(string fileName) {
            return (bool) interceptor.Invoke("load$", "load(const QString&)", typeof(bool), typeof(string), fileName);
        }
        public bool LoadFromData(Pointer<byte> buf, uint len, string format, uint flags) {
            return (bool) interceptor.Invoke("loadFromData$$$$", "loadFromData(const unsigned char*, uint, const char*, Qt::ImageConversionFlags)", typeof(bool), typeof(Pointer<byte>), buf, typeof(uint), len, typeof(string), format, typeof(uint), flags);
        }
        public bool LoadFromData(Pointer<byte> buf, uint len, string format) {
            return (bool) interceptor.Invoke("loadFromData$$$", "loadFromData(const unsigned char*, uint, const char*)", typeof(bool), typeof(Pointer<byte>), buf, typeof(uint), len, typeof(string), format);
        }
        public bool LoadFromData(Pointer<byte> buf, uint len) {
            return (bool) interceptor.Invoke("loadFromData$$", "loadFromData(const unsigned char*, uint)", typeof(bool), typeof(Pointer<byte>), buf, typeof(uint), len);
        }
        public bool LoadFromData(QByteArray data, string format, uint flags) {
            return (bool) interceptor.Invoke("loadFromData#$$", "loadFromData(const QByteArray&, const char*, Qt::ImageConversionFlags)", typeof(bool), typeof(QByteArray), data, typeof(string), format, typeof(uint), flags);
        }
        public bool LoadFromData(QByteArray data, string format) {
            return (bool) interceptor.Invoke("loadFromData#$", "loadFromData(const QByteArray&, const char*)", typeof(bool), typeof(QByteArray), data, typeof(string), format);
        }
        public bool LoadFromData(QByteArray data) {
            return (bool) interceptor.Invoke("loadFromData#", "loadFromData(const QByteArray&)", typeof(bool), typeof(QByteArray), data);
        }
        public bool Save(string fileName, string format, int quality) {
            return (bool) interceptor.Invoke("save$$$", "save(const QString&, const char*, int) const", typeof(bool), typeof(string), fileName, typeof(string), format, typeof(int), quality);
        }
        public bool Save(string fileName, string format) {
            return (bool) interceptor.Invoke("save$$", "save(const QString&, const char*) const", typeof(bool), typeof(string), fileName, typeof(string), format);
        }
        public bool Save(string fileName) {
            return (bool) interceptor.Invoke("save$", "save(const QString&) const", typeof(bool), typeof(string), fileName);
        }
        public bool Save(QIODevice device, string format, int quality) {
            return (bool) interceptor.Invoke("save#$$", "save(QIODevice*, const char*, int) const", typeof(bool), typeof(QIODevice), device, typeof(string), format, typeof(int), quality);
        }
        public bool Save(QIODevice device, string format) {
            return (bool) interceptor.Invoke("save#$", "save(QIODevice*, const char*) const", typeof(bool), typeof(QIODevice), device, typeof(string), format);
        }
        public bool Save(QIODevice device) {
            return (bool) interceptor.Invoke("save#", "save(QIODevice*) const", typeof(bool), typeof(QIODevice), device);
        }
        public QPixmap Copy(int x, int y, int width, int height) {
            return (QPixmap) interceptor.Invoke("copy$$$$", "copy(int, int, int, int) const", typeof(QPixmap), typeof(int), x, typeof(int), y, typeof(int), width, typeof(int), height);
        }
        public QPixmap Copy(QRect rect) {
            return (QPixmap) interceptor.Invoke("copy#", "copy(const QRect&) const", typeof(QPixmap), typeof(QRect), rect);
        }
        public QPixmap Copy() {
            return (QPixmap) interceptor.Invoke("copy", "copy() const", typeof(QPixmap));
        }
        public int SerialNumber() {
            return (int) interceptor.Invoke("serialNumber", "serialNumber() const", typeof(int));
        }
        public long CacheKey() {
            return (long) interceptor.Invoke("cacheKey", "cacheKey() const", typeof(long));
        }
        public bool IsDetached() {
            return (bool) interceptor.Invoke("isDetached", "isDetached() const", typeof(bool));
        }
        public void Detach() {
            interceptor.Invoke("detach", "detach()", typeof(void));
        }
        public bool IsQBitmap() {
            return (bool) interceptor.Invoke("isQBitmap", "isQBitmap() const", typeof(bool));
        }
        [SmokeMethod("paintEngine() const")]
        public override QPaintEngine PaintEngine() {
            return (QPaintEngine) interceptor.Invoke("paintEngine", "paintEngine() const", typeof(QPaintEngine));
        }
        [SmokeMethod("metric(QPaintDevice::PaintDeviceMetric) const")]
        protected override int Metric(QPaintDevice.PaintDeviceMetric arg1) {
            return (int) interceptor.Invoke("metric$", "metric(QPaintDevice::PaintDeviceMetric) const", typeof(int), typeof(QPaintDevice.PaintDeviceMetric), arg1);
        }
        ~QPixmap() {
            interceptor.Invoke("~QPixmap", "~QPixmap()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QPixmap", "~QPixmap()", typeof(void));
        }
        public static bool operator!(QPixmap lhs) {
            return (bool) staticInterceptor.Invoke("operator!", "operator!() const", typeof(bool), typeof(QPixmap), lhs);
        }
        public static int DefaultDepth() {
            return (int) staticInterceptor.Invoke("defaultDepth", "defaultDepth()", typeof(int));
        }
        public static QPixmap GrabWindow(uint arg1, int x, int y, int w, int h) {
            return (QPixmap) staticInterceptor.Invoke("grabWindow$$$$$", "grabWindow(WId, int, int, int, int)", typeof(QPixmap), typeof(uint), arg1, typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
        }
        public static QPixmap GrabWindow(uint arg1, int x, int y, int w) {
            return (QPixmap) staticInterceptor.Invoke("grabWindow$$$$", "grabWindow(WId, int, int, int)", typeof(QPixmap), typeof(uint), arg1, typeof(int), x, typeof(int), y, typeof(int), w);
        }
        public static QPixmap GrabWindow(uint arg1, int x, int y) {
            return (QPixmap) staticInterceptor.Invoke("grabWindow$$$", "grabWindow(WId, int, int)", typeof(QPixmap), typeof(uint), arg1, typeof(int), x, typeof(int), y);
        }
        public static QPixmap GrabWindow(uint arg1, int x) {
            return (QPixmap) staticInterceptor.Invoke("grabWindow$$", "grabWindow(WId, int)", typeof(QPixmap), typeof(uint), arg1, typeof(int), x);
        }
        public static QPixmap GrabWindow(uint arg1) {
            return (QPixmap) staticInterceptor.Invoke("grabWindow$", "grabWindow(WId)", typeof(QPixmap), typeof(uint), arg1);
        }
        public static QPixmap GrabWidget(QWidget widget, QRect rect) {
            return (QPixmap) staticInterceptor.Invoke("grabWidget##", "grabWidget(QWidget*, const QRect&)", typeof(QPixmap), typeof(QWidget), widget, typeof(QRect), rect);
        }
        public static QPixmap GrabWidget(QWidget widget, int x, int y, int w, int h) {
            return (QPixmap) staticInterceptor.Invoke("grabWidget#$$$$", "grabWidget(QWidget*, int, int, int, int)", typeof(QPixmap), typeof(QWidget), widget, typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
        }
        public static QPixmap GrabWidget(QWidget widget, int x, int y, int w) {
            return (QPixmap) staticInterceptor.Invoke("grabWidget#$$$", "grabWidget(QWidget*, int, int, int)", typeof(QPixmap), typeof(QWidget), widget, typeof(int), x, typeof(int), y, typeof(int), w);
        }
        public static QPixmap GrabWidget(QWidget widget, int x, int y) {
            return (QPixmap) staticInterceptor.Invoke("grabWidget#$$", "grabWidget(QWidget*, int, int)", typeof(QPixmap), typeof(QWidget), widget, typeof(int), x, typeof(int), y);
        }
        public static QPixmap GrabWidget(QWidget widget, int x) {
            return (QPixmap) staticInterceptor.Invoke("grabWidget#$", "grabWidget(QWidget*, int)", typeof(QPixmap), typeof(QWidget), widget, typeof(int), x);
        }
        public static QPixmap GrabWidget(QWidget widget) {
            return (QPixmap) staticInterceptor.Invoke("grabWidget#", "grabWidget(QWidget*)", typeof(QPixmap), typeof(QWidget), widget);
        }
        public static QMatrix TrueMatrix(QMatrix m, int w, int h) {
            return (QMatrix) staticInterceptor.Invoke("trueMatrix#$$", "trueMatrix(const QMatrix&, int, int)", typeof(QMatrix), typeof(QMatrix), m, typeof(int), w, typeof(int), h);
        }
        public static QTransform TrueMatrix(QTransform m, int w, int h) {
            return (QTransform) staticInterceptor.Invoke("trueMatrix#$$", "trueMatrix(const QTransform&, int, int)", typeof(QTransform), typeof(QTransform), m, typeof(int), w, typeof(int), h);
        }
        public static QPixmap FromImage(QImage image, uint flags) {
            return (QPixmap) staticInterceptor.Invoke("fromImage#$", "fromImage(const QImage&, Qt::ImageConversionFlags)", typeof(QPixmap), typeof(QImage), image, typeof(uint), flags);
        }
        public static QPixmap FromImage(QImage image) {
            return (QPixmap) staticInterceptor.Invoke("fromImage#", "fromImage(const QImage&)", typeof(QPixmap), typeof(QImage), image);
        }
    }
}
