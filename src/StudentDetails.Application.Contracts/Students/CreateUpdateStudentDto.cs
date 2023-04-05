using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentDetails.Students
{
    public class CreateUpdateStudentDto
    {
        [Required (ErrorMessage ="Not more than 50 letters")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field")]
        public int Roll { get; set; }

        [Required(ErrorMessage = "Must be an unique email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must be a phone number")]
        [DataType(DataType.PhoneNumber)]
        public long Phone { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
