using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QA_api.Models.Dtos
{
    public class ResponseDTO
{
    public bool Success { get; set; }=true;
    public List<String> Message { get; set; }
    public object Data { get; set; }
}
}