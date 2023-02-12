
using Front.Models;
using Front.Models.Dtos;

namespace Front.Services.IServices
{
    public interface IBaseService :IDisposable
    {
        public ResponseDTO ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
