using LightInject;
using System.Collections.Generic;

namespace ASPNETCore30WebApp
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IThing, Thing>(new PerRequestLifeTime());
        }
    }

    public class Thing : IThing
    {
        public IEnumerable<string> ProduceValues()
        {
            return new[] { "value1", "value2" };
        }
    }

    public interface IThing
    {
        IEnumerable<string> ProduceValues();
    }
}