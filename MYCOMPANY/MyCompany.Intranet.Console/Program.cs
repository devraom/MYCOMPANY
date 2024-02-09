using System;
using System.Collections.Generic;

namespace MyCompany.Intranet.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese el número de empleados a capturar: ");
            int n = int.Parse(System.Console.ReadLine());

            List<Empleado> empleados = new List<Empleado>();

            for (int i = 0; i < n; i++)
            {
                Empleado oent = new Empleado();

                System.Console.WriteLine("Empleado Número " + (i + 1));
                System.Console.WriteLine("Nombre: ");
                oent.nombre = System.Console.ReadLine();
                System.Console.WriteLine("Horas: ");
                oent.horas = int.Parse(System.Console.ReadLine());
                empleados.Add(oent);
                oent = null;
            }

            foreach (Empleado empleado in empleados)
            {
                System.Console.WriteLine("Empleado");
                System.Console.WriteLine("Nombre: " + empleado.nombre);
                System.Console.WriteLine("Horas: " + empleado.horas + "hrs.");

                decimal salario = empleado.horas * 20;
                if (empleado.horas > 40)
                    salario += (empleado.horas - 40) * 5;

                System.Console.WriteLine("Salario: $" + salario);
            }
        }
    }

    public class Empleado
    {
        public string nombre { get; set; }
        public int horas { get; set; }
    }
}