using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp31.Models;

namespace asp31.Data
{
    public class asp31Context : DbContext
    {
        public asp31Context (DbContextOptions<asp31Context> options)
            : base(options)
        {
        }

        public DbSet<asp31.Models.Employee> Employee { get; set; }
    }
}
