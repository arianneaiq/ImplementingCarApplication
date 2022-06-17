using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementingCarApplication
{
    public partial class Form1 : Form
    {
        private Car car1;
        private Car car2;
        private Car car3;
        private Car car4;
        private Car car5;
        private Car selectedCar;

        public Form1()
        {
            InitializeComponent();
            car1 = new Car("y000001", 70, 0, "Ok");
            car2 = new Car("y000002", 80, 0,"Ok");
            car3 = new Car("y000003", 90,0,"Ok");
            car4 = new Car("y000004", 100,0,"Ok");
            car5 = new Car("y000005", 90,0,"Ok");
            selectedCar = new Car();
        }

        private void cbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedindex = cbCars.SelectedIndex;
            cbCars.SelectedItem = selectedCar;

            if(cbCars.SelectedIndex == 0)
            {
                selectedCar = car1;
                lbCarInfo.Text = car1.GetInfo();

            } else if (cbCars.SelectedIndex == 1)
            {
                selectedCar = car2;
                lbCarInfo.Text = car2.GetInfo();
            }
            else if (cbCars.SelectedIndex == 2)
            {
                selectedCar = car3;
                lbCarInfo.Text = car3.GetInfo();
            }
            else if (cbCars.SelectedIndex == 3)
            {
                selectedCar = car4;
                lbCarInfo.Text = car4.GetInfo();

            }else if (cbCars.SelectedIndex == 4)
            {
                selectedCar = car5;
                lbCarInfo.Text = car5.GetInfo();
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            selectedCar.SetUnderMaintenance(true);
            lbCarInfo.Text = selectedCar.GetInfo();
        }

        private void btnReturnMaintenance_Click(object sender, EventArgs e)
        {
            selectedCar.SetUnderMaintenance(false);
            lbCarInfo.Text = selectedCar.GetInfo();
        }

        private void btnRefeul_Click(object sender, EventArgs e)
        {

            selectedCar.addFuel(Convert.ToInt32(nFeulAmount.Value));
            lbCarInfo.Text = selectedCar.GetInfo();

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            selectedCar.SetSold();
            lbCarInfo.Text = selectedCar.GetInfo();
               
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

        }
    }
}
