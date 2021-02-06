
namespace TechSupport.UserControls
{
    partial class DisplayOpenIncidents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridViewIncidentViewer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncidentViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewIncidentViewer
            // 
            this.gridViewIncidentViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIncidentViewer.Location = new System.Drawing.Point(0, 3);
            this.gridViewIncidentViewer.Name = "gridViewIncidentViewer";
            this.gridViewIncidentViewer.RowHeadersWidth = 102;
            this.gridViewIncidentViewer.RowTemplate.Height = 40;
            this.gridViewIncidentViewer.Size = new System.Drawing.Size(1038, 746);
            this.gridViewIncidentViewer.TabIndex = 0;
            // 
            // DisplayOpenIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewIncidentViewer);
            this.Name = "DisplayOpenIncidents";
            this.Size = new System.Drawing.Size(1041, 752);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncidentViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewIncidentViewer;
    }
}
