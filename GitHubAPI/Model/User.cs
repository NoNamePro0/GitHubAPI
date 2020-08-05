using Newtonsoft.Json;
using System;

namespace GitHubAPI.Model
{
    public class User
    {
        /// <summary>
        /// Username from User
        /// </summary>
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// User-ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeID { get; set; }

        /// <summary>
        /// User's Avatar as URL
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }

        /// <summary>
        /// User-ID from Gravatar
        /// </summary>
        [JsonProperty("gravatar_id")]
        public string GravatarID { get; set; }

        /// <summary>
        /// HTML-Page-Url from User
        /// </summary>
        [JsonProperty("html_url")]
        public string HtmlURL { get; set; }

        /// <summary>
        /// For example 'User' or 'Organization'.
        /// </summary>

        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If the User is a Site Admin from GitHub
        /// </summary>
        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        /// <summary>
        /// The Full Name given from the User. Not the Username
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The company given from User in the profile
        /// </summary>
        [JsonProperty("company")]
        public string company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("blog")]
        public string Blog { get; set; }

        /// <summary>
        /// Location or city from User given in the profile
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// E-Mail if User has published it on the profile
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// If GitHub suggest jobs. User self set it.
        /// </summary>
        [JsonProperty("hireable")]
        public bool IsHireable { get; set; }

        /// <summary>
        /// The Bio or Description from User
        /// </summary>
        [JsonProperty("bio")]
        public string Bio { get; set; }

        /// <summary>
        /// Twitter-Username from User. Not verified.
        /// </summary>
        [JsonProperty("twitter_username")]
        public string Twitter { get; set; }

        /// <summary>
        /// Amount of public repositories.
        /// </summary>
        [JsonProperty("public_repos")]
        public int PublicRepos { get; set; }

        /// <summary>
        /// Amount of public gists.
        /// </summary>
        [JsonProperty("public_gists")]
        public int PublicGists { get; set; }

        /// <summary>
        /// Amount of Followers
        /// </summary>
        [JsonProperty("followers")]
        public int CountFollowers { get; set; }

        /// <summary>
        /// Amount of following Users
        /// </summary>
        [JsonProperty("following")]
        public int CountFollowing { get; set; }

        /// <summary>
        /// Date in a string, where user created their account
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date in a string, where user updated thier profile
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
