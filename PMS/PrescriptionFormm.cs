using System;
using System.Windows.Forms;

namespace PMS
{
    public partial class PrescriptionFormm : Form
    {
        public PrescriptionFormm()
        {
            InitializeComponent();
        }

        private void PrescriptionFormm_Load(object sender, EventArgs e)
        {
            LoadPrescriptions();
        }

        private void LoadPrescriptions()
        {
            // Implement logic to load prescription data into the prescriptionDataGridView
        }
    }
}