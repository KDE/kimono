//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	[SmokeClass("KBookmarkExporterBase")]
	public abstract class KBookmarkExporterBase : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KBookmarkExporterBase(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KBookmarkExporterBase), this);
		}
		public KBookmarkExporterBase(KBookmarkManager mgr, string fileName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KBookmarkExporterBase#$", "KBookmarkExporterBase(KBookmarkManager*, const QString&)", typeof(void), typeof(KBookmarkManager), mgr, typeof(string), fileName);
		}
		[SmokeMethod("write(const KBookmarkGroup&)")]
		public abstract void Write(KBookmarkGroup arg1);
	}
}
