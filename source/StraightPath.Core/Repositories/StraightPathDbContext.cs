using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using StraightPath.Core.Orthography;

namespace StraightPath.Core.Repositories
{
    public class StraightPathDbContext:DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Verse>  Verses { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}
