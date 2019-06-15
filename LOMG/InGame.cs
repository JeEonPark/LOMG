using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOMG
{
    public partial class InGame : Form
    {


        #region Vars
        PictureBox pb;
        PictureBox pb2;

        ProgressBar pr;
        ProgressBar pr2;

        Label ll;
        Label ll2;

        bools b;
        GameInformation gi;

        Bandit1 b1;

        dynamic c;


        private int Speed_Movement = 3;
        private int Gravity = 20;
        private int Force = 0;
        private int Speed_Jump = 3;
        private int Speed_Fall = 3;
        int current_player_X;
        int current_player_Y;
        int Q_Attack_Tick = 0;
        int W_Attack_Tick = 0;
        int E_Attack_Tick = 0;


        private bool Player_Left = false;
        private bool Player_Right = false;
        private bool Player_Jump = false;
        private bool Player_Jumping = false;
        private bool Player_InAir = false;
        bool GameStart = false;
        bool Player_WatchingLeft = false;
        bool Can_Q_Attack = true;
        bool Can_W_Attack = true;
        bool Can_E_Attack = true;
        bool Q_Attack = false;
        bool W_Attack = false;
        bool E_Attack = false;
        bool Player_WatchingLeftwhenAttack_Q = true;
        bool Player_WatchingLeftwhenAttack_W = true;
        bool Player_WatchingLeftwhenAttack_E = true;







        #endregion

        public InGame()
        {
            InitializeComponent();

            b = new bools();
            gi = new GameInformation();

            if (b.GSamIServer) //내가 서버일경우
            {
                pb = LeftCharacter;
                pb2 = RightCharacter;
                pr = leftHPBar;
                pr2 = rightHPBar;
                ll = left_Level;
                ll2 = right_Level;
                labelClient.Visible = true;
                ServerConnectButton.Visible = true;
                Player_WatchingLeft = false;
                
            }
            else  //내가 클라이언트일 경우
            {
                pb2 = LeftCharacter;
                pb = RightCharacter;
                pr2 = leftHPBar;
                pr = rightHPBar;
                ll2 = left_Level;
                ll = right_Level;
                labelServerIP.Visible = true;
                ClientConnectButton.Visible = true;
                Player_WatchingLeft = true;
            }

            if(gi.GSChampion == 1)
            {
                //궁수1
            }
            else if(gi.GSChampion == 2)
            {
                //궁수 2
            }
            else if (gi.GSChampion == 3)
            {
                //마법사 1
            }
            else if (gi.GSChampion == 4)
            {
                //마법사 2
            }
            else if (gi.GSChampion == 5)
            {
                //도적 1
                b1 = new Bandit1();
                c = b1;
            }
            else if (gi.GSChampion == 6)
            {
                //도적 2
            }

        }

        #region GetSet
        public int GSSpeed_Movement
        {
            get { return Speed_Movement; }
            set { Speed_Movement = value; }
        }
        public bool GSPlayer_Left
        {
            get { return Player_Left; }
            set { Player_Left = value; }
        }
        public bool GSPlayer_Right
        {
            get { return Player_Right; }
            set { Player_Right = value; }
        }
        public int GSGravity
        {
            get { return Gravity; }
            set { Gravity = value; }
        }
        public int GSForce
        {
            get { return Force; }
            set { Force = value; }
        }
        public int GSSpeed_Jump
        {
            get { return Speed_Jump; }
            set { Speed_Jump = value; }
        }
        public int GSSpeed_Fail
        {
            get { return Speed_Fall; }
            set { Speed_Fall = value; }
        }
        public bool GSPlayer_Jump
        {
            get { return Player_Jump; }
            set { Player_Jump = value; }
        }
        public bool GSPlayer_Jumping
        {
            get { return Player_Jumping; }
            set { Player_Jumping = value; }
        }
        public bool GSPlayer_InAir
        {
            get { return Player_InAir; }
            set { Player_InAir = value; }
        }

        #endregion

        #region Keyboard
        private void InGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Player_Left = true;
                    Player_WatchingLeft = true;
                    break;
                case Keys.Right:
                    Player_Right = true;
                    Player_WatchingLeft = false;
                    break;
                case Keys.Space:
                    if (!Player_Jump && !Player_InAir)
                    {
                        pb.Top -= Speed_Jump;
                        Force = Gravity;
                        Player_Jump = true;
                    }
                    break;
                case Keys.Q:
                    if (Can_Q_Attack)
                    {
                        current_player_X = pb.Location.X;
                        current_player_Y = pb.Location.Y;

                        if (Player_WatchingLeft)
                        {
                            Q_A_Image.Left = current_player_X-10;
                            Q_A_Image.Top = current_player_Y + 40;
                            Q_Attack = true;
                            Can_Q_Attack = false;
                            Player_WatchingLeftwhenAttack_Q = true;
                            Q_A_Image.Visible = true;
                        }
                        else
                        {
                            Q_A_Image.Left = current_player_X+40;
                            Q_A_Image.Top = current_player_Y + 40;
                            Q_Attack = true;
                            Can_Q_Attack = false;
                            Player_WatchingLeftwhenAttack_Q = false;
                            Q_A_Image.Visible = true;
                        }

                    }
                    break;
                
            }
        }

        private void InGame_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Player_Left = false;
                    break;
                case Keys.Right:
                    Player_Right = false;
                    break;
                
            }
        }

       

        #endregion

        #region TimerTicks
        private void timer_moveAndjump_Tick(object sender, EventArgs e)
        {
            
            if (Player_Right && pb.Right <= WorldFrame.Width - 3)//이동
            {
                pb.Left += Speed_Movement;
            }
            if (Player_Left && pb.Location.X >= 3)
            {
                pb.Left -= Speed_Movement;
            }

            if (Force > 0)//중력
            {
                Force--;
                pb.Top -= Speed_Jump;
            }
            else
            {
                Player_Jump = false;
            }

            if (b.GSamIServer)//포탑이나 넥서스 근처일 시 속도 줄이기
            {
                if(LeftCharacter.Location.X > 895 && LeftCharacter.Location.X < 1205)
                {
                    Speed_Movement = 1;
                }
                else if (LeftCharacter.Location.X > 1205)
                {
                    Speed_Movement = 1;
                }
                else
                {
                    Speed_Movement = 3;
                }
                
            }
            else
            {
                if (RightCharacter.Location.X < 525 && LeftCharacter.Location.X > 215)
                {
                    Speed_Movement = 1;
                }
                else if (LeftCharacter.Location.X < 215)
                {
                    Speed_Movement = 1;
                }
                else
                {
                    Speed_Movement = 3;
                }
            }

            //progress bar 와 level 라벨 움직임
            Point p = new Point();
            p.X = pb.Location.X - 5;
            p.Y = pb.Location.Y - 10;
            pr.Location = p;

            p.X = pb.Location.X - 4;
            p.Y = pb.Location.Y - 25;
            ll.Location = p;

        }

        private void Timer_gravity_Tick(object sender, EventArgs e)
        {
            if (pb.Location.Y < 300)
            {
                Player_InAir = true;
            }
            else
            {
                Player_InAir = false;
            }

            if (!Player_Jump && pb.Location.Y < 300 && Player_InAir)
            {
                pb.Top += Speed_Fall;
            }

        }

        private void Testtick_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("tick");

        }
        private void Timer_attack_Tick(object sender, EventArgs e)
        {
            if (Q_Attack)
            {
                if (Player_WatchingLeftwhenAttack_Q)//Tick 20일경우 없앰
                {
                    Q_A_Image.Left -= 5;

                    Q_Attack_Tick++;

                    if(Q_Attack_Tick == 20)
                    {
                        Q_Attack = false;
                        Q_A_Image.Top = 50;
                        Q_A_Image.Left = 50;
                        Q_A_Image.Visible = false;
                        Can_Q_Attack = true;
                        Q_Attack_Tick = 0;
                    }
                }
                else
                {
                    Q_A_Image.Left += 5;

                    Q_Attack_Tick++;

                    if (Q_Attack_Tick == 20)
                    {
                        Q_Attack = false;
                        Q_A_Image.Top = 50;
                        Q_A_Image.Left = 50;
                        Q_A_Image.Visible = false;
                        Can_Q_Attack = true;
                        Q_Attack_Tick = 0;
                    }
                }
            }
        }

        private void Timer_HP_Exp_Tick(object sender, EventArgs e)
        {
            //내꺼
            c.CheckLevel();
            pr.Maximum = c.GSmaxHp;
            pr.Value = c.GShp;
            if (c.GSlevel == 1)
            {
                myExpBar.Minimum = 0;
                myExpBar.Maximum = 99;
            }
            else
            {
                myExpBar.Minimum = (myExpBar.Minimum) + (100 + (c.GSlevel - 2) * 20);
                myExpBar.Maximum = (myExpBar.Maximum + 1) + (100 + (c.GSlevel - 1) * 20) - 1;
            }
            myLevel.Text = c.GSlevel.ToString();
            myExpBar.Value = c.GSexp;
            
        }


        #endregion

        #region voids
        private void ServerConnectButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ServerStart);
            thread.Start();
            ServerConnectButton.Visible = false;

        }

        private void ClientConnectButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ClientStart);
            thread.Start();
            ClientConnectButton.Visible = false;


        }

        private Point mousePoint;
        private void InGame_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void InGame_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        #endregion

        Socket Server, Client;
        #region Server
        private void ServerStart() //내가 서버일경우
        {

            byte[] getByte = new byte[1024];
            byte[] setByte = new byte[1024];
            const int sPort = 23456;

            string stringbyte = null;
            IPAddress serverIP = IPAddress.Parse("25.53.5.184");
            Console.WriteLine("asdfasdf");
            IPEndPoint serverEndPoint = new IPEndPoint(serverIP, sPort);
            try
            {
                Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Server.Bind(serverEndPoint);
                Server.Listen(10);
                Client = Server.Accept();

                if (Client.Connected)
                {


                    labelClient.Invoke((MethodInvoker)delegate ()
                    {
                        labelClient.Visible = false;
                    });


                    while (true)
                    {
                        Client.Receive(getByte, 0, getByte.Length, SocketFlags.None);
                        stringbyte = Encoding.UTF7.GetString(getByte);
                        if (stringbyte != String.Empty)
                        {
                            int getValueLength = 0;
                            getValueLength = byteArrayDefrag(getByte);
                            stringbyte = Encoding.UTF7.GetString(getByte, 0, getValueLength + 1);
                            string[] result = stringbyte.Split(new char[] { '$' });
                            #region Receive Result

                            /*
                             * Thread 에서 Form 접근할 시
                             .Invoke((MethodInvoker)delegate ()
                            {
                                //할거
                            });
                            */


                            //상대 위치 이동하여 이동
                            Point lc = new Point();
                            lc.X = Convert.ToInt32(result[0]);
                            lc.Y = Convert.ToInt32(result[1]);
                            RightCharacter.Invoke((MethodInvoker)delegate ()
                            {
                                RightCharacter.Location = lc;
                            });

                            //상대 Q스킬 이미지 위치 및 Visible
                            bool v = Convert.ToBoolean(result[14]);
                            Enemy_Q_A_Image.Invoke((MethodInvoker)delegate ()
                            {
                                //할거
                                Enemy_Q_A_Image.Visible = v;
                            });
                            Point eqai = new Point();
                            eqai.X = Convert.ToInt32(result[12]);
                            eqai.Y = Convert.ToInt32(result[13]);
                            Enemy_Q_A_Image.Invoke((MethodInvoker)delegate ()
                            {
                                //할거
                                Enemy_Q_A_Image.Location = eqai;
                            });

                            //상대 체력 동기화
                            rightHPBar.Invoke((MethodInvoker)delegate ()
                             {
                                 //할거
                                 rightHPBar.Maximum = Convert.ToInt32(result[28]);
                                 rightHPBar.Value = Convert.ToInt32(result[4]);
                                 
                             });


                            #endregion

                            string sendData = LeftCharacter.Location.X + "$" + LeftCharacter.Location.Y + "$" + leftHPBar.Value + "$" + rightHPBar.Value + "$" +
                    "4" + "$" + "5" + "$" + "6" + "$" + "7" + "$" + "8" + "$" + "9" + "$" + "10" + "$" + "11" + "$" + Q_A_Image.Location.X
                     + "$" + Q_A_Image.Location.Y + "$" + Q_A_Image.Visible + "$" + "15" + "$" + "16" + "$" + "17" + "$" + "18" + "$" + "19" + "$"
                      + "$" + "20" + "$" + "21" + "$" + "22" + "$" + "23" + "$" + "24" + "$" + "25" + "$" + "26" + "$" + leftHPBar.Maximum + "$" +
                      rightHPBar.Maximum; ;
                            byte[] setsendData = Encoding.UTF7.GetBytes(sendData);
                            Client.Send(setsendData, 0, setsendData.Length, SocketFlags.None);
                        }
                        getByte = new byte[1024];
                        setByte = new byte[1024];

                    }
                    

                }

            }
            catch (System.Net.Sockets.SocketException socketEx)
            {
                Console.WriteLine("[Error]:{0}", socketEx.Message);
            }
            catch (System.Exception commonEx)
            {
                Console.WriteLine("[Error]:{0}", commonEx.Message);
            }
            finally
            {
                
            }
        }

        Socket socket;
        private void ClientStart()//내가 클라이언트일 경우
        {
            byte[] getByte = new byte[1024];
            byte[] setByte = new byte[1024];
            const int sPort = 23456;

            string sendstring = null;
            string getstring = null;

            IPAddress serverIP = IPAddress.Parse("25.53.5.184");
            IPEndPoint serverEndPoint = new IPEndPoint(serverIP, sPort);
            Console.WriteLine("asdfsad");
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            socket.Connect(serverEndPoint);
            if (socket.Connected)
            {
                Console.WriteLine("Connected");
                labelClient.Invoke((MethodInvoker)delegate ()
                {
                    labelClient.Visible = false;
                });


                
            }

            while (true)
            {
                sendstring = RightCharacter.Location.X + "$" + RightCharacter.Location.Y + "$" + leftHPBar.Value + "$" + rightHPBar.Value + "$" +
                    "4" + "$" + "5" + "$" + "6" + "$" + "7" + "$" + "8" + "$" + "9" + "$" + "10" + "$" + "11" + "$" + Q_A_Image.Location.X
                     + "$" + Q_A_Image.Location.Y + "$" + Q_A_Image.Visible + "$" + "15" + "$" + "16" + "$" + "17" + "$" + "18" + "$" + "19" + "$"
                      + "$" + "20" + "$" + "21" + "$" + "22" + "$" + "23" + "$" + "24" + "$" + "25" + "$" + "26" + "$" + leftHPBar.Maximum + "$" + 
                      rightHPBar.Maximum;
                if (sendstring != String.Empty)
                {
                    int getValueLength = 0;
                    setByte = Encoding.UTF7.GetBytes(sendstring);
                    socket.Send(setByte, 0, setByte.Length, SocketFlags.None);
                    socket.Receive(getByte, 0, getByte.Length, SocketFlags.None);
                    getValueLength = byteArrayDefrag(getByte);
                    getstring = Encoding.UTF7.GetString(getByte, 0, getValueLength + 1);
                    string[] result = getstring.Split(new char[] { '$' });

                    #region Receive Result

                    /*
                     * Thread 에서 Form 접근할 시
                     .Invoke((MethodInvoker)delegate ()
                    {
                        //할거
                    });
                    */


                    //상대 위치 이동하여 이동
                    Point lc = new Point();
                    lc.X = Convert.ToInt32(result[0]);
                    lc.Y = Convert.ToInt32(result[1]);
                    LeftCharacter.Invoke((MethodInvoker)delegate ()
                    {
                        LeftCharacter.Location = lc;
                    });

                    //상대 Q스킬 이미지 위치 및 Visible
                    bool v = Convert.ToBoolean(result[14]);
                    Enemy_Q_A_Image.Invoke((MethodInvoker)delegate ()
                     {
                         //할거
                         Enemy_Q_A_Image.Visible = v;
                     });
                    Point eqai = new Point();
                    eqai.X = Convert.ToInt32(result[12]);
                    eqai.Y = Convert.ToInt32(result[13]);
                    Enemy_Q_A_Image.Invoke((MethodInvoker)delegate ()
                     {
                         //할거
                         Enemy_Q_A_Image.Location = eqai;
                     });

                    //상대 체력 동기화
                    leftHPBar.Invoke((MethodInvoker)delegate ()
                    {
                        //할거
                        rightHPBar.Maximum = Convert.ToInt32(result[27]);
                        leftHPBar.Value = Convert.ToInt32(result[3]);
                    });

                    #endregion

                }
                getByte = new byte[1024];

                Thread.Sleep(10);

            }

            

        }


        public static int byteArrayDefrag(byte[] sData)
        {
            int endLength = 0;
            for (int i = 0; i < sData.Length; i++)
            {
                if ((byte)sData[i] != (byte)0)
                {
                    endLength = i;
                }
            }
            return endLength;
        }

        #endregion

    }
}
