//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  This widget provides a checkable list of all available mimetypes,
	///  and a list of selected ones, as well as a corresponding list of file
	///  extensions, an optional text and an optional edit button (not working yet).
	///  Mime types is presented in a list view, with name, comment and patterns columns.
	/// </remarks>		<author> Anders Lund (anders at alweb dk), jan 23, 2002
	///  </author>
	/// 		<short>    This widget provides a checkable list of all available mimetypes,  and a list of selected ones, as well as a corresponding list of file  extensions, an optional text and an optional edit button (not working yet).</short>
	[SmokeClass("KMimeTypeChooser")]
	public class KMimeTypeChooser : KVBox, IDisposable {
 		protected KMimeTypeChooser(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KMimeTypeChooser), this);
		}
		/// <remarks>
		///  Buttons and data for display.
		///      </remarks>		<short>    Buttons and data for display.</short>
		public enum Visuals {
			Comments = 1,
			Patterns = 2,
			EditButton = 4,
		}
		/// <remarks>
		///  Create a new KMimeTypeChooser.
		/// <param> name="text" A Text to display above the list
		/// </param><param> name="selectedMimeTypes" A list of mimetype names, theese will be checked
		///         in the list if they exist.
		/// </param><param> name="visuals" A OR'd Visuals enum to decide which data and buttons to display.
		/// </param><param> name="defaultGroup" The group to open when no groups are selected (like
		///         "text"). If not provided, no group is opened. If <code>groupsToShow</code>
		///         is provided and defaultGroup is not a member of that, it is ignored.
		/// </param><param> name="groupsToShow" a list of mimetype groups to show. If empty, all
		///         groups are shown.
		/// </param><param> name="parent" The parent widget to use
		///      </param></remarks>		<short>    Create a new KMimeTypeChooser.</short>
		public KMimeTypeChooser(string text, List<string> selectedMimeTypes, string defaultGroup, List<string> groupsToShow, int visuals, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMimeTypeChooser$?$?$#", "KMimeTypeChooser(const QString&, const QStringList&, const QString&, const QStringList&, int, QWidget*)", typeof(void), typeof(string), text, typeof(List<string>), selectedMimeTypes, typeof(string), defaultGroup, typeof(List<string>), groupsToShow, typeof(int), visuals, typeof(QWidget), parent);
		}
		public KMimeTypeChooser(string text, List<string> selectedMimeTypes, string defaultGroup, List<string> groupsToShow, int visuals) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMimeTypeChooser$?$?$", "KMimeTypeChooser(const QString&, const QStringList&, const QString&, const QStringList&, int)", typeof(void), typeof(string), text, typeof(List<string>), selectedMimeTypes, typeof(string), defaultGroup, typeof(List<string>), groupsToShow, typeof(int), visuals);
		}
		public KMimeTypeChooser(string text, List<string> selectedMimeTypes, string defaultGroup, List<string> groupsToShow) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMimeTypeChooser$?$?", "KMimeTypeChooser(const QString&, const QStringList&, const QString&, const QStringList&)", typeof(void), typeof(string), text, typeof(List<string>), selectedMimeTypes, typeof(string), defaultGroup, typeof(List<string>), groupsToShow);
		}
		public KMimeTypeChooser(string text, List<string> selectedMimeTypes, string defaultGroup) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMimeTypeChooser$?$", "KMimeTypeChooser(const QString&, const QStringList&, const QString&)", typeof(void), typeof(string), text, typeof(List<string>), selectedMimeTypes, typeof(string), defaultGroup);
		}
		public KMimeTypeChooser(string text, List<string> selectedMimeTypes) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMimeTypeChooser$?", "KMimeTypeChooser(const QString&, const QStringList&)", typeof(void), typeof(string), text, typeof(List<string>), selectedMimeTypes);
		}
		public KMimeTypeChooser(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMimeTypeChooser$", "KMimeTypeChooser(const QString&)", typeof(void), typeof(string), text);
		}
		public KMimeTypeChooser() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KMimeTypeChooser", "KMimeTypeChooser()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> a list of all selected selected mimetypes represented by their name.
		///      </return>
		/// 		<short>   </short>
		public List<string> MimeTypes() {
			return (List<string>) interceptor.Invoke("mimeTypes", "mimeTypes() const", typeof(List<string>));
		}
		/// <remarks>
		/// </remarks>		<return> a list of the fileame patterns associated with all selected mimetypes.
		///      </return>
		/// 		<short>   </short>
		public List<string> Patterns() {
			return (List<string>) interceptor.Invoke("patterns", "patterns() const", typeof(List<string>));
		}
		~KMimeTypeChooser() {
			interceptor.Invoke("~KMimeTypeChooser", "~KMimeTypeChooser()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KMimeTypeChooser", "~KMimeTypeChooser()", typeof(void));
		}
		protected new IKMimeTypeChooserSignals Emit {
			get { return (IKMimeTypeChooserSignals) Q_EMIT; }
		}
	}

	public interface IKMimeTypeChooserSignals : IKVBoxSignals {
	}
}
