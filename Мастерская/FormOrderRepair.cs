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
    public partial class FormOrderRepair : Form
    {
        public FormOrderRepair()
        {
            InitializeComponent();
        }

        private void FormOrderRepair_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Заказ_на_ремонт". При необходимости она может быть перемещена или удалена.
            this.заказ_на_ремонтTableAdapter.Fill(this.мастерскаяDataSet.Заказ_на_ремонт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Заказ_на_ремонт". При необходимости она может быть перемещена или удалена.
            this.заказ_на_ремонтTableAdapter.Fill(this.мастерскаяDataSet.Заказ_на_ремонт);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
        }

        private void заказ_на_ремонтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказ_на_ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }

        private void заказ_на_ремонтBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.заказ_на_ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }
    }
}
