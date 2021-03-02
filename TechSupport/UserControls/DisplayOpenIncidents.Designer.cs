
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
            this.listViewIncidentViewer = new System.Windows.Forms.ListView();
            this.lblNoOpenIncidents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewIncidentViewer
            // 
            this.listViewIncidentViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewIncidentViewer.FullRowSelect = true;
            this.listViewIncidentViewer.HideSelection = false;
            this.listViewIncidentViewer.Location = new System.Drawing.Point(0, 0);
            this.listViewIncidentViewer.Name = "listViewIncidentViewer";
            this.listViewIncidentViewer.Size = new System.Drawing.Size(1423, 583);
            this.listViewIncidentViewer.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewIncidentViewer.TabIndex = 0;
            this.listViewIncidentViewer.UseCompatibleStateImageBehavior = false;
            this.listViewIncidentViewer.View = System.Windows.Forms.View.Details;
            // 
            // lblNoOpenIncidents
            // 
            this.lblNoOpenIncidents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoOpenIncidents.AutoSize = true;
            this.lblNoOpenIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOpenIncidents.ForeColor = System.Drawing.Color.Red;
            this.lblNoOpenIncidents.Location = new System.Drawing.Point(583, 598);
            this.lblNoOpenIncidents.Name = "lblNoOpenIncidents";
            this.lblNoOpenIncidents.Size = new System.Drawing.Size(0, 46);
            this.lblNoOpenIncidents.TabIndex = 1;
            this.lblNoOpenIncidents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayOpenIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNoOpenIncidents);
            this.Controls.Add(this.listViewIncidentViewer);
            this.Name = "DisplayOpenIncidents";
            this.Size = new System.Drawing.Size(1423, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewIncidentViewer;
        private System.Windows.Forms.Label lblNoOpenIncidents;
    }
}
