using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Gateways;
using Starkit.Test.Infrastructure.Context;

namespace Starkit.Test.Infrastructure.DAOs
{
    public class NameDAO : INameGateway
    {
        public NameContext? Context { get; set; }

        public NameDAO() {
            Context = new NameContext();
        }
        public Task<NameResponseDTO> Get()
        {    
            throw new NotImplementedException();
        }
    }
}
