using System.Collections.Generic;

namespace AngularJsProjectApi.DTO
{
    public class GroupScheduleDTO
    {
        public string Group { get; set; }
        public List<HourGroupScheduleDTO> Schedule { get; set; }
    }
}