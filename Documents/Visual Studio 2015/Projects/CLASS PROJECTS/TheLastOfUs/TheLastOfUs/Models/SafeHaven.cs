using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheLastOfUs.Models
{
    public class SafeHaven
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Safe Haven")]
        public string Name { get; set; }
        public virtual ICollection<SafeHaven> SafeHavens { get; set; }
    }
}