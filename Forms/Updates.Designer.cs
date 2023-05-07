namespace Midas_Manager {
    partial class Updates {
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
            this.btnCheckForWindowsUpdates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckForWindowsUpdates
            // 
            this.btnCheckForWindowsUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.btnCheckForWindowsUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckForWindowsUpdates.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckForWindowsUpdates.ForeColor = System.Drawing.Color.White;
            this.btnCheckForWindowsUpdates.Location = new System.Drawing.Point(31, 25);
            this.btnCheckForWindowsUpdates.Name = "btnCheckForWindowsUpdates";
            this.btnCheckForWindowsUpdates.Size = new System.Drawing.Size(392, 92);
            this.btnCheckForWindowsUpdates.TabIndex = 0;
            this.btnCheckForWindowsUpdates.Text = "Check for windows updates";
            this.btnCheckForWindowsUpdates.UseVisualStyleBackColor = false;
            this.btnCheckForWindowsUpdates.Click += new System.EventHandler(this.btnCheckForWindowsUpdates_Click);
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 568);
            this.Controls.Add(this.btnCheckForWindowsUpdates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Updates";
            this.Text = "Updates";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCheckForWindowsUpdates;
    }
}