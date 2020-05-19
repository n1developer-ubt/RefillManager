using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefillManager
{
    class SftpSetting
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string HostName { get; set; }
        public int Port { get; set; } = 0;
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public AuthenticationType AuthenticationType { get; set; }
        public string FacilityName { get; set; }
    }

    enum AuthenticationType
    {
        PrivateKey,
        Password,
        PublicKey
    }
}
