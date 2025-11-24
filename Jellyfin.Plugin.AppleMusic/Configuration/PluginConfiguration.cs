using System.ComponentModel;
using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.AppleMusic.Configuration
{
    /// <summary>
    /// Apple Music region types.
    /// </summary>
    public enum RegionType
    {
        /// <summary>
        /// United States.
        /// </summary>
        [Description("us")]
        US,

        /// <summary>
        /// Japan.
        /// </summary>
        [Description("jp")]
        JA
    }

    /// <summary>
    /// The plugin configuration.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
        /// </summary>
        public PluginConfiguration()
        {
            Region = RegionType.JA;
        }

        /// <summary>
        /// Gets or sets the Apple Music region.
        /// </summary>
        public RegionType Region { get; set; } = RegionType.JA;
    }
}
