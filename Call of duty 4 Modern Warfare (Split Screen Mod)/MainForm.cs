using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Call_of_duty_4_Modern_Warfare__Split_Screen_Mod_
{
    public partial class MainForm : Form
    {
        string GitHubLink = "https://github.com/MaxwellTav/Call-of-duty-4-Modern-Warfare-Split-Screen-Mod-";
        public MainForm()
        { InitializeComponent(); }

        private void MainForm_Load(object sender, EventArgs e)
        {
            titleText.Text = Text;

            FormShadow.SetShadowForm(this);
        }

        private void BannerAnim_Tick(object sender, EventArgs e)
        {
            if (BannerLabel.Location.X >= -3)
                BannerLabel.Location = new Point(-540, 7);
            else
                BannerLabel.Location = new Point(BannerLabel.Location.X + 1, BannerLabel.Location.Y);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = 
                MessageBox.Show("¿Está seguro que desea salir de la aplicación?...", 
                "¡Está saliendo de la aplicación!", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        { WindowState = FormWindowState.Minimized; }

        private void SinglePlayerButton_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Shortcuts\codhistory.lnk");
            Application.Exit();
        }

        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            Process.Start(Application.StartupPath + @"\Shortcuts\Xpadder.lnk");
            Process.Start(Application.StartupPath + @"\Shortcuts\CoD4 Multiplayer script.ahk");

            Thread.Sleep(3000);

            Process.Start(Application.StartupPath + @"\Shortcuts\cod1p.lnk");
            Process.Start(Application.StartupPath + @"\Shortcuts\cod2p.lnk");
            UseWaitCursor = false;

            Application.Exit();
        }

        private void BannerLabel_Click(object sender, EventArgs e)
        {
            Process.Start(GitHubLink);
        }

        private void NormalOnlineButton_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Shortcuts\cod1p.lnk");
            Application.Exit();
        }
    }
}
