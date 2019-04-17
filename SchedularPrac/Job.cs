using Quartz;

namespace SchedularPrac
{
    public class Job : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Form2 fm = new Form2();
            fm.TopMost = true;
            fm.ShowDialog();
        }
    }
}
