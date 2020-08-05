using System.Net;
using System.IO;

namespace GitHubAPI
{
    public class Helper
    {
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

        public static Access DefaultAccess = new Access()
        {
            UserAgent = "GitHubAPI Client - github.com/NoNamePro0/GithubAPI"
        };
    }
}
