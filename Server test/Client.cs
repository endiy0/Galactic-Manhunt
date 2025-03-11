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
        public Ship ship;
        public Inventory inventory;

        public Client(TcpClient client, int n)
        {
            this.client = client;
            nickname = "Client" + n.ToString();
            ship = new Ship(ship);
            inventory = new Inventory();
            // TODO: itemMax, abilityMax 받아오기
        }

        public Client(TcpClient client, string str)
        {
            this.client = client;
            nickname = str;
            ship = new Ship(ship);
            inventory = new Inventory();
        }

        public void Send(string type, string msg)
        {
            client.GetStream().Write(Encoding.UTF8.GetBytes(type + "⧫" + msg + "◊"));
        }
    }
}