using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class DummyData
    {
        public string JobType { get; set; }
        public string TripNo { get; set; }
        public string StageNo { get; set; }
        public string EmplName { get; set; }
        public string StartTime { get; set; }

        public DummyData()
        {

        }

        //public DummyData(string JobType, string TripNo, string StageNo, string EmplName, string startTime)
        //{
        //    this.JobType = JobType;
        //    this.TripNo = TripNo;
        //    this.StageNo = StageNo;
        //    this.EmplName = EmplName;
        //    this.StartTime = startTime;
        //}
    }
}
