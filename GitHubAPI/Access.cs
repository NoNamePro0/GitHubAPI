namespace GitHubAPI
{
    /// <summary>
    /// Give this filled class to other methods, for add Access Token and User Agent.
    /// </summary>
    public class Access
    {
        /// <summary>
        /// Name of the App. Will be send to GitHub. Browser send the browser name as User Agent
        /// </summary>
        public string UserAgent { get; set; }
    }
}
