using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafíoHerencia_francisco_linan
{
    abstract public class Inmueble
    {
        protected int superficie;
        protected int antiguedad;
        protected int precio_base;
        abstract public float CalcularPrecio();

        protected float PrecioComun()
        {
            float precio = this.precio_base;

            if (this.antiguedad < 15)
            {
                precio -= precio * 0.01f;
            }
            else
            {
                precio -= precio * 0.02f;
            }

            return precio;
        }
    }
}
