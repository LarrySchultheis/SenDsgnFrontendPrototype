using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class TicketData
    {
        public string JobType { get; set; }
        public int TripNo { get; set; }
        public string StageNo { get; set; }
        public string EmplName { get; set; }
        public DateTime StartTime { get; set; }

        public TicketData()
        {

        }

        public TicketData(string JobType, int TripNo, string StageNo, string EmplName, DateTime startTime)
        {
            this.JobType = JobType;
            this.TripNo = TripNo;
            this.StageNo = StageNo;
            this.EmplName = EmplName;
            this.StartTime = startTime;
        }
    }
}
