﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Template_4333
{
    public class Usluga
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdServices { get; set; }
        public string NameServices { get; set; }
        public string TypeOfService { get; set; }
        public string CodeService { get; set; }
        public int Cost { get; set; }
    }

    public class EntityModelContainer : DbContext
    {
        public EntityModelContainer()
            : base("name=EntityModelContainer")
        {
        }

        public DbSet<Usluga> Uslugas { get; set; }
    }
}

