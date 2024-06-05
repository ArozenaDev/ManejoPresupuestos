using DocumentFormat.OpenXml.Wordprocessing;

namespace ManejoPresupuesto.Models
{
    public class PaginacionViewModel
    {
        public int Pagina { get; set; } = 1;
        public int recordsPorPagina = 10;
        private readonly int cantidadMaximaRecordsPorPagina = 50;

        public int RecordsPorPagina
        {
            get => recordsPorPagina;
            set
            {
                recordsPorPagina = (value > cantidadMaximaRecordsPorPagina) ? cantidadMaximaRecordsPorPagina : value;
            }
        }

        public int RecordsASaltar => recordsPorPagina * (Pagina - 1);
    }
}
