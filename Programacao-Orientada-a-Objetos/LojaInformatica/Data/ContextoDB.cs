using LojaInfo.Models;
using Microsoft.EntityFrameworkCore;
namespace LojaInfo.Data
{
    // classe ContextoDB herda DbContext
    public class ContextoDB : DbContext
    {
        public ContextoDB(DbContextOptions options) : base(options) { }
        public DbSet<ModelClientes> clientes { get; set; }
    }
}
     
