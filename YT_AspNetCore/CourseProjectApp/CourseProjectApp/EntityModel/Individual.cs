using CourseProjectApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.EntityModel
{
    public class Individual
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IndividualId { get; set; }


        [StringLength(50)]
        [Required]
        public string FullName { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [ForeignKey("AspNetUserId")]
        public ApplicationUser User { get; set; }
        public string AspNetUserId { get; set; }
    }
}
