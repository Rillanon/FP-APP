using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FP_AppointmentDiary
{
    public partial class SelectStaffDialog : Form
    {
        public SelectStaffDialog()
        {
            InitializeComponent();
        }

        public void SetSchedulerStorage(ref DevExpress.XtraScheduler.SchedulerControl e)
        {
            this.ResourceCheckList.SchedulerControl = e;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

        }
        
        


    }
}
