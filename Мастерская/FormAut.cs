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

namespace Мастерская
{
    public partial class FormAut : Form
    {

        public FormAut()
        {
            InitializeComponent();
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand checkAdminQuery = new SqlCommand("SELECT COUNT(*) FROM Сотрудник WHERE Роль = 'Администратор'", connection);
                int adminCount = (int)checkAdminQuery.ExecuteScalar();

                if (adminCount == 0)
                {
                    SqlCommand createAdminQuery = new SqlCommand("INSERT INTO Сотрудник (Фамилия, Имя, Логин, Пароль, Роль, Телефон, Адрес) VALUES (@Фамилия, @Имя, @Логин, @Пароль, 'Администратор', @Телефон, @Адрес)", connection);
                    createAdminQuery.Parameters.AddWithValue("@Фамилия", "Admin");
                    createAdminQuery.Parameters.AddWithValue("@Имя", "Admin");
                    createAdminQuery.Parameters.AddWithValue("@Логин", "admin");
                    createAdminQuery.Parameters.AddWithValue("@Пароль", "admin");
                    createAdminQuery.Parameters.AddWithValue("@Телефон", "admin");
                    createAdminQuery.Parameters.AddWithValue("@Адрес", "admin");
                    createAdminQuery.ExecuteNonQuery();
                }

                SqlCommand loginQuery = new SqlCommand("SELECT ИдСотрудника, Роль FROM Сотрудник WHERE Логин = @Логин AND Пароль = @Пароль", connection);
                loginQuery.Parameters.AddWithValue("@Логин", username);
                loginQuery.Parameters.AddWithValue("@Пароль", password);

                using (SqlDataReader reader = loginQuery.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader["Роль"].ToString();

                        switch (role)
                        {
                            case "Администратор":
                                FormAdmin adminForm = new FormAdmin();
                                adminForm.Show();
                                break;
                            case "Менеджер":
                                FormManag managerForm = new FormManag();
                                managerForm.Show();
                                break;
                            case "Мастер":
                                FormMaster masterForm = new FormMaster();
                                masterForm.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void FormAut_Load(object sender, EventArgs e)
        {

        }
    }
}
