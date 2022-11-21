using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_calculator
{
    public partial class tip_calculator : Form
    {
        
        

        public tip_calculator()
        {
            InitializeComponent();
        }

        private void tip_calculator_Load(object sender, EventArgs e)
        {

        }

        private void tip5_btn_Click(object sender, EventArgs e)
        {
            double bill = Convert.ToDouble(bill_box.Text);
            double num_people = Convert.ToDouble(nPeople_box.Text);
            double tip_5 = 0.05; //5% tip

            double tip_5_amount = bill * tip_5;
            tipAmount_box.Text = Math.Round((tip_5_amount / num_people), 2).ToString();
            totalAmount_box.Text = Math.Round((bill / num_people + tip_5_amount), 2).ToString();
        }

        private void tip10_btn_Click(object sender, EventArgs e)
        {
            double bill = Convert.ToDouble(bill_box.Text);
            double num_people = Convert.ToDouble(nPeople_box.Text);
            double tip_10 = 0.10;

            double tip_10_amount = bill * tip_10;
            tipAmount_box.Text = Math.Round((tip_10_amount / num_people), 2).ToString();
            totalAmount_box.Text = Math.Round((bill / num_people + tip_10_amount), 2).ToString();
        }

        private void tip15_btn_Click(object sender, EventArgs e)
        {
            double bill = Convert.ToDouble(bill_box.Text);
            double num_people = Convert.ToDouble(nPeople_box.Text);
            double tip_15 = 0.15;

            double tip_15_amount = bill * tip_15;
            tipAmount_box.Text = Math.Round((tip_15_amount / num_people), 2).ToString();
            totalAmount_box.Text = Math.Round((bill / num_people + tip_15_amount), 2).ToString();
        }

        private void tip25_btn_Click(object sender, EventArgs e)
        {
            double bill = Convert.ToDouble(bill_box.Text);
            double num_people = Convert.ToDouble(nPeople_box.Text);
            double tip_25 = 0.25;

            double tip_25_amount = bill * tip_25;
            tipAmount_box.Text = Math.Round((tip_25_amount / num_people), 2).ToString();
            totalAmount_box.Text = Math.Round((bill / num_people + tip_25_amount), 2).ToString();
        }

        private void tip50_btn_Click(object sender, EventArgs e)
        {
            double bill = Convert.ToDouble(bill_box.Text);
            double num_people = Convert.ToDouble(nPeople_box.Text);
            double tip_50 = 0.50;

            double tip_50_amount = bill * tip_50;
            tipAmount_box.Text = Math.Round((tip_50_amount / num_people), 2).ToString();
            totalAmount_box.Text = Math.Round((bill / num_people + tip_50_amount), 2).ToString();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            double bill = Convert.ToDouble(bill_box.Text);
            double num_people = Convert.ToDouble(nPeople_box.Text);
            double tip_custom = Convert.ToDouble(customTip_box.Text);

            double tip_custom_amount = (bill * tip_custom) / 100;
            tipAmount_box.Text = Math.Round((tip_custom_amount / num_people), 2).ToString();
            totalAmount_box.Text = Math.Round((bill / num_people + tip_custom_amount), 2).ToString();
        }
    }
}
