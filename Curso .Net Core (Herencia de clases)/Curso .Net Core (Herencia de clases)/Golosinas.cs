using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Curso_.Net_Core__Herencia_de_clases_
{
    class Golosinas : Almacen
    {

        private List<Producto> golosinas;
        public Golosinas()
        {
            golosinas = new List<Producto>();
        }
        public override void addProducto(Producto producto)
        {
            golosinas.Add(producto);
        }

        public override List<Producto> getProducto(String producto)
        {
            var Golosinas = new List<Producto>();
            if (producto.Equals(""))
            {
                Golosinas = golosinas;
            }
            else
            {
                Golosinas = golosinas.Where(g => g.nombre.Equals(producto)).ToList();
            }
            return Golosinas;
        }
    }
}
