using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicinery.Models
{
    public class Order
    {
        public long Id { get; set; }
        public IEnumerable<AddToCart> Items { get; set; } = Enumerable.Empty<AddToCart>();
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalAmount => Items.Sum(i => i.Amount);

        public OrderStatus Status { get; set; } = OrderStatus.Placed;
        public Color Color => _orderStatusColorsMap[Status];

        private static readonly IReadOnlyDictionary<OrderStatus, Color> _orderStatusColorsMap =
            new Dictionary<OrderStatus, Color>
            {
                [OrderStatus.Placed] = Colors.Yellow,
                [OrderStatus.Confirmed] = Colors.Blue,
                [OrderStatus.Delivered] = Colors.Green,
                [OrderStatus.Cancelled] = Colors.Red,
            };
    }
}
