using StrategyWithInterface.Route.Interfaces;

namespace StrategyWithInterface.Route
{
    public class RoadStrategy : IRouteStrategy
    {
        public string BuildRoute(string pointA, string pointB)
        {
            return $"La forma más facil de viajar desde {pointA} hasta {pointB}";
        }
    }
}
