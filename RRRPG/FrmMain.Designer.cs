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
            lblWeaponSelectSaber = new Label();
            picWeaponSelectSaber = new PictureBox();
            label6 = new Label();
            pictureBoxRandom = new PictureBox();
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
            label1 = new Label();
            Score = new Label();
            Shop = new Button();
            CloseShop = new Button();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            volumeSlider = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            pictureBoxRandom = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectSaber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRandom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volumeSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRandom).BeginInit();
            SuspendLayout();
            // 
            // picOpponent
            // 
            picOpponent.BackColor = Color.Transparent;
            picOpponent.BackgroundImageLayout = ImageLayout.None;
            picOpponent.Location = new Point(611, 159);
            picOpponent.Margin = new Padding(3, 4, 3, 4);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(601, 668);
            picOpponent.TabIndex = 0;
            picOpponent.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackColor = Color.Transparent;
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(14, 115);
            picPlayer.Margin = new Padding(3, 4, 3, 4);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(559, 713);
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(183, 927);
            btnDoIt.Margin = new Padding(3, 4, 3, 4);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(257, 93);
            btnDoIt.TabIndex = 2;
            btnDoIt.Text = "Try Your Luck!";
            btnDoIt.UseVisualStyleBackColor = true;
            btnDoIt.Click += btnDoIt_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.Transparent;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(242, 64);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(105, 41);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "Player";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.BackColor = Color.Transparent;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(870, 67);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(161, 41);
            lblOpponent.TabIndex = 4;
            lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectMagicWand
            // 
            picWeaponSelectMagicWand.BackColor = Color.Gray;
            picWeaponSelectMagicWand.BackgroundImage = Properties.Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand.Location = new Point(14, 13);
            picWeaponSelectMagicWand.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            picWeaponSelectMagicWand.Size = new Size(85, 153);
            picWeaponSelectMagicWand.TabIndex = 5;
            picWeaponSelectMagicWand.TabStop = false;
            picWeaponSelectMagicWand.Click += picWeaponSelectMagicWand_Click;
            // 
            // lblWeaponSelectMagicWand
            // 
            lblWeaponSelectMagicWand.AutoSize = true;
            lblWeaponSelectMagicWand.BackColor = Color.Transparent;
            lblWeaponSelectMagicWand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectMagicWand.ForeColor = Color.White;
            lblWeaponSelectMagicWand.Location = new Point(31, 166);
            lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            lblWeaponSelectMagicWand.Size = new Size(70, 28);
            lblWeaponSelectMagicWand.TabIndex = 6;
            lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // panWeaponSelect
            // 
            panWeaponSelect.BackColor = Color.Gray;
            panWeaponSelect.Controls.Add(lblWeaponSelectSaber);
            panWeaponSelect.Controls.Add(picWeaponSelectSaber);
            panWeaponSelect.Controls.Add(label6);
            panWeaponSelect.Controls.Add(pictureBoxRandom);
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
            panWeaponSelect.ForeColor = Color.Transparent;
            panWeaponSelect.Location = new Point(579, 848);
            panWeaponSelect.Margin = new Padding(3, 4, 3, 4);
            panWeaponSelect.Name = "panWeaponSelect";
            panWeaponSelect.Size = new Size(647, 305);
            panWeaponSelect.TabIndex = 7;
            // 
            // lblWeaponSelectSaber
            // 
            lblWeaponSelectSaber.AutoSize = true;
            lblWeaponSelectSaber.BackColor = Color.Transparent;
            lblWeaponSelectSaber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectSaber.ForeColor = Color.White;
            lblWeaponSelectSaber.Location = new Point(435, 165);
            lblWeaponSelectSaber.Name = "lblWeaponSelectSaber";
            lblWeaponSelectSaber.Size = new Size(53, 21);
            lblWeaponSelectSaber.TabIndex = 19;
            lblWeaponSelectSaber.Text = "Saber";
            // 
            // picWeaponSelectSaber
            // 
            picWeaponSelectSaber.BackColor = Color.Gray;
            picWeaponSelectSaber.BackgroundImage = Properties.Resources.Img_Saber1;
            picWeaponSelectSaber.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectSaber.Location = new Point(430, 10);
            picWeaponSelectSaber.Name = "picWeaponSelectSaber";
            picWeaponSelectSaber.Size = new Size(57, 152);
            picWeaponSelectSaber.TabIndex = 18;
            picWeaponSelectSaber.TabStop = false;
            picWeaponSelectSaber.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(507, 165);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 17;
            label6.Text = "Random";
            // 
            // pictureBoxRandom
            // 
            pictureBoxRandom.BackColor = Color.Gray;
            pictureBoxRandom.BackgroundImage = Properties.Resources.Img_Shadow_Idle;
            pictureBoxRandom.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRandom.Location = new Point(497, 10);
            pictureBoxRandom.Name = "pictureBoxRandom";
            pictureBoxRandom.Size = new Size(57, 152);
            pictureBoxRandom.TabIndex = 16;
            pictureBoxRandom.TabStop = false;
            pictureBoxRandom.Click += pictureBoxRandom_Click;
            // 
            // lblWeaponSelectBow
            // 
            lblWeaponSelectBow.AutoSize = true;
            lblWeaponSelectBow.BackColor = Color.Transparent;
            lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow.ForeColor = Color.White;
            lblWeaponSelectBow.Location = new Point(372, 166);
            lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            lblWeaponSelectBow.Size = new Size(53, 28);
            lblWeaponSelectBow.TabIndex = 15;
            lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            picWeaponSelectBow.BackColor = Color.Gray;
            picWeaponSelectBow.BackgroundImage = Properties.Resources.Img_Bow;
            picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow.Location = new Point(362, 11);
            picWeaponSelectBow.Name = "picWeaponSelectBow";
            picWeaponSelectBow.Size = new Size(57, 152);
            picWeaponSelectBow.TabIndex = 14;
            picWeaponSelectBow.TabStop = false;
            picWeaponSelectBow.Click += picWeaponSelectBow_Click;
            // 
            // lblWeaponSelectNerfRev
            // 
            lblWeaponSelectNerfRev.AutoSize = true;
            lblWeaponSelectNerfRev.BackColor = Color.Transparent;
            lblWeaponSelectNerfRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectNerfRev.ForeColor = Color.White;
            lblWeaponSelectNerfRev.Location = new Point(351, 166);
            lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            lblWeaponSelectNerfRev.Size = new Size(115, 21);
            lblWeaponSelectNerfRev.TabIndex = 13;
            lblWeaponSelectNerfRev.Text = "Nerf Gun";
            // 
            // picWeaponSelectNerfRev
            // 
            picWeaponSelectNerfRev.BackColor = Color.Gray;
            picWeaponSelectNerfRev.BackgroundImage = Properties.Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev.Location = new Point(285, 11);
            picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            picWeaponSelectNerfRev.Size = new Size(57, 152);
            picWeaponSelectNerfRev.TabIndex = 12;
            picWeaponSelectNerfRev.TabStop = false;
            picWeaponSelectNerfRev.Click += picWeaponSelectNerfRev_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(235, 260);
            label3.Name = "label3";
            label3.Size = new Size(207, 37);
            label3.TabIndex = 11;
            label3.Text = "Weapon Select";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeaponSelectWaterGun
            // 
            lblWeaponSelectWaterGun.AutoSize = true;
            lblWeaponSelectWaterGun.BackColor = Color.Transparent;
            lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun.ForeColor = Color.White;
            lblWeaponSelectWaterGun.Location = new Point(185, 165);
            lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            lblWeaponSelectWaterGun.Size = new Size(113, 28);
            lblWeaponSelectWaterGun.TabIndex = 10;
            lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun
            // 
            lblWeaponSelectCorkGun.AutoSize = true;
            lblWeaponSelectCorkGun.BackColor = Color.Transparent;
            lblWeaponSelectCorkGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectCorkGun.ForeColor = Color.White;
            lblWeaponSelectCorkGun.Location = new Point(105, 165);
            lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
            lblWeaponSelectCorkGun.Size = new Size(99, 28);
            lblWeaponSelectCorkGun.TabIndex = 9;
            lblWeaponSelectCorkGun.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            picWeaponSelectWaterGun.BackColor = Color.Gray;
            picWeaponSelectWaterGun.BackgroundImage = Properties.Resources.Img_Water_Gun;
            picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun.Location = new Point(200, 10);
            picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            picWeaponSelectWaterGun.Size = new Size(57, 152);
            picWeaponSelectWaterGun.TabIndex = 8;
            picWeaponSelectWaterGun.TabStop = false;
            picWeaponSelectWaterGun.Click += picWeaponSelectWaterGun_Click;
            // 
            // picWeaponSelectCorkGun
            // 
            picWeaponSelectCorkGun.BackColor = Color.Gray;
            picWeaponSelectCorkGun.BackgroundImage = Properties.Resources.Img_Cork_Gun;
            picWeaponSelectCorkGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectCorkGun.Location = new Point(116, 10);
            picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
            picWeaponSelectCorkGun.Size = new Size(57, 152);
            picWeaponSelectCorkGun.TabIndex = 7;
            picWeaponSelectCorkGun.TabStop = false;
            picWeaponSelectCorkGun.Click += picWeaponSelectCorkGun_Click;
            // 
            // btnStart
            // 
            btnStart.FlatAppearance.BorderColor = Color.DimGray;
            btnStart.FlatAppearance.BorderSize = 5;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(282, 951);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(257, 93);
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
            lblOpponentSpeak.Location = new Point(666, 133);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(263, 41);
            lblOpponentSpeak.TabIndex = 9;
            lblOpponentSpeak.Text = "I will outlast you!";
            // 
            // lblPlayerSpeak
            // 
            lblPlayerSpeak.AutoSize = true;
            lblPlayerSpeak.BackColor = Color.White;
            lblPlayerSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerSpeak.Location = new Point(377, 211);
            lblPlayerSpeak.Name = "lblPlayerSpeak";
            lblPlayerSpeak.Size = new Size(355, 41);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(103, 41);
            label1.TabIndex = 12;
            label1.Text = "Score:";
            label1.Click += label1_Click;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Score.ForeColor = Color.White;
            Score.Location = new Point(102, 12);
            Score.MinimumSize = new Size(114, 0);
            Score.Name = "Score";
            Score.Size = new Size(114, 41);
            Score.TabIndex = 13;
            Score.Text = "0";
            // 
            // Shop
            // 
            Shop.FlatAppearance.BorderColor = Color.DimGray;
            Shop.FlatAppearance.BorderSize = 5;
            Shop.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            Shop.FlatStyle = FlatStyle.Flat;
            Shop.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            Shop.ForeColor = Color.White;
            Shop.Location = new Point(54, 951);
            Shop.Margin = new Padding(3, 4, 3, 4);
            Shop.Name = "Shop";
            Shop.Size = new Size(222, 93);
            Shop.TabIndex = 14;
            Shop.Text = "SHOP";
            Shop.UseVisualStyleBackColor = true;
            Shop.Click += button1_Click;
            // 
            // CloseShop
            // 
            CloseShop.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            CloseShop.Location = new Point(178, 1077);
            CloseShop.Margin = new Padding(3, 4, 3, 4);
            CloseShop.Name = "CloseShop";
            CloseShop.Size = new Size(222, 93);
            CloseShop.TabIndex = 15;
            CloseShop.Text = "Close Shop";
            CloseShop.UseVisualStyleBackColor = true;
            CloseShop.Visible = false;
            CloseShop.Click += CloseShop_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(434, 927);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(33, 43);
            button2.TabIndex = 17;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(434, 976);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(33, 43);
            button4.TabIndex = 19;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(434, 1021);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(33, 43);
            button6.TabIndex = 21;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 695);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 22;
            label2.Text = "Luck";
            label2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 730);
            label4.Name = "label4";
            label4.Size = new Size(112, 41);
            label4.TabIndex = 23;
            label4.Text = "Health";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 766);
            label5.Name = "label5";
            label5.Size = new Size(107, 41);
            label5.TabIndex = 24;
            label5.Text = "Reflex";
            label5.Visible = false;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(121, 927);
            label7.MinimumSize = new Size(57, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 43);
            label7.TabIndex = 26;
            label7.Text = "Stats";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Visible = false;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(106, 730);
            label8.MinimumSize = new Size(50, 0);
            label8.Name = "label8";
            label8.Size = new Size(57, 43);
            label8.TabIndex = 27;
            label8.Text = "Stats";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Visible = false;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(121, 1024);
            label9.MinimumSize = new Size(57, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 43);
            label9.TabIndex = 28;
            label9.Text = "Stats";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DimGray;
            label10.Location = new Point(184, 927);
            label10.MinimumSize = new Size(229, 43);
            label10.Name = "label10";
            label10.Size = new Size(229, 43);
            label10.TabIndex = 29;
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DimGray;
            label11.Location = new Point(184, 1021);
            label11.MinimumSize = new Size(229, 43);
            label11.Name = "label11";
            label11.Size = new Size(229, 43);
            label11.TabIndex = 30;
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DimGray;
            label12.Location = new Point(184, 972);
            label12.MinimumSize = new Size(229, 43);
            label12.Name = "label12";
            label12.Size = new Size(229, 43);
            label12.TabIndex = 31;
            label12.Visible = false;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Location = new Point(184, 927);
            label13.MaximumSize = new Size(229, 43);
            label13.MinimumSize = new Size(0, 43);
            label13.Name = "label13";
            label13.Size = new Size(11, 43);
            label13.TabIndex = 32;
            label13.Visible = false;
            // 
            // label14
            // 
            label14.BackColor = Color.White;
            label14.Location = new Point(184, 973);
            label14.MaximumSize = new Size(229, 43);
            label14.MinimumSize = new Size(0, 43);
            label14.Name = "label14";
            label14.Size = new Size(11, 43);
            label14.TabIndex = 33;
            label14.Visible = false;
            // 
            // label15
            // 
            label15.BackColor = Color.White;
            label15.Location = new Point(184, 1023);
            label15.MaximumSize = new Size(229, 43);
            label15.MinimumSize = new Size(0, 43);
            label15.Name = "label15";
            label15.Size = new Size(11, 43);
            label15.TabIndex = 34;
            label15.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.EVLyO8VVAAIt1ru;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1241, 841);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 836);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(1241, 351);
            button1.TabIndex = 36;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(14, 848);
            button3.Name = "button3";
            button3.Size = new Size(72, 52);
            button3.TabIndex = 37;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // volumeSlider
            // 
            volumeSlider.Location = new Point(102, 847);
            volumeSlider.Maximum = 100;
            volumeSlider.Name = "volumeSlider";
            volumeSlider.Size = new Size(257, 56);
            volumeSlider.TabIndex = 38;
            volumeSlider.Value = 100;
            volumeSlider.Scroll += volumeSlider_Scroll;
            // 
            // timer1
            // 
            timer1.Interval = 110000;
            timer1.Tick += timer1_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(507, 165);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 17;
            label6.Text = "Random";
            // 
            // pictureBoxRandom
            // 
            pictureBoxRandom.BackColor = Color.Gray;
            pictureBoxRandom.BackgroundImage = Properties.Resources.Img_Shadow_Idle;
            pictureBoxRandom.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxRandom.Location = new Point(497, 10);
            pictureBoxRandom.Name = "pictureBoxRandom";
            pictureBoxRandom.Size = new Size(57, 152);
            pictureBoxRandom.TabIndex = 16;
            pictureBoxRandom.TabStop = false;
            pictureBoxRandom.Click += pictureBoxRandom_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1085, 845);
            Controls.Add(volumeSlider);
            Controls.Add(button3);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(lblPlayerSpeak);
            Controls.Add(picOpponent);
            Controls.Add(Shop);
            Controls.Add(btnStart);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(CloseShop);
            Controls.Add(Score);
            Controls.Add(label1);
            Controls.Add(panWeaponSelect);
            Controls.Add(lblOpponent);
            Controls.Add(lblPlayer);
            Controls.Add(btnDoIt);
            Controls.Add(picPlayer);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "Russian Roulette RPG";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            panWeaponSelect.ResumeLayout(false);
            panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectSaber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRandom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)volumeSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRandom).EndInit();
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
        private Label Score;
        private Button Shop;
        private Button CloseShop;
        private Button button2;
        private Button button4;
        private Button button6;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private TrackBar volumeSlider;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private PictureBox pictureBoxRandom;
        private Label lblWeaponSelectSaber;
        private PictureBox pictureBox2;
        private PictureBox picWeaponSelectSaber;
    }
}