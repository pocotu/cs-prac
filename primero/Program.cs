using System;

namespace primero
{
    // Clase principal (Main)
    class programa
    {
        // Método principal (Main: punto de entrada de la aplicación .NET)
        // void indica que no devuelve nada
        // static indica que no necesita una instancia de la clase para ser ejecutado
        // instancia es un objeto de una clase (ejemplo: new programa())
        static void Main(string[] args)
        {
            int anio = 2023; // declaración de una variable de tipo entero
            Console.WriteLine("Hola a todos " + anio);
            // Console.ReadLine(); // Espera a que se pulse una tecla, otro metodo es Console.ReadKey();
            Console.ReadLine();
        }
    }
}