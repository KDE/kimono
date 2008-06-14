//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	/// <remarks>
	///  This class lets you categorize a view. It is meant to be used along with
	///  KCategorizedView class.
	///  In general terms all you need to do is to reimplement subSortLessThan() and
	///  compareCategories() methods. In order to make categorization work, you need
	///  to also call setCategorizedModel() class to enable it, since the categorization
	///  is disabled by default.
	/// </remarks>		<author> Rafael Fernández López <ereslibre@kde.org>
	///   </author>
	/// 		<short>    This class lets you categorize a view.</short>
	/// 		<see> KCategorizedView</see>
	[SmokeClass("KCategorizedSortFilterProxyModel")]
	public class KCategorizedSortFilterProxyModel : QSortFilterProxyModel, IDisposable {
 		protected KCategorizedSortFilterProxyModel(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KCategorizedSortFilterProxyModel), this);
		}
		public enum AdditionalRoles {
			CategoryDisplayRole = 0x17CE990A,
			CategorySortRole = 0x27857E60,
		}
		public KCategorizedSortFilterProxyModel(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCategorizedSortFilterProxyModel#", "KCategorizedSortFilterProxyModel(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public KCategorizedSortFilterProxyModel() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCategorizedSortFilterProxyModel", "KCategorizedSortFilterProxyModel()", typeof(void));
		}
		/// <remarks>
		///  Overridden from QSortFilterProxyModel. Sorts the source model using
		///  <code>column</code> for the given <code>order.</code>
		///       </remarks>		<short>    Overridden from QSortFilterProxyModel.</short>
		[SmokeMethod("sort(int, Qt::SortOrder)")]
		public override void Sort(int column, Qt.SortOrder order) {
			interceptor.Invoke("sort$$", "sort(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
		}
		[SmokeMethod("sort(int)")]
		public override void Sort(int column) {
			interceptor.Invoke("sort$", "sort(int)", typeof(void), typeof(int), column);
		}
		/// <remarks>
		/// </remarks>		<return> whether the model is categorized or not. Disabled by default.
		///       </return>
		/// 		<short>   </short>
		public bool IsCategorizedModel() {
			return (bool) interceptor.Invoke("isCategorizedModel", "isCategorizedModel() const", typeof(bool));
		}
		/// <remarks>
		///  Enables or disables the categorization feature.
		/// <param> name="categorizedModel" whether to enable or disable the categorization feature.
		///       </param></remarks>		<short>    Enables or disables the categorization feature.</short>
		public void SetCategorizedModel(bool categorizedModel) {
			interceptor.Invoke("setCategorizedModel$", "setCategorizedModel(bool)", typeof(void), typeof(bool), categorizedModel);
		}
		/// <remarks>
		/// </remarks>		<return> the column being used for sorting.
		///       </return>
		/// 		<short>   </short>
		public int SortColumn() {
			return (int) interceptor.Invoke("sortColumn", "sortColumn() const", typeof(int));
		}
		/// <remarks>
		/// </remarks>		<return> the sort order being used for sorting.
		///       </return>
		/// 		<short>   </short>
		public new Qt.SortOrder SortOrder() {
			return (Qt.SortOrder) interceptor.Invoke("sortOrder", "sortOrder() const", typeof(Qt.SortOrder));
		}
		/// <remarks>
		///  Set if the sorting using CategorySortRole will use a natural comparison
		///  in the case that strings were returned. If enabled, string.LocaleAwareCompare
		///  will be used for sorting.
		/// <param> name="sortCategoriesByNaturalComparison" whether to sort using a natural comparison or not.
		///       </param></remarks>		<short>    Set if the sorting using CategorySortRole will use a natural comparison  in the case that strings were returned.</short>
		public void SetSortCategoriesByNaturalComparison(bool sortCategoriesByNaturalComparison) {
			interceptor.Invoke("setSortCategoriesByNaturalComparison$", "setSortCategoriesByNaturalComparison(bool)", typeof(void), typeof(bool), sortCategoriesByNaturalComparison);
		}
		/// <remarks>
		/// </remarks>		<return> whether it is being used a natural comparison for sorting. Enabled by default.
		///       </return>
		/// 		<short>   </short>
		public bool SortCategoriesByNaturalComparison() {
			return (bool) interceptor.Invoke("sortCategoriesByNaturalComparison", "sortCategoriesByNaturalComparison() const", typeof(bool));
		}
		/// <remarks>
		///  Overridden from QSortFilterProxyModel. If you are subclassing
		///  KCategorizedSortFilterProxyModel, you will probably not need to reimplement this
		///  method.
		///  It calls compareCategories() to sort by category.  If the both items are in the
		///  same category (i.e. compareCategories returns 0), then subSortLessThan is called.
		///  @warning You usually won't need to reimplement this method when subclassing
		///           from KCategorizedSortFilterProxyModel.
		///       </remarks>		<return> Returns true if the item <code>left</code> is less than the item <code>right</code> when sorting.
		/// </return>
		/// 		<short>    Overridden from QSortFilterProxyModel.</short>
		[SmokeMethod("lessThan(const QModelIndex&, const QModelIndex&) const")]
		protected override bool LessThan(QModelIndex left, QModelIndex right) {
			return (bool) interceptor.Invoke("lessThan##", "lessThan(const QModelIndex&, const QModelIndex&) const", typeof(bool), typeof(QModelIndex), left, typeof(QModelIndex), right);
		}
		/// <remarks>
		///  This method has a similar purpose as lessThan() has on QSortFilterProxyModel.
		///  It is used for sorting items that are in the same category.
		/// </remarks>		<return> Returns true if the item <code>left</code> is less than the item <code>right</code> when sorting.
		///       </return>
		/// 		<short>    This method has a similar purpose as lessThan() has on QSortFilterProxyModel.</short>
		[SmokeMethod("subSortLessThan(const QModelIndex&, const QModelIndex&) const")]
		protected virtual bool SubSortLessThan(QModelIndex left, QModelIndex right) {
			return (bool) interceptor.Invoke("subSortLessThan##", "subSortLessThan(const QModelIndex&, const QModelIndex&) const", typeof(bool), typeof(QModelIndex), left, typeof(QModelIndex), right);
		}
		/// <remarks>
		///  This method compares the category of the <code>left</code> index with the category
		///  of the <code>right</code> index.
		///  Internally and if not reimplemented, this method will ask for <code>left</code> and
		///  <code>right</code> models for role CategorySortRole. In order to correctly sort
		///  categories, the data() metod of the model should return a qlonglong (or numeric) value, or
		///  a string object. string objects will be sorted with string.LocaleAwareCompare if
		///  sortCategoriesByNaturalComparison() is true.
		///  @note Please have present that:
		///        string(char(char.ObjectReplacementCharacter)) >
		///        string(char(char.ReplacementCharacter)) >
		///        [ all possible strings ] >
		///        string();
		///        This means that string() will be sorted the first one, while
		///        string(char(char.ObjectReplacementCharacter)) and
		///        string(char(char.ReplacementCharacter)) will be sorted in last
		///        position.
		///  @warning Please note that data() method of the model should return always
		///           information of the same type. If you return a string for an index,
		///           you should return always strings for all indexes for role CategorySortRole
		///           in order to correctly sort categories. You can't mix by returning
		///           a string for one index, and a qlonglong for other.
		///  @note If you need a more complex layout, you will have to reimplement this
		///        method.
		/// </remarks>		<return> A negative value if the category of <code>left</code> should be placed before the
		///          category of <code>right.</code> 0 if <code>left</code> and <code>right</code> are on the same category, and
		///          a positive value if the category of <code>left</code> should be placed after the
		///          category of <code>right.</code>
		///       </return>
		/// 		<short>    This method compares the category of the <code>left</code> index with the category  of the <code>right</code> index.</short>
		[SmokeMethod("compareCategories(const QModelIndex&, const QModelIndex&) const")]
		protected virtual int CompareCategories(QModelIndex left, QModelIndex right) {
			return (int) interceptor.Invoke("compareCategories##", "compareCategories(const QModelIndex&, const QModelIndex&) const", typeof(int), typeof(QModelIndex), left, typeof(QModelIndex), right);
		}
		~KCategorizedSortFilterProxyModel() {
			interceptor.Invoke("~KCategorizedSortFilterProxyModel", "~KCategorizedSortFilterProxyModel()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KCategorizedSortFilterProxyModel", "~KCategorizedSortFilterProxyModel()", typeof(void));
		}
		protected new IKCategorizedSortFilterProxyModelSignals Emit {
			get { return (IKCategorizedSortFilterProxyModelSignals) Q_EMIT; }
		}
	}

	public interface IKCategorizedSortFilterProxyModelSignals : IQSortFilterProxyModelSignals {
	}
}
