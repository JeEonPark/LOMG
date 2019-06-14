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
        int Gravity = 20;
        int Force = 0;

        private bool Player_Left = false;
        private bool Player_Right = false;
        bool Player_Jump = false;
        //sdsdsdsdsdsddsdsd

        //asdfasdf

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
        }

        #endregion
    }
}
