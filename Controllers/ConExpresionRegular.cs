using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppWeb_Regex.Models;
using System.IO;

namespace AppWeb_Regex.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ConExpresionRegular : ControllerBase
    {
        [HttpGet("ConsultarValidacion/{Asunto}")]
        public bool Get(string Asunto)
        {
            return (new ExpresionRegular().ValidarExpresionRegular(Asunto));
        }

        //public bool Post(string Asunto)
        //{
        //    return (new ExpresionRegular().ValidarExpresionRegular(Asunto));
        //}
    }
}
