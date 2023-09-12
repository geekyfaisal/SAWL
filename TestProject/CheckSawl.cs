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
        private ISawl<CheckSawl> sawl = new Sawl<CheckSawl>();

        public void funtest()
        {
            sawl.Information("Welcome {0}", 1);
        }
    }
}
