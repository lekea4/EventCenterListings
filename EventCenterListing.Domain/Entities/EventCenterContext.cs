using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCenterListings.Models
{
    public class EventCenterContext : DbContext
    {

        public EventCenterContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<EventCenter> EventCenters { get; set; }
    }
}
