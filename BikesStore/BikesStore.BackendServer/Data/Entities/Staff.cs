namespace BikesStore.BackendServer.Data.Entities
{
    public class Staff
    {
        public int Staff_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Active { get; set; }
        public int Store_ID { get; set; }
        public string Manager_ID { get; set; }
    }
}
