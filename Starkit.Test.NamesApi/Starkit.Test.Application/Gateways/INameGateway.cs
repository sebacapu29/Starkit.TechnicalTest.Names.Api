using Starkit.Test.Domain;

namespace Starkit.Test.Application.Gateways
{
    public interface INameGateway
    {
        public Task<IEnumerable<NameEntity>> GetContext();
    }
}
