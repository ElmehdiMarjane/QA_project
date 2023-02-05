using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_api.Models.Dtos
{
    public class QuestionDto
    {
        public int QuestionId {get;set;}
        public string QuestionText {get;set;}
        public int Points{get;set;}
        public string Answer{get;set;}
        public string Category {get;set;}
    }
}