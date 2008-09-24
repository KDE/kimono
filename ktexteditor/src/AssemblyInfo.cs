using System.Reflection;
using System.Runtime.CompilerServices;
using Qyoto;

// Version number is the same as the version of the latest KTextEditor
// for which the classes have been generated.
[assembly: AssemblyVersion("4.1.0.0")]

// Unnecessary, as the keyfile is given to the compiler as a parameter.
// It may be useful to have it here, though.
[assembly: AssemblyKeyFile ("key.snk")]

[assembly: AssemblySmokeInitializer(typeof(KTextEditor.InitKTextEditor))]
