using Newtonsoft.Json;
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
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Node-ID of Repo
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeID { get; set; }

        /// <summary>
        /// Name of the Repository
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Owner and Name with `/` seperated
        /// </summary>
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// Owner of Repository
        /// </summary>
        [JsonProperty("owner")]
        public RepoOwner Owner { get; set; }

        /// <summary>
        /// HTML-Page-URL for Users
        /// </summary>
        [JsonProperty("html_url")]
        public string HtmlURL { get; set; }

        /// <summary>
        /// Description of Repo
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Boolean if the Repo is a fork of another repo
        /// </summary>
        [JsonProperty("fork")]
        public bool IsFork { get; set; }

        /// <summary>
        /// Date and Time for Creation of Repo
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date and Time of Updating Information of Repo like Description or Name
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Date and Time from the last push
        /// </summary>
        [JsonProperty("pushed_at")]
        public DateTime PushedAt { get; set; }

        /// <summary>
        /// Clone-URL for opening in git-Client: git://
        /// </summary>
        [JsonProperty("git_url")]
        public string GitURL { get; set; }

        /// <summary>
        /// Clone-URL for Cloning with SSH
        /// </summary>
        [JsonProperty("ssh_url")]
        public string sshURL { get; set; }

        /// <summary>
        /// Clone-URL for Cloning with HTTP
        /// </summary>
        [JsonProperty("clone_url")]
        public string CloneURL { get; set; }

        /// <summary>
        /// Page from Repository
        /// </summary>
        [JsonProperty("svn_url")]
        public string svnURL { get; set; }

        /// <summary>
        /// Homepage from Repository, given from User
        /// </summary>
        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Amount of User who starred repo
        /// </summary>
        [JsonProperty("stargazers_count")]
        public int CountStargazers { get; set; }

        /// <summary>
        /// Amount of User who watching repo
        /// </summary>
        [JsonProperty("watchers_count")]
        public int CountWatchers { get; set; }

        /// <summary>
        /// Main-Langugage of Repository-Code
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// If Issues are allowed and enabled
        /// </summary>
        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        /// <summary>
        /// If Projects are enabled
        /// </summary>
        [JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        /// <summary>
        /// If Downloads/Releases will show on HTML-Git-Page
        /// </summary>
        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        /// <summary>
        /// If Wiki are enabled
        /// </summary>
        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        /// <summary>
        /// If Repo is on GitHub Pages hosted
        /// </summary>
        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        /// <summary>
        /// Amount of Forks
        /// </summary>
        [JsonProperty("forks_count")]
        public int CountForks { get; set; }

        /// <summary>
        /// If Repo is archived and read-only
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// If Repo is disabled
        /// </summary>
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// Amount of Open Issues
        /// </summary>
        [JsonProperty("open_issues_count")]
        public int CountOpenIssues { get; set; }

        /// <summary>
        /// The License from Repo.
        /// </summary>
        [JsonProperty("license")]
        public ShortLicense License { get; set; }

        /// <summary>
        /// Amount of Open Issues
        /// </summary>
        [JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        /// <summary>
        /// Branch-Name for the default branch. Shown as default on HTML-Git-Page
        /// </summary>
        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
    }
}
