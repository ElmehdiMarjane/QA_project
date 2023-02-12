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
        public Ctx(DbContextOptions<Ctx> options) : base(options)
        {}

        
        public DbSet<Question> Questions{get;set;}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Question>().HasData(new Question
            {
                QuestionId = 1,
                QuestionText = "ChaiseBoisMassif",
                Points = 15,
                Answer = "categorie1",
                Category = "1.jpg"
            });
            modelBuilder.Entity<Question>().HasData(new Question
            {
                QuestionId = 2,
                QuestionText = "ChaiseBoiscqsccsMassif",
                Points = 15,
                Answer = "categorsie1",
                Category = "1.jpg"
            });
            modelBuilder.Entity<Question>().HasData(new Question
            {
                QuestionId = 3,
                QuestionText = "scqscsq",
                Points = 15,
                Answer = "categossrie1",
                Category = "1.jpg"
            });
        }
    }
}