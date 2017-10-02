using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeBodegas
{
    class Bodega
    {
        private string Responsable;
        private int EspacioTotal;
        private int EspacioOcupado;
        private string TipoHortaliza;

        Bodega(string Responsable, int EspacioTotal, int EspacioOcupado, string TipoHortaliza)
        {
            this.Responsable = Responsable;
            this.EspacioTotal = EspacioTotal;
            this.EspacioOcupado = EspacioOcupado;
            this.TipoHortaliza = TipoHortaliza;
        }
        public string pResponsable
        {
            get
            {
                return Responsable;
            }
            set
            {
                Responsable = value;
            }
        }
        public int pEspacioTotal
        {
            get
            {
                return EspacioTotal;
            }
            set
            {
                EspacioTotal = value;
            }
}
        public int pEspacioOcupado
        {
            get
            {
                return EspacioOcupado;
            }
            set
            {
                EspacioOcupado = value;
            }
        }
            }
}
