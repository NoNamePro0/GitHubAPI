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
            GitHubAPI.Model.Repo[] repos = GitHubAPI.Get.Repos(GitHubAPI.Get.User("NoNamePro0"));

            Assert.Pass();
        }
    }
}