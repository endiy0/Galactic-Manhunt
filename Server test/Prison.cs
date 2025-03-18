using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{

    // 잡히 도둑들 가두어놓는 감옥 클래스

    
    public class Prison
    {
        public int max_Count;
        public int count_robber = 0;
        public Galaxy galaxy;

        public Prison(Galaxy galaxy)
        {
            this.galaxy = galaxy;
            max_Count = Server.robbers.Count();
        }

        public void Add_Robber()
        {
            count_robber++;
        }

        public bool Is_Finish()
        {
            if(count_robber == max_Count) return true;
            return false;
        }
        public void Minus_Robber()
        {
            count_robber--;
        }

    }
}
