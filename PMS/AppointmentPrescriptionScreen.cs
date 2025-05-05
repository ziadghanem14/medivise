using System;
using System.Windows.Forms;

namespace PMS
{
    public partial class AppointmentPrescriptionScreen : Form
    {
        public AppointmentPrescriptionScreen()
        {
            InitializeComponent();
        }

        private void AppointmentPrescriptionScreen_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadPrescriptions();
        }

        private void LoadAppointments()
        {
            // Implement logic to load appointment data into appointmentDataGridView
        }

        private void LoadPrescriptions()
        {
            // Implement logic to load prescription data into prescriptionDataGridView
        }
    }
}