using Mango.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Website.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        Task<T> SendAsync<T>(APIRequest aPIRequest);
    }
}
