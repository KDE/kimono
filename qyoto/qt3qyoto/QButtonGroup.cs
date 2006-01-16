//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQButtonGroupSignals"></see> for signals emitted by QButtonGroup
	[SmokeClass("QButtonGroup")]
	public class QButtonGroup : QGroupBox, IDisposable {
 		protected QButtonGroup(Type dummy) : base((Type) null) {}
		interface IQButtonGroupProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QButtonGroup), this);
			_interceptor = (QButtonGroup) realProxy.GetTransparentProxy();
		}
		private QButtonGroup ProxyQButtonGroup() {
			return (QButtonGroup) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QButtonGroup() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQButtonGroupProxy), null);
			_staticInterceptor = (IQButtonGroupProxy) realProxy.GetTransparentProxy();
		}
		private static IQButtonGroupProxy StaticQButtonGroup() {
			return (IQButtonGroupProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQButtonGroup().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQButtonGroup().ClassName();
		}
		public QButtonGroup(QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(parent,name);
		}
		[SmokeMethod("QButtonGroup(QWidget*, const char*)")]
		private void NewQButtonGroup(QWidget parent, string name) {
			ProxyQButtonGroup().NewQButtonGroup(parent,name);
		}
		public QButtonGroup(QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(parent);
		}
		[SmokeMethod("QButtonGroup(QWidget*)")]
		private void NewQButtonGroup(QWidget parent) {
			ProxyQButtonGroup().NewQButtonGroup(parent);
		}
		public QButtonGroup() : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup();
		}
		[SmokeMethod("QButtonGroup()")]
		private void NewQButtonGroup() {
			ProxyQButtonGroup().NewQButtonGroup();
		}
		public QButtonGroup(string title, QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(title,parent,name);
		}
		[SmokeMethod("QButtonGroup(const QString&, QWidget*, const char*)")]
		private void NewQButtonGroup(string title, QWidget parent, string name) {
			ProxyQButtonGroup().NewQButtonGroup(title,parent,name);
		}
		public QButtonGroup(string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(title,parent);
		}
		[SmokeMethod("QButtonGroup(const QString&, QWidget*)")]
		private void NewQButtonGroup(string title, QWidget parent) {
			ProxyQButtonGroup().NewQButtonGroup(title,parent);
		}
		public QButtonGroup(string title) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(title);
		}
		[SmokeMethod("QButtonGroup(const QString&)")]
		private void NewQButtonGroup(string title) {
			ProxyQButtonGroup().NewQButtonGroup(title);
		}
		public QButtonGroup(int columns, Qt.Orientation o, QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(columns,o,parent,name);
		}
		[SmokeMethod("QButtonGroup(int, Qt::Orientation, QWidget*, const char*)")]
		private void NewQButtonGroup(int columns, Qt.Orientation o, QWidget parent, string name) {
			ProxyQButtonGroup().NewQButtonGroup(columns,o,parent,name);
		}
		public QButtonGroup(int columns, Qt.Orientation o, QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(columns,o,parent);
		}
		[SmokeMethod("QButtonGroup(int, Qt::Orientation, QWidget*)")]
		private void NewQButtonGroup(int columns, Qt.Orientation o, QWidget parent) {
			ProxyQButtonGroup().NewQButtonGroup(columns,o,parent);
		}
		public QButtonGroup(int columns, Qt.Orientation o) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(columns,o);
		}
		[SmokeMethod("QButtonGroup(int, Qt::Orientation)")]
		private void NewQButtonGroup(int columns, Qt.Orientation o) {
			ProxyQButtonGroup().NewQButtonGroup(columns,o);
		}
		public QButtonGroup(int columns, Qt.Orientation o, string title, QWidget parent, string name) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(columns,o,title,parent,name);
		}
		[SmokeMethod("QButtonGroup(int, Qt::Orientation, const QString&, QWidget*, const char*)")]
		private void NewQButtonGroup(int columns, Qt.Orientation o, string title, QWidget parent, string name) {
			ProxyQButtonGroup().NewQButtonGroup(columns,o,title,parent,name);
		}
		public QButtonGroup(int columns, Qt.Orientation o, string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(columns,o,title,parent);
		}
		[SmokeMethod("QButtonGroup(int, Qt::Orientation, const QString&, QWidget*)")]
		private void NewQButtonGroup(int columns, Qt.Orientation o, string title, QWidget parent) {
			ProxyQButtonGroup().NewQButtonGroup(columns,o,title,parent);
		}
		public QButtonGroup(int columns, Qt.Orientation o, string title) : this((Type) null) {
			CreateProxy();
			CreateSignalProxy();
			NewQButtonGroup(columns,o,title);
		}
		[SmokeMethod("QButtonGroup(int, Qt::Orientation, const QString&)")]
		private void NewQButtonGroup(int columns, Qt.Orientation o, string title) {
			ProxyQButtonGroup().NewQButtonGroup(columns,o,title);
		}
		[SmokeMethod("isExclusive() const")]
		public bool IsExclusive() {
			return ProxyQButtonGroup().IsExclusive();
		}
		[SmokeMethod("isRadioButtonExclusive() const")]
		public bool IsRadioButtonExclusive() {
			return ProxyQButtonGroup().IsRadioButtonExclusive();
		}
		[SmokeMethod("setExclusive(bool)")]
		public virtual void SetExclusive(bool arg1) {
			ProxyQButtonGroup().SetExclusive(arg1);
		}
		[SmokeMethod("setRadioButtonExclusive(bool)")]
		public virtual void SetRadioButtonExclusive(bool arg1) {
			ProxyQButtonGroup().SetRadioButtonExclusive(arg1);
		}
		[SmokeMethod("insert(QButton*, int)")]
		public int Insert(QButton arg1, int id) {
			return ProxyQButtonGroup().Insert(arg1,id);
		}
		[SmokeMethod("insert(QButton*)")]
		public int Insert(QButton arg1) {
			return ProxyQButtonGroup().Insert(arg1);
		}
		[SmokeMethod("remove(QButton*)")]
		public void Remove(QButton arg1) {
			ProxyQButtonGroup().Remove(arg1);
		}
		[SmokeMethod("find(int) const")]
		public new QButton FindButton(int id) {
			return ProxyQButtonGroup().FindButton(id);
		}
		[SmokeMethod("id(QButton*) const")]
		public int Id(QButton arg1) {
			return ProxyQButtonGroup().Id(arg1);
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQButtonGroup().Count();
		}
		[SmokeMethod("setButton(int)")]
		public virtual void SetButton(int id) {
			ProxyQButtonGroup().SetButton(id);
		}
		[SmokeMethod("moveFocus(int)")]
		public virtual void MoveFocus(int arg1) {
			ProxyQButtonGroup().MoveFocus(arg1);
		}
		[SmokeMethod("selected() const")]
		public QButton Selected() {
			return ProxyQButtonGroup().Selected();
		}
		[SmokeMethod("selectedId() const")]
		public int SelectedId() {
			return ProxyQButtonGroup().SelectedId();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQButtonGroup().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQButtonGroup().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQButtonGroup().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQButtonGroup().TrUtf8(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQButtonGroup().Event(e);
		}
		[Q_SLOT("void buttonPressed()")]
		[SmokeMethod("buttonPressed()")]
		protected void ButtonPressed() {
			ProxyQButtonGroup().ButtonPressed();
		}
		[Q_SLOT("void buttonReleased()")]
		[SmokeMethod("buttonReleased()")]
		protected void ButtonReleased() {
			ProxyQButtonGroup().ButtonReleased();
		}
		[Q_SLOT("void buttonClicked()")]
		[SmokeMethod("buttonClicked()")]
		protected void ButtonClicked() {
			ProxyQButtonGroup().ButtonClicked();
		}
		[Q_SLOT("void buttonToggled(bool)")]
		[SmokeMethod("buttonToggled(bool)")]
		protected void ButtonToggled(bool on) {
			ProxyQButtonGroup().ButtonToggled(on);
		}
		~QButtonGroup() {
			DisposeQButtonGroup();
		}
		public new void Dispose() {
			DisposeQButtonGroup();
		}
		private void DisposeQButtonGroup() {
			ProxyQButtonGroup().DisposeQButtonGroup();
		}
		protected new void CreateSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQButtonGroupSignals), this);
			Q_EMIT = (IQButtonGroupSignals) realProxy.GetTransparentProxy();
		}
		protected new IQButtonGroupSignals Emit() {
			return (IQButtonGroupSignals) Q_EMIT;
		}
	}

	public interface IQButtonGroupSignals : IQGroupBoxSignals {
		[Q_SIGNAL("void pressed(int)")]
		void Pressed(int id);
		[Q_SIGNAL("void released(int)")]
		void Released(int id);
		[Q_SIGNAL("void clicked(int)")]
		void Clicked(int id);
	}
}
