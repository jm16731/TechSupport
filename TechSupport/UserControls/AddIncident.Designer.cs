
namespace TechSupport.UserControls
{
    partial class AddIncident
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
            this.tblLayoutPnlAddIncident = new System.Windows.Forms.TableLayoutPanel();
            this.lblIncidentName = new System.Windows.Forms.Label();
            this.txtIncidentName = new System.Windows.Forms.TextBox();
            this.lblIncidentDescription = new System.Windows.Forms.Label();
            this.lblIncidentCustomerID = new System.Windows.Forms.Label();
            this.txtIncidentDescription = new System.Windows.Forms.TextBox();
            this.txtIncidentCustomerID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblIDError = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblLayoutPnlAddIncident.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPnlAddIncident
            // 
            this.tblLayoutPnlAddIncident.ColumnCount = 2;
            this.tblLayoutPnlAddIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPnlAddIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIncidentName, 0, 0);
            this.tblLayoutPnlAddIncident.Controls.Add(this.txtIncidentName, 1, 0);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIncidentDescription, 0, 1);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIncidentCustomerID, 0, 2);
            this.tblLayoutPnlAddIncident.Controls.Add(this.txtIncidentDescription, 1, 1);
            this.tblLayoutPnlAddIncident.Controls.Add(this.txtIncidentCustomerID, 1, 2);
            this.tblLayoutPnlAddIncident.Controls.Add(this.btnClear, 1, 4);
            this.tblLayoutPnlAddIncident.Controls.Add(this.btnAdd, 0, 4);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIDError, 1, 3);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblMessage, 0, 3);
            this.tblLayoutPnlAddIncident.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPnlAddIncident.Name = "tblLayoutPnlAddIncident";
            this.tblLayoutPnlAddIncident.RowCount = 5;
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayoutPnlAddIncident.Size = new System.Drawing.Size(1124, 627);
            this.tblLayoutPnlAddIncident.TabIndex = 0;
            // 
            // lblIncidentName
            // 
            this.lblIncidentName.AutoSize = true;
            this.lblIncidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentName.Location = new System.Drawing.Point(3, 0);
            this.lblIncidentName.Name = "lblIncidentName";
            this.lblIncidentName.Size = new System.Drawing.Size(126, 46);
            this.lblIncidentName.TabIndex = 3;
            this.lblIncidentName.Text = "Name";
            // 
            // txtIncidentName
            // 
            this.txtIncidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentName.Location = new System.Drawing.Point(565, 3);
            this.txtIncidentName.Name = "txtIncidentName";
            this.txtIncidentName.Size = new System.Drawing.Size(516, 53);
            this.txtIncidentName.TabIndex = 4;
            this.txtIncidentName.TextChanged += new System.EventHandler(this.LblName_TextChanged);
            // 
            // lblIncidentDescription
            // 
            this.lblIncidentDescription.AutoSize = true;
            this.lblIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentDescription.Location = new System.Drawing.Point(3, 110);
            this.lblIncidentDescription.Name = "lblIncidentDescription";
            this.lblIncidentDescription.Size = new System.Drawing.Size(221, 46);
            this.lblIncidentDescription.TabIndex = 5;
            this.lblIncidentDescription.Text = "Description";
            // 
            // lblIncidentCustomerID
            // 
            this.lblIncidentCustomerID.AutoSize = true;
            this.lblIncidentCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentCustomerID.Location = new System.Drawing.Point(3, 305);
            this.lblIncidentCustomerID.Name = "lblIncidentCustomerID";
            this.lblIncidentCustomerID.Size = new System.Drawing.Size(243, 46);
            this.lblIncidentCustomerID.TabIndex = 6;
            this.lblIncidentCustomerID.Text = "Customer ID";
            // 
            // txtIncidentDescription
            // 
            this.txtIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentDescription.Location = new System.Drawing.Point(565, 113);
            this.txtIncidentDescription.Multiline = true;
            this.txtIncidentDescription.Name = "txtIncidentDescription";
            this.txtIncidentDescription.Size = new System.Drawing.Size(556, 152);
            this.txtIncidentDescription.TabIndex = 7;
            this.txtIncidentDescription.TextChanged += new System.EventHandler(this.LblDescription_TextChanged);
            // 
            // txtIncidentCustomerID
            // 
            this.txtIncidentCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentCustomerID.Location = new System.Drawing.Point(565, 308);
            this.txtIncidentCustomerID.Name = "txtIncidentCustomerID";
            this.txtIncidentCustomerID.Size = new System.Drawing.Size(516, 53);
            this.txtIncidentCustomerID.TabIndex = 8;
            this.txtIncidentCustomerID.TextChanged += new System.EventHandler(this.LblCustomerID_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(565, 499);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(344, 118);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(344, 118);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_click);
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.Location = new System.Drawing.Point(565, 404);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(0, 46);
            this.lblIDError.TabIndex = 11;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(3, 404);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 46);
            this.lblMessage.TabIndex = 12;
            // 
            // AddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutPnlAddIncident);
            this.Name = "AddIncident";
            this.Size = new System.Drawing.Size(1127, 630);
            this.tblLayoutPnlAddIncident.ResumeLayout(false);
            this.tblLayoutPnlAddIncident.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPnlAddIncident;
        private System.Windows.Forms.Label lblIncidentName;
        private System.Windows.Forms.TextBox txtIncidentName;
        private System.Windows.Forms.Label lblIncidentDescription;
        private System.Windows.Forms.Label lblIncidentCustomerID;
        private System.Windows.Forms.TextBox txtIncidentDescription;
        private System.Windows.Forms.TextBox txtIncidentCustomerID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.Label lblMessage;
    }
}
