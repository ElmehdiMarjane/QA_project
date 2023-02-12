using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Front.Models.Dtos;
using Front.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Front.Controllers
{
    
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(IQuestionService questionService, ILogger<QuestionController> logger)
        {
            _questionService = questionService;
            _logger = logger;
        }

        public async Task<IActionResult> QuestionIndex()
        {
            Console.WriteLine("Reached ---------------------------------------");
            List<QuestionDto> list=new();
            var response=await _questionService.GetAllQuestionsAsync<ResponseDTO>();
            
            if(response!=null){
                list= JsonConvert.DeserializeObject<List<QuestionDto>>(Convert.ToString(response.Data));
                Console.WriteLine("Reached --------------------------------------->"+list.Count);
            }
            
            return View(list);
        }


    }
}