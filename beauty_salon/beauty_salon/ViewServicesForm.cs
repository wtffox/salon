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
    public partial class ViewServicesForm : Form
    {
        public ViewServicesForm()
        {
            InitializeComponent();
            serviceBindingSource.DataSource = nail_salonDataSet.Service;
            var columns = servicesDataGridView.Columns;
            for (int i = 0; i < columns.Count; i++)
                columnsCB.Items.Add(columns[i].HeaderText);
            columnsCB.SelectedIndex = 0;
        }

        private void ViewServices_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nail_salonDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.nail_salonDataSet.Service);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        private void ViewServices_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
            
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
         
            try
            {
                string search = searchTB.Text;
                (serviceBindingSource.DataSource as DataTable).DefaultView.RowFilter = $"Convert([{servicesDataGridView.Columns[columnsCB.SelectedIndex].DataPropertyName}], System.String) like '%{searchTB.Text}%'";
            }
            catch { Exception ex; }
           


        }

        private void addDataServBtn_Click(object sender, EventArgs e)
        {
            addServiceDataForm addServiceDataForm = new addServiceDataForm();
            addServiceDataForm.Show();
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (serviceBindingSource.Current == null)
                return;
            serviceBindingSource.RemoveCurrent();
            serviceBindingSource.EndEdit();
            serviceTableAdapter.Adapter.Update(nail_salonDataSet);
        }

        private void servicesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            serviceBindingSource.EndEdit();
            serviceTableAdapter.Adapter.Update(nail_salonDataSet);
        }
    }
}
