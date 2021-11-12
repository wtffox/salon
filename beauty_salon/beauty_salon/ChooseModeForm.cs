using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beauty_salon
{
    public partial class ChooseModeForm : Form
    {
        public ChooseModeForm()
        {
            InitializeComponent();
            logoNamePanel.BackColor = Color.FromArgb(225, 228, 255);
        }

        private void viewServBtn_Click(object sender, EventArgs e)
        {
            ViewServicesForm viewServices = new ViewServicesForm();
            viewServices.Show();
            Hide();
        }

        private void addDataServBtn_Click(object sender, EventArgs e)
        {
            addServiceDataForm addServiceDataForm = new addServiceDataForm();
            addServiceDataForm.Show();
            Hide();
        }
    }
}
