using Starkit.Test.Infrastructure.Models;
using System.Text.Json;
using System;

namespace Starkit.Test.Infrastructure.Context
{
    public class NameContext
    {
        public IEnumerable<NameModel>? NameModels { get; set; }

        public NameContext() {
            string text = File.ReadAllText(@"./names.json");
            var names = JsonSerializer.Deserialize<NameModel>(text);
        }
    }
}
