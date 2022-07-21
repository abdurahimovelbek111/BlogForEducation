
using System.Collections.Generic;

namespace BlogForEducation.Application.DTOs
{
    public class UserDto:UserForCreationDto
    {
        public int Id { get; set; }
        public IList<BlogDto> Blogs { get; set; }
    }
}
