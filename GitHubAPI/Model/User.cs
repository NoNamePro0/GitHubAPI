namespace GitHubAPI.Model
{
    public class User
    {
        /// <summary>
        /// Username from User
        /// </summary>
        public string login { get; set; }
        
        /// <summary>
        /// User-ID
        /// </summary>
        public int id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string node_id { get; set; }
        
        /// <summary>
        /// User's Avatar as URL
        /// </summary>
        public string avatar_url { get; set; }

        /// <summary>
        /// User-ID from Gravatar
        /// </summary>
        public string gravatar_id { get; set; }

        /// <summary>
        /// The API-URL from User
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// HTML-Page-Url from User
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// API-URL to list followers in a array.
        /// </summary>
        public string followers_url { get; set; }

        /// <summary>
        /// API-URL to list following users in a array
        /// </summary>
        public string following_url { get; set; }

        /// <summary>
        /// API-URL for Gists from User
        /// </summary>
        public string gists_url { get; set; }

        /// <summary>
        /// API-URL for list starred repositories
        /// </summary>
        public string starred_url { get; set; }

        /// <summary>
        /// API-URL for list watching repositories
        /// </summary>
        public string subscriptions_url { get; set; }

        /// <summary>
        /// API-URL for list organizations from user
        /// </summary>
        public string organizations_url { get; set; }

        /// <summary>
        /// API-URL for list repositories
        /// </summary>
        public string repos_url { get; set; }
        
        /// <summary>
        /// API-URL for list events like pushs
        /// </summary>
        public string events_url { get; set; }

        /// <summary>
        /// API-URL for list received events
        /// </summary>
        public string received_events_url { get; set; }

        /// <summary>
        /// For example 'User' or 'Organization'.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// If the User is a Site Admin from GitHub
        /// </summary>
        public bool site_admin { get; set; }

        /// <summary>
        /// The Full Name given from the User. Not the Username
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The company given from User in the profile
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string blog { get; set; }

        /// <summary>
        /// Location or city from User given in the profile
        /// </summary>
        public string location { get; set; }

        /// <summary>
        /// E-Mail if User has published it on the profile
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// If GitHub suggest jobs. User self set it.
        /// </summary>
        public bool hireable { get; set; }

        /// <summary>
        /// The Bio or Description from User
        /// </summary>
        public string bio { get; set; }

        /// <summary>
        /// Twitter-Username from User. Not verified.
        /// </summary>
        public string twitter_username { get; set; }

        /// <summary>
        /// Amount of public repositories.
        /// </summary>
        public int public_repos { get; set; }

        /// <summary>
        /// Amount of public gists.
        /// </summary>
        public int public_gists { get; set; }

        /// <summary>
        /// Amount of Followers
        /// </summary>
        public int followers { get; set; }

        /// <summary>
        /// Amount of following Users
        /// </summary>
        public int following { get; set; }

        /// <summary>
        /// Date in a string, where user created their account
        /// </summary>
        public string created_at { get; set; }

        /// <summary>
        /// Date in a string, where user updated thier profile
        /// </summary>
        public string updated_at { get; set; }
    }
}
