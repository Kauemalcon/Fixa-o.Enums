using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixação.Enums.Entities.Enums;

namespace Fixação.Enums.Entities
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemsPedido> Item { get; set; } = new List<ItemsPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime momento, StatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemsPedido item)
        {
            Item.Add(item);
        }

        public void RemoveItem(ItemsPedido item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (ItemsPedido item in Item)
            {
                soma += item.SubTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Item pedido:");
            foreach (ItemsPedido item in Item)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
