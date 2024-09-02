using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2_PSAM
{
    internal class Menu
    {
        List<Opcion> opciones;
        private Operacion operacion;

        public Menu()
        {
            //operacion = new Operacion();
            opciones = new List<Opcion>()
            {
                new Opcion("Sumar", Suma),
                new Opcion("Resta", Resta),
                new Opcion("Multiplicación", Multiplicacion),
                new Opcion("División", Division),
                new Opcion("Salir", Salir),
             };

            while (true)
            {
                Console.WriteLine("**Calculadora de números enteros**");
                Console.WriteLine("Seleccione la opción deseada:");
                Console.WriteLine();
                MostrarMenu();
                Console.WriteLine();
                seleccionarOpcion();
            }
        }

        ////
        public void MostrarMenu()
        {
            foreach(Opcion opcion in opciones)
            {
                Console.WriteLine(opciones.IndexOf(opcion) + " .  " + opcion.Message);
            }
        }

        public void seleccionarOpcion()
        {
            int numOpcion = int.Parse(Console.ReadLine());
            Console.Clear();
            opciones[numOpcion].Action.Invoke();
            Console.Clear();
        }

        public Operacion solicitarNumeros()
        {
            Console.WriteLine("Ingresa el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            
            return operacion = new Operacion(num1, num2);
        }

        public void Continuar()
        {
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
        }

        ////
        
        public void Suma()
        {
            Operacion operacion = solicitarNumeros();
            Console.WriteLine("El resultado de la suma es: " + operacion.Suma());
            Continuar();
        }
        public void Resta()
        {
            Operacion operacion = solicitarNumeros();
            Console.WriteLine("El resultado de la resta es: " + operacion.Resta());
            Continuar();
        }

        public void Multiplicacion()
        {
            Operacion operacion = solicitarNumeros();
            Console.WriteLine("El resultado de la multiplicación es: " + operacion.Multiplicacion());
            Continuar();
        }

        public void Division()
        {
            Console.WriteLine("IMPORTANTE: No ingresar 0 como divisor");
            Operacion operacion = solicitarNumeros();
            Console.WriteLine("El resultado de la división es: {0:F2}", operacion.Division());
            Continuar();
        }

        public void Salir()
        {
            Console.WriteLine("Cerrando el programa...");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
    }
}
