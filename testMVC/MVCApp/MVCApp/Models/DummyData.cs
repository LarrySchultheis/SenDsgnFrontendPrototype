using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class DummyData
    {
        public string JobType { get; set; }
        public string tripNo { get; set; }
        public string stageNo { get; set; }
        public string EmplName { get; set; }
        public string StartTime { get; set; }

        public DummyData(string JobType, string tripNo, string stageNo, string EmplName, string startTime)
        {
            this.JobType = JobType;
            this.tripNo = tripNo;
            this.stageNo = stageNo;
            this.EmplName = EmplName;
            this.StartTime = startTime;
        }
    }
}
