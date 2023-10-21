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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мастерская
{
    public partial class FormAdmin : Form
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True";
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.мастерскаяDataSet.Сотрудник);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
        }

        private void textBoxFindFam_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFindFam.Text;

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                сотрудникBindingSource.Filter = string.Format("Фамилия LIKE '{0}%'", filterText);
            }
            else
            {
                сотрудникBindingSource.RemoveFilter();
            }
        }

        private void textBoxFindLogin_TextChanged(object sender, EventArgs e)
        {
            string filterText1 = textBoxFindLogin.Text;

            if (!string.IsNullOrWhiteSpace(filterText1))
            {
                сотрудникBindingSource.Filter = string.Format("Логин LIKE '{0}%'", filterText1);
            }
            else
            {
                сотрудникBindingSource.RemoveFilter();
            }
        }

        private void FillDataGridView()
        {

            string query = "SELECT * FROM Сотрудник";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            MessageBox.Show("Данные обновлены успешно.");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(фамилияTextBox.Text) || string.IsNullOrWhiteSpace(имяTextBox.Text) || string.IsNullOrWhiteSpace(логинTextBox.Text)
                || string.IsNullOrWhiteSpace(парольTextBox.Text) || string.IsNullOrWhiteSpace(телефонTextBox.Text) || string.IsNullOrWhiteSpace(адресTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            string lastName = фамилияTextBox.Text;
            string firstName = имяTextBox.Text;
            string login = логинTextBox.Text;
            string password = парольTextBox.Text;
            string role = comboBoxRole.Text;
            string tel = телефонTextBox.Text;
            string adress = адресTextBox.Text;

            if (!IsValidName(lastName) || !IsValidName(firstName))
            {
                MessageBox.Show("Фамилия и имя должны начинаться с большой буквы и быть на русском языке.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("InsertEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Фамилия", lastName);
                    command.Parameters.AddWithValue("@Имя", firstName);
                    command.Parameters.AddWithValue("@Логин", login);
                    command.Parameters.AddWithValue("@Пароль", password);
                    command.Parameters.AddWithValue("@Роль", role);
                    command.Parameters.AddWithValue("@Телефон", tel);
                    command.Parameters.AddWithValue("@Адрес", adress);

                    command.ExecuteNonQuery();
                }

                FillDataGridView();
                ClearInputFields();

                MessageBox.Show("Данные добавлены успешно.");
            }
        }

        private void ClearInputFields()
        {
            фамилияTextBox.Clear();
            имяTextBox.Clear();
            логинTextBox.Clear();
            парольTextBox.Clear();
            телефонTextBox.Clear();
            адресTextBox.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для редактирования.");
                return;
            }

            if (string.IsNullOrWhiteSpace(фамилияTextBox.Text) || string.IsNullOrWhiteSpace(имяTextBox.Text) || string.IsNullOrWhiteSpace(логинTextBox.Text)
                || string.IsNullOrWhiteSpace(парольTextBox.Text) || string.IsNullOrWhiteSpace(телефонTextBox.Text) || string.IsNullOrWhiteSpace(адресTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            int selectedEmployeeId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            string lastName = фамилияTextBox.Text;
            string firstName = имяTextBox.Text;
            string login = логинTextBox.Text;
            string password = парольTextBox.Text;
            string role = comboBoxRole.Text;
            string tel = телефонTextBox.Text;
            string adress = адресTextBox.Text;

            if (!IsValidName(lastName) || !IsValidName(firstName))
            {
                MessageBox.Show("Фамилия и имя должны начинаться с большой буквы и быть на русском языке.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UpdateEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдСотрудника", selectedEmployeeId);
                    command.Parameters.AddWithValue("@Фамилия", lastName);
                    command.Parameters.AddWithValue("@Имя", firstName);
                    command.Parameters.AddWithValue("@Логин", login);
                    command.Parameters.AddWithValue("@Пароль", password);
                    command.Parameters.AddWithValue("@Роль", role);
                    command.Parameters.AddWithValue("@Телефон", tel);
                    command.Parameters.AddWithValue("@Адрес", adress);

                    command.ExecuteNonQuery();
                }

                FillDataGridView();
                ClearInputFields();
            }


            MessageBox.Show("Данные изменены успешно.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DeleteEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдСотрудника", selectedEmployeeId);
                    command.ExecuteNonQuery();
                }

                FillDataGridView();

                MessageBox.Show("Данные удалены успешно.");
            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sortField = comboBoxSort1.Text;
                string sortOrder = comboBoxSort2.Text;

                sortOrder = comboBoxSort2.Text;
                switch (sortOrder)
                {
                    case "Возрастание":
                        sortOrder = "ASC";
                        break;
                    case "Убывание":
                        sortOrder = "DESC";
                        break;
                }

                using (SqlCommand command = new SqlCommand("SortEmployees", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SortField", sortField);
                    command.Parameters.AddWithValue("@SortOrder", sortOrder);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }

                MessageBox.Show("Список отсортирован.");
            }
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^[А-Я][а-я]+$";
            return Regex.IsMatch(name, pattern);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEmployeeId;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedEmployeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                фамилияTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                имяTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                логинTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                парольTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBoxRole.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                телефонTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                адресTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
