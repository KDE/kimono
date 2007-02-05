//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQToolBarSignals"></see> for signals emitted by QToolBar
	[SmokeClass("QToolBar")]
	public class QToolBar : QWidget, IDisposable {
 		protected QToolBar(Type dummy) : base((Type) null) {}
		[SmokeClass("QToolBar")]
		interface IQToolBarProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QToolBar), this);
			_interceptor = (QToolBar) realProxy.GetTransparentProxy();
		}
		private QToolBar ProxyQToolBar() {
			return (QToolBar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QToolBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQToolBarProxy), null);
			_staticInterceptor = (IQToolBarProxy) realProxy.GetTransparentProxy();
		}
		private static IQToolBarProxy StaticQToolBar() {
			return (IQToolBarProxy) _staticInterceptor;
		}
		[Q_PROPERTY("bool", "movable")]
		public bool Movable {
			get {
				return Property("movable").Value<bool>();
			}
			set {
				SetProperty("movable", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("Qt::ToolBarAreas", "allowedAreas")]
		public int AllowedAreas {
			get {
				return Property("allowedAreas").Value<int>();
			}
			set {
				SetProperty("allowedAreas", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public Qt.Orientation Orientation {
			get {
				return Property("orientation").Value<Qt.Orientation>();
			}
			set {
				SetProperty("orientation", QVariant.FromValue<Qt.Orientation>(value));
			}
		}
		[Q_PROPERTY("QSize", "iconSize")]
		public QSize IconSize {
			get {
				return Property("iconSize").Value<QSize>();
			}
			set {
				SetProperty("iconSize", QVariant.FromValue<QSize>(value));
			}
		}
		[Q_PROPERTY("Qt::ToolButtonStyle", "toolButtonStyle")]
		public Qt.ToolButtonStyle ToolButtonStyle {
			get {
				return Property("toolButtonStyle").Value<Qt.ToolButtonStyle>();
			}
			set {
				SetProperty("toolButtonStyle", QVariant.FromValue<Qt.ToolButtonStyle>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QToolBar(string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQToolBar(title,parent);
		}
		[SmokeMethod("QToolBar", "(const QString&, QWidget*)", "$#")]
		private void NewQToolBar(string title, QWidget parent) {
			ProxyQToolBar().NewQToolBar(title,parent);
		}
		public QToolBar(string title) : this((Type) null) {
			CreateProxy();
			NewQToolBar(title);
		}
		[SmokeMethod("QToolBar", "(const QString&)", "$")]
		private void NewQToolBar(string title) {
			ProxyQToolBar().NewQToolBar(title);
		}
		public QToolBar(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQToolBar(parent);
		}
		[SmokeMethod("QToolBar", "(QWidget*)", "#")]
		private void NewQToolBar(QWidget parent) {
			ProxyQToolBar().NewQToolBar(parent);
		}
		public QToolBar() : this((Type) null) {
			CreateProxy();
			NewQToolBar();
		}
		[SmokeMethod("QToolBar", "()", "")]
		private void NewQToolBar() {
			ProxyQToolBar().NewQToolBar();
		}
		[SmokeMethod("isMovable", "() const", "")]
		public bool IsMovable() {
			return ProxyQToolBar().IsMovable();
		}
		[SmokeMethod("isAreaAllowed", "(Qt::ToolBarArea) const", "$")]
		public bool IsAreaAllowed(Qt.ToolBarArea area) {
			return ProxyQToolBar().IsAreaAllowed(area);
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQToolBar().Clear();
		}
		[SmokeMethod("addAction", "(QAction*)", "#")]
		public new void AddAction(QAction action) {
			ProxyQToolBar().AddAction(action);
		}
		[SmokeMethod("addAction", "(const QString&)", "$")]
		public new QAction AddAction(string text) {
			return ProxyQToolBar().AddAction(text);
		}
		[SmokeMethod("addAction", "(const QIcon&, const QString&)", "#$")]
		public new QAction AddAction(QIcon icon, string text) {
			return ProxyQToolBar().AddAction(icon,text);
		}
		[SmokeMethod("addAction", "(const QString&, const QObject*, const char*)", "$#$")]
		public new QAction AddAction(string text, QObject receiver, string member) {
			return ProxyQToolBar().AddAction(text,receiver,member);
		}
		[SmokeMethod("addAction", "(const QIcon&, const QString&, const QObject*, const char*)", "#$#$")]
		public new QAction AddAction(QIcon icon, string text, QObject receiver, string member) {
			return ProxyQToolBar().AddAction(icon,text,receiver,member);
		}
		[SmokeMethod("addSeparator", "()", "")]
		public QAction AddSeparator() {
			return ProxyQToolBar().AddSeparator();
		}
		[SmokeMethod("insertSeparator", "(QAction*)", "#")]
		public QAction InsertSeparator(QAction before) {
			return ProxyQToolBar().InsertSeparator(before);
		}
		[SmokeMethod("addWidget", "(QWidget*)", "#")]
		public QAction AddWidget(QWidget widget) {
			return ProxyQToolBar().AddWidget(widget);
		}
		[SmokeMethod("insertWidget", "(QAction*, QWidget*)", "##")]
		public QAction InsertWidget(QAction before, QWidget widget) {
			return ProxyQToolBar().InsertWidget(before,widget);
		}
		[SmokeMethod("actionGeometry", "(QAction*) const", "#")]
		public QRect ActionGeometry(QAction action) {
			return ProxyQToolBar().ActionGeometry(action);
		}
		[SmokeMethod("actionAt", "(const QPoint&) const", "#")]
		public QAction ActionAt(QPoint p) {
			return ProxyQToolBar().ActionAt(p);
		}
		[SmokeMethod("actionAt", "(int, int) const", "$$")]
		public QAction ActionAt(int x, int y) {
			return ProxyQToolBar().ActionAt(x,y);
		}
		[SmokeMethod("toggleViewAction", "() const", "")]
		public QAction ToggleViewAction() {
			return ProxyQToolBar().ToggleViewAction();
		}
		[SmokeMethod("widgetForAction", "(QAction*) const", "#")]
		public QWidget WidgetForAction(QAction action) {
			return ProxyQToolBar().WidgetForAction(action);
		}
		public static new string Tr(string s, string c) {
			return StaticQToolBar().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQToolBar().Tr(s);
		}
		[SmokeMethod("actionEvent", "(QActionEvent*)", "#")]
		protected new void ActionEvent(QActionEvent arg1) {
			ProxyQToolBar().ActionEvent(arg1);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQToolBar().ChangeEvent(arg1);
		}
		[SmokeMethod("childEvent", "(QChildEvent*)", "#")]
		protected new void ChildEvent(QChildEvent arg1) {
			ProxyQToolBar().ChildEvent(arg1);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQToolBar().PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQToolBar().ResizeEvent(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent arg1) {
			return ProxyQToolBar().Event(arg1);
		}
		~QToolBar() {
			DisposeQToolBar();
		}
		public new void Dispose() {
			DisposeQToolBar();
		}
		[SmokeMethod("~QToolBar", "()", "")]
		private void DisposeQToolBar() {
			ProxyQToolBar().DisposeQToolBar();
		}
		protected new IQToolBarSignals Emit {
			get {
				return (IQToolBarSignals) Q_EMIT;
			}
		}
	}

	public interface IQToolBarSignals : IQWidgetSignals {
		[Q_SIGNAL("void actionTriggered(QAction*)")]
		void ActionTriggered(QAction action);
		[Q_SIGNAL("void movableChanged(bool)")]
		void MovableChanged(bool movable);
		[Q_SIGNAL("void allowedAreasChanged(Qt::ToolBarAreas)")]
		void AllowedAreasChanged(int allowedAreas);
		[Q_SIGNAL("void orientationChanged(Qt::Orientation)")]
		void OrientationChanged(Qt.Orientation orientation);
		[Q_SIGNAL("void iconSizeChanged(const QSize&)")]
		void IconSizeChanged(QSize iconSize);
		[Q_SIGNAL("void toolButtonStyleChanged(Qt::ToolButtonStyle)")]
		void ToolButtonStyleChanged(Qt.ToolButtonStyle toolButtonStyle);
	}
}
