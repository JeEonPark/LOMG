﻿namespace LOMG
{
    partial class InGame
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGame));
            this.LeftCharacter = new System.Windows.Forms.PictureBox();
            this.timer_moveAndjump = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.right_Level = new System.Windows.Forms.Label();
            this.left_Level = new System.Windows.Forms.Label();
            this.rightHPBar = new System.Windows.Forms.ProgressBar();
            this.leftHPBar = new System.Windows.Forms.ProgressBar();
            this.Enemy_Q_A_Image = new System.Windows.Forms.PictureBox();
            this.Q_A_Image = new System.Windows.Forms.PictureBox();
            this.RightCharacter = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.leftPortop = new System.Windows.Forms.PictureBox();
            this.ClientConnectButton = new System.Windows.Forms.Label();
            this.ServerConnectButton = new System.Windows.Forms.Label();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.timer_gravity = new System.Windows.Forms.Timer(this.components);
            this.testtick = new System.Windows.Forms.Timer(this.components);
            this.timer_attack = new System.Windows.Forms.Timer(this.components);
            this.myExpBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.myLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_HP_Exp = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LeftCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_Q_A_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q_A_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPortop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftCharacter
            // 
            this.LeftCharacter.BackColor = System.Drawing.Color.Transparent;
            this.LeftCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LeftCharacter.Image = ((System.Drawing.Image)(resources.GetObject("LeftCharacter.Image")));
            this.LeftCharacter.Location = new System.Drawing.Point(100, 300);
            this.LeftCharacter.Name = "LeftCharacter";
            this.LeftCharacter.Size = new System.Drawing.Size(40, 80);
            this.LeftCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LeftCharacter.TabIndex = 0;
            this.LeftCharacter.TabStop = false;
            // 
            // timer_moveAndjump
            // 
            this.timer_moveAndjump.Enabled = true;
            this.timer_moveAndjump.Interval = 1;
            this.timer_moveAndjump.Tick += new System.EventHandler(this.timer_moveAndjump_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1404, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.SkyBlue;
            this.WorldFrame.Controls.Add(this.right_Level);
            this.WorldFrame.Controls.Add(this.left_Level);
            this.WorldFrame.Controls.Add(this.rightHPBar);
            this.WorldFrame.Controls.Add(this.leftHPBar);
            this.WorldFrame.Controls.Add(this.Enemy_Q_A_Image);
            this.WorldFrame.Controls.Add(this.Q_A_Image);
            this.WorldFrame.Controls.Add(this.RightCharacter);
            this.WorldFrame.Controls.Add(this.LeftCharacter);
            this.WorldFrame.Controls.Add(this.pictureBox5);
            this.WorldFrame.Controls.Add(this.pictureBox4);
            this.WorldFrame.Controls.Add(this.pictureBox3);
            this.WorldFrame.Controls.Add(this.leftPortop);
            this.WorldFrame.Controls.Add(this.ClientConnectButton);
            this.WorldFrame.Controls.Add(this.ServerConnectButton);
            this.WorldFrame.Controls.Add(this.labelServerIP);
            this.WorldFrame.Controls.Add(this.labelClient);
            this.WorldFrame.Location = new System.Drawing.Point(-1, -1);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(1404, 381);
            this.WorldFrame.TabIndex = 4;
            // 
            // right_Level
            // 
            this.right_Level.AutoSize = true;
            this.right_Level.Location = new System.Drawing.Point(1258, 276);
            this.right_Level.Name = "right_Level";
            this.right_Level.Size = new System.Drawing.Size(49, 12);
            this.right_Level.TabIndex = 15;
            this.right_Level.Text = "level : 1";
            // 
            // left_Level
            // 
            this.left_Level.AutoSize = true;
            this.left_Level.Location = new System.Drawing.Point(96, 275);
            this.left_Level.Name = "left_Level";
            this.left_Level.Size = new System.Drawing.Size(49, 12);
            this.left_Level.TabIndex = 14;
            this.left_Level.Text = "level : 1";
            // 
            // rightHPBar
            // 
            this.rightHPBar.Location = new System.Drawing.Point(1257, 290);
            this.rightHPBar.Name = "rightHPBar";
            this.rightHPBar.Size = new System.Drawing.Size(49, 10);
            this.rightHPBar.TabIndex = 13;
            // 
            // leftHPBar
            // 
            this.leftHPBar.Location = new System.Drawing.Point(95, 290);
            this.leftHPBar.Name = "leftHPBar";
            this.leftHPBar.Size = new System.Drawing.Size(49, 10);
            this.leftHPBar.TabIndex = 12;
            this.leftHPBar.Value = 100;
            // 
            // Enemy_Q_A_Image
            // 
            this.Enemy_Q_A_Image.Image = ((System.Drawing.Image)(resources.GetObject("Enemy_Q_A_Image.Image")));
            this.Enemy_Q_A_Image.Location = new System.Drawing.Point(90, 50);
            this.Enemy_Q_A_Image.Name = "Enemy_Q_A_Image";
            this.Enemy_Q_A_Image.Size = new System.Drawing.Size(10, 10);
            this.Enemy_Q_A_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Enemy_Q_A_Image.TabIndex = 11;
            this.Enemy_Q_A_Image.TabStop = false;
            this.Enemy_Q_A_Image.Visible = false;
            // 
            // Q_A_Image
            // 
            this.Q_A_Image.Image = ((System.Drawing.Image)(resources.GetObject("Q_A_Image.Image")));
            this.Q_A_Image.Location = new System.Drawing.Point(50, 50);
            this.Q_A_Image.Name = "Q_A_Image";
            this.Q_A_Image.Size = new System.Drawing.Size(10, 10);
            this.Q_A_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Q_A_Image.TabIndex = 10;
            this.Q_A_Image.TabStop = false;
            this.Q_A_Image.Visible = false;
            // 
            // RightCharacter
            // 
            this.RightCharacter.BackColor = System.Drawing.Color.Transparent;
            this.RightCharacter.Image = ((System.Drawing.Image)(resources.GetObject("RightCharacter.Image")));
            this.RightCharacter.Location = new System.Drawing.Point(1261, 300);
            this.RightCharacter.Name = "RightCharacter";
            this.RightCharacter.Size = new System.Drawing.Size(40, 80);
            this.RightCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RightCharacter.TabIndex = 1;
            this.RightCharacter.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1300, 214);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 170);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(990, 244);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 155);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // leftPortop
            // 
            this.leftPortop.BackColor = System.Drawing.Color.Transparent;
            this.leftPortop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftPortop.Image = ((System.Drawing.Image)(resources.GetObject("leftPortop.Image")));
            this.leftPortop.Location = new System.Drawing.Point(330, 244);
            this.leftPortop.Name = "leftPortop";
            this.leftPortop.Size = new System.Drawing.Size(80, 155);
            this.leftPortop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPortop.TabIndex = 6;
            this.leftPortop.TabStop = false;
            // 
            // ClientConnectButton
            // 
            this.ClientConnectButton.AutoSize = true;
            this.ClientConnectButton.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.ClientConnectButton.Location = new System.Drawing.Point(795, 85);
            this.ClientConnectButton.Name = "ClientConnectButton";
            this.ClientConnectButton.Size = new System.Drawing.Size(89, 19);
            this.ClientConnectButton.TabIndex = 5;
            this.ClientConnectButton.Text = "연결하기";
            this.ClientConnectButton.Visible = false;
            this.ClientConnectButton.Click += new System.EventHandler(this.ClientConnectButton_Click);
            // 
            // ServerConnectButton
            // 
            this.ServerConnectButton.AutoSize = true;
            this.ServerConnectButton.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.ServerConnectButton.Location = new System.Drawing.Point(795, 53);
            this.ServerConnectButton.Name = "ServerConnectButton";
            this.ServerConnectButton.Size = new System.Drawing.Size(89, 19);
            this.ServerConnectButton.TabIndex = 4;
            this.ServerConnectButton.Text = "연결하기";
            this.ServerConnectButton.Visible = false;
            this.ServerConnectButton.Click += new System.EventHandler(this.ServerConnectButton_Click);
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Location = new System.Drawing.Point(676, 91);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(69, 12);
            this.labelServerIP.TabIndex = 3;
            this.labelServerIP.Text = "서버 주소 : ";
            this.labelServerIP.Visible = false;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelClient.Location = new System.Drawing.Point(632, 56);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(147, 15);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "클라이언트 대기중...";
            this.labelClient.Visible = false;
            // 
            // timer_gravity
            // 
            this.timer_gravity.Enabled = true;
            this.timer_gravity.Interval = 1;
            this.timer_gravity.Tick += new System.EventHandler(this.Timer_gravity_Tick);
            // 
            // testtick
            // 
            this.testtick.Enabled = true;
            this.testtick.Interval = 1000;
            this.testtick.Tick += new System.EventHandler(this.Testtick_Tick);
            // 
            // timer_attack
            // 
            this.timer_attack.Enabled = true;
            this.timer_attack.Interval = 1;
            this.timer_attack.Tick += new System.EventHandler(this.Timer_attack_Tick);
            // 
            // myExpBar
            // 
            this.myExpBar.BackColor = System.Drawing.SystemColors.Control;
            this.myExpBar.Location = new System.Drawing.Point(122, 58);
            this.myExpBar.Maximum = 99;
            this.myExpBar.Name = "myExpBar";
            this.myExpBar.Size = new System.Drawing.Size(335, 23);
            this.myExpBar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.myLevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.myExpBar);
            this.panel1.Location = new System.Drawing.Point(461, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 100);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "레벨";
            // 
            // myLevel
            // 
            this.myLevel.AutoSize = true;
            this.myLevel.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Bold);
            this.myLevel.Location = new System.Drawing.Point(16, 20);
            this.myLevel.Name = "myLevel";
            this.myLevel.Size = new System.Drawing.Size(41, 40);
            this.myLevel.TabIndex = 7;
            this.myLevel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "경험치 :";
            // 
            // timer_HP_Exp
            // 
            this.timer_HP_Exp.Enabled = true;
            this.timer_HP_Exp.Interval = 1;
            this.timer_HP_Exp.Tick += new System.EventHandler(this.Timer_HP_Exp_Tick);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.WorldFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InGame";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InGame_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InGame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InGame_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.LeftCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.WorldFrame.ResumeLayout(false);
            this.WorldFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_Q_A_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q_A_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPortop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox LeftCharacter;
        private System.Windows.Forms.Timer timer_moveAndjump;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.Timer timer_gravity;
        private System.Windows.Forms.PictureBox RightCharacter;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Timer testtick;
        private System.Windows.Forms.Label ClientConnectButton;
        private System.Windows.Forms.Label ServerConnectButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox leftPortop;
        private System.Windows.Forms.Timer timer_attack;
        private System.Windows.Forms.PictureBox Q_A_Image;
        private System.Windows.Forms.PictureBox Enemy_Q_A_Image;
        private System.Windows.Forms.ProgressBar myExpBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label myLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar rightHPBar;
        private System.Windows.Forms.ProgressBar leftHPBar;
        private System.Windows.Forms.Label right_Level;
        private System.Windows.Forms.Label left_Level;
        private System.Windows.Forms.Timer timer_HP_Exp;
    }
}

