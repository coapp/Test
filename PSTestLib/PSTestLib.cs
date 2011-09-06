using System;
using System.Collections.Generic;
using System.Management.Automation;
using CoApp.Toolkit.Engine;
using CoApp.Toolkit.Engine.Client;

namespace PSTestLib
{
    [Cmdlet(VerbsCommon.Get,"Messages")]
    public class GetMessages : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            WriteObject(new PackageManagerMessages
            {
                UnexpectedFailure = UnexpectedFailure,
                NoPackagesFound = NoPackagesFound,
                PermissionRequired = OperationRequiresPermission,
                Error = MessageArgumentError,
                RequireRemoteFile = GetRemoteFile,
                OperationCancelled = CancellationRequested,
                PackageInformation = PackageInfo,
                PackageDetails = PackageDetail,
                FeedDetails = FeedInfo,
                ScanningPackagesProgress = ScanProgress,
                InstallingPackageProgress = InstallProgress,
                RemovingPackageProgress = RemoveProgress,
                InstalledPackage = InstallComplete,
                RemovedPackage = RemoveComplete,
                FailedPackageInstall = InstallFailed,
                FailedPackageRemoval = RemoveFailed,
                Warning = WarningMsg,
                FeedAdded = NewFeed,
                FeedRemoved = LostFeed,
                FeedSuppressed = SupressedFeed,
                NoFeedsFound = NoFeeds,
                FileNotFound = NoFile,
                PackageBlocked = BlockedPackage,
                FileNotRecognized = NotRecognized,
                Recognized = Recognized,
                UnknownPackage = Unknown,
                PackageHasPotentialUpgrades = PotentialUpgrades,
                UnableToDownloadPackage = UnableToDownload,
                UnableToInstallPackage = UnableToInstall,
                UnableToResolveDependencies = UnableToResolveDeps,
                PackageSatisfiedBy = Satisfied
            });
        }
        
        #region Default message handlers
        protected void PackageInfo(Package P)
        { Host.UI.WriteLine("PackageInfo received: " + P.CanonicalName); }
        protected void PackageDetail(Package P)
        { Host.UI.WriteLine("PackageDetail received: " + P.CanonicalName); }
        protected void FeedInfo(string Location, DateTime Scanned, bool Session, bool Supressed, bool Validated)
        { Host.UI.WriteLine("FeedInfo received: " + Location); }
        protected void ScanProgress(string Location, int Progress)
        { Host.UI.WriteLine("Scanning in progress:  " + Location + "  " + Progress + "%"); }
        protected void InstallProgress(string CName, int Progress)
        { Host.UI.WriteLine("Install in progress:  " + CName + "  " + Progress + "%"); }
        protected void RemoveProgress(string CName, int Progress)
        { Host.UI.WriteLine("Remove in progress:  " + CName + "  " + Progress + "%"); }
        protected void InstallComplete(string CName)
        { Host.UI.WriteLine("Install complete:  " + CName); }
        protected void RemoveComplete(string CName)
        { Host.UI.WriteLine("Remove complete:  " + CName); }
        protected void InstallFailed(string CName, string Filename, string Reason)
        { Host.UI.WriteLine("Install failed for " + CName + " from " + Filename + ":  " + Reason); }
        protected void RemoveFailed(string CName, string Reason)
        { Host.UI.WriteLine("Remove failed for " + CName + ":  " + Reason); }
        protected void WarningMsg(string arg1, string arg2, string arg3)
        { Host.UI.WriteLine("Warning:  " + arg1 + ", " + arg2 + ", " + arg3); }
        protected void NewFeed(string feed)
        { Host.UI.WriteLine("Feed added:  " + feed); }
        protected void LostFeed(string feed)
        { Host.UI.WriteLine("Feed removed:  " + feed); }
        protected void SupressedFeed(string feed)
        { Host.UI.WriteLine("Feed supressed:  " + feed); }
        protected void NoFeeds()
        { Host.UI.WriteLine("No feeds found."); }
        protected void NoFile(string Filename)
        { Host.UI.WriteLine("File not found:  " + Filename); }
        protected void BlockedPackage(string CName)
        { Host.UI.WriteLine("Package is blocked:  " + CName); }
        protected void NotRecognized(string Location, string Remote)
        { Host.UI.WriteLine("File not recognized:  " + Location + " from " + Remote); }
        protected void Recognized(string CName)
        { Host.UI.WriteLine("File recognized:  " + CName); }
        protected void Unknown(string CName)
        { Host.UI.WriteLine("Unknown package:  " + CName); }
        protected void PotentialUpgrades(Package Current, IEnumerable<Package> Super)
        { Host.UI.WriteLine("Package may have upgrades available:  " + Current.CanonicalName); }
        protected void UnableToDownload(Package Pack)
        { Host.UI.WriteLine("Unable to download package:  " + Pack.CanonicalName); }
        protected void UnableToInstall(Package Pack)
        { Host.UI.WriteLine("Unable to install package:  " + Pack.CanonicalName); }
        protected void UnableToResolveDeps(Package Pack, IEnumerable<Package> Deps)
        { Host.UI.WriteLine("Unable to resolve package dependencies:  " + Pack.CanonicalName); }
        protected void Satisfied(Package Requested, Package Existing)
        { Host.UI.WriteLine("Package requirement is satisfied:  " + Requested.CanonicalName + " ==> " + Existing.CanonicalName); }
        protected void CancellationRequested(string obj)
        { Host.UI.WriteLine("Operation Canceled:  " + obj); }
        protected void MessageArgumentError(string arg1, string arg2, string arg3)
        { Host.UI.WriteLine("Message Argument Error " + arg1 + ", " + arg2 + ", " + arg3 + "."); }
        protected void OperationRequiresPermission(string policyName)
        { Host.UI.WriteLine("Operation requires permission Policy: " + policyName); }
        protected void NoPackagesFound()
        { Host.UI.WriteLine("Did not find any packages."); }
        protected void UnexpectedFailure(Exception obj)
        { Host.UI.WriteLine("SERVER EXCEPTION: " + obj.Message + "\n" + obj.StackTrace); }

        protected void GetRemoteFile(string canonicalName, IEnumerable<string> Remotes, string LocalPath, bool Force)
        {
            Host.UI.Write("Request for remote file: "+LocalPath+canonicalName+"\n\tfrom:\n");
            foreach (string remote in Remotes)
            {
                Host.UI.WriteLine("\t\t"+remote);
            }
        }


        #endregion
    }
}
