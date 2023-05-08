using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midas_Manager {
    public partial class WindowsSettings : Form {
        public WindowsSettings() {
            InitializeComponent();
        }

        private void btnCheckForWindowsUpdates_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:windowsupdate");
        }

        private void btnDisplay_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:display");
        }

        private void btnSound_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:sound");
        }

        private void btnNotifications_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:notifications");
        }

        private void btnPower_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:powersleep");
        }

        private void btnAccount_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:account");
        }

        private void btnDateTime_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:dateandtime");
        }

        private void btnLanguage_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:regionlanguage");
        }

        private void btnAccessibility_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:easeofaccess");
        }

        private void btnInstalledApps_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:appsfeatures");
        }

        private void btnInstalledAppsLegacy_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("appwiz.cpl");
        }

        private void btnBluetoothDevices_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:devices");
        }

        private void btnNetworkInternet_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:network-status");
        }

        private void btnPersonalisation_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:personalization");
        }

        private void btnprivacySecurity_Click(object sender, EventArgs e) {
            ProgramWideFunctions.CommandPrompt("start ms-settings:privacy");
        }
    }
}
