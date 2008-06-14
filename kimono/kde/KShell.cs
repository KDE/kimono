//Auto-generated by kalyptus. DO NOT EDIT.
namespace KShell {
	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  Flags for splitArgs().
	///      </remarks>		<short>    Flags for splitArgs().</short>
	public enum Option {
		NoOptions = 0,
		TildeExpand = 1,
		AbortOnMeta = 2,
	}
	/// <remarks>
	///  Status codes from splitArgs()
	///      </remarks>		<short>    Status codes from splitArgs()      </short>
	public enum Errors {
		NoError = 0,
		BadQuoting = 1,
		FoundMeta = 2,
	}
	/// <remarks>
	///  \namespace KShell
	///  Emulates some basic system shell functionality.
	/// </remarks>		<short>    \namespace KShell  Emulates some basic system shell functionality.</short>
	/// 		<see> KStringHandler</see>
	[SmokeClass("KShell")]
	public class Global {
		private static SmokeInvocation staticInterceptor = null;
		static Global() {
			staticInterceptor = new SmokeInvocation(typeof(Global), null);
		}
		/// <remarks>
		///  Splits <code>cmd</code> according to system shell word splitting and quoting rules.
		///  Can optionally perform tilde expansion and/or abort if it finds shell
		///  meta characters it cannot process.
		///  On NIX the behavior is based on the POSIX shell and bash:
		///  - Whitespace splits tokens
		///  - The backslash quotes the following character
		///  - A string enclosed in single quotes is not split. No shell meta
		///    characters are interpreted.
		///  - A string enclosed in double quotes is not split. Within the string,
		///    the backslash quotes shell meta characters - if it is followed
		///    by a "meaningless" character, the backslash is output verbatim.
		///  - A string enclosed in $'' is not split. Within the string, the
		///    backslash has a similar meaning to the one in C strings. Consult
		///    the bash manual for more information.
		///  On Windows, the behavior is defined by the Microsoft C runtime. Qt and
		///  many other implementations comply with this standard, but many do not.
		///  - Whitespace splits tokens
		///  - A string enclosed in double quotes is not split
		///    - 2N double quotes within a quoted string yield N literal quotes.
		///      This is not documented on MSDN.
		///  - Backslashes have special semantics iff they are followed by a double
		///    quote:
		///    - 2N backslashes + double quote => N backslashes and begin/end quoting
		///    - 2N+1 backslashes + double quote => N backslashes + literal quote
		///  If AbortOnMeta is used on Windows, this function applies cmd shell
		///  semantics before proceeding with word splitting:
		///  - Cmd ignores <b>all</b> special chars between double quotes.
		///    Note that the quotes are <b>not</b> removed at this stage - the
		///    tokenization rules described above still apply.
		///  - The <code>circumflex</code> is the escape char for everything including
		///    itself.
		/// <param> name="cmd" the command to split
		/// </param><param> name="flags" operation flags, see \ref Option
		/// </param><param> name="err" if not NULL, a status code will be stored at the pointer
		///   target, see \ref Errors
		/// </param></remarks>		<return> a list of unquoted words or an empty list if an error occurred
		///      </return>
		/// 		<short>    Splits <code>cmd</code> according to system shell word splitting and quoting rules.</short>
		public static List<string> SplitArgs(string cmd, uint flags, KShell.Errors err) {
			return (List<string>) staticInterceptor.Invoke("splitArgs$$$", "splitArgs(const QString&, KShell::Options, KShell::Errors*)", typeof(List<string>), typeof(string), cmd, typeof(uint), flags, typeof(KShell.Errors), err);
		}
		public static List<string> SplitArgs(string cmd, uint flags) {
			return (List<string>) staticInterceptor.Invoke("splitArgs$$", "splitArgs(const QString&, KShell::Options)", typeof(List<string>), typeof(string), cmd, typeof(uint), flags);
		}
		public static List<string> SplitArgs(string cmd) {
			return (List<string>) staticInterceptor.Invoke("splitArgs$", "splitArgs(const QString&)", typeof(List<string>), typeof(string), cmd);
		}
		/// <remarks>
		///  Quotes and joins <code>args</code> together according to system shell rules.
		///  If the output is fed back into splitArgs(), the AbortOnMeta flag
		///  needs to be used on Windows. On NIX, no such requirement exists.
		///  See quoteArg() for more info.
		/// <param> name="args" a list of strings to quote and join
		/// </param></remarks>		<return> a command suitable for shell execution
		///      </return>
		/// 		<short>    Quotes and joins <code>args</code> together according to system shell rules.</short>
		public static string JoinArgs(List<string> args) {
			return (string) staticInterceptor.Invoke("joinArgs?", "joinArgs(const QStringList&)", typeof(string), typeof(List<string>), args);
		}
		/// <remarks>
		///  Quotes <code>arg</code> according to system shell rules.
		///  This function can be used to quote an argument string such that
		///  the shell processes it properly. This is e.g. necessary for
		///  user-provided file names which may contain spaces or quotes.
		///  It also prevents expansion of wild cards and environment variables.
		///  On NIX, the output is POSIX shell compliant.
		///  On Windows, it is compliant with the argument splitting code of the
		///  Microsoft C runtime and the cmd shell used together.
		///  Occurrences of the <code>percent</code> <code>sign</code> are replaced with
		///  <code>\</code>%PERCENT_SIGN% to prevent spurious variable expansion;
		///  related KDE functions are prepared for this.
		/// <param> name="arg" the argument to quote
		/// </param></remarks>		<return> the quoted argument
		///      </return>
		/// 		<short>    Quotes <code>arg</code> according to system shell rules.</short>
		public static string QuoteArg(string arg) {
			return (string) staticInterceptor.Invoke("quoteArg$", "quoteArg(const QString&)", typeof(string), typeof(string), arg);
		}
		/// <remarks>
		///  Performs tilde expansion on <code>path.</code> Interprets "~/path" and
		///  "~user/path". If the path starts with an escaped tilde ("\~" on UNIX,
		///  "^~" on Windows), the escape char is removed and the path is returned
		///  as is.
		/// <param> name="path" the path to tilde-expand
		/// </param></remarks>		<return> the expanded path
		///      </return>
		/// 		<short>    Performs tilde expansion on <code>path.</code></short>
		public static string TildeExpand(string path) {
			return (string) staticInterceptor.Invoke("tildeExpand$", "tildeExpand(const QString&)", typeof(string), typeof(string), path);
		}
	}
}
