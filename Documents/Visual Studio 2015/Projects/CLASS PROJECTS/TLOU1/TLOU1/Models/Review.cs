using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TLOU1.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Category"), Display(Name = "Safe Haven")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public string Name { get; set; }
        [Display(Name = "Move-In Date")]
        public DateTime MoveInDate { get; set; }
        [Display(Name = "Move-Out Date")]
        public DateTime MoveOutDate { get; set; }
        [Display(Name = "Describe this safe haven.")]
        [MinLength(2), MaxLength(50)]//minlength usually annoys users. be careful about it. these "length" data annotations may or may not include spaces
        public string Description { get; set; }
        public bool IsSafe { get; set; }
        public bool HasMedicine { get; set; }
    }
}