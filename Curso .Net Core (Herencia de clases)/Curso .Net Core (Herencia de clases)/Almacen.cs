using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_.Net_Core__Herencia_de_clases_
{
    public abstract class Almacen
    {
        public abstract List<Producto> getProducto(string producto);
        public abstract void addProducto(Producto producto);
    }
}
