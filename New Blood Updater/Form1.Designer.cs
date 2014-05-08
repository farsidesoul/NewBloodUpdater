using System.Drawing;
namespace New_Blood_Updater
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.downloadButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.tb_patchLocation = new System.Windows.Forms.TextBox();
            this.tb_wowFolderLocation = new System.Windows.Forms.TextBox();
            this.tb_realmListLocation = new System.Windows.Forms.TextBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.downloadStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.Transparent;
            this.downloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downloadButton.BackgroundImage")));
            this.downloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.ForeColor = System.Drawing.Color.Transparent;
            this.downloadButton.Location = new System.Drawing.Point(144, 311);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(235, 50);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(588, 282);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.selectionLabel.Location = new System.Drawing.Point(335, 266);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(139, 13);
            this.selectionLabel.TabIndex = 3;
            this.selectionLabel.Text = "Select your WoW Directory:";
            // 
            // tb_patchLocation
            // 
            this.tb_patchLocation.Location = new System.Drawing.Point(12, 12);
            this.tb_patchLocation.Name = "tb_patchLocation";
            this.tb_patchLocation.ReadOnly = true;
            this.tb_patchLocation.Size = new System.Drawing.Size(259, 20);
            this.tb_patchLocation.TabIndex = 4;
            this.tb_patchLocation.Text = "http://www.dropbox.com/s/s3nni1lcpixm3m9/patch-4.mpq?dl=1";
            this.tb_patchLocation.Visible = false;
            // 
            // tb_wowFolderLocation
            // 
            this.tb_wowFolderLocation.BackColor = System.Drawing.Color.NavajoWhite;
            this.tb_wowFolderLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_wowFolderLocation.Location = new System.Drawing.Point(144, 282);
            this.tb_wowFolderLocation.Name = "tb_wowFolderLocation";
            this.tb_wowFolderLocation.Size = new System.Drawing.Size(438, 20);
            this.tb_wowFolderLocation.TabIndex = 5;
            // 
            // tb_realmListLocation
            // 
            this.tb_realmListLocation.Location = new System.Drawing.Point(545, 12);
            this.tb_realmListLocation.Name = "tb_realmListLocation";
            this.tb_realmListLocation.ReadOnly = true;
            this.tb_realmListLocation.Size = new System.Drawing.Size(259, 20);
            this.tb_realmListLocation.TabIndex = 7;
            this.tb_realmListLocation.Text = "http://www.dropbox.com/s/pgjzwwsa4h1jqf6/realmlist.wtf?dl=1";
            this.tb_realmListLocation.Visible = false;
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.Transparent;
            this.launchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("launchButton.BackgroundImage")));
            this.launchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.launchButton.FlatAppearance.BorderSize = 0;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchButton.Location = new System.Drawing.Point(428, 311);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(235, 50);
            this.launchButton.TabIndex = 8;
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // downloadStatusLabel
            // 
            this.downloadStatusLabel.AutoSize = true;
            this.downloadStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.downloadStatusLabel.Location = new System.Drawing.Point(363, 376);
            this.downloadStatusLabel.Name = "downloadStatusLabel";
            this.downloadStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.downloadStatusLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 398);
            this.Controls.Add(this.downloadStatusLabel);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.tb_realmListLocation);
            this.Controls.Add(this.tb_wowFolderLocation);
            this.Controls.Add(this.tb_patchLocation);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.downloadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ghost of New Blood Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.TextBox tb_patchLocation;
        private System.Windows.Forms.TextBox tb_wowFolderLocation;
        private System.Windows.Forms.TextBox tb_realmListLocation;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Label downloadStatusLabel;
    }
}

