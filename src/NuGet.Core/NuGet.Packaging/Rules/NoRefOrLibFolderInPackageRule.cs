using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NuGet.Client;
using NuGet.Common;
using NuGet.ContentModel;
using NuGet.Frameworks;
using NuGet.RuntimeModel;

namespace NuGet.Packaging.Rules
{
    class NoRefOrLibFolderInPackageRule : IPackageRule
    {
        private static readonly List<string> FrameworkIdentifiers = typeof(FrameworkConstants.FrameworkIdentifiers).GetFields()
                .Select(s => s.GetRawConstantValue().ToString()).ToList();
        public string MessageFormat { get; }

        public NoRefOrLibFolderInPackageRule(string messageFormat)
        {
            MessageFormat = messageFormat;
        }

        public IEnumerable<PackagingLogMessage> Validate(PackageArchiveReader package)
        {
            var files = package.GetFiles();
            return Validate(files);
        }

        internal IEnumerable<PackagingLogMessage> Validate(IEnumerable<string> files)
        {
            var managedCodeConventions = new ManagedCodeConventions(new RuntimeGraph());
            var collection = new ContentItemCollection();
            collection.Load(files);

            var libItems = GetContentForPattern(collection, managedCodeConventions.Patterns.CompileLibAssemblies);
            var refItems = GetContentForPattern(collection, managedCodeConventions.Patterns.CompileRefAssemblies);
            var buildItems = GetContentForPattern(collection, managedCodeConventions.Patterns.MSBuildFiles);

            var libFrameworks = GetGroupFrameworks(libItems).ToArray();
            var refFrameworks = GetGroupFrameworks(refItems).ToArray();
            var buildFrameworks = GetGroupFrameworks(buildItems).ToArray();

            if (libFrameworks.Length == 0 && refFrameworks.Length == 0)
            {
                //if you can't find the ref and lib folder, then find the build folder
                if (buildFrameworks.Length != 0)
                {
                    //if you can find any folders other than native or any, raise an NU5127
                    if (buildFrameworks.Any(t => (FrameworkConstants.DotNetAll.Satisfies(t) || IsValidFramework(t))
                        && t.GetShortFolderName() != "dotnet"
                        && t.GetShortFolderName() != "native"))
                    {
                        var possibleFrameworks = buildFrameworks.
                            Where(t => t.IsSpecificFramework && t.GetShortFolderName() != "dotnet" && t.GetShortFolderName() != "native").
                            Select(t => t.GetShortFolderName()).ToArray();

                        (var tfmNames, var suggestedDirectories) = GenerateWarningString(possibleFrameworks);
                        
                        var issue = new List<PackagingLogMessage>();
                        issue.Add(PackagingLogMessage.CreateWarning(string.Format(MessageFormat, tfmNames, suggestedDirectories),
                            NuGetLogCode.NU5127));
                        return issue;
                    }
                }
            }

            return Array.Empty<PackagingLogMessage>();
        }

        private (string, string) GenerateWarningString(string[] possibleFrameworks)
        {
            var tfmNames = new StringBuilder();
            var suggestedDirectories = new StringBuilder();
            if (possibleFrameworks.Length > 1)
            {
                for (int i = 0; i < possibleFrameworks.Length; i++)
                {
                    if (i != possibleFrameworks.Length - 1)
                    {
                        tfmNames.Append(possibleFrameworks[i] + ", ");
                    }
                    else
                    {
                        tfmNames.Append("and " + possibleFrameworks[i]);
                    }

                    tfmNames.AppendFormat("-lib/{0}/_._", possibleFrameworks[i]).AppendLine();
                }
            }
            else
            {
                tfmNames.Append(possibleFrameworks[0]);
                suggestedDirectories.AppendFormat("-lib/{0}/_._", possibleFrameworks[0]);
            }

            return (tfmNames.ToString(), suggestedDirectories.ToString());

        }

        private static IEnumerable<ContentItemGroup> GetContentForPattern(ContentItemCollection collection, PatternSet pattern)
        {
            return collection.FindItemGroups(pattern);
        }

        private static IEnumerable<NuGetFramework> GetGroupFrameworks(IEnumerable<ContentItemGroup> groups)
        {
            return groups.Select(e => ((NuGetFramework)e.Properties["tfm"]));
        }

        private static bool IsValidFramework(NuGetFramework framework)
        {
            return FrameworkIdentifiers.Contains(framework.Framework);
        }

    }
}
