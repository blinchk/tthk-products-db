using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace tthk_products_db
{
    public partial class TootedForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\products.mdf; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private NumericUpDown[] numericBoxes;
        private int id = 0;
        public TootedForm()
        {
            InitializeComponent();
            numericBoxes = new NumericUpDown[] { amountNumeric, priceNumeric };
            // We use different types of input boxes
            RequestCategories();
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

        private void RequestCategories()
        {
            connection.Open();
            command = new SqlCommand("SELECT title FROM categories;", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AddCategoryToCheckbox(reader, "title");
                }

                connection.Close();
            }
        }

        private void AddCategoryToCheckbox(SqlDataReader source, string name)
        {
            categoryCheckbox.Items.Add(source[name].ToString());
        }

        private bool ValidateTextBoxes()
        {
            if (titleTextBox.Text == "") return false;
            return true;
        }

        private void ClearData()
        {
            id = 0;
            titleTextBox.Text = "";
            foreach(var numeric in numericBoxes)
            {
                numeric.Value = 0;
            }
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO products(title, amount, price, imageSource) VALUES (@title, @amount, @price, @imageSource);", connection);
                command.Parameters.AddWithValue("@title", titleTextBox.Text);
                command.Parameters.AddWithValue("@amount", amountNumeric.Value);
                command.Parameters.AddWithValue("@price", priceNumeric.Value);
                command.Parameters.AddWithValue("@imageSource", pictureTextBox.Text);
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
                command = new SqlCommand("UPDATE products SET title=@title, amount=@amount, price=@price, imageSource=@imageSource WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@title", titleTextBox.Text);
                command.Parameters.AddWithValue("@amount", amountNumeric.Value);
                command.Parameters.AddWithValue("@price", priceNumeric.Value);
                command.Parameters.AddWithValue("@imageSource", pictureTextBox.Text);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                connection.Open();
                command = new SqlCommand("DELETE FROM products WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andmed on kustatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("DELETE FROM products;", connection);
            command.ExecuteNonQuery();
            connection.Close();
            DisplayData();
            ClearData();
            MessageBox.Show("Kõik andmed on kustatud");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                titleTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                amountNumeric.Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                priceNumeric.Value = Decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                pictureTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                var request = WebRequest.Create(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        productPictureBox.Image = Bitmap.FromStream(stream);
                    }
                }
            }
            catch (FormatException exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
