using Framework.Front.Model;
using Framework.Front.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Front.ApiServices
{
    public abstract class ApiServiceBase
    {
        private readonly IHttpService _httpService;

        public ApiServiceBase(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public abstract string ApiUrl { get; set; }

        public async Task<List<TModel>> GetAll<TModel>() where TModel : class, IModel
        {
            return await _httpService.Get<List<TModel>>(ApiUrl);
        }
        public async Task<TModel> FindById<TModel>(Guid id) where TModel : class, IModel
        {
            return await _httpService.Get<TModel>(ApiUrl + "/" + id);
        }
        public async Task Create<TModel>(TModel model) where TModel : class, IModel
        {
            await _httpService.Post<TModel>(ApiUrl, model);
        }
        public async Task Edit<TModel>(TModel model) where TModel : class, IModel
        {
            await _httpService.Put<TModel>(ApiUrl, model);
        }
        public async Task Delete(Guid id)
        {
            await _httpService.Delete(ApiUrl + "?Id" + id);
        }
    }
}
