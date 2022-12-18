using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public record RegisterDto
    {
        public String? FirstName { get; init; }
        public String? LastName { get; init; }
        
        [Required]
        public String UserName { get; init; }
        
        [Required]
        public String Email { get; init; }
        
        [Required]
        public String Password { get; init; }
    }
}
