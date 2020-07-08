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

    public partial class DealerInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""D:\Marwadi\6th Sem\NET\Assignment\Inventory Management System\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf"";Integrated Security=True");
        public DealerInfo()
        {
            InitializeComponent();
        }

        private void InsertDealerInfo_Click(object sender, EventArgs e)
        {
            /*if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }*/
            try
            {
                //Create SqlConnection

                SqlCommand cmd = new SqlCommand("Select * from DealerInfo where DealerName=@DealerName", con);
                cmd.Parameters.AddWithValue("@DealerName", txtDealerName.Text);
                //cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                //con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                //con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    /* MessageBox.Show("Login Successful!");
                     this.Hide();
                     // Dashboard dsb = new Dashboard();
                     MDIParent1 md = new MDIParent1();
                     md.Show();*/
                    MessageBox.Show("This Dealer Name Is Already Added");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("insert into DealerInfo (DealerName,DealerCompanyName,Contact,Address,City) VALUES (@DealerName,@DealerCompanyName,@Contact,@Address,@City)", con);
                    cmd1.Parameters.AddWithValue("@DealerName", txtDealerName.Text);
                    cmd1.Parameters.AddWithValue("@DealerCompanyName", txtCompanyName.Text);
                    cmd1.Parameters.AddWithValue("@Contact", txtDealerContact.Text);
                    cmd1.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd1.Parameters.AddWithValue("@City", txtCity.Text);
                    
                   
                    cmd1.ExecuteNonQuery();
                    DisplayDealerData();

                    txtDealerName.Text = "";
                    txtCompanyName.Text = "";
                    txtDealerContact.Text = "";
                    txtAddress.Text = "";
                    txtCity.Text = "";


                    MessageBox.Show("Dealer Info  Added Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DealerInfo_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            DisplayDealerData();
        }

        public void DisplayDealerData()
        {
            SqlCommand cmd = new SqlCommand("Select * from DealerInfo", con);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            dealer_infoGridView.DataSource = ds;

        }

        private void btnDeleteDealerInfo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from DealerInfo where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dealer_infoGridView.SelectedCells[0].Value.ToString()));
            cmd.ExecuteNonQuery();
            DisplayDealerData();
            txtDealerName.Text = "";
            txtCompanyName.Text = "";
            txtDealerContact.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";

            MessageBox.Show("Dealer Info  Deleted Successfully");
        }

        private void dealer_infoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dealer_infoGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from DealerInfo where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dealer_infoGridView.SelectedCells[0].Value.ToString()));
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
    
                txtDealerName.Text = dr["DealerName"].ToString();
                txtCompanyName.Text = dr["DealerCompanyName"].ToString();
                txtDealerContact.Text = dr["Contact"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtCity.Text = dr["City"].ToString();
            }
        }

        private void btnUpdateDealerInfo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update DealerInfo set DealerName = @DealerName,DealerCompanyName = @DealerCompanyName,Contact = @Contact, Address = @Address, City = @City where Id= @Id", con);
            cmd2.Parameters.AddWithValue("@Id", Convert.ToInt32(dealer_infoGridView.SelectedCells[0].Value.ToString()));
            cmd2.Parameters.AddWithValue("@DealerName", txtDealerName.Text);
            cmd2.Parameters.AddWithValue("@DealerCompanyName", txtCompanyName.Text);
            cmd2.Parameters.AddWithValue("@Contact", txtDealerContact.Text);
            cmd2.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd2.Parameters.AddWithValue("@City", txtCity.Text);
            cmd2.ExecuteNonQuery();
            DisplayDealerData();
            MessageBox.Show("Dealer Info Updated Succesfully");
            
        }
    }
}
