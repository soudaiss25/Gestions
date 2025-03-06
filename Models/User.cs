using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions.Models
{
    public class User : Personne
    {
        [Key]  
        
        [MaxLength(20)]
        public string identifiant { get; set; }
        [ MaxLength(255)]
        public string MotDePasse { get; set; }

        [MaxLength(20)]
        public string status { get; set; }
        [MaxLength(20)]
        public string role { get; set; }
    }
}
