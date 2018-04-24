using AngularJsProjectApi.DTO;
using AngularJsProjectApi.Models;
using System.Linq;
using System.Web.Http;

namespace AngularJsProjectApi.API
{
    public class PostController : ApiController
    {
        private readonly ScheduleContext dbContext;

        public PostController()
        {
            this.dbContext = new ScheduleContext();
        }

        [HttpPost, Route("api/groups/add")]
        public void AddGroup([FromBody]GroupDTO group)
        {
            dbContext.GROUP.Add(new GROUP()
            {
                Name = group.Name
            });

            dbContext.SaveChanges();

            var groupId = dbContext.GROUP.OrderByDescending(g => g.Id).Select(g => g.Id).FirstOrDefault();

            for (int i = 1; i < 6; i++)
            {
                dbContext.Hour8.Add(new Hour8() { DayId = i, GroupId = groupId, Name = "Okienko" });
                dbContext.Hour9.Add(new Hour9() { DayId = i, GroupId = groupId, Name = "Okienko" });
                dbContext.Hour10.Add(new Hour10() { DayId = i, GroupId = groupId, Name = "Okienko" });
                dbContext.Hour11.Add(new Hour11() { DayId = i, GroupId = groupId, Name = "Okienko" });
                dbContext.Hour12.Add(new Hour12() { DayId = i, GroupId = groupId, Name = "Okienko" });
                dbContext.Hour13.Add(new Hour13() { DayId = i, GroupId = groupId, Name = "Okienko" });
                dbContext.Hour14.Add(new Hour14() { DayId = i, GroupId = groupId, Name = "Okienko" });
                dbContext.Hour15.Add(new Hour15() { DayId = i, GroupId = groupId, Name = "Okienko" });
            }

            dbContext.SaveChanges();
        }
    }
}
