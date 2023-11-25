using SAWL;

namespace TestProject
{
    internal class CheckSawl
    {
        private Sawl sawl = new Sawl();
        private SLogger slog = new SLogger();

        public void funtest()
        {
            slog.Createlogger(filename: "wix");
            sawl.Information("Welcome {0}", 1);
            sawl.Debug("Why No Debuging");
        }
    }
}