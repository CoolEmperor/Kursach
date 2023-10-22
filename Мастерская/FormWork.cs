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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастерская
{
    public partial class FormWork : Form
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True";

        public FormWork()
        {
            InitializeComponent();
        }

        private void FormWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Тип_поломки". При необходимости она может быть перемещена или удалена.
            this.тип_поломкиTableAdapter.Fill(this.мастерскаяDataSet.Тип_поломки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.мастерскаяDataSet.Работа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Заказ_на_диагностику". При необходимости она может быть перемещена или удалена.
            this.заказ_на_диагностикуTableAdapter.Fill(this.мастерскаяDataSet.Заказ_на_диагностику);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView2.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
        }

        private void FillDataGridView()
        {
            string zakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string query = $"SELECT * FROM Работа WHERE ИдЗаявки = {zakaz}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
            }
        }

        private void ClearInputFields()
        {
            названиеTextBox.Clear();
            стоимостьTextBox.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(названиеTextBox.Text) || string.IsNullOrWhiteSpace(стоимостьTextBox.Text)
                || string.IsNullOrWhiteSpace(comboBox3.Text) /*|| string.IsNullOrWhiteSpace(comboBox4.Text)*/)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = названиеTextBox.Text;
            string cost = стоимостьTextBox.Text;
            string polomka = comboBox3.SelectedValue.ToString();
            string zakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("InsertWork", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Название", name);
                    command.Parameters.AddWithValue("@Стоимость", cost);
                    command.Parameters.AddWithValue("@ИдПоломки", polomka);
                    command.Parameters.AddWithValue("@ИдЗаявки", zakaz);

                    command.ExecuteNonQuery();
                }

                ClearInputFields();
                FillDataGridView();
                MessageBox.Show("Данные добавлены успешно.");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = названиеTextBox.Text;
            string cost = стоимостьTextBox.Text;
            string polomka = comboBox3.SelectedValue.ToString();
            string zakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            int selectedRowId = (int)dataGridView2.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateWork", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдРаботы", selectedRowId);
                    command.Parameters.AddWithValue("@Название", name);
                    command.Parameters.AddWithValue("@Стоимость", cost);
                    command.Parameters.AddWithValue("@ИдПоломки", polomka);
                    command.Parameters.AddWithValue("@ИдЗаявки", zakaz);

                    command.ExecuteNonQuery();
                }

                ClearInputFields();
                FillDataGridView();
                MessageBox.Show("Данные изменены успешно.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = (int)dataGridView2.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DeleteWork", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдРаботы", selectedEmployeeId);

                    command.ExecuteNonQuery();
                }

                FillDataGridView();
                MessageBox.Show("Данные удалены успешно.");
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFind.Text;

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                fKРаботаИдЗаявки3B75D760BindingSource.Filter = $"Название LIKE '{filterText}%'";
            }
            else
            {
                fKРаботаИдЗаявки3B75D760BindingSource.RemoveFilter();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DataRowView selectedRow = (DataRowView)comboBoxFType.SelectedItem;
                int selectedValue = (int)selectedRow["ИдПоломки"];
                fKРаботаИдЗаявки3B75D760BindingSource.Filter = string.Format("ИдПоломки = {0}", selectedValue);
            }
            else if (checkBox1.Checked == false)
            {
                fKРаботаИдЗаявки3B75D760BindingSource.RemoveFilter();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string filterText = textBoxF2.Text;

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                if (decimal.TryParse(filterText, out decimal filterValue))
                {
                    fKРаботаИдЗаявки3B75D760BindingSource.Filter = $"Стоимость = {filterValue}";
                }
                else
                {
                    MessageBox.Show("Введите корректное числовое значение.");
                }
            }
            else
            {
                fKРаботаИдЗаявки3B75D760BindingSource.RemoveFilter();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string sortOrder = "";
            string sortOrder1 = comboBox2.Text;
            switch (sortOrder1)
            {
                case "Возрастание":
                    sortOrder = "ASC";
                    break;
                case "Убывание":
                    sortOrder = "DESC";
                    break;
            }

            string sortField = comboBox1.Text;
            string zakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SortWorkByField", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдЗаявки", zakaz);
                    command.Parameters.AddWithValue("@SortField", sortField);
                    command.Parameters.AddWithValue("@SortOrder", sortOrder);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;
                }

                MessageBox.Show("Данные отсортированы успешно.");
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEmployeeId;
            if (dataGridView2.SelectedRows.Count > 0)
            {
                selectedEmployeeId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                названиеTextBox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                стоимостьTextBox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                comboBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                //comboBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
