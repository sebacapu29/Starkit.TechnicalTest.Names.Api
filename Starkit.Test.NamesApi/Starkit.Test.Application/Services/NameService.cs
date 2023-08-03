using Starkit.Test.Application.DTOs.Requests;
using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Gateways;
using Starkit.Test.Application.Interfaces;

namespace Starkit.Test.Application.Services
{
    public class NameService : INameService
    {
        public INameGateway _nameGateway;

        public NameService(INameGateway nameGateway) 
        {
            _nameGateway = nameGateway;
        }
        public async Task<IEnumerable<NameResponse>> GetNames(NameRequest nameRequestDTO)
        {
            var names = await _nameGateway.Get();
            return names;
        }
    }
}
