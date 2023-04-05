using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace StudentDetails.Students
{
    public class StudentDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public int Roll { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}
