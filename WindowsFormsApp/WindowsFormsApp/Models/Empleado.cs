using System;

namespace WindowsFormsApp.Empleados
{
    public class Empleado
    {
        public Guid EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int? Edad { get; set; }
        public byte[] Foto { get; set; }
    }
}
