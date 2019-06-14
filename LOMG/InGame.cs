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
        private int Speed_Movement = 3;
        private int Gravity = 20;
        private int Force = 0;
        private int Speed_Jump = 3;
        private int Speed_Fall = 3;

        private bool Player_Left = false;
        private bool Player_Right = false;
        private bool Player_Jump = false;
        private bool Player_Jumping = false;
        private bool Player_InAir = false;
        bool GameStart = false;

        PictureBox pb;
        PictureBox pb2;


        #endregion

        public InGame()
        {
            InitializeComponent();

            bools b = new bools();
            if (b.GSamIServer) //내가 서버일경우
            {
                pb = LeftCharacter;
                pb2 = RightCharacter;
                labelClient.Visible = true;
                
            }
            else  //내가 클라이언트일 경우
            {
                pb2 = LeftCharacter;
                pb = RightCharacter;
                labelServerIP.Visible = true;
                buttonConnect.Visible = true;
                textBoxIP.Visible = true;
                
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
                    break;
                case Keys.Right:
                    Player_Right = true;
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
                case Keys.Space:
                    if (!Player_Jump && !Player_InAir)
                    {
                        pb.Top -= Speed_Jump;
                        Force = Gravity;
                        Player_Jump = true;
                    }
                    break;

            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ClientStart);
            thread.Start();
        }

        #endregion

        #region TimerTicks
        private void timer_moveAndjump_Tick(object sender, EventArgs e)
        {
            if (Player_Right && pb.Right <= WorldFrame.Width - 3)
            {
                pb.Left += Speed_Movement;
            }
            if (Player_Left && pb.Location.X >= 3)
            {
                pb.Left -= Speed_Movement;
            }

            if (Force > 0)
            {
                Force--;
                pb.Top -= Speed_Jump;
            }
            else
            {
                Player_Jump = false;
            }

        }

        private void Timer_gravity_Tick(object sender, EventArgs e)
        {
            if (pb.Location.Y < 261)
            {
                Player_InAir = true;
            }
            else
            {
                Player_InAir = false;
            }

            if (!Player_Jump && pb.Location.Y < 261 && Player_InAir)
            {
                pb.Top += Speed_Fall;
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

                    new Thread(delegate ()
                    {
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
                                Point lc = new Point();
                                lc.X = Convert.ToInt32(result[0]);
                                lc.Y = Convert.ToInt32(result[1]);
                                RightCharacter.Invoke((MethodInvoker)delegate ()
                                {
                                    RightCharacter.Location = lc;
                                });

                                string sendData = LeftCharacter.Location.X + "$" + LeftCharacter.Location.Y;
                                byte[] setsendData = Encoding.UTF7.GetBytes(sendData);
                                Client.Send(setsendData, 0, setsendData.Length, SocketFlags.None);
                            }
                            getByte = new byte[1024];
                            setByte = new byte[1024];

                        }
                    }).Start();

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

            IPAddress serverIP = IPAddress.Parse(textBoxIP.Text);
            IPEndPoint serverEndPoint = new IPEndPoint(serverIP, sPort);
            Console.WriteLine("asdfsad");
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            socket.Connect(serverEndPoint);
            if (socket.Connected)
            {
                Console.WriteLine("Connected");
                
            }


                while (true)
                {
                    sendstring = RightCharacter.Location.X + "$" + RightCharacter.Location.Y;
                    if (sendstring != String.Empty)
                    {
                        int getValueLength = 0;
                        setByte = Encoding.UTF7.GetBytes(sendstring);
                        socket.Send(setByte, 0, setByte.Length, SocketFlags.None);
                        socket.Receive(getByte, 0, getByte.Length, SocketFlags.None);
                        getValueLength = byteArrayDefrag(getByte);
                        getstring = Encoding.UTF7.GetString(getByte, 0, getValueLength + 1);
                        string[] result = getstring.Split(new char[] { '$' });
                        Point lc = new Point();
                        lc.X = Convert.ToInt32(result[0]);
                        lc.Y = Convert.ToInt32(result[1]);
                        LeftCharacter.Location = lc;

                        }
                        getByte = new byte[1024];

                }

            

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

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ServerStart);
            thread.Start();
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
