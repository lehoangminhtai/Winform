using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class _21110635_ProductDetails : Form
    {
        SqlConnection sqlconProductDetails;
        SqlCommand sqlcomProductDetails;
        SqlDataReader sqldreaderProductDetails;
        int rowNumber;
        string operation;
        string record;
        string connectionString;

        public _21110635_ProductDetails()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Motor;Integrated Security=True";
            sqlconProductDetails = new SqlConnection(connectionString);
            sqlcomProductDetails = new SqlCommand();
        }

        private void _21110635_ProductDetails_Load(object sender, EventArgs e)
        {
            try
            {
                ClearControls();
                if (sqlconProductDetails.State == ConnectionState.Open)
                    sqlconProductDetails.Close();
                sqlconProductDetails.Open();
                sqlcomProductDetails.CommandText = "SELECT * FROM ProductDetails";
                sqlcomProductDetails.Connection = sqlconProductDetails;
                sqldreaderProductDetails = sqlcomProductDetails.ExecuteReader();
                if (sqldreaderProductDetails.HasRows)
                {
                    sqldreaderProductDetails.Read();
                    DisplayResults();
                    if (sqldreaderProductDetails.Read())
                    {
                        btnNext.Enabled = true;
                        btnLast.Enabled = true;
                        rowNumber = rowNumber + 1;
                        btnPrevious_Click(null, null);
                    }
                    else
                    {
                        btnNext.Enabled = false;
                        btnLast.Enabled = false;
                        btnFirst.Enabled = false;
                        btnPrevious.Enabled = false;
                    }
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                    DisableButtons();

                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnAddNew.Enabled = true;
            }
            catch (SqlException sqlexcProductDetails)
            {
                MessageBox.Show("Problem while connecting to database.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlconProductDetails.Close();
            }

        }
        // Displays the record
        void DisplayResults()
        {
            txtModel.Text = sqldreaderProductDetails.GetString(0);
            txtManufacturer.Text = sqldreaderProductDetails.GetString(1);
            txtBuiltYear.Text = sqldreaderProductDetails.GetInt32(2).ToString();
            txtVIN.Text = sqldreaderProductDetails.GetString(3);
            txtCylinders.Text = sqldreaderProductDetails.GetInt32(4).ToString();
            txtColor.Text = sqldreaderProductDetails.GetString(5);
            txtEngineNumber.Text = sqldreaderProductDetails.GetInt32(6).ToString();
            txtPrice.Text = sqldreaderProductDetails.GetInt32(7).ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            operation = "addnew";
            DisableButtons();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtModel.Focus();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (sqldreaderProductDetails.Read())
            {
                rowNumber = rowNumber + 1;
                DisplayResults();
            }
            else
            {
                MessageBox.Show("This is the last record.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int currentRowNumber = 0;
            if (!sqldreaderProductDetails.IsClosed)
                sqldreaderProductDetails.Close();
            sqldreaderProductDetails = sqlcomProductDetails.ExecuteReader();
            if (rowNumber != 0)
            {
                while (currentRowNumber < rowNumber)
                {
                    currentRowNumber = currentRowNumber + 1;
                    sqldreaderProductDetails.Read();
                }
                DisplayResults();
                rowNumber = rowNumber - 1;
            }
            else
            {
                MessageBox.Show("This is the first record.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqldreaderProductDetails.Read();
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
            }
            btnNext.Enabled = true;
            btnLast.Enabled = true;

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            while (sqldreaderProductDetails.Read())
            {
                rowNumber = rowNumber + 1;
                DisplayResults();
            }
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (!sqldreaderProductDetails.IsClosed)
                sqldreaderProductDetails.Close();
            sqldreaderProductDetails = sqlcomProductDetails.ExecuteReader();
            if (rowNumber != 0)
            {
                sqldreaderProductDetails.Read();
                DisplayResults();
                rowNumber = 0;
            }
            else
            {
                MessageBox.Show("This is the first record.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqldreaderProductDetails.Read();
            }
            btnPrevious.Enabled = false;
            btnFirst.Enabled = false;
            btnNext.Enabled = true;
            btnLast.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string addNewString = "";
            int index = 0;
            if (txtModel.Text == "")
            {
                MessageBox.Show("Please enter the model.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtModel.Focus();
                return;
            }
            else if (txtManufacturer.Text == "")
            {
                MessageBox.Show("Please enter the manufacturer.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManufacturer.Focus();
                return;
            }
            else if (txtBuiltYear.Text == "")
            {
                MessageBox.Show("Please enter the built year.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuiltYear.Focus();
                return;
            }
            else if (txtVIN.Text == "")
            {
                MessageBox.Show("Please enter the Vehicle Identity Number.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVIN.Focus();
                return;
            }
            else if (txtCylinders.Text == "")
            {
                MessageBox.Show("Please enter the number of cylinders.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCylinders.Focus();
                return;
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Please enter the color.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtColor.Focus();
                return;
            }
            else if (txtEngineNumber.Text == "")
            {
                MessageBox.Show("Please enter the engine number.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEngineNumber.Focus();
                return;
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter the price.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Focus();
                return;
            }

            if (txtBuiltYear.Text != "")
            {
                try
                {
                    index = Convert.ToInt32(txtBuiltYear.Text);
                    if (index < 0)
                    {
                        MessageBox.Show("Please enter a positive value for the year.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBuiltYear.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a numeric value for the year.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuiltYear.Focus();
                    return;
                }
            }
            if (txtCylinders.Text != "")
            {
                try
                {
                    index = Convert.ToInt32(txtCylinders.Text);
                    if (index < 0)
                    {
                        MessageBox.Show("Please enter a positive value for cylinders.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCylinders.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a numeric value for cylinders.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCylinders.Focus();
                    return;
                }
            }
            if (txtEngineNumber.Text != "")
            {
                try
                {
                    index = Convert.ToInt32(txtEngineNumber.Text);
                    if (index < 0)
                    {
                        MessageBox.Show("Please enter a positive value for engine number.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEngineNumber.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a numeric value for engine number.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEngineNumber.Focus();
                    return;
                }
            }
            if (txtPrice.Text != "")
            {
                try
                {
                    index = Convert.ToInt32(txtPrice.Text);
                    if (index < 0)
                    {
                        MessageBox.Show("Please enter a positive value for price.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPrice.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a numeric value for price.", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Focus();
                    return;
                }
            }

            if (operation == "addnew")
                addNewString = "INSERT INTO ProductDetails VALUES ('" + txtModel.Text + "','" + txtManufacturer.Text + "'," + txtBuiltYear.Text + ",'" + txtVIN.Text + "'," + txtCylinders.Text + ",'" + txtColor.Text + "'," + txtEngineNumber.Text + "," + txtPrice.Text + ")";
            else if (operation == "edit")
                addNewString = "UPDATE ProductDetails SET Manufacturers='" + txtManufacturer.Text + "',BuiltYear=" + txtBuiltYear.Text + ",VIN='" + txtVIN.Text + "',Cylinders=" + txtCylinders.Text + ",Color='" + txtColor.Text + "',EngineNumber=" + txtEngineNumber.Text + ",Price=" + txtPrice.Text + " WHERE Model='" + txtModel.Text + "'";

            if (operation != "")
            {

                if (!sqldreaderProductDetails.IsClosed)
                    sqldreaderProductDetails.Close();
                sqlcomProductDetails.CommandText = addNewString;
                sqlcomProductDetails.Connection = sqlconProductDetails;
                record = "Model: " + txtModel.Text + "\nManufacturer: " + txtManufacturer.Text + "\nBuiltYear: " + txtBuiltYear.Text + "\nVIN: " + txtVIN.Text + "\nCylinders: " + txtCylinders.Text + "\nColor: " + txtColor.Text + "\nEngine Number: " + txtEngineNumber.Text + "\nPrice: " + txtPrice.Text ;
                sqlcomProductDetails.ExecuteNonQuery();
                MessageBox.Show("The following details have been saved successfully.\n" + record, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _21110635_ProductDetails_Load(null, null);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DisableButtons();
            operation = "edit";
            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            operation = "";
            _21110635_ProductDetails_Load(null, null);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = "Model: " + txtModel.Text + "\nManufacturer: " + txtManufacturer.Text + "\nBuiltYear: " + txtBuiltYear.Text + "\nVIN: " + txtVIN.Text + "\nCylinders: " + txtCylinders.Text + "\nColor: " + txtColor.Text + "\nEngineNumber: " + txtEngineNumber.Text + "\nPrice: " + txtPrice.Text;
            if (!sqldreaderProductDetails.IsClosed)
                sqldreaderProductDetails.Close();
            sqlcomProductDetails.CommandText = "DELETE FROM ProductDetails WHERE Model='" + txtModel.Text + "'";
            if (sqlconProductDetails.State == ConnectionState.Open)
                sqlconProductDetails.Close();
            sqlconProductDetails.Open();
            sqlcomProductDetails.ExecuteNonQuery();
            sqlconProductDetails.Close();
            MessageBox.Show("The record has been deleted successfully.\n" + record, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _21110635_ProductDetails_Load(null, null);

        }

        // Clears the controls
        void ClearControls()
        {
            txtModel.Text = "";
            txtManufacturer.Text = "";
            txtBuiltYear.Text = "";
            txtVIN.Text = "";
            txtCylinders.Text = "";
            txtColor.Text = "";
            txtEngineNumber.Text = "";
            txtPrice.Text = "";
        }

        // Disables the buttons
        void DisableButtons()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnCancel.Enabled = false;
            btnAddNew.Enabled = false;
        }

    }
}
