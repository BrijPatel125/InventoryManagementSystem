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
    public partial class Sales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""D:\Marwadi\6th Sem\NET\Assignment\Inventory Management System\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf"";Integrated Security=True");
        DataTable dt = new DataTable();
        int total = 0;
        public Sales()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dt.Clear();
            dt.Columns.Add("Product");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");
        }

        private void txtProduct_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();

            SqlCommand cmd = new SqlCommand("Select * from Stock where ProductName LIKE ('"+ txtProduct.Text +"%')", con);
            //cmd.Parameters.AddWithValue("@ProductName", txtProduct.Text);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                listBox1.Items.Add(dr["ProductName"].ToString());
            }
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Down)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex + 1;
                }
                if(e.KeyCode==Keys.Up)
                {
                    this.listBox1.SelectedIndex = this.listBox1.SelectedIndex - 1;
                }
                if(e.KeyCode==Keys.Enter)
                {
                    txtProduct.Text = listBox1.SelectedItem.ToString();
                    listBox1.Visible = false;
                    txtPrice.Focus();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select top 1 * from PurchaseMaster where ProductName = @ProductName order by id desc ", con);
            cmd.Parameters.AddWithValue("@ProductName", txtProduct.Text);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                txtPrice.Text = dr["ProductPrice"].ToString();
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd = new SqlCommand("select * from Stock where ProductName = @ProductName", con);
            cmd.Parameters.AddWithValue("@ProductName", txtProduct.Text);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                stock = Convert.ToInt32(dr["ProductQty"].ToString());
            }

            if(Convert.ToInt32(txtQty.Text)>stock)
            {
                MessageBox.Show("This Value Is Not Available");
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["Product"] = txtProduct.Text;
                dr["Price"] = txtPrice.Text;
                dr["Quantity"] = txtQty.Text;
                dr["Total"] = txtTotal.Text;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;

                total = total + Convert.ToInt32(dr["Total"].ToString());

                lblTotalValue.Text = total.ToString();
            }
            txtProduct.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";

            MessageBox.Show("Sales Data Added Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                total = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString()));
                foreach(DataRow dr1 in dt.Rows)
                {
                    total = total + Convert.ToInt32(dr1["Total"].ToString());
                    lblTotalValue.Text = total.ToString();
    
                }
                MessageBox.Show("Sales Data Deleted Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = new SqlCommand("insert into Order_User (FirstName,LastName,BillType,PurchaseDate) VALUES (@FirstName,@LastName,@BillType,@PurchaseDate)", con);
            cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd1.Parameters.AddWithValue("@BillType", Bill_TypecomboBox.Text);
            cmd1.Parameters.AddWithValue("@PurchaseDate", BilldateTimePicker.Value);
            cmd1.ExecuteNonQuery();



            SqlCommand cmd2 = new SqlCommand("select top 1 Id from Order_User order by id desc ", con);
            orderid = cmd2.ExecuteScalar().ToString();
            //DataSet ds2 = new DataSet();
            //SqlDataAdapter adapt2 = new SqlDataAdapter(cmd2);
            //adapt2.Fill(ds2);
            //foreach (DataRow dr2 in ds2.Tables[0].Rows)
            //{
            //    orderid = dr2["Id"].ToString();
            //    //MessageBox.Show(orderid);
            //}


            foreach(DataRow dr in dt.Rows)
            {
                SqlCommand cmd3 = new SqlCommand("insert into Order_Item2 (OrderId,Product,Price,Qty,Total) VALUES (@OrderId,@Product,@Price,@Qty,@Total)", con);
                cmd3.Parameters.AddWithValue("@OrderId",orderid);
                cmd3.Parameters.AddWithValue("@Product", dr["Product"].ToString());
                cmd3.Parameters.AddWithValue("@Price", dr["Price"].ToString());
                cmd3.Parameters.AddWithValue("@Qty", dr["Quantity"].ToString());
                cmd3.Parameters.AddWithValue("@Total", dr["Total"].ToString());
                cmd3.ExecuteNonQuery();

                //Above Code Is to Update The Stock Quantity
                int qty = 0;
                string pname = "";
                qty = Convert.ToInt32(dr["Quantity"].ToString());
                pname = dr["Product"].ToString();
                SqlCommand cmd4 = new SqlCommand(" update Stock set ProductQty = ProductQty-@ProductQty where ProductName = @ProductName", con);
                cmd4.Parameters.AddWithValue("@ProductName", pname.ToString());
                cmd4.Parameters.AddWithValue("@ProductQty", qty);                
                cmd4.ExecuteNonQuery();

            }

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtProduct.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
            lblTotalValue.Text = "";

            MessageBox.Show("Record Saved Successfully");
        }
    }
}
