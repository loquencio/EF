
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF
{
    class EFContext : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Governador> Governadores { get; set; }

        public EFContext()
        {
            DropCreateDatabaseIfModelChanges<EFContext> initializer = new DropCreateDatabaseIfModelChanges<EFContext>();
            Database.SetInitializer<EFContext>(initializer);
        }
    }
}
