using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace StudentDetails.Students
{
    public class Student : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Roll { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}
