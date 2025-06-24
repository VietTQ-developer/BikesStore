namespace BikesStore.BackendServer.Data.Entities
{
    public class Order_Item
    {
        public int Order_ID { get; set; }
        public int Item_ID { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public decimal List_Price { get; set; }
        public decimal Discount { get; set; }
    }
}
