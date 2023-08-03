using Starkit.Test.Application.DTOs.Responses;

namespace Starkit.Test.Application.Gateways
{
    public interface INameGateway
    {
        public Task<IEnumerable<NameResponse>> Get();
    }
}
