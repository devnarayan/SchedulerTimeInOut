using Quartz;

namespace SchedularPrac
{
    public class Job : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            AlertScreen fm = new AlertScreen
            {
                TopMost = true
            };
            fm.ShowDialog();
        }
    }
}
