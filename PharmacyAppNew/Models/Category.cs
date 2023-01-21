using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppNew.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string Name { get; set; } = null!;
    }
}
