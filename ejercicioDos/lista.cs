using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ejercicioDos
{
    internal class lista
    {
        public int[] mauricioList = new int[10];
        public int[] NuevamauricioList = new int[10];



        public lista() {

            for (int i = 0; i < mauricioList.Length; i++)
            {
                mauricioList[i] = i+1;
               
            }
        }


        public void agregarElementos()
        {
            verElementos();
            int numero;


            Console.WriteLine("que numero desea agregar?");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                           ");

            mauricioList = mauricioList.Append(numero).ToArray();

            
            foreach (var item in mauricioList)
            {
                Console.WriteLine(item);
            }
            mauricioList = NuevamauricioList;
            Console.ReadLine();

        }


        public void verElementos()
        {
            string elementostr = "";
            for (int i = 0; i < mauricioList.Length; i++)
            {
                elementostr += "[" + mauricioList[i] + "]";
            }
            Console.WriteLine(elementostr);
            //Console.Read();


        }

        public void AgregarUnElemntoPosicion()
        {
            verElementos();
            int posicion;
            int ingresar;
            Console.WriteLine("Seleccione la posicion que desea ingresar el numero");
            posicion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seleccione el numero que desea ingresar");
            ingresar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("                                               ");

            int i = mauricioList.Length - 1;

            while (i < posicion)
            {
                mauricioList[i] = mauricioList[i - 1];
                i--;
            }
            mauricioList[posicion] = ingresar;

            foreach (var mauricioLista in mauricioList)
            {
                Console.WriteLine(mauricioLista);
            }
            Console.Read();


        }


        public void EleminarElemento()
        {
          

            verElementos();
            NuevamauricioList = new int[mauricioList.Length -1]; 
            int posicion;

            Console.WriteLine("indique el indice del elemento que desea eleminar");
            posicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                                               ");

            int j = 0;
            for (int i = 0; i < NuevamauricioList.Length; i++)
            {
                
                if (i == posicion)
                {
                    j++;
                }
                NuevamauricioList[i] = mauricioList[j];
                j++;
            }
            mauricioList = NuevamauricioList;
            verElementos();
            Console.Read();

        }

        public void buscarElementoDentroDeLista()
        {
            verElementos();
            int elemento;

            Console.WriteLine("ingrese el numero que desea saber su indice");
            elemento = Convert.ToInt32(Console.ReadLine());

            int indice = Array.IndexOf(mauricioList, elemento);
            Console.WriteLine("el indice es: " + indice.ToString());
           
            Console.Read();

        }

        public void buscarElementoPorIndice()
        {
            verElementos();

            Console.WriteLine("ingrese el indice del elemento que desea buscar");
            int indice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("el elemento es: " + mauricioList[indice]);

            Console.Read();

        }

    }
}
