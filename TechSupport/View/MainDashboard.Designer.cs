
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
            this.usrCntrlAddIncident = new TechSupport.UserControls.AddIncident();
            this.tabLoadAll = new System.Windows.Forms.TabPage();
            this.loadAll1 = new TechSupport.UserControls.LoadAll();
            this.tabSearchIncident = new System.Windows.Forms.TabPage();
            this.usrCntrlSearchIncident = new TechSupport.UserControls.SearchIncident();
            this.searchIncident1 = new TechSupport.UserControls.SearchIncident();
            this.lblMainUsername = new System.Windows.Forms.Label();
            this.lnklblLogout = new System.Windows.Forms.LinkLabel();
            this.usrCntrlLoadAll = new TechSupport.UserControls.LoadAll();
            this.tabDisplayOpenIncidents = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.displayOpenIncidents1 = new TechSupport.UserControls.DisplayOpenIncidents();
            this.tabCntrlIncidents.SuspendLayout();
            this.tabAddIncident.SuspendLayout();
            this.tabLoadAll.SuspendLayout();
            this.tabSearchIncident.SuspendLayout();
            this.tabDisplayOpenIncidents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCntrlIncidents
            // 
            this.tabCntrlIncidents.Controls.Add(this.tabAddIncident);
            this.tabCntrlIncidents.Controls.Add(this.tabLoadAll);
            this.tabCntrlIncidents.Controls.Add(this.tabSearchIncident);
            this.tabCntrlIncidents.Controls.Add(this.tabDisplayOpenIncidents);
            this.tabCntrlIncidents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabCntrlIncidents.Location = new System.Drawing.Point(0, 229);
            this.tabCntrlIncidents.Name = "tabCntrlIncidents";
            this.tabCntrlIncidents.SelectedIndex = 0;
            this.tabCntrlIncidents.Size = new System.Drawing.Size(1436, 725);
            this.tabCntrlIncidents.TabIndex = 1;
            this.tabCntrlIncidents.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabSelectedIndex);
            // 
            // tabAddIncident
            // 
            this.tabAddIncident.Controls.Add(this.usrCntrlAddIncident);
            this.tabAddIncident.Location = new System.Drawing.Point(10, 48);
            this.tabAddIncident.Name = "tabAddIncident";
            this.tabAddIncident.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddIncident.Size = new System.Drawing.Size(1416, 667);
            this.tabAddIncident.TabIndex = 0;
            this.tabAddIncident.Text = "Add Incident";
            this.tabAddIncident.UseVisualStyleBackColor = true;
            // 
            // usrCntrlAddIncident
            // 
            this.usrCntrlAddIncident.AutoScroll = true;
            this.usrCntrlAddIncident.AutoSize = true;
            this.usrCntrlAddIncident.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrCntrlAddIncident.Location = new System.Drawing.Point(-2, 0);
            this.usrCntrlAddIncident.Name = "usrCntrlAddIncident";
            this.usrCntrlAddIncident.Size = new System.Drawing.Size(1130, 633);
            this.usrCntrlAddIncident.TabIndex = 2;
            // 
            // tabLoadAll
            // 
            this.tabLoadAll.Controls.Add(this.loadAll1);
            this.tabLoadAll.Location = new System.Drawing.Point(10, 48);
            this.tabLoadAll.Name = "tabLoadAll";
            this.tabLoadAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadAll.Size = new System.Drawing.Size(1416, 667);
            this.tabLoadAll.TabIndex = 1;
            this.tabLoadAll.Text = "Load All";
            this.tabLoadAll.UseVisualStyleBackColor = true;
            // 
            // loadAll1
            // 
            this.loadAll1.Location = new System.Drawing.Point(0, 3);
            this.loadAll1.Name = "loadAll1";
            this.loadAll1.Size = new System.Drawing.Size(1416, 658);
            this.loadAll1.TabIndex = 0;
            // 
            // tabSearchIncident
            // 
            this.tabSearchIncident.Controls.Add(this.usrCntrlSearchIncident);
            this.tabSearchIncident.Controls.Add(this.searchIncident1);
            this.tabSearchIncident.Location = new System.Drawing.Point(10, 48);
            this.tabSearchIncident.Name = "tabSearchIncident";
            this.tabSearchIncident.Size = new System.Drawing.Size(1416, 667);
            this.tabSearchIncident.TabIndex = 2;
            this.tabSearchIncident.Text = "Search Incidents";
            this.tabSearchIncident.UseVisualStyleBackColor = true;
            // 
            // usrCntrlSearchIncident
            // 
            this.usrCntrlSearchIncident.Location = new System.Drawing.Point(-10, 3);
            this.usrCntrlSearchIncident.Name = "usrCntrlSearchIncident";
            this.usrCntrlSearchIncident.Size = new System.Drawing.Size(1423, 661);
            this.usrCntrlSearchIncident.TabIndex = 1;
            // 
            // searchIncident1
            // 
            this.searchIncident1.Location = new System.Drawing.Point(761, 171);
            this.searchIncident1.Name = "searchIncident1";
            this.searchIncident1.Size = new System.Drawing.Size(8, 8);
            this.searchIncident1.TabIndex = 0;
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
            this.lnklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogout_linkClicked);
            // 
            // usrCntrlLoadAll
            // 
            this.usrCntrlLoadAll.AutoSize = true;
            this.usrCntrlLoadAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usrCntrlLoadAll.Location = new System.Drawing.Point(0, 0);
            this.usrCntrlLoadAll.Name = "usrCntrlLoadAll";
            this.usrCntrlLoadAll.Size = new System.Drawing.Size(1395, 568);
            this.usrCntrlLoadAll.TabIndex = 0;
            // 
            // tabDisplayOpenIncidents
            // 
            this.tabDisplayOpenIncidents.Controls.Add(this.displayOpenIncidents1);
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
            // displayOpenIncidents1
            // 
            this.displayOpenIncidents1.Location = new System.Drawing.Point(-10, 3);
            this.displayOpenIncidents1.Name = "displayOpenIncidents1";
            this.displayOpenIncidents1.Size = new System.Drawing.Size(1436, 664);
            this.displayOpenIncidents1.TabIndex = 1;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.close_All);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.tabCntrlIncidents.ResumeLayout(false);
            this.tabAddIncident.ResumeLayout(false);
            this.tabAddIncident.PerformLayout();
            this.tabLoadAll.ResumeLayout(false);
            this.tabSearchIncident.ResumeLayout(false);
            this.tabDisplayOpenIncidents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrlIncidents;
        private System.Windows.Forms.TabPage tabAddIncident;
        private UserControls.AddIncident usrCntrlAddIncident;
        private System.Windows.Forms.TabPage tabLoadAll;
        private System.Windows.Forms.TabPage tabSearchIncident;
        private System.Windows.Forms.Label lblMainUsername;
        private System.Windows.Forms.LinkLabel lnklblLogout;
        private UserControls.LoadAll usrCntrlLoadAll;
        private UserControls.LoadAll loadAll1;
        private UserControls.SearchIncident usrCntrlSearchIncident;
        private UserControls.SearchIncident searchIncident1;
        private System.Windows.Forms.TabPage tabDisplayOpenIncidents;
        private System.Windows.Forms.ListView listView1;
        private UserControls.DisplayOpenIncidents displayOpenIncidents1;
    }
}