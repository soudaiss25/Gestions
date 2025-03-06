using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;

namespace Gestions.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Dbgestionscontext : DbContext
    { 
        public Dbgestionscontext() : base("Dbgestioncontext")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Appartement> Appartements { get; set; }
        public DbSet<Proprietaire> Proprietaires { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<ModePaiement> ModePaiements { get; set; }
        public DbSet<Gestionnaire> Gestionnaires { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<TypeAppartement> typeAppartements { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<ContratLocation> contratLocation { get; set; }
        public DbSet<Td_Erreur> td_Erruers { get; set; }

        internal void SaveChanges(Proprietaire p)
        {
            throw new NotImplementedException();
        }
    }

 }
