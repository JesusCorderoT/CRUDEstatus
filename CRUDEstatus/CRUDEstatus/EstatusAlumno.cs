using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class EstatusAlumno
    {
      
       static List<EstatusStruct> _lstPersonas = new List<EstatusStruct>();

        public List<EstatusStruct> ConsultaTodos() {
            return _lstPersonas;
        }

        public static void Agregar(EstatusStruct estados)
        {
            _lstPersonas.Add(new EstatusStruct 
            { IDE = estados.IDE, NOM = estados.NOM, APP = estados.APP });
        }

        public static void ConsultarUno(EstatusStruct est)
        {
            EstatusStruct Edo1 = _lstPersonas.Find(edo => edo.IDE == est.IDE);
            Console.WriteLine($"ID: {Edo1.IDE}, nombre: {Edo1.NOM} apellidos: {Edo1.APP}");
        }

        public static void Actualizar(EstatusStruct est)
        {
            EstatusStruct Edo1 = _lstPersonas.Find(edo => edo.IDE == est.IDE);
            Console.WriteLine("Actualizando al alumno:");
            Console.WriteLine($"ID: {Edo1.IDE}, nombre: ={Edo1.NOM} apellidos {Edo1.APP}");

            Edo1.NOM = est.NOM; 
            Edo1.APP= est.APP;
        }

        public static void Eliminar(EstatusStruct estados)
        {
            EstatusStruct Edo1 = _lstPersonas.Find(edo => edo.IDE == estados.IDE);
            _lstPersonas.Remove(Edo1);
        }
    }
}
