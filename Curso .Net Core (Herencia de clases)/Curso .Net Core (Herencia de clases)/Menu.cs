using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_.Net_Core__Herencia_de_clases_
{
    class Menu : IMenu
    {
        Almacen golosina = new Golosinas();
        public void golosinas()
        {
            var des = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de golocinas y frutas");
                if (golosina.getProducto("").Count.Equals(0))
                {
                    Console.WriteLine("No hay golocinas");
                    Console.WriteLine("Desea agregar golocinas precione la letra s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("Cuantas golosinas va a agregar");
                        int cantidad = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Nueva golosina");
                            Console.WriteLine("Ingrese el ID");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            golosina.addProducto(new Producto
                            {
                                id = id,
                                nombre = nombre,
                                precio = precio
                            }); ;
                        }
                        Console.WriteLine("Desea ir al inicio? s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desea ir al inicio? s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de golocinas y frutas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas: ");
                    foreach (var item in golosina.getProducto(""))
                    {
                        Console.WriteLine($"ID= {item.id} Golosina {item.nombre} precio {item.precio}");
                    }
                    Console.WriteLine("Desea realizar venta de golosina s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        ventas();
                    }
                    else
                    {
                        valor = false;
                    }
                }

            } while (valor);
        }

        public double solicitarPago()
        {
            bool pagoCorrecto = false;
            double res = 0;
            while (!pagoCorrecto)
            {
                Console.WriteLine("Como desea pagar con: 10, 5");
                res = double.Parse(Console.ReadLine());
                if (res != 5 && res != 10)
                {
                    Console.WriteLine("Pago no valido");
                }
                else
                {
                    pagoCorrecto = true;
                }
            }
            return res;
        }

        public void ventas()
        {
            double total = 0;
            String des = "";
            do
            {
                Console.WriteLine("Ingrese el producto");
                String producto = Console.ReadLine();
                var productos = golosina.getProducto(producto);
                while (productos.Count.Equals(0)) 
                {
                    Console.WriteLine("Golosina no disponible por favor ingrese otro");
                    producto = Console.ReadLine();
                    productos = golosina.getProducto(producto);
                }
                Console.WriteLine($"Su monto a pagar es: {productos[0].precio} $ Dolar");
                double pago = solicitarPago();
                while (pago < productos[0].precio)
                {
                    Console.WriteLine("Faltan " +(productos[0].precio - pago).ToString() + " $ Dolar");
                    pago += solicitarPago();
                }
                Console.WriteLine("Su cambio es: "+ (pago - productos[0].precio).ToString());
                total += productos[0].precio;
                Console.WriteLine("Su pago fue de " + total.ToString() + " $ dolar");
                Console.WriteLine("Desea realizar otra compra s/n");
                des = Console.ReadLine();
            } while (des.Equals("s"));
        }
    }
}
