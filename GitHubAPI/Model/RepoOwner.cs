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
        public string login { get; set; }

        /// <summary>
        /// User-ID from Repository Owner
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Node-ID of Repository Owner
        /// </summary>
        public string node_id { get; set; }

        /// <summary>
        /// The URL to the Avatar
        /// </summary>
        public string avatar_url { get; set; }

        /// <summary>
        /// User-ID from Gravatar
        /// </summary>
        public string gravatar_id { get; set; }

        /// <summary>
        /// HTML-Page-Url from User
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// If it's a 'User' or 'Organisation'
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// If the User is a GitHub Site Admin
        /// </summary>
        public bool site_admin { get; set; }
    }
}
