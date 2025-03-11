using ValueAPI.Data;
using ValueAPI.Models;      
using Microsoft.AspNetCore.Mvc;

namespace ValueAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PointController : ControllerBase
    {
        private readonly AppDbContext Db;
        public PointController(AppDbContext db)
        {
            Db = db;
        }

        [HttpGet]
        public ActionResult<List<Point>> Get()
        {
            var data = Db.Points.ToList();

            return Ok(data);
        }

        [HttpPost]
        public async  Task<ActionResult<Point>> Post(WritePoint value)
        {
            var sum = Db.Points.Where(x => x.Userid == value.Userid).Sum(i => i.average);
            var count = Db.Points.Where(x => x.Userid == value.Userid).Count();
            Point point = new Point
            {
                Senderid = value.Senderid,
                Userid = value.Userid,
                first = value.first,
                second = value.second,
                third = value.third,
                fourth = value.fourth,
                fifth = value.fifth,
                average = (value.first + value.second + value.third + value.fourth + value.fifth)/5.0
                

            };
            Db.Points.Add(point);
            Db.SaveChanges();
            await Task.Run(() => avarageCounter(value.Userid));
            return Ok(point);
        }
        private void avarageCounter(int id)
        {
            var sum = Db.Points.Where(x => x.Userid == id).Sum(i => i.average);
            var count = Db.Points.Where(x => x.Userid == id).Count();
            Student student = Db.Students.Where(x => x.Id == id).FirstOrDefault();
            student.taverage = Math.Round((double)sum / count,1);
            Db.Students.Update(student);
            Db.SaveChanges();
        }




    }
}
