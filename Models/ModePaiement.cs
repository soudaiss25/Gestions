using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions.Models
{
    public class ModePaiement
    {
        [Key]
        public int IdModePaiment { get; set; }
        [Required]
        public string Libelle { get; set; }
        public ICollection <Paiement> paiements { get; set; }
    }
}
