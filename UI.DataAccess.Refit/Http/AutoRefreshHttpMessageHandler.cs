using System.Net.Http.Headers;
using UI.DataAccess.Refit.Stores;

namespace UI.DataAccess.Refit.Http;

public class AutoRefreshHttpMessageHandler : DelegatingHandler
{
    //private readonly TokenStore _tokenStore;

    public AutoRefreshHttpMessageHandler(/*TokenStore tokenStore)*/ ) : base(new HttpClientHandler())
    {
        //_tokenStore = tokenStore;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TokenStore.AccessToken);
        return base.SendAsync(request, cancellationToken);
    }
}
