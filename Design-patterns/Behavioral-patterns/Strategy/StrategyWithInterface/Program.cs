using StrategyWithInterface.Route;
using StrategyWithInterface.Route.Interfaces;
using System;

namespace StrategyWithInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio de Patrón de comportamiento STRATEGY\n");

            Navigator navigator = new Navigator();

            Console.WriteLine("Seleccionando la primera estrategia: Viajar en transporte público");
            IRouteStrategy strategy = new PublicTransportStrategy();
            navigator.SetRouteStrategy(strategy);
            string route = navigator.CalculateRoute("centro", "nor-oriente");
            Console.WriteLine(route + "\n");

            Console.WriteLine("Seleccionando la segunda estrategia: Caminar");
            strategy = new WalkingStrategy();
            navigator.SetRouteStrategy(strategy);
            route = navigator.CalculateRoute("la entrada del bazar", "tienda de souvenir");
            Console.WriteLine(route + "\n");

            Console.WriteLine("Seleccionando la tercera estrategia: Ruta");
            strategy = new RoadStrategy();
            navigator.SetRouteStrategy(strategy);
            route = navigator.CalculateRoute("calle 12", "calle 80");
            Console.WriteLine(route + "\n");

            Console.ReadKey();
        }
    }
}
