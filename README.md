# ServiceStackWithQuartz  [![Build status](https://ci.appveyor.com/api/projects/status/sfp7sg7gh6x1x580/branch/master?svg=true)](https://ci.appveyor.com/project/CodeRevver/servicestackwithquartz/branch/master)

ServiceStack.Funq.Quartz allows an easy registration of all Quartz Jobs within ServiceStack's Funq container.  This allows for dependency injection within any Quartz Job.

This repository goes alongside my blog post here:  [Creating a ServiceStack Windows Service that uses Quartz] (http://michaelclark.tech/2016/04/16/creating-a-servicestack-windows-service-that-uses-quartz/)

You can install this package via Nuget with: [install-package ServiceStack.Funq.Quartz](https://www.nuget.org/packages/ServiceStack.Funq.Quartz/)

##How to use
Register your jobs with the Funq container by calling the RegisterQuartzJobs with the assembly that contains your Jobs:

```csharp
    //// Add the using
    using ServiceStack.Funq.Quartz;

    //// This method scans the assembly for the Jobs
    container.RegisterQuartzJobs(typeof(HelloJob));
    
    //// Resolve the Quartz Scheduler as normal
    var scheduler = container.Resolve<IScheduler>();
    
    //// Start Quartz Scheduler
    scheduler.Start();
```
##ServiceStack
You can find the ServiceStack framework here:  [https://github.com/ServiceStack/ServiceStack](https://github.com/ServiceStack/ServiceStack)
