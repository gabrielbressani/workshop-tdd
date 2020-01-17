using System.Threading.Tasks;
using Refit;

namespace Boliche.Api
{
    public interface IBolicheApi
    {
        [Get("/arremessos")]
        Task<ArremessosResponse> ObterArremessos();

    }
}
