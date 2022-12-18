using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public record LoginDto
    {
        [Required]
        public String? UserName { get; init; }
        
        [Required]
        public String? Password { get; init; }
    }
}
