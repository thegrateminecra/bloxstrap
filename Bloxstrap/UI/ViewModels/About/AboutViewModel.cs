using System.Windows;

namespace Bloxstrap.UI.ViewModels.About
{
    public class AboutViewModel : NotifyPropertyChangedViewModel
    {
        public string Version => string.Format(Strings.Menu_About_Version, App.Version);

        public BuildMetadataAttribute BuildMetadata => App.BuildMetadata;

        public string BuildTimestamp => BuildMetadata.Timestamp.ToFriendlyString();
        public string BuildCommitHashUrl => $"https://github.com/{App.ProjectRepository}/commit/{BuildMetadata.CommitHash}";

        public Visibility BuildInformationVisibility => App.IsProductionBuild ? Visibility.Collapsed : Visibility.Visible;

        // local release builds carry a placeholder hash, so there's nothing worth linking to
        private bool HasRealCommit => Regex.IsMatch(BuildMetadata.CommitHash ?? "", "^[0-9a-f]{7,40}$");

        public Visibility BuildCommitVisibility =>
            App.IsActionBuild && HasRealCommit ? Visibility.Visible : Visibility.Collapsed;
    }
}
