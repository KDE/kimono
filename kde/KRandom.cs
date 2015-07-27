//Auto-generated by kalyptus. DO NOT EDIT.
namespace KRandom {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \headerfile krandom.h <KRandom>
    ///  This namespace provides methods which generate random data.
    ///  </remarks>        <short> Helper class to create random data.</short>
    [SmokeClass("KRandom")]
    public class Global {
        private static SmokeInvocation staticInterceptor = null;
        static Global() {
            staticInterceptor = new SmokeInvocation(typeof(Global), null);
        }
        /// <remarks>
        ///  Generates a uniform random number.
        /// </remarks>        <return> A random number in the range [0, RAND_MAX). The RNG is seeded
        ///    on first use.
        ///      </return>
        ///         <short>    Generates a uniform random number.</short>
        public static int Random() {
            return (int) staticInterceptor.Invoke("random", "random()", typeof(int));
        }
        /// <remarks>
        ///  Generates a random string.  It operates in the range [A-Za-z0-9]
        /// <param> name="length" Generate a string of this length.
        /// </param></remarks>        <return> the random string
        ///      </return>
        ///         <short>    Generates a random string.</short>
        public static string RandomString(int length) {
            return (string) staticInterceptor.Invoke("randomString$", "randomString(int)", typeof(string), typeof(int), length);
        }
    }
}