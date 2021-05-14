using Microsoft.EntityFrameworkCore;

namespace RiderBugRepro
{
    public static class Program
    {
        public static void Main()
        {
            var context = new Context();
            context.Analyser.Include(x => x.AnalyserExaminations).ThenInclude(x => x.Examination);
        }
    }
}