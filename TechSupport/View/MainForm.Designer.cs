
namespace TechSupport.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblMainUsername = new System.Windows.Forms.Label();
            this.lnklblLogout = new System.Windows.Forms.LinkLabel();
            this.gridViewIncidentViewer = new System.Windows.Forms.DataGridView();
            this.btnAddIncident = new System.Windows.Forms.Button();
            this.btnSearchIncident = new System.Windows.Forms.Button();
            this.incidentControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncidentViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainUsername
            // 
            this.lblMainUsername.AutoSize = true;
            this.lblMainUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainUsername.Location = new System.Drawing.Point(33, 33);
            this.lblMainUsername.Name = "lblMainUsername";
            this.lblMainUsername.Size = new System.Drawing.Size(196, 46);
            this.lblMainUsername.TabIndex = 0;
            this.lblMainUsername.Text = "username";
            this.lblMainUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnklblLogout
            // 
            this.lnklblLogout.AutoSize = true;
            this.lnklblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLogout.Location = new System.Drawing.Point(1233, 33);
            this.lnklblLogout.Name = "lnklblLogout";
            this.lnklblLogout.Size = new System.Drawing.Size(143, 46);
            this.lnklblLogout.TabIndex = 1;
            this.lnklblLogout.TabStop = true;
            this.lnklblLogout.Text = "Logout";
            this.lnklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogout_LinkClicked);
            // 
            // gridViewIncidentViewer
            // 
            this.gridViewIncidentViewer.AllowUserToAddRows = false;
            this.gridViewIncidentViewer.AllowUserToDeleteRows = false;
            this.gridViewIncidentViewer.AllowUserToResizeColumns = false;
            this.gridViewIncidentViewer.AllowUserToResizeRows = false;
            this.gridViewIncidentViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIncidentViewer.Location = new System.Drawing.Point(12, 349);
            this.gridViewIncidentViewer.Name = "gridViewIncidentViewer";
            this.gridViewIncidentViewer.ReadOnly = true;
            this.gridViewIncidentViewer.RowHeadersWidth = 102;
            this.gridViewIncidentViewer.RowTemplate.Height = 40;
            this.gridViewIncidentViewer.Size = new System.Drawing.Size(1389, 565);
            this.gridViewIncidentViewer.TabIndex = 0;
            this.gridViewIncidentViewer.TabStop = false;
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIncident.Location = new System.Drawing.Point(104, 176);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(380, 95);
            this.btnAddIncident.TabIndex = 3;
            this.btnAddIncident.Text = "Add Incident";
            this.btnAddIncident.UseVisualStyleBackColor = true;
            this.btnAddIncident.Click += new System.EventHandler(this.addBtnIncident_click);
            // 
            // btnSearchIncident
            // 
            this.btnSearchIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchIncident.Location = new System.Drawing.Point(927, 176);
            this.btnSearchIncident.Name = "btnSearchIncident";
            this.btnSearchIncident.Size = new System.Drawing.Size(380, 95);
            this.btnSearchIncident.TabIndex = 4;
            this.btnSearchIncident.Text = "Search Incident";
            this.btnSearchIncident.UseVisualStyleBackColor = true;
            this.btnSearchIncident.Click += new System.EventHandler(this.searchBtnIncident_click);
            // 
            // incidentControllerBindingSource
            // 
            this.incidentControllerBindingSource.DataSource = typeof(TechSupport.Controller.IncidentController);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 926);
            this.Controls.Add(this.btnSearchIncident);
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(this.gridViewIncidentViewer);
            this.Controls.Add(this.lnklblLogout);
            this.Controls.Add(this.lblMainUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeAll);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncidentViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainUsername;
        private System.Windows.Forms.LinkLabel lnklblLogout;
        private System.Windows.Forms.DataGridView gridViewIncidentViewer;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.Button btnSearchIncident;
        private System.Windows.Forms.BindingSource incidentControllerBindingSource;
    }
}