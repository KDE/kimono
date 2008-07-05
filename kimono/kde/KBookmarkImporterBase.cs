//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  A class for importing NS bookmarks
	///  KEditBookmarks uses it to insert bookmarks into its DOM tree,
	///  and KActionMenu uses it to create actions directly.
	///   See <see cref="IKBookmarkImporterBaseSignals"></see> for signals emitted by KBookmarkImporterBase
	/// </remarks>		<short>    A class for importing NS bookmarks  KEditBookmarks uses it to insert bookmarks into its DOM tree,  and KActionMenu uses it to create actions directly.</short>
	[SmokeClass("KBookmarkImporterBase")]
	public abstract class KBookmarkImporterBase : QObject {
 		protected KBookmarkImporterBase(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KBookmarkImporterBase), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KBookmarkImporterBase() {
			staticInterceptor = new SmokeInvocation(typeof(KBookmarkImporterBase), null);
		}
		public KBookmarkImporterBase() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KBookmarkImporterBase", "KBookmarkImporterBase()", typeof(void));
		}
		public void SetFilename(string filename) {
			interceptor.Invoke("setFilename$", "setFilename(const QString&)", typeof(void), typeof(string), filename);
		}
		[SmokeMethod("parse()")]
		public abstract void Parse();
		[SmokeMethod("findDefaultLocation(bool) const")]
		public abstract string FindDefaultLocation(bool forSaving);
		public void SetupSignalForwards(QObject src, QObject dst) {
			interceptor.Invoke("setupSignalForwards##", "setupSignalForwards(QObject*, QObject*)", typeof(void), typeof(QObject), src, typeof(QObject), dst);
		}
		public static KBookmarkImporterBase Factory(string type) {
			return (KBookmarkImporterBase) staticInterceptor.Invoke("factory$", "factory(const QString&)", typeof(KBookmarkImporterBase), typeof(string), type);
		}
		protected new IKBookmarkImporterBaseSignals Emit {
			get { return (IKBookmarkImporterBaseSignals) Q_EMIT; }
		}
	}

	public interface IKBookmarkImporterBaseSignals : IQObjectSignals {
		/// <remarks>
		///  Notify about a new bookmark
		///  Use "html" for the icon
		///      </remarks>		<short>    Notify about a new bookmark  Use "html" for the icon      </short>
		[Q_SIGNAL("void newBookmark(QString, QString, QString)")]
		void NewBookmark(string text, string url, string additionalInfo);
		/// <remarks>
		///  Notify about a new folder
		///  Use "bookmark_folder" for the icon
		///      </remarks>		<short>    Notify about a new folder  Use "bookmark_folder" for the icon      </short>
		[Q_SIGNAL("void newFolder(QString, bool, QString)")]
		void NewFolder(string text, bool open, string additionalInfo);
		/// <remarks>
		///  Notify about a new separator
		///      </remarks>		<short>    Notify about a new separator      </short>
		[Q_SIGNAL("void newSeparator()")]
		void NewSeparator();
		/// <remarks>
		///  Tell the outside world that we're going down
		///  one menu
		///      </remarks>		<short>    Tell the outside world that we're going down  one menu      </short>
		[Q_SIGNAL("void endFolder()")]
		void EndFolder();
	}
}
