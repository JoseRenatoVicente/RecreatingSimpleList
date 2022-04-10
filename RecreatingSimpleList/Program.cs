using System;
using System.Collections.Generic;

namespace RecreatingSimpleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<Paciente> lista1 = new Lista<Paciente>();

            Paciente paciente1 = new Paciente("José Renato", "352.122.277-20", DateTime.Now);
            Paciente paciente2 = new Paciente("Ana", "121.144.277-20", DateTime.Now);
            Paciente paciente3 = new Paciente("Bianca", "826.439.272-28", DateTime.Now);
            Paciente paciente4 = new Paciente("Rafael", "826.439.272-28", DateTime.Now);
            Paciente paciente5 = new Paciente("Susi", "826.439.272-28", DateTime.Now);


            lista1.Add(paciente1);
            lista1.Add(paciente2);
            lista1.Add(paciente3);
            lista1.Add(paciente4);
            lista1.Add(paciente5);

            lista1.Remove(paciente1);

            lista1.RemoveAt(2);

            lista1.Sort();

            Console.WriteLine(lista1.Count);

            /*Lista<string> lista1 = new Lista<string>();

             lista1.Add("0");
             lista1.Add("0");
             lista1.Add("1");
             lista1.Add("2");
             lista1.Add("3");

             lista1.Add("1");
             lista1.Add("4");
             lista1.Add("4");
             lista1.Add("4");
             lista1.Add("4");
             lista1.Add("4");
             lista1.Add("4");

             lista1.Sort();*/

            /*List<string> lista = new List<string>();
            lista.Insert(0, "teste");
            lista.Insert(1, "teste2");

            Console.WriteLine(lista[1] + " " + lista[2]);

            lista.ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine();
            lista.ForEach(delegate (string i) { Console.WriteLine(i.ToString()); }); */




            Console.ReadKey();

        }
    }
}
