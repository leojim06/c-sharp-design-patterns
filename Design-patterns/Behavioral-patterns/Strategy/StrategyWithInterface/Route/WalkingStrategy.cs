using StrategyWithInterface.Route.Interfaces;

namespace StrategyWithInterface.Route
{
    public class WalkingStrategy : IRouteStrategy
    {
        public string BuildRoute(string pointA, string pointB)
        {
            return $"Camina desde {pointA} hasta {pointB}";
        }
    }
}
