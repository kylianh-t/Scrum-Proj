using RRRPG.Properties;
using RRRPGLib;
using System.Media;
using NAudio.Wave;

namespace RRRPG;

public partial class FrmTitle : Form
{
    int flag = 1;
    private WaveOutEvent waveOut;
    private WaveFileReader waveFileReader;
    public FrmTitle()
    {
        InitializeComponent();
        volumeSlider.Hide();
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        ResourcesRef.Resources = Resources.ResourceManager;
        Hide();
        waveOut.Stop();
        FrmMain frmMain = new FrmMain();
        frmMain.ShowDialog();
        FormManager.openForms.Add(frmMain);
    }

    private void FrmTitle_Load(object sender, EventArgs e)
    {
        waveOut = new WaveOutEvent();
        waveFileReader = new WaveFileReader(Resources.Mus_Title_Bg_Music_3);
        waveOut.Init(waveFileReader);
        waveOut.Play();
        waveOut.Volume = 1;
        FormManager.openForms.Add(this);
    }

    private void FrmTitle_FormClosed(object sender, FormClosedEventArgs e)
    {
        waveOut.Dispose();
        waveFileReader.Dispose();
        FormManager.openForms.Remove(this);
        FormManager.CloseAll();
    }

    private void button1_Click(object sender, EventArgs e)
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
