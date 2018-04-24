using AngularJsProjectApi.DTO;
using AngularJsProjectApi.Models;
using System.Linq;
using System.Web.Http;

namespace AngularJsProjectApi.API
{
    public class PutController : ApiController
    {
        private readonly ScheduleContext dbContext;

        public PutController()
        {
            this.dbContext = new ScheduleContext();
        }

        [HttpPut, Route("api/put/schedule")]
        public IHttpActionResult Edit([FromBody]EditScheduleDTO schedule)
        {
            var day = dbContext.Day.Where(d => d.Name == schedule.Day).FirstOrDefault();
            var groupId = dbContext.GROUP.Where(g => g.Name == schedule.Group).Select(g => g.Id).FirstOrDefault();
            var hour8 = day.Hour8.Where(h => h.GroupId == groupId).FirstOrDefault();
            var hour9 = day.Hour9.Where(h => h.GroupId == groupId).FirstOrDefault();
            var hour10 = day.Hour10.Where(h => h.GroupId == groupId).FirstOrDefault();
            var hour11 = day.Hour11.Where(h => h.GroupId == groupId).FirstOrDefault();
            var hour12 = day.Hour12.Where(h => h.GroupId == groupId).FirstOrDefault();
            var hour13 = day.Hour13.Where(h => h.GroupId == groupId).FirstOrDefault();
            var hour14 = day.Hour14.Where(h => h.GroupId == groupId).FirstOrDefault();
            var hour15 = day.Hour15.Where(h => h.GroupId == groupId).FirstOrDefault();

            hour8.Name = schedule.Schedule[0].Activity;
            hour9.Name = schedule.Schedule[1].Activity;
            hour10.Name = schedule.Schedule[2].Activity;
            hour11.Name = schedule.Schedule[3].Activity;
            hour12.Name = schedule.Schedule[4].Activity;
            hour13.Name = schedule.Schedule[5].Activity;
            hour14.Name = schedule.Schedule[6].Activity;
            hour15.Name = schedule.Schedule[7].Activity;

            dbContext.SaveChanges();

            return Ok();
        }
    }
}
