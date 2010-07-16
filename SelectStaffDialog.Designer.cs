namespace FP_AppointmentDiary
{
    partial class SelectStaffDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStaffDialog));
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceDataSet = new FP_AppointmentDiary.ResourceDataSet();
            this.CloseButton = new DevExpress.XtraEditors.SimpleButton();
            this.resourcesTableAdapter = new FP_AppointmentDiary.ResourceDataSetTableAdapters.ResourcesTableAdapter();
            this.ResourceCheckList = new DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceCheckList)).BeginInit();
            this.SuspendLayout();
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.resourceDataSet;
            // 
            // resourceDataSet
            // 
            this.resourceDataSet.DataSetName = "ResourceDataSet";
            this.resourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(12, 217);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(268, 44);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // ResourceCheckList
            // 
            this.ResourceCheckList.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourceCheckList.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ResourceCheckList.Appearance.Options.UseFont = true;
            this.ResourceCheckList.Appearance.Options.UseForeColor = true;
            this.ResourceCheckList.Location = new System.Drawing.Point(-1, -1);
            this.ResourceCheckList.Name = "ResourceCheckList";
            this.ResourceCheckList.Size = new System.Drawing.Size(297, 212);
            this.ResourceCheckList.TabIndex = 0;
            // 
            // SelectStaffDialog
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ResourceCheckList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectStaffDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff Display";
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceCheckList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CloseButton;
        private ResourceDataSet resourceDataSet;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private ResourceDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private DevExpress.XtraScheduler.UI.ResourcesCheckedListBoxControl ResourceCheckList;

    }
}