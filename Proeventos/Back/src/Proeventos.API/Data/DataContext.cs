using Microsoft.EntityFrameworkCore;
using Proeventos.API.Models;

namespace Proeventos.Back.src.Proeventos.API.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) {}
    }
}