﻿using System;
using System.Collections.Generic;

namespace MVCApp.Services.DBModels
{
    public partial class TicketData
    {
        public TicketData()
        {
            TicketDataLog = new HashSet<TicketDataLog>();
        }

        public int EntryId { get; set; }
        public int TripNumber { get; set; }
        public string StageNumber { get; set; }
        public int JobTypeId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public string Comments { get; set; }
        public DateTime? EntryDate { get; set; }
        public string PalletNumber { get; set; }
        public DateTime? EndTime { get; set; }
        public string PalletType { get; set; }
        public int? PalletWrapsNumber { get; set; }
        public string Carrier { get; set; }
        public string TrailerNo { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual ICollection<TicketDataLog> TicketDataLog { get; set; }
    }
}
