using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiProjec.Models;

namespace WebApiProjec.Data
{
    public class WebApiProjecContext : DbContext
    {
        public WebApiProjecContext (DbContextOptions<WebApiProjecContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiProjec.Models.Member> Member { get; set; } = default!;
        public DbSet<WebApiProjec.Models.Membership> Membership { get; set; } = default!;
        public DbSet<WebApiProjec.Models.Court> Court { get; set; } = default!;
        public DbSet<WebApiProjec.Models.Reservation> Reservation { get; set; } = default!;
        public DbSet<WebApiProjec.Models.Trainer> Trainer { get; set; } = default!;
        public DbSet<WebApiProjec.Models.Review> Review { get; set; } = default!;
    }
}
