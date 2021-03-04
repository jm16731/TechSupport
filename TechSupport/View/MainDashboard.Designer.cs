
namespace TechSupport.View
{
    partial class MainDashboard
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
            this.tabCntrlIncidents = new System.Windows.Forms.TabControl();
            this.tabAddIncident = new System.Windows.Forms.TabPage();
            this.tabDisplayOpenIncidents = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabUpdateIncident = new System.Windows.Forms.TabPage();
            this.lblMainUsername = new System.Windows.Forms.Label();
            this.lnklblLogout = new System.Windows.Forms.LinkLabel();
            this.usrCntrlAddIncident = new TechSupport.UserControls.AddIncident();
            this.usrCntrlDisplayOpenIncidents = new TechSupport.UserControls.DisplayOpenIncidents();
            this.updateIncident1 = new TechSupport.UserControls.UpdateIncident();
            this.tabCntrlIncidents.SuspendLayout();
            this.tabAddIncident.SuspendLayout();
            this.tabDisplayOpenIncidents.SuspendLayout();
            this.tabUpdateIncident.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCntrlIncidents
            // 
            this.tabCntrlIncidents.Controls.Add(this.tabAddIncident);
            this.tabCntrlIncidents.Controls.Add(this.tabDisplayOpenIncidents);
            this.tabCntrlIncidents.Controls.Add(this.tabUpdateIncident);
            this.tabCntrlIncidents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabCntrlIncidents.Location = new System.Drawing.Point(0, 229);
            this.tabCntrlIncidents.Name = "tabCntrlIncidents";
            this.tabCntrlIncidents.SelectedIndex = 0;
            this.tabCntrlIncidents.Size = new System.Drawing.Size(1436, 725);
            this.tabCntrlIncidents.TabIndex = 1;
            this.tabCntrlIncidents.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabSelecting);
            // 
            // tabAddIncident
            // 
            this.tabAddIncident.Controls.Add(this.usrCntrlAddIncident);
            this.tabAddIncident.Location = new System.Drawing.Point(10, 48);
            this.tabAddIncident.Name = "tabAddIncident";
            this.tabAddIncident.Size = new System.Drawing.Size(1416, 667);
            this.tabAddIncident.TabIndex = 5;
            this.tabAddIncident.Text = "Add Incident";
            this.tabAddIncident.UseVisualStyleBackColor = true;
            // 
            // tabDisplayOpenIncidents
            // 
            this.tabDisplayOpenIncidents.Controls.Add(this.usrCntrlDisplayOpenIncidents);
            this.tabDisplayOpenIncidents.Controls.Add(this.listView1);
            this.tabDisplayOpenIncidents.Location = new System.Drawing.Point(10, 48);
            this.tabDisplayOpenIncidents.Name = "tabDisplayOpenIncidents";
            this.tabDisplayOpenIncidents.Size = new System.Drawing.Size(1416, 667);
            this.tabDisplayOpenIncidents.TabIndex = 3;
            this.tabDisplayOpenIncidents.Text = "Display Open Incidents";
            this.tabDisplayOpenIncidents.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-10, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1426, 664);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabUpdateIncident
            // 
            this.tabUpdateIncident.Controls.Add(this.updateIncident1);
            this.tabUpdateIncident.Location = new System.Drawing.Point(10, 48);
            this.tabUpdateIncident.Name = "tabUpdateIncident";
            this.tabUpdateIncident.Size = new System.Drawing.Size(1416, 667);
            this.tabUpdateIncident.TabIndex = 4;
            this.tabUpdateIncident.Text = "Update Incident";
            this.tabUpdateIncident.UseVisualStyleBackColor = true;
            // 
            // lblMainUsername
            // 
            this.lblMainUsername.AutoSize = true;
            this.lblMainUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainUsername.Location = new System.Drawing.Point(41, 39);
            this.lblMainUsername.Name = "lblMainUsername";
            this.lblMainUsername.Size = new System.Drawing.Size(196, 46);
            this.lblMainUsername.TabIndex = 2;
            this.lblMainUsername.Text = "username";
            this.lblMainUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnklblLogout
            // 
            this.lnklblLogout.AutoSize = true;
            this.lnklblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLogout.Location = new System.Drawing.Point(1200, 39);
            this.lnklblLogout.Name = "lnklblLogout";
            this.lnklblLogout.Size = new System.Drawing.Size(143, 46);
            this.lnklblLogout.TabIndex = 3;
            this.lnklblLogout.TabStop = true;
            this.lnklblLogout.Text = "Logout";
            this.lnklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblLogout_linkClicked);
            // 
            // usrCntrlAddIncident
            // 
            this.usrCntrlAddIncident.Location = new System.Drawing.Point(-2, 3);
            this.usrCntrlAddIncident.Name = "usrCntrlAddIncident";
            this.usrCntrlAddIncident.Size = new System.Drawing.Size(1416, 667);
            this.usrCntrlAddIncident.TabIndex = 0;
            // 
            // usrCntrlDisplayOpenIncidents
            // 
            this.usrCntrlDisplayOpenIncidents.Location = new System.Drawing.Point(0, 4);
            this.usrCntrlDisplayOpenIncidents.Name = "usrCntrlDisplayOpenIncidents";
            this.usrCntrlDisplayOpenIncidents.Size = new System.Drawing.Size(1423, 661);
            this.usrCntrlDisplayOpenIncidents.TabIndex = 1;
            // 
            // updateIncident1
            // 
            this.updateIncident1.Location = new System.Drawing.Point(-2, 3);
            this.updateIncident1.Name = "updateIncident1";
            this.updateIncident1.Size = new System.Drawing.Size(1416, 667);
            this.updateIncident1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1436, 954);
            this.Controls.Add(this.lnklblLogout);
            this.Controls.Add(this.lblMainUsername);
            this.Controls.Add(this.tabCntrlIncidents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close_All);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.tabCntrlIncidents.ResumeLayout(false);
            this.tabAddIncident.ResumeLayout(false);
            this.tabDisplayOpenIncidents.ResumeLayout(false);
            this.tabUpdateIncident.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrlIncidents;
        private System.Windows.Forms.Label lblMainUsername;
        private System.Windows.Forms.LinkLabel lnklblLogout;
        private System.Windows.Forms.TabPage tabDisplayOpenIncidents;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabUpdateIncident;
        private System.Windows.Forms.TabPage tabAddIncident;
        private UserControls.DisplayOpenIncidents usrCntrlDisplayOpenIncidents;
        private UserControls.AddIncident usrCntrlAddIncident;
        private UserControls.UpdateIncident updateIncident1;
    }
}