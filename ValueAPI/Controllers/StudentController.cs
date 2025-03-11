using ValueAPI.Data;
using ValueAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ValueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext Db;
        public StudentController(AppDbContext db)
        {
            Db = db;
        }

        [HttpGet("{Id}")]
        public ActionResult<List<Student>> Get(int Id)
        {
            var data = Db.Students.Where(x=> x.Id == Id);

            return Ok(data);
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            var data = Db.Students.ToList();

            return Ok(data);
        }
        [HttpPost]
        public ActionResult<List<Student>> Post(WriteStudent data)
        {
            Student student = new Student
            {
                Name = data.Name,
                Surname = data.Surname,
                taverage = 0
            };
                
            Db.Students.Add(student);
            Db.SaveChanges();
            return Ok(data);
        }
    }
}
