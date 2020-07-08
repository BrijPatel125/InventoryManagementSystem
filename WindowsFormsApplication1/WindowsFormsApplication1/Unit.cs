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
    public partial class Unit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""D:\Marwadi\6th Sem\NET\Assignment\Inventory Management System\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf"";Integrated Security=True");
        public Unit()
        {
            InitializeComponent();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
           if(txtUnit.Text == "")
           {
               MessageBox.Show("Please provide Unit");
               return;
           }
           try
           {
                //Create SqlConnection

                SqlCommand cmd = new SqlCommand("Select * from Units where unit=@unit", con);
                cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show unit is already registered
                if (count == 1)
                {
                    MessageBox.Show("This Unit Is Already Added");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("insert into Units (unit) VALUES(@Unit)", con);
                    cmd1.Parameters.AddWithValue("@Unit", txtUnit.Text);
                    cmd1.ExecuteNonQuery();
                    DisplayUnitData();
                    txtUnit.Text = "";
                    MessageBox.Show("Unit Added Succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            DisplayUnitData();
        }
        public void DisplayUnitData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Units", con);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            unitGridView.DataSource = ds;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("delete from Units where id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(unitGridView.SelectedCells[0].Value.ToString()));
            cmd.ExecuteNonQuery();
            DisplayUnitData();
            MessageBox.Show("Unit Deleted Successfully");
        }
    }
}
