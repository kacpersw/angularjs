using AngularJsProjectApi.DTO;
using AngularJsProjectApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AngularJsProjectApi.API
{
    public class GetController : ApiController
    {
        private readonly ScheduleContext dbContext;

        public GetController()
        {
            this.dbContext = new ScheduleContext();
        }

        [HttpGet, Route("api/get/schedule/{dayName}")]
        public DayScheduleDTO GetDaySchedule([FromUri]string dayName)
        {
            var daySchedule = new DayScheduleDTO() { Day = dayName };
            var day = dbContext.Day.Where(d => d.Name == dayName).FirstOrDefault();

            var hour8 = new HourScheduleDTO() { Hour = 8 };
            var hour9 = new HourScheduleDTO() { Hour = 9 };
            var hour10 = new HourScheduleDTO() { Hour = 10 };
            var hour11 = new HourScheduleDTO() { Hour = 11 };
            var hour12 = new HourScheduleDTO() { Hour = 12 };
            var hour13 = new HourScheduleDTO() { Hour = 13 };
            var hour14 = new HourScheduleDTO() { Hour = 14 };
            var hour15 = new HourScheduleDTO() { Hour = 15 };

            hour8.Activities = day.Hour8.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();
            hour9.Activities = day.Hour9.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();
            hour10.Activities = day.Hour10.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();
            hour11.Activities = day.Hour11.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();
            hour12.Activities = day.Hour12.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();
            hour13.Activities = day.Hour13.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();
            hour14.Activities = day.Hour14.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();
            hour15.Activities = day.Hour15.OrderBy(a=>a.GroupId).Select(a => a.Name).ToList();

            daySchedule.Schedule = new List<HourScheduleDTO>();
            daySchedule.Schedule.Add(hour8);
            daySchedule.Schedule.Add(hour9);
            daySchedule.Schedule.Add(hour10);
            daySchedule.Schedule.Add(hour11);
            daySchedule.Schedule.Add(hour12);
            daySchedule.Schedule.Add(hour13);
            daySchedule.Schedule.Add(hour14);
            daySchedule.Schedule.Add(hour15);

            return daySchedule;
        }

        [HttpGet, Route("api/get/groups")]
        public IEnumerable<string> GetGroups() => dbContext
            .GROUP
            .Select(g => g.Name)
            .ToList();

        [HttpGet, Route("api/get/groups")]
        public DayGroupScheduleDTO GetGroupDay(string groupName, string dayName)
        {
            var daySchedule = new DayGroupScheduleDTO() { Group = groupName };

            var day = dbContext.Day.Where(d => d.Name == dayName).FirstOrDefault();
            var groupId = dbContext.GROUP.Where(g => g.Name == groupName).Select(g => g.Id).FirstOrDefault();

            var hour8 = new HourGroupScheduleDTO() { Hour = 8 };
            var hour9 = new HourGroupScheduleDTO() { Hour = 9 };
            var hour10 = new HourGroupScheduleDTO() { Hour = 10 };
            var hour11 = new HourGroupScheduleDTO() { Hour = 11 };
            var hour12 = new HourGroupScheduleDTO() { Hour = 12 };
            var hour13 = new HourGroupScheduleDTO() { Hour = 13 };
            var hour14 = new HourGroupScheduleDTO() { Hour = 14 };
            var hour15 = new HourGroupScheduleDTO() { Hour = 15 };

            hour8.Activity = day.Hour8.OrderBy(a => a.GroupId).Where(e=>e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();
            hour9.Activity = day.Hour9.OrderBy(a => a.GroupId).Where(e => e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();
            hour10.Activity = day.Hour10.OrderBy(a => a.GroupId).Where(e => e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();
            hour11.Activity = day.Hour11.OrderBy(a => a.GroupId).Where(e => e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();
            hour12.Activity = day.Hour12.OrderBy(a => a.GroupId).Where(e => e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();
            hour13.Activity = day.Hour13.OrderBy(a => a.GroupId).Where(e => e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();
            hour14.Activity = day.Hour14.OrderBy(a => a.GroupId).Where(e => e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();
            hour15.Activity = day.Hour15.OrderBy(a => a.GroupId).Where(e => e.GroupId == groupId).Select(a => a.Name).FirstOrDefault();

            daySchedule.Schedule = new List<HourGroupScheduleDTO>();
            daySchedule.Schedule.Add(hour8);
            daySchedule.Schedule.Add(hour9);
            daySchedule.Schedule.Add(hour10);
            daySchedule.Schedule.Add(hour11);
            daySchedule.Schedule.Add(hour12);
            daySchedule.Schedule.Add(hour13);
            daySchedule.Schedule.Add(hour14);
            daySchedule.Schedule.Add(hour15);

            return daySchedule;
        }

    }
}
