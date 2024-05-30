namespace ManejoPresupuesto.Models
{
    public class TransaccionActualizacionViewModel: TransaccionCreacionViewModel
    {
        public int CuentaAnteriorId { get; set; }
        public decimal CantidadAnterior { get; set; }
        public string urlRetorno { get; set; }
    }
}
