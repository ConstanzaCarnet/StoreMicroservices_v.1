using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Model;

public class Order
{
	public int Id { get; set; }
	public int ProductId { get; set; }
	public int Quantity { get; set; }
	public decimal TotalPrice { get; set; }
	public DateTime OrderDate { get; set; }

	public Order(int id, int productId, int quantity, decimal totalPrice, DateTime orderDate)
	{
		Id = id;
		ProductId = productId;
		Quantity = quantity;
		TotalPrice = totalPrice;
		OrderDate = orderDate;
    }

}
