using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мастерская
{
    public partial class FormOrderDiagnostics : Form
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True";

        public FormOrderDiagnostics()
        {
            InitializeComponent();
        }

        private void FormOrderDiagnostics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.мастерскаяDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Вид_техники". При необходимости она может быть перемещена или удалена.
            this.вид_техникиTableAdapter.Fill(this.мастерскаяDataSet.Вид_техники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Заказ_на_диагностику". При необходимости она может быть перемещена или удалена.
            this.заказ_на_диагностикуTableAdapter.Fill(this.мастерскаяDataSet.Заказ_на_диагностику);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;

        }
        private void FillDataGridView()
        {
            string query = "SELECT * FROM [Заказ_на_диагностику]";
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
            дата_принятияDateTimePicker.Value = DateTime.Now;
            дата_выдачиDateTimePicker.Value = DateTime.Now;
            статусTextBox.Clear();
            КлиентTextBox.Clear();
            номер_телефонаTextBox.Clear();
        }

        private void buttonВид_Click(object sender, EventArgs e)
        {
            FormTypeTechnick form = new FormTypeTechnick();
            form.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(дата_принятияDateTimePicker.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
                || string.IsNullOrWhiteSpace(дата_выдачиDateTimePicker.Text) || string.IsNullOrWhiteSpace(статусTextBox.Text)
                || string.IsNullOrWhiteSpace(КлиентTextBox.Text) || string.IsNullOrWhiteSpace(СотрудникComboBox.Text)
                || string.IsNullOrWhiteSpace(номер_телефонаTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string dateacc = дата_принятияDateTimePicker.Value.ToString();
            string type = comboBox3.SelectedValue.ToString();
            string dateiss = дата_выдачиDateTimePicker.Value.ToString();
            string status = статусTextBox.Text;
            string work = СотрудникComboBox.SelectedValue.ToString();
            string client = КлиентTextBox.Text;
            string numtel = номер_телефонаTextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [Заказ_на_диагностику] (Дата_принятия, ИдВида, Дата_выдачи, Статус, ИдСотрудника, ФИО_Клиента, Номер_телефона) VALUES (@Дата_принятия, @ИдВида, @Дата_выдачи, @Статус, @ИдСотрудника, @ФИО_Клиента, @Номер_телефона)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Дата_принятия", dateacc);
                    command.Parameters.AddWithValue("@ИдВида", type);
                    command.Parameters.AddWithValue("@Дата_выдачи", dateiss);
                    command.Parameters.AddWithValue("@Статус", status);
                    command.Parameters.AddWithValue("@ИдСотрудника", work);
                    command.Parameters.AddWithValue("@ФИО_Клиента", client);
                    command.Parameters.AddWithValue("@Номер_телефона", numtel);

                    command.ExecuteNonQuery();
                }

                ClearInputFields();

                FillDataGridView();

                MessageBox.Show("Данные добавлены успешно.");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(дата_принятияDateTimePicker.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
                || string.IsNullOrWhiteSpace(дата_выдачиDateTimePicker.Text) || string.IsNullOrWhiteSpace(статусTextBox.Text)
                || string.IsNullOrWhiteSpace(КлиентTextBox.Text) || string.IsNullOrWhiteSpace(СотрудникComboBox.Text)
                || string.IsNullOrWhiteSpace(номер_телефонаTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string dateacc = дата_принятияDateTimePicker.Value.ToString();
            string type = comboBox3.SelectedValue.ToString();
            string dateiss = дата_выдачиDateTimePicker.Value.ToString();
            string status = статусTextBox.Text;
            string work = СотрудникComboBox.SelectedValue.ToString();
            string client = КлиентTextBox.Text;
            string numtel = номер_телефонаTextBox.Text;

            int selectedRowId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE [Заказ_на_диагностику] SET Дата_принятия = @Дата_принятия, ИдВида = @ИдВида, Дата_выдачи = @Дата_выдачи, Статус = @Статус, ИдСотрудника = @ИдСотрудника, ФИО_Клиента = @ФИО_Клиента, Номер_телефона = @Номер_телефона WHERE ИдЗаявки = @ИдЗаявки";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ИдЗаявки", selectedRowId);
                    command.Parameters.AddWithValue("@Дата_принятия", dateacc);
                    command.Parameters.AddWithValue("@ИдВида", type);
                    command.Parameters.AddWithValue("@Дата_выдачи", dateiss);
                    command.Parameters.AddWithValue("@Статус", status);
                    command.Parameters.AddWithValue("@ИдСотрудника", work);
                    command.Parameters.AddWithValue("@ФИО_Клиента", client);
                    command.Parameters.AddWithValue("@Номер_телефона", numtel);

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

                string query = "DELETE FROM [Заказ_на_диагностику] WHERE ИдЗаявки = @ИдЗаявки";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ИдЗаявки", selectedEmployeeId);
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
                заказнадиагностикуBindingSource.Filter = $"{findField} LIKE '{filterText}%'";
            }
            else
            {
                заказнадиагностикуBindingSource.RemoveFilter();
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM [Заказ_на_диагностику] ORDER BY {sortField} {sortOrder}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            MessageBox.Show("Данные отсортированы успешно.");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEmployeeId;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedEmployeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                дата_принятияDateTimePicker.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                дата_выдачиDateTimePicker.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                статусTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                СотрудникComboBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                КлиентTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                номер_телефонаTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
        }
    }
}
