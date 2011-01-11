using Qyoto;
using System.Reflection;
using System.Runtime.CompilerServices;

// Version number is the same as the version of the latest Nepomuk
// for which the classes have been generated.
[assembly: AssemblyVersion("2.2.0.0")]

// Unnecessary, as the keyfile is given to the compiler as a parameter.
// It may be useful to have it here, though.
[assembly: AssemblyKeyFile ("key.snk")]

[assembly: AssemblySmokeInitializer(typeof(Nepomuk.InitNepomuk))]
