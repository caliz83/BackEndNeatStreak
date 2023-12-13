using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndNeatStreak.Models.DTO
{
    public class PasswordDTO
    {
        public string? Salt { get; set; }

        public string? Hash { get; set; }
    }
}