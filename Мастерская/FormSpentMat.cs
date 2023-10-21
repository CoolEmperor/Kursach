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
    public partial class FormSpentMat : Form
    {
        public FormSpentMat()
        {
            InitializeComponent();
        }

        private void FormSpentMat_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView2.RowHeadersDefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
        }
    }
}
