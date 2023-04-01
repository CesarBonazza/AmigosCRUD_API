using Microsoft.EntityFrameworkCore;
using AmigosCRUD.Domain.Entities;

namespace AmigosCRUD.Services
{
    public class AmigosDBContext : DbContext
    {
        public AmigosDBContext(DbContextOptions<AmigosDBContext> options) : base(options) 
        {
        }
        public DbSet<Amigo> Amigo { get; set; }
    }
}