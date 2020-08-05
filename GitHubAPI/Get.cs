using Newtonsoft.Json;
using GitHubAPI.Model;
using static GitHubAPI.Helper;

namespace GitHubAPI
{
    /// <summary>
    /// Methods for Get-Requests to GitHub and answers a class.
    /// </summary>
    public class Get
    {
        /// <summary>
        /// Get a User/Organisation from GitHub.
        /// </summary>
        /// <param name="username">Username from the GitHub User, which will be requested</param>
        /// <param name="access">Filled Access-Class for User Agent and Auth. Optional.</param>
        /// <returns>A User-Class from GitHub</returns>
        public static User User(string username, Access access = null)
        {
            if (access == null)
            {
                access = DefaultAccess;
            }

            string response = Helper.Http($"https://api.github.com/users/{username}", access);
            return JsonConvert.DeserializeObject<User>(response);
        }

        /// <summary>
        /// Give a Repo-Array from Users repos
        /// </summary>
        /// <param name="user">Repositories by this User</param>
        /// <param name="access">Filled Access-Class for User Agent and Auth. Optional.</param>
        /// <returns>A Repo-Array with the repositories</returns>
        public static Repo[] Repos(User user, Access access = null) { return Repos(user.Login, access); }

        /// <summary>
        /// Give a Repo-Array from Users repos
        /// </summary>
        /// <param name="username">Repositories by this Username</param>
        /// <param name="access">Filled Access-Class for User Agent and Auth. Optional.</param>
        /// <returns>A Repo-Array with the repositories</returns>
        public static Repo[] Repos(string username, Access access = null)
        {
            if (access == null)
            {
                access = DefaultAccess;
            }

            string response = Helper.Http($"https://api.github.com/users/{username}/repos", access);
            return JsonConvert.DeserializeObject<Repo[]>(response);
        }
    }
}
