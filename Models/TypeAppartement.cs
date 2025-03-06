using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions.Models
{
    public class TypeAppartement
    {
        [Key]
        public int IdType { get; set; }
        [Required]
        public string LibelleType { get; set; }
        public ICollection<Appartement> Appartements { get; set; }
    }
}
