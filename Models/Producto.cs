namespace smart_stock.Models
{
    public class Producto
    {
        public int id_producto { get; set; }
       public string nombre { get; set; } = string.Empty;
        public string marca { get; set; } = string.Empty;
       public decimal precio { get; set; } 
        public int stock { get; set; }
        DateTime? FechaCreacion { get; set; }
    }
}
