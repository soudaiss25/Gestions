using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions.Models
{
    public class Paiement
    {
        [Key]
        public int IdPaiement { get; set; }
        public DateTime datePaiement { get; set; }
        public float montant { get; set; }
        public string numeroFacture { get; set; }
        public int IdContratLocation { get; set; }
        [ForeignKey("IdContratLocation")]
        public virtual ContratLocation ContratLocation { get; set; }
        public int IdModePaiement { get; set; }
        [ForeignKey("IdModePaiement")]
        public virtual ModePaiement ModePaiement { get; set;}

    }
}
