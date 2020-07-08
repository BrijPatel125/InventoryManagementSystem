using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class AddProductName : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""D:\Marwadi\6th Sem\NET\Assignment\Inventory Management System\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf"";Integrated Security=True");
        public AddProductName()
        {
            InitializeComponent();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        public void Fill_DropDown()
        {
            comboBoxSelectUnit.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select * from Units", con);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach(DataRow dr in ds.Rows)
            {
                comboBoxSelectUnit.Items.Add(dr["unit"].ToString());
            }
        }

        private void AddProductName_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           DisplayProductData();
            Fill_DropDown();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please provide Unit");
                return;
            }
            try
            {
                //Create SqlConnection

                SqlCommand cmd = new SqlCommand("Select * from ProductName where ProductName=@ProductName", con);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show unit is already registered
                if (count == 1)
                {
                    MessageBox.Show("This Product Name Is Already Added");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("insert into ProductName (ProductName,Unit) VALUES(@ProductName,@Unit)", con);
                    cmd1.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    cmd1.Parameters.AddWithValue("@Unit", comboBoxSelectUnit.SelectedItem.ToString());
                    cmd1.ExecuteNonQuery();
                    DisplayProductData();
                    txtProductName.Text = "";
                    MessageBox.Show("Product Name Added Succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayProductData()
        {
            SqlCommand cmd = new SqlCommand("Select * from ProductName", con);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            productGridView.DataSource = ds;

        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            comboBoxUpdateSelectedUnit.Items.Clear();
            SqlCommand cmd1 = new SqlCommand("Select * from Units", con);
            cmd1.ExecuteNonQuery();
            DataTable ds1 = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
            //DataSet ds = new DataSet();
            adapt1.Fill(ds1);
            foreach (DataRow dr1 in ds1.Rows)
            {
                comboBoxUpdateSelectedUnit.Items.Add(dr1["unit"].ToString());
            }

            SqlCommand cmd = new SqlCommand("Select * from ProductName where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(productGridView.SelectedCells[0].Value.ToString()));
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                txtUpdateProductName.Text = dr["ProductName"].ToString();
                comboBoxUpdateSelectedUnit.SelectedItem = dr["unit"].ToString();
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*SqlCommand cmd2 = new SqlCommand("update ProductName set ProductName = @ProductName,Unit = @Unit where Id= Convert.ToInt32(productGridView.SelectedCells[0].Value.ToString())", con);
            //cmd2.Parameters.AddWithValue("@Id", Convert.ToInt32(productGridView.SelectedCells[0].Value.ToString()));
            cmd2.Parameters.AddWithValue("@ProductName", txtUpdateProductName.Text);
            cmd2.Parameters.AddWithValue("@Unit", comboBoxUpdateSelectedUnit.SelectedItem.ToString());
            cmd2.ExecuteNonQuery();
            DisplayProductData();
            //txtProductName.Text = "";
            MessageBox.Show("Product Name Updated Succesfully");*/

            int i = Convert.ToInt32(productGridView.SelectedCells[0].Value.ToString());
            //MessageBox.Show(i.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ProductName set ProductName = '" + txtUpdateProductName.Text + "', Unit = '" +comboBoxUpdateSelectedUnit.SelectedItem.ToString()+ "' where Id = " + i + "";
            cmd.ExecuteNonQuery();
            DisplayProductData();
            //txtProductName.Text = "";
            MessageBox.Show("Product Name Updated Succesfully");
        }

    }
}
