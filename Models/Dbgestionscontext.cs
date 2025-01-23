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
    }

 }
