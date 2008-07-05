//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QUuid")]
	public class QUuid : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QUuid(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QUuid), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QUuid() {
			staticInterceptor = new SmokeInvocation(typeof(QUuid), null);
		}
		public enum Variant {
			VarUnknown = -1,
			NCS = 0,
			DCE = 2,
			Microsoft = 6,
			Reserved = 7,
		}
		public enum Version {
			VerUnknown = -1,
			Time = 1,
			EmbeddedPOSIX = 2,
			Name = 3,
			Random = 4,
		}
		//  operator QString(); >>>> NOT CONVERTED
		public QUuid() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUuid", "QUuid()", typeof(void));
		}
		public QUuid(uint l, ushort w1, ushort w2, ushort b1, ushort b2, ushort b3, ushort b4, ushort b5, ushort b6, ushort b7, ushort b8) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUuid$$$$$$$$$$$", "QUuid(uint, unsigned short, unsigned short, uchar, uchar, uchar, uchar, uchar, uchar, uchar, uchar)", typeof(void), typeof(uint), l, typeof(ushort), w1, typeof(ushort), w2, typeof(ushort), b1, typeof(ushort), b2, typeof(ushort), b3, typeof(ushort), b4, typeof(ushort), b5, typeof(ushort), b6, typeof(ushort), b7, typeof(ushort), b8);
		}
		public QUuid(string arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUuid$", "QUuid(const QString&)", typeof(void), typeof(string), arg1);
		}
		public new string ToString() {
			return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public override bool Equals(object o) {
			if (!(o is QUuid)) { return false; }
			return this == (QUuid) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public QUuid.Variant variant() {
			return (QUuid.Variant) interceptor.Invoke("variant", "variant() const", typeof(QUuid.Variant));
		}
		public QUuid.Version version() {
			return (QUuid.Version) interceptor.Invoke("version", "version() const", typeof(QUuid.Version));
		}
		~QUuid() {
			interceptor.Invoke("~QUuid", "~QUuid()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QUuid", "~QUuid()", typeof(void));
		}
		public static bool operator==(QUuid lhs, QUuid orig) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QUuid&) const", typeof(bool), typeof(QUuid), lhs, typeof(QUuid), orig);
		}
		public static bool operator!=(QUuid lhs, QUuid orig) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QUuid&) const", typeof(bool), typeof(QUuid), lhs, typeof(QUuid), orig);
		}
		public static bool operator<(QUuid lhs, QUuid other) {
			return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QUuid&) const", typeof(bool), typeof(QUuid), lhs, typeof(QUuid), other);
		}
		public static bool operator>(QUuid lhs, QUuid other) {
			return (bool) staticInterceptor.Invoke("operator>#", "operator>(const QUuid&) const", typeof(bool), typeof(QUuid), lhs, typeof(QUuid), other);
		}
		public static QUuid CreateUuid() {
			return (QUuid) staticInterceptor.Invoke("createUuid", "createUuid()", typeof(QUuid));
		}
	}
}
