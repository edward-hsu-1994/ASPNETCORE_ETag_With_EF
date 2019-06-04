using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models {
    public class MemoryContext : DbContext {
        public virtual DbSet<Article> Articles { get; set; }

        public MemoryContext() { }

        public MemoryContext(DbContextOptions<MemoryContext> options)
            : base(options) { }
    }
}
