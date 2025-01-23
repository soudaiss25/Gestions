﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gestions.Models
{
    public class Proprietaire : Personne
    {
        [Required,MaxLength(20)]
        public string Ninea { get; set; }

        [Required, MaxLength(20)]
        public string Rccm { get; set; }
        
        public virtual ICollection<Appartement> Appartements { get; set; }

    }
}
