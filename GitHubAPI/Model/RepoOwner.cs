using Newtonsoft.Json;

namespace GitHubAPI.Model
{
    /// <summary>
    /// Owner of a Repository. User or a Organisation
    /// </summary>
    public class RepoOwner
    {
        /// <summary>
        /// Username of Repository Owner
        /// </summary>
        [JsonProperty("login")]
        public string login { get; set; }

        /// <summary>
        /// User-ID from Repository Owner
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Node-ID of Repository Owner
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeID { get; set; }

        /// <summary>
        /// The URL to the Avatar
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }

        /// <summary>
        /// User-ID from Gravatar
        /// </summary>
        [JsonProperty("gravatar_id")]
        public string GravtarID { get; set; }

        /// <summary>
        /// HTML-Page-Url from User
        /// </summary>
        [JsonProperty("html_url")]
        public string HtmlURL { get; set; }

        /// <summary>
        /// If it's a 'User' or 'Organisation'
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If the User is a GitHub Site Admin
        /// </summary>
        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }
}
