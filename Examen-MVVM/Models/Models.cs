namespace Examen_MVVM.Models
{
    public class Producto
    {
        public decimal Precio { get; set; }
    }

    public class CalculoDescuento
    {
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
    }
}