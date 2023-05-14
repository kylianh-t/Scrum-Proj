namespace RRRPG
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            picOpponent = new PictureBox();
            picPlayer = new PictureBox();
            btnDoIt = new Button();
            lblPlayer = new Label();
            lblOpponent = new Label();
            picWeaponSelectMagicWand = new PictureBox();
            lblWeaponSelectMagicWand = new Label();
            panWeaponSelect = new Panel();
            lblWeaponSelectLightSaber = new Label();
            picWeaponSelectLightSaber = new PictureBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            lblWeaponSelectBow = new Label();
            picWeaponSelectBow = new PictureBox();
            lblWeaponSelectNerfRev = new Label();
            picWeaponSelectNerfRev = new PictureBox();
            label3 = new Label();
            lblWeaponSelectWaterGun = new Label();
            lblWeaponSelectCorkGun = new Label();
            picWeaponSelectWaterGun = new PictureBox();
            picWeaponSelectCorkGun = new PictureBox();
            btnStart = new Button();
            lblOpponentSpeak = new Label();
            lblPlayerSpeak = new Label();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectLightSaber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).BeginInit();
            SuspendLayout();
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(525, 120);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(526, 348);
            picOpponent.TabIndex = 0;
            picOpponent.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(12, 86);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(489, 382);
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(156, 527);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(225, 70);
            btnDoIt.TabIndex = 2;
            btnDoIt.Text = "Try Your Luck!";
            btnDoIt.UseVisualStyleBackColor = true;
            btnDoIt.Click += btnDoIt_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(212, 48);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(85, 32);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Player";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(761, 50);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(129, 32);
            lblOpponent.TabIndex = 4;
            lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectMagicWand
            // 
            picWeaponSelectMagicWand.BackColor = Color.Black;
            picWeaponSelectMagicWand.BackgroundImage = Properties.Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand.Location = new Point(12, 10);
            picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            picWeaponSelectMagicWand.Size = new Size(89, 153);
            picWeaponSelectMagicWand.TabIndex = 5;
            picWeaponSelectMagicWand.TabStop = false;
            picWeaponSelectMagicWand.Click += picWeaponSelectMagicWand_Click;
            // 
            // lblWeaponSelectMagicWand
            // 
            lblWeaponSelectMagicWand.AutoSize = true;
            lblWeaponSelectMagicWand.BackColor = Color.Black;
            lblWeaponSelectMagicWand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectMagicWand.ForeColor = Color.White;
            lblWeaponSelectMagicWand.Location = new Point(31, 166);
            lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            lblWeaponSelectMagicWand.Size = new Size(57, 21);
            lblWeaponSelectMagicWand.TabIndex = 6;
            lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // panWeaponSelect
            // 
            panWeaponSelect.BackColor = Color.Black;
            panWeaponSelect.Controls.Add(lblWeaponSelectLightSaber);
            panWeaponSelect.Controls.Add(picWeaponSelectLightSaber);
            panWeaponSelect.Controls.Add(label1);
            panWeaponSelect.Controls.Add(pictureBox);
            panWeaponSelect.Controls.Add(lblWeaponSelectBow);
            panWeaponSelect.Controls.Add(picWeaponSelectBow);
            panWeaponSelect.Controls.Add(lblWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(picWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(label3);
            panWeaponSelect.Controls.Add(lblWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(lblWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(picWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectMagicWand);
            panWeaponSelect.Controls.Add(lblWeaponSelectMagicWand);
            panWeaponSelect.Location = new Point(503, 468);
            panWeaponSelect.Name = "panWeaponSelect";
            panWeaponSelect.Size = new Size(566, 229);
            panWeaponSelect.TabIndex = 7;
            // 
            // lblWeaponSelectLightSaber
            // 
            lblWeaponSelectLightSaber.AutoSize = true;
            lblWeaponSelectLightSaber.BackColor = Color.Black;
            lblWeaponSelectLightSaber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectLightSaber.ForeColor = Color.White;
            lblWeaponSelectLightSaber.Location = new Point(399, 166);
            lblWeaponSelectLightSaber.Name = "lblWeaponSelectLightSaber";
            lblWeaponSelectLightSaber.Size = new Size(92, 21);
            lblWeaponSelectLightSaber.TabIndex = 19;
            lblWeaponSelectLightSaber.Text = "LightSaber";
            // 
            // picWeaponSelectLightSaber
            // 
            picWeaponSelectLightSaber.BackColor = Color.Black;
            picWeaponSelectLightSaber.BackgroundImage = (Image)resources.GetObject("picWeaponSelectLightSaber.BackgroundImage");
            picWeaponSelectLightSaber.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectLightSaber.Location = new Point(415, 10);
            picWeaponSelectLightSaber.Name = "picWeaponSelectLightSaber";
            picWeaponSelectLightSaber.Size = new Size(61, 152);
            picWeaponSelectLightSaber.TabIndex = 18;
            picWeaponSelectLightSaber.TabStop = false;
            picWeaponSelectLightSaber.Click += picWeaponSelectLightSaber_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(487, 166);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 17;
            label1.Text = "Random";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Black;
            pictureBox.BackgroundImage = Properties.Resources.Img_Shadow_Idle;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Location = new Point(492, 11);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(61, 152);
            pictureBox.TabIndex = 16;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // lblWeaponSelectBow
            // 
            lblWeaponSelectBow.AutoSize = true;
            lblWeaponSelectBow.BackColor = Color.Black;
            lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow.ForeColor = Color.White;
            lblWeaponSelectBow.Location = new Point(361, 166);
            lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            lblWeaponSelectBow.Size = new Size(43, 21);
            lblWeaponSelectBow.TabIndex = 15;
            lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            picWeaponSelectBow.BackColor = Color.Black;
            picWeaponSelectBow.BackgroundImage = Properties.Resources.Img_Bow;
            picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow.Location = new Point(343, 11);
            picWeaponSelectBow.Name = "picWeaponSelectBow";
            picWeaponSelectBow.Size = new Size(61, 152);
            picWeaponSelectBow.TabIndex = 14;
            picWeaponSelectBow.TabStop = false;
            picWeaponSelectBow.Click += picWeaponSelectBow_Click;
            // 
            // lblWeaponSelectNerfRev
            // 
            lblWeaponSelectNerfRev.AutoSize = true;
            lblWeaponSelectNerfRev.BackColor = Color.Black;
            lblWeaponSelectNerfRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectNerfRev.ForeColor = Color.White;
            lblWeaponSelectNerfRev.Location = new Point(278, 166);
            lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            lblWeaponSelectNerfRev.Size = new Size(44, 21);
            lblWeaponSelectNerfRev.TabIndex = 13;
            lblWeaponSelectNerfRev.Text = "Nerf";
            // 
            // picWeaponSelectNerfRev
            // 
            picWeaponSelectNerfRev.BackColor = Color.Black;
            picWeaponSelectNerfRev.BackgroundImage = Properties.Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev.Location = new Point(268, 11);
            picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            picWeaponSelectNerfRev.Size = new Size(61, 152);
            picWeaponSelectNerfRev.TabIndex = 12;
            picWeaponSelectNerfRev.TabStop = false;
            picWeaponSelectNerfRev.Click += picWeaponSelectNerfRev_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(206, 195);
            label3.Name = "label3";
            label3.Size = new Size(158, 30);
            label3.TabIndex = 11;
            label3.Text = "Weapon Select";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeaponSelectWaterGun
            // 
            lblWeaponSelectWaterGun.AutoSize = true;
            lblWeaponSelectWaterGun.BackColor = Color.Black;
            lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun.ForeColor = Color.White;
            lblWeaponSelectWaterGun.Location = new Point(178, 165);
            lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            lblWeaponSelectWaterGun.Size = new Size(90, 21);
            lblWeaponSelectWaterGun.TabIndex = 10;
            lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun
            // 
            lblWeaponSelectCorkGun.AutoSize = true;
            lblWeaponSelectCorkGun.BackColor = Color.Black;
            lblWeaponSelectCorkGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectCorkGun.ForeColor = Color.White;
            lblWeaponSelectCorkGun.Location = new Point(99, 165);
            lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
            lblWeaponSelectCorkGun.Size = new Size(80, 21);
            lblWeaponSelectCorkGun.TabIndex = 9;
            lblWeaponSelectCorkGun.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            picWeaponSelectWaterGun.BackColor = Color.Black;
            picWeaponSelectWaterGun.BackgroundImage = Properties.Resources.Img_Water_Gun;
            picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun.Location = new Point(192, 10);
            picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            picWeaponSelectWaterGun.Size = new Size(61, 152);
            picWeaponSelectWaterGun.TabIndex = 8;
            picWeaponSelectWaterGun.TabStop = false;
            picWeaponSelectWaterGun.Click += picWeaponSelectWaterGun_Click;
            // 
            // picWeaponSelectCorkGun
            // 
            picWeaponSelectCorkGun.BackColor = Color.Black;
            picWeaponSelectCorkGun.BackgroundImage = Properties.Resources.Img_Cork_Gun;
            picWeaponSelectCorkGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectCorkGun.Location = new Point(111, 10);
            picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
            picWeaponSelectCorkGun.Size = new Size(61, 152);
            picWeaponSelectCorkGun.TabIndex = 7;
            picWeaponSelectCorkGun.TabStop = false;
            picWeaponSelectCorkGun.Click += picWeaponSelectCorkGun_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(208, 600);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(225, 70);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.AutoSize = true;
            lblOpponentSpeak.BackColor = Color.White;
            lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak.Location = new Point(583, 100);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(213, 32);
            lblOpponentSpeak.TabIndex = 9;
            lblOpponentSpeak.Text = "I will outlast you!";
            // 
            // lblPlayerSpeak
            // 
            lblPlayerSpeak.AutoSize = true;
            lblPlayerSpeak.BackColor = Color.White;
            lblPlayerSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerSpeak.Location = new Point(330, 158);
            lblPlayerSpeak.Name = "lblPlayerSpeak";
            lblPlayerSpeak.Size = new Size(288, 32);
            lblPlayerSpeak.TabIndex = 10;
            lblPlayerSpeak.Text = "Bite my shiny metal ass!";
            // 
            // tmrStateMachine
            // 
            tmrStateMachine.Interval = 40;
            tmrStateMachine.Tick += tmrDialog_Tick;
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            tmrPlayMusicAfterGameOver.Tick += tmrPlayMusicAfterGameOver_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1085, 781);
            Controls.Add(lblPlayerSpeak);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(btnStart);
            Controls.Add(panWeaponSelect);
            Controls.Add(lblOpponent);
            Controls.Add(lblPlayer);
            Controls.Add(btnDoIt);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "Russian Roulette RPG";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            panWeaponSelect.ResumeLayout(false);
            panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectLightSaber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picOpponent;
        private PictureBox picPlayer;
        private Button btnDoIt;
        private Label lblPlayer;
        private Label lblOpponent;
        private PictureBox picWeaponSelectMagicWand;
        private Label lblWeaponSelectMagicWand;
        private Panel panWeaponSelect;
        private Button btnStart;
        private Label lblOpponentSpeak;
        private Label lblPlayerSpeak;
        private System.Windows.Forms.Timer tmrStateMachine;
        private PictureBox picWeaponSelectCorkGun;
        private Label lblWeaponSelectWaterGun;
        private Label lblWeaponSelectCorkGun;
        private PictureBox picWeaponSelectWaterGun;
        private Label label3;
        private Label lblWeaponSelectBow;
        private PictureBox picWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private PictureBox picWeaponSelectNerfRev;
        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Label label1;
        private PictureBox pictureBox;
        private Label lblWeaponSelectLightSaber;
        private PictureBox picWeaponSelectLightSaber;
    }
}