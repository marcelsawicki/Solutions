using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MapsterApp3.Mapper;
using MapsterApp3.Model;
using Module.Domain;

namespace MapsterApp3.Mapper
{
    public partial class OrderMapper : IOrderMapper
    {
        public Expression<Func<Order, Invoice>> OrderProjection => p1 => new Invoice()
        {
            Id = p1.Id,
            FirstName = p1.FirstName,
            LastName = p1.LastName,
            Lines = p1.Lines.Select<OrderLine, InvoiceLine>(p2 => new InvoiceLine()
            {
                Id = p2.Id,
                FirstName = p2.FirstName,
                LastName = p2.LastName,
                Price = p2.Price
            }).ToList<InvoiceLine>()
        };
        public Order Map(Invoice p3)
        {
            return p3 == null ? null : new Order()
            {
                Id = p3.Id,
                FirstName = p3.FirstName,
                LastName = p3.LastName,
                Lines = funcMain1(p3.Lines)
            };
        }
        
        private List<OrderLine> funcMain1(List<InvoiceLine> p4)
        {
            if (p4 == null)
            {
                return null;
            }
            List<OrderLine> result = new List<OrderLine>(p4.Count);
            
            int i = 0;
            int len = p4.Count;
            
            while (i < len)
            {
                InvoiceLine item = p4[i];
                result.Add(item == null ? null : new OrderLine()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Price = item.Price
                });
                i++;
            }
            return result;
            
        }
    }
}