using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QA_api.Models;

namespace QA_api.Context
{
    public class Ctx : DbContext
    {
        public Ctx(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Question> Questions{get;set;}
    }
}