using Starkit.Test.Application.DTOs.Requests;
using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Interfaces;

namespace Starkit.Test.Application.Services
{
    public class NameService : INameService
    {
        public Task<IEnumerable<NameResponseDTO>> GetNames(NameRequestDTO nameRequestDTO)
        {
            throw new NotImplementedException();
        }
    }
}
