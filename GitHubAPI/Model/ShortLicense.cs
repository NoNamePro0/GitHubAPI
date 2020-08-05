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
        public string key { get; set; }

        /// <summary>
        /// Full Name of Lisence
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// A ID for the License
        /// </summary>
        public string spdx_id { get; set; }

        /// <summary>
        /// Node-ID of Liscence
        /// </summary>
        public string node_id { get; set; }
    }
}
