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

namespace tthk_products_db
{
    public partial class TootedForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\products.mdf; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private int id = 0;
        private TextBox[] textBoxes;
        public TootedForm()
        {
            InitializeComponent();
            textBoxes = new TextBox[] {titleTextBox, amountTextBox, priceTextBox};
            DisplayData();
            ClearData();
        }

        private void DisplayData()
        {
            connection.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM products;", connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private bool ValidateTextBoxes()
        {
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void ClearData()
        {
            id = 0;
            foreach (var textBox in textBoxes)
            {
                textBox.Text = "";
            }
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO products(title, amount, price) VALUES (@title, @amount, @price);", connection);
                command.Parameters.AddWithValue("@title", titleTextBox.Text);
                command.Parameters.AddWithValue("@amount", amountTextBox.Text);
                command.Parameters.AddWithValue("price", priceTextBox.Text);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on lisatud");
            }
            else
            {
                MessageBox.Show("Viga!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes() && id != 0)
            {
                connection.Open();
                command = new SqlCommand("UPDATE products SET title=@title, amount=@amount, price=@price WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", titleTextBox.Text);
                command.Parameters.AddWithValue("@amount", amountTextBox.Text);
                command.Parameters.AddWithValue("@price", priceTextBox.Text);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                titleTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                amountTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                priceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (FormatException exception)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
