using Newtonsoft.Json;
using GitHubAPI.Model;
using static GitHubAPI.Helper;

namespace GitHubAPI
{
    public class Get
    {
        public static User User(string username, Access access = null)
        {
            if (access == null)
            {
                access = DefaultAccess;
            }

            string response = Helper.Http($"https://api.github.com/users/{username}", access);
            return JsonConvert.DeserializeObject<User>(response);
        }
    }
}
