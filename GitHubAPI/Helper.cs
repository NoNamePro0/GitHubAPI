using System.Net;
using System.IO;

namespace GitHubAPI
{
    /// <summary>
    /// Some helpers just for the GitHubAPI-Library
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// A method to get the response from the GitHub API via HTTP. This will just used for the GitHubAPI
        /// </summary>
        /// <param name="uri">The Url which will response</param>
        /// <param name="access">Filled Access-Class for User Agent and more.</param>
        /// <returns>Answer from HTTP-Server as String</returns>
        public static string Http(string uri, Access access)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.UserAgent = access.UserAgent;
            request.Accept = "application/vnd.github.v3+json";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())

            using (StreamReader reader = new StreamReader(stream))
            { return reader.ReadToEnd(); }
        }

        /// <summary>
        /// The default Access-Class, if no Access-Class given to GitHubAPI-Method given.
        /// </summary>
        public static Access DefaultAccess = new Access()
        {
            UserAgent = "GitHubAPI Client - github.com/NoNamePro0/GithubAPI"
        };
    }
}
