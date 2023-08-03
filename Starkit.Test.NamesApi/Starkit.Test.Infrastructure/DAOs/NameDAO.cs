using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Gateways;
using Starkit.Test.Infrastructure.Context;

namespace Starkit.Test.Infrastructure.DAOs
{
    public class NameDAO : INameGateway
    {
        public NameContext Context { get; set; }

        public NameDAO()
        {
            Context = new NameContext();
        }
        public Task<IEnumerable<NameResponse>> Get()
        {
            if (Context.NameModels != null)
            {
                var lista = new List<NameResponse>();
                foreach (var item in Context.NameModels)
                {
                    lista.Add(new NameResponse { Name = item.name, Gender = item.gender});
                }
                return Task.FromResult(lista.Select(x=>x));
            }
            throw new HttpRequestException("Se produjo un error con la fuente de datos");
        }
    }
}
