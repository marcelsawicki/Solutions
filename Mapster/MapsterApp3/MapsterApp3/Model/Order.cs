using Mapster;

namespace MapsterApp3.Model
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderLine> Lines { get; set; }

        public static Order Create(int id, string name)
        {
            return new Order()
            {
                Id = id,
                Name = name,
                Lines = new List<OrderLine>()
            };
        }
    }
}
