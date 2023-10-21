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
    public partial class FormManag : Form
    {
        public FormManag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTypeTechnick form = new FormTypeTechnick();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTypeDevice form = new FormTypeDevice();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormModelDevice form = new FormModelDevice();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormOrderDiagnostics form = new FormOrderDiagnostics();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormOrderRepair form = new FormOrderRepair();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormOrderAcc form = new FormOrderAcc();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormTypeBreak form = new FormTypeBreak();
            form.Show();
        }
    }
}
