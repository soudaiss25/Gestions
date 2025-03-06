using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions.Models
{
    public class Appartement
    {
        [Key]
        public int IdAppartement { get; set; }

        [Required,MaxLength(100)]
        public string AdresseAppartement { get; set; }

        public float? Surface {  get; set; }

        public int? NombrePiece { get; set; }

        public int? IdProprietaire { get; set; }

        [ForeignKey("IdProprietaire")]
        public virtual Proprietaire Proprietaire { get; set; }
        public int idTypeAppartement { get; set; }
        [ForeignKey("idTypeAppartement")]
        public virtual TypeAppartement TypeAppartement { get; set; }
        public bool Disponible { get; set; }


    }
}
