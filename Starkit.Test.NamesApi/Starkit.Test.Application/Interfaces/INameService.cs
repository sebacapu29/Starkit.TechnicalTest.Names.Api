using Starkit.Test.Application.DTOs.Requests;
using Starkit.Test.Application.DTOs.Responses;

namespace Starkit.Test.Application.Interfaces
{
    public interface INameService
    {
        public Task<IEnumerable<NameResponse>> GetNames(NameRequest nameRequestDTO); 
    }
}
