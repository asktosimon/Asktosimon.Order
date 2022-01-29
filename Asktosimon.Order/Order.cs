namespace Asktosimon.Order
{
    public class Order<TDelivery>
    {
        public TDelivery Delivery { get; set; }

        public string ID { get; }

        public Client Recipent { get; }

        public List<Product> Products { get; }

        public Dictionary<int, string> CountOfProducts { get; }

        public Order(
            Client client,
            string ID,
            TDelivery delivery,
            List<Product> products,
            Dictionary<int, string> countOfProducts
        )
        {
            Recipent = client;
            this.ID = ID;
            Delivery = delivery;
            Products = products;
            CountOfProducts = countOfProducts;
        }
    }
}