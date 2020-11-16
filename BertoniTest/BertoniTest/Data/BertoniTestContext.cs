using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BertoniServices.Entities;

namespace BertoniTest.Data
{
    public class BertoniTestContext : DbContext
    {
        public BertoniTestContext (DbContextOptions<BertoniTestContext> options)
            : base(options)
        {
        }

        public DbSet<BertoniServices.Entities.Album> Album { get; set; }
    }
}
