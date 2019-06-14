using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOMG
{
    public partial class InGame : Form
    {
        public InGame()
        {
            InitializeComponent();

        }

        #region Vars
        private int Speed_Movement = 3;
        private int Gravity = 20;
        private int Force = 0;
        int Speed_Jump = 3;
        int Speed_Fall = 3;

        private bool Player_Left = false;
        private bool Player_Right = false;
        bool Player_Jump = false;
        bool Player_Jumping = false;
        bool Player_InAir = false;
        

        #endregion

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
                        pictureBox1.Top -= Speed_Jump;
                        Force = Gravity;
                        Player_Jump = true;
                    }
                    break;

            }
        }

        #endregion

        #region TimerTicks
        private void timer_moveAndjump_Tick(object sender, EventArgs e)
        {
            if (Player_Right && pictureBox1.Right <= WorldFrame.Width - 3)
            {
                pictureBox1.Left += Speed_Movement;
            }
            if (Player_Left && pictureBox1.Location.X >= 3)
            {
                pictureBox1.Left -= Speed_Movement;
            }
            label1.Text = pictureBox1.Left.ToString();


            if (Force > 0)
            {
                Force--;
                pictureBox1.Top -= Speed_Jump;
            }
            else
            {
                Player_Jump = false;
            }

        }

        private void Timer_gravity_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Location.Y < 261)
            {
                Player_InAir = true;
            }
            else
            {
                Player_InAir = false;
            }

            if (!Player_Jump && pictureBox1.Location.Y < 261 && Player_InAir)
            {
                pictureBox1.Top += Speed_Fall;
            }
            
        }

        #endregion


    }
}
