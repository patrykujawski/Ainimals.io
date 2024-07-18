using Ainimals.io.ImagineAPI;
using RestEase;

namespace Ainimals.io;

public interface ImagineApi
{
    [Post("/items/images/")]
    Task<Payload> GenerateImage();
        
    [Get("/items/images/{imageId}")]
    Task<Payload> GetImage([Path] string imageId);
    
}