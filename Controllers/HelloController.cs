using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{    
    [ApiController]
    public class HelloController : ControllerBase
    {
        HelloService helloService;

        public HelloController(HelloService helloService)
        {
            this.helloService = helloService;
        }

        //Main page API ../hello
        [Route("[controller]")]
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(helloService.list);
        }

        [Route("[controller]")]
        [HttpPost]
        public ActionResult Post(Hello hello)
        {
            helloService.list.Add(hello);
            return Ok($"Successful Post of {hello.Name}");
        }


        //Delete page ../delete
        [Route("[controller]/[action]")]
        [HttpGet]
        [ActionName("delete")]
        public ActionResult GetDelete()
        {
            return Ok("POST here to delete an entry");
        }

        [Route("[controller]/[action]")]
        [HttpPost]
        [ActionName("delete")]
        public ActionResult Delete(Hello hello)
        {
            if(helloService.list.Remove(hello))
            {
                return Ok("Deleted Successfully");
            }
            else
            {
                return Ok("Deleted Unsuccessfully, no such entry exists");
            }
        }
    }
}