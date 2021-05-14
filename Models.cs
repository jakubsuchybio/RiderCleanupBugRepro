using System.Collections.Generic;

namespace RiderBugRepro
{
    public class Analyser
    {
        public string Version { get; set; }
        public ICollection<AnalyserExamination> AnalyserExaminations { get; set; }
    }

    public class Examination
    {
        public string Name { get; set; }
        public ICollection<AnalyserExamination> AnalyserExaminations { get; set; }
    }

    public class AnalyserExamination
    {
        public int AnalyserId { get; set; }
        public Analyser Analyser { get; set; }
        public int ExaminationId { get; set; }
        public Examination Examination { get; set; }
    }
}