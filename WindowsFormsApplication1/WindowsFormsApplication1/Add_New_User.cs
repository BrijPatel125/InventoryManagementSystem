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
    public partial class Add_New_User : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""D:\Marwadi\6th Sem\NET\Assignment\Inventory Management System\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf"";Integrated Security=True");
        public Add_New_User()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblheading_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            /*if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }*/
            try
            {
                //Create SqlConnection

                SqlCommand cmd = new SqlCommand("Select * from Registration where Username=@username", con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
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
                    MessageBox.Show("This Username Is Already Registered");
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("insert into Registration (FirstName,LastName,Username,Password,Email,Contact) VALUES(@FirstName,@LastName,@Username,@Password,@Email,@Contact)", con);
                    cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd1.Parameters.AddWithValue("@Username", txtUserName.Text);
                    cmd1.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd1.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd1.ExecuteNonQuery();
                    DisplayUserData();
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtUserName.Text="";
                    txtPassword.Text="";
                    txtEmail.Text="";
                    txtContact.Text = "";


                    MessageBox.Show("User Added Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_New_User_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }       
            con.Open();
            DisplayUserData();
        }
        public void DisplayUserData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Registration", con);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds;
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("delete from Registration where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString()));
            cmd.ExecuteNonQuery();
            DisplayUserData();
            MessageBox.Show("User Deleted Successfully");

        }
    }
}
