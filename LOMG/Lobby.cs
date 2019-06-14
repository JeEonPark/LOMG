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

        #endregion

    }
}
