using Ainimals.io.ImagineAPI;
using RestEase;

namespace Ainimals.io;

public class ImagineApiImpl : ImagineApi
{
    private static readonly Uri BaseUri = new Uri("https://demo.imagineapi.dev");
    private readonly ImagineApi _imagineApi = RestClient.For<ImagineApi>(BaseUri);
        
    public async Task<Payload> GenerateImage()
    {
        return await _imagineApi.GenerateImage();
    }

    public async Task<Payload> GetImage(string imageId)
    {
        return await _imagineApi.GetImage(imageId);
    }
}
