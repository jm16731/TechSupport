
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
            this.SuspendLayout();
            // 
            // listViewIncidentViewer
            // 
            this.listViewIncidentViewer.FullRowSelect = true;
            this.listViewIncidentViewer.HideSelection = false;
            this.listViewIncidentViewer.Location = new System.Drawing.Point(0, 0);
            this.listViewIncidentViewer.Name = "listViewIncidentViewer";
            this.listViewIncidentViewer.Size = new System.Drawing.Size(1423, 658);
            this.listViewIncidentViewer.TabIndex = 0;
            this.listViewIncidentViewer.UseCompatibleStateImageBehavior = false;
            this.listViewIncidentViewer.View = System.Windows.Forms.View.List;
            // 
            // DisplayOpenIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewIncidentViewer);
            this.Name = "DisplayOpenIncidents";
            this.Size = new System.Drawing.Size(1423, 661);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewIncidentViewer;
    }
}
