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
    public partial class ADMain : Form
    {
        public ADMain()
        {
            InitializeComponent();
            this.ADSchedulerControl.Start = System.DateTime.Today;
            this.MainMenuRibbonControl.SelectedPage = HomeRibbonPage;
        }

        private void ExitBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Application.Exit();
        }


        private void ADMain_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'appointmentDataSet.Appointments' table. You can move, or remove it, as needed.
                this.appointmentsTableAdapter.Fill(this.appointmentDataSet.Appointments);
                // TODO: This line of code loads data into the 'resourceDataSet.Resources' table. You can move, or remove it, as needed.
                this.resourcesTableAdapter.Fill(this.resourceDataSet.Resources);
                this.ClockTimer.Start();

            }

            catch (Exception)
            {
               //Need to call ExceptionHandlingDiag 
            }


        }

        private void ADSchedulerStorage_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            this.appointmentsTableAdapter.Update(this.appointmentDataSet);
            this.appointmentDataSet.AcceptChanges();
        }

        private void ADSchedulerStorage_AppointmentInserting(object sender, DevExpress.XtraScheduler.PersistentObjectCancelEventArgs e)
        {
            this.appointmentsTableAdapter.Update(this.appointmentDataSet);
            this.appointmentDataSet.AcceptChanges();
        }

        private void ADSchedulerStorage_AppointmentsDeleted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            this.appointmentsTableAdapter.Update(this.appointmentDataSet);
            this.appointmentDataSet.AcceptChanges();
        }

        private void ADSchedulerStorage_AppointmentDeleting(object sender, DevExpress.XtraScheduler.PersistentObjectCancelEventArgs e)
        {
           
                this.appointmentsTableAdapter.Update(this.appointmentDataSet);
                this.appointmentDataSet.AcceptChanges();
               }

        private void SelectStaffBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectStaffDialog Temp = new SelectStaffDialog();
            Temp.SetSchedulerStorage(ref this.ADSchedulerControl);
            Temp.Show();
        }

        private void CheckInBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            List<DevExpress.XtraScheduler.Appointment> y = new List<DevExpress.XtraScheduler.Appointment>();

            foreach (DevExpress.XtraScheduler.Appointment x in this.ADSchedulerControl.SelectedAppointments)
            {

                y.Add(x); // added to anther collection as changing x during runtime can screw up enumeration. 
            }

            foreach (DevExpress.XtraScheduler.Appointment x in y)
            {
                x.LabelId = 7; //sets appointment to check in label.
            }
           
        }

        private void CheckOutBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CheckOutDialog NewCheckOutDialog = new CheckOutDialog();
            List<DevExpress.XtraScheduler.Appointment> y = new List<DevExpress.XtraScheduler.Appointment>();
          

            foreach (DevExpress.XtraScheduler.Appointment x in this.ADSchedulerStorage.GetAppointments(System.DateTime.Today, System.DateTime.Today.AddDays(1)))
            {
                //Check If the Appointment is checked in, potential performance problem as check in items accumalates. 
                //Code written in such a way so only today's checked in appointments get into the invoice list. 
                //Uninvoiced checked in appointments from previous and future dates have to be entered manually from another form.
                
                if (x.LabelId == 7) 
                {
                    y.Add(x);
                }
            }
            NewCheckOutDialog.SetAppointmentCollection(ref y);
            NewCheckOutDialog.Show();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            this.ADMainMenuClockText.Caption = DateTime.Today.ToLongDateString() + "|" + DateTime.Now.ToLongTimeString();
        }

       
    }
}
