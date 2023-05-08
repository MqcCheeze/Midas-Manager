using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midas_Manager {
    public partial class MainMenu : Form {

        Main main = new Main();
        WindowsSettings windowsSettings = new WindowsSettings();
        Storage storage = new Storage();
        Apps apps = new Apps();
        Settings settings = new Settings();

        Form previousForm;

        private readonly Color colourUnselected = Color.FromArgb(170, 192, 170);
        private readonly Color colourSelected = Color.FromArgb(201, 217, 190);

        public MainMenu() {
            InitializeComponent();

            pnlView.Controls.Remove(previousForm);
            Button buttonClicked = btnMainMenu;
            LoadMenu(main, buttonClicked);
        }

        private void MainMenu_Load(object sender, EventArgs e) {
            
        }

        private void LoadMenu(Form formToShow, Button buttonClicked) {
            previousForm = formToShow;

            UnselectAllButtons();

            buttonClicked.BackColor = colourSelected;
            formToShow.TopLevel = false;
            formToShow.AutoScroll = true;
            pnlView.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void UnselectAllButtons() {
            btnMainMenu.BackColor = colourUnselected;
            btnWindowsSettings.BackColor = colourUnselected;
            btnStorage.BackColor = colourUnselected;
            btnApps.BackColor = colourUnselected;
            btnSettings.BackColor = colourUnselected;
        }

        private void btnMainMenu_Click(object sender, EventArgs e) {
            pnlView.Controls.Remove(previousForm);
            Button buttonClicked = btnMainMenu;
            LoadMenu(main, buttonClicked);
        }

        private void btnWindowsSettings_Click(object sender, EventArgs e) {
            pnlView.Controls.Remove(previousForm);
            Button buttonClicked = btnWindowsSettings;
            LoadMenu(windowsSettings, buttonClicked);
        }

        private void btnStorage_Click(object sender, EventArgs e) {
            pnlView.Controls.Remove(previousForm);
            Button buttonClicked = btnStorage;
            LoadMenu(storage, buttonClicked);
        }

        private void btnApps_Click(object sender, EventArgs e) {
            pnlView.Controls.Remove(previousForm);
            Button buttonClicked = btnApps;
            LoadMenu(apps, buttonClicked);
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            pnlView.Controls.Remove(previousForm);
            Button buttonClicked = btnSettings;
            LoadMenu(settings, buttonClicked);
        }
    }
}
