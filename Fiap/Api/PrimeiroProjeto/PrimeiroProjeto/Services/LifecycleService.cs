namespace PrimeiroProjeto.Services
{
    public class LifecycleService : ILifecycloService
    {
        public readonly DateTime _date = DateTime.Now;
        public DateTime DataAtual() => _date;

    }
}
