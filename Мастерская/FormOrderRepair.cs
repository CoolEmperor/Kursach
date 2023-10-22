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
    public partial class FormOrderRepair : Form
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True";

        public FormOrderRepair()
        {
            InitializeComponent();
        }

        private void FormOrderRepair_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.мастерскаяDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Заказ_на_ремонт". При необходимости она может быть перемещена или удалена.
            this.заказ_на_ремонтTableAdapter.Fill(this.мастерскаяDataSet.Заказ_на_ремонт);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
        }

        private void FillDataGridView()
        {
            string query = "SELECT * FROM [Заказ_на_ремонт]";
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
            дата_концаDateTimePicker.Value = DateTime.Now;
            дата_началаDateTimePicker.Value = DateTime.Now;
            скидкаTextBox.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(дата_началаDateTimePicker.Text) || string.IsNullOrWhiteSpace(дата_концаDateTimePicker.Text)
                || string.IsNullOrWhiteSpace(comboBoxСотрудник.Text) || string.IsNullOrWhiteSpace(comboBoxЗаявка.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string datestart = дата_началаDateTimePicker.Value.ToString();
            string dateend = дата_концаDateTimePicker.Value.ToString();
            string employe = comboBoxСотрудник.SelectedValue.ToString();
            string disc = скидкаTextBox.Text;
            string zakaz = comboBoxЗаявка.SelectedValue.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [Заказ_на_ремонт] (ИдЗаявки, Дата_начала, Дата_конца, ИдСотрудника, Скидка) VALUES (@ИдЗаявки, @Дата_начала, @Дата_конца, @ИдСотрудника, @Скидка)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ИдЗаявки", datestart);
                    command.Parameters.AddWithValue("@Дата_начала", dateend);
                    command.Parameters.AddWithValue("@Дата_конца", employe);
                    command.Parameters.AddWithValue("@ИдСотрудника", disc);
                    command.Parameters.AddWithValue("@Скидка", zakaz);

                    command.ExecuteNonQuery();
                }

                ClearInputFields();

                FillDataGridView();

                MessageBox.Show("Данные добавлены успешно.");
            }
            FillDataGridView();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(дата_началаDateTimePicker.Text) || string.IsNullOrWhiteSpace(дата_концаDateTimePicker.Text)
                || string.IsNullOrWhiteSpace(comboBoxСотрудник.Text) || string.IsNullOrWhiteSpace(comboBoxЗаявка.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string datestart = дата_началаDateTimePicker.Value.ToString();
            string dateend = дата_концаDateTimePicker.Value.ToString();
            string employe = comboBoxСотрудник.SelectedValue.ToString();
            string disc = скидкаTextBox.Text;
            string zakaz = comboBoxЗаявка.SelectedValue.ToString();

            int selectedRowId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE [Заказ_на_ремонт] SET ИдЗаявки = @ИдЗаявки, Дата_начала = @Дата_начала, Дата_конца = @Дата_конца, ИдСотрудника = @ИдСотрудника, Скидка = @Скидка WHERE Номер_квитанции = @Номер_квитанции";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Номер_квитанции", selectedRowId);
                    command.Parameters.AddWithValue("@ИдЗаявки", datestart);
                    command.Parameters.AddWithValue("@Дата_начала", dateend);
                    command.Parameters.AddWithValue("@Дата_конца", employe);
                    command.Parameters.AddWithValue("@ИдСотрудника", disc);
                    command.Parameters.AddWithValue("@Скидка", zakaz);

                    command.ExecuteNonQuery();
                }

                ClearInputFields();

                FillDataGridView();

                MessageBox.Show("Данные изменены успешно.");
            }
            FillDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM [Заказ_на_ремонт] WHERE Номер_квитанции = @Номер_квитанции";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Номер_квитанции", selectedEmployeeId);
                    command.ExecuteNonQuery();
                }

                FillDataGridView();
            }

            MessageBox.Show("Данные удалены успешно.");
        }
    }
}
