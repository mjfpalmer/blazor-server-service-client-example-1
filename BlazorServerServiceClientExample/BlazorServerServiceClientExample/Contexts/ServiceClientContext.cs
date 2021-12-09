namespace BlazorServerServiceClientExample.Contexts
{
  using Microsoft.PowerPlatform.Dataverse.Client;

  public class ServiceClientContext
  {
    public ServiceClientContext()
    {
      string dataverseConnectionString = "<connection string here>";
      this.ServiceClient = new ServiceClient(dataverseConnectionString);
      if (!this.ServiceClient.IsReady)
      {
        throw this.ServiceClient.LastException;
      }
    }

    private ServiceClient ServiceClient { get;set; }
}
}
