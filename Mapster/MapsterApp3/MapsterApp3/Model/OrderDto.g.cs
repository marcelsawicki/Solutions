using System.Collections.Generic;
using MapsterApp3.Model;

namespace MapsterApp3.Model
{
    public partial class OrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderLineDto> Lines { get; set; }
    }
}