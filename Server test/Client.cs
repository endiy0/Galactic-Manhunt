using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 클라이언트 클래스
    class Client
    {
        public TcpClient client;
        public string nickname;

        public Client(TcpClient client, int n)
        {
            this.client = client;
            nickname = "Client" + n.ToString();
        }

        public Client(TcpClient client, string str)
        {
            this.client = client;
            nickname = str;
        }
    }
}
