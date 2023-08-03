namespace Starkit.Test.Infrastructure.Models
{
    public class NameModel
    {
        public char gender { get; set; }
        public string? name { get; set; }
    }
    public class Response
    {
       public List<NameModel>? response { get; set;}
    }
}
