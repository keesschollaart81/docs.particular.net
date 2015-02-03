namespace Ordering.Subscriber
{
    using NServiceBus;
	public class EndpointConfig : IConfigureThisEndpoint, AsA_Server
    {
	    public void Customize(BusConfiguration configuration)
	    {
	        configuration.UsePersistence<InMemoryPersistence>();
	    }
    }
}