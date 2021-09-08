using SuperMarketManagementSystem.SQLProcedures;
using System;
using System.Windows.Forms;
using SuperMarketManagementSystem.Models;

namespace SuperMarketManagementSystem
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            ProductIDTextBox.Text = "";
            ProductNameTextBox.Text = "";
            ProductQuantityTextBox.Text = "";
            ProductPriceTextBox.Text = "";
        }

        private CategoryProcedures CategorySqlProcedure = new CategoryProcedures();
        private ProductProcedures ProductSqlProcedure = new ProductProcedures();

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            CategoryComboBox1.ValueMember = "categoryName";
            CategoryComboBox1.DataSource = CategorySqlProcedure.GetCategoryNames();
            CategoryComboBox2.ValueMember = "categoryName";
            CategoryComboBox2.DataSource = CategorySqlProcedure.GetCategoryNames();
            ProductDataGridView.DataSource = ProductSqlProcedure.GetAllProducts();

            ClearTextBoxes();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProductTable product = new ProductTable();
                product.productID = int.Parse(ProductIDTextBox.Text);
                product.productName = ProductNameTextBox.Text;
                product.productCategory = CategoryComboBox1.SelectedValue.ToString();
                product.productQuantity = int.Parse(ProductQuantityTextBox.Text);
                product.productPrice = int.Parse(ProductPriceTextBox.Text);

                ProductSqlProcedure.AddProduct(product);
                MessageBox.Show("Product added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductIDTextBox.Text = ProductDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProductNameTextBox.Text = ProductDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantityTextBox.Text = ProductDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ProductPriceTextBox.Text = ProductDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            CategoryComboBox1.SelectedValue = ProductDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductIDTextBox.Text == "")
                {
                    MessageBox.Show("Select a Product to delete");
                }
                else
                {
                    ProductSqlProcedure.DeleteProduct(int.Parse(ProductIDTextBox.Text));
                    MessageBox.Show("Product deleted successfully");
                    ProductForm_Load(sender, e);
                }
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
                if (ProductIDTextBox.Text == "" || ProductNameTextBox.Text == "" || ProductQuantityTextBox.Text == "" ||
                    ProductPriceTextBox.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    ProductTable product = new ProductTable();
                    product.productID = int.Parse(ProductIDTextBox.Text);
                    product.productName = ProductNameTextBox.Text;
                    product.productQuantity = int.Parse(ProductQuantityTextBox.Text);
                    product.productPrice = int.Parse(ProductPriceTextBox.Text);
                    product.productCategory = CategoryComboBox1.SelectedValue.ToString();

                    ProductSqlProcedure.UpdateProduct(product);
                    MessageBox.Show("Product successfully updated");
                    ProductForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ProductDataGridView.DataSource = ProductSqlProcedure.GetAllProducts();
        }

        private void SellersButton_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void ClearPropertiesButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void CategoryComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String category = CategoryComboBox2.SelectedValue.ToString();
            ProductDataGridView.DataSource = ProductSqlProcedure.GetProductsByCategory(category);
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
