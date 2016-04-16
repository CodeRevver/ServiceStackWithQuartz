﻿using ServiceStackWithQuartz.ServiceInterface;
using Quartz;
using ServiceStack.Text;

namespace ServiceStackWithQuartz
{
    public class HelloJob : IJob
    {
        private MyServices MyServices { get; set; }
        public HelloJob(MyServices myServices)
        {
            MyServices = myServices;
        }

        public virtual void Execute(IJobExecutionContext context)
        {
            var response = MyServices.Any(new ServiceModel.Hello
            {
                Name = "Michael Clark"
            });

            response.PrintDump();
        }
    }
}