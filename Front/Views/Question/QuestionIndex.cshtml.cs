using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Front.Views.Question
{
    public class QuestionIndex : PageModel
    {
        private readonly ILogger<QuestionIndex> _logger;

        public QuestionIndex(ILogger<QuestionIndex> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}