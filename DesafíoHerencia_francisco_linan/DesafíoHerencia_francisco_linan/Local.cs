using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafíoHerencia_francisco_linan
{
    public class Local : Inmueble
    {
        private int nro_ventanas;

        public Local(int nro_ventanas, int superficie, int antiguedad, int precio_base)
        {
            this.nro_ventanas = nro_ventanas;
            this.superficie = superficie;
            this.antiguedad = antiguedad;
            this.precio_base = precio_base;
        }

        override public float CalcularPrecio()
        {
            float precio = this.PrecioComun();

            if (this.superficie > 50)
            {
                precio += precio * 0.01f;
            }

            if (this.nro_ventanas <= 1)
            {
                precio -= precio * 0.02f;
            }    

            if (this.nro_ventanas > 4)
            {
                precio += precio * 0.02f;
            }

            return precio;
        }
    }
}
