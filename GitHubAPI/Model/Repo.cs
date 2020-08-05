using System;

namespace GitHubAPI.Model
{
    /// <summary>
    /// Repository on GitHub of a User or Organisation
    /// </summary>
    public class Repo
    {
        /// <summary>
        /// ID of Repository
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Node-ID of Repo
        /// </summary>
        public string node_id { get; set; }

        /// <summary>
        /// Name of the Repository
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Owner and Name with `/` seperated
        /// </summary>
        public string full_name { get; set; }

        /// <summary>
        /// Owner of Repository
        /// </summary>
        public RepoOwner owner { get; set; }

        /// <summary>
        /// HTML-Page-URL for Users
        /// </summary>
        public string html_url { get; set; }

        /// <summary>
        /// Description of Repo
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Boolean if the Repo is a fork of another repo
        /// </summary>
        public bool fork { get; set; }

        /// <summary>
        /// Date and Time for Creation of Repo
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// Date and Time of Updating Information of Repo like Description or Name
        /// </summary>
        public DateTime updated_at { get; set; }

        /// <summary>
        /// Date and Time from the last push
        /// </summary>
        public DateTime pushed_at { get; set; }

        /// <summary>
        /// Clone-URL for opening in git-Client: git://
        /// </summary>
        public string git_url { get; set; }

        /// <summary>
        /// Clone-URL for Cloning with SSH
        /// </summary>
        public string ssh_url { get; set; }

        /// <summary>
        /// Clone-URL for Cloning with HTTP
        /// </summary>
        public string clone_url { get; set; }

        /// <summary>
        /// Page from Repository
        /// </summary>
        public string svn_url { get; set; }

        /// <summary>
        /// Homepage from Repository, given from User
        /// </summary>
        public string homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// Amount of User who starred repo
        /// </summary>
        public int stargazers_count { get; set; }

        /// <summary>
        /// Amount of User who watching repo
        /// </summary>
        public int watchers_count { get; set; }

        /// <summary>
        /// Main-Langugage of Repository-Code
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// If Issues are allowed and enabled
        /// </summary>
        public bool has_issues { get; set; }

        /// <summary>
        /// If Projects are enabled
        /// </summary>
        public bool has_projects { get; set; }

        /// <summary>
        /// If Downloads/Releases will show on HTML-Git-Page
        /// </summary>
        public bool has_downloads { get; set; }

        /// <summary>
        /// If Wiki are enabled
        /// </summary>
        public bool has_wiki { get; set; }

        /// <summary>
        /// If Repo is on GitHub Pages hosted
        /// </summary>
        public bool has_pages { get; set; }

        /// <summary>
        /// Amount of Forks
        /// </summary>
        public int forks_count { get; set; }

        /// <summary>
        /// If Repo is archived and read-only
        /// </summary>
        public bool archived { get; set; }

        /// <summary>
        /// If Repo is disabled
        /// </summary>
        public bool disabled { get; set; }

        /// <summary>
        /// Amount of Open Issues
        /// </summary>
        public int open_issues_count { get; set; }

        /// <summary>
        /// The License from Repo.
        /// </summary>
        public ShortLicense license { get; set; }

        /// <summary>
        /// Amount of Forks
        /// </summary>
        public int forks { get; set; }

        /// <summary>
        /// Amount of Open Issues
        /// </summary>
        public int open_issues { get; set; }

        /// <summary>
        /// Amount of User who watching repo
        /// </summary>
        public int watchers { get; set; }

        /// <summary>
        /// Branch-Name for the default branch. Shown as default on HTML-Git-Page
        /// </summary>
        public string default_branch { get; set; }
    }
}
