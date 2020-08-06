using Newtonsoft.Json;

namespace GitHubAPI.Model
{
    public class BranchCommit
    {
        /// <summary>
        /// SHA-Hash for Commit. It's like a ID for the Repo.
        /// </summary>
        [JsonProperty("sha")]
        public string Sha { get; set; }
    }

    public class Branch
    {
        /// <summary>
        /// The-Branch name like 'master' or 'main'
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Branch-Commit-Class with the SHA Hash
        /// </summary>
        [JsonProperty("commit")]
        public BranchCommit Commit { get; set; }

        /// <summary>
        /// If Branch is protected and only access for User with Special Access
        /// </summary>
        [JsonProperty("protected")]
        public bool Protected { get; set; }
    }
}