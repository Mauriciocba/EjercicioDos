using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            lista mauricioListaNueva = new lista();
            int numeroSeleccion;

            Console.WriteLine("1-agregar un elemento al final de la lista");
            Console.WriteLine("2-agregar un elemento en alguna posición de la lista");
            Console.WriteLine("3-eliminar un elemento");
            Console.WriteLine("4-buscar un elemento en la lista (devolviendo su posición)");
            Console.WriteLine("5-obtener un elemento (en la posición de la lista indicada)");
            Console.WriteLine("0-Para salir");


            numeroSeleccion = Convert.ToInt32(Console.ReadLine());

            switch (numeroSeleccion)
            {
                case 1:
                    mauricioListaNueva.agregarElementos();
                    break;
                case 2:
                    mauricioListaNueva.AgregarUnElemntoPosicion();
                    break;
                case 3:
                    mauricioListaNueva.EleminarElemento();
                    break;
                case 4:
                    mauricioListaNueva.buscarElementoDentroDeLista();
                    break;
                case 5:
                    mauricioListaNueva.buscarElementoPorIndice();
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
