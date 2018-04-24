using AngularJsProjectApi.Models;
using System.Linq;
using System.Web.Http;

namespace AngularJsProjectApi.API
{
    public class DeleteController : ApiController
    {
        private readonly ScheduleContext dbContext;

        public DeleteController()
        {
            this.dbContext = new ScheduleContext();
        }

        [HttpDelete, Route("api/delete/group/{name}")]
        public void DeleteGroup([FromUri]string name)
        {
            var group = dbContext.GROUP.Where(g => g.Name == name).FirstOrDefault();

            var hour8 = dbContext.Hour8.Where(h=>h.GroupId == group.Id).ToList();
            var hour9 = dbContext.Hour9.Where(h => h.GroupId == group.Id).ToList();
            var hour10 = dbContext.Hour10.Where(h => h.GroupId == group.Id).ToList();
            var hour11 = dbContext.Hour11.Where(h => h.GroupId == group.Id).ToList();
            var hour12 = dbContext.Hour12.Where(h => h.GroupId == group.Id).ToList();
            var hour13 = dbContext.Hour13.Where(h => h.GroupId == group.Id).ToList();
            var hour14 = dbContext.Hour14.Where(h => h.GroupId == group.Id).ToList();
            var hour15 = dbContext.Hour15.Where(h => h.GroupId == group.Id).ToList();

            for (var i = 0; i< hour8.Count; i++)
            {
                dbContext.Hour8.Remove(hour8[i]);
            }

            for (var i = 0; i < hour9.Count; i++)
            {
                dbContext.Hour9.Remove(hour9[i]);
            }
        
            for (var i = 0; i < hour10.Count; i++)
            {
                dbContext.Hour10.Remove(hour10[i]);
            }

            for (var i = 0; i < hour11.Count; i++)
            {
                dbContext.Hour11.Remove(hour11[i]);
            }

            for (var i = 0; i < hour12.Count; i++)
            {
                dbContext.Hour12.Remove(hour12[i]);
            }

            for (var i = 0; i < hour13.Count; i++)
            {
                dbContext.Hour13.Remove(hour13[i]);
            }

            for (var i = 0; i < hour14.Count; i++)
            {
                dbContext.Hour14.Remove(hour14[i]);
            }

            for (var i = 0; i < hour15.Count; i++)
            {
                dbContext.Hour15.Remove(hour15[i]);
            }
            dbContext.SaveChanges();

            dbContext.GROUP.Remove(group);
            dbContext.SaveChanges();
        }
    }
}
