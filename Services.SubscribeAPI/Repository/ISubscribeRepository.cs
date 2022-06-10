using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.SubscribeAPI.Repository
{
    public interface ISubscribeRepository
    {
        Task<List<string>> PullMessage();
    }
}
