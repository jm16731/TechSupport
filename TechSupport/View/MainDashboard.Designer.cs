
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
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddIncident);
            this.tabControl1.Controls.Add(this.tabLoadAll);
            this.tabControl1.Controls.Add(this.tabSearchIncident);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 293);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1436, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAddIncident
            // 
            this.tabAddIncident.Location = new System.Drawing.Point(10, 48);
            this.tabAddIncident.Name = "tabAddIncident";
            this.tabAddIncident.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddIncident.Size = new System.Drawing.Size(1416, 603);
            this.tabAddIncident.TabIndex = 0;
            this.tabAddIncident.Text = "Add Incident";
            this.tabAddIncident.UseVisualStyleBackColor = true;
            // 
            // tabLoadAll
            // 
            this.tabLoadAll.Location = new System.Drawing.Point(10, 48);
            this.tabLoadAll.Name = "tabLoadAll";
            this.tabLoadAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadAll.Size = new System.Drawing.Size(1416, 603);
            this.tabLoadAll.TabIndex = 1;
            this.tabLoadAll.Text = "Load All";
            this.tabLoadAll.UseVisualStyleBackColor = true;
            // 
            // tabSearchIncident
            // 
            this.tabSearchIncident.Location = new System.Drawing.Point(10, 48);
            this.tabSearchIncident.Name = "tabSearchIncident";
            this.tabSearchIncident.Size = new System.Drawing.Size(1416, 603);
            this.tabSearchIncident.TabIndex = 2;
            this.tabSearchIncident.Text = "Search Incidents";
            this.tabSearchIncident.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 954);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddIncident;
        private System.Windows.Forms.TabPage tabLoadAll;
        private System.Windows.Forms.TabPage tabSearchIncident;
    }
}