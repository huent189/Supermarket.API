using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(100)]
        public String Name { get; set; }
    }
}
