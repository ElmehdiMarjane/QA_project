using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QA_api.Models.Dtos;

namespace QA_api.Repositoriy
{
    public interface IQuestionRepository
    {
        Task<IEnumerable<QuestionDto>> GetQuestions();
        Task<QuestionDto> GetQuestion(int QuestionId);

        Task<QuestionDto> CreateUpdateQuestion(QuestionDto question);
        Task<bool> DeleteQuestion(int QuestionId);

        
    }
}