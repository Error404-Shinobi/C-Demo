using OneRelationDemo;

Order order = new Order();
order.Name = "Order1";
order.Address = "Address1";
Delivery delivery = new Delivery();
delivery.Number="ST100001";
delivery.CompanyName = "Company1";
//delivery.order = order;
order.delivery = delivery;
using (MyDbContext db = new MyDbContext())
{
    db.Orders.Add(order);
    db.Deliveries.Add(delivery);
    db.SaveChanges();
}