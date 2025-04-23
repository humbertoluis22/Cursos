using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ScreenSoundConnection:DbContext
    {
        public DbSet<Artista> Artistas { get; set; }

        //private string connectionString = "Data Source=localhost;Initial Catalog=ScreenSound;Integrated Security=True;TrustServerCertificate=True";
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=ScreenSound;" +
            "Integrated Security=True;" +
            "Encrypt=False;" +
            "TrustServerCertificate=True;" +
            "Application Intent=ReadWrite;" +
            "MultiSubnetFailover=False";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //public SqlConnection ObterConexao()
        //{
        //    return new SqlConnection(connectionString);
        //}



    }
}
