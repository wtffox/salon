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
    public partial class addServiceDataForm : Form
    {
        public addServiceDataForm()
        {
            InitializeComponent();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using(SalonModel salonModel = new SalonModel())
            {
                Service service = new Service();
                service.Title = titleTb.Text;
                service.Cost = Convert.ToDecimal(costTb.Text);
                service.DurationInSeconds = Convert.ToInt32(timeTb.Text);
                service.Description = descriptionTb.Text;
                service.Discount = Convert.ToDouble(discountTb.Text);
                service.MainImagePath = pathTb.Text;

                salonModel.Service.Add(service);
                salonModel.SaveChanges();

                titleTb.Clear();
                costTb.Clear();
                timeTb.Clear();
                descriptionTb.Clear();
                discountTb.Clear();
                pathTb.Clear();


            }
        }
    }
}
