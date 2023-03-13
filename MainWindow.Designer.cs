﻿
namespace Xbox_Achievement_Unlocker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.LBL_Attached = new System.Windows.Forms.Label();
            this.TXT_Xauth = new System.Windows.Forms.TextBox();
            this.BTN_GrabXauth = new System.Windows.Forms.Button();
            this.LBL_Gamertag = new System.Windows.Forms.Label();
            this.LBL_Gamerscore = new System.Windows.Forms.Label();
            this.Panel_Recents = new System.Windows.Forms.Panel();
            this.BTN_SpoofGame = new System.Windows.Forms.Button();
            this.TXT_Xuid = new System.Windows.Forms.TextBox();
            this.BTN_SaveToFile = new System.Windows.Forms.Button();
            this.LST_GameFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Skidbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // LBL_Attached
            // 
            this.LBL_Attached.AutoSize = true;
            this.LBL_Attached.ForeColor = System.Drawing.Color.Red;
            this.LBL_Attached.Location = new System.Drawing.Point(12, 9);
            this.LBL_Attached.Name = "LBL_Attached";
            this.LBL_Attached.Size = new System.Drawing.Size(145, 15);
            this.LBL_Attached.TabIndex = 0;
            this.LBL_Attached.Text = "Not attached to Xbox App";
            // 
            // TXT_Xauth
            // 
            this.TXT_Xauth.BackColor = System.Drawing.SystemColors.Control;
            this.TXT_Xauth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Xauth.Location = new System.Drawing.Point(12, 102);
            this.TXT_Xauth.Name = "TXT_Xauth";
            this.TXT_Xauth.Size = new System.Drawing.Size(158, 16);
            this.TXT_Xauth.TabIndex = 1;
            this.TXT_Xauth.Text = "xauth:";
            // 
            // BTN_GrabXauth
            // 
            this.BTN_GrabXauth.Enabled = false;
            this.BTN_GrabXauth.Location = new System.Drawing.Point(12, 124);
            this.BTN_GrabXauth.Name = "BTN_GrabXauth";
            this.BTN_GrabXauth.Size = new System.Drawing.Size(158, 46);
            this.BTN_GrabXauth.TabIndex = 2;
            this.BTN_GrabXauth.Text = "Grab All";
            this.BTN_GrabXauth.UseVisualStyleBackColor = true;
            this.BTN_GrabXauth.Click += new System.EventHandler(this.BTN_GrabXauth_Click);
            // 
            // LBL_Gamertag
            // 
            this.LBL_Gamertag.AutoSize = true;
            this.LBL_Gamertag.Location = new System.Drawing.Point(173, 121);
            this.LBL_Gamertag.Name = "LBL_Gamertag";
            this.LBL_Gamertag.Size = new System.Drawing.Size(65, 15);
            this.LBL_Gamertag.TabIndex = 6;
            this.LBL_Gamertag.Text = "Gamertag: ";
            // 
            // LBL_Gamerscore
            // 
            this.LBL_Gamerscore.AutoSize = true;
            this.LBL_Gamerscore.Location = new System.Drawing.Point(173, 136);
            this.LBL_Gamerscore.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LBL_Gamerscore.Name = "LBL_Gamerscore";
            this.LBL_Gamerscore.Size = new System.Drawing.Size(76, 15);
            this.LBL_Gamerscore.TabIndex = 7;
            this.LBL_Gamerscore.Text = "Gamerscore: ";
            // 
            // Panel_Recents
            // 
            this.Panel_Recents.AutoScroll = true;
            this.Panel_Recents.Location = new System.Drawing.Point(0, 176);
            this.Panel_Recents.Name = "Panel_Recents";
            this.Panel_Recents.Size = new System.Drawing.Size(797, 336);
            this.Panel_Recents.TabIndex = 8;
            // 
            // BTN_SpoofGame
            // 
            this.BTN_SpoofGame.Enabled = false;
            this.BTN_SpoofGame.Location = new System.Drawing.Point(631, 128);
            this.BTN_SpoofGame.Name = "BTN_SpoofGame";
            this.BTN_SpoofGame.Size = new System.Drawing.Size(158, 46);
            this.BTN_SpoofGame.TabIndex = 9;
            this.BTN_SpoofGame.Text = "Open Game Spoofer";
            this.BTN_SpoofGame.UseVisualStyleBackColor = true;
            this.BTN_SpoofGame.Click += new System.EventHandler(this.BTN_SpoofGame_Click);
            // 
            // TXT_Xuid
            // 
            this.TXT_Xuid.BackColor = System.Drawing.SystemColors.Control;
            this.TXT_Xuid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Xuid.Location = new System.Drawing.Point(176, 154);
            this.TXT_Xuid.Name = "TXT_Xuid";
            this.TXT_Xuid.Size = new System.Drawing.Size(158, 16);
            this.TXT_Xuid.TabIndex = 10;
            this.TXT_Xuid.Text = "XUID:";
            // 
            // BTN_SaveToFile
            // 
            this.BTN_SaveToFile.Enabled = false;
            this.BTN_SaveToFile.Location = new System.Drawing.Point(631, 76);
            this.BTN_SaveToFile.Name = "BTN_SaveToFile";
            this.BTN_SaveToFile.Size = new System.Drawing.Size(158, 46);
            this.BTN_SaveToFile.TabIndex = 11;
            this.BTN_SaveToFile.Text = "Save games list to file";
            this.BTN_SaveToFile.UseVisualStyleBackColor = true;
            this.BTN_SaveToFile.Click += new System.EventHandler(this.BTN_SaveToFile_Click);
            // 
            // LST_GameFilter
            // 
            this.LST_GameFilter.FormattingEnabled = true;
            this.LST_GameFilter.Items.AddRange(new object[] {
            "All",
            "Console Only",
            "New Gen",
            "Win32"});
            this.LST_GameFilter.Location = new System.Drawing.Point(504, 151);
            this.LST_GameFilter.Name = "LST_GameFilter";
            this.LST_GameFilter.Size = new System.Drawing.Size(121, 23);
            this.LST_GameFilter.TabIndex = 12;
            this.LST_GameFilter.SelectedIndexChanged += new System.EventHandler(this.LST_GameFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter Games List:";
            // 
            // Skidbox
            // 
            this.Skidbox.BackColor = System.Drawing.SystemColors.Control;
            this.Skidbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Skidbox.Location = new System.Drawing.Point(163, 6);
            this.Skidbox.Name = "Skidbox";
            this.Skidbox.ReadOnly = true;
            this.Skidbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Skidbox.Size = new System.Drawing.Size(625, 96);
            this.Skidbox.TabIndex = 14;
            this.Skidbox.Text = resources.GetString("Skidbox.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LST_GameFilter);
            this.Controls.Add(this.BTN_SaveToFile);
            this.Controls.Add(this.BTN_SpoofGame);
            this.Controls.Add(this.TXT_Xuid);
            this.Controls.Add(this.Panel_Recents);
            this.Controls.Add(this.LBL_Gamerscore);
            this.Controls.Add(this.LBL_Gamertag);
            this.Controls.Add(this.BTN_GrabXauth);
            this.Controls.Add(this.TXT_Xauth);
            this.Controls.Add(this.LBL_Attached);
            this.Controls.Add(this.Skidbox);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label LBL_Attached;
        private System.Windows.Forms.TextBox TXT_Xauth;
        private System.Windows.Forms.Button BTN_GrabXauth;
        private System.Windows.Forms.Label LBL_Gamertag;
        private System.Windows.Forms.Label LBL_Gamerscore;
        private System.Windows.Forms.Panel Panel_Recents;
        private System.Windows.Forms.Button BTN_SpoofGame;
        private System.Windows.Forms.TextBox TXT_Xuid;
        private System.Windows.Forms.Button BTN_SaveToFile;
        private System.Windows.Forms.ComboBox LST_GameFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Skidbox;
    }
}

