using System.Collections.Generic;

namespace AngularJsProjectApi.DTO
{
    public class DayScheduleDTO
    {
        public string Day { get; set; }
        public List<HourScheduleDTO> Schedule { get; set; }
    }
}