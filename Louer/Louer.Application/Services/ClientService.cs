using Louer.Infra.Repository;

namespace Louer.Application.Services
{
    public class ClientService
    {

        private readonly ClienteRepository _repository;

        public ClientService(ClienteRepository repository)
        {
            _repository = repository;
        }

    }
}
