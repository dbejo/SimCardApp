using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    class SimpleSim
    {
        public string phoneNumber { get; set; }
        public string fullName { get; set; }
        public string  email { get; set; }
        public bool isActivated { get; set; }
        public int pin { get; set; }
        public int type { get; set; }
        public int balance { get; set; }

        public SimpleSim AddSim(string fullName, string email)
        {
            Random rnd = new Random(System.DateTime.Now.Millisecond);
            SimpleSim simpleSim = new SimpleSim();
            simpleSim.phoneNumber = "(" + rnd.Next(10,99) + ") " + rnd.Next(100,999) + "-" + rnd.Next(1000, 9999);
            simpleSim.fullName = fullName;
            simpleSim.email = email;
            simpleSim.isActivated = true;
            simpleSim.pin = rnd.Next(1000, 9999);
            simpleSim.type = 0;
            simpleSim.balance = rnd.Next(10000);
            return simpleSim;
        }
    }
}
