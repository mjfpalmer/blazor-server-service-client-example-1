namespace BlazorServerServiceClientExample.Contexts
{
  using Microsoft.PowerPlatform.Dataverse.Client;

  public class ServiceClientContext
  {
    public ServiceClientContext()
    {
    }

    public Lazy<ServiceClient> ServiceClient { get; } = new Lazy<ServiceClient>(() => new ServiceClient("<connection string here>"));
  }
}
