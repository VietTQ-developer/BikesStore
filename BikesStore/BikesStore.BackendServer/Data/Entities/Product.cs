namespace BikesStore.BackendServer.Data.Entities
{
    public class Product
    {
        public int Product_ID { get; set; }
        public int Product_Name { get; set; }
        public int Brand_ID { get; set; }
        public int Category_ID { get; set; }
        public int Model_Year { get; set; }
        public decimal List_Price { get; set; }
    }
}
