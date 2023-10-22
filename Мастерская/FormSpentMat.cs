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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастерская
{
    public partial class FormSpentMat : Form
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True";

        public FormSpentMat()
        {
            InitializeComponent();
        }

        private void FormSpentMat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.мастерскаяDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Вид_техники". При необходимости она может быть перемещена или удалена.
            this.вид_техникиTableAdapter.Fill(this.мастерскаяDataSet.Вид_техники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Затраченный_материал". При необходимости она может быть перемещена или удалена.
            this.затраченный_материалTableAdapter.Fill(this.мастерскаяDataSet.Затраченный_материал);
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
            string query = $"SELECT * FROM [Затраченный_материал] WHERE ИдЗаявки = {zakaz}";
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
            if (string.IsNullOrWhiteSpace(названиеTextBox.Text) || string.IsNullOrWhiteSpace(стоимостьTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = названиеTextBox.Text;
            string cost = стоимостьTextBox.Text;
            string zakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [Затраченный_материал] (Название, Стоимость, ИдЗаявки) VALUES (@Название, @Стоимость, @ИдЗаявки)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Название", name);
                    command.Parameters.AddWithValue("@Стоимость", cost);
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
            string zakaz = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            int selectedRowId = (int)dataGridView2.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE [Затраченный_материал] SET Название = @Название, Стоимость = @Стоимость, ИдЗаявки = @ИдЗаявки WHERE ИдМатериала = @ИдМатериала";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ИдМатериала", selectedRowId);

                    command.Parameters.AddWithValue("@Название", name);
                    command.Parameters.AddWithValue("@Стоимость", cost);
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

                string query = "DELETE FROM [Затраченный_материал] WHERE ИдМатериала = @ИдМатериала";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ИдМатериала", selectedEmployeeId);
                    command.ExecuteNonQuery();
                }

                FillDataGridView();
            }

            MessageBox.Show("Данные удалены успешно.");
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFind.Text;

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                fKЗатраченнИдЗая48CFD27EBindingSource.Filter = $"Название LIKE '{filterText}%'";
            }
            else
            {
                fKЗатраченнИдЗая48CFD27EBindingSource.RemoveFilter();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string filterText = textBoxF2.Text;

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                if (decimal.TryParse(filterText, out decimal filterValue))
                {
                    fKЗатраченнИдЗая48CFD27EBindingSource.Filter = $"Стоимость = {filterValue}";
                }
                else
                {
                    MessageBox.Show("Введите корректное числовое значение.");
                }
            }
            else
            {
                fKЗатраченнИдЗая48CFD27EBindingSource.RemoveFilter();
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

                string query = $"SELECT * FROM [Затраченный_материал] WHERE ИдМатериала = @ИдМатериала ORDER BY {sortField} {sortOrder}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ИдМатериала", zakaz);

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
            }
        }
    }
}
