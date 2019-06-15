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
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }
        #region Vars
        private Point mousePoint;
        #endregion

        #region void
        private void button1_Click(object sender, EventArgs e)
        {
            bools b = new bools();
            b.GSamIServer = true;
            b.GSigOn = true;

            GameInformation gi = new GameInformation();
            if(radioButton1.Checked == true)
            {
                gi.GSChampion = 1;
            }
            else if(radioButton2.Checked == true)
            {
                gi.GSChampion = 2;
            }
            else if (radioButton3.Checked == true)
            {
                gi.GSChampion = 3;
            }
            else if (radioButton4.Checked == true)
            {
                gi.GSChampion = 4;
            }
            else if (radioButton5.Checked == true)
            {
                gi.GSChampion = 5;
            }
            else if (radioButton6.Checked == true)
            {
                gi.GSChampion = 6;
            }

            InGame dlg = new InGame();
            dlg.Show();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bools b = new bools();
            b.GSamIServer = true;
            b.GSigOn = true;

            GameInformation gi = new GameInformation();
            if (radioButton1.Checked == true)
            {
                gi.GSChampion = 1;
            }
            else if (radioButton2.Checked == true)
            {
                gi.GSChampion = 2;
            }
            else if (radioButton3.Checked == true)
            {
                gi.GSChampion = 3;
            }
            else if (radioButton4.Checked == true)
            {
                gi.GSChampion = 4;
            }
            else if (radioButton5.Checked == true)
            {
                gi.GSChampion = 5;
            }
            else if (radioButton6.Checked == true)
            {
                gi.GSChampion = 6;
            }

            bools b = new bools();
            b.GSamIServer = false;
            b.GSigOn = true;

            InGame dlg = new InGame();
            dlg.Show();
            this.Close();
        }


        //창 끌고 이동
        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        //X 버튼
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        
    }
}
