namespace BikesStore.BackendServer.Data.Entities
{
    public class Order
    {
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        //Order status: 1 = Pending; 2 = Processing; 3 = Rejected; 4 = Completed
        public int Order_Status { get; set; }
        public DateTime Order_Date { get; set; }
        public DateTime Required_Date { get; set; }
        public DateTime Shipped_Date { get; set; }
        public int Store_ID { get; set; }
        public int Staff_ID { get; set; }
    }
}
