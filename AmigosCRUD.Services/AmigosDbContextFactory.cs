using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosCRUD.Services
{
    public class AmigosDbContextFactory : IDesignTimeDbContextFactory<AmigosDBContext>
    {
        public AmigosDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AmigosDBContext>();
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Documents\\ApiFDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            return new AmigosDBContext(optionsBuilder.Options);
        }
    }
}
