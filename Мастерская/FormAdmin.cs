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
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdminData.surname = "";
            FormAdminData.name = "";
            FormAdminData.login = "";
            FormAdminData.password = "";
            FormAdminData.role = "";
            FormAdminData.numtel = "";
            FormAdminData.adress = "";
            FormAdminData f = new FormAdminData();
            f.ShowDialog();
            try
            {
                bool DeleteBool = FormAdminData.DeleteBool;
                if (DeleteBool == true)
                {

                    if (string.IsNullOrWhiteSpace(FormAdminData.surname) || string.IsNullOrWhiteSpace(FormAdminData.name)
                        || string.IsNullOrWhiteSpace(FormAdminData.login)
                        || string.IsNullOrWhiteSpace(FormAdminData.password) || string.IsNullOrWhiteSpace(FormAdminData.numtel) 
                        || string.IsNullOrWhiteSpace(FormAdminData.adress))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.");
                        return;
                    }

                    string lastName = FormAdminData.surname;
                    string firstName = FormAdminData.name;
                    string login = FormAdminData.login;
                    string password = FormAdminData.password;
                    string role = FormAdminData.role;
                    string tel = FormAdminData.numtel;
                    string adress = FormAdminData.adress;

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

                        MessageBox.Show("Данные добавлены успешно.");
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Строка не может быть добавление!!!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для редактирования.");
                return;
            }
            int selectedEmployeeId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormAdminData.surname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FormAdminData.name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FormAdminData.login = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                FormAdminData.password = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                FormAdminData.role = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                FormAdminData.numtel = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                FormAdminData.adress = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }

            FormAdminData f = new FormAdminData();
            f.ShowDialog();
            
            try
            {
                bool DeleteBool = FormAdminData.DeleteBool;
                if (DeleteBool == true)
                {

                    if (string.IsNullOrWhiteSpace(FormAdminData.surname) || string.IsNullOrWhiteSpace(FormAdminData.name)
                        || string.IsNullOrWhiteSpace(FormAdminData.login)
                        || string.IsNullOrWhiteSpace(FormAdminData.password) || string.IsNullOrWhiteSpace(FormAdminData.numtel)
                        || string.IsNullOrWhiteSpace(FormAdminData.adress))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.");
                        return;
                    }

                    string lastName = FormAdminData.surname;
                    string firstName = FormAdminData.name;
                    string login = FormAdminData.login;
                    string password = FormAdminData.password;
                    string role = FormAdminData.role;
                    string tel = FormAdminData.numtel;
                    string adress = FormAdminData.adress;

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
                    }


                MessageBox.Show("Данные изменены успешно.");
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Строка не может быть добавление!!!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormDelete f = new FormDelete();
            f.ShowDialog();
            try
            {
                bool DeleteBool = FormDelete.DeleteBool;
                if (DeleteBool == true)
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
                    }
                }
                MessageBox.Show("Данные удалены успешно.");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Строка не может быть удалена!!!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
