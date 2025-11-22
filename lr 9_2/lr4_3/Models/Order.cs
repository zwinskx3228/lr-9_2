namespace lr4_3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
    }
}