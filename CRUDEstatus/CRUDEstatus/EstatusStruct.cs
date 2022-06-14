using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    public class EstatusStruct
    {

        public EstatusStruct(string ide, string nombre, string apellidos) {
            IDE = ide;
            NOM = nombre;
            APP = apellidos;
        }


        public EstatusStruct() { }
        public string IDE { get; set; }
        public string NOM { get; set; }
        public string APP { get; set; }



    }


    }
