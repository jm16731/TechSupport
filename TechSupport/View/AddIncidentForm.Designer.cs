
namespace TechSupport.View
{
    partial class AddIncidentForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIncidentName = new System.Windows.Forms.Label();
            this.lblIncidentDescription = new System.Windows.Forms.Label();
            this.lblIncidentCustomerID = new System.Windows.Forms.Label();
            this.txtIncidentName = new System.Windows.Forms.TextBox();
            this.txtIncidentDescription = new System.Windows.Forms.TextBox();
            this.txtIncidentCustomerID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 735);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(344, 118);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.add_click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(736, 735);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(344, 118);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancel_click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtIncidentCustomerID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIncidentDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIncidentName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIncidentDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIncidentCustomerID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIncidentName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.66355F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.33645F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1466, 1040);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblIncidentName
            // 
            this.lblIncidentName.AutoSize = true;
            this.lblIncidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentName.Location = new System.Drawing.Point(3, 0);
            this.lblIncidentName.Name = "lblIncidentName";
            this.lblIncidentName.Size = new System.Drawing.Size(126, 46);
            this.lblIncidentName.TabIndex = 2;
            this.lblIncidentName.Text = "Name";
            // 
            // lblIncidentDescription
            // 
            this.lblIncidentDescription.AutoSize = true;
            this.lblIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentDescription.Location = new System.Drawing.Point(3, 148);
            this.lblIncidentDescription.Name = "lblIncidentDescription";
            this.lblIncidentDescription.Size = new System.Drawing.Size(221, 46);
            this.lblIncidentDescription.TabIndex = 3;
            this.lblIncidentDescription.Text = "Description";
            // 
            // lblIncidentCustomerID
            // 
            this.lblIncidentCustomerID.AutoSize = true;
            this.lblIncidentCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentCustomerID.Location = new System.Drawing.Point(3, 535);
            this.lblIncidentCustomerID.Name = "lblIncidentCustomerID";
            this.lblIncidentCustomerID.Size = new System.Drawing.Size(243, 46);
            this.lblIncidentCustomerID.TabIndex = 4;
            this.lblIncidentCustomerID.Text = "Customer ID";
            // 
            // txtIncidentName
            // 
            this.txtIncidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentName.Location = new System.Drawing.Point(736, 3);
            this.txtIncidentName.Name = "txtIncidentName";
            this.txtIncidentName.Size = new System.Drawing.Size(516, 53);
            this.txtIncidentName.TabIndex = 1;
            // 
            // txtIncidentDescription
            // 
            this.txtIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentDescription.Location = new System.Drawing.Point(736, 151);
            this.txtIncidentDescription.Multiline = true;
            this.txtIncidentDescription.Name = "txtIncidentDescription";
            this.txtIncidentDescription.Size = new System.Drawing.Size(727, 283);
            this.txtIncidentDescription.TabIndex = 2;
            // 
            // txtIncidentCustomerID
            // 
            this.txtIncidentCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentCustomerID.Location = new System.Drawing.Point(736, 538);
            this.txtIncidentCustomerID.Name = "txtIncidentCustomerID";
            this.txtIncidentCustomerID.Size = new System.Drawing.Size(516, 53);
            this.txtIncidentCustomerID.TabIndex = 3;
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 1033);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Incident";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtIncidentCustomerID;
        private System.Windows.Forms.TextBox txtIncidentDescription;
        private System.Windows.Forms.Label lblIncidentName;
        private System.Windows.Forms.Label lblIncidentDescription;
        private System.Windows.Forms.Label lblIncidentCustomerID;
        private System.Windows.Forms.TextBox txtIncidentName;
    }
}