namespace MapsterApp3.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderLineDto> Lines { get; set; }
    }
}
