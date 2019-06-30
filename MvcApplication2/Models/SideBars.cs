using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MvcApplication2.Migrations.Seeds
{
   public class SideBars
    {
       [Key]
       public int Id { get; set; }
       [Required]
       [StringLength(20)]
        public string Name { get; set; }
       [Required]
       [StringLength(20)]
        public string Contorller { get; set; }
       [Required]
       [StringLength(20)]
        public string Action { get; set; }
    }
}
