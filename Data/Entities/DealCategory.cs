using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealsMo.Data.Entities
{
    public class DealCategory
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Deal Category Name is required")]
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Status { get; set; }
        public int Seq { get; set; }
        public string FAIcon { get; set; }
        public bool IsPrivateCategory { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedTS { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedTS { get; set; }
    }
}
