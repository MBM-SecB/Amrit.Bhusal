using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers
{
    [Route("/api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Route("getstring")]
        public string[] GetString()
        {
            return new string[] {"Amrit Bhusal","Amri Bhusal"};
        }
        [Route("getstring/{int}")]
        public string GetString(int x)
        {
            return "Amrit Bhusal";
        }


    }
}