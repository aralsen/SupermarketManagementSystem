using System;
using System.Windows.Forms;
using SuperMarketManagementSystem.Models;
using SuperMarketManagementSystem.SQLProcedures;

namespace SuperMarketManagementSystem
{
    public partial class SellerForm : Form
    {
        private SellerProcedures SellerSqlProcedures = new SellerProcedures();

        public SellerForm()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            SellerIDTextBox.Text = "";
            SellerNameTextBox.Text = "";
            SellerAgeTextBox.Text = "";
            SellerPhoneTextBox.Text = "";
            SellerPasswordTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            SellerDataGridView.DataSource = SellerSqlProcedures.GetAllSellers();
            ClearTextBoxes();
        }

        private void SellerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellerIDTextBox.Text = SellerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            SellerNameTextBox.Text = SellerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            SellerAgeTextBox.Text = SellerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhoneTextBox.Text = SellerDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            SellerPasswordTextBox.Text = SellerDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                SellerTable seller = new SellerTable();
                seller.sellerID = int.Parse(SellerIDTextBox.Text);
                seller.sellerName = SellerNameTextBox.Text;
                seller.sellerAge = int.Parse(SellerAgeTextBox.Text);
                seller.sellerPhone = SellerPhoneTextBox.Text;
                seller.sellerPassword = SellerPasswordTextBox.Text;

                SellerSqlProcedures.AddSeller(seller);
                MessageBox.Show("Seller added successfully");
                SellerForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerIDTextBox.Text == "" || SellerNameTextBox.Text == "" || SellerAgeTextBox.Text == ""
                    || SellerPhoneTextBox.Text == "" || SellerPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    SellerTable seller = new SellerTable();
                    seller.sellerID = int.Parse(SellerIDTextBox.Text);
                    seller.sellerName = SellerNameTextBox.Text;
                    seller.sellerAge = int.Parse(SellerAgeTextBox.Text);
                    seller.sellerPhone = SellerPhoneTextBox.Text;
                    seller.sellerPassword = SellerPasswordTextBox.Text;

                    SellerSqlProcedures.UpdateSeller(seller);
                    MessageBox.Show("Seller successfully updated");
                    SellerForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerIDTextBox.Text == "")
                {
                    MessageBox.Show("Select Seller to delete");
                }
                else
                {
                    SellerSqlProcedures.DeleteSeller(int.Parse(SellerIDTextBox.Text));
                    MessageBox.Show("Seller deleted successfully");
                    SellerForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearPropertiesButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void ManagersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm manager = new ManagerForm();
            manager.Show();
        }
    }
}
