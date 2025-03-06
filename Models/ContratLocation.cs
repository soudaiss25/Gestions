using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions.Models
{
    public class ContratLocation
    {
        [Key]
        public int IdContratLocation { get; set; }
        public string Numero { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public DateTime? DateCreation { get; set; }
        public int IdAppartement {  get; set; }
        [ForeignKey("IdAppartement")]
        public virtual Appartement Appartement { get; set; }
        public int IdLocataire { get; set; }
        [ForeignKey("IdLocataire")]
        public virtual Locataire Locataire { get; set; }
        public ICollection<Paiement> Paiements { get; set; }

    }
}
