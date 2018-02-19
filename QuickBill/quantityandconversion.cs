using System;
using System.Windows.Forms;
using UnitsNet;

namespace QuickBill
{
    public delegate void DataSendHandler(string str);
    public partial class quantityandconversion : Form
    {
        public event DataSendHandler dataSent;
        
        public quantityandconversion()
        {

            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            double quantity;
            Mass weight;
            Volume vol;

            if (double.TryParse(qtybc.Text, out quantity))
            {

                if (itemmu.Text == "kilogram")
                {
                    if (unitSelect.Text == "gram")
                    {
                        weight = Mass.FromGrams(quantity);
                        qtyac.Text = weight.Kilograms.ToString();

                    }
                    else if (unitSelect.Text == "milligram")
                    {
                        weight = Mass.FromMilligrams(quantity);
                        qtyac.Text = weight.Kilograms.ToString();
                    }

                }
                else if (itemmu.Text == "gram")
                {

                    if (unitSelect.Text == "kilogram")
                    {
                        weight = Mass.FromKilograms(quantity);
                        qtyac.Text = weight.Grams.ToString();

                    }
                    else if (unitSelect.Text == "milligram")
                    {
                        weight = Mass.FromMilligrams(quantity);
                        qtyac.Text = weight.Grams.ToString();
                    }
                }
                else if (itemmu.Text == "milligram")
                {
                    if (unitSelect.Text == "kilogram")
                    {
                        weight = Mass.FromKilograms(quantity);
                        qtyac.Text = weight.Milligrams.ToString();

                    }
                    else if (unitSelect.Text == "gram")
                    {
                        weight = Mass.FromGrams(quantity);
                        qtyac.Text = weight.Milligrams.ToString();
                    }

                }
                else if (itemmu.Text == "litre")
                {
                    if (unitSelect.Text == "millilitre")
                    {
                        vol = Volume.FromMilliliters(quantity);
                        qtyac.Text = vol.Liters.ToString();
                    }

                }
                else if (itemmu.Text == "millilitre")
                {
                    if (unitSelect.Text == "litre")
                    {
                        vol = Volume.FromLiters(quantity);
                        qtyac.Text = vol.Milliliters.ToString();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter a numeric Value in quantity convert field");
            }

        }

        private void quantityandconversion_Load(object sender, EventArgs e)
        {
            string catmu = itemmu.Text;
            if (catmu == "kilogram")
            {
                unitSelect.Items.Add("gram");
                unitSelect.Items.Add("milligram");
            }
            else if (catmu == "gram")
            {
                unitSelect.Items.Add("kilogram");
                unitSelect.Items.Add("milligram");
            }
            else if(catmu == "milligram")
            {
                unitSelect.Items.Add("kilogram");
                unitSelect.Items.Add("gram");
            }
            else if (catmu == "litre")
            {
                unitSelect.Items.Add("millilitre");
            }
            else if (catmu == "millilitre")
            {
                unitSelect.Items.Add("litre");
            }
            else
            {
                unitSelect.Enabled = false;
                qtybc.Enabled = false;
            }

        }

        private void qtyAddbtn_Click(object sender, EventArgs e)
        {

            double outqty;
            int pqty;
            if( !double.TryParse(qtyac.Text, out outqty))
            {
                MessageBox.Show("Please enter a numeric value in Quantity field");
            }
            else if(double.Parse(qtyac.Text)<=0)
            {
                MessageBox.Show("Quantity must be greater than 0");
            }
            else
            {
               
                if (qtyac.Text != "")
                {
                    if (itemmu.Text == "pcs")
                    {
                        if (Int32.TryParse(qtyac.Text, out pqty))
                        {
                            this.dataSent(pqty.ToString());
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Quantity cannot be float when Measuring unit is \"pcs\"");
                        }
                    }
                    else
                    {
                        this.dataSent(qtyac.Text);
                        this.Close();
                    }
                }
                                                    
            }
            
        }

        private void quantityandconversion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qtyac.Text == "")
            {
                DialogResult res= MessageBox.Show("Quantity field is empty","Warning",MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                {
                    e.Cancel = true;
                }
                
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void itemmu_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void qtyac_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtybc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
