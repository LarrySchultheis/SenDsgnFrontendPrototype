using System;
using System.Collections.Generic;

namespace MVCApp.Services.DBModels
{
    public partial class Employee
    {
        public Employee()
        {
            TicketData = new HashSet<TicketData>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public virtual ICollection<TicketData> TicketData { get; set; }
    }
}
