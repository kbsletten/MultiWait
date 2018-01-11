# MultiWait

MultiWait addresses the ergonomic problem of handling multiple async requests
simultaneously while still getting the best possible concurrency. Without MultiWait, you have to create temporary variables for all the in-flight tasks like this:

```
var userTask = GetUserByUserIdAsync(userId);
var userReposTask = GetUserReposByUserIdAsync(userId);
var userIssuesTask = GetUserIssuesByUserIdAsync(userId);
var userPRsTask = GetUserPullRequestsByUserIdAsync(userId);

var user = await userTask;
var userRepos = await userReposTask;
var userIssues = await userIssuesTask;
var userPRs = await userPRsTask;
```

But with MultiWait it can become this:

```
var (user, userRepos, userIssues, userPrs) = await
	Tasks.WhenAll(
		GetUserByUserIdAsync(userId),
		GetUserReposByUserIdAsync(userId),
		GetUserIssuesByUserIdAsync(userId),
		GetUserPullRequestsByUserIdAsync(userId)
	);
```

## Installation
MultiWait requires .NET Standard 2.0 which allows it to run on the following runtimes:

* .NET Framework 4.6.1 or greater
* .NET Core 2.0 or greater

This package can be added to a project with NuGet by running:

* `Install-Package MultiWait -Source nuget.org` in Visual Studio NuGet Console
* `dotnet add package MultiWait` on your command line in a .NET Core project
