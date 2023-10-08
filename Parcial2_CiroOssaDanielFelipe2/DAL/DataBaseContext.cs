using Microsoft.EntityFrameworkCore;
using Parcial2_CiroOssaDanielFelipe2.DAL.Entities;
using System.Collections.Generic;

namespace Parcial2_CiroOssaDanielFelipe2.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<NaturalPerson> naturalPeople { get; set; }
    }
}