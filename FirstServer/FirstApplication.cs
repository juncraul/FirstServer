using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Photon.SocketServer;
using ExitGames.Logging;
using log4net;
using log4net.Config;
using ExitGames.Logging.Log4Net;
using LogManager = ExitGames.Logging.LogManager;

namespace FirstServer
{
    public class FirstApplication : ApplicationBase
    {
        private static ILogger Log { get; set; }
        protected override PeerBase CreatePeer(InitRequest initRequest)
        {
            Log.InfoFormat("Creating client Peer");
            return new FirstPeer(initRequest);
        }

        protected override void Setup()
        {
            LogManager.SetLoggerFactory(Log4NetLoggerFactory.Instance);
            Log = LogManager.GetCurrentClassLogger();
            GlobalContext.Properties["LogFileName"] = ApplicationName;
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Path.Combine(BinaryPath, "log4net.config")));

            Log.InfoFormat("Setting up first custom server!");
        }

        protected override void TearDown()
        {
            Log.InfoFormat("Called TearDown");
            //nothing to implement here
        }
    }
}
