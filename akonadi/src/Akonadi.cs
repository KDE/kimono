namespace Akonadi {

	using Qyoto;

	using System;
	using System.Runtime.InteropServices;

	public class InitAkonadi {
		[DllImport("libakonadi-sharp", CharSet=CharSet.Ansi)]
		static extern void Init_akonadi();
		
		public static void InitSmoke() {
			Init_akonadi();
		}
	}
}
