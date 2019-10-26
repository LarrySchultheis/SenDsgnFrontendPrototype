using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCApp.Services.DBModels;

namespace MVCApp.Services
{
    public class DataEntry
    {

        public void PostEntry(Models.TicketData td)
        {
            var x = td;
            using (var context = new TicketingSystemContext())
            {
                IEnumerable<JobType> jobs = context.JobType;
                JobType job = null;

                foreach (JobType j in jobs)
                {
                    if (td.JobType == j.JobType1)
                    {
                        job = j;
                        break;
                    }
                }
                var e = new Employee()
                {
                    EmployeeName = td.EmplName
                };
                var tdata = new TicketData()
                {
                    TripNumber = td.TripNo,
                    StageNumber = td.StageNo,
                    JobType = job,
                    JobTypeId = job.JobTypeId,
                    Employee = e,
                    EmployeeId = e.EmployeeId,
                    StartTime = td.StartTime
                };
                context.Employee.Add(e);
                context.TicketData.Add(tdata);
                context.SaveChanges();
            }

        }
    }
}
