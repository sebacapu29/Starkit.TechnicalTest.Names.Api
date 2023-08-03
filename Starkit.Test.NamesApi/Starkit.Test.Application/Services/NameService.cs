using Starkit.Test.Application.DTOs.Requests;
using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Gateways;
using Starkit.Test.Application.Interfaces;
using System.Xml.Linq;

namespace Starkit.Test.Application.Services
{
    public class NameService : INameService
    {
        private INameGateway _nameGateway;

        public NameService(INameGateway nameGateway) 
        {
            _nameGateway = nameGateway;
        }
        public async Task<IEnumerable<NameResponse>> GetNames(NameRequest nameRequest)
        {
            var names = await _nameGateway.GetContext();

            var allNamesList = names.Select(name => new NameResponse { Gender = name.Gender, Name = name.Name });
            var filteredNames = allNamesList.Where(name => (name.Name.StartsWith(nameRequest.Name) && name.Gender == nameRequest.Gender));

            if (!filteredNames.Any())            
                return allNamesList;
            
            return filteredNames;
        }
    }
}
