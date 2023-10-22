using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мастерская
{
 
    public partial class FormAdminData : Form
    {
        public FormAdminData()
        {
            InitializeComponent();
        }

        private void FormAdminData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.мастерскаяDataSet.Сотрудник);

            FormAdmin f = new FormAdmin();

            фамилияTextBox.Text = surname;
            имяTextBox.Text = name;
            логинTextBox.Text = login;
            парольTextBox.Text = password;
            comboBox1.Text = role;
            телефонTextBox.Text = numtel;
            адресTextBox.Text = adress;

        }

        static public bool DeleteBool = false;
        static public string surname;
        static public string name;
        static public string login;
        static public string password;
        static public string role;
        static public string numtel;
        static public string adress;

       

        private void button1_Click(object sender, EventArgs e)
        {
            surname  = фамилияTextBox.Text;
            name = имяTextBox.Text;
            login = логинTextBox.Text;
            password = парольTextBox.Text;
            role = comboBox1.Text;
            numtel = телефонTextBox.Text;
            adress = адресTextBox.Text;
            DeleteBool = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteBool = false;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            фамилияTextBox.Clear();
            имяTextBox.Clear();
            логинTextBox.Clear();
            парольTextBox.Clear();
            телефонTextBox.Clear();
            адресTextBox.Clear();
        }
    }
}
