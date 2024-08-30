namespace MyFirstWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }  // Ürünün benzersiz kimliği (primary key)

        public string Name { get; set; }  // Ürünün adı

        public string Description { get; set; }  // Ürünün açıklaması

        public decimal Price { get; set; }  // Ürünün fiyatı

        public int Stock { get; set; }  // Ürünün mevcut stok miktarı

        public string Category { get; set; }  // Ürünün kategorisi

        public DateTime CreatedDate { get; set; }  // Ürünün oluşturulma tarihi

        public DateTime UpdatedDate { get; set; }  // Ürünün son güncellenme tarihi

        public bool IsActive { get; set; }  // Ürünün aktif olup olmadığını belirten bayrak
    }

} 