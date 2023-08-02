using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Gateways;

namespace Starkit.Test.Infrastructure
{
    public class NameDAO : INameGateway
    {
        public Task<NameResponseDTO> Get()
        {
            throw new NotImplementedException();
        }
    }
}
