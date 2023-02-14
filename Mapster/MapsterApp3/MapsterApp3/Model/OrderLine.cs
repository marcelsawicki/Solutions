using Mapster;

namespace MapsterApp3.Model
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class OrderLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
