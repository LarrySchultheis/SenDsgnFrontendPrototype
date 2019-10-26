using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCApp.Services.DBModels;

namespace MVCApp.Services
{
    public class RecordRetriever
    {
        public IEnumerable<TicketData> RetrieveRecords()
        {
            using (var context = new TicketingSystemContext())
            {

                var tdata = context.TicketData.ToList();
                return tdata;

            }
        }
    }
}
