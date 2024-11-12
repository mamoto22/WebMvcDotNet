using Microsoft.EntityFrameworkCore;
using WebMvcDotNet.Models;

namespace WebMvcDotNet.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options) 
        { }

        public DbSet<Usuario> Usuario { get; set; }    
    }
}
