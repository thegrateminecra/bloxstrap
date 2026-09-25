namespace Bloxstrap.Enums
{
    /// <summary>
    /// Controls how the bootstrapper picks which Roblox version to run.
    /// </summary>
    public enum RobloxVersionMode
    {
        /// <summary>
        /// Always query Roblox and run whatever is newest.
        /// </summary>
        Latest,

        /// <summary>
        /// Keep whatever version is already installed. Nothing gets downloaded.
        /// </summary>
        Pinned,

        /// <summary>
        /// Run a specific version hash instead of the latest.
        /// </summary>
        Custom
    }
}
