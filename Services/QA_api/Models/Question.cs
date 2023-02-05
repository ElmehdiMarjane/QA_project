using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace QA_api.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int QuestionId {get;set;}
        [Required,StringLength(25)]
        public string QuestionText {get;set;}
        public int Points{get;set;}
        public string Answer{get;set;}
        public string Category {get;set;}
    }
}