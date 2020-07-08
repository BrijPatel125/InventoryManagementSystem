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
    public partial class PurchaseMaster : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""D:\Marwadi\6th Sem\NET\Assignment\Inventory Management System\WindowsFormsApplication1\WindowsFormsApplication1\inventory.mdf"";Integrated Security=True");
        public PurchaseMaster()
        {
            InitializeComponent();
        }

        private void lblExpiryDate_Click(object sender, EventArgs e)
        {

        }

        private void lblPurchaseType_Click(object sender, EventArgs e)
        {

        }

        private void lblDealerName_Click(object sender, EventArgs e)
        {

        }

        private void lblPurchaseDate_Click(object sender, EventArgs e)
        {

        }

        private void lblProductTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblProductPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblProductQty_Click(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblProfit_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseMaster_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            Fill_ProductName();
            Fill_DealerName();
        }
        public void Fill_ProductName()
        {
            SqlCommand cmd = new SqlCommand("Select * from ProductName", con);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                Product_NamecomboBox.Items.Add(dr["ProductName"].ToString());
            }
        }
        private void Product_NamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from ProductName where ProductName = @ProductName", con);
            cmd.Parameters.AddWithValue("@ProductName", Product_NamecomboBox.Text);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                lblUnit.Text = dr["Unit"].ToString();
            }
        }

        public void Fill_DealerName()
        {
            SqlCommand cmd = new SqlCommand("Select * from DealerInfo", con);
            cmd.ExecuteNonQuery();
            DataTable ds = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            adapt.Fill(ds);
            foreach (DataRow dr in ds.Rows)
            {
                Dealer_NamecomboBox.Items.Add(dr["DealerName"].ToString());
            }
        }

        private void txtProductPrice_Leave(object sender, EventArgs e)
        {
            txtProductTotal.Text = Convert.ToString(Convert.ToInt32(txtProductQty.Text) * Convert.ToInt32(txtProductPrice.Text));
        }

        private void btnPurchaseItem_Click(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("Select * from Stock where ProductName = @ProductName", con);
            cmd1.Parameters.AddWithValue("@ProductName", Product_NamecomboBox.Text);
            cmd1.ExecuteNonQuery();
            DataTable ds1 = new DataTable();
            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
            //DataSet ds = new DataSet();
            adapt1.Fill(ds1);
            int count = Convert.ToInt32(ds1.Rows.Count.ToString());
            if(count == 0)
            {
                SqlCommand cmd2 = new SqlCommand("insert into PurchaseMaster (ProductName,ProductQty,ProductUnit,ProductPrice,ProductTotal,PurchaseDate,PurchasePartyName,PurchaseType,ExpiryDate,Profit) VALUES(@ProductName,@ProductQty,@ProductUnit,@ProductPrice,@ProductTotal,@PurchaseDate,@PurchasePartyName,@PurchaseType,@ExpiryDate,@Profit)", con);
                cmd2.Parameters.AddWithValue("@ProductName", Product_NamecomboBox.Text);
                cmd2.Parameters.AddWithValue("@ProductQty", txtProductQty.Text);
                cmd2.Parameters.AddWithValue("@ProductUnit", lblUnit.Text);
                cmd2.Parameters.AddWithValue("@ProductPrice", txtProductPrice.Text);
                cmd2.Parameters.AddWithValue("@ProductTotal", txtProductTotal.Text);
                cmd2.Parameters.AddWithValue("@PurchaseDate", PurchasedateTimePicker.Value);
                cmd2.Parameters.AddWithValue("@PurchasePartyName", Dealer_NamecomboBox.Text);
                cmd2.Parameters.AddWithValue("@PurchaseType", Purchase_TypecomboBox.Text);
                cmd2.Parameters.AddWithValue("@ExpiryDate", ExpirydateTimePicker.Value);
                cmd2.Parameters.AddWithValue("@Profit", txtProfit.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Purchase Item Added Succesfully");

                SqlCommand cmd3 = new SqlCommand("insert into Stock (ProductName,ProductQty,ProductUnit) VALUES(@ProductName,@ProductQty,@ProductUnit)", con);
                cmd3.Parameters.AddWithValue("@ProductName", Product_NamecomboBox.Text);
                cmd3.Parameters.AddWithValue("@ProductQty", txtProductQty.Text);
                cmd3.Parameters.AddWithValue("@ProductUnit", lblUnit.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Purchase Item Added To Stock Succesfully");
            
            
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand("insert into PurchaseMaster (ProductName,ProductQty,ProductUnit,ProductPrice,ProductTotal,PurchaseDate,PurchasePartyName,PurchaseType,ExpiryDate,Profit) VALUES(@ProductName,@ProductQty,@ProductUnit,@ProductPrice,@ProductTotal,@PurchaseDate,@PurchasePartyName,@PurchaseType,@ExpiryDate,@Profit)", con);
                cmd4.Parameters.AddWithValue("@ProductName", Product_NamecomboBox.Text);
                cmd4.Parameters.AddWithValue("@ProductQty", txtProductQty.Text);
                cmd4.Parameters.AddWithValue("@ProductUnit", lblUnit.Text);
                cmd4.Parameters.AddWithValue("@ProductPrice", txtProductPrice.Text);
                cmd4.Parameters.AddWithValue("@ProductTotal", txtProductTotal.Text);
                cmd4.Parameters.AddWithValue("@PurchaseDate", PurchasedateTimePicker.Value);
                cmd4.Parameters.AddWithValue("@PurchasePartyName", Dealer_NamecomboBox.Text);
                cmd4.Parameters.AddWithValue("@PurchaseType", Purchase_TypecomboBox.Text);
                cmd4.Parameters.AddWithValue("@ExpiryDate", ExpirydateTimePicker.Value);
                cmd4.Parameters.AddWithValue("@Profit", txtProfit.Text);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Purchase Item Added Succesfully");

                //for update
                SqlCommand cmd5 = new SqlCommand("update Stock set ProductQty = ProductQty + @ProductQty where ProductName = @ProductName", con);
                cmd5.Parameters.AddWithValue("@ProductName", Product_NamecomboBox.Text);
                cmd5.Parameters.AddWithValue("@ProductQty", txtProductQty.Text);
                cmd5.ExecuteNonQuery();
                //DisplayDealerData();
                MessageBox.Show("Stock Updated Succesfully");
            
            }


            
        }
    }
}
