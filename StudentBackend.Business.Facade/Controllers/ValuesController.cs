using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentBackend.Business.Logic.Contracts;
using StudentBackend.Common.Logic;

namespace StudentBackend.Business.Facade.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly IStudentBusinessLogic studentbusinesslogic;

        public ValuesController(IStudentBusinessLogic studentbusinesslogic)
        {
            this.studentbusinesslogic = studentbusinesslogic;
        }

        // GET api/values
        //[HttpGet("api/[controller].{format}"), FormatFilter]
        [HttpGet()]
        public IEnumerable<Student> Get()
        {
            return this.studentbusinesslogic.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return this.studentbusinesslogic.GetById(id);
        }

        // POST api/values
        [HttpPost()]
        public void Post([FromBody]Student student) /*,[FromBody]string value*/
        {
            this.studentbusinesslogic.Add(student);
        }

        // PUT api/values/5
        [HttpPut()]
        public void Put([FromBody]Student student)
        {
            this.studentbusinesslogic.Update(student);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.studentbusinesslogic.Delete(id);
        }
    }
}
