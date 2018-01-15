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

## Usage
### Tasks.WhenAll
This method is the workhorse of this library, allowing you to `await` up to 16
concurrent tasks all of different types. This differs from
`System.Threading.Tasks.Task.WhenAll<T>(T...)` in two key ways: This method can
take arguments of different types (unlike T[]) and it cannot take a different
number of arguments at runtime (or even more than 16 at compile-time). The main
utility of this method is to allow you to `await` 2 or more tasks simultaneously
without creating temporary variables or spreading `await` through your whole
method.

```
var (x, y) = await Tasks.WhenAll(GetXAsync(), GetYAsync());
```

### Tasks.WhenAny
This method is this library's analog to `System.Threading.Tasks.WhenAny`. It
allows you to wait for the first of a couple of tasks, getting the result of the
first and returning the default value for the others.

```
var (value, cache) = await Tasks.WhenAny(GetValueAsync(), GetCacheAsync());
if (value != null) return value;
return MapToValue(cache);
```

### Tasks.WaitAll
This method is just like `Tasks.WhenAll` except that it waits the tasks, it
doesn't `await` them.

```
var (x, y) = Task.WaitAll(GetXAsync(), GetYAsync());
```

### Tasks.WaitAny
This method is just like `Tasks.WhenAny` except that it waits the tasks, it
doesn't `await` them.

```
var (value, cache) = Tasks.WaitAny(GetValueAsync(), GetCacheAsync());
if (value != null) return value;
return MapToValue(cache);
```
