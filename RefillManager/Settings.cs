using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefillManager
{
    class Settings
    {
        public string SMTPHost { get; set; } = "";
        public int Port { get; set; } = -1;
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Subject { get; set; } = "";
        public string FacilityName { get; set; } = "";
        public string To { get; set; } = "";
    }
}
