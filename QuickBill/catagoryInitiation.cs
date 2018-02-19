using QuickBill.Properties;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickBill
{

    public partial class catagoryInitiation : Form
    {

        public catagoryInitiation()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void catagoryInitiation_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float stax, ctax;
            Regex rx = new Regex("([_])");

            if (insertcattextbox.Text == "")
            {
                MessageBox.Show("Please enter a catagory name");
            }
            else if (mucombobox.Text == "")
            {
                MessageBox.Show("Please select a measuring unit to measure the catagory of items");
            }
            else if (!float.TryParse(sgsttb.Text, out stax))
            {

                MessageBox.Show("Please enter only numeric value in SGST field");

            }
            else if (!float.TryParse(cgsttb.Text, out ctax))
            {
                MessageBox.Show("Please enter only numeric value in CGST field");
            }
            else if(float.Parse(cgsttb.Text)>99 || float.Parse(cgsttb.Text) < 0)
            {
                MessageBox.Show("CGST value is unacceptable (0 - 99)");
            }
            else if (float.Parse(sgsttb.Text) > 99 || float.Parse(sgsttb.Text) < 0)
            {
                MessageBox.Show("SGST value is unacceptable (0 - 99)");
            }
            else if (rx.IsMatch(insertcattextbox.Text))
            {
                MessageBox.Show("'_' Charecter is not allowed in a Catagory Name");
            }
            else
            {
                try
                {
                    dboperation operation = new dboperation();
                    SqlCeConnection conn = null;
                    conn = operation.dbConnection(Settings.Default.DatabasePath);
                    if (!duplicate(conn, insertcattextbox.Text))
                    {
                        string insertquery = "INSERT INTO catagory(Catagory,sgst,cgst,MeasuringUnit) VALUES(@cat,@sgst,@cgst,@mu)";
                        SqlCeCommand cmd = new SqlCeCommand(insertquery, conn);
                        cmd.Parameters.AddWithValue("@cat", insertcattextbox.Text);
                        cmd.Parameters.AddWithValue("@sgst", sgsttb.Text);
                        cmd.Parameters.AddWithValue("@cgst", cgsttb.Text);
                        cmd.Parameters.AddWithValue("@mu", mucombobox.Text);
                        int result = cmd.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("Error Inserting New User");
                            return;
                        }
                        insertcattextbox.Clear();
                        mucombobox.ResetText();
                        sgsttb.Clear();
                        cgsttb.Clear();
                        bool flag = false;
                        flag = load_datagridview(conn);
                        if (flag == true)
                        {

                            //  MessageBox.Show("Table Loading Complete");
                        }

                        else
                        {
                            MessageBox.Show("Error occured to load the table from the database");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! Please try a different name as a catagory");
                    }
                    operation.closeDBConnection(conn);
                }
                catch (Exception ex)
                {

                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var editcat = new editCatagory();
            foreach (DataGridViewRow row in catDataShow.SelectedRows)
            {
                editcat.catnameupdate.Text = row.Cells[1].Value.ToString();
                editcat.updatemu.Text = row.Cells[2].Value.ToString();
                editcat.updatesgst.Text = row.Cells[3].Value.ToString();
                editcat.updatecgst.Text = row.Cells[4].Value.ToString();
                editcat.cid.Text = row.Cells[0].Value.ToString();
                editcat.ShowDialog();
            }

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mucombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Fetch data from database to datagridview

        private bool load_datagridview(SqlCeConnection conn)
        {
            try
            {
                string selectquery = "SELECT * FROM catagory ORDER BY CatId DESC";
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(selectquery, conn);
                DataTable dt = new DataTable();
                catDataShow.AutoGenerateColumns = false;
                adapter.Fill(dt);
                catDataShow.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        // Check the catagory name to prevent duplicate entry

        private bool duplicate(SqlCeConnection conn, string catname)
        {
            try
            {
                string query = "SELECT Catagory FROM catagory";
                SqlCeDataReader reader = null;
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (catname.ToLower() == reader.GetString(0).ToLower())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while checking for duplicate entry");
                return true;
            }
        }

        private void catagoryInitiation_Load(object sender, EventArgs e)
        {
            try
            {
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                load_datagridview(conn);
                operation.closeDBConnection(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading database tables");
            }
        }

        private void catRmv_Click(object sender, EventArgs e)
        {
            var removecat = new rmvCatagory();
            foreach (DataGridViewRow row in catDataShow.SelectedRows)
            {
                removecat.catnamermv.Text = row.Cells[1].Value.ToString();
                removecat.catmurmv.Text = row.Cells[2].Value.ToString();
                removecat.catsgstrmv.Text = row.Cells[3].Value.ToString();
                removecat.catcgstrmv.Text = row.Cells[4].Value.ToString();
                removecat.rmvcid.Text = row.Cells[0].Value.ToString();
                removecat.ShowDialog();
            }
            dboperation operation = new dboperation();
            SqlCeConnection conn = operation.dbConnection(Settings.Default.DatabasePath);
            load_datagridview(conn);
            operation.closeDBConnection(conn);

        }

        private void catagoryInitiation_Activated(object sender, EventArgs e)
        {
            try
            {
                dboperation operation = new dboperation();
                SqlCeConnection conn = null;
                conn = operation.dbConnection(Settings.Default.DatabasePath);
                load_datagridview(conn);
                operation.closeDBConnection(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading database tables");
            }
        }
    }
}
