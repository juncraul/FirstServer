using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photon.SocketServer;
using PhotonHostRuntimeInterfaces;

namespace FirstServer
{
    public class FirstPeer : ClientPeer
    {
        public FirstPeer(InitRequest initRequest) : base(initRequest)
        {

        }

        protected override void OnOperationRequest(OperationRequest operationRequest, SendParameters sendParameters)
        {
            //nothing to implement here
        }

        protected override void OnDisconnect(DisconnectReason reasonCode, string reasonDetail)
        {
            //nothing to implement here
        }
    }
}
