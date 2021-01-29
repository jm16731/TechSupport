
namespace TechSupport.UserControls
{
    partial class LoadAll
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
            this.gridViewIncidentViewer.AllowUserToAddRows = false;
            this.gridViewIncidentViewer.AllowUserToDeleteRows = false;
            this.gridViewIncidentViewer.AllowUserToOrderColumns = true;
            this.gridViewIncidentViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIncidentViewer.Location = new System.Drawing.Point(3, 0);
            this.gridViewIncidentViewer.Name = "gridViewIncidentViewer";
            this.gridViewIncidentViewer.ReadOnly = true;
            this.gridViewIncidentViewer.RowHeadersWidth = 102;
            this.gridViewIncidentViewer.RowTemplate.Height = 40;
            this.gridViewIncidentViewer.Size = new System.Drawing.Size(1389, 565);
            this.gridViewIncidentViewer.TabIndex = 1;
            this.gridViewIncidentViewer.TabStop = false;
            // 
            // LoadAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewIncidentViewer);
            this.Name = "LoadAll";
            this.Size = new System.Drawing.Size(1392, 564);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncidentViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewIncidentViewer;
    }
}
