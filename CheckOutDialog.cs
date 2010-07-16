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
    public partial class CheckOutDialog : Form
    {
        public CheckOutDialog()
        {
            InitializeComponent();
        
        }

        public void SetAppointmentCollection(ref List<DevExpress.XtraScheduler.Appointment> e)
        {
            this.AppointmentCheckList.DataSource = e;
            this.AppointmentCheckList.DisplayMember = "Subject";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

        }

        private void InvoiceButton_Click(object sender, EventArgs e)
        {
            //Stub Invoice Form Comes in here;
        }

       
    }
}
