using Core.Entity;
using Core.Repository;

namespace Infrastructure.Repository
{
    public class LivroRepository : EFRepository<Livro> , ILivroRepository
    {
        public LivroRepository(ApplicationDbContext context) : base(context)
        {
            
        }

        public void CadastrarEmMassa(IEnumerable<Livro> livros)
        {
            var tempo1 = System.Diagnostics.Stopwatch.StartNew();

            _dbSet.AddRange(livros);
            _context.SaveChanges();

            tempo1.Stop();
            var milisegundos = tempo1.ElapsedMilliseconds;  

            var tempo2 = System.Diagnostics.Stopwatch.StartNew();

            _context.BulkInsert(livros);

            tempo2.Stop();
            var milisegundos2 = tempo2.ElapsedMilliseconds;

            System.Diagnostics.Debug.WriteLine($"AddRange : {milisegundos}");
            System.Diagnostics.Debug.WriteLine($"bulkInsert : {milisegundos2}");
        }
    }
}
