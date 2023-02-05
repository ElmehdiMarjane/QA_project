using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QA_api.Context;
using QA_api.Models;
using QA_api.Models.Dtos;

namespace QA_api.Repositoriy
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly Ctx _dbContext;
        private IMapper _mapper;
        public async Task<QuestionDto> CreateUpdateQuestion(QuestionDto questionDto)
        {
            Question question=_mapper.Map<QuestionDto,Question>(questionDto);
            if(question.QuestionId>0){
                _dbContext.Questions.Update(question);
            }else{
                _dbContext.Questions.Add(question);
            }
            await _dbContext.AddRangeAsync();
            return _mapper.Map<Question,QuestionDto>(question);
           
        }

        public async Task<bool> DeleteQuestion(int questionId)
        {
            try{


            
           Question question=await _dbContext.Questions.FirstOrDefaultAsync(x=>x.QuestionId==questionId);
           if(question==null){
            return false;

           }
           _dbContext.Questions.Remove(question);
           return true;}
           
           catch(Exception e){
            Console.WriteLine("Current error : "+e.Message);
            return false;
           }
        }

        public async Task<QuestionDto> GetQuestion(int questionId)
        {
            Question question=await _dbContext.Questions.Where(x=>x.QuestionId==questionId).FirstOrDefaultAsync();
            return _mapper.Map<QuestionDto>(question);
        }

        public async Task<IEnumerable<QuestionDto>> GetQuestions()
        {
            List<Question> questions=await _dbContext.Questions.ToListAsync();
            return _mapper.Map<List<QuestionDto>>(questions);
        }
    }
}