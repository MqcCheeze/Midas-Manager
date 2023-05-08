using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midas_Manager {
    public partial class Apps : Form {
        public Apps() {
            InitializeComponent();
        }

        private void btnChrome_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install google.chrome");

            ProgramWideFunctions.CommandPrompt("start chrome.exe");
        }

        private void btnFirefox_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install mozilla.firefox");

            ProgramWideFunctions.CommandPrompt("start firefox.exe");
        }

        private void btnBraveBrowser_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install brave.brave");

            ProgramWideFunctions.CommandPrompt("start brave.exe");
        }

        private void btnTorBrowser_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install torproject.torbrowser");

            ProgramWideFunctions.CommandPrompt("start torbrowser.exe");
        }

        private void btnSevenZip_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install 7zip.7zip");

            ProgramWideFunctions.CommandPrompt("start 7zip.exe");
        }

        private void btnWinrar_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install rarlab.winrar");

            ProgramWideFunctions.CommandPrompt("start winrar.exe");
        }

        private void btnFDM_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install softdeluxe.freedownloadmanager");

            ProgramWideFunctions.CommandPrompt("start fdm.exe");
        }

        private void btnUTorrent_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install utorrent");
        }

        private void btnAudacity_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install audacity.audacity");

            ProgramWideFunctions.CommandPrompt("start audacity.exe");
        }

        private void btnDiscord_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install discord.discord");
        }

        private void btnSlack_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install slacktechnologies.slack");

            ProgramWideFunctions.CommandPrompt("start slack.exe");
        }

        private void btnTeams_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install microsoft.teams");
        }

        private void btnWhatsapp_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("winget install 9NKSQGP7F2NH");

            ProgramWideFunctions.CommandPrompt("start whatsapp.exe");
        }
    }
}
