namespace PhanVanViet.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // ✅ Không cần nullable
        public string Image { get; set; } = string.Empty; // ✅ Không cần nullable
        public float Price { get; set; }
    }
}
