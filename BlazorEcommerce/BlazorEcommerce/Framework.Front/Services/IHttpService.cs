using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Front.Services
{
    public interface IHttpService
    {
        Task<T> Get<T>(string uri);
        Task Post<T>(string uri, object value);
        Task Put<T>(string uri, object value);
        Task Delete(string uri);
    }
}
