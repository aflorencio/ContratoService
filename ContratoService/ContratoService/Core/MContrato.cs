using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoService
{
    public class FichaCliente
    {
        public string particularEmpresa { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipoDocIdentidad { get; set; }
        public string docIdentidad { get; set; }
        public string localidad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string nombreEmpresa { get; set; }
        public string tipoDocIdentidadEmpresa { get; set; }
        public string docIdentidadEmpresa { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string buscadoresContratados { get; set; }
        public string palabrasClavesContratadas { get; set; }
        public string totalPresupuesto { get; set; }
        public string moneda { get; set; }
        public int totalEnlaces { get; set; }
        public string fechaFinal { get; set; }
    }

    public class ContratoEntre
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipoDocIdentidad { get; set; }
        public string docIdentidad { get; set; }
        public string localidad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
    }

    public class Apoderamiento
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipoDocIdentidad { get; set; }
        public string docIdentidad { get; set; }
        public string localidad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string documentoServiceID { get; set; }
    }

    public class Pago
    {
        public int importe { get; set; }
        public string moneda { get; set; }
        public string plazosPago { get; set; }
    }

    public class AcuerdoConfidencialidad
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string tipoDocIdentidad { get; set; }
        public string docIdentidad { get; set; }
        public string localidad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
    }

    public class MContrato
    {
        public string _id { get; set; }
        public string fecha { get; set; }
        public List<bool> contratoContiene { get; set; }
        public string nota { get; set; }
        public FichaCliente fichaCliente { get; set; }
        public ContratoEntre contratoEntre { get; set; }
        public List<string> enlacesEliminar { get; set; }
        public List<Apoderamiento> apoderamiento { get; set; }
        public List<string> documentoIdentitad { get; set; }
        public Pago pago { get; set; }
        public AcuerdoConfidencialidad acuerdoConfidencialidad { get; set; }
    }
}
