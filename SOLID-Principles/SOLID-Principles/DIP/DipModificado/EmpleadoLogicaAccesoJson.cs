using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DipModificado
{
    public class EmpleadoLogicaAccesoJson : IEmpleadoLogicaAccesoDatos
    {
        private readonly List<Empleado> _empleados = new List<Empleado>();
        public EmpleadoLogicaAccesoJson()
        {
            _empleados = LoadJson();
        }
        public Empleado ObtenerDetalleEmpleado(int id)
        {
            return _empleados.FirstOrDefault(e => e.ID == id);
        }

        private List<Empleado> LoadJson()
        {
            using (StreamReader r = new StreamReader("Empleados.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Empleado>>(json);
            }
        }
    }
}
