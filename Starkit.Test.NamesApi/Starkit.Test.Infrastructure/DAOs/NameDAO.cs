﻿using Starkit.Test.Application;
using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Gateways;
using Starkit.Test.Domain;
using Starkit.Test.Infrastructure.Context;

namespace Starkit.Test.Infrastructure.DAOs
{
    public class NameDAO : INameGateway
    {
        public readonly NameContext Context;

        public NameDAO()
        {
            Context = new NameContext();
        }
        public Task<IEnumerable<NameEntity>> GetContext()
        {
            if (Context.NameModels != null)
            {
                var lista = new List<NameEntity>();
                foreach (var item in Context.NameModels)
                {
                    lista.Add(new NameEntity { Name = item.name, Gender = item.gender});
                }
                return Task.FromResult(lista.Select(x=>x));
            }
            Logger.LogError("An error occur when trying to connect to datasource");
            throw new HttpRequestException("An error occur when trying to connect to datasource");
        }
    }
}
