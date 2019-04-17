using Quartz;
using Quartz.Impl;
using System;

namespace SchedularPrac
{
  public  class Scheduler
    {
        public  void Start()
        {

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<Job>().Build();
            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("IDGJob", "IDG")
               .WithCronSchedule("1 * * * * ?")
              // .StartAt(date)
               .WithPriority(1)
               .Build();
            scheduler.ScheduleJob(job, trigger);

            System.Windows.Forms.Application.ExitThread();
        }

    }
}
