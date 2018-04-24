using System.Collections.Generic;

namespace AngularJsProjectApi.DTO
{
    public class DayGroupScheduleDTO
    {
        public string Group { get; set; }
        public List<HourGroupScheduleDTO> Schedule { get; set; }
    }
}