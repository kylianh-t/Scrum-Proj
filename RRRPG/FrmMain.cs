using RRRPG.Properties;
using RRRPGLib;
using System.Media;

namespace RRRPG
{
    public partial class FrmMain : Form
    {
        private SoundPlayer soundPlayer;
        private int state;
        private Character player;
        private Character opponent;
        private Weapon weapon;
        private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap;
        private List<string> rand_Names = new List<string> { "Neo", "Sakura", "Voldemort", "Stewie", "Your Mom", "My Mom", "Danny Phantom", "Harry Potter", "Sasuke", "Naruto", "Sephiroth", "Clark Kent", "Batman", "Joker", "JigglyPuff", "Timmy Turner", "SpongeBob", "Eren Yeager", "Henry", "Curious George", "Pikachu", "Jesus", "Ash", "Link", "Ganondorf", "Bayonetta", "Captain Falcon", "Mario", "Nes", "Cloud" };
        static Random rnd = new Random();
        private int numofgames = 0;

        public FrmMain()
        {
            InitializeComponent();
            FormManager.openForms.Add(this);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
            soundPlayer.PlayLooping();
            btnDoIt.Visible = false;
            lblOpponentSpeak.Visible = false;
            lblPlayerSpeak.Visible = false;
            picWeaponSelectBow.Visible = false;
            picWeaponSelectCorkGun.Visible = false;
            picWeaponSelectWaterGun.Visible = false;
            picWeaponSelectNerfRev.Visible = false;
            picWeaponSelectLightSaber.Visible = false;
            lblWeaponSelectLightSaber.Visible = false;
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
        {WeaponType.LIGHT_SABER, (picWeaponSelectLightSaber, lblWeaponSelectLightSaber) },
      };
            SelectWeapon(WeaponType.MAGIC_WAND);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            player.Shutup();
            player.ShowIdle();
            opponent.ShowIdle();
            btnStart.Visible = false;
            lblOpponent.Text = rand_Names[rnd.Next(rand_Names.Count)];
            lblPlayer.Text = rand_Names[rnd.Next(rand_Names.Count)];
            opponent.SaySmack();
            tmrStateMachine.Interval = 3500;
            tmrStateMachine.Enabled = true;
            state = 0;
            numofgames++;
            panWeaponSelect.Visible = false;
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
                tmrPlayMusicAfterGameOver.Enabled = true;
                panWeaponSelect.Visible = true;
                state = -1;
                tmrStateMachine.Enabled = false;
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
                if (numofgames > 4)
                {
                    picWeaponSelectLightSaber.Visible = true;
                    lblWeaponSelectLightSaber.Visible = true;
                }
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
                tmrPlayMusicAfterGameOver.Enabled = true;
                panWeaponSelect.Visible = true;
                state = -1;
                tmrStateMachine.Enabled = false;
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
                if (numofgames > 4)
                {
                    picWeaponSelectLightSaber.Visible = true;
                    lblWeaponSelectLightSaber.Visible = true;
                }
            }
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
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
            }
            btnDoIt.Visible = false;
        }

        private void SelectWeapon(WeaponType type)
        {
            Color selectedColor = Color.Yellow;
            foreach (var weaponSel in weaponSelectMap)
            {
                weaponSel.Value.pic.BackColor = Color.Black;
                weaponSel.Value.pic.BorderStyle = BorderStyle.None;
                weaponSel.Value.lbl.ForeColor = Color.White;
            }
            weaponSelectMap[type].pic.BackColor = selectedColor;
            weaponSelectMap[type].pic.BorderStyle = BorderStyle.Fixed3D;
            weaponSelectMap[type].lbl.ForeColor = selectedColor;
            weapon = Weapon.MakeWeapon(type);
            opponent = Character.MakeOpponent(type, picOpponent, lblOpponentSpeak);
            player = Character.MakePlayer(type, picPlayer, lblPlayerSpeak);
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

        private void picWeaponSelectLightSaber_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.LIGHT_SABER);
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
                soundPlayer.PlayLooping();
            }
            tmrPlayMusicAfterGameOver.Enabled = false;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            int randIndex;
            if (numofgames < 6)
            {
                randIndex = rnd.Next(numofgames + 1);
            }
            else
            {
                randIndex = rnd.Next(6);
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
                case 5:
                    SelectWeapon(WeaponType.LIGHT_SABER);
                    break;
                default:
                    SelectWeapon(WeaponType.MAGIC_WAND);
                    break;
            }
        }


    }
}