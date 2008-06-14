//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  This class is used to store information about a program. It can store
	///  such values as version number, program name, home page, email address
	///  for bug reporting, multiple authors and contributors
	///  (using KAboutPerson), license and copyright information.
	///  Currently, the values set here are shown by the "About" box
	///  (see KAboutDialog), used by the bug report dialog (see KBugReport),
	///  and by the help shown on command line (see KCmdLineArgs).
	///  They are also used for the icon and the name of the program's windows.
	///  @note Instead of the more usual i18n calls, for translatable text the ki18n
	///  calls are used to produce KLocalizedStrings, which can delay the translation
	///  lookup. This is necessary because the translation catalogs are usually not
	///  yet initialized at the point where KAboutData is constructed.
	/// </remarks>		<author> Espen Sand (espen@kde.org), David Faure (faure@kde.org)
	///  </author>
	/// 		<short> Holds information needed by the "About" box and other  classes. </short>
	[SmokeClass("KAboutData")]
	public class KAboutData : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KAboutData(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KAboutData), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KAboutData() {
			staticInterceptor = new SmokeInvocation(typeof(KAboutData), null);
		}
		/// <remarks>
		///  Describes the license of the software.
		///    </remarks>		<short>    Describes the license of the software.</short>
		public enum LicenseKey {
			License_Custom = -2,
			License_File = -1,
			License_Unknown = 0,
			License_GPL = 1,
			License_GPL_V2 = 1,
			License_LGPL = 2,
			License_LGPL_V2 = 2,
			License_BSD = 3,
			License_Artistic = 4,
			License_QPL = 5,
			License_QPL_V1_0 = 5,
			License_GPL_V3 = 6,
			License_LGPL_V3 = 7,
		}
		/// <remarks>
		///  Format of the license name.
		///    </remarks>		<short>    Format of the license name.</short>
		public enum NameFormat {
			ShortName = 0,
			FullName = 1,
		}
		/// <remarks>
		///  Constructor.
		/// <param> name="appName" The program name used internally. Example: "kedit"
		/// </param><param> name="catalogName" The translation catalog name; if null or empty, the
		///         <code>appName</code> will be used. You may want the catalog name to
		///         differ from program name, for example, when you want to group
		///         translations of several smaller utilities under the same catalog.
		/// </param><param> name="programName" A displayable program name string. This string
		///         should be marked for translation. Example: ki18n("KEdit")
		/// </param><param> name="version" The program version string.
		/// </param><param> name="shortDescription" A short description of what the program does.
		///         This string should be marked for translation.
		///         Example: ki18n("A simple text editor.")
		/// </param><param> name="licenseType" The license identifier. Use setLicenseText or
		///               setLicenseTextFile if you use a license not predefined here.
		/// </param><param> name="copyrightStatement" A copyright statement, that can look like this:
		///         ki18n("(c) 1999-2000, Name"). The string specified here is
		///         taken verbatim; the author information from addAuthor is not used.
		/// </param><param> name="text" Some free form text, that can contain any kind of
		///         information. The text can contain newlines. This string
		///         should be marked for translation.
		/// </param><param> name="homePageAddress" The program homepage string.
		///         Start the address with "http://". "http://some.domain" is
		///         is correct, "some.domain" is not.
		///  IMPORTANT: if you set a home page address, this will change the "organization domain"
		///  of the application, which is used for automatic DBUS registration.
		/// </param><param> name="bugsEmailAddress" The bug report email address string.
		///         This defaults to the kde.org bug system.
		/// </param>     </remarks>		<short>    Constructor.</short>
		/// 		<see> setOrganizationDomain</see>
		public KAboutData(QByteArray appName, QByteArray catalogName, KLocalizedString programName, QByteArray version, KLocalizedString shortDescription, KAboutData.LicenseKey licenseType, KLocalizedString copyrightStatement, KLocalizedString text, QByteArray homePageAddress, QByteArray bugsEmailAddress) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData#####$####", "KAboutData(const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&, KAboutData::LicenseKey, const KLocalizedString&, const KLocalizedString&, const QByteArray&, const QByteArray&)", typeof(void), typeof(QByteArray), appName, typeof(QByteArray), catalogName, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), shortDescription, typeof(KAboutData.LicenseKey), licenseType, typeof(KLocalizedString), copyrightStatement, typeof(KLocalizedString), text, typeof(QByteArray), homePageAddress, typeof(QByteArray), bugsEmailAddress);
		}
		public KAboutData(QByteArray appName, QByteArray catalogName, KLocalizedString programName, QByteArray version, KLocalizedString shortDescription, KAboutData.LicenseKey licenseType, KLocalizedString copyrightStatement, KLocalizedString text, QByteArray homePageAddress) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData#####$###", "KAboutData(const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&, KAboutData::LicenseKey, const KLocalizedString&, const KLocalizedString&, const QByteArray&)", typeof(void), typeof(QByteArray), appName, typeof(QByteArray), catalogName, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), shortDescription, typeof(KAboutData.LicenseKey), licenseType, typeof(KLocalizedString), copyrightStatement, typeof(KLocalizedString), text, typeof(QByteArray), homePageAddress);
		}
		public KAboutData(QByteArray appName, QByteArray catalogName, KLocalizedString programName, QByteArray version, KLocalizedString shortDescription, KAboutData.LicenseKey licenseType, KLocalizedString copyrightStatement, KLocalizedString text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData#####$##", "KAboutData(const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&, KAboutData::LicenseKey, const KLocalizedString&, const KLocalizedString&)", typeof(void), typeof(QByteArray), appName, typeof(QByteArray), catalogName, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), shortDescription, typeof(KAboutData.LicenseKey), licenseType, typeof(KLocalizedString), copyrightStatement, typeof(KLocalizedString), text);
		}
		public KAboutData(QByteArray appName, QByteArray catalogName, KLocalizedString programName, QByteArray version, KLocalizedString shortDescription, KAboutData.LicenseKey licenseType, KLocalizedString copyrightStatement) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData#####$#", "KAboutData(const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&, KAboutData::LicenseKey, const KLocalizedString&)", typeof(void), typeof(QByteArray), appName, typeof(QByteArray), catalogName, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), shortDescription, typeof(KAboutData.LicenseKey), licenseType, typeof(KLocalizedString), copyrightStatement);
		}
		public KAboutData(QByteArray appName, QByteArray catalogName, KLocalizedString programName, QByteArray version, KLocalizedString shortDescription, KAboutData.LicenseKey licenseType) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData#####$", "KAboutData(const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&, KAboutData::LicenseKey)", typeof(void), typeof(QByteArray), appName, typeof(QByteArray), catalogName, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), shortDescription, typeof(KAboutData.LicenseKey), licenseType);
		}
		public KAboutData(QByteArray appName, QByteArray catalogName, KLocalizedString programName, QByteArray version, KLocalizedString shortDescription) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData#####", "KAboutData(const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&, const KLocalizedString&)", typeof(void), typeof(QByteArray), appName, typeof(QByteArray), catalogName, typeof(KLocalizedString), programName, typeof(QByteArray), version, typeof(KLocalizedString), shortDescription);
		}
		public KAboutData(QByteArray appName, QByteArray catalogName, KLocalizedString programName, QByteArray version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData####", "KAboutData(const QByteArray&, const QByteArray&, const KLocalizedString&, const QByteArray&)", typeof(void), typeof(QByteArray), appName, typeof(QByteArray), catalogName, typeof(KLocalizedString), programName, typeof(QByteArray), version);
		}
		/// <remarks>
		///  Copy constructor.  Performs a deep copy.
		/// <param> name="other" object to copy
		///      </param></remarks>		<short>    Copy constructor.</short>
		public KAboutData(KAboutData other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KAboutData#", "KAboutData(const KAboutData&)", typeof(void), typeof(KAboutData), other);
		}
		/// <remarks>
		///  Defines an author.
		///  You can call this function as many times as you need. Each entry is
		///  appended to a list. The person in the first entry is assumed to be
		///  the leader of the project.
		/// <param> name="name" The developer's name. It should be marked for translation
		///              like this: ki18n("Developer Name")
		/// </param><param> name="task" What the person is responsible for. This text can contain
		///              newlines. It should be marked for translation like this:
		///              ki18n("Task description..."). Can be left empty.
		/// </param><param> name="emailAddress" An Email address where the person can be reached.
		///                      Can be left empty.
		/// </param><param> name="webAddress" The person's homepage or a relevant link.
		///         Start the address with "http://". "http://some.domain" is
		///         correct, "some.domain" is not. Can be left empty.
		/// </param>     </remarks>		<short>    Defines an author.</short>
		public KAboutData AddAuthor(KLocalizedString name, KLocalizedString task, QByteArray emailAddress, QByteArray webAddress) {
			return (KAboutData) interceptor.Invoke("addAuthor####", "addAuthor(const KLocalizedString&, const KLocalizedString&, const QByteArray&, const QByteArray&)", typeof(KAboutData), typeof(KLocalizedString), name, typeof(KLocalizedString), task, typeof(QByteArray), emailAddress, typeof(QByteArray), webAddress);
		}
		public KAboutData AddAuthor(KLocalizedString name, KLocalizedString task, QByteArray emailAddress) {
			return (KAboutData) interceptor.Invoke("addAuthor###", "addAuthor(const KLocalizedString&, const KLocalizedString&, const QByteArray&)", typeof(KAboutData), typeof(KLocalizedString), name, typeof(KLocalizedString), task, typeof(QByteArray), emailAddress);
		}
		public KAboutData AddAuthor(KLocalizedString name, KLocalizedString task) {
			return (KAboutData) interceptor.Invoke("addAuthor##", "addAuthor(const KLocalizedString&, const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), name, typeof(KLocalizedString), task);
		}
		public KAboutData AddAuthor(KLocalizedString name) {
			return (KAboutData) interceptor.Invoke("addAuthor#", "addAuthor(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), name);
		}
		/// <remarks>
		///  Defines a person that deserves credit.
		///  You can call this function as many times as you need. Each entry
		///  is appended to a list.
		/// <param> name="name" The person's name. It should be marked for translation
		///              like this: ki18n("Contributor Name")
		/// </param><param> name="task" What the person has done to deserve the honor. The
		///         text can contain newlines. It should be marked for
		///         translation like this: ki18n("Task description...")
		///         Can be left empty.
		/// </param><param> name="emailAddress" An email address when the person can be reached.
		///         Can be left empty.
		/// </param><param> name="webAddress" The person's homepage or a relevant link.
		///         Start the address with "http://". "http://some.domain" is
		///         is correct, "some.domain" is not. Can be left empty.
		/// </param>     </remarks>		<short>    Defines a person that deserves credit.</short>
		public KAboutData AddCredit(KLocalizedString name, KLocalizedString task, QByteArray emailAddress, QByteArray webAddress) {
			return (KAboutData) interceptor.Invoke("addCredit####", "addCredit(const KLocalizedString&, const KLocalizedString&, const QByteArray&, const QByteArray&)", typeof(KAboutData), typeof(KLocalizedString), name, typeof(KLocalizedString), task, typeof(QByteArray), emailAddress, typeof(QByteArray), webAddress);
		}
		public KAboutData AddCredit(KLocalizedString name, KLocalizedString task, QByteArray emailAddress) {
			return (KAboutData) interceptor.Invoke("addCredit###", "addCredit(const KLocalizedString&, const KLocalizedString&, const QByteArray&)", typeof(KAboutData), typeof(KLocalizedString), name, typeof(KLocalizedString), task, typeof(QByteArray), emailAddress);
		}
		public KAboutData AddCredit(KLocalizedString name, KLocalizedString task) {
			return (KAboutData) interceptor.Invoke("addCredit##", "addCredit(const KLocalizedString&, const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), name, typeof(KLocalizedString), task);
		}
		public KAboutData AddCredit(KLocalizedString name) {
			return (KAboutData) interceptor.Invoke("addCredit#", "addCredit(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), name);
		}
		/// <remarks>
		///  @brief Sets the name(s) of the translator(s) of the GUI.
		///  Since this depends on the language, just use a dummy text marked for
		///  translation.
		///  The canonical use is:
		///  <pre>
		///  setTranslator(ki18nc("NAME OF TRANSLATORS", "Your names"),
		///                ki18nc("EMAIL OF TRANSLATORS", "Your emails"));
		///  </pre>
		///  The translator can then translate this dummy text with his name
		///  or with a list of names separated with ",".
		///  If there is no translation or the application is used with the
		///  default language, this function call is ignored.
		/// <param> name="name" the name(s) of the translator(s)
		/// </param><param> name="emailAddress" the email address(es) of the translator(s)
		/// </param></remarks>		<short>    @brief Sets the name(s) of the translator(s) of the GUI.</short>
		/// 		<see> KAboutTranslator</see>
		public KAboutData SetTranslator(KLocalizedString name, KLocalizedString emailAddress) {
			return (KAboutData) interceptor.Invoke("setTranslator##", "setTranslator(const KLocalizedString&, const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), name, typeof(KLocalizedString), emailAddress);
		}
		/// <remarks>
		///  Defines a license text, which is marked for translation.
		///  Example:
		///  <pre>
		///  setLicenseText( ki18n("This is my license") );
		///  </pre>
		/// <param> name="license" The license text.
		///      </param></remarks>		<short>    Defines a license text, which is marked for translation.</short>
		public KAboutData SetLicenseText(KLocalizedString license) {
			return (KAboutData) interceptor.Invoke("setLicenseText#", "setLicenseText(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), license);
		}
		/// <remarks>
		///  Adds a license text, which is marked for translation.
		///  If there is only one unknown license set, e.g. by using the default
		///  parameter in the constructor, that one is replaced.
		///  Example:
		///  <pre>
		///  addLicenseText( ki18n("This is my license") );
		///  </pre>
		/// <param> name="license" The license text.
		/// </param></remarks>		<short>    Adds a license text, which is marked for translation.</short>
		/// 		<see> setLicenseText</see>
		/// 		<see> addLicense</see>
		/// 		<see> addLicenseTextFile</see>
		public KAboutData AddLicenseText(KLocalizedString license) {
			return (KAboutData) interceptor.Invoke("addLicenseText#", "addLicenseText(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), license);
		}
		/// <remarks>
		///  Defines a license text by pointing to a file where it resides.
		///  The file format has to be plain text in an encoding compatible to the locale.
		/// <param> name="file" Path to the file in the local filesystem containing the license text.
		///      </param></remarks>		<short>    Defines a license text by pointing to a file where it resides.</short>
		public KAboutData SetLicenseTextFile(string file) {
			return (KAboutData) interceptor.Invoke("setLicenseTextFile$", "setLicenseTextFile(const QString&)", typeof(KAboutData), typeof(string), file);
		}
		/// <remarks>
		///  Adds a license text by pointing to a file where it resides.
		///  The file format has to be plain text in an encoding compatible to the locale.
		///  If there is only one unknown license set, e.g. by using the default
		///  parameter in the constructor, that one is replaced.
		/// <param> name="file" Path to the file in the local filesystem containing the license text.
		/// </param></remarks>		<short>    Adds a license text by pointing to a file where it resides.</short>
		/// 		<see> addLicenseText</see>
		/// 		<see> addLicense</see>
		/// 		<see> setLicenseTextFile</see>
		public KAboutData AddLicenseTextFile(string file) {
			return (KAboutData) interceptor.Invoke("addLicenseTextFile$", "addLicenseTextFile(const QString&)", typeof(KAboutData), typeof(string), file);
		}
		/// <remarks>
		///  Defines the program name used internally.
		/// <param> name="appName" The application name. Example: "kate".
		///      </param></remarks>		<short>    Defines the program name used internally.</short>
		public KAboutData SetAppName(QByteArray appName) {
			return (KAboutData) interceptor.Invoke("setAppName#", "setAppName(const QByteArray&)", typeof(KAboutData), typeof(QByteArray), appName);
		}
		/// <remarks>
		///  Defines the displayable program name string.
		/// <param> name="programName" The program name. This string should be
		///         marked for translation.
		///         Example: ki18n("Advanced Text Editor").
		///      </param></remarks>		<short>    Defines the displayable program name string.</short>
		public KAboutData SetProgramName(KLocalizedString programName) {
			return (KAboutData) interceptor.Invoke("setProgramName#", "setProgramName(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), programName);
		}
		/// <remarks>
		///  Defines the program icon.
		///  Use this if you need to have an application icon
		///  whose name is different than the application name.
		/// <param> name="iconName" name of the icon. Example: "accessories-text-editor"
		/// </param></remarks>		<short>    Defines the program icon.</short>
		/// 		<see> programIconName</see>
		public KAboutData SetProgramIconName(string iconName) {
			return (KAboutData) interceptor.Invoke("setProgramIconName$", "setProgramIconName(const QString&)", typeof(KAboutData), typeof(string), iconName);
		}
		/// <remarks>
		///  Defines the program logo.
		///  Use this if you need to have an application logo
		///  in AboutData other than the application icon.
		///  Because KAboutData is in kdecore it cannot use QImage directly,
		///  so this is a QVariant that should contain a QImage.
		/// <param> name="image" logo image.
		/// </param></remarks>		<short>    Defines the program logo.</short>
		/// 		<see> programLogo</see>
		public KAboutData SetProgramLogo(QVariant image) {
			return (KAboutData) interceptor.Invoke("setProgramLogo#", "setProgramLogo(const QVariant&)", typeof(KAboutData), typeof(QVariant), image);
		}
		/// <remarks>
		///  Defines the program version string.
		/// <param> name="version" The program version.
		///      </param></remarks>		<short>    Defines the program version string.</short>
		public KAboutData SetVersion(QByteArray version) {
			return (KAboutData) interceptor.Invoke("setVersion#", "setVersion(const QByteArray&)", typeof(KAboutData), typeof(QByteArray), version);
		}
		/// <remarks>
		///  Defines a short description of what the program does.
		/// <param> name="shortDescription" The program description. This string should
		///         be marked for translation. Example: ki18n("An advanced text
		///         editor with syntax highlighting support.").
		///      </param></remarks>		<short>    Defines a short description of what the program does.</short>
		public KAboutData SetShortDescription(KLocalizedString shortDescription) {
			return (KAboutData) interceptor.Invoke("setShortDescription#", "setShortDescription(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), shortDescription);
		}
		/// <remarks>
		///  Defines the translation catalog that the program uses.
		/// <param> name="catalogName" The translation catalog name.
		///      </param></remarks>		<short>    Defines the translation catalog that the program uses.</short>
		public KAboutData SetCatalogName(QByteArray catalogName) {
			return (KAboutData) interceptor.Invoke("setCatalogName#", "setCatalogName(const QByteArray&)", typeof(KAboutData), typeof(QByteArray), catalogName);
		}
		/// <remarks>
		///  Defines the license identifier.
		/// <param> name="licenseKey" The license identifier.
		/// </param></remarks>		<short>    Defines the license identifier.</short>
		/// 		<see> addLicenseText</see>
		/// 		<see> setLicenseText</see>
		/// 		<see> setLicenseTextFile</see>
		public KAboutData SetLicense(KAboutData.LicenseKey licenseKey) {
			return (KAboutData) interceptor.Invoke("setLicense$", "setLicense(KAboutData::LicenseKey)", typeof(KAboutData), typeof(KAboutData.LicenseKey), licenseKey);
		}
		/// <remarks>
		///  Adds a license identifier.
		///  If there is only one unknown license set, e.g. by using the default
		///  parameter in the constructor, that one is replaced.
		/// <param> name="licenseKey" The license identifier.
		/// </param></remarks>		<short>    Adds a license identifier.</short>
		/// 		<see> setLicenseText</see>
		/// 		<see> addLicenseText</see>
		/// 		<see> addLicenseTextFile</see>
		public KAboutData AddLicense(KAboutData.LicenseKey licenseKey) {
			return (KAboutData) interceptor.Invoke("addLicense$", "addLicense(KAboutData::LicenseKey)", typeof(KAboutData), typeof(KAboutData.LicenseKey), licenseKey);
		}
		/// <remarks>
		///  Defines the copyright statement to show when displaying the license.
		/// <param> name="copyrightStatement" A copyright statement, that can look like
		///         this: ki18n("(c) 1999-2000, Name"). The string specified here is
		///         taken verbatim; the author information from addAuthor is not used.
		///      </param></remarks>		<short>    Defines the copyright statement to show when displaying the license.</short>
		public KAboutData SetCopyrightStatement(KLocalizedString copyrightStatement) {
			return (KAboutData) interceptor.Invoke("setCopyrightStatement#", "setCopyrightStatement(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), copyrightStatement);
		}
		/// <remarks>
		///  Defines the additional text to show in the about dialog.
		/// <param> name="otherText" Some free form text, that can contain any kind of
		///         information. The text can contain newlines. This string
		///         should be marked for translation.
		///      </param></remarks>		<short>    Defines the additional text to show in the about dialog.</short>
		public KAboutData SetOtherText(KLocalizedString otherText) {
			return (KAboutData) interceptor.Invoke("setOtherText#", "setOtherText(const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), otherText);
		}
		/// <remarks>
		///  Defines the program homepage.
		/// <param> name="homepage" The program homepage string.
		///         Start the address with "http://". "http://kate.kde.org"
		///         is correct but "kate.kde.org" is not.
		///      </param></remarks>		<short>    Defines the program homepage.</short>
		public KAboutData SetHomepage(QByteArray homepage) {
			return (KAboutData) interceptor.Invoke("setHomepage#", "setHomepage(const QByteArray&)", typeof(KAboutData), typeof(QByteArray), homepage);
		}
		/// <remarks>
		///  Defines the address where bug reports should be sent.
		/// <param> name="bugAddress" The bug report email address string.
		///         This defaults to the kde.org bug system.
		///      </param></remarks>		<short>    Defines the address where bug reports should be sent.</short>
		public KAboutData SetBugAddress(QByteArray bugAddress) {
			return (KAboutData) interceptor.Invoke("setBugAddress#", "setBugAddress(const QByteArray&)", typeof(KAboutData), typeof(QByteArray), bugAddress);
		}
		/// <remarks>
		///  Defines the Internet domain of the organization that wrote this application.
		///  The domain is set to kde.org by default, or the domain of the homePageAddress constructor argument,
		///  if set.
		///  Make sure to call setOrganizationDomain if your product is developed out of the
		///  kde.org version-control system.
		///  Used by the automatic registration to DBus done by KApplication and KUniqueApplication.
		///  IMPORTANT: if the organization domain is set, the .desktop file that describes your
		///  application should have an entry like X-DBUS-ServiceName=reversed_domain.kmyapp
		///  For instance kwrite passes "http://www.kate-editor.org" as the homePageAddress so it needs
		///  X-DBUS-ServiceName=org.kate-editor.kwrite in its kwrite.desktop file.
		/// <param> name="domain" the domain name, for instance kde.org, koffice.org, kdevelop.org, etc.
		///      </param></remarks>		<short>    Defines the Internet domain of the organization that wrote this application.</short>
		public KAboutData SetOrganizationDomain(QByteArray domain) {
			return (KAboutData) interceptor.Invoke("setOrganizationDomain#", "setOrganizationDomain(const QByteArray&)", typeof(KAboutData), typeof(QByteArray), domain);
		}
		/// <remarks>
		///  Defines the product name which will be used in the KBugReport dialog.
		///  By default it's the appName, but you can overwrite it here to provide
		///  support for special components e.g. in the form 'product/component',
		///  such as 'kontact/summary'.
		/// <param> name="name" The name of product
		///      </param></remarks>		<short>    Defines the product name which will be used in the KBugReport dialog.</short>
		public KAboutData SetProductName(QByteArray name) {
			return (KAboutData) interceptor.Invoke("setProductName#", "setProductName(const QByteArray&)", typeof(KAboutData), typeof(QByteArray), name);
		}
		/// <remarks>
		///  Returns the application's internal name.
		/// </remarks>		<return> the internal program name.
		///      </return>
		/// 		<short>    Returns the application's internal name.</short>
		public string AppName() {
			return (string) interceptor.Invoke("appName", "appName() const", typeof(string));
		}
		/// <remarks>
		///  Returns the application's product name, which will be used in KBugReport
		///  dialog. By default it returns appName(), otherwise the one which is set
		///  with setProductName()
		/// </remarks>		<return> the product name.
		///      </return>
		/// 		<short>    Returns the application's product name, which will be used in KBugReport  dialog.</short>
		public string ProductName() {
			return (string) interceptor.Invoke("productName", "productName() const", typeof(string));
		}
		/// <remarks>
		///  Returns the translated program name.
		/// </remarks>		<return> the program name (translated).
		///      </return>
		/// 		<short>    Returns the translated program name.</short>
		public string ProgramName() {
			return (string) interceptor.Invoke("programName", "programName() const", typeof(string));
		}
		/// <remarks>
		///  Returns the domain name of the organization that wrote this application.
		///  Used by the automatic registration to DBus done by KApplication and KUniqueApplication.
		///      </remarks>		<short>    Returns the domain name of the organization that wrote this application.</short>
		public string OrganizationDomain() {
			return (string) interceptor.Invoke("organizationDomain", "organizationDomain() const", typeof(string));
		}
		/// <remarks>
		///  Provided for use by KCrash
		///      </remarks>		<short>   </short>
		public string InternalProgramName() {
			return (string) interceptor.Invoke("internalProgramName", "internalProgramName() const", typeof(string));
		}
		/// <remarks>
		///  Provided for use by KCrash
		///      </remarks>		<short>   </short>
		public void TranslateInternalProgramName() {
			interceptor.Invoke("translateInternalProgramName", "translateInternalProgramName() const", typeof(void));
		}
		/// <remarks>
		///  Returns the program's icon name.
		///  The default value is <code>appName</code> .
		///  Use <code>setProgramIconName</code> if you need to have an icon
		///  whose name is different from the internal application name.
		/// </remarks>		<return> the program's icon name.
		/// </return>
		/// 		<short>    Returns the program's icon name.</short>
		/// 		<see> setProgramIconName</see>
		public string ProgramIconName() {
			return (string) interceptor.Invoke("programIconName", "programIconName() const", typeof(string));
		}
		/// <remarks>
		///  Returns the program logo image.
		///  Because KAboutData is in kdecore it cannot use QImage directly,
		///  so this is a QVariant containing a QImage.
		/// </remarks>		<return> the program logo data, or a null image if there is
		///          no custom application logo defined.
		///      </return>
		/// 		<short>    Returns the program logo image.</short>
		public QVariant ProgramLogo() {
			return (QVariant) interceptor.Invoke("programLogo", "programLogo() const", typeof(QVariant));
		}
		/// <remarks>
		///  Returns the program's version.
		/// </remarks>		<return> the version string.
		///      </return>
		/// 		<short>    Returns the program's version.</short>
		public string Version() {
			return (string) interceptor.Invoke("version", "version() const", typeof(string));
		}
		/// <remarks>
		///  Provided for use by KCrash
		///      </remarks>		<short>   </short>
		public string InternalVersion() {
			return (string) interceptor.Invoke("internalVersion", "internalVersion() const", typeof(string));
		}
		/// <remarks>
		///  Returns a short, translated description.
		/// </remarks>		<return> the short description (translated). Can be
		///          string() if not set.
		///      </return>
		/// 		<short>    Returns a short, translated description.</short>
		public string ShortDescription() {
			return (string) interceptor.Invoke("shortDescription", "shortDescription() const", typeof(string));
		}
		/// <remarks>
		///  Returns the program's translation catalog name.
		/// </remarks>		<return> the catalog name.
		///      </return>
		/// 		<short>    Returns the program's translation catalog name.</short>
		public string CatalogName() {
			return (string) interceptor.Invoke("catalogName", "catalogName() const", typeof(string));
		}
		/// <remarks>
		///  Returns the application homepage.
		/// </remarks>		<return> the application homepage URL. Can be string() if
		///          not set.
		///      </return>
		/// 		<short>    Returns the application homepage.</short>
		public string Homepage() {
			return (string) interceptor.Invoke("homepage", "homepage() const", typeof(string));
		}
		/// <remarks>
		///  Returns the email address for bugs.
		/// </remarks>		<return> the email address where to report bugs.
		///      </return>
		/// 		<short>    Returns the email address for bugs.</short>
		public string BugAddress() {
			return (string) interceptor.Invoke("bugAddress", "bugAddress() const", typeof(string));
		}
		/// <remarks>
		///  Provided for use by KCrash
		///      </remarks>		<short>   </short>
		public string InternalBugAddress() {
			return (string) interceptor.Invoke("internalBugAddress", "internalBugAddress() const", typeof(string));
		}
		/// <remarks>
		///  Returns a list of authors.
		/// </remarks>		<return> author information (list of persons).
		///      </return>
		/// 		<short>    Returns a list of authors.</short>
		public List<KAboutPerson> Authors() {
			return (List<KAboutPerson>) interceptor.Invoke("authors", "authors() const", typeof(List<KAboutPerson>));
		}
		/// <remarks>
		///  Returns a list of persons who contributed.
		/// </remarks>		<return> credit information (list of persons).
		///      </return>
		/// 		<short>    Returns a list of persons who contributed.</short>
		public List<KAboutPerson> Credits() {
			return (List<KAboutPerson>) interceptor.Invoke("credits", "credits() const", typeof(List<KAboutPerson>));
		}
		/// <remarks>
		///  Returns a list of translators.
		/// </remarks>		<return> translators information (list of persons)
		///      </return>
		/// 		<short>    Returns a list of translators.</short>
		public List<KAboutPerson> Translators() {
			return (List<KAboutPerson>) interceptor.Invoke("translators", "translators() const", typeof(List<KAboutPerson>));
		}
		/// <remarks>
		///  Returns a translated, free form text.
		/// </remarks>		<return> the free form text (translated). Can be string() if not set.
		///      </return>
		/// 		<short>    Returns a translated, free form text.</short>
		public string OtherText() {
			return (string) interceptor.Invoke("otherText", "otherText() const", typeof(string));
		}
		/// <remarks>
		///  Returns a list of licenses.
		/// </remarks>		<return> licenses information (list of licenses)
		/// </return>
		/// 		<short>    Returns a list of licenses.</short>
		public List<KAboutLicense> Licenses() {
			return (List<KAboutLicense>) interceptor.Invoke("licenses", "licenses() const", typeof(List<KAboutLicense>));
		}
		/// <remarks>
		///  Returns the copyright statement.
		/// </remarks>		<return> the copyright statement. Can be string() if not set.
		///      </return>
		/// 		<short>    Returns the copyright statement.</short>
		public string CopyrightStatement() {
			return (string) interceptor.Invoke("copyrightStatement", "copyrightStatement() const", typeof(string));
		}
		/// <remarks>
		///  Returns the plain text displayed around the list of authors instead
		///  of the default message telling users to send bug reports to bugAddress().
		/// </remarks>		<return> the plain text displayed around the list of authors instead
		///          of the default message.  Can be string().
		///      </return>
		/// 		<short>    Returns the plain text displayed around the list of authors instead  of the default message telling users to send bug reports to bugAddress().</short>
		public string CustomAuthorPlainText() {
			return (string) interceptor.Invoke("customAuthorPlainText", "customAuthorPlainText() const", typeof(string));
		}
		/// <remarks>
		///  Returns the rich text displayed around the list of authors instead
		///  of the default message telling users to send bug reports to bugAddress().
		/// </remarks>		<return> the rich text displayed around the list of authors instead
		///          of the default message.  Can be string().
		///      </return>
		/// 		<short>    Returns the rich text displayed around the list of authors instead  of the default message telling users to send bug reports to bugAddress().</short>
		public string CustomAuthorRichText() {
			return (string) interceptor.Invoke("customAuthorRichText", "customAuthorRichText() const", typeof(string));
		}
		/// <remarks>
		///  Returns whether custom text should be displayed around the list of
		///  authors.
		/// </remarks>		<return> whether custom text should be displayed around the list of
		///          authors.
		///      </return>
		/// 		<short>    Returns whether custom text should be displayed around the list of  authors.</short>
		public bool CustomAuthorTextEnabled() {
			return (bool) interceptor.Invoke("customAuthorTextEnabled", "customAuthorTextEnabled() const", typeof(bool));
		}
		/// <remarks>
		///  Sets the custom text displayed around the list of authors instead
		///  of the default message telling users to send bug reports to bugAddress().
		/// <param> name="plainText" The plain text.
		/// </param><param> name="richText" The rich text.
		/// </param> Setting both to parameters to KLocalizedString() will cause no message to be
		///  displayed at all.  Call unsetCustomAuthorText() to revert to the default
		///  message.
		///      </remarks>		<short>    Sets the custom text displayed around the list of authors instead  of the default message telling users to send bug reports to bugAddress().</short>
		public KAboutData SetCustomAuthorText(KLocalizedString plainText, KLocalizedString richText) {
			return (KAboutData) interceptor.Invoke("setCustomAuthorText##", "setCustomAuthorText(const KLocalizedString&, const KLocalizedString&)", typeof(KAboutData), typeof(KLocalizedString), plainText, typeof(KLocalizedString), richText);
		}
		/// <remarks>
		///  Clears any custom text displayed around the list of authors and falls
		///  back to the default message telling users to send bug reports to
		///  bugAddress().
		///      </remarks>		<short>    Clears any custom text displayed around the list of authors and falls  back to the default message telling users to send bug reports to  bugAddress().</short>
		public KAboutData UnsetCustomAuthorText() {
			return (KAboutData) interceptor.Invoke("unsetCustomAuthorText", "unsetCustomAuthorText()", typeof(KAboutData));
		}
		~KAboutData() {
			interceptor.Invoke("~KAboutData", "~KAboutData()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KAboutData", "~KAboutData()", typeof(void));
		}
		/// <remarks>
		///  Returns a message about the translation team.
		/// </remarks>		<return> a message about the translation team
		///      </return>
		/// 		<short>    Returns a message about the translation team.</short>
		public static string AboutTranslationTeam() {
			return (string) staticInterceptor.Invoke("aboutTranslationTeam", "aboutTranslationTeam()", typeof(string));
		}
	}
}
