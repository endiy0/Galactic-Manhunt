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
        public Galaxy galaxy;
        public PlanetSystem planetSystem;
        public PlanetSystem advanced_planetsystem;          // 행성 탐방 스킬때문에 사용
        public PlayerType playerType;
        public bool is_moving = true;        // 행동 가능/불가능 판별 변수
        

        public Client(TcpClient client, int n)
        {
            this.client = client;
            nickname = "Client" + n.ToString();
            ship = new Ship(ship.shipType);
            inventory = new Inventory(140,100);
            
        }

        public Client(TcpClient client, string str)
        {
            this.client = client;
            nickname = str;
            ship = new Ship(ship.shipType);
            inventory = new Inventory(140,100);
        }


        // 겟 퓨얼 찬 반 함수

        // TODO 구현
        public bool Help_robber(Resource resource, double mass)
        {
            return true;
        }
        

        public void Send(string type, string msg)
        {
            client.GetStream().Write(Encoding.UTF8.GetBytes(type + "⧫" + msg + "◊"));
        }

             //  개인의 역할 정하기

        public void Type_Selection(PlayerType type)
        {
            playerType = (type == PlayerType.cop) ? PlayerType.cop : PlayerType.robber;
        }

        public enum PlayerType
        {
            robber,
            cop
        }
    }
}