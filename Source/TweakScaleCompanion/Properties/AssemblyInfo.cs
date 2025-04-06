using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("TweakScaleCompanion")]
[assembly: AssemblyDescription("The Official Companion for TweakScale")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(TweakScaleCompanion.LegalMamboJambo.Company)]
[assembly: AssemblyProduct(TweakScaleCompanion.LegalMamboJambo.Product)]
[assembly: AssemblyCopyright(TweakScaleCompanion.LegalMamboJambo.Copyright)]
[assembly: AssemblyTrademark(TweakScaleCompanion.LegalMamboJambo.Trademark)]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(TweakScaleCompanion.Version.Number)]
[assembly: AssemblyFileVersion(TweakScaleCompanion.Version.Number)]
[assembly: KSPAssembly("TweakScaleCompanion", TweakScaleCompanion.Version.major, TweakScaleCompanion.Version.minor)]
// [assembly: KSPAssemblyDependency("Scale_Redist", 2, 5)] KSP 1.12.2 screwed up the Dependency Check
#if USE_KSPE
[assembly: KSPAssemblyDependency("KSPe", 2, 5)]
[assembly: KSPAssemblyDependency("KSPe.UI", 2, 5)]
#else
[assembly: KSPAssemblyDependency("KSPe.Light.TweakScale", 2, 5)]
#endif
// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
