using Front.Models.Dtos;

namespace Front.Services.IServices
{
    public interface IQuestionService:IBaseService
    {
        Task<T> GetAllQuestionsAsync<T>();
        Task<T> GetQuestionByIdAsync<T>(int id);
        Task<T> CreateQuestionAsync<T>(QuestionDto QuestionDto);
        Task<T> UpdateQuestionAsync<T>(QuestionDto QuestionDto);
        Task<T> DeleteQuestionAsync<T>(int id );

    }
}
