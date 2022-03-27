using StrategyWithInterface.Route.Interfaces;
using System;

namespace StrategyWithInterface
{
    public class Navigator
    {
        private IRouteStrategy _routeStrategy = null;

        public Navigator() { }

        public void SetRouteStrategy(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public string CalculateRoute(string pointA, string pointB)
        {
            if (_routeStrategy == null)
                throw new Exception("Set a stategy before start to calculate the new route");

            return _routeStrategy.BuildRoute(pointA, pointB);
        }
    }
}
