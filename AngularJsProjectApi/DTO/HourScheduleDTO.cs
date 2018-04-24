using System.Collections.Generic;

namespace AngularJsProjectApi.DTO
{
    public class HourScheduleDTO
    {
        public int Hour { get; set; }
        public List<string> Activities { get; set; }
    }
}