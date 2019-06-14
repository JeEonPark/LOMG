namespace LOMG
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.RightCharacter = new System.Windows.Forms.PictureBox();
            this.timer_gravity = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftCharacter
            // 
            this.LeftCharacter.BackColor = System.Drawing.Color.Transparent;
            this.LeftCharacter.Image = ((System.Drawing.Image)(resources.GetObject("LeftCharacter.Image")));
            this.LeftCharacter.Location = new System.Drawing.Point(0, 261);
            this.LeftCharacter.Name = "LeftCharacter";
            this.LeftCharacter.Size = new System.Drawing.Size(70, 120);
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
            this.WorldFrame.Controls.Add(this.button1);
            this.WorldFrame.Controls.Add(this.buttonConnect);
            this.WorldFrame.Controls.Add(this.textBoxIP);
            this.WorldFrame.Controls.Add(this.labelServerIP);
            this.WorldFrame.Controls.Add(this.labelClient);
            this.WorldFrame.Controls.Add(this.RightCharacter);
            this.WorldFrame.Controls.Add(this.LeftCharacter);
            this.WorldFrame.Location = new System.Drawing.Point(-1, -1);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(1404, 381);
            this.WorldFrame.TabIndex = 4;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(797, 131);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "연결";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Visible = false;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(617, 133);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(174, 21);
            this.textBoxIP.TabIndex = 4;
            this.textBoxIP.Visible = false;
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Location = new System.Drawing.Point(547, 138);
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
            // RightCharacter
            // 
            this.RightCharacter.BackColor = System.Drawing.Color.Transparent;
            this.RightCharacter.Image = ((System.Drawing.Image)(resources.GetObject("RightCharacter.Image")));
            this.RightCharacter.Location = new System.Drawing.Point(1331, 261);
            this.RightCharacter.Name = "RightCharacter";
            this.RightCharacter.Size = new System.Drawing.Size(70, 120);
            this.RightCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RightCharacter.TabIndex = 1;
            this.RightCharacter.TabStop = false;
            // 
            // timer_gravity
            // 
            this.timer_gravity.Enabled = true;
            this.timer_gravity.Interval = 1;
            this.timer_gravity.Tick += new System.EventHandler(this.Timer_gravity_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "연결";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 480);
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
            ((System.ComponentModel.ISupportInitialize)(this.RightCharacter)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox LeftCharacter;
        private System.Windows.Forms.Timer timer_moveAndjump;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.Timer timer_gravity;
        private System.Windows.Forms.PictureBox RightCharacter;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Button button1;
    }
}

