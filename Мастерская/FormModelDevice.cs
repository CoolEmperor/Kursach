using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мастерская
{
    public partial class FormModelDevice : Form
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True";
        public FormModelDevice()
        {
            InitializeComponent();
        }

        private void FormModelDevice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Модель". При необходимости она может быть перемещена или удалена.
            this.модельTableAdapter.Fill(this.мастерскаяDataSet.Модель);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;

        }

        private void FillDataGridView()
        {
            string query = "SELECT * FROM Модель";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void ClearInputFields()
        {
            названиеTextBox.Clear();
            дата_выпускаDateTimePicker.Value = DateTime.Now;
            описаниеTextBox.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(названиеTextBox.Text) || string.IsNullOrWhiteSpace(описаниеTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = названиеTextBox.Text;
            string desc = описаниеTextBox.Text;
            string date = дата_выпускаDateTimePicker.Value.ToString();

            if (!IsValidName(name) || !IsValidName(desc))
            {
                MessageBox.Show("Название и описание должны начинаться с большой буквы и быть на русском языке.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("InsertModel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Название", name);
                    command.Parameters.AddWithValue("@Дата", date);
                    command.Parameters.AddWithValue("@Описание", desc);

                    command.ExecuteNonQuery();
                }

                ClearInputFields();
                FillDataGridView();
                MessageBox.Show("Данные добавлены успешно.");
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(названиеTextBox.Text) || string.IsNullOrWhiteSpace(описаниеTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = названиеTextBox.Text;
            string desc = описаниеTextBox.Text;
            string date = дата_выпускаDateTimePicker.Value.ToString();

            if (!IsValidName(name) || !IsValidName(desc))
            {
                MessageBox.Show("Название и описание должны начинаться с большой буквы и быть на русском языке.");
                return;
            }

            int selectedRowId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateModel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдМодели", selectedRowId);
                    command.Parameters.AddWithValue("@Название", name);
                    command.Parameters.AddWithValue("@Дата", date);
                    command.Parameters.AddWithValue("@Описание", desc);

                    command.ExecuteNonQuery();
                }

                ClearInputFields();
                FillDataGridView();
                MessageBox.Show("Данные изменены успешно.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DeleteModel", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдМодели", selectedEmployeeId);

                    command.ExecuteNonQuery();
                }

                FillDataGridView();
            }

            MessageBox.Show("Данные удалены успешно.");
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFind.Text;
            string findField = comboBoxFind.Text;

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                модельBindingSource.Filter = $"{findField} LIKE '{filterText}%'";
            }
            else
            {
                модельBindingSource.RemoveFilter();
            }
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^[А-Я][а-я]+$";
            return Regex.IsMatch(name, pattern);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string sortOrder = comboBox2.Text;
            switch (sortOrder)
            {
                case "Возрастание":
                    sortOrder = "ASC";
                    break;
                case "Убывание":
                    sortOrder = "DESC";
                    break;
            }
            string sortField = comboBox1.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SortModels", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SortField", sortField);
                    command.Parameters.AddWithValue("@SortOrder", sortOrder);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                MessageBox.Show("Данные отсортированы успешно.");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEmployeeId;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedEmployeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                названиеTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                описаниеTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string dateValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (DateTime.TryParse(dateValue, out DateTime result))
                {
                    дата_выпускаDateTimePicker.Value = result.Date;
                }
                else
                {
                    MessageBox.Show("Неверный формат даты.");
                }

            }
        }
    }
}
