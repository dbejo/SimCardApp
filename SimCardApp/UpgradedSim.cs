using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    class UpgradedSim : SimpleSim
    {
        public int puk { get; set; }

        public new UpgradedSim AddSim(string fullName, string email)
        {
            Random rnd = new Random(System.DateTime.Now.Millisecond);
            UpgradedSim upgradedSim = new UpgradedSim();
            upgradedSim.phoneNumber = "(" + rnd.Next(10, 99) + ") " + rnd.Next(100, 999) + "-" + rnd.Next(1000, 9999);
            upgradedSim.fullName = fullName;
            upgradedSim.email = email;
            upgradedSim.isActivated = true;
            upgradedSim.pin = rnd.Next(1000, 9999);
            upgradedSim.puk = 1234;
            upgradedSim.type = 1;
            upgradedSim.balance = rnd.Next(10000);
            return upgradedSim;
        }
    }
}
