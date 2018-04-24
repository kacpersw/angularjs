using System.Collections.Generic;

namespace AngularJsProjectApi.DTO
{
    public class EditScheduleDTO
    {
        public string Day { get; set; }
        public string Group { get; set; }
        public List<HourGroupScheduleDTO> Schedule { get; set; }
    }
}