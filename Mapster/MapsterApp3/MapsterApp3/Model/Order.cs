using Mapster;

namespace MapsterApp3.Model
{
    [AdaptTo("[name]Dto"), GenerateMapper]
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<OrderLine> Lines { get; set; }

        public static Order Create(int id, string firstname, string lastname)
        {
            return new Order()
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Lines = new List<OrderLine>()
            };
        }
    }
}
