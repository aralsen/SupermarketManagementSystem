using SuperMarketManagementSystem.Models;
using SuperMarketManagementSystem.SQLProcedures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private ManagerProcedure ManagerSqlProcedure = new ManagerProcedure();

        private void ClearTextBoxes()
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            PhoneTextBox.Text = "";
            PasswordTextBox.Text = "";
            AddressTextBox.Text = "";
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

        private void SellersButton_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            ManagerDataGridView.DataSource = ManagerSqlProcedure.DisplayAllManagers();
            ClearTextBoxes();
        }

        private void ManagerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTextBox.Text = ManagerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            NameTextBox.Text = ManagerDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            AgeTextBox.Text = ManagerDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTextBox.Text = ManagerDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTextBox.Text = ManagerDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            AddressTextBox.Text = ManagerDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                ManagerTable manager = new ManagerTable();
                manager.managerID = int.Parse(IDTextBox.Text);
                manager.managerName = NameTextBox.Text;
                manager.managerAge = int.Parse(AgeTextBox.Text);
                manager.managerPhone = PhoneTextBox.Text;
                manager.managerPassword = PasswordTextBox.Text;
                manager.managerAddress = AddressTextBox.Text;

                ManagerSqlProcedure.AddManger(manager);
                MessageBox.Show("Manager added successfully");
                ManagerForm_Load(sender, e);
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
                if (IDTextBox.Text == "" || NameTextBox.Text == "" || AgeTextBox.Text == "" ||
                    PhoneTextBox.Text == "" || PasswordTextBox.Text == "")
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    ManagerTable manager = new ManagerTable();
                    manager.managerID = int.Parse(IDTextBox.Text);
                    manager.managerName = NameTextBox.Text;
                    manager.managerAge = int.Parse(AgeTextBox.Text);
                    manager.managerPhone = PhoneTextBox.Text;
                    manager.managerPassword = PasswordTextBox.Text;
                    manager.managerAddress = AddressTextBox.Text;

                    ManagerSqlProcedure.UpdateManager(manager);
                    MessageBox.Show("Manager successfully updated");
                    ManagerForm_Load(sender, e);
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
                if (IDTextBox.Text == "")
                {
                    MessageBox.Show("Select Manager to delete!");
                }
                else
                {
                    ManagerSqlProcedure.DeleteManger(int.Parse(IDTextBox.Text));
                    MessageBox.Show("Manager deleted successfully!");
                    ManagerForm_Load(sender, e);
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
    }
}
