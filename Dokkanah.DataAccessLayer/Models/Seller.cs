namespace Dokaanah.Models
{
    public class Seller:BaseEntity
    {
        
        public string?     Email          { get; set; }
        public string?     Password       { get; set; }

        public virtual ICollection<Product> GetProducts { get; set; } = new List<Product>();

    }
}
