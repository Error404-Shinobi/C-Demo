using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRelationDemo
{
    public class Delivery
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Number { get; set; }
        public Order order { get; set; }
        public int OrderId { get; set; }
    }
}
