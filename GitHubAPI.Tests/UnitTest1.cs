using NUnit.Framework;

namespace GitHubAPI.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            GitHubAPI.Model.Branch[] branches = GitHubAPI.Get.Branches(GitHubAPI.Get.Repos(GitHubAPI.Get.User("NoNamePro0"))[0]);

            Assert.Pass();
        }
    }
}