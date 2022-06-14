using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_.Net_Core__Herencia_de_clases_
{
    public class Frutas : Almacen
    {
        public override void addProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public override List<Producto> getProducto(String producto)
        {
            throw new NotImplementedException();
        }
    }
}
