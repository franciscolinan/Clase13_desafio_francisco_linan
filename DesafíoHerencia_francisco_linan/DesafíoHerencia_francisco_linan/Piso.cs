using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafíoHerencia_francisco_linan
{
    public class Piso : Inmueble
    {
        private int piso_nro;

        public Piso(int piso_nro, int superficie, int antiguedad, int precio_base)
        {
            this.piso_nro = piso_nro;
            this.superficie = superficie;
            this.antiguedad = antiguedad;
            this.precio_base = precio_base;
        }

        override public float CalcularPrecio()
        {
            float precio = this.PrecioComun();

            if (this.piso_nro >= 3)
            {
                precio += precio * 0.03f;
            }

            return precio;
        }
    }
}
