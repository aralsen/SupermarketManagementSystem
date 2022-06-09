using SuperMarketManagementSystem.Models;
using SuperMarketManagementSystem.SQLProcedures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        private ProductProcedures ProductSqlProcedure = new ProductProcedures();
        private CategoryProcedures CategorySqlProcedure = new CategoryProcedures();
        private BillProcedures BillSqlProcedure = new BillProcedures();

        private void SellingForm_Load(object sender, EventArgs e)
        {
            SellingProductDataGridView.DataSource = ProductSqlProcedure.GetProductNamePriceQuantity();
            BillDataGridView.DataSource = BillSqlProcedure.GetAllBills();
            CategoryComboBox.ValueMember = "categoryName";
            CategoryComboBox.DataSource = CategorySqlProcedure.GetCategoryNames();
            SellerNameLabel.Text = LoginForm.sellerName;
        }

        private void SellingProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductNameTextBox.Text = SellingProductDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProductPriceTextBox.Text = SellingProductDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int GridTotal = 0, n = 0;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BillIDTextBox.Text == "")
            {
                MessageBox.Show("Missing bill ID");
            }
            else
            {
                try
                {
                    BillTable bill = new BillTable();
                    bill.billID = int.Parse(BillIDTextBox.Text);
                    bill.sellerName = SellerNameLabel.Text;
                    bill.billDate = DateLabel.Text;
                    bill.totalAmount = int.Parse(ResultLabel.Text);

                    BillSqlProcedure.AddBill(bill);
                    MessageBox.Show("Order added successfully");
                    OrderDataGridView.Rows.Clear();
                    GridTotal = 0;
                    ResultLabel.Text = "" + 0;
                    SellingForm_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RODOSTO SUPERMARKET", new Font("Centry Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            
            e.Graphics.DrawString("Bill ID: " + BillDataGridView.SelectedRows[0].Cells[0].Value.ToString(), 
                                    new Font("Centry Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));

            e.Graphics.DrawString("Seller Name: " + SellerNameLabel.Text,
                                    new Font("Centry Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));

            e.Graphics.DrawString("Date: " + BillDataGridView.SelectedRows[0].Cells[2].Value.ToString(),
                                    new Font("Centry Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));

            e.Graphics.DrawString("Total Amount: " + BillDataGridView.SelectedRows[0].Cells[3].Value.ToString(),
                                    new Font("Centry Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
        }

        private void CategoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String category = CategoryComboBox.SelectedItem.ToString();
            SellingProductDataGridView.DataSource = ProductSqlProcedure.GetProductNamePriceQuantityByCategory(category);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SellingProductDataGridView.DataSource = ProductSqlProcedure.GetProductNamePriceQuantity();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(BillDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                BillSqlProcedure.DeleteBill(id);
                MessageBox.Show("Bill deleted successfully");
                SellingForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellingForm_Paint(object sender, PaintEventArgs e)
        {
            DateLabel.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" +
                DateTime.Today.Year.ToString();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (ProductNameTextBox.Text == "" || ProductQuantityTextBox.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                if (int.Parse(ProductQuantityTextBox.Text) > int.Parse(SellingProductDataGridView.SelectedRows[0].Cells[2].Value.ToString()))
                {
                    MessageBox.Show("There is not enough quantity of selected product. For now, please ask less quantity!");
                }
                else
                {
                    int total = int.Parse(ProductPriceTextBox.Text) * int.Parse(ProductQuantityTextBox.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(OrderDataGridView);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = ProductNameTextBox.Text;
                    newRow.Cells[2].Value = ProductPriceTextBox.Text;
                    newRow.Cells[3].Value = ProductQuantityTextBox.Text;
                    newRow.Cells[4].Value = int.Parse(ProductPriceTextBox.Text) * int.Parse(ProductQuantityTextBox.Text);
                    OrderDataGridView.Rows.Add(newRow);
                    GridTotal = GridTotal + total;
                    ResultLabel.Text = "" + GridTotal;
                    n++;
                    SellingForm_Load(sender, e);
                }
            }
        }
    }
}
