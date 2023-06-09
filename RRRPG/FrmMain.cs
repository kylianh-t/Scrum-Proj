using RRRPG.Properties;
using RRRPGLib;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;

namespace RRRPG
{
    public partial class FrmMain : Form
    {
        public int Myscore = 0;
        private SoundPlayer soundPlayer;
        int flag = 1;
        private WaveOutEvent waveOut;
        private WaveFileReader waveFileReader;
        private int state;
        private Character player;
        private Character opponent;
        private Weapon weapon;
        private int numofgames = 0;
        private List<string> rand_Names = new List<string> { "Neo", "Sakura", "Voldemort", "Stewie", "Your Mom", "My Mom", "Danny Phantom", "Harry Potter", "Sasuke", "Naruto", "Sephiroth", "Clark Kent", "Batman", "Joker", "JigglyPuff", "Timmy Turner", "SpongeBob", "Eren Yeager", "Henry", "Curious George", "Pikachu", "Jesus", "Ash", "Link", "Ganondorf", "Bayonetta", "Captain Falcon", "Mario", "Nes", "Cloud" };
        static Random rnd = new Random();
        private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap;

        public FrmMain()
        {
            InitializeComponent();
            FormManager.openForms.Add(this);
            volumeSlider.Hide();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            waveOut = new WaveOutEvent();
            waveFileReader = new WaveFileReader(Resources.Mus_Title_Bg_Music1);
            waveOut.Init(waveFileReader);
            waveOut.Play();
            waveOut.Volume = .75f;
            volumeSlider.Value = 75;
            btnDoIt.Visible = false;
            lblOpponentSpeak.Visible = false;
            lblPlayerSpeak.Visible = false;
            picWeaponSelectBow.Visible = false;
            picWeaponSelectCorkGun.Visible = false;
            picWeaponSelectWaterGun.Visible = false;
            picWeaponSelectNerfRev.Visible = false;
            //picWeaponSelectLightSaber.Visible = false;
            //lblWeaponSelectLightSaber.Visible = false;
            lblWeaponSelectBow.Visible = false;
            lblWeaponSelectCorkGun.Visible = false;
            lblWeaponSelectWaterGun.Visible = false;
            lblWeaponSelectNerfRev.Visible = false;
            weapon = Weapon.MakeWeapon(WeaponType.MAGIC_WAND);
            state = -1;
            weaponSelectMap = new() {
        {WeaponType.BOW, (picWeaponSelectBow, lblWeaponSelectBow) },
        {WeaponType.CORK_GUN, (picWeaponSelectCorkGun,lblWeaponSelectCorkGun) },
        {WeaponType.WATER_GUN, (picWeaponSelectWaterGun, lblWeaponSelectWaterGun) },
        {WeaponType.MAGIC_WAND, (picWeaponSelectMagicWand, lblWeaponSelectMagicWand) },
        {WeaponType.NERF_REVOLVER, (picWeaponSelectNerfRev, lblWeaponSelectNerfRev) },
        {WeaponType.SABER, (picWeaponSelectSaber, lblWeaponSelectSaber) },
      };
            SelectWeapon(WeaponType.MAGIC_WAND);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            player.Shutup();
            player.ShowIdle();
            opponent.ShowIdle();
            btnStart.Visible = false;
            opponent.SaySmack();
            tmrStateMachine.Interval = 3500;
            tmrStateMachine.Enabled = true;
            state = 0;
            lblOpponent.Text = rand_Names[rnd.Next(rand_Names.Count)];
            lblPlayer.Text = rand_Names[rnd.Next(rand_Names.Count)];
            numofgames++;
            panWeaponSelect.Visible = false;
            Shop.Visible = false;
        }

        private void tmrDialog_Tick(object sender, EventArgs e)
        {
            if (state == 0)
            {
                opponent.Shutup();
                player.SaySmack();
                state = 1;
            }
            else if (state == 1)
            {
                opponent.Shutup();
                player.Shutup();
                player.ShowReady();
                opponent.ShowNoWeapon();
                btnDoIt.Visible = true;
                tmrStateMachine.Enabled = false;
                state = 2;
            }
            else if (state == 3)
            {
                player.SayOw();
                state = 4;
                tmrStateMachine.Interval = 2500;
            }
            else if (state == 4)
            {
                player.SayBoned();
                btnStart.Visible = true;
                Shop.Visible = true;
                tmrPlayMusicAfterGameOver.Enabled = true;
                panWeaponSelect.Visible = true;
                state = -1;
                Unlock_Weapon();
                tmrStateMachine.Enabled = false;

            }
            else if (state == 5)
            {
                player.Shutup();
                opponent.ShowReady();
                state = 6;
            }
            else if (state == 6)
            {
                if (opponent.PullTrigger(weapon))
                {
                    state = 7;
                }
                else
                {
                    state = 1;
                }
            }
            else if (state == 7)
            {
                opponent.SayOw();
                state = 8;
                tmrStateMachine.Interval = 2500;
            }
            else if (state == 8)
            {

                opponent.SayBoned();
                btnStart.Visible = true;
                Shop.Visible = true;
                tmrPlayMusicAfterGameOver.Enabled = true;
                panWeaponSelect.Visible = true;
                state = -1;
                tmrStateMachine.Enabled = false;
                Unlock_Weapon();
                Myscore += 5;
                //when bender's apponent dies, he gets 5 points
                Score.Text = String.Format("{0}", Myscore);
            }
        }
        private void Unlock_Weapon()
        {
            if (numofgames > 0)
            {
                picWeaponSelectCorkGun.Visible = true;
                lblWeaponSelectCorkGun.Visible = true;
            }
            if (numofgames > 1)
            {
                picWeaponSelectWaterGun.Visible = true;
                lblWeaponSelectWaterGun.Visible = true;
            }
            if (numofgames > 2)
            {
                picWeaponSelectNerfRev.Visible = true;
                lblWeaponSelectNerfRev.Visible = true;
            }
            if (numofgames > 3)
            {
                picWeaponSelectBow.Visible = true;
                lblWeaponSelectBow.Visible = true;
            }

        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            Console.WriteLine(state);
            if (player.PullTrigger(weapon))
            {
                state = 3;
                tmrStateMachine.Interval = 2200;
                tmrStateMachine.Enabled = true;

            }
            else
            {
                state = 5;
                tmrStateMachine.Interval = 1500;
                tmrStateMachine.Enabled = true;
                Myscore += 1;

                //everytime bender doges a bullet he gets a point
                Score.Text = String.Format("{0}", Myscore);
            }
            btnDoIt.Visible = false;
        }
        //public int i = 0;
        private void SelectWeapon(WeaponType type)
        {
            Color selectedColor = Color.Yellow;
            foreach (var weaponSel in weaponSelectMap)
            {
                weaponSel.Value.pic.BackColor = Color.Gray;
                weaponSel.Value.pic.BorderStyle = BorderStyle.None;
                weaponSel.Value.lbl.ForeColor = Color.White;
            }
            weaponSelectMap[type].pic.BackColor = selectedColor;
            weaponSelectMap[type].pic.BorderStyle = BorderStyle.Fixed3D;
            weaponSelectMap[type].lbl.ForeColor = selectedColor;
            weapon = Weapon.MakeWeapon(type);
            opponent = Character.MakeOpponent(type, picOpponent, lblOpponentSpeak);

            //iniitializes the player one time and keeps the same instance for each vs
            //if (i == 0)
            //{
            player = Character.MakePlayer(type, picPlayer, lblPlayerSpeak);
            //   i += 1;
            //}
        }

        private void picWeaponSelectMagicWand_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.MAGIC_WAND);
        }

        private void picWeaponSelectCorkGun_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.CORK_GUN);
        }

        private void picWeaponSelectWaterGun_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.WATER_GUN);
        }

        private void picWeaponSelectNerfRev_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.NERF_REVOLVER);
        }

        private void picWeaponSelectBow_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.BOW);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.SABER);
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }

        private void tmrPlayMusicAfterGameOver_Tick(object sender, EventArgs e)
        {
            if (btnStart.Visible)
            {

            }
            tmrPlayMusicAfterGameOver.Enabled = false;
        }

        //opens the shop
        private void button1_Click(object sender, EventArgs e)
        {
            label16.Visible = true;
            btnStart.Visible = false;
            Shop.Visible = false;
            CloseShop.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            button6.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            GetStats(player);

        }

        private void CloseShop_Click(object sender, EventArgs e)
        {
            label16.Visible = false;
            btnStart.Visible = true;
            Shop.Visible = true;
            CloseShop.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }


        public void GetStats(Character character)
        {


            float L = character.Stats.Luck;
            float H = character.Stats.Health;
            float R = character.Stats.Reflex;

            label7.Text = string.Format("{0}%", Math.Floor(L * 100));
            label8.Text = string.Format("{0}%", H);
            label9.Text = string.Format("{0}%", Math.Floor(R * 100));

            int L2 = (int)Math.Floor(L * 100);
            int H2 = (int)Math.Floor(H);
            int R2 = (int)Math.Floor(R * 100);

            label13.Width = L2;
            label14.Width = H2;
            label15.Width = R2;

            label13.BringToFront();
            label14.BringToFront();
            label15.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //when the butten is clicked the change luck function is sent a value of .01 or 1%
            if (Myscore >= 5)
            {
                ChangeLuck(player, (float).01);
                GetStats(player);
                Myscore -= 5;
                Score.Text = String.Format("{0}", Myscore);
                label13.Width += 1;
            }
            else
            {
                MessageBox.Show("you do not have enough points for that(you need 5)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Myscore >= 5)
            {
                ChangeHealth(player, 1);
                GetStats(player);
                Myscore -= 5;
                Score.Text = String.Format("{0}", Myscore);
                label14.Width += 1;
            }
            else
            {
                MessageBox.Show("you do not have enough points for that(you need 5)");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Myscore >= 5)
            {
                ChangeReflex(player, (float).01);
                GetStats(player);
                Myscore -= 5;
                Score.Text = String.Format("{0}", Myscore);
                label15.Width += 1;
            }
            else
            {
                MessageBox.Show("you do not have enough points for that(you need 5)");
            }
        }

        public float y;
        //these functions below are used when the plus button are clicked to help update the stats
        public void ChangeLuck(Character character, float X)
        {
            //y += X;

            //adds the .01 luck value to the player object
            player.Stats.Luck += X;
        }
        public void ChangeHealth(Character character, int X)
        {

            //adds the .01 luck value to the player object
            player.Stats.Health += X;
        }
        public void ChangeReflex(Character character, float X)
        {

            //adds the .01 luck value to the player object
            player.Stats.Reflex += X;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == 1)
                volumeSlider.Hide();
            else
                volumeSlider.Show();
        }

        private void volumeSlider_Scroll(object sender, EventArgs e)
        {
            waveOut.Volume = (float)volumeSlider.Value / 100f;
        }
        private void pictureBoxRandom_Click(object sender, EventArgs e)
        {
            int randIndex;
            if (numofgames < 5)
            {
                randIndex = rnd.Next(numofgames + 1);
            }
            else
            {
                randIndex = rnd.Next(5);
            }
            switch (randIndex)
            {
                case 0:
                    SelectWeapon(WeaponType.MAGIC_WAND);
                    break;
                case 1:
                    SelectWeapon(WeaponType.CORK_GUN);
                    break;
                case 2:
                    SelectWeapon(WeaponType.WATER_GUN);
                    break;
                case 3:
                    SelectWeapon(WeaponType.NERF_REVOLVER);
                    break;
                case 4:
                    SelectWeapon(WeaponType.BOW);
                    break;
                default:
                    SelectWeapon(WeaponType.MAGIC_WAND);
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            waveOut.Stop();
            waveOut.Dispose();
            waveFileReader.Dispose();
            waveOut = new WaveOutEvent();
            waveFileReader = new WaveFileReader(Resources.Mus_Title_Bg_Music_3);
            waveOut.Init(waveFileReader);
            waveOut.Play();
        }


    }
}