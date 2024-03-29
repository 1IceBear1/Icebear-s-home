using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace GameServer
{
    /// <summary>
    /// 服务器类，安置所有服务器逻辑
    /// </summary>
    class Server
    {
        public static int maxPlayer { get; set; }
        public static int port { get; set; }
        private static TcpListener tcpListener;
        public void start(int _maxPlayer,int _port)
        {
            maxPlayer=_maxPlayer;
            port=_port;
            tcpListener = new TcpListener(IPAddress.Any, port);

        }

    }
}
