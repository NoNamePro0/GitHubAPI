# GitHubAPI ![.NET Core](https://github.com/NoNamePro0/GitHubAPI/workflows/.NET%20Core/badge.svg)
:octocat: .NET Library for GitHub API Management

## Usage

```csharp
GitHubAPI.Model.User user = GitHubAPI.Get.User("NoNamePro0");
```

#### Advanced Access (User-Agent, Authorization,..)
```csharp
GitHubAPI.Access access = new GitHubAPI.Access()
{
	UserAgent = "My Awesome GitHub Client"
};
GitHubAPI.Model.User user = GitHubAPI.Get.User("NoNamePro0", access);
```
