using ExercicioEnumEComp.Entities.Enums;

namespace ExercicioEnumEComp.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() 
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            int quantity = 0;
            double price = 0.00;
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                quantity = item.Quantity;
                price = item.Price;
                sum += (quantity * price);
            }
            return sum;
        }
        
    }
}
