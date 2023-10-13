using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Domain.Commom
{
    public abstract class BaseDomainEnitity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
        public string LastMOdifiedBy { get; set; }

    }
}
