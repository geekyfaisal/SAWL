using SAWL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class CheckSawl
    {
        private Sawl sawl = new Sawl();

        public void funtest()
        {
            sawl.Information("Welcome {0}", 1);
            sawl.Debug("Why No Debuging");
        }
    }
}
