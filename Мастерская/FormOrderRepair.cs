using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using FastReport;
using FastReport.Data;
using FastReport.RichTextParser;
using Microsoft.Graph.Models;
using Report = FastReport.Report;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Заказ_на_диагностику". При необходимости она может быть перемещена или удалена.
            this.заказ_на_диагностикуTableAdapter.Fill(this.мастерскаяDataSet.Заказ_на_диагностику);
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
                    command.Parameters.AddWithValue("@ИдЗаявки", zakaz);
                    command.Parameters.AddWithValue("@Дата_начала", datestart);
                    command.Parameters.AddWithValue("@Дата_конца", dateend);
                    command.Parameters.AddWithValue("@ИдСотрудника", employe);
                    command.Parameters.AddWithValue("@Скидка", disc); 

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEmployeeId;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedEmployeeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                comboBoxЗаявка.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                дата_началаDateTimePicker.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                дата_концаDateTimePicker.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBoxСотрудник.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                скидкаTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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

                string query = $"SELECT * FROM [Заказ_на_ремонт] ORDER BY {sortField} {sortOrder}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            MessageBox.Show("Данные отсортированы успешно.");
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            int orderId = (int)dataGridView1.CurrentRow.Cells[1].Value;
            string query = "SELECT Заказ_на_ремонт.*, Заказ_на_диагностику.*, Вид_техники.*, Работа.* " +
                               "FROM Заказ_на_диагностику " +
                               "JOIN Вид_техники ON Заказ_на_диагностику.ИдВида = Вид_техники.ИдВида " +
                               "JOIN Заказ_на_ремонт ON Заказ_на_диагностику.ИдЗаявки = Заказ_на_ремонт.ИдЗаявки " +
                               "JOIN Работа ON Заказ_на_диагностику.ИдЗаявки = Работа.ИдЗаявки " +
                               "WHERE Заказ_на_диагностику.ИдЗаявки = OrderId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet data = new DataSet();
                        adapter.Fill(data);
                        Report report = new Report();
                        report.Load("C:\\Users\\dimas\\OneDrive\\Рабочий стол\\Отчет.frx");
                        report.RegisterData(data);
                        report.Prepare();
                        using (var export = new FastReport.Export.Pdf.PDFExport())
                        {
                            export.Export(report, "Квитанция.pdf");
                        }
                    }
                }
            }
        }
    }
}
