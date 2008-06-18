//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;

	public partial class KCmdLineArgs : Object {
		/// <remarks>
		///  Initialize class.
		///  This function should be called as the very first thing in
		///   your application.
		/// <param> name="argv" As passed to <code>main</code>(...).
		/// </param><param> name="appname" The untranslated name of your application. This should
		///                 match with <code>argv</code>[0].
		/// </param><param> name="catalog" Translation catalog name, if empty <code>appname</code> will be used.
		/// </param><param> name="programName" A program name string to be used for display
		///         purposes. This string should be marked for translation.
		///         Example: ki18n("KEdit")
		/// </param><param> name="version" A version.
		/// </param><param> name="description" A short description of what your application is about.
		///                     Also marked for translation.
		/// </param><param> name="stdargs" KDE/Qt or no default parameters
		///    </param></remarks>		<short>    Initialize class.</short>
		public static void Init(string[] argv, QByteArray appname, QByteArray catalog, KLocalizedString programName, QByteArray version, KLocalizedString description, uint stdargs) {
			string[] args = new string[argv.Length + 1];
			args[0] = System.Reflection.Assembly.GetExecutingAssembly().Location;
			argv.CopyTo(args, 1);
			staticInterceptor.Invoke("init$?#####$", "init(int, char**, const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&, KCmdLineArgs::StdCmdLineArgs)", typeof(void), typeof(int), args.Length, typeof(string[]), args, typeof(QByteArray), appname, typeof(QByteArray), catalog, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), description, typeof(uint), stdargs);
		}
		public static void Init(string[] argv, QByteArray appname, QByteArray catalog, KLocalizedString programName, QByteArray version, KLocalizedString description) {
			string[] args = new string[argv.Length + 1];
			args[0] = System.Reflection.Assembly.GetExecutingAssembly().Location;
			argv.CopyTo(args, 1);
			staticInterceptor.Invoke("init$?#####", "init(int, char**, const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&)", typeof(void), typeof(int), args.Length, typeof(string[]), args, typeof(QByteArray), appname, typeof(QByteArray), catalog, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), description);
		}
		public static void Init(string[] argv, QByteArray appname, QByteArray catalog, KLocalizedString programName, QByteArray version) {
			string[] args = new string[argv.Length + 1];
			args[0] = System.Reflection.Assembly.GetExecutingAssembly().Location;
			argv.CopyTo(args, 1);
			staticInterceptor.Invoke("init$?####", "init(int, char**, const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&)", typeof(void), typeof(int), args.Length, typeof(string[]), args, typeof(QByteArray), appname, typeof(QByteArray), catalog, typeof(KLocalizedString), programName, typeof(QByteArray), version);
		}
		/// <remarks>
		///  Initialize class.
		///  This function should be called as the very first thing in
		///   your application. It uses KAboutData to replace some of the
		///   arguments that would otherwise be required.
		/// <param> name="_argv" As passed to <code>main</code>(...).
		/// </param><param> name="about" A KAboutData object describing your program.
		/// </param><param> name="stdargs" KDE/Qt or no default parameters
		///    </param></remarks>		<short>    Initialize class.</short>
		public static void Init(string[] argv, KAboutData about, uint stdargs) {
			string[] args = new string[argv.Length + 1];
			args[0] = System.Reflection.Assembly.GetExecutingAssembly().Location;
			argv.CopyTo(args, 1);
			staticInterceptor.Invoke("init$?#$", "init(int, char**, const KAboutData*, KCmdLineArgs::StdCmdLineArgs)", typeof(void), typeof(string), args, typeof(KAboutData), about, typeof(uint), stdargs);
		}
		public static void Init(string[] argv, KAboutData about) {
			string[] args = new string[argv.Length + 1];
			args[0] = System.Reflection.Assembly.GetExecutingAssembly().Location;
			argv.CopyTo(args, 1);
			staticInterceptor.Invoke("init$?#", "init(int, char**, const KAboutData*)", typeof(void), typeof(int), args.Length, typeof(string[]), args, typeof(KAboutData), about);
		}
	}
}