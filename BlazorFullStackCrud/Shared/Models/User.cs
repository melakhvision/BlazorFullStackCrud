using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackCrud.Shared.Models
{
    public class User
    {
        public int Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Cellnumber { get; set; } = null!;
        public string Emailid { get; set; } = null!;
    }
}
