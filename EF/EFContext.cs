﻿
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
    }
}
