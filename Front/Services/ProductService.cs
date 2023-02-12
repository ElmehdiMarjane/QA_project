

using Front.Models;
using Front.Models.Dtos;
using Front.Services.IServices;

namespace Front.Services
{
    public class QuestionService : BaseService, IQuestionService
    {
        private readonly IHttpClientFactory _httpClient;
        public QuestionService(IHttpClientFactory httpClient):base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> CreateQuestionAsync<T>(QuestionDto questionDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data= questionDto,   
                Url = SD.QuestionAPIBase + "/api/Questions",
               // AccessToken = token

            }

                );
        }

        public async Task<T> DeleteQuestionAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.QuestionAPIBase + "/api/Questions/"+id,
                //AccessToken = token

            }

                );
        }

        public async Task<T> GetAllQuestionsAsync<T>()
        {
           return await this.SendAsync<T>(new ApiRequest()
            {
                 ApiType=SD.ApiType.GET,
                 Url=SD.QuestionAPIBase+"/api/Questions",
                // AccessToken=token

            }
                
                );
        }

        public async Task<T> GetQuestionByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.QuestionAPIBase + "/api/Questions/"+id,
               // AccessToken = token

            }

                );
        }

        public async Task<T> UpdateQuestionAsync<T>(QuestionDto QuestionDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data= QuestionDto,
                Url = SD.QuestionAPIBase + "/api/Questions",
               // AccessToken = token

            }

                );
        }
    }
}
