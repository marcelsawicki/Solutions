using Mapster;
using MapsterApp3.Model;
using Module.Domain;
using System.Linq.Expressions;

namespace MapsterApp3.Mapper
{
    [Mapper]
    public interface IOrderMapper
    {
        Expression<Func<Order, Invoice>> OrderProjection { get; }
        Order Map(Invoice invoice);
    }
}
