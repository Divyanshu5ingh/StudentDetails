using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentDetails.Students
{
    public class CreateUpdateStudentDto
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        
        public int Roll { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public long Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
