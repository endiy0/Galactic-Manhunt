using System.Net.Sockets;
using System.Text;

namespace Client_test
{
    public partial class ChatClient : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        int mynum;
        bool isConnected;
        string nickname;
        static string str;
        static bool isGameStarted;
        internal Job job;
        internal ShipType ship;
        internal Inventory storage;

        internal Dictionary<Job, string> jobDisplay = new Dictionary<Job, string> // enum Job에 따른 한글 표시
        {
            { Job.Robber, "도둑" },
            { Job.Cop, "경찰" }
        };

        internal Dictionary<ShipType, string> shipDisplay = new Dictionary<ShipType, string> // enum ShipType에 따른 한글 표시
        {
            { ShipType.newbie_ship, "초급자 전용 함선" },
            { ShipType.resource_ship, "자원 함선" },
            { ShipType.sailor_ship, "선원 함선" },
            { ShipType.galaxy_moving_ship, "초은하 이동 함선" },
            { ShipType.thief_ship, "도적 함선" }
        };

        public ChatClient()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            isConnected = false;
            isGameStarted = false;
            comboBox1.SelectedIndex = 0; // default = 전체

            storage = new Inventory(0, 0); // 아이템 최대량, 능력 최대량
        }

        public void GetShip()
        {
            Invoke(new Action(() => label4.Text = "직업: " + jobDisplay[job] + "\n" + "함선: " + shipDisplay[ship]));
        }

        private void button1_Click(object sender, EventArgs e) // 연결
        {
            try
            {
                if (int.TryParse(textBox3.Text, out int port))
                {
                    client = new TcpClient(textBox2.Text, port);
                    stream = client.GetStream();
                    receiveThread = new Thread(ReceiveMessages);
                    receiveThread.IsBackground = true;
                    receiveThread.Start();
                    listBox1.Items.Add("Connected to Server...");
                    isConnected = true;
                    button1.Enabled = false;  // 연결
                    button2.Enabled = true;   // 연결 해제
                    button3.Enabled = true;   // 전송
                    textBox1.Enabled = true;  // 닉네임
                    textBox4.Enabled = false; // 채팅창
                    comboBox1.Enabled = true; // 채팅 대상 설정
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[102400];
            string msg = "";

            while (true)
            {
                try
                {
                    buffer = new byte[102400];
                    if (msg != "")
                    {
                        buffer = Encoding.UTF8.GetBytes(msg);
                    }
                    while (true)
                    {
                        byte[] data = new byte[256];
                        int bytesRead = stream.Read(data, 0, data.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }

                        data = data.Where(x => x != 0).ToArray();

                        if (buffer.Length == 102400)
                        {
                            buffer = data;
                        }
                        else
                        {
                            buffer = buffer.Concat(data).ToArray();
                        }

                        msg = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                        if (msg.Contains('◊'))
                        {
                            break;
                        }
                    }
                    if (Encoding.UTF8.GetString(buffer, 0, buffer.Length).Split("◊").Length == 1)
                    {
                        msg = "";
                    }
                    else
                    {
                        msg = Encoding.UTF8.GetString(buffer, 0, buffer.Length).Split("◊")[1];
                    }
                    string[] message = Encoding.UTF8.GetString(buffer, 0, buffer.Length).Split("◊")[0].Split('⧫');

                    if (message[0] == "0") // 채팅
                    {
                        Invoke(new Action(() => listBox1.Items.Add(message[1])));
                    }
                    else if (message[0] == "1") // 연결 종료
                    {
                        client.Close();
                        if (message[1] != "")
                        {
                            MessageBox.Show(message[1]);
                        }

                        Invoke(new Action(() =>
                        {
                            listBox1.Items.Add("DisConnected from server...");
                            isConnected = false;
                            button1.Enabled = true;    // 연결
                            button2.Enabled = false;   // 연결 해제
                            button3.Enabled = false;   // 전송
                            textBox4.Enabled = true;   // 닉네임
                            textBox1.Enabled = false;  // 채팅창
                            comboBox1.Enabled = false; // 채팅 대상 설정
                            listBox2.Items.Clear();
                        }));

                        break;
                    }

                    else if (message[0] == "2") // 번호 지정
                    {
                        mynum = int.Parse(message[1]);
                        Invoke(new Action(() => str = textBox4.Text));
                        if (str == "")
                        {
                            nickname = "Client" + mynum.ToString();
                            Invoke(new Action(() => textBox4.Text = nickname));
                        }
                        else if (!str.Contains('⧫'))
                        {
                            nickname = str;
                        }
                        else
                        {
                            MessageBox.Show("이름에 다음 문자가 포함되어서는 안됩니다: ⧫\n기본 이름으로 진행합니다.");
                            nickname = "Client" + mynum.ToString();
                            Invoke(new Action(() => textBox4.Text = nickname));
                        }
                        stream.Write(Encoding.UTF8.GetBytes("3⧫" + nickname + '◊'));
                        stream.Flush();
                    }
                    else if (message[0] == "4") // 접속한 클라이언트 이름
                    {
                        Invoke(new Action(() => listBox2.Items.Add(message[1])));
                    }
                    else if (message[0] == "5") // 접속 종료한 클라이언트 이름
                    {
                        Invoke(new Action(() => listBox2.Items.Remove(message[1])));
                    }
                    else if (message[0] == "6") // 게임 시작
                    {
                        isGameStarted = true;
                        Invoke(new Action(() =>
                        {
                            ShipSelection shipSelection = new ShipSelection(this);
                            shipSelection.Show();
                        }));
                        button4.Enabled = true;
                        button5.Enabled = true;
                    }
                    else if (message[0] == "7") // 게임 종료
                    {
                        isGameStarted = false;
                    }
                    else if (message[0] == "8") // 역할 전송 받기
                    {
                        job = (Job)int.Parse(message[1]);
                        Invoke(new Action(() => label4.Text = "직업: " + jobDisplay[job] + "\n"));
                    }
                    Invoke(new Action(() => listBox1.TopIndex = listBox1.Items.Count - 1));
                }
                catch (Exception ex)
                {
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // 연결 해제
        {
            stream.Write(Encoding.UTF8.GetBytes("1⧫◊"));
            stream.Flush();
            stream.Close();
            client.Close();
            listBox1.Items.Add("DisConnected from Server...");
            isConnected = false;
            button1.Enabled = true;    // 연결
            button2.Enabled = false;   // 연결 해제
            button3.Enabled = false;   // 전송
            textBox4.Enabled = true;   // 닉네임
            textBox1.Enabled = false;  // 채팅창
            comboBox1.Enabled = false; // 채팅 대상 설정
            listBox2.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // 프로그램 종료
        {
            if (isConnected)
            {
                stream.Write(Encoding.UTF8.GetBytes("1⧫◊"));
                stream.Flush();
                stream.Close();
                client.Close();
                listBox1.Items.Add("DisConnected from server...");
                isConnected = false;
                button1.Enabled = true;  // 연결
                button2.Enabled = false; // 연결 해제
                button3.Enabled = false; // 전송
                textBox4.Enabled = true; // 닉네임
            }
        }

        private void button3_Click(object sender, EventArgs e) // 전송
        {
            if (!textBox1.Text.Contains('⧫') && !textBox1.Text.Contains('◊'))
            {
                if (textBox1.Text != "")
                {
                    stream.Write(Encoding.UTF8.GetBytes("0⧫" + $"{nickname}: " + textBox1.Text + '◊'));
                    stream.Flush();
                    listBox1.Items.Add($"{nickname}: " + textBox1.Text);
                    textBox1.Text = "";
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
                else
                {
                    MessageBox.Show("채팅은 공백이면 안됩니다.");
                }
            }
            else
            {
                MessageBox.Show("채팅에 다음 문자는 포함되면 안됩니다: ⧫, ◊");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isConnected) // 엔터 누르면 전송
            {
                button3.PerformClick(); // 전송 버튼
            }
        }

        private void button5_Click(object sender, EventArgs e) // 저장고 확인
        {
            Storage storage = new Storage(this);
            storage.Show();
        }

        private void button4_Click(object sender, EventArgs e) // 할 일 선택
        {
            // TODO: TaskSelection 본인 턴 확인 후 실행
            // TODO: TaskSelection 혹은 다른 Task창이 열러있는지 확인 후 아무것도 열려있지 않을 때만 열기

            //if (본인 턴)
            //{
            TaskSelection taskSelection = new TaskSelection(this, false);
            taskSelection.Show();
            //}
            //else
            //{
            //    TaskSelection taskSelection = new TaskSelection(this, true);
            //    taskSelection.Show();
            //}
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 누르면 연결
            {
                button1.PerformClick(); // 연결 버튼
            }
        }
    }

    // 직업 타입
    enum Job
    {
        Robber, // 도둑
        Cop     // 경찰
    }

    // TODO: 함선 클래스 완성되면 붙여넣기

    // 함선 타입
    enum ShipType
    {
        newbie_ship,        // 초급자 전용 함선
        resource_ship,      // 자원 함선
        sailor_ship,        // 선원 함선
        galaxy_moving_ship, // 초은하 이동 함선
        thief_ship          // 도적 함선
    }

    #region Ability
    // Ability 클래스
    class Ability
    {
        AbilityType type;
        public Ability(AbilityType ABILITYTYPE)
        {
            type = ABILITYTYPE;
        }
    }

    enum AbilityType
    {
        // 경찰
        dark_under_the_lamp,  // 등잔 밑이 어둡다
        galaxy_travel,        // 은하 탐방
        planet_travel,        // 행성 탐방
        stun,                 // 스턴
        handcuff,             // 수갑
        team_identify,        // 팀 식별

        // 도둑                  
        get_fuel,             // 겟 퓨얼
        fuel_changer,         // 연료 교환권
        fuel_compressor,      // 연료 압축기
        stun_remover,         // 스턴 제거기

        // 공통                  
        store_growth          // 저장량 증가
    }
    #endregion

    #region Item
    // 아이템 클래스
    class Item
    {
        Resource Itemtype;
        string Name;
        public double mass; // 질량, 단위: kg
        public static int ResourceCount = 10;
        public static int AirCount = 3;
        public static int CompountCount = 4;
        public static int MineralCount = 2;
        public static int OrganicMatterCount = 1;

        public Item(Resource ITEMTYPE, double MASS)
        {
            Itemtype = ITEMTYPE;
            mass = MASS;
            if (Itemtype == Resource.Hydrogen)
                Name = "수소";

            else if (Itemtype == Resource.Nitrogen)
                Name = "질소";

            else if (Itemtype == Resource.Oxygen)
                Name = "산소";

            else if (Itemtype == Resource.Peroxide)
                Name = "퍼옥사이드";

            else if (Itemtype == Resource.Hydrazine)
                Name = "하이드라진";

            else if (Itemtype == Resource.Epsilon)
                Name = "엑실론";

            else if (Itemtype == Resource.Food)
                Name = "식량";

            else if (Itemtype == Resource.Epsilon_crystal)
                Name = "엑실론 크리스탈";

            else if (Itemtype == Resource.Water)
                Name = "물";

            else if (Itemtype == Resource.Seed)
                Name = "씨앗";

            else if (Itemtype == Resource.Chrono)
                Name = "크로노";
        }

        public Resource GetItemType()
        {
            return Itemtype;
        }

        public string GetItemName()
        {
            return Name;
        }
    }

    // 자원 종류
    // 자원 추가할때마다 Item의 전역변수 Count 수정하기
    enum Resource
    {
        Hydrogen,         // 수소
        Nitrogen,         // 질소
        Oxygen,           // 산소
        Epsilon_crystal,  // 엑실론-크리스탈

        Peroxide,         // 퍼옥사이드
        Hydrazine,        // 하이드라진
        Epsilon,          // 엑실론

        Water,            // 물
        Food,             // 식량

        Seed,             // 씨앗

        Chrono            // 크로노
    }
    #endregion

    #region Inventory
    // 인벤토리 클래스
    class Inventory
    {
        List<Item> items;                    // 아이템 저장 함수
        Dictionary<Ability, int> abilities;  // 능력 저장 함수
        double itemMax;                      // 아이템 최댓값, 단위: kg
        int abilityMax;                      // 능력 최댓값, 단위: 개

        public Inventory(double itemmax, int abilitymax)
        {
            items = new List<Item>();
            abilities = new Dictionary<Ability, int>();
            itemMax = itemmax;
            abilityMax = abilitymax;
        }

        // 아이템 최대량 반환
        public double ItemMax
        {
            get { return itemMax; }
        }

        // 능력 최대량 반환
        public int AbilityMax
        {
            get { return abilityMax; }
        }

        // 아이템 리스트 반환
        public List<Item> Items
        {
            get { return items; }
        }

        // 능력 리스트 반환
        public Dictionary<Ability, int> Abilities
        {
            get { return abilities; }
        }

        // 아이템 최대량 설정
        public void SetItemMax(double itemMAX)
        {
            itemMax = itemMAX;
        }

        // 능력 최대량 설정
        public void SetAbilityMax(int abilityMAX)
        {
            abilityMax = abilityMAX;
        }

        // 아이템 추가
        public void AddItem(Item item)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.items[i].GetItemType() == item.GetItemType())
                {
                    this.items[i].mass += item.mass;
                    return;
                }
            }
            this.items.Add(item);
        }

        // 아이템 삭제
        public bool RemoveItem(Item item) // if문 사용해서 빠졌는지 안빠졌는지 꼭 체크해줘야함
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.items[i].GetItemType() == item.GetItemType())
                {
                    if (this.items[i].mass - item.mass >= 0)
                    {
                        this.items[i].mass -= item.mass;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        // 아이템 초기화(전체 삭제)
        public void Clear()
        {
            items.Clear();
        }

        // 두 인벤토리 더하기
        public static Inventory operator +(Inventory inv, Item item)
        {
            for (int i = 0; i < inv.Items.Count; i++)
            {
                if (inv.items[i].GetItemType() == item.GetItemType())
                {
                    inv.items[i].mass += item.mass;
                    return inv;
                }
            }
            inv.items.Add(item);
            return inv;
        }
    }
    #endregion
}