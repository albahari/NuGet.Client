﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetVSExtension {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGetVSExtension.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get the account manager, unable to check the keychain..
        /// </summary>
        internal static string AccountProvider_FailedToLoadAccountManager {
            get {
                return ResourceManager.GetString("AccountProvider_FailedToLoadAccountManager", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not get the account provider, unable to check the keychain..
        /// </summary>
        internal static string AccountProvider_FailedToLoadVSOAccountProvider {
            get {
                return ResourceManager.GetString("AccountProvider_FailedToLoadVSOAccountProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No valid credentials found for VSO account..
        /// </summary>
        internal static string AccountProvider_NoValidCrededentialsFound {
            get {
                return ResourceManager.GetString("AccountProvider_NoValidCrededentialsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to authenticate without prompting user..
        /// </summary>
        internal static string AccountProvider_TriedToShowUIOnNonInteractive {
            get {
                return ResourceManager.GetString("AccountProvider_TriedToShowUIOnNonInteractive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not create tool window..
        /// </summary>
        internal static string CanNotCreateWindow {
            get {
                return ResourceManager.GetString("CanNotCreateWindow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default credentials credential provider failed to load..
        /// </summary>
        internal static string CredentialProviderFailed_DefaultCredentialsCredentialProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_DefaultCredentialsCredentialProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load credential provider from assembly {0}..
        /// </summary>
        internal static string CredentialProviderFailed_ImportedProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_ImportedProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The legacy NuGet credential provider failed to load..
        /// </summary>
        internal static string CredentialProviderFailed_LegacyCredentialProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_LegacyCredentialProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Visual Studio or VSTS account provider failed to load..
        /// </summary>
        internal static string CredentialProviderFailed_VisualStudioAccountProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_VisualStudioAccountProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Visual Studio credential provider failed to load..
        /// </summary>
        internal static string CredentialProviderFailed_VisualStudioCredentialProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_VisualStudioCredentialProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package Manager.
        /// </summary>
        internal static string DialogTitle {
            get {
                return ResourceManager.GetString("DialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project &apos;{0}&apos; is unsupported.
        /// </summary>
        internal static string DTE_ProjectUnsupported {
            get {
                return ResourceManager.GetString("DTE_ProjectUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation failed.
        /// </summary>
        internal static string ErrorDialogBoxTitle {
            get {
                return ResourceManager.GetString("ErrorDialogBoxTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ========== Finished ==========.
        /// </summary>
        internal static string Finished {
            get {
                return ResourceManager.GetString("Finished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage NuGet Packages for &amp;Solution....
        /// </summary>
        internal static string ManagePackageForSolutionLabel {
            get {
                return ResourceManager.GetString("ManagePackageForSolutionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage &amp;NuGet Packages....
        /// </summary>
        internal static string ManagePackageLabel {
            get {
                return ResourceManager.GetString("ManagePackageLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No project is selected for this operation..
        /// </summary>
        internal static string NoProjectSelected {
            get {
                return ResourceManager.GetString("NoProjectSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No projects supported by NuGet in the solution..
        /// </summary>
        internal static string NoSupportedProjectsInSolution {
            get {
                return ResourceManager.GetString("NoSupportedProjectsInSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nuget.
        /// </summary>
        internal static string NuGetSearchProvider_CategoryShortcut {
            get {
                return ResourceManager.GetString("NuGetSearchProvider_CategoryShortcut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search NuGet packages.
        /// </summary>
        internal static string NuGetSearchProvider_Description {
            get {
                return ResourceManager.GetString("NuGetSearchProvider_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Packages.
        /// </summary>
        internal static string NuGetSearchProvider_DisplayText {
            get {
                return ResourceManager.GetString("NuGetSearchProvider_DisplayText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search Online for NuGet Packages matching &apos;{0}&apos;.
        /// </summary>
        internal static string NuGetStaticResult_DisplayText {
            get {
                return ResourceManager.GetString("NuGetStaticResult_DisplayText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} nuget configuration is invalid..
        /// </summary>
        internal static string ProjectHasAnInvalidNuGetConfiguration {
            get {
                return ResourceManager.GetString("ProjectHasAnInvalidNuGetConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project is not eligible for migration. Either the project is not packages.config based or doesn&apos;t support PackageReference yet. Visit https://docs.microsoft.com/en-us/nuget/reference/migrate-packages-config-to-package-reference for more information..
        /// </summary>
        internal static string ProjectMigrateErrorMessage {
            get {
                return ResourceManager.GetString("ProjectMigrateErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some NuGet packages were installed using a target framework different from the current target framework and may need to be reinstalled. Visit https://docs.nuget.org/docs/workflows/reinstalling-packages for more information.  Packages affected: {0}.
        /// </summary>
        internal static string ProjectUpgradeAndRetargetErrorMessage {
            get {
                return ResourceManager.GetString("ProjectUpgradeAndRetargetErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credential provider gave an invalid response..
        /// </summary>
        internal static string ProviderException_MalformedResponse {
            get {
                return ResourceManager.GetString("ProviderException_MalformedResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Solution is not saved. Please save your solution before managing NuGet packages..
        /// </summary>
        internal static string SolutionIsNotSaved {
            get {
                return ResourceManager.GetString("SolutionIsNotSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Solution is not saved. Please save your solution and re-open solution before managing NuGet packages..
        /// </summary>
        internal static string SolutionIsNotSavedPromptReopen {
            get {
                return ResourceManager.GetString("SolutionIsNotSavedPromptReopen", resourceCulture);
            }
        }
    }
}
