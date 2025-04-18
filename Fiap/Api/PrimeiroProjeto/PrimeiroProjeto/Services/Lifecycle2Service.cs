namespace PrimeiroProjeto.Services
{
    public class Lifecycle2Service : ILifecycloService
    {
        private readonly ILifecycloService _lifecycleService;

        public Lifecycle2Service(ILifecycloService lifecycleService)
        {
            _lifecycleService = lifecycleService;
        }

        public DateTime DataAtual() => _lifecycleService.DataAtual();   

    }

}
