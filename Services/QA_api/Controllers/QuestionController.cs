using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QA_api.Models.Dtos;
using QA_api.Repositoriy;

namespace QA_api.Controllers
{
    [ApiController]
    [Route("api/Questions")]
    public class QuestionController : ControllerBase
    {
        protected ResponseDTO _response;
        private IQuestionRepository questionRepository;

        public QuestionController(ResponseDTO response, IQuestionRepository questionRepository)
        {
            this._response =new ResponseDTO();
            this.questionRepository = questionRepository;
        }


        [HttpGet]
        public async Task<Object> GetAll(){
            try{
                IEnumerable<QuestionDto> questionDtos=await questionRepository.GetQuestions();
                _response.Data=questionDtos;
            }
            
            catch(Exception e){
                _response.Success=false;
                _response.Message=new List<String>{e.ToString()};
            }
            return _response;
        }

        [HttpGet]
        [Route("{questionId}")]
        public async Task<Object> GetOne(int questionId){
            try{
                QuestionDto questionDto=await questionRepository.GetQuestion(questionId);
                _response.Data=questionDto;
            }
            
            catch(Exception e){
                _response.Success=false;
                _response.Message=new List<String>{e.ToString()};
            }
            return _response;
        }
        [HttpPost]
        public async Task<Object> Create([FromBody]QuestionDto questionDto){
            try{
                QuestionDto question=await questionRepository.CreateUpdateQuestion(questionDto);
                _response.Data=question;
            }
            
            catch(Exception e){
                _response.Success=false;
                _response.Message=new List<String>{e.ToString()};
            }
            return _response;
        }

        [HttpPut]
        public async Task<Object> Update([FromBody]QuestionDto questionDto){
            try{
                QuestionDto question=await questionRepository.CreateUpdateQuestion(questionDto);
                _response.Data=question;
            }
            
            catch(Exception e){
                _response.Success=false;
                _response.Message=new List<String>{e.ToString()};
            }
            return _response;
        }

        [HttpDelete]
        [Route("{questionId}")]
        public async Task<Object> Delete(int questionId){
            try{
                _response.Success=await questionRepository.DeleteQuestion(questionId);
                _response.Data=_response.Success;
            }
            
            catch(Exception e){
                _response.Success=false;
                _response.Message=new List<String>{e.ToString()};
            }
            return _response;
        }


    }
}