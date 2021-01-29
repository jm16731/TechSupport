
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddIncident = new System.Windows.Forms.TabPage();
            this.tabLoadAll = new System.Windows.Forms.TabPage();
            this.tabSearchIncident = new System.Windows.Forms.TabPage();
            this.usrCntrlAddIncident = new TechSupport.UserControls.AddIncident();
            this.tabControl1.SuspendLayout();
            this.tabAddIncident.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddIncident);
            this.tabControl1.Controls.Add(this.tabLoadAll);
            this.tabControl1.Controls.Add(this.tabSearchIncident);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 138);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1436, 816);
            this.tabControl1.TabIndex = 1;
            // 
            // tabAddIncident
            // 
            this.tabAddIncident.Controls.Add(this.usrCntrlAddIncident);
            this.tabAddIncident.Location = new System.Drawing.Point(10, 48);
            this.tabAddIncident.Name = "tabAddIncident";
            this.tabAddIncident.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddIncident.Size = new System.Drawing.Size(1416, 758);
            this.tabAddIncident.TabIndex = 0;
            this.tabAddIncident.Text = "Add Incident";
            this.tabAddIncident.UseVisualStyleBackColor = true;
            // 
            // tabLoadAll
            // 
            this.tabLoadAll.Location = new System.Drawing.Point(10, 48);
            this.tabLoadAll.Name = "tabLoadAll";
            this.tabLoadAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadAll.Size = new System.Drawing.Size(1416, 758);
            this.tabLoadAll.TabIndex = 1;
            this.tabLoadAll.Text = "Load All";
            this.tabLoadAll.UseVisualStyleBackColor = true;
            // 
            // tabSearchIncident
            // 
            this.tabSearchIncident.Location = new System.Drawing.Point(10, 48);
            this.tabSearchIncident.Name = "tabSearchIncident";
            this.tabSearchIncident.Size = new System.Drawing.Size(1416, 758);
            this.tabSearchIncident.TabIndex = 2;
            this.tabSearchIncident.Text = "Search Incidents";
            this.tabSearchIncident.UseVisualStyleBackColor = true;
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
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1436, 954);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.close_All);
            this.tabControl1.ResumeLayout(false);
            this.tabAddIncident.ResumeLayout(false);
            this.tabAddIncident.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddIncident;
        private UserControls.AddIncident usrCntrlAddIncident;
        private System.Windows.Forms.TabPage tabLoadAll;
        private System.Windows.Forms.TabPage tabSearchIncident;
    }
}