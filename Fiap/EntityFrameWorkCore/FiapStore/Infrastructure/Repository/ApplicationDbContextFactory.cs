using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Repository
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            Console.WriteLine("⚙️ ApplicationDbContextFactory chamado");

            try
            {
                var connectionString = "Server=PCHUMBERTO;Database=FiapStore;User Id=Humberto;Password=Humberto;TrustServerCertificate=True";

                // Verificando se a connection string está correta
                if (string.IsNullOrEmpty(connectionString))
                    throw new InvalidOperationException("A string de conexão está vazia.");

                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlServer(connectionString);
                optionsBuilder.UseLazyLoadingProxies();

                return new ApplicationDbContext(optionsBuilder.Options);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar DbContext: {ex.Message}");
                throw;
            }
        }
    }
}
