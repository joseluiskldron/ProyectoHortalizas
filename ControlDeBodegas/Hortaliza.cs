using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeBodegas
{
    class Hortaliza
    {
        private int clave;
        private string nombre;
        private string descripcion;
        
        public Hortaliza(int clave, string nombre, string descripcion)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public int pClave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }
        public string pNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string pDescripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
    }
}
