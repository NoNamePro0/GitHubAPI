using Newtonsoft.Json;

namespace GitHubAPI.Model
{
    /// <summary>
    /// License for a Repository
    /// </summary>
    public class ShortLicense
    {
        /// <summary>
        /// A short id tolower of License
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Full Name of Lisence
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A ID for the License
        /// </summary>
        [JsonProperty("spdx_id")]
        public string SpdxID { get; set; }

        /// <summary>
        /// Node-ID of Liscence
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeID { get; set; }
    }
}
