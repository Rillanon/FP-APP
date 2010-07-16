namespace FP_AppointmentDiary
{
    partial class CheckOutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutDialog));
            this.InvoiceButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.AppointmentCheckList = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentCheckList)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceButton.Appearance.Options.UseFont = true;
            this.InvoiceButton.Location = new System.Drawing.Point(386, 466);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(180, 67);
            this.InvoiceButton.TabIndex = 0;
            this.InvoiceButton.Text = "Invoice";
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Appearance.Options.UseFont = true;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(572, 466);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(180, 67);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AppointmentCheckList
            // 
            this.AppointmentCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentCheckList.Location = new System.Drawing.Point(0, 0);
            this.AppointmentCheckList.Name = "AppointmentCheckList";
            this.AppointmentCheckList.Size = new System.Drawing.Size(764, 445);
            this.AppointmentCheckList.TabIndex = 2;
            // 
            // CheckOutDialog
            // 
            this.AcceptButton = this.InvoiceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(764, 545);
            this.Controls.Add(this.AppointmentCheckList);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InvoiceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckOutDialog";
            this.Text = "Check Out";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentCheckList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton InvoiceButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.CheckedListBoxControl AppointmentCheckList;
    }
}