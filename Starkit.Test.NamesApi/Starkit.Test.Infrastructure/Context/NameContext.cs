using Starkit.Test.Infrastructure.Models;
using System.Text.Json;
using System;
using System.Reflection;
using Newtonsoft.Json;
using Starkit.Test.Application;

namespace Starkit.Test.Infrastructure.Context
{
    public class NameContext
    {
        public IEnumerable<NameModel>? NameModels { get; set; }

        public NameContext() {

            try
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Context\names.json");
                string text = File.ReadAllText(path);
                var names = JsonConvert.DeserializeObject<Response>(text);
                if (names != null)
                {
                    NameModels = names.response;
                }
            }
            catch (Exception)
            {
                Logger.LogError("Error al establecer la conexion con la fuente de datos");
                throw;
            }

        }
    }
}
