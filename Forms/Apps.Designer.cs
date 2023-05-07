namespace Midas_Manager {
    partial class Apps {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnChrome = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFirefox = new System.Windows.Forms.Button();
            this.btnBraveBrowser = new System.Windows.Forms.Button();
            this.btnTorBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChrome
            // 
            this.btnChrome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnChrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChrome.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChrome.ForeColor = System.Drawing.Color.White;
            this.btnChrome.Location = new System.Drawing.Point(30, 60);
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.Size = new System.Drawing.Size(210, 60);
            this.btnChrome.TabIndex = 2;
            this.btnChrome.Text = "Chrome";
            this.btnChrome.UseVisualStyleBackColor = false;
            this.btnChrome.Click += new System.EventHandler(this.btnChrome_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(99)))), ((int)(((byte)(114)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(955, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "If the app isn\'t installed, this will install it, otherwise it will update it and" +
    " open it";
            // 
            // btnFirefox
            // 
            this.btnFirefox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnFirefox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirefox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirefox.ForeColor = System.Drawing.Color.White;
            this.btnFirefox.Location = new System.Drawing.Point(30, 140);
            this.btnFirefox.Name = "btnFirefox";
            this.btnFirefox.Size = new System.Drawing.Size(210, 60);
            this.btnFirefox.TabIndex = 4;
            this.btnFirefox.Text = "Firefox";
            this.btnFirefox.UseVisualStyleBackColor = false;
            this.btnFirefox.Click += new System.EventHandler(this.btnFirefox_Click);
            // 
            // btnBraveBrowser
            // 
            this.btnBraveBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnBraveBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBraveBrowser.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBraveBrowser.ForeColor = System.Drawing.Color.White;
            this.btnBraveBrowser.Location = new System.Drawing.Point(30, 220);
            this.btnBraveBrowser.Name = "btnBraveBrowser";
            this.btnBraveBrowser.Size = new System.Drawing.Size(210, 60);
            this.btnBraveBrowser.TabIndex = 5;
            this.btnBraveBrowser.Text = "Brave Browser";
            this.btnBraveBrowser.UseVisualStyleBackColor = false;
            this.btnBraveBrowser.Click += new System.EventHandler(this.btnBraveBrowser_Click);
            // 
            // btnTorBrowser
            // 
            this.btnTorBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnTorBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorBrowser.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTorBrowser.ForeColor = System.Drawing.Color.White;
            this.btnTorBrowser.Location = new System.Drawing.Point(30, 300);
            this.btnTorBrowser.Name = "btnTorBrowser";
            this.btnTorBrowser.Size = new System.Drawing.Size(210, 60);
            this.btnTorBrowser.TabIndex = 6;
            this.btnTorBrowser.Text = "Tor Browser";
            this.btnTorBrowser.UseVisualStyleBackColor = false;
            this.btnTorBrowser.Click += new System.EventHandler(this.btnTorBrowser_Click);
            // 
            // Apps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 568);
            this.Controls.Add(this.btnTorBrowser);
            this.Controls.Add(this.btnBraveBrowser);
            this.Controls.Add(this.btnFirefox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnChrome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Apps";
            this.Text = "Apps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChrome;
        private Label lblTitle;
        private Button btnFirefox;
        private Button btnBraveBrowser;
        private Button btnTorBrowser;
    }
}