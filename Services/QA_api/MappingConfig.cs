using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using QA_api.Models;
using QA_api.Models.Dtos;

namespace QA_api
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps(){

            var mappingConfig=new MapperConfiguration(config=>{
                config.CreateMap<QuestionDto,Question>();
                config.CreateMap<Question,QuestionDto>();

            });
            return mappingConfig;
        }
    }
}