namespace Louer.Infra.Repository
{
    public class ClienteRepository
    {

        private readonly LouerContexto _context;

        public ClienteRepository(LouerContexto context)
        {
            _context = context;
        }
    }
}
