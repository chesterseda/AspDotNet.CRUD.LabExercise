using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Models
{
    public class CustomerEntity: BaseEntity
    {
        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        public string? Address { get; set; }

        [RegularExpression("([0-9]+)")]
        [MinLength(11)]
        [MaxLength(11)]
        public string? Phone { get; set; }
    }
}
