using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M4_EFCoreMVC.CodeFirst.Models
{
    public class EurocopaDBContext: DbContext
    {

        public EurocopaDBContext(DbContextOptions<EurocopaDBContext> options): base(options)
        {

        }

        public virtual DbSet<Player> Player { get; set; }


    }
}
