using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FiboApi.Controllers
{
    [Route("api/[controller]")]
    public class FiboController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public int Get(int id)
        {
            return fibo(id);
        }

        private int fibo(int number)
        {
            if (number < 2) return 1;
            return fibo(number - 1) + fibo(number - 2);
        }
    }
}
