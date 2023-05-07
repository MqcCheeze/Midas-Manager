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
    }
}
