using StrategyWithInterface.Route.Interfaces;

namespace StrategyWithInterface.Route
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public string BuildRoute(string pointA, string pointB)
        {
            return $"La mejor forma de conocer la ciudad a través de transporte públic desde {pointA} hasta {pointB}";
        }
    }
}
