using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MEH.Teste.API.Controllers
{
    [Route("api/error")]
    [ApiController]
    public class TestErrorController : ControllerBase
    {
        // GET: api/error
        /// <summary>
        /// Gera uma exception para testes.
        /// </summary>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // Gera erro 500
            throw new NullReferenceException();
        }
    }
}
